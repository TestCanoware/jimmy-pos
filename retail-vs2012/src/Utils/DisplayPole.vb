Imports System.IO.Ports

Public Class DisplayPole    

    Private srPort As SerialPort

    Public Sub OpenPort(ByVal Port As String, _
       ByVal BaudRate As Integer, ByVal DataBit As Integer, _
       ByVal Parity As Integer, ByVal StopBit As Integer)

        srPort = New SerialPort(Port, BaudRate, Parity, 8, StopBit)
        If Not srPort.IsOpen Then srPort.Open()

    End Sub


    'To clear Display.....
    Public Sub ClearDisplay()

        srPort.Write(" ".PadRight(40))
        'srPort.WriteLine(" ".PadRight(20))

    End Sub

    'Display Function 
    ''line' 1 for First line and 0 For second line
    Public Sub Display(ByVal textToDisplay As String, ByVal line As Integer)
        If (line = 0) Then
            srPort.Write(textToDisplay.PadRight(20))
        Else
            srPort.Write(vbCrLf & textToDisplay.PadRight(20))
        End If
    End Sub

    Public Sub Display(ByVal textToDisplay As String)
        srPort.Write(textToDisplay)
    End Sub

    Public Function isOpen() As Boolean
        If srPort Is Nothing Then
            Return False
        End If
        Return srPort.IsOpen
    End Function

    Public Sub Close()

        If srPort Is Nothing Then
            Exit Sub
        End If

        Try
            If srPort.IsOpen Then
                srPort.Close()
            End If

        Catch ex As Exception
            srPort = Nothing
        End Try

    End Sub

End Class
