Imports Utils
Imports Utils.General
Imports DataAccess

Public Class frmLogin

#Region " Variables Declarations "

    Const FORMTITLE = "Login"

    Private m_intTimes As Integer
    Private m_showing As Boolean = True
    Private objDA As New DataAccessNut

#End Region

#Region " Initialisation "

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Initialise()
    End Sub

    Private Sub Initialise()
        AssignValue(gGetLocale(Me.Name, "title"), Me.Text)
        Messenger.Caption = Me.Text
        gSetLocaleChange(Me.Name, Me)

        CursorButtons(Me, Cursors.Hand)

        ClearFields()
        Me.Opacity = 0
        Me.Activate()
        Me.Refresh()
        fadeTimer.Start()
        Me.Refresh()
        UpdateControls()
    End Sub

#End Region

#Region " Utility Procedures "

    Private Function AuthenticateLogin(ByVal strUserName As String, ByVal strPassword As String) As Boolean

        Try
            gUserObj = objDA.GetUserPassword(strUserName, strPassword)
            If gUserObj Is Nothing Then
                Messenger.ShowInformation(gMSG_LOGIN_NOT_SUCCEED)
                Return False
            End If

            gBranchObj = objDA.GetBranch(gAppConfig.BranchId)
            If Not gBranchObj Is Nothing Then

                'Checking the current time
                If Not gCheckCurrentDateTime() Then Return False

                gPosLoginObj = objDA.GetPosLogin(gBranchObj.pkid, gSysConfig.PosId, gUserObj.userid)

                gPosEndDayClosingObj = objDA.GetEndDayClosing(gBranchObj.pkid, gSysConfig.PosId, gUserObj.userid)
            End If

            Return True

        Catch ex As Exception
            Messenger.Caption = FORMTITLE & " - AuthenticateLogin "
            Messenger.ShowError("User Login Error!")
            WriteToLogFile(ex.Message)

            Return False

        End Try

    End Function

    Private Sub fadeTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) _
                                   Handles fadeTimer.Tick
        Dim d As Double

        If m_showing Then
            d = (1000 / Me.fadeTimer.Interval) / 100
            If Me.Opacity + d >= 1.0 Then
                Me.Opacity = 1.0
                Me.fadeTimer.Stop()
            Else
                Me.Opacity += d
            End If
        Else
            d = (1000.0 / Me.fadeTimer.Interval) / 100.0
            If Me.Opacity - d <= 0.0 Then
                Me.Opacity = 0.0
                Me.fadeTimer.Stop()
            Else
                Me.Opacity -= d
            End If
        End If

    End Sub


#End Region

#Region " Controls Populating, Updating, etc "

    Private Sub UpdateControls()
        btnLogin.Enabled = txtUsername.Text.Length > 0 AndAlso txtPassword.Text.Trim.Length > 0
    End Sub

    Private Sub ClearFields()
        txtUsername.Text = String.Empty
        txtPassword.Text = String.Empty
    End Sub

#End Region

#Region " Event Handler/Response "

    Private Sub txtUsername_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsername.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                btnCancel.Focus()
            Case Keys.Down, Keys.Return
                txtPassword.SelectAll()
                txtPassword.Focus()
        End Select
    End Sub

    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                txtUsername.SelectAll()
                txtUsername.Focus()

            Case Keys.Down
                btnLogin.Focus()

            Case Keys.Return
                btnLogin.PerformClick()
        End Select
    End Sub

    Private Sub txtUserName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.TextChanged
        UpdateControls()
    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged
        UpdateControls()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click

        If txtUsername.Text.Trim.Length = 0 Or txtPassword.Text.Trim.Length = 0 Then
            Exit Sub
        End If

        Dim myCursor As New WaitCursor

        Try

            If AuthenticateLogin(txtUsername.Text.Trim, txtPassword.Text.Trim) Then
                Me.DialogResult = DialogResult.OK
            Else
                txtUsername.Focus()
                txtUsername.SelectAll()
                txtPassword.Clear()
            End If

        Catch ex As Exception
            Messenger.ShowError("User Login Error!")
            WriteToLogFile(ex.Message)

        Finally
            myCursor.Dispose()
        End Try

    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
                             Handles btnCancel.Click
        Application.Exit()

    End Sub

    Private Sub txtOpening_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOpening.KeyPress
        e.Handled = Utils.General.KeyPress("0123456789.", True, e)
    End Sub

#End Region

End Class

