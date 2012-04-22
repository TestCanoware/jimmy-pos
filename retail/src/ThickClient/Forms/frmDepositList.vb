Imports Utils
Imports Utils.General
Imports DataAccess

Public Class frmDepositList

#Region " Variable Declarations "

    Private FORMTITLE As String = "Deposit"
    Private objDA As New DataAccessNut
    Public objCustAcc As New DACustAccountObject
    Public objCustUser As New DACustUserObject
    Public arrDocRow As New ArrayList

#End Region

#Region " Initialisation "

    Private Sub frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Initialise()
    End Sub

    Private Sub Initialise()
        If Not objCustUser.pkid = 0 Then
            Me.Text = FORMTITLE & " - " & objCustUser.GetName() & " (" & objCustUser.pkid & ")"
        Else
            Me.Text = FORMTITLE & " - " & objCustAcc.name & " (" & objCustAcc.pkid & ")"
        End If

        AssignValue(gGetLocale(Me.Name, "title"), Me.Text)
        Messenger.Caption = Me.Text
        gSetLocaleChange(Me.Name, Me)

        General.CursorButtons(Me, Cursors.Hand)

        SetupDefaultControls()

        SetEventHanlder()

        Load_dataGrid(False)
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
            .DataPropertyName = DAOfficialReceipt.ENTITY_NAME
            .HeaderText = "Customer Name"
            .Name = "col2"
            .ReadOnly = True
        End With

        Dim col3 As New System.Windows.Forms.DataGridViewTextBoxColumn
        With col3
            .AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            .DataPropertyName = DAOfficialReceipt.LASTUPDATE
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
            .DataPropertyName = DAOfficialReceipt.OPEN_BALANCE
            .HeaderText = "Balance"
            .Name = "col5"
            .ReadOnly = True
        End With

        Dim col6 As New System.Windows.Forms.DataGridViewTextBoxColumn
        With col6
            .AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            .DataPropertyName = "payment"
            .HeaderText = "This Payment"
            .Name = "col6"
            .ReadOnly = False
        End With

        'Set Default cell style
        col3.DefaultCellStyle = GetDataGridViewCellStyle(GetType(DateTime))
        col4.DefaultCellStyle = GetDataGridViewCellStyle(GetType(Decimal))
        col5.DefaultCellStyle = GetDataGridViewCellStyle(GetType(Decimal))
        col6.DefaultCellStyle = GetDataGridViewCellStyle(GetType(Decimal))

        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {col1, col2, col3, col4, col5, col6})
        Me.DataGridView1.Focus()
        Me.DataGridView1.ReadOnly = False

    End Sub

    Private Sub SetEventHanlder()

    End Sub

#End Region

#Region " Load Controls - ComboBox, ListView, ListBox, etc "

    Private Sub Load_dataGrid(ByVal all As Boolean)

        Dim ds As DataSet

        Try
            If all Then
                ds = objDA.GetAllDeposit
            Else
                ds = objDA.GetDeposit(objCustAcc.pkid)
            End If

            AddPaymentColumn(ds.Tables(0))

            DataGridView1.DataSource = ds.Tables(0)

            For Each dataCol As DataGridViewColumn In Me.DataGridView1.Columns
                If dataCol.DataPropertyName = DAOfficialReceipt.PKID OrElse _
                    dataCol.DataPropertyName = DAOfficialReceipt.LASTUPDATE OrElse _
                    dataCol.DataPropertyName = DAOfficialReceipt.OPEN_BALANCE OrElse _
                    dataCol.DataPropertyName = DAOfficialReceipt.AMOUNT OrElse _
                    dataCol.DataPropertyName = "payment" Then
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

#End Region

#Region " Database Updating - Presentation Layer "


#End Region

#Region " Controls Populating, Updating, etc "


    Private Sub ClearControls()

    End Sub


#End Region

#Region " Utility Procedures "

    Private Sub AddPaymentColumn(ByVal table As DataTable)
        Dim name As String = "payment"
        table.Columns.Add(name, GetType(Decimal))

        For Each dr As DataRow In table.Rows
            dr(name) = dr(DAOfficialReceipt.OPEN_BALANCE)
            dr.AcceptChanges()
        Next

        table.AcceptChanges()
    End Sub

#End Region

#Region " Event Handler/Response "

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        If DataGridView1.SelectedRows.Count = 0 Then Exit Sub

        arrDocRow.Clear()
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            Dim pkid As Long = row.Cells("col1").Value
            Dim balance As Decimal = row.Cells("col5").Value
            Dim payment As Decimal = row.Cells("col6").Value

            If payment > balance Then
                Messenger.ShowWarning("The payment of deposit # '" & pkid & "' cannot exceed the balance.")
                row.Cells("col6").Selected = True
                Exit Sub
            End If

            Dim dr As New DocRow
            dr.refKey = pkid
            dr.price = payment
            arrDocRow.Add(dr)
            
        Next

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub tbNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbNew.Click
        Dim frm As New frmNewDeposit
        frm.pkid = objCustUser.pkid
        frm.ShowDialog()

        Load_dataGrid(False)
    End Sub

    Private Sub tbRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbRemove.Click
        If DataGridView1.SelectedRows.Count = 0 Then Exit Sub

        If Messenger.ShowQuestion(gMSG_REMOVE_DEPOSIT, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Try
            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                Dim pkid As Long = row.Cells("col1").Value
                Dim obj As New DAOfficialReceiptObject
                obj = objDA.GetOfficialReceipt(pkid)
                If Not obj Is Nothing Then
                    obj.status = DAOfficialReceipt.STATUS_CANCELLED
                    objDA.UpdateOfficialReceipt(obj, obj.amount)
                End If
            Next

        Catch ex As Exception
            Messenger.Caption = FORMTITLE & "-" & "RemoveButtonClick"
            Messenger.ShowError(ex)
        End Try

    End Sub

    Private Sub tbRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbRefresh.Click
        Load_dataGrid(False)
    End Sub

    Private Sub tbShowAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbShowAll.Click
        Load_dataGrid(True)
    End Sub

    Private Sub tbClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbClose.Click
        btnCancel.PerformClick()
    End Sub

    Private Sub DataGridView1_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError
        Messenger.ShowError("Invalid value!")
    End Sub

#End Region

End Class