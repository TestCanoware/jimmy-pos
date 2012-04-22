Imports System.Configuration
Imports Utils
Imports Utils.General

Module Main


    <STAThread()> _
    Public Sub Main()

        ' XP Theme style
        Application.EnableVisualStyles()
        Application.DoEvents()

        If GetAppSettingKey(gAPP_KEY_THICK_CLIENT_IS_INSTALL) <> "1" Then
            Dim frm As New frmInstallation
            If Not frm.ShowDialog() = DialogResult.OK Then
                Exit Sub
            End If

        End If


        Try
            gSysConfig = New Utils.SysConfig
            gLoadAppConfig()

        Catch ex As Exception
            Messenger.ShowError(ex)
            Exit Sub
        End Try

        'RunThreadBranch
        'Dim frm1 As New Form1
        'frm1.ShowDialog()

        Dim isLoop As Boolean = True

        While (isLoop)
            ' Display login form and return the login result value
            If Not ShowLogin() Then
                isLoop = False
                'gStopSyncer = True
                'DataAccess.Commands.CloseConn()
                Application.Exit()
            Else
                'RunThread()
                If gBranchObj Is Nothing Then
                    Dim frm As New frmConfig
                    frm.ShowDialog()

                    frm.Dispose()
                    frm = Nothing
                Else

                    gRunThreadWebService()
                    gCloseComPort()
                    gOpenComPort()

                    Dim objMain As New frmMainMenu
                    objMain.WindowState = FormWindowState.Maximized
                    objMain.ShowDialog()

                    objMain.Dispose()
                    objMain = Nothing
                    gStopThread()
                End If
            End If

            ' Initialise the application
            '
            ' Display main application form


            ' Clean up objetcs
        End While

    End Sub

    '------------------------------------------------------------
    ' ShowLogin :-
    ' Display login form and return login result value
    '------------------------------------------------------------
    Private Function ShowLogin() As Boolean
        Dim objLogin As New frmLogin
        Dim result As Boolean = False

        ' Display login form
        If objLogin.ShowDialog = DialogResult.OK Then
            result = True
        End If

        objLogin.Dispose()
        objLogin = Nothing
        Return result

    End Function

   

End Module
