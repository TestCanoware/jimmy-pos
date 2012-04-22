<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewDeposit
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblRemarks = New System.Windows.Forms.Label
        Me.txtRemarks = New System.Windows.Forms.TextBox
        Me.btnNew = New System.Windows.Forms.Button
        Me.grpPaymentType = New System.Windows.Forms.GroupBox
        Me.btnCash = New System.Windows.Forms.Button
        Me.btnOthersPayment = New System.Windows.Forms.Button
        Me.txtCustIC = New System.Windows.Forms.TextBox
        Me.lblCustomerIcNum = New System.Windows.Forms.Label
        Me.txtCustContact = New System.Windows.Forms.TextBox
        Me.lblCustomerContact = New System.Windows.Forms.Label
        Me.txtCustName = New System.Windows.Forms.TextBox
        Me.lblCustomerName = New System.Windows.Forms.Label
        Me.btnSearchCustomer = New System.Windows.Forms.Button
        Me.txtCustomerID = New System.Windows.Forms.TextBox
        Me.lblCustomerId = New System.Windows.Forms.Label
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.lblTotalCcy = New System.Windows.Forms.Label
        Me.lblAmount = New System.Windows.Forms.Label
        Me.btnConfirm = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.grpPaymentType.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblTitle.Location = New System.Drawing.Point(48, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(200, 35)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "New Deposit"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ThickClient.My.Resources.Resources.Purse
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 32)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblRemarks)
        Me.GroupBox1.Controls.Add(Me.txtRemarks)
        Me.GroupBox1.Controls.Add(Me.btnNew)
        Me.GroupBox1.Controls.Add(Me.grpPaymentType)
        Me.GroupBox1.Controls.Add(Me.txtCustIC)
        Me.GroupBox1.Controls.Add(Me.lblCustomerIcNum)
        Me.GroupBox1.Controls.Add(Me.txtCustContact)
        Me.GroupBox1.Controls.Add(Me.lblCustomerContact)
        Me.GroupBox1.Controls.Add(Me.txtCustName)
        Me.GroupBox1.Controls.Add(Me.lblCustomerName)
        Me.GroupBox1.Controls.Add(Me.btnSearchCustomer)
        Me.GroupBox1.Controls.Add(Me.txtCustomerID)
        Me.GroupBox1.Controls.Add(Me.lblCustomerId)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.lblTotalCcy)
        Me.GroupBox1.Controls.Add(Me.lblAmount)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 342)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'lblRemarks
        '
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemarks.Location = New System.Drawing.Point(10, 173)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(59, 14)
        Me.lblRemarks.TabIndex = 76
        Me.lblRemarks.Text = "Remarks"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(182, 173)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(201, 68)
        Me.txtRemarks.TabIndex = 8
        '
        'btnNew
        '
        Me.btnNew.Image = Global.ThickClient.My.Resources.Resources.New_16x16
        Me.btnNew.Location = New System.Drawing.Point(284, 56)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(24, 25)
        Me.btnNew.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btnNew, "New Customer")
        Me.btnNew.UseVisualStyleBackColor = True
        Me.btnNew.Visible = False
        '
        'grpPaymentType
        '
        Me.grpPaymentType.Controls.Add(Me.btnCash)
        Me.grpPaymentType.Controls.Add(Me.btnOthersPayment)
        Me.grpPaymentType.Location = New System.Drawing.Point(6, 245)
        Me.grpPaymentType.Name = "grpPaymentType"
        Me.grpPaymentType.Size = New System.Drawing.Size(370, 84)
        Me.grpPaymentType.TabIndex = 68
        Me.grpPaymentType.TabStop = False
        Me.grpPaymentType.Text = "Payment Type"
        '
        'btnCash
        '
        Me.btnCash.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCash.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCash.Image = Global.ThickClient.My.Resources.Resources.green_dollar_32x32
        Me.btnCash.Location = New System.Drawing.Point(16, 19)
        Me.btnCash.Name = "btnCash"
        Me.btnCash.Size = New System.Drawing.Size(141, 47)
        Me.btnCash.TabIndex = 9
        Me.btnCash.Text = "Cash"
        Me.btnCash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCash.UseVisualStyleBackColor = True
        '
        'btnOthersPayment
        '
        Me.btnOthersPayment.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOthersPayment.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOthersPayment.Image = Global.ThickClient.My.Resources.Resources.payment
        Me.btnOthersPayment.Location = New System.Drawing.Point(218, 19)
        Me.btnOthersPayment.Name = "btnOthersPayment"
        Me.btnOthersPayment.Size = New System.Drawing.Size(141, 47)
        Me.btnOthersPayment.TabIndex = 10
        Me.btnOthersPayment.Text = "Others Payment"
        Me.btnOthersPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOthersPayment.UseVisualStyleBackColor = True
        '
        'txtCustIC
        '
        Me.txtCustIC.Location = New System.Drawing.Point(182, 147)
        Me.txtCustIC.MaxLength = 30
        Me.txtCustIC.Name = "txtCustIC"
        Me.txtCustIC.Size = New System.Drawing.Size(201, 20)
        Me.txtCustIC.TabIndex = 7
        '
        'lblCustomerIcNum
        '
        Me.lblCustomerIcNum.AutoSize = True
        Me.lblCustomerIcNum.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCustomerIcNum.Location = New System.Drawing.Point(10, 149)
        Me.lblCustomerIcNum.Name = "lblCustomerIcNum"
        Me.lblCustomerIcNum.Size = New System.Drawing.Size(125, 14)
        Me.lblCustomerIcNum.TabIndex = 66
        Me.lblCustomerIcNum.Text = "Customer I/C Num:"
        '
        'txtCustContact
        '
        Me.txtCustContact.Location = New System.Drawing.Point(182, 117)
        Me.txtCustContact.MaxLength = 30
        Me.txtCustContact.Name = "txtCustContact"
        Me.txtCustContact.Size = New System.Drawing.Size(201, 20)
        Me.txtCustContact.TabIndex = 6
        '
        'lblCustomerContact
        '
        Me.lblCustomerContact.AutoSize = True
        Me.lblCustomerContact.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCustomerContact.Location = New System.Drawing.Point(10, 119)
        Me.lblCustomerContact.Name = "lblCustomerContact"
        Me.lblCustomerContact.Size = New System.Drawing.Size(123, 14)
        Me.lblCustomerContact.TabIndex = 64
        Me.lblCustomerContact.Text = "Customer Contact:"
        '
        'txtCustName
        '
        Me.txtCustName.Location = New System.Drawing.Point(182, 87)
        Me.txtCustName.MaxLength = 50
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(201, 20)
        Me.txtCustName.TabIndex = 5
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCustomerName.Location = New System.Drawing.Point(10, 89)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(107, 14)
        Me.lblCustomerName.TabIndex = 62
        Me.lblCustomerName.Text = "Customer Name:"
        '
        'btnSearchCustomer
        '
        Me.btnSearchCustomer.Image = Global.ThickClient.My.Resources.Resources.Search_16x16
        Me.btnSearchCustomer.Location = New System.Drawing.Point(252, 56)
        Me.btnSearchCustomer.Name = "btnSearchCustomer"
        Me.btnSearchCustomer.Size = New System.Drawing.Size(25, 25)
        Me.btnSearchCustomer.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.btnSearchCustomer, "Search")
        Me.btnSearchCustomer.UseVisualStyleBackColor = True
        Me.btnSearchCustomer.Visible = False
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(182, 58)
        Me.txtCustomerID.MaxLength = 10
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(67, 20)
        Me.txtCustomerID.TabIndex = 2
        Me.txtCustomerID.Visible = False
        '
        'lblCustomerId
        '
        Me.lblCustomerId.AutoSize = True
        Me.lblCustomerId.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCustomerId.Location = New System.Drawing.Point(10, 60)
        Me.lblCustomerId.Name = "lblCustomerId"
        Me.lblCustomerId.Size = New System.Drawing.Size(88, 14)
        Me.lblCustomerId.TabIndex = 58
        Me.lblCustomerId.Text = "Customer ID:"
        Me.lblCustomerId.Visible = False
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(182, 14)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(201, 35)
        Me.txtTotal.TabIndex = 1
        Me.txtTotal.Text = "9,999.00"
        '
        'lblTotalCcy
        '
        Me.lblTotalCcy.AutoSize = True
        Me.lblTotalCcy.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCcy.Location = New System.Drawing.Point(116, 17)
        Me.lblTotalCcy.Name = "lblTotalCcy"
        Me.lblTotalCcy.Size = New System.Drawing.Size(67, 29)
        Me.lblTotalCcy.TabIndex = 31
        Me.lblTotalCcy.Text = "MYR"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(7, 16)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(116, 29)
        Me.lblAmount.TabIndex = 30
        Me.lblAmount.Text = "Amount:"
        '
        'btnConfirm
        '
        Me.btnConfirm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfirm.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(35, 398)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(141, 47)
        Me.btnConfirm.TabIndex = 11
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(237, 398)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(141, 47)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel (Esc)"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmNewDeposit
        '
        Me.AcceptButton = Me.btnConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(414, 457)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNewDeposit"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmDeposit"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpPaymentType.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalCcy As System.Windows.Forms.Label
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents btnSearchCustomer As System.Windows.Forms.Button
    Friend WithEvents txtCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerId As System.Windows.Forms.Label
    Friend WithEvents txtCustContact As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerContact As System.Windows.Forms.Label
    Friend WithEvents txtCustName As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents txtCustIC As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerIcNum As System.Windows.Forms.Label
    Friend WithEvents grpPaymentType As System.Windows.Forms.GroupBox
    Friend WithEvents btnCash As System.Windows.Forms.Button
    Friend WithEvents btnOthersPayment As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents lblRemarks As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox

End Class
