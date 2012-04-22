<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptReceipt_risis
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptReceipt_risis))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.txtReportName = New DataDynamics.ActiveReports.TextBox
        Me.txtTime = New DataDynamics.ActiveReports.TextBox
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.txtReceiptId = New DataDynamics.ActiveReports.TextBox
        Me.txtSales = New DataDynamics.ActiveReports.TextBox
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.txtQty = New DataDynamics.ActiveReports.TextBox
        Me.txtPrice = New DataDynamics.ActiveReports.TextBox
        Me.txtAmount = New DataDynamics.ActiveReports.TextBox
        Me.txtDesc = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.ReportHeader1 = New DataDynamics.ActiveReports.ReportHeader
        Me.srptHeader = New DataDynamics.ActiveReports.SubReport
        Me.ReportFooter1 = New DataDynamics.ActiveReports.ReportFooter
        Me.TextBox22 = New DataDynamics.ActiveReports.TextBox
        Me.txtNetTotal = New DataDynamics.ActiveReports.TextBox
        Me.txtPosMsg1 = New DataDynamics.ActiveReports.TextBox
        Me.txtPosMsg2 = New DataDynamics.ActiveReports.TextBox
        Me.Line3 = New DataDynamics.ActiveReports.Line
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
        Me.txtTax = New DataDynamics.ActiveReports.TextBox
        Me.txtPay1 = New DataDynamics.ActiveReports.TextBox
        Me.txtTotalQty = New DataDynamics.ActiveReports.TextBox
        Me.txtPay2 = New DataDynamics.ActiveReports.TextBox
        Me.txtCashier = New DataDynamics.ActiveReports.TextBox
        Me.txtPos = New DataDynamics.ActiveReports.TextBox
        Me.txtPay1Amt = New DataDynamics.ActiveReports.TextBox
        Me.txtPay2Amt = New DataDynamics.ActiveReports.TextBox
        CType(Me.txtReportName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReceiptId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNetTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPosMsg1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPosMsg2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPay1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPay2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCashier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPay1Amt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPay2Amt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtReportName, Me.txtTime, Me.TextBox1, Me.TextBox3, Me.Line1, Me.txtReceiptId})
        Me.PageHeader1.Height = 0.5729167!
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
        Me.txtReportName.Style = "ddo-char-set: 0; text-align: center; font-size: 10pt; font-family: Arial; "
        Me.txtReportName.Text = "txtReportName"
        Me.txtReportName.Top = 0.1875!
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
        Me.txtTime.Left = 0.0!
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Style = "ddo-char-set: 0; text-align: left; font-size: 10pt; "
        Me.txtTime.Text = "txtTime"
        Me.txtTime.Top = 0.0!
        Me.txtTime.Width = 1.5625!
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
        Me.TextBox1.Style = "ddo-char-set: 0; text-align: left; font-size: 10pt; font-family: Arial; "
        Me.TextBox1.Text = "Description"
        Me.TextBox1.Top = 0.375!
        Me.TextBox1.Width = 1.0!
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
        Me.TextBox3.Style = "ddo-char-set: 0; text-align: right; font-size: 10pt; font-family: Arial; "
        Me.TextBox3.Text = "Amount"
        Me.TextBox3.Top = 0.375!
        Me.TextBox3.Width = 0.625!
        '
        'Line1
        '
        Me.Line1.Border.BottomColor = System.Drawing.Color.Black
        Me.Line1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Border.LeftColor = System.Drawing.Color.Black
        Me.Line1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Border.RightColor = System.Drawing.Color.Black
        Me.Line1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Border.TopColor = System.Drawing.Color.Black
        Me.Line1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Height = 0.0!
        Me.Line1.Left = 0.0!
        Me.Line1.LineStyle = DataDynamics.ActiveReports.LineStyle.Dash
        Me.Line1.LineWeight = 2.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.5625!
        Me.Line1.Width = 2.4375!
        Me.Line1.X1 = 0.0!
        Me.Line1.X2 = 2.4375!
        Me.Line1.Y1 = 0.5625!
        Me.Line1.Y2 = 0.5625!
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
        Me.txtReceiptId.Left = 1.5625!
        Me.txtReceiptId.Name = "txtReceiptId"
        Me.txtReceiptId.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 12pt; font-famil" & _
            "y: Arial; "
        Me.txtReceiptId.Text = "txtReceiptId"
        Me.txtReceiptId.Top = 0.0!
        Me.txtReceiptId.Width = 0.875!
        '
        'txtSales
        '
        Me.txtSales.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSales.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSales.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSales.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSales.Border.RightColor = System.Drawing.Color.Black
        Me.txtSales.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSales.Border.TopColor = System.Drawing.Color.Black
        Me.txtSales.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSales.Height = 0.1875!
        Me.txtSales.Left = 0.0!
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Style = "ddo-char-set: 0; text-align: left; font-size: 10pt; font-family: Arial; "
        Me.txtSales.Text = "txtSales"
        Me.txtSales.Top = 1.3125!
        Me.txtSales.Width = 2.4375!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtQty, Me.txtPrice, Me.txtAmount, Me.txtDesc})
        Me.Detail1.Height = 0.3755!
        Me.Detail1.Name = "Detail1"
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
        Me.txtQty.Height = 0.1875!
        Me.txtQty.Left = 0.375!
        Me.txtQty.Name = "txtQty"
        Me.txtQty.OutputFormat = resources.GetString("txtQty.OutputFormat")
        Me.txtQty.Style = "ddo-char-set: 0; text-align: right; font-size: 10pt; "
        Me.txtQty.Text = "txtQty"
        Me.txtQty.Top = 0.1875!
        Me.txtQty.Width = 0.4375!
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
        Me.txtPrice.Height = 0.1875!
        Me.txtPrice.Left = 1.0!
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.OutputFormat = resources.GetString("txtPrice.OutputFormat")
        Me.txtPrice.Style = "ddo-char-set: 0; text-align: right; font-size: 10pt; "
        Me.txtPrice.Text = "txtPrice"
        Me.txtPrice.Top = 0.1875!
        Me.txtPrice.Width = 0.6875!
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
        Me.txtAmount.Height = 0.1875!
        Me.txtAmount.Left = 1.75!
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.OutputFormat = resources.GetString("txtAmount.OutputFormat")
        Me.txtAmount.Style = "ddo-char-set: 0; text-align: right; font-size: 10pt; "
        Me.txtAmount.Text = "txtAmount"
        Me.txtAmount.Top = 0.1875!
        Me.txtAmount.Width = 0.6875!
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
        Me.txtDesc.Height = 0.1875!
        Me.txtDesc.Left = 0.0!
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Style = "ddo-char-set: 0; text-align: left; font-size: 10pt; "
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
        Me.srptHeader.Width = 2.47!
        '
        'ReportFooter1
        '
        Me.ReportFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox22, Me.txtNetTotal, Me.txtPosMsg1, Me.txtPosMsg2, Me.Line3, Me.TextBox2, Me.txtTax, Me.txtPay1, Me.txtTotalQty, Me.txtPay2, Me.txtSales, Me.txtCashier, Me.txtPos, Me.txtPay1Amt, Me.txtPay2Amt})
        Me.ReportFooter1.Height = 1.739583!
        Me.ReportFooter1.Name = "ReportFooter1"
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
        Me.TextBox22.Height = 0.1875!
        Me.TextBox22.Left = 0.4375!
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 12pt; "
        Me.TextBox22.Text = "TOTAL"
        Me.TextBox22.Top = 0.125!
        Me.TextBox22.Width = 0.625!
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
        Me.txtNetTotal.Left = 1.3125!
        Me.txtNetTotal.Name = "txtNetTotal"
        Me.txtNetTotal.OutputFormat = resources.GetString("txtNetTotal.OutputFormat")
        Me.txtNetTotal.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 12pt; "
        Me.txtNetTotal.Text = "0.00"
        Me.txtNetTotal.Top = 0.125!
        Me.txtNetTotal.Width = 1.125!
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
        Me.txtPosMsg1.Style = "ddo-char-set: 0; text-align: center; font-size: 8pt; "
        Me.txtPosMsg1.Text = "txtPosMsg1"
        Me.txtPosMsg1.Top = 0.9375!
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
        Me.txtPosMsg2.Style = "ddo-char-set: 0; text-align: center; font-size: 8pt; "
        Me.txtPosMsg2.Tag = " "
        Me.txtPosMsg2.Text = "txtPosMsg2"
        Me.txtPosMsg2.Top = 1.125!
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
        Me.Line3.LineStyle = DataDynamics.ActiveReports.LineStyle.Dash
        Me.Line3.LineWeight = 2.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.0625!
        Me.Line3.Width = 2.4375!
        Me.Line3.X1 = 0.0!
        Me.Line3.X2 = 2.4375!
        Me.Line3.Y1 = 0.0625!
        Me.Line3.Y2 = 0.0625!
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
        Me.TextBox2.Left = 0.4375!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.TextBox2.Text = "INCLUSIVE OF GST @ 7%"
        Me.TextBox2.Top = 0.75!
        Me.TextBox2.Width = 1.5!
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
        Me.txtTax.Left = 1.9375!
        Me.txtTax.Name = "txtTax"
        Me.txtTax.OutputFormat = resources.GetString("txtTax.OutputFormat")
        Me.txtTax.Style = "ddo-char-set: 0; text-align: right; font-size: 10pt; "
        Me.txtTax.Text = "9,999"
        Me.txtTax.Top = 0.75!
        Me.txtTax.Width = 0.5!
        '
        'txtPay1
        '
        Me.txtPay1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtPay1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPay1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtPay1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPay1.Border.RightColor = System.Drawing.Color.Black
        Me.txtPay1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPay1.Border.TopColor = System.Drawing.Color.Black
        Me.txtPay1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPay1.Height = 0.1875!
        Me.txtPay1.Left = 0.4375!
        Me.txtPay1.Name = "txtPay1"
        Me.txtPay1.Style = "ddo-char-set: 0; text-align: left; font-size: 10pt; "
        Me.txtPay1.Text = "CASH"
        Me.txtPay1.Top = 0.375!
        Me.txtPay1.Width = 2.0!
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
        Me.txtTotalQty.Left = 0.0625!
        Me.txtTotalQty.Name = "txtTotalQty"
        Me.txtTotalQty.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 12pt; "
        Me.txtTotalQty.Text = Nothing
        Me.txtTotalQty.Top = 0.125!
        Me.txtTotalQty.Width = 0.25!
        '
        'txtPay2
        '
        Me.txtPay2.Border.BottomColor = System.Drawing.Color.Black
        Me.txtPay2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPay2.Border.LeftColor = System.Drawing.Color.Black
        Me.txtPay2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPay2.Border.RightColor = System.Drawing.Color.Black
        Me.txtPay2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPay2.Border.TopColor = System.Drawing.Color.Black
        Me.txtPay2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPay2.Height = 0.1875!
        Me.txtPay2.Left = 0.4375!
        Me.txtPay2.Name = "txtPay2"
        Me.txtPay2.Style = "ddo-char-set: 0; text-align: left; font-size: 10pt; "
        Me.txtPay2.Text = "CHANGE"
        Me.txtPay2.Top = 0.5625!
        Me.txtPay2.Width = 1.0!
        '
        'txtCashier
        '
        Me.txtCashier.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCashier.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCashier.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCashier.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCashier.Border.RightColor = System.Drawing.Color.Black
        Me.txtCashier.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCashier.Border.TopColor = System.Drawing.Color.Black
        Me.txtCashier.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCashier.Height = 0.1875!
        Me.txtCashier.Left = 0.0!
        Me.txtCashier.Name = "txtCashier"
        Me.txtCashier.Style = "ddo-char-set: 0; text-align: left; font-size: 10pt; font-family: Arial; "
        Me.txtCashier.Text = "txtCashier"
        Me.txtCashier.Top = 1.5!
        Me.txtCashier.Width = 2.125!
        '
        'txtPos
        '
        Me.txtPos.Border.BottomColor = System.Drawing.Color.Black
        Me.txtPos.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPos.Border.LeftColor = System.Drawing.Color.Black
        Me.txtPos.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPos.Border.RightColor = System.Drawing.Color.Black
        Me.txtPos.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPos.Border.TopColor = System.Drawing.Color.Black
        Me.txtPos.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPos.Height = 0.1875!
        Me.txtPos.Left = 1.3125!
        Me.txtPos.Name = "txtPos"
        Me.txtPos.Style = "ddo-char-set: 0; text-align: left; font-size: 10pt; font-family: Arial; "
        Me.txtPos.Text = "txtPos"
        Me.txtPos.Top = 1.5!
        Me.txtPos.Width = 1.125!
        '
        'txtPay1Amt
        '
        Me.txtPay1Amt.Border.BottomColor = System.Drawing.Color.Black
        Me.txtPay1Amt.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPay1Amt.Border.LeftColor = System.Drawing.Color.Black
        Me.txtPay1Amt.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPay1Amt.Border.RightColor = System.Drawing.Color.Black
        Me.txtPay1Amt.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPay1Amt.Border.TopColor = System.Drawing.Color.Black
        Me.txtPay1Amt.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPay1Amt.Height = 0.1875!
        Me.txtPay1Amt.Left = 1.625!
        Me.txtPay1Amt.Name = "txtPay1Amt"
        Me.txtPay1Amt.OutputFormat = resources.GetString("txtPay1Amt.OutputFormat")
        Me.txtPay1Amt.Style = "ddo-char-set: 0; text-align: right; font-weight: normal; font-size: 10pt; "
        Me.txtPay1Amt.Text = "0"
        Me.txtPay1Amt.Top = 0.375!
        Me.txtPay1Amt.Width = 0.8125!
        '
        'txtPay2Amt
        '
        Me.txtPay2Amt.Border.BottomColor = System.Drawing.Color.Black
        Me.txtPay2Amt.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPay2Amt.Border.LeftColor = System.Drawing.Color.Black
        Me.txtPay2Amt.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPay2Amt.Border.RightColor = System.Drawing.Color.Black
        Me.txtPay2Amt.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPay2Amt.Border.TopColor = System.Drawing.Color.Black
        Me.txtPay2Amt.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPay2Amt.Height = 0.1875!
        Me.txtPay2Amt.Left = 1.625!
        Me.txtPay2Amt.Name = "txtPay2Amt"
        Me.txtPay2Amt.OutputFormat = resources.GetString("txtPay2Amt.OutputFormat")
        Me.txtPay2Amt.Style = "ddo-char-set: 0; text-align: right; font-weight: normal; font-size: 10pt; "
        Me.txtPay2Amt.Text = "0"
        Me.txtPay2Amt.Top = 0.5625!
        Me.txtPay2Amt.Width = 0.8125!
        '
        'rptReceipt_risis
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
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReceiptId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNetTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPosMsg1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPosMsg2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPay1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPay2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCashier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPay1Amt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPay2Amt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents ReportHeader1 As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents ReportFooter1 As DataDynamics.ActiveReports.ReportFooter
    Friend WithEvents txtQty As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPrice As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAmount As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDesc As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox22 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtNetTotal As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPosMsg1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPosMsg2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line3 As DataDynamics.ActiveReports.Line
    Friend WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTax As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtReportName As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTime As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
    Friend WithEvents txtReceiptId As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtSales As DataDynamics.ActiveReports.TextBox
    Friend WithEvents srptHeader As DataDynamics.ActiveReports.SubReport
    Friend WithEvents txtPay1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTotalQty As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPay2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCashier As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPos As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPay1Amt As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPay2Amt As DataDynamics.ActiveReports.TextBox
End Class
