Imports Utils
Imports Utils.General
Imports DataAccess

Public Class frmFindItem

    Private FORMTITLE As String = "Find Item"
    Public keywoards As String
    Public price As String
    Public itemCode As String
    Private objDA As New DataAccessNut

    Private Sub frmFindItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AssignValue(gGetLocale(Me.Name, "title"), Me.Text)
        Messenger.Caption = Me.Text
        gSetLocaleChange(Me.Name, Me)

        CursorButtons(Me, Cursors.Hand)

        'Add DataCoulmn
        Dim colItemCode As New System.Windows.Forms.DataGridViewTextBoxColumn
        With colItemCode
            .AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            .DataPropertyName = DAItem.ITEM_CODE
            .HeaderText = gGetLocale(Me.Name, "colItemCode.Text")
            .Name = "colItemCode"
            .ReadOnly = True
        End With

        Dim colName As New System.Windows.Forms.DataGridViewTextBoxColumn
        With colName
            .AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            .DataPropertyName = DAItem.NAME
            .HeaderText = gGetLocale(Me.Name, "colName.Text")
            .Name = "colName"
            .ReadOnly = True
        End With

        Dim colEAN As New System.Windows.Forms.DataGridViewTextBoxColumn
        With colEAN
            .AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            .DataPropertyName = DAItem.EANCODE
            .HeaderText = gGetLocale(Me.Name, "colEAN.Text")
            .Name = "colEAN"
            .ReadOnly = True
        End With

        Dim colQty As New System.Windows.Forms.DataGridViewTextBoxColumn
        With colQty
            .AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            .DataPropertyName = DAStock.BALANCE
            .HeaderText = gGetLocale(Me.Name, "colQty.Text")
            .Name = "colQty"
            .ReadOnly = True
        End With

        Dim colPrice As New System.Windows.Forms.DataGridViewTextBoxColumn
        With colPrice
            .AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            .DataPropertyName = DAItem.PRICELIST
            .HeaderText = gGetLocale(Me.Name, "colPrice.Text")
            .Name = "colPrice"
            .ReadOnly = True
        End With

        colQty.DefaultCellStyle = GetDataGridViewCellStyle(GetType(System.Int16))
        colPrice.DefaultCellStyle = GetDataGridViewCellStyle(GetType(System.Decimal))

        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {colItemCode, colName, colEAN, colQty, colPrice})
        Me.DataGridView1.Focus()

        txtSearch.Text = keywoards
        btnSearch.PerformClick()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If txtSearch.TextLength = 0 Then
            Exit Sub
        End If

        Dim ds As DataSet = Nothing
        ds = objDA.GetItem(txtSearch.Text.Trim, gBranchObj.invLocationId)
        If ds Is Nothing OrElse ds.Tables.Count = 0 OrElse ds.Tables(0).Rows.Count = 0 Then
            Messenger.ShowInformation(gMSG_ITEM_NOT_FOUND)
            Exit Sub
        End If

        With DataGridView1
            .DataSource = ds.Tables(0)
        End With

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
        itemCode = DataGridView1.Rows(index).Cells("colItemCode").Value
        price = DataGridView1.Rows(index).Cells("colPrice").Value
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
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