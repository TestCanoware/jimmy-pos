Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 
Imports DataAccess


Public Class rptDailySalesReport_CardDetails 

    Private Const CARD_DETAILS_FIELD = "card_details"
    Private objDA As New DataAccessNut
    Private userId As Integer
    Private dateFrom As Date
    Private dateTo As Date
    Private posId As Integer


    Public Sub New(ByVal userId As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, ByVal posId As Integer)
        MyBase.New()
        InitializeComponent()
        Me.userId = userId
        Me.dateFrom = dateFrom
        Me.dateTo = dateTo
        Me.posId = posId
    End Sub

    Private Sub rptDailySalesReport_CardDetails_DataInitialize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataInitialize
        Me.Fields.Add(CARD_DETAILS_FIELD)
    End Sub

    Private Sub rptDailySalesReport_CardDetails_FetchData(ByVal sender As Object, ByVal eArgs As DataDynamics.ActiveReports.ActiveReport3.FetchEventArgs) Handles Me.FetchData
        Dim cardType As String = Me.Fields(DAOfficialReceipt.CARD_TYPE).Value
        Dim cardNo As String = Me.Fields(DAOfficialReceipt.CARD_NUMBER).Value
        Dim cardValidThru As DateTime = Me.Fields(DAOfficialReceipt.CARD_VALID_THRU).Value

        Me.Fields(CARD_DETAILS_FIELD).Value = ""
        If cardType <> "" Then
            Me.Fields(CARD_DETAILS_FIELD).Value &= cardType
        End If

        If cardNo <> "" Then
            Me.Fields(CARD_DETAILS_FIELD).Value &= "XXXXXX" & cardNo.Substring(cardNo.Length - 10, 10)
        End If

        Me.Fields(CARD_DETAILS_FIELD).Value = Utils.General.FormatDateTime2(cardValidThru)
    End Sub


    Private Sub rptDailySalesReport_CardDetails_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart

        ' Set data field 
        txtInvoiceNo.DataField = "invoice_no"
        txtAmt.DataField = DAOfficialReceipt.AMOUNT_CARD
        txtCardDetails.DataField = CARD_DETAILS_FIELD


        ' Get Receipt transaction
        Dim ds As DataSet = Nothing
        ds = objDA.GetDailyCardDetails(userId, dateFrom, dateTo, posId)

        Me.DataSource = ds.Tables(0)

    End Sub

End Class
