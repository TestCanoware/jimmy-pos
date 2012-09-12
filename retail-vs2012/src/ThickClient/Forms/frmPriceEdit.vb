Imports Utils
Imports Utils.General

Public Class frmPriceEdit

    Public price As Decimal

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If NumericUpDown1.Value > NumericUpDown1.Maximum Then
            Messenger.ShowWarning("Select qty cannot more than existing qty!")
            Exit Sub
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub


    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub frmSelectQty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NumericUpDown1.Maximum = 100
        NumericUpDown1.Focus()
        NumericUpDown1.Value = 0

        lblPrice.Text = FormatCurrency(price)
        txtPrice.Text = FormatCurrency(price)

        NumericUpDown1.Select(0, NumericUpDown1.Value.ToString.Length - 1)
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        txtPrice.Text = FormatCurrency(price - (price * NumericUpDown1.Value / 100))
    End Sub

    Private Sub txtPrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrice.KeyPress
        e.Handled = Utils.General.KeyPress("0123456789.", True, e)
    End Sub
End Class