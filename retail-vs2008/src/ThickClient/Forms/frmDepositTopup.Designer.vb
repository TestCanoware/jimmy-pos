<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepositTopup
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
        Me.lblTotalAmt = New System.Windows.Forms.Label
        Me.lblCurrentTotalDeposit = New System.Windows.Forms.Label
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.lblCustIC = New System.Windows.Forms.Label
        Me.lblCustContact = New System.Windows.Forms.Label
        Me.lblCustName = New System.Windows.Forms.Label
        Me.lblCustomerIcNum = New System.Windows.Forms.Label
        Me.lblCustomerContact = New System.Windows.Forms.Label
        Me.lblCustomerName = New System.Windows.Forms.Label
        Me.grpPaymentType = New System.Windows.Forms.GroupBox
        Me.btnCash = New System.Windows.Forms.Button
        Me.btnOthersPayment = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.txtDepositID = New System.Windows.Forms.TextBox
        Me.lblDeposit = New System.Windows.Forms.Label
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.lblAmountCcy = New System.Windows.Forms.Label
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
        Me.lblTitle.Size = New System.Drawing.Size(250, 35)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Deposit Top ups"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ThickClient.My.Resources.Resources.Money_Calculator
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 32)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTotalAmt)
        Me.GroupBox1.Controls.Add(Me.lblCurrentTotalDeposit)
        Me.GroupBox1.Controls.Add(Me.ListView1)
        Me.GroupBox1.Controls.Add(Me.lblCustIC)
        Me.GroupBox1.Controls.Add(Me.lblCustContact)
        Me.GroupBox1.Controls.Add(Me.lblCustName)
        Me.GroupBox1.Controls.Add(Me.lblCustomerIcNum)
        Me.GroupBox1.Controls.Add(Me.lblCustomerContact)
        Me.GroupBox1.Controls.Add(Me.lblCustomerName)
        Me.GroupBox1.Controls.Add(Me.grpPaymentType)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtDepositID)
        Me.GroupBox1.Controls.Add(Me.lblDeposit)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.lblAmountCcy)
        Me.GroupBox1.Controls.Add(Me.lblAmount)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 342)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'lblTotalAmt
        '
        Me.lblTotalAmt.AutoSize = True
        Me.lblTotalAmt.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmt.ForeColor = System.Drawing.Color.DarkRed
        Me.lblTotalAmt.Location = New System.Drawing.Point(178, 128)
        Me.lblTotalAmt.Name = "lblTotalAmt"
        Me.lblTotalAmt.Size = New System.Drawing.Size(156, 23)
        Me.lblTotalAmt.TabIndex = 85
        Me.lblTotalAmt.Text = "MYR 99,999.00"
        '
        'lblCurrentTotalDeposit
        '
        Me.lblCurrentTotalDeposit.AutoSize = True
        Me.lblCurrentTotalDeposit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentTotalDeposit.Location = New System.Drawing.Point(8, 134)
        Me.lblCurrentTotalDeposit.Name = "lblCurrentTotalDeposit"
        Me.lblCurrentTotalDeposit.Size = New System.Drawing.Size(148, 14)
        Me.lblCurrentTotalDeposit.TabIndex = 84
        Me.lblCurrentTotalDeposit.Text = "Current Total Deposit: "
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 160)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(360, 79)
        Me.ListView1.TabIndex = 83
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Date"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Amount"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 82
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Sales Person"
        Me.ColumnHeader4.Width = 111
        '
        'lblCustIC
        '
        Me.lblCustIC.AutoSize = True
        Me.lblCustIC.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCustIC.Location = New System.Drawing.Point(179, 111)
        Me.lblCustIC.Name = "lblCustIC"
        Me.lblCustIC.Size = New System.Drawing.Size(62, 14)
        Me.lblCustIC.TabIndex = 80
        Me.lblCustIC.Text = "lblCustIC"
        '
        'lblCustContact
        '
        Me.lblCustContact.AutoSize = True
        Me.lblCustContact.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCustContact.Location = New System.Drawing.Point(179, 97)
        Me.lblCustContact.Name = "lblCustContact"
        Me.lblCustContact.Size = New System.Drawing.Size(98, 14)
        Me.lblCustContact.TabIndex = 79
        Me.lblCustContact.Text = "lblCustContact"
        '
        'lblCustName
        '
        Me.lblCustName.AutoSize = True
        Me.lblCustName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCustName.Location = New System.Drawing.Point(179, 81)
        Me.lblCustName.Name = "lblCustName"
        Me.lblCustName.Size = New System.Drawing.Size(82, 14)
        Me.lblCustName.TabIndex = 78
        Me.lblCustName.Text = "lblCustName"
        '
        'lblCustomerIcNum
        '
        Me.lblCustomerIcNum.AutoSize = True
        Me.lblCustomerIcNum.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCustomerIcNum.Location = New System.Drawing.Point(10, 111)
        Me.lblCustomerIcNum.Name = "lblCustomerIcNum"
        Me.lblCustomerIcNum.Size = New System.Drawing.Size(129, 14)
        Me.lblCustomerIcNum.TabIndex = 77
        Me.lblCustomerIcNum.Text = "Customer I/C Num: "
        '
        'lblCustomerContact
        '
        Me.lblCustomerContact.AutoSize = True
        Me.lblCustomerContact.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCustomerContact.Location = New System.Drawing.Point(10, 96)
        Me.lblCustomerContact.Name = "lblCustomerContact"
        Me.lblCustomerContact.Size = New System.Drawing.Size(123, 14)
        Me.lblCustomerContact.TabIndex = 76
        Me.lblCustomerContact.Text = "Customer Contact:"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCustomerName.Location = New System.Drawing.Point(10, 81)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(107, 14)
        Me.lblCustomerName.TabIndex = 75
        Me.lblCustomerName.Text = "Customer Name:"
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
        'btnSearch
        '
        Me.btnSearch.Image = Global.ThickClient.My.Resources.Resources.Search_16x16
        Me.btnSearch.Location = New System.Drawing.Point(252, 55)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(25, 25)
        Me.btnSearch.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.btnSearch, "Search")
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtDepositID
        '
        Me.txtDepositID.Location = New System.Drawing.Point(182, 58)
        Me.txtDepositID.MaxLength = 10
        Me.txtDepositID.Name = "txtDepositID"
        Me.txtDepositID.Size = New System.Drawing.Size(67, 20)
        Me.txtDepositID.TabIndex = 2
        '
        'lblDeposit
        '
        Me.lblDeposit.AutoSize = True
        Me.lblDeposit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDeposit.Location = New System.Drawing.Point(10, 60)
        Me.lblDeposit.Name = "lblDeposit"
        Me.lblDeposit.Size = New System.Drawing.Size(97, 14)
        Me.lblDeposit.TabIndex = 58
        Me.lblDeposit.Text = "Deposit Slip #:"
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
        'lblAmountCcy
        '
        Me.lblAmountCcy.AutoSize = True
        Me.lblAmountCcy.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountCcy.Location = New System.Drawing.Point(116, 17)
        Me.lblAmountCcy.Name = "lblAmountCcy"
        Me.lblAmountCcy.Size = New System.Drawing.Size(67, 29)
        Me.lblAmountCcy.TabIndex = 31
        Me.lblAmountCcy.Text = "MYR"
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
        'frmDepositTopup
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
        Me.Name = "frmDepositTopup"
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
    Friend WithEvents lblAmountCcy As System.Windows.Forms.Label
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents grpPaymentType As System.Windows.Forms.GroupBox
    Friend WithEvents btnCash As System.Windows.Forms.Button
    Friend WithEvents btnOthersPayment As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtDepositID As System.Windows.Forms.TextBox
    Friend WithEvents lblDeposit As System.Windows.Forms.Label
    Friend WithEvents lblCustIC As System.Windows.Forms.Label
    Friend WithEvents lblCustContact As System.Windows.Forms.Label
    Friend WithEvents lblCustName As System.Windows.Forms.Label
    Friend WithEvents lblCustomerIcNum As System.Windows.Forms.Label
    Friend WithEvents lblCustomerContact As System.Windows.Forms.Label
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents lblTotalAmt As System.Windows.Forms.Label
    Friend WithEvents lblCurrentTotalDeposit As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader

End Class
