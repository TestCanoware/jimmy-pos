Imports Utils
Imports Utils.General
Imports DataAccess

Public Class frmSelectHold

    Private FORMTITLE As String = "Select Hold"
    Public arrHold As ArrayList
    Private cManager As CurrencyManager

    Public index As Integer = -1

    Private Sub frmSelectHold_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds As DataSet = Nothing
        AssignValue(gGetLocale(Me.Name, "title"), Me.Text)
        Messenger.Caption = Me.Text
        gSetLocaleChange(Me.Name, Me)
        CursorButtons(Me, Cursors.Hand)

        Try
            If arrHold.Count = 0 Then Exit Sub

            colTime.DataPropertyName = "TxnTime"
            colRemarks.DataPropertyName = "Remarks"
            colAmount.DataPropertyName = "TotalAmount"

            colTime.DefaultCellStyle = GetDataGridViewCellStyle(GetType(System.DateTime))
            colAmount.DefaultCellStyle = GetDataGridViewCellStyle(GetType(System.Decimal))

            MyDataGrid1.DataSource = arrHold

            ' remove column not specific
            For Each dataCol As DataGridViewColumn In MyDataGrid1.Columns
                If dataCol.DataPropertyName = "TxnTime" OrElse _
                    dataCol.DataPropertyName = "Remarks" OrElse _
                    dataCol.DataPropertyName = "TotalAmount" Then

                    dataCol.Visible = True
                Else
                    dataCol.Visible = False
                End If
            Next

            If MyDataGrid1.Rows.Count > 0 Then _
                MyDataGrid1.Rows(0).Selected = True

        Catch ex As Exception
            Messenger.ShowError("Select Hold Listing Error!")
            WriteToLogFile(ex.Message)
        End Try

    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If MyDataGrid1.SelectedRows.Count = 0 Then Exit Sub

        Try
            index = MyDataGrid1.SelectedRows(0).Index
        Catch ex As Exception

        End Try
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub


    Private Sub MyDataGrid1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyDataGrid1.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnOk.PerformClick()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnClearAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearAll.Click
        arrHold.Clear()
        MyDataGrid1.DataSource = Nothing
    End Sub
End Class