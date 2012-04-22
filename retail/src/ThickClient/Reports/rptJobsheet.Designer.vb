<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptJobsheet
    Inherits DataDynamics.ActiveReports.ActiveReport3

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
        End If
        MyBase.Dispose(disposing)
    End Sub

    'NOTE: The following procedure is required by the ActiveReports Designer
    'It can be modified using the ActiveReports Designer.
    'Do not modify it using the code editor.
    Private WithEvents PageHeader1 As DataDynamics.ActiveReports.PageHeader
    Private WithEvents Detail1 As DataDynamics.ActiveReports.Detail
    Private WithEvents PageFooter1 As DataDynamics.ActiveReports.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptJobsheet))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.txtReportName = New DataDynamics.ActiveReports.TextBox
        Me.txtTime = New DataDynamics.ActiveReports.TextBox
        Me.txtUser = New DataDynamics.ActiveReports.TextBox
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox11 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
        Me.txtReceiptId = New DataDynamics.ActiveReports.TextBox
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.txtCode = New DataDynamics.ActiveReports.TextBox
        Me.txtQty = New DataDynamics.ActiveReports.TextBox
        Me.txtPrice = New DataDynamics.ActiveReports.TextBox
        Me.txtAmount = New DataDynamics.ActiveReports.TextBox
        Me.txtDesc = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.ReportHeader1 = New DataDynamics.ActiveReports.ReportHeader
        Me.srptHeader = New DataDynamics.ActiveReports.SubReport
        Me.ReportFooter1 = New DataDynamics.ActiveReports.ReportFooter
        Me.txtTotalQty = New DataDynamics.ActiveReports.TextBox
        Me.txtTotal = New DataDynamics.ActiveReports.TextBox
        Me.Line4 = New DataDynamics.ActiveReports.Line
        Me.TextBox21 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox22 = New DataDynamics.ActiveReports.TextBox
        Me.txtNetTotal = New DataDynamics.ActiveReports.TextBox
        Me.Line5 = New DataDynamics.ActiveReports.Line
        Me.txtPosMsg1 = New DataDynamics.ActiveReports.TextBox
        Me.txtPosMsg2 = New DataDynamics.ActiveReports.TextBox
        Me.Line3 = New DataDynamics.ActiveReports.Line
        Me.txtPosMsg3 = New DataDynamics.ActiveReports.TextBox
        Me.txtPosMsg4 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
        Me.txtTax = New DataDynamics.ActiveReports.TextBox
        Me.txtDeposit = New DataDynamics.ActiveReports.TextBox
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox
        CType(Me.txtReportName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReceiptId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNetTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPosMsg1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPosMsg2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPosMsg3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPosMsg4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeposit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtReportName, Me.txtTime, Me.txtUser, Me.TextBox1, Me.TextBox11, Me.TextBox9, Me.TextBox3, Me.txtReceiptId})
        Me.PageHeader1.Height = 1.0!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'txtReportName
        '
        Me.txtReportName.Border.BottomColor = System.Drawing.Color.Black
        Me.txtReportName.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtReportName.Border.LeftColor = System.Drawing.Color.Black
        Me.txtReportName.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtReportName.Border.RightColor = System.Drawing.Color.Black
        Me.txtReportName.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtReportName.Border.TopColor = System.Drawing.Color.Black
        Me.txtReportName.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtReportName.Height = 0.1875!
        Me.txtReportName.Left = 0.0!
        Me.txtReportName.Name = "txtReportName"
        Me.txtReportName.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; font-size: 8.25pt; "
        Me.txtReportName.Text = "txtReportName"
        Me.txtReportName.Top = 0.0!
        Me.txtReportName.Width = 2.4375!
        '
        'txtTime
        '
        Me.txtTime.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTime.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTime.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTime.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTime.Border.RightColor = System.Drawing.Color.Black
        Me.txtTime.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTime.Border.TopColor = System.Drawing.Color.Black
        Me.txtTime.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTime.Height = 0.1875!
        Me.txtTime.Left = 0.625!
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.txtTime.Text = "txtTime"
        Me.txtTime.Top = 0.3125!
        Me.txtTime.Width = 1.8125!
        '
        'txtUser
        '
        Me.txtUser.Border.BottomColor = System.Drawing.Color.Black
        Me.txtUser.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtUser.Border.LeftColor = System.Drawing.Color.Black
        Me.txtUser.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtUser.Border.RightColor = System.Drawing.Color.Black
        Me.txtUser.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtUser.Border.TopColor = System.Drawing.Color.Black
        Me.txtUser.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtUser.Height = 0.1875!
        Me.txtUser.Left = 0.0!
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.txtUser.Text = "txtUser"
        Me.txtUser.Top = 0.5!
        Me.txtUser.Width = 2.4375!
        '
        'TextBox1
        '
        Me.TextBox1.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Height = 0.1875!
        Me.TextBox1.Left = 0.0!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "text-decoration: underline; ddo-char-set: 0; text-align: left; font-size: 8.25pt;" & _
            " font-family: Arial; "
        Me.TextBox1.Text = "Code & Desc"
        Me.TextBox1.Top = 0.8125!
        Me.TextBox1.Width = 1.0!
        '
        'TextBox11
        '
        Me.TextBox11.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox11.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox11.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox11.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox11.Height = 0.1875!
        Me.TextBox11.Left = 1.0!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Style = "text-decoration: underline; ddo-char-set: 0; text-align: right; font-size: 8.25pt" & _
            "; font-family: Arial; "
        Me.TextBox11.Text = "Qty"
        Me.TextBox11.Top = 0.8125!
        Me.TextBox11.Width = 0.25!
        '
        'TextBox9
        '
        Me.TextBox9.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Height = 0.1875!
        Me.TextBox9.Left = 1.3125!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = "text-decoration: underline; ddo-char-set: 0; text-align: right; font-size: 8.25pt" & _
            "; font-family: Arial; "
        Me.TextBox9.Text = "Price"
        Me.TextBox9.Top = 0.8125!
        Me.TextBox9.Width = 0.5!
        '
        'TextBox3
        '
        Me.TextBox3.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Height = 0.1875!
        Me.TextBox3.Left = 1.8125!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "text-decoration: underline; ddo-char-set: 0; text-align: right; font-size: 8.25pt" & _
            "; font-family: Arial; "
        Me.TextBox3.Text = "Amt"
        Me.TextBox3.Top = 0.8125!
        Me.TextBox3.Width = 0.625!
        '
        'txtReceiptId
        '
        Me.txtReceiptId.Border.BottomColor = System.Drawing.Color.Black
        Me.txtReceiptId.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtReceiptId.Border.LeftColor = System.Drawing.Color.Black
        Me.txtReceiptId.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtReceiptId.Border.RightColor = System.Drawing.Color.Black
        Me.txtReceiptId.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtReceiptId.Border.TopColor = System.Drawing.Color.Black
        Me.txtReceiptId.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtReceiptId.Height = 0.1875!
        Me.txtReceiptId.Left = 0.0!
        Me.txtReceiptId.Name = "txtReceiptId"
        Me.txtReceiptId.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; font-family: Arial; "
        Me.txtReceiptId.Text = "txtReceiptId"
        Me.txtReceiptId.Top = 0.3125!
        Me.txtReceiptId.Width = 0.5625!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtCode, Me.txtQty, Me.txtPrice, Me.txtAmount, Me.txtDesc})
        Me.Detail1.Height = 0.3958333!
        Me.Detail1.Name = "Detail1"
        '
        'txtCode
        '
        Me.txtCode.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCode.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCode.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCode.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCode.Border.RightColor = System.Drawing.Color.Black
        Me.txtCode.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCode.Border.TopColor = System.Drawing.Color.Black
        Me.txtCode.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCode.DataField = "item_code"
        Me.txtCode.Height = 0.1875!
        Me.txtCode.Left = 0.0!
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.txtCode.Text = "txtCode"
        Me.txtCode.Top = 0.1875!
        Me.txtCode.Width = 1.0!
        '
        'txtQty
        '
        Me.txtQty.Border.BottomColor = System.Drawing.Color.Black
        Me.txtQty.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQty.Border.LeftColor = System.Drawing.Color.Black
        Me.txtQty.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQty.Border.RightColor = System.Drawing.Color.Black
        Me.txtQty.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQty.Border.TopColor = System.Drawing.Color.Black
        Me.txtQty.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQty.DataField = "total_quantity"
        Me.txtQty.Height = 0.1875!
        Me.txtQty.Left = 1.0!
        Me.txtQty.Name = "txtQty"
        Me.txtQty.OutputFormat = resources.GetString("txtQty.OutputFormat")
        Me.txtQty.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtQty.Text = "txtQty"
        Me.txtQty.Top = 0.1875!
        Me.txtQty.Width = 0.25!
        '
        'txtPrice
        '
        Me.txtPrice.Border.BottomColor = System.Drawing.Color.Black
        Me.txtPrice.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPrice.Border.LeftColor = System.Drawing.Color.Black
        Me.txtPrice.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPrice.Border.RightColor = System.Drawing.Color.Black
        Me.txtPrice.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPrice.Border.TopColor = System.Drawing.Color.Black
        Me.txtPrice.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPrice.DataField = "unit_price_quoted"
        Me.txtPrice.Height = 0.1875!
        Me.txtPrice.Left = 1.1875!
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.OutputFormat = resources.GetString("txtPrice.OutputFormat")
        Me.txtPrice.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtPrice.Text = "txtPrice"
        Me.txtPrice.Top = 0.1875!
        Me.txtPrice.Width = 0.625!
        '
        'txtAmount
        '
        Me.txtAmount.Border.BottomColor = System.Drawing.Color.Black
        Me.txtAmount.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmount.Border.LeftColor = System.Drawing.Color.Black
        Me.txtAmount.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmount.Border.RightColor = System.Drawing.Color.Black
        Me.txtAmount.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmount.Border.TopColor = System.Drawing.Color.Black
        Me.txtAmount.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmount.DataField = "total"
        Me.txtAmount.Height = 0.1875!
        Me.txtAmount.Left = 1.8125!
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.OutputFormat = resources.GetString("txtAmount.OutputFormat")
        Me.txtAmount.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtAmount.Text = "txtAmount"
        Me.txtAmount.Top = 0.1875!
        Me.txtAmount.Width = 0.625!
        '
        'txtDesc
        '
        Me.txtDesc.Border.BottomColor = System.Drawing.Color.Black
        Me.txtDesc.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDesc.Border.LeftColor = System.Drawing.Color.Black
        Me.txtDesc.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDesc.Border.RightColor = System.Drawing.Color.Black
        Me.txtDesc.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDesc.Border.TopColor = System.Drawing.Color.Black
        Me.txtDesc.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDesc.DataField = "name"
        Me.txtDesc.Height = 0.1875!
        Me.txtDesc.Left = 0.0!
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.txtDesc.Text = "txtDesc"
        Me.txtDesc.Top = 0.0!
        Me.txtDesc.Width = 2.4375!
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0.0!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'ReportHeader1
        '
        Me.ReportHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.srptHeader})
        Me.ReportHeader1.Height = 0.25!
        Me.ReportHeader1.Name = "ReportHeader1"
        '
        'srptHeader
        '
        Me.srptHeader.Border.BottomColor = System.Drawing.Color.Black
        Me.srptHeader.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srptHeader.Border.LeftColor = System.Drawing.Color.Black
        Me.srptHeader.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srptHeader.Border.RightColor = System.Drawing.Color.Black
        Me.srptHeader.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srptHeader.Border.TopColor = System.Drawing.Color.Black
        Me.srptHeader.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srptHeader.CloseBorder = False
        Me.srptHeader.Height = 0.25!
        Me.srptHeader.Left = 0.0!
        Me.srptHeader.Name = "srptHeader"
        Me.srptHeader.Report = Nothing
        Me.srptHeader.ReportName = "SubReport1"
        Me.srptHeader.Top = 0.0!
        Me.srptHeader.Width = 2.625!
        '
        'ReportFooter1
        '
        Me.ReportFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtTotalQty, Me.txtTotal, Me.Line4, Me.TextBox21, Me.TextBox22, Me.txtNetTotal, Me.Line5, Me.txtPosMsg1, Me.txtPosMsg2, Me.Line3, Me.txtPosMsg3, Me.txtPosMsg4, Me.TextBox2, Me.txtTax, Me.txtDeposit, Me.TextBox6})
        Me.ReportFooter1.Height = 1.864583!
        Me.ReportFooter1.Name = "ReportFooter1"
        '
        'txtTotalQty
        '
        Me.txtTotalQty.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTotalQty.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalQty.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTotalQty.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalQty.Border.RightColor = System.Drawing.Color.Black
        Me.txtTotalQty.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalQty.Border.TopColor = System.Drawing.Color.Black
        Me.txtTotalQty.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalQty.Height = 0.1875!
        Me.txtTotalQty.Left = 1.0!
        Me.txtTotalQty.Name = "txtTotalQty"
        Me.txtTotalQty.OutputFormat = resources.GetString("txtTotalQty.OutputFormat")
        Me.txtTotalQty.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtTotalQty.Text = "txtTotalQty"
        Me.txtTotalQty.Top = 0.0625!
        Me.txtTotalQty.Width = 0.25!
        '
        'txtTotal
        '
        Me.txtTotal.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTotal.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotal.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTotal.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotal.Border.RightColor = System.Drawing.Color.Black
        Me.txtTotal.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotal.Border.TopColor = System.Drawing.Color.Black
        Me.txtTotal.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotal.Height = 0.1875!
        Me.txtTotal.Left = 1.625!
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.OutputFormat = resources.GetString("txtTotal.OutputFormat")
        Me.txtTotal.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtTotal.Text = "txtSubTotal"
        Me.txtTotal.Top = 0.0625!
        Me.txtTotal.Width = 0.8125!
        '
        'Line4
        '
        Me.Line4.Border.BottomColor = System.Drawing.Color.Black
        Me.Line4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line4.Border.LeftColor = System.Drawing.Color.Black
        Me.Line4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line4.Border.RightColor = System.Drawing.Color.Black
        Me.Line4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line4.Border.TopColor = System.Drawing.Color.Black
        Me.Line4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line4.Height = 0.0!
        Me.Line4.Left = 0.0!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.6875!
        Me.Line4.Width = 2.4375!
        Me.Line4.X1 = 0.0!
        Me.Line4.X2 = 2.4375!
        Me.Line4.Y1 = 0.6875!
        Me.Line4.Y2 = 0.6875!
        '
        'TextBox21
        '
        Me.TextBox21.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox21.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox21.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox21.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox21.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox21.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox21.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox21.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox21.Height = 0.1875!
        Me.TextBox21.Left = 0.0!
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.TextBox21.Text = "TOTAL:"
        Me.TextBox21.Top = 0.0625!
        Me.TextBox21.Width = 0.8125!
        '
        'TextBox22
        '
        Me.TextBox22.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox22.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox22.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox22.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox22.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox22.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox22.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox22.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox22.Height = 0.188!
        Me.TextBox22.Left = 0.0!
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.TextBox22.Text = "NET TOTAL:"
        Me.TextBox22.Top = 0.75!
        Me.TextBox22.Width = 0.75!
        '
        'txtNetTotal
        '
        Me.txtNetTotal.Border.BottomColor = System.Drawing.Color.Black
        Me.txtNetTotal.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNetTotal.Border.LeftColor = System.Drawing.Color.Black
        Me.txtNetTotal.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNetTotal.Border.RightColor = System.Drawing.Color.Black
        Me.txtNetTotal.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNetTotal.Border.TopColor = System.Drawing.Color.Black
        Me.txtNetTotal.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNetTotal.Height = 0.1875!
        Me.txtNetTotal.Left = 1.625!
        Me.txtNetTotal.Name = "txtNetTotal"
        Me.txtNetTotal.OutputFormat = resources.GetString("txtNetTotal.OutputFormat")
        Me.txtNetTotal.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtNetTotal.Text = "txtNetTotal"
        Me.txtNetTotal.Top = 0.75!
        Me.txtNetTotal.Width = 0.8125!
        '
        'Line5
        '
        Me.Line5.Border.BottomColor = System.Drawing.Color.Black
        Me.Line5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line5.Border.LeftColor = System.Drawing.Color.Black
        Me.Line5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line5.Border.RightColor = System.Drawing.Color.Black
        Me.Line5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line5.Border.TopColor = System.Drawing.Color.Black
        Me.Line5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line5.Height = 0.0!
        Me.Line5.Left = 0.0!
        Me.Line5.LineWeight = 1.0!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 1.0!
        Me.Line5.Width = 2.4375!
        Me.Line5.X1 = 0.0!
        Me.Line5.X2 = 2.4375!
        Me.Line5.Y1 = 1.0!
        Me.Line5.Y2 = 1.0!
        '
        'txtPosMsg1
        '
        Me.txtPosMsg1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtPosMsg1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPosMsg1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtPosMsg1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPosMsg1.Border.RightColor = System.Drawing.Color.Black
        Me.txtPosMsg1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPosMsg1.Border.TopColor = System.Drawing.Color.Black
        Me.txtPosMsg1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPosMsg1.Height = 0.1875!
        Me.txtPosMsg1.Left = 0.0!
        Me.txtPosMsg1.Name = "txtPosMsg1"
        Me.txtPosMsg1.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; "
        Me.txtPosMsg1.Text = "txtPosMsg1"
        Me.txtPosMsg1.Top = 1.0625!
        Me.txtPosMsg1.Width = 2.4375!
        '
        'txtPosMsg2
        '
        Me.txtPosMsg2.Border.BottomColor = System.Drawing.Color.Black
        Me.txtPosMsg2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPosMsg2.Border.LeftColor = System.Drawing.Color.Black
        Me.txtPosMsg2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPosMsg2.Border.RightColor = System.Drawing.Color.Black
        Me.txtPosMsg2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPosMsg2.Border.TopColor = System.Drawing.Color.Black
        Me.txtPosMsg2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPosMsg2.Height = 0.1875!
        Me.txtPosMsg2.Left = 0.0!
        Me.txtPosMsg2.Name = "txtPosMsg2"
        Me.txtPosMsg2.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; "
        Me.txtPosMsg2.Tag = " "
        Me.txtPosMsg2.Text = "txtPosMsg2"
        Me.txtPosMsg2.Top = 1.25!
        Me.txtPosMsg2.Width = 2.4375!
        '
        'Line3
        '
        Me.Line3.Border.BottomColor = System.Drawing.Color.Black
        Me.Line3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line3.Border.LeftColor = System.Drawing.Color.Black
        Me.Line3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line3.Border.RightColor = System.Drawing.Color.Black
        Me.Line3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line3.Border.TopColor = System.Drawing.Color.Black
        Me.Line3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line3.Height = 0.0!
        Me.Line3.Left = 0.0!
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.0!
        Me.Line3.Width = 2.4375!
        Me.Line3.X1 = 0.0!
        Me.Line3.X2 = 2.4375!
        Me.Line3.Y1 = 0.0!
        Me.Line3.Y2 = 0.0!
        '
        'txtPosMsg3
        '
        Me.txtPosMsg3.Border.BottomColor = System.Drawing.Color.Black
        Me.txtPosMsg3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPosMsg3.Border.LeftColor = System.Drawing.Color.Black
        Me.txtPosMsg3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPosMsg3.Border.RightColor = System.Drawing.Color.Black
        Me.txtPosMsg3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPosMsg3.Border.TopColor = System.Drawing.Color.Black
        Me.txtPosMsg3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPosMsg3.Height = 0.1875!
        Me.txtPosMsg3.Left = 0.0!
        Me.txtPosMsg3.Name = "txtPosMsg3"
        Me.txtPosMsg3.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; "
        Me.txtPosMsg3.Tag = " "
        Me.txtPosMsg3.Text = "txtPosMsg3"
        Me.txtPosMsg3.Top = 1.4375!
        Me.txtPosMsg3.Width = 2.4375!
        '
        'txtPosMsg4
        '
        Me.txtPosMsg4.Border.BottomColor = System.Drawing.Color.Black
        Me.txtPosMsg4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPosMsg4.Border.LeftColor = System.Drawing.Color.Black
        Me.txtPosMsg4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPosMsg4.Border.RightColor = System.Drawing.Color.Black
        Me.txtPosMsg4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPosMsg4.Border.TopColor = System.Drawing.Color.Black
        Me.txtPosMsg4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPosMsg4.Height = 0.1875!
        Me.txtPosMsg4.Left = 0.0!
        Me.txtPosMsg4.Name = "txtPosMsg4"
        Me.txtPosMsg4.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; "
        Me.txtPosMsg4.Tag = " "
        Me.txtPosMsg4.Text = "txtPosMsg4"
        Me.txtPosMsg4.Top = 1.625!
        Me.txtPosMsg4.Width = 2.4375!
        '
        'TextBox2
        '
        Me.TextBox2.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Height = 0.1875!
        Me.TextBox2.Left = 0.0!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.TextBox2.Text = "TAX:"
        Me.TextBox2.Top = 0.25!
        Me.TextBox2.Width = 0.75!
        '
        'txtTax
        '
        Me.txtTax.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTax.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTax.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTax.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTax.Border.RightColor = System.Drawing.Color.Black
        Me.txtTax.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTax.Border.TopColor = System.Drawing.Color.Black
        Me.txtTax.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTax.Height = 0.1875!
        Me.txtTax.Left = 1.625!
        Me.txtTax.Name = "txtTax"
        Me.txtTax.OutputFormat = resources.GetString("txtTax.OutputFormat")
        Me.txtTax.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtTax.Text = "txtTax"
        Me.txtTax.Top = 0.25!
        Me.txtTax.Width = 0.8125!
        '
        'txtDeposit
        '
        Me.txtDeposit.Border.BottomColor = System.Drawing.Color.Black
        Me.txtDeposit.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDeposit.Border.LeftColor = System.Drawing.Color.Black
        Me.txtDeposit.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDeposit.Border.RightColor = System.Drawing.Color.Black
        Me.txtDeposit.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDeposit.Border.TopColor = System.Drawing.Color.Black
        Me.txtDeposit.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDeposit.Height = 0.1875!
        Me.txtDeposit.Left = 1.625!
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.OutputFormat = resources.GetString("txtDeposit.OutputFormat")
        Me.txtDeposit.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtDeposit.Text = "txtDeposit"
        Me.txtDeposit.Top = 0.4375!
        Me.txtDeposit.Width = 0.8125!
        '
        'TextBox6
        '
        Me.TextBox6.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox6.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox6.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox6.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox6.Height = 0.1875!
        Me.TextBox6.Left = 0.0!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.TextBox6.Text = "DEPOSIT:"
        Me.TextBox6.Top = 0.4375!
        Me.TextBox6.Width = 0.75!
        '
        'rptJobsheet
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 2.47!
        Me.Sections.Add(Me.ReportHeader1)
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.PageFooter1)
        Me.Sections.Add(Me.ReportFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.txtReportName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReceiptId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNetTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPosMsg1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPosMsg2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPosMsg3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPosMsg4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeposit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents ReportHeader1 As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents ReportFooter1 As DataDynamics.ActiveReports.ReportFooter
    Friend WithEvents txtTotalQty As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTotal As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line4 As DataDynamics.ActiveReports.Line
    Friend WithEvents TextBox21 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox22 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtNetTotal As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line5 As DataDynamics.ActiveReports.Line
    Friend WithEvents txtPosMsg1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPosMsg2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line3 As DataDynamics.ActiveReports.Line
    Friend WithEvents txtPosMsg3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPosMsg4 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTax As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDeposit As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCode As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtQty As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPrice As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAmount As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDesc As DataDynamics.ActiveReports.TextBox
    Friend WithEvents srptHeader As DataDynamics.ActiveReports.SubReport
    Friend WithEvents txtReportName As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTime As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtUser As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox11 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtReceiptId As DataDynamics.ActiveReports.TextBox
End Class
