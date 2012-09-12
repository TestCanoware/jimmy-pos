Imports System.IO
Imports Utils
Imports Utils.General
Imports DataAccess

Public Class frmMain

#Region " Variables Declarations "

    Private Const CASH_IN As String = "CASH IN"
    Private Const CASH_OUT As String = "CASH OUT"

    Private FORMTITLE As String = My.Application.Info.Title
    Private isSearch As Boolean
    Private colTxn As New Collection
    Private totalTxn As Decimal
    Private change As Decimal
    Private objDocRow As DocRow

    Private isDelete As Boolean
    Private isESCkey As Boolean
    Private isNumPad As Boolean
    Private isCash As Boolean
    Private isReport As Boolean
    Private isVoid As Boolean
    Private isHold As Boolean

    Private strReport() As String = {"F1 Back", "F2 Daily Sales Report", "F3 Hourly Sales Report", "F4 Detailed Void Report", "F5 Void Report", "F6 Official Receipt Listing"}
    Private strMainName() As String = {"F1 Find Item", "F2 Delete All Items", "F3 Cash In", "F4 Cash Out", "F5 Void", "F6 Others Payment", "F7 Reports", "F8 End Day Closing", "F9 Logout", "F10 Config", "F11 Hold"}
    Private txtBox As TextBox
    Private invoiceId As Long

    Private resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))


    Private Structure objTransaction
        Dim itemCode As String
        Dim desc As String
        Dim qty As String
        Dim price As String
        Dim discount As String
        Dim amount As String
    End Structure

    Private objDA As New DAMain

#End Region

#Region " Initialisation "

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = isESCkey
        isESCkey = False
    End Sub

    Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Alt And e.KeyCode = Keys.F4 Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmMain_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.C
                MsgBox("testing")
        End Select

    End Sub

    Private Sub frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'AddHandler Me.KeyDown, AddressOf Me.frmMain_KeyDown
        Initialise()
    End Sub

    Private Sub Initialise()
        Me.Text = FORMTITLE
        Messenger.Caption = FORMTITLE
        lblUser.Text = gUserName
        lblDate.Text = Now.ToString("dd-MM-yyyy")
        lblWelcome.Text = gConfigObj.MsgWelcome

        CursorButtons(Me, Cursors.Hand)

        SetupDefaultControls()
        Reset()

        MenuItem(False)

        lblCounter.Text = Format(objDA.getConuter, "000000") & "/" & gCurrentTotalBill

        If gConfigObj.Logo <> "" Then
            Try
                LoadPicture(Path.Combine(Application.StartupPath, gConfigObj.Logo), picLogo)
            Catch ex As Exception

            End Try
        End If

        Load_cboSalesman()
    End Sub

#End Region

#Region " Load Controls - ComboBox, ListView, ListBox, etc "

    Private Sub Load_cboSalesman()
        'Load branches
        Dim ds As DataSet = Nothing
        objDA.getUserObject(ds)

        With cboSalesman
            .DropDownStyle = ComboBoxStyle.DropDownList
            .DataSource = Nothing

            .DataSource = ds.Tables(0)
            .DisplayMember = "username"
            .ValueMember = "userid"

            If .Items.Count > 0 Then _
                .SelectedValue = 0
        End With

    End Sub

#End Region

#Region " Controls Populating, Updating, etc "

    Private Sub SetupDefaultControls()
        MenuStrip1.Visible = False

        pCash.Location = pHistory.Location
        pCashInOut.Location = pHistory.Location
        pCashBill.Location = pHistory.Location

        pCash.Anchor = pHistory.Anchor
        pCashInOut.Anchor = pHistory.Anchor
        pCashBill.Anchor = pHistory.Anchor

        pCash.Size = pHistory.Size
        pCashInOut.Size = pHistory.Size
        pCashBill.Size = pHistory.Size

        'Timer2.Enabled = False
        pHistory.Visible = False

        lblBottom.Visible = False
    End Sub

    Private Sub ClearFileds()
        txtItemCode.Text = ""
        txtQty.Text = "1"
        txtPay.Text = ""
        txtCashInOut.Text = ""
        txtCashBillId.Text = ""

        pCash.Visible = False
        pCashInOut.Visible = False
        pCashBill.Visible = False
        'pHistory.Visible = False

        txtItemCode.Focus()
        txtItemCode.SelectAll()

        'isDelete = False
        'isESCkey = False
        'isNumPad = False
        isCash = False
        'isVoid = False
    End Sub

    Private Sub Reset()
        GlacialList1.Items.Clear()
        GlacialList1.Refresh()

        txtTotalQty.Text = "0"
        txtTotalTxn.Text = gCurrency & " 0.00"
        totalTxn = 0
        ClearFileds()

        isDelete = False
        isESCkey = False
        isNumPad = False
        isCash = False
        isVoid = False

        pCash.Visible = False
        pCashInOut.Visible = False
        pHistory.Visible = False
        pCashBill.Visible = False

        'EnabledItemCode()
    End Sub

    Private Sub EnabledItemCode()
        'gLockFields(txtItemCode, isCash)
        'gLockFields(txtQty, isCash)
    End Sub

    Private Sub LoadControl(ByVal panel As Panel)
        pCash.Visible = False
        pCashInOut.Visible = False
        pHistory.Visible = False
        pCashBill.Visible = False
        isCash = False

        If (panel IsNot Nothing) Then
            panel.Visible = True
            isCash = True
        End If

        If panel.Name = pHistory.Name Then
            isCash = False
        End If

        EnabledItemCode()
    End Sub

#End Region

