Imports DataAccess
Imports Utils
Imports Utils.General

Public Class frmJobsheet

#Region " Variable Declarations "

    ' Default Const
    Private Saving As Boolean = False
    Private FORMTITLE As String = "Create Jobsheet"

    Private TEXT_ADD_ITEM As String = gGetLocale("frmMainThickClient", "btnAdd.Text")
    Private TEXT_UPDATE_ITEM As String = gGetLocale("frmMainThickClient", "btnUpdateItem.Text")

    ' Object 
    Private objCustAcc As New DACustAccountObject
    Private objCustUser As New DACustUserObject
    Private objDA As New DataAccessNut
    Private objReceipt As DAOfficialReceiptObject
    Private objJobsheet As DAJobsheetObject
    Private objDocRow As DocRow

    ' ArrayList
    Private arrDocRow As New ArrayList
    Private arrDeposit As New ArrayList
    Private arrJobsheet As New ArrayList

    Private itemEditMode As Boolean
    Private textBoxFocused As TextBox

    'Extenal Details
    Private remarks As String = ""
    Private tender As Decimal = 0

    Private returnChange As Decimal = 0

    Public Enum FormMode
        JOBSHEET
        JOBSHEET_EDIT
    End Enum

    Public frmMode As FormMode

#End Region

#Region " Initialisation "

    Public Sub New(ByVal frmMode As FormMode)
        MyBase.New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.frmMode = frmMode

    End Sub


    Private Sub frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Initialise()
    End Sub

    Private Sub Initialise()
        If frmMode = FormMode.JOBSHEET Then
            FORMTITLE = "Create Jobsheet"
            AssignValue(Me.Text, gGetLocale(Me.Name, "title.create"))
        Else
            FORMTITLE = "Edit Jobsheet"
            AssignValue(Me.Text, gGetLocale(Me.Name, "title.edit"))
        End If

        'AssignValue(gGetLocale(Me.Name, "title"), Me.Text)
        Messenger.Caption = Me.Text
        gSetLocaleChange(Me.Name, Me)

        General.CursorButtons(Me, Cursors.Hand)

        SetEventHanlder()

        SetupDefaultControls()

        ShowEditJobsheetMenu(frmMode = FormMode.JOBSHEET_EDIT)

        SetCustAcc(gDefaultCustAcc)

    End Sub

    Private Sub SetupDefaultControls()

        ClearControls()

        lblWelcome.Text = gAppConfig.MsgWelcome & " - " & FORMTITLE
        lblDateShow.Text = FormatDateTime(Now)
        lblUserShow.Text = gUserObj.username

        lblSubTotalCcy.Text = gBranchObj.currency
        lblTotalIncludeTaxCcy.Text = gBranchObj.currency
        lblTotalDepositCcy.Text = gBranchObj.currency
        lblTotalCcy.Text = gBranchObj.currency
        lblTotalQtyCcy.Text = gBranchObj.currency

        lblTotalExcludeTaxCcy.Text = gBranchObj.currency
        lblGrandTotalCcy.Text = gBranchObj.currency

        LockAllFields(pTotal, True)

        Load_cboSalesman()
        txtItem.Focus()

        cboSalesman.Enabled = Not gAppConfig.DisallowUserToChangeSalesman

        If gAppConfig.PriceIncludeTax Then
            pIncludeTax.Visible = True
        Else
            pExcludeTax.Visible = True
        End If

        LoadPictureFromBlob(gAppConfig.LogoBlob, picLogo)

    End Sub

    Private Sub SetEventHanlder()

        AddHandler btnSearchCustomer.Click, AddressOf ButtonClick
        AddHandler btnSearchCustAcc.Click, AddressOf ButtonClick

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
        AddHandler btnSave.Click, AddressOf ButtonClick
        AddHandler btnDelete.Click, AddressOf ButtonClick
        AddHandler btnDot.Click, AddressOf ButtonClick
        AddHandler btnEdit.Click, AddressOf ButtonClick
        AddHandler btnBackspace.Click, AddressOf ButtonClick

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
        AddHandler txtItem.Click, AddressOf TextClick
        AddHandler txtQty.Click, AddressOf TextClick
        AddHandler txtPrice.Click, AddressOf TextClick
        AddHandler txtDisc.Click, AddressOf TextClick
        AddHandler txtDiscPercentage.Click, AddressOf TextClick

        AddHandler txtCustomer.Enter, AddressOf TextEnter
        AddHandler txtCustAcc.Enter, AddressOf TextEnter
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
            Messenger.Caption = FORMTITLE & "-" & "Load_cboSalesman"
            Messenger.ShowError("Load Salesman Error!")
            WriteToLogFile(ex.Message)
        End Try

    End Sub

