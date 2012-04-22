<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptHourlySalesReport
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptHourlySalesReport))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.txtNoBill = New DataDynamics.ActiveReports.TextBox
        Me.txtAmount = New DataDynamics.ActiveReports.TextBox
        Me.txtHour = New DataDynamics.ActiveReports.TextBox
        Me.txtCashier = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.ReportHeader1 = New DataDynamics.ActiveReports.ReportHeader
        Me.ReportFooter1 = New DataDynamics.ActiveReports.ReportFooter
        Me.txtGrand = New DataDynamics.ActiveReports.TextBox
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.txtTotalBill = New DataDynamics.ActiveReports.TextBox
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox
        Me.srptHeader = New DataDynamics.ActiveReports.SubReport
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox
        Me.txtDate = New DataDynamics.ActiveReports.TextBox
        Me.txtReportName = New DataDynamics.ActiveReports.TextBox
        Me.txtUser = New DataDynamics.ActiveReports.TextBox
        Me.txtTime = New DataDynamics.ActiveReports.TextBox
        CType(Me.txtNoBill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCashier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGrand, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalBill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReportName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.TextBox4, Me.txtDate, Me.txtReportName, Me.txtUser, Me.txtTime})
        Me.PageHeader1.Height = 1.125!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtNoBill, Me.txtAmount, Me.txtHour, Me.txtCashier})
        Me.Detail1.Height = 0.1875!
        Me.Detail1.Name = "Detail1"
        '
        'txtNoBill
        '
        Me.txtNoBill.Border.BottomColor = System.Drawing.Color.Black
        Me.txtNoBill.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNoBill.Border.LeftColor = System.Drawing.Color.Black
        Me.txtNoBill.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNoBill.Border.RightColor = System.Drawing.Color.Black
        Me.txtNoBill.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNoBill.Border.TopColor = System.Drawing.Color.Black
        Me.txtNoBill.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNoBill.DataField = "count"
        Me.txtNoBill.Height = 0.1875!
        Me.txtNoBill.Left = 1.4375!
        Me.txtNoBill.Name = "txtNoBill"
        Me.txtNoBill.OutputFormat = resources.GetString("txtNoBill.OutputFormat")
        Me.txtNoBill.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; "
        Me.txtNoBill.Text = Nothing
        Me.txtNoBill.Top = 0.0!
        Me.txtNoBill.Width = 0.375!
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
        Me.txtAmount.DataField = "amount"
        Me.txtAmount.Height = 0.1875!
        Me.txtAmount.Left = 1.875!
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.OutputFormat = resources.GetString("txtAmount.OutputFormat")
        Me.txtAmount.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtAmount.Text = Nothing
        Me.txtAmount.Top = 0.0!
        Me.txtAmount.Width = 0.5625!
        '
        'txtHour
        '
        Me.txtHour.Border.BottomColor = System.Drawing.Color.Black
        Me.txtHour.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtHour.Border.LeftColor = System.Drawing.Color.Black
        Me.txtHour.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtHour.Border.RightColor = System.Drawing.Color.Black
        Me.txtHour.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtHour.Border.TopColor = System.Drawing.Color.Black
        Me.txtHour.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtHour.Height = 0.1875!
        Me.txtHour.Left = 1.0!
        Me.txtHour.Name = "txtHour"
        Me.txtHour.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.txtHour.Text = Nothing
        Me.txtHour.Top = 0.0!
        Me.txtHour.Width = 0.4375!
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
        Me.txtCashier.DataField = "username"
        Me.txtCashier.Height = 0.1875!
        Me.txtCashier.Left = 0.0!
        Me.txtCashier.Name = "txtCashier"
        Me.txtCashier.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.txtCashier.Text = Nothing
        Me.txtCashier.Top = 0.0!
        Me.txtCashier.Width = 1.0625!
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
        'ReportFooter1
        '
        Me.ReportFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtGrand, Me.Line1, Me.txtTotalBill, Me.TextBox9})
        Me.ReportFooter1.Height = 0.3333333!
        Me.ReportFooter1.Name = "ReportFooter1"
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
        Me.txtGrand.DataField = "amount"
        Me.txtGrand.Height = 0.1875!
        Me.txtGrand.Left = 1.875!
        Me.txtGrand.Name = "txtGrand"
        Me.txtGrand.OutputFormat = resources.GetString("txtGrand.OutputFormat")
        Me.txtGrand.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; "
        Me.txtGrand.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.txtGrand.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.txtGrand.Text = "0.00"
        Me.txtGrand.Top = 0.0625!
        Me.txtGrand.Width = 0.5625!
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
        'txtTotalBill
        '
        Me.txtTotalBill.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTotalBill.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalBill.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTotalBill.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalBill.Border.RightColor = System.Drawing.Color.Black
        Me.txtTotalBill.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalBill.Border.TopColor = System.Drawing.Color.Black
        Me.txtTotalBill.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalBill.DataField = "count"
        Me.txtTotalBill.Height = 0.1875!
        Me.txtTotalBill.Left = 1.4375!
        Me.txtTotalBill.Name = "txtTotalBill"
        Me.txtTotalBill.OutputFormat = resources.GetString("txtTotalBill.OutputFormat")
        Me.txtTotalBill.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; "
        Me.txtTotalBill.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.txtTotalBill.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.txtTotalBill.Text = "0"
        Me.txtTotalBill.Top = 0.0625!
        Me.txtTotalBill.Width = 0.375!
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
        Me.TextBox9.Left = 0.0!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.OutputFormat = resources.GetString("TextBox9.OutputFormat")
        Me.TextBox9.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; "
        Me.TextBox9.Text = "TOTAL"
        Me.TextBox9.Top = 0.0625!
        Me.TextBox9.Width = 0.75!
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
        Me.TextBox1.Style = "ddo-char-set: 0; text-decoration: underline; text-align: left; font-size: 8.25pt;" & _
            " "
        Me.TextBox1.Text = "Cashier"
        Me.TextBox1.Top = 0.9375!
        Me.TextBox1.Width = 1.0!
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
        Me.TextBox2.Left = 1.0!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "ddo-char-set: 0; text-decoration: underline; text-align: left; font-size: 8.25pt;" & _
            " "
        Me.TextBox2.Text = "Hour"
        Me.TextBox2.Top = 0.9375!
        Me.TextBox2.Width = 0.375!
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
        Me.TextBox3.Left = 1.4375!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "ddo-char-set: 0; text-decoration: underline; text-align: center; font-size: 8.25p" & _
            "t; "
        Me.TextBox3.Text = "No of Bill"
        Me.TextBox3.Top = 0.9375!
        Me.TextBox3.Width = 0.5!
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
        Me.TextBox4.Left = 1.9375!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "ddo-char-set: 0; text-decoration: underline; text-align: right; font-size: 8.25pt" & _
            "; "
        Me.TextBox4.Text = "Amt"
        Me.TextBox4.Top = 0.9375!
        Me.TextBox4.Width = 0.5!
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
        'rptHourlySalesReport
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
        CType(Me.txtNoBill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCashier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGrand, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalBill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReportName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents ReportHeader1 As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents ReportFooter1 As DataDynamics.ActiveReports.ReportFooter
    Friend WithEvents txtNoBill As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAmount As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtGrand As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
    Friend WithEvents txtHour As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCashier As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTotalBill As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents srptHeader As DataDynamics.ActiveReports.SubReport
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDate As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtReportName As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtUser As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTime As DataDynamics.ActiveReports.TextBox
End Class
