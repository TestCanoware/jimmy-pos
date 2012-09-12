Imports Utils
Imports Utils.General


Public Class frmSelectSN

    Private objDA As New DataAccessNut
    Public stockId As Integer
    Private dv As New DataView

    Private Sub frmSelectSN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AssignValue(gGetLocale(Me.Name, "title"), Me.Text)
        Messenger.Caption = Me.Text
        gSetLocaleChange(Me.Name, Me)

        CursorButtons(Me, Cursors.Hand)

        Dim ds As New DataSet
        ds = objDA.GetSerialNumbers(stockId)

        dv = ds.Tables(0).DefaultView
        lstSN.DataSource = dv
        lstSN.DisplayMember = "serial"
        lstSN.ValueMember = "serial"
        lstSN.Refresh()

        lstSN.ClearSelected()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub txtKeyword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKeyword.TextChanged
        dv.RowFilter = "serial like '" & txtKeyword.Text.Trim & "%'"
        lstSN.ClearSelected()
    End Sub
End Class