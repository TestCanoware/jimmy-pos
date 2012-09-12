Imports Utils
Imports Utils.General

Public Class frmSelectQty

    Public selectQty As Integer
    Public maxQty As Integer

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If txtRemark.Text.Trim.Length = 0 AndAlso gAppConfig.RemarksRequiredDeletingItem Then
            Messenger.ShowWarning(gMSG_ENTER_REMARKS)
            Exit Sub
        End If

        If NumericUpDown1.Value > NumericUpDown1.Maximum Then
            Messenger.ShowWarning("Select qty cannot more than existing qty!")
            Exit Sub
        End If

        If NumericUpDown1.Value = 0 Then
            Messenger.ShowWarning("Select qty cannot be ZERO!")
            Exit Sub
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub


    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub frmSelectQty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AssignValue(gGetLocale(Me.Name, "title"), Me.Text)
        Messenger.Caption = Me.Text
        gSetLocaleChange(Me.Name, Me)

        NumericUpDown1.Maximum = maxQty
        NumericUpDown1.Focus()
        NumericUpDown1.Select(0, Len(NumericUpDown1.Value))
    End Sub

End Class