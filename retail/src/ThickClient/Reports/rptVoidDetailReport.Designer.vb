<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptVoidDetailReport
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptVoidDetailReport))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.txtCode = New DataDynamics.ActiveReports.TextBox
        Me.txtQty = New DataDynamics.ActiveReports.TextBox
        Me.txtPrice = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.ReportHeader1 = New DataDynamics.ActiveReports.ReportHeader
        Me.ReportFooter1 = New DataDynamics.ActiveReports.ReportFooter
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
        Me.txtTotalQty = New DataDynamics.ActiveReports.TextBox
        Me.txtTotalAmount = New DataDynamics.ActiveReports.TextBox
        Me.srptHeader = New DataDynamics.ActiveReports.SubReport
        Me.txtCategoryName = New DataDynamics.ActiveReports.TextBox
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox
        Me.txtDate = New DataDynamics.ActiveReports.TextBox
        Me.txtReportName = New DataDynamics.ActiveReports.TextBox
        Me.txtUser = New DataDynamics.ActiveReports.TextBox
        Me.txtTime = New DataDynamics.ActiveReports.TextBox
        CType(Me.txtCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCategoryName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReportName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtCategoryName, Me.TextBox4, Me.TextBox5, Me.txtDate, Me.txtReportName, Me.txtUser, Me.txtTime})
        Me.PageHeader1.Height = 1.1875!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtCode, Me.txtQty, Me.txtPrice})
        Me.Detail1.Height = 0.1875!
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
        Me.txtCode.DataField = "name"
        Me.txtCode.Height = 0.1875!
        Me.txtCode.Left = 0.0!
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Style = "ddo-char-set: 0; text-align: left; font-size: 8pt; "
        Me.txtCode.Text = Nothing
        Me.txtCode.Top = 0.0!
        Me.txtCode.Width = 1.4375!
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
        Me.txtQty.Left = 1.5!
        Me.txtQty.Name = "txtQty"
        Me.txtQty.OutputFormat = resources.GetString("txtQty.OutputFormat")
        Me.txtQty.Style = "ddo-char-set: 0; text-align: right; font-size: 8pt; "
        Me.txtQty.Text = "0"
        Me.txtQty.Top = 0.0!
        Me.txtQty.Width = 0.3125!
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
        Me.txtPrice.DataField = "total_amt"
        Me.txtPrice.Height = 0.1875!
        Me.txtPrice.Left = 1.875!
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.OutputFormat = resources.GetString("txtPrice.OutputFormat")
        Me.txtPrice.Style = "ddo-char-set: 0; text-align: right; font-size: 8pt; "
        Me.txtPrice.Text = "0.00"
        Me.txtPrice.Top = 0.0!
        Me.txtPrice.Width = 0.5625!
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
        Me.ReportFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Line2, Me.TextBox1, Me.txtTotalQty, Me.txtTotalAmount})
        Me.ReportFooter1.Height = 0.3125!
        Me.ReportFooter1.Name = "ReportFooter1"
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
        Me.Line2.Top = 0.0625!
        Me.Line2.Width = 2.45!
        Me.Line2.X1 = 0.0!
        Me.Line2.X2 = 2.45!
        Me.Line2.Y1 = 0.0625!
        Me.Line2.Y2 = 0.0625!
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
        Me.TextBox1.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; font-size: 8.25pt; "
        Me.TextBox1.Text = "TOTAL"
        Me.TextBox1.Top = 0.125!
        Me.TextBox1.Width = 1.4375!
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
        Me.txtTotalQty.Left = 1.5!
        Me.txtTotalQty.Name = "txtTotalQty"
        Me.txtTotalQty.OutputFormat = resources.GetString("txtTotalQty.OutputFormat")
        Me.txtTotalQty.Style = "ddo-char-set: 0; text-align: right; font-weight: normal; font-size: 8.25pt; "
        Me.txtTotalQty.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.txtTotalQty.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.txtTotalQty.Text = "0"
        Me.txtTotalQty.Top = 0.125!
        Me.txtTotalQty.Width = 0.3125!
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTotalAmount.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalAmount.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTotalAmount.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalAmount.Border.RightColor = System.Drawing.Color.Black
        Me.txtTotalAmount.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalAmount.Border.TopColor = System.Drawing.Color.Black
        Me.txtTotalAmount.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalAmount.DataField = "total_amt"
        Me.txtTotalAmount.Height = 0.1875!
        Me.txtTotalAmount.Left = 1.875!
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.OutputFormat = resources.GetString("txtTotalAmount.OutputFormat")
        Me.txtTotalAmount.Style = "ddo-char-set: 0; text-align: right; font-weight: normal; font-size: 8.25pt; "
        Me.txtTotalAmount.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.txtTotalAmount.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.txtTotalAmount.Text = "0.00"
        Me.txtTotalAmount.Top = 0.125!
        Me.txtTotalAmount.Width = 0.5625!
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
        Me.txtCategoryName.Height = 0.1875!
        Me.txtCategoryName.Left = 0.0!
        Me.txtCategoryName.Name = "txtCategoryName"
        Me.txtCategoryName.Style = "ddo-char-set: 0; text-decoration: underline; text-align: left; font-size: 8.25pt;" & _
            " font-family: Microsoft Sans Serif; "
        Me.txtCategoryName.Text = "Department"
        Me.txtCategoryName.Top = 1.0!
        Me.txtCategoryName.Width = 1.4375!
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
        Me.TextBox4.Left = 1.5!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "ddo-char-set: 0; text-decoration: underline; text-align: center; font-size: 8.25p" & _
            "t; font-family: Microsoft Sans Serif; "
        Me.TextBox4.Text = "Qty"
        Me.TextBox4.Top = 1.0!
        Me.TextBox4.Width = 0.3125!
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
        Me.TextBox5.Left = 1.875!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "ddo-char-set: 0; text-decoration: underline; text-align: right; font-size: 8.25pt" & _
            "; font-family: Microsoft Sans Serif; "
        Me.TextBox5.Text = "Amt"
        Me.TextBox5.Top = 1.0!
        Me.TextBox5.Width = 0.5625!
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
        'rptVoidDetailReport
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
        CType(Me.txtCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCategoryName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReportName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents ReportHeader1 As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents ReportFooter1 As DataDynamics.ActiveReports.ReportFooter
    Friend WithEvents txtCode As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtQty As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPrice As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line2 As DataDynamics.ActiveReports.Line
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTotalQty As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTotalAmount As DataDynamics.ActiveReports.TextBox
    Friend WithEvents srptHeader As DataDynamics.ActiveReports.SubReport
    Friend WithEvents txtCategoryName As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtDate As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtReportName As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtUser As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTime As DataDynamics.ActiveReports.TextBox
End Class
