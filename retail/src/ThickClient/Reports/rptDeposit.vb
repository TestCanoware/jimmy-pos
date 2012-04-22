Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 
Imports Utils
Imports Utils.General
Imports DataAccess

Public Class rptDeposit

    Private pkid As Long
    Private objDA As New DataAccessNut

    Private Const AMOUNT_FIELD = "amount"

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

        Try
            'Get Deposit
            Dim receiptObj As New DAOfficialReceiptObject
            receiptObj = objDA.GetOfficialReceipt(pkid)

            txtReportName.Text = "DEPOSIT"
            txtReceiptID.Text = pkid
            txtTime.Text = FormatDateTime(receiptObj.paymentTime)
            txtUser.Text = objDA.GetUserName(receiptObj.userIdUpdate) & " / " & gSysConfig.PosId

            ' Get Data
            txtReceived.Text = receiptObj.GetCustName
            txtRemarks.Text = receiptObj.GetRemarks
            txtAmount.Text = FormatCurrency(receiptObj.GetTotalAmount)

            txtPaymentDetails.MultiLine = True
            If receiptObj.GetTotalAmountCash > 0 Then
                txtPaymentDetails.Text &= "Cash: " & FormatCurrency(receiptObj.GetTotalAmountCash) & " (CB" & receiptObj.cbCash & ")" & vbCrLf
            End If
            If receiptObj.GetTotalAmountCard > 0 Then
                txtPaymentDetails.Text &= "Card: " & FormatCurrency(receiptObj.GetTotalAmountCard) & " (CB" & receiptObj.cbCard & ")" & vbCrLf
            End If
            If receiptObj.GetTotalAmountCheque > 0 Then
                txtPaymentDetails.Text &= "Cheque: " & FormatCurrency(receiptObj.GetTotalAmountCheque) & " (CB" & receiptObj.cbCheque & ")" & vbCrLf
            End If
            If receiptObj.GetTotalAmountPDCheque > 0 Then
                txtPaymentDetails.Text &= "PD Cheque: " & FormatCurrency(receiptObj.GetTotalAmountPDCheque) & " (CB" & receiptObj.cbPDCheque & ")" & vbCrLf
            End If
            If receiptObj.GetTotalAmountCoupon > 0 Then
                txtPaymentDetails.Text &= "Coupon: " & FormatCurrency(receiptObj.GetTotalAmountCoupon) & " (CB" & receiptObj.cbCoupon & ")" & vbCrLf
            End If
            If receiptObj.GetTotalAmountOther > 0 Then
                txtPaymentDetails.Text &= "Other: " & FormatCurrency(receiptObj.GetTotalAmountOther) & " (CB" & receiptObj.cbOther & ")" & vbCrLf
            End If

            ' Set data field 
            txtDate.DataField = "date"
            txtAmt.DataField = "amount"
            txtAmt.Alignment = TextAlignment.Right
            txtSales.DataField = "salesperson"

            'Convert array List to Dataset
            Dim dt As New DataTable

            dt.Columns.Add("date", GetType(String))
            dt.Columns.Add("amount", GetType(Decimal))
            dt.Columns.Add("salesperson", GetType(String))

            For Each obj As DAOfficialReceiptObject In receiptObj.arrItems
                Dim row As DataRow = dt.NewRow
                row("date") = FormatDateTime(obj.lastUpdate)
                row("amount") = FormatCurrency(obj.openBalance)
                row("salesperson") = objDA.GetUserName(obj.userIdUpdate)

                dt.Rows.Add(row)
            Next

            Me.DataSource = dt

        Catch ex As Exception
            Messenger.ShowError("Deposit Printable Error!")
            WriteToLogFile(ex.Message)
        End Try

    End Sub

End Class
