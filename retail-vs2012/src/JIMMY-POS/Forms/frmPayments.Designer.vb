<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayments))
        Me.lblTitle = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnConfirm = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.txtChequeNo = New System.Windows.Forms.TextBox
        Me.lblChequeNo = New System.Windows.Forms.Label
        Me.txtCCBank = New System.Windows.Forms.TextBox
        Me.lblCCBank = New System.Windows.Forms.Label
        Me.cboMonth = New System.Windows.Forms.ComboBox
        Me.cboYear = New System.Windows.Forms.ComboBox
        Me.txtCCAppCode = New System.Windows.Forms.TextBox
        Me.lblCCAprovalCode = New System.Windows.Forms.Label
        Me.lblCCExpiry = New System.Windows.Forms.Label
        Me.txtCCName = New System.Windows.Forms.TextBox
        Me.lblCCName = New System.Windows.Forms.Label
        Me.txtCCNo = New System.Windows.Forms.TextBox
        Me.lblTotalAmount = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.picKeyboard = New System.Windows.Forms.PictureBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.btnCash = New System.Windows.Forms.Button
        Me.btnOthers = New System.Windows.Forms.Button
        Me.btnCheque = New System.Windows.Forms.Button
        Me.btnVoucher = New System.Windows.Forms.Button
        Me.btnNets = New System.Windows.Forms.Button
        Me.btnJCB = New System.Windows.Forms.Button
        Me.btnCUP = New System.Windows.Forms.Button
        Me.btnAmex = New System.Windows.Forms.Button
        Me.btnMaster = New System.Windows.Forms.Button
        Me.btnVisa = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.grpCard = New System.Windows.Forms.GroupBox
        Me.txtCardParticulars = New System.Windows.Forms.TextBox
        Me.lblCCNo = New System.Windows.Forms.Label
        Me.btnCardParticulars = New System.Windows.Forms.Button
        Me.lblCardParticulars = New System.Windows.Forms.Label
        Me.lblMode = New System.Windows.Forms.Label
        Me.grpCheque = New System.Windows.Forms.GroupBox
        Me.lblChequeAmount = New System.Windows.Forms.Label
        Me.txtAmtCheque = New System.Windows.Forms.TextBox
        Me.lblChequeDate = New System.Windows.Forms.Label
        Me.dtpChequeDate = New System.Windows.Forms.DateTimePicker
        Me.grpOthers = New System.Windows.Forms.GroupBox
        Me.lblAmount = New System.Windows.Forms.Label
        Me.txtAmt = New System.Windows.Forms.TextBox
        Me.lblDesc = New System.Windows.Forms.Label
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.colNo = New System.Windows.Forms.ColumnHeader
        Me.colMode = New System.Windows.Forms.ColumnHeader
        Me.colAmount = New System.Windows.Forms.ColumnHeader
        Me.btnRemove = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKeyboard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.grpCard.SuspendLayout()
        Me.grpCheque.SuspendLayout()
        Me.grpOthers.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblTitle.Location = New System.Drawing.Point(62, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(251, 35)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Other Payments"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.JimmyPos.My.Resources.Resources.payment
        Me.PictureBox1.Location = New System.Drawing.Point(27, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 32)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnConfirm
        '
        Me.btnConfirm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfirm.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(231, 489)
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
        Me.btnCancel.Location = New System.Drawing.Point(433, 489)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(141, 47)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel (Esc)"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtChequeNo
        '
        Me.txtChequeNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChequeNo.Location = New System.Drawing.Point(177, 63)
        Me.txtChequeNo.Name = "txtChequeNo"
        Me.txtChequeNo.Size = New System.Drawing.Size(182, 47)
        Me.txtChequeNo.TabIndex = 57
        Me.txtChequeNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblChequeNo
        '
        Me.lblChequeNo.AutoSize = True
        Me.lblChequeNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChequeNo.Location = New System.Drawing.Point(6, 74)
        Me.lblChequeNo.Name = "lblChequeNo"
        Me.lblChequeNo.Size = New System.Drawing.Size(152, 29)
        Me.lblChequeNo.TabIndex = 71
        Me.lblChequeNo.Text = "Cheque No."
        '
        'txtCCBank
        '
        Me.txtCCBank.Location = New System.Drawing.Point(134, 102)
        Me.txtCCBank.Name = "txtCCBank"
        Me.txtCCBank.Size = New System.Drawing.Size(225, 20)
        Me.txtCCBank.TabIndex = 3
        '
        'lblCCBank
        '
        Me.lblCCBank.AutoSize = True
        Me.lblCCBank.Location = New System.Drawing.Point(6, 105)
        Me.lblCCBank.Name = "lblCCBank"
        Me.lblCCBank.Size = New System.Drawing.Size(49, 13)
        Me.lblCCBank.TabIndex = 69
        Me.lblCCBank.Text = "CC Bank"
        '
        'cboMonth
        '
        Me.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonth.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cboMonth.Location = New System.Drawing.Point(249, 154)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(110, 21)
        Me.cboMonth.TabIndex = 6
        '
        'cboYear
        '
        Me.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYear.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Items.AddRange(New Object() {"2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018"})
        Me.cboYear.Location = New System.Drawing.Point(134, 154)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(109, 21)
        Me.cboYear.TabIndex = 5
        '
        'txtCCAppCode
        '
        Me.txtCCAppCode.Location = New System.Drawing.Point(134, 181)
        Me.txtCCAppCode.Name = "txtCCAppCode"
        Me.txtCCAppCode.Size = New System.Drawing.Size(109, 20)
        Me.txtCCAppCode.TabIndex = 7
        '
        'lblCCAprovalCode
        '
        Me.lblCCAprovalCode.AutoSize = True
        Me.lblCCAprovalCode.Location = New System.Drawing.Point(6, 184)
        Me.lblCCAprovalCode.Name = "lblCCAprovalCode"
        Me.lblCCAprovalCode.Size = New System.Drawing.Size(94, 13)
        Me.lblCCAprovalCode.TabIndex = 54
        Me.lblCCAprovalCode.Text = "CC Approval Code"
        '
        'lblCCExpiry
        '
        Me.lblCCExpiry.AutoSize = True
        Me.lblCCExpiry.Location = New System.Drawing.Point(6, 157)
        Me.lblCCExpiry.Name = "lblCCExpiry"
        Me.lblCCExpiry.Size = New System.Drawing.Size(52, 13)
        Me.lblCCExpiry.TabIndex = 50
        Me.lblCCExpiry.Text = "CC Expiry"
        '
        'txtCCName
        '
        Me.txtCCName.Location = New System.Drawing.Point(134, 128)
        Me.txtCCName.Name = "txtCCName"
        Me.txtCCName.Size = New System.Drawing.Size(225, 20)
        Me.txtCCName.TabIndex = 4
        '
        'lblCCName
        '
        Me.lblCCName.AutoSize = True
        Me.lblCCName.Location = New System.Drawing.Point(6, 131)
        Me.lblCCName.Name = "lblCCName"
        Me.lblCCName.Size = New System.Drawing.Size(52, 13)
        Me.lblCCName.TabIndex = 48
        Me.lblCCName.Text = "CC Name"
        '
        'txtCCNo
        '
        Me.txtCCNo.Location = New System.Drawing.Point(134, 76)
        Me.txtCCNo.MaxLength = 100
        Me.txtCCNo.Name = "txtCCNo"
        Me.txtCCNo.Size = New System.Drawing.Size(225, 20)
        Me.txtCCNo.TabIndex = 2
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
        Me.picKeyboard.Image = Global.JimmyPos.My.Resources.Resources.Keyboard_icon64
        Me.picKeyboard.Location = New System.Drawing.Point(333, -1)
        Me.picKeyboard.Name = "picKeyboard"
        Me.picKeyboard.Size = New System.Drawing.Size(64, 64)
        Me.picKeyboard.TabIndex = 32
        Me.picKeyboard.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picKeyboard, "Click to show screen keyboard")
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnCash, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnOthers, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCheque, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnVoucher, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnNets, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnJCB, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCUP, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAmex, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnMaster, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnVisa, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(403, 13)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(373, 465)
        Me.TableLayoutPanel1.TabIndex = 33
        '
        'btnCash
        '
        Me.btnCash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCash.Location = New System.Drawing.Point(3, 351)
        Me.btnCash.Name = "btnCash"
        Me.btnCash.Size = New System.Drawing.Size(118, 111)
        Me.btnCash.TabIndex = 9
        Me.btnCash.Text = "Cash"
        Me.btnCash.UseVisualStyleBackColor = True
        '
        'btnOthers
        '
        Me.btnOthers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnOthers.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOthers.Location = New System.Drawing.Point(251, 235)
        Me.btnOthers.Name = "btnOthers"
        Me.btnOthers.Size = New System.Drawing.Size(119, 110)
        Me.btnOthers.TabIndex = 8
        Me.btnOthers.Text = "Others"
        Me.btnOthers.UseVisualStyleBackColor = True
        '
        'btnCheque
        '
        Me.btnCheque.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheque.Location = New System.Drawing.Point(127, 235)
        Me.btnCheque.Name = "btnCheque"
        Me.btnCheque.Size = New System.Drawing.Size(118, 110)
        Me.btnCheque.TabIndex = 7
        Me.btnCheque.Text = "Cheque "
        Me.btnCheque.UseVisualStyleBackColor = True
        '
        'btnVoucher
        '
        Me.btnVoucher.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnVoucher.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoucher.Location = New System.Drawing.Point(3, 235)
        Me.btnVoucher.Name = "btnVoucher"
        Me.btnVoucher.Size = New System.Drawing.Size(118, 110)
        Me.btnVoucher.TabIndex = 6
        Me.btnVoucher.Text = "Voucher"
        Me.btnVoucher.UseVisualStyleBackColor = True
        '
        'btnNets
        '
        Me.btnNets.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnNets.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNets.Image = Global.JimmyPos.My.Resources.Resources.NetsCard
        Me.btnNets.Location = New System.Drawing.Point(251, 119)
        Me.btnNets.Name = "btnNets"
        Me.btnNets.Size = New System.Drawing.Size(119, 110)
        Me.btnNets.TabIndex = 5
        Me.btnNets.UseVisualStyleBackColor = True
        '
        'btnJCB
        '
        Me.btnJCB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnJCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJCB.Image = Global.JimmyPos.My.Resources.Resources.JCB
        Me.btnJCB.Location = New System.Drawing.Point(127, 119)
        Me.btnJCB.Name = "btnJCB"
        Me.btnJCB.Size = New System.Drawing.Size(118, 110)
        Me.btnJCB.TabIndex = 4
        Me.btnJCB.UseVisualStyleBackColor = True
        '
        'btnCUP
        '
        Me.btnCUP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCUP.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCUP.Image = Global.JimmyPos.My.Resources.Resources.ChinaUnionPay
        Me.btnCUP.Location = New System.Drawing.Point(3, 119)
        Me.btnCUP.Name = "btnCUP"
        Me.btnCUP.Size = New System.Drawing.Size(118, 110)
        Me.btnCUP.TabIndex = 3
        Me.btnCUP.UseVisualStyleBackColor = True
        '
        'btnAmex
        '
        Me.btnAmex.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAmex.Image = Global.JimmyPos.My.Resources.Resources.American_Express_Card_Icon__128px__Copyright_2008_Titan_Icons
        Me.btnAmex.Location = New System.Drawing.Point(251, 3)
        Me.btnAmex.Name = "btnAmex"
        Me.btnAmex.Size = New System.Drawing.Size(119, 110)
        Me.btnAmex.TabIndex = 2
        Me.btnAmex.UseVisualStyleBackColor = True
        '
        'btnMaster
        '
        Me.btnMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMaster.Image = Global.JimmyPos.My.Resources.Resources.MasterCard_Icon__128px__Copyright_2007_Titan_Icons
        Me.btnMaster.Location = New System.Drawing.Point(127, 3)
        Me.btnMaster.Name = "btnMaster"
        Me.btnMaster.Size = New System.Drawing.Size(118, 110)
        Me.btnMaster.TabIndex = 1
        Me.btnMaster.UseVisualStyleBackColor = True
        '
        'btnVisa
        '
        Me.btnVisa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnVisa.Image = Global.JimmyPos.My.Resources.Resources.Visa_Card_Icon__128px__Copyright_2007_Titan_Icons
        Me.btnVisa.Location = New System.Drawing.Point(3, 3)
        Me.btnVisa.Name = "btnVisa"
        Me.btnVisa.Size = New System.Drawing.Size(118, 110)
        Me.btnVisa.TabIndex = 0
        Me.btnVisa.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "visa1.gif")
        Me.ImageList1.Images.SetKeyName(1, "visa_logo_7.gif")
        '
        'grpCard
        '
        Me.grpCard.Controls.Add(Me.txtCardParticulars)
        Me.grpCard.Controls.Add(Me.lblCCNo)
        Me.grpCard.Controls.Add(Me.btnCardParticulars)
        Me.grpCard.Controls.Add(Me.lblCardParticulars)
        Me.grpCard.Controls.Add(Me.txtCCNo)
        Me.grpCard.Controls.Add(Me.txtCCBank)
        Me.grpCard.Controls.Add(Me.lblCCName)
        Me.grpCard.Controls.Add(Me.txtCCName)
        Me.grpCard.Controls.Add(Me.lblCCExpiry)
        Me.grpCard.Controls.Add(Me.lblCCAprovalCode)
        Me.grpCard.Controls.Add(Me.txtCCAppCode)
        Me.grpCard.Controls.Add(Me.cboYear)
        Me.grpCard.Controls.Add(Me.cboMonth)
        Me.grpCard.Controls.Add(Me.lblCCBank)
        Me.grpCard.Location = New System.Drawing.Point(27, 136)
        Me.grpCard.Name = "grpCard"
        Me.grpCard.Size = New System.Drawing.Size(370, 217)
        Me.grpCard.TabIndex = 34
        Me.grpCard.TabStop = False
        '
        'txtCardParticulars
        '
        Me.txtCardParticulars.Location = New System.Drawing.Point(9, 33)
        Me.txtCardParticulars.MaxLength = 100
        Me.txtCardParticulars.Name = "txtCardParticulars"
        Me.txtCardParticulars.Size = New System.Drawing.Size(317, 20)
        Me.txtCardParticulars.TabIndex = 1
        '
        'lblCCNo
        '
        Me.lblCCNo.AutoSize = True
        Me.lblCCNo.Location = New System.Drawing.Point(6, 79)
        Me.lblCCNo.Name = "lblCCNo"
        Me.lblCCNo.Size = New System.Drawing.Size(38, 13)
        Me.lblCCNo.TabIndex = 72
        Me.lblCCNo.Text = "CC No"
        '
        'btnCardParticulars
        '
        Me.btnCardParticulars.Image = Global.JimmyPos.My.Resources.Resources.Search_16x16
        Me.btnCardParticulars.Location = New System.Drawing.Point(332, 31)
        Me.btnCardParticulars.Name = "btnCardParticulars"
        Me.btnCardParticulars.Size = New System.Drawing.Size(32, 23)
        Me.btnCardParticulars.TabIndex = 71
        Me.btnCardParticulars.UseVisualStyleBackColor = True
        '
        'lblCardParticulars
        '
        Me.lblCardParticulars.AutoSize = True
        Me.lblCardParticulars.Location = New System.Drawing.Point(6, 14)
        Me.lblCardParticulars.Name = "lblCardParticulars"
        Me.lblCardParticulars.Size = New System.Drawing.Size(81, 13)
        Me.lblCardParticulars.TabIndex = 70
        Me.lblCardParticulars.Text = "Card Particulars"
        '
        'lblMode
        '
        Me.lblMode.AutoSize = True
        Me.lblMode.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblMode.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblMode.Location = New System.Drawing.Point(20, 91)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(295, 39)
        Me.lblMode.TabIndex = 35
        Me.lblMode.Text = "Mode of payment"
        '
        'grpCheque
        '
        Me.grpCheque.Controls.Add(Me.lblChequeAmount)
        Me.grpCheque.Controls.Add(Me.txtAmtCheque)
        Me.grpCheque.Controls.Add(Me.lblChequeNo)
        Me.grpCheque.Controls.Add(Me.txtChequeNo)
        Me.grpCheque.Controls.Add(Me.lblChequeDate)
        Me.grpCheque.Controls.Add(Me.dtpChequeDate)
        Me.grpCheque.Location = New System.Drawing.Point(27, 136)
        Me.grpCheque.Name = "grpCheque"
        Me.grpCheque.Size = New System.Drawing.Size(370, 217)
        Me.grpCheque.TabIndex = 36
        Me.grpCheque.TabStop = False
        '
        'lblChequeAmount
        '
        Me.lblChequeAmount.AutoSize = True
        Me.lblChequeAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChequeAmount.Location = New System.Drawing.Point(6, 14)
        Me.lblChequeAmount.Name = "lblChequeAmount"
        Me.lblChequeAmount.Size = New System.Drawing.Size(100, 29)
        Me.lblChequeAmount.TabIndex = 77
        Me.lblChequeAmount.Text = "Amount"
        '
        'txtAmtCheque
        '
        Me.txtAmtCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmtCheque.Location = New System.Drawing.Point(112, 10)
        Me.txtAmtCheque.Name = "txtAmtCheque"
        Me.txtAmtCheque.Size = New System.Drawing.Size(247, 47)
        Me.txtAmtCheque.TabIndex = 76
        Me.txtAmtCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblChequeDate
        '
        Me.lblChequeDate.AutoSize = True
        Me.lblChequeDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChequeDate.Location = New System.Drawing.Point(6, 123)
        Me.lblChequeDate.Name = "lblChequeDate"
        Me.lblChequeDate.Size = New System.Drawing.Size(165, 29)
        Me.lblChequeDate.TabIndex = 72
        Me.lblChequeDate.Text = "Cheque Date"
        '
        'dtpChequeDate
        '
        Me.dtpChequeDate.CustomFormat = "yyyy-MM-dd"
        Me.dtpChequeDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpChequeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpChequeDate.Location = New System.Drawing.Point(177, 120)
        Me.dtpChequeDate.Name = "dtpChequeDate"
        Me.dtpChequeDate.Size = New System.Drawing.Size(182, 35)
        Me.dtpChequeDate.TabIndex = 58
        '
        'grpOthers
        '
        Me.grpOthers.Controls.Add(Me.lblAmount)
        Me.grpOthers.Controls.Add(Me.txtAmt)
        Me.grpOthers.Controls.Add(Me.lblDesc)
        Me.grpOthers.Controls.Add(Me.txtDescription)
        Me.grpOthers.Location = New System.Drawing.Point(27, 136)
        Me.grpOthers.Name = "grpOthers"
        Me.grpOthers.Size = New System.Drawing.Size(370, 217)
        Me.grpOthers.TabIndex = 37
        Me.grpOthers.TabStop = False
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(6, 15)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(100, 29)
        Me.lblAmount.TabIndex = 73
        Me.lblAmount.Text = "Amount"
        '
        'txtAmt
        '
        Me.txtAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmt.Location = New System.Drawing.Point(112, 11)
        Me.txtAmt.Name = "txtAmt"
        Me.txtAmt.Size = New System.Drawing.Size(247, 47)
        Me.txtAmt.TabIndex = 1
        Me.txtAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(6, 71)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(100, 20)
        Me.lblDesc.TabIndex = 71
        Me.lblDesc.Text = "Description"
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(112, 67)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(247, 134)
        Me.txtDescription.TabIndex = 2
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNo, Me.colMode, Me.colAmount})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(27, 356)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(324, 122)
        Me.ListView1.TabIndex = 38
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'colNo
        '
        Me.colNo.Text = "No"
        Me.colNo.Width = 46
        '
        'colMode
        '
        Me.colMode.Text = "Payment Mode"
        Me.colMode.Width = 170
        '
        'colAmount
        '
        Me.colAmount.Text = "Amount"
        Me.colAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colAmount.Width = 85
        '
        'btnRemove
        '
        Me.btnRemove.Image = Global.JimmyPos.My.Resources.Resources.Delete_32x32
        Me.btnRemove.Location = New System.Drawing.Point(357, 402)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(40, 40)
        Me.btnRemove.TabIndex = 40
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.JimmyPos.My.Resources.Resources.Add_32x32
        Me.btnAdd.Location = New System.Drawing.Point(357, 356)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(40, 40)
        Me.btnAdd.TabIndex = 39
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'frmPayments
        '
        Me.AcceptButton = Me.btnConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(781, 548)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.lblMode)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.lblTotalAmount)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picKeyboard)
        Me.Controls.Add(Me.grpOthers)
        Me.Controls.Add(Me.grpCheque)
        Me.Controls.Add(Me.grpCard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPayments"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmOtherPayments"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKeyboard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.grpCard.ResumeLayout(False)
        Me.grpCard.PerformLayout()
        Me.grpCheque.ResumeLayout(False)
        Me.grpCheque.PerformLayout()
        Me.grpOthers.ResumeLayout(False)
        Me.grpOthers.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtChequeNo As System.Windows.Forms.TextBox
    Friend WithEvents lblChequeNo As System.Windows.Forms.Label
    Friend WithEvents txtCCBank As System.Windows.Forms.TextBox
    Friend WithEvents lblCCBank As System.Windows.Forms.Label
    Friend WithEvents cboMonth As System.Windows.Forms.ComboBox
    Friend WithEvents cboYear As System.Windows.Forms.ComboBox
    Friend WithEvents txtCCAppCode As System.Windows.Forms.TextBox
    Friend WithEvents lblCCAprovalCode As System.Windows.Forms.Label
    Friend WithEvents lblCCExpiry As System.Windows.Forms.Label
    Friend WithEvents txtCCName As System.Windows.Forms.TextBox
    Friend WithEvents lblCCName As System.Windows.Forms.Label
    Friend WithEvents txtCCNo As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalAmount As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents picKeyboard As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnVisa As System.Windows.Forms.Button
    Friend WithEvents btnOthers As System.Windows.Forms.Button
    Friend WithEvents btnCheque As System.Windows.Forms.Button
    Friend WithEvents btnVoucher As System.Windows.Forms.Button
    Friend WithEvents btnNets As System.Windows.Forms.Button
    Friend WithEvents btnJCB As System.Windows.Forms.Button
    Friend WithEvents btnCUP As System.Windows.Forms.Button
    Friend WithEvents btnAmex As System.Windows.Forms.Button
    Friend WithEvents btnMaster As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents grpCard As System.Windows.Forms.GroupBox
    Friend WithEvents lblMode As System.Windows.Forms.Label
    Friend WithEvents txtCardParticulars As System.Windows.Forms.TextBox
    Friend WithEvents lblCCNo As System.Windows.Forms.Label
    Friend WithEvents btnCardParticulars As System.Windows.Forms.Button
    Friend WithEvents lblCardParticulars As System.Windows.Forms.Label
    Friend WithEvents grpCheque As System.Windows.Forms.GroupBox
    Friend WithEvents lblChequeDate As System.Windows.Forms.Label
    Friend WithEvents dtpChequeDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents grpOthers As System.Windows.Forms.GroupBox
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents txtAmt As System.Windows.Forms.TextBox
    Friend WithEvents btnCash As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents colNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents colMode As System.Windows.Forms.ColumnHeader
    Friend WithEvents colAmount As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lblChequeAmount As System.Windows.Forms.Label
    Friend WithEvents txtAmtCheque As System.Windows.Forms.TextBox

End Class
