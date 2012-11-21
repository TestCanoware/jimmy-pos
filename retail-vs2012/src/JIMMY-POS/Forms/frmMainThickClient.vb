Imports DataAccess
Imports Utils
Imports Utils.General

Public Class frmMainThickClient

#Region " Variable Declarations "

    ' Default Const
    Private Saving As Boolean = False
    Private FORMTITLE As String = My.Application.Info.Title
    Private defaultCustAcc As Integer = 500

    'Const
    Private TEXT_ADD_ITEM As String = gGetLocale("frmMainThickClient", "btnAdd.Text")
    Private TEXT_UPDATE_ITEM As String = gGetLocale("frmMainThickClient", "btnUpdateItem.Text")
    Private TEXT_BACK_TO_CASHSALE As String = gGetLocale("frmMainThickClient", "btnBackToCashSale.Text")
    Private TEXT_PREVIOUS As String = gGetLocale("frmMainThickClient", "btnPrevious.Text")
    Private TEXT_NEXT As String = gGetLocale("frmMainThickClient", "btnNext.Text")
    Private TEXT_VOID As String = gGetLocale("frmMainThickClient", "btnVoid.Text")
    Private TEXT_RESET As String = gGetLocale("frmMainThickClient", "btnReset.Text")
    Private TEXT_CASH_IN_OUT As String = gGetLocale("frmMainThickClient", "btnCashInOut.Text")
    Private TEXT_PAYMENT As String = gGetLocale("frmMainThickClient", "btnPayment.Text")
    Private TEXT_DELETE_ITEM As String = gGetLocale("frmMainThickClient", "btnDelete.Text")


    'Default CashSale Color
    Private CashSaleTitleBarColor As Color = Color.SkyBlue
    Private CashSaleToolsMenuColor As Color = Color.LightCyan
    Private CashSaleDetailsColor As Color = Color.Azure
    Private CashSaleItemDetailsColor As Color = Color.LemonChiffon
    Private CashSaleTotalColor As Color = Color.LightCyan


    ' Images
    Private imgConnected As Image = My.Resources.ball_green
    Private imgDisConnected As Image = My.Resources.ball_red
    Private imgSave As Image = My.Resources.Save_32x32
    Private imgCash As Image = My.Resources.green_dollar_32x32
    Private imgPrev As Image = My.Resources.Previous_32x32
    Private imgNext As Image = My.Resources.Next_32x32
    Private imgCashInOut As Image = My.Resources.Money
    Private imgOtherPayments As Image = My.Resources.payment

    ' Object 
    Private objCustAcc As New DACustAccountObject
    Private objCustUser As New DACustUserObject
    Private objDA As New DataAccessNut
    Private objReceipt As DAOfficialReceiptObject
    Private objJobsheet As DAJobsheetObject
    Private objSalesTxn As SalesTxn
    Private objInvoice As DAInvoiceObject
    Private objDocRow As DocRow

    ' ArrayList
    Private arrDocRow As New ArrayList
    Private arrHold As New ArrayList
    Private arrDeposit As New ArrayList
    Private arrJobsheet As New ArrayList

    Private itemEditMode As Boolean

    Private returnChange As Decimal = 0
    Private tender As Decimal = 0
    Private textBoxFocused As TextBox

    'Extenal Details
    Private remarks As String = ""
    Private trackingNo As String = ""
    Private billingHandphone As String = ""

    Private Enum FormMode
        MAIN
        CASHSALE_VIEW
    End Enum

    Private Enum MenuMode
        MAIN
        REPORT
        MORE
    End Enum

    Private frmMode As FormMode
    Private mnuMode As MenuMode

#End Region

#Region " Initialisation "

    Private Sub frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Initialise()
    End Sub

    Private Sub Initialise()
        AssignValue(gGetLocale(Me.Name, "title"), Me.Text)
        Messenger.Caption = Me.Text
        gSetLocaleChange(Me.Name, Me)

        General.CursorButtons(Me, Cursors.Hand)

        SetEventHanlder()

        SetupDefaultControls()

    End Sub

    Private Sub SetupDefaultControls()
        'Temp hide memberCard
        lblMemberCard.Visible = False
        txtMemberCard.Visible = False
        btnSearchMember.Visible = False
        lblMember.Visible = False

        ClearControls()

        lblWelcome.Text = gAppConfig.MsgWelcome
        lblShowDate.Text = FormatDateTime(Now)
        lblShowUser.Text = gUserObj.username

        lblSubTotalCcy.Text = gBranchObj.currency
        lblTotalIncludeTaxCcy.Text = gBranchObj.currency
        lblTotalDepositCcy.Text = gBranchObj.currency
        lblTotalCcy.Text = gBranchObj.currency
        lblTotalQtyCcy.Text = gBranchObj.currency

        lblTotalExcludeTaxCcy.Text = gBranchObj.currency
        lblGrandTotalCcy.Text = gBranchObj.currency

        ' Lock all fields at Total panel
        LockAllFields(pTotal, True)

        ' Check Permission for lock fields

        LockPrice(Not gHasPermission(Permission.EditPrice))
        LockDiscount(Not gHasPermission(Permission.GiveDiscount))
        LockCustAcc(Not gHasPermission(Permission.CustAccount))

        Load_cboSalesman()
        txtItem.Focus()

        frmMode = FormMode.MAIN

        ShowMenu(1)

        lblCounter.Text = Format(objDA.GetPosConuter, "000000") & "/" & gCurrentTotalBill

        cboSalesman.Enabled = Not gAppConfig.DisallowUserToChangeSalesman

        If gAppConfig.PriceIncludeTax Then
            pIncludeTax.Visible = True
        Else
            pExcludeTax.Visible = True
        End If

        LoadPictureFromBlob(gAppConfig.LogoBlob, picLogo)

    End Sub

    Private Sub SetEventHanlder()

        'AddHandler btnSearchCustomer.Click, AddressOf ButtonClick
        'AddHandler btnSearchCustAcc.Click, AddressOf ButtonClick
        AddHandler btnSearchMember.Click, AddressOf ButtonClick

        AddHandler btn0.Click, AddressOf ButtonClick
        AddHandler btn1.Click, AddressOf ButtonClick
        AddHandler btn2.Click, AddressOf ButtonClick
        AddHandler btn3.Click, AddressOf ButtonClick
        AddHandler btn4.Click, AddressOf ButtonClick
        AddHandler btn5.Click, AddressOf ButtonClick
        AddHandler btn6.Click, AddressOf ButtonClick
        AddHandler btn7.Click, AddressOf ButtonClick
        AddHandler btn8.Click, AddressOf ButtonClick
        AddHandler btn9.Click, AddressOf ButtonClick

        AddHandler btnAdd.Click, AddressOf ButtonClick
        AddHandler btnCash.Click, AddressOf ButtonClick
        AddHandler btnCashInOut.Click, AddressOf ButtonClick
        AddHandler btnDelete.Click, AddressOf ButtonClick
        AddHandler btnDot.Click, AddressOf ButtonClick
        AddHandler btnEdit.Click, AddressOf ButtonClick
        AddHandler btnPayment.Click, AddressOf ButtonClick
        AddHandler btnReset.Click, AddressOf ButtonClick
        AddHandler btnSaleHistory.Click, AddressOf ButtonClick

        AddHandler btnCustAccount.Click, AddressOf ButtonClick
        AddHandler btnFOC.Click, AddressOf ButtonClick
        AddHandler btnSalesperson.Click, AddressOf ButtonClick
        AddHandler btnBackspace.Click, AddressOf ButtonClick
        AddHandler btnGoodsExchange.Click, AddressOf ButtonClick

        AddHandler txtCustAcc.KeyPress, AddressOf TextIntegerKeyPress
        AddHandler txtCustomer.KeyPress, AddressOf TextIntegerKeyPress

        AddHandler txtItem.KeyPress, AddressOf TextKeyPress
        AddHandler txtQty.KeyPress, AddressOf TextIntegerKeyPress
        AddHandler txtPrice.KeyPress, AddressOf TextDecimalKeyPress
        AddHandler txtDiscPercentage.KeyPress, AddressOf TextIntegerKeyPress
        AddHandler txtDisc.KeyPress, AddressOf TextDecimalKeyPress

        'AddHandler txtPrice.Leave, AddressOf TextDecimalLeave

        'AddHandler txtQty.KeyPress, AddressOf TextKeyPress
        'AddHandler txtPrice.KeyPress, AddressOf TextKeyPress
        'AddHandler txtDiscPercentage.KeyPress, AddressOf TextKeyPress
        'AddHandler txtDisc.KeyPress, AddressOf TextKeyPress

        AddHandler txtCustomer.Click, AddressOf TextClick
        AddHandler txtCustAcc.Click, AddressOf TextClick
        AddHandler txtMemberCard.Click, AddressOf TextClick
        AddHandler txtItem.Click, AddressOf TextClick
        AddHandler txtQty.Click, AddressOf TextClick
        AddHandler txtPrice.Click, AddressOf TextClick
        AddHandler txtDisc.Click, AddressOf TextClick
        AddHandler txtDiscPercentage.Click, AddressOf TextClick

        AddHandler txtCustomer.Enter, AddressOf TextEnter
        AddHandler txtCustAcc.Enter, AddressOf TextEnter
        AddHandler txtMemberCard.Enter, AddressOf TextEnter
        AddHandler txtItem.Enter, AddressOf TextEnter
        AddHandler txtQty.Enter, AddressOf TextEnter
        AddHandler txtPrice.Enter, AddressOf TextEnter
        AddHandler txtDisc.Enter, AddressOf TextEnter
        AddHandler txtDiscPercentage.Enter, AddressOf TextEnter

    End Sub

#End Region

#Region " Load Controls - ComboBox, ListView, ListBox, etc "

    Private Sub Load_cboSalesman()

        Dim ds As DataSet

        Try
            ds = objDA.GetAllUser
            PopulateComboBoxWithDataset(ds, DAUser.USERNAME, DAUser.USERID, cboSalesman)

            cboSalesman.SelectedValue = gUserObj.userid

        Catch ex As Exception
            Messenger.Caption = Me.Text & " - Load Salesman Error"
            Messenger.ShowError(ex.Message)
        End Try

    End Sub

