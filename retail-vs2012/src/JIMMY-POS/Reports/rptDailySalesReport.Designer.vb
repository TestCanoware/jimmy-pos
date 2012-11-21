<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptDailySalesReport
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
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.txtInvoiceNo = New DataDynamics.ActiveReports.TextBox
        Me.txtAmt = New DataDynamics.ActiveReports.TextBox
        Me.txtCardDetails = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.ReportHeader1 = New DataDynamics.ActiveReports.ReportHeader
        Me.srptHeader = New DataDynamics.ActiveReports.SubReport
        Me.txtReportName = New DataDynamics.ActiveReports.TextBox
        Me.txtUser = New DataDynamics.ActiveReports.TextBox
        Me.txtTime = New DataDynamics.ActiveReports.TextBox
        Me.txtDate = New DataDynamics.ActiveReports.TextBox
        Me.srptCollection = New DataDynamics.ActiveReports.SubReport
        Me.ReportFooter1 = New DataDynamics.ActiveReports.ReportFooter
        Me.TextBox24 = New DataDynamics.ActiveReports.TextBox
        Me.txtTotalDrawer = New DataDynamics.ActiveReports.TextBox
        Me.Line4 = New DataDynamics.ActiveReports.Line
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.Label2 = New DataDynamics.ActiveReports.Label
        Me.txtBranch = New DataDynamics.ActiveReports.TextBox
        Me.TextBox15 = New DataDynamics.ActiveReports.TextBox
        Me.txtAmtCashSales = New DataDynamics.ActiveReports.TextBox
        Me.txtAmtCashIn = New DataDynamics.ActiveReports.TextBox
        Me.TextBox18 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox21 = New DataDynamics.ActiveReports.TextBox
        Me.txtAmtCashOut = New DataDynamics.ActiveReports.TextBox
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.srptSummary = New DataDynamics.ActiveReports.SubReport
        CType(Me.txtInvoiceNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCardDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReportName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalDrawer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBranch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmtCashSales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmtCashIn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmtCashOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Height = 0.0!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtInvoiceNo, Me.txtAmt, Me.txtCardDetails})
        Me.Detail1.Height = 0.375!
        Me.Detail1.Name = "Detail1"
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Border.BottomColor = System.Drawing.Color.Black
        Me.txtInvoiceNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtInvoiceNo.Border.LeftColor = System.Drawing.Color.Black
        Me.txtInvoiceNo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtInvoiceNo.Border.RightColor = System.Drawing.Color.Black
        Me.txtInvoiceNo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtInvoiceNo.Border.TopColor = System.Drawing.Color.Black
        Me.txtInvoiceNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtInvoiceNo.Height = 0.1875!
        Me.txtInvoiceNo.Left = 0.0!
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Style = "ddo-char-set: 0; font-size: 10pt; "
        Me.txtInvoiceNo.Text = "txtReceiptId"
        Me.txtInvoiceNo.Top = 0.0!
        Me.txtInvoiceNo.Width = 0.875!
        '
        'txtAmt
        '
        Me.txtAmt.Border.BottomColor = System.Drawing.Color.Black
        Me.txtAmt.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmt.Border.LeftColor = System.Drawing.Color.Black
        Me.txtAmt.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmt.Border.RightColor = System.Drawing.Color.Black
        Me.txtAmt.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmt.Border.TopColor = System.Drawing.Color.Black
        Me.txtAmt.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAmt.Height = 0.1875!
        Me.txtAmt.Left = 1.4375!
        Me.txtAmt.Name = "txtAmt"
        Me.txtAmt.OutputFormat = resources.GetString("txtAmt.OutputFormat")
        Me.txtAmt.Style = "ddo-char-set: 0; text-align: right; font-size: 10pt; "
        Me.txtAmt.Text = "txtAmt"
        Me.txtAmt.Top = 0.0!
        Me.txtAmt.Width = 1.0!
        '
        'txtCardDetails
        '
        Me.txtCardDetails.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCardDetails.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCardDetails.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCardDetails.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCardDetails.Border.RightColor = System.Drawing.Color.Black
        Me.txtCardDetails.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCardDetails.Border.TopColor = System.Drawing.Color.Black
        Me.txtCardDetails.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCardDetails.Height = 0.1875!
        Me.txtCardDetails.Left = 0.0!
        Me.txtCardDetails.Name = "txtCardDetails"
        Me.txtCardDetails.Style = "ddo-char-set: 0; font-size: 10pt; "
        Me.txtCardDetails.Text = "txtCardDetails"
        Me.txtCardDetails.Top = 0.1875!
        Me.txtCardDetails.Width = 2.4375!
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0.0!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'ReportHeader1
        '
        Me.ReportHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.srptHeader, Me.txtReportName, Me.txtUser, Me.txtTime, Me.txtDate, Me.srptCollection, Me.Label1, Me.Label2, Me.txtBranch, Me.TextBox1, Me.Line1})
        Me.ReportHeader1.Height = 1.90625!
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
        Me.srptHeader.Width = 2.4375!
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
        Me.txtReportName.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 8.25pt; "
        Me.txtReportName.Text = "txtReportName"
        Me.txtReportName.Top = 0.3125!
        Me.txtReportName.Width = 2.4375!
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
        Me.txtUser.Top = 1.125!
        Me.txtUser.Width = 2.4375!
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
        Me.txtTime.Top = 0.9375!
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
        Me.txtDate.Left = 0.75!
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.txtDate.Text = "txtDate"
        Me.txtDate.Top = 0.5!
        Me.txtDate.Width = 1.6875!
        '
        'srptCollection
        '
        Me.srptCollection.Border.BottomColor = System.Drawing.Color.Black
        Me.srptCollection.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srptCollection.Border.LeftColor = System.Drawing.Color.Black
        Me.srptCollection.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srptCollection.Border.RightColor = System.Drawing.Color.Black
        Me.srptCollection.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srptCollection.Border.TopColor = System.Drawing.Color.Black
        Me.srptCollection.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srptCollection.CloseBorder = False
        Me.srptCollection.Height = 0.25!
        Me.srptCollection.Left = 0.0!
        Me.srptCollection.Name = "srptCollection"
        Me.srptCollection.Report = Nothing
        Me.srptCollection.ReportName = "SubReport1"
        Me.srptCollection.Top = 1.375!
        Me.srptCollection.Width = 2.44!
        '
        'ReportFooter1
        '
        Me.ReportFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox24, Me.txtTotalDrawer, Me.Line4, Me.TextBox15, Me.txtAmtCashSales, Me.txtAmtCashIn, Me.TextBox18, Me.TextBox21, Me.txtAmtCashOut, Me.Line2, Me.srptSummary})
        Me.ReportFooter1.Height = 1.229167!
        Me.ReportFooter1.Name = "ReportFooter1"
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
        Me.TextBox24.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 10pt; "
        Me.TextBox24.Text = "TOTAL CASH IN DRAWER"
        Me.TextBox24.Top = 1.0!
        Me.TextBox24.Width = 2.0!
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
        Me.txtTotalDrawer.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 10pt; "
        Me.txtTotalDrawer.Text = "0.00"
        Me.txtTotalDrawer.Top = 1.0!
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
        Me.Line4.Top = 0.375!
        Me.Line4.Width = 2.4375!
        Me.Line4.X1 = 0.0!
        Me.Line4.X2 = 2.4375!
        Me.Line4.Y1 = 0.375!
        Me.Line4.Y2 = 0.375!
        '
        'Label1
        '
        Me.Label1.Border.BottomColor = System.Drawing.Color.Black
        Me.Label1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.LeftColor = System.Drawing.Color.Black
        Me.Label1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.RightColor = System.Drawing.Color.Black
        Me.Label1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.TopColor = System.Drawing.Color.Black
        Me.Label1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Height = 0.1875!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.0!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "ddo-char-set: 0; font-size: 8.25pt; "
        Me.Label1.Text = "Date Range :"
        Me.Label1.Top = 0.5!
        Me.Label1.Width = 0.75!
        '
        'Label2
        '
        Me.Label2.Border.BottomColor = System.Drawing.Color.Black
        Me.Label2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Border.LeftColor = System.Drawing.Color.Black
        Me.Label2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Border.RightColor = System.Drawing.Color.Black
        Me.Label2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Border.TopColor = System.Drawing.Color.Black
        Me.Label2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Height = 0.1875!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.0!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "ddo-char-set: 0; font-size: 8.25pt; "
        Me.Label2.Text = "Branch ID :"
        Me.Label2.Top = 0.6875!
        Me.Label2.Width = 0.75!
        '
        'txtBranch
        '
        Me.txtBranch.Border.BottomColor = System.Drawing.Color.Black
        Me.txtBranch.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtBranch.Border.LeftColor = System.Drawing.Color.Black
        Me.txtBranch.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtBranch.Border.RightColor = System.Drawing.Color.Black
        Me.txtBranch.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtBranch.Border.TopColor = System.Drawing.Color.Black
        Me.txtBranch.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtBranch.Height = 0.1875!
        Me.txtBranch.Left = 0.75!
        Me.txtBranch.Name = "txtBranch"
        Me.txtBranch.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.txtBranch.Text = "txtBranch"
        Me.txtBranch.Top = 0.6875!
        Me.txtBranch.Width = 1.6875!
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
        Me.TextBox15.Style = "ddo-char-set: 0; text-align: left; font-size: 9.75pt; "
        Me.TextBox15.Text = "CASH SALES"
        Me.TextBox15.Top = 0.4375!
        Me.TextBox15.Width = 1.0625!
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
        Me.txtAmtCashSales.Style = "ddo-char-set: 0; text-align: right; font-size: 9.75pt; "
        Me.txtAmtCashSales.Text = "0.00"
        Me.txtAmtCashSales.Top = 0.4375!
        Me.txtAmtCashSales.Width = 0.6875!
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
        Me.txtAmtCashIn.Style = "ddo-char-set: 0; text-align: right; font-size: 9.75pt; "
        Me.txtAmtCashIn.Text = "0.00"
        Me.txtAmtCashIn.Top = 0.625!
        Me.txtAmtCashIn.Width = 0.6875!
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
        Me.TextBox18.Style = "ddo-char-set: 0; text-align: left; font-size: 9.75pt; "
        Me.TextBox18.Text = "CASH IN"
        Me.TextBox18.Top = 0.625!
        Me.TextBox18.Width = 1.0625!
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
        Me.TextBox21.Style = "ddo-char-set: 0; text-align: left; font-size: 9.75pt; "
        Me.TextBox21.Text = "CASH OUT"
        Me.TextBox21.Top = 0.8125!
        Me.TextBox21.Width = 1.0625!
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
        Me.txtAmtCashOut.Style = "ddo-char-set: 0; text-align: right; font-size: 9.75pt; "
        Me.txtAmtCashOut.Text = "0.00"
        Me.txtAmtCashOut.Top = 0.8125!
        Me.txtAmtCashOut.Width = 0.6875!
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
        Me.TextBox1.Style = "ddo-char-set: 0; text-decoration: none; text-align: left; font-weight: bold; font" & _
            "-size: 12pt; "
        Me.TextBox1.Text = "PAYMENT DETAILS:"
        Me.TextBox1.Top = 1.6875!
        Me.TextBox1.Width = 2.4375!
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
        Me.Line1.Top = 1.6875!
        Me.Line1.Width = 2.4375!
        Me.Line1.X1 = 0.0!
        Me.Line1.X2 = 2.4375!
        Me.Line1.Y1 = 1.6875!
        Me.Line1.Y2 = 1.6875!
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
        Me.Line2.Top = 0.0!
        Me.Line2.Width = 2.4375!
        Me.Line2.X1 = 0.0!
        Me.Line2.X2 = 2.4375!
        Me.Line2.Y1 = 0.0!
        Me.Line2.Y2 = 0.0!
        '
        'srptSummary
        '
        Me.srptSummary.Border.BottomColor = System.Drawing.Color.Black
        Me.srptSummary.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srptSummary.Border.LeftColor = System.Drawing.Color.Black
        Me.srptSummary.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srptSummary.Border.RightColor = System.Drawing.Color.Black
        Me.srptSummary.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srptSummary.Border.TopColor = System.Drawing.Color.Black
        Me.srptSummary.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srptSummary.CloseBorder = False
        Me.srptSummary.Height = 0.25!
        Me.srptSummary.Left = 0.0!
        Me.srptSummary.Name = "srptSummary"
        Me.srptSummary.Report = Nothing
        Me.srptSummary.ReportName = "SubReport1"
        Me.srptSummary.Top = 0.0625!
        Me.srptSummary.Width = 2.44!
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
        CType(Me.txtInvoiceNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCardDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReportName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalDrawer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBranch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmtCashSales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmtCashIn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmtCashOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents ReportHeader1 As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents ReportFooter1 As DataDynamics.ActiveReports.ReportFooter
    Friend WithEvents TextBox24 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTotalDrawer As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line4 As DataDynamics.ActiveReports.Line
    Friend WithEvents srptHeader As DataDynamics.ActiveReports.SubReport
    Friend WithEvents txtInvoiceNo As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAmt As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCardDetails As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtReportName As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtUser As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTime As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDate As DataDynamics.ActiveReports.TextBox
    Friend WithEvents srptCollection As DataDynamics.ActiveReports.SubReport
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label2 As DataDynamics.ActiveReports.Label
    Friend WithEvents txtBranch As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox15 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAmtCashSales As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAmtCashIn As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox18 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox21 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAmtCashOut As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line2 As DataDynamics.ActiveReports.Line
    Friend WithEvents srptSummary As DataDynamics.ActiveReports.SubReport
End Class
