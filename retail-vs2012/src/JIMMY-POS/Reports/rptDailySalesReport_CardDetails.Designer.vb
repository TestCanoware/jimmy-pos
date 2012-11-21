<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptDailySalesReport_CardDetails 
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptDailySalesReport_CardDetails))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.txtInvoiceNo = New DataDynamics.ActiveReports.TextBox
        Me.txtAmt = New DataDynamics.ActiveReports.TextBox
        Me.txtCardDetails = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        CType(Me.txtInvoiceNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCardDetails, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Detail1.Height = 0.3645833!
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
        Me.txtInvoiceNo.Text = "txtInvoiceNo"
        Me.txtInvoiceNo.Top = 0.0!
        Me.txtInvoiceNo.Width = 0.75!
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
        Me.txtCardDetails.Text = "txtInvoiceNo"
        Me.txtCardDetails.Top = 0.1875!
        Me.txtCardDetails.Width = 2.4375!
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0.0!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'rptDailySalesReport_CardDetails
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 2.45!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.txtInvoiceNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCardDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents txtInvoiceNo As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAmt As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtCardDetails As DataDynamics.ActiveReports.TextBox
End Class 
