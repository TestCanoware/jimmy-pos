Imports Utils
Imports Utils.General
Imports DataAccess

Public Class frmDeposit

#Region " Variable Declarations "

    Private FORMTITLE As String = "Deposit"
    Public keyword As String
    Private objDA As New DataAccessNut
    Public objReceipt As New DAOfficialReceiptObject

    Public showTopup As Boolean = True

#End Region

#Region " Initialisation "

    Private Sub frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Initialise()
    End Sub

    Private Sub Initialise()
        AssignValue(gGetLocale(Me.Name, "title"), Me.Text)
        Messenger.Caption = Me.Text
        gSetLocaleChange(Me.Name, Me)

        General.CursorButtons(Me, Cursors.Hand)

        SetupDefaultControls()

        SetEventHanlder()

        btnTopup.Visible = showTopup
    End Sub

    Private Sub SetupDefaultControls()

        'Add DataCoulmn
        Dim col1 As New System.Windows.Forms.DataGridViewTextBoxColumn
        With col1
            .AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            .DataPropertyName = DAOfficialReceipt.PKID
            .HeaderText = "Deposit #"
            .Name = "col1"
            .ReadOnly = True
        End With

        Dim col2 As New System.Windows.Forms.DataGridViewTextBoxColumn
        With col2
            .AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            .DataPropertyName = DAOfficialReceipt.REMARKS_CUST_NAME
            .HeaderText = "Customer Name"
            .Name = "col2"
            .ReadOnly = True
        End With

        Dim col3 As New System.Windows.Forms.DataGridViewTextBoxColumn
        With col3
            .AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            .DataPropertyName = DAOfficialReceipt.PAYMENT_TIME
            .HeaderText = "Date"
            .Name = "col3"
            .ReadOnly = True
        End With

        Dim col4 As New System.Windows.Forms.DataGridViewTextBoxColumn
        With col4
            .AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            .DataPropertyName = DAOfficialReceipt.AMOUNT
            .HeaderText = "Amount"
            .Name = "col4"
            .ReadOnly = True
        End With

        Dim col5 As New System.Windows.Forms.DataGridViewTextBoxColumn
        With col5
            .AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            .DataPropertyName = DAOfficialReceipt.PAYMENT_REMARKS
            .HeaderText = "Remarks"
            .Name = "col5"
            .ReadOnly = True
        End With

        'Dim col5 As New System.Windows.Forms.DataGridViewTextBoxColumn
        'With col5
        '    .AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        '    .DataPropertyName = DAOfficialReceipt.OPEN_BALANCE
        '    .HeaderText = "Balance"
        '    .Name = "col5"
        '    .ReadOnly = True
        'End With

        'Dim col6 As New System.Windows.Forms.DataGridViewTextBoxColumn
        'With col6
        '    .AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        '    .DataPropertyName = "payment"
        '    .HeaderText = "This Payment"
        '    .Name = "col6"
        '    .ReadOnly = False
        'End With

        'Set Default cell style
        col3.DefaultCellStyle = GetDataGridViewCellStyle(GetType(DateTime))
        col4.DefaultCellStyle = GetDataGridViewCellStyle(GetType(Decimal))
        'col5.DefaultCellStyle = GetDataGridViewCellStyle(GetType(Decimal))
        'col6.DefaultCellStyle = GetDataGridViewCellStyle(GetType(Decimal))

        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {col1, col2, col3, col4, col5})
        Me.DataGridView1.Focus()
        Me.DataGridView1.ReadOnly = False

    End Sub

    Private Sub SetEventHanlder()

    End Sub

#End Region

#Region " Load Controls - ComboBox, ListView, ListBox, etc "


#End Region

#Region " Database Updating - Presentation Layer "


#End Region

#Region " Controls Populating, Updating, etc "


    Private Sub ClearControls()

    End Sub


#End Region

#Region " Utility Procedures "

    Private Sub NewButtonClick()

        Dim frm As New frmNewDeposit

        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtDeposit.Text = frm.returnObj.pkid
        End If

    End Sub

    Private Sub TopupButtonClick()

        Dim frm As New frmDepositTopup
        frm.ShowDialog()

    End Sub

    Private Sub PrintButtonClick()
        Dim frm As New frmSelect
        frm.document = "Deposit"
        If Not frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If

        Dim pkid As Long = frm.txtCashSale.Text
        Dim obj As DAOfficialReceiptObject = objDA.GetOfficialReceipt(pkid)
        If obj Is Nothing Then
            Messenger.ShowWarning("The Deposit# '" & pkid & "' does not exist!")
            Exit Sub
        End If

        gShowReport(New rptDeposit(pkid), False)
    End Sub

    Private Sub SearchButtonClick()
        If txtSearch.TextLength = 0 Then Exit Sub

        Dim ds As DataSet

        Try
            ds = objDA.GetDepositFuzzySearch(txtSearch.Text.Trim)

            DataGridView1.DataSource = ds.Tables(0)

            For Each dataCol As DataGridViewColumn In Me.DataGridView1.Columns
                If dataCol.DataPropertyName = DAOfficialReceipt.PKID OrElse _
                    dataCol.DataPropertyName = DAOfficialReceipt.PAYMENT_TIME OrElse _
                    dataCol.DataPropertyName = DAOfficialReceipt.REMARKS_CUST_NAME OrElse _
                    dataCol.DataPropertyName = DAOfficialReceipt.AMOUNT OrElse _
                    dataCol.DataPropertyName = DAOfficialReceipt.PAYMENT_REMARKS Then
                    dataCol.Visible = True
                Else
                    dataCol.Visible = False
                End If
            Next

        Catch ex As Exception
            Messenger.Caption = FORMTITLE & "-" & "Load_dataGrid"
            Messenger.ShowError(ex)
        End Try
    End Sub

    Private Sub SelectButtonClick()
        If txtDeposit.TextLength = 0 Then Exit Sub

        Dim pkid As Integer = txtDeposit.Text.Trim

        objReceipt = objDA.GetOfficialReceipt(pkid)
        If objReceipt Is Nothing Then
            Messenger.ShowWarning("The Deposit# '" & pkid & "' does not exist!")
            Exit Sub
        End If

        If objReceipt.openBalance = 0 Then
            Messenger.ShowWarning("The Deposit# '" & pkid & "' has not open balance!")
            Exit Sub
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

#End Region

#Region " Event Handler/Response "

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        SearchButtonClick()
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
        'return deposit pkid
        Dim pkid As Integer = DataGridView1.Rows(index).Cells("col1").Value

        objReceipt = objDA.GetOfficialReceipt(pkid)
        If objReceipt Is Nothing Then
            Messenger.ShowWarning("The Deposit# '" & pkid & "' does not exist!")
            Exit Sub
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
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
            txtDeposit.Text = DataGridView1.Rows(rowIndex).Cells("col1").Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        SelectButtonClick
    End Sub

    Private Sub txtJobsheet_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDeposit.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                btnSelect.PerformClick()
        End Select
    End Sub

    Private Sub txtJobsheet_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDeposit.KeyPress
        e.Handled = Utils.General.KeyPress("0123456789", True, e)
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        NewButtonClick()
    End Sub

    Private Sub btnTopup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTopup.Click
        TopupButtonClick()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        PrintButtonClick()
    End Sub

#End Region

End Class