#End Region

#Region " Database Updating - Presentation Layer "

    Private Sub AddItem()

        Dim itemCode As String = txtItem.Text.Trim
        Dim qty As Integer = IIf(txtQty.Text = "", 0, txtQty.Text)
        Dim price As Decimal = IIf(txtPrice.Text = "", 0, txtPrice.Text)
        Dim discPercentage As Integer = IIf(txtDiscPercentage.Text = "", 0, txtDiscPercentage.Text)
        Dim disc As Decimal = IIf(txtDisc.Text = "", 0, txtDisc.Text)

        If itemCode = "" Then Exit Sub

        Dim objDocRow As New DocRow
        Try

            objDocRow = objDA.GetItemDocRow(itemCode, gBranchObj.invLocationId)
            If objDocRow Is Nothing Then
                'Messenger.ShowInformation(gMSG_ITEM_NOT_FOUND)
                FindItemClick(itemCode)
                Exit Sub
            End If

            If qty > 0 Then objDocRow.qty = qty

            'Get Serialized item
            'If (objDocRow.serialized) Then
            '    Dim frm As New frmSelectSN
            '    frm.stockId = objDocRow.stockId
            '    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            '        For Each row As DataRowView In frm.lstSN.SelectedItems
            '            objDocRow.arrSerials.Add(row("serial"))                        
            '        Next
            '        objDocRow.qty = objDocRow.arrSerials.Count
            '    Else
            '        Exit Sub
            '    End If
            'End If


            If price > 0 Then objDocRow.price = price
            If discPercentage > 0 AndAlso discPercentage <= 100 Then
                If price > 0 Then
                    objDocRow.discount = price * discPercentage / 100
                Else
                    objDocRow.discount = objDocRow.price * discPercentage / 100
                End If
            End If

            If disc > 0 AndAlso disc < objDocRow.price Then
                objDocRow.discount = disc
            End If

            objDocRow.remarks = cboSalesman.Text            
            AddItemWithDocRow(objDocRow)

            ' add to ArrayList DocRow
            arrDocRow.Add(objDocRow)

            SetTotal()

            ClearAddItemFields()

            gDisplayPole(objDocRow.itemName, FormatCurrency(objDocRow.GetAmount))

        Catch ex As Exception
            Messenger.Caption = Me.Text & " - Add Item Error"
            Messenger.ShowError(ex.Message)
        End Try

    End Sub

    Private Sub UpdateItem()

        Try

            If GlacialList1.SelectedItems.Count = 0 Then Exit Sub

            Dim qty As Integer = txtQty.Text
            Dim price As Decimal = txtPrice.Text
            Dim discPercentage As Integer = txtDiscPercentage.Text
            Dim disc As Decimal = txtDisc.Text

            'objDocRow = SelectDocRow()

            If qty > 0 Then objDocRow.qty = qty
            objDocRow.price = price

            If discPercentage = 0 AndAlso disc = 0 Then
                objDocRow.discount = 0
            Else
                If discPercentage > 0 AndAlso discPercentage <= 100 Then
                    If price > 0 Then
                        objDocRow.discount = price * discPercentage / 100
                    Else
                        objDocRow.discount = objDocRow.price * discPercentage / 100
                    End If
                End If

                If disc > 0 AndAlso disc < objDocRow.price Then
                    objDocRow.discount = disc
                End If
            End If

            UpdateItemWithDocRow(objDocRow)
            UpdateDeleteItem(objDocRow)

            gDisplayPole(objDocRow.itemName, FormatCurrency(objDocRow.GetAmount))

            ShowEditItemMenu(False)

            SetTotal()
            ClearAddItemFields()

        Catch ex As Exception
            Messenger.Caption = Me.Text & " - Update Item Error"
            Messenger.ShowError(ex.Message)
        End Try

    End Sub

    Private Sub UpdateDeleteItem(ByVal objDocRow As DocRow)

        Dim dr As New DocRow
        Dim item As New GlacialComponents.Controls.GLItem
        For Each item In GlacialList1.Items
            dr = DirectCast(item.Tag, DocRow)
            If objDocRow.guid = dr.guid Then

                Dim qty As Integer = dr.qty
                Dim remarks As String = dr.remarks
                AssignFieldsValue(objDocRow, dr)
                dr.qty = qty
                dr.remarks = remarks

                Dim sn As String = Utils.General.GetCSV(objDocRow.arrSerials)
                If sn.Length > 0 Then sn = "SN: " & sn

                item.SubItems(1).Text = objDocRow.itemCode & vbCrLf & objDocRow.itemName & " (" & objDocRow.remarks & ") " & sn
                item.SubItems(2).Text = dr.qty
                item.SubItems(3).Text = FormatCurrencyNoComma(dr.GetPriceStd)
                item.SubItems(4).Text = FormatCurrencyNoComma(dr.discount)
                item.SubItems(5).Text = FormatCurrencyNoComma(dr.GetAmount)

                item.Tag = dr

            End If
        Next

    End Sub

    Private Sub EditItem()

        objDocRow = SelectDocRow()
        If objDocRow Is Nothing Then Exit Sub
        If objDocRow.qty < 0 Then Exit Sub

        txtItem.Text = objDocRow.itemCode
        txtQty.Text = objDocRow.qty
        txtPrice.Text = FormatCurrencyNoComma(objDocRow.price)
        txtDisc.Text = FormatCurrencyNoComma(objDocRow.discount)

        ShowEditItemMenu(True)

    End Sub

    Private Sub DeleteItem()

        If Not gLoadPermission(Permission.DeleteItem) Then Exit Sub

        objDocRow = SelectDocRow()
        If objDocRow Is Nothing Then Exit Sub

        If Not gShowMsgDeleteConfirm() Then Exit Sub

        If objDocRow.itemType = DocRow.TYPE_GOODS_EXCHANGE Then
            arrDocRow.Remove(objDocRow)
            RemoveItem()
            Exit Sub
        End If

        Dim frm As New frmSelectQty
        frm.maxQty = GetItemMaxQty(objDocRow)
        If Not frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If

        Dim qty As Integer = frm.NumericUpDown1.Value
        If gAppConfig.AddNewLineDeletingItem Then
            Dim newDocRow As New DocRow
            AssignFieldsValue(objDocRow, newDocRow)

            newDocRow.qty = Decimal.Negate(qty)
            newDocRow.remarks = frm.txtRemark.Text.Trim

            arrDocRow.Add(newDocRow)
            AddItemWithDocRow(newDocRow)
        Else
            objDocRow.qty -= qty
            If objDocRow.qty = 0 Then
                arrDocRow.Remove(objDocRow)
                RemoveItem()
            Else
                UpdateItemWithDocRow(objDocRow)
            End If

        End If

        SetTotal()

        ClearAddItemFields()

        gShowMsgDeleteSucceed()
    End Sub

    Private Function SelectDocRow() As DocRow
        If GlacialList1.Items.Count = 0 Then Return Nothing

        Dim objDocRow As DocRow = Nothing
        If GlacialList1.SelectedItems.Count = 0 Then
            GlacialList1.Items(0).Selected = True
            GlacialList1.Focus()
            Return Nothing
        End If

        Dim item As New GlacialComponents.Controls.GLItem
        item = GlacialList1.SelectedItems(0)
        objDocRow = DirectCast(item.Tag, DocRow)
        If objDocRow.qty <= 0 AndAlso Not objDocRow.itemType = DocRow.TYPE_GOODS_EXCHANGE Then Return Nothing

        Return objDocRow
    End Function

    Private Function GetItemMaxQty(ByVal objDocRow As DocRow) As Integer

        Dim qty As Integer = 0
        Dim item As New GlacialComponents.Controls.GLItem
        For Each item In GlacialList1.Items
            Dim dr As New DocRow
            dr = DirectCast(item.Tag, DocRow)
            If objDocRow.guid = dr.guid Then
                qty += dr.qty
            End If
        Next

        Return qty

    End Function

    Private Function SaveTxn() As Boolean

        Dim receiptId As Integer = 0
        objInvoice = New DAInvoiceObject

        Dim guid As String = System.Guid.NewGuid.ToString

        Dim depositAmt As Decimal = lblTotalDepositAmt.Text
        Dim taxAmt As Decimal = lblTotalExcludeTaxAmt.Text
        Dim subTotal As Decimal = lblSubTotalAmt.Text
        Dim grandTotal As Decimal = lblGrandTotalAmt.Text

        Dim isRefund As Boolean = grandTotal < 0

        ' Pop up cash drawer
        'WriteToLogFile("Pop up cash drawer")
        CashRegisterItemClick()

        Try
            Dim change As Decimal = returnChange
            If change > 0 Then
                gDisplayPole("CHANGE:", FormatCurrency(change))
            End If

            'WriteToLogFile("Save Transaction.")
            If Not CreateCashSale(guid, objInvoice, objReceipt) Then Return False

            'Deposit Settlement
            DepositSettlement(objInvoice, isRefund, guid)

            UpdateJobsheetState(objInvoice, guid)

            'To Refund
            If isRefund Then
                If Messenger.ShowQuestion(gMSG_REFUND, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Dim frm As New frmPaymentVoucher
                    frm.pkid = objCustAcc.pkid
                    frm.arrDeposit = arrDeposit
                    frm.frmMode = frmPaymentVoucher.FormMode.MAIN
                    frm.ShowDialog()
                End If
            End If

            ''WriteToLogFile("Print Receipt")
            gPrintCashBill(objInvoice.mPkid)

            objDA.UpdateQtyBill(gPosEndDayClosingObj)
            gCurrentTotalBill += 1
            objDA.UpdatePosCounter()

            lblCounter.Text = Format(objDA.GetPosConuter, "000000") & "/" & gCurrentTotalBill

            gShowMsgTxnSucceed(objInvoice.mPkid, "CASH SALE")

            If change > 0 Then
                gShowMessage(gBranchObj.currency & " " & FormatCurrency(change))
            End If

            gDisplayPole(gAppConfig.MsgWelcome, "")

            ResetButtonClick()

            Return True

        Catch ex As Exception
            Messenger.Caption = FORMTITLE & " - Save Transaction Error"
            Messenger.ShowError(ex.Message)
            Saving = False
            Return False
        End Try

    End Function

    Private Function UpdateJobsheetState(ByVal invObj As DAInvoiceObject, ByVal guid As String) As Boolean

        For Each obj As DAJobsheetObject In arrJobsheet
            'obj.state = DAJobsheet.STATE_INVOICE
            'objDA.UpdateJobsheet(obj, guid)

            '' create doclink for this jobsheet
            'Dim doclinkObj As New DADocLinkObject
            'doclinkObj.name_space = DADocLink.NS_CUSTOMER
            'doclinkObj.relType = DADocLink.RELTYPE_JS_TO_INVOICE
            'doclinkObj.srcDocRef = DAInvoice.TABLENAME
            'doclinkObj.srcDocId = invObj.mPkid
            'doclinkObj.tgtDocRef = DAJobsheet.TABLENAME
            'doclinkObj.tgtDocId = obj.pkid
            'doclinkObj.currency = invObj.mCurrency
            'doclinkObj.amount = 0
            'doclinkObj.lastUpdate = Now
            'doclinkObj.userIdUpdate = gUserObj.userid

            'objDA.InsertDocLink(doclinkObj)
            objDA.ModifyJobsheetState(obj, invObj, guid)
        Next

    End Function


    Private Function CreateCashSale(ByVal guid As String, ByRef invObj As DAInvoiceObject, _
                                            ByRef receiptObj As DAOfficialReceiptObject) As Boolean

        Try

            invObj = New DAInvoiceObject
            invObj.mEntityKey = objCustAcc.pkid
            invObj.mEntityName = objCustAcc.name
            invObj.mEntityTable = DACustAccount.TABLENAME
            invObj.mEntityCode = objCustAcc.custAccountCode
            invObj.salesId = cboSalesman.SelectedValue
            invObj.mTimeIssued = Now
            invObj.mTotalAmt = GetInvoiceTotal()
            invObj.taxAmount = GetTotalTaxAmount()
            invObj.mUserIdUpdate = gUserObj.userid
            invObj.mLastUpdate = Now
            invObj.mCustSvcCtrId = gBranchObj.pkid
            invObj.mLocationId = gBranchObj.invLocationId
            invObj.mPCCenter = gBranchObj.accPCCenterId
            invObj.mCurrency = gBranchObj.currency
            invObj.mState = DAInvoice.ST_CREATED
            invObj.mRemarks = Me.remarks
            invObj.trackingNo = Me.trackingNo
            invObj.billingHandphone = Me.billingHandphone

            invObj.receiverName = objCustAcc.name
            invObj.receiverHandphone = objCustAcc.mobilePhone

            invObj.posId = gSysConfig.PosId

            If Not objCustUser Is Nothing Then
                invObj.mForeignTable = DACustUser.TABLENAME
                invObj.mForeignKey = objCustUser.pkid
                invObj.receiverName = objCustUser.GetName()
                invObj.receiverHandphone = objCustUser.mobilePhone
            End If

            For Each dr As DocRow In arrDocRow
                Dim invItemObj As New DAInvoiceItemObject(invObj, dr)
                invObj.arrItems.Add(invItemObj)
            Next

            Return objDA.CreateCashsale(invObj, receiptObj, guid)

        Catch ex As Exception
            Messenger.Caption = Me.Text & " - Create Cash Sale Error"
            Messenger.ShowError(ex.Message)
            Return False
        End Try

    End Function


    Private Function InsertReceipt(ByVal guid As String, ByRef invObj As DAInvoiceObject, ByRef receiptObj As DAOfficialReceiptObject) As Boolean

        Try
            receiptObj.entityKey = objCustAcc.pkid
            receiptObj.entityName = objCustAcc.name
            receiptObj.entityTable = DACustAccount.TABLENAME
            receiptObj.currency = invObj.mCurrency
            receiptObj.paymentTime = invObj.mTimeIssued
            receiptObj.paymentRemarks = invObj.mRemarks
            receiptObj.lastUpdate = Now
            receiptObj.userIdUpdate = gUserObj.userid
            receiptObj.cbCash = gBranchObj.cashbookCash
            receiptObj.cbCard = gBranchObj.cashbookCard
            receiptObj.cbCheque = gBranchObj.cashbookCheque
            receiptObj.cbCoupon = gBranchObj.cashbookCoupon
            receiptObj.cbPDCheque = gBranchObj.cashbookPDCheque
            receiptObj.cbOther = gBranchObj.cashbookOther
            receiptObj.branch = gBranchObj.pkid
            receiptObj.pcCenter = gBranchObj.accPCCenterId
            receiptObj.cashNotesReceived = tender
            receiptObj.cashNotesChange = returnChange
            receiptObj.posId = gSysConfig.PosId

            objDA.InsertOfficialReceipt(receiptObj, receiptObj.pkid, guid)

            ' Update Receipt Id at Invoice
            invObj.mReceiptId = receiptObj.pkid
            objDA.UpdateInvoice(invObj)

            Return True

        Catch ex As Exception
            Messenger.Caption = Me.Text & " - Create Receipt Error"
            Messenger.ShowError(ex.Message)
            Return False
        End Try


    End Function

    Public Function InsertCashInOut(ByVal amount As Decimal, ByVal remarks As String, ByVal status As String, ByRef pkid As Integer)

        Try
            Dim obj As New DAPosCashInOutObject
            If status = DAPosCashInOut.STATUS_CASH_OUT Then
                amount = Decimal.Negate(amount)
            End If
            obj.amount = amount
            obj.branchId = gBranchObj.pkid
            obj.lastupdate = Now
            obj.posId = gSysConfig.PosId
            obj.remarks = remarks
            obj.status = status
            obj.userId = gUserObj.userid

            Return objDA.InsertPosCashInOut(obj, pkid)

        Catch ex As Exception
            Messenger.Caption = Me.Text & " - Create Cash In Out Error"
            Messenger.ShowError(ex.Message)
            Return False
        End Try

    End Function

    Public Function LoadJobsheet(ByVal pkid As Long) As Boolean

        'Dim jobsheetObj As DAJobsheetObject
        ' Get Jobsheet with pkid
        objJobsheet = objDA.GetJobsheet(pkid)
        If objJobsheet Is Nothing Then
            Messenger.ShowWarning("The Jobsheet '" & pkid & "' does not exist!")
            Return False
        End If

        If objJobsheet.state = DAJobsheet.STATE_INVOICE Then
            Messenger.ShowWarning("The Jobsheet '" & pkid & "' has been converted into invoice!")
            Return False
        End If

        SetCustAcc(objJobsheet.entityKey)
        If objJobsheet.foreignTable = DACustUser.TABLENAME Then
            SetCustUser(objJobsheet.foreignKey)
        End If

        For Each jobsheetItemObj As DAJobsheetItemObject In objJobsheet.arrItems
            Dim dr As New DocRow
            dr = jobsheetItemObj.GetDocRow()
            AddItemWithDocRow(dr)
            arrDocRow.Add(dr)
        Next

        'Set External Details
        Me.remarks = objJobsheet.remarks

        SetTotal()

    End Function

    Public Function LoadInvoice(ByVal pkid As Long) As Boolean

        Dim InvoiceObj As DAInvoiceObject
        ' Get Invoice with pkid
        InvoiceObj = objDA.GetInvoice(pkid)
        If InvoiceObj Is Nothing Then
            Messenger.ShowWarning("The Cash Sale '" & pkid & "' does not exist!")
            Return False
        End If

        ShowViewCashSaleMenu(pkid, True)

        objInvoice = InvoiceObj

        ' Get deposit amt
        Me.arrDeposit.Clear()
        Dim row As New DocRow
        row.refKey = pkid
        row.price = Decimal.Negate(objDA.GetDepositAmt(pkid))

        arrDeposit.Add(row)

        SetCustAcc(objInvoice.mEntityKey)
        If objInvoice.mForeignTable = DACustUser.TABLENAME Then
            SetCustUser(objInvoice.mForeignKey)
        End If

        For Each InvoiceItemObj As DAInvoiceItemObject In objInvoice.arrItems
            Dim dr As New DocRow
            dr = InvoiceItemObj.GetDocRow()
            AddItemWithDocRow(dr)
            arrDocRow.Add(dr)
        Next

        'Set External Details
        Me.trackingNo = objInvoice.trackingNo
        Me.billingHandphone = objInvoice.billingHandphone
        Me.remarks = objInvoice.mRemarks

        SetTotal()

        If objInvoice.mStatus = DAInvoice.STATUS_CANCELLED Then
            Messenger.ShowWarning("The Cash Sale '" & pkid & "' has been canceled!")
            lblWelcome.Text &= " - CANCELED "
            btnDelete.Enabled = False
        End If

        gDisplayPole(gAppConfig.MsgWelcome, "")
    End Function

    Public Function InsertDocLink(ByVal invObj As DAInvoiceObject, ByVal receiptObj As DAOfficialReceiptObject, ByVal payment As Decimal, _
                                  ByVal relType As String) As Boolean

        Try

            Dim obj As New DADocLinkObject
            obj.name_space = DADocLink.NS_CUSTOMER
            obj.relType = relType
            obj.srcDocRef = DAOfficialReceipt.TABLENAME
            obj.srcDocId = receiptObj.pkid
            obj.tgtDocRef = DAInvoice.TABLENAME
            obj.tgtDocId = invObj.mPkid
            obj.currency = invObj.mCurrency
            obj.amount = Decimal.Negate(payment)
            obj.lastUpdate = Now
            obj.userIdUpdate = gUserObj.userid

            objDA.CreateDoclink(obj)

            Return True

        Catch ex As Exception
            Messenger.Caption = Me.Text & " - Create Document Link Error"
            Messenger.ShowError(ex.Message)
            Return False
        End Try

    End Function

    Public Function UpdateBalanceReceipt(ByVal receiptObj As DAOfficialReceiptObject, ByVal payment As Decimal, ByVal guid As String) As Boolean

        Try
            Dim newBalance As Decimal = receiptObj.openBalance - payment
            If newBalance > 0 Then
                receiptObj.openBalance = newBalance
            Else
                receiptObj.openBalance = 0
            End If

            objDA.UpdateOfficialReceipt(receiptObj, payment, guid)

        Catch ex As Exception
            Messenger.Caption = Me.Text & " - Update Balance Receipt Error"
            Messenger.ShowError(ex.Message)
            Return False
        End Try

    End Function

    Public Function DepositSettlement(ByVal invObj As DAInvoiceObject, ByVal isRefund As Boolean, ByVal guid As String) As Boolean

        For Each dr As DocRow In arrDeposit
            Dim receiptObj As New DAOfficialReceiptObject
            receiptObj = objDA.GetOfficialReceipt(dr.refKey)

            Dim payment As Decimal = IIf(isRefund, invObj.mTotalAmt, dr.price)

            'Create doclink
            InsertDocLink(invObj, receiptObj, payment, DADocLink.RELTYPE_PYMT_INV_DEPOSIT)

            UpdateBalanceReceipt(receiptObj, payment, guid)
        Next

    End Function

    Public Sub CancelInvoice()

        If Not gLoadPermission(Permission.CancelSale) Then Exit Sub

        If Not gShowMsgVoidConfirm() Then Exit Sub

        Dim frm As New frmRemark
        If Not frm.ShowDialog = DialogResult.OK Then
            Exit Sub
        End If

        If Not objDA.CancelInvoice(objInvoice.mPkid, frm.txtRemark.Text.Trim) Then Exit Sub

        gShowMsgVoidSucceed(objInvoice.mPkid, "")

        lblWelcome.Text &= " - CANCELED"
        btnDelete.Enabled = False

        gPrintCashBill(objInvoice.mPkid)
    End Sub

#End Region

#Region " Controls Populating, Updating, etc "

    Private Sub EnabledMenuKey(ByVal enable As Boolean)
        For Each mnu As ToolStripMenuItem In mnuTools.DropDownItems
            mnu.Enabled = enable
        Next
    End Sub

    Private Sub ShowMenu(ByVal mode As Integer)

        For Each tb As ToolStripItem In ToolStrip1.Items
            tb.Visible = False
        Next

        EnabledMenuKey(False)

        Select Case mode
            Case 1 ' Tools Menu

                ShowToolsMenu(True)
                mnuMode = MenuMode.MAIN

            Case 2 ' Report Menu

                ShowReportMenu(True)
                mnuMode = MenuMode.REPORT

            Case 3 'More Menu

                ShowMoreMenu(True)
                mnuMode = MenuMode.MORE

        End Select


    End Sub

    Private Sub ShowToolsMenu(ByVal show As Boolean)
        tbFindItem.Visible = show
        tbHold.Visible = show
        tbRecall.Visible = show
        tbDeposit.Visible = show
        tbCashRegister.Visible = show
        tbReports.Visible = show
        tbEndDayClosing.Visible = show
        tbLogout.Visible = show
        tbConfig.Visible = show
        tbPrint.Visible = show
        tbSync.Visible = show


        mnuF1.Enabled = show
        mnuF2.Enabled = show
        mnuF3.Enabled = show
        mnuF4.Enabled = show
        mnuF5.Enabled = show
        mnuF7.Enabled = show
        mnuF8.Enabled = show
        mnuF9.Enabled = show
        mnuF10.Enabled = show
        mnuF11.Enabled = show
        mnuF12.Enabled = show

    End Sub

    Private Sub ShowReportMenu(ByVal show As Boolean)
        tbBack.Visible = show
        tbDailySalesReport.Visible = show
        tbHourlySalesReport.Visible = show
        tbDetailedVoidReport.Visible = show
        tbVoidReport.Visible = show
        tbReceiptListing.Visible = show
        tbSummaryStockSoldReport.Visible = show

        mnuF1.Enabled = show
        mnuF2.Enabled = show
        mnuF3.Enabled = show
        mnuF4.Enabled = show
        mnuF5.Enabled = show
        mnuF6.Enabled = show
        mnuF7.Enabled = show

    End Sub

    Private Sub ShowMoreMenu(ByVal show As Boolean)


        mnuF1.Enabled = show
        mnuF2.Enabled = show
        mnuF3.Enabled = show
        mnuF4.Enabled = show
        mnuF5.Enabled = show
    End Sub

    Private Sub ShowEditItemMenu(ByVal show As Boolean)
        itemEditMode = show
        LockItem(show)
        LockQty(show)
        If show Then
            btnAdd.Text = TEXT_UPDATE_ITEM
        Else
            btnAdd.Text = TEXT_ADD_ITEM
        End If
    End Sub

    Private Sub ShowViewCashSaleMenu(ByVal invoiceId As Long, ByVal show As Boolean)

        ClearControls()

        If show Then
            lblWelcome.Text = gAppConfig.MsgWelcome & " - " & "CASHSALE : " & invoiceId
            btnDelete.Text = TEXT_VOID
            btnReset.Text = TEXT_BACK_TO_CASHSALE
            btnCashInOut.Text = TEXT_PREVIOUS
            btnCashInOut.Image = imgPrev
            btnPayment.Text = TEXT_NEXT
            btnPayment.Image = imgNext

            frmMode = FormMode.CASHSALE_VIEW
            EnabledMenuKey(False)
        Else
            lblWelcome.Text = gAppConfig.MsgWelcome
            btnDelete.Text = TEXT_DELETE_ITEM
            btnReset.Text = TEXT_RESET
            btnCashInOut.Text = TEXT_CASH_IN_OUT
            btnCashInOut.Image = imgCashInOut
            btnPayment.Text = TEXT_PAYMENT
            btnPayment.Image = imgOtherPayments

            frmMode = FormMode.MAIN
            EnabledMenuKey(True)
        End If

        LockAllFields(Me, show)
        LockAllButtons(Me, show)

        btnDelete.Enabled = True
        btnReset.Enabled = True
        btnSaleHistory.Enabled = True
        btnCashInOut.Enabled = True
        btnPayment.Enabled = True

    End Sub

    Private Sub ClearAddItemFields()
        txtItem.Text = ""
        txtQty.Text = "1"
        txtPrice.Text = "0.00"
        txtDiscPercentage.Text = "0"
        txtDisc.Text = "0.00"

        LockItem(False)
        txtItem.Focus()

        itemEditMode = False
        ShowEditItemMenu(False)
    End Sub

    Private Sub ClearControls()
        ClearAddItemFields()
        GlacialList1.Items.Clear()
        GlacialList1.Refresh()
        'txtWarning.Text = ""

        arrDocRow.Clear()
        arrJobsheet.Clear()
        arrDeposit.Clear()

        lblSubTotalAmt.Text = "0.00"
        lblTotalIncludeTaxAmt.Text = "0.00"
        lblTotalDepositAmt.Text = "0.00"
        lblTotalAmt.Text = "0.00"
        lblTotalQtyAmt.Text = "0"

        lblTotalExcludeTaxAmt.Text = "0.00"
        lblGrandTotalAmt.Text = "0.00"

        lblShowCustomerAccount.Text = ""
        lblShowCustomer.Text = ""
        txtCustomer.Text = ""
        txtCustAcc.Text = ""
        lblShowDeposit.Text = ""

        ' Reset Receipt Object
        objReceipt = New DAOfficialReceiptObject
        objDocRow = New DocRow
        objCustAcc = New DACustAccountObject
        objCustUser = New DACustUserObject

        remarks = ""

        Saving = False

        SetCustAcc(defaultCustAcc)

        tender = 0
        returnChange = 0

        gDisplayPole(gAppConfig.MsgWelcome, "")

        Me.remarks = ""
        Me.trackingNo = ""
        Me.billingHandphone = ""
    End Sub

    Private Sub LockItem(ByVal isLock As Boolean)
        LockFields(txtItem, isLock)
    End Sub

    Private Sub LockQty(ByVal isLock As Boolean)
        LockFields(txtQty, isLock)
    End Sub

    Private Sub LockPrice(ByVal isLock As Boolean)
        LockFields(txtPrice, isLock)
    End Sub

    Private Sub LockDiscount(ByVal isLock As Boolean)
        LockFields(txtDisc, isLock)
        LockFields(txtDiscPercentage, isLock)
    End Sub

    Private Sub LockCustAcc(ByVal isLock As Boolean)
        LockFields(txtCustAcc, isLock)
    End Sub

#End Region

#Region " Utility Procedures "

#Region " Tool Strip Item Clicked "

    ' ToolStrip1
    Private Sub FindItemClick(ByVal keywords As String)
        Dim frm As New frmFindItem
        frm.keywoards = keywords
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtItem.Text = frm.itemCode
            txtPrice.Text = FormatCurrency(frm.price)
            txtQty.Focus()
        End If
    End Sub

    Private Sub HoldItemClick()
        If Not HasItems() Then Exit Sub

        Dim frm As New frmRemark
        If Not frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If

        Dim remarks As String = frm.txtRemark.Text.Trim
        Dim obj As New SalesTxn
        obj.CustomerId = txtCustAcc.Text
        obj.SalesId = cboSalesman.SelectedValue
        obj.Remarks = remarks
        obj.ArrDocRow = New ArrayList(arrDocRow.ToArray)
        obj.TotalAmount = GetGrandTotal()
        obj.TxnTime = Now
        arrHold.Add(obj)

        ResetButtonClick()

    End Sub

    Private Sub RecallItemClick()
        If HasItems() Then Exit Sub

        Dim frm As New frmSelectHold

        frm.arrHold = arrHold
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            If frm.index < 0 Then Exit Sub
            objSalesTxn = DirectCast(arrHold.Item(frm.index), SalesTxn)

            'Setup Hold SalesTxn
            arrDocRow.Clear()
            txtCustAcc.Text = objSalesTxn.CustomerId
            cboSalesman.SelectedValue = objSalesTxn.SalesId
            For Each row As DocRow In objSalesTxn.ArrDocRow
                AddItemWithDocRow(row)
                arrDocRow.Add(row)
            Next
        End If

        SetTotal()

    End Sub

    Private Sub DepositItemClick()
        'Messenger.ShowInformation("Under Construction")
        'Exit Sub
        'If HasItems() Then Exit Sub

        Dim frm As New frmDepositList
        frm.objCustAcc = objCustAcc
        frm.objCustUser = objCustUser
        If Not frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If

        If frm.arrDocRow.Count = 0 Then Exit Sub

        arrDeposit.Clear()
        For Each dr As DocRow In frm.arrDocRow
            arrDeposit.Add(dr)
        Next

        SetTotal()
        SetDeposit()

    End Sub

    Private Sub LoadJobsheetItemClick()
        'If HasItems() Then Exit Sub

        Dim frm As New frmFindJobsheet
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            LoadJobsheet(frm.keywoards)
        End If

    End Sub

    Private Sub CashRegisterItemClick()
        Try
            OpenCashDrawer(gSysConfig.CashDrawerCode, gAppConfig.PrinterSetup)

        Catch ex As Exception
            Messenger.Caption = Me.Text & " - Open Cash Drawer"
            Messenger.ShowError(ex.Message)
        End Try
    End Sub

    Private Sub ReportsItemClick()
        If HasItems() Then Exit Sub

        If gLoadPermission(Permission.ViewReport) Then
            ShowMenu(2)
        End If
    End Sub

    Private Sub EndDayClosingClickItem()
        If HasItems() Then Exit Sub

        If arrHold.Count > 0 Then
            Messenger.ShowWarning(gMSG_HELD_ITEMS_DETECTED)
            Exit Sub
        End If

        If Messenger.ShowQuestion("Are you sure?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Dim timeStart As DateTime
        timeStart = gPosEndDayClosingObj.timeStart

        Dim difHour As Double = Format(GetDiffHours(Now, timeStart), "0.00")
        ' check hour
        If difHour < gAppConfig.MinHourEndDayClosing Then
            Messenger.ShowWarning(difHour & " hours: Cannot End Day Closing. Min Hour must be at least " & gAppConfig.MinHourEndDayClosing)
            Exit Sub
        End If

        Dim timeEnd As DateTime = Now
        PrintingFormat.PrintDailySalesReport(gUserObj.userid, timeStart, timeEnd, gSysConfig.PosId, "End Day Closing")

        gPosEndDayClosingObj.timeEnd = timeEnd
        objDA.UpdateEndDayClosing(gPosEndDayClosingObj)

        gPosEndDayClosingObj = objDA.GetEndDayClosing(gBranchObj.pkid, gSysConfig.PosId, gUserObj.userid)

        gCurrentTotalBill = 0
        lblCounter.Text = Format(objDA.GetPosConuter, "000000") & "/" & gCurrentTotalBill

    End Sub

    Private Sub LogoutItemClick()
        If HasItems() Then Exit Sub

        'If Messenger.ShowQuestion(gMSG_LOGOUT, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
        '    Exit Sub
        'End If

        ''Checking the current time
        'If Not gCheckCurrentDateTime() Then Exit Sub

        'Dim rpt As New rptDailySalesReport(gUserObj.userid, gPosEndDayClosingObj.timeStart, Now, gSysConfig.PosId, "DAILY SALES REPORT")
        'gShowReport(rpt)

        'objDA.UpdatePosLogin(gPosLoginObj)

        'Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub ConfigItemClick()
        If HasItems() Then Exit Sub

        If Not gLoadPermission(Permission.Config) Then
            Exit Sub
        End If

        Dim frm As New frmConfig
        frm.ShowDialog()
        frm.Dispose()
    End Sub

    Private Sub PrintItemClick()
        If HasItems() Then Exit Sub

        Dim frm As New frmSelect
        frm.document = "Cashsale"
        If Not objInvoice Is Nothing Then
            frm.pkid = objInvoice.mPkid
        End If

        If Not frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If

        Dim pkid As Long = frm.txtCashSale.Text
        Dim InvoiceObj As DAInvoiceObject = objDA.GetInvoice(pkid)
        If InvoiceObj Is Nothing Then
            Messenger.ShowWarning("The Cashsale '" & pkid & "' does not exist!")
            Exit Sub
        End If

        gPrintCashBill(pkid)

    End Sub

    Private Sub SyncItemClick()
        If HasItems() Then Exit Sub

        If gAppConfig.AutoSynchronize Then
            Messenger.ShowInformation(gMSG_AUTO_SYNC)
            Exit Sub
        End If

        Try
            If gIsSyncProcessing = False Then
                gIsSyncProcessing = True
                gRunThreadWebServiceManually()
            End If

        Catch ex As Exception
            Messenger.Caption = Me.Text & " - Sync Processing Error"
            Messenger.ShowError(ex.Message)
        End Try

    End Sub

    Private Sub BackItemClick()
        ShowMenu(1)
    End Sub

    Private Sub DailySalesReportItemClick()
        Dim frm As New frmDailySalesReport
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim posId As Integer = IIf(frm.txtCounter.Text = "", 0, frm.txtCounter.Text)
            PrintingFormat.PrintDailySalesReport(frm.cboUser.SelectedValue, frm.dtpDateFrom.Value, frm.dtpDateTo.Value, posId)
        End If
        frm.Dispose()
    End Sub

    Private Sub HourlySalesReportItemClick()
        Dim frm As New frmHourlySalesReport
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim posId As Integer = IIf(frm.txtCounter.Text = "", 0, frm.txtCounter.Text)
            gShowReport(New rptHourlySalesReport(frm.cboUser.SelectedValue, frm.dtpDateFrom.Value, posId), False)
        End If
    End Sub

    Private Sub DetailedVoidReportItemClick()
        Dim frm As New frmVoidDetailReport
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim posId As Integer = IIf(frm.txtCounter.Text = "", 0, frm.txtCounter.Text)
            gShowReport(New rptVoidReport(frm.cboUser.SelectedValue, frm.dtpDateFrom.Value, frm.dtpDateTo.Value, posId), False)
        End If
    End Sub

    Private Sub VoidReportItemClick()
        Dim frm As New frmVoidReport
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim posId As Integer = IIf(frm.txtCounter.Text = "", 0, frm.txtCounter.Text)
            gShowReport(New rptVoidDetailReport(frm.cboUser.SelectedValue, frm.dtpDateFrom.Value, frm.dtpDateTo.Value, posId), False)
        End If
    End Sub

    Private Sub ReceiptListingItemClick()
        Dim frm As New frmReceiptListing
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim posId As Integer = IIf(frm.txtCounter.Text = "", 0, frm.txtCounter.Text)
            gShowReport(New rptReceiptListing(frm.cboUser.SelectedValue, frm.dtpDateFrom.Value, frm.dtpDateTo.Value, posId), False)
        End If
    End Sub

    Private Sub SummaryStockSoldItemClick()
        Dim frm As New frmSummaryStockSold
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim posId As Integer = IIf(frm.txtCounter.Text = "", 0, frm.txtCounter.Text)
            'gShowReport(New rptSummaryStockSold(frm.cboUser.SelectedValue, frm.dtpDateFrom.Value, frm.dtpDateTo.Value, posId), False)
            PrintingFormat.PrintStockSummarySoldReport(frm.cboUser.SelectedValue, frm.dtpDateFrom.Value, frm.dtpDateTo.Value, posId)
        End If
    End Sub

#End Region

#Region " Button Clicked "

    Private Sub SearchCustAccountButtonClick()
        If Not gLoadPermission(Permission.CustAccount) Then Exit Sub

        Dim frm As New frmFindCustAcc
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            SetCustAcc(frm.keywoards)
        End If

    End Sub

    Private Sub SearchCustomerButtonClick()

        Dim frm As New frmFindCustUser
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            SetCustUser(frm.keywoards)
        End If

    End Sub

    Private Sub SearchMemberButtonClick()
        Messenger.ShowInformation("Under Construction")
    End Sub

    Private Sub ZeroButtonClick()
        SetTextBoxValue(textBoxFocused, "0")
    End Sub

    Private Sub OneButtonClick()
        SetTextBoxValue(textBoxFocused, "1")
    End Sub

    Private Sub TwoButtonClick()
        SetTextBoxValue(textBoxFocused, "2")
    End Sub

    Private Sub ThreeButtonClick()
        SetTextBoxValue(textBoxFocused, "3")
    End Sub

    Private Sub FourButtonClick()
        SetTextBoxValue(textBoxFocused, "4")
    End Sub

    Private Sub FiveButtonClick()
        SetTextBoxValue(textBoxFocused, "5")
    End Sub

    Private Sub SixButtonClick()
        SetTextBoxValue(textBoxFocused, "6")
    End Sub

    Private Sub SevenButtonClick()
        SetTextBoxValue(textBoxFocused, "7")
    End Sub

    Private Sub EightButtonClick()
        SetTextBoxValue(textBoxFocused, "8")
    End Sub

    Private Sub NineButtonClick()
        SetTextBoxValue(textBoxFocused, "9")
    End Sub

    Private Sub DotButtonClick()
        SetTextBoxValue(textBoxFocused, ".")
    End Sub

    Private Sub BackSpaceButtonClick()
        SetTextBoxValue(textBoxFocused, "backspace")
    End Sub

    Private Sub AddButtonClick()
        If itemEditMode Then
            UpdateItem()
        Else
            AddItem()
        End If
        txtItem.Focus()
    End Sub

    Private Sub CashButtonClick()
        If Not HasItems() Then Exit Sub

        If Saving = True Then Exit Sub
        Saving = True

        gDisplayPole("AMOUNT:", FormatCurrency(lblTotalAmt.Text))
        Dim frm As New frmPaymentCash
        frm.total = GetGrandTotal()
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            objReceipt = New DAOfficialReceiptObject
            If frm.total > 0 Then
                objReceipt.amountCash = frm.total
                objReceipt.amount = objReceipt.amountCash
                objReceipt.paymentMethod = "CASH"
            End If
            Me.tender = Convert.ToDecimal(frm.txtTender.Text)
            Me.returnChange = Convert.ToDecimal(frm.txtChange.Text)

            objReceipt.cashNotesReceived = tender
            objReceipt.cashNotesChange = returnChange

            SaveTxn()
        End If

        If Not objSalesTxn Is Nothing Then
            arrHold.Remove(objSalesTxn)
        End If

        Saving = False

    End Sub

    Private Sub DeleteButtonClick()
        If frmMode = FormMode.CASHSALE_VIEW Then
            CancelInvoice()
        Else
            DeleteItem()
        End If
    End Sub

    Private Sub EditButtonClick()
        EditItem()
    End Sub

    Private Sub CashInOutButtonClick()
        If HasItems() AndAlso frmMode = FormMode.MAIN Then Exit Sub

        Select Case frmMode
            Case FormMode.MAIN
                If gLoadPermission(Permission.CashInOut) Then
                    Dim frm As New frmCashInOut
                    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        Dim pkid As Integer = 0
                        InsertCashInOut(frm.txtTotal.Text.Trim, frm.txtRemarks.Text, frm.cboType.Text, pkid)
                        gShowReport(New rptCashInOut(pkid), True)
                    End If
                End If

            Case FormMode.CASHSALE_VIEW
                LoadInvoice(objInvoice.mPkid - 1)

        End Select

    End Sub

    Private Sub OtherPaymentsButtonClick()
        If Not HasItems() AndAlso frmMode = FormMode.MAIN Then Exit Sub

        Select Case frmMode
            Case FormMode.MAIN
                If Not gLoadPermission(Permission.OtherPayment) Then Exit Sub

                gDisplayPole("AMOUNT:", lblTotalAmt.Text)
                Dim frm As New frmPayments
                frm.total = GetGrandTotal()
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    objReceipt = frm.objReceipt
                    SaveTxn()
                End If

            Case FormMode.CASHSALE_VIEW
                LoadInvoice(objInvoice.mPkid + 1)

        End Select

    End Sub

    Private Sub SalesHistoryButtonClick()
        If HasItems() AndAlso frmMode = FormMode.MAIN Then Exit Sub

        If Not gLoadPermission(Permission.SaleHistory) Then Exit Sub

        Dim frm As New frmSelect
        frm.document = "Cashsale"
        If Not objInvoice Is Nothing Then
            frm.pkid = objInvoice.mPkid
        End If

        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            LoadInvoice(frm.txtCashSale.Text)
        End If

    End Sub

    Private Sub ResetButtonClick()
        If frmMode = FormMode.CASHSALE_VIEW Then
            ShowViewCashSaleMenu(0, False)
        Else
            If Not gLoadPermission(Permission.Reset) Then Exit Sub

            ClearControls()
        End If
    End Sub

    Private Sub KeyboardButtonClick()
        System.Diagnostics.Process.Start("osk")
    End Sub

    Private Sub FOCButtonClick()

        If Not gLoadPermission(Permission.FOC) Then Exit Sub

        Dim frm As New frmFOCItem

        If Not frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If

        Dim itemCode As String = frm.txtItem.Text.Trim
        If itemCode = "" Then Exit Sub

        Dim qty As Integer = frm.txtQty.Text.Trim
        Dim remarks As String = frm.txtRemarks.Text.Trim

        Dim objDocRow As New DocRow
        Try

            objDocRow = objDA.GetItemDocRow(itemCode, gBranchObj.invLocationId)
            If objDocRow Is Nothing Then
                'Messenger.ShowInformation(gMSG_ITEM_NOT_FOUND)
                FindItemClick(itemCode)
                objDocRow = objDA.GetItemDocRow(txtItem.Text, gBranchObj.invLocationId)
            End If

            objDocRow.qty = qty
            objDocRow.remarks = cboSalesman.Text & " - " & remarks
            objDocRow.price = 0
            objDocRow.itemType = DocRow.TYPE_FOC

            AddItemWithDocRow(objDocRow)

            ' add to ArrayList DocRow
            arrDocRow.Add(objDocRow)

            SetTotal()
            ClearAddItemFields()

        Catch ex As Exception
            Messenger.Caption = Me.Text & " - Add FOC Item Error"
            Messenger.ShowError(ex.Message)
        End Try
    End Sub

    Private Sub GoodsExchangeButtonClick()

        If Not gLoadPermission(Permission.GoodsExchange) Then Exit Sub

        Dim frm As New frmGoodsExchange

        If Not frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If

        Dim itemCode As String = frm.txtItem.Text.Trim
        If itemCode = "" Then Exit Sub

        Dim qty As Integer = frm.txtQty.Text.Trim
        Dim remarks As String = frm.txtRemarks.Text.Trim
        Dim price As Decimal = frm.txtPrice.Text.Trim

        Dim objDocRow As New DocRow
        Try

            objDocRow = objDA.GetItemDocRow(itemCode, gBranchObj.invLocationId)
            If objDocRow Is Nothing Then
                'Messenger.ShowInformation(gMSG_ITEM_NOT_FOUND)
                FindItemClick(itemCode)
                objDocRow = objDA.GetItemDocRow(txtItem.Text, gBranchObj.invLocationId)
            End If

            objDocRow.qty = Decimal.Negate(qty)
            objDocRow.remarks = cboSalesman.Text & " - " & remarks
            If price > 0 Then objDocRow.price = price
            objDocRow.itemType = DocRow.TYPE_GOODS_EXCHANGE

            If GetGrandTotal() < Decimal.Negate(objDocRow.GetAmount) Then
                Messenger.ShowInformation(gMSG_EXCHANGE_ITEM_PIRCE)
                Exit Sub
            End If

            AddItemWithDocRow(objDocRow)

            ' add to ArrayList DocRow
            arrDocRow.Add(objDocRow)

            SetTotal()
            ClearAddItemFields()

        Catch ex As Exception
            Messenger.Caption = Me.Text & " - Add Goods Exchange Error"
            Messenger.ShowError(ex.Message)
        End Try

    End Sub


    Private Sub SalespersonButtonClick()

        If Not gLoadPermission(Permission.Salesperson) Then Exit Sub

        Try
            cboSalesman.Text = txtItem.Text.Trim
            AutoCompleteCombo_Leave(cboSalesman)
            txtItem.Clear()

        Catch ex As Exception
            Messenger.Caption = Me.Text & " - Add Salesperson Error"
            Messenger.ShowError(ex.Message)
        End Try

    End Sub

#End Region

    Private Sub SetCustAcc(ByVal pkid As Integer)

        If pkid = 0 Then
            SetCustAcc(defaultCustAcc)
            Exit Sub
        End If

        Dim obj As New DACustAccountObject
        obj = objDA.GetCustAccount(pkid)

        If obj Is Nothing Then
            Messenger.ShowWarning("The Customer Account '" & pkid & "' does not exist!")
            txtCustAcc.Focus()
            'If Not pkid = defaultCustAcc Then SetCustAcc(defaultCustAcc)
        Else
            objCustAcc = obj
        End If

        lblShowCustomerAccount.Text = objCustAcc.name
        txtCustAcc.Text = objCustAcc.pkid

        txtCustAcc.SelectAll()

    End Sub

    Private Sub SetCustUser(ByVal pkid As Integer)
        If pkid = 0 Then
            objCustUser = New DACustUserObject
            lblShowCustomer.Text = ""
            txtCustomer.Text = ""
            Exit Sub
        End If

        Dim obj As New DACustUserObject
        obj = objDA.GetCustUser(pkid)

        If obj Is Nothing Then
            Messenger.ShowWarning("The Customer '" & pkid & "' does not exist!")
            txtCustomer.Focus()
        Else
            objCustUser = obj
            SetCustAcc(objCustUser.accId)
        End If

        If Not objCustUser.pkid = 0 Then
            lblShowCustomer.Text = objCustUser.GetName
            If objCustUser.mobilePhone <> "" Then lblShowCustomer.Text &= " Contact: " & objCustUser.mobilePhone

            txtCustomer.Text = objCustUser.pkid
        End If

        txtCustomer.SelectAll()

    End Sub

    Public Sub SetDeposit()

        Dim strValue As String = ""

        For Each dr As DocRow In arrDeposit
            strValue &= dr.refKey & " " & gBranchObj.currency & FormatCurrency(dr.price) & ","
        Next

        If strValue.LastIndexOf(",") > 0 Then
            strValue = strValue.Remove(strValue.Length - 1, 1)
        End If

        lblShowDeposit.Text = strValue

    End Sub


    Public Sub SetTotalAll(ByRef qty As Integer, ByRef amount As Decimal, _
                                    ByRef taxAmount As Decimal, ByRef deposit As Decimal, ByRef grandTotal As Decimal)

        qty = 0
        amount = 0
        deposit = 0
        For Each item As DocRow In arrDocRow
            qty += item.qty
            amount += item.GetAmount
            taxAmount += item.GetTaxAmount
        Next

        deposit = GetTotalDeposit()

        If gAppConfig.PriceIncludeTax Then
            grandTotal = amount - deposit
        Else
            grandTotal = amount + taxAmount - deposit
        End If

    End Sub

    Public Function GetTotalQty() As Integer

        Dim qty As Integer = 0
        For Each item As DocRow In arrDocRow
            qty += item.qty
        Next

        Return qty

    End Function

    Public Function GetTotalAmount() As Decimal

        Dim amt As Decimal = 0
        For Each item As DocRow In arrDocRow
            amt += item.GetAmount
        Next

        Return amt

    End Function

    Public Function GetTotalTaxAmount() As Decimal

        Dim amt As Decimal = 0
        For Each item As DocRow In arrDocRow
            amt += item.GetTaxAmount
        Next

        Return amt

    End Function

    Public Function GetTotalDeposit() As Decimal

        Dim amt As Decimal = 0
        For Each dr As DocRow In arrDeposit
            amt += dr.price
        Next

        Return amt

    End Function

    Public Function GetGrandTotal() As Decimal
        If gAppConfig.PriceIncludeTax Then
            Return GetTotalAmount() - GetTotalDeposit()
        Else
            Return GetTotalAmount() + GetTotalTaxAmount() - GetTotalDeposit()
        End If
    End Function

    Public Function GetInvoiceTotal() As Decimal
        If gAppConfig.PriceIncludeTax Then
            Return GetTotalAmount()
        Else
            Return GetTotalAmount() + GetTotalTaxAmount()
        End If
    End Function

    Public Sub SetTotal()

        Dim qty, amount, taxAmount, deposit, grandTotal As Decimal
        SetTotalAll(qty, amount, taxAmount, deposit, grandTotal)

        ' Apply Five Cent
        If gAppConfig.ApplyFiveCentConcept AndAlso gAppConfig.FiveCentItemCode.Trim <> "" Then

            For Each item As DocRow In arrDocRow
                If item.itemType = DocRow.TYPE_FIVE_CENT_ITEM Then
                    grandTotal = Decimal.Subtract(grandTotal, item.GetAmount)
                End If
            Next

            '2. Remove Five Cent item
            Dim dr As DocRow = Nothing
            For Each item As GlacialComponents.Controls.GLItem In GlacialList1.Items
                dr = DirectCast(item.Tag, DocRow)
                If dr.itemType = DocRow.TYPE_FIVE_CENT_ITEM Then
                    GlacialList1.Items.Remove(item)
                    arrDocRow.Remove(dr)
                    Exit For
                End If
            Next
            GlacialList1.Refresh()

            '3. If got rounding five cent 
            Dim amt As Decimal
            amt = Rounding5Cent(grandTotal)
            amt = Decimal.Subtract(amt, Convert.ToDecimal(FormatCurrency(grandTotal)))

            If Convert.ToDecimal(amt) <> 0 Then
                '4. Create new Five Cent DocRow 
                Dim objDocRow As DocRow = objDA.GetItemDocRow(gAppConfig.FiveCentItemCode, gBranchObj.invLocationId)
                objDocRow.qty = 1
                objDocRow.price = amt
                objDocRow.remarks = cboSalesman.Text
                objDocRow.itemType = DocRow.TYPE_FIVE_CENT_ITEM

                AddItemWithDocRow(objDocRow)

                arrDocRow.Add(objDocRow)
            End If
        End If

        '5. Get Total Amount Again
        SetTotalAll(qty, amount, taxAmount, deposit, grandTotal)
        lblSubTotalAmt.Text = FormatCurrency(amount)
        lblTotalIncludeTaxAmt.Text = FormatCurrency(taxAmount)
        lblTotalDepositAmt.Text = FormatCurrency(deposit)
        lblTotalAmt.Text = FormatCurrency(amount - deposit)
        lblTotalQtyAmt.Text = FormatInt(qty)

        lblTotalExcludeTaxAmt.Text = FormatCurrency(taxAmount)
        lblGrandTotalAmt.Text = FormatCurrency(grandTotal)

    End Sub


    Private Sub AddItemWithDocRow(ByVal objDocRow As DocRow)
        If objDocRow.isDeleted Then Exit Sub

        Dim item As New GlacialComponents.Controls.GLItem
        Dim subitem1 As New GlacialComponents.Controls.GLSubItem
        Dim subitem2 As New GlacialComponents.Controls.GLSubItem
        Dim subitem3 As New GlacialComponents.Controls.GLSubItem
        Dim subitem4 As New GlacialComponents.Controls.GLSubItem
        Dim subitem5 As New GlacialComponents.Controls.GLSubItem

        Dim sn As String = Utils.General.GetCSV(objDocRow.arrSerials)
        If sn.Length > 0 Then sn = "SN: " & sn

        item.Text = GlacialList1.Count + 1
        subitem1.Text = objDocRow.itemCode & vbCrLf & objDocRow.itemName & " (" & objDocRow.remarks & ") " & sn
        subitem2.Text = objDocRow.qty
        subitem3.Text = FormatCurrencyNoComma(objDocRow.GetPriceStd)
        subitem4.Text = FormatCurrencyNoComma(objDocRow.discount)
        subitem5.Text = FormatCurrencyNoComma(objDocRow.GetAmount)

        item.Tag = objDocRow
        item.SubItems.AddRange(New GlacialComponents.Controls.GLSubItem() {subitem1, subitem2, subitem3, subitem4, subitem5})

        If objDocRow.GetNetPrice < objDocRow.unitCostMA Then
            item.ForeColor = Color.Red
        End If

        GlacialList1.Items.Add(item)
        GlacialList1.Refresh()

        Dim count As Integer = GlacialList1.Items.Count
        GlacialList1.Items(count - 1).Selected = True

    End Sub

    Private Sub UpdateItemWithDocRow(ByVal objDocRow As DocRow)
        If GlacialList1.SelectedItems.Count = 0 Then Exit Sub

        Dim item As New GlacialComponents.Controls.GLItem
        item = GlacialList1.SelectedItems(0)

        Dim sn As String = Utils.General.GetCSV(objDocRow.arrSerials)
        If sn.Length > 0 Then sn = "SN: " & sn

        item.SubItems(1).Text = objDocRow.itemCode & vbCrLf & objDocRow.itemName & " (" & objDocRow.remarks & ") " & sn
        item.SubItems(2).Text = objDocRow.qty
        item.SubItems(3).Text = FormatCurrencyNoComma(objDocRow.GetPriceStd)
        item.SubItems(4).Text = FormatCurrencyNoComma(objDocRow.discount)
        item.SubItems(5).Text = FormatCurrencyNoComma(objDocRow.GetAmount)

        item.Tag = objDocRow

        GlacialList1.Refresh()

        gDisplayPole(objDocRow.itemName, FormatCurrency(objDocRow.GetAmount))
    End Sub

    Private Sub RemoveItem()
        If GlacialList1.SelectedItems.Count = 0 Then Exit Sub

        Dim item As New GlacialComponents.Controls.GLItem
        item = GlacialList1.SelectedItems(0)

        Dim index As Integer = item.Text
        GlacialList1.Items.Remove(item)

        For i As Integer = index - 1 To GlacialList1.Count - 1
            GlacialList1.Items(i).Text = i + 1
        Next

        GlacialList1.Refresh()
    End Sub


    Private Function HasItems() As Boolean
        Dim result As Boolean
        result = (arrDocRow.Count > 0)

        'If result Then
        '    Messenger.ShowInformation(gMSG_TRANSACTION_EXIST)
        'Else
        '    Messenger.ShowInformation(gMSG_TRANSACTION_NOT_EXIST)
        'End If

        Return result

    End Function

#End Region

#Region " Event Handler/Response "

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        Dim item As ToolStripItem = e.ClickedItem

        Try

            Select Case item.Name
                Case "tbFindItem"
                    FindItemClick("")
                Case "tbHold"
                    HoldItemClick()
                Case "tbRecall"
                    RecallItemClick()
                Case "tbDeposit"
                    DepositItemClick()
                Case "tbCashRegister"
                    CashRegisterItemClick()
                Case "tbLoadJobsheet"
                    LoadJobsheetItemClick()
                Case "tbReports"
                    ReportsItemClick()
                Case "tbEndDayClosing"
                    EndDayClosingClickItem()
                Case "tbLogout"
                    LogoutItemClick()
                Case "tbConfig"
                    ConfigItemClick()
                Case "tbBack"
                    BackItemClick()
                Case "tbDailySalesReport"
                    DailySalesReportItemClick()
                Case "tbHourlySalesReport"
                    HourlySalesReportItemClick()
                Case "tbDetailedVoidReport"
                    DetailedVoidReportItemClick()
                Case "tbVoidReport"
                    VoidReportItemClick()
                Case "tbReceiptListing"
                    ReceiptListingItemClick()
                Case "tbSummaryStockSoldReport"
                    SummaryStockSoldItemClick()
                Case "tbPrint"
                    PrintItemClick()
                Case "tbSync"
                    SyncItemClick()
            End Select

        Catch ex As Exception
            Messenger.Caption = Me.Text & " - " & sender.name & " Error"
            Messenger.ShowError(ex.Message)
        End Try

    End Sub

    Private Sub mnuTools_DropDownItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles mnuTools.DropDownItemClicked
        Dim item As ToolStripItem
        item = e.ClickedItem

        Try

            Select Case item.Name
                Case "mnuF1"
                    Select Case mnuMode
                        Case MenuMode.MAIN
                            FindItemClick("")
                        Case MenuMode.REPORT
                            BackItemClick()
                        Case MenuMode.MORE
                            BackItemClick()
                    End Select

                Case "mnuF2"
                    Select Case mnuMode
                        Case MenuMode.MAIN
                            HoldItemClick()
                        Case MenuMode.REPORT
                            DailySalesReportItemClick()
                        Case MenuMode.MORE

                    End Select

                Case "mnuF3"
                    Select Case mnuMode
                        Case MenuMode.MAIN
                            RecallItemClick()
                        Case MenuMode.REPORT
                            HourlySalesReportItemClick()
                        Case MenuMode.MORE

                    End Select

                Case "mnuF4"
                    Select Case mnuMode
                        Case MenuMode.MAIN
                            DepositItemClick()
                        Case MenuMode.REPORT
                            DetailedVoidReportItemClick()
                        Case MenuMode.MORE

                    End Select

                Case "mnuF5"
                    Select Case mnuMode
                        Case MenuMode.MAIN
                            CashRegisterItemClick()
                        Case MenuMode.REPORT
                            VoidReportItemClick()
                        Case MenuMode.MORE

                    End Select

                Case "mnuF6"
                    Select Case mnuMode
                        Case MenuMode.MAIN
                            LoadJobsheetItemClick()
                        Case MenuMode.REPORT
                            ReceiptListingItemClick()
                        Case MenuMode.MORE

                    End Select

                Case "mnuF7"
                    Select Case mnuMode
                        Case MenuMode.MAIN
                            ReportsItemClick()
                        Case MenuMode.REPORT
                            SummaryStockSoldItemClick()
                        Case MenuMode.MORE

                    End Select

                Case "mnuF8"
                    Select Case mnuMode
                        Case MenuMode.MAIN
                            EndDayClosingClickItem()
                        Case MenuMode.REPORT

                        Case MenuMode.MORE

                    End Select

                Case "mnuF9"
                    Select Case mnuMode
                        Case MenuMode.MAIN
                            LogoutItemClick()
                        Case MenuMode.REPORT

                        Case MenuMode.MORE

                    End Select

                Case "mnuF10"
                    Select Case mnuMode
                        Case MenuMode.MAIN
                            ConfigItemClick()
                        Case MenuMode.REPORT

                        Case MenuMode.MORE

                    End Select

                Case "mnuF11"
                    Select Case mnuMode
                        Case MenuMode.MAIN
                            PrintItemClick()
                        Case MenuMode.REPORT

                        Case MenuMode.MORE

                    End Select

                Case "mnuF12"
                    Select Case mnuMode
                        Case MenuMode.MAIN
                            SyncItemClick()
                        Case MenuMode.REPORT

                        Case MenuMode.MORE

                    End Select
            End Select

            txtItem.Focus()

        Catch ex As Exception
            Messenger.Caption = Me.Text & " - " & sender.name & " Error "
            Messenger.ShowError(ex.Message)
        End Try

    End Sub

    Private Sub mnuKey_DropDownItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles mnuKey.DropDownItemClicked
        Dim item As ToolStripItem = e.ClickedItem

        Try
            Select Case item.Name
                Case "mnuItemCode"
                    txtItem.Focus()
                Case "mnuQty"
                    txtQty.Focus()
                Case "mnuPrice"
                    If Not gLoadPermission(Permission.EditPrice) Then Exit Sub
                    LockPrice(False)
                    txtPrice.Focus()
                Case "mnuDisc"
                    If Not gLoadPermission(Permission.GiveDiscount) Then Exit Sub
                    LockDiscount(False)
                    txtDiscPercentage.Focus()
                Case "mnuDisc1"
                    If Not gLoadPermission(Permission.GiveDiscount) Then Exit Sub
                    LockDiscount(False)
                    txtDisc.Focus()
                Case "mnuCustAcc"
                    txtCustAcc.Focus()
                Case "mnuCustUser"
                    txtCustomer.Focus()
                Case "mnuMember"
                    txtMemberCard.Focus()
                Case "mnuSalesman"
                    cboSalesman.Focus()
                Case "mnuDelete"
                    btnDelete.PerformClick()
            End Select

            'txtItem.Focus()

        Catch ex As Exception
            Messenger.Caption = Me.Text & " - " & sender.name & " Error "
            Messenger.ShowError(ex.Message)
        End Try

    End Sub

    Private Sub ButtonClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim btn As Button = DirectCast(sender, Button)

        Try

            Select Case sender.name
                Case "btnSearchCustAcc"
                    SearchCustAccountButtonClick()
                    txtItem.Focus()
                Case "btnSearchCustomer"
                    SearchCustomerButtonClick()
                    txtItem.Focus()
                Case "btnSearchMember"
                    SearchMemberButtonClick()
                    txtItem.Focus()
                Case "btn0"
                    ZeroButtonClick()
                Case "btn1"
                    OneButtonClick()
                Case "btn2"
                    TwoButtonClick()
                Case "btn3"
                    ThreeButtonClick()
                Case "btn4"
                    FourButtonClick()
                Case "btn5"
                    FiveButtonClick()
                Case "btn6"
                    SixButtonClick()
                Case "btn7"
                    SevenButtonClick()
                Case "btn8"
                    EightButtonClick()
                Case "btn9"
                    NineButtonClick()
                Case "btnDot"
                    DotButtonClick()
                Case "btnBackspace"
                    BackSpaceButtonClick()
                Case "btnAdd"
                    AddButtonClick()
                    txtItem.Focus()
                Case "btnCash"
                    CashButtonClick()
                    txtItem.Focus()
                Case "btnCashInOut"
                    CashInOutButtonClick()
                    txtItem.Focus()
                Case "btnDelete"
                    DeleteButtonClick()
                    txtItem.Focus()
                Case "btnEdit"
                    EditButtonClick()
                    txtItem.Focus()
                Case "btnPayment"
                    OtherPaymentsButtonClick()
                    txtItem.Focus()
                Case "btnReset"
                    ResetButtonClick()
                    txtItem.Focus()
                Case "btnSaleHistory"
                    SalesHistoryButtonClick()
                    txtItem.Focus()
                Case "btnKeyboard"
                    KeyboardButtonClick()
                Case "btnCustAccount"
                    SearchCustAccountButtonClick()
                    txtItem.Focus()
                Case "btnCustomer"
                    SearchCustomerButtonClick()
                    txtItem.Focus()
                Case "btnFOC"
                    FOCButtonClick()
                Case "btnGoodsExchange"
                    GoodsExchangeButtonClick()
                Case "btnSalesperson"
                    SalespersonButtonClick()
                    txtItem.Focus()
            End Select

            'txtItem.Focus()

        Catch ex As Exception
            Messenger.Caption = Me.Text & " - " & sender.name & " Error "
            Messenger.ShowError(ex.Message)
        End Try

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblShowDate.Text = GetNow()

        If gConnectWS Then
            Me.picConnect.Image = imgConnected
            Me.ToolTip1.SetToolTip(Me.picConnect, "Connected.")
            Me.tbSync.Enabled = Not gIsSyncProcessing
        Else
            Me.picConnect.Image = imgDisConnected
            Me.ToolTip1.SetToolTip(Me.picConnect, "Disconnected.")
            Me.tbSync.Enabled = False
        End If

    End Sub

    Private Sub TextIntegerKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        TextKeyPress(sender, e)
        e.Handled = Utils.General.KeyPress("0123456789", True, e)
    End Sub

    Private Sub TextDecimalKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        TextKeyPress(sender, e)
        e.Handled = KeyPressDecimal(sender, e)
    End Sub

    Private Sub TextDecimalLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        'Dim txt As TextBox = DirectCast(sender, TextBox)
        'txt.Text = FormatCurrency(txt.Text)
    End Sub

    Private Sub TextKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'if (e.KeyChar == (Char)Keys.Delete)
        Dim txt As TextBox = sender
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                AddButtonClick()
            Case Convert.ToChar("+")
                CashButtonClick()
                e.Handled = True
                txt.Text = ""
            Case Convert.ToChar(Keys.Escape)
                ClearAddItemFields()
        End Select
        e.Handled = Utils.General.KeyPress("=""", False, e)
    End Sub

    Private Sub txtCustAcc_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCustAcc.Leave
        If txtCustAcc.Text.Trim = "" Then Exit Sub

        SetCustAcc(txtCustAcc.Text)
    End Sub

    Private Sub txtCustomer_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCustomer.Leave
        If txtCustomer.Text.Trim = "" Then Exit Sub

        SetCustUser(txtCustomer.Text)
    End Sub

    Private Sub txtItem_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtItem.TextChanged
        txtItem.Text = txtItem.Text.ToUpper
        txtItem.SelectionStart = txtItem.Text.Length
    End Sub

    Private Sub GlacialList1_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GlacialList1.SizeChanged

        Dim totalSize As Integer = GlacialList1.Size.Width
        Dim totalColSize As Integer = 0

        For Each col As GlacialComponents.Controls.GLColumn In GlacialList1.Columns
            If Not col.Name = "colItem" Then
                totalColSize += col.Width
            End If
        Next

        GlacialList1.Columns("colItem").Width = totalSize - totalColSize
    End Sub

    Private Sub TextClick(ByVal sender As Object, ByVal e As System.EventArgs)
        textBoxFocused = DirectCast(sender, TextBox)
        textBoxFocused.SelectAll()
    End Sub

    Private Sub TextEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        textBoxFocused = DirectCast(sender, TextBox)
        textBoxFocused.SelectAll()
    End Sub

    Private Sub lnkDetails_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkDetails.LinkClicked
        Dim frm As New frmDetails
        frm.txtTrackingNo.Text = Me.trackingNo
        frm.txtBilingHandphone.Text = Me.billingHandphone
        frm.txtRemark.Text = Me.remarks
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.trackingNo = frm.txtTrackingNo.Text.Trim
            Me.billingHandphone = frm.txtBilingHandphone.Text.Trim
            Me.remarks = frm.txtRemark.Text.Trim
        End If
    End Sub

    Private Sub lnkItemDetails_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkItemDetails.LinkClicked
        If Not itemEditMode Then Exit Sub

        Dim frm As New frmItemDetails
        frm.objDocRow = objDocRow

        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            objDocRow.itemName = frm.txtName.Text.Trim
            objDocRow.remarks = frm.txtRemarks.Text.Trim
            objDocRow.taxCode = frm.cboTaxCode.Text
            objDocRow.taxType = frm.txtTaxType.Text
            objDocRow.taxRate = Decimal.ToDouble(frm.txtTaxRate.Text) / 100
        End If

    End Sub

    Private Sub cboSalesman_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSalesman.KeyUp
        Utils.General.AutoCompleteCombo_KeyUp(cboSalesman, e)
    End Sub

    Private Sub cboSalesman_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSalesman.Leave
        AutoCompleteCombo_Leave(cboSalesman)
    End Sub

    Private Sub txtPrice_Leave(sender As Object, e As EventArgs) Handles txtPrice.Leave
        LockPrice(Not gHasPermission(Permission.EditPrice))
    End Sub

    Private Sub txtDisc_Leave(sender As Object, e As EventArgs) Handles txtDisc.Leave, txtDiscPercentage.Leave
        LockDiscount(Not gHasPermission(Permission.GiveDiscount))
    End Sub

#End Region

End Class