Imports DataAccess
Imports System.IO
Imports Utils
Imports Utils.General
Imports System.Globalization
Imports System.Text
Imports System.Threading
Imports System.Timers


Public Class frmConfig

    Const FORMTITLE = "Configuration"

    Private strfilenameOld As String
    Private strFilenameNew As String
    Private objDA As New DataAccessNut

    Private Sub frmConfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        AssignValue(gGetLocale(Me.Name, "title"), Me.Text)
        Messenger.Caption = Me.Text
        gSetLocaleChange(Me.Name, Me)

        CursorButtons(Me, Cursors.Hand)

        'Load price scheme
        With cboPrices
            .DropDownStyle = ComboBoxStyle.DropDownList

            .Items.Add("Price List")
            .Items.Add("Price Sale")
            .Items.Add("Price Disc1")
            .Items.Add("Price Disc2")
            .Items.Add("Price Disc3")

            If .Items.Count > 0 Then _
                .SelectedIndex = 0
        End With

        Load_cboBranch()
        Load_cboLocale()
        Load_cboPrinterSetup()

        Load_cboPrintableReceipt()
        Load_cboPrintableEndDayClosing()
        Load_cboPrintableStockSummarySold()
        LoadAppConfig()

        LockFields(txtHost, True)
        'LockFields(txtSyncBranch, True)
        'LockFields(txtWebService, True)
        'LockFields(txtSyncResult, True)

        txtSyncResult.ReadOnly = True
        txtSyncResult.Visible = False

        TextChangeEvent(Me)
        btnApply.Enabled = False

        lblStart.Text = ""
        lblEnd.Text = ""

        lblImportMsg.Text = ""
        lblExportMsg.Text = ""

    End Sub


    Private Sub TextChangeEvent(ByVal ctl As Control)
        For Each myControl As Control In ctl.Controls
            If (myControl.GetType Is GetType(System.Windows.Forms.TextBox) OrElse _
               myControl.GetType Is GetType(System.Windows.Forms.ComboBox) OrElse _
               myControl.GetType Is GetType(System.Windows.Forms.NumericUpDown) OrElse _
               myControl.GetType Is GetType(System.Windows.Forms.DateTimePicker)) AndAlso _
               myControl.Name <> "txtSyncResult" Then
                AddHandler myControl.TextChanged, AddressOf Text_TextChanged
            End If

            If myControl.GetType Is GetType(System.Windows.Forms.CheckBox) Then
                Dim chk As CheckBox = DirectCast(myControl, CheckBox)
                AddHandler chk.CheckedChanged, AddressOf Text_TextChanged
            End If

            TextChangeEvent(myControl)

        Next 'myControl
    End Sub


    Private Sub Load_cboBranch()

        Dim ds As DataSet = Nothing
        ds = objDA.GetAllBranch

        With cboBranches
            .DropDownStyle = ComboBoxStyle.DropDownList
            .DataSource = Nothing

            .DataSource = ds.Tables(0)
            .DisplayMember = "code"
            .ValueMember = "pkid"

            If .Items.Count > 0 Then _
                .SelectedIndex = 0
        End With

    End Sub

    Private Sub Load_cboLocale()

        Dim di As New DirectoryInfo(gResourcesPath)
        If Not di.Exists Then Exit Sub


        For Each diChild As DirectoryInfo In di.GetDirectories
            Try
                Dim ci As New CultureInfo(diChild.Name)
                cboLocale.Items.Add(ci)
            Catch ex As Exception
                WriteToLogFile(ex.Message)
            End Try
        Next
    End Sub

    Private Sub Load_cboPrinterSetup()
        cboPrinterSetup.Items.Add("STAR")
        cboPrinterSetup.Items.Add("EPSON")
    End Sub

    Private Sub Load_cboPrintableReceipt()
        Dim arr As ArrayList = GetPrintables(PrintingFormat.PrintingType.Receipt)
        cboPrintableReceipt.Items.AddRange(arr.ToArray)
    End Sub

    Private Sub Load_cboPrintableEndDayClosing()
        Dim arr As ArrayList = GetPrintables(PrintingFormat.PrintingType.DailySalesReport)
        cboPrintableDailySalesReport.Items.AddRange(arr.ToArray)
    End Sub

    Private Sub Load_cboPrintableStockSummarySold()
        Dim arr As ArrayList = GetPrintables(PrintingFormat.PrintingType.StockSummarySoldReport)
        cboPrintableStockSummarySoldReport.Items.AddRange(arr.ToArray)
    End Sub

    Private Function GetPrintables(ByVal type As PrintingFormat.PrintingType) As ArrayList
        Dim arr As New ArrayList
        Dim di As New DirectoryInfo(gReportPath)
        If Not di.Exists Then
            di.Create()
        End If

        ' convertion form enum to string
        'string name= Enum.GetName(typeof(ArrayListBinding.SortFilter), SortFilter.FirstName); 
        Dim startWith As String = [Enum].GetName(GetType(PrintingFormat.PrintingType), type).ToLower
        Dim isAdd As Boolean = False
        For Each fi As FileInfo In di.GetFiles
            Dim name As String = fi.Name
            isAdd = False
            If name.ToLower.StartsWith(startWith) AndAlso fi.Extension = ".rpx" Then
                'name = name.Replace(type, "")
                'If name.StartsWith("-") OrElse name.StartsWith("_") Then
                'name = name.Remove(0, 1)
                'End If
                isAdd = True
            End If

            If type = PrintingFormat.PrintingType.DailySalesReport Then
                If name.ToLower.Contains("_collection") Then
                    isAdd = False
                ElseIf name.ToLower.Contains("_summary") Then
                    isAdd = False
                End If
            End If

            If isAdd Then
                arr.Add(name)
            End If
        Next

        Return arr
    End Function

    Private Sub LoadAppConfig()

        ' Standard
        cboBranches.SelectedValue = gAppConfig.BranchId
        cboPrices.Text = gAppConfig.PriceSchema
        txtHost.Text = gAppConfig.Host
        txtWebService.Text = gAppConfig.WebService
        chkSelligBelowQty.Checked = gAppConfig.SellingBelowQty
        chkSelligBelowMinPrice.Checked = gAppConfig.SellingBelowMinPrice
        chkPriceIncludeTax.Checked = gAppConfig.PriceIncludeTax
        chkRemarksRequired.Checked = gAppConfig.RemarksRequiredDeletingItem
        chkAddNewLine.Checked = gAppConfig.AddNewLineDeletingItem
        chkDisallowUser.Checked = gAppConfig.DisallowUserToChangeSalesman
        chkApplyFiveCent.Checked = gAppConfig.ApplyFiveCentConcept
        txtItemCode.Text = gAppConfig.FiveCentItemCode

        ' Message Setup
        txtConfirmDelete.Text = gAppConfig.MsgDeleteConfirm
        txtConfirmTxn.Text = gAppConfig.MsgTxnConfirm
        txtConfirmVoid.Text = gAppConfig.MsgVoidConfirm

        txtSucceedDelete.Text = gAppConfig.MsgDeleteSucceed
        txtSucceedTxn.Text = gAppConfig.MsgTxnSucceed
        txtSucceedVoid.Text = gAppConfig.MsgVoidSucceed

        chkSucceedDelete.Checked = gAppConfig.MsgDeleteSucceedEnabled
        chkSucceedTxn.Checked = gAppConfig.MsgTxnSucceedEnabled
        chkSucceedVoid.Checked = gAppConfig.MsgVoidSucceedEnabled

        chkConfirmDelete.Checked = gAppConfig.MsgDeleteConfirmEnabled
        chkConfirmTxn.Checked = gAppConfig.MsgTxnConfirmEnabled
        chkConfirmVoid.Checked = gAppConfig.MsgVoidConfirmEnabled

        chkPaymentExceed.Checked = gAppConfig.MsgPaymentExceedEnabled
        txtPaymentExceed.Text = gAppConfig.MsgPaymentExceed

        ' Receipt Bottom Msg
        txtMsg1.Text = gAppConfig.MsgBottom1
        txtMsg2.Text = gAppConfig.MsgBottom2
        txtMsg3.Text = gAppConfig.MsgBottom3
        txtMsg4.Text = gAppConfig.MsgBottom4

        ' Others
        txtWelcome.Text = gAppConfig.MsgWelcome
        NumericUpDown1.Value = gAppConfig.MinHourEndDayClosing
        LoadPictureFromBlob(gAppConfig.LogoBlob, picLogo)
        Dim ci As New CultureInfo(gAppConfig.CurrentSystemLocale)
        cboLocale.SelectedItem = ci
        cboPrinterSetup.Text = gAppConfig.PrinterSetup

        ' Synchronization
        'txtSyncBranch.Text = cboBranches.Text
        'txtSyncWebService.Text = txtWebService.Text
        chkAutoSynchronize.Checked = gAppConfig.AutoSynchronize
        txtSyncerTiming.Text = gAppConfig.SyncerTiming
        btnUpload.Enabled = Not gAppConfig.AutoSynchronize

        ' Printable
        cboPrintableReceipt.Text = gAppConfig.PrintableReceipt
        cboPrintableDailySalesReport.Text = gAppConfig.PrintableDailySalesReport
        cboPrintableStockSummarySoldReport.Text = gAppConfig.PrintableStockSummarySoldReport

    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

        If btnApply.Enabled Then SaveConfig()

        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub txtPosNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = Utils.General.KeyPress("0123456789", True, e)
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        With OpenFileDialog1
            '.InitialDirectory = "C:\"
            .Filter = "All Files|*.*|Bitmaps|*.bmp|GIFs|*.gif|JPEGs|*.jpg"
            .FilterIndex = 4
        End With

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            LoadPicture(OpenFileDialog1.FileName, picLogo)
            'picLogo.Image = Image.FromFile(OpenFileDialog1.FileName)
            'picLogo.SizeMode = PictureBoxSizeMode.StretchImage
            'picLogo.BorderStyle = BorderStyle.Fixed3D
            strFilenameNew = OpenFileDialog1.FileName()
            btnApply.Enabled = True
        End If
    End Sub

    Private Sub btnGetBranch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtWebService.Text = "" Then
            Messenger.ShowWarning("The Web Service does not exist!")
            Exit Sub
        End If

        EnabledControls(False)
        Dim ws As New WebService(txtWebService.Text)
        Try
            AddHandler ws.Progress, AddressOf ws_Progress
            If ws.GetBranch() Then
                Messenger.ShowInformation("Get Branch Finished!")
                Load_cboBranch()
            Else
                Messenger.ShowError("Get Branch Error!")
            End If

        Catch ex As Exception
            Messenger.ShowError(ex)
        End Try
        EnabledControls(True)
    End Sub

    Private Sub EnabledControls(ByVal value As Boolean)
        'btnGetBranch.Enabled = value
        btnOk.Enabled = value
        btnCancel.Enabled = value
        'TabControl1.Enabled = value
        btnDownload.Enabled = value
        btnUpload.Enabled = value
        btnApply.Enabled = value

        If Not value Then
            DisableCloseButton(Me.Handle)
        End If
    End Sub

    Private Sub btnDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDownload.Click

        If txtWebService.Text = "" Then
            Messenger.ShowWarning("The Web Service does not exist!")
            Exit Sub
        End If

        If cboBranches.Text = "" Then
            Messenger.ShowWarning("The Branch does not exist!")
            Exit Sub
        End If

        Dim cursor As New WaitCursor
        EnabledControls(False)
        txtSyncResult.Visible = True
        strResult = vbCrLf & "Starting Downloading Database....."
        txtSyncResult.Text = strResult
        lblEnd.Text = ""
        Application.DoEvents()

        Dim ws As New WebService(txtWebService.Text)
        Try
            AddHandler ws.Progress, AddressOf ws_Progress
            '20100511 Jimmy: RISIS-92
            'lblStart.Text = FormatDateTime(Now)
            lblStart.Text = ws.GetServerTime()
            ws.GetFirst()
            'lblEnd.Text = FormatDateTime(Now)
            lblEnd.Text = ws.GetServerTime

            'txtSyncResult.AppendText(vbCrLf & "Downloading Database Finished!")
            txtSyncResult.Text = "Downloading Database Finished!" & vbCrLf & txtSyncResult.Text
            Messenger.ShowInformation("Downloading Database Finished!")

        Catch ex As Exception
            Messenger.ShowError(ex)
        End Try

        EnabledControls(True)
        cursor.Dispose()
    End Sub


    Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click

        If txtWebService.Text = "" Then
            Messenger.ShowWarning("The Web Service does not exist!")
            Exit Sub
        End If

        If cboBranches.Text = "" Then
            Messenger.ShowWarning("The Branch does not exist!")
            Exit Sub
        End If

        Dim cursor As New WaitCursor
        EnabledControls(False)
        txtSyncResult.Visible = True
        strResult = vbCrLf & "Starting Uploading Database....."
        txtSyncResult.Text = strResult
        lblEnd.Text = ""
        Application.DoEvents()

        Dim ws As New WebService(txtWebService.Text)
        Try
            AddHandler ws.Progress, AddressOf ws_Progress
            lblStart.Text = ws.GetServerTime()
            ws.Upload()
            lblEnd.Text = ws.GetServerTime

            'txtSyncResult.AppendText(vbCrLf & "Uploading Database Finished!")
            txtSyncResult.Text = "Uploading Database Finished!" & vbCrLf & txtSyncResult.Text
            Messenger.ShowInformation("Uploading Database Finished!")

        Catch ex As Exception
            Messenger.ShowError(ex)
        End Try

        EnabledControls(True)
        cursor.Dispose()
    End Sub


    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        SaveConfig()
        'txtSyncBranch.Text = cboBranches.Text
        txtWebService.Text = gAppConfig.WebService

        btnApply.Enabled = False
    End Sub

    Private Sub SaveConfig()

        If Not cboBranches.SelectedValue Is Nothing Then
            objDA.UpdatePosConfig("POS_CONFIG_BRANCH_ID", cboBranches.SelectedValue)
        End If

        objDA.UpdatePosConfig("POS_CONFIG_PRICE_SCHEMA", cboPrices.Text)
        'objDA.UpdatePosConfig("POS_CONFIG_HOST", txtHost.Text.Trim)
        objDA.UpdatePosConfig("POS_CONFIG_WEB_SERVICE", txtWebService.Text.Trim)

        objDA.UpdatePosConfig("POS_CONFIG_MSG_BOTTOM_1", txtMsg1.Text.Trim)
        objDA.UpdatePosConfig("POS_CONFIG_MSG_BOTTOM_2", txtMsg2.Text.Trim)
        objDA.UpdatePosConfig("POS_CONFIG_MSG_BOTTOM_3", txtMsg3.Text.Trim)
        objDA.UpdatePosConfig("POS_CONFIG_MSG_BOTTOM_4", txtMsg4.Text.Trim)

        objDA.UpdatePosConfig("POS_CONFIG_MSG_DELETE_CONFIRM", txtConfirmDelete.Text.Trim)
        objDA.UpdatePosConfig("POS_CONFIG_MSG_DELETE_SUCCEED", txtSucceedDelete.Text.Trim)
        objDA.UpdatePosConfig("POS_CONFIG_MSG_DELETE_CONFIRM_ENABLED", chkConfirmDelete.Checked.ToString)
        objDA.UpdatePosConfig("POS_CONFIG_MSG_DELETE_SUCCEED_ENABLED", chkSucceedDelete.Checked.ToString)

        objDA.UpdatePosConfig("POS_CONFIG_MSG_TXN_CONFIRM", txtConfirmTxn.Text.Trim)
        objDA.UpdatePosConfig("POS_CONFIG_MSG_TXN_SUCCEED", txtSucceedTxn.Text.Trim)
        objDA.UpdatePosConfig("POS_CONFIG_MSG_TXN_CONFIRM_ENABLED", chkConfirmTxn.Checked.ToString)
        objDA.UpdatePosConfig("POS_CONFIG_MSG_TXN_SUCCEED_ENABLED", chkSucceedTxn.Checked.ToString)

        objDA.UpdatePosConfig("POS_CONFIG_MSG_VOID_CONFIRM", txtConfirmVoid.Text.Trim)
        objDA.UpdatePosConfig("POS_CONFIG_MSG_VOID_SUCCEED", txtSucceedVoid.Text.Trim)
        objDA.UpdatePosConfig("POS_CONFIG_MSG_VOID_CONFIRM_ENABLED", chkConfirmVoid.Checked.ToString)
        objDA.UpdatePosConfig("POS_CONFIG_MSG_VOID_SUCCEED_ENABLED", chkSucceedVoid.Checked.ToString)

        objDA.UpdatePosConfig("POS_CONFIG_MSG_PAYMENT_EXCEED", txtPaymentExceed.Text.Trim)
        objDA.UpdatePosConfig("POS_CONFIG_MSG_PAYMENT_EXCEED_ENABLED", chkPaymentExceed.Checked.ToString)

        objDA.UpdatePosConfig("POS_CONFIG_MSG_WELCOME", txtWelcome.Text.Trim)
        objDA.UpdatePosConfig("POS_CONFIG_SYNCER_TIMING", txtSyncerTiming.Text.Trim)
        objDA.UpdatePosConfig("POS_CONFIG_MIN_HOUR_END_DAY_CLOSING", NumericUpDown1.Value)

        objDA.UpdatePosConfig("POS_CONFIG_SELLING_BELOW_QTY", chkSelligBelowQty.Checked.ToString)
        objDA.UpdatePosConfig("POS_CONFIG_SELLING_BELOW_MIN_PRICE", chkSelligBelowMinPrice.Checked.ToString)

        If strFilenameNew <> "" Then

            'picLogo.Image = Nothing
            'If File.Exists(strfilenameOld) Then
            '    'Try
            '    File.Delete(strfilenameOld)
            '    'Catch ex As Exception

            '    'End Try

            'End If
            Try
                Dim fs As New FileStream(strFilenameNew, FileMode.Open, FileAccess.Read)
                Dim rawData() As Byte = New Byte(fs.Length) {}
                fs.Read(rawData, 0, fs.Length)
                fs.Close()

                objDA.UpdatePosConfigContentFile("POS_CONFIG_LOGO", Path.GetFileName(strFilenameNew), rawData)

            Catch ex As Exception
                Messenger.Caption = Me.Text & " - Update Logo Fails"
                Messenger.ShowError(ex)
            End Try
            'Try
            '    File.Copy(strFilenameNew, Path.Combine(Application.StartupPath, Path.GetFileName(strFilenameNew)), True)
            'Catch ex As Exception
            '    WriteToLogFile("Error: " & ex.Message)
            'End Try


        End If

        objDA.UpdatePosConfig("POS_CONFIG_AUTO_SYNCHRONIZE", chkAutoSynchronize.Checked.ToString)
        objDA.UpdatePosConfig("POS_CONFIG_PRICE_INCLUDE_TAX", chkPriceIncludeTax.Checked.ToString)

        objDA.UpdatePosConfig("POS_CONFIG_REMARKS_REQUIRED_DELETING_ITEM", chkRemarksRequired.Checked.ToString)
        objDA.UpdatePosConfig("POS_CONFIG_ADD_NEW_LINE_DELETING_ITEM", chkAddNewLine.Checked.ToString)
        objDA.UpdatePosConfig("POS_CONFIG_DISALLOW_USER_TO_CHANGE_SALESMAN", chkDisallowUser.Checked.ToString)

        Dim ci As CultureInfo = DirectCast(cboLocale.SelectedItem, CultureInfo)
        If Not ci Is Nothing Then
            objDA.UpdatePosConfig("POS_CONFIG_CURRENT_SYSTEM_LOCALE", ci.Name)
        End If

        objDA.UpdatePosConfig("POS_CONFIG_PRINTABLE_RECEIPT", cboPrintableReceipt.Text)
        objDA.UpdatePosConfig("POS_CONFIG_PRINTABLE_DAILY_SALES_REPORT", cboPrintableDailySalesReport.Text)
        objDA.UpdatePosConfig("POS_CONFIG_PRINTABLE_STOCK_SUMMARY_SOLD_REPORT", cboPrintableStockSummarySoldReport.Text)

        objDA.UpdatePosConfig("POS_CONFIG_PRINTER_SETUP", cboPrinterSetup.Text)

        objDA.UpdatePosConfig("POS_CONFIG_APPLY_FIVE_CENT_CONCEPT", chkApplyFiveCent.Checked.ToString)
        objDA.UpdatePosConfig("POS_CONFIG_FIVE_CENT_ITEM_CODE", txtItemCode.Text)

        'Reload config
        gLoadAppConfig()

        'get branch
        gBranchObj = objDA.GetBranch(gAppConfig.BranchId)

    End Sub

    Dim strName As String = ""
    Dim strResult As String = ""

    Public Sub ws_Progress(ByVal totalRecord As Integer, ByVal name As String)
        Application.DoEvents()
        If strName <> name And strName <> "" Then
            'txtSyncResult.AppendText(vbCrLf)
            txtSyncResult.Text = vbCrLf & txtSyncResult.Text
            strResult = txtSyncResult.Text
        End If
        txtSyncResult.Text = name & ": " & totalRecord & strResult
        strName = name
    End Sub

    Private Sub txtSyncResult_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSyncResult.TextChanged
        'txtSyncResult.SelectionStart = Len(txtSyncResult.Text)
        'txtSyncResult.SelectionLength = 0
    End Sub

    Private Sub Text_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        btnApply.Enabled = True
    End Sub


    Private Sub btnRetrieve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetrieve.Click

        With SaveFileDialog1
            '.InitialDirectory = "C:\"
            .Filter = "All Files|*.*|Bitmaps|*.bmp|GIFs|*.gif|JPEGs|*.jpg"
            .FilterIndex = 4
            .FileName = gAppConfig.Logo
        End With

        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            Try

                Dim cf As Byte() = objDA.GetPosConfigContentFile("POS_CONFIG_LOGO")
                Dim K As Long
                K = UBound(cf)

                Dim WriteFs As New FileStream(SaveFileDialog1.FileName, FileMode.Create, FileAccess.Write)
                WriteFs.Write(cf, 0, K)
                WriteFs.Close()

            Catch ex As Exception
                Messenger.ShowError(ex)
            End Try

        End If


    End Sub

    Private Sub chkAutoSynchronize_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAutoSynchronize.CheckedChanged
        btnUpload.Enabled = Not chkAutoSynchronize.Checked
    End Sub

