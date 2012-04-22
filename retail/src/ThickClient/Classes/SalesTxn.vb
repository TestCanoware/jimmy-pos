Public Class SalesTxn

    Private mCustomerId As Integer
    Private mSalesId As Integer
    Private mRemarks As String
    Private mArrDocRow As New ArrayList
    Private mTotalAmount As Decimal
    Private mTxnTime As Date

    Public Property CustomerId() As Integer
        Get
            Return mCustomerId
        End Get
        Set(ByVal value As Integer)
            mCustomerId = value
        End Set
    End Property

    Public Property SalesId() As Integer
        Get
            Return mSalesId
        End Get
        Set(ByVal value As Integer)
            mSalesId = value
        End Set
    End Property

    Public Property Remarks() As String
        Get
            Return mRemarks
        End Get
        Set(ByVal value As String)
            mRemarks = value
        End Set
    End Property

    Public Property ArrDocRow() As ArrayList
        Get
            Return mArrDocRow
        End Get
        Set(ByVal value As ArrayList)
            mArrDocRow = value
        End Set
    End Property

    Public Property TotalAmount() As Decimal
        Get
            Return mTotalAmount
        End Get
        Set(ByVal value As Decimal)
            mTotalAmount = value
        End Set
    End Property

    Public Property TxnTime() As Date
        Get
            Return mTxnTime
        End Get
        Set(ByVal value As Date)
            mTxnTime = value
        End Set
    End Property

End Class
