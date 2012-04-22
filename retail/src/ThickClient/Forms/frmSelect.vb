Imports Utils
Imports Utils.General

Public Class frmSelect

    Public pkid As Long = 0
    Public document As String

    Private Sub frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AssignValue(gGetLocale(Me.Name, "title"), Me.Text)
        Messenger.Caption = Me.Text
        gSetLocaleChange(Me.Name, Me)

        CursorButtons(Me, Cursors.Hand)

        'Me.Text = "Select " & document

        'lblJobsheet.Text = document & " #"

        txtCashSale.Text = pkid
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub txtCashSale_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCashSale.KeyPress
        e.Handled = Utils.General.KeyPress("1234567890", True, e)
    End Sub
End Class