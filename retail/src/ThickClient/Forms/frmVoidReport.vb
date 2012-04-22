Imports Utils
Imports Utils.General
Imports DataAccess

Public Class frmVoidReport

    Private objDA As New DataAccessNut
    Private FORMTITLE As String = "Void Report"

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCounter.KeyPress
        e.Handled = Utils.General.KeyPress("0123456789", True, e)
    End Sub

    Private Sub frmDailySalesReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AssignValue(gGetLocale(Me.Name, "title"), Me.Text)
        Messenger.Caption = Me.Text
        gSetLocaleChange(Me.Name, Me)

        CursorButtons(Me, Cursors.Hand)

        'dtpDateFrom.CustomFormat = GetDateTimePattern()
        'dtpDateTo.CustomFormat = GetDateTimePattern()

        gLoadUsers(cboUser)
        txtCounter.Clear()
        dtpDateFrom.Value = GetTodayDate()
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Dim frm As New frmSelectEndDayClosing
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            dtpDateFrom.Value = frm.startTime
            dtpDateTo.Value = frm.endTime
        End If
    End Sub
End Class