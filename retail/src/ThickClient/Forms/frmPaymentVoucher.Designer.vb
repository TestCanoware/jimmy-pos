<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaymentVoucher
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
        Me.lblTitle = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnCreate = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnSearchCustomer = New System.Windows.Forms.Button
        Me.txtCustomer = New System.Windows.Forms.TextBox
        Me.lblCustomer = New System.Windows.Forms.Label
        Me.btnRemove = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.colNo = New System.Windows.Forms.ColumnHeader
        Me.colDocument = New System.Windows.Forms.ColumnHeader
        Me.colDesc = New System.Windows.Forms.ColumnHeader
        Me.colAmount = New System.Windows.Forms.ColumnHeader
        Me.lblAmtShow = New System.Windows.Forms.Label
        Me.lblAmount = New System.Windows.Forms.Label
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.lblDate = New System.Windows.Forms.Label
        Me.lblRemarks = New System.Windows.Forms.Label
        Me.txtRemarks = New System.Windows.Forms.TextBox
        Me.lblPayTo = New System.Windows.Forms.Label
        Me.txtPayTo = New System.Windows.Forms.TextBox
        Me.btnSearchCustAcc = New System.Windows.Forms.Button
        Me.txtCustAcc = New System.Windows.Forms.TextBox
        Me.lblCustAccount = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblTitle.Location = New System.Drawing.Point(48, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(274, 35)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Payment Voucher"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ThickClient.My.Resources.Resources.coins
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 32)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnCreate
        '
        Me.btnCreate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCreate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.Location = New System.Drawing.Point(35, 512)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(141, 47)
        Me.btnCreate.TabIndex = 11
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(216, 512)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(141, 47)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel (Esc)"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSearchCustomer)
        Me.GroupBox2.Controls.Add(Me.txtCustomer)
        Me.GroupBox2.Controls.Add(Me.lblCustomer)
        Me.GroupBox2.Controls.Add(Me.btnRemove)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.ListView1)
        Me.GroupBox2.Controls.Add(Me.lblAmtShow)
        Me.GroupBox2.Controls.Add(Me.lblAmount)
        Me.GroupBox2.Controls.Add(Me.dtpDate)
        Me.GroupBox2.Controls.Add(Me.lblDate)
        Me.GroupBox2.Controls.Add(Me.lblRemarks)
        Me.GroupBox2.Controls.Add(Me.txtRemarks)
        Me.GroupBox2.Controls.Add(Me.lblPayTo)
        Me.GroupBox2.Controls.Add(Me.txtPayTo)
        Me.GroupBox2.Controls.Add(Me.btnSearchCustAcc)
        Me.GroupBox2.Controls.Add(Me.txtCustAcc)
        Me.GroupBox2.Controls.Add(Me.lblCustAccount)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(387, 444)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        '
        'btnSearchCustomer
        '
        Me.btnSearchCustomer.Image = Global.ThickClient.My.Resources.Resources.Search_16x16
        Me.btnSearchCustomer.Location = New System.Drawing.Point(347, 14)
        Me.btnSearchCustomer.Name = "btnSearchCustomer"
        Me.btnSearchCustomer.Size = New System.Drawing.Size(25, 25)
        Me.btnSearchCustomer.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.btnSearchCustomer, "Searh Customer")
        Me.btnSearchCustomer.UseVisualStyleBackColor = True
        '
        'txtCustomer
        '
        Me.txtCustomer.Location = New System.Drawing.Point(274, 17)
        Me.txtCustomer.MaxLength = 10
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(67, 20)
        Me.txtCustomer.TabIndex = 4
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Location = New System.Drawing.Point(215, 20)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(51, 13)
        Me.lblCustomer.TabIndex = 3
        Me.lblCustomer.Text = "Customer"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(296, 412)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 10
        Me.btnRemove.Text = "&Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(212, 412)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNo, Me.colDocument, Me.colDesc, Me.colAmount})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 200)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(360, 206)
        Me.ListView1.TabIndex = 82
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'colNo
        '
        Me.colNo.Text = "No"
        Me.colNo.Width = 33
        '
        'colDocument
        '
        Me.colDocument.Text = "Document #"
        Me.colDocument.Width = 71
        '
        'colDesc
        '
        Me.colDesc.Text = "Description"
        Me.colDesc.Width = 179
        '
        'colAmount
        '
        Me.colAmount.Text = "Amount"
        Me.colAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colAmount.Width = 59
        '
        'lblAmtShow
        '
        Me.lblAmtShow.AutoSize = True
        Me.lblAmtShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblAmtShow.Location = New System.Drawing.Point(108, 176)
        Me.lblAmtShow.Name = "lblAmtShow"
        Me.lblAmtShow.Size = New System.Drawing.Size(14, 13)
        Me.lblAmtShow.TabIndex = 81
        Me.lblAmtShow.Text = "0"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(16, 176)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(49, 13)
        Me.lblAmount.TabIndex = 80
        Me.lblAmount.Text = "Amount"
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "yyyy-MM-dd"
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(108, 148)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(92, 20)
        Me.dtpDate.TabIndex = 8
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(20, 152)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(30, 13)
        Me.lblDate.TabIndex = 76
        Me.lblDate.Text = "Date"
        '
        'lblRemarks
        '
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.Location = New System.Drawing.Point(16, 76)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(49, 13)
        Me.lblRemarks.TabIndex = 74
        Me.lblRemarks.Text = "Remarks"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(108, 72)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(264, 68)
        Me.txtRemarks.TabIndex = 7
        '
        'lblPayTo
        '
        Me.lblPayTo.AutoSize = True
        Me.lblPayTo.Location = New System.Drawing.Point(16, 48)
        Me.lblPayTo.Name = "lblPayTo"
        Me.lblPayTo.Size = New System.Drawing.Size(41, 13)
        Me.lblPayTo.TabIndex = 72
        Me.lblPayTo.Text = "Pay To"
        '
        'txtPayTo
        '
        Me.txtPayTo.Location = New System.Drawing.Point(108, 44)
        Me.txtPayTo.Name = "txtPayTo"
        Me.txtPayTo.Size = New System.Drawing.Size(264, 20)
        Me.txtPayTo.TabIndex = 6
        '
        'btnSearchCustAcc
        '
        Me.btnSearchCustAcc.Image = Global.ThickClient.My.Resources.Resources.Search_16x16
        Me.btnSearchCustAcc.Location = New System.Drawing.Point(184, 14)
        Me.btnSearchCustAcc.Name = "btnSearchCustAcc"
        Me.btnSearchCustAcc.Size = New System.Drawing.Size(25, 25)
        Me.btnSearchCustAcc.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.btnSearchCustAcc, "Search Cust Account")
        Me.btnSearchCustAcc.UseVisualStyleBackColor = True
        '
        'txtCustAcc
        '
        Me.txtCustAcc.Location = New System.Drawing.Point(108, 17)
        Me.txtCustAcc.MaxLength = 10
        Me.txtCustAcc.Name = "txtCustAcc"
        Me.txtCustAcc.Size = New System.Drawing.Size(67, 20)
        Me.txtCustAcc.TabIndex = 1
        '
        'lblCustAccount
        '
        Me.lblCustAccount.AutoSize = True
        Me.lblCustAccount.Location = New System.Drawing.Point(16, 20)
        Me.lblCustAccount.Name = "lblCustAccount"
        Me.lblCustAccount.Size = New System.Drawing.Size(71, 13)
        Me.lblCustAccount.TabIndex = 67
        Me.lblCustAccount.Text = "Cust Account"
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.ThickClient.My.Resources.Resources.Print_32x32
        Me.PictureBox2.Location = New System.Drawing.Point(362, 13)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 32)
        Me.PictureBox2.TabIndex = 30
        Me.PictureBox2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox2, "Print")
        '
        'frmPaymentVoucher
        '
        Me.AcceptButton = Me.btnCreate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(404, 565)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPaymentVoucher"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmPaymentVoucher"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearchCustAcc As System.Windows.Forms.Button
    Friend WithEvents txtCustAcc As System.Windows.Forms.TextBox
    Friend WithEvents lblCustAccount As System.Windows.Forms.Label
    Friend WithEvents lblPayTo As System.Windows.Forms.Label
    Friend WithEvents txtPayTo As System.Windows.Forms.TextBox
    Friend WithEvents lblRemarks As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblAmtShow As System.Windows.Forms.Label
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents colNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDocument As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDesc As System.Windows.Forms.ColumnHeader
    Friend WithEvents colAmount As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnSearchCustomer As System.Windows.Forms.Button
    Friend WithEvents txtCustomer As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
