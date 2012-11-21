Imports Utils
Imports Utils.General
Imports DataAccess

Public Class frmFindCustAcc

    Private FORMTITLE As String = "Find Customer Account"
    Public keywoards As String
    Private objDA As New DataAccessNut

    Private Sub frmFindCust_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AssignValue(gGetLocale(Me.Name, "title"), Me.Text)
        Messenger.Caption = Me.Text
        gSetLocaleChange(Me.Name, Me)

        CursorButtons(Me, Cursors.Hand)
        'btnSearch.PerformClick()

        'Add DataCoulmn
        Dim col1 As New System.Windows.Forms.DataGridViewTextBoxColumn
        With col1
            .AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            .DataPropertyName = DACustAccount.PKID
            .HeaderText = gGetLocale(Me.Name, "colCustId.Text")
            .Name = "colCustId"
            .ReadOnly = True
        End With

        Dim col2 As New System.Windows.Forms.DataGridViewTextBoxColumn
        With col2
            .AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            .DataPropertyName = DACustAccount.NAME
            .HeaderText = gGetLocale(Me.Name, "colName.Text")
            .Name = "colName"
            .ReadOnly = True
        End With

        Dim col3 As New System.Windows.Forms.DataGridViewTextBoxColumn
        With col3
            .AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            .DataPropertyName = DACustAccount.MOBILE_PHONE
            .HeaderText = gGetLocale(Me.Name, "colContact.Text")
            .Name = "colContact"
            .ReadOnly = True
        End With

        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {col1, col2, col3})
        Me.DataGridView1.Focus()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        If txtSearch.TextLength = 0 Then
            Exit Sub
        End If

        Try
            Dim ds As DataSet
            ds = objDA.GetCustAccount(txtSearch.Text)
            If ds Is Nothing OrElse ds.Tables.Count = 0 OrElse ds.Tables(0).Rows.Count = 0 Then
                Messenger.ShowInformation("Customer Account not found!")
                Exit Sub
            End If

            With DataGridView1
                .DataSource = ds.Tables(0)
            End With

            ' remove column not specific
            For Each dataCol As DataGridViewColumn In Me.DataGridView1.Columns
                If dataCol.DataPropertyName = DACustAccount.PKID OrElse _
                    dataCol.DataPropertyName = DACustAccount.NAME OrElse _
                    dataCol.DataPropertyName = DACustAccount.MOBILE_PHONE Then
                    dataCol.Visible = True
                Else
                    dataCol.Visible = False
                End If
            Next

        Catch ex As Exception
            Messenger.Caption = FORMTITLE & " - SearchButtonClick"
            Messenger.ShowError(ex)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub


    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        RecordSelected(e.RowIndex)
    End Sub

    Private Sub DataGridView1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyUp
        'If e.KeyData = Keys.Enter Then
        '    'Ignore return key
        '    'Dim cur_cell As DataGridViewCell = DataGridView1.CurrentCell
        '    'Dim col As Integer = cur_cell.ColumnIndex
        '    'col = (col + 1) Mod DataGridView1.Columns.Count
        '    'cur_cell = DataGridView1.CurrentRow.Cells(col)
        '    'DataGridView1.CurrentCell = cur_cell

        '    Dim rowIndex As Integer = DataGridView1.SelectedRows(0).Index
        '    If rowIndex <= DataGridView1.RowCount Then
        '        rowIndex -= 1
        '    End If
        '    MsgBox(rowIndex)
        '    RecordSelected(rowIndex)
        'End If

        'If e.KeyCode = Keys.Up Then
        '    If DataGridView1.SelectedRows(0).Index = 0 OrElse DataGridView1.SelectedRows(0).Index = DataGridView1.RowCount - 1 Then
        '        txtSearch.Focus()
        '        txtSearch.SelectAll()
        '    End If
        'End If
    End Sub

    Private Sub RecordSelected(ByVal index As Integer)
        'return custAccId
        Me.keywoards = DataGridView1.Rows(index).Cells("colCustId").Value
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        Select Case e.KeyCode
            Case Keys.Up, Keys.Down
                DataGridView1.Focus()
        End Select
    End Sub

    Private Sub DataGridView1_OnEnterKey() Handles DataGridView1.OnEnterKey
        Dim rowIndex As Integer = DataGridView1.SelectedRows(0).Index
        RecordSelected(rowIndex)
    End Sub

End Class