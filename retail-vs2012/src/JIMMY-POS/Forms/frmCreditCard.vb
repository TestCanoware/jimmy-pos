Imports Utils
Imports Utils.General

Public Class frmCreditCard

    Public total As Decimal

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If gConfigObj.MsgTxnConfirmEnabled Then
            If Messenger.ShowQuestion(gConfigObj.MsgTxnConfirm, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Else
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub frmCreditCard_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

End Class