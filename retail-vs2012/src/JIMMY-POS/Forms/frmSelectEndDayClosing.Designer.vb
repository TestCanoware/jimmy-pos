<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectEndDayClosing
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btnOk = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.CommandsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MyDataGrid1 = New JimmyPos.MyDataGrid
        Me.colStartTime = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colEndTime = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTotalBill = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colAmount = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.CommandsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOk.Location = New System.Drawing.Point(260, 239)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "&Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(341, 239)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'CommandsBindingSource
        '
        Me.CommandsBindingSource.DataSource = GetType(DataAccess.Commands)
        '
        'MyDataGrid1
        '
        Me.MyDataGrid1.AllowUserToAddRows = False
        Me.MyDataGrid1.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MyDataGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.MyDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MyDataGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colStartTime, Me.colEndTime, Me.colTotalBill, Me.colAmount})
        Me.MyDataGrid1.Location = New System.Drawing.Point(13, 12)
        Me.MyDataGrid1.MultiSelect = False
        Me.MyDataGrid1.Name = "MyDataGrid1"
        Me.MyDataGrid1.ReadOnly = True
        Me.MyDataGrid1.RowHeadersVisible = False
        Me.MyDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGrid1.Size = New System.Drawing.Size(404, 221)
        Me.MyDataGrid1.StandardTab = True
        Me.MyDataGrid1.TabIndex = 0
        '
        'colStartTime
        '
        Me.colStartTime.FillWeight = 122.0!
        Me.colStartTime.HeaderText = "Start Time"
        Me.colStartTime.Name = "colStartTime"
        Me.colStartTime.ReadOnly = True
        '
        'colEndTime
        '
        Me.colEndTime.FillWeight = 122.0!
        Me.colEndTime.HeaderText = "End Time"
        Me.colEndTime.Name = "colEndTime"
        Me.colEndTime.ReadOnly = True
        '
        'colTotalBill
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colTotalBill.DefaultCellStyle = DataGridViewCellStyle5
        Me.colTotalBill.FillWeight = 70.0!
        Me.colTotalBill.HeaderText = "Total Bill"
        Me.colTotalBill.Name = "colTotalBill"
        Me.colTotalBill.ReadOnly = True
        '
        'colAmount
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colAmount.DefaultCellStyle = DataGridViewCellStyle6
        Me.colAmount.HeaderText = "Amount"
        Me.colAmount.Name = "colAmount"
        Me.colAmount.ReadOnly = True
        '
        'frmSelectEndDayClosing
        '
        Me.AcceptButton = Me.btnOk
        Me.AccessibleDescription = " "
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(429, 269)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.MyDataGrid1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSelectEndDayClosing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSelectEndDayClosing"
        CType(Me.CommandsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MyDataGrid1 As JimmyPos.MyDataGrid
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents CommandsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colStartTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEndTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTotalBill As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAmount As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
