
Imports Utils
Imports Utils.General
Imports DataAccess

Public Class frmPaymentVoucher

#Region " Variable Declarations "

    Private FORMTITLE As String = "Deposit Refund"
    Private Saving As Boolean = False

    Public objDA As New DataAccessNut
    Public objCustAcc As New DACustAccountObject
    Public objCustUser As New DACustUserObject
    Private objCashAccount As New DACashAccountObject
    Private objPV As New DAPaymentVoucherObject

    Private arrDocRow As New ArrayList
    Public pkid As Integer = 0
    Public arrDeposit As New ArrayList

    Public Enum FormMode
        MAIN
        JOBSHEET
    End Enum

    Public frmMode As FormMode

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

        SetCashAccount()

        If Not pkid = 0 Then SetCustAcc(pkid)

        If isMain() Then
            For Each dr As DocRow In arrDeposit
                Dim receiptObj As New DAOfficialReceiptObject
                receiptObj = objDA.GetOfficialReceipt(dr.refKey)
                If receiptObj.openBalance > 0 Then
                    AddDocRow(receiptObj, True)
                End If
            Next
        Else
            For Each obj As DAOfficialReceiptObject In arrDeposit
                If obj.openBalance > 0 Then
                    AddDocRow(obj, True)
                End If
            Next
        End If
        SetCreateButton()
    End Sub

    Private Sub SetupDefaultControls()
        ClearFields(Me)

        btnCreate.Enabled = False

        ClearControls()

        GroupBox2.Focus()
        txtCustAcc.Focus()
    End Sub

    Private Sub SetEventHanlder()

        AddHandler btnAdd.Click, AddressOf ButtonClick
        AddHandler btnRemove.Click, AddressOf ButtonClick
        AddHandler btnCreate.Click, AddressOf ButtonClick
        AddHandler btnCancel.Click, AddressOf ButtonClick
        AddHandler btnSearchCustAcc.Click, AddressOf ButtonClick

    End Sub

#End Region

#Region " Load Controls - ComboBox, ListView, ListBox, etc "

   

#End Region

#Region " Database Updating - Presentation Layer "

    Private Function InsertPaymentVoucher() As Boolean

        Try
            Dim guid As String = GetGuid()

            objPV = New DAPaymentVoucherObject
            With objPV
                .pcCenter = gBranchObj.accPCCenterId
                .branch = gBranchObj.pkid
                .currency = gBranchObj.currency
                .amountTotal = GetItemAmount()
                .glCodeCredit = objCashAccount.accountType
                .cashbookOther = objCashAccount.pkId
                .payTo = txtPayTo.Text.Trim
                .remarks = txtRemarks.Text.Trim
                .dateStmt = dtpDate.Value
                .dateCreated = Now
                .dateApproved = Now
                .dateVerified = Now
                .dateUpdate = dtpDate.Value
                .userIdUpdate = gUserObj.userid
                .userIdCreate = gUserObj.userid
                .userIdPIC = gUserObj.userid
            End With

            objPV.arrItems.Clear()
            Dim count As Integer = 0
            For Each dr As DocRow In arrDocRow
                Dim pviObj As New DAPaymentVoucherItemObject(objPV, dr)
                objPV.arrItems.Add(pviObj)
            Next

            If Not objDA.CreatePaymentVoucher(objPV, guid) Then
                Messenger.ShowError("Create Payment Voucher Failed!")
                Return False
            End If

            For Each dr As DocRow In arrDocRow
                'Dim pviObj As New DAPaymentVoucherItemObject(objPV, dr)
                'InsertDocLink(pviObj, dr)

                If dr.refTable = DAOfficialReceipt.TABLENAME Then
                    Dim receiptObj As DAOfficialReceiptObject = DirectCast(dr.tag, DAOfficialReceiptObject)
                    Dim payment As Decimal = dr.price
                    For Each itemObj As DAOfficialReceiptObject In receiptObj.arrItems
                        If itemObj.pkid = receiptObj.pkid Then
                            payment = dr.price
                        Else
                            payment = itemObj.openBalance
                        End If
                        UpdateBalanceReceipt(itemObj, payment, guid)
                    Next
                End If
            Next

            SetupDefaultControls()

            gShowReport(New rptPaymentVoucher(objPV.pkid), True)

            gShowMsgTxnSucceed(objPV.pkid, "PAYMENT VOUCHER")

        Catch ex As Exception
            Messenger.Caption = FORMTITLE & "- Create Payment Voucher Error"
            Messenger.ShowError(ex.Message)
            WriteToLogFile(ex.Message)
            Return False
        End Try
    End Function


    Public Function InsertDocLink(ByVal pviObj As DAPaymentVoucherItemObject, ByVal dr As DocRow) As Boolean

        Try

            Dim obj As New DADocLinkObject
            obj.srcDocRef = DAPaymentVoucherItem.TABLENAME
            obj.srcDocId = pviObj.pkid
            obj.tgtDocRef = dr.refTable
            obj.tgtDocId = dr.refKey
            obj.currency = pviObj.currency
            obj.lastUpdate = Now
            obj.userIdUpdate = gUserObj.userid

            If dr.refTable = DAOfficialReceipt.TABLENAME Then
                obj.name_space = DADocLink.NS_CUSTOMER
                obj.relType = DADocLink.RELTYPE_PYMT_CN
                obj.amount = Decimal.Negate(dr.price)
            End If

            objDA.CreateDocLink(obj)

            Return True

        Catch ex As Exception
            Messenger.Caption = FORMTITLE & "- Create Document Link Error"
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
            Messenger.Caption = FORMTITLE & "- Update Balance Receipt Error"
            Messenger.ShowError(ex.Message)
            Return False
        End Try

    End Function

