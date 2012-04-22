Public Class MyDataGrid
    Inherits DataGridView

    Public Event OnEnterKey()

    Private Const WM_KEYDOWN As Integer = &H100
    Private Const WM_KEYUP As Integer = &H101
    Private Const WM_CHAR As Integer = &H102
    'Protected Overrides Sub OnCellValueChanged(ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    '    Trace.WriteLine(Me(e.ColumnIndex, e.RowIndex).Value.ToString)
    '    Trace.WriteLine(e.ColumnIndex)
    '    MyBase.OnCellValueChanged(e)
    'End Sub
    Public Overrides Function PreProcessMessage(ByRef msg As System.Windows.Forms.Message) As Boolean
        Dim keyCode As Keys = CType(msg.WParam.ToInt32(), Keys) And Keys.KeyCode
        ' for a datagrid, we need to eat the tab key oe else its done twice
        If msg.Msg = WM_KEYDOWN AndAlso keyCode = Keys.Enter Then
            'Dim intRow As Integer = Me.CurrentCell.RowIndex
            'Dim intCol As Integer = Me.CurrentCell.ColumnIndex
            'Me.FindForm.SelectNextControl(Me, True, True, False, True)
            RaiseEvent OnEnterKey()
            Return True
        End If
        Return MyBase.PreProcessMessage(msg)
    End Function

    'Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean

    '    'If msg.WParam.ToInt32() = CInt(Keys.Enter) Then

    '    '    SendKeys.Send("{Tab}")

    '    '    Return True

    '    'End If

    '    Return MyBase.ProcessCmdKey(msg, keyData)

    'End Function 'ProcessCmdKey



End Class 'MyDataGrid