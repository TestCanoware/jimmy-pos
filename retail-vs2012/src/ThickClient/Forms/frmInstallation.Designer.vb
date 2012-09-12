<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInstallation
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
        Me.lblInstall = New System.Windows.Forms.Label
        Me.panel2 = New System.Windows.Forms.Panel
        Me.pictureBox1 = New System.Windows.Forms.PictureBox
        Me.folderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.pnlSecond = New System.Windows.Forms.Panel
        Me.btnAttach = New System.Windows.Forms.Button
        Me.label2 = New System.Windows.Forms.Label
        Me.panel2.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSecond.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblInstall
        '
        Me.lblInstall.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstall.Location = New System.Drawing.Point(104, 39)
        Me.lblInstall.Name = "lblInstall"
        Me.lblInstall.Size = New System.Drawing.Size(393, 35)
        Me.lblInstall.TabIndex = 1
        Me.lblInstall.Text = "Thick Client Installation"
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.White
        Me.panel2.Controls.Add(Me.lblInstall)
        Me.panel2.Controls.Add(Me.pictureBox1)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel2.Location = New System.Drawing.Point(0, 0)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(500, 111)
        Me.panel2.TabIndex = 8
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = Global.ThickClient.My.Resources.Resources.wavelet
        Me.pictureBox1.Location = New System.Drawing.Point(18, 16)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(80, 80)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 0
        Me.pictureBox1.TabStop = False
        '
        'pnlSecond
        '
        Me.pnlSecond.Controls.Add(Me.btnAttach)
        Me.pnlSecond.Controls.Add(Me.label2)
        Me.pnlSecond.Location = New System.Drawing.Point(0, 117)
        Me.pnlSecond.Name = "pnlSecond"
        Me.pnlSecond.Size = New System.Drawing.Size(500, 113)
        Me.pnlSecond.TabIndex = 7
        '
        'btnAttach
        '
        Me.btnAttach.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAttach.Location = New System.Drawing.Point(379, 58)
        Me.btnAttach.Name = "btnAttach"
        Me.btnAttach.Size = New System.Drawing.Size(118, 42)
        Me.btnAttach.TabIndex = 5
        Me.btnAttach.Text = "Next"
        Me.btnAttach.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(6, 11)
        Me.label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(426, 16)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Application is now configuring database. Click Next to continue"
        '
        'frmInstallation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 231)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.pnlSecond)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInstallation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome To"
        Me.panel2.ResumeLayout(False)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSecond.ResumeLayout(False)
        Me.pnlSecond.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents lblInstall As System.Windows.Forms.Label
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents folderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Private WithEvents pnlSecond As System.Windows.Forms.Panel
    Private WithEvents btnAttach As System.Windows.Forms.Button
    Private WithEvents label2 As System.Windows.Forms.Label
End Class
