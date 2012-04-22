
Public Class DAInvoiceItemObject

    Public mPkid As Long = 0
    Public mInvoiceId As Long = 0
    Public mPosItemId As Integer = 0
    Public mRemarks As String = ""
    Public mTotalQty As Decimal = 0
    Public mCurrency As String = ""
    Public mUnitPriceQuoted As Decimal = 0
    Public mStrName1 As String = ""
    Public mStrValue1 As String = ""
    Public mPic1 As Integer = 0
    Public mPic2 As Integer = 0
    Public mPic3 As Integer = 0
    Public mCurrency2 As String = ""
    Public mUnitPriceQuoted2 As Decimal = 0
    Public mTaxAmt As Decimal = 0
    Public mTaxAmt2 As Decimal = 0
    Public mStrName2 As String = ""
    Public mStrValue2 As String = ""
    Public mStrName3 As String = ""
    Public mStrValue3 As String = ""
    Public mIntName1 As String = ""
    Public mIntValue1 As Integer = 0
    Public mIntName2 As String = ""
    Public mIntValue2 As Integer = 0
    Public mBdName1 As String = ""
    Public mBdValue1 As Decimal = 0
    Public mStatus As String = DAInvoiceItem.STATUS_ACTIVE
    Public mState As String = ""
    Public mPosItemType As String = ""
    Public mItemId As Integer = 0
    Public mItemCode As String = ""
    Public mBarCode As String = ""
    Public mSerialized As Boolean
    Public mName As String = ""
    Public mOutstandingQty As Decimal = 0
    Public mPackage As Boolean
    Public mParentId As Long = 0
    Public mUnitCostMa As Decimal = 0
    Public mUnitPriceStd As Decimal = 0
    Public mUnitPriceStd2 As Decimal = 0
    Public mUnitDiscount As Decimal = 0
    Public mUnitDiscount2 As Decimal = 0
    Public mUnitCommission As Decimal = 0
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
    Public bomConvertTime As Date
    Public bomConvertUser As Integer = 0
    Public bomTargetLoc As Integer = 0
    Public bomSourceLoc As Integer = 0
    Public warrantyType As String = ""
    Public warrantyOption As String = ""
    Public warrantyExpiry As Date
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
    Public loyaltyProcessStatus As String = ""
    Public loyaltyProcessReversalStatus As String = ""
    Public loyaltyJTxnStatus As String = ""
    Public loyaltyJTxnReversalStatus As String = ""
    Public jobsheet_index_pkid As Long = 0
    Public package_group As String = ""
    Public taxCode As String = ""
    Public taxType As String = ""
    Public taxRate As Decimal = 0
    Public date_start As Date
    Public date_end As Date

    Public uom As String = ""
    Public taxOption As String = ""
    Public jobsheetItemId As Long

    Public Sub New()
        MyBase.new()
    End Sub

    Public Sub New(ByVal invObj As DAInvoiceObject, ByVal dr As DocRow)
        MyBase.New()

        Me.mInvoiceId = invObj.mPkid
        Me.mItemId = dr.itemId
        Me.mItemCode = dr.itemCode
        Me.mName = dr.itemName
        Me.mBarCode = dr.eanCode
        Me.stkId = dr.stockId
        Me.stkLocationId = invObj.mLocationId
        Me.mRemarks = dr.remarks

        Me.mCurrency = invObj.mCurrency
        Me.mPosItemType = dr.itemType.ToString

        Me.mTotalQty = dr.qty
        Me.mUnitCostMa = dr.unitCostMA
        Me.mUnitPriceQuoted = dr.GetPriceQuoted
        Me.mUnitPriceStd = dr.GetPriceStd
        Me.mUnitDiscount = dr.discount

        Me.mPic1 = invObj.salesId
        Me.mPic2 = invObj.salesId
        Me.mPic3 = invObj.salesId

        Me.mTaxAmt = dr.GetTaxAmount
        Me.taxCode = dr.taxCode
        Me.taxType = dr.taxType
        Me.taxRate = dr.taxRate

        Me.taxOption = dr.GetTaxOption

        If dr.docIndexTable = DAJobsheet.TABLENAME Then
            Me.jobsheet_index_pkid = dr.docIndexKey
        End If

        If dr.docItemTable = DAJobsheetItem.TABLENAME Then
            Me.jobsheetItemId = dr.docItemKey
        End If

    End Sub


    Public Function GetDocRow() As DocRow
        Dim dr As New DocRow

        dr.refKey = Me.mPkid
        dr.itemId = Me.mItemId
        dr.itemCode = Me.mItemCode
        dr.itemName = Me.mName
        dr.eanCode = Me.mBarCode
        dr.stockId = Me.stkId
        dr.itemType = Me.mPosItemType
        dr.qty = Me.mTotalQty
        dr.unitCostMA = Me.mUnitCostMa
        dr.price = Me.mUnitPriceStd
        dr.discount = Me.mUnitDiscount

        dr.taxCode = Me.taxCode
        dr.taxRate = Me.taxRate
        dr.taxType = Me.taxType

        dr.taxOption = Me.taxOption

        Return dr

    End Function


End Class
