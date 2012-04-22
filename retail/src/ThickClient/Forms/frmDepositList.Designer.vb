<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepositList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDepositList))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tbNew = New System.Windows.Forms.ToolStripButton
        Me.tbRemove = New System.Windows.Forms.ToolStripButton
        Me.tbRefresh = New System.Windows.Forms.ToolStripButton
        Me.tbShowAll = New System.Windows.Forms.ToolStripButton
        Me.tbClose = New System.Windows.Forms.ToolStripButton
        Me.pDetails = New System.Windows.Forms.Panel
        Me.DataGridView1 = New ThickClient.MyDataGrid
        Me.pBottom = New System.Windows.Forms.Panel
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnConfirm = New System.Windows.Forms.Button
        Me.ToolStrip1.SuspendLayout()
        Me.pDetails.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.LightCyan
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbNew, Me.tbRemove, Me.tbRefresh, Me.tbShowAll, Me.tbClose})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(567, 52)
        Me.ToolStrip1.TabIndex = 46
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tbNew
        '
        Me.tbNew.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNew.ForeColor = System.Drawing.Color.Black
        Me.tbNew.Image = Global.ThickClient.My.Resources.Resources.New_32x32
        Me.tbNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbNew.Name = "tbNew"
        Me.tbNew.Size = New System.Drawing.Size(36, 49)
        Me.tbNew.Text = "&New"
        Me.tbNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tbRemove
        '
        Me.tbRemove.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRemove.ForeColor = System.Drawing.Color.Black
        Me.tbRemove.Image = Global.ThickClient.My.Resources.Resources.Remove_32x32
        Me.tbRemove.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbRemove.Name = "tbRemove"
        Me.tbRemove.Size = New System.Drawing.Size(50, 49)
        Me.tbRemove.Text = "&Remove"
        Me.tbRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tbRemove.Visible = False
        '
        'tbRefresh
        '
        Me.tbRefresh.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRefresh.ForeColor = System.Drawing.Color.Black
        Me.tbRefresh.Image = Global.ThickClient.My.Resources.Resources.Refresh_32x32
        Me.tbRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbRefresh.Name = "tbRefresh"
        Me.tbRefresh.Size = New System.Drawing.Size(49, 49)
        Me.tbRefresh.Text = "Re&fresh"
        Me.tbRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tbShowAll
        '
        Me.tbShowAll.ForeColor = System.Drawing.Color.Black
        Me.tbShowAll.Image = Global.ThickClient.My.Resources.Resources.Preview_32x32
        Me.tbShowAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbShowAll.Name = "tbShowAll"
        Me.tbShowAll.Size = New System.Drawing.Size(51, 49)
        Me.tbShowAll.Text = "Show &All"
        Me.tbShowAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tbClose
        '
        Me.tbClose.ForeColor = System.Drawing.Color.Black
        Me.tbClose.Image = Global.ThickClient.My.Resources.Resources.Log_Out_32x32
        Me.tbClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbClose.Name = "tbClose"
        Me.tbClose.Size = New System.Drawing.Size(37, 49)
        Me.tbClose.Text = "&Close"
        Me.tbClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tbClose.Visible = False
        '
        'pDetails
        '
        Me.pDetails.Controls.Add(Me.DataGridView1)
        Me.pDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pDetails.Location = New System.Drawing.Point(0, 52)
        Me.pDetails.Name = "pDetails"
        Me.pDetails.Size = New System.Drawing.Size(567, 196)
        Me.pDetails.TabIndex = 47
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(567, 196)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 4
        '
        'pBottom
        '
        Me.pBottom.BackColor = System.Drawing.SystemColors.Control
        Me.pBottom.Controls.Add(Me.btnCancel)
        Me.pBottom.Controls.Add(Me.btnConfirm)
        Me.pBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pBottom.Location = New System.Drawing.Point(0, 248)
        Me.pBottom.Name = "pBottom"
        Me.pBottom.Size = New System.Drawing.Size(567, 70)
        Me.pBottom.TabIndex = 48
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(311, 11)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(141, 47)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel (Esc)"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(108, 11)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(141, 47)
        Me.btnConfirm.TabIndex = 5
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'frmDepositList
        '
        Me.AcceptButton = Me.btnConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(567, 318)
        Me.Controls.Add(Me.pDetails)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.pBottom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDepositList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDepositList"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.pDetails.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBottom.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As ThickClient.MyDataGrid
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tbNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbRemove As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents pDetails As System.Windows.Forms.Panel
    Friend WithEvents pBottom As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents tbRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbShowAll As System.Windows.Forms.ToolStripButton
End Class
