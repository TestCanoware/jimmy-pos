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
        Me.nuLimit = New System.Windows.Forms.NumericUpDown
        Me.chkUploadByLimit = New System.Windows.Forms.CheckBox
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
        Me.grpExport = New System.Windows.Forms.GroupBox
        Me.lblExportDateMsg = New System.Windows.Forms.Label
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tbStandard.SuspendLayout()
        Me.tbMessageSetup.SuspendLayout()
        Me.tbReceiptBottomMsg.SuspendLayout()
        Me.tbSynch.SuspendLayout()
        CType(Me.nuLimit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbOthers.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbPrintable.SuspendLayout()
        Me.tbImportExport.SuspendLayout()
        Me.grpExport.SuspendLayout()
        Me.grpImport.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = Global.JimmyPos.My.Resources.Resources.Configuration
        Me.PictureBox1.InitialImage = Nothing
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'btnOk
        '
        resources.ApplyResources(Me.btnOk, "btnOk")
        Me.btnOk.AutoEllipsis = True
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Tag = ""
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        resources.ApplyResources(Me.btnCancel, "btnCancel")
        Me.btnCancel.AutoEllipsis = True
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Tag = ""
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        resources.ApplyResources(Me.lblTitle, "lblTitle")
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Tag = "frmConfig.title.lable"
        '
        'TabControl1
        '
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.Controls.Add(Me.tbStandard)
        Me.TabControl1.Controls.Add(Me.tbMessageSetup)
        Me.TabControl1.Controls.Add(Me.tbReceiptBottomMsg)
        Me.TabControl1.Controls.Add(Me.tbSynch)
        Me.TabControl1.Controls.Add(Me.tbOthers)
        Me.TabControl1.Controls.Add(Me.tbPrintable)
        Me.TabControl1.Controls.Add(Me.tbImportExport)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
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
        resources.ApplyResources(Me.tbStandard, "tbStandard")
        Me.tbStandard.Name = "tbStandard"
        Me.tbStandard.UseVisualStyleBackColor = True
        '
        'lblItemCode
        '
        resources.ApplyResources(Me.lblItemCode, "lblItemCode")
        Me.lblItemCode.Name = "lblItemCode"
        '
        'txtItemCode
        '
        resources.ApplyResources(Me.txtItemCode, "txtItemCode")
        Me.txtItemCode.Name = "txtItemCode"
        '
        'chkApplyFiveCent
        '
        resources.ApplyResources(Me.chkApplyFiveCent, "chkApplyFiveCent")
        Me.chkApplyFiveCent.Name = "chkApplyFiveCent"
        Me.chkApplyFiveCent.UseVisualStyleBackColor = True
        '
        'chkDisallowUser
        '
        resources.ApplyResources(Me.chkDisallowUser, "chkDisallowUser")
        Me.chkDisallowUser.Name = "chkDisallowUser"
        Me.chkDisallowUser.UseVisualStyleBackColor = True
        '
        'chkAddNewLine
        '
        resources.ApplyResources(Me.chkAddNewLine, "chkAddNewLine")
        Me.chkAddNewLine.Name = "chkAddNewLine"
        Me.chkAddNewLine.UseVisualStyleBackColor = True
        '
        'chkRemarksRequired
        '
        resources.ApplyResources(Me.chkRemarksRequired, "chkRemarksRequired")
        Me.chkRemarksRequired.Name = "chkRemarksRequired"
        Me.chkRemarksRequired.UseVisualStyleBackColor = True
        '
        'chkPriceIncludeTax
        '
        resources.ApplyResources(Me.chkPriceIncludeTax, "chkPriceIncludeTax")
        Me.chkPriceIncludeTax.Name = "chkPriceIncludeTax"
        Me.chkPriceIncludeTax.UseVisualStyleBackColor = True
        '
        'chkSelligBelowQty
        '
        resources.ApplyResources(Me.chkSelligBelowQty, "chkSelligBelowQty")
        Me.chkSelligBelowQty.Name = "chkSelligBelowQty"
        Me.chkSelligBelowQty.UseVisualStyleBackColor = True
        '
        'lblTransaction
        '
        resources.ApplyResources(Me.lblTransaction, "lblTransaction")
        Me.lblTransaction.Name = "lblTransaction"
        '
        'chkSelligBelowMinPrice
        '
        resources.ApplyResources(Me.chkSelligBelowMinPrice, "chkSelligBelowMinPrice")
        Me.chkSelligBelowMinPrice.Name = "chkSelligBelowMinPrice"
        Me.chkSelligBelowMinPrice.UseVisualStyleBackColor = True
        '
        'txtHost
        '
        resources.ApplyResources(Me.txtHost, "txtHost")
        Me.txtHost.Name = "txtHost"
        '
        'lblDatabaseHost
        '
        resources.ApplyResources(Me.lblDatabaseHost, "lblDatabaseHost")
        Me.lblDatabaseHost.Name = "lblDatabaseHost"
        '
        'cboPrices
        '
        Me.cboPrices.FormattingEnabled = True
        resources.ApplyResources(Me.cboPrices, "cboPrices")
        Me.cboPrices.Name = "cboPrices"
        '
        'lblPriceSchema
        '
        resources.ApplyResources(Me.lblPriceSchema, "lblPriceSchema")
        Me.lblPriceSchema.Name = "lblPriceSchema"
        '
        'cboBranches
        '
        Me.cboBranches.FormattingEnabled = True
        resources.ApplyResources(Me.cboBranches, "cboBranches")
        Me.cboBranches.Name = "cboBranches"
        '
        'lblBranch
        '
        resources.ApplyResources(Me.lblBranch, "lblBranch")
        Me.lblBranch.Name = "lblBranch"
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
        resources.ApplyResources(Me.tbMessageSetup, "tbMessageSetup")
        Me.tbMessageSetup.Name = "tbMessageSetup"
        Me.tbMessageSetup.UseVisualStyleBackColor = True
        '
        'txtSucceedDelete
        '
        resources.ApplyResources(Me.txtSucceedDelete, "txtSucceedDelete")
        Me.txtSucceedDelete.Name = "txtSucceedDelete"
        '
        'chkPaymentExceed
        '
        resources.ApplyResources(Me.chkPaymentExceed, "chkPaymentExceed")
        Me.chkPaymentExceed.Name = "chkPaymentExceed"
        Me.chkPaymentExceed.UseVisualStyleBackColor = True
        '
        'txtPaymentExceed
        '
        resources.ApplyResources(Me.txtPaymentExceed, "txtPaymentExceed")
        Me.txtPaymentExceed.Name = "txtPaymentExceed"
        '
        'chkSucceedVoid
        '
        resources.ApplyResources(Me.chkSucceedVoid, "chkSucceedVoid")
        Me.chkSucceedVoid.Name = "chkSucceedVoid"
        Me.chkSucceedVoid.UseVisualStyleBackColor = True
        '
        'chkSucceedTxn
        '
        resources.ApplyResources(Me.chkSucceedTxn, "chkSucceedTxn")
        Me.chkSucceedTxn.Name = "chkSucceedTxn"
        Me.chkSucceedTxn.UseVisualStyleBackColor = True
        '
        'chkConfirmVoid
        '
        resources.ApplyResources(Me.chkConfirmVoid, "chkConfirmVoid")
        Me.chkConfirmVoid.Name = "chkConfirmVoid"
        Me.chkConfirmVoid.UseVisualStyleBackColor = True
        '
        'chkConfirmDelete
        '
        resources.ApplyResources(Me.chkConfirmDelete, "chkConfirmDelete")
        Me.chkConfirmDelete.Name = "chkConfirmDelete"
        Me.chkConfirmDelete.UseVisualStyleBackColor = True
        '
        'chkConfirmTxn
        '
        resources.ApplyResources(Me.chkConfirmTxn, "chkConfirmTxn")
        Me.chkConfirmTxn.Name = "chkConfirmTxn"
        Me.chkConfirmTxn.UseVisualStyleBackColor = True
        '
        'txtSucceedVoid
        '
        resources.ApplyResources(Me.txtSucceedVoid, "txtSucceedVoid")
        Me.txtSucceedVoid.Name = "txtSucceedVoid"
        '
        'txtSucceedTxn
        '
        resources.ApplyResources(Me.txtSucceedTxn, "txtSucceedTxn")
        Me.txtSucceedTxn.Name = "txtSucceedTxn"
        '
        'txtConfirmVoid
        '
        resources.ApplyResources(Me.txtConfirmVoid, "txtConfirmVoid")
        Me.txtConfirmVoid.Name = "txtConfirmVoid"
        '
        'txtConfirmDelete
        '
        resources.ApplyResources(Me.txtConfirmDelete, "txtConfirmDelete")
        Me.txtConfirmDelete.Name = "txtConfirmDelete"
        '
        'txtConfirmTxn
        '
        resources.ApplyResources(Me.txtConfirmTxn, "txtConfirmTxn")
        Me.txtConfirmTxn.Name = "txtConfirmTxn"
        '
        'chkSucceedDelete
        '
        resources.ApplyResources(Me.chkSucceedDelete, "chkSucceedDelete")
        Me.chkSucceedDelete.Name = "chkSucceedDelete"
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
        resources.ApplyResources(Me.tbReceiptBottomMsg, "tbReceiptBottomMsg")
        Me.tbReceiptBottomMsg.Name = "tbReceiptBottomMsg"
        Me.tbReceiptBottomMsg.UseVisualStyleBackColor = True
        '
        'txtMsg4
        '
        resources.ApplyResources(Me.txtMsg4, "txtMsg4")
        Me.txtMsg4.Name = "txtMsg4"
        '
        'lblMessage4
        '
        resources.ApplyResources(Me.lblMessage4, "lblMessage4")
        Me.lblMessage4.Name = "lblMessage4"
        '
        'txtMsg3
        '
        resources.ApplyResources(Me.txtMsg3, "txtMsg3")
        Me.txtMsg3.Name = "txtMsg3"
        '
        'lblMessage3
        '
        resources.ApplyResources(Me.lblMessage3, "lblMessage3")
        Me.lblMessage3.Name = "lblMessage3"
        '
        'txtMsg2
        '
        resources.ApplyResources(Me.txtMsg2, "txtMsg2")
        Me.txtMsg2.Name = "txtMsg2"
        '
        'lblMessage2
        '
        resources.ApplyResources(Me.lblMessage2, "lblMessage2")
        Me.lblMessage2.Name = "lblMessage2"
        '
        'txtMsg1
        '
        resources.ApplyResources(Me.txtMsg1, "txtMsg1")
        Me.txtMsg1.Name = "txtMsg1"
        '
        'lblMessage1
        '
        resources.ApplyResources(Me.lblMessage1, "lblMessage1")
        Me.lblMessage1.Name = "lblMessage1"
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
        resources.ApplyResources(Me.tbSynch, "tbSynch")
        Me.tbSynch.Name = "tbSynch"
        Me.tbSynch.UseVisualStyleBackColor = True
        '
        'nuLimit
        '
        resources.ApplyResources(Me.nuLimit, "nuLimit")
        Me.nuLimit.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nuLimit.Name = "nuLimit"
        Me.nuLimit.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'chkUploadByLimit
        '
        resources.ApplyResources(Me.chkUploadByLimit, "chkUploadByLimit")
        Me.chkUploadByLimit.Name = "chkUploadByLimit"
        Me.chkUploadByLimit.UseVisualStyleBackColor = True
        '
        'lblEndTime
        '
        resources.ApplyResources(Me.lblEndTime, "lblEndTime")
        Me.lblEndTime.Name = "lblEndTime"
        '
        'lblStartTime
        '
        resources.ApplyResources(Me.lblStartTime, "lblStartTime")
        Me.lblStartTime.Name = "lblStartTime"
        '
        'lblUpload
        '
        resources.ApplyResources(Me.lblUpload, "lblUpload")
        Me.lblUpload.Name = "lblUpload"
        '
        'lblDownload
        '
        resources.ApplyResources(Me.lblDownload, "lblDownload")
        Me.lblDownload.Name = "lblDownload"
        '
        'lblSyncTimingExample
        '
        resources.ApplyResources(Me.lblSyncTimingExample, "lblSyncTimingExample")
        Me.lblSyncTimingExample.Name = "lblSyncTimingExample"
        '
        'txtSyncerTiming
        '
        resources.ApplyResources(Me.txtSyncerTiming, "txtSyncerTiming")
        Me.txtSyncerTiming.Name = "txtSyncerTiming"
        '
        'lblSyncTiming
        '
        resources.ApplyResources(Me.lblSyncTiming, "lblSyncTiming")
        Me.lblSyncTiming.Name = "lblSyncTiming"
        '
        'chkAutoSynchronize
        '
        resources.ApplyResources(Me.chkAutoSynchronize, "chkAutoSynchronize")
        Me.chkAutoSynchronize.Name = "chkAutoSynchronize"
        Me.chkAutoSynchronize.UseVisualStyleBackColor = True
        '
        'btnUpload
        '
        resources.ApplyResources(Me.btnUpload, "btnUpload")
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'lblEnd
        '
        resources.ApplyResources(Me.lblEnd, "lblEnd")
        Me.lblEnd.Name = "lblEnd"
        '
        'lblStart
        '
        resources.ApplyResources(Me.lblStart, "lblStart")
        Me.lblStart.Name = "lblStart"
        '
        'txtSyncResult
        '
        resources.ApplyResources(Me.txtSyncResult, "txtSyncResult")
        Me.txtSyncResult.Name = "txtSyncResult"
        '
        'btnDownload
        '
        resources.ApplyResources(Me.btnDownload, "btnDownload")
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.UseVisualStyleBackColor = True
        '
        'txtWebService
        '
        resources.ApplyResources(Me.txtWebService, "txtWebService")
        Me.txtWebService.Name = "txtWebService"
        '
        'lblSyncWebService
        '
        resources.ApplyResources(Me.lblSyncWebService, "lblSyncWebService")
        Me.lblSyncWebService.Name = "lblSyncWebService"
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
        resources.ApplyResources(Me.tbOthers, "tbOthers")
        Me.tbOthers.Name = "tbOthers"
        Me.tbOthers.UseVisualStyleBackColor = True
        '
        'lblPrinterSetup
        '
        resources.ApplyResources(Me.lblPrinterSetup, "lblPrinterSetup")
        Me.lblPrinterSetup.Name = "lblPrinterSetup"
        '
        'cboPrinterSetup
        '
        Me.cboPrinterSetup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPrinterSetup.FormattingEnabled = True
        resources.ApplyResources(Me.cboPrinterSetup, "cboPrinterSetup")
        Me.cboPrinterSetup.Name = "cboPrinterSetup"
        '
        'btnRetrieve
        '
        resources.ApplyResources(Me.btnRetrieve, "btnRetrieve")
        Me.btnRetrieve.Name = "btnRetrieve"
        Me.btnRetrieve.UseVisualStyleBackColor = True
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.picLogo, "picLogo")
        Me.picLogo.Name = "picLogo"
        Me.picLogo.TabStop = False
        '
        'lblCurrentSysLocale
        '
        resources.ApplyResources(Me.lblCurrentSysLocale, "lblCurrentSysLocale")
        Me.lblCurrentSysLocale.Name = "lblCurrentSysLocale"
        '
        'cboLocale
        '
        Me.cboLocale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLocale.FormattingEnabled = True
        resources.ApplyResources(Me.cboLocale, "cboLocale")
        Me.cboLocale.Name = "cboLocale"
        '
        'NumericUpDown1
        '
        resources.ApplyResources(Me.NumericUpDown1, "NumericUpDown1")
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblMinimumHour
        '
        resources.ApplyResources(Me.lblMinimumHour, "lblMinimumHour")
        Me.lblMinimumHour.Name = "lblMinimumHour"
        '
        'btnBrowse
        '
        resources.ApplyResources(Me.btnBrowse, "btnBrowse")
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'lblLogo
        '
        resources.ApplyResources(Me.lblLogo, "lblLogo")
        Me.lblLogo.Name = "lblLogo"
        '
        'txtWelcome
        '
        resources.ApplyResources(Me.txtWelcome, "txtWelcome")
        Me.txtWelcome.Name = "txtWelcome"
        '
        'lblWelcomeTo
        '
        resources.ApplyResources(Me.lblWelcomeTo, "lblWelcomeTo")
        Me.lblWelcomeTo.Name = "lblWelcomeTo"
        '
        'tbPrintable
        '
        Me.tbPrintable.Controls.Add(Me.cboPrintableStockSummarySoldReport)
        Me.tbPrintable.Controls.Add(Me.lblStockSummarySoldReport)
        Me.tbPrintable.Controls.Add(Me.cboPrintableDailySalesReport)
        Me.tbPrintable.Controls.Add(Me.lblDailySalesReport)
        Me.tbPrintable.Controls.Add(Me.cboPrintableReceipt)
        Me.tbPrintable.Controls.Add(Me.lblReceipt)
        resources.ApplyResources(Me.tbPrintable, "tbPrintable")
        Me.tbPrintable.Name = "tbPrintable"
        Me.tbPrintable.UseVisualStyleBackColor = True
        '
        'cboPrintableStockSummarySoldReport
        '
        Me.cboPrintableStockSummarySoldReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPrintableStockSummarySoldReport.FormattingEnabled = True
        resources.ApplyResources(Me.cboPrintableStockSummarySoldReport, "cboPrintableStockSummarySoldReport")
        Me.cboPrintableStockSummarySoldReport.Name = "cboPrintableStockSummarySoldReport"
        '
        'lblStockSummarySoldReport
        '
        resources.ApplyResources(Me.lblStockSummarySoldReport, "lblStockSummarySoldReport")
        Me.lblStockSummarySoldReport.Name = "lblStockSummarySoldReport"
        '
        'cboPrintableDailySalesReport
        '
        Me.cboPrintableDailySalesReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPrintableDailySalesReport.FormattingEnabled = True
        resources.ApplyResources(Me.cboPrintableDailySalesReport, "cboPrintableDailySalesReport")
        Me.cboPrintableDailySalesReport.Name = "cboPrintableDailySalesReport"
        '
        'lblDailySalesReport
        '
        resources.ApplyResources(Me.lblDailySalesReport, "lblDailySalesReport")
        Me.lblDailySalesReport.Name = "lblDailySalesReport"
        '
        'cboPrintableReceipt
        '
        Me.cboPrintableReceipt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPrintableReceipt.FormattingEnabled = True
        resources.ApplyResources(Me.cboPrintableReceipt, "cboPrintableReceipt")
        Me.cboPrintableReceipt.Name = "cboPrintableReceipt"
        '
        'lblReceipt
        '
        resources.ApplyResources(Me.lblReceipt, "lblReceipt")
        Me.lblReceipt.Name = "lblReceipt"
        '
        'tbImportExport
        '
        Me.tbImportExport.Controls.Add(Me.grpExport)
        Me.tbImportExport.Controls.Add(Me.grpImport)
        resources.ApplyResources(Me.tbImportExport, "tbImportExport")
        Me.tbImportExport.Name = "tbImportExport"
        Me.tbImportExport.UseVisualStyleBackColor = True
        '
        'grpExport
        '
        Me.grpExport.Controls.Add(Me.lblExportDateMsg)
        Me.grpExport.Controls.Add(Me.lblDateTo)
        Me.grpExport.Controls.Add(Me.lblDateFrom)
        Me.grpExport.Controls.Add(Me.dtpDateTo)
        Me.grpExport.Controls.Add(Me.dtpDateFrom)
        Me.grpExport.Controls.Add(Me.chkDate)
        Me.grpExport.Controls.Add(Me.lblExportMsg)
        Me.grpExport.Controls.Add(Me.btnExport)
        Me.grpExport.Controls.Add(Me.lblExportFile)
        Me.grpExport.Controls.Add(Me.txtExportFile)
        Me.grpExport.Controls.Add(Me.btnBrowseExport)
        resources.ApplyResources(Me.grpExport, "grpExport")
        Me.grpExport.Name = "grpExport"
        Me.grpExport.TabStop = False
        '
        'lblExportDateMsg
        '
        resources.ApplyResources(Me.lblExportDateMsg, "lblExportDateMsg")
        Me.lblExportDateMsg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblExportDateMsg.Name = "lblExportDateMsg"
        '
        'lblDateTo
        '
        resources.ApplyResources(Me.lblDateTo, "lblDateTo")
        Me.lblDateTo.Name = "lblDateTo"
        '
        'lblDateFrom
        '
        resources.ApplyResources(Me.lblDateFrom, "lblDateFrom")
        Me.lblDateFrom.Name = "lblDateFrom"
        '
        'dtpDateTo
        '
        resources.ApplyResources(Me.dtpDateTo, "dtpDateTo")
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Name = "dtpDateTo"
        '
        'dtpDateFrom
        '
        resources.ApplyResources(Me.dtpDateFrom, "dtpDateFrom")
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFrom.Name = "dtpDateFrom"
        '
        'chkDate
        '
        resources.ApplyResources(Me.chkDate, "chkDate")
        Me.chkDate.Name = "chkDate"
        Me.chkDate.UseVisualStyleBackColor = True
        '
        'lblExportMsg
        '
        resources.ApplyResources(Me.lblExportMsg, "lblExportMsg")
        Me.lblExportMsg.Name = "lblExportMsg"
        '
        'btnExport
        '
        resources.ApplyResources(Me.btnExport, "btnExport")
        Me.btnExport.Name = "btnExport"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'lblExportFile
        '
        resources.ApplyResources(Me.lblExportFile, "lblExportFile")
        Me.lblExportFile.Name = "lblExportFile"
        '
        'txtExportFile
        '
        resources.ApplyResources(Me.txtExportFile, "txtExportFile")
        Me.txtExportFile.Name = "txtExportFile"
        '
        'btnBrowseExport
        '
        resources.ApplyResources(Me.btnBrowseExport, "btnBrowseExport")
        Me.btnBrowseExport.Name = "btnBrowseExport"
        Me.btnBrowseExport.UseVisualStyleBackColor = True
        '
        'grpImport
        '
        Me.grpImport.Controls.Add(Me.lblImportMsg)
        Me.grpImport.Controls.Add(Me.btnImport)
        Me.grpImport.Controls.Add(Me.lblImportFile)
        Me.grpImport.Controls.Add(Me.txtImportFile)
        Me.grpImport.Controls.Add(Me.btnBrowseImport)
        resources.ApplyResources(Me.grpImport, "grpImport")
        Me.grpImport.Name = "grpImport"
        Me.grpImport.TabStop = False
        '
        'lblImportMsg
        '
        resources.ApplyResources(Me.lblImportMsg, "lblImportMsg")
        Me.lblImportMsg.Name = "lblImportMsg"
        '
        'btnImport
        '
        resources.ApplyResources(Me.btnImport, "btnImport")
        Me.btnImport.Name = "btnImport"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'lblImportFile
        '
        resources.ApplyResources(Me.lblImportFile, "lblImportFile")
        Me.lblImportFile.Name = "lblImportFile"
        '
        'txtImportFile
        '
        resources.ApplyResources(Me.txtImportFile, "txtImportFile")
        Me.txtImportFile.Name = "txtImportFile"
        '
        'btnBrowseImport
        '
        resources.ApplyResources(Me.btnBrowseImport, "btnBrowseImport")
        Me.btnBrowseImport.Name = "btnBrowseImport"
        Me.btnBrowseImport.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnApply
        '
        resources.ApplyResources(Me.btnApply, "btnApply")
        Me.btnApply.AutoEllipsis = True
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Tag = ""
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
        'frmConfig
        '
        Me.AcceptButton = Me.btnOk
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfig"
        Me.ShowIcon = False
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
        CType(Me.nuLimit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbOthers.ResumeLayout(False)
        Me.tbOthers.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbPrintable.ResumeLayout(False)
        Me.tbPrintable.PerformLayout()
        Me.tbImportExport.ResumeLayout(False)
        Me.grpExport.ResumeLayout(False)
        Me.grpExport.PerformLayout()
        Me.grpImport.ResumeLayout(False)
        Me.grpImport.PerformLayout()
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
    Friend WithEvents grpExport As System.Windows.Forms.GroupBox
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
    Friend WithEvents lblExportDateMsg As System.Windows.Forms.Label
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents chkUploadByLimit As System.Windows.Forms.CheckBox
    Friend WithEvents nuLimit As System.Windows.Forms.NumericUpDown
End Class
