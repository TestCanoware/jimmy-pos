Imports Utils
Imports Utils.General
Imports DataAccess

Public Class frmFindJobsheet

    Private FORMTITLE As String = "Find Jobsheet"
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
            .DataPropertyName = DAJobsheet.PKID
            .HeaderText = gGetLocale(Me.Name, "colJobsheet.Text")
            .Name = "colJobsheet"
            .ReadOnly = True
        End With

        Dim col2 As New System.Windows.Forms.DataGridViewTextBoxColumn
        With col2
            .AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            .DataPropertyName = DAJobsheet.TIME_CREATED
            .HeaderText = gGetLocale(Me.Name, "colDate.Text")
            .Name = "colDate"
            .ReadOnly = True
        End With

        Dim col3 As New System.Windows.Forms.DataGridViewTextBoxColumn
        With col3
            .AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            .DataPropertyName = DAJobsheet.ENTITY_NAME
            .HeaderText = gGetLocale(Me.Name, "colCustomer.Text")
            .Name = "colCustomer"
            .ReadOnly = True
        End With

        Dim col4 As New System.Windows.Forms.DataGridViewTextBoxColumn
        With col4
            .AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            .DataPropertyName = DAJobsheet.AMOUNT_TOTAL
            .HeaderText = gGetLocale(Me.Name, "colAmount.Text")
            .Name = "colAmount"
            .ReadOnly = True
        End With


        Dim col5 As New System.Windows.Forms.DataGridViewTextBoxColumn
        With col5
            .AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            .DataPropertyName = DAJobsheet.STATE
            .HeaderText = gGetLocale(Me.Name, "colStatus.Text")
            .Name = "colStatus"
            .ReadOnly = True
        End With

        col2.DefaultCellStyle = GetDataGridViewCellStyle(GetType(System.DateTime))
        col4.DefaultCellStyle = GetDataGridViewCellStyle(GetType(System.Decimal))
       
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {col1, col2, col3, col4, col5})
        Me.DataGridView1.Focus()

        Load_cboStatus()

    End Sub


    Private Sub Load_cboStatus()

        With cboStatus
            .Items.Add("ALL")
            .Items.Add(DAJobsheet.STATE_CREATED)
            .Items.Add(DAJobsheet.STATE_INVOICE)

            .SelectedIndex = 0
        End With
    End Sub


    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        If txtSearch.TextLength = 0 Then
            Exit Sub
        End If

        Try
            Dim ds As DataSet
            ds = objDA.GetJobsheet(txtSearch.Text)
            If ds Is Nothing OrElse ds.Tables.Count = 0 OrElse ds.Tables(0).Rows.Count = 0 Then
                Messenger.ShowInformation("Jobsheet not found!")
                Exit Sub
            End If

            Dim dv As New DataView(ds.Tables(0))
            If Not cboStatus.Text = "ALL" Then
                dv.RowFilter = DAJobsheet.STATE & " = " & PreparedStatement(cboStatus.Text)
            End If

            DataGridView1.DataSource = dv

            ' remove column not specific
            For Each dataCol As DataGridViewColumn In Me.DataGridView1.Columns
                If dataCol.DataPropertyName = DAJobsheet.PKID OrElse _
                    dataCol.DataPropertyName = DAJobsheet.ENTITY_NAME OrElse _
                    dataCol.DataPropertyName = DAJobsheet.TIME_CREATED OrElse _
                    dataCol.DataPropertyName = DAJobsheet.AMOUNT_TOTAL OrElse _
                    dataCol.DataPropertyName = DAJobsheet.STATE Then
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
        'return Jobsheet pkid
        Me.keywoards = DataGridView1.Rows(index).Cells(0).Value
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        Select Case e.KeyCode
            Case Keys.Up, Keys.Down
                DataGridView1.Focus()
            Case Keys.Enter
                btnSearch.PerformClick()
        End Select
    End Sub

    Private Sub DataGridView1_OnEnterKey() Handles DataGridView1.OnEnterKey
        Dim rowIndex As Integer = DataGridView1.SelectedRows(0).Index
        RecordSelected(rowIndex)
    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        Try
            Dim rowIndex As Integer = DataGridView1.SelectedRows(0).Index
            txtJobsheet.Text = DataGridView1.Rows(rowIndex).Cells("col1").Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        If txtJobsheet.TextLength = 0 Then Exit Sub

        Me.keywoards = txtJobsheet.Text.Trim
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub txtJobsheet_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtJobsheet.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                btnSelect.PerformClick()
        End Select
    End Sub

    Private Sub txtJobsheet_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtJobsheet.KeyPress
        e.Handled = Utils.General.KeyPress("0123456789", True, e)
    End Sub

End Class