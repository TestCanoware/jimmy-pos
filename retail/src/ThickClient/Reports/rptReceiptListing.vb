Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 
Imports Utils
Imports Utils.General

Public Class rptReceiptListing

    Private userId As Integer
    Private dateFrom As Date
    Private dateTo As Date
    Private posId As Integer
    Private totalSales As Decimal
    Private objDA As New DataAccessNut

    Public Sub New(ByVal userId As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, ByVal posId As Integer)
        MyBase.New()
        InitializeComponent()
        Me.userId = userId
        Me.dateFrom = dateFrom
        Me.dateTo = dateTo
        Me.posId = posId
    End Sub

    Private Sub rptVoidReport_FetchData(ByVal sender As Object, ByVal eArgs As DataDynamics.ActiveReports.ActiveReport3.FetchEventArgs) Handles Me.FetchData

        'Dim quantity As Double = Convert.ToDouble(Me.Fields("Quantity").Value, CultureInfo.CurrentCulture)
        'Dim unitPrice As Decimal = Convert.ToDecimal(Me.Fields("total_amt").Value)
        'Dim discount As Double = Convert.ToDouble(Me.Fields("Discount").Value, CultureInfo.CurrentCulture)

        ' Now perform the calculation for our added calculated field:
        'Me.Fields("ExtendedPrice").Value = quantity * unitPrice - quantity * unitPrice * discount

        'Dim percentage As Decimal = 0.0
        'If unitPrice <> 0 Then
        'percentage = (unitPrice / totalSales)
        'End If
        'txtPercentage.Text = Format(percentage, "0.00%")
    End Sub

    Private Sub rptVoidReport_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart

        Dim ds As DataSet = Nothing
        Try
            txtReportName.Text = "RECEIPT LISTING"
            txtDate.Text = FormatDateTime(dateTo) & " TO " & FormatDateTime(dateTo)
            txtTime.Text = GetNow()
            txtUser.Text = IIf(Me.userId = 0, "ALL", objDA.GetUserName(Me.userId)) & " / " & IIf(Me.posId = 0, "ALL", posId)

            ' get transaction
            ds = Nothing
            ds = objDA.GetReceiptListing(Me.userId, Me.dateFrom, Me.dateTo, Me.posId)
            Me.DataSource = ds.Tables(0)

        Catch ex As Exception
            Messenger.ShowError("Receipt Listing Printable Error!")
            WriteToLogFile(ex.Message)
        End Try
    End Sub

   
End Class
