<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfig
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfig))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnOk = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.lblTitle = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tbStandard = New System.Windows.Forms.TabPage
        Me.lblItemCode = New System.Windows.Forms.Label
        Me.txtItemCode = New System.Windows.Forms.TextBox
        Me.chkApplyFiveCent = New System.Windows.Forms.CheckBox
        Me.chkDisallowUser = New System.Windows.Forms.CheckBox
        Me.chkAddNewLine = New System.Windows.Forms.CheckBox
        Me.chkRemarksRequired = New System.Windows.Forms.CheckBox
        Me.chkPriceIncludeTax = New System.Windows.Forms.CheckBox
        Me.chkSelligBelowQty = New System.Windows.Forms.CheckBox
        Me.lblTransaction = New System.Windows.Forms.Label
        Me.chkSelligBelowMinPrice = New System.Windows.Forms.CheckBox
        Me.txtHost = New System.Windows.Forms.TextBox
        Me.lblDatabaseHost = New System.Windows.Forms.Label
        Me.cboPrices = New System.Windows.Forms.ComboBox
        Me.lblPriceSchema = New System.Windows.Forms.Label
        Me.cboBranches = New System.Windows.Forms.ComboBox
        Me.lblBranch = New System.Windows.Forms.Label
        Me.tbMessageSetup = New System.Windows.Forms.TabPage
        Me.txtSucceedDelete = New System.Windows.Forms.TextBox
        Me.chkPaymentExceed = New System.Windows.Forms.CheckBox
        Me.txtPaymentExceed = New System.Windows.Forms.TextBox
        Me.chkSucceedVoid = New System.Windows.Forms.CheckBox
        Me.chkSucceedTxn = New System.Windows.Forms.CheckBox
        Me.chkConfirmVoid = New System.Windows.Forms.CheckBox
        Me.chkConfirmDelete = New System.Windows.Forms.CheckBox
        Me.chkConfirmTxn = New System.Windows.Forms.CheckBox
        Me.txtSucceedVoid = New System.Windows.Forms.TextBox
        Me.txtSucceedTxn = New System.Windows.Forms.TextBox
        Me.txtConfirmVoid = New System.Windows.Forms.TextBox
        Me.txtConfirmDelete = New System.Windows.Forms.TextBox
        Me.txtConfirmTxn = New System.Windows.Forms.TextBox
        Me.chkSucceedDelete = New System.Windows.Forms.CheckBox
        Me.tbReceiptBottomMsg = New System.Windows.Forms.TabPage
        Me.txtMsg4 = New System.Windows.Forms.TextBox
        Me.lblMessage4 = New System.Windows.Forms.Label
        Me.txtMsg3 = New System.Windows.Forms.TextBox
        Me.lblMessage3 = New System.Windows.Forms.Label
        Me.txtMsg2 = New System.Windows.Forms.TextBox
        Me.lblMessage2 = New System.Windows.Forms.Label
        Me.txtMsg1 = New System.Windows.Forms.TextBox
        Me.lblMessage1 = New System.Windows.Forms.Label
        Me.tbSynch = New System.Windows.Forms.TabPage
        Me.lblEndTime = New System.Windows.Forms.Label
        Me.lblStartTime = New System.Windows.Forms.Label
        Me.lblUpload = New System.Windows.Forms.Label
        Me.lblDownload = New System.Windows.Forms.Label
        Me.lblSyncTimingExample = New System.Windows.Forms.Label
        Me.txtSyncerTiming = New System.Windows.Forms.TextBox
        Me.lblSyncTiming = New System.Windows.Forms.Label
        Me.chkAutoSynchronize = New System.Windows.Forms.CheckBox
        Me.btnUpload = New System.Windows.Forms.Button
        Me.lblEnd = New System.Windows.Forms.Label
        Me.lblStart = New System.Windows.Forms.Label
        Me.txtSyncResult = New System.Windows.Forms.TextBox
        Me.btnDownload = New System.Windows.Forms.Button
        Me.txtWebService = New System.Windows.Forms.TextBox
        Me.lblSyncWebService = New System.Windows.Forms.Label
        Me.tbOthers = New System.Windows.Forms.TabPage
        Me.lblPrinterSetup = New System.Windows.Forms.Label
        Me.cboPrinterSetup = New System.Windows.Forms.ComboBox
        Me.btnRetrieve = New System.Windows.Forms.Button
        Me.picLogo = New System.Windows.Forms.PictureBox
        Me.lblCurrentSysLocale = New System.Windows.Forms.Label
        Me.cboLocale = New System.Windows.Forms.ComboBox
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.lblMinimumHour = New System.Windows.Forms.Label
        Me.btnBrowse = New System.Windows.Forms.Button
        Me.lblLogo = New System.Windows.Forms.Label
        Me.txtWelcome = New System.Windows.Forms.TextBox
        Me.lblWelcomeTo = New System.Windows.Forms.Label
        Me.tbPrintable = New System.Windows.Forms.TabPage
        Me.cboPrintableStockSummarySoldReport = New System.Windows.Forms.ComboBox
        Me.lblStockSummarySoldReport = New System.Windows.Forms.Label
        Me.cboPrintableDailySalesReport = New System.Windows.Forms.ComboBox
        Me.lblDailySalesReport = New System.Windows.Forms.Label
        Me.cboPrintableReceipt = New System.Windows.Forms.ComboBox
        Me.lblReceipt = New System.Windows.Forms.Label
        Me.tbImportExport = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblDateTo = New System.Windows.Forms.Label
        Me.lblDateFrom = New System.Windows.Forms.Label
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker
        Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker
        Me.chkDate = New System.Windows.Forms.CheckBox
        Me.lblExportMsg = New System.Windows.Forms.Label
        Me.btnExport = New System.Windows.Forms.Button
        Me.lblExportFile = New System.Windows.Forms.Label
        Me.txtExportFile = New System.Windows.Forms.TextBox
        Me.btnBrowseExport = New System.Windows.Forms.Button
        Me.grpImport = New System.Windows.Forms.GroupBox
        Me.lblImportMsg = New System.Windows.Forms.Label
        Me.btnImport = New System.Windows.Forms.Button
        Me.lblImportFile = New System.Windows.Forms.Label
        Me.txtImportFile = New System.Windows.Forms.TextBox
        Me.btnBrowseImport = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.btnApply = New System.Windows.Forms.Button
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.chkUploadByLimit = New System.Windows.Forms.CheckBox
        Me.nuLimit = New System.Windows.Forms.NumericUpDown
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tbStandard.SuspendLayout()
        Me.tbMessageSetup.SuspendLayout()
        Me.tbReceiptBottomMsg.SuspendLayout()
        Me.tbSynch.SuspendLayout()
        Me.tbOthers.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbPrintable.SuspendLayout()
        Me.tbImportExport.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpImport.SuspendLayout()
        CType(Me.nuLimit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(25, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.AutoEllipsis = True
        Me.btnOk.Location = New System.Drawing.Point(339, 358)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 36)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Tag = ""
        Me.btnOk.Text = "&Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.AutoEllipsis = True
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(420, 358)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 36)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Tag = ""
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(103, 28)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(69, 13)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Tag = "frmConfig.title.lable"
        Me.lblTitle.Text = "Configuration"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tbStandard)
        Me.TabControl1.Controls.Add(Me.tbMessageSetup)
        Me.TabControl1.Controls.Add(Me.tbReceiptBottomMsg)
        Me.TabControl1.Controls.Add(Me.tbSynch)
        Me.TabControl1.Controls.Add(Me.tbOthers)
        Me.TabControl1.Controls.Add(Me.tbPrintable)
        Me.TabControl1.Controls.Add(Me.tbImportExport)
        Me.TabControl1.Location = New System.Drawing.Point(21, 84)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(560, 270)
        Me.TabControl1.TabIndex = 5
        '
        'tbStandard
        '
        Me.tbStandard.Controls.Add(Me.lblItemCode)
        Me.tbStandard.Controls.Add(Me.txtItemCode)
        Me.tbStandard.Controls.Add(Me.chkApplyFiveCent)
        Me.tbStandard.Controls.Add(Me.chkDisallowUser)
        Me.tbStandard.Controls.Add(Me.chkAddNewLine)
        Me.tbStandard.Controls.Add(Me.chkRemarksRequired)
        Me.tbStandard.Controls.Add(Me.chkPriceIncludeTax)
        Me.tbStandard.Controls.Add(Me.chkSelligBelowQty)
        Me.tbStandard.Controls.Add(Me.lblTransaction)
        Me.tbStandard.Controls.Add(Me.chkSelligBelowMinPrice)
        Me.tbStandard.Controls.Add(Me.txtHost)
        Me.tbStandard.Controls.Add(Me.lblDatabaseHost)
        Me.tbStandard.Controls.Add(Me.cboPrices)
        Me.tbStandard.Controls.Add(Me.lblPriceSchema)
        Me.tbStandard.Controls.Add(Me.cboBranches)
        Me.tbStandard.Controls.Add(Me.lblBranch)
        Me.tbStandard.Location = New System.Drawing.Point(4, 22)
        Me.tbStandard.Name = "tbStandard"
        Me.tbStandard.Padding = New System.Windows.Forms.Padding(3)
        Me.tbStandard.Size = New System.Drawing.Size(552, 244)
        Me.tbStandard.TabIndex = 0
        Me.tbStandard.Text = "Standard"
        Me.tbStandard.UseVisualStyleBackColor = True
        '
        'lblItemCode
        '
        Me.lblItemCode.AutoSize = True
        Me.lblItemCode.Location = New System.Drawing.Point(255, 222)
        Me.lblItemCode.Name = "lblItemCode"
        Me.lblItemCode.Size = New System.Drawing.Size(55, 13)
        Me.lblItemCode.TabIndex = 35
        Me.lblItemCode.Text = "Item Code"
        '
        'txtItemCode
        '
        Me.txtItemCode.Location = New System.Drawing.Point(316, 218)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(184, 20)
        Me.txtItemCode.TabIndex = 34
        '
        'chkApplyFiveCent
        '
        Me.chkApplyFiveCent.AutoSize = True
        Me.chkApplyFiveCent.Location = New System.Drawing.Point(93, 221)
        Me.chkApplyFiveCent.Name = "chkApplyFiveCent"
        Me.chkApplyFiveCent.Size = New System.Drawing.Size(143, 17)
        Me.chkApplyFiveCent.TabIndex = 33
        Me.chkApplyFiveCent.Text = "Apply Five Cent Concept"
        Me.chkApplyFiveCent.UseVisualStyleBackColor = True
        '
        'chkDisallowUser
        '
        Me.chkDisallowUser.AutoSize = True
        Me.chkDisallowUser.Location = New System.Drawing.Point(93, 202)
        Me.chkDisallowUser.Name = "chkDisallowUser"
        Me.chkDisallowUser.Size = New System.Drawing.Size(195, 17)
        Me.chkDisallowUser.TabIndex = 11
        Me.chkDisallowUser.Text = "Disallow User To Change Salesman"
        Me.chkDisallowUser.UseVisualStyleBackColor = True
        '
        'chkAddNewLine
        '
        Me.chkAddNewLine.AutoSize = True
        Me.chkAddNewLine.Location = New System.Drawing.Point(93, 180)
        Me.chkAddNewLine.Name = "chkAddNewLine"
        Me.chkAddNewLine.Size = New System.Drawing.Size(190, 17)
        Me.chkAddNewLine.TabIndex = 10
        Me.chkAddNewLine.Text = "Add New Line When Deleting Item"
        Me.chkAddNewLine.UseVisualStyleBackColor = True
        '
        'chkRemarksRequired
        '
        Me.chkRemarksRequired.AutoSize = True
        Me.chkRemarksRequired.Location = New System.Drawing.Point(93, 157)
        Me.chkRemarksRequired.Name = "chkRemarksRequired"
        Me.chkRemarksRequired.Size = New System.Drawing.Size(211, 17)
        Me.chkRemarksRequired.TabIndex = 9
        Me.chkRemarksRequired.Text = "Remarks Required When Deleting Item"
        Me.chkRemarksRequired.UseVisualStyleBackColor = True
        '
        'chkPriceIncludeTax
        '
        Me.chkPriceIncludeTax.AutoSize = True
        Me.chkPriceIncludeTax.Location = New System.Drawing.Point(370, 134)
        Me.chkPriceIncludeTax.Name = "chkPriceIncludeTax"
        Me.chkPriceIncludeTax.Size = New System.Drawing.Size(109, 17)
        Me.chkPriceIncludeTax.TabIndex = 8
        Me.chkPriceIncludeTax.Text = "Price Include Tax"
        Me.chkPriceIncludeTax.UseVisualStyleBackColor = True
        '
        'chkSelligBelowQty
        '
        Me.chkSelligBelowQty.AutoSize = True
        Me.chkSelligBelowQty.Location = New System.Drawing.Point(93, 134)
        Me.chkSelligBelowQty.Name = "chkSelligBelowQty"
        Me.chkSelligBelowQty.Size = New System.Drawing.Size(108, 17)
        Me.chkSelligBelowQty.TabIndex = 6
        Me.chkSelligBelowQty.Text = "Selling Below Qty"
        Me.chkSelligBelowQty.UseVisualStyleBackColor = True
        '
        'lblTransaction
        '
        Me.lblTransaction.AutoSize = True
        Me.lblTransaction.Location = New System.Drawing.Point(10, 135)
        Me.lblTransaction.Name = "lblTransaction"
        Me.lblTransaction.Size = New System.Drawing.Size(63, 13)
        Me.lblTransaction.TabIndex = 32
        Me.lblTransaction.Text = "Transaction"
        '
        'chkSelligBelowMinPrice
        '
        Me.chkSelligBelowMinPrice.AutoSize = True
        Me.chkSelligBelowMinPrice.Location = New System.Drawing.Point(228, 134)
        Me.chkSelligBelowMinPrice.Name = "chkSelligBelowMinPrice"
        Me.chkSelligBelowMinPrice.Size = New System.Drawing.Size(136, 17)
        Me.chkSelligBelowMinPrice.TabIndex = 7
        Me.chkSelligBelowMinPrice.Text = "Selling Below Min Price"
        Me.chkSelligBelowMinPrice.UseVisualStyleBackColor = True
        '
        'txtHost
        '
        Me.txtHost.Location = New System.Drawing.Point(93, 75)
        Me.txtHost.Name = "txtHost"
        Me.txtHost.Size = New System.Drawing.Size(394, 20)
        Me.txtHost.TabIndex = 4
        '
        'lblDatabaseHost
        '
        Me.lblDatabaseHost.AutoSize = True
        Me.lblDatabaseHost.Location = New System.Drawing.Point(10, 78)
        Me.lblDatabaseHost.Name = "lblDatabaseHost"
        Me.lblDatabaseHost.Size = New System.Drawing.Size(78, 13)
        Me.lblDatabaseHost.TabIndex = 14
        Me.lblDatabaseHost.Text = "Database Host"
        '
        'cboPrices
        '
        Me.cboPrices.FormattingEnabled = True
        Me.cboPrices.Location = New System.Drawing.Point(93, 45)
        Me.cboPrices.Name = "cboPrices"
        Me.cboPrices.Size = New System.Drawing.Size(217, 21)
        Me.cboPrices.TabIndex = 3
        '
        'lblPriceSchema
        '
        Me.lblPriceSchema.AutoSize = True
        Me.lblPriceSchema.Location = New System.Drawing.Point(10, 48)
        Me.lblPriceSchema.Name = "lblPriceSchema"
        Me.lblPriceSchema.Size = New System.Drawing.Size(73, 13)
        Me.lblPriceSchema.TabIndex = 12
        Me.lblPriceSchema.Text = "Price Schema"
        '
        'cboBranches
        '
        Me.cboBranches.FormattingEnabled = True
        Me.cboBranches.Location = New System.Drawing.Point(93, 14)
        Me.cboBranches.Name = "cboBranches"
        Me.cboBranches.Size = New System.Drawing.Size(217, 21)
        Me.cboBranches.TabIndex = 1
        '
        'lblBranch
        '
        Me.lblBranch.AutoSize = True
        Me.lblBranch.Location = New System.Drawing.Point(10, 17)
        Me.lblBranch.Name = "lblBranch"
        Me.lblBranch.Size = New System.Drawing.Size(41, 13)
        Me.lblBranch.TabIndex = 10
        Me.lblBranch.Text = "Branch"
        '
        'tbMessageSetup
        '
        Me.tbMessageSetup.Controls.Add(Me.txtSucceedDelete)
        Me.tbMessageSetup.Controls.Add(Me.chkPaymentExceed)
        Me.tbMessageSetup.Controls.Add(Me.txtPaymentExceed)
        Me.tbMessageSetup.Controls.Add(Me.chkSucceedVoid)
        Me.tbMessageSetup.Controls.Add(Me.chkSucceedTxn)
        Me.tbMessageSetup.Controls.Add(Me.chkConfirmVoid)
        Me.tbMessageSetup.Controls.Add(Me.chkConfirmDelete)
        Me.tbMessageSetup.Controls.Add(Me.chkConfirmTxn)
        Me.tbMessageSetup.Controls.Add(Me.txtSucceedVoid)
        Me.tbMessageSetup.Controls.Add(Me.txtSucceedTxn)
        Me.tbMessageSetup.Controls.Add(Me.txtConfirmVoid)
        Me.tbMessageSetup.Controls.Add(Me.txtConfirmDelete)
        Me.tbMessageSetup.Controls.Add(Me.txtConfirmTxn)
        Me.tbMessageSetup.Controls.Add(Me.chkSucceedDelete)
        Me.tbMessageSetup.Location = New System.Drawing.Point(4, 22)
        Me.tbMessageSetup.Name = "tbMessageSetup"
        Me.tbMessageSetup.Padding = New System.Windows.Forms.Padding(3)
        Me.tbMessageSetup.Size = New System.Drawing.Size(552, 244)
        Me.tbMessageSetup.TabIndex = 1
        Me.tbMessageSetup.Text = "Message Setup"
        Me.tbMessageSetup.UseVisualStyleBackColor = True
        '
        'txtSucceedDelete
        '
        Me.txtSucceedDelete.Location = New System.Drawing.Point(148, 118)
        Me.txtSucceedDelete.Name = "txtSucceedDelete"
        Me.txtSucceedDelete.Size = New System.Drawing.Size(340, 20)
        Me.txtSucceedDelete.TabIndex = 10
        '
        'chkPaymentExceed
        '
        Me.chkPaymentExceed.AutoSize = True
        Me.chkPaymentExceed.Location = New System.Drawing.Point(10, 172)
        Me.chkPaymentExceed.Name = "chkPaymentExceed"
        Me.chkPaymentExceed.Size = New System.Drawing.Size(106, 17)
        Me.chkPaymentExceed.TabIndex = 13
        Me.chkPaymentExceed.Text = "Payment Exceed"
        Me.chkPaymentExceed.UseVisualStyleBackColor = True
        '
        'txtPaymentExceed
        '
        Me.txtPaymentExceed.Location = New System.Drawing.Point(148, 170)
        Me.txtPaymentExceed.Name = "txtPaymentExceed"
        Me.txtPaymentExceed.Size = New System.Drawing.Size(340, 20)
        Me.txtPaymentExceed.TabIndex = 14
        '
        'chkSucceedVoid
        '
        Me.chkSucceedVoid.AutoSize = True
        Me.chkSucceedVoid.Location = New System.Drawing.Point(10, 146)
        Me.chkSucceedVoid.Name = "chkSucceedVoid"
        Me.chkSucceedVoid.Size = New System.Drawing.Size(105, 17)
        Me.chkSucceedVoid.TabIndex = 11
        Me.chkSucceedVoid.Text = "Void Succeeded"
        Me.chkSucceedVoid.UseVisualStyleBackColor = True
        '
        'chkSucceedTxn
        '
        Me.chkSucceedTxn.AutoSize = True
        Me.chkSucceedTxn.Location = New System.Drawing.Point(10, 94)
        Me.chkSucceedTxn.Name = "chkSucceedTxn"
        Me.chkSucceedTxn.Size = New System.Drawing.Size(102, 17)
        Me.chkSucceedTxn.TabIndex = 7
        Me.chkSucceedTxn.Text = "Txn Succeeded"
        Me.chkSucceedTxn.UseVisualStyleBackColor = True
        '
        'chkConfirmVoid
        '
        Me.chkConfirmVoid.AutoSize = True
        Me.chkConfirmVoid.Location = New System.Drawing.Point(10, 68)
        Me.chkConfirmVoid.Name = "chkConfirmVoid"
        Me.chkConfirmVoid.Size = New System.Drawing.Size(85, 17)
        Me.chkConfirmVoid.TabIndex = 5
        Me.chkConfirmVoid.Text = "Void Confirm"
        Me.chkConfirmVoid.UseVisualStyleBackColor = True
        '
        'chkConfirmDelete
        '
        Me.chkConfirmDelete.AutoSize = True
        Me.chkConfirmDelete.Location = New System.Drawing.Point(10, 42)
        Me.chkConfirmDelete.Name = "chkConfirmDelete"
        Me.chkConfirmDelete.Size = New System.Drawing.Size(118, 17)
        Me.chkConfirmDelete.TabIndex = 3
        Me.chkConfirmDelete.Text = "Delete Item Confirm"
        Me.chkConfirmDelete.UseVisualStyleBackColor = True
        '
        'chkConfirmTxn
        '
        Me.chkConfirmTxn.AutoSize = True
        Me.chkConfirmTxn.Location = New System.Drawing.Point(10, 16)
        Me.chkConfirmTxn.Name = "chkConfirmTxn"
        Me.chkConfirmTxn.Size = New System.Drawing.Size(82, 17)
        Me.chkConfirmTxn.TabIndex = 1
        Me.chkConfirmTxn.Text = "Txn Confirm"
        Me.chkConfirmTxn.UseVisualStyleBackColor = True
        '
        'txtSucceedVoid
        '
        Me.txtSucceedVoid.Location = New System.Drawing.Point(148, 144)
        Me.txtSucceedVoid.Name = "txtSucceedVoid"
        Me.txtSucceedVoid.Size = New System.Drawing.Size(340, 20)
        Me.txtSucceedVoid.TabIndex = 12
        '
        'txtSucceedTxn
        '
        Me.txtSucceedTxn.Location = New System.Drawing.Point(148, 92)
        Me.txtSucceedTxn.Name = "txtSucceedTxn"
        Me.txtSucceedTxn.Size = New System.Drawing.Size(340, 20)
        Me.txtSucceedTxn.TabIndex = 8
        '
        'txtConfirmVoid
        '
        Me.txtConfirmVoid.Location = New System.Drawing.Point(148, 66)
        Me.txtConfirmVoid.Name = "txtConfirmVoid"
        Me.txtConfirmVoid.Size = New System.Drawing.Size(340, 20)
        Me.txtConfirmVoid.TabIndex = 6
        '
        'txtConfirmDelete
        '
        Me.txtConfirmDelete.Location = New System.Drawing.Point(148, 40)
        Me.txtConfirmDelete.Name = "txtConfirmDelete"
        Me.txtConfirmDelete.Size = New System.Drawing.Size(340, 20)
        Me.txtConfirmDelete.TabIndex = 4
        '
        'txtConfirmTxn
        '
        Me.txtConfirmTxn.Location = New System.Drawing.Point(148, 14)
        Me.txtConfirmTxn.Name = "txtConfirmTxn"
        Me.txtConfirmTxn.Size = New System.Drawing.Size(340, 20)
        Me.txtConfirmTxn.TabIndex = 2
        '
        'chkSucceedDelete
        '
        Me.chkSucceedDelete.AutoSize = True
        Me.chkSucceedDelete.Location = New System.Drawing.Point(10, 120)
        Me.chkSucceedDelete.Name = "chkSucceedDelete"
        Me.chkSucceedDelete.Size = New System.Drawing.Size(138, 17)
        Me.chkSucceedDelete.TabIndex = 9
        Me.chkSucceedDelete.Text = "Delete Item Succeeded"
        Me.chkSucceedDelete.UseVisualStyleBackColor = True
        '
        'tbReceiptBottomMsg
        '
        Me.tbReceiptBottomMsg.Controls.Add(Me.txtMsg4)
        Me.tbReceiptBottomMsg.Controls.Add(Me.lblMessage4)
        Me.tbReceiptBottomMsg.Controls.Add(Me.txtMsg3)
        Me.tbReceiptBottomMsg.Controls.Add(Me.lblMessage3)
        Me.tbReceiptBottomMsg.Controls.Add(Me.txtMsg2)
        Me.tbReceiptBottomMsg.Controls.Add(Me.lblMessage2)
        Me.tbReceiptBottomMsg.Controls.Add(Me.txtMsg1)
        Me.tbReceiptBottomMsg.Controls.Add(Me.lblMessage1)
        Me.tbReceiptBottomMsg.Location = New System.Drawing.Point(4, 22)
        Me.tbReceiptBottomMsg.Name = "tbReceiptBottomMsg"
        Me.tbReceiptBottomMsg.Padding = New System.Windows.Forms.Padding(3)
        Me.tbReceiptBottomMsg.Size = New System.Drawing.Size(552, 244)
        Me.tbReceiptBottomMsg.TabIndex = 2
        Me.tbReceiptBottomMsg.Text = "Receipt Bottom Msg"
        Me.tbReceiptBottomMsg.UseVisualStyleBackColor = True
        '
        'txtMsg4
        '
        Me.txtMsg4.Location = New System.Drawing.Point(81, 92)
        Me.txtMsg4.Name = "txtMsg4"
        Me.txtMsg4.Size = New System.Drawing.Size(407, 20)
        Me.txtMsg4.TabIndex = 31
        '
        'lblMessage4
        '
        Me.lblMessage4.AutoSize = True
        Me.lblMessage4.Location = New System.Drawing.Point(10, 95)
        Me.lblMessage4.Name = "lblMessage4"
        Me.lblMessage4.Size = New System.Drawing.Size(59, 13)
        Me.lblMessage4.TabIndex = 30
        Me.lblMessage4.Text = "Message 4"
        '
        'txtMsg3
        '
        Me.txtMsg3.Location = New System.Drawing.Point(81, 66)
        Me.txtMsg3.Name = "txtMsg3"
        Me.txtMsg3.Size = New System.Drawing.Size(407, 20)
        Me.txtMsg3.TabIndex = 29
        '
        'lblMessage3
        '
        Me.lblMessage3.AutoSize = True
        Me.lblMessage3.Location = New System.Drawing.Point(10, 69)
        Me.lblMessage3.Name = "lblMessage3"
        Me.lblMessage3.Size = New System.Drawing.Size(59, 13)
        Me.lblMessage3.TabIndex = 28
        Me.lblMessage3.Text = "Message 3"
        '
        'txtMsg2
        '
        Me.txtMsg2.Location = New System.Drawing.Point(81, 40)
        Me.txtMsg2.Name = "txtMsg2"
        Me.txtMsg2.Size = New System.Drawing.Size(407, 20)
        Me.txtMsg2.TabIndex = 27
        '
        'lblMessage2
        '
        Me.lblMessage2.AutoSize = True
        Me.lblMessage2.Location = New System.Drawing.Point(10, 43)
        Me.lblMessage2.Name = "lblMessage2"
        Me.lblMessage2.Size = New System.Drawing.Size(59, 13)
        Me.lblMessage2.TabIndex = 26
        Me.lblMessage2.Text = "Message 2"
        '
        'txtMsg1
        '
        Me.txtMsg1.Location = New System.Drawing.Point(81, 14)
        Me.txtMsg1.Name = "txtMsg1"
        Me.txtMsg1.Size = New System.Drawing.Size(407, 20)
        Me.txtMsg1.TabIndex = 25
        '
        'lblMessage1
        '
        Me.lblMessage1.AutoSize = True
        Me.lblMessage1.Location = New System.Drawing.Point(10, 17)
        Me.lblMessage1.Name = "lblMessage1"
        Me.lblMessage1.Size = New System.Drawing.Size(59, 13)
        Me.lblMessage1.TabIndex = 24
        Me.lblMessage1.Text = "Message 1"
        '
        'tbSynch
        '
        Me.tbSynch.Controls.Add(Me.nuLimit)
        Me.tbSynch.Controls.Add(Me.chkUploadByLimit)
        Me.tbSynch.Controls.Add(Me.lblEndTime)
        Me.tbSynch.Controls.Add(Me.lblStartTime)
        Me.tbSynch.Controls.Add(Me.lblUpload)
        Me.tbSynch.Controls.Add(Me.lblDownload)
        Me.tbSynch.Controls.Add(Me.lblSyncTimingExample)
        Me.tbSynch.Controls.Add(Me.txtSyncerTiming)
        Me.tbSynch.Controls.Add(Me.lblSyncTiming)
        Me.tbSynch.Controls.Add(Me.chkAutoSynchronize)
        Me.tbSynch.Controls.Add(Me.btnUpload)
        Me.tbSynch.Controls.Add(Me.lblEnd)
        Me.tbSynch.Controls.Add(Me.lblStart)
        Me.tbSynch.Controls.Add(Me.txtSyncResult)
        Me.tbSynch.Controls.Add(Me.btnDownload)
        Me.tbSynch.Controls.Add(Me.txtWebService)
        Me.tbSynch.Controls.Add(Me.lblSyncWebService)
        Me.tbSynch.Location = New System.Drawing.Point(4, 22)
        Me.tbSynch.Name = "tbSynch"
        Me.tbSynch.Size = New System.Drawing.Size(552, 244)
        Me.tbSynch.TabIndex = 4
        Me.tbSynch.Text = "Synchronization"
        Me.tbSynch.UseVisualStyleBackColor = True
        '
        'lblEndTime
        '
        Me.lblEndTime.AutoSize = True
        Me.lblEndTime.Location = New System.Drawing.Point(10, 209)
        Me.lblEndTime.Name = "lblEndTime"
        Me.lblEndTime.Size = New System.Drawing.Size(52, 13)
        Me.lblEndTime.TabIndex = 46
        Me.lblEndTime.Text = "End Time"
        '
        'lblStartTime
        '
        Me.lblStartTime.AutoSize = True
        Me.lblStartTime.Location = New System.Drawing.Point(10, 176)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(55, 13)
        Me.lblStartTime.TabIndex = 45
        Me.lblStartTime.Text = "Start Time"
        '
        'lblUpload
        '
        Me.lblUpload.AutoSize = True
        Me.lblUpload.Location = New System.Drawing.Point(10, 81)
        Me.lblUpload.Name = "lblUpload"
        Me.lblUpload.Size = New System.Drawing.Size(41, 13)
        Me.lblUpload.TabIndex = 44
        Me.lblUpload.Text = "Upload"
        '
        'lblDownload
        '
        Me.lblDownload.AutoSize = True
        Me.lblDownload.Location = New System.Drawing.Point(10, 57)
        Me.lblDownload.Name = "lblDownload"
        Me.lblDownload.Size = New System.Drawing.Size(55, 13)
        Me.lblDownload.TabIndex = 43
        Me.lblDownload.Text = "Download"
        '
        'lblSyncTimingExample
        '
        Me.lblSyncTimingExample.AutoSize = True
        Me.lblSyncTimingExample.Location = New System.Drawing.Point(401, 81)
        Me.lblSyncTimingExample.Name = "lblSyncTimingExample"
        Me.lblSyncTimingExample.Size = New System.Drawing.Size(84, 13)
        Me.lblSyncTimingExample.TabIndex = 42
        Me.lblSyncTimingExample.Text = "(eg. 5000=5sec)"
        '
        'txtSyncerTiming
        '
        Me.txtSyncerTiming.Location = New System.Drawing.Point(286, 78)
        Me.txtSyncerTiming.MaxLength = 12
        Me.txtSyncerTiming.Name = "txtSyncerTiming"
        Me.txtSyncerTiming.Size = New System.Drawing.Size(100, 20)
        Me.txtSyncerTiming.TabIndex = 41
        '
        'lblSyncTiming
        '
        Me.lblSyncTiming.AutoSize = True
        Me.lblSyncTiming.Location = New System.Drawing.Point(242, 81)
        Me.lblSyncTiming.Name = "lblSyncTiming"
        Me.lblSyncTiming.Size = New System.Drawing.Size(38, 13)
        Me.lblSyncTiming.TabIndex = 40
        Me.lblSyncTiming.Text = "Timing"
        '
        'chkAutoSynchronize
        '
        Me.chkAutoSynchronize.AutoSize = True
        Me.chkAutoSynchronize.Location = New System.Drawing.Point(116, 81)
        Me.chkAutoSynchronize.Name = "chkAutoSynchronize"
        Me.chkAutoSynchronize.Size = New System.Drawing.Size(108, 17)
        Me.chkAutoSynchronize.TabIndex = 39
        Me.chkAutoSynchronize.Text = "Automate Upload"
        Me.chkAutoSynchronize.UseVisualStyleBackColor = True
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(116, 104)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(110, 23)
        Me.btnUpload.TabIndex = 26
        Me.btnUpload.Text = "Manual Upload"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'lblEnd
        '
        Me.lblEnd.AutoSize = True
        Me.lblEnd.Location = New System.Drawing.Point(113, 209)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(36, 13)
        Me.lblEnd.TabIndex = 25
        Me.lblEnd.Text = "lblEnd"
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Location = New System.Drawing.Point(113, 176)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(39, 13)
        Me.lblStart.TabIndex = 24
        Me.lblStart.Text = "lblStart"
        '
        'txtSyncResult
        '
        Me.txtSyncResult.Location = New System.Drawing.Point(245, 139)
        Me.txtSyncResult.Multiline = True
        Me.txtSyncResult.Name = "txtSyncResult"
        Me.txtSyncResult.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtSyncResult.Size = New System.Drawing.Size(247, 83)
        Me.txtSyncResult.TabIndex = 23
        '
        'btnDownload
        '
        Me.btnDownload.Location = New System.Drawing.Point(116, 52)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(94, 23)
        Me.btnDownload.TabIndex = 22
        Me.btnDownload.Text = "Download Now"
        Me.btnDownload.UseVisualStyleBackColor = True
        '
        'txtWebService
        '
        Me.txtWebService.Location = New System.Drawing.Point(116, 17)
        Me.txtWebService.Name = "txtWebService"
        Me.txtWebService.Size = New System.Drawing.Size(376, 20)
        Me.txtWebService.TabIndex = 21
        '
        'lblSyncWebService
        '
        Me.lblSyncWebService.AutoSize = True
        Me.lblSyncWebService.Location = New System.Drawing.Point(10, 20)
        Me.lblSyncWebService.Name = "lblSyncWebService"
        Me.lblSyncWebService.Size = New System.Drawing.Size(69, 13)
        Me.lblSyncWebService.TabIndex = 18
        Me.lblSyncWebService.Text = "Web Service"
        '
        'tbOthers
        '
        Me.tbOthers.Controls.Add(Me.lblPrinterSetup)
        Me.tbOthers.Controls.Add(Me.cboPrinterSetup)
        Me.tbOthers.Controls.Add(Me.btnRetrieve)
        Me.tbOthers.Controls.Add(Me.picLogo)
        Me.tbOthers.Controls.Add(Me.lblCurrentSysLocale)
        Me.tbOthers.Controls.Add(Me.cboLocale)
        Me.tbOthers.Controls.Add(Me.NumericUpDown1)
        Me.tbOthers.Controls.Add(Me.lblMinimumHour)
        Me.tbOthers.Controls.Add(Me.btnBrowse)
        Me.tbOthers.Controls.Add(Me.lblLogo)
        Me.tbOthers.Controls.Add(Me.txtWelcome)
        Me.tbOthers.Controls.Add(Me.lblWelcomeTo)
        Me.tbOthers.Location = New System.Drawing.Point(4, 22)
        Me.tbOthers.Name = "tbOthers"
        Me.tbOthers.Padding = New System.Windows.Forms.Padding(3)
        Me.tbOthers.Size = New System.Drawing.Size(552, 244)
        Me.tbOthers.TabIndex = 3
        Me.tbOthers.Text = "Others"
        Me.tbOthers.UseVisualStyleBackColor = True
        '
        'lblPrinterSetup
        '
        Me.lblPrinterSetup.AutoSize = True
        Me.lblPrinterSetup.Location = New System.Drawing.Point(10, 215)
        Me.lblPrinterSetup.Name = "lblPrinterSetup"
        Me.lblPrinterSetup.Size = New System.Drawing.Size(68, 13)
        Me.lblPrinterSetup.TabIndex = 43
        Me.lblPrinterSetup.Text = "Printer Setup"
        Me.lblPrinterSetup.Visible = False
        '
        'cboPrinterSetup
        '
        Me.cboPrinterSetup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPrinterSetup.FormattingEnabled = True
        Me.cboPrinterSetup.Location = New System.Drawing.Point(140, 212)
        Me.cboPrinterSetup.Name = "cboPrinterSetup"
        Me.cboPrinterSetup.Size = New System.Drawing.Size(131, 21)
        Me.cboPrinterSetup.TabIndex = 42
        Me.cboPrinterSetup.Visible = False
        '
        'btnRetrieve
        '
        Me.btnRetrieve.Location = New System.Drawing.Point(210, 80)
        Me.btnRetrieve.Name = "btnRetrieve"
        Me.btnRetrieve.Size = New System.Drawing.Size(75, 23)
        Me.btnRetrieve.TabIndex = 41
        Me.btnRetrieve.Text = "&Retrieve"
        Me.btnRetrieve.UseVisualStyleBackColor = True
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picLogo.Location = New System.Drawing.Point(140, 40)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(64, 64)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 40
        Me.picLogo.TabStop = False
        '
        'lblCurrentSysLocale
        '
        Me.lblCurrentSysLocale.AutoSize = True
        Me.lblCurrentSysLocale.Location = New System.Drawing.Point(10, 144)
        Me.lblCurrentSysLocale.Name = "lblCurrentSysLocale"
        Me.lblCurrentSysLocale.Size = New System.Drawing.Size(113, 13)
        Me.lblCurrentSysLocale.TabIndex = 39
        Me.lblCurrentSysLocale.Text = "Current System Locale"
        '
        'cboLocale
        '
        Me.cboLocale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLocale.FormattingEnabled = True
        Me.cboLocale.Location = New System.Drawing.Point(140, 141)
        Me.cboLocale.Name = "cboLocale"
        Me.cboLocale.Size = New System.Drawing.Size(259, 21)
        Me.cboLocale.TabIndex = 38
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(140, 114)
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(45, 20)
        Me.NumericUpDown1.TabIndex = 35
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblMinimumHour
        '
        Me.lblMinimumHour.Location = New System.Drawing.Point(10, 114)
        Me.lblMinimumHour.Name = "lblMinimumHour"
        Me.lblMinimumHour.Size = New System.Drawing.Size(100, 30)
        Me.lblMinimumHour.TabIndex = 34
        Me.lblMinimumHour.Text = "Minimum hour of End Day Closing"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(210, 40)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 30
        Me.btnBrowse.Text = "&Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'lblLogo
        '
        Me.lblLogo.AutoSize = True
        Me.lblLogo.Location = New System.Drawing.Point(10, 40)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(31, 13)
        Me.lblLogo.TabIndex = 29
        Me.lblLogo.Text = "Logo"
        '
        'txtWelcome
        '
        Me.txtWelcome.Location = New System.Drawing.Point(140, 14)
        Me.txtWelcome.Name = "txtWelcome"
        Me.txtWelcome.Size = New System.Drawing.Size(348, 20)
        Me.txtWelcome.TabIndex = 27
        '
        'lblWelcomeTo
        '
        Me.lblWelcomeTo.AutoSize = True
        Me.lblWelcomeTo.Location = New System.Drawing.Point(10, 17)
        Me.lblWelcomeTo.Name = "lblWelcomeTo"
        Me.lblWelcomeTo.Size = New System.Drawing.Size(68, 13)
        Me.lblWelcomeTo.TabIndex = 26
        Me.lblWelcomeTo.Text = "Welcome To"
        '
        'tbPrintable
        '
        Me.tbPrintable.Controls.Add(Me.cboPrintableStockSummarySoldReport)
        Me.tbPrintable.Controls.Add(Me.lblStockSummarySoldReport)
        Me.tbPrintable.Controls.Add(Me.cboPrintableDailySalesReport)
        Me.tbPrintable.Controls.Add(Me.lblDailySalesReport)
        Me.tbPrintable.Controls.Add(Me.cboPrintableReceipt)
        Me.tbPrintable.Controls.Add(Me.lblReceipt)
        Me.tbPrintable.Location = New System.Drawing.Point(4, 22)
        Me.tbPrintable.Name = "tbPrintable"
        Me.tbPrintable.Size = New System.Drawing.Size(552, 244)
        Me.tbPrintable.TabIndex = 5
        Me.tbPrintable.Text = "Printable"
        Me.tbPrintable.UseVisualStyleBackColor = True
        '
        'cboPrintableStockSummarySoldReport
        '
        Me.cboPrintableStockSummarySoldReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPrintableStockSummarySoldReport.FormattingEnabled = True
        Me.cboPrintableStockSummarySoldReport.Location = New System.Drawing.Point(187, 68)
        Me.cboPrintableStockSummarySoldReport.Name = "cboPrintableStockSummarySoldReport"
        Me.cboPrintableStockSummarySoldReport.Size = New System.Drawing.Size(217, 21)
        Me.cboPrintableStockSummarySoldReport.TabIndex = 16
        '
        'lblStockSummarySoldReport
        '
        Me.lblStockSummarySoldReport.AutoSize = True
        Me.lblStockSummarySoldReport.Location = New System.Drawing.Point(10, 71)
        Me.lblStockSummarySoldReport.Name = "lblStockSummarySoldReport"
        Me.lblStockSummarySoldReport.Size = New System.Drawing.Size(140, 13)
        Me.lblStockSummarySoldReport.TabIndex = 17
        Me.lblStockSummarySoldReport.Text = "Stock Summary Sold Report"
        '
        'cboPrintableDailySalesReport
        '
        Me.cboPrintableDailySalesReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPrintableDailySalesReport.FormattingEnabled = True
        Me.cboPrintableDailySalesReport.Location = New System.Drawing.Point(187, 41)
        Me.cboPrintableDailySalesReport.Name = "cboPrintableDailySalesReport"
        Me.cboPrintableDailySalesReport.Size = New System.Drawing.Size(217, 21)
        Me.cboPrintableDailySalesReport.TabIndex = 14
        '
        'lblDailySalesReport
        '
        Me.lblDailySalesReport.AutoSize = True
        Me.lblDailySalesReport.Location = New System.Drawing.Point(10, 44)
        Me.lblDailySalesReport.Name = "lblDailySalesReport"
        Me.lblDailySalesReport.Size = New System.Drawing.Size(94, 13)
        Me.lblDailySalesReport.TabIndex = 15
        Me.lblDailySalesReport.Text = "Daily Sales Report"
        '
        'cboPrintableReceipt
        '
        Me.cboPrintableReceipt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPrintableReceipt.FormattingEnabled = True
        Me.cboPrintableReceipt.Location = New System.Drawing.Point(187, 14)
        Me.cboPrintableReceipt.Name = "cboPrintableReceipt"
        Me.cboPrintableReceipt.Size = New System.Drawing.Size(217, 21)
        Me.cboPrintableReceipt.TabIndex = 11
        '
        'lblReceipt
        '
        Me.lblReceipt.AutoSize = True
        Me.lblReceipt.Location = New System.Drawing.Point(10, 17)
        Me.lblReceipt.Name = "lblReceipt"
        Me.lblReceipt.Size = New System.Drawing.Size(44, 13)
        Me.lblReceipt.TabIndex = 13
        Me.lblReceipt.Text = "Receipt"
        '
        'tbImportExport
        '
        Me.tbImportExport.Controls.Add(Me.GroupBox1)
        Me.tbImportExport.Controls.Add(Me.grpImport)
        Me.tbImportExport.Location = New System.Drawing.Point(4, 22)
        Me.tbImportExport.Name = "tbImportExport"
        Me.tbImportExport.Size = New System.Drawing.Size(552, 244)
        Me.tbImportExport.TabIndex = 6
        Me.tbImportExport.Text = "Import And Export"
        Me.tbImportExport.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblDateTo)
        Me.GroupBox1.Controls.Add(Me.lblDateFrom)
        Me.GroupBox1.Controls.Add(Me.dtpDateTo)
        Me.GroupBox1.Controls.Add(Me.dtpDateFrom)
        Me.GroupBox1.Controls.Add(Me.chkDate)
        Me.GroupBox1.Controls.Add(Me.lblExportMsg)
        Me.GroupBox1.Controls.Add(Me.btnExport)
        Me.GroupBox1.Controls.Add(Me.lblExportFile)
        Me.GroupBox1.Controls.Add(Me.txtExportFile)
        Me.GroupBox1.Controls.Add(Me.btnBrowseExport)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(525, 128)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Export Transaction Queue"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(50, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(434, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "If the date is not checked, it will export all transactions that have not been ex" & _
            "ported before."
        '
        'lblDateTo
        '
        Me.lblDateTo.AutoSize = True
        Me.lblDateTo.Location = New System.Drawing.Point(234, 58)
        Me.lblDateTo.Name = "lblDateTo"
        Me.lblDateTo.Size = New System.Drawing.Size(46, 13)
        Me.lblDateTo.TabIndex = 21
        Me.lblDateTo.Text = "Date To"
        '
        'lblDateFrom
        '
        Me.lblDateFrom.AutoSize = True
        Me.lblDateFrom.Location = New System.Drawing.Point(71, 58)
        Me.lblDateFrom.Name = "lblDateFrom"
        Me.lblDateFrom.Size = New System.Drawing.Size(56, 13)
        Me.lblDateFrom.TabIndex = 20
        Me.lblDateFrom.Text = "Date From"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "yyyy-MM-dd"
        Me.dtpDateTo.Enabled = False
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(286, 54)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(96, 20)
        Me.dtpDateTo.TabIndex = 19
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.CustomFormat = "yyyy-MM-dd"
        Me.dtpDateFrom.Enabled = False
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFrom.Location = New System.Drawing.Point(132, 55)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(96, 20)
        Me.dtpDateFrom.TabIndex = 18
        '
        'chkDate
        '
        Me.chkDate.AutoSize = True
        Me.chkDate.Location = New System.Drawing.Point(53, 60)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.Size = New System.Drawing.Size(15, 14)
        Me.chkDate.TabIndex = 17
        Me.chkDate.UseVisualStyleBackColor = True
        '
        'lblExportMsg
        '
        Me.lblExportMsg.AutoSize = True
        Me.lblExportMsg.Location = New System.Drawing.Point(65, 100)
        Me.lblExportMsg.Name = "lblExportMsg"
        Me.lblExportMsg.Size = New System.Drawing.Size(67, 13)
        Me.lblExportMsg.TabIndex = 16
        Me.lblExportMsg.Text = "lblExportMsg"
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(427, 25)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(75, 23)
        Me.btnExport.TabIndex = 15
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'lblExportFile
        '
        Me.lblExportFile.AutoSize = True
        Me.lblExportFile.Location = New System.Drawing.Point(20, 30)
        Me.lblExportFile.Name = "lblExportFile"
        Me.lblExportFile.Size = New System.Drawing.Size(26, 13)
        Me.lblExportFile.TabIndex = 13
        Me.lblExportFile.Text = "File:"
        '
        'txtExportFile
        '
        Me.txtExportFile.Location = New System.Drawing.Point(52, 27)
        Me.txtExportFile.Name = "txtExportFile"
        Me.txtExportFile.Size = New System.Drawing.Size(280, 20)
        Me.txtExportFile.TabIndex = 14
        '
        'btnBrowseExport
        '
        Me.btnBrowseExport.Location = New System.Drawing.Point(338, 25)
        Me.btnBrowseExport.Name = "btnBrowseExport"
        Me.btnBrowseExport.Size = New System.Drawing.Size(83, 23)
        Me.btnBrowseExport.TabIndex = 12
        Me.btnBrowseExport.Text = "Browse..."
        Me.btnBrowseExport.UseVisualStyleBackColor = True
        '
        'grpImport
        '
        Me.grpImport.Controls.Add(Me.lblImportMsg)
        Me.grpImport.Controls.Add(Me.btnImport)
        Me.grpImport.Controls.Add(Me.lblImportFile)
        Me.grpImport.Controls.Add(Me.txtImportFile)
        Me.grpImport.Controls.Add(Me.btnBrowseImport)
        Me.grpImport.Location = New System.Drawing.Point(13, 3)
        Me.grpImport.Name = "grpImport"
        Me.grpImport.Size = New System.Drawing.Size(525, 89)
        Me.grpImport.TabIndex = 15
        Me.grpImport.TabStop = False
        Me.grpImport.Text = "Import Master Data from EMP"
        '
        'lblImportMsg
        '
        Me.lblImportMsg.AutoSize = True
        Me.lblImportMsg.Location = New System.Drawing.Point(65, 60)
        Me.lblImportMsg.Name = "lblImportMsg"
        Me.lblImportMsg.Size = New System.Drawing.Size(66, 13)
        Me.lblImportMsg.TabIndex = 16
        Me.lblImportMsg.Text = "lblImportMsg"
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(427, 25)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(75, 23)
        Me.btnImport.TabIndex = 15
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'lblImportFile
        '
        Me.lblImportFile.AutoSize = True
        Me.lblImportFile.Location = New System.Drawing.Point(20, 30)
        Me.lblImportFile.Name = "lblImportFile"
        Me.lblImportFile.Size = New System.Drawing.Size(26, 13)
        Me.lblImportFile.TabIndex = 13
        Me.lblImportFile.Text = "File:"
        '
        'txtImportFile
        '
        Me.txtImportFile.Location = New System.Drawing.Point(52, 27)
        Me.txtImportFile.Name = "txtImportFile"
        Me.txtImportFile.Size = New System.Drawing.Size(280, 20)
        Me.txtImportFile.TabIndex = 14
        '
        'btnBrowseImport
        '
        Me.btnBrowseImport.Location = New System.Drawing.Point(338, 25)
        Me.btnBrowseImport.Name = "btnBrowseImport"
        Me.btnBrowseImport.Size = New System.Drawing.Size(83, 23)
        Me.btnBrowseImport.TabIndex = 12
        Me.btnBrowseImport.Text = "Browse..."
        Me.btnBrowseImport.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnApply
        '
        Me.btnApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApply.AutoEllipsis = True
        Me.btnApply.Location = New System.Drawing.Point(501, 358)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 36)
        Me.btnApply.TabIndex = 6
        Me.btnApply.Tag = ""
        Me.btnApply.Text = "&Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Timer3
        '
        Me.Timer3.Interval = 10
        '
        'chkUploadByLimit
        '
        Me.chkUploadByLimit.AutoSize = True
        Me.chkUploadByLimit.Location = New System.Drawing.Point(245, 108)
        Me.chkUploadByLimit.Name = "chkUploadByLimit"
        Me.chkUploadByLimit.Size = New System.Drawing.Size(99, 17)
        Me.chkUploadByLimit.TabIndex = 47
        Me.chkUploadByLimit.Text = "Upload By Limit"
        Me.chkUploadByLimit.UseVisualStyleBackColor = True
        '
        'nuLimit
        '
        Me.nuLimit.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nuLimit.Location = New System.Drawing.Point(351, 108)
        Me.nuLimit.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nuLimit.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nuLimit.Name = "nuLimit"
        Me.nuLimit.Size = New System.Drawing.Size(56, 20)
        Me.nuLimit.TabIndex = 48
        Me.nuLimit.Value = New Decimal(New Integer() {200, 0, 0, 0})
        '
        'frmConfig
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(597, 398)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuration"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tbStandard.ResumeLayout(False)
        Me.tbStandard.PerformLayout()
        Me.tbMessageSetup.ResumeLayout(False)
        Me.tbMessageSetup.PerformLayout()
        Me.tbReceiptBottomMsg.ResumeLayout(False)
        Me.tbReceiptBottomMsg.PerformLayout()
        Me.tbSynch.ResumeLayout(False)
        Me.tbSynch.PerformLayout()
        Me.tbOthers.ResumeLayout(False)
        Me.tbOthers.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbPrintable.ResumeLayout(False)
        Me.tbPrintable.PerformLayout()
        Me.tbImportExport.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpImport.ResumeLayout(False)
        Me.grpImport.PerformLayout()
        CType(Me.nuLimit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tbStandard As System.Windows.Forms.TabPage
    Friend WithEvents txtHost As System.Windows.Forms.TextBox
    Friend WithEvents lblDatabaseHost As System.Windows.Forms.Label
    Friend WithEvents cboPrices As System.Windows.Forms.ComboBox
    Friend WithEvents lblPriceSchema As System.Windows.Forms.Label
    Friend WithEvents cboBranches As System.Windows.Forms.ComboBox
    Friend WithEvents lblBranch As System.Windows.Forms.Label
    Friend WithEvents tbMessageSetup As System.Windows.Forms.TabPage
    Friend WithEvents txtSucceedVoid As System.Windows.Forms.TextBox
    Friend WithEvents txtSucceedDelete As System.Windows.Forms.TextBox
    Friend WithEvents txtSucceedTxn As System.Windows.Forms.TextBox
    Friend WithEvents txtConfirmVoid As System.Windows.Forms.TextBox
    Friend WithEvents txtConfirmDelete As System.Windows.Forms.TextBox
    Friend WithEvents txtConfirmTxn As System.Windows.Forms.TextBox
    Friend WithEvents tbReceiptBottomMsg As System.Windows.Forms.TabPage
    Friend WithEvents txtMsg3 As System.Windows.Forms.TextBox
    Friend WithEvents lblMessage3 As System.Windows.Forms.Label
    Friend WithEvents txtMsg2 As System.Windows.Forms.TextBox
    Friend WithEvents lblMessage2 As System.Windows.Forms.Label
    Friend WithEvents txtMsg1 As System.Windows.Forms.TextBox
    Friend WithEvents lblMessage1 As System.Windows.Forms.Label
    Friend WithEvents chkConfirmVoid As System.Windows.Forms.CheckBox
    Friend WithEvents chkConfirmDelete As System.Windows.Forms.CheckBox
    Friend WithEvents chkConfirmTxn As System.Windows.Forms.CheckBox
    Friend WithEvents chkSucceedVoid As System.Windows.Forms.CheckBox
    Friend WithEvents chkSucceedDelete As System.Windows.Forms.CheckBox
    Friend WithEvents chkSucceedTxn As System.Windows.Forms.CheckBox
    Friend WithEvents chkPaymentExceed As System.Windows.Forms.CheckBox
    Friend WithEvents txtPaymentExceed As System.Windows.Forms.TextBox
    Friend WithEvents tbOthers As System.Windows.Forms.TabPage
    Friend WithEvents txtWelcome As System.Windows.Forms.TextBox
    Friend WithEvents lblWelcomeTo As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents lblLogo As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblMinimumHour As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtMsg4 As System.Windows.Forms.TextBox
    Friend WithEvents lblMessage4 As System.Windows.Forms.Label
    Friend WithEvents tbSynch As System.Windows.Forms.TabPage
    Friend WithEvents txtWebService As System.Windows.Forms.TextBox
    Friend WithEvents lblSyncWebService As System.Windows.Forms.Label
    Friend WithEvents btnDownload As System.Windows.Forms.Button
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents chkSelligBelowQty As System.Windows.Forms.CheckBox
    Friend WithEvents lblTransaction As System.Windows.Forms.Label
    Friend WithEvents chkSelligBelowMinPrice As System.Windows.Forms.CheckBox
    Friend WithEvents txtSyncResult As System.Windows.Forms.TextBox
    Friend WithEvents chkPriceIncludeTax As System.Windows.Forms.CheckBox
    Friend WithEvents chkRemarksRequired As System.Windows.Forms.CheckBox
    Friend WithEvents chkAddNewLine As System.Windows.Forms.CheckBox
    Friend WithEvents chkDisallowUser As System.Windows.Forms.CheckBox
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents lblEnd As System.Windows.Forms.Label
    Friend WithEvents lblCurrentSysLocale As System.Windows.Forms.Label
    Friend WithEvents cboLocale As System.Windows.Forms.ComboBox
    Friend WithEvents tbPrintable As System.Windows.Forms.TabPage
    Friend WithEvents cboPrintableReceipt As System.Windows.Forms.ComboBox
    Friend WithEvents lblReceipt As System.Windows.Forms.Label
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnRetrieve As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cboPrintableDailySalesReport As System.Windows.Forms.ComboBox
    Friend WithEvents lblDailySalesReport As System.Windows.Forms.Label
    Friend WithEvents lblPrinterSetup As System.Windows.Forms.Label
    Friend WithEvents cboPrinterSetup As System.Windows.Forms.ComboBox
    Friend WithEvents cboPrintableStockSummarySoldReport As System.Windows.Forms.ComboBox
    Friend WithEvents lblStockSummarySoldReport As System.Windows.Forms.Label
    Friend WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents lblSyncTimingExample As System.Windows.Forms.Label
    Friend WithEvents txtSyncerTiming As System.Windows.Forms.TextBox
    Friend WithEvents lblSyncTiming As System.Windows.Forms.Label
    Friend WithEvents chkAutoSynchronize As System.Windows.Forms.CheckBox
    Friend WithEvents lblUpload As System.Windows.Forms.Label
    Friend WithEvents lblDownload As System.Windows.Forms.Label
    Friend WithEvents lblItemCode As System.Windows.Forms.Label
    Friend WithEvents txtItemCode As System.Windows.Forms.TextBox
    Friend WithEvents chkApplyFiveCent As System.Windows.Forms.CheckBox
    Friend WithEvents tbImportExport As System.Windows.Forms.TabPage
    Friend WithEvents btnBrowseImport As System.Windows.Forms.Button
    Friend WithEvents lblImportFile As System.Windows.Forms.Label
    Friend WithEvents grpImport As System.Windows.Forms.GroupBox
    Friend WithEvents txtImportFile As System.Windows.Forms.TextBox
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents lblImportMsg As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblExportMsg As System.Windows.Forms.Label
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents lblExportFile As System.Windows.Forms.Label
    Friend WithEvents txtExportFile As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowseExport As System.Windows.Forms.Button
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents lblEndTime As System.Windows.Forms.Label
    Friend WithEvents lblStartTime As System.Windows.Forms.Label
    Friend WithEvents chkDate As System.Windows.Forms.CheckBox
    Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDateTo As System.Windows.Forms.Label
    Friend WithEvents lblDateFrom As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents chkUploadByLimit As System.Windows.Forms.CheckBox
    Friend WithEvents nuLimit As System.Windows.Forms.NumericUpDown
End Class
