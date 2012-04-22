Imports System.IO

Public Class SysConfig

    Public Server As String
    Public UserId As String
    Public Password As String
    Public DB As String
    Public PosId As Integer
    Public CashDrawerCode As String
    Public LeftMargin As String
    Public RightMargin As String
    Public TopMargin As String
    Public BottomMargin As String
    Public DisplayPoleComPort As String
    Public DisplayPoleBaudRate As String
    Public DisplayPoleParity As String
    Public DisplayPoleDataBits As String
    Public DisplayPoleStopBits As String

    Public Sub New()
        Dim ini As New INIFile
        Dim filename As String

        filename = Path.Combine(AppPath, Path.Combine("Data", "SysConfig.ini"))
        ini.LoadINI(filename)

        Server = ini.GetSection("Server").GetKey("Server").value
        UserId = ini.GetSection("Database").GetKey("UserId").value
        Password = ini.GetSection("Database").GetKey("Password").value
        DB = ini.GetSection("Database").GetKey("DB").value
        PosId = ini.GetSection("POS").GetKey("PosId").value
        CashDrawerCode = ini.GetSection("POS").GetKey("CashDrawerCode").value

        LeftMargin = ini.GetSection("Report").GetKey("LeftMargin").value
        RightMargin = ini.GetSection("Report").GetKey("RightMargin").value
        TopMargin = ini.GetSection("Report").GetKey("TopMargin").value
        BottomMargin = ini.GetSection("Report").GetKey("BottomMargin").value

        'Display Pole
        DisplayPoleComPort = ini.GetSection("DisplayPole").GetKey("ComPort").value
        DisplayPoleBaudRate = ini.GetSection("DisplayPole").GetKey("BaudRate").value
        DisplayPoleParity = ini.GetSection("DisplayPole").GetKey("Parity").value
        DisplayPoleDataBits = ini.GetSection("DisplayPole").GetKey("DataBits").value
        DisplayPoleStopBits = ini.GetSection("DisplayPole").GetKey("StopBits").value

        ini = Nothing
    End Sub

    Private Function AppPath() As String
        Return System.Windows.Forms.Application.StartupPath
    End Function

End Class
