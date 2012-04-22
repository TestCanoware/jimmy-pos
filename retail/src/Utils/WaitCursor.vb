Imports System
Imports System.Windows.Forms

Public NotInheritable Class WaitCursor
    Implements IDisposable

#Region " Variables "

    Private m_cursor As Cursor

#End Region

#Region " Constructor and Destructor "

    Sub New()
        InitializeComponent()

    End Sub

    Public Sub Dispose() Implements System.IDisposable.Dispose
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub

#End Region

#Region " Properties "


#End Region

#Region " Events "


#End Region

#Region " Procedures "

    Private Sub InitializeComponent()
        m_cursor = Cursor.Current
        Cursor.Current = Cursors.WaitCursor
    End Sub

    Protected Overrides Sub Finalize()
        Dispose(False)
    End Sub

    Private Sub Dispose(ByVal disposing As Boolean)
        If (disposing) Then
            If Not (m_cursor Is Nothing) Then
                Cursor.Current = m_cursor
                m_cursor = Nothing
            End If
        End If
    End Sub

#End Region

End Class
