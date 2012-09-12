<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptDailySalesReport1
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptDailySalesReport))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.txtTotalOther = New DataDynamics.ActiveReports.TextBox
        Me.txtReportName = New DataDynamics.ActiveReports.TextBox
        Me.TextBox17 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox16 = New DataDynamics.ActiveReports.TextBox
        Me.txtTotalCashBill = New DataDynamics.ActiveReports.TextBox
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox12 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
        Me.txtUser = New DataDynamics.ActiveReports.TextBox
        Me.TextBox31 = New DataDynamics.ActiveReports.TextBox
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.TextBox19 = New DataDynamics.ActiveReports.TextBox
        Me.txtTotalChequeQty = New DataDynamics.ActiveReports.TextBox
        Me.txtTotalCheque = New DataDynamics.ActiveReports.TextBox
        Me.txtVisaAmt = New DataDynamics.ActiveReports.TextBox
        Me.txtTotalCashQty = New DataDynamics.ActiveReports.TextBox
        Me.txtTotalOtherQty = New DataDynamics.ActiveReports.TextBox
        Me.TextBox25 = New DataDynamics.ActiveReports.TextBox
        Me.txtTotal1 = New DataDynamics.ActiveReports.TextBox
        Me.txtTotalVoucherQty = New DataDynamics.ActiveReports.TextBox
        Me.txtTotalCash = New DataDynamics.ActiveReports.TextBox
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox28 = New DataDynamics.ActiveReports.TextBox
        Me.txtTotalVoucher = New DataDynamics.ActiveReports.TextBox
        Me.txtVisaQty = New DataDynamics.ActiveReports.TextBox
        Me.txtTime = New DataDynamics.ActiveReports.TextBox
        Me.txtDate = New DataDynamics.ActiveReports.TextBox
        Me.TextBox14 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox20 = New DataDynamics.ActiveReports.TextBox
        Me.txtMasterAmt = New DataDynamics.ActiveReports.TextBox
        Me.txtMasterQty = New DataDynamics.ActiveReports.TextBox
        Me.TextBox26 = New DataDynamics.ActiveReports.TextBox
        Me.txtAmexAmt = New DataDynamics.ActiveReports.TextBox
        Me.txtAmexQty = New DataDynamics.ActiveReports.TextBox
        Me.TextBox30 = New DataDynamics.ActiveReports.TextBox
        Me.txtChinaAmt = New DataDynamics.ActiveReports.TextBox
        Me.txtChinaQty = New DataDynamics.ActiveReports.TextBox
        Me.TextBox34 = New DataDynamics.ActiveReports.TextBox
        Me.txtJcbAmt = New DataDynamics.ActiveReports.TextBox
        Me.txtJcbQty = New DataDynamics.ActiveReports.TextBox
        Me.TextBox37 = New DataDynamics.ActiveReports.TextBox
        Me.txtNetsAmt = New DataDynamics.ActiveReports.TextBox
        Me.txtNetsQty = New DataDynamics.ActiveReports.TextBox
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.txtCategoryName = New DataDynamics.ActiveReports.TextBox
        Me.txtPercentage = New DataDynamics.ActiveReports.TextBox
        Me.txtTotalPrice = New DataDynamics.ActiveReports.TextBox
        Me.txtQty = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.ReportHeader1 = New DataDynamics.ActiveReports.ReportHeader
        Me.srptHeader = New DataDynamics.ActiveReports.SubReport
        Me.ReportFooter1 = New DataDynamics.ActiveReports.ReportFooter
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.txtGrand = New DataDynamics.ActiveReports.TextBox
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox8 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox10 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox11 = New DataDynamics.ActiveReports.TextBox
        Me.txtQtySales = New DataDynamics.ActiveReports.TextBox
        Me.txtAmtSales = New DataDynamics.ActiveReports.TextBox
        Me.TextBox15 = New DataDynamics.ActiveReports.TextBox
        Me.txtQtyCashSale = New DataDynamics.ActiveReports.TextBox
        Me.txtAmtCashSales = New DataDynamics.ActiveReports.TextBox
        Me.TextBox18 = New DataDynamics.ActiveReports.TextBox
        Me.txtQtyCashIn = New DataDynamics.ActiveReports.TextBox
        Me.txtAmtCashIn = New DataDynamics.ActiveReports.TextBox
        Me.TextBox21 = New DataDynamics.ActiveReports.TextBox
        Me.txtQtyCashOut = New DataDynamics.ActiveReports.TextBox
        Me.txtAmtCashOut = New DataDynamics.ActiveReports.TextBox
        Me.TextBox24 = New DataDynamics.ActiveReports.TextBox
        Me.txtTotalDrawer = New DataDynamics.ActiveReports.TextBox
        Me.Line4 = New DataDynamics.ActiveReports.Line
        Me.txtTotalQty = New DataDynamics.ActiveReports.TextBox
        Me.SubReport1 = New DataDynamics.ActiveReports.SubReport
        CType(Me.txtTotalOther, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReportName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalCashBill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalChequeQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalCheque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVisaAmt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalCashQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalOtherQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalVoucherQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalCash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalVoucher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVisaQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMasterAmt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMasterQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmexAmt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmexQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChinaAmt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChinaQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJcbAmt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJcbQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNetsAmt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNetsQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCategoryName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPercentage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGrand, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtySales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmtSales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtyCashSale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmtCashSales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtyCashIn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmtCashIn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtyCashOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmtCashOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalDrawer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtTotalOther, Me.txtReportName, Me.TextBox17, Me.TextBox16, Me.txtTotalCashBill, Me.TextBox3, Me.TextBox12, Me.TextBox1, Me.txtUser, Me.TextBox31, Me.Line2, Me.TextBox19, Me.txtTotalChequeQty, Me.txtTotalCheque, Me.txtVisaAmt, Me.txtTotalCashQty, Me.txtTotalOtherQty, Me.TextBox25, Me.txtTotal1, Me.txtTotalVoucherQty, Me.txtTotalCash, Me.TextBox2, Me.TextBox5, Me.TextBox28, Me.txtTotalVoucher, Me.txtVisaQty, Me.txtTime, Me.txtDate, Me.TextBox14, Me.TextBox20, Me.txtMasterAmt, Me.txtMasterQty, Me.TextBox26, Me.txtAmexAmt, Me.txtAmexQty, Me.TextBox30, Me.txtChinaAmt, Me.txtChinaQty, Me.TextBox34, Me.txtJcbAmt, Me.txtJcbQty, Me.TextBox37, Me.txtNetsAmt, Me.txtNetsQty, Me.SubReport1})
        Me.PageHeader1.Height = 4.270833!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'txtTotalOther
        '
        Me.txtTotalOther.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTotalOther.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalOther.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTotalOther.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalOther.Border.RightColor = System.Drawing.Color.Black
        Me.txtTotalOther.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalOther.Border.TopColor = System.Drawing.Color.Black
        Me.txtTotalOther.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalOther.Height = 0.1875!
        Me.txtTotalOther.Left = 1.75!
        Me.txtTotalOther.Name = "txtTotalOther"
        Me.txtTotalOther.OutputFormat = resources.GetString("txtTotalOther.OutputFormat")
        Me.txtTotalOther.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtTotalOther.Text = "0.00"
        Me.txtTotalOther.Top = 2.875!
        Me.txtTotalOther.Width = 0.6875!
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
        'TextBox17
        '
        Me.TextBox17.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox17.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox17.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox17.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox17.Height = 0.1875!
        Me.TextBox17.Left = 1.625!
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Style = "text-decoration: underline; ddo-char-set: 0; text-align: right; font-size: 8.25pt" & _
            "; "
        Me.TextBox17.Text = "Qty"
        Me.TextBox17.Top = 4.0625!
        Me.TextBox17.Width = 0.3125!
        '
        'TextBox16
        '
        Me.TextBox16.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox16.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox16.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox16.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox16.Height = 0.1875!
        Me.TextBox16.Left = 0.0!
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Style = "text-decoration: underline; ddo-char-set: 0; text-align: left; font-size: 8.25pt;" & _
            " "
        Me.TextBox16.Text = "Department"
        Me.TextBox16.Top = 4.0625!
        Me.TextBox16.Width = 1.125!
        '
        'txtTotalCashBill
        '
        Me.txtTotalCashBill.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTotalCashBill.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalCashBill.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTotalCashBill.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalCashBill.Border.RightColor = System.Drawing.Color.Black
        Me.txtTotalCashBill.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalCashBill.Border.TopColor = System.Drawing.Color.Black
        Me.txtTotalCashBill.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalCashBill.Height = 0.1875!
        Me.txtTotalCashBill.Left = 1.125!
        Me.txtTotalCashBill.Name = "txtTotalCashBill"
        Me.txtTotalCashBill.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtTotalCashBill.Text = "0"
        Me.txtTotalCashBill.Top = 3.1875!
        Me.txtTotalCashBill.Width = 0.5625!
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
        Me.TextBox3.Left = 0.0!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.TextBox3.Text = "TOTAL"
        Me.TextBox3.Top = 3.1875!
        Me.TextBox3.Width = 0.4375!
        '
        'TextBox12
        '
        Me.TextBox12.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox12.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox12.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox12.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox12.Height = 0.1875!
        Me.TextBox12.Left = 0.0!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.TextBox12.Text = "VISA"
        Me.TextBox12.Top = 1.375!
        Me.TextBox12.Width = 1.0!
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
        Me.TextBox1.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 8.25pt; "
        Me.TextBox1.Text = "COLLECTION"
        Me.TextBox1.Top = 1.0!
        Me.TextBox1.Width = 1.6875!
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
        Me.txtUser.Top = 0.6875!
        Me.txtUser.Width = 2.4375!
        '
        'TextBox31
        '
        Me.TextBox31.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox31.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox31.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox31.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox31.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox31.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox31.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox31.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox31.Height = 0.1875!
        Me.TextBox31.Left = 0.0!
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.TextBox31.Text = "OTHER"
        Me.TextBox31.Top = 2.875!
        Me.TextBox31.Width = 1.0!
        '
        'Line2
        '
        Me.Line2.Border.BottomColor = System.Drawing.Color.Black
        Me.Line2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Border.LeftColor = System.Drawing.Color.Black
        Me.Line2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Border.RightColor = System.Drawing.Color.Black
        Me.Line2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Border.TopColor = System.Drawing.Color.Black
        Me.Line2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Height = 0.0!
        Me.Line2.Left = 0.0!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 3.125!
        Me.Line2.Width = 2.5!
        Me.Line2.X1 = 0.0!
        Me.Line2.X2 = 2.5!
        Me.Line2.Y1 = 3.125!
        Me.Line2.Y2 = 3.125!
        '
        'TextBox19
        '
        Me.TextBox19.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox19.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox19.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox19.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox19.Height = 0.1875!
        Me.TextBox19.Left = 1.9375!
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Style = "text-decoration: underline; ddo-char-set: 0; text-align: right; font-size: 8.25pt" & _
            "; "
        Me.TextBox19.Text = "Amt"
        Me.TextBox19.Top = 4.0625!
        Me.TextBox19.Width = 0.5!
        '
        'txtTotalChequeQty
        '
        Me.txtTotalChequeQty.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTotalChequeQty.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalChequeQty.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTotalChequeQty.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalChequeQty.Border.RightColor = System.Drawing.Color.Black
        Me.txtTotalChequeQty.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalChequeQty.Border.TopColor = System.Drawing.Color.Black
        Me.txtTotalChequeQty.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalChequeQty.Height = 0.1875!
        Me.txtTotalChequeQty.Left = 1.125!
        Me.txtTotalChequeQty.Name = "txtTotalChequeQty"
        Me.txtTotalChequeQty.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtTotalChequeQty.Text = "0"
        Me.txtTotalChequeQty.Top = 2.5!
        Me.txtTotalChequeQty.Width = 0.5625!
        '
        'txtTotalCheque
        '
        Me.txtTotalCheque.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTotalCheque.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalCheque.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTotalCheque.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalCheque.Border.RightColor = System.Drawing.Color.Black
        Me.txtTotalCheque.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalCheque.Border.TopColor = System.Drawing.Color.Black
        Me.txtTotalCheque.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalCheque.Height = 0.1875!
        Me.txtTotalCheque.Left = 1.75!
        Me.txtTotalCheque.Name = "txtTotalCheque"
        Me.txtTotalCheque.OutputFormat = resources.GetString("txtTotalCheque.OutputFormat")
        Me.txtTotalCheque.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtTotalCheque.Text = "0.00"
        Me.txtTotalCheque.Top = 2.5!
        Me.txtTotalCheque.Width = 0.6875!
        '
        'txtVisaAmt
        '
        Me.txtVisaAmt.Border.BottomColor = System.Drawing.Color.Black
        Me.txtVisaAmt.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVisaAmt.Border.LeftColor = System.Drawing.Color.Black
        Me.txtVisaAmt.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVisaAmt.Border.RightColor = System.Drawing.Color.Black
        Me.txtVisaAmt.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVisaAmt.Border.TopColor = System.Drawing.Color.Black
        Me.txtVisaAmt.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVisaAmt.Height = 0.1875!
        Me.txtVisaAmt.Left = 1.75!
        Me.txtVisaAmt.Name = "txtVisaAmt"
        Me.txtVisaAmt.OutputFormat = resources.GetString("txtVisaAmt.OutputFormat")
        Me.txtVisaAmt.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtVisaAmt.Text = "0.00"
        Me.txtVisaAmt.Top = 1.375!
        Me.txtVisaAmt.Width = 0.6875!
        '
        'txtTotalCashQty
        '
        Me.txtTotalCashQty.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTotalCashQty.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalCashQty.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTotalCashQty.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalCashQty.Border.RightColor = System.Drawing.Color.Black
        Me.txtTotalCashQty.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalCashQty.Border.TopColor = System.Drawing.Color.Black
        Me.txtTotalCashQty.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalCashQty.Height = 0.1875!
        Me.txtTotalCashQty.Left = 1.125!
        Me.txtTotalCashQty.Name = "txtTotalCashQty"
        Me.txtTotalCashQty.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtTotalCashQty.Text = "0"
        Me.txtTotalCashQty.Top = 1.1875!
        Me.txtTotalCashQty.Width = 0.5625!
        '
        'txtTotalOtherQty
        '
        Me.txtTotalOtherQty.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTotalOtherQty.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalOtherQty.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTotalOtherQty.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalOtherQty.Border.RightColor = System.Drawing.Color.Black
        Me.txtTotalOtherQty.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalOtherQty.Border.TopColor = System.Drawing.Color.Black
        Me.txtTotalOtherQty.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalOtherQty.Height = 0.1875!
        Me.txtTotalOtherQty.Left = 1.125!
        Me.txtTotalOtherQty.Name = "txtTotalOtherQty"
        Me.txtTotalOtherQty.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtTotalOtherQty.Text = "0"
        Me.txtTotalOtherQty.Top = 2.875!
        Me.txtTotalOtherQty.Width = 0.5625!
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
        Me.TextBox25.Height = 0.1875!
        Me.TextBox25.Left = 0.0!
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.TextBox25.Text = "CHEQUE"
        Me.TextBox25.Top = 2.5!
        Me.TextBox25.Width = 1.0!
        '
        'txtTotal1
        '
        Me.txtTotal1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTotal1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotal1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTotal1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotal1.Border.RightColor = System.Drawing.Color.Black
        Me.txtTotal1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotal1.Border.TopColor = System.Drawing.Color.Black
        Me.txtTotal1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotal1.Height = 0.1875!
        Me.txtTotal1.Left = 1.75!
        Me.txtTotal1.Name = "txtTotal1"
        Me.txtTotal1.OutputFormat = resources.GetString("txtTotal1.OutputFormat")
        Me.txtTotal1.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtTotal1.Text = "0.00"
        Me.txtTotal1.Top = 3.1875!
        Me.txtTotal1.Width = 0.6875!
        '
        'txtTotalVoucherQty
        '
        Me.txtTotalVoucherQty.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTotalVoucherQty.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalVoucherQty.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTotalVoucherQty.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalVoucherQty.Border.RightColor = System.Drawing.Color.Black
        Me.txtTotalVoucherQty.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalVoucherQty.Border.TopColor = System.Drawing.Color.Black
        Me.txtTotalVoucherQty.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalVoucherQty.Height = 0.1875!
        Me.txtTotalVoucherQty.Left = 1.125!
        Me.txtTotalVoucherQty.Name = "txtTotalVoucherQty"
        Me.txtTotalVoucherQty.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtTotalVoucherQty.Text = "0"
        Me.txtTotalVoucherQty.Top = 2.6875!
        Me.txtTotalVoucherQty.Width = 0.5625!
        '
        'txtTotalCash
        '
        Me.txtTotalCash.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTotalCash.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalCash.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTotalCash.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalCash.Border.RightColor = System.Drawing.Color.Black
        Me.txtTotalCash.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalCash.Border.TopColor = System.Drawing.Color.Black
        Me.txtTotalCash.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalCash.Height = 0.1875!
        Me.txtTotalCash.Left = 1.75!
        Me.txtTotalCash.Name = "txtTotalCash"
        Me.txtTotalCash.OutputFormat = resources.GetString("txtTotalCash.OutputFormat")
        Me.txtTotalCash.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtTotalCash.Text = "0.00"
        Me.txtTotalCash.Top = 1.1875!
        Me.txtTotalCash.Width = 0.6875!
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
        Me.TextBox2.Text = "CASH"
        Me.TextBox2.Top = 1.1875!
        Me.TextBox2.Width = 1.0!
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
        Me.TextBox5.Left = 0.0!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "text-decoration: none; ddo-char-set: 0; text-align: left; font-weight: bold; font" & _
            "-size: 8.25pt; "
        Me.TextBox5.Text = "NET SALES SUMMARY"
        Me.TextBox5.Top = 3.8125!
        Me.TextBox5.Width = 2.25!
        '
        'TextBox28
        '
        Me.TextBox28.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox28.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox28.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox28.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox28.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox28.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox28.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox28.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox28.Height = 0.1875!
        Me.TextBox28.Left = 0.0!
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.TextBox28.Text = "VOUCHER"
        Me.TextBox28.Top = 2.6875!
        Me.TextBox28.Width = 1.0!
        '
        'txtTotalVoucher
        '
        Me.txtTotalVoucher.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTotalVoucher.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalVoucher.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTotalVoucher.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalVoucher.Border.RightColor = System.Drawing.Color.Black
        Me.txtTotalVoucher.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalVoucher.Border.TopColor = System.Drawing.Color.Black
        Me.txtTotalVoucher.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalVoucher.Height = 0.1875!
        Me.txtTotalVoucher.Left = 1.75!
        Me.txtTotalVoucher.Name = "txtTotalVoucher"
        Me.txtTotalVoucher.OutputFormat = resources.GetString("txtTotalVoucher.OutputFormat")
        Me.txtTotalVoucher.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtTotalVoucher.Text = "0.00"
        Me.txtTotalVoucher.Top = 2.6875!
        Me.txtTotalVoucher.Width = 0.6875!
        '
        'txtVisaQty
        '
        Me.txtVisaQty.Border.BottomColor = System.Drawing.Color.Black
        Me.txtVisaQty.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVisaQty.Border.LeftColor = System.Drawing.Color.Black
        Me.txtVisaQty.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVisaQty.Border.RightColor = System.Drawing.Color.Black
        Me.txtVisaQty.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVisaQty.Border.TopColor = System.Drawing.Color.Black
        Me.txtVisaQty.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVisaQty.Height = 0.1875!
        Me.txtVisaQty.Left = 1.125!
        Me.txtVisaQty.Name = "txtVisaQty"
        Me.txtVisaQty.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtVisaQty.Text = "0"
        Me.txtVisaQty.Top = 1.375!
        Me.txtVisaQty.Width = 0.5625!
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
        Me.txtTime.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.txtTime.Text = "txtTime"
        Me.txtTime.Top = 0.5!
        Me.txtTime.Width = 2.4375!
        '
        'txtDate
        '
        Me.txtDate.Border.BottomColor = System.Drawing.Color.Black
        Me.txtDate.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDate.Border.LeftColor = System.Drawing.Color.Black
        Me.txtDate.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDate.Border.RightColor = System.Drawing.Color.Black
        Me.txtDate.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDate.Border.TopColor = System.Drawing.Color.Black
        Me.txtDate.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDate.Height = 0.1875!
        Me.txtDate.Left = 0.0!
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; "
        Me.txtDate.Text = "txtDate"
        Me.txtDate.Top = 0.1875!
        Me.txtDate.Width = 2.4375!
        '
        'TextBox14
        '
        Me.TextBox14.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox14.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox14.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox14.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox14.Height = 0.1875!
        Me.TextBox14.Left = 1.0!
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.OutputFormat = resources.GetString("TextBox14.OutputFormat")
        Me.TextBox14.Style = "text-decoration: underline; ddo-char-set: 0; text-align: right; font-size: 8.25pt" & _
            "; "
        Me.TextBox14.Text = "Sales %"
        Me.TextBox14.Top = 4.0625!
        Me.TextBox14.Width = 0.625!
        '
        'TextBox20
        '
        Me.TextBox20.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox20.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox20.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox20.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox20.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox20.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox20.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox20.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox20.Height = 0.1875!
        Me.TextBox20.Left = 0.0!
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.TextBox20.Text = "MASTER"
        Me.TextBox20.Top = 1.5625!
        Me.TextBox20.Width = 1.0!
        '
        'txtMasterAmt
        '
        Me.txtMasterAmt.Border.BottomColor = System.Drawing.Color.Black
        Me.txtMasterAmt.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMasterAmt.Border.LeftColor = System.Drawing.Color.Black
        Me.txtMasterAmt.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMasterAmt.Border.RightColor = System.Drawing.Color.Black
        Me.txtMasterAmt.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMasterAmt.Border.TopColor = System.Drawing.Color.Black
        Me.txtMasterAmt.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMasterAmt.Height = 0.1875!
        Me.txtMasterAmt.Left = 1.75!
        Me.txtMasterAmt.Name = "txtMasterAmt"
        Me.txtMasterAmt.OutputFormat = resources.GetString("txtMasterAmt.OutputFormat")
        Me.txtMasterAmt.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtMasterAmt.Text = "0.00"
        Me.txtMasterAmt.Top = 1.5625!
        Me.txtMasterAmt.Width = 0.6875!
        '
        'txtMasterQty
        '
        Me.txtMasterQty.Border.BottomColor = System.Drawing.Color.Black
        Me.txtMasterQty.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMasterQty.Border.LeftColor = System.Drawing.Color.Black
        Me.txtMasterQty.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMasterQty.Border.RightColor = System.Drawing.Color.Black
        Me.txtMasterQty.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMasterQty.Border.TopColor = System.Drawing.Color.Black
        Me.txtMasterQty.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMasterQty.Height = 0.1875!
        Me.txtMasterQty.Left = 1.125!
        Me.txtMasterQty.Name = "txtMasterQty"
        Me.txtMasterQty.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtMasterQty.Text = "0"
        Me.txtMasterQty.Top = 1.5625!
        Me.txtMasterQty.Width = 0.5625!
        '
        'TextBox26
        '
        Me.TextBox26.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox26.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox26.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox26.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox26.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox26.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox26.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox26.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox26.Height = 0.1875!
        Me.TextBox26.Left = 0.0!
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.TextBox26.Text = "AMEX"
        Me.TextBox26.Top = 1.75!
        Me.TextBox26.Width = 1.0!
        '
        'txtAmexAmt
        '
        Me.txtAmexAmt.Border.BottomColor = System.Drawing.Color.Black
        Me.txtAmexAmt.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmexAmt.Border.LeftColor = System.Drawing.Color.Black
        Me.txtAmexAmt.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmexAmt.Border.RightColor = System.Drawing.Color.Black
        Me.txtAmexAmt.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmexAmt.Border.TopColor = System.Drawing.Color.Black
        Me.txtAmexAmt.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmexAmt.Height = 0.1875!
        Me.txtAmexAmt.Left = 1.75!
        Me.txtAmexAmt.Name = "txtAmexAmt"
        Me.txtAmexAmt.OutputFormat = resources.GetString("txtAmexAmt.OutputFormat")
        Me.txtAmexAmt.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtAmexAmt.Text = "0.00"
        Me.txtAmexAmt.Top = 1.75!
        Me.txtAmexAmt.Width = 0.6875!
        '
        'txtAmexQty
        '
        Me.txtAmexQty.Border.BottomColor = System.Drawing.Color.Black
        Me.txtAmexQty.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmexQty.Border.LeftColor = System.Drawing.Color.Black
        Me.txtAmexQty.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmexQty.Border.RightColor = System.Drawing.Color.Black
        Me.txtAmexQty.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmexQty.Border.TopColor = System.Drawing.Color.Black
        Me.txtAmexQty.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmexQty.Height = 0.1875!
        Me.txtAmexQty.Left = 1.125!
        Me.txtAmexQty.Name = "txtAmexQty"
        Me.txtAmexQty.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtAmexQty.Text = "0"
        Me.txtAmexQty.Top = 1.75!
        Me.txtAmexQty.Width = 0.5625!
        '
        'TextBox30
        '
        Me.TextBox30.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox30.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox30.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox30.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox30.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox30.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox30.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox30.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox30.Height = 0.1875!
        Me.TextBox30.Left = 0.0!
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.TextBox30.Text = "CHINA UNION PAY"
        Me.TextBox30.Top = 1.9375!
        Me.TextBox30.Width = 1.125!
        '
        'txtChinaAmt
        '
        Me.txtChinaAmt.Border.BottomColor = System.Drawing.Color.Black
        Me.txtChinaAmt.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtChinaAmt.Border.LeftColor = System.Drawing.Color.Black
        Me.txtChinaAmt.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtChinaAmt.Border.RightColor = System.Drawing.Color.Black
        Me.txtChinaAmt.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtChinaAmt.Border.TopColor = System.Drawing.Color.Black
        Me.txtChinaAmt.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtChinaAmt.Height = 0.1875!
        Me.txtChinaAmt.Left = 1.75!
        Me.txtChinaAmt.Name = "txtChinaAmt"
        Me.txtChinaAmt.OutputFormat = resources.GetString("txtChinaAmt.OutputFormat")
        Me.txtChinaAmt.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtChinaAmt.Text = "0.00"
        Me.txtChinaAmt.Top = 1.9375!
        Me.txtChinaAmt.Width = 0.6875!
        '
        'txtChinaQty
        '
        Me.txtChinaQty.Border.BottomColor = System.Drawing.Color.Black
        Me.txtChinaQty.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtChinaQty.Border.LeftColor = System.Drawing.Color.Black
        Me.txtChinaQty.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtChinaQty.Border.RightColor = System.Drawing.Color.Black
        Me.txtChinaQty.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtChinaQty.Border.TopColor = System.Drawing.Color.Black
        Me.txtChinaQty.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtChinaQty.Height = 0.1875!
        Me.txtChinaQty.Left = 1.125!
        Me.txtChinaQty.Name = "txtChinaQty"
        Me.txtChinaQty.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtChinaQty.Text = "0"
        Me.txtChinaQty.Top = 1.9375!
        Me.txtChinaQty.Width = 0.5625!
        '
        'TextBox34
        '
        Me.TextBox34.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox34.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox34.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox34.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox34.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox34.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox34.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox34.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox34.Height = 0.1875!
        Me.TextBox34.Left = 0.0!
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.TextBox34.Text = "JCB CARD"
        Me.TextBox34.Top = 2.125!
        Me.TextBox34.Width = 1.0!
        '
        'txtJcbAmt
        '
        Me.txtJcbAmt.Border.BottomColor = System.Drawing.Color.Black
        Me.txtJcbAmt.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtJcbAmt.Border.LeftColor = System.Drawing.Color.Black
        Me.txtJcbAmt.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtJcbAmt.Border.RightColor = System.Drawing.Color.Black
        Me.txtJcbAmt.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtJcbAmt.Border.TopColor = System.Drawing.Color.Black
        Me.txtJcbAmt.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtJcbAmt.Height = 0.1875!
        Me.txtJcbAmt.Left = 1.75!
        Me.txtJcbAmt.Name = "txtJcbAmt"
        Me.txtJcbAmt.OutputFormat = resources.GetString("txtJcbAmt.OutputFormat")
        Me.txtJcbAmt.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtJcbAmt.Text = "0.00"
        Me.txtJcbAmt.Top = 2.125!
        Me.txtJcbAmt.Width = 0.6875!
        '
        'txtJcbQty
        '
        Me.txtJcbQty.Border.BottomColor = System.Drawing.Color.Black
        Me.txtJcbQty.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtJcbQty.Border.LeftColor = System.Drawing.Color.Black
        Me.txtJcbQty.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtJcbQty.Border.RightColor = System.Drawing.Color.Black
        Me.txtJcbQty.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtJcbQty.Border.TopColor = System.Drawing.Color.Black
        Me.txtJcbQty.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtJcbQty.Height = 0.1875!
        Me.txtJcbQty.Left = 1.125!
        Me.txtJcbQty.Name = "txtJcbQty"
        Me.txtJcbQty.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtJcbQty.Text = "0"
        Me.txtJcbQty.Top = 2.125!
        Me.txtJcbQty.Width = 0.5625!
        '
        'TextBox37
        '
        Me.TextBox37.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox37.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox37.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox37.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox37.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox37.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox37.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox37.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox37.Height = 0.1875!
        Me.TextBox37.Left = 0.0!
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.TextBox37.Text = "Nets"
        Me.TextBox37.Top = 2.3125!
        Me.TextBox37.Width = 1.0!
        '
        'txtNetsAmt
        '
        Me.txtNetsAmt.Border.BottomColor = System.Drawing.Color.Black
        Me.txtNetsAmt.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNetsAmt.Border.LeftColor = System.Drawing.Color.Black
        Me.txtNetsAmt.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNetsAmt.Border.RightColor = System.Drawing.Color.Black
        Me.txtNetsAmt.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNetsAmt.Border.TopColor = System.Drawing.Color.Black
        Me.txtNetsAmt.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNetsAmt.Height = 0.1875!
        Me.txtNetsAmt.Left = 1.75!
        Me.txtNetsAmt.Name = "txtNetsAmt"
        Me.txtNetsAmt.OutputFormat = resources.GetString("txtNetsAmt.OutputFormat")
        Me.txtNetsAmt.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtNetsAmt.Text = "0.00"
        Me.txtNetsAmt.Top = 2.3125!
        Me.txtNetsAmt.Width = 0.6875!
        '
        'txtNetsQty
        '
        Me.txtNetsQty.Border.BottomColor = System.Drawing.Color.Black
        Me.txtNetsQty.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNetsQty.Border.LeftColor = System.Drawing.Color.Black
        Me.txtNetsQty.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNetsQty.Border.RightColor = System.Drawing.Color.Black
        Me.txtNetsQty.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNetsQty.Border.TopColor = System.Drawing.Color.Black
        Me.txtNetsQty.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNetsQty.Height = 0.1875!
        Me.txtNetsQty.Left = 1.125!
        Me.txtNetsQty.Name = "txtNetsQty"
        Me.txtNetsQty.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtNetsQty.Text = "0"
        Me.txtNetsQty.Top = 2.3125!
        Me.txtNetsQty.Width = 0.5625!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtCategoryName, Me.txtPercentage, Me.txtTotalPrice, Me.txtQty})
        Me.Detail1.Height = 0.2083333!
        Me.Detail1.Name = "Detail1"
        '
        'txtCategoryName
        '
        Me.txtCategoryName.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCategoryName.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCategoryName.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCategoryName.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCategoryName.Border.RightColor = System.Drawing.Color.Black
        Me.txtCategoryName.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCategoryName.Border.TopColor = System.Drawing.Color.Black
        Me.txtCategoryName.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCategoryName.DataField = "name"
        Me.txtCategoryName.Height = 0.1875!
        Me.txtCategoryName.Left = 0.0!
        Me.txtCategoryName.Name = "txtCategoryName"
        Me.txtCategoryName.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.txtCategoryName.Text = Nothing
        Me.txtCategoryName.Top = 0.0!
        Me.txtCategoryName.Width = 1.125!
        '
        'txtPercentage
        '
        Me.txtPercentage.Border.BottomColor = System.Drawing.Color.Black
        Me.txtPercentage.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPercentage.Border.LeftColor = System.Drawing.Color.Black
        Me.txtPercentage.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPercentage.Border.RightColor = System.Drawing.Color.Black
        Me.txtPercentage.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPercentage.Border.TopColor = System.Drawing.Color.Black
        Me.txtPercentage.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPercentage.Height = 0.1875!
        Me.txtPercentage.Left = 1.125!
        Me.txtPercentage.Name = "txtPercentage"
        Me.txtPercentage.OutputFormat = resources.GetString("txtPercentage.OutputFormat")
        Me.txtPercentage.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtPercentage.Text = Nothing
        Me.txtPercentage.Top = 0.0!
        Me.txtPercentage.Width = 0.5!
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTotalPrice.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalPrice.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTotalPrice.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalPrice.Border.RightColor = System.Drawing.Color.Black
        Me.txtTotalPrice.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalPrice.Border.TopColor = System.Drawing.Color.Black
        Me.txtTotalPrice.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalPrice.DataField = "total_amt"
        Me.txtTotalPrice.Height = 0.1875!
        Me.txtTotalPrice.Left = 1.9375!
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.OutputFormat = resources.GetString("txtTotalPrice.OutputFormat")
        Me.txtTotalPrice.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtTotalPrice.Text = Nothing
        Me.txtTotalPrice.Top = 0.0!
        Me.txtTotalPrice.Width = 0.5!
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
        Me.txtQty.DataField = "total_qty"
        Me.txtQty.Height = 0.1875!
        Me.txtQty.Left = 1.625!
        Me.txtQty.Name = "txtQty"
        Me.txtQty.OutputFormat = resources.GetString("txtQty.OutputFormat")
        Me.txtQty.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtQty.Text = Nothing
        Me.txtQty.Top = 0.0!
        Me.txtQty.Width = 0.3125!
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
        Me.ReportFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Line1, Me.txtGrand, Me.TextBox6, Me.TextBox8, Me.TextBox9, Me.TextBox10, Me.TextBox11, Me.txtQtySales, Me.txtAmtSales, Me.TextBox15, Me.txtQtyCashSale, Me.txtAmtCashSales, Me.TextBox18, Me.txtQtyCashIn, Me.txtAmtCashIn, Me.TextBox21, Me.txtQtyCashOut, Me.txtAmtCashOut, Me.TextBox24, Me.txtTotalDrawer, Me.Line4, Me.txtTotalQty})
        Me.ReportFooter1.Height = 1.916667!
        Me.ReportFooter1.Name = "ReportFooter1"
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
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.0!
        Me.Line1.Width = 2.45!
        Me.Line1.X1 = 0.0!
        Me.Line1.X2 = 2.45!
        Me.Line1.Y1 = 0.0!
        Me.Line1.Y2 = 0.0!
        '
        'txtGrand
        '
        Me.txtGrand.Border.BottomColor = System.Drawing.Color.Black
        Me.txtGrand.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtGrand.Border.LeftColor = System.Drawing.Color.Black
        Me.txtGrand.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtGrand.Border.RightColor = System.Drawing.Color.Black
        Me.txtGrand.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtGrand.Border.TopColor = System.Drawing.Color.Black
        Me.txtGrand.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtGrand.DataField = "total_amt"
        Me.txtGrand.Height = 0.1875!
        Me.txtGrand.Left = 1.9375!
        Me.txtGrand.Name = "txtGrand"
        Me.txtGrand.OutputFormat = resources.GetString("txtGrand.OutputFormat")
        Me.txtGrand.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtGrand.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.txtGrand.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.txtGrand.Text = "0.00"
        Me.txtGrand.Top = 0.0625!
        Me.txtGrand.Width = 0.5!
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
        Me.TextBox6.Style = "text-decoration: none; ddo-char-set: 0; text-align: left; font-weight: bold; font" & _
            "-size: 8.25pt; "
        Me.TextBox6.Text = "SUMMARY"
        Me.TextBox6.Top = 0.3125!
        Me.TextBox6.Width = 1.5!
        '
        'TextBox8
        '
        Me.TextBox8.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox8.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox8.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox8.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox8.Height = 0.1875!
        Me.TextBox8.Left = 0.0!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Style = "text-decoration: underline; ddo-char-set: 0; text-align: left; font-size: 8.25pt;" & _
            " "
        Me.TextBox8.Text = "Details"
        Me.TextBox8.Top = 0.5625!
        Me.TextBox8.Width = 0.75!
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
        Me.TextBox9.Left = 1.25!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = "text-decoration: underline; ddo-char-set: 0; text-align: right; font-size: 8.25pt" & _
            "; "
        Me.TextBox9.Text = "Qty"
        Me.TextBox9.Top = 0.5625!
        Me.TextBox9.Width = 0.4375!
        '
        'TextBox10
        '
        Me.TextBox10.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox10.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox10.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox10.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox10.Height = 0.1875!
        Me.TextBox10.Left = 1.75!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Style = "text-decoration: underline; ddo-char-set: 0; text-align: right; font-size: 8.25pt" & _
            "; "
        Me.TextBox10.Text = "Amt"
        Me.TextBox10.Top = 0.5625!
        Me.TextBox10.Width = 0.6875!
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
        Me.TextBox11.Left = 0.0!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.TextBox11.Text = "GROSS SALES"
        Me.TextBox11.Top = 0.8125!
        Me.TextBox11.Width = 1.0625!
        '
        'txtQtySales
        '
        Me.txtQtySales.Border.BottomColor = System.Drawing.Color.Black
        Me.txtQtySales.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQtySales.Border.LeftColor = System.Drawing.Color.Black
        Me.txtQtySales.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQtySales.Border.RightColor = System.Drawing.Color.Black
        Me.txtQtySales.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQtySales.Border.TopColor = System.Drawing.Color.Black
        Me.txtQtySales.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQtySales.Height = 0.1875!
        Me.txtQtySales.Left = 1.25!
        Me.txtQtySales.Name = "txtQtySales"
        Me.txtQtySales.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtQtySales.Text = "0"
        Me.txtQtySales.Top = 0.8125!
        Me.txtQtySales.Width = 0.4375!
        '
        'txtAmtSales
        '
        Me.txtAmtSales.Border.BottomColor = System.Drawing.Color.Black
        Me.txtAmtSales.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmtSales.Border.LeftColor = System.Drawing.Color.Black
        Me.txtAmtSales.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmtSales.Border.RightColor = System.Drawing.Color.Black
        Me.txtAmtSales.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmtSales.Border.TopColor = System.Drawing.Color.Black
        Me.txtAmtSales.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmtSales.Height = 0.1875!
        Me.txtAmtSales.Left = 1.75!
        Me.txtAmtSales.Name = "txtAmtSales"
        Me.txtAmtSales.Style = "ddo-char-set: 0; text-decoration: none; text-align: right; font-size: 8.25pt; "
        Me.txtAmtSales.Text = "0.00"
        Me.txtAmtSales.Top = 0.8125!
        Me.txtAmtSales.Width = 0.6875!
        '
        'TextBox15
        '
        Me.TextBox15.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox15.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox15.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox15.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox15.Height = 0.1875!
        Me.TextBox15.Left = 0.0!
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.TextBox15.Text = "CASH SALES"
        Me.TextBox15.Top = 1.0!
        Me.TextBox15.Width = 1.0625!
        '
        'txtQtyCashSale
        '
        Me.txtQtyCashSale.Border.BottomColor = System.Drawing.Color.Black
        Me.txtQtyCashSale.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQtyCashSale.Border.LeftColor = System.Drawing.Color.Black
        Me.txtQtyCashSale.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQtyCashSale.Border.RightColor = System.Drawing.Color.Black
        Me.txtQtyCashSale.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQtyCashSale.Border.TopColor = System.Drawing.Color.Black
        Me.txtQtyCashSale.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQtyCashSale.Height = 0.1875!
        Me.txtQtyCashSale.Left = 1.25!
        Me.txtQtyCashSale.Name = "txtQtyCashSale"
        Me.txtQtyCashSale.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtQtyCashSale.Text = "0"
        Me.txtQtyCashSale.Top = 1.0!
        Me.txtQtyCashSale.Width = 0.4375!
        '
        'txtAmtCashSales
        '
        Me.txtAmtCashSales.Border.BottomColor = System.Drawing.Color.Black
        Me.txtAmtCashSales.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmtCashSales.Border.LeftColor = System.Drawing.Color.Black
        Me.txtAmtCashSales.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmtCashSales.Border.RightColor = System.Drawing.Color.Black
        Me.txtAmtCashSales.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmtCashSales.Border.TopColor = System.Drawing.Color.Black
        Me.txtAmtCashSales.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmtCashSales.Height = 0.1875!
        Me.txtAmtCashSales.Left = 1.75!
        Me.txtAmtCashSales.Name = "txtAmtCashSales"
        Me.txtAmtCashSales.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtAmtCashSales.Text = "0.00"
        Me.txtAmtCashSales.Top = 1.0!
        Me.txtAmtCashSales.Width = 0.6875!
        '
        'TextBox18
        '
        Me.TextBox18.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox18.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox18.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox18.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox18.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox18.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox18.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox18.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox18.Height = 0.1875!
        Me.TextBox18.Left = 0.0!
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.TextBox18.Text = "CASH IN"
        Me.TextBox18.Top = 1.1875!
        Me.TextBox18.Width = 1.0625!
        '
        'txtQtyCashIn
        '
        Me.txtQtyCashIn.Border.BottomColor = System.Drawing.Color.Black
        Me.txtQtyCashIn.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQtyCashIn.Border.LeftColor = System.Drawing.Color.Black
        Me.txtQtyCashIn.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQtyCashIn.Border.RightColor = System.Drawing.Color.Black
        Me.txtQtyCashIn.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQtyCashIn.Border.TopColor = System.Drawing.Color.Black
        Me.txtQtyCashIn.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQtyCashIn.Height = 0.1875!
        Me.txtQtyCashIn.Left = 1.25!
        Me.txtQtyCashIn.Name = "txtQtyCashIn"
        Me.txtQtyCashIn.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtQtyCashIn.Text = "0"
        Me.txtQtyCashIn.Top = 1.1875!
        Me.txtQtyCashIn.Width = 0.4375!
        '
        'txtAmtCashIn
        '
        Me.txtAmtCashIn.Border.BottomColor = System.Drawing.Color.Black
        Me.txtAmtCashIn.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmtCashIn.Border.LeftColor = System.Drawing.Color.Black
        Me.txtAmtCashIn.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmtCashIn.Border.RightColor = System.Drawing.Color.Black
        Me.txtAmtCashIn.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmtCashIn.Border.TopColor = System.Drawing.Color.Black
        Me.txtAmtCashIn.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmtCashIn.Height = 0.1875!
        Me.txtAmtCashIn.Left = 1.75!
        Me.txtAmtCashIn.Name = "txtAmtCashIn"
        Me.txtAmtCashIn.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtAmtCashIn.Text = "0.00"
        Me.txtAmtCashIn.Top = 1.1875!
        Me.txtAmtCashIn.Width = 0.6875!
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
        Me.TextBox21.Text = "CASH OUT"
        Me.TextBox21.Top = 1.375!
        Me.TextBox21.Width = 1.0625!
        '
        'txtQtyCashOut
        '
        Me.txtQtyCashOut.Border.BottomColor = System.Drawing.Color.Black
        Me.txtQtyCashOut.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQtyCashOut.Border.LeftColor = System.Drawing.Color.Black
        Me.txtQtyCashOut.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQtyCashOut.Border.RightColor = System.Drawing.Color.Black
        Me.txtQtyCashOut.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQtyCashOut.Border.TopColor = System.Drawing.Color.Black
        Me.txtQtyCashOut.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQtyCashOut.Height = 0.1875!
        Me.txtQtyCashOut.Left = 1.25!
        Me.txtQtyCashOut.Name = "txtQtyCashOut"
        Me.txtQtyCashOut.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtQtyCashOut.Text = "0"
        Me.txtQtyCashOut.Top = 1.375!
        Me.txtQtyCashOut.Width = 0.4375!
        '
        'txtAmtCashOut
        '
        Me.txtAmtCashOut.Border.BottomColor = System.Drawing.Color.Black
        Me.txtAmtCashOut.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmtCashOut.Border.LeftColor = System.Drawing.Color.Black
        Me.txtAmtCashOut.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmtCashOut.Border.RightColor = System.Drawing.Color.Black
        Me.txtAmtCashOut.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmtCashOut.Border.TopColor = System.Drawing.Color.Black
        Me.txtAmtCashOut.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmtCashOut.Height = 0.1875!
        Me.txtAmtCashOut.Left = 1.75!
        Me.txtAmtCashOut.Name = "txtAmtCashOut"
        Me.txtAmtCashOut.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtAmtCashOut.Text = "0.00"
        Me.txtAmtCashOut.Top = 1.375!
        Me.txtAmtCashOut.Width = 0.6875!
        '
        'TextBox24
        '
        Me.TextBox24.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox24.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox24.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox24.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox24.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox24.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox24.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox24.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox24.Height = 0.1875!
        Me.TextBox24.Left = 0.0!
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.TextBox24.Text = "TOTAL IN DRAWER"
        Me.TextBox24.Top = 1.6875!
        Me.TextBox24.Width = 1.75!
        '
        'txtTotalDrawer
        '
        Me.txtTotalDrawer.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTotalDrawer.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalDrawer.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTotalDrawer.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalDrawer.Border.RightColor = System.Drawing.Color.Black
        Me.txtTotalDrawer.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalDrawer.Border.TopColor = System.Drawing.Color.Black
        Me.txtTotalDrawer.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalDrawer.Height = 0.1875!
        Me.txtTotalDrawer.Left = 1.75!
        Me.txtTotalDrawer.Name = "txtTotalDrawer"
        Me.txtTotalDrawer.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtTotalDrawer.Text = "0.00"
        Me.txtTotalDrawer.Top = 1.6875!
        Me.txtTotalDrawer.Width = 0.6875!
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
        Me.Line4.Top = 1.625!
        Me.Line4.Width = 2.4375!
        Me.Line4.X1 = 0.0!
        Me.Line4.X2 = 2.4375!
        Me.Line4.Y1 = 1.625!
        Me.Line4.Y2 = 1.625!
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
        Me.txtTotalQty.DataField = "total_qty"
        Me.txtTotalQty.Height = 0.1875!
        Me.txtTotalQty.Left = 1.625!
        Me.txtTotalQty.Name = "txtTotalQty"
        Me.txtTotalQty.OutputFormat = resources.GetString("txtTotalQty.OutputFormat")
        Me.txtTotalQty.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtTotalQty.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.txtTotalQty.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.txtTotalQty.Text = "0"
        Me.txtTotalQty.Top = 0.0625!
        Me.txtTotalQty.Width = 0.3125!
        '
        'SubReport1
        '
        Me.SubReport1.Border.BottomColor = System.Drawing.Color.Black
        Me.SubReport1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.SubReport1.Border.LeftColor = System.Drawing.Color.Black
        Me.SubReport1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.SubReport1.Border.RightColor = System.Drawing.Color.Black
        Me.SubReport1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.SubReport1.Border.TopColor = System.Drawing.Color.Black
        Me.SubReport1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.SubReport1.CloseBorder = False
        Me.SubReport1.Height = 0.25!
        Me.SubReport1.Left = 0.0!
        Me.SubReport1.Name = "SubReport1"
        Me.SubReport1.Report = Nothing
        Me.SubReport1.ReportName = "SubReport1"
        Me.SubReport1.Top = 3.5!
        Me.SubReport1.Width = 2.4375!
        '
        'rptDailySalesReport
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
        CType(Me.txtTotalOther, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReportName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalCashBill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalChequeQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalCheque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVisaAmt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalCashQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalOtherQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalVoucherQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalCash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalVoucher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVisaQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMasterAmt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMasterQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmexAmt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmexQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChinaAmt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChinaQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJcbAmt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJcbQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNetsAmt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNetsQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCategoryName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPercentage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGrand, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtySales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmtSales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtyCashSale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmtCashSales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtyCashIn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmtCashIn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtyCashOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmtCashOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalDrawer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents ReportHeader1 As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents ReportFooter1 As DataDynamics.ActiveReports.ReportFooter
    Friend WithEvents txtCategoryName As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPercentage As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTotalPrice As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
    Friend WithEvents txtGrand As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox8 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox10 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox11 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtQtySales As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAmtSales As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox15 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtQtyCashSale As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAmtCashSales As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox18 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtQtyCashIn As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAmtCashIn As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox21 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtQtyCashOut As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAmtCashOut As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox24 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTotalDrawer As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line4 As DataDynamics.ActiveReports.Line
    Friend WithEvents txtQty As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTotalQty As DataDynamics.ActiveReports.TextBox
    Friend WithEvents srptHeader As DataDynamics.ActiveReports.SubReport
    Friend WithEvents txtTotalOther As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtReportName As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox17 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox16 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTotalCashBill As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox12 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtUser As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox31 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line2 As DataDynamics.ActiveReports.Line
    Friend WithEvents TextBox19 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTotalChequeQty As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTotalCheque As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtVisaAmt As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTotalCashQty As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTotalOtherQty As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox25 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTotal1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTotalVoucherQty As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTotalCash As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox28 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTotalVoucher As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtVisaQty As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTime As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDate As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox14 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox20 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtMasterAmt As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtMasterQty As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox26 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAmexAmt As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAmexQty As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox30 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtChinaAmt As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtChinaQty As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox34 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtJcbAmt As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtJcbQty As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox37 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtNetsAmt As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtNetsQty As DataDynamics.ActiveReports.TextBox
    Friend WithEvents SubReport1 As DataDynamics.ActiveReports.SubReport
End Class
