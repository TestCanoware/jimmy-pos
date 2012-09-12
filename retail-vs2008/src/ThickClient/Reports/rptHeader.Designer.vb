<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptHeader
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptHeader))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.ReportHeader1 = New DataDynamics.ActiveReports.ReportHeader
        Me.txtBranchName = New DataDynamics.ActiveReports.TextBox
        Me.txtAdd2 = New DataDynamics.ActiveReports.TextBox
        Me.txtTel = New DataDynamics.ActiveReports.TextBox
        Me.txtAdd1 = New DataDynamics.ActiveReports.TextBox
        Me.txtRegNo = New DataDynamics.ActiveReports.TextBox
        Me.ReportFooter1 = New DataDynamics.ActiveReports.ReportFooter
        CType(Me.txtBranchName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdd2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRegNo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Detail1.Height = 0.02083333!
        Me.Detail1.Name = "Detail1"
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0.0!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'ReportHeader1
        '
        Me.ReportHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtBranchName, Me.txtAdd2, Me.txtTel, Me.txtAdd1, Me.txtRegNo})
        Me.ReportHeader1.Height = 0.9479167!
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
        Me.txtBranchName.Width = 2.4375!
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
        Me.txtAdd2.Width = 2.4375!
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
        Me.txtTel.Width = 2.4375!
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
        Me.txtAdd1.Width = 2.4375!
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
        Me.txtRegNo.Width = 2.4375!
        '
        'ReportFooter1
        '
        Me.ReportFooter1.Height = 0.0!
        Me.ReportFooter1.Name = "ReportFooter1"
        '
        'rptHeader
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
        CType(Me.txtBranchName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdd2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRegNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents ReportHeader1 As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents ReportFooter1 As DataDynamics.ActiveReports.ReportFooter
    Friend WithEvents txtBranchName As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAdd2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTel As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAdd1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtRegNo As DataDynamics.ActiveReports.TextBox
End Class
