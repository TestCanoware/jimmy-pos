
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document 
Imports Utils.General

Public Class rptDailySalesReport_Collection 

    Private objDA As New DataAccessNut
    Private userId As Integer
    Private dateFrom As Date
    Private dateTo As Date
    Private posId As Integer
    Private totalQty As Integer
    Private totalAmt As Decimal

    Public Sub New(ByVal userId As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, ByVal posId As Integer)
        MyBase.New()
        InitializeComponent()
        Me.userId = userId
        Me.dateFrom = dateFrom
        Me.dateTo = dateTo
        Me.posId = posId
    End Sub

    Private Sub rptDailySalesReport_Collection_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart

        txtName.DataField = "NAME"
        txtQty.DataField = "COUNT"
        txtAmt.DataField = "AMOUNT"
        txtTotalQty.DataField = "COUNT"
        txtTotalAmt.DataField = "AMOUNT"

        'Dim ds As DataSet
        'ds = objDA.GetDailySalesReportCollection(Me.userId, Me.dateFrom, Me.dateTo, Me.posId)
        'If Not ds.Tables(0).Rows.Count = 0 Then
        '    Me.DataSource = ds.Tables(0)
        'End If

        'ds = objDA.GetDailySalesReport(Me.userId, Me.dateFrom, Me.dateTo, Me.posId)
        'If ds IsNot Nothing AndAlso Not ds.Tables(0).Rows.Count = 0 Then
        '    If Not ds.Tables(0).Rows(0)("sum_no_gst").ToString = "" Then
        '        txtTotalAmtNoGST.Text = FormatCurrency(ds.Tables(0).Rows(0)("sum_no_gst"))
        '    End If
        'End If
    End Sub
End Class
