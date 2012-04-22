Imports Utils.General

Public Class DAJobsheetItemObject

    Public pkid As Long = 0
    Public indexId As Long = 0
    Public itemType As String = ""
    Public itemId As Integer = 0
    Public itemCode As String = ""
    Public barCode As String = ""
    Public serialized As Boolean = False
    Public name As String = ""
    Public isPackage As Boolean = False
    Public parentId As Long = 0
    Public position As Integer = 0
    Public remarks As String = ""
    Public description As String = ""
    Public pic1 As Integer = 0
    Public pic2 As Integer = 0
    Public pic3 As Integer = 0
    Public quantity As Decimal = 0
    Public currency As String = ""
    Public unitPriceList As Decimal = 0
    Public unitDiscount As Decimal = 0
    Public unitPriceNet As Decimal = 0
    Public taxType As String = ""
    Public unitTax As Decimal = 0
    Public currency2 As String = ""
    Public unitPriceList2 As Decimal = 0
    Public unitDiscount2 As Decimal = 0
    Public unitPriceNet2 As Decimal = 0
    Public taxType2 As String = ""
    Public unitTax2 As Decimal = 0
    Public unitCostMA As Decimal = 0
    Public unitPriceStd As Decimal = 0
    Public unitCommission As Decimal = 0
    Public codeProject As String = ""
    Public codeDepartment As String = ""
    Public codeDealer As String = ""
    Public codeSalesman As String = ""
    Public stkId As Integer = 0
    Public stkLocationId As Integer = 0
    Public stkLocationCode As String = ""
    Public bomConvertMode As String = ""
    Public bomId As Integer = 0
    Public bomConvertStatus As String = ""
    Public bomConvertTime As Date = GetDefaultDate
    Public bomConvertUser As Integer = 0
    Public bomTargetLoc As Integer = 0
    Public bomSourceLoc As Integer = 0
    Public warrantyType As String = ""
    Public warrantyOption As String = ""
    Public warrantyExpiry As Date = GetDefaultDate
    Public status As String = ""
    Public pseudoLogic As String = ""
    Public pseudoCode As String = ""
    Public pseudoName As String = ""
    Public pseudoDescription As String = ""
    Public pseudoCurrency As String = ""
    Public pseudoPrice As Decimal = 0
    Public pseudoQty As Decimal = 0
    Public loyaltyLogic As String = ""
    Public loyaltyPointsAwarded As Decimal = 0
    Public loyaltyPointsRedeemed As Decimal = 0
    Public package_group As String = ""
    Public expiryStatus As String = ""
    Public taxCode As String = ""
    Public taxRate As Decimal = 0
    Public taxOption As String = ""
    Public taxAmt As Decimal = 0
    Public taxAmt2 As Decimal = 0

    Public Sub New()
        MyBase.new()
    End Sub

    Public Sub New(ByVal jobsheetObj As DAJobsheetObject, ByVal dr As DocRow)
        MyBase.New()

        Me.indexId = jobsheetObj.pkid
        Me.itemId = dr.itemId
        Me.itemCode = dr.itemCode
        Me.name = dr.itemName
        Me.barCode = dr.eanCode
        Me.stkId = dr.stockId
        Me.stkLocationId = jobsheetObj.location
        Me.currency = jobsheetObj.currency
        Me.itemType = dr.itemType

        Me.quantity = dr.qty
        Me.unitCostMA = dr.unitCostMA
        Me.unitPriceList = dr.price
        Me.unitPriceNet = dr.GetPriceQuoted
        Me.unitPriceStd = dr.GetNetPrice
        Me.unitDiscount = dr.discount

        Me.pic1 = jobsheetObj.salesId
        Me.pic2 = jobsheetObj.salesId
        Me.pic3 = jobsheetObj.salesId

        Me.taxCode = dr.taxCode
        Me.taxType = dr.taxType
        Me.taxRate = dr.taxRate

        Me.unitTax = IIf(dr.qty > 0, dr.GetTaxAmount / dr.qty, 0)
        Me.package_group = dr.guid
        Me.remarks = dr.remarks
        Me.taxOption = dr.taxOption
        Me.taxAmt = dr.GetTaxAmount

    End Sub


    Public Function GetDocRow() As DocRow
        Dim dr As New DocRow

        dr.refKey = Me.pkid
        dr.itemId = Me.itemId
        dr.itemCode = Me.itemCode
        dr.itemName = Me.name
        dr.eanCode = Me.barCode
        dr.stockId = Me.stkId
        dr.itemType = Me.itemType
        dr.qty = Me.quantity
        dr.unitCostMA = Me.unitCostMA
        dr.price = Me.unitPriceList
        dr.discount = Me.unitDiscount
        dr.remarks = Me.remarks
        dr.guid = Me.package_group

        dr.taxCode = Me.taxCode
        dr.taxType = Me.taxType
        dr.taxRate = Me.taxRate

        dr.docItemTable = DAJobsheetItem.TABLENAME
        dr.docItemKey = Me.pkid

        dr.taxOption = Me.taxOption
        Return dr

    End Function

End Class