#End Region

#Region " Controls Populating, Updating, etc "

    Private Sub ClearControls()
        ListView1.Items.Clear()
        arrDocRow.Clear()
        objCustAcc = New DACustAccountObject

        SetAmount()
    End Sub


    Private Sub SetCreateButton()
        btnCreate.Enabled = ListView1.Items.Count > 0 AndAlso txtPayTo.TextLength > 3
    End Sub

#End Region

#Region " Utility Procedures "

    Public Function isMain() As Boolean
        Return frmMode = FormMode.Main
    End Function

    Private Sub SetCustAcc(ByVal pkid As Integer)
        If pkid = 0 Then Exit Sub

        Dim obj As New DACustAccountObject
        obj = objDA.GetCustAccount(pkid)

        If obj Is Nothing Then
            Messenger.ShowWarning("The Customer Account '" & pkid & "' does not exist!")
            txtCustAcc.Focus()
        Else
            objCustAcc = obj
        End If

        txtPayTo.Text = objCustAcc.name
        txtCustAcc.Text = objCustAcc.pkid

        txtCustAcc.SelectAll()
    End Sub

    Private Sub SetCustUser(ByVal pkid As Integer)
        If pkid = 0 Then Exit Sub

        Dim obj As New DACustUserObject
        obj = objDA.GetCustUser(pkid)

        If obj Is Nothing Then
            Messenger.ShowWarning("The Customer '" & pkid & "' does not exist!")
            txtCustomer.Focus()
        Else
            objCustUser = obj
        End If

        If Not objCustUser.pkid = 0 Then
            txtPayTo.Text = objCustUser.GetName
            txtCustomer.Text = objCustUser.pkid
        End If

        txtCustomer.SelectAll()

    End Sub
    Private Sub SearchCustAccountButtonClick()

        Dim frm As New frmFindCustAcc
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            SetCustAcc(frm.keywoards)
        End If

    End Sub

    Private Sub CreateButtonClick()
        If Saving = True Then Exit Sub
        Saving = True

        Messenger.Caption = Me.Text
        If Not gShowMsgTxnConfirm() Then
            Exit Sub
        End If

        InsertPaymentVoucher()

        Saving = False
    End Sub

    Private Sub AddButtonClick()
        'Dim frm As New frmDepositList
        'If Not objCustAcc Is Nothing Then frm.objCustAcc = objCustAcc
        'If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    For Each dr As DocRow In frm.arrDocRow
        '        AddDocRow(dr)
        '    Next
        'End If

        Dim frm As New frmDeposit
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            AddDocRow(frm.objReceipt)
        End If
    End Sub

    Private Sub CancelButtonClick()
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub RemoveButtonClick()
        For Each item As ListViewItem In ListView1.SelectedItems
            Dim dr As DocRow = DirectCast(item.Tag, DocRow)
            item.Remove()
            arrDocRow.Remove(dr)
        Next
        SetAmount()
    End Sub

    Private Sub AddDocRow(ByVal dr As DocRow)
        Dim receiptObj As DAOfficialReceiptObject
        receiptObj = objDA.GetOfficialReceipt(dr.refKey)

        AddDocRow(receiptObj)
    End Sub

    Private Sub AddDocRow(ByVal receiptObj As DAOfficialReceiptObject, Optional ByVal isRefund As Boolean = False)

        If Not ExistItem(receiptObj.pkid, DAOfficialReceipt.TABLENAME) Then Exit Sub

        Dim row As New DocRow
        row.refKey = receiptObj.pkid
        row.entityTable = receiptObj.entityTable
        row.entityName = receiptObj.entityName
        row.entityKey = receiptObj.entityKey

        If isRefund Then
            row.price = receiptObj.openBalance
        Else
            If receiptObj.arrItems.Count > 0 Then
                row.price = receiptObj.GetTotalBalanceAmount
            Else
                row.price = receiptObj.amount
            End If

        End If

        row.refTable = DAOfficialReceipt.TABLENAME
        row.glCodeCredit = objCashAccount.accountType
        row.glCodeDebit = "accReceivable"
        row.tag = receiptObj
        row.description = receiptObj.GetCustName & " Tel: " & receiptObj.GetCustContact
        row.synchoKey = receiptObj.synchroKey

        arrDocRow.Add(row)

        AddItemWithDocRow(row)
    End Sub

    Private Sub AddItemWithDocRow(ByVal dr As DocRow)

        'No | Document # | Description | Amount
        Dim item As New ListViewItem
        item.Text = ListView1.Items.Count + 1
        item.SubItems.Add(dr.refKey)
        item.SubItems.Add(dr.description)
        item.SubItems.Add(FormatCurrency(dr.price))
        item.Tag = dr

        ListView1.Items.Add(item)

        SetAmount()
    End Sub

    Private Function ExistItem(ByVal refKey As Long, ByVal refTable As String) As Boolean

        For Each dr As DocRow In arrDocRow
            If dr.refKey = refKey AndAlso dr.refTable = refTable Then
                Messenger.ShowInformation("The document has been loaded!")
                Return False
            End If
        Next

        Return True
    End Function

    Private Function GetItemAmount() As Decimal
        Dim amt As Decimal = 0
        For Each dr As DocRow In arrDocRow
            amt += dr.price
        Next
        Return amt
    End Function

    Private Sub SetAmount()
        lblAmtShow.Text = gBranchObj.currency & " " & FormatCurrency(GetItemAmount)
    End Sub

    Private Sub SetCashAccount()
        objCashAccount = objDA.GetCashAccount(gBranchObj.cashbookCash)
        If objCashAccount Is Nothing Then
            objCashAccount = New DACashAccountObject
        End If
    End Sub

