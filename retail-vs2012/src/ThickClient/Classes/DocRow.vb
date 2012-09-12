Public Class DocRow

    Public itemId As Integer = 0
    Public itemCode As String = ""
    Public eanCode As String = ""
    Public itemName As String = ""
    Public qty As Integer = 1
    Public price As Decimal = 0
    Public balQty As Integer = 0
    Public unitCostMA As Decimal = 0
    Public stockId As Integer = 0
    Public minPrice As Decimal = 0
    Public discount As Decimal = 0

    Public taxAmt As Decimal = 0
    Public taxCode As String = ""
    Public taxType As String = ""
    Public taxRate As Decimal = 0

    Public Function GetAmount() As Decimal
        Return qty * (price - discount)
    End Function

    Public Function GetNewBal() As Decimal
        Return balQty - qty
    End Function

    Public Function GetNetPrice() As Decimal
        Return price - discount
    End Function

End Class
