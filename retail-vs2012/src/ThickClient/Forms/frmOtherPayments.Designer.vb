<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOtherPayments
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
        Me.btnConfirm = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCoupon = New System.Windows.Forms.TextBox
        Me.lblCoupon = New System.Windows.Forms.Label
        Me.lblTotalAmtShow = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.lblTotalAmount2 = New System.Windows.Forms.Label
        Me.dtpPDChequeDate = New System.Windows.Forms.DateTimePicker
        Me.dtpChequeDate = New System.Windows.Forms.DateTimePicker
        Me.txtOther = New System.Windows.Forms.TextBox
        Me.lblOther = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.lblPDChequeDate = New System.Windows.Forms.Label
        Me.txtPDChequeNo = New System.Windows.Forms.TextBox
        Me.lblPDChequeNo = New System.Windows.Forms.Label
        Me.txtPDCheque = New System.Windows.Forms.TextBox
        Me.lblPDCheque = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lblChequeDate = New System.Windows.Forms.Label
        Me.txtChequeNo = New System.Windows.Forms.TextBox
        Me.lblChequeNo = New System.Windows.Forms.Label
        Me.txtCheque = New System.Windows.Forms.TextBox
        Me.lblCheque = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.txtCCBank = New System.Windows.Forms.TextBox
        Me.lblCCBank = New System.Windows.Forms.Label
        Me.cboCCType = New System.Windows.Forms.ComboBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.txtCard = New System.Windows.Forms.TextBox
        Me.lblCreditCard = New System.Windows.Forms.Label
        Me.txtCash = New System.Windows.Forms.TextBox
        Me.lblCash = New System.Windows.Forms.Label
        Me.cboMonth = New System.Windows.Forms.ComboBox
        Me.cboYear = New System.Windows.Forms.ComboBox
        Me.txtCCAppCode = New System.Windows.Forms.TextBox
        Me.lblCCAprovalCode = New System.Windows.Forms.Label
        Me.lblCCExpiry = New System.Windows.Forms.Label
        Me.txtCCName = New System.Windows.Forms.TextBox
        Me.lblCCName = New System.Windows.Forms.Label
        Me.txtCCNo = New System.Windows.Forms.TextBox
        Me.lblCCNumber = New System.Windows.Forms.Label
        Me.lblTotalAmount = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.picKeyboard = New System.Windows.Forms.PictureBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picKeyboard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblTitle.Location = New System.Drawing.Point(48, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(251, 35)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Other Payments"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ThickClient.My.Resources.Resources.payment
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 32)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnConfirm
        '
        Me.btnConfirm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfirm.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(35, 565)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(141, 47)
        Me.btnConfirm.TabIndex = 3
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(237, 565)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(141, 47)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel (Esc)"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.txtCoupon)
        Me.GroupBox2.Controls.Add(Me.lblCoupon)
        Me.GroupBox2.Controls.Add(Me.lblTotalAmtShow)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.lblTotalAmount2)
        Me.GroupBox2.Controls.Add(Me.dtpPDChequeDate)
        Me.GroupBox2.Controls.Add(Me.dtpChequeDate)
        Me.GroupBox2.Controls.Add(Me.txtOther)
        Me.GroupBox2.Controls.Add(Me.lblOther)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.lblPDChequeDate)
        Me.GroupBox2.Controls.Add(Me.txtPDChequeNo)
        Me.GroupBox2.Controls.Add(Me.lblPDChequeNo)
        Me.GroupBox2.Controls.Add(Me.txtPDCheque)
        Me.GroupBox2.Controls.Add(Me.lblPDCheque)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.lblChequeDate)
        Me.GroupBox2.Controls.Add(Me.txtChequeNo)
        Me.GroupBox2.Controls.Add(Me.lblChequeNo)
        Me.GroupBox2.Controls.Add(Me.txtCheque)
        Me.GroupBox2.Controls.Add(Me.lblCheque)
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.txtCCBank)
        Me.GroupBox2.Controls.Add(Me.lblCCBank)
        Me.GroupBox2.Controls.Add(Me.cboCCType)
        Me.GroupBox2.Controls.Add(Me.GroupBox7)
        Me.GroupBox2.Controls.Add(Me.txtCard)
        Me.GroupBox2.Controls.Add(Me.lblCreditCard)
        Me.GroupBox2.Controls.Add(Me.txtCash)
        Me.GroupBox2.Controls.Add(Me.lblCash)
        Me.GroupBox2.Controls.Add(Me.cboMonth)
        Me.GroupBox2.Controls.Add(Me.cboYear)
        Me.GroupBox2.Controls.Add(Me.txtCCAppCode)
        Me.GroupBox2.Controls.Add(Me.lblCCAprovalCode)
        Me.GroupBox2.Controls.Add(Me.lblCCExpiry)
        Me.GroupBox2.Controls.Add(Me.txtCCName)
        Me.GroupBox2.Controls.Add(Me.lblCCName)
        Me.GroupBox2.Controls.Add(Me.txtCCNo)
        Me.GroupBox2.Controls.Add(Me.lblCCNumber)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 94)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(387, 453)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(19, 374)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(352, 5)
        Me.GroupBox1.TabIndex = 82
        Me.GroupBox1.TabStop = False
        '
        'txtCoupon
        '
        Me.txtCoupon.Location = New System.Drawing.Point(145, 349)
        Me.txtCoupon.Name = "txtCoupon"
        Me.txtCoupon.Size = New System.Drawing.Size(62, 20)
        Me.txtCoupon.TabIndex = 64
        Me.txtCoupon.Text = "0"
        Me.txtCoupon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCoupon
        '
        Me.lblCoupon.AutoSize = True
        Me.lblCoupon.Location = New System.Drawing.Point(17, 352)
        Me.lblCoupon.Name = "lblCoupon"
        Me.lblCoupon.Size = New System.Drawing.Size(44, 13)
        Me.lblCoupon.TabIndex = 81
        Me.lblCoupon.Text = "Coupon"
        '
        'lblTotalAmtShow
        '
        Me.lblTotalAmtShow.AutoSize = True
        Me.lblTotalAmtShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblTotalAmtShow.Location = New System.Drawing.Point(142, 423)
        Me.lblTotalAmtShow.Name = "lblTotalAmtShow"
        Me.lblTotalAmtShow.Size = New System.Drawing.Size(14, 13)
        Me.lblTotalAmtShow.TabIndex = 79
        Me.lblTotalAmtShow.Text = "0"
        '
        'GroupBox5
        '
        Me.GroupBox5.Location = New System.Drawing.Point(18, 412)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(352, 5)
        Me.GroupBox5.TabIndex = 78
        Me.GroupBox5.TabStop = False
        '
        'lblTotalAmount2
        '
        Me.lblTotalAmount2.AutoSize = True
        Me.lblTotalAmount2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblTotalAmount2.Location = New System.Drawing.Point(17, 423)
        Me.lblTotalAmount2.Name = "lblTotalAmount2"
        Me.lblTotalAmount2.Size = New System.Drawing.Size(82, 13)
        Me.lblTotalAmount2.TabIndex = 77
        Me.lblTotalAmount2.Text = "Total Amount"
        '
        'dtpPDChequeDate
        '
        Me.dtpPDChequeDate.CustomFormat = "yyyy-MM-dd"
        Me.dtpPDChequeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPDChequeDate.Location = New System.Drawing.Point(145, 315)
        Me.dtpPDChequeDate.Name = "dtpPDChequeDate"
        Me.dtpPDChequeDate.Size = New System.Drawing.Size(81, 20)
        Me.dtpPDChequeDate.TabIndex = 63
        '
        'dtpChequeDate
        '
        Me.dtpChequeDate.CustomFormat = "yyyy-MM-dd"
        Me.dtpChequeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpChequeDate.Location = New System.Drawing.Point(145, 249)
        Me.dtpChequeDate.Name = "dtpChequeDate"
        Me.dtpChequeDate.Size = New System.Drawing.Size(81, 20)
        Me.dtpChequeDate.TabIndex = 58
        '
        'txtOther
        '
        Me.txtOther.Location = New System.Drawing.Point(145, 386)
        Me.txtOther.Name = "txtOther"
        Me.txtOther.Size = New System.Drawing.Size(62, 20)
        Me.txtOther.TabIndex = 65
        Me.txtOther.Text = "0"
        Me.txtOther.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblOther
        '
        Me.lblOther.AutoSize = True
        Me.lblOther.Location = New System.Drawing.Point(17, 390)
        Me.lblOther.Name = "lblOther"
        Me.lblOther.Size = New System.Drawing.Size(75, 13)
        Me.lblOther.TabIndex = 76
        Me.lblOther.Text = "Other / Contra"
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(20, 337)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(352, 5)
        Me.GroupBox4.TabIndex = 68
        Me.GroupBox4.TabStop = False
        '
        'lblPDChequeDate
        '
        Me.lblPDChequeDate.AutoSize = True
        Me.lblPDChequeDate.Location = New System.Drawing.Point(17, 315)
        Me.lblPDChequeDate.Name = "lblPDChequeDate"
        Me.lblPDChequeDate.Size = New System.Drawing.Size(88, 13)
        Me.lblPDChequeDate.TabIndex = 75
        Me.lblPDChequeDate.Text = "PD Cheque Date"
        '
        'txtPDChequeNo
        '
        Me.txtPDChequeNo.Location = New System.Drawing.Point(302, 287)
        Me.txtPDChequeNo.Name = "txtPDChequeNo"
        Me.txtPDChequeNo.Size = New System.Drawing.Size(68, 20)
        Me.txtPDChequeNo.TabIndex = 61
        Me.txtPDChequeNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPDChequeNo
        '
        Me.lblPDChequeNo.AutoSize = True
        Me.lblPDChequeNo.Location = New System.Drawing.Point(213, 291)
        Me.lblPDChequeNo.Name = "lblPDChequeNo"
        Me.lblPDChequeNo.Size = New System.Drawing.Size(82, 13)
        Me.lblPDChequeNo.TabIndex = 74
        Me.lblPDChequeNo.Text = "PD Cheque No."
        '
        'txtPDCheque
        '
        Me.txtPDCheque.Location = New System.Drawing.Point(145, 287)
        Me.txtPDCheque.Name = "txtPDCheque"
        Me.txtPDCheque.Size = New System.Drawing.Size(62, 20)
        Me.txtPDCheque.TabIndex = 60
        Me.txtPDCheque.Text = "0"
        Me.txtPDCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPDCheque
        '
        Me.lblPDCheque.AutoSize = True
        Me.lblPDCheque.Location = New System.Drawing.Point(17, 291)
        Me.lblPDCheque.Name = "lblPDCheque"
        Me.lblPDCheque.Size = New System.Drawing.Size(62, 13)
        Me.lblPDCheque.TabIndex = 73
        Me.lblPDCheque.Text = "PD Cheque"
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(18, 276)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(352, 5)
        Me.GroupBox3.TabIndex = 67
        Me.GroupBox3.TabStop = False
        '
        'lblChequeDate
        '
        Me.lblChequeDate.AutoSize = True
        Me.lblChequeDate.Location = New System.Drawing.Point(17, 254)
        Me.lblChequeDate.Name = "lblChequeDate"
        Me.lblChequeDate.Size = New System.Drawing.Size(70, 13)
        Me.lblChequeDate.TabIndex = 72
        Me.lblChequeDate.Text = "Cheque Date"
        '
        'txtChequeNo
        '
        Me.txtChequeNo.Location = New System.Drawing.Point(300, 222)
        Me.txtChequeNo.Name = "txtChequeNo"
        Me.txtChequeNo.Size = New System.Drawing.Size(68, 20)
        Me.txtChequeNo.TabIndex = 57
        Me.txtChequeNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblChequeNo
        '
        Me.lblChequeNo.AutoSize = True
        Me.lblChequeNo.Location = New System.Drawing.Point(213, 226)
        Me.lblChequeNo.Name = "lblChequeNo"
        Me.lblChequeNo.Size = New System.Drawing.Size(64, 13)
        Me.lblChequeNo.TabIndex = 71
        Me.lblChequeNo.Text = "Cheque No."
        '
        'txtCheque
        '
        Me.txtCheque.Location = New System.Drawing.Point(145, 222)
        Me.txtCheque.Name = "txtCheque"
        Me.txtCheque.Size = New System.Drawing.Size(62, 20)
        Me.txtCheque.TabIndex = 56
        Me.txtCheque.Text = "0"
        Me.txtCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCheque
        '
        Me.lblCheque.AutoSize = True
        Me.lblCheque.Location = New System.Drawing.Point(17, 226)
        Me.lblCheque.Name = "lblCheque"
        Me.lblCheque.Size = New System.Drawing.Size(44, 13)
        Me.lblCheque.TabIndex = 70
        Me.lblCheque.Text = "Cheque"
        '
        'GroupBox6
        '
        Me.GroupBox6.Location = New System.Drawing.Point(18, 210)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(352, 5)
        Me.GroupBox6.TabIndex = 66
        Me.GroupBox6.TabStop = False
        '
        'txtCCBank
        '
        Me.txtCCBank.Location = New System.Drawing.Point(145, 105)
        Me.txtCCBank.Name = "txtCCBank"
        Me.txtCCBank.Size = New System.Drawing.Size(225, 20)
        Me.txtCCBank.TabIndex = 49
        '
        'lblCCBank
        '
        Me.lblCCBank.AutoSize = True
        Me.lblCCBank.Location = New System.Drawing.Point(17, 109)
        Me.lblCCBank.Name = "lblCCBank"
        Me.lblCCBank.Size = New System.Drawing.Size(49, 13)
        Me.lblCCBank.TabIndex = 69
        Me.lblCCBank.Text = "CC Bank"
        '
        'cboCCType
        '
        Me.cboCCType.FormattingEnabled = True
        Me.cboCCType.Items.AddRange(New Object() {"VISA", "MASTER", "AMEX", "DINERS", "OTHER"})
        Me.cboCCType.Location = New System.Drawing.Point(145, 78)
        Me.cboCCType.Name = "cboCCType"
        Me.cboCCType.Size = New System.Drawing.Size(96, 21)
        Me.cboCCType.TabIndex = 46
        '
        'GroupBox7
        '
        Me.GroupBox7.Location = New System.Drawing.Point(19, 40)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(352, 5)
        Me.GroupBox7.TabIndex = 65
        Me.GroupBox7.TabStop = False
        '
        'txtCard
        '
        Me.txtCard.Location = New System.Drawing.Point(145, 52)
        Me.txtCard.Name = "txtCard"
        Me.txtCard.Size = New System.Drawing.Size(62, 20)
        Me.txtCard.TabIndex = 45
        Me.txtCard.Text = "0"
        Me.txtCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCreditCard
        '
        Me.lblCreditCard.AutoSize = True
        Me.lblCreditCard.Location = New System.Drawing.Point(17, 56)
        Me.lblCreditCard.Name = "lblCreditCard"
        Me.lblCreditCard.Size = New System.Drawing.Size(59, 13)
        Me.lblCreditCard.TabIndex = 62
        Me.lblCreditCard.Text = "Credit Card"
        '
        'txtCash
        '
        Me.txtCash.Location = New System.Drawing.Point(145, 16)
        Me.txtCash.MaxLength = 12
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(62, 20)
        Me.txtCash.TabIndex = 43
        Me.txtCash.Text = "0"
        Me.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCash
        '
        Me.lblCash.AutoSize = True
        Me.lblCash.Location = New System.Drawing.Point(17, 19)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(31, 13)
        Me.lblCash.TabIndex = 59
        Me.lblCash.Text = "Cash"
        '
        'cboMonth
        '
        Me.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonth.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cboMonth.Location = New System.Drawing.Point(260, 157)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(110, 21)
        Me.cboMonth.TabIndex = 53
        '
        'cboYear
        '
        Me.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYear.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Items.AddRange(New Object() {"2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018"})
        Me.cboYear.Location = New System.Drawing.Point(145, 157)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(109, 21)
        Me.cboYear.TabIndex = 52
        '
        'txtCCAppCode
        '
        Me.txtCCAppCode.Location = New System.Drawing.Point(145, 184)
        Me.txtCCAppCode.Name = "txtCCAppCode"
        Me.txtCCAppCode.Size = New System.Drawing.Size(109, 20)
        Me.txtCCAppCode.TabIndex = 55
        '
        'lblCCAprovalCode
        '
        Me.lblCCAprovalCode.AutoSize = True
        Me.lblCCAprovalCode.Location = New System.Drawing.Point(16, 188)
        Me.lblCCAprovalCode.Name = "lblCCAprovalCode"
        Me.lblCCAprovalCode.Size = New System.Drawing.Size(97, 13)
        Me.lblCCAprovalCode.TabIndex = 54
        Me.lblCCAprovalCode.Text = " CC Approval Code"
        '
        'lblCCExpiry
        '
        Me.lblCCExpiry.AutoSize = True
        Me.lblCCExpiry.Location = New System.Drawing.Point(17, 161)
        Me.lblCCExpiry.Name = "lblCCExpiry"
        Me.lblCCExpiry.Size = New System.Drawing.Size(52, 13)
        Me.lblCCExpiry.TabIndex = 50
        Me.lblCCExpiry.Text = "CC Expiry"
        '
        'txtCCName
        '
        Me.txtCCName.Location = New System.Drawing.Point(145, 131)
        Me.txtCCName.Name = "txtCCName"
        Me.txtCCName.Size = New System.Drawing.Size(225, 20)
        Me.txtCCName.TabIndex = 51
        '
        'lblCCName
        '
        Me.lblCCName.AutoSize = True
        Me.lblCCName.Location = New System.Drawing.Point(17, 135)
        Me.lblCCName.Name = "lblCCName"
        Me.lblCCName.Size = New System.Drawing.Size(52, 13)
        Me.lblCCName.TabIndex = 48
        Me.lblCCName.Text = "CC Name"
        '
        'txtCCNo
        '
        Me.txtCCNo.Location = New System.Drawing.Point(247, 78)
        Me.txtCCNo.MaxLength = 100
        Me.txtCCNo.Name = "txtCCNo"
        Me.txtCCNo.Size = New System.Drawing.Size(123, 20)
        Me.txtCCNo.TabIndex = 47
        '
        'lblCCNumber
        '
        Me.lblCCNumber.AutoSize = True
        Me.lblCCNumber.Location = New System.Drawing.Point(17, 82)
        Me.lblCCNumber.Name = "lblCCNumber"
        Me.lblCCNumber.Size = New System.Drawing.Size(61, 13)
        Me.lblCCNumber.TabIndex = 44
        Me.lblCCNumber.Text = "CC Number"
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblTotalAmount.ForeColor = System.Drawing.Color.DarkRed
        Me.lblTotalAmount.Location = New System.Drawing.Point(148, 52)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(238, 39)
        Me.lblTotalAmount.TabIndex = 31
        Me.lblTotalAmount.Text = "RM   0.00        "
        Me.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(20, 52)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(122, 39)
        Me.lblTotal.TabIndex = 30
        Me.lblTotal.Text = "TOTAL"
        '
        'picKeyboard
        '
        Me.picKeyboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picKeyboard.Image = Global.ThickClient.My.Resources.Resources.Keyboard_icon64
        Me.picKeyboard.Location = New System.Drawing.Point(333, 10)
        Me.picKeyboard.Name = "picKeyboard"
        Me.picKeyboard.Size = New System.Drawing.Size(64, 64)
        Me.picKeyboard.TabIndex = 32
        Me.picKeyboard.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picKeyboard, "Click to show screen keyboard")
        '
        'frmOtherPayments
        '
        Me.AcceptButton = Me.btnConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(408, 624)
        Me.Controls.Add(Me.picKeyboard)
        Me.Controls.Add(Me.lblTotalAmount)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOtherPayments"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmOtherPayments"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.picKeyboard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalAmtShow As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalAmount2 As System.Windows.Forms.Label
    Friend WithEvents dtpPDChequeDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpChequeDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtOther As System.Windows.Forms.TextBox
    Friend WithEvents lblOther As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPDChequeDate As System.Windows.Forms.Label
    Friend WithEvents txtPDChequeNo As System.Windows.Forms.TextBox
    Friend WithEvents lblPDChequeNo As System.Windows.Forms.Label
    Friend WithEvents txtPDCheque As System.Windows.Forms.TextBox
    Friend WithEvents lblPDCheque As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblChequeDate As System.Windows.Forms.Label
    Friend WithEvents txtChequeNo As System.Windows.Forms.TextBox
    Friend WithEvents lblChequeNo As System.Windows.Forms.Label
    Friend WithEvents txtCheque As System.Windows.Forms.TextBox
    Friend WithEvents lblCheque As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCCBank As System.Windows.Forms.TextBox
    Friend WithEvents lblCCBank As System.Windows.Forms.Label
    Friend WithEvents cboCCType As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCard As System.Windows.Forms.TextBox
    Friend WithEvents lblCreditCard As System.Windows.Forms.Label
    Friend WithEvents txtCash As System.Windows.Forms.TextBox
    Friend WithEvents lblCash As System.Windows.Forms.Label
    Friend WithEvents cboMonth As System.Windows.Forms.ComboBox
    Friend WithEvents cboYear As System.Windows.Forms.ComboBox
    Friend WithEvents txtCCAppCode As System.Windows.Forms.TextBox
    Friend WithEvents lblCCAprovalCode As System.Windows.Forms.Label
    Friend WithEvents lblCCExpiry As System.Windows.Forms.Label
    Friend WithEvents txtCCName As System.Windows.Forms.TextBox
    Friend WithEvents lblCCName As System.Windows.Forms.Label
    Friend WithEvents txtCCNo As System.Windows.Forms.TextBox
    Friend WithEvents lblCCNumber As System.Windows.Forms.Label
    Friend WithEvents lblTotalAmount As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCoupon As System.Windows.Forms.TextBox
    Friend WithEvents lblCoupon As System.Windows.Forms.Label
    Friend WithEvents picKeyboard As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
