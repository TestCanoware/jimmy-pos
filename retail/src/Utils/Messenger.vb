Imports System
Imports System.Windows.Forms

Public NotInheritable Class Messenger

#Region " Variables "

    Private Const FILE_OPEN_ERROR_MSG = "Error opening file:"
    Private Const FILE_SAVE_ERROR_MSG = "Error saving file:"

#End Region

#Region " Constructor and Destructor "

    Sub New()
        InitializeComponent()

    End Sub

#End Region

#Region " Properties "

    Private Shared m_caption As String
    Public Shared Property Caption() As String
        Get
            Return m_caption
        End Get
        Set(ByVal Value As String)
            m_caption = Value
        End Set
    End Property

#End Region

#Region " Events "


#End Region

#Region " Procedures "

    Private Sub InitializeComponent()

    End Sub

    Public Shared Sub ShowError(ByVal ex As Exception)
        Show(ex.Message, MessageBoxIcon.Error, MessageBoxButtons.OK)
        General.WriteToLogFile("Error: " & ex.Message)
    End Sub

    Public Shared Sub ShowError(ByVal message As String)
        Show(message, MessageBoxIcon.Error, MessageBoxButtons.OK)
        General.WriteToLogFile("Error: " & message)
    End Sub

    Public Shared Sub ShowWarning(ByVal ex As Exception)
        Show(ex.Message, MessageBoxIcon.Exclamation, MessageBoxButtons.OK)
    End Sub

    Public Shared Sub ShowWarning(ByVal message As String)
        Show(message, MessageBoxIcon.Exclamation, MessageBoxButtons.OK)
    End Sub

    Public Shared Function ShowQuestion(ByVal message As String, ByVal buttons As MessageBoxButtons) As DialogResult
        Return Show(message, MessageBoxIcon.Question, buttons)
    End Function

    Public Shared Function ShowQuestion(ByVal message As String, ByVal icon As MessageBoxIcon, ByVal buttons As MessageBoxButtons) As DialogResult
        Return Show(message, icon, buttons)
    End Function

    Public Shared Sub ShowInformation(ByVal message As String)
        Show(message, MessageBoxIcon.Information, MessageBoxButtons.OK)
    End Sub

    Public Shared Sub Show(ByVal ex As Exception, ByVal icon As MessageBoxIcon)
        Show(ex.Message, icon, MessageBoxButtons.OK)
    End Sub

    Public Shared Sub ShowFileOpenError(ByVal fileName As String, ByVal ex As Exception)
        If ((Not fileName Is Nothing) AndAlso (fileName <> String.Empty)) Then
            If (Not ex Is Nothing) Then
                Show(String.Format("{0}{2}{1}{2}{2}{3}", FILE_OPEN_ERROR_MSG, fileName, Environment.NewLine, ex.Message), MessageBoxIcon.Exclamation, MessageBoxButtons.OK)
            Else
                Show(String.Format("{0}{1}", FILE_OPEN_ERROR_MSG, fileName), MessageBoxIcon.Exclamation, MessageBoxButtons.OK)
            End If
        Else
            If (Not ex Is Nothing) Then
                Show(String.Format("{0}{1}{1}{2}", FILE_OPEN_ERROR_MSG, Environment.NewLine, ex.Message), MessageBoxIcon.Exclamation, MessageBoxButtons.OK)
            Else
                Show(FILE_OPEN_ERROR_MSG, MessageBoxIcon.Exclamation, MessageBoxButtons.OK)
            End If
        End If
    End Sub

    Public Shared Sub ShowFileSaveError(ByVal fileName As String, ByVal ex As Exception)
        If ((Not fileName Is Nothing) AndAlso (fileName <> String.Empty)) Then
            If (Not ex Is Nothing) Then
                ShowError(String.Format("{0}{2}{1}{2}{2}{3}", FILE_SAVE_ERROR_MSG, fileName, Environment.NewLine, ex.Message))
            Else
                ShowError(String.Format("{0}{1}", FILE_SAVE_ERROR_MSG, fileName))
            End If
        Else
            If (Not ex Is Nothing) Then
                ShowError(String.Format("{0}{1}{1}{2}", FILE_SAVE_ERROR_MSG, Environment.NewLine, ex.Message))
            Else
                ShowError(FILE_SAVE_ERROR_MSG)
            End If
        End If
    End Sub

    Public Shared Function Show(ByVal message As String, ByVal icon As MessageBoxIcon, ByVal buttons As MessageBoxButtons) As DialogResult
        Return MessageBox.Show(message, Caption, buttons, icon)
    End Function

#End Region

End Class
