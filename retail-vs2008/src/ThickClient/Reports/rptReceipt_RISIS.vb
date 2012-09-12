Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document 
Imports Utils
Imports Utils.General
Imports DataAccess

Public Class rptReceipt_risis

    Private Const AMOUNT_FIELD = "amount"
    Private Const UNIT_PRICE_FIELD = "unit_price"
    Private Const NO_FIELD = "no"
    Private Const DESC_FIELD = "desc"

    Private pkid As Long
    Private objDA As New DataAccessNut
    Private depositAmt As Decimal = 0
    Private row As Integer = 0
    Private salesman As String

    Public Sub New(ByVal pkid As Long)
        MyBase.New()
        InitializeComponent()
        Me.pkid = pkid
    End Sub

    Private Sub rptReceipt_DataInitialize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataInitialize
        Me.Fields.Add(AMOUNT_FIELD)
        Me.Fields.Add(UNIT_PRICE_FIELD)
        Me.Fields.Add(NO_FIELD)
        Me.Fields.Add(DESC_FIELD)
    End Sub

    Private Sub rptReceipt_FetchData(ByVal sender As Object, ByVal eArgs As DataDynamics.ActiveReports.ActiveReport3.FetchEventArgs) Handles Me.FetchData
        Dim qty As Integer = Me.Fields(DAInvoiceItem.TOTALQTY).Value
        Dim price As Decimal = Me.Fields(DAInvoiceItem.UNIT_PRICE_QUOTED).Value
        Dim tax As Decimal = Me.Fields(DAInvoiceItem.TAXAMT).Value
        Dim disc As Decimal = Me.Fields(DAInvoiceItem.UNIT_DISCOUNT).Value
        Dim itemName As String = Me.Fields(DAInvoiceItem.NAME).Value
        Dim remarks As String = Me.Fields(DAInvoiceItem.REMARKS).Value
        Dim itemCode As String = Me.Fields(DAInvoiceItem.ITEM_CODE).Value


        If remarks <> salesman Then
            Me.Fields(DESC_FIELD).Value = itemCode & " " & itemName & " (" & remarks & ")"
        Else
            Me.Fields(DESC_FIELD).Value = itemCode & " " & itemName
        End If

        Me.Fields(UNIT_PRICE_FIELD).Value = price
        Me.Fields(AMOUNT_FIELD).Value = Me.Fields(UNIT_PRICE_FIELD).Value * qty

        row += 1
        Me.Fields(NO_FIELD).Value = row
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

            If invObj.mStatus = DAInvoice.STATUS_CANCELLED Then
                txtReportName.Text = "VOID REPORT"
                'txtRemarks.Text = "Remarks: " & receiptObj.remarksReverse
            Else
                txtReportName.Text = ""
                'txtRemarks.Text = "Remarks: " & invObj.mRemarks
            End If


            txtReceiptId.Text = pkid
            txtTime.Text = FormatDateTime(invObj.mTimeIssued)
            'txtUser.Text = objDA.GetUserName(invObj.mUserIdUpdate)
            'txtCounter.Text = objDA.GetPosIdByInvoiceId(pkid)
            salesman = objDA.GetUserName(invObj.salesId)
            txtSales.Text = "Svr:" & objDA.GetUserName(invObj.salesId)
            txtCashier.Text = "Csh:" & objDA.GetUserName(invObj.mUserIdUpdate)
            txtPos.Text = "POS:" & invObj.posId

            txtPosMsg1.Text = gAppConfig.MsgBottom1
            txtPosMsg2.Text = gAppConfig.MsgBottom2
            'txtPosMsg3.Text = gAppConfig.MsgBottom3
            'txtPosMsg4.Text = gAppConfig.MsgBottom4

            ' Set data field 
            txtDesc.DataField = DESC_FIELD
            'txtCode.DataField = DAInvoiceItem.ITEM_CODE
            'txtNo.DataField = NO_FIELD
            txtQty.DataField = DAInvoiceItem.TOTALQTY
            txtPrice.DataField = UNIT_PRICE_FIELD
            'txtDisc.DataField = DAInvoiceItem.UNIT_DISCOUNT
            txtAmount.DataField = AMOUNT_FIELD

            txtTotalQty.DataField = DAInvoiceItem.TOTALQTY
            txtTotalQty.SummaryRunning = SummaryRunning.All
            txtTotalQty.SummaryType = SummaryType.GrandTotal

            'txtTotal.DataField = AMOUNT_FIELD
            'txtTotal.SummaryRunning = SummaryRunning.All
            'txtTotal.SummaryType = SummaryType.GrandTotal

            txtTax.Text = FormatCurrency(invObj.taxAmount)
            'txtDeposit.Text = FormatCurrency(Me.depositAmt)
            txtNetTotal.Text = FormatCurrency(invObj.mTotalAmt + Me.depositAmt)


            txtPay1.Text = ""
            txtPay2.Text = ""
            txtPay1Amt.Text = ""
            txtPay2Amt.Text = ""
            'txtPayment.Text = "Payment Mode: " & receiptObj.paymentMethod
            If Not receiptObj Is Nothing Then

                If receiptObj.paymentMethod <> "" Then
                    txtPay1.Text = receiptObj.paymentMethod
                    txtPay1Amt.Text = FormatCurrency(receiptObj.amount)
                End If

                If receiptObj.cardNumber <> "" Then
                    txtPay1.Text = receiptObj.cardType & " " & receiptObj.GetCardNo(10)
                    txtPay1Amt.Text = ""
                    txtPay2.Text = ""
                    txtPay2Amt.Text = FormatCurrency(receiptObj.amountCard)

                ElseIf receiptObj.cashNotesChange <> 0 Then
                    txtPay1.Text = "CASH"
                    txtPay1Amt.Text = FormatCurrency(receiptObj.cashNotesReceived)
                    txtPay2.Text = "CHANGE"
                    txtPay2Amt.Text = FormatCurrency(receiptObj.cashNotesChange)
                End If
            End If

            ' Get Receipt transaction
            ds = Nothing
            objDA.GetInvoiceItem(Me.pkid, ds)
            Me.DataSource = ds.Tables(0)

        Catch ex As Exception
            Messenger.ShowError("Receipt Printable Error!")
            WriteToLogFile(ex.Message)
        End Try

    End Sub


End Class
