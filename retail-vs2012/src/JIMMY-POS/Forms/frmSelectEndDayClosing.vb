Imports Utils
Imports Utils.General
Imports DataAccess

Public Class frmSelectEndDayClosing

    Public startTime As DateTime = Now
    Public endTime As DateTime = Now
    Private objDA As New DataAccessNut
    Private FORMTITLE As String = "Select End Day Closing"

    Private Sub frmSelectEndDayClosing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds As DataSet = Nothing
        AssignValue(gGetLocale(Me.Name, "title"), Me.Text)
        Messenger.Caption = Me.Text
        gSetLocaleChange(Me.Name, Me)

        CursorButtons(Me, Cursors.Hand)

        Try
            colStartTime.DataPropertyName = DAPosEndDayClosing.TIME_START
            colEndTime.DataPropertyName = DAPosEndDayClosing.TIME_END
            colTotalBill.DataPropertyName = DAPosEndDayClosing.QTY_BILL
            colAmount.DataPropertyName = DAPosEndDayClosing.AMOUNT

            colStartTime.DefaultCellStyle = GetDataGridViewCellStyle(GetType(System.DateTime))
            colEndTime.DefaultCellStyle = GetDataGridViewCellStyle(GetType(System.DateTime))
            colTotalBill.DefaultCellStyle = GetDataGridViewCellStyle(GetType(System.Int16))
            colAmount.DefaultCellStyle = GetDataGridViewCellStyle(GetType(System.Decimal))

            ds = objDA.GetEndDayClosing()
            If ds Is Nothing Then Exit Sub

            MyDataGrid1.DataSource = ds.Tables(0)

            ' remove column not specific
            For Each dataCol As DataGridViewColumn In MyDataGrid1.Columns
                If dataCol.DataPropertyName = DAPosEndDayClosing.TIME_START OrElse _
                    dataCol.DataPropertyName = DAPosEndDayClosing.TIME_END OrElse _
                    dataCol.DataPropertyName = DAPosEndDayClosing.QTY_BILL OrElse _
                    dataCol.DataPropertyName = DAPosEndDayClosing.AMOUNT Then

                    dataCol.Visible = True
                Else
                    dataCol.Visible = False
                End If
            Next

            If MyDataGrid1.Rows.Count > 0 Then _
                MyDataGrid1.Rows(0).Selected = True

        Catch ex As Exception
            Messenger.ShowError("Select End Day Closing Error!")
            WriteToLogFile(ex.Message)
        End Try

    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If MyDataGrid1.SelectedRows.Count = 0 Then Exit Sub

        Dim index As Integer = MyDataGrid1.SelectedRows(0).Index
        Dim strStart As String = MyDataGrid1.Rows(index).Cells(colStartTime.Name).Value
        Dim strEnd As String = MyDataGrid1.Rows(index).Cells(colEndTime.Name).Value

        Try
            startTime = Convert.ToDateTime(strStart)
            endTime = Convert.ToDateTime(strEnd)
        Catch ex As Exception
            WriteToLogFile(FORMTITLE & "-" & ex.Message)
        End Try
    End Sub


    Private Sub MyDataGrid1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyDataGrid1.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnOk.PerformClick()
        End If
    End Sub

End Class