Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 
Imports Utils
Imports Utils.General

Public Class rptReceipt_itKakimotor

    Private pkid As Long
    Private cash As Decimal
    Private change As Decimal
    'Private objDA As New DAMain
    Private isCard As Boolean

    Public Sub New(ByVal pkid As Long, ByVal cash As Decimal, ByVal change As Decimal, Optional ByVal isCard As Boolean = False)
        MyBase.New()
        InitializeComponent()
        Me.pkid = pkid
        Me.cash = cash
        Me.change = change
        Me.isCard = isCard
    End Sub

    Private Sub rptReceipt_ReportEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportEnd
        Try
            'Me.Document.Print(False, False, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rptReceipt_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        Dim ds As DataSet = Nothing
        Dim branchCode As String = ""
        Try
            txtBranchName.Text = ""
            txtBranchDesc.Text = ""
            txtAdd1.Text = ""
            txtAdd2.Text = ""
            txtTel.Text = ""
            txtWebsite.Text = ""

            'objDA.getBranchObject(gBranchID, ds)
            If ds IsNot Nothing AndAlso Not ds.Tables(0).Rows.Count = 0 Then
                With ds.Tables(0).Rows(0)
                    txtBranchName.Text = .Item("name").ToString & " (" & .Item("reg_no") & ")"
                    txtBranchDesc.Text = .Item("description").ToString
                    txtAdd1.Text = .Item("addr1").ToString & " " & .Item("addr2").ToString

                    If .Item("addr3").ToString <> "" Then txtAdd2.Text &= .Item("addr3").ToString & " "
                    If .Item("zip").ToString <> "" Then txtAdd2.Text &= .Item("zip").ToString & " "
                    If .Item("state").ToString <> "" Then txtAdd2.Text &= .Item("state").ToString
                    txtTel.Text = "Tel: " & .Item("phone_no").ToString & ", Fax: " & .Item("fax_no").ToString

                    branchCode = .Item("code").ToString
                    txtWebsite.Text = "Website: " & .Item("web_url").ToString

                End With
            End If


            ' get InvoiceIndex Object
            ds = Nothing
            Dim dsInvoice As DataSet = Nothing
            'objDA.getInvoiceObject(pkid, ds)
            If ds IsNot Nothing AndAlso Not ds.Tables(0).Rows.Count = 0 Then
                With ds.Tables(0).Rows(0)
                    txtReceiptID.Text = branchCode & "-" & pkid
                    txtDate.Text = CType(.Item("time_issued"), DateTime).ToString("dd MMM yyyy")
                    'txtSalesman.Text = objDA.getUserName(.Item("sales_id"))
                    txtRemarks.Text = .Item("remarks").ToString
                    txtRefNo.Text = "Ref No: " & pkid.ToString
                End With
            End If

            ' get rceipt transaction
            ds = Nothing
            'objDA.getInvoiceItemObject(Me.pkid, ds)
            Me.DataSource = ds.Tables(0)


        Catch ex As Exception
            Messenger.ShowError(ex.Message)
        End Try

    End Sub

    Public Shared Function ConvertStringToDate(ByVal value As String) As Date
        Return DateTime.ParseExact(value, "yyyy MMM dddd HH:mm tt", Nothing)
    End Function

End Class
