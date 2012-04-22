<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptReceipt_yms
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptReceipt_yms))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.txtReportName = New DataDynamics.ActiveReports.TextBox
        Me.txtTime = New DataDynamics.ActiveReports.TextBox
        Me.Line6 = New DataDynamics.ActiveReports.Line
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox11 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.txtReceiptId = New DataDynamics.ActiveReports.TextBox
        Me.txtSales = New DataDynamics.ActiveReports.TextBox
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox
        Me.txtCurrency = New DataDynamics.ActiveReports.TextBox
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.txtQty = New DataDynamics.ActiveReports.TextBox
        Me.txtPrice = New DataDynamics.ActiveReports.TextBox
        Me.txtAmount = New DataDynamics.ActiveReports.TextBox
        Me.txtDesc = New DataDynamics.ActiveReports.TextBox
        Me.txtDisc = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.ReportHeader1 = New DataDynamics.ActiveReports.ReportHeader
        Me.srptHeader = New DataDynamics.ActiveReports.SubReport
        Me.ReportFooter1 = New DataDynamics.ActiveReports.ReportFooter
        Me.TextBox25 = New DataDynamics.ActiveReports.TextBox
        Me.txtTendered = New DataDynamics.ActiveReports.TextBox
        Me.TextBox27 = New DataDynamics.ActiveReports.TextBox
        Me.txtChange = New DataDynamics.ActiveReports.TextBox
        Me.txtRemarks = New DataDynamics.ActiveReports.TextBox
        Me.TextBox22 = New DataDynamics.ActiveReports.TextBox
        Me.txtNetTotal = New DataDynamics.ActiveReports.TextBox
        Me.txtPosMsg1 = New DataDynamics.ActiveReports.TextBox
        Me.txtPosMsg2 = New DataDynamics.ActiveReports.TextBox
        Me.Line3 = New DataDynamics.ActiveReports.Line
        Me.txtPosMsg3 = New DataDynamics.ActiveReports.TextBox
        Me.txtPosMsg4 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
        Me.txtTax = New DataDynamics.ActiveReports.TextBox
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox
        Me.txtPayment = New DataDynamics.ActiveReports.TextBox
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox
        Me.txtNo = New DataDynamics.ActiveReports.TextBox
        Me.txtPaymentInfo = New DataDynamics.ActiveReports.TextBox
        CType(Me.txtReportName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReceiptId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTendered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNetTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPosMsg1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPosMsg2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPosMsg3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPosMsg4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPaymentInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtReportName, Me.txtTime, Me.Line6, Me.TextBox1, Me.TextBox11, Me.TextBox9, Me.TextBox3, Me.Line1, Me.txtReceiptId, Me.txtSales, Me.TextBox4, Me.TextBox5, Me.txtCurrency})
        Me.PageHeader1.Height = 1.395833!
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
        Me.txtReportName.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; font-family: Arial; "
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
        Me.txtTime.Left = 0.75!
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.txtTime.Text = "txtTime"
        Me.txtTime.Top = 0.375!
        Me.txtTime.Width = 1.625!
        '
        'Line6
        '
        Me.Line6.Border.BottomColor = System.Drawing.Color.Black
        Me.Line6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line6.Border.LeftColor = System.Drawing.Color.Black
        Me.Line6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line6.Border.RightColor = System.Drawing.Color.Black
        Me.Line6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line6.Border.TopColor = System.Drawing.Color.Black
        Me.Line6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line6.Height = 0.0!
        Me.Line6.Left = 0.0!
        Me.Line6.LineWeight = 3.0!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 0.875!
        Me.Line6.Width = 2.4375!
        Me.Line6.X1 = 0.0!
        Me.Line6.X2 = 2.4375!
        Me.Line6.Y1 = 0.875!
        Me.Line6.Y2 = 0.875!
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
        Me.TextBox1.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; font-family: Arial; "
        Me.TextBox1.Text = "Description"
        Me.TextBox1.Top = 0.9375!
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
        Me.TextBox11.Left = 0.25!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Arial; "
        Me.TextBox11.Text = "Qty"
        Me.TextBox11.Top = 1.125!
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
        Me.TextBox9.Height = 0.188!
        Me.TextBox9.Left = 0.625!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Arial; "
        Me.TextBox9.Text = "U. Price"
        Me.TextBox9.Top = 1.125!
        Me.TextBox9.Width = 0.625!
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
        Me.TextBox3.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Arial; "
        Me.TextBox3.Text = "Total Amt"
        Me.TextBox3.Top = 0.9375!
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
        Me.Line1.LineWeight = 3.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 1.375!
        Me.Line1.Width = 2.4375!
        Me.Line1.X1 = 0.0!
        Me.Line1.X2 = 2.4375!
        Me.Line1.Y1 = 1.375!
        Me.Line1.Y2 = 1.375!
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
        Me.txtReceiptId.Top = 0.375!
        Me.txtReceiptId.Width = 0.75!
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
        Me.txtSales.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; font-family: Arial; "
        Me.txtSales.Text = "txtSales"
        Me.txtSales.Top = 0.625!
        Me.txtSales.Width = 2.375!
        '
        'TextBox5
        '
        Me.TextBox5.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox5.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox5.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox5.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox5.Height = 0.1875!
        Me.TextBox5.Left = 1.25!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Arial; "
        Me.TextBox5.Text = "Disc."
        Me.TextBox5.Top = 1.125!
        Me.TextBox5.Width = 0.5625!
        '
        'txtCurrency
        '
        Me.txtCurrency.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCurrency.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCurrency.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCurrency.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCurrency.Border.RightColor = System.Drawing.Color.Black
        Me.txtCurrency.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCurrency.Border.TopColor = System.Drawing.Color.Black
        Me.txtCurrency.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCurrency.Height = 0.1875!
        Me.txtCurrency.Left = 1.8125!
        Me.txtCurrency.Name = "txtCurrency"
        Me.txtCurrency.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Arial; "
        Me.txtCurrency.Text = "SGD"
        Me.txtCurrency.Top = 1.125!
        Me.txtCurrency.Width = 0.625!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtNo, Me.txtQty, Me.txtPrice, Me.txtAmount, Me.txtDesc, Me.txtDisc})
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
        Me.txtQty.Left = 0.25!
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
        Me.txtPrice.Height = 0.1875!
        Me.txtPrice.Left = 0.625!
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
        Me.txtDesc.Height = 0.1875!
        Me.txtDesc.Left = 0.0!
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.txtDesc.Text = "txtDesc"
        Me.txtDesc.Top = 0.0!
        Me.txtDesc.Width = 2.4375!
        '
        'txtDisc
        '
        Me.txtDisc.Border.BottomColor = System.Drawing.Color.Black
        Me.txtDisc.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDisc.Border.LeftColor = System.Drawing.Color.Black
        Me.txtDisc.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDisc.Border.RightColor = System.Drawing.Color.Black
        Me.txtDisc.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDisc.Border.TopColor = System.Drawing.Color.Black
        Me.txtDisc.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDisc.Height = 0.1875!
        Me.txtDisc.Left = 1.25!
        Me.txtDisc.Name = "txtDisc"
        Me.txtDisc.OutputFormat = resources.GetString("txtDisc.OutputFormat")
        Me.txtDisc.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtDisc.Text = "txtDisc"
        Me.txtDisc.Top = 0.1875!
        Me.txtDisc.Width = 0.5625!
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
        Me.ReportFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox25, Me.txtTendered, Me.TextBox27, Me.txtChange, Me.txtRemarks, Me.TextBox22, Me.txtNetTotal, Me.txtPosMsg1, Me.txtPosMsg2, Me.Line3, Me.txtPosMsg3, Me.txtPosMsg4, Me.TextBox2, Me.txtTax, Me.TextBox6, Me.txtPayment, Me.txtPaymentInfo})
        Me.ReportFooter1.Height = 3.010417!
        Me.ReportFooter1.Name = "ReportFooter1"
        '
        'TextBox25
        '
        Me.TextBox25.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox25.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox25.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox25.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox25.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox25.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox25.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox25.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox25.Height = 0.188!
        Me.TextBox25.Left = 0.4375!
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.TextBox25.Text = "Amount Tendered"
        Me.TextBox25.Top = 0.4375!
        Me.TextBox25.Width = 1.0!
        '
        'txtTendered
        '
        Me.txtTendered.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTendered.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTendered.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTendered.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTendered.Border.RightColor = System.Drawing.Color.Black
        Me.txtTendered.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTendered.Border.TopColor = System.Drawing.Color.Black
        Me.txtTendered.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTendered.Height = 0.1875!
        Me.txtTendered.Left = 1.625!
        Me.txtTendered.Name = "txtTendered"
        Me.txtTendered.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtTendered.Text = "txtTendered"
        Me.txtTendered.Top = 0.625!
        Me.txtTendered.Width = 0.8125!
        '
        'TextBox27
        '
        Me.TextBox27.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox27.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox27.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox27.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox27.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox27.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox27.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox27.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox27.Height = 0.1875!
        Me.TextBox27.Left = 0.4375!
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.TextBox27.Text = "Change"
        Me.TextBox27.Top = 0.8125!
        Me.TextBox27.Width = 0.75!
        '
        'txtChange
        '
        Me.txtChange.Border.BottomColor = System.Drawing.Color.Black
        Me.txtChange.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtChange.Border.LeftColor = System.Drawing.Color.Black
        Me.txtChange.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtChange.Border.RightColor = System.Drawing.Color.Black
        Me.txtChange.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtChange.Border.TopColor = System.Drawing.Color.Black
        Me.txtChange.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtChange.Height = 0.1875!
        Me.txtChange.Left = 1.625!
        Me.txtChange.Name = "txtChange"
        Me.txtChange.OutputFormat = resources.GetString("txtChange.OutputFormat")
        Me.txtChange.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtChange.Text = "txtChange"
        Me.txtChange.Top = 0.8125!
        Me.txtChange.Width = 0.8125!
        '
        'txtRemarks
        '
        Me.txtRemarks.Border.BottomColor = System.Drawing.Color.Black
        Me.txtRemarks.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRemarks.Border.LeftColor = System.Drawing.Color.Black
        Me.txtRemarks.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRemarks.Border.RightColor = System.Drawing.Color.Black
        Me.txtRemarks.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRemarks.Border.TopColor = System.Drawing.Color.Black
        Me.txtRemarks.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRemarks.Height = 0.1875!
        Me.txtRemarks.Left = 0.0!
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.txtRemarks.Text = "Remarks:"
        Me.txtRemarks.Top = 1.8125!
        Me.txtRemarks.Width = 2.4375!
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
        Me.TextBox22.Left = 0.4375!
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 8.25pt; "
        Me.TextBox22.Text = "Net Total:"
        Me.TextBox22.Top = 0.125!
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
        Me.txtNetTotal.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; "
        Me.txtNetTotal.Text = "txtNetTotal"
        Me.txtNetTotal.Top = 0.125!
        Me.txtNetTotal.Width = 0.8125!
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
        Me.txtPosMsg1.Top = 2.125!
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
        Me.txtPosMsg2.Top = 2.3125!
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
        Me.Line3.Left = 1.25!
        Me.Line3.LineWeight = 4.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.0625!
        Me.Line3.Width = 1.1875!
        Me.Line3.X1 = 1.25!
        Me.Line3.X2 = 2.4375!
        Me.Line3.Y1 = 0.0625!
        Me.Line3.Y2 = 0.0625!
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
        Me.txtPosMsg3.Top = 2.5!
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
        Me.txtPosMsg4.Top = 2.6875!
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
        Me.TextBox2.Left = 0.4375!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.TextBox2.Text = "7.00% GST Inclusive"
        Me.TextBox2.Top = 1.125!
        Me.TextBox2.Width = 1.1875!
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
        Me.txtTax.Top = 1.125!
        Me.txtTax.Width = 0.8125!
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
        Me.TextBox6.Left = 0.4375!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.OutputFormat = resources.GetString("TextBox6.OutputFormat")
        Me.TextBox6.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.TextBox6.Text = "CASH"
        Me.TextBox6.Top = 0.625!
        Me.TextBox6.Width = 0.625!
        '
        'txtPayment
        '
        Me.txtPayment.Border.BottomColor = System.Drawing.Color.Black
        Me.txtPayment.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPayment.Border.LeftColor = System.Drawing.Color.Black
        Me.txtPayment.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPayment.Border.RightColor = System.Drawing.Color.Black
        Me.txtPayment.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPayment.Border.TopColor = System.Drawing.Color.Black
        Me.txtPayment.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPayment.Height = 0.1875!
        Me.txtPayment.Left = 0.0!
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.txtPayment.Text = "txtPayment"
        Me.txtPayment.Top = 1.4375!
        Me.txtPayment.Width = 2.4375!
        '
        'TextBox4
        '
        Me.TextBox4.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Height = 0.1875!
        Me.TextBox4.Left = 0.0!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; font-family: Arial; "
        Me.TextBox4.Text = "No"
        Me.TextBox4.Top = 1.125!
        Me.TextBox4.Width = 0.25!
        '
        'txtNo
        '
        Me.txtNo.Border.BottomColor = System.Drawing.Color.Black
        Me.txtNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNo.Border.LeftColor = System.Drawing.Color.Black
        Me.txtNo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNo.Border.RightColor = System.Drawing.Color.Black
        Me.txtNo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNo.Border.TopColor = System.Drawing.Color.Black
        Me.txtNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNo.DataField = "item_code"
        Me.txtNo.Height = 0.188!
        Me.txtNo.Left = 0.0!
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.txtNo.Text = "txtNo"
        Me.txtNo.Top = 0.1875!
        Me.txtNo.Width = 0.25!
        '
        'txtPaymentInfo
        '
        Me.txtPaymentInfo.Border.BottomColor = System.Drawing.Color.Black
        Me.txtPaymentInfo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPaymentInfo.Border.LeftColor = System.Drawing.Color.Black
        Me.txtPaymentInfo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPaymentInfo.Border.RightColor = System.Drawing.Color.Black
        Me.txtPaymentInfo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPaymentInfo.Border.TopColor = System.Drawing.Color.Black
        Me.txtPaymentInfo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPaymentInfo.Height = 0.1875!
        Me.txtPaymentInfo.Left = 0.0!
        Me.txtPaymentInfo.Name = "txtPaymentInfo"
        Me.txtPaymentInfo.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.txtPaymentInfo.Text = "txtPaymentInfo"
        Me.txtPaymentInfo.Top = 1.625!
        Me.txtPaymentInfo.Width = 2.4375!
        '
        'rptReceipt_yms
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 2.46875!
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
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReceiptId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTendered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNetTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPosMsg1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPosMsg2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPosMsg3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPosMsg4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPayment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPaymentInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents ReportHeader1 As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents ReportFooter1 As DataDynamics.ActiveReports.ReportFooter
    Friend WithEvents TextBox25 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTendered As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox27 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtChange As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtRemarks As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtQty As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPrice As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAmount As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDesc As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox22 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtNetTotal As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPosMsg1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPosMsg2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line3 As DataDynamics.ActiveReports.Line
    Friend WithEvents txtPosMsg3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPosMsg4 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTax As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDisc As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPayment As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtReportName As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTime As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line6 As DataDynamics.ActiveReports.Line
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox11 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
    Friend WithEvents txtReceiptId As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtSales As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCurrency As DataDynamics.ActiveReports.TextBox
    Friend WithEvents srptHeader As DataDynamics.ActiveReports.SubReport
    Friend WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtNo As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPaymentInfo As DataDynamics.ActiveReports.TextBox
End Class