#Region " Database Updating - Presentation Layer "

    Private Function SearhItemCode() As Boolean
        If txtItemCode.TextLength = 0 Then
            Return False
        End If


        Dim ds As DataSet = Nothing
        objDA.getItemPosObject(txtItemCode.Text.Trim, gLocationID, ds)

        If ds Is Nothing Or ds.Tables.Count = 0 Or ds.Tables(0).Rows.Count = 0 Then
            'Messenger.ShowWarning("Item Code not found!")
            Dim frm As New frmFindItem
            frm.keywoards = txtItemCode.Text.Trim
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                txtItemCode.Text = gItemCode
                SearhItemCode()
                Return False
            Else
                txtItemCode.SelectAll()
                Return False
            End If
        End If


        objDocRow = New DocRow
        With objDocRow
            .itemId = ds.Tables(0).Rows(0)("pkid")
            .itemCode = ds.Tables(0).Rows(0)("item_code")
            .itemName = ds.Tables(0).Rows(0)("name")
            .eanCode = ds.Tables(0).Rows(0)("ean_code")
            .price = ds.Tables(0).Rows(0)("price_list")
            .qty = txtQty.Text
            .balQty = ds.Tables(0).Rows(0)("bal")
            .unitCostMA = ds.Tables(0).Rows(0)("unit_cost_ma")
            .stockId = ds.Tables(0).Rows(0)("stockId")
            .minPrice = ds.Tables(0).Rows(0)("price_min")
        End With

        isSearch = True
        txtItemCode.Focus()
        Return True

    End Function

    Private Sub AddDocRow()
        If Not isSearch Then
            If Not SearhItemCode() Then
                txtItemCode.Focus()
                Exit Sub
            End If
        End If

        'Dim item As New ListViewItem
        Dim item As New GlacialComponents.Controls.GLItem
        Dim subitem1 As New GlacialComponents.Controls.GLSubItem
        Dim subitem2 As New GlacialComponents.Controls.GLSubItem
        Dim subitem3 As New GlacialComponents.Controls.GLSubItem
        Dim subitem4 As New GlacialComponents.Controls.GLSubItem

        'item.Text = ListView1.Items.Count + 1
        item.Text = GlacialList1.Count + 1
        subitem1.Text = txtItemCode.Text & vbCrLf & objDocRow.itemName
        subitem2.Text = txtQty.Text
        subitem3.Text = FormatCurrency(objDocRow.price)
        subitem4.Text = FormatCurrency(objDocRow.getAmount)

        'item.SubItems.Add(txtItemCode.Text & vbCrLf & objDocRow.itemName)
        'item.SubItems.Add(objDocRow.itemName)
        'item.SubItems.Add(txtQty.Text)
        'item.SubItems.Add(FormatCurrency(objDocRow.price))

        'item.SubItems.Add(FormatCurrency(objDocRow.getAmount))
        item.Tag = objDocRow
        item.SubItems.AddRange(New GlacialComponents.Controls.GLSubItem() {subitem1, subitem2, subitem3, subitem4})

        'ListView1.Items.Add(item)
        GlacialList1.Items.Add(item)
        GlacialList1.Refresh()

        Dim index As Integer
        If GlacialList1.Count > 0 Then
            index = GlacialList1.Count - 1
        Else
            index = 0
        End If

        GlacialList1.Items(index).Selected = True

        pHistory.Visible = True
        lblItemCode.Text = objDocRow.itemCode
        lblDesc.Text = objDocRow.itemName
        lblQty.Text = objDocRow.qty
        lblPrice.Text = FormatCurrency(objDocRow.price)
        lblBalance.Text = objDocRow.balQty

        ClearFileds()
        txtItemCode.Focus()
        isSearch = False
        CalculateTotalQtyAndAmount()
    End Sub

    Private Function SaveTxn() As Boolean

        Dim invoiceId As Long
        Dim invoiceItemId As Long
        Dim receiptId As Long
        Dim salesId As Integer

        Try

            salesId = cboSalesman.SelectedValue
            invoiceId = objDA.insertInvoice(totalTxn, salesId)

            'For Each item As ListViewItem In ListView1.Items
            For Each item As GlacialComponents.Controls.GLItem In GlacialList1.Items
                Dim docrow As DocRow = DirectCast(item.Tag, DocRow)

                invoiceItemId = objDA.insertInvoiceItem(invoiceId, docrow)

                ' Update stock balance in inv_stock
                objDA.updateBalanceInventory(docrow.stockId, docrow.qty)

            Next

            ' Insert Cash Receipt at acc_receipt_index
            receiptId = objDA.insertReceipt(totalTxn)

            'Update receipt id at cust_invoice_index
            objDA.updateInvoice(invoiceId, "receipt_id", receiptId)
            objDA.insertTC(invoiceId, salesId)


            'gPrintCashBill(invoiceId, Convert.ToDecimal(txtPay.Text), change)
            Return True

        Catch ex As Exception
            Messenger.ShowError(ex.Message)
            Return False
        End Try

    End Function

    Private Function SaveTxnCC(ByVal totalTxn As Decimal, ByVal cardNumber As String, ByVal cardName As String, ByVal cardValid As DateTime, ByVal cardApproval As String) As Boolean

        Dim invoiceId As Long
        Dim invoiceItemId As Long
        Dim receiptId As Long
        Dim salesId As Integer

        Try
            salesId = cboSalesman.SelectedValue

            invoiceId = objDA.insertInvoice(totalTxn, salesId)

            'For Each item As ListViewItem In ListView1.Items
            For Each item As GlacialComponents.Controls.GLItem In GlacialList1.Items
                Dim docrow As DocRow = DirectCast(item.Tag, DocRow)

                invoiceItemId = objDA.insertInvoiceItem(invoiceId, docrow)

                ' Update stock balance in inv_stock
                'objDA.updateBalanceInventory(docrow.stockId, docrow.qty)

            Next

            ' Insert Cash Receipt at acc_receipt_index
            receiptId = objDA.insertReceiptCC(totalTxn, cardNumber, cardName, cardValid, cardApproval)

            'Update receipt id at cust_invoice_index
            objDA.updateInvoice(invoiceId, "receipt_id", receiptId)
            objDA.insertTC(invoiceId, salesId)


            'gPrintCashBill(invoiceId, totalTxn, 0, True)

            Return True

        Catch ex As Exception
            Messenger.ShowError(ex.Message)
            Return False
        End Try

    End Function

    Public Function ExistInvoice() As Boolean
        Dim ds As DataSet = Nothing
        Dim pkid As Long = txtCashBillId.Text

        objDA.getInvoiceObject(pkid, DAMain.STATE_ACTIVE, ds)
        If ds Is Nothing Then
            Return False
        End If

        If ds.Tables(0).Rows.Count <= 0 Then
            Messenger.ShowWarning("The Cash Bill# '" & pkid & "' not found!")
            txtCashBillId.Focus()
            Return False
        End If

        Return True

    End Function
