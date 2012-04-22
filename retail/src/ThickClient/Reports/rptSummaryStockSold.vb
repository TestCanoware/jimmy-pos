Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 
Imports Utils
Imports Utils.General

Public Class rptSummaryStockSold

    Private userId As Integer
    Private dateFrom As Date
    Private dateTo As Date
    Private posId As Integer
    Private totalSales As Decimal
    Private objDA As New DataAccessNut

    Private count As Integer = 0
    Public Sub New(ByVal userId As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, ByVal posId As Integer)
        MyBase.New()
        InitializeComponent()
        Me.userId = userId
        Me.dateFrom = dateFrom
        Me.dateTo = dateTo
        Me.posId = posId
    End Sub

    Private Sub rptSummaryStockSold_DataInitialize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataInitialize
        Me.Fields.Add("NO")
    End Sub

    Private Sub rptVoidReport_FetchData(ByVal sender As Object, ByVal eArgs As DataDynamics.ActiveReports.ActiveReport3.FetchEventArgs) Handles Me.FetchData
        count += 1
        Me.Fields("NO").Value = count

    End Sub

    Private Sub rptVoidReport_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart

        Dim ds As DataSet = Nothing
        Try
            txtReportName.Text = "SUMMARY STOCK SOLD REPORT"
            txtDate.Text = FormatDateTime(dateFrom) & " TO " & FormatDateTime(dateTo)
            txtTime.Text = GetNow()
            txtUser.Text = IIf(Me.userId = 0, "ALL", objDA.GetUserName(Me.userId)) & " / " & IIf(Me.posId = 0, "ALL", posId)

            ' get transaction
            ds = Nothing
            ds = objDA.GetSummaryStockSold(Me.userId, Me.dateFrom, Me.dateTo, Me.posId)
            Me.DataSource = ds.Tables(0)

        Catch ex As Exception
            Messenger.ShowError("Summary Stock Sold Printable Error!")
            WriteToLogFile(ex.Message)
        End Try
    End Sub


End Class
