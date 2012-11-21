Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 
Imports Utils
Imports Utils.General
Imports DataAccess

Public Class rptJobsheet

    Private pkid As Long
    Private objDA As New DataAccessNut
    Private subTotal As Decimal = 0
    Private totalQty As Integer = 0

    Private Const AMOUNT_FIELD = "amount"

    Public Sub New(ByVal pkid As Long)
        MyBase.New()
        InitializeComponent()
        Me.pkid = pkid
    End Sub

    Private Sub rptJobsheet_DataInitialize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataInitialize
        Me.Fields.Add(AMOUNT_FIELD)
    End Sub

    Private Sub rptJobsheet_FetchData(ByVal sender As Object, ByVal eArgs As DataDynamics.ActiveReports.ActiveReport3.FetchEventArgs) Handles Me.FetchData
        Dim qty As Integer = Me.Fields(DAJobsheetItem.QUANTITY).Value
        Dim price As Decimal = Me.Fields(DAJobsheetItem.UNIT_PRICE_STD).Value

        Me.Fields(AMOUNT_FIELD).Value = qty * price
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
            'Get Jobsheet
            Dim jobsheetObj As New DAJobsheetObject
            jobsheetObj = objDA.GetJobsheet(pkid)

            txtReportName.Text = "JOBSHEET"
            txtReceiptID.Text = pkid
            txtTime.Text = FormatDateTime(jobsheetObj.timeCreated)
            txtUser.Text = objDA.GetUserName(jobsheetObj.useridEdit) & " / " & gSysConfig.PosId

            txtPosMsg1.Text = gAppConfig.MsgBottom1
            txtPosMsg2.Text = gAppConfig.MsgBottom2
            txtPosMsg3.Text = gAppConfig.MsgBottom3
            txtPosMsg4.Text = gAppConfig.MsgBottom4

            ' Set data field 
            txtDesc.DataField = DAJobsheetItem.NAME
            txtCode.DataField = DAJobsheetItem.ITEM_CODE
            txtQty.DataField = DAJobsheetItem.QUANTITY
            txtPrice.DataField = DAJobsheetItem.UNIT_PRICE_STD
            txtAmount.DataField = AMOUNT_FIELD

            txtTotalQty.DataField = DAJobsheetItem.QUANTITY
            txtTotalQty.SummaryRunning = SummaryRunning.All
            txtTotalQty.SummaryType = SummaryType.GrandTotal

            txtTotal.DataField = AMOUNT_FIELD
            txtTotal.SummaryRunning = SummaryRunning.All
            txtTotal.SummaryType = SummaryType.GrandTotal

            txtTax.Text = FormatCurrency(jobsheetObj.taxAmount)


            Dim objReceipt As DAOfficialReceiptObject
            objReceipt = objDA.GetReceiptByJobsheet(pkid)
            Dim openBalance As Decimal = 0
            If Not objReceipt Is Nothing Then
                For Each obj As DAOfficialReceiptObject In objReceipt.arrItems
                    openBalance += obj.openBalance
                Next
            End If

            openBalance = Decimal.Negate(openBalance)
            txtDeposit.Text = FormatCurrency(openBalance)
            txtNetTotal.Text = FormatCurrency(jobsheetObj.amountTotal + openBalance)
            
            ' Get JobsheetItem dataset
            ds = Nothing
            objDA.GetJobsheetItem(Me.pkid, ds)
            Me.DataSource = ds.Tables(0)

        Catch ex As Exception
            Messenger.ShowError("Jobsheet Printable Error!")
            WriteToLogFile(ex.Message)
        End Try

    End Sub

    Private Sub ReportFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportFooter1.Format

    End Sub
End Class
