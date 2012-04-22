<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemDetails
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
        Me.txtName = New System.Windows.Forms.TextBox
        Me.btnOk = New System.Windows.Forms.Button
        Me.lblName = New System.Windows.Forms.Label
        Me.lblItemCode = New System.Windows.Forms.Label
        Me.txtItemCode = New System.Windows.Forms.TextBox
        Me.lblTaxCode = New System.Windows.Forms.Label
        Me.cboTaxCode = New System.Windows.Forms.ComboBox
        Me.txtTaxType = New System.Windows.Forms.TextBox
        Me.lblTaxType = New System.Windows.Forms.Label
        Me.txtTaxRate = New System.Windows.Forms.TextBox
        Me.lblTaxRate = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblRemarks = New System.Windows.Forms.Label
        Me.txtRemarks = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(63, 35)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(221, 82)
        Me.txtName.TabIndex = 2
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.Location = New System.Drawing.Point(127, 238)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 6
        Me.btnOk.Text = "&Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(2, 38)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name"
        '
        'lblItemCode
        '
        Me.lblItemCode.AutoSize = True
        Me.lblItemCode.Location = New System.Drawing.Point(2, 12)
        Me.lblItemCode.Name = "lblItemCode"
        Me.lblItemCode.Size = New System.Drawing.Size(55, 13)
        Me.lblItemCode.TabIndex = 3
        Me.lblItemCode.Text = "Item Code"
        '
        'txtItemCode
        '
        Me.txtItemCode.Location = New System.Drawing.Point(63, 9)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(220, 20)
        Me.txtItemCode.TabIndex = 1
        '
        'lblTaxCode
        '
        Me.lblTaxCode.AutoSize = True
        Me.lblTaxCode.Location = New System.Drawing.Point(2, 152)
        Me.lblTaxCode.Name = "lblTaxCode"
        Me.lblTaxCode.Size = New System.Drawing.Size(53, 13)
        Me.lblTaxCode.TabIndex = 4
        Me.lblTaxCode.Text = "Tax Code"
        '
        'cboTaxCode
        '
        Me.cboTaxCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTaxCode.FormattingEnabled = True
        Me.cboTaxCode.Location = New System.Drawing.Point(63, 149)
        Me.cboTaxCode.Name = "cboTaxCode"
        Me.cboTaxCode.Size = New System.Drawing.Size(220, 21)
        Me.cboTaxCode.TabIndex = 4
        '
        'txtTaxType
        '
        Me.txtTaxType.Location = New System.Drawing.Point(63, 176)
        Me.txtTaxType.Name = "txtTaxType"
        Me.txtTaxType.Size = New System.Drawing.Size(220, 20)
        Me.txtTaxType.TabIndex = 5
        '
        'lblTaxType
        '
        Me.lblTaxType.AutoSize = True
        Me.lblTaxType.Location = New System.Drawing.Point(2, 179)
        Me.lblTaxType.Name = "lblTaxType"
        Me.lblTaxType.Size = New System.Drawing.Size(52, 13)
        Me.lblTaxType.TabIndex = 7
        Me.lblTaxType.Text = "Tax Type"
        '
        'txtTaxRate
        '
        Me.txtTaxRate.Location = New System.Drawing.Point(63, 202)
        Me.txtTaxRate.MaxLength = 6
        Me.txtTaxRate.Name = "txtTaxRate"
        Me.txtTaxRate.Size = New System.Drawing.Size(68, 20)
        Me.txtTaxRate.TabIndex = 6
        '
        'lblTaxRate
        '
        Me.lblTaxRate.AutoSize = True
        Me.lblTaxRate.Location = New System.Drawing.Point(2, 205)
        Me.lblTaxRate.Name = "lblTaxRate"
        Me.lblTaxRate.Size = New System.Drawing.Size(51, 13)
        Me.lblTaxRate.TabIndex = 9
        Me.lblTaxRate.Text = "Tax Rate"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(208, 238)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(137, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "%"
        '
        'lblRemarks
        '
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.Location = New System.Drawing.Point(2, 126)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(49, 13)
        Me.lblRemarks.TabIndex = 11
        Me.lblRemarks.Text = "Remarks"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(63, 123)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(220, 20)
        Me.txtRemarks.TabIndex = 3
        '
        'frmItemDetails
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(295, 273)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.lblRemarks)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtTaxRate)
        Me.Controls.Add(Me.lblTaxRate)
        Me.Controls.Add(Me.txtTaxType)
        Me.Controls.Add(Me.lblTaxType)
        Me.Controls.Add(Me.cboTaxCode)
        Me.Controls.Add(Me.lblTaxCode)
        Me.Controls.Add(Me.txtItemCode)
        Me.Controls.Add(Me.lblItemCode)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmItemDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmItemDetails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblItemCode As System.Windows.Forms.Label
    Friend WithEvents txtItemCode As System.Windows.Forms.TextBox
    Friend WithEvents lblTaxCode As System.Windows.Forms.Label
    Friend WithEvents cboTaxCode As System.Windows.Forms.ComboBox
    Friend WithEvents txtTaxType As System.Windows.Forms.TextBox
    Friend WithEvents lblTaxType As System.Windows.Forms.Label
    Friend WithEvents txtTaxRate As System.Windows.Forms.TextBox
    Friend WithEvents lblTaxRate As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblRemarks As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
End Class
