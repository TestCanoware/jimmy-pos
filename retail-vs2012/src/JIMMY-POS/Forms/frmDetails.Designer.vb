<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetails
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
        Me.txtRemark = New System.Windows.Forms.TextBox
        Me.btnOk = New System.Windows.Forms.Button
        Me.lblRemarks = New System.Windows.Forms.Label
        Me.lblTrackingNo = New System.Windows.Forms.Label
        Me.txtTrackingNo = New System.Windows.Forms.TextBox
        Me.txtBilingHandphone = New System.Windows.Forms.TextBox
        Me.lblBillingHandphone = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(10, 89)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(274, 102)
        Me.txtRemark.TabIndex = 3
        '
        'btnOk
        '
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOk.Location = New System.Drawing.Point(208, 197)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "&Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'lblRemarks
        '
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.Location = New System.Drawing.Point(10, 72)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(49, 13)
        Me.lblRemarks.TabIndex = 2
        Me.lblRemarks.Text = "Remarks"
        '
        'lblTrackingNo
        '
        Me.lblTrackingNo.AutoSize = True
        Me.lblTrackingNo.Location = New System.Drawing.Point(10, 9)
        Me.lblTrackingNo.Name = "lblTrackingNo"
        Me.lblTrackingNo.Size = New System.Drawing.Size(66, 13)
        Me.lblTrackingNo.TabIndex = 3
        Me.lblTrackingNo.Text = "Tracking No"
        '
        'txtTrackingNo
        '
        Me.txtTrackingNo.Location = New System.Drawing.Point(109, 6)
        Me.txtTrackingNo.Name = "txtTrackingNo"
        Me.txtTrackingNo.Size = New System.Drawing.Size(174, 20)
        Me.txtTrackingNo.TabIndex = 1
        '
        'txtBilingHandphone
        '
        Me.txtBilingHandphone.Location = New System.Drawing.Point(109, 41)
        Me.txtBilingHandphone.Name = "txtBilingHandphone"
        Me.txtBilingHandphone.Size = New System.Drawing.Size(174, 20)
        Me.txtBilingHandphone.TabIndex = 2
        '
        'lblBillingHandphone
        '
        Me.lblBillingHandphone.AutoSize = True
        Me.lblBillingHandphone.Location = New System.Drawing.Point(10, 44)
        Me.lblBillingHandphone.Name = "lblBillingHandphone"
        Me.lblBillingHandphone.Size = New System.Drawing.Size(93, 13)
        Me.lblBillingHandphone.TabIndex = 5
        Me.lblBillingHandphone.Text = "Billing Handphone"
        '
        'frmDetails
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 227)
        Me.Controls.Add(Me.txtBilingHandphone)
        Me.Controls.Add(Me.lblBillingHandphone)
        Me.Controls.Add(Me.txtTrackingNo)
        Me.Controls.Add(Me.lblTrackingNo)
        Me.Controls.Add(Me.lblRemarks)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtRemark)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents lblRemarks As System.Windows.Forms.Label
    Friend WithEvents lblTrackingNo As System.Windows.Forms.Label
    Friend WithEvents txtTrackingNo As System.Windows.Forms.TextBox
    Friend WithEvents txtBilingHandphone As System.Windows.Forms.TextBox
    Friend WithEvents lblBillingHandphone As System.Windows.Forms.Label
End Class
