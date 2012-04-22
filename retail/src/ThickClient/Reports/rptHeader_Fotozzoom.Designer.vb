<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptHeader_Fotozzoom 
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptHeader_Fotozzoom))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.ReportHeader1 = New DataDynamics.ActiveReports.ReportHeader
        Me.ReportFooter1 = New DataDynamics.ActiveReports.ReportFooter
        Me.Label2 = New DataDynamics.ActiveReports.Label
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
        Me.txtBranchName = New DataDynamics.ActiveReports.TextBox
        Me.txtTel = New DataDynamics.ActiveReports.TextBox
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBranchName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTel, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Detail1.Height = 0.0!
        Me.Detail1.Name = "Detail1"
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0.0!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'ReportHeader1
        '
        Me.ReportHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label2, Me.TextBox1, Me.txtBranchName, Me.txtTel})
        Me.ReportHeader1.Height = 0.75!
        Me.ReportHeader1.Name = "ReportHeader1"
        '
        'ReportFooter1
        '
        Me.ReportFooter1.Height = 0.0!
        Me.ReportFooter1.Name = "ReportFooter1"
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
        Me.Label2.Height = 0.3125!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.0!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "ddo-char-set: 0; font-weight: bold; font-size: 15.75pt; "
        Me.Label2.Text = "FOTO-ZZOOM SDN BHD"
        Me.Label2.Top = 0.0!
        Me.Label2.Width = 2.5625!
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
        Me.TextBox1.Left = 1.875!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; "
        Me.TextBox1.Text = "145663-V"
        Me.TextBox1.Top = 0.25!
        Me.TextBox1.Width = 0.6875!
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
        Me.txtBranchName.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; font-family: Arial; "
        Me.txtBranchName.Text = "Foto-ZZoom Sdn Bhd (145663-V)"
        Me.txtBranchName.Top = 0.375!
        Me.txtBranchName.Width = 2.5625!
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
        Me.txtTel.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; font-family: Arial; "
        Me.txtTel.Text = "txtTel"
        Me.txtTel.Top = 0.5625!
        Me.txtTel.Width = 2.5625!
        '
        'rptHeader_Fotozzoom
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 2.572917!
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
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBranchName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents ReportHeader1 As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents Label2 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtBranchName As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTel As DataDynamics.ActiveReports.TextBox
    Friend WithEvents ReportFooter1 As DataDynamics.ActiveReports.ReportFooter
End Class
