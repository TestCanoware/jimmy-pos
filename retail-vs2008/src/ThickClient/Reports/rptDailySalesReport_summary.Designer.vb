<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptDailySalesReport_Summary
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptDailySalesReport_Summary))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
        Me.txtGrossSalesAmt = New DataDynamics.ActiveReports.TextBox
        Me.txtGrossSalesQty = New DataDynamics.ActiveReports.TextBox
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.txtTotalAmt = New DataDynamics.ActiveReports.TextBox
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
        Me.txtName = New DataDynamics.ActiveReports.TextBox
        Me.txtQty = New DataDynamics.ActiveReports.TextBox
        Me.txtAmt = New DataDynamics.ActiveReports.TextBox
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGrossSalesAmt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGrossSalesQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalAmt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmt, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtAmt, Me.txtQty, Me.txtName})
        Me.Detail1.Height = 0.1875!
        Me.Detail1.Name = "Detail1"
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0.0!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox1, Me.txtGrossSalesAmt, Me.txtGrossSalesQty, Me.TextBox5})
        Me.GroupHeader1.Height = 0.375!
        Me.GroupHeader1.Name = "GroupHeader1"
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
        Me.TextBox1.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 12pt; "
        Me.TextBox1.Text = "SUMMARY"
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 2.375!
        '
        'txtGrossSalesAmt
        '
        Me.txtGrossSalesAmt.Border.BottomColor = System.Drawing.Color.Black
        Me.txtGrossSalesAmt.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtGrossSalesAmt.Border.LeftColor = System.Drawing.Color.Black
        Me.txtGrossSalesAmt.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtGrossSalesAmt.Border.RightColor = System.Drawing.Color.Black
        Me.txtGrossSalesAmt.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtGrossSalesAmt.Border.TopColor = System.Drawing.Color.Black
        Me.txtGrossSalesAmt.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtGrossSalesAmt.Height = 0.1875!
        Me.txtGrossSalesAmt.Left = 1.75!
        Me.txtGrossSalesAmt.Name = "txtGrossSalesAmt"
        Me.txtGrossSalesAmt.OutputFormat = resources.GetString("txtGrossSalesAmt.OutputFormat")
        Me.txtGrossSalesAmt.Style = "ddo-char-set: 0; text-align: right; font-size: 10pt; "
        Me.txtGrossSalesAmt.Text = "0.00"
        Me.txtGrossSalesAmt.Top = 0.1875!
        Me.txtGrossSalesAmt.Width = 0.6875!
        '
        'txtGrossSalesQty
        '
        Me.txtGrossSalesQty.Border.BottomColor = System.Drawing.Color.Black
        Me.txtGrossSalesQty.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtGrossSalesQty.Border.LeftColor = System.Drawing.Color.Black
        Me.txtGrossSalesQty.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtGrossSalesQty.Border.RightColor = System.Drawing.Color.Black
        Me.txtGrossSalesQty.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtGrossSalesQty.Border.TopColor = System.Drawing.Color.Black
        Me.txtGrossSalesQty.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtGrossSalesQty.Height = 0.1875!
        Me.txtGrossSalesQty.Left = 1.25!
        Me.txtGrossSalesQty.Name = "txtGrossSalesQty"
        Me.txtGrossSalesQty.Style = "ddo-char-set: 0; text-align: right; font-size: 10pt; "
        Me.txtGrossSalesQty.Text = "0"
        Me.txtGrossSalesQty.Top = 0.1875!
        Me.txtGrossSalesQty.Width = 0.5!
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
        Me.TextBox5.Style = "ddo-char-set: 0; text-align: left; font-size: 10pt; "
        Me.TextBox5.Text = "GROSS SALES"
        Me.TextBox5.Top = 0.1875!
        Me.TextBox5.Width = 1.1875!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Line2, Me.txtTotalAmt, Me.TextBox2})
        Me.GroupFooter1.Height = 0.3020833!
        Me.GroupFooter1.Name = "GroupFooter1"
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
        Me.Line2.Left = 1.75!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.0!
        Me.Line2.Width = 0.75!
        Me.Line2.X1 = 1.75!
        Me.Line2.X2 = 2.5!
        Me.Line2.Y1 = 0.0!
        Me.Line2.Y2 = 0.0!
        '
        'txtTotalAmt
        '
        Me.txtTotalAmt.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTotalAmt.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalAmt.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTotalAmt.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalAmt.Border.RightColor = System.Drawing.Color.Black
        Me.txtTotalAmt.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalAmt.Border.TopColor = System.Drawing.Color.Black
        Me.txtTotalAmt.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalAmt.Height = 0.1875!
        Me.txtTotalAmt.Left = 1.75!
        Me.txtTotalAmt.Name = "txtTotalAmt"
        Me.txtTotalAmt.OutputFormat = resources.GetString("txtTotalAmt.OutputFormat")
        Me.txtTotalAmt.Style = "ddo-char-set: 0; text-align: right; font-weight: normal; font-size: 9.75pt; "
        Me.txtTotalAmt.Text = "0.00"
        Me.txtTotalAmt.Top = 0.0625!
        Me.txtTotalAmt.Width = 0.6875!
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
        Me.TextBox2.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; font-size: 9.75pt; "
        Me.TextBox2.Text = "NET SALES"
        Me.TextBox2.Top = 0.0625!
        Me.TextBox2.Width = 0.9375!
        '
        'txtName
        '
        Me.txtName.Border.BottomColor = System.Drawing.Color.Black
        Me.txtName.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtName.Border.LeftColor = System.Drawing.Color.Black
        Me.txtName.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtName.Border.RightColor = System.Drawing.Color.Black
        Me.txtName.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtName.Border.TopColor = System.Drawing.Color.Black
        Me.txtName.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtName.Height = 0.1875!
        Me.txtName.Left = 0.0!
        Me.txtName.Name = "txtName"
        Me.txtName.Style = "ddo-char-set: 0; text-align: left; font-size: 10pt; "
        Me.txtName.Text = "VOID (CASH)"
        Me.txtName.Top = 0.0!
        Me.txtName.Width = 1.25!
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
        Me.txtQty.Left = 1.25!
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Style = "ddo-char-set: 0; text-align: right; font-size: 10pt; "
        Me.txtQty.Text = "0"
        Me.txtQty.Top = 0.0!
        Me.txtQty.Width = 0.5!
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
        Me.txtAmt.Left = 1.75!
        Me.txtAmt.Name = "txtAmt"
        Me.txtAmt.OutputFormat = resources.GetString("txtAmt.OutputFormat")
        Me.txtAmt.Style = "ddo-char-set: 0; text-align: right; font-size: 10pt; "
        Me.txtAmt.Text = "0.00"
        Me.txtAmt.Top = 0.0!
        Me.txtAmt.Width = 0.6875!
        '
        'rptDailySalesReport_Summary
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 2.5!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGrossSalesAmt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGrossSalesQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalAmt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents Line2 As DataDynamics.ActiveReports.Line
    Friend WithEvents txtTotalAmt As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtGrossSalesAmt As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtGrossSalesQty As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAmt As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtQty As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtName As DataDynamics.ActiveReports.TextBox
End Class
