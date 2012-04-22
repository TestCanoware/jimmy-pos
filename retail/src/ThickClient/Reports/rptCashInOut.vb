Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 
Imports Utils
Imports Utils.General
Imports DataAccess

Public Class rptCashInOut

    Private pkid As Integer
    Private objDA As New DataAccessNut

    Public Sub New(ByVal pkid As Integer)
        MyBase.New()
        InitializeComponent()
        Me.pkid = pkid
    End Sub

    Private Sub rptReceipt_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart

        Dim obj As New DAPosCashInOutObject

        Try
            txtReceiptID.Text = pkid
            txtTime.Text = GetNow()

            obj = objDA.GetPosCashInOut(pkid)
            If obj IsNot Nothing Then
                txtReceiptID.Text = pkid
                txtUser.Text = objDA.GetUserName(obj.userId) & " / " & gSysConfig.PosId
                txtAmount.Text = FormatCurrency(obj.amount)
                txtStatus.Text = obj.status
                txtRemark.Text = obj.remarks
            End If
           
        Catch ex As Exception
            Messenger.ShowError("Cash In or Out Printable Error!")
            WriteToLogFile(ex.Message)
        End Try

    End Sub

   
End Class
