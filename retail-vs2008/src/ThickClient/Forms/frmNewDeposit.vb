
Imports Utils
Imports Utils.General
Imports DataAccess

Public Class frmNewDeposit

#Region " Variable Declarations "

    Private saving As Boolean = False
    Private FORMTITLE As String = "New Deposit"
    Private defaultCustAcc As Integer = 500

    Private objDA As New DataAccessNut
    Private objCustAccount As New DACustAccountObject
    Public objCustUser As New DACustUserObject
    Private objReceiptCash As New DAOfficialReceiptObject
    Private objReceiptOthers As New DAOfficialReceiptObject
    Private paymentCash As Boolean = True

    Private amount As Decimal = 0
    Public canPrint As Boolean = True

    Public pkid As Integer
    Public returnObj As New DAOfficialReceiptObject

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

        SetupDefaultControls()

        SetEventHanlder()

        If pkid > 0 Then SetCustUser(pkid)
    End Sub

    Private Sub SetupDefaultControls()
        ClearControls()

        'LockFields(txtCustName, True)
        'LockFields(txtCustContact, True)
        'LockFields(txtCustIC, True)

        lblTotalCcy.Text = gBranchObj.currency
    End Sub

    Private Sub SetEventHanlder()

    End Sub

#End Region

#Region " Load Controls - ComboBox, ListView, ListBox, etc "


#End Region

#Region " Database Updating - Presentation Layer "

    Private Sub insertDeposit()
        If saving Then Exit Sub
        saving = True

        Dim obj As DAOfficialReceiptObject

        Try
            'If txtCustomerID.Text.Trim.Length = 0 Then
            'InsertCustUser()
            'End If

            'getCustAccount
            SetCustAcc(defaultCustAcc)

            If paymentCash Then
                obj = objReceiptCash
            Else
                obj = objReceiptOthers
            End If

            obj.branch = gBranchObj.pkid
            obj.cbCard = gBranchObj.cashbookCard
            obj.cbCash = gBranchObj.cashbookCash
            obj.cbCheque = gBranchObj.cashbookCheque
            obj.cbCoupon = gBranchObj.cashbookCoupon
            obj.cbOther = gBranchObj.cashbookOther
            obj.cbPDCheque = gBranchObj.cashbookPDCheque
            obj.currency = gBranchObj.currency
            obj.entityKey = objCustAccount.pkid
            obj.entityName = objCustAccount.name
            obj.entityTable = DACustAccount.TABLENAME
            obj.paymentTime = Now
            obj.lastUpdate = Now
            obj.openBalance = txtTotal.Text
            obj.pcCenter = gBranchObj.accPCCenterId
            obj.userIdUpdate = gUserObj.userid
            obj.status = DAOfficialReceipt.STATUS_ACTIVE
            obj.SetPaymentRemarks(txtCustName.Text.Trim, txtCustContact.Text.Trim, txtCustIC.Text.Trim, txtRemarks.Text.Trim)
            obj.posId = gSysConfig.PosId

            If objDA.CreateDeposit(obj) Then
                'SetupDefaultControls()
                If canPrint Then gShowReport(New rptDeposit(obj.pkid), True)

                gShowMsgTxnSucceed(obj.pkid, "DEPOSIT")

                returnObj = obj
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If

        Catch ex As Exception
            Messenger.Caption = FORMTITLE & "- Create New Deposit Error"
            Messenger.ShowError(ex.Message)
        End Try

        saving = False

    End Sub

    Private Sub InsertCustUser()
        Dim obj As New DACustUserObject

        'Try

        With obj
            .nameFirst = txtCustName.Text.Trim
            .mobilePhone = txtCustContact.Text.Trim
            .referenceNo = txtCustIC.Text.Trim
            .useridEdit = gUserObj.userid
            .lastupdate = Now
            .salesman = gUserObj.userid
        End With

        obj.pkid = objDA.InsertCustUser(obj)
        'objCustUser = obj
        'If pkid <> 0 Then
        '    Messenger.ShowInformation("Customer '" & pkid & "' Created!")
        '    Me.DialogResult = Windows.Forms.DialogResult.OK
        '    Me.Close()
        'End If

        'Catch ex As Exception
        '    Messenger.Caption = FORMTITLE & "- ConfirmButtonClick"
        '    Messenger.ShowError("Create New Customer Error!")
        '    WriteToLogFile(ex.Message)
        'End Try

    End Sub