#Region "Import And Export"

    Private Sub btnBrowseImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseImport.Click
        Dim dlg As New OpenFileDialog
        dlg.RestoreDirectory = True
        dlg.Filter = "SQL File (*.sql) |*.sql|All Files (*.*) |*.*"

        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtImportFile.Text = dlg.FileName
        End If
    End Sub

    Dim Thread1 As System.Threading.Thread
    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        Dim strFile As String = txtImportFile.Text.Trim
        If strFile.Length = 0 Then Exit Sub

        Try

            Dim fi As New FileInfo(strFile)
            If Not fi.Exists Then
                Messenger.ShowWarning("The file '" & fi.Name & "' does not exist!")
                Exit Sub
            End If

            'lblImportMsg.Text = "Import in progress. Please wait...."
            Timer1.Enabled = True
            ticks = 0

            Thread1 = New System.Threading.Thread(AddressOf ImportSQL)
            Thread1.Start()

        Catch ex As Exception
            Messenger.ShowError(ex)
            Timer1.Enabled = False
        End Try

    End Sub

    Private Sub ImportSQL()

        Dim file As String = txtImportFile.Text
        Dim sb As New StringBuilder
        Dim oReader As New StreamReader(file)

        Try

            While Not oReader.EndOfStream
                sb.Append(oReader.ReadToEnd())
            End While
            oReader.Close()

            Dim comm As New Commands
            comm.ExecuteNonQuery(sb.ToString)

            Timer1.Enabled = False
            Messenger.ShowInformation(gMSG_IMPORT_SUCCESSFULLY)

        Catch ex As Exception
            Timer1.Enabled = False
            Messenger.ShowError(ex)

        End Try

        Thread1.Abort()

    End Sub

    Dim ticks As Integer
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ticks += 1
        lblImportMsg.Text = String.Format("Import in progress. Please wait.....{0} seconds.", ticks)
    End Sub


    Private Sub btnBrowseExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseExport.Click
        Dim dlg As New SaveFileDialog
        dlg.RestoreDirectory = True
        dlg.RestoreDirectory = True
        dlg.Filter = "CSV File (*.csv) |*.csv|All Files (*.*) |*.*"

        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtExportFile.Text = dlg.FileName
        End If

    End Sub


    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        Dim strFile As String = txtExportFile.Text.Trim
        If strFile.Length = 0 Then Exit Sub

        Try

            'lblExportMsg.Text = "Export in progress. Please wait...."
            Timer2.Enabled = True
            ticks2 = 0

            'Timer3.Enabled = True

            Thread1 = New System.Threading.Thread(AddressOf ExportSQL)
            Thread1.Start()

        Catch ex As Exception
            Timer2.Enabled = False
            Messenger.ShowError(ex)

        End Try

    End Sub


    Private Sub ExportSQL()

        Dim file As String = txtExportFile.Text
        'Dim sb As New StringBuilder
        Dim ds As New DataSet
        'Dim oWriter As StreamWriter

        Try

            If chkDate.Checked Then
                ds = objDA.GetTCTxQueueByDate(dtpDateFrom.Value, dtpDateTo.Value)
            Else
                ds = objDA.GetTCTxQueueByStatus(DATCTxQueue.STATUS_PENDING)
            End If


            If ds.Tables.Count = 0 Then Exit Sub
            If ds.Tables(0).Rows.Count = 0 Then
                Timer2.Enabled = False                
                'Timer3.Enabled = True
                Messenger.ShowInformation(gMSG_NO_EXPORT_TRANSACTIONS)
            Else
                'sb.Append(gGetInsertStatementString(ds.Tables(0), DATCTxQueue.TABLENAME))
                'oWriter = New StreamWriter(file, False)
                'oWriter.Write(sb.ToString)
                'oWriter.Close()
                'oWriter.Dispose()

                gSetDataTableToCSV(ds.Tables(0), file, ",")

                For Each dr As DataRow In ds.Tables(0).Rows
                    Dim pkid As Long = dr(DATCTxQueue.PKID)
                    objDA.UpdateTCTxQueueByStatus(pkid.ToString, DATCTxQueue.STATUS_EXPORT)
                Next

                Timer2.Enabled = False                
                'Timer3.Enabled = True
                Messenger.ShowInformation(gMSG_EXPORT_SUCCESSFULLY)

            End If

        Catch ex As Exception
            Timer2.Enabled = False
            'Timer3.Enabled = True
            Messenger.ShowError(ex)            
        End Try

        Thread1.Abort()

    End Sub

    Dim ticks2 As Integer
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ticks2 += 1
        lblExportMsg.Text = String.Format("Export in progress. Please wait.....{0} seconds.", ticks2)
    End Sub

    Private Sub chkDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDate.CheckedChanged
        dtpDateFrom.Enabled = chkDate.Checked
        dtpDateTo.Enabled = chkDate.Checked
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        lblImportMsg.Text = ""
        lblExportMsg.Text = ""
        Timer3.Enabled = False
    End Sub

#End Region

   
    
End Class

