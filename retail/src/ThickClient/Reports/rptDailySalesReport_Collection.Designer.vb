<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptDailySalesReport_Collection 
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptDailySalesReport_Collection))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.txtAmt = New DataDynamics.ActiveReports.TextBox
        Me.txtQty = New DataDynamics.ActiveReports.TextBox
        Me.txtName = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
        Me.txtTotalQty = New DataDynamics.ActiveReports.TextBox
        Me.txtTotalAmt = New DataDynamics.ActiveReports.TextBox
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
        Me.txtTotalAmtNoGST = New DataDynamics.ActiveReports.TextBox
        CType(Me.txtAmt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalAmt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalAmtNoGST, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.txtName.Text = "CASH"
        Me.txtName.Top = 0.0!
        Me.txtName.Width = 1.0!
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0.0!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox1})
        Me.GroupHeader1.Height = 0.25!
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
        Me.TextBox1.Text = "COLLECTION DETAILS :"
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 2.375!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Line2, Me.TextBox3, Me.txtTotalQty, Me.txtTotalAmt, Me.TextBox2, Me.txtTotalAmtNoGST})
        Me.GroupFooter1.Height = 0.4375!
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
        Me.TextBox3.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; font-size: 9.75pt; "
        Me.TextBox3.Text = "TOTAL (Incl . GST)"
        Me.TextBox3.Top = 0.0625!
        Me.TextBox3.Width = 1.25!
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
        Me.txtTotalQty.Left = 1.25!
        Me.txtTotalQty.Name = "txtTotalQty"
        Me.txtTotalQty.Style = "ddo-char-set: 0; text-align: right; font-weight: normal; font-size: 9.75pt; "
        Me.txtTotalQty.SummaryGroup = "GroupHeader1"
        Me.txtTotalQty.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.txtTotalQty.Text = "0"
        Me.txtTotalQty.Top = 0.0625!
        Me.txtTotalQty.Width = 0.5!
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
        Me.txtTotalAmt.SummaryGroup = "GroupHeader1"
        Me.txtTotalAmt.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
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
        Me.TextBox2.Text = "TOTAL (Excl. GST)"
        Me.TextBox2.Top = 0.25!
        Me.TextBox2.Width = 1.75!
        '
        'txtTotalAmtNoGST
        '
        Me.txtTotalAmtNoGST.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTotalAmtNoGST.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalAmtNoGST.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTotalAmtNoGST.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalAmtNoGST.Border.RightColor = System.Drawing.Color.Black
        Me.txtTotalAmtNoGST.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalAmtNoGST.Border.TopColor = System.Drawing.Color.Black
        Me.txtTotalAmtNoGST.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalAmtNoGST.Height = 0.1875!
        Me.txtTotalAmtNoGST.Left = 1.75!
        Me.txtTotalAmtNoGST.Name = "txtTotalAmtNoGST"
        Me.txtTotalAmtNoGST.OutputFormat = resources.GetString("txtTotalAmtNoGST.OutputFormat")
        Me.txtTotalAmtNoGST.Style = "ddo-char-set: 0; text-align: right; font-weight: normal; font-size: 9.75pt; "
        Me.txtTotalAmtNoGST.Text = "0.00"
        Me.txtTotalAmtNoGST.Top = 0.25!
        Me.txtTotalAmtNoGST.Width = 0.6875!
        '
        'rptDailySalesReport_Collection
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
        CType(Me.txtAmt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalAmt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalAmtNoGST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents txtAmt As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtQty As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtName As DataDynamics.ActiveReports.TextBox
    Friend WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents Line2 As DataDynamics.ActiveReports.Line
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTotalQty As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTotalAmt As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTotalAmtNoGST As DataDynamics.ActiveReports.TextBox
End Class
