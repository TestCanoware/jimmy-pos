Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 
Imports Utils
Imports Utils.General
Imports DataAccess

Public Class rptDailySalesReport1

    Private userId As Integer
    Private dateFrom As Date
    Private dateTo As Date
    Private posId As Integer
    Private totalSales As Decimal
    Private totalBill As Integer
    Private title As String
    Private objDA As New DataAccessNut


    Public Sub New(ByVal userId As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, ByVal posId As Integer, ByVal title As String)
        MyBase.New()
        InitializeComponent()
        Me.userId = userId
        Me.dateFrom = dateFrom
        Me.dateTo = dateTo
        Me.posId = posId
        Me.title = title
    End Sub


    Private Sub rptDailySalesReport_FetchData(ByVal sender As Object, ByVal eArgs As DataDynamics.ActiveReports.ActiveReport3.FetchEventArgs) Handles Me.FetchData

        Try
            If Me.DataSource Is Nothing Then Exit Sub

            'Dim quantity As Double = Convert.ToDouble(Me.Fields("Quantity").Value, CultureInfo.CurrentCulture)
            Dim unitPrice As Decimal = Convert.ToDecimal(Me.Fields("total_amt").Value)
            'Dim discount As Double = Convert.ToDouble(Me.Fields("Discount").Value, CultureInfo.CurrentCulture)

            ' Now perform the calculation for our added calculated field:
            'Me.Fields("ExtendedPrice").Value = quantity * unitPrice - quantity * unitPrice * discount

            Dim percentage As Decimal = 0.0
            If unitPrice <> 0 Then
                percentage = (unitPrice / totalSales)
            End If
            txtPercentage.Text = Format(percentage, "0.00%")
        Catch ex As Exception

        End Try
    End Sub


    Private Sub rptDailySalesReport_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart

        Dim ds As DataSet = Nothing
        Try

            txtReportName.Text = title
            txtDate.Text = FormatDateTime(dateFrom) & " TO " & FormatDateTime(dateTo)
            txtTime.Text = GetNow()
            txtUser.Text = IIf(Me.userId = 0, "ALL", objDA.GetUserName(Me.userId)) & " / " & IIf(Me.posId = 0, "ALL", posId)


            ' Get All Sales
            ds = Nothing
            totalSales = 0
            ds = objDA.GetDailySalesReport(Me.userId, Me.dateFrom, Me.dateTo, Me.posId)
            If ds IsNot Nothing AndAlso Not ds.Tables(0).Rows.Count = 0 Then
                If Not ds.Tables(0).Rows(0)("sum").ToString = "" Then

                    totalBill = ds.Tables(0).Rows(0)("count")
                    totalSales = ds.Tables(0).Rows(0)("sum")

                    txtTotalCashBill.Text = FormatInt(totalBill)
                    txtTotal1.Text = FormatCurrency(totalSales)

                    txtQtySales.Text = FormatInt(totalBill)
                    txtAmtSales.Text = FormatCurrency(totalSales)
                End If
            End If

            ' Get Cash Sales
            ds = Nothing
            ds = objDA.GetDailySalesReportByType(Me.userId, Me.dateFrom, Me.dateTo, Me.posId, "CASH")
            If ds IsNot Nothing AndAlso Not ds.Tables(0).Rows.Count = 0 Then
                If Not ds.Tables(0).Rows(0)("sum").ToString = "" Then

                    txtTotalCashQty.Text = FormatInt(ds.Tables(0).Rows(0)("count"))
                    txtTotalCash.Text = FormatCurrency(ds.Tables(0).Rows(0)("sum"))

                    txtQtyCashSale.Text = FormatInt(ds.Tables(0).Rows(0)("count"))
                    txtAmtCashSales.Text = FormatCurrency(ds.Tables(0).Rows(0)("sum"))

                End If
            End If

            ' Get VISA Sales
            ds = Nothing
            ds = objDA.GetDailySalesReportByType(Me.userId, Me.dateFrom, Me.dateTo, Me.posId, "CARD", "VISA")
            If ds IsNot Nothing AndAlso Not ds.Tables(0).Rows.Count = 0 Then
                If Not ds.Tables(0).Rows(0)("sum").ToString = "" Then

                    txtVisaQty.Text = FormatInt(ds.Tables(0).Rows(0)("count"))
                    txtVisaAmt.Text = FormatCurrency(ds.Tables(0).Rows(0)("sum"))

                End If
            End If

            ' Get MASTER Sales
            ds = Nothing
            ds = objDA.GetDailySalesReportByType(Me.userId, Me.dateFrom, Me.dateTo, Me.posId, "CARD", "MASTER")
            If ds IsNot Nothing AndAlso Not ds.Tables(0).Rows.Count = 0 Then
                If Not ds.Tables(0).Rows(0)("sum").ToString = "" Then

                    txtMasterQty.Text = FormatInt(ds.Tables(0).Rows(0)("count"))
                    txtMasterAmt.Text = FormatCurrency(ds.Tables(0).Rows(0)("sum"))

                End If
            End If

            ' Get AMEX Sales
            ds = Nothing
            ds = objDA.GetDailySalesReportByType(Me.userId, Me.dateFrom, Me.dateTo, Me.posId, "CARD", "AMEX")
            If ds IsNot Nothing AndAlso Not ds.Tables(0).Rows.Count = 0 Then
                If Not ds.Tables(0).Rows(0)("sum").ToString = "" Then

                    txtAmexQty.Text = FormatInt(ds.Tables(0).Rows(0)("count"))
                    txtAmexAmt.Text = FormatCurrency(ds.Tables(0).Rows(0)("sum"))

                End If
            End If

            ' Get China Union Pay Sales
            ds = Nothing
            ds = objDA.GetDailySalesReportByType(Me.userId, Me.dateFrom, Me.dateTo, Me.posId, "CARD", "China Union Pay")
            If ds IsNot Nothing AndAlso Not ds.Tables(0).Rows.Count = 0 Then
                If Not ds.Tables(0).Rows(0)("sum").ToString = "" Then

                    txtChinaQty.Text = FormatInt(ds.Tables(0).Rows(0)("count"))
                    txtChinaAmt.Text = FormatCurrency(ds.Tables(0).Rows(0)("sum"))

                End If
            End If

            ' Get JCB Card Sales
            ds = Nothing
            ds = objDA.GetDailySalesReportByType(Me.userId, Me.dateFrom, Me.dateTo, Me.posId, "CARD", "JCB Card")
            If ds IsNot Nothing AndAlso Not ds.Tables(0).Rows.Count = 0 Then
                If Not ds.Tables(0).Rows(0)("sum").ToString = "" Then

                    txtJcbQty.Text = FormatInt(ds.Tables(0).Rows(0)("count"))
                    txtJcbAmt.Text = FormatCurrency(ds.Tables(0).Rows(0)("sum"))

                End If
            End If

            ' Get Nets Sales
            ds = Nothing
            ds = objDA.GetDailySalesReportByType(Me.userId, Me.dateFrom, Me.dateTo, Me.posId, "CARD", "Nets")
            If ds IsNot Nothing AndAlso Not ds.Tables(0).Rows.Count = 0 Then
                If Not ds.Tables(0).Rows(0)("sum").ToString = "" Then

                    txtNetsQty.Text = FormatInt(ds.Tables(0).Rows(0)("count"))
                    txtNetsAmt.Text = FormatCurrency(ds.Tables(0).Rows(0)("sum"))

                End If
            End If


            ' Get Cheque Sales
            ds = Nothing
            ds = objDA.GetDailySalesReportByType(Me.userId, Me.dateFrom, Me.dateTo, Me.posId, "CHEQUE")
            If ds IsNot Nothing AndAlso Not ds.Tables(0).Rows.Count = 0 Then
                If Not ds.Tables(0).Rows(0)("sum").ToString = "" Then

                    txtTotalChequeQty.Text = FormatInt(ds.Tables(0).Rows(0)("count"))
                    txtTotalCheque.Text = FormatCurrency(ds.Tables(0).Rows(0)("sum"))

                End If
            End If

            ' Get Coupon Sales
            ds = Nothing
            ds = objDA.GetDailySalesReportByType(Me.userId, Me.dateFrom, Me.dateTo, Me.posId, "COUPON")
            If ds IsNot Nothing AndAlso Not ds.Tables(0).Rows.Count = 0 Then
                If Not ds.Tables(0).Rows(0)("sum").ToString = "" Then

                    txtTotalVoucherQty.Text = FormatInt(ds.Tables(0).Rows(0)("count"))
                    txtTotalVoucher.Text = FormatCurrency(ds.Tables(0).Rows(0)("sum"))

                End If
            End If

            ' Get Cheque Sales
            ds = Nothing
            ds = objDA.GetDailySalesReportByType(Me.userId, Me.dateFrom, Me.dateTo, Me.posId, "CHEQUE")
            If ds IsNot Nothing AndAlso Not ds.Tables(0).Rows.Count = 0 Then
                If Not ds.Tables(0).Rows(0)("sum").ToString = "" Then

                    txtTotalChequeQty.Text = FormatInt(ds.Tables(0).Rows(0)("count"))
                    txtTotalCheque.Text = FormatCurrency(ds.Tables(0).Rows(0)("sum"))

                End If
            End If

            ' Get Other Sales
            ds = Nothing
            ds = objDA.GetDailySalesReportByType(Me.userId, Me.dateFrom, Me.dateTo, Me.posId, "OTHER")
            If ds IsNot Nothing AndAlso Not ds.Tables(0).Rows.Count = 0 Then
                If Not ds.Tables(0).Rows(0)("sum").ToString = "" Then

                    txtTotalOtherQty.Text = FormatInt(ds.Tables(0).Rows(0)("count"))
                    txtTotalOther.Text = FormatCurrency(ds.Tables(0).Rows(0)("sum"))

                End If
            End If

            ' Get Subreport
            SubReport1.Report = New rptDailySalesReport_CardDetails(Me.userId, Me.dateFrom, Me.dateTo, Me.posId)

            ' Get Department Sales
            ds = Nothing
            ds = objDA.GetDailySalesSummaryReport(Me.userId, Me.dateFrom, Me.dateTo, Me.posId)
            If Not ds.Tables(0).Rows.Count = 0 Then
                Me.DataSource = ds.Tables(0)
            End If

            ' Get Cash In and Out
            ds = Nothing
            Dim totalAmt As Decimal = 0
            ds = objDA.GetCashInOutSummary(Me.userId, Me.dateFrom, Me.dateTo, Me.posId)
            If ds IsNot Nothing Then
                For Each row As DataRow In ds.Tables(0).Rows
                    If row("status").ToString = DAPosCashInOut.STATUS_CASH_IN Then
                        txtQtyCashIn.Text = row("count").ToString
                        txtAmtCashIn.Text = FormatCurrency(row("sum"))
                    Else
                        txtQtyCashOut.Text = row("count").ToString
                        txtAmtCashOut.Text = FormatCurrency(row("sum"))
                    End If
                    totalAmt += row("sum")
                Next
            End If

            txtTotalDrawer.Text = FormatCurrency(totalAmt + txtAmtCashSales.Text)

        Catch ex As Exception
            Messenger.ShowError("Daily Sales Report Error!")
            WriteToLogFile(ex.Message)
        End Try
    End Sub

End Class
