Public Class frmFindCashSale

    Public pkid As Long = 0

    Private Sub frmRemark_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Utils.General.CursorButtons(Me, Cursors.Hand)

        txtCashSale.Text = pkid
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub txtCashSale_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCashSale.KeyPress
        e.Handled = Utils.General.KeyPress("1234567890", True, e)
    End Sub
End Class