#End Region

#Region " Database Updating - Presentation Layer "

    Private Sub AddItem()

        Dim itemCode As String = txtItem.Text.Trim
        Dim qty As Integer = txtQty.Text
        Dim price As Decimal = txtPrice.Text
        Dim discPercentage As Integer = txtDiscPercentage.Text
        Dim disc As Decimal = txtDisc.Text

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

            AddItemWithDocRow(objDocRow)

            ' add to ArrayList DocRow
            If Not objJobsheet Is Nothing Then
                objDocRow.docIndexTable = DAJobsheet.TABLENAME
                objDocRow.docIndexKey = objJobsheet.pkid
            End If

            arrDocRow.Add(objDocRow)

            SetTotal()
            ClearAddItemFields()

        Catch ex As Exception
            Messenger.Caption = FORMTITLE & "- Add Item Error"
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

            objDocRow = SelectDocRow()

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

            ShowEditItemMenu(False)

            SetTotal()
            ClearAddItemFields()

        Catch ex As Exception
            Messenger.Caption = FORMTITLE & "- Edit Item Error"
            Messenger.ShowError(ex.Message)
        End Try

    End Sub

    Private Sub UpdateDeleteItem(ByVal objDocRow As DocRow)

        Dim dr As New DocRow
        Dim item As New GlacialComponents.Controls.GLItem
        For Each item In GlacialList1.Items
            dr = DirectCast(item.Tag, DocRow)
            If objDocRow.guid = dr.guid Then

                Dim refKey As Long = dr.refKey
                Dim qty As Integer = dr.qty
                Dim remarks As String = dr.remarks
                AssignFieldsValue(objDocRow, dr)

                dr.refKey = refKey
                dr.qty = qty
                dr.remarks = remarks

                item.SubItems(1).Text = dr.itemCode & vbCrLf & dr.itemName
                item.SubItems(2).Text = dr.qty
                item.SubItems(3).Text = FormatCurrency(dr.price)
                item.SubItems(4).Text = FormatCurrency(dr.discount)
                item.SubItems(5).Text = FormatCurrency(dr.GetAmount)

                item.Tag = dr

            End If
        Next

    End Sub

    Private Sub EditItem()

        If GlacialList1.SelectedItems.Count = 0 Then Exit Sub

        Dim item As New GlacialComponents.Controls.GLItem
        item = GlacialList1.SelectedItems(0)

        'Dim objDocRow As New DocRow
        objDocRow = DirectCast(item.Tag, DocRow)
        If objDocRow.qty < 0 Then Exit Sub

        txtItem.Text = objDocRow.itemCode
        txtQty.Text = objDocRow.qty
        txtPrice.Text = FormatCurrency(objDocRow.price)
        txtDisc.Text = FormatCurrency(objDocRow.discount)

        ShowEditItemMenu(True)

    End Sub

    Private Sub DeleteItem()
        objDocRow = SelectDocRow()
        If objDocRow Is Nothing Then Exit Sub

        If Not gShowMsgDeleteConfirm() Then Exit Sub

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
        Dim objDocRow As DocRow = Nothing
        If GlacialList1.SelectedItems.Count = 0 Then Return Nothing

        Dim item As New GlacialComponents.Controls.GLItem
        item = GlacialList1.SelectedItems(0)
        objDocRow = DirectCast(item.Tag, DocRow)
        If objDocRow.qty <= 0 Then Return Nothing

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


    Private Function InsertJobsheet() As Boolean

        If Not gShowMsgTxnConfirm() Then Exit Function

        Try
            objJobsheet = New DAJobsheetObject
            objJobsheet.entityKey = objCustAcc.pkid
            objJobsheet.entityName = objCustAcc.name
            objJobsheet.entityTable = DACustAccount.TABLENAME
            objJobsheet.salesId = cboSalesman.SelectedValue
            objJobsheet.timeCreated = Now
            objJobsheet.amountTotal = GetGrandTotal()
            objJobsheet.taxAmount = GetTotalTaxAmount()
            objJobsheet.useridEdit = gUserObj.userid
            objJobsheet.lastUpdate = Now
            objJobsheet.branch = gBranchObj.pkid
            objJobsheet.location = gBranchObj.invLocationId
            objJobsheet.pcCenter = gBranchObj.accPCCenterId
            objJobsheet.currency = gBranchObj.currency
            objJobsheet.state = DAJobsheet.STATE_CREATED
            objJobsheet.remarks = Me.remarks

            objJobsheet.receiverName = objCustAcc.name
            objJobsheet.receiverHandphone = objCustAcc.mobilePhone

            If Not objCustUser Is Nothing Then
                objJobsheet.foreignTable = DACustUser.TABLENAME
                objJobsheet.foreignKey = objCustUser.pkid
                objJobsheet.receiverName = objCustUser.GetName()
                objJobsheet.receiverHandphone = objCustUser.mobilePhone
            End If

            For Each dr As DocRow In arrDocRow
                Dim jobsheetItemObj As New DAJobsheetItemObject(objJobsheet, dr)
                objJobsheet.arrItems.Add(jobsheetItemObj)
            Next

            If Not objDA.CreateJobsheet(objJobsheet, objReceipt) Then Return False

            'InsertDocLink(objJobsheet, objReceipt, objReceipt.openBalance)

            ResetItemClick()

            'Show Printable
            gShowReport(New rptJobsheet(objJobsheet.pkid), True)

            gShowMsgTxnSucceed(objJobsheet.pkid, "JOBSHEET")

            Return True

        Catch ex As Exception
            Messenger.Caption = FORMTITLE & "- Insert Jobsheet Error"
            Messenger.ShowError(ex.Message)
            Return False
        End Try

    End Function

    Private Function UpdateJobsheet() As Boolean

        If Not gShowMsgTxnConfirm() Then Exit Function

        Try
            objJobsheet.entityKey = objCustAcc.pkid
            objJobsheet.entityName = objCustAcc.name
            objJobsheet.entityTable = DACustAccount.TABLENAME
            objJobsheet.salesId = cboSalesman.SelectedValue
            objJobsheet.amountTotal = GetGrandTotal()
            objJobsheet.useridEdit = gUserObj.userid
            objJobsheet.lastUpdate = Now
            objJobsheet.branch = gBranchObj.pkid
            objJobsheet.location = gBranchObj.invLocationId
            objJobsheet.pcCenter = gBranchObj.accPCCenterId
            objJobsheet.currency = gBranchObj.currency
            'objJobsheet.state = DAJobsheet.STATE_CREATED
            objJobsheet.taxAmount = GetTotalTaxAmount()

            objJobsheet.receiverName = objCustAcc.name
            objJobsheet.receiverHandphone = objCustAcc.mobilePhone

            If Not objCustUser Is Nothing Then
                objJobsheet.foreignTable = DACustUser.TABLENAME
                objJobsheet.foreignKey = objCustUser.pkid
                objJobsheet.receiverName = objCustUser.GetName()
                objJobsheet.receiverHandphone = objCustUser.mobilePhone
            End If

            'For Each dr As DocRow In arrDocRow
            '    If dr.refKey = 0 Then
            '        'insert
            '        Dim jbosheetItemObj As New DAJobsheetItemObject(objJobsheet, dr)
            '        objDA.InsertJobsheetItem(jbosheetItemObj)
            '    Else
            '        If dr.isDeleted Then
            '            'delete
            '            objDA.DeleteJobsheetItem(dr.refKey)
            '        Else
            '            'update
            '            Dim jbosheetItemObj As New DAJobsheetItemObject(objJobsheet, dr)
            '            jbosheetItemObj.pkid = dr.refKey
            '            objDA.UpdateJobsheetItem(jbosheetItemObj)
            '        End If
            '    End If
            'Next

            If Not objDA.ModifyJobsheet(objJobsheet, arrDocRow) Then Return False

            ResetItemClick()

            'Go back to Create Jobsheet menu
            'ShowEditJobsheetMenu(0, False)

            'Show Printable
            gShowReport(New rptJobsheet(objJobsheet.pkid), True)

            gShowMsgTxnSucceed(objJobsheet.pkid, "JOBSHEET")

            Return True

        Catch ex As Exception
            Messenger.Caption = FORMTITLE & "- Save Jobsheet Error"
            Messenger.ShowError(ex.Message)
            Return False
        End Try

    End Function

    Private Function UpdateJobsheetState(ByVal invObj As DAInvoiceObject, ByVal guid As String) As Boolean

        objDA.ModifyJobsheetState(objJobsheet, invObj, guid)

        ''For Each obj As DAJobsheetObject In arrJobsheet
        'objJobsheet.state = DAJobsheet.STATE_INVOICE
        'objDA.UpdateJobsheet(objJobsheet, guid)

        '' create doclink for this jobsheet
        'Dim doclinkObj As New DADocLinkObject
        'doclinkObj.name_space = DADocLink.NS_CUSTOMER
        'doclinkObj.relType = DADocLink.RELTYPE_JS_TO_INVOICE
        'doclinkObj.srcDocRef = DAInvoice.TABLENAME
        'doclinkObj.srcDocId = invObj.mPkid
        'doclinkObj.tgtDocRef = DAJobsheet.TABLENAME
        'doclinkObj.tgtDocId = objJobsheet.pkid
        'doclinkObj.currency = invObj.mCurrency
        'doclinkObj.amount = 0
        'doclinkObj.lastUpdate = Now
        'doclinkObj.userIdUpdate = gUserObj.userid

        'objDA.InsertDocLink(doclinkObj)
        ''Next

    End Function

    Private Function CreateCashSale(ByVal guid As String, ByRef invObj As DAInvoiceObject, _
                                   ByRef receiptObj As DAOfficialReceiptObject) As Boolean

        Try

            invObj = New DAInvoiceObject
            invObj.mEntityKey = objJobsheet.entityKey
            invObj.mEntityName = objJobsheet.entityName
            invObj.mEntityTable = objJobsheet.entityTable
            invObj.mEntityCode = ""
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

            invObj.receiverName = objCustAcc.name
            invObj.receiverHandphone = objCustAcc.mobilePhone

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
            Messenger.Caption = FORMTITLE & "- Create Receipt Error!"
           Messenger.ShowError(ex.Message)
            Return False
        End Try


    End Function

    Public Function InsertDocLink(ByVal jobsheetObj As DAJobsheetObject, ByVal receiptObj As DAOfficialReceiptObject, ByVal payment As Decimal) As Boolean
        Try

            Dim obj As New DADocLinkObject
            obj.name_space = DADocLink.NS_CUSTOMER
            obj.relType = DADocLink.RELTYPE_PYMT_JOBSHEET_DEPOSIT
            obj.srcDocRef = DAOfficialReceipt.TABLENAME
            obj.srcDocId = receiptObj.pkid
            obj.tgtDocRef = DAJobsheet.TABLENAME
            obj.tgtDocId = jobsheetObj.pkid
            obj.currency = jobsheetObj.currency
            obj.amount = Decimal.Negate(payment)
            obj.lastUpdate = Now
            obj.userIdUpdate = gUserObj.userid

            objDA.CreateDocLink(obj)

            Return True

        Catch ex As Exception
            Messenger.Caption = FORMTITLE & "- Create Document Link Error"
            Messenger.ShowError(ex.Message)
            Return False
        End Try

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

    Public Function DepositSettlement(ByVal invObj As DAInvoiceObject, ByVal isRefund As Boolean, ByVal guid As String) As Boolean

        Dim totalAmt As Decimal = invObj.mTotalAmt
        Dim payment As Decimal = 0
        For Each obj As DAOfficialReceiptObject In arrDeposit
            'Dim payment As Decimal = IIf(isRefund, invObj.mTotalAmt, obj.openBalance)
            payment = obj.openBalance

            If payment > totalAmt Then
                payment = totalAmt
            Else
                totalAmt -= payment
            End If

            'Create doclink
            InsertDocLink(invObj, obj, payment, DADocLink.RELTYPE_PYMT_INV_DEPOSIT)

            UpdateBalanceReceipt(obj, payment, guid)
        Next

    End Function

    Private Function SaveTxn(ByVal receiptObj As DAOfficialReceiptObject) As Boolean

        Dim receiptId As Integer = 0
        Dim objInvoice As New DAInvoiceObject

        Dim guid As String = GetGuid()

        Try

            Dim depositAmt As Decimal = GetTotalDeposit()
            Dim taxAmt As Decimal = GetTotalTaxAmount()
            Dim subTotal As Decimal = GetTotalAmount()
            Dim grandTotal As Decimal = GetGrandTotal()

            Dim isRefund As Boolean = grandTotal < 0

            If Not CreateCashSale(guid, objInvoice, objReceipt) Then Return False

            'Deposit Settlement
            DepositSettlement(objInvoice, isRefund, guid)

            UpdateJobsheetState(objInvoice, guid)

            'To Refund
            If isRefund Then
                If Messenger.ShowQuestion(gMSG_REFUND, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Dim frm As New frmPaymentVoucher
                    frm.pkid = objInvoice.mEntityKey
                    frm.arrDeposit = arrDeposit
                    frm.frmMode = frmPaymentVoucher.FormMode.JOBSHEET
                    frm.ShowDialog()
                End If
            End If

            gPrintCashBill(objInvoice.mPkid)

            objDA.UpdateQtyBill(gPosEndDayClosingObj)
            gCurrentTotalBill += 1
            objDA.UpdatePosCounter()

            gShowMsgTxnSucceed(objInvoice.mPkid, "CASH SALE")

            ResetItemClick()

            Return True

        Catch ex As Exception
            Messenger.Caption = FORMTITLE & " - Save Transaction Error"
            Messenger.ShowError(ex.Message)
            Saving = False
            Return False
        End Try

    End Function

#End Region

#Region " Controls Populating, Updating, etc "

    Private Sub EnabledMenuKey(ByVal enable As Boolean)
        For Each mnu As ToolStripMenuItem In mnuTools.DropDownItems
            mnu.Enabled = enable
        Next
    End Sub

    Private Sub ShowEditItemMenu(ByVal show As Boolean)
        itemEditMode = show
        LockItem(show)
        If show Then
            btnAdd.Text = TEXT_UPDATE_ITEM
            txtQty.Focus()
        Else
            btnAdd.Text = TEXT_ADD_ITEM
        End If
    End Sub

    Private Sub ShowEditJobsheetMenu(ByVal show As Boolean)

        If frmMode = FormMode.JOBSHEET_EDIT Then
            'lblWelcome.Text = gAppConfigObj.MsgWelcome & " - " & "JOBSHEET : " & jobsheetId
        End If

        tbCancel.Visible = show
        tbCash.Visible = show
        tbPayment.Visible = show
        tbLoadJobsheet.Visible = show

        mnuF3.Enabled = show
        mnuF7.Enabled = show
        mnuF8.Enabled = show
        mnuF6.Enabled = show

    End Sub

    Private Sub EnaledEditJobsheetMenu(ByVal enabled As Boolean)

        tbFindItem.Enabled = enabled
        tbCancel.Enabled = enabled
        tbCash.Enabled = enabled
        tbPayment.Enabled = enabled

        mnuF3.Enabled = enabled
        mnuF7.Enabled = enabled
        mnuF8.Enabled = enabled
        mnuF1.Enabled = enabled

        LockAllButtons(TableLayoutPanel1, Not enabled)
        LockAllFields(Me, Not enabled)

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

        lblWelcome.Text = gAppConfig.MsgWelcome & " - " & FORMTITLE

        ClearAddItemFields()
        GlacialList1.Items.Clear()
        GlacialList1.Refresh()

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

        lblCustAcc.Text = ""
        lblCustomer.Text = ""
        txtCustomer.Text = ""
        txtCustAcc.Text = ""
        lblDepositSlip.Text = ""

        ClearDepositDetails()

        ' Reset Receipt Object
        objReceipt = New DAOfficialReceiptObject
        objDocRow = New DocRow
        objCustAcc = New DACustAccountObject
        objCustUser = New DACustUserObject

        remarks = ""

        Saving = False

        If frmMode = FormMode.JOBSHEET_EDIT Then EnaledEditJobsheetMenu(False)

    End Sub

    Private Sub ClearDepositDetails()
        lblDepositSlip.Text = ""
        lblCustName.Text = ""
        lblCustContact.Text = ""
        lblCustIC.Text = ""
    End Sub


    Private Sub LockItem(ByVal isLock As Boolean)
        LockFields(txtItem, isLock)
    End Sub

    Public Function LoadJobsheet() As Boolean

        ResetItemClick()

        SetCustAcc(objJobsheet.entityKey)
        If objJobsheet.foreignTable = DACustUser.TABLENAME Then
            SetCustUser(objJobsheet.foreignKey)
        End If

        For Each jobsheetItemObj As DAJobsheetItemObject In objJobsheet.arrItems
            Dim dr As New DocRow
            dr = jobsheetItemObj.GetDocRow()
            dr.docIndexTable = DAJobsheet.TABLENAME
            dr.docIndexKey = objJobsheet.pkid
            AddItemWithDocRow(dr)
            arrDocRow.Add(dr)
        Next

        'Set External Details
        Me.remarks = objJobsheet.remarks

        SetTotal()

        lblWelcome.Text = gAppConfig.MsgWelcome & " - " & FORMTITLE & ": " & objJobsheet.pkid

        EnaledEditJobsheetMenu(True)

    End Function

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

    Private Sub CancelJobsheetItemClick()
        If Messenger.ShowQuestion("Are you sure?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        objJobsheet.state = DAJobsheet.STATE_CLOSED
        If objDA.UpdateJobsheet(objJobsheet) Then
            Messenger.ShowInformation("The Jobsheet close succeed!")
            ResetItemClick()
        End If
    End Sub

    Private Sub DepositItemClick()
        Dim frm As New frmDeposit
        If Not frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If

        'Dim receiptObj As DAOfficialReceiptObject
        objJobsheet = objDA.GetJobsheetByReceipt(frm.objReceipt.pkid)

        If frmMode = FormMode.JOBSHEET_EDIT Then
            If objJobsheet Is Nothing Then
                Messenger.ShowWarning("The Jobsheet belong this receipt does not exist!")
                Exit Sub
            End If

            If objJobsheet.state = DAJobsheet.STATE_INVOICE Then
                Messenger.ShowWarning("The Jobsheet belong this receipt has been converted into invoice!")
                Exit Sub
            End If

            LoadJobsheet()
        Else
            If (Not objJobsheet Is Nothing) AndAlso (Not objJobsheet.state = DAJobsheet.STATE_CLOSED) Then
                Messenger.ShowWarning("The receipt has been used!")
                Exit Sub
            End If
        End If

        objReceipt = frm.objReceipt
        SetDepositDetails(objReceipt)

        'SetDeposit()

    End Sub

    Private Sub LoadJobsheetItemClick()
        'If HasItems() Then Exit Sub

        Dim frm As New frmFindJobsheet
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim pkid As Long = frm.keywoards
            objJobsheet = objDA.GetJobsheet(pkid)

            If objJobsheet Is Nothing Then
                Messenger.ShowWarning("The Jobsheet '" & pkid & "' does not exist!")
                Exit Sub
            End If

            If objJobsheet.state = DAJobsheet.STATE_INVOICE Then
                Messenger.ShowWarning("The Jobsheet '" & pkid & "' has been converted into invoice!")
                Exit Sub
            End If

            If objJobsheet.state = DAJobsheet.STATE_CLOSED Then
                Messenger.ShowWarning("The Jobsheet '" & pkid & "' has been closed!")
                Exit Sub
            End If

            LoadJobsheet()

            Dim receiptObj As DAOfficialReceiptObject
            receiptObj = objDA.GetReceiptByJobsheet(objJobsheet.pkid)
            SetDepositDetails(receiptObj)
        End If

    End Sub

    Private Sub CloseItemClick()
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub ResetItemClick()
        ClearControls()
    End Sub

    Private Sub CashItemClick()
        If Not HasItems() Then Exit Sub

        Dim frm As New frmPaymentCash
        frm.total = Convert.ToDecimal(lblTotalAmt.Text)
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim receiptObj As New DAOfficialReceiptObject
            If frm.total > 0 Then
                receiptObj.amountCash = frm.total
                receiptObj.amount = receiptObj.amountCash
            End If
            Me.tender = Convert.ToDecimal(frm.txtTender.Text)
            Me.returnChange = Convert.ToDecimal(frm.txtChange.Text)

            objReceipt.cashNotesReceived = tender
            objReceipt.cashNotesChange = returnChange

            SaveTxn(receiptObj)
        End If
    End Sub

    Private Sub OtherPaymentsItemClick()
        If Not HasItems() Then Exit Sub

        'Dim frm As New frmOtherPayments
        'frm.frmMode = frmOtherPayments.FormMode.MAIN
        'frm.total = Convert.ToDecimal(lblTotalAmt.Text)
        'If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    Dim receiptObj As New DAOfficialReceiptObject
        '    receiptObj = frm.objReceipt
        '    SaveTxn(receiptObj)
        'End If

        Dim frm As New frmPayments
        frm.total = GetGrandTotal()
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim receiptObj As New DAOfficialReceiptObject
            receiptObj = frm.objReceipt
            SaveTxn(receiptObj)
        End If
    End Sub

    Private Sub PrintItemClick()
        If HasItems() Then Exit Sub

        Dim frm As New frmSelect
        frm.document = "Jobsheet"
        If Not objJobsheet Is Nothing Then
            frm.pkid = objJobsheet.pkid
        End If

        If Not frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If

        Dim pkid As Long = frm.txtCashSale.Text
        Dim jobsheetObj As DAJobsheetObject = objDA.GetJobsheet(pkid)
        If jobsheetObj Is Nothing Then
            Messenger.ShowWarning("The Jobsheet '" & pkid & "' does not exist!")
            Exit Sub
        End If

        gShowReport(New rptJobsheet(pkid), False)

    End Sub

#End Region

#Region " Button Clicked "

    Private Sub SearchCustAccountButtonClick()

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

    Private Sub AddButtonClick()
        If itemEditMode Then
            UpdateItem()
        Else
            AddItem()
        End If
        txtItem.Focus()
    End Sub

    Private Sub SaveButtonClick()
        If Not HasItems() Then Exit Sub

        If Saving = True Then Exit Sub
        Saving = True

        Select Case frmMode
            Case FormMode.JOBSHEET
                InsertJobsheet()

            Case FormMode.JOBSHEET_EDIT
                UpdateJobsheet()

        End Select

        Saving = False

    End Sub

    Private Sub DeleteButtonClick()
        DeleteItem()
    End Sub

    Private Sub EditButtonClick()
        EditItem()
    End Sub

    Private Sub BackSpaceButtonClick()
        SetTextBoxValue(textBoxFocused, "backspace")
    End Sub

#End Region

    Private Sub SetCustAcc(ByVal pkid As Integer)
        If pkid = 0 Then Exit Sub

        Dim obj As New DACustAccountObject
        obj = objDA.GetCustAccount(pkid)

        If obj Is Nothing Then
            Messenger.ShowWarning("The Customer Account '" & pkid & "' does not exist!")
            txtCustAcc.Focus()
            'If Not pkid = defaultCustAcc Then SetCustAcc(defaultCustAcc)
        Else
            objCustAcc = obj
        End If

        lblCustAcc.Text = objCustAcc.name
        txtCustAcc.Text = objCustAcc.pkid

        txtCustAcc.SelectAll()

    End Sub

    Private Sub SetCustUser(ByVal pkid As Integer)
        If pkid = 0 Then
            objCustUser = New DACustUserObject
            lblCustomer.Text = ""
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
            lblCustomer.Text = objCustUser.GetName
            If objCustUser.mobilePhone <> "" Then lblCustomer.Text &= " Contact: " & objCustUser.mobilePhone

            txtCustomer.Text = objCustUser.pkid
        End If

        txtCustomer.SelectAll()

    End Sub

    Public Sub SetDepositDetails(ByVal receiptObj As DAOfficialReceiptObject)
        ClearDepositDetails()

        If Not receiptObj Is Nothing Then
            lblDepositSlip.Text = receiptObj.pkid
            lblCustName.Text = receiptObj.GetCustName
            lblCustContact.Text = receiptObj.GetCustContact
            lblCustIC.Text = receiptObj.GetCustIC

            arrDeposit.Clear()
            For Each obj As DAOfficialReceiptObject In receiptObj.arrItems
                arrDeposit.Add(obj)
            Next

            SetTotal()
        End If

    End Sub

    Public Sub SetDeposit()

        Dim strValue As String = ""

        For Each obj As DAOfficialReceiptObject In arrDeposit
            If obj.status <> DAOfficialReceipt.STATUS_TOPUP Then _
                strValue &= obj.pkid & " " & gBranchObj.currency & FormatCurrency(obj.GetTotalAmount) & ","
        Next

        If strValue.LastIndexOf(",") > 0 Then
            strValue = strValue.Remove(strValue.Length - 1, 1)
        End If

        lblDepositSlip.Text = strValue

    End Sub

    Public Sub SetTotalAll(ByRef qty As Integer, ByRef amount As Decimal, _
                                    ByRef taxAmount As Decimal, ByRef deposit As Decimal, ByRef grandTotal As Decimal)

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
        For Each obj As DAOfficialReceiptObject In arrDeposit
            amt += obj.openBalance
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

        item.Text = GlacialList1.Count + 1
        subitem1.Text = objDocRow.itemCode & vbCrLf & objDocRow.itemName & " (" & objDocRow.remarks & ") "
        subitem2.Text = objDocRow.qty
        subitem3.Text = FormatCurrency(objDocRow.GetPriceStd)
        subitem4.Text = FormatCurrency(objDocRow.discount)
        subitem5.Text = FormatCurrency(objDocRow.GetAmount)

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

        item.SubItems(1).Text = objDocRow.itemCode & vbCrLf & objDocRow.itemName & " (" & objDocRow.remarks & ") "
        item.SubItems(2).Text = objDocRow.qty
        item.SubItems(3).Text = FormatCurrency(objDocRow.GetPriceStd)
        item.SubItems(4).Text = FormatCurrency(objDocRow.discount)
        item.SubItems(5).Text = FormatCurrency(objDocRow.GetAmount)

        item.Tag = objDocRow

        GlacialList1.Refresh()
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
                Case "tbCancel"
                    CancelJobsheetItemClick()
                Case "tbDeposit"
                    DepositItemClick()
                Case "tbLoadJobsheet"
                    LoadJobsheetItemClick()
                Case "tbClose"
                    CloseItemClick()
                Case "tbReset"
                    ResetItemClick()
                Case "tbCash"
                    CashItemClick()
                Case "tbPayment"
                    OtherPaymentsItemClick()
                Case "tbPrint"
                    PrintItemClick()
            End Select

        Catch ex As Exception
            Messenger.Caption = FORMTITLE & "-" & sender.name
            Messenger.ShowError(item.Text & " Error!")
            WriteToLogFile(ex.Message)
        End Try

    End Sub

    Private Sub mnuTools_DropDownItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles mnuTools.DropDownItemClicked
        Dim item As ToolStripItem
        item = e.ClickedItem

        Try

            Select Case item.Name
                Case "mnuF1"
                    FindItemClick("")
                Case "mnuF2"
                    ResetItemClick()
                Case "mnuF3"
                    CancelJobsheetItemClick()
                Case "mnuF4"
                    DepositItemClick()
                Case "mnuF5"

                Case "mnuF6"
                    LoadJobsheetItemClick()
                Case "mnuF7"
                    CashItemClick()
                Case "mnuF8"
                    OtherPaymentsItemClick()
                Case "mnuF9"
                    CloseItemClick()
                Case "mnuF10"
                    ResetItemClick()
                Case "mnuF11"
                    PrintItemClick()
                Case "mnuf12"

            End Select

            txtItem.Focus()

        Catch ex As Exception
            Messenger.Caption = FORMTITLE & "-" & sender.name
            Messenger.ShowError("System Error!")
            WriteToLogFile(ex.Message)
        End Try

    End Sub

    Private Sub mnuKey_DropDownItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles mnuKey.DropDownItemClicked
        Dim item As ToolStripItem
        item = e.ClickedItem

        Try
            Select Case item.Name
                Case "mnuItemCode"
                    txtItem.Focus()
                Case "mnuQty"
                    txtQty.Focus()
                Case "mnuPrice"
                    txtPrice.Focus()
                Case "mnuDisc"
                    txtDiscPercentage.Focus()
                Case "mnuDisc1"
                    txtDisc.Focus()
                Case "mnuCustAcc"
                    txtCustAcc.Focus()
                Case "mnuCustUser"
                    txtCustomer.Focus()
                Case "mnuSalesman"
                    cboSalesman.Focus()
                Case "mnuDelete"
                    btnDelete.PerformClick()
            End Select

            'txtItem.Focus()

        Catch ex As Exception
            Messenger.Caption = FORMTITLE & "-" & sender.name
            Messenger.ShowError("System Error!")
            WriteToLogFile(ex.Message)
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
                Case "btnAdd"
                    AddButtonClick()
                    txtItem.Focus()
                Case "btnSave"
                    SaveButtonClick()
                    txtItem.Focus()
                Case "btnDelete"
                    DeleteButtonClick()
                    txtItem.Focus()
                Case "btnEdit"
                    EditButtonClick()
                    txtItem.Focus()
                Case "btnBackspace"
                    BackSpaceButtonClick()
            End Select

        Catch ex As Exception
            Messenger.Caption = FORMTITLE & "-" & sender.name
            Messenger.ShowError(btn.Text & " Error!")
            WriteToLogFile(ex.Message)
        End Try

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblDateShow.Text = GetNow()
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
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Enter)
                AddButtonClick()
            Case Convert.ToChar("+")
                SaveButtonClick()
                e.Handled = True
            Case Convert.ToChar(Keys.Escape)
                ClearAddItemFields()
        End Select
        e.Handled = Utils.General.KeyPress("=""", False, e)
    End Sub

    Private Sub txtCustAcc_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        If txtCustAcc.Text.Trim = "" Then Exit Sub

        SetCustAcc(txtCustAcc.Text)
    End Sub

    Private Sub txtCustomer_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
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

    Private Sub TextEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        textBoxFocused = DirectCast(sender, TextBox)
        textBoxFocused.SelectAll()
    End Sub

    Private Sub TextClick(ByVal sender As Object, ByVal e As System.EventArgs)
        textBoxFocused = DirectCast(sender, TextBox)
        textBoxFocused.SelectAll()
    End Sub

    Private Sub lnkDetails_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkDetails.LinkClicked
        Dim frm As New frmDetails
        frm.txtRemark.Text = Me.remarks
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
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

#End Region

   
End Class