#End Region

#Region " Event Handler/Response "

    Private Sub ButtonClick(ByVal sender As Object, ByVal e As System.EventArgs)

        Try
            Select Case sender.name
                Case "btnCreate"
                    CreateButtonClick()
                Case "btnAdd"
                    AddButtonClick()
                Case "btnCancel"
                    CancelButtonClick()
                Case "btnRemove"
                    RemoveButtonClick()
                Case "btnSearchCustAcc"
                    SearchCustAccountButtonClick()
            End Select

            SetCreateButton()

        Catch ex As Exception
            Messenger.Caption = FORMTITLE & "-" & sender.name
            Messenger.ShowError("Button Click Error!")
            WriteToLogFile(ex.Message)
        End Try

    End Sub

    Private Sub txtCustAcc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCustAcc.KeyPress
        e.Handled = Utils.General.KeyPress("0123456789", True, e)
    End Sub


    Private Sub txtCustAcc_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCustAcc.Leave
        If txtCustAcc.TextLength = 0 Then Exit Sub

        SetCustAcc(txtCustAcc.Text.Trim)
    End Sub

    Private Sub txtCustomer_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCustomer.Leave
        If txtCustomer.TextLength = 0 Then Exit Sub

        SetCustUser(txtCustomer.Text.Trim)
    End Sub

    Private Sub txtPayTo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPayTo.TextChanged
        SetCreateButton()
    End Sub

#End Region


    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Dim frm As New frmSelect
        frm.document = "Payment Voucher"
        If Not objPV Is Nothing Then
            frm.pkid = objPV.pkid
        End If

        If Not frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If

        Dim pkid As Long = frm.txtCashSale.Text
        Dim obj As DAPaymentVoucherObject = objDA.GetPaymentVoucher(pkid)
        If obj Is Nothing Then
            Messenger.ShowWarning("The Payment Voucher# '" & pkid & "' does not exist!")
            Exit Sub
        End If

        gShowReport(New rptPaymentVoucher(pkid), False)

    End Sub
End Class
