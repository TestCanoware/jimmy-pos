Imports Utils
Imports Utils.General
Imports DataAccess

Public Class frmCashInOut

    Public total As Decimal

    Private Sub frmCashInOut_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        gStopScreenKeyboard()
    End Sub

    Private Sub frmCashInOut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AssignValue(gGetLocale(Me.Name, "title"), Me.Text)
        Messenger.Caption = Me.Text
        gSetLocaleChange(Me.Name, Me)

        txtTotal.Text = "0.00"
        lblAmountCcy.Text = gBranchObj.currency
       
        btnConfirm.Enabled = False
        txtTotal.Focus()

        cboType.Items.Add(DAPosCashInOut.STATUS_CASH_IN)
        cboType.Items.Add(DAPosCashInOut.STATUS_CASH_OUT)

        cboType.SelectedIndex = 1
    End Sub

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub txtTotal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotal.KeyPress
        e.Handled = KeyPressDecimal(sender, e)
    End Sub

    Private Sub txtTotal_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTotal.TextChanged

        Try
            total = Convert.ToDecimal(txtTotal.Text)
        Catch ex As Exception
            total = 0
        End Try


        btnConfirm.Enabled = total > 0
    End Sub

    Private Sub picKeyboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picKeyboard.Click
        gShowScreenKeyboard()
    End Sub

  
End Class
