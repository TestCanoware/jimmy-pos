Imports Utils
Imports Utils.General

Public Class frmMessage

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim c As Color = Color.Maroon
        Dim c1 As Color = Me.GroupBox1.BackColor

        If Timer1.Tag = True Then
            lblMessage.ForeColor = c
            lblMessage.BackColor = c1
            Timer1.Tag = False
        Else
            lblMessage.ForeColor = c1
            lblMessage.BackColor = c1
            Timer1.Tag = True
        End If

    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Me.Close()
    End Sub

    Private Sub frmMessage_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AssignValue(gGetLocale(Me.Name, "title"), Me.Text)
        Messenger.Caption = Me.Text
        gSetLocaleChange(Me.Name, Me)
    End Sub
End Class