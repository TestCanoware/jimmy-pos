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
    Public itemType As String = TYPE_NORMAL
    Public remarks As String = ""

    Public taxCode As String = ""
    Public taxType As String = ""
    Public taxRate As Decimal = 0

    Public entityKey As Integer = 0
    Public entityName As String = ""
    Public entityTable As String = ""

    Public refKey As Long = 0
    Public refTable As String = ""

    Public glCodeCredit As String = "'"
    Public glCodeDebit As String = ""
    Public isDeleted As Boolean = False
    Public tag As Object

    Public taxEnabled As Boolean = False

    Public guid As String = ""
    Public description As String = ""
    Public synchoKey As String

    ' 20100226 Jimmy -> used for document link of index and item table.
    Public docIndexKey As Long = 0
    Public docIndexTable As String = ""
    Public docItemKey As Long = 0
    Public docItemTable As String = ""
    ' End 20100226 Jimmy

    Public taxOption As String = ""
    Public serialized As Boolean = False
    Public arrSerials As New ArrayList

    Public Const TYPE_NORMAL = "NORMAL"
    Public Const TYPE_FOC = "FOC"
    Public Const TYPE_GOODS_EXCHANGE = "GOODS_EXCHANGE"
    Public Const TYPE_FIVE_CENT_ITEM = "FIVE_CENT_ITEM"

    Public Const TAX_OPTION_INCLUDE_TAX = "INCLUDE_TAX"
    Public Const TAX_OPTION_EXCLUDE_TAX = "EXCLUDE_TAX"

    Public Sub New()
        MyBase.New()

        guid = System.Guid.NewGuid.ToString
    End Sub

    Public Function GetNewBal() As Decimal
        Return balQty - qty
    End Function

    Public Function GetNetPrice() As Decimal
        Dim netPrice As Decimal = 0
        netPrice = price - discount

        Return netPrice

    End Function

    Public Function GetPriceStd() As Decimal
        Dim netPrice As Decimal = price

        Return netPrice

    End Function

    Public Function GetAmount() As Decimal
        Return qty * GetNetPrice()
    End Function

    Public Function GetUnitTax() As Decimal
        If qty > 0 Then
            Return GetTaxAmount() / qty
        End If

        Return GetTaxAmount()
    End Function

    Public Function GetTaxAmount() As Decimal
        Dim taxAmt As Decimal = 0
        If isPriceIncludeTax() Then
            taxAmt = GetAmount() * (taxRate * 100) / (100 + (taxRate * 100))
        Else
            taxAmt = GetAmount() * taxRate
        End If

        Return taxAmt
    End Function

    Public Function GetPriceQuoted() As Decimal
        Dim priceQuoted As Decimal
        priceQuoted = GetNetPrice()

        If Not (isPriceIncludeTax) Then
            priceQuoted = priceQuoted + GetUnitTax()
        End If

        Return priceQuoted

    End Function

    Public Function GetTaxOption() As String
        Return taxOption
    End Function

    Public Function isPriceIncludeTax() As Boolean
        If (taxOption = DocRow.TAX_OPTION_INCLUDE_TAX) Then
            Return True
        End If
        Return False
    End Function


End Class
