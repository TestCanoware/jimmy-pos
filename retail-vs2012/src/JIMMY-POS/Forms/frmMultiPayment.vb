Imports Utils
Imports Utils.General

Public Class frmMultiPayment

    Public total As Decimal
    Public amt As Decimal

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If amt - total < 0 Then
            If gConfigObj.MsgPaymentExceedEnabled Then Messenger.ShowWarning(gConfigObj.MsgPaymentExceed)
        Else
            If gConfigObj.MsgTxnConfirmEnabled Then
                If Messenger.ShowQuestion(gConfigObj.MsgTxnConfirm, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblTotal.Text = gCurrency & " " & FormatCurrency(total)

        cboYear.Items.Clear()
        For i As Integer = 0 To 9
            cboYear.Items.Add(Now.AddYears(i).Year)
        Next

        cboMonth.Items.Clear()
        For i As Integer = 1 To 12
            cboMonth.Items.Add(MonthName(i))
        Next
    End Sub

    Private Sub txtCash_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCash.KeyPress, txtCC.KeyPress, txtCheque.KeyPress, txtPDCheque.KeyPress, txtOther.KeyPress
        e.Handled = Utils.General.KeyPress("0123456789.", True, e)
    End Sub

    Private Sub txtCash_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCash.Leave, txtCC.Leave, txtCheque.Leave, txtPDCheque.Leave, txtOther.Leave
        Dim amtCash As Decimal = Convert.ToDecimal(txtCash.Text)
        Dim amtCC As Decimal = Convert.ToDecimal(txtCC.Text)
        Dim amtCheque As Decimal = Convert.ToDecimal(txtCheque.Text)
        Dim amtPDCheque As Decimal = Convert.ToDecimal(txtPDCheque.Text)
        Dim amtOther As Decimal = Convert.ToDecimal(txtOther.Text)

        amt = amtCash + amtCC + amtCheque + amtPDCheque + amtOther

        lblTotalAmt.Text = gCurrency & " " & FormatCurrency(amt)

    End Sub


End Class