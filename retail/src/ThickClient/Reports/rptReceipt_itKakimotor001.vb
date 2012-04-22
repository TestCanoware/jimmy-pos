Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 
Imports Utils
Imports Utils.General

Public Class rptReceipt_itKakimotor001

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

        Try
            txtBranchName.Text = ""
            txtBranchDesc.Text = ""
            txtAdd1.Text = ""
            txtAdd2.Text = ""
            txtAdd3.Text = ""
            txtAdd4.Text = ""
            txtTel.Text = ""

            'objDA.getBranchObject(gBranchID, ds)
            If ds IsNot Nothing AndAlso Not ds.Tables(0).Rows.Count = 0 Then
                With ds.Tables(0).Rows(0)
                    txtBranchName.Text = .Item("name").ToString & " (" & .Item("reg_no") & ")"
                    txtBranchDesc.Text = .Item("description").ToString
                    txtAdd1.Text = .Item("addr1").ToString
                    txtAdd2.Text = .Item("addr2").ToString
                    txtAdd3.Text = .Item("addr3").ToString
                    txtAdd4.Text = .Item("zip").ToString & " " & .Item("state").ToString
                    txtTel.Text = "Tel: " & .Item("phone_no").ToString & ", Fax: " & .Item("fax_no").ToString
                End With
            End If

            ' get InvoiceIndex Object
            ds = Nothing
            Dim dsInvoice As DataSet = Nothing
            'objDA.getInvoiceObject(pkid, ds)
            If ds IsNot Nothing AndAlso Not ds.Tables(0).Rows.Count = 0 Then
                With ds.Tables(0).Rows(0)
                    txtReceiptID.Text = pkid
                    txtTime.Text = CType(.Item("time_issued"), DateTime).ToString("dd MMM yyyy")
                    'txtUser.Text = gUserName '& " " & gUserID
                    'txtSalesman.Text = objDA.getUserName(.Item("sales_id"))
                End With
            End If

            txtTendered.Text = FormatCurrency(Me.cash)

            'txtPosMsg1.Text = gConfigObj.MsgBottom1
            'txtPosMsg2.Text = gConfigObj.MsgBottom2
            'txtPosMsg3.Text = gConfigObj.MsgBottom3
            'txtPosMsg4.Text = gConfigObj.MsgBottom4

            ' get rceipt transaction
            ds = Nothing
            'objDA.getInvoiceItemObject(Me.pkid, ds)
            Me.DataSource = ds.Tables(0)

            txtChange.Text = Decimal.Negate(Me.change)

            If isCard Then _
                txtCash.Text = "CREDIT CARD"
            'Me.Document.Printer.PrinterSettings.Copies = 5

        Catch ex As Exception
            Messenger.ShowError(ex.Message)
        End Try

    End Sub

End Class
