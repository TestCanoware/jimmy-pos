<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreview
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.mnuMain = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem
        Me.mnuExport = New System.Windows.Forms.MenuItem
        Me.mnuSaveDocument = New System.Windows.Forms.MenuItem
        Me.mnuPrinterSetup = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.dlgPrint = New System.Windows.Forms.PrintDialog
        Me.arvMain = New DataDynamics.ActiveReports.Viewer.Viewer
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuExport, Me.mnuSaveDocument, Me.mnuPrinterSetup, Me.MenuItem1})
        Me.mnuFile.MergeType = System.Windows.Forms.MenuMerge.MergeItems
        Me.mnuFile.Text = "&File"
        '
        'mnuExport
        '
        Me.mnuExport.Index = 0
        Me.mnuExport.Text = "Export..."
        '
        'mnuSaveDocument
        '
        Me.mnuSaveDocument.Index = 1
        Me.mnuSaveDocument.Text = "Save..."
        '
        'mnuPrinterSetup
        '
        Me.mnuPrinterSetup.Index = 2
        Me.mnuPrinterSetup.Text = "Printer Setup..."
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 3
        Me.MenuItem1.Text = "Page Setup"
        Me.MenuItem1.Visible = False
        '
        'arvMain
        '
        Me.arvMain.BackColor = System.Drawing.SystemColors.Control
        Me.arvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.arvMain.Document = New DataDynamics.ActiveReports.Document.Document("ARNet Document")
        Me.arvMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arvMain.Location = New System.Drawing.Point(0, 0)
        Me.arvMain.Margin = New System.Windows.Forms.Padding(0)
        Me.arvMain.Name = "arvMain"
        Me.arvMain.ReportViewer.CurrentPage = 0
        Me.arvMain.ReportViewer.MultiplePageCols = 1
        Me.arvMain.ReportViewer.MultiplePageRows = 1
        Me.arvMain.ReportViewer.ViewType = DataDynamics.ActiveReports.Viewer.ViewType.Normal
        Me.arvMain.Size = New System.Drawing.Size(586, 502)
        Me.arvMain.TabIndex = 1
        Me.arvMain.TableOfContents.Text = "Contents"
        Me.arvMain.TableOfContents.Width = 200
        Me.arvMain.TabTitleLength = 35
        Me.arvMain.Toolbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'frmPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 502)
        Me.Controls.Add(Me.arvMain)
        Me.Menu = Me.mnuMain
        Me.Name = "frmPreview"
        Me.Text = "Report Preview"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents mnuMain As System.Windows.Forms.MainMenu
    Private WithEvents mnuFile As System.Windows.Forms.MenuItem
    Private WithEvents mnuExport As System.Windows.Forms.MenuItem
    Private WithEvents mnuSaveDocument As System.Windows.Forms.MenuItem
    Private WithEvents mnuPrinterSetup As System.Windows.Forms.MenuItem
    Private WithEvents dlgPrint As System.Windows.Forms.PrintDialog
    Private WithEvents arvMain As DataDynamics.ActiveReports.Viewer.Viewer
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
End Class