#End Region

#Region " Controls Populating, Updating, etc "


    Private Sub ClearControls()
        objReceiptCash = New DAOfficialReceiptObject
        objReceiptOthers = New DAOfficialReceiptObject

        ClearFields(Me)
        btnConfirm.Enabled = False
        txtTotal.Text = "0.00"
        txtTotal.Focus()
    End Sub

    Private Sub ShowConfirmButton(ByVal paymentAmount As Decimal)

        btnConfirm.Enabled = amount = paymentAmount
    End Sub

#End Region

#Region " Utility Procedures "

    Private Sub SetCustUser(ByVal pkid As Integer)

        objCustUser = objDA.GetCustUser(pkid)
        If objCustUser Is Nothing Then
            Messenger.ShowWarning("The Customer '" & pkid & "' does not exist!")
        Else
            'objCustAccount = objDA.GetCustAccount(objCustUser.accId)
            txtCustomerID.Text = pkid
            txtCustName.Text = objCustUser.GetName
            txtCustContact.Text = objCustUser.mobilePhone
            txtCustIC.Text = objCustUser.referenceNo
        End If

    End Sub

    Private Sub SetCustAcc(ByVal pkid As Integer)
        If pkid = 0 Then
            SetCustAcc(defaultCustAcc)
            Exit Sub
        End If

        Dim obj As New DACustAccountObject
        obj = objDA.GetCustAccount(pkid)

        If obj Is Nothing Then
            Messenger.ShowWarning("The Customer Account '" & pkid & "' does not exist!")
        Else
            objCustAccount = obj
        End If

    End Sub

#End Region

#Region " Event Handler/Response "

    Private Sub txtTotal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotal.KeyPress
        e.Handled = KeyPressDecimal(sender, e)
    End Sub


    Private Sub btnCash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCash.Click
        Dim frm As New frmPaymentCash
        frm.frmMode = frmPaymentCash.FormMode.DEPOSIT
        frm.total = txtTotal.Text
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            objReceiptCash.amountCash = frm.total
            objReceiptCash.amount = objReceiptCash.amountCash
            grpPaymentType.Text = "Payment Type: Cash  Amount: " & FormatCurrency(objReceiptCash.amount)
            paymentCash = True
            ShowConfirmButton(objReceiptCash.amount)
        End If
    End Sub

    Private Sub btnOtherPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOthersPayment.Click
        Dim frm As New frmPayments
        frm.frmMode = frmPaymentCash.FormMode.DEPOSIT
        frm.objReceipt = objReceiptOthers
        frm.total = txtTotal.Text
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            objReceiptOthers = frm.objReceipt
            grpPaymentType.Text = "Payment Type: Others  Amount: " & FormatCurrency(objReceiptOthers.amount)
            paymentCash = False
            ShowConfirmButton(objReceiptOthers.amount)
        End If
    End Sub

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        If Not gShowMsgTxnConfirm() Then Exit Sub
        
        insertDeposit()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnSearchCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchCustomer.Click
        Dim frm As New frmFindCustUser
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            SetCustUser(frm.keywoards)
        End If
    End Sub

    Private Sub txtCustomerID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCustomerID.KeyPress
        e.Handled = Utils.General.KeyPress("0123456789", True, e)
    End Sub

    Private Sub txtCustomerID_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCustomerID.Leave
        If txtCustomerID.Text.Trim = "" Then Exit Sub

        SetCustUser(txtCustomerID.Text)
    End Sub

    Private Sub txtTotal_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTotal.Leave
        If txtTotal.Text = "" Then
            txtTotal.Text = "0.00"
        Else
            amount = txtTotal.Text
            txtTotal.Text = FormatCurrency(amount)
        End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim frm As New frmNewCustomer
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            SetCustUser(frm.pkid)
        End If
    End Sub

#End Region

   
End Class
