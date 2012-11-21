Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 
Imports Utils
Imports Utils.General
Imports DataAccess

Public Class rptDailySalesReport

    Private Const CARD_DETAILS_FIELD = "card_details"

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

    Private Sub rptDailySalesReport_DataInitialize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataInitialize
        Me.Fields.Add(CARD_DETAILS_FIELD)
    End Sub


    Private Sub rptDailySalesReport_FetchData(ByVal sender As Object, ByVal eArgs As DataDynamics.ActiveReports.ActiveReport3.FetchEventArgs) Handles Me.FetchData

        Try
            If Me.DataSource Is Nothing Then Exit Sub

            Dim cardType As String = Me.Fields(DAOfficialReceipt.CARD_TYPE).Value
            Dim cardNo As String = Me.Fields(DAOfficialReceipt.CARD_NUMBER).Value
            Dim cardValidThru As DateTime = Me.Fields(DAOfficialReceipt.CARD_VALID_THRU).Value

            Me.Fields(CARD_DETAILS_FIELD).Value = ""
            If cardType <> "" Then
                Me.Fields(CARD_DETAILS_FIELD).Value &= cardType
            End If

            If cardNo.Length >= 12 Then
                Me.Fields(CARD_DETAILS_FIELD).Value &= " XXXX XXXX " & cardNo.Substring(cardNo.Length - 4, 4)
            End If

            Me.Fields(CARD_DETAILS_FIELD).Value &= " " & Utils.General.FormatDateTime2(cardValidThru)

        Catch ex As Exception
            Utils.General.WriteToLogFile(ex.Message)
        End Try
    End Sub


    Private Sub rptDailySalesReport_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart

        Dim ds As DataSet = Nothing
        Try
            
            txtReportName.Text = title
            txtDate.Text = FormatDateTime(dateFrom) & " TO " & FormatDateTime(dateTo)
            txtTime.Text = Now.ToString("yyyy-MM-dd") & Space(10) & Now.ToString("h:mm:ss tt")
            txtUser.Text = IIf(Me.userId = 0, "ALL", objDA.GetUserName(Me.userId)) & " / " & IIf(Me.posId = 0, "ALL", posId)
            txtBranch.Text = gBranchObj.code

            txtInvoiceNo.DataField = "invoice_no"
            txtAmt.DataField = DAOfficialReceipt.AMOUNT_CARD
            txtCardDetails.DataField = CARD_DETAILS_FIELD

            ' Get All Sales
            ds = Nothing
            totalSales = 0
            ds = objDA.GetDailySalesReport(Me.userId, Me.dateFrom, Me.dateTo, Me.posId)
            If ds IsNot Nothing AndAlso Not ds.Tables(0).Rows.Count = 0 Then
                If Not ds.Tables(0).Rows(0)("sum").ToString = "" Then

                    totalBill = ds.Tables(0).Rows(0)("count")
                    totalSales = ds.Tables(0).Rows(0)("sum")

                    'txtQtySales.Text = FormatInt(totalBill)
                    'txtAmtSales.Text = FormatCurrency(totalSales)
                End If
            End If

            ' Get Cash Sales
            ds = Nothing
            ds = objDA.GetDailySalesReportByType(Me.userId, Me.dateFrom, Me.dateTo, Me.posId, "CASH")
            If ds IsNot Nothing AndAlso Not ds.Tables(0).Rows.Count = 0 Then
                If Not ds.Tables(0).Rows(0)("sum").ToString = "" Then

                    'txtQtyCashSale.Text = FormatInt(ds.Tables(0).Rows(0)("count"))
                    txtAmtCashSales.Text = FormatCurrency(ds.Tables(0).Rows(0)("sum"))

                End If
            End If


            ' Get Card Details Sales
            ds = Nothing
            ds = objDA.GetDailyCardDetails(Me.userId, Me.dateFrom, Me.dateTo, Me.posId)
            If Not ds.Tables(0).Rows.Count = 0 Then
                Me.DataSource = ds.Tables(0)
            End If

            '' Get Void Cash
            'ds = Nothing
            'ds = objDA.GetDailySalesReportVoid(Me.userId, Me.dateFrom, Me.dateTo, Me.posId, "CASH")
            'If ds IsNot Nothing AndAlso Not ds.Tables(0).Rows.Count = 0 Then
            '    If Not ds.Tables(0).Rows(0)("sum").ToString = "" Then

            '        txtVoidQty.Text = FormatInt(ds.Tables(0).Rows(0)("count"))
            '        txtVoidAmt.Text = FormatCurrency(Decimal.Negate(ds.Tables(0).Rows(0)("sum")))

            '    End If
            'End If

            '' Get Void Card
            'ds = Nothing
            'ds = objDA.GetDailySalesReportVoid(Me.userId, Me.dateFrom, Me.dateTo, Me.posId, "CARD")
            'If ds IsNot Nothing AndAlso Not ds.Tables(0).Rows.Count = 0 Then
            '    If Not ds.Tables(0).Rows(0)("sum").ToString = "" Then

            '        txtVoidCardQty.Text = FormatInt(ds.Tables(0).Rows(0)("count"))
            '        txtVoidCardAmt.Text = FormatCurrency(Decimal.Negate(ds.Tables(0).Rows(0)("sum")))

            '    End If
            'End If

            ' Get Cash In and Out
            ds = Nothing
            Dim totalAmt As Decimal = 0
            ds = objDA.GetCashInOutSummary(Me.userId, Me.dateFrom, Me.dateTo, Me.posId)
            If ds IsNot Nothing Then
                For Each row As DataRow In ds.Tables(0).Rows
                    If row("status").ToString = DAPosCashInOut.STATUS_CASH_IN Then
                        'txtQtyCashIn.Text = row("count").ToString
                        txtAmtCashIn.Text = FormatCurrency(row("sum"))
                    Else
                        'txtQtyCashOut.Text = row("count").ToString
                        txtAmtCashOut.Text = FormatCurrency(row("sum"))
                    End If
                    totalAmt += row("sum")
                Next
            End If

            txtTotalDrawer.Text = FormatCurrency(totalAmt + Convert.ToDecimal(txtAmtCashSales.Text))

            'get subreport
            Dim srpt As New rptDailySalesReport_Collection(Me.userId, Me.dateFrom, Me.dateTo, Me.posId)
            Me.srptCollection.Report = srpt

            Dim srptSumm As New rptDailySalesReport_Summary(Me.userId, Me.dateFrom, Me.dateTo, Me.posId)
            Me.srptSummary.Report = srptSumm

        Catch ex As Exception
            Messenger.ShowError("Daily Sales Report Error!")
            WriteToLogFile(ex.Message)
        End Try
    End Sub

End Class
