Public Class DAInvoiceObject

    Public mPkid As Long = 0
    Public mStmtNumber As Long = 0
    Public mSalesTxnId As Long = 0
    Public mPaymentTermsId As Integer = 0
    Public mTimeIssued As Date
    Public mCurrency As String = ""
    Public mTotalAmt As Decimal = 0
    Public mOutstandingAmt As Decimal = 0
    Public mOutstandingBfPdc As Decimal = 0
    Public mRemarks As String = ""
    Public mState As String = DAInvoice.ST_CREATED
    Public mStatus As String = DAInvoice.STATUS_ACTIVE
    Public mLastUpdate As Date
    Public mUserIdUpdate As Integer = 0
    Public mEntityTable As String = ""
    Public mEntityKey As Integer = 0
    Public mEntityName As String = ""
    Public mEntityCode As String = ""
    Public mIdentityNumber As String = ""
    Public mEntityContactPerson As String = ""
    Public mForeignTable As String = ""
    Public mForeignKey As Integer = 0
    Public mForeignText As String = ""
    Public mCustSvcCtrId As Integer = 0
    Public mLocationId As Integer = 0
    Public mPCCenter As Integer = 0
    Public mTxnType As String = ""
    Public mStmtType As String = ""
    Public mReferenceNo As String = ""
    Public mDescription As String = ""
    Public mWorkOrder As Long = 0
    Public mDeliveryOrder As Long = 0
    Public mReceiptId As Long = 0
    Public mDisplayFormat As String = ""
    Public mDocType As String = ""
    Public billingHandphone As String = ""
    Public billingPhone1 As String = ""
    Public billingPhone2 As String = ""
    Public billingFax As String = ""
    Public billingEmail As String = ""
    Public billingCompanyName As String = ""
    Public billingAdd1 As String = ""
    Public billingAdd2 As String = ""
    Public billingAdd3 As String = ""
    Public billingCity As String = ""
    Public billingZip As String = ""
    Public billingState As String = ""
    Public billingCountry As String = ""
    Public receiverName As String = ""
    Public receiverHandphone As String = ""
    Public receiverPhone1 As String = ""
    Public receiverPhone2 As String = ""
    Public receiverFax As String = ""
    Public receiverEmail As String = ""
    Public receiverCompanyName As String = ""
    Public receiverAdd1 As String = ""
    Public receiverAdd2 As String = ""
    Public receiverAdd3 As String = ""
    Public receiverCity As String = ""
    Public receiverZip As String = ""
    Public receiverState As String = ""
    Public receiverCountry As String = ""
    Public terms1Option As String = ""
    Public terms1Date As Date
    Public terms1DiscPct As Decimal = 0
    Public terms1DiscAmt As Decimal = 0
    Public terms2Option As String = ""
    Public terms2Date As Date
    Public terms2DiscPct As Decimal = 0
    Public terms2DiscAmt As Decimal = 0
    Public rebate1Option As String = ""
    Public rebate1Date As Date
    Public rebate1Gain As Decimal = 0
    Public rebate1Consume As Decimal = 0
    Public rebate2Option As String = ""
    Public rebate2Date As Date
    Public rebate2Gain As Decimal = 0
    Public rebate2Consume As Decimal = 0
    Public codeDept As String = ""
    Public codeProject As String = ""
    Public codeSupplier As String = ""
    Public subtype1 As String = ""
    Public subtype2 As String = ""
    Public subtype3 As String = ""
    Public accidentDate As Date
    Public policyNumber As String = ""
    Public loyaltyCardStatus As String = ""
    Public loyaltyCardPkid As Long = 0
    Public claimAmount As Decimal = 0
    Public salesId As Integer = 0
    Public trackingNo As String = ""
    Public guid As String = ""
    Public taxAmount As Decimal = 0
    Public taxType As String = ""
    Public loyaltyProcessStatus As String = ""
    Public loyaltyProcessReversalStatus As String = ""
    Public loyaltyJTxnStatus As String = ""
    Public loyaltyJTxnReversalStatus As String = ""
    Public loyaltyPointsAwarded As Decimal = 0
    Public loyaltyPointsRedeemed As Decimal = 0
    Public mCurrency2 As String = ""
    Public mTotalAmt2 As Decimal = 0
    Public mOutstandingAmt2 As Decimal = 0
    Public taxAmount2 As Decimal = 0
    Public xrate As Decimal = 0
    Public mCostOfGoodsSold As Decimal = 0
    Public mDefaultRowsNumber As Integer = 0
    Public incoterms As String = ""
    Public permitNo As String = ""
    Public permitDoc1 As String = ""
    Public permitDoc2 As String = ""
    Public permitDoc3 As String = ""
    Public txnDoc1 As String = ""
    Public txnDoc2 As String = ""
    Public txnDoc3 As String = ""
    Public transportDoc1 As String = ""
    Public transportDoc2 As String = ""
    Public transportDoc3 As String = ""
    Public transportDate As Date
    Public tradersRemarks As String = ""
    Public synchroKey As String = System.Guid.NewGuid.ToString

    Public arrItems As New ArrayList

    '20100226 Jimmy
    Public membershipCardPkid As Long = 0
    Public groupDiscount As Decimal = 0
    Public consignmentId As Long = 0
    Public posId As Integer = 0

End Class
