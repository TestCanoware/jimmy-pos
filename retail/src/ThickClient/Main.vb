Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports Utils
Imports Utils.General

Module Main


    <STAThread()> _
    Public Sub Main()

        ' XP Theme style
        Application.EnableVisualStyles()
        Application.DoEvents()

        ' Check exist database
        Dim isCreateNewDB As Boolean = False
        Dim config As New SysConfig

        Try
            Dim comm As New DataAccess.Commands
            comm.ConnectDatabase()

        Catch ex As MySqlException
            '1042 - cannot connect MySQL server
            '1045 - password not correct
            '1049 - database not correct
            If (ex.Number = 1049) Then
                If Messenger.ShowQuestion(ex.Message & vbCrLf & "Do you want to create database '" & config.DB & "'?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    isCreateNewDB = True
                Else
                    Exit Sub
                End If
            Else
                Messenger.ShowError(ex)
                Exit Sub
            End If
        End Try
        

        If isCreateNewDB Then
            Dim frm As New frmInstallation
            frm.database = config.DB
            If Not frm.ShowDialog() = DialogResult.OK Then
                Exit Sub
            End If

        End If


        Try
            gSysConfig = New Utils.SysConfig            
            gLoadAppConfig()
            gLoadGlobalResource()

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