#End Region

#Region " Utility Procedures "

    Private Function CalculateTotalQtyAndAmount() As Decimal

        Dim qty As Integer = 0
        Dim amt As Decimal = 0

        totalTxn = 0
        'For Each item As ListViewItem In ListView1.Items
        For Each item As GlacialComponents.Controls.GLItem In GlacialList1.Items
            qty += Convert.ToInt16(item.SubItems(2).Text)
            totalTxn += Convert.ToDecimal(item.SubItems(4).Text)
        Next

        txtTotalQty.Text = qty
        txtTotalTxn.Text = gCurrency & " " & FormatCurrency(totalTxn)

        If Timer2.Enabled Then
            txtTotalTxn.ForeColor = txtTotalQty.ForeColor
            Timer2.Enabled = False
        End If

    End Function

    Private Function hasTxn() As Boolean
        'Return ListView1.Items.Count > 0
        Return GlacialList1.Count > 0
    End Function

    Private Sub MenuItem(ByVal isReport As Boolean)

        'Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        If isReport Then
            For i As Integer = 0 To ToolStrip1.Items.Count - 1
                If i > strReport.GetLength(0) - 1 Then
                    ToolStrip1.Items(i).Visible = False
                Else
                    ToolStrip1.Items(i).Text = strReport(i)
                    ToolStrip1.Items(i).Image = CType(resources.GetObject(strReport(i)), System.Drawing.Image)
                End If

            Next
        Else
            For i As Integer = 0 To ToolStrip1.Items.Count - 1
                If i > strReport.GetLength(0) - 1 Then
                    ToolStrip1.Items(i).Visible = True
                End If
                ToolStrip1.Items(i).Text = strMainName(i)
                ToolStrip1.Items(i).Image = CType(resources.GetObject(strMainName(i)), System.Drawing.Image)
            Next
        End If
        Me.isReport = isReport
    End Sub

    Private Sub ShowDailySalesReport()
        Dim frm As New frmDailySalesReport
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim posId As Integer = IIf(frm.txtCounter.Text = "", 0, frm.txtCounter.Text)
            gShowReport(New rptDailySalesReport(frm.cboUser.SelectedValue, frm.dtpDateFrom.Value, frm.dtpDateTo.Value, posId, "DAILY SALES REPORT"))
        End If
    End Sub

    Private Sub ShowHoulrySalesReport()
        Dim frm As New frmHourlySalesReport
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim posId As Integer = IIf(frm.txtCounter.Text = "", 0, frm.txtCounter.Text)
            gShowReport(New rptHourlySalesReport(frm.cboUser.SelectedValue, frm.dtpDateFrom.Value, posId))
        End If
    End Sub

    Private Sub ShowVoidReport()
        Dim frm As New frmVoidReport
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim posId As Integer = IIf(frm.txtCounter.Text = "", 0, frm.txtCounter.Text)
            gShowReport(New rptVoidDetailReport(frm.cboUser.SelectedValue, frm.dtpDateFrom.Value, frm.dtpDateTo.Value, posId))
        End If
    End Sub


    Private Sub ShowVoidDetailReport()
        Dim frm As New frmVoidDetailReport
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim posId As Integer = IIf(frm.txtCounter.Text = "", 0, frm.txtCounter.Text)
            gShowReport(New rptVoidReport(frm.cboUser.SelectedValue, frm.dtpDateFrom.Value, frm.dtpDateTo.Value, posId))
        End If
    End Sub

    Private Sub ShowReceiptListing()
        Dim frm As New frmReceiptListing
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim posId As Integer = IIf(frm.txtCounter.Text = "", 0, frm.txtCounter.Text)
            gShowReport(New rptReceiptListing(frm.cboUser.SelectedValue, frm.dtpDateFrom.Value, frm.dtpDateTo.Value, posId))
        End If
    End Sub
#End Region

