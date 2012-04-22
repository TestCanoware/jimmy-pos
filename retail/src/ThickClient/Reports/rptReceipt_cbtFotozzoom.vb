Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 
Imports Utils
Imports Utils.General
Imports DataAccess

Public Class rptReceipt_cbtFotozzoom

    Private Const AMOUNT_FIELD = "amount"

    Private pkid As Long
    Private objDA As New DataAccessNut
    Private depositAmt As Decimal = 0

    Public Sub New(ByVal pkid As Long)
        MyBase.New()
        InitializeComponent()
        Me.pkid = pkid
    End Sub

    Private Sub rptReceipt_DataInitialize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataInitialize
        Me.Fields.Add(AMOUNT_FIELD)
    End Sub

    Private Sub rptReceipt_FetchData(ByVal sender As Object, ByVal eArgs As DataDynamics.ActiveReports.ActiveReport3.FetchEventArgs) Handles Me.FetchData
        Dim qty As Integer = Me.Fields(DAInvoiceItem.TOTALQTY).Value
        Dim price As Decimal = Me.Fields(DAInvoiceItem.UNIT_PRICE_QUOTED).Value

        Me.Fields(AMOUNT_FIELD).Value = qty * price
    End Sub

    Private Sub rptReceipt_ReportEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportEnd
        Try
            'Me.Document.Print(False, False, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rptReceipt_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        Dim ds As DataSet = Nothing

        Try
            'Get Invoice
            Dim invObj As New DAInvoiceObject
            invObj = objDA.GetInvoice(pkid)

            Dim receiptObj As New DAOfficialReceiptObject
            receiptObj = objDA.GetOfficialReceipt(invObj.mReceiptId)

            depositAmt = objDA.GetDepositAmt(pkid)

            txtReceiptID.Text = pkid
            txtTime.Text = FormatDateTime1(invObj.mTimeIssued)
            txtUser.Text = "(" & objDA.GetUserName(invObj.mUserIdUpdate) & ")"
            'txtMachineNo.Text = objDA.GetPosIdByInvoiceId(pkid)

            txtTendered.Text = FormatCurrency(receiptObj.cashNotesReceived)

            txtPosMsg1.Text = gAppConfig.MsgBottom1
            txtPosMsg2.Text = gAppConfig.MsgBottom2
            txtPosMsg3.Text = gAppConfig.MsgBottom3
            txtPosMsg4.Text = gAppConfig.MsgBottom4

            ' Set data field 
            txtDesc.DataField = DAInvoiceItem.NAME
            txtCode.DataField = DAInvoiceItem.ITEM_CODE
            txtQty.DataField = DAInvoiceItem.TOTALQTY
            txtPrice.DataField = DAInvoiceItem.UNIT_PRICE_QUOTED
            txtAmount.DataField = AMOUNT_FIELD

            'txtTotalQty.DataField = DAInvoiceItem.TOTALQTY
            'txtTotalQty.SummaryRunning = SummaryRunning.All
            'txtTotalQty.SummaryType = SummaryType.GrandTotal

            'txtTotal.DataField = AMOUNT_FIELD
            'txtTotal.SummaryRunning = SummaryRunning.All
            'txtTotal.SummaryType = SummaryType.GrandTotal

            'txtTax.Text = FormatCurrency(invObj.taxAmount)
            txtDeposit.Text = FormatCurrency(Me.depositAmt)
            txtNetTotal.Text = FormatCurrency(invObj.mTotalAmt + Me.depositAmt)
            txtChange.Text = FormatCurrency(receiptObj.cashNotesChange)

            'txtRemarks.Text = "Remarks: " & invObj.mRemarks

            ' Get Receipt transaction
            ds = Nothing
            objDA.GetInvoiceItem(Me.pkid, ds)
            Me.DataSource = ds.Tables(0)

            'Barcode1.Text = "*" & pkid & "*"
            Barcode1.Text = pkid

        Catch ex As Exception
            Messenger.ShowError("Receipt Printable Error!")
            WriteToLogFile(ex.Message)
        End Try

    End Sub

End Class
