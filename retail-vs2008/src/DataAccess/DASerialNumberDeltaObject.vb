Public Class DASerialNumberDeltaObject

    Public guid As String = ""
    Public parentGuid As String = ""
    Public name_space As String = ""
    Public txnType As String = ""
    Public txnCode As String = ""
    Public serialNumber As String = ""
    Public personInCharge As Integer = 0
    Public processNode As Integer = 0
    Public stockId As Integer = 0
    Public itemId As Integer = 0
    Public itemCode As String = ""
    Public refStockId As Integer = 0
    Public quantity As Decimal = 0
    Public currency As String = ""
    Public unitPrice As Decimal = 0
    Public currency2 As String = ""
    Public unitPrice2 As Decimal = 0
    Public txnTime As New Date(2001, 1, 1, 0, 0, 1)
    Public schTime As New Date(2001, 1, 1, 0, 0, 1)
    Public warrantyStart As New Date(2001, 1, 1, 0, 0, 1)
    Public warrantyEnd As New Date(2001, 1, 1, 0, 0, 1)
    Public remarks As String = ""
    Public intReserved1 As Integer = 0
    Public strReserved1 As String = ""
    Public strReserved2 As String = ""
    Public strReserved3 As String = ""
    Public strReserved4 As String = ""
    Public entityTable As String = ""
    Public entityId As Integer = 0
    Public docTable As String = ""
    Public docKey As Long = 0
    Public state As String = ""
    Public status As String = ""
    Public userIdEdit As Integer = 0
    Public timeEdit As New Date(2001, 1, 1, 0, 0, 1)
    Public stockDelta As Long = 0
    Public loyaltyLogic As String = ""
    Public loyaltyPointsAwarded As Decimal = 0
    Public loyaltyPointsRedeemed As Decimal = 0

End Class
