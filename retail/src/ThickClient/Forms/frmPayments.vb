
Imports Utils
Imports Utils.General
Imports DataAccess

Public Class frmPayments


#Region " Variable Declarations "

    Public Enum PaymentMode
        Card
        Voucher
        Cheque
        Others
        Cash
    End Enum

    Private FORMTITLE As String = "Other Payments"

    Public total As Decimal = 0
    Private payMode As PaymentMode
    Private payAmt As Decimal

    Public objReceipt As DAOfficialReceiptObject
    Public canSave As Boolean = True

    Public Enum FormMode
        MAIN
        DEPOSIT
    End Enum

    Public frmMode As FormMode

#End Region

#Region " Initialisation "

    Private Sub frmOtherPayments_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        gStopScreenKeyboard()
    End Sub

    Private Sub frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Initialise()
    End Sub

    Private Sub Initialise()
        AssignValue(gGetLocale(Me.Name, "title"), Me.Text)
        Messenger.Caption = Me.Text
        gSetLocaleChange(Me.Name, Me)

        General.CursorButtons(Me, Cursors.Hand)

        SetupDefaultControls()

        SetEventHanlder()

        If objReceipt Is Nothing Then objReceipt = New DAOfficialReceiptObject

        btnVisa.PerformClick()
        txtCardParticulars.Focus()
    End Sub

    Private Sub SetupDefaultControls()
        ClearFields(Me)

        lblTotalAmount.Text = gBranchObj.currency & " " & FormatCurrency(total)
        
        ClearControls()
        btnConfirm.Enabled = False

        Load_cboMonth()
        Load_cboYear()

    End Sub

    Private Sub SetEventHanlder()

        AddHandler btnVisa.Click, AddressOf ButtonClick
        AddHandler btnMaster.Click, AddressOf ButtonClick
        AddHandler btnAmex.Click, AddressOf ButtonClick
        AddHandler btnCUP.Click, AddressOf ButtonClick
        AddHandler btnJCB.Click, AddressOf ButtonClick
        AddHandler btnNets.Click, AddressOf ButtonClick
        AddHandler btnVoucher.Click, AddressOf ButtonClick
        AddHandler btnCheque.Click, AddressOf ButtonClick
        AddHandler btnOthers.Click, AddressOf ButtonClick
        AddHandler btnCash.Click, AddressOf ButtonClick

        AddHandler txtAmt.KeyPress, AddressOf TextDecimalKeyPress
        AddHandler txtAmtCheque.KeyPress, AddressOf TextDecimalKeyPress
    End Sub

#End Region

#Region " Load Controls - ComboBox, ListView, ListBox, etc "

    Private Sub Load_cboYear()
        cboYear.Items.Clear()
        For i As Integer = 0 To 19
            cboYear.Items.Add(Now.AddYears(i).Year)
        Next
    End Sub

    Private Sub Load_cboMonth()
        cboMonth.Items.Clear()
        For i As Integer = 1 To 12
            cboMonth.Items.Add(MonthName(i))
        Next
    End Sub

#End Region

#Region " Database Updating - Presentation Layer "


#End Region

#Region " Controls Populating, Updating, etc "


    Private Sub ClearControls()
        lblMode.Text = ""
    End Sub

    Private Sub ShowCardFields()
        grpCheque.Visible = False
        grpOthers.Visible = False

        ClearFields(grpCard)
        grpCard.Visible = True
        txtCardParticulars.Focus()
    End Sub

    Private Sub ShowChequeFields()
        grpCard.Visible = False
        grpOthers.Visible = False

        ClearFields(grpCheque)
        grpCheque.Visible = True
        txtAmtCheque.Text = total - GetTotalAmt()
        txtAmtCheque.Focus()
    End Sub

    Private Sub ShowOtherFields(ByVal isCash As Boolean)
        grpCard.Visible = False
        grpCheque.Visible = False

        ClearFields(grpOthers)
        grpOthers.Visible = True

        lblDesc.Visible = Not isCash
        txtDescription.Visible = Not isCash

        txtAmt.Text = total - GetTotalAmt()
        txtAmt.Focus()
    End Sub

#End Region

