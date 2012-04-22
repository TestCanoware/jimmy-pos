Imports System
Imports System.Text
Imports System.Security.Cryptography
Imports System.Windows.Forms
Imports System.Globalization
Imports System.Reflection
Imports System.IO
Imports System.Configuration

Public NotInheritable Class General

#Region " Registry "

    '------------------------------------------------------------
    ' ReadFromRegistry :-
    ' Returns a value from the registry
    ' Source : Apress Book - Ultimate VBNet - Ch 7
    '------------------------------------------------------------
    Public Shared Function ReadFromRegistry(ByVal RegistryLocation As String, _
                                      ByVal RegistryName As String) _
                                      As Object

        Dim MyKey As Microsoft.Win32.RegistryKey

        MyKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegistryLocation)
        Return MyKey.GetValue(RegistryName)
        MyKey.Close()

    End Function


    '------------------------------------------------------------
    ' WriteToRegistry
    ' Writes a value to the registry
    ' Source : Apress Book - Ultimate VBNet - Ch 7
    '------------------------------------------------------------
    Public Shared Function WriteToRegistry(ByVal RegistryLocation As String, _
                                     ByVal RegistryName As String) _
                                     As Object

        Dim MyKey As Microsoft.Win32.RegistryKey
        Dim objData As Object = Nothing

        MyKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(RegistryLocation)
        MyKey.SetValue(RegistryName, objData)
        Return objData
        MyKey.Close()

    End Function

