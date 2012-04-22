Imports Utils
Imports Utils.General

Public Class frmPreview

    'Public doc As DataDynamics.ActiveReports.Document.Document
    Public rpt As DataDynamics.ActiveReports.ActiveReport3

    Private Sub frmPreview_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        AssignValue(gGetLocale(Me.Name, "title"), Me.Text)
        Messenger.Caption = Me.Text
        gSetLocaleChange(Me.Name, Me)

        arvMain.Document = rpt.Document

        ' add custom buttons to the viewer's toolbar
        Dim icoSave As Icon = My.Resources.Save16x16
        Dim icoExport As Icon = My.Resources.Export16x16
        Dim icoPrint As Image = My.Resources.Print_32x32
        arvMain.Toolbar.Images.Images.Add(icoSave)
        arvMain.Toolbar.Images.Images.Add(icoExport)
        arvMain.Toolbar.Images.Images.Add(icoPrint)

        'Add Save button to the toolbar
        Dim _btn As New DataDynamics.ActiveReports.Toolbar.Button
        _btn.ImageIndex = 14 ' new images were added to Toolbar.Images 
        _btn.ButtonStyle = DataDynamics.ActiveReports.Toolbar.ButtonStyle.Icon
        _btn.Caption = "Save"
        _btn.Id = 5001 ' unique identifier for the new tool
        _btn.ToolTip = "Save Report Document"
        arvMain.Toolbar.Tools.Insert(1, CType(_btn, DataDynamics.ActiveReports.Toolbar.Tool))

        'Add Export button to the toolbar
        _btn = New DataDynamics.ActiveReports.Toolbar.Button
        _btn.ImageIndex = 15
        _btn.Id = 5002
        _btn.ButtonStyle = DataDynamics.ActiveReports.Toolbar.ButtonStyle.Icon
        _btn.Caption = "Export"
        _btn.ToolTip = "Export Report Document"
        arvMain.Toolbar.Tools.Insert(2, CType(_btn, DataDynamics.ActiveReports.Toolbar.Tool))

        'Add Export button to the toolbar
        '_btn = New DataDynamics.ActiveReports.Toolbar.Button
        '_btn.ImageIndex = 16
        '_btn.Id = 5003
        '_btn.ButtonStyle = DataDynamics.ActiveReports.Toolbar.ButtonStyle.Icon
        '_btn.Caption = "Print"
        '_btn.ToolTip = "Print Report Document"
        'arvMain.Toolbar.Tools.Insert(3, CType(_btn, DataDynamics.ActiveReports.Toolbar.Tool))

        'arvMain.Toolbar.Tools
    End Sub


    Private Sub arvMain_ToolClick(ByVal sender As Object, ByVal e As DataDynamics.ActiveReports.Toolbar.ToolClickEventArgs) Handles arvMain.ToolClick
        'Add code to run when new buttons are clicked
        Try
            Select Case e.Tool.Id
                Case 5001 'Save button
                    Me.SaveDocument()
                Case 5002 'Export button
                    Me.ExportDocument()
                Case 5003
                    arvMain.Document.Print()
                    'arvMain.Document.Print()
            End Select
        Catch exp As System.IO.IOException
            MessageBox.Show(exp.ToString())
        End Try
    End Sub

    'Saves out an existing report document to the RDF format.
    Private Sub SaveDocument()
        Dim _dlgSave As New SaveFileDialog
        _dlgSave.Title = "Save Report Document"
        _dlgSave.Filter = "Report Document Files (*.rdf)|*.rdf"
        _dlgSave.DefaultExt = "rdf"
        _dlgSave.AddExtension = True
        If _dlgSave.ShowDialog(Me) = DialogResult.OK Then
            If System.IO.File.Exists(_dlgSave.FileName) Then
                If MessageBox.Show(Me, "Overwrite Existing File?", "Overwrite", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                    Return
                End If
            End If
            arvMain.Document.Save(_dlgSave.FileName)
        End If
    End Sub 'SaveDocument


    'Opens the export form to export out the current report document
    Private Sub ExportDocument()
        Dim _exportForm As New frmExport(arvMain.Document)
        _exportForm.ShowDialog(Me)
    End Sub 'ExportDocument


    'mnuExport_Click - called the ExportDocument() call to export out the
    'current report document
    Private Sub mnuExport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuExport.Click
        Me.ExportDocument()
    End Sub 'mnuExport_Click


    'mnuSaveDocument_Click - called the SaveDocument() call to save the 
    'current report document to the RDF format.
    Private Sub mnuSaveDocument_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuSaveDocument.Click
        Me.SaveDocument()
    End Sub 'mnuSaveDocument_Click


    'mnuPrinterSetup_Click - opens the Printer Dialog box to assist in
    'printer setup.
    Private Sub mnuPrinterSetup_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuPrinterSetup.Click
        If Not (Me.arvMain.Document Is Nothing) Then
            Me.dlgPrint.Document = Me.arvMain.Document.Printer
            dlgPrint.ShowDialog(Me)
        End If

    End Sub 'mnuPrinterSetup_Click

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        If Not (Me.arvMain.Document Is Nothing) Then
            Me.PageSetupDialog1.Document = rpt.Document.Printer
            With Me.PageSetupDialog1.PageSettings
                .Margins.Bottom = rpt.PageSettings.Margins.Bottom
                .Margins.Top = rpt.PageSettings.Margins.Top
                .Margins.Left = rpt.PageSettings.Margins.Left
                .Margins.Right = rpt.PageSettings.Margins.Right
                .Landscape = rpt.Document.Printer.Landscape

            End With
            '
            If PageSetupDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then

                With rpt.PageSettings
                    .Margins.Bottom = Me.PageSetupDialog1.PageSettings.Margins.Bottom
                    .Margins.Top = Me.PageSetupDialog1.PageSettings.Margins.Top
                    .Margins.Left = Me.PageSetupDialog1.PageSettings.Margins.Left
                    .Margins.Right = Me.PageSetupDialog1.PageSettings.Margins.Right
                    rpt.Document.Printer.Landscape = Me.PageSetupDialog1.PageSettings.Landscape
                End With

                'rpt.Restart()
                'rpt.Run(True)
                'Me.arvMain.Document = rpt.Document
                'Me.arvMain.Invalidate()
                'Me.arvMain.Update()
                'Me.arvMain.PerformLayout()
                'Me.arvMain.ReportViewer.Refresh()

            End If
        End If
    End Sub
End Class