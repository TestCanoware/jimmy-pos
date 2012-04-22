Imports Utils
Imports Utils.General
Imports DataAccess

Public Class frmUserPassword

    Public permission As String
    Public objDA As New DataAccessNut

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If txtUser.TextLength = 0 Or txtPassword.TextLength = 0 Then
            Exit Sub
        End If

        Dim userId As Integer
        Dim userObj As New DAUserObject


        userObj = objDA.GetUserPassword(txtUser.Text.Trim, txtPassword.Text.Trim)
        If userObj Is Nothing Then
            Messenger.ShowInformation(gMSG_LOGIN_NOT_SUCCEED)
            Exit Sub
        End If

        userId = userObj.userid
        
        If Not userId = 500 Then
            If Not objDA.isExistUserPermission(userId, permission) Then
                Messenger.ShowInformation(gMSG_LOGIN_NOT_SUCCEED)
                Exit Sub
            End If
        End If

        Me.DialogResult = Windows.Forms.DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.No
        Me.Close()
    End Sub

    Private Sub frmUserPassword_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AssignValue(gGetLocale(Me.Name, "title"), Me.Text)
        Messenger.Caption = Me.Text
        gSetLocaleChange(Me.Name, Me)
    End Sub
End Class
