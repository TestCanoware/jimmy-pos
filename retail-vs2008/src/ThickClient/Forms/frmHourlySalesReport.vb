Imports Utils
Imports Utils.General
Imports DataAccess

Public Class frmHourlySalesReport

    Private objDA As New DataAccessNut
    Private FORMTITLE As String = "Hourly Sales Report"

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

        gLoadUsers(cboUser)
        txtCounter.Clear()

        dtpDateFrom.Value = GetTodayDate()
    End Sub

End Class