#Region " Utility Procedures "

    Public Function isMain() As Boolean
        Return frmMode = FormMode.Main
    End Function

    Public Function GetDecimal(ByVal txt As TextBox) As Decimal
        Dim dec As Decimal = 0
        If txt.TextLength > 0 Then
            dec = Convert.ToDecimal(txt.Text)
        End If

        Return dec
    End Function

    Public Function GetTotalAmt() As Decimal
        Dim amt As Decimal = 0
        For Each itm As ListViewItem In ListView1.Items
            amt += itm.SubItems(2).Text
        Next
        Return amt
    End Function

    Public Function IsExistPayment(ByVal payMode As PaymentMode) As Boolean
        For Each itm As ListViewItem In ListView1.Items
            Dim obj As DAOfficialReceiptObject = DirectCast(itm.Tag, DAOfficialReceiptObject)
            If obj.paymentMethod = payMode Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function ValidationCard() As Boolean
        canSave = True
        'If txtCCNo.TextLength < 12 Then
        '    Messenger.ShowWarning("Invalid Credit Card No!")
        '    canSave = False
        'End If

        ''If txtCCName.TextLength < 3 Then
        ''    Messenger.ShowWarning("Invalid Credit Card Name!")
        ''    canSave = False
        ''End If

        'If cboMonth.Text = "" Then
        '    Messenger.ShowWarning("Invalid Credit Card Expiry Month!")
        '    canSave = False
        'End If

        'If cboYear.Text = "" Then
        '    Messenger.ShowWarning("Invalid Credit Card Expiry Year!")
        '    canSave = False
        'End If

        Return canSave
    End Function

#End Region

