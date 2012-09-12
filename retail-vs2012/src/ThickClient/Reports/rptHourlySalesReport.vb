Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 
Imports Utils
Imports Utils.General

Public Class rptHourlySalesReport

    Private userId As Integer
    Private dateFrom As Date
    'Private dateTo As Date
    Private posId As Integer
    Private totalSales As Decimal
    Private objDA As New DataAccessNut

    Public Sub New(ByVal userId As Integer, ByVal dateFrom As Date, ByVal posId As Integer)
        MyBase.New()
        InitializeComponent()
        Me.userId = userId
        Me.dateFrom = dateFrom
        'Me.dateTo = dateTo
        Me.posId = posId
    End Sub

    Private Sub rptDailySalesReport_FetchData(ByVal sender As Object, ByVal eArgs As DataDynamics.ActiveReports.ActiveReport3.FetchEventArgs) Handles Me.FetchData

        ''Dim quantity As Double = Convert.ToDouble(Me.Fields("Quantity").Value, CultureInfo.CurrentCulture)
        'Dim unitPrice As Decimal = Convert.ToDecimal(Me.Fields("total_amt").Value)
        ''Dim discount As Double = Convert.ToDouble(Me.Fields("Discount").Value, CultureInfo.CurrentCulture)

        '' Now perform the calculation for our added calculated field:
        ''Me.Fields("ExtendedPrice").Value = quantity * unitPrice - quantity * unitPrice * discount

        'Dim percentage As Decimal = 0.0
        'If unitPrice <> 0 Then
        '    percentage = (unitPrice / totalSales)
        'End If
        'txtPercentage.Text = Format(percentage, "0.00%")
        Try
            Dim a As New System.Text.ASCIIEncoding
            Dim bytes As Byte() = Me.Fields("hour").Value
            Dim hour As Integer = 0
            If (a.GetString(bytes) <> "") Then
                hour = Convert.ToInt16(a.GetString(bytes))
            End If

            Dim hour1 As Integer = hour + 1

            ''Error null
            'txtCashier.Text = Me.Fields("username").Value.ToString
            txtHour.Text = Format(hour, "00") & " - " & Format(hour1, "00")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub rptDailySalesReport_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart

        Dim ds As DataSet = Nothing
        Try
            txtReportName.Text = "HOURLY SALES REPORT"
            txtDate.Text = FormatDateTime(dateFrom)
            txtTime.Text = GetNow()
            txtUser.Text = IIf(Me.userId = 0, "ALL", objDA.getUserName(Me.userId)) & " / " & IIf(Me.posId = 0, "ALL", posId)

            ds = Nothing
            ds = objDA.GetHourlySalesReport(Me.userId, Me.dateFrom, Me.posId)
            Me.DataSource = ds.Tables(0)

        Catch ex As Exception
            Messenger.ShowError("Hourly Sales Report Error!")
            WriteToLogFile(ex.Message)
        End Try
    End Sub


End Class
