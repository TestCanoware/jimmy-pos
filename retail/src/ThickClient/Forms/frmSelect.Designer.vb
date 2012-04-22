<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelect
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
        Me.btnSelect = New System.Windows.Forms.Button
        Me.txtCashSale = New System.Windows.Forms.TextBox
        Me.lblNumber = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(164, 27)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(69, 22)
        Me.btnSelect.TabIndex = 8
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'txtCashSale
        '
        Me.txtCashSale.Location = New System.Drawing.Point(89, 27)
        Me.txtCashSale.MaxLength = 20
        Me.txtCashSale.Name = "txtCashSale"
        Me.txtCashSale.Size = New System.Drawing.Size(69, 20)
        Me.txtCashSale.TabIndex = 7
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNumber.Location = New System.Drawing.Point(12, 30)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(60, 13)
        Me.lblNumber.TabIndex = 9
        Me.lblNumber.Text = "Number #: "
        '
        'frmSelect
        '
        Me.AcceptButton = Me.btnSelect
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(249, 81)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.txtCashSale)
        Me.Controls.Add(Me.lblNumber)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents txtCashSale As System.Windows.Forms.TextBox
    Friend WithEvents lblNumber As System.Windows.Forms.Label
End Class
