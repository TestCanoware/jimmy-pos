Imports Utils
Imports Utils.General
Imports DataAccess
Imports System.Text
Imports System.Resources
Imports System.Threading
Imports System.Globalization
Imports System.IO

Module modGlobal

    Public Const gSTART_DATE = "2001-01-01"
    Public Const gMSG_ITEM_NOT_FOUND = "Item not found or below qty!"
    Public Const gMSG_LOGOUT = "Are you sure to Logout the system?"
    Public Const gMSG_CHECK_CURRENT_DATE = "Please check the current date and time!"
    Public Const gMSG_LOGIN_NOT_SUCCEED = "You could not be authenticated!"
    Public Const gMSG_ENTER_REMARKS = "Please enter the remarks!"
    Public Const gMSG_REMOVE_DEPOSIT = "Are you sure to remove selected records?"
    Public Const gMSG_REFUND = "Do you want to refund?"
    Public Const gMSG_TRANSACTION_EXIST = "Transaction exist!"
    Public Const gMSG_TRANSACTION_NOT_EXIST = "No Transaction exist!"
    Public Const gMSG_AUTO_SYNC = "Auto Synchronize exist!"
    Public Const gMSG_EXCHANGE_ITEM_PIRCE = "The exchanged item's price needs to be equal or less than of this transaction's"
    Public Const gMSG_HELD_ITEMS_DETECTED = "Held items detected!"
    Public Const gMSG_IMPORT_SUCCESSFULLY = "Import successfully!"
    Public Const gMSG_EXPORT_SUCCESSFULLY = "Export successfully!"
    Public Const gMSG_NO_EXPORT_TRANSACTIONS = "All transactions has been exported, there's no more transactions pending export!"

    'Public Const gMSG_NEW_DEPOSIT = "Are you sure to Create New Deposit?"
    Public Const gAPP_KEY_THICK_CLIENT_IS_INSTALL = "ThickClientIsInstall"

    Private objDA As New DataAccessNut
    Public gUserObj As New DAUserObject
    Public gBranchObj As New DABranchObject
    Public gPosEndDayClosingObj As New DAPosEndDayClosingObject
    Public gPosLoginObj As New DAPosLoginObject
    Public gAppConfig As AppConfig
    Public gSysConfig As Utils.SysConfig

    Public gCurrentTotalBill As Integer = 0
    Public gConnectWS As Boolean = False
    Public gFrmScreenKeyboard As frmScreenKeyboard
    'Public gFrmScreenKeyboard As Form1
    Public gDefaultCustAcc As Integer = 500

    Private Thread1 As System.Threading.Thread
    Private Thread2 As System.Threading.Thread

    Public gResourcesPath As String = Path.Combine(Application.StartupPath, "resources")
    Public gReportPath As String = Path.Combine(Application.StartupPath, "reports")

    Public gIsSyncProcessing As Boolean = False
    Public gComPort As New Rs232()

    Public Structure Permission

        Public id As Integer
        Public Const VoidReceipt As String = "pos_perm_void_receipt"
        Public Const CashIn As String = "pos_perm_cash_in"
        Public Const CashOut As String = "pos_perm_cash_out"
        Public Const Config As String = "pos_perm_config"
        Public Const Report As String = "pos_perm_view_reports"
        Public Const DeleteItem As String = "pos_perm_delete_item"
        Public Const CancelSale As String = "pos_perm_cancel_sale"

    End Structure

    Public Structure AppConfig

        ' Standard
        Public BranchId As Integer
        Public PriceSchema As String
        Public Host As String
        Public WebService As String
        Public SellingBelowQty As Boolean
        Public SellingBelowMinPrice As Boolean
        Public PriceIncludeTax As Boolean
        Public RemarksRequiredDeletingItem As Boolean
        Public AddNewLineDeletingItem As Boolean
        Public DisallowUserToChangeSalesman As Boolean
        Public ApplyFiveCentConcept As Boolean
        Public FiveCentItemCode As String

        ' Message Setup
        Public MsgTxnConfirmEnabled As Boolean
        Public MsgTxnConfirm As String
        Public MsgDeleteConfirmEnabled As Boolean
        Public MsgDeleteConfirm As String
        Public MsgVoidConfirmEnabled As Boolean
        Public MsgVoidConfirm As String
        Public MsgTxnSucceedEnabled As Boolean
        Public MsgTxnSucceed As String
        Public MsgDeleteSucceedEnabled As Boolean
        Public MsgDeleteSucceed As String
        Public MsgVoidSucceedEnabled As Boolean
        Public MsgVoidSucceed As String
        Public MsgPaymentExceed As String
        Public MsgPaymentExceedEnabled As Boolean

        ' Receipt Bottom Msg
        Public MsgBottom1 As String
        Public MsgBottom2 As String
        Public MsgBottom3 As String
        Public MsgBottom4 As String

        ' Synchronization
        Public AutoSynchronize As Boolean
        Public SyncerTiming As String

        ' Others
        Public MsgWelcome As String
        Public Logo As String
        Public LogoBlob As Byte()
        Public MinHourEndDayClosing As String
        Public CurrentSystemLocale As String

        ' Printable
        Public PrintableReceipt As String
        Public PrintableDailySalesReport As String
        Public PrintableStockSummarySoldReport As String
        Public PrinterSetup As String

    End Structure


    Public Sub gLoadAppConfig()

        With gAppConfig
            ' Standard
            .BranchId = IIf(objDA.GetPosConfig("POS_CONFIG_BRANCH_ID") = "", 1, objDA.GetPosConfig("POS_CONFIG_BRANCH_ID"))
            .PriceSchema = objDA.GetPosConfig("POS_CONFIG_PRICE_SCHEMA")
            .Host = gSysConfig.Server  'System.Configuration.ConfigurationManager.AppSettings("connectMySQL") 'objDA.getPosConfig("POS_CONFIG_HOST")
            .WebService = objDA.GetPosConfig("POS_CONFIG_WEB_SERVICE")
            .SellingBelowQty = IIf(objDA.GetPosConfig("POS_CONFIG_SELLING_BELOW_QTY").ToUpper = "TRUE", True, False)
            .SellingBelowMinPrice = IIf(objDA.GetPosConfig("POS_CONFIG_SELLING_BELOW_MIN_PRICE").ToUpper = "TRUE", True, False)
            .PriceIncludeTax = IIf(objDA.GetPosConfig("POS_CONFIG_PRICE_INCLUDE_TAX").ToUpper = "TRUE", True, False)
            .RemarksRequiredDeletingItem = IIf(objDA.GetPosConfig("POS_CONFIG_REMARKS_REQUIRED_DELETING_ITEM").ToUpper = "TRUE", True, False)
            .AddNewLineDeletingItem = IIf(objDA.GetPosConfig("POS_CONFIG_ADD_NEW_LINE_DELETING_ITEM").ToUpper = "TRUE", True, False)
            .DisallowUserToChangeSalesman = IIf(objDA.GetPosConfig("POS_CONFIG_DISALLOW_USER_TO_CHANGE_SALESMAN").ToUpper = "TRUE", True, False)
            .ApplyFiveCentConcept = IIf(objDA.GetPosConfig("POS_CONFIG_APPLY_FIVE_CENT_CONCEPT").ToUpper = "TRUE", True, False)
            .FiveCentItemCode = objDA.GetPosConfig("POS_CONFIG_FIVE_CENT_ITEM_CODE")

            ' Message Setup
            .MsgDeleteConfirm = objDA.GetPosConfig("POS_CONFIG_MSG_DELETE_CONFIRM")
            .MsgDeleteSucceed = objDA.GetPosConfig("POS_CONFIG_MSG_DELETE_SUCCEED")
            .MsgDeleteConfirmEnabled = IIf(objDA.GetPosConfig("POS_CONFIG_MSG_DELETE_CONFIRM_ENABLED").ToUpper = "TRUE", True, False)
            .MsgDeleteSucceedEnabled = IIf(objDA.GetPosConfig("POS_CONFIG_MSG_DELETE_SUCCEED_ENABLED").ToUpper = "TRUE", True, False)

            .MsgTxnConfirm = objDA.GetPosConfig("POS_CONFIG_MSG_TXN_CONFIRM")
            .MsgTxnSucceed = objDA.GetPosConfig("POS_CONFIG_MSG_TXN_SUCCEED")
            .MsgTxnConfirmEnabled = IIf(objDA.GetPosConfig("POS_CONFIG_MSG_TXN_CONFIRM_ENABLED").ToUpper = "TRUE", True, False)
            .MsgTxnSucceedEnabled = IIf(objDA.GetPosConfig("POS_CONFIG_MSG_TXN_SUCCEED_ENABLED").ToUpper = "TRUE", True, False)

            .MsgVoidConfirm = objDA.GetPosConfig("POS_CONFIG_MSG_VOID_CONFIRM")
            .MsgVoidSucceed = objDA.GetPosConfig("POS_CONFIG_MSG_VOID_SUCCEED")
            .MsgVoidConfirmEnabled = IIf(objDA.GetPosConfig("POS_CONFIG_MSG_VOID_CONFIRM_ENABLED").ToUpper = "TRUE", True, False)
            .MsgVoidSucceedEnabled = IIf(objDA.GetPosConfig("POS_CONFIG_MSG_VOID_SUCCEED_ENABLED").ToUpper = "TRUE", True, False)

            .MsgPaymentExceed = objDA.GetPosConfig("POS_CONFIG_MSG_PAYMENT_EXCEED")
            .MsgPaymentExceedEnabled = IIf(objDA.GetPosConfig("POS_CONFIG_MSG_PAYMENT_EXCEED_ENABLED").ToUpper = "TRUE", True, False)

            ' Receipt Bottom Msg
            .MsgBottom1 = objDA.GetPosConfig("POS_CONFIG_MSG_BOTTOM_1")
            .MsgBottom2 = objDA.GetPosConfig("POS_CONFIG_MSG_BOTTOM_2")
            .MsgBottom3 = objDA.GetPosConfig("POS_CONFIG_MSG_BOTTOM_3")
            .MsgBottom4 = objDA.GetPosConfig("POS_CONFIG_MSG_BOTTOM_4")

            ' Others
            .MsgWelcome = objDA.GetPosConfig("POS_CONFIG_MSG_WELCOME")
            .Logo = objDA.GetPosConfig("POS_CONFIG_LOGO")
            .LogoBlob = objDA.GetPosConfigContentFile("POS_CONFIG_LOGO")
            .MinHourEndDayClosing = IIf(objDA.GetPosConfig("POS_CONFIG_MIN_HOUR_END_DAY_CLOSING") = "", "12", objDA.GetPosConfig("POS_CONFIG_MIN_HOUR_END_DAY_CLOSING"))
            .CurrentSystemLocale = objDA.GetPosConfig("POS_CONFIG_CURRENT_SYSTEM_LOCALE")

            ' Synchronization
            .SyncerTiming = IIf(objDA.GetPosConfig("POS_CONFIG_SYNCER_TIMING") = "", "5000", objDA.GetPosConfig("POS_CONFIG_SYNCER_TIMING"))
            .AutoSynchronize = IIf(objDA.GetPosConfig("POS_CONFIG_AUTO_SYNCHRONIZE").ToUpper = "TRUE", True, False)

            ' Printable
            .PrintableReceipt = objDA.GetPosConfig("POS_CONFIG_PRINTABLE_RECEIPT")
            .PrintableDailySalesReport = objDA.GetPosConfig("POS_CONFIG_PRINTABLE_DAILY_SALES_REPORT")
            .PrintableStockSummarySoldReport = objDA.GetPosConfig("POS_CONFIG_PRINTABLE_STOCK_SUMMARY_SOLD_REPORT")
            ' 20100507 Jimmy
            Dim value As String = objDA.GetPosConfig("POS_CONFIG_PRINTER_SETUP")
            If value = "" Then
                value = "STAR"
                objDA.UpdatePosConfig("POS_CONFIG_PRINTER_SETUP", value)
            End If
            .PrinterSetup = value
            ' End 20100507 Jimmy

            gSetCulture()

        End With

    End Sub


    Public Function gLoadPermission(ByVal permission As String) As Boolean
        If gUserObj.username.ToUpper = "DEVELOPER" Then Return True

        'Dim frm As New frmUserPassword
        'frm.permission = permission

        'If frm.ShowDialog = DialogResult.Yes Then Return True

        'Return False
        Return True

    End Function

    Public Sub gShowReport(ByVal report As DataDynamics.ActiveReports.ActiveReport3, ByVal directPrint As Boolean)
        Dim myCursor As New WaitCursor
        Dim rptHeader As New DataDynamics.ActiveReports.ActiveReport3

        Try

            Select Case gAppConfig.PrintableReceipt
                Case "itKakimotor"
                    'gShowReport(New rptReceipt_itKakimotor(invoiceId, pay, change, isCard))

                Case "itKakimotor001"
                    'gShowReport(New rptReceipt_itKakimotor001(invoiceId, pay, change, isCard))

                Case "FOTOZZOOM"
                    rptHeader = New rptHeader_Fotozzoom()

                Case Else
                    rptHeader = New rptHeader
            End Select

            'rptHeader = New rptHeader
            'report.SetLicense("JOHKUFOO8FJ48SKO9HF7")

            'Get subReport
            'myControl.GetType Is GetType(System.Windows.Forms.TextBox)

            Dim section As DataDynamics.ActiveReports.Section = report.Sections(0)
            For Each ctl As DataDynamics.ActiveReports.ARControl In section.Controls
                If ctl.GetType Is GetType(DataDynamics.ActiveReports.SubReport) Then
                    Dim srpt As DataDynamics.ActiveReports.SubReport = DirectCast(ctl, DataDynamics.ActiveReports.SubReport)
                    srpt.Report = rptHeader
                    srpt.Report.PageSettings.Margins.Left = 0
                    srpt.Report.PageSettings.Margins.Right = 0
                    srpt.Report.PageSettings.Margins.Top = 0
                    srpt.Report.PageSettings.Margins.Bottom = 0
                End If
            Next

            ' Create a new instance of the viewer form, pass document and parent form
            report.PageSettings.Margins.Left = gSysConfig.LeftMargin
            report.PageSettings.Margins.Right = gSysConfig.RightMargin
            report.PageSettings.Margins.Top = gSysConfig.TopMargin
            report.PageSettings.Margins.Bottom = gSysConfig.BottomMargin
            report.Run(True)

            If directPrint Then
                report.Document.Print(False, False, True)
            Else
                Dim viewerForm As New frmPreview()
                viewerForm.rpt = report
                viewerForm.ShowDialog()
            End If

        Catch ex As System.Exception
            Messenger.Caption = "Printable Error"
            Messenger.ShowError(ex.Message)

        Finally
            myCursor.Dispose()
        End Try


    End Sub

    Public Sub gRunWebService()
        Dim ws As New WebService(gAppConfig.WebService)
        Dim isSync As Boolean = False

        While (True)
            Try
                Threading.Thread.Sleep(gAppConfig.SyncerTiming)
                ws.address = gAppConfig.WebService
                If isSync = False Then
                    isSync = True
                    If gAppConfig.AutoSynchronize Then
                        ws.GetAll()
                    Else
                        ws.MakeConnection()
                    End If
                    gConnectWS = ws.isConnected
                    isSync = False
                End If

            Catch ex As Exception
                DebugPrint("Error gRunWebService: " & ex.Message)
                gConnectWS = False
                isSync = False
            End Try

        End While
    End Sub

    Public Sub gRunWebServiceManually()
        Dim ws As New WebService(gAppConfig.WebService)

        Try
            ws.address = gAppConfig.WebService
            ws.GetAll()

            Messenger.ShowInformation("Synchornizing Database Finished!")

        Catch ex As Exception
            DebugPrint("Error gRunWebServiceManually: " & ex.Message)
            Messenger.ShowError("Synchronization is failed!")
        End Try

        gIsSyncProcessing = False

        gStopThreadManually()

    End Sub

    Public Sub gRunThreadWebService()
        If Thread1 Is Nothing Then
            Thread1 = New System.Threading.Thread(AddressOf gRunWebService)
            Thread1.Start()
        End If
    End Sub

    Public Sub gStopThread()
        If Not Thread1 Is Nothing Then
            Thread1.Abort()
            Thread1 = Nothing
        End If
    End Sub

    Public Function gRunThreadWebServiceManually() As Boolean
        'If Thread2 Is Nothing Then
        Thread2 = Nothing
        Thread2 = New System.Threading.Thread(AddressOf gRunWebServiceManually)
        Thread2.Start()
        'End If
    End Function

    Public Sub gStopThreadManually()
        If Not Thread2 Is Nothing Then
            Thread2.Abort()
            Thread2 = Nothing
        End If
    End Sub

    ' for various branch and/or client
    Public Sub gPrintCashBill(ByVal invoiceId As Long, Optional ByVal isCard As Boolean = False)

        Select Case gAppConfig.PrintableReceipt.ToUpper
            Case "itKakimotor"
                'gShowReport(New rptReceipt_itKakimotor(invoiceId, pay, change, isCard))

            Case "itKakimotor001"
                'gShowReport(New rptReceipt_itKakimotor001(invoiceId, pay, change, isCard))

            Case "FOTOZZOOM"
                'gShowReport(New rptReceipt_cbtFotozzoom(invoiceId), True)

            Case "CDELI"
                'gShowReport(New rptReceipt_risis(invoiceId), True)

            Case Else
                'gShowReport(New rptReceipt_risis(invoiceId), True)

        End Select

        PrintingFormat.PrintReceipt(invoiceId, True)
    End Sub


    Public Function gGetPriceFieldByConfig() As String

        Select Case gAppConfig.PriceSchema
            Case "Price List"
                Return DAItem.PRICELIST
            Case "Price Sale"
                Return DAItem.PRICESALE
            Case "Price Disc1"
                Return DAItem.PRICEDISC1
            Case "Price Disc2"
                Return DAItem.PRICEDISC2
            Case "Price Disc3"
                Return DAItem.PRICEDISC3
            Case Else
                Return DAItem.PRICELIST
        End Select

    End Function


    Public Function gCheckCurrentDateTime() As Boolean
        Dim currentTime As DateTime = Now
        Dim recordTime As DateTime

        recordTime = objDA.GetLastTimeLogin(gBranchObj.pkid, gSysConfig.PosId)
        If recordTime <> Nothing Then
            If FormatDateTime(recordTime) <> FormatDateTime(GetDefaultDate()) Then
                If Now < recordTime Then
                    Messenger.ShowInformation(gMSG_CHECK_CURRENT_DATE)
                    Return False
                End If
            End If
        End If

        Return True

    End Function


    Public Sub gShowMsgTxnSucceed(ByVal pkid As Long, ByVal form As String)
        If gAppConfig.MsgTxnSucceedEnabled Then
            Dim msg As String = gAppConfig.MsgTxnSucceed
            msg = msg.Replace("<pkid>", pkid)
            msg = msg.Replace("<form>", form)
            Messenger.ShowInformation(msg)
        End If
    End Sub


    Public Function gShowMsgTxnConfirm() As Boolean
        If gAppConfig.MsgTxnConfirmEnabled Then
            Return Messenger.ShowQuestion(gAppConfig.MsgTxnConfirm, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes
        End If

        Return True

    End Function

    Public Sub gShowMsgVoidSucceed(ByVal pkid As Long, ByVal form As String)
        If gAppConfig.MsgVoidSucceedEnabled Then
            Dim msg As String = gAppConfig.MsgVoidSucceed
            msg = msg.Replace("<pkid>", pkid)
            msg = msg.Replace("<form>", form)
            Messenger.ShowInformation(msg)
        End If
    End Sub

    Public Function gShowMsgVoidConfirm() As Boolean
        If gAppConfig.MsgVoidConfirmEnabled Then
            Return Messenger.ShowQuestion(gAppConfig.MsgVoidConfirm, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes
        End If

        Return True

    End Function

    Public Sub gShowMsgDeleteSucceed()
        If gAppConfig.MsgDeleteSucceedEnabled Then
            Dim msg As String = gAppConfig.MsgDeleteSucceed
            'msg = msg.Replace("<pkid>", pkid)
            'msg = msg.Replace("<form>", Form)
            Messenger.ShowInformation(msg)
        End If
    End Sub

    Public Function gShowMsgDeleteConfirm() As Boolean
        If gAppConfig.MsgDeleteConfirmEnabled Then
            Return Messenger.ShowQuestion(gAppConfig.MsgDeleteConfirm, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes
        End If

        Return True

    End Function

    Public Sub gShowScreenKeyboard()
        If gFrmScreenKeyboard Is Nothing Then
            gFrmScreenKeyboard = New frmScreenKeyboard
            'gFrmScreenKeyboard = New Form1
            gFrmScreenKeyboard.TopMost = True
            gFrmScreenKeyboard.Show()
        End If
    End Sub


    Public Sub gStopScreenKeyboard()
        If Not gFrmScreenKeyboard Is Nothing Then
            'gFrmScreenKeyboard.Close()
            gFrmScreenKeyboard.Dispose()
            gFrmScreenKeyboard = Nothing
        End If
    End Sub


    Public Sub gLoadPicture(ByVal strFileName As String, ByVal picLogo As DataDynamics.ActiveReports.Picture)
        Try
            If strFileName = "" Then Exit Sub
            strFileName = System.IO.Path.Combine(Application.StartupPath, strFileName)

            If Not IO.File.Exists(strFileName) Then Exit Sub
            'Dim fs As New System.IO.FileStream(strFileName, IO.FileMode.Open, IO.FileAccess.Read)

            'Dim bArrImage(fs.Length) As Byte
            'fs.Read(bArrImage, 0, Convert.ToInt32(fs.Length))
            'fs.Close()

            'Dim ms As New MemoryStream(bArrImage)
            'picLogo.Image = Image.FromStream(ms)
            'picLogo.Image = System.Drawing.Image.FromStream(fs)
            'picLogo.SizeMode = PictureBoxSizeMode.StretchImage
            'ms.Dispose()
            'fs.Close()

            Dim img As New System.Drawing.Bitmap(strFileName)
            picLogo.Image = img

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub


    Public Sub gShowMessage(ByVal msg As String)
        Dim frm As New frmMessage
        frm.lblMessage.Text = msg
        frm.ShowDialog()
    End Sub


    Public Sub gOpenComPort()

        Try
            gComPort.Open(gSysConfig.DisplayPoleComPort, gSysConfig.DisplayPoleBaudRate, gSysConfig.DisplayPoleDataBits, _
                                gSysConfig.DisplayPoleParity, gSysConfig.DisplayPoleStopBits, 4096)

        Catch ex As Exception
            WriteToLogFile(ex.Message)
            gComPort = Nothing
        End Try

    End Sub

    Public Sub gCloseComPort()

        Try
            If gComPort.IsOpen Then
                gComPort.Close()
            End If

        Catch ex As Exception
            WriteToLogFile(ex.Message)
            gComPort = Nothing
        End Try

    End Sub

    Public Sub gDisplayPole(ByVal msg1 As String, ByVal msg2 As String)
        Try
            If gComPort Is Nothing Then
                Exit Sub
            End If

            If Not gComPort.IsOpen Then
                Exit Sub
            End If

            'Clear text
            gComPort.Write(Encoding.ASCII.GetBytes(Chr(12)))
            gComPort.Write(Encoding.ASCII.GetBytes(msg1))
            If (msg1.Length < 20) Then
                gComPort.Write(Encoding.ASCII.GetBytes(vbCrLf))
            ElseIf (msg1.Length <> 20) Then
                gComPort.Write(Encoding.ASCII.GetBytes(" "))
            End If

            gComPort.Write(Encoding.ASCII.GetBytes(msg2))

        Catch ex As Exception
            WriteToLogFile(ex.Message)

        End Try

    End Sub


    Public Sub gSetCulture()
        Dim objCI As New CultureInfo(gAppConfig.CurrentSystemLocale)
        Thread.CurrentThread.CurrentCulture = objCI
        Thread.CurrentThread.CurrentUICulture = objCI
    End Sub


    Public Sub gSetLocaleChange(ByVal formName As String, ByVal ctl As Control)

        If ctl.GetType Is GetType(System.Windows.Forms.ToolStrip) Then
            Dim ts As ToolStrip = DirectCast(ctl, ToolStrip)
            For Each item As ToolStripItem In ts.Items
                Dim name As String = item.Name & ".Text"
                Dim text As String = gGetLocale(formName, name)

                AssignValue(text, item.Text)
            Next
        End If

        If ctl.GetType Is GetType(GlacialComponents.Controls.GlacialList) Then
            Dim gl As GlacialComponents.Controls.GlacialList = DirectCast(ctl, GlacialComponents.Controls.GlacialList)
            For Each item As GlacialComponents.Controls.GLColumn In gl.Columns
                Dim name As String = item.Name & ".Text"
                Dim text As String = gGetLocale(formName, name)

                AssignValue(text, item.Text)
            Next
        End If

        If ctl.GetType Is GetType(ThickClient.MyDataGrid) Then
            Dim dg As DataGridView = DirectCast(ctl, DataGridView)
            For Each item As DataGridViewColumn In dg.Columns
                Dim name As String = item.Name & ".HeaderText"
                Dim text As String = gGetLocale(formName, name)

                AssignValue(text, item.HeaderText)
            Next
        End If

        If ctl.GetType Is GetType(System.Windows.Forms.DataGridView) Then
            Dim dg As DataGridView = DirectCast(ctl, DataGridView)
            For Each item As DataGridViewColumn In dg.Columns
                Dim name As String = item.Name & ".HeaderText"
                Dim text As String = gGetLocale(formName, name)

                AssignValue(text, item.HeaderText)
            Next
        End If

        For Each myControl As Control In ctl.Controls
            Dim name As String = myControl.Name & ".Text"
            Dim text As String = gGetLocale(formName, name)

            AssignValue(text, myControl.Text)

            gSetLocaleChange(formName, myControl)
        Next 'myControl
    End Sub

    Public Function gGetLocale(ByVal formName As String, ByVal sourcename As String) As String
        Dim returnValue As String = ""
        Dim localePath As String = Path.Combine(gResourcesPath, gAppConfig.CurrentSystemLocale)
        Dim localeFile As String = Path.Combine(localePath, formName & ".resx")

        If Not File.Exists(localeFile) Then Return ""

        Dim resx As New ResXResourceReader(localeFile)

        Try
            For Each d As DictionaryEntry In resx
                If sourcename = d.Key Then
                    returnValue = d.Value
                    Exit For
                End If
            Next d

            'Close the reader.
            resx.Close()

        Catch ex As Exception
            WriteToLogFile(ex.Message)
        End Try

        Return returnValue

    End Function


    Public Sub gLoadUsers(ByVal ctl As ComboBox)
        Dim ds As DataSet = Nothing

        Try
            ds = objDA.GetAllUser
            'objDA.getUserObjectByBranch(gBranchID, ds)

            If ds IsNot Nothing Then
                Dim row As DataRow = ds.Tables(0).NewRow
                row(DAUser.USERNAME) = "ALL"
                row(DAUser.USERID) = 0
                ds.Tables(0).Rows.Add(row)

                '    cboUser.DataSource = Nothing
                '    cboUser.DataSource = ds.Tables(0)
                '    cboUser.DisplayMember = "username"
                '    cboUser.ValueMember = "userid"

                PopulateComboBoxWithDataset(ds, DAUser.USERNAME, DAUser.USERID, ctl)
                ctl.SelectedIndex = ctl.Items.Count - 1
            End If

        Catch ex As Exception
            Messenger.ShowError(ex.Message)
        End Try
    End Sub


    Public Function gGetInsertStatementString(ByVal dt As DataTable, ByVal tableName As String) As String

        Dim sb As New StringBuilder

        sb.Append("INSERT INTO " & tableName & "(")

        For i As Integer = 0 To dt.Columns.Count - 1
            If i > 0 Then sb.Append(",")
            Dim col As DataColumn = dt.Columns(i)
            sb.Append(col.ColumnName)
        Next

        sb.Append(") VALUES " & vbCrLf)
        For i As Integer = 0 To dt.Rows.Count - 1
            Dim dr As DataRow = dt.Rows(i)
            If i > 0 Then sb.Append(";" & vbCrLf & "INSERT INTO " & tableName & " VALUES " & vbCrLf)
            sb.Append("(")
            For j As Integer = 0 To dt.Columns.Count - 1
                If (j > 0) Then sb.Append(",")
                Dim col As DataColumn = dt.Columns(j)
                Select Case col.ColumnName.ToLower
                    Case "pkid"
                        sb.Append("(SELECT MAX(pkid)+1 FROM " & tableName & ")")
                    Case DATCTxQueue.DATE_RECEIVED
                        sb.Append("(SELECT now())")
                    Case Else
                        sb.Append(PreparedStatement(dr(col.ColumnName)))
                End Select


            Next
            sb.Append(")")
        Next

        Return sb.ToString
    End Function


    Public Sub gSetDataTableToCSV(ByVal dtable As DataTable, ByVal path_filename As String, ByVal sep_char As String)
        Dim writer As System.IO.StreamWriter
        Try
            writer = New System.IO.StreamWriter(path_filename, False)

            Dim _sep As String = ""
            Dim builder As New System.Text.StringBuilder

            ' Header Name
            For Each col As DataColumn In dtable.Columns
                builder.Append(_sep).Append(col.ColumnName)
                _sep = sep_char
            Next
            writer.WriteLine(builder.ToString())

            For Each row As DataRow In dtable.Rows
                _sep = ""
                builder = New System.Text.StringBuilder

                For Each col As DataColumn In dtable.Columns
                    builder.Append(_sep).Append(PreparedStatementCSV(row(col.ColumnName)))
                    _sep = sep_char
                Next
                writer.WriteLine(builder.ToString())
            Next
        Catch ex As Exception

        Finally
            If Not writer Is Nothing Then writer.Close()
        End Try
    End Sub


    Public Function gGetDataTableToCSV(ByVal dtable As DataTable, ByVal sep_char As String, ByRef sbPkid As StringBuilder) As String

        Dim builder As New System.Text.StringBuilder

        Try
            Dim _sep As String = ""

            ' Header Name
            For Each col As DataColumn In dtable.Columns
                builder.Append(_sep).Append(col.ColumnName)
                _sep = sep_char
            Next
            builder.Append(vbCrLf)

            For Each row As DataRow In dtable.Rows
                _sep = ""
                builder = New System.Text.StringBuilder

                For Each col As DataColumn In dtable.Columns
                    builder.Append(_sep).Append(PreparedStatementCSV(row(col.ColumnName)))
                    If (col.ColumnName.ToLower = "pkid") Then
                        If sbPkid.Length > 0 Then sbPkid.Append(",")
                        sbPkid.Append(row(col.ColumnName))
                    End If
                    _sep = sep_char

                Next
                builder.Append(vbCrLf)
            Next
        Catch ex As Exception

        End Try

        Return builder.ToString()

    End Function

End Module