#Region " Event Handler/Response "

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        If isMain() Then
            If Not gShowMsgTxnConfirm() Then Exit Sub
        End If

        If txtCardParticulars.TextLength > 0 Then
            btnAdd.PerformClick()
        End If

        If Not canSave Then Exit Sub

        'Update Receipt Object
        objReceipt = New DAOfficialReceiptObject
        With objReceipt
            For Each itm As ListViewItem In ListView1.Items
                Dim obj As DAOfficialReceiptObject = DirectCast(itm.Tag, DAOfficialReceiptObject)
                Select Case obj.paymentMethod
                    Case PaymentMode.Card
                        .amountCard = obj.amountCard
                        .cardType = obj.cardType
                        .cardName = obj.cardName
                        .cardBank = obj.cardBank
                        .cardNumber = obj.cardNumber
                        .cardApprovalCode = obj.cardApprovalCode
                        .cardValidThru = obj.cardValidThru
                        .paymentMethod = IIf(.paymentMethod = "", obj.cardType, .paymentMethod & ", " & obj.cardType)

                    Case PaymentMode.Voucher
                        .amountCoupon = obj.amountCoupon
                        .paymentRemarks = obj.paymentRemarks
                        .paymentMethod = IIf(.paymentMethod = "", "VOUCHER", .paymentMethod & ", " & "VOUCHER")

                    Case PaymentMode.Cheque
                        .amountCheque = obj.amountCheque
                        .chequeNumber = obj.chequeNumber
                        .datePDCheque = obj.datePDCheque
                        .paymentMethod = IIf(.paymentMethod = "", "CHEQUE", .paymentMethod & ", " & "CHEQUE")

                    Case PaymentMode.Others
                        .amountOther = obj.amountOther
                        .paymentRemarks = obj.paymentRemarks
                        .paymentMethod = IIf(.paymentMethod = "", "OTHERS", .paymentMethod & ", " & "OTHERS")

                    Case PaymentMode.Cash
                        .amountCash = obj.amountCash
                        .paymentMethod = IIf(.paymentMethod = "", "CASH", .paymentMethod & ", " & "CASH")

                End Select
            Next
            .amount = GetTotalAmt()
        End With


        ' TODO: Need add card payment config charge
        '.cardPctCharges = 
        '.cardSurcharge()
        '.cardId = cardpaymentconfig;

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub picKeyboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picKeyboard.Click
        gShowScreenKeyboard()
    End Sub

    Private Sub ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Select Case sender.name
            Case "btnVisa"
                payMode = PaymentMode.Card
                lblMode.Text = "VISA"
                ShowCardFields()
            Case "btnMaster"
                payMode = PaymentMode.Card
                lblMode.Text = "MASTER"
                ShowCardFields()
            Case "btnAmex"
                payMode = PaymentMode.Card
                lblMode.Text = "AMEX"
                ShowCardFields()
            Case "btnCUP"
                payMode = PaymentMode.Card
                lblMode.Text = "China Union Pay"
                ShowCardFields()
            Case "btnJCB"
                payMode = PaymentMode.Card
                lblMode.Text = "JCB Card"
                ShowCardFields()
            Case "btnNets"
                payMode = PaymentMode.Card
                lblMode.Text = "Nets"
                ShowCardFields()
            Case "btnVoucher"
                payMode = PaymentMode.Voucher
                lblMode.Text = btnVoucher.Text.ToUpper
                ShowOtherFields(False)
            Case "btnCheque"
                payMode = PaymentMode.Cheque
                lblMode.Text = btnCheque.Text.ToUpper
                ShowChequeFields()
            Case "btnOthers"
                payMode = PaymentMode.Others
                lblMode.Text = btnOthers.Text.ToUpper
                ShowOtherFields(False)
            Case "btnCash"
                payMode = PaymentMode.Cash
                lblMode.Text = btnCash.Text.ToUpper
                ShowOtherFields(True)
        End Select

    End Sub

    Private Sub btnCardParticulars_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCardParticulars.Click
        If txtCardParticulars.TextLength > 55 Then
            Dim cc As New Utils.CreditCard(txtCardParticulars.Text.Trim)
            txtCCNo.Text = cc.No
            txtCCName.Text = cc.Name
            cboMonth.Text = MonthName(cc.ExpiryMonth)

            Dim y As String = cboYear.Items(cboYear.Items.Count - 1)
            cboYear.Text = IIf(cc.ExpiryYear > y, y, cc.ExpiryYear)

            'txtCardParticulars.Text = ""

            ValidationCard()
        End If

    End Sub

    Private Sub TextDecimalKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = KeyPressDecimal(sender, e)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If IsExistPayment(payMode) Then
            Messenger.ShowWarning("The Payment Mode already exist!")
            Exit Sub
        End If

        Dim obj As New DAOfficialReceiptObject
        With obj
            .paymentMethod = payMode
            Select Case payMode
                Case PaymentMode.Card
                    payAmt = total - GetTotalAmt()

                    If txtCardParticulars.Text.Length > 0 Then
                        btnCardParticulars.PerformClick()
                    End If

                    If Not ValidationCard() Then Exit Sub

                    .amountCard = payAmt
                    .cardType = lblMode.Text
                    .cardName = txtCCName.Text.Trim
                    .cardBank = txtCCBank.Text.Trim
                    .cardNumber = txtCCNo.Text.Trim
                    .cardApprovalCode = txtCCAppCode.Text.Trim
                    If cboYear.Text.Length > 0 AndAlso cboMonth.Text.Length > 0 Then
                        .cardValidThru = GetLastDayInMonth(cboYear.Text, cboMonth.Text)
                    End If

                Case PaymentMode.Voucher
                    payAmt = txtAmt.Text

                    .amountCoupon = payAmt
                    .paymentRemarks = txtDescription.Text.Trim

                Case PaymentMode.Cheque
                    payAmt = txtAmtCheque.Text

                    .amountCheque = payAmt
                    .chequeNumber = txtChequeNo.Text.Trim
                    .datePDCheque = dtpChequeDate.Value

                Case PaymentMode.Others
                    payAmt = txtAmt.Text

                    .amountOther = payAmt
                    .paymentRemarks = txtDescription.Text.Trim

                Case PaymentMode.Cash
                    payAmt = txtAmt.Text

                    .amountCash = payAmt

            End Select
        End With

        Dim item As New ListViewItem
        item.Text = ListView1.Items.Count + 1
        item.Tag = obj
        item.SubItems.Add(lblMode.Text)
        item.SubItems.Add(FormatCurrency(payAmt))

        ListView1.Items.Add(item)

        btnConfirm.Enabled = GetTotalAmt() = total
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If ListView1.SelectedItems.Count = 0 Then Exit Sub

        ListView1.Items.Remove(ListView1.SelectedItems(0))

        btnConfirm.Enabled = GetTotalAmt() = total
    End Sub

    Private Sub txtCardParticulars_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCardParticulars.KeyPress
        Select e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                btnConfirm.PerformClick()
        End Select
    End Sub

    Private Sub txtCardParticulars_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCardParticulars.TextChanged
        btnConfirm.Enabled = True
    End Sub


#End Region


End Class
