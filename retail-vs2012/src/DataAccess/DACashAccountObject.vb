Public Class DACashAccountObject

    Public pkId As Integer = 0
    Public code As String = ""
    Public name As String = ""
    Public description As String = ""
    Public accountNumber As String = ""
    Public accountType As String = ""
    Public currency As String = ""
    Public levelLow As Decimal = 0
    Public levelHigh As Decimal = 0
    Public facilityAmount As Decimal = 0
    Public overdraftLimit As Decimal = 0
    Public signatory1 As String = ""
    Public signatory2 As String = ""
    Public signatory3 As String = ""
    Public signatory4 As String = ""
    Public signature As Byte()
    Public pcCenter As Integer = 0
    Public add1 As String = ""
    Public add2 As String = ""
    Public add3 As String = ""
    Public state As String = ""
    Public country As String = ""
    Public phone As String = ""
    Public contactPerson As String = ""
    Public fax As String = ""
    Public userIdCreate As Integer = 0
    Public userIdUpdate As Integer = 0
    Public createTime As New Date(2001, 1, 1, 0, 0, 1)
    Public lastUpdate As New Date(2001, 1, 1, 0, 0, 1)
    Public status As String = ""

End Class
