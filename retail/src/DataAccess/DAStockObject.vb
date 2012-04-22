Public Class DAStockObject

    Public pkid As Integer = 0
    Public stockCode As String = ""
    Public description As String = ""
    Public itemId As Integer = 0
    Public locationId As Integer = 0
    Public accPCCenterId As Integer = 0
    Public balance As Decimal = 0
    Public conditionId As Integer = 0
    Public status As String = ""
    Public lastUpdate As New Date(2001, 1, 1, 0, 0, 1)
    Public userIdUpdate As Integer = 0
    Public guid As String = ""
    Public unitCostFifo As Decimal = 0
    Public unitCostMA As Decimal = 0
    Public unitCostWA As Decimal = 0
    Public unitCostLast As Decimal = 0
    Public unitCostReplacement As Decimal = 0
    Public lastPurchaseDate As New Date(2001, 1, 1, 0, 0, 1)
    Public minQty As Integer = 0
    Public maxQty As Integer = 0
    Public subLocation As String = ""

End Class
