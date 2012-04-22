Imports Utils
Imports System.Reflection
Imports System.IO

Public Class frmInstallation

    Private Sub btnAttach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAttach.Click

        Dim cursors As New WaitCursor

        Try
            Dim assembly1 As Assembly = Assembly.GetExecutingAssembly()
            Dim sqlStreamReader As New StreamReader(assembly1.GetManifestResourceStream("ThickClient.wsemp.sql"))
            Dim strSQL As String = sqlStreamReader.ReadToEnd()

            Dim comm As New DataAccess.Commands
            comm.ConnectDatabase("mysql")

            comm.ExecuteNonQuery(strSQL)

            General.SetAppSettingKey(gAPP_KEY_THICK_CLIENT_IS_INSTALL, 1)

            Messenger.ShowInformation("Application is successfully installed.")

            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            Messenger.ShowError(ex)

        Finally
            cursors.Dispose()
        End Try

    End Sub


    Private Sub frmInstallaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Messenger.Caption = Me.Text
    End Sub


End Class