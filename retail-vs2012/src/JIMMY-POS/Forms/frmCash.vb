Imports Utils
Imports Utils.General

Public Class frmCash

    Public total As Decimal
    Public change As Decimal

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If change > 0 Then
            If gConfigObj.MsgPaymentExceedEnabled Then Messenger.ShowWarning(gConfigObj.MsgPaymentExceed)
        Else
            If gConfigObj.MsgTxnConfirmEnabled Then
                If Messenger.ShowQuestion(gConfigObj.MsgTxnConfirm, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            Else
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub


    Private Sub frmCash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtPay.Focus()
        txtPay.SelectAll()
        lblTotal.Text = "RM " & FormatCurrency(total)
        lblChange.Text = "RM " & FormatCurrency(total)
    End Sub

    Private Sub txtPay_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPay.KeyPress
        e.Handled = Utils.General.KeyPress("0123456789.", True, e)
    End Sub

    Private Sub txtPay_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPay.TextChanged
        Try
            change = total - Convert.ToDecimal(txtPay.Text)
            lblChange.Text = "RM " & FormatCurrency(change)

        Catch ex As Exception
            lblChange.Text = "RM " & FormatCurrency(total)
        End Try

    End Sub

End Class