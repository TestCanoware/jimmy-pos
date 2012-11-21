Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 
Imports Utils
Imports Utils.General
Imports DataAccess

Public Class rptPaymentVoucher

    Private pkid As Long
    Private objDA As New DataAccessNut

    Public Sub New(ByVal pkid As Long)
        MyBase.New()
        InitializeComponent()
        Me.pkid = pkid
    End Sub

    Private Sub rptReceipt_ReportEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportEnd


        Try
            'Me.Document.Print(False, False, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rptJobsheet_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        Dim ds As DataSet = Nothing

        Try
            'Get Deposit
            Dim pvObj As New DAPaymentVoucherObject
            pvObj = objDA.GetPaymentVoucher(pkid)

            txtReportName.Text = "DEPOSIT REFUND"
            txtReceiptID.Text = pkid
            txtTime.Text = FormatDateTime(pvObj.dateStmt)
            txtUser.Text = objDA.GetUserName(pvObj.userIdCreate) & " / " & gSysConfig.PosId
            'txtCounter.Text = gSysConfig.PosId 'TODO: need get from pos_doclink

            ' Get Data
            txtReceived.Text = pvObj.payTo
            txtAmount.Text = FormatCurrency(pvObj.amountTotal)
            txtRemarks.Text = pvObj.remarks

            ' Set Data Fields
            'txtNo.DataField = DAPaymentVoucherItem.POSITION
            txtDocument.DataField = DAPaymentVoucherItem.REFERENCE_NO
            txtDesc.DataField = DAPaymentVoucherItem.ENTITY_NAME
            txtAmt.DataField = DAPaymentVoucherItem.AMOUNT

            ' Get PaymentVoucherItem
            objDA.GetPaymentVoucherItem(pvObj.pkid, ds)
            Dim dv As DataView = ds.Tables(0).DefaultView
            dv.Sort = DAPaymentVoucherItem.POSITION

            Me.DataSource = dv

        Catch ex As Exception
            Messenger.ShowError("Payment Voucher Printable Error!")
            WriteToLogFile(ex.Message)
        End Try

    End Sub

End Class