#End Region

    Public Shared Function WriteToEventLog(ByVal Entry As String, _
                                       Optional ByVal AppName As String = "VB.NET Application", _
                                       Optional ByVal EventType As EventLogEntryType = EventLogEntryType.Information, _
                                       Optional ByVal LogName As String = "Application") As Boolean

        '*************************************************************
        'PURPOSE: Write Entry to Event Log using VB.NET
        'PARAMETERS: Entry - Value to Write
        '            AppName - Name of Client Application. Needed 
        '              because before writing to event log, you must 
        '              have a named EventLog source. 
        '            EventType - Entry Type, from EventLogEntryType 
        '              Structure e.g., EventLogEntryType.Warning, 
        '              EventLogEntryType.Error
        '            LogName: Name of Log (System, Application; 
        '              Security is read-only) If you 
        '              specify a non-existent log, the log will be
        '              created

        'RETURNS:   True if successful, false if not

        'EXAMPLES: 
        '1. Simple Example, Accepting All Defaults
        '    WriteToEventLog "Hello Event Log"

        '2.  Specify EventSource, EventType, and LogName
        '    WriteToEventLog("Danger, Danger, Danger", "MyVbApp", _
        '                      EventLogEntryType.Warning, "System")
        '
        'NOTE:     EventSources are tightly tied to their log. 
        '          So don't use the same source name for different 
        '          logs, and vice versa
        '******************************************************

        Dim objEventLog As New EventLog()

        Try
            'Register the App as an Event Source
            If Not EventLog.SourceExists(AppName) Then
                EventLog.CreateEventSource(AppName, LogName)
            End If

            objEventLog.Source = AppName

            'WriteEntry is overloaded; this is one
            'of 10 ways to call it
            objEventLog.WriteEntry(Entry, EventType)
            Return True
        Catch Ex As Exception
            Return False

        End Try

    End Function

    Public Shared Function ConvertToHex(ByVal data As Byte()) As String
        Dim sb As New System.Text.StringBuilder
        'sb.Append("0x")
        For Each b As Byte In data
            sb.AppendFormat("{0:X2}", b)
        Next

        Return sb.ToString.ToLower

    End Function

    Public Shared Function GetSHA1(ByVal msg As String) As String

        Dim sha As New SHA1Managed
        Dim ae As New ASCIIEncoding
        Dim data As Byte() = ae.GetBytes(msg)
        Dim digest As Byte() = sha.ComputeHash(data)

        Return ConvertToHex(digest)

    End Function

    Public Shared Sub CursorButtons(ByVal ctl As Control, ByVal cursor As Cursor)
        For Each myControl As Control In ctl.Controls
            If myControl.GetType Is GetType(System.Windows.Forms.Button) OrElse _
                myControl.GetType Is GetType(System.Windows.Forms.ToolStrip) OrElse _
                myControl.GetType Is GetType(System.Windows.Forms.StatusStrip) Then
                myControl.Cursor = cursor
            End If
            CursorButtons(myControl, cursor)
        Next 'myControl
    End Sub

    Public Shared Sub ClearFields(ByVal ctl As Control, Optional ByVal isLock As Boolean = False)
        For Each myControl As Control In ctl.Controls
            Select Case myControl.GetType.ToString
                Case "System.Windows.Forms.ComboBox"
                    Dim cbo As ComboBox = CType(myControl, ComboBox)
                    If cbo.Items.Count > 0 Then cbo.SelectedIndex = 0
                    cbo.SelectedIndex = -1

                    LockFields(myControl, isLock)

                Case "System.Windows.Forms.TextBox"
                    myControl.Text = ""
                    LockFields(myControl, isLock)
            End Select
            ClearFields(myControl, isLock)
        Next 'myControl
    End Sub

    Public Shared Sub LockAllFields(ByVal ctl As Control, ByVal isLock As Boolean)
        For Each myControl As Control In ctl.Controls
            If myControl.GetType Is GetType(System.Windows.Forms.TextBox) OrElse _
               myControl.GetType Is GetType(System.Windows.Forms.ComboBox) OrElse _
               myControl.GetType Is GetType(System.Windows.Forms.DateTimePicker) Then
                LockFields(myControl, isLock)
            End If
            LockAllFields(myControl, isLock)
        Next 'myControl
    End Sub

    Public Shared Sub LockAllButtons(ByVal ctl As Control, ByVal isLock As Boolean)
        For Each myControl As Control In ctl.Controls
            If myControl.GetType Is GetType(System.Windows.Forms.Button) OrElse _
                myControl.GetType Is GetType(System.Windows.Forms.ToolStrip) OrElse _
                myControl.GetType Is GetType(System.Windows.Forms.StatusStrip) Then
                myControl.Enabled = Not isLock
            End If
            LockAllButtons(myControl, isLock)
        Next 'myControl
    End Sub

    Public Shared Sub LockFields(ByVal ctl As Control, ByVal isLock As Boolean)
        Dim color As System.Drawing.color
        color = ctl.BackColor

        ctl.Enabled = Not isLock
        ctl.BackColor = color
    End Sub


    '------------------------------------------------------------
    ' gPopulateComboBoxWithDataset :-
    ' Returns the combobox with the attached dataset
    '------------------------------------------------------------
    Public Shared Sub PopulateComboBoxWithDataset(ByVal objDataset As DataSet, _
                                                 ByVal strDisplayMember As String, _
                                                 ByVal strValueMember As String, _
                                                 ByRef cboReference As ComboBox)
        'Clear previous data bindings
        cboReference.DataSource = Nothing
        cboReference.DisplayMember = String.Empty
        cboReference.ValueMember = String.Empty

        'Rebind ComboBox control
        cboReference.DataSource = objDataset.Tables(0)
        cboReference.DisplayMember = strDisplayMember
        cboReference.ValueMember = strValueMember

        'Reset the selected index
        cboReference.SelectedIndex = -1

    End Sub


    '------------------------------------------------------------
    ' PopulateListBoxWithDataset :-
    ' Returns the listbox with the attached dataset
    '------------------------------------------------------------
    Public Shared Sub PopulateListBoxWithDataset(ByVal dsDataset As DataSet, _
                                              ByVal strDisplayMember As String, _
                                              ByVal strValueMember As String, _
                                              ByRef lstListbox As ListBox)
        'Clear previous data bindings
        lstListbox.DataSource = Nothing
        lstListbox.DisplayMember = String.Empty
        lstListbox.ValueMember = String.Empty
        lstListbox.Items.Clear()

        'Rebind ComboBox control
        lstListbox.DataSource = dsDataset.Tables(0)
        lstListbox.DisplayMember = strDisplayMember
        lstListbox.ValueMember = strValueMember

        'Reset the selected index
        lstListbox.SelectedIndex = -1

    End Sub

    Public Shared Function KeyPress(ByVal key As String, ByVal isValid As Boolean, ByVal e As System.Windows.Forms.KeyPressEventArgs) As Boolean
        If isValid Then
            If e.KeyChar <> ControlChars.Back And e.KeyChar <> ControlChars.Cr Then
                If InStr(key, e.KeyChar) = 0 Then
                    Return isValid
                End If
            End If
        Else
            If InStr(key, e.KeyChar) = 0 Then
                Return isValid
            End If
        End If
        Return Not isValid

    End Function

    Public Shared Function PreparedStatement(ByVal value As Object) As String
        Dim Temp As String
        Dim dtValue As Date

        If value Is System.DBNull.Value Then Return "''"
        If value Is Nothing Then Return "''"

        Select Case value.GetType.ToString

            Case "System.Int16", "System.Int32", "System.Int64", "System.Decimal", "System.UInt16", "System.UInt32", "System.UInt64"
                Return value.ToString()

            Case "System.String"
                Return "'" & value.ToString.Replace("'", "''") & "'"

            Case "System.DateTime"
                dtValue = CType(value, DateTime)
                If dtValue.ToString("yyyy-MM-dd") = "0001-01-01" Then
                    Return "'2001-01-01 00:00:01'"
                Else
                    ' Convert to universal datetime format (will work on all databases in all countries)
                    Return "'" & dtValue.ToString("yyyy-MM-dd HH:mm:ss") & "'"
                End If

            Case "System.Boolean"
                Temp = value.ToString()
                Temp = Temp.Replace("True", "1")
                Temp = Temp.Replace("False", "0")
                Return Temp

            Case "System.Byte[]"
                'Dim ascii As New System.Text.ASCIIEncoding
                'Dim str As String = ascii.GetString(value)

                'Dim strText As String
                'strText = Bytes_To_String(value)

                ''dim strText = Convert.to

                'If strText = "" Then
                '    Return "''"
                'Else
                '    Return strText
                'End If

            Case Else
                Return "''"

        End Select

        Return "''"
    End Function

    Public Shared Function PreparedStatementCSV(ByVal value As Object) As String
        Dim Temp As String
        Dim dtValue As Date

        If value Is System.DBNull.Value Then Return ""
        If value Is Nothing Then Return ""

        Select Case value.GetType.ToString

            Case "System.Int16", "System.Int32", "System.Int64", "System.Decimal", "System.UInt16", "System.UInt32", "System.UInt64"
                Return value.ToString()

            Case "System.String"
                Return value.ToString.Replace("'", "''")

            Case "System.DateTime"
                dtValue = CType(value, DateTime)
                If dtValue.ToString("yyyy-MM-dd") = "0001-01-01" Then
                    Return "2001-01-01 00:00:01"
                Else
                    ' Convert to universal datetime format (will work on all databases in all countries)
                    Return dtValue.ToString("yyyy-MM-dd HH:mm:ss")
                End If

            Case "System.Boolean"
                Temp = value.ToString()
                Temp = Temp.Replace("True", "1")
                Temp = Temp.Replace("False", "0")
                Return Temp

            Case "System.Byte[]"
                'Dim ascii As New System.Text.ASCIIEncoding
                'Dim str As String = ascii.GetString(value)

                'Dim strText As String
                'strText = Bytes_To_String(value)

                ''dim strText = Convert.to

                'If strText = "" Then
                '    Return "''"
                'Else
                '    Return strText
                'End If

            Case Else
                Return ""

        End Select

        Return ""
    End Function

    Public Shared Sub AssignValue(ByVal valueFrom As Object, ByRef valueTo As Object)
        If valueFrom Is Nothing Then Exit Sub
        If valueFrom Is System.DBNull.Value Then Exit Sub

        Select Case valueFrom.ToString.ToUpper
            Case ""
            Case "TRUE"
                valueTo = 1
            Case "FALSE"
                valueTo = 0
            Case "1"
                valueTo = 1
            Case "0"
                valueTo = 0
            Case Else
                valueTo = valueFrom
        End Select

    End Sub

    Public Shared Function GetDiffHours(ByVal date1 As DateTime, ByVal date2 As DateTime) As Double

        Dim dtDiff As TimeSpan = date1 - date2
        Return dtDiff.TotalHours

    End Function

    Public Shared Function FormatCurrency(ByVal value As Object) As String

        Try
            Return Format(Convert.ToDecimal(value), "#,##0.00")
        Catch ex As Exception
            Return value
        End Try

    End Function

    Public Shared Function FormatInt(ByVal value As Object) As String

        Try
            Return Format(Convert.ToInt32(value), "#,##0")
        Catch ex As Exception
            Return value
        End Try

    End Function

    Public Shared Function FormatDate(ByVal value As Object) As String

        Try
            Return Format(Convert.ToDateTime(value), "yyyy-MM-dd")
        Catch ex As Exception
            Return value
        End Try

    End Function

    Public Shared Function FormatDateTime2(ByVal value As Object) As String

        Try
            Return Format(Convert.ToDateTime(value), "MM") & "/" & Format(Convert.ToDateTime(value), "yy")
        Catch ex As Exception
            Return value
        End Try

    End Function

    Public Shared Function FormatDateTime1(ByVal value As Object) As String

        Try
            Return Format(Convert.ToDateTime(value), "dd MMM yyyy HH:mm:ss")
        Catch ex As Exception
            Return value
        End Try

    End Function

    Public Shared Function FormatDateTime(ByVal value As Object) As String

        Try
            'Return Format(Convert.ToDateTime(value), "yyyy-MM-dd h:mm:ss tt")
            Return Convert.ToDateTime(value).ToString

        Catch ex As Exception
            Return value
        End Try

    End Function

    Public Shared Function FormatShortDate(ByVal value As Object) As String

        Try
            Return Format(Convert.ToDateTime(value), GetShortDatePattern)

        Catch ex As Exception
            Return value
        End Try

    End Function

    Public Shared Function FormatTime(ByVal value As Object) As String

        Try
            Return Format(Convert.ToDateTime(value), GetLongTimePattern)

        Catch ex As Exception
            Return value
        End Try

    End Function

    Public Shared Function GetNow() As String

        'Return Date.Now.ToString("yyyy-MM-dd h:mm:ss tt")
        Return Date.Now.ToString

    End Function

    'Public Shared Function GetNow() As DateTime
    '    Return Convert.ToDateTime(GetNowString)
    'End Function

    Public Shared Function GetTimeLong(ByVal dt As DateTime) As Long

        Dim baseTime As New DateTime(1970, 1, 1)
        Return (dt.ToUniversalTime.Ticks - baseTime.Ticks) / TimeSpan.TicksPerMillisecond

    End Function

    Public Shared Function GetDateTime(ByVal ticks As Long) As DateTime

        Try

            If ticks > 0 Then
                Dim baseTime As New DateTime(1970, 1, 1)
                Dim dt As New DateTime(ticks * TimeSpan.TicksPerMillisecond)
                Dim lng As Long = (dt.ToLocalTime.Ticks) + baseTime.Ticks

                Return New DateTime(lng)
            Else
                Return New DateTime(1, 1, 1)
            End If

        Catch ex As Exception
            Return New DateTime(1, 1, 1)
        End Try


    End Function

    Public Shared Sub LoadPicture(ByVal strFileName As String, ByVal picLogo As PictureBox)

        Dim fs As New System.IO.FileStream(strFileName, IO.FileMode.Open, IO.FileAccess.Read)

        Try

            Dim bArrImage(fs.Length) As Byte
            fs.Read(bArrImage, 0, Convert.ToInt32(fs.Length))
            fs.Close()

            Dim ms As New MemoryStream(bArrImage)
            picLogo.Image = Drawing.Image.FromStream(ms)
            'picLogo.Image = System.Drawing.Image.FromStream(fs)
            'picLogo.SizeMode = PictureBoxSizeMode.StretchImage
            'picLogo.BorderStyle = BorderStyle.Fixed3D
            'ms.Dispose()

        Catch ex As Exception
            Throw New Exception(ex.Message)

        Finally
            fs.Close()

        End Try

    End Sub


    Public Shared Sub LoadPictureFromBlob(ByVal blob As Byte(), ByVal picLogo As PictureBox)

        Try
            Dim strFilename As String = Path.GetTempFileName()

            If blob Is Nothing AndAlso blob.LongLength = 0 Then Exit Sub

            RetrieveFile(blob, strFilename)
            LoadPicture(strFilename, picLogo)

            File.Delete(strFilename)

        Catch ex As Exception
            WriteToLogFile(ex.Message)
        End Try

    End Sub

    Public Shared Sub WriteToLogFile(ByVal msg As String)
        Try
            Dim filename As String = Date.Now.ToString("yyyy-MM-dd") & ".log"
            Dim path As String = System.IO.Path.Combine(Application.StartupPath, "log")
            Dim dir As New System.IO.DirectoryInfo(path)

            If Not dir.Exists Then dir.Create()

            filename = System.IO.Path.Combine(dir.FullName, filename)
            Dim fi As New System.IO.FileInfo(filename)
            If Not fi.Exists Then fi.Create()
            fi = Nothing

            Dim objWriter As New System.IO.StreamWriter(filename, True)

            objWriter.WriteLine(GetNow() & " : " & msg)

            objWriter.Close()

        Catch ex As Exception
            WriteToEventLog(ex.Message, "VB.NET Application", EventLogEntryType.Error)
        End Try
    End Sub

    Public Shared Sub DebugPrint(ByVal msg As String)
        Debug.Print(msg)
        WriteToLogFile(msg)
    End Sub

    ' Disables the close button ('X') on form.
    Private Declare Function RemoveMenu Lib "user32" (ByVal hMenu As IntPtr, ByVal nPosition As Integer, ByVal wFlags As Long) As IntPtr
    Private Declare Function GetSystemMenu Lib "user32" (ByVal hWnd As IntPtr, ByVal bRevert As Boolean) As IntPtr
    Private Declare Function GetMenuItemCount Lib "user32" (ByVal hMenu As IntPtr) As Integer
    Private Declare Function DrawMenuBar Lib "user32" (ByVal hwnd As IntPtr) As Boolean

    Private Const MF_BYPOSITION = &H400
    Private Const MF_REMOVE = &H1000
    Private Const MF_DISABLED = &H2

    Public Shared Sub DisableCloseButton(ByVal hwnd As IntPtr)

        Dim hMenu As IntPtr
        Dim menuItemCount As Integer

        hMenu = GetSystemMenu(hwnd, False)
        menuItemCount = GetMenuItemCount(hMenu)

        Call RemoveMenu(hMenu, menuItemCount - 1, MF_DISABLED Or MF_BYPOSITION)
        Call RemoveMenu(hMenu, menuItemCount - 2, MF_DISABLED Or MF_BYPOSITION)
        Call DrawMenuBar(hwnd)

    End Sub


    Public Shared Function KeyPressDecimal(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) As Boolean
        If InStr(DirectCast(sender, TextBox).Text, ".") > 1 Then
            Return Utils.General.KeyPress("0123456789", True, e)
        Else
            Return Utils.General.KeyPress("0123456789.", True, e)
        End If
    End Function


    Public Shared Function KeyPressInteger(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) As Boolean
        If DirectCast(sender, TextBox).TextLength = 0 Then
            Return Utils.General.KeyPress("-0123456789", True, e)
        Else
            Return Utils.General.KeyPress("0123456789", True, e)
        End If
    End Function


    Public Shared Function GetDefaultDate() As Date
        Return New Date(2001, 1, 1, 0, 0, 1)
    End Function

    Public Shared Function GetTodayDate() As Date
        Return New Date(Now.Year, Now.Month, Now.Day, 0, 0, 0)
    End Function

    Public Shared Function MonthNameToInt(ByVal monthName As String) As Integer
        Return DateTime.ParseExact(monthName, "MMMM", CultureInfo.CurrentCulture).Month
    End Function


    Public Shared Function GetLastDayInMonth(ByVal year As Integer, ByVal monthName As String) As Date
        Dim month As Integer = MonthNameToInt(monthName)
        Dim dtDate As New Date(year, month, 1, 0, 0, 1)

        Return GetLastDayInMonth(dtDate)
    End Function


    Public Shared Function GetLastDayInMonth(ByVal dtDate As Date) As Date
        'example for #2009-02-20# we want to get the last day in the month 02,
        ' (ie. date for last day in Feb)

        Dim year As Integer = dtDate.Year
        Dim month As Integer = dtDate.Month
        Dim days As Integer = DateTime.DaysInMonth(year, month)

        Return New Date(year, month, days, 0, 0, 1)

    End Function


    Public Shared Function GetDataGridViewCellStyle(ByVal valueType As System.Type) As DataGridViewCellStyle
        Dim cellStyle As New DataGridViewCellStyle

        Select Case valueType.ToString

            Case "System.Int16", "System.Int32", "System.Int64", "System.UInt16", "System.UInt32", "System.UInt64"
                cellStyle.Format = "#,##0"
                cellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            Case "System.Decimal"
                cellStyle.Format = "#,##0.00"
                cellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            Case "System.String"

            Case "System.DateTime"
                cellStyle.Format = GetDateTimePattern()

            Case "System.Boolean"

        End Select

        Return cellStyle

    End Function


    Public Shared Sub SetTextBoxValue(ByVal ctl As TextBox, ByVal value As String)
        Dim start As Integer = ctl.SelectionStart
        Dim length As Integer = ctl.SelectionLength
        Dim text As String = ctl.Text

        If length > 0 Then
            'text = text.Remove(start, length)
            Dim startText As String = text.Substring(0, start)
            Dim endLength As Integer = length + startText.Length
            If endLength > text.Length Then
                endLength = 0
            Else
                endLength = text.Length - endLength
            End If
            Dim endText As String = text.Substring(start + length, endLength)
            If value = "backspace" Then
                If startText.Length > 0 Then ctl.Text = startText.Substring(0, startText.Length - 1) & endText
            Else
                ctl.Text = startText & value & endText
            End If
        Else
            If value = "backspace" Then
                If text.Length > 0 Then ctl.Text = text.Substring(0, text.Length - 1)
            Else
                ctl.Text = text & value
            End If
        End If

        ctl.Focus()
        ctl.DeselectAll()
        ctl.SelectionStart = ctl.Text.Length

    End Sub


    Public Shared Sub AssignFieldsValue(ByVal objFrom As Object, ByRef objTo As Object)

        Dim FieldFrom As FieldInfo() = objFrom.GetType.GetFields(BindingFlags.NonPublic Or BindingFlags.Public Or BindingFlags.Instance)
        Dim FieldTo As FieldInfo() = objTo.GetType.GetFields(BindingFlags.NonPublic Or BindingFlags.Public Or BindingFlags.Instance)
        Dim nameField As String

        For i As Integer = 0 To FieldTo.Length - 1
            nameField = FieldTo(i).Name
            'If nameFiled = "name_space" Then
            'nameFiled = "namespace"
            'End If
            'nameFiled &= "Field"

            For j As Integer = 0 To FieldFrom.Length - 1
                If (nameField.ToLower = FieldFrom(j).Name.ToLower) Then
                    'string s = Encoding..ASCII.GetString( byteData);
                    Dim strValue As Object = FieldFrom(j).GetValue(objFrom)
                    If strValue Is Nothing Then
                        Exit For
                    End If
                    Select Case strValue.ToString()
                        Case "System.Byte[]"
                            'strValue = Encoding.ASCII.GetString(strValue)
                            strValue = BitConverter.ToString(strValue)
                    End Select
                    FieldTo(i).SetValue(objTo, strValue) 'itemobj.pkid = itmobjemp.pkid, 
                    Exit For
                End If
            Next
        Next i

    End Sub


    Public Shared Function GetXML(ByVal obj As Object, ByVal tableName As String, ByVal objName As String) As String
        Dim FieldFrom As FieldInfo() = obj.GetType.GetFields(BindingFlags.NonPublic Or BindingFlags.Public Or BindingFlags.Instance)
        Dim strXML As String = ""

        strXML = "<" & objName & ">"

        For i As Integer = 0 To FieldFrom.Length - 1
            Dim nameField As String = FieldFrom(i).Name
            Dim strValue As Object = FieldFrom(i).GetValue(obj)

            Select Case strValue.GetType.ToString
                Case "System.Collections.ArrayList"

                Case "System.DateTime"
                    Dim dtValue As Date = CType(strValue, Date)
                    If dtValue.ToString("yyyy-MM-dd HH:mm:ss") = "2001-01-01 00:00:01" Then
                        strValue = "0001-01-01 00:00:00"
                    Else
                        ' Convert to universal datetime format (will work on all databases in all countries)
                        strValue = dtValue.ToString("yyyy-MM-dd HH:mm:ss")
                    End If

                    strXML &= "<" & nameField & ">" & strValue & "</" & nameField & ">"

                Case Else
                    ' 20120103 Jimmy : LARRIE - temp add logic because not yet creat pos_id field at EMP server
                    If Not (objName = "com.vlee.ejb.accounting.OfficialReceiptObject" AndAlso nameField = "posId") Then
                        strXML &= "<" & nameField & ">" & strValue & "</" & nameField & ">"
                    End If
            End Select

        Next

        strXML &= "</" & objName & ">"

        Return strXML
    End Function

    Public Shared Sub OpenCashDrawer(ByVal cashDrawerCode As String, ByVal printer As String)

        Try

            Dim intFileNo As Integer = FreeFile()
            Dim str As String() = cashDrawerCode.Split(",")
            Dim code As String = ""
            For i As Integer = 0 To str.Length - 1
                code = code & Chr(str(i))
            Next

            Select Case printer
                Case "STAR"
                    Dim printDoc As New System.Drawing.Printing.PrintDocument
                    Dim defualtPrinterName As String = printDoc.PrinterSettings.PrinterName
                    DirectPrinter.SendStringToPrinter(defualtPrinterName, code)

                Case "EPSON"
                    Dim printDoc As New System.Drawing.Printing.PrintDocument
                    Dim defualtPrinterName As String = printDoc.PrinterSettings.PrinterName
                    DirectPrinter.SendStringToPrinter(defualtPrinterName, " " + code)
                    'Dim filename As String = Path.Combine(AppPath, Path.Combine("Data", "CashDrawer.dat"))
                    'Dim fi As New System.IO.FileInfo(filename)
                    'If Not fi.Exists Then
                    '    Dim fs1 As FileStream = fi.Create
                    '    fs1.Close()
                    'End If
                    'fi = Nothing

                    'Dim objWriter As New System.IO.StreamWriter(filename, True)
                    'objWriter.WriteLine(code)
                    'objWriter.Close()

                    'FileOpen(1, filename, OpenMode.Output)
                    'PrintLine(1, code)
                    'FileClose(1)
                    'Shell("print /d:lpt1 """ & filename & """", vbNormalFocus)

                    '' fix the file being used by other
                    'Dim file As New FileStream(filename, FileMode.Open)
                    'file.Close()
                    'file.Dispose()

                    'Dim printDoc As New System.Drawing.Printing.PrintDocument
                    'Dim defualtPrinterName As String = printDoc.PrinterSettings.PrinterName
                    'Dim drawerCode As Byte() = New Byte() {cashDrawerCode}

                    'PrintDataGrid.RawPrinterHelper.OpenCashDrawer(defualtPrinterName, drawerCode)
            End Select

        Catch ex As Exception
            WriteToLogFile(ex.Message)
        End Try

    End Sub

    'Public Shared Sub OpenCashDrawer(ByVal cashDrawerCode As String)
    '    Dim printDoc As New System.Drawing.Printing.PrintDocument
    '    Dim defualtPrinterName As String = printDoc.PrinterSettings.PrinterName
    '    Dim drawerCode As Byte() = New Byte() {cashDrawerCode}

    '    PrintDataGrid.RawPrinterHelper.OpenCashDrawer(defualtPrinterName, drawerCode)
    'End Sub

    'Public Shared Sub OpenCashDrawer()
    '    Dim printDoc As New System.Drawing.Printing.PrintDocument
    '    Dim defualtPrinterName As String = printDoc.PrinterSettings.PrinterName

    '    PrintDataGrid.RawPrinterHelper.OpenCashDrawer(defualtPrinterName)
    'End Sub

    Public Shared Function AppPath() As String
        Return System.Windows.Forms.Application.StartupPath
    End Function

    Public Shared Function GetGuid() As String
        Return System.Guid.NewGuid.ToString

    End Function

    ''' <summary>
    ''' Fnction to return the text value based on the index provided
    ''' </summary>
    ''' <param name="_enum">Enum to work with</param>
    ''' <param name="name">The value we're looking for</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetIntegerValue(ByVal _enum As Type, ByVal name As String) As Integer
        Dim intValue As Integer = 0
        'get the names from the enumeration
        Dim names() As String = System.Enum.GetNames(_enum)
        'get the values from the enumeration
        Dim values() As Integer = System.Enum.GetValues(_enum)
        'Now we loop through all the names in the enum list
        'looking for a match
        For i As Integer = 0 To names.Length - 1
            'If this current index matches the name
            'then we return that name
            If names(i) = name Then
                intValue = names(i)
                Exit For
            End If
        Next
        Return intValue
    End Function


    Public Shared Function Bytes_To_String(ByVal bytes_Input As Byte()) As String
        ' convert the byte array back to a true string  
        Dim strTemp As String = ""
        For x As Integer = 0 To bytes_Input.GetUpperBound(0)
            Dim number As Integer = Integer.Parse(bytes_Input(x).ToString())
            strTemp += number.ToString("X").PadLeft(2, "0"c)
        Next
        ' return the finished string of hex values  
        Return strTemp
    End Function


    Public Shared Function GetBLOB(ByVal filename As String) As Byte()

        Dim fs As New FileStream(filename, FileMode.Open, FileAccess.Read)
        Dim rawData As Byte() = New Byte(fs.Length) {}
        fs.Read(rawData, 0, fs.Length)
        fs.Close()

        Return rawData
    End Function


    Public Shared Sub RetrieveFile(ByVal blob As Byte(), ByVal filename As String)

        Dim K As Long
        K = UBound(blob)

        Dim WriteFs As New FileStream(filename, FileMode.Create, FileAccess.Write)
        WriteFs.Write(blob, 0, K)
        WriteFs.Close()

    End Sub


    Public Shared Function GetFileContents(ByVal FullPath As String, _
                                    Optional ByRef ErrInfo As String = "") As String

        Dim strContents As String = ""
        Dim objReader As StreamReader

        Try

            objReader = New StreamReader(FullPath)
            strContents = objReader.ReadToEnd()
            objReader.Close()

        Catch Ex As Exception
            ErrInfo = Ex.Message
        End Try

        Return strContents

    End Function


    Public Shared Function SaveTextToFile(ByVal strData As String, ByVal FullPath As String, _
                                   Optional ByVal ErrInfo As String = "") As Boolean

        Dim Contents As String = ""
        Dim bAns As Boolean = False
        Dim objReader As StreamWriter

        Try
            objReader = New StreamWriter(FullPath)
            objReader.Write(strData)
            objReader.Close()
            bAns = True

        Catch Ex As Exception
            ErrInfo = Ex.Message
        End Try

        Return bAns
    End Function


    Public Shared Function GetDateTimePattern() As String
        Dim date_info As DateTimeFormatInfo = _
            CultureInfo.CurrentCulture.DateTimeFormat()

        Return date_info.ShortDatePattern & " " & date_info.LongTimePattern
    End Function

    Public Shared Function GetShortDatePattern() As String
        Dim date_info As DateTimeFormatInfo = _
            CultureInfo.CurrentCulture.DateTimeFormat()

        Return date_info.ShortDatePattern
    End Function

    Public Shared Function GetLongTimePattern() As String
        Dim date_info As DateTimeFormatInfo = _
            CultureInfo.CurrentCulture.DateTimeFormat()

        Return date_info.LongTimePattern
    End Function

    Public Shared Sub AutoCompleteCombo_KeyUp(ByVal cbo As ComboBox, ByVal e As KeyEventArgs)
        Dim sTypedText As String
        Dim iFoundIndex As Integer
        Dim oFoundItem As Object
        Dim sFoundText As String
        Dim sAppendText As String

        'Allow select keys without Autocompleting

        Select Case e.KeyCode
            Case Keys.Back, Keys.Left, Keys.Right, Keys.Up, Keys.Delete, Keys.Down
                Return
        End Select

        'Get the Typed Text and Find it in the list

        sTypedText = cbo.Text
        iFoundIndex = cbo.FindString(sTypedText)

        'If we found the Typed Text in the list then Autocomplete

        If iFoundIndex >= 0 Then

            'Get the Item from the list (Return Type depends if Datasource was bound 

            ' or List Created)

            oFoundItem = cbo.Items(iFoundIndex)

            'Use the ListControl.GetItemText to resolve the Name in case the Combo 

            ' was Data bound

            sFoundText = cbo.GetItemText(oFoundItem)

            'Append then found text to the typed text to preserve case

            sAppendText = sFoundText.Substring(sTypedText.Length)
            cbo.Text = sTypedText & sAppendText

            'Select the Appended Text

            cbo.SelectionStart = sTypedText.Length
            cbo.SelectionLength = sAppendText.Length

        End If

    End Sub


    Public Shared Sub AutoCompleteCombo_Leave(ByVal cbo As ComboBox)
        Dim iFoundIndex As Integer

        iFoundIndex = cbo.FindStringExact(cbo.Text)

        cbo.SelectedIndex = iFoundIndex

    End Sub

    Public Shared Function Rounding5Cent(ByVal value As Decimal) As Decimal
        Dim result As Decimal = FormatCurrency(value)
        Dim no As Decimal = 20

        result = Math.Round(Decimal.Multiply(result, no), 0)
        result = Math.Round(Decimal.Divide(result, no), 2)

        Return result
    End Function

    Public Shared Function GetAppSettingKey(ByVal keyname As String)
        Dim myconfig As Configuration = ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.None)
        If (myconfig.AppSettings.Settings(keyname) Is Nothing) Then Return ""
        Return myconfig.AppSettings.Settings(keyname).Value
    End Function

    Public Shared Sub SetAppSettingKey(ByVal keyname As String, ByVal value As String)
        Dim myconfig As Configuration = ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.None)
        If (myconfig.AppSettings.Settings(keyname) Is Nothing) Then
            myconfig.AppSettings.Settings.Add(keyname, value)
        Else
            myconfig.AppSettings.Settings(keyname).Value = value
        End If
        myconfig.Save()
    End Sub

End Class
