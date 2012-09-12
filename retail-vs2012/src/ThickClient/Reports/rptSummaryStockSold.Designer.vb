<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptSummaryStockSold
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptSummaryStockSold))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.Line4 = New DataDynamics.ActiveReports.Line
        Me.txtDate = New DataDynamics.ActiveReports.TextBox
        Me.txtReportName = New DataDynamics.ActiveReports.TextBox
        Me.txtUser = New DataDynamics.ActiveReports.TextBox
        Me.txtTime = New DataDynamics.ActiveReports.TextBox
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.Label2 = New DataDynamics.ActiveReports.Label
        Me.Label3 = New DataDynamics.ActiveReports.Label
        Me.Label4 = New DataDynamics.ActiveReports.Label
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.txtCode = New DataDynamics.ActiveReports.TextBox
        Me.txtQty = New DataDynamics.ActiveReports.TextBox
        Me.txtTotal = New DataDynamics.ActiveReports.TextBox
        Me.txtNo = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.ReportHeader1 = New DataDynamics.ActiveReports.ReportHeader
        Me.txtBranchName = New DataDynamics.ActiveReports.TextBox
        Me.txtAdd2 = New DataDynamics.ActiveReports.TextBox
        Me.txtTel = New DataDynamics.ActiveReports.TextBox
        Me.txtAdd1 = New DataDynamics.ActiveReports.TextBox
        Me.txtRegNo = New DataDynamics.ActiveReports.TextBox
        Me.ReportFooter1 = New DataDynamics.ActiveReports.ReportFooter
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
        Me.txtQtyAmt = New DataDynamics.ActiveReports.TextBox
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
        Me.Line1 = New DataDynamics.ActiveReports.Line
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReportName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBranchName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdd2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRegNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtyAmt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Line4, Me.txtDate, Me.txtReportName, Me.txtUser, Me.txtTime, Me.Label1, Me.Label2, Me.Label3, Me.Label4})
        Me.PageHeader1.Height = 1.1875!
        Me.PageHeader1.Name = "PageHeader1"
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
        Me.Line4.Top = 2.4375!
        Me.Line4.Width = 2.4375!
        Me.Line4.X1 = 0.0!
        Me.Line4.X2 = 2.4375!
        Me.Line4.Y1 = 2.4375!
        Me.Line4.Y2 = 2.4375!
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
        Me.txtDate.Width = 2.5625!
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
        Me.txtReportName.Width = 2.5625!
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
        Me.txtUser.Width = 2.5625!
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
        Me.txtTime.Width = 2.5625!
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
        Me.Label1.Style = "font-weight: bold; "
        Me.Label1.Text = "No"
        Me.Label1.Top = 0.9375!
        Me.Label1.Width = 0.25!
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
        Me.Label2.Left = 0.3125!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-weight: bold; "
        Me.Label2.Text = "Item Code"
        Me.Label2.Top = 0.9375!
        Me.Label2.Width = 0.9375!
        '
        'Label3
        '
        Me.Label3.Border.BottomColor = System.Drawing.Color.Black
        Me.Label3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Border.LeftColor = System.Drawing.Color.Black
        Me.Label3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Border.RightColor = System.Drawing.Color.Black
        Me.Label3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Border.TopColor = System.Drawing.Color.Black
        Me.Label3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Height = 0.1875!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 1.375!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "text-align: center; font-weight: bold; "
        Me.Label3.Text = "Qty"
        Me.Label3.Top = 0.9375!
        Me.Label3.Width = 0.3125!
        '
        'Label4
        '
        Me.Label4.Border.BottomColor = System.Drawing.Color.Black
        Me.Label4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Border.LeftColor = System.Drawing.Color.Black
        Me.Label4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Border.RightColor = System.Drawing.Color.Black
        Me.Label4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Border.TopColor = System.Drawing.Color.Black
        Me.Label4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Height = 0.1875!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 1.75!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "text-align: center; font-weight: bold; "
        Me.Label4.Text = "Total Amt"
        Me.Label4.Top = 0.9375!
        Me.Label4.Width = 0.75!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtCode, Me.txtQty, Me.txtTotal, Me.txtNo})
        Me.Detail1.Height = 0.1979167!
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
        Me.txtCode.Left = 0.375!
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Style = "ddo-char-set: 0; text-align: left; font-size: 10pt; "
        Me.txtCode.Text = "txtCode"
        Me.txtCode.Top = 0.0!
        Me.txtCode.Width = 0.875!
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
        Me.txtQty.Left = 1.1875!
        Me.txtQty.Name = "txtQty"
        Me.txtQty.OutputFormat = resources.GetString("txtQty.OutputFormat")
        Me.txtQty.Style = "ddo-char-set: 0; text-align: right; font-size: 10pt; "
        Me.txtQty.Text = "100000"
        Me.txtQty.Top = 0.0!
        Me.txtQty.Width = 0.5625!
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
        Me.txtTotal.DataField = "total"
        Me.txtTotal.Height = 0.1875!
        Me.txtTotal.Left = 1.75!
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.OutputFormat = resources.GetString("txtTotal.OutputFormat")
        Me.txtTotal.Style = "ddo-char-set: 0; text-align: right; font-size: 10pt; "
        Me.txtTotal.Text = "txtTotal"
        Me.txtTotal.Top = 0.0!
        Me.txtTotal.Width = 0.75!
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
        Me.txtNo.DataField = "NO"
        Me.txtNo.Height = 0.1875!
        Me.txtNo.Left = 0.0!
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Style = "ddo-char-set: 0; text-align: left; font-size: 10pt; "
        Me.txtNo.Text = "txtNo"
        Me.txtNo.Top = 0.0!
        Me.txtNo.Width = 0.3125!
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0.0!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'ReportHeader1
        '
        Me.ReportHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtBranchName, Me.txtAdd2, Me.txtTel, Me.txtAdd1, Me.txtRegNo})
        Me.ReportHeader1.Height = 0.9375!
        Me.ReportHeader1.Name = "ReportHeader1"
        '
        'txtBranchName
        '
        Me.txtBranchName.Border.BottomColor = System.Drawing.Color.Black
        Me.txtBranchName.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtBranchName.Border.LeftColor = System.Drawing.Color.Black
        Me.txtBranchName.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtBranchName.Border.RightColor = System.Drawing.Color.Black
        Me.txtBranchName.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtBranchName.Border.TopColor = System.Drawing.Color.Black
        Me.txtBranchName.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtBranchName.Height = 0.1875!
        Me.txtBranchName.Left = 0.0!
        Me.txtBranchName.Name = "txtBranchName"
        Me.txtBranchName.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; font-size: 12pt; font-f" & _
            "amily: Arial; "
        Me.txtBranchName.Text = "txtBranchName"
        Me.txtBranchName.Top = 0.0!
        Me.txtBranchName.Width = 2.5625!
        '
        'txtAdd2
        '
        Me.txtAdd2.Border.BottomColor = System.Drawing.Color.Black
        Me.txtAdd2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAdd2.Border.LeftColor = System.Drawing.Color.Black
        Me.txtAdd2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAdd2.Border.RightColor = System.Drawing.Color.Black
        Me.txtAdd2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAdd2.Border.TopColor = System.Drawing.Color.Black
        Me.txtAdd2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAdd2.Height = 0.1875!
        Me.txtAdd2.Left = 0.0!
        Me.txtAdd2.Name = "txtAdd2"
        Me.txtAdd2.Style = "ddo-char-set: 0; text-align: center; font-size: 10pt; font-family: Arial; "
        Me.txtAdd2.Text = "txtAdd2"
        Me.txtAdd2.Top = 0.375!
        Me.txtAdd2.Width = 2.5625!
        '
        'txtTel
        '
        Me.txtTel.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTel.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTel.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTel.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTel.Border.RightColor = System.Drawing.Color.Black
        Me.txtTel.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTel.Border.TopColor = System.Drawing.Color.Black
        Me.txtTel.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTel.Height = 0.1875!
        Me.txtTel.Left = 0.0!
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Style = "ddo-char-set: 0; text-align: center; font-size: 10pt; font-family: Arial; "
        Me.txtTel.Text = "txtTel"
        Me.txtTel.Top = 0.5625!
        Me.txtTel.Width = 2.5625!
        '
        'txtAdd1
        '
        Me.txtAdd1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtAdd1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAdd1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtAdd1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAdd1.Border.RightColor = System.Drawing.Color.Black
        Me.txtAdd1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAdd1.Border.TopColor = System.Drawing.Color.Black
        Me.txtAdd1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAdd1.Height = 0.1875!
        Me.txtAdd1.Left = 0.0!
        Me.txtAdd1.Name = "txtAdd1"
        Me.txtAdd1.Style = "ddo-char-set: 0; text-align: center; font-size: 10pt; font-family: Arial; "
        Me.txtAdd1.Text = "txtAdd1"
        Me.txtAdd1.Top = 0.1875!
        Me.txtAdd1.Width = 2.5625!
        '
        'txtRegNo
        '
        Me.txtRegNo.Border.BottomColor = System.Drawing.Color.Black
        Me.txtRegNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRegNo.Border.LeftColor = System.Drawing.Color.Black
        Me.txtRegNo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRegNo.Border.RightColor = System.Drawing.Color.Black
        Me.txtRegNo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRegNo.Border.TopColor = System.Drawing.Color.Black
        Me.txtRegNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtRegNo.Height = 0.1875!
        Me.txtRegNo.Left = 0.0!
        Me.txtRegNo.Name = "txtRegNo"
        Me.txtRegNo.Style = "ddo-char-set: 0; text-align: center; font-size: 10pt; font-family: Arial; "
        Me.txtRegNo.Text = "txtReg"
        Me.txtRegNo.Top = 0.75!
        Me.txtRegNo.Width = 2.5625!
        '
        'ReportFooter1
        '
        Me.ReportFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox1, Me.txtQtyAmt, Me.TextBox3, Me.Line1})
        Me.ReportFooter1.Height = 0.34375!
        Me.ReportFooter1.Name = "ReportFooter1"
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
        Me.TextBox1.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 10pt; "
        Me.TextBox1.Text = "TOTAL"
        Me.TextBox1.Top = 0.125!
        Me.TextBox1.Width = 0.9375!
        '
        'txtQtyAmt
        '
        Me.txtQtyAmt.Border.BottomColor = System.Drawing.Color.Black
        Me.txtQtyAmt.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQtyAmt.Border.LeftColor = System.Drawing.Color.Black
        Me.txtQtyAmt.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQtyAmt.Border.RightColor = System.Drawing.Color.Black
        Me.txtQtyAmt.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQtyAmt.Border.TopColor = System.Drawing.Color.Black
        Me.txtQtyAmt.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQtyAmt.DataField = "total_quantity"
        Me.txtQtyAmt.Height = 0.1875!
        Me.txtQtyAmt.Left = 1.125!
        Me.txtQtyAmt.Name = "txtQtyAmt"
        Me.txtQtyAmt.OutputFormat = resources.GetString("txtQtyAmt.OutputFormat")
        Me.txtQtyAmt.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 10pt; "
        Me.txtQtyAmt.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.txtQtyAmt.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.txtQtyAmt.Text = "txtQtyAmt"
        Me.txtQtyAmt.Top = 0.125!
        Me.txtQtyAmt.Width = 0.5!
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
        Me.TextBox3.DataField = "total"
        Me.TextBox3.Height = 0.1875!
        Me.TextBox3.Left = 1.6875!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.OutputFormat = resources.GetString("TextBox3.OutputFormat")
        Me.TextBox3.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 10pt; "
        Me.TextBox3.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.TextBox3.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox3.Text = "txtTotalAmt"
        Me.TextBox3.Top = 0.125!
        Me.TextBox3.Width = 0.8125!
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
        Me.Line1.Top = 0.0625!
        Me.Line1.Width = 2.5!
        Me.Line1.X1 = 0.0!
        Me.Line1.X2 = 2.5!
        Me.Line1.Y1 = 0.0625!
        Me.Line1.Y2 = 0.0625!
        '
        'rptSummaryStockSold
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 2.510417!
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
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReportName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBranchName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdd2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRegNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtyAmt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents ReportHeader1 As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents ReportFooter1 As DataDynamics.ActiveReports.ReportFooter
    Friend WithEvents txtCode As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtQty As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTotal As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line4 As DataDynamics.ActiveReports.Line
    Friend WithEvents txtDate As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtReportName As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtUser As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTime As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label2 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label3 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label4 As DataDynamics.ActiveReports.Label
    Friend WithEvents txtNo As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtQtyAmt As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
    Friend WithEvents txtBranchName As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAdd2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTel As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAdd1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtRegNo As DataDynamics.ActiveReports.TextBox
End Class