#Region " Event Handler/Response "

    Private Sub tbFindItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbFindItem.Click
        If isReport Then
            MenuItem(False)
            Exit Sub
        End If

        If isCash Then
            Exit Sub
        End If

        Dim frm As New frmFindItem
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtItemCode.Text = gItemCode
            SearhItemCode()
        End If
        txtItemCode.Focus()
        txtItemCode.SelectAll()
    End Sub

    Private Sub tbCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbCancel.Click
        If isReport Then
            ShowDailySalesReport()
            Exit Sub
        End If

        If isCash Then
            Exit Sub
        End If

        If Not hasTxn() Then
            Exit Sub
        End If

        If Not gLoadPermission(Permission.CancelSale) Then
            Exit Sub
        End If

        If gConfigObj.MsgVoidConfirmEnabled Then
            If Messenger.ShowQuestion(gConfigObj.MsgVoidConfirm, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Reset()
                If gConfigObj.MsgTxnSucceedEnabled Then Messenger.ShowInformation(gConfigObj.MsgVoidSucceed)
                txtItemCode.Focus()
            End If
        Else
            Reset()
            If gConfigObj.MsgTxnSucceedEnabled Then Messenger.ShowInformation(gConfigObj.MsgVoidSucceed)
            txtItemCode.Focus()
        End If

    End Sub

    Private Sub tbCashIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbCashIn.Click
        If hasTxn() Then
            Exit Sub
        End If

        If isReport Then
            ShowHoulrySalesReport()
            Exit Sub
        End If

        If Not gLoadPermission(Permission.CashIn) Then
            Exit Sub
        End If

        LoadControl(pCashInOut)
        lblCashInOut.Text = CASH_IN
        txtCashInOut.Focus()
        txtCashInOut.SelectAll()
        txtCashInOut.Clear()
        txtRemark.Clear()
    End Sub

    Private Sub tbCashOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbCashOut.Click
        If hasTxn() Then
            Exit Sub
        End If

        If isReport Then
            ShowVoidDetailReport()
            Exit Sub
        End If

        If Not gLoadPermission(Permission.CashOut) Then
            Exit Sub
        End If

        LoadControl(pCashInOut)
        lblCashInOut.Text = CASH_OUT
        txtCashInOut.Focus()
        txtCashInOut.SelectAll()
        txtCashInOut.Clear()
        txtRemark.Clear()
    End Sub

    Private Sub tbLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbLogout.Click
        If hasTxn() Then
            Exit Sub
        End If

        If Messenger.ShowQuestion("Are you sure to Log out the system?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        'Checking the current time
        Dim currentTime As DateTime = Now
        Dim recordTime As DateTime

        recordTime = objDA.getLastTimeLogin(gBranchID, gConfigObj.PosId)
        If recordTime.ToString("yyyy-MM-dd") <> "0001-01-01" Then
            If Now < recordTime Then
                Messenger.ShowInformation("Please check the current date and time.")
                Exit Sub
            End If
        End If

        Dim timeStart As DateTime
        Dim ds As DataSet = Nothing
        objDA.getCustPosLogin(gBranchID, gConfigObj.PosId, gUserID, ds)
        If ds Is Nothing Then Exit Sub
        timeStart = ds.Tables(0).Rows(0)("time_start")
        'Me.Hide()

        Dim rpt As New rptDailySalesReport(gUserID, timeStart, Now, gConfigObj.PosId, "DAILY SALES REPORT")
        gShowReport(rpt)

        objDA.updateCustPosLogin(gBranchID, gConfigObj.PosId, gUserID)
        'objDA.insertCustPosLogin(gBranchID, gPosID, gUserID, objDA.STATUS_END)
        'Me.Hide()
        Me.DialogResult = Windows.Forms.DialogResult.OK
        'Dim frm As New frmLogin()

        'If frmLogin.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    Me.Show()
        '    Initialise()
        'Else
        '    DataAccess.Commands.CloseConn()
        '    Me.Close()
        '    Application.Exit()
        'End If

    End Sub

    Private Sub tbCC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbPopDrawer.Click

        If isReport Then
            ShowReceiptListing()
            Exit Sub
        End If

        'Dim frm As New frmCreditCard
        'frm.total = Convert.ToDecimal(totalTxn)
        'If Not frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    Exit Sub
        'End If

        'Dim cardNumber As String = frm.txtCCNo.Text.Trim
        'Dim cardName As String = frm.txtCCName.Text.Trim
        'Dim cardValid As New Date(frm.cboYear.Text, frm.cboMonth.SelectedIndex + 1, 1)
        'Dim cardApproval As String = frm.txtCCAppCode.Text.Trim

        'If Not SaveTxnCC(totalTxn, cardNumber, cardName, cardValid, cardApproval) Then
        '    Exit Sub
        'End If

        'Reset()
        'txtTotalTxn.ForeColor = Color.Red
        'txtTotalTxn.Text = "CHANGE " & gCurrency & " 0.00" '& FormatCurrency(Decimal.Negate(change))

        'Timer2.Enabled = True

        'Try
        '    objDA.addQtyBill(gBranchID, gConfigObj.PosId, 1)
        '    gCurrentTotalBill += 1
        '    objDA.updateConuter()
        '    lblCounter.Text = Format(objDA.getConuter, "000000") & "/" & gCurrentTotalBill
        '    If gConfigObj.MsgTxnSucceedEnabled Then Messenger.ShowInformation(gConfigObj.MsgTxnSucceed)

        'Catch ex As Exception
        '    Messenger.ShowError(ex)
        'End Try
    End Sub


    Private Sub frmMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        'Dim total As Integer = 0
        ''For Each col As ColumnHeader In ListView1.Columns
        'For Each col As GlacialComponents.Controls.GLColumn In GlacialList1.Columns
        '    'If col.Index <> 2 Then
        '    '    total += col.Width
        '    'End If
        '    If col.Name <> "Column2" Then
        '        total += col.Width
        '    End If
        'Next
        ''ListView1.Columns(2).Width = ListView1.Size.Width - total '- 17
        'GlacialList1.Columns(2).Width = GlacialList1.Size.Width - total
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = Now.ToString("h:mm:ss tt")

        If gConnectWS Then
            Me.picConnect.Image = CType(resources.GetObject("ball.green"), System.Drawing.Image)
            Me.ToolTip1.SetToolTip(Me.picConnect, "Connected.")
        Else
            Me.picConnect.Image = CType(resources.GetObject("ball.red"), System.Drawing.Image)
            Me.ToolTip1.SetToolTip(Me.picConnect, "Disconnected.")
        End If

    End Sub

    Private Sub txtQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyDown
        Select Case e.KeyCode
            Case Keys.Up, Keys.Down, Keys.Return
                txtItemCode.SelectAll()
                txtItemCode.Focus()
        End Select
    End Sub

    Private Sub txtQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        e.Handled = Utils.General.KeyPress("0123456789", True, e)
    End Sub

    Private Sub txtPay_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPay.KeyDown
        If e.KeyCode = Keys.Return Then
            btnCashOk.PerformClick()
        End If
    End Sub

    Private Sub txtPrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCashInOut.KeyPress, txtPay.KeyPress
        If InStr(DirectCast(sender, TextBox).Text, ".") > 1 Then
            e.Handled = Utils.General.KeyPress("0123456789", True, e)
        Else
            e.Handled = Utils.General.KeyPress("0123456789.", True, e)
        End If
    End Sub

    Private Sub txtItemCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCashBillId.GotFocus, txtCashInOut.GotFocus, txtPay.GotFocus, txtQty.GotFocus, txtRemark.GotFocus
        Dim txt As TextBox = DirectCast(sender, TextBox)
        txt.SelectAll()
    End Sub

    Private Sub txtItemCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtItemCode.KeyPress
        e.Handled = Utils.General.KeyPress("+*", False, e)
    End Sub

    Private Sub txtItemCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItemCode.KeyUp
        Select Case e.KeyCode
            Case Keys.Multiply
                btnQty.PerformClick()
            Case Keys.Add
                btnCash.PerformClick()
        End Select
    End Sub

    Private Sub txtItemCode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtItemCode.TextChanged
        Dim sel_start As Integer
        Dim sel_length As Integer

        sel_start = txtItemCode.SelectionStart
        sel_length = txtItemCode.SelectionLength
        txtItemCode.Text = txtItemCode.Text.ToUpper
        txtItemCode.SelectionStart = sel_start
        txtItemCode.SelectionLength = sel_length
    End Sub

    Private Sub txtItemCode_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtItemCode.Enter, txtQty.Enter, txtCashInOut.Enter, txtPay.Enter, txtRemark.Enter
        Dim txt As TextBox = DirectCast(sender, TextBox)
        txtBox = txt
        isDelete = False
    End Sub

    Private Sub txtItemCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItemCode.KeyDown
        Select Case e.KeyCode
            Case Keys.Return
                If txtItemCode.TextLength > 0 Then
                    If Not SearhItemCode() Then
                        txtItemCode.Focus()
                    Else
                        AddDocRow()
                    End If
                End If

            Case Keys.Up, Keys.Down
                txtQty.SelectAll()
                txtQty.Focus()
        End Select
    End Sub

    Private Sub txtItemCode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtItemCode.Leave

    End Sub

    Private Sub ListView1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles GlacialList1.Enter
        'If ListView1.Items.Count > 0 Then
        '    ListView1.Items(0).Selected = True
        '    isDelete = True
        'End If
        If GlacialList1.Count > 0 Then
            GlacialList1.Items(0).Selected = True
            isDelete = True
        End If
    End Sub

    Private Sub ListView1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles GlacialList1.Leave
        'isDelete = False
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GlacialList1.SelectedIndexChanged
        'If Not ListView1.SelectedItems Is Nothing AndAlso ListView1.SelectedItems.Count > 0 Then
        'Dim item As ListViewItem
        'item = ListView1.SelectedItems.Item(0)

        'txtItemCode.Text = item.SubItems(1).Text
        'txtQty.Text = item.SubItems(3).Text
        'txtPrice.Text = item.SubItems(4).Text
        'If item.Tag = PERCENTAGE Then
        '    txtDisc1.Text = item.SubItems(5).Text
        'Else
        '    txtDisc2.Text = item.SubItems(5).Text
        'End If
        'txtAmount.Text = item.SubItems(6).Text
        'End If
    End Sub


    Private Sub FindItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindItemToolStripMenuItem.Click
        tbFindItem.PerformClick()
    End Sub

    Private Sub CancelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelToolStripMenuItem.Click
        tbCancel.PerformClick()
    End Sub

    Private Sub CashInToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashInToolStripMenuItem.Click
        tbCashIn.PerformClick()
    End Sub

    Private Sub CashOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashOutToolStripMenuItem.Click
        tbCashOut.PerformClick()
    End Sub

    Private Sub ReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportsToolStripMenuItem.Click
        tbReports.PerformClick()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        tbLogout.PerformClick()
    End Sub

    Private Sub ItemCodeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemCodeToolStripMenuItem.Click
        txtItemCode.Focus()
    End Sub

    Private Sub QuantityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuantityToolStripMenuItem.Click
        txtQty.Focus()
    End Sub

    Private Sub PriceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PriceToolStripMenuItem.Click
        'txtPrice.Focus()
    End Sub

    Private Sub tbReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbReports.Click
        If hasTxn() Then
            Exit Sub
        End If

        If Not gLoadPermission(Permission.Report) Then
            Exit Sub
        End If

        MenuItem(True)
    End Sub

    Private Sub btnCash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCash.Click
        If Not hasTxn() Then
            Exit Sub
        End If

        LoadControl(pCash)

        txtPay.Focus()
        txtPay.SelectAll()
        lblTotal.Text = gCurrency & " " & FormatCurrency(totalTxn)
        lblChange.Text = gCurrency & " 0.00" '& FormatCurrency(totalTxn)
    End Sub

    Private Sub btnCashOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCashOk.Click
        If change > 0 Then
            If gConfigObj.MsgPaymentExceedEnabled Then Messenger.ShowWarning(gConfigObj.MsgPaymentExceed)
        Else
            If gConfigObj.MsgTxnConfirmEnabled Then
                If Messenger.ShowQuestion(gConfigObj.MsgTxnConfirm, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
            End If

            If Not SaveTxn() Then
                Exit Sub
            End If

            Reset()
            txtTotalTxn.ForeColor = Color.Red
            txtTotalTxn.Text = "CHANGE " & gCurrency & " " & FormatCurrency(Decimal.Negate(change))

            Timer2.Enabled = True

            Try
                objDA.addQtyBill(gBranchID, gConfigObj.PosId, 1)
                gCurrentTotalBill += 1
                objDA.updateConuter()
                lblCounter.Text = Format(objDA.getConuter, "000000") & "/" & gCurrentTotalBill
                If gConfigObj.MsgTxnSucceedEnabled Then Messenger.ShowInformation(gConfigObj.MsgTxnSucceed)

            Catch ex As Exception
                Messenger.ShowError(ex)
            End Try

        End If
    End Sub

    Private Sub btnCashCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCashCancel.Click
        'LoadControl(Nothing)
        ClearFileds()
    End Sub

    Private Sub btnCashInOutOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCashInOutOk.Click
        'LoadControl(Nothing)
        Dim status As String = DAMain.STATUS_CASH_OUT
        Dim pkid As Integer

        If lblCashInOut.Text = CASH_IN Then
            status = DAMain.STATUS_CASH_IN
        End If

        Try
            pkid = objDA.insertCashInOut(txtCashInOut.Text.Trim, txtRemark.Text, status)

            gShowReport(New rptCashInOut(pkid))
        Catch ex As Exception
            Messenger.ShowError(ex.Message)
        End Try

        ClearFileds()
    End Sub

    Private Sub btnCashInOutCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCashInOutCancel.Click
        'LoadControl(Nothing)
        ClearFileds()
    End Sub

    Private Sub txtPay_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPay.TextChanged
        Try
            Dim value As Decimal = 0

            change = totalTxn - Convert.ToDecimal(txtPay.Text)
            If change < 0 Then
                value = Decimal.Negate(change)
                lblChange.Text = gCurrency & " " & FormatCurrency(value)
                'Else
                'value = change
            End If

        Catch ex As Exception
            lblChange.Text = gCurrency & " 0.00" '& FormatCurrency(totalTxn)
        End Try

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If isCash Then
            Exit Sub
        End If

        If Not hasTxn() Then
            Exit Sub
        End If

        If Not isDelete Then
            'ListView1.Items(0).Selected = True
            'ListView1.Focus()
            GlacialList1.Items(0).Selected = True
            GlacialList1.Focus()
            isDelete = True
        Else
            'If ListView1.SelectedItems.Count > 0 Then
            If GlacialList1.SelectedItems.Count > 0 Then
                If Not gLoadPermission(Permission.DeleteItem) Then
                    Exit Sub
                End If
                If gConfigObj.MsgDeleteConfirmEnabled Then
                    If Messenger.ShowQuestion(gConfigObj.MsgDeleteConfirm, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                        isDelete = False
                        txtItemCode.Focus()
                        Exit Sub
                    End If
                End If

                Dim item As GlacialComponents.Controls.GLItem = DirectCast(GlacialList1.SelectedItems(0), GlacialComponents.Controls.GLItem)
                Dim qty As Integer = item.SubItems(2).Text 'ListView1.SelectedItems(0).SubItems(3).Text
                Dim objDocRow As DocRow = DirectCast(item.Tag, DocRow)
                If (qty > 1) Then
                    'Dim frm As New frmSelectQty
                    'frm.maxQty = qty
                    'If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    '    qty = qty - frm.NumericUpDown1.Value
                    '    If qty = 0 Then
                    '        Dim index As Integer = GlacialList1.SelectedItems(0).Index
                    '        GlacialList1.Items.Remove(item)

                    '        For i As Integer = index To GlacialList1.Count - 1
                    '            GlacialList1.Items(i).Text = i + 1
                    '        Next
                    '    Else
                    '        item.SubItems(2).Text = qty
                    '        item.SubItems(4).Text = FormatCurrency(qty * Convert.ToDecimal(GlacialList1.SelectedItems(0).SubItems(3).Text))
                    '        objDocRow.qty = qty
                    '    End If
                    'End If
                Else
                    'Dim index As Integer = GlacialList1.SelectedItems(0).index

                    Dim index As Integer = item.Text
                    GlacialList1.Items.Remove(item)

                    For i As Integer = index - 1 To GlacialList1.Count - 1
                        GlacialList1.Items(i).Text = i + 1
                    Next
                End If
                pHistory.Visible = False
                If gConfigObj.MsgDeleteSucceedEnabled Then Messenger.ShowInformation(gConfigObj.MsgDeleteSucceed)
            End If
            GlacialList1.Refresh()
            isDelete = False
            CalculateTotalQtyAndAmount()
            txtItemCode.Focus()
        End If

    End Sub

    Private Sub btnQty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQty.Click
        txtQty.SelectAll()
        txtQty.Focus()
    End Sub

    Private Sub tbQuantity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        btnQty.PerformClick()
    End Sub

    Private Sub QtyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        btnQty.PerformClick()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearFileds()
    End Sub

    Private Sub DeleteItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteItemToolStripMenuItem.Click
        btnDelete.PerformClick()
    End Sub

    Private Sub VoidToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VoidToolStripMenuItem.Click
        tbVoid.PerformClick()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        'TextBox1.Text = "Hi there!!"
        Dim c As Color = txtTotalQty.ForeColor
        Dim c1 As Color = txtTotalQty.BackColor

        If Timer2.Tag = True Then
            txtTotalTxn.ForeColor = Color.Red
            txtTotalTxn.BackColor = c1
            Timer2.Tag = False
        Else
            txtTotalTxn.ForeColor = c1
            txtTotalTxn.BackColor = c1
            Timer2.Tag = True
        End If

    End Sub

    Private Sub txtQty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQty.LostFocus
        If txtQty.Text.Trim.Length = 0 Then
            txtQty.Text = 1
        End If
    End Sub

    Private Sub btnCancel_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If isVoid Then
            Reset()
        Else
            ClearFileds()
        End If

        isESCkey = True
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btnDot.Click
        Dim btn As Button = CType(sender, Button)
        If txtBox.Text.Length < txtBox.MaxLength Then
            txtBox.Text &= btn.Text
        End If

        txtBox.Focus()
    End Sub

    Private Sub PopDrawerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PopDrawerToolStripMenuItem.Click
        tbPopDrawer.PerformClick()
    End Sub

    Private Sub tbVoid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbVoid.Click
        If hasTxn() Then
            Exit Sub
        End If

        If isReport Then
            ShowVoidReport()
            Exit Sub
        End If

        If Not gLoadPermission(Permission.VoidReceipt) Then
            Exit Sub
        End If

        LoadControl(pCashBill)
        txtCashBillId.Focus()
        isVoid = True
    End Sub

    Private Sub btnCBOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCBOk.Click
        If gConfigObj.MsgVoidConfirmEnabled Then
            If Messenger.ShowQuestion(gConfigObj.MsgVoidConfirm, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        End If

        Try
            If Not ExistInvoice() Then
                Exit Sub
            End If

            If objDA.CancelInvoice(txtCashBillId.Text) Then
                Dim frm As New frmRemark
                If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    objDA.updateInvoice(txtCashBillId.Text, "remarks", frm.txtRemark.Text.Trim())
                End If
                If gConfigObj.MsgVoidSucceedEnabled Then Messenger.ShowInformation(gConfigObj.MsgVoidSucceed)
                Reset()
            End If
        Catch ex As Exception
            Messenger.ShowError(ex)
        End Try

    End Sub

    Private Sub btnCBCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCBCancel.Click
        Reset()
    End Sub

    Private Sub txtCashBillId_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCashBillId.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                btnCBView.Focus()
            Case Keys.Down, Keys.Return
                btnCBOk.Focus()
        End Select
    End Sub

    Private Sub txtCashBillId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCashBillId.KeyPress
        e.Handled = Utils.General.KeyPress("0123456789", True, e)
    End Sub

    Private Sub btnCBView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCBView.Click

        If txtCashBillId.TextLength <= 0 Then
            Exit Sub
        End If

        If Not ExistInvoice() Then
            Exit Sub
        End If

        Dim pkid As Long = txtCashBillId.Text.Trim
        Dim ds As DataSet = Nothing
        objDA.getInvoiceItemObject(pkid, ds)
        If ds Is Nothing Then
            Exit Sub
        End If

        GlacialList1.Items.Clear()
       
        For Each row As DataRow In ds.Tables(0).Rows

            Dim item As New GlacialComponents.Controls.GLItem
            Dim subitem1 As New GlacialComponents.Controls.GLSubItem
            Dim subitem2 As New GlacialComponents.Controls.GLSubItem
            Dim subitem3 As New GlacialComponents.Controls.GLSubItem
            Dim subitem4 As New GlacialComponents.Controls.GLSubItem

            item.Text = GlacialList1.Count + 1
            subitem1.Text = row.Item("item_code") & vbCrLf & row.Item("name").ToString
            subitem2.Text = Format(row.Item("total_quantity"), 0)
            subitem3.Text = FormatCurrency(row.Item("unit_price_quoted"))
            subitem4.Text = FormatCurrency(row.Item("total"))
            item.Tag = row

            item.SubItems.AddRange(New GlacialComponents.Controls.GLSubItem() {subitem1, subitem2, subitem3, subitem4})
            GlacialList1.Items.Add(item)
            GlacialList1.Refresh()
        Next

        CalculateTotalQtyAndAmount()
        txtCashBillId.Focus()
        txtCashBillId.SelectAll()

    End Sub

    Private Sub btnCBOk_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCBOk.GotFocus, btnCBCancel.GotFocus, btnCBView.GotFocus, btnCashOk.GotFocus, btnCashCancel.GotFocus, btnCashInOutOk.GotFocus, btnCashInOutCancel.GotFocus
        Dim btn As Button = DirectCast(sender, Button)
        btn.ForeColor = Color.DarkBlue
    End Sub

    Private Sub btnCBOk_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCBOk.LostFocus, btnCBCancel.LostFocus, btnCBView.LostFocus, btnCashOk.LostFocus, btnCashCancel.LostFocus, btnCashInOutOk.LostFocus, btnCashInOutCancel.LostFocus
        Dim btn As Button = DirectCast(sender, Button)
        btn.ForeColor = Color.Black
    End Sub


    Private Sub EndDayClosingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EndDayClosingToolStripMenuItem.Click
        tbEndDayClosing.PerformClick()
    End Sub

    Private Sub tbEndDayClosing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbEndDayClosing.Click

        If hasTxn() Then
            Exit Sub
        End If

        If Messenger.ShowQuestion("Are you sure?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Try
            Dim timeStart As DateTime
            Dim ds As DataSet = Nothing
            objDA.getEndDayClosingByPos(gBranchID, gConfigObj.PosId, ds)
            If ds Is Nothing Then Exit Sub
            timeStart = ds.Tables(0).Rows(0)("time_start")

            Dim difHour As Double = Format(GetDiffHours(Now, timeStart), "0.00")
            ' check hour
            If difHour < gConfigObj.MinHourEndDayClosing Then
                Messenger.ShowWarning(difHour & " hours: Cannot End Day Closing. Min Hour must be at least " & gConfigObj.MinHourEndDayClosing)
                Exit Sub
            End If

            Dim rpt As New rptDailySalesReport(0, timeStart, Now, gConfigObj.PosId, "END DAY CLOSING")
            gShowReport(rpt)

            objDA.updateEndDayClosing(gBranchID, gConfigObj.PosId, 0)

            objDA.insertEndDayClosing(gBranchID, gConfigObj.PosId, gUserID)

            gCurrentTotalBill = 0
            lblCounter.Text = Format(objDA.getConuter, "000000") & "/" & gCurrentTotalBill

        Catch ex As Exception
            Messenger.ShowError(ex)
        End Try
    End Sub


    Private Sub tbConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbConfig.Click
        If hasTxn() Then
            Exit Sub
        End If

        If Not gLoadPermission(Permission.Config) Then
            Exit Sub
        End If

        Dim frm As New frmConfig
        frm.ShowDialog()
        Initialise()

    End Sub

    Private Sub ConfigToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfigToolStripMenuItem.Click
        tbConfig.PerformClick()
    End Sub

 
    Private Sub HoldToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HoldToolStripMenuItem.Click
        tbHold.PerformClick()
    End Sub

    Private Sub tbHold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbHold.Click
        If isHold Then
            If hasTxn() Then Exit Sub

            GlacialList1.Items.Clear()

            For i As Integer = 1 To colTxn.Count
                Dim docrow As DocRow = DirectCast(colTxn.Item(i), DocRow)

                Dim item As New GlacialComponents.Controls.GLItem
                Dim subitem1 As New GlacialComponents.Controls.GLSubItem
                Dim subitem2 As New GlacialComponents.Controls.GLSubItem
                Dim subitem3 As New GlacialComponents.Controls.GLSubItem
                Dim subitem4 As New GlacialComponents.Controls.GLSubItem

                item.Text = GlacialList1.Count + 1
                subitem1.Text = docrow.itemCode & vbCrLf & docrow.itemName
                subitem2.Text = docrow.qty
                subitem3.Text = FormatCurrency(docrow.price)
                subitem4.Text = FormatCurrency(docrow.getAmount)
                item.Tag = docrow
                item.SubItems.AddRange(New GlacialComponents.Controls.GLSubItem() {subitem1, subitem2, subitem3, subitem4})

                GlacialList1.Items.Add(item)
                GlacialList1.Refresh()
            Next

            CalculateTotalQtyAndAmount()
            isHold = False
            tbHold.Text = "F11 Hold"
        Else
            If Not hasTxn() Then Exit Sub

            colTxn.Clear()
            For Each item As GlacialComponents.Controls.GLItem In GlacialList1.Items
                Dim docrow As DocRow = DirectCast(item.Tag, DocRow)

                colTxn.Add(docrow)
            Next

            Reset()
            isHold = True
            tbHold.Text = "F11 UnHold"
        End If


    End Sub

#End Region

    Private Sub btnSync_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSync.Click
        gStopThread()

        'RunThread(dtpSync.Value, lblBottom)
    End Sub

    Private Sub btnEditPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditPrice.Click
        If isCash Then
            Exit Sub
        End If

        If Not hasTxn() Then
            Exit Sub
        End If

        If GlacialList1.SelectedItems.Count > 0 Then
            'If Not gLoadPermission(Permission.DeleteItem) Then
            '    Exit Sub
            'End If
            'If gConfigObj.MsgDeleteConfirmEnabled Then
            '    If Messenger.ShowQuestion(gConfigObj.MsgDeleteConfirm, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
            '        isDelete = False
            '        txtItemCode.Focus()
            '        Exit Sub
            '    End If
            'End If

            Dim item As GlacialComponents.Controls.GLItem = DirectCast(GlacialList1.SelectedItems(0), GlacialComponents.Controls.GLItem)
            Dim qty As Integer = item.SubItems(2).Text
            Dim price As Decimal = item.SubItems(3).Text
            Dim objDocRow As DocRow = DirectCast(item.Tag, DocRow)

            'Dim frm As New frmPriceEdit
            'frm.price = price
            'If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            '    Dim newPrice As Decimal = frm.txtPrice.Text
            '    If (newPrice < objDocRow.minPrice) And (Not gConfigObj.SellingBelowMinPrice) Then
            '        Messenger.ShowInformation("Cannot Selling below min price!")
            '    Else
            '        item.SubItems(3).Text = FormatCurrency(frm.txtPrice.Text)
            '        item.SubItems(4).Text = FormatCurrency(qty * Convert.ToDecimal(GlacialList1.SelectedItems(0).SubItems(3).Text))
            '        objDocRow.price = newPrice
            '    End If
            'End If
        End If
       
        pHistory.Visible = False
        CalculateTotalQtyAndAmount()
        txtItemCode.Focus()

    End Sub

End Class
