Imports Utils.General

Public Class DAPaymentVoucherItemObject

    Public pkid As Long = 0
    Public indexId As Long = 0
    Public position As Integer = 0
    Public uuid As String = System.Guid.NewGuid.ToString
    Public txnType As String = ""
    Public txnCode As String = ""
    Public chequeNo As String = ""
    Public pcCenter As Integer = 0
    Public branch As Integer = 0
    Public category As String = ""
    Public project As String = ""
    Public glCodeDebit As String = ""
    Public glCodeCredit As String = ""
    Public currency As String = ""
    Public amount As Decimal = 0
    Public xrate As Decimal = 0
    Public currency2 As String = ""
    Public amount2 As Decimal = 0
    Public referenceNo As String = ""
    Public description As String = ""
    Public remarks As String = ""
    Public info1 As String = "" ' store synchro_key of acc_receipt_index (ref table)
    Public info2 As String = "" ' store acc_receipt_index (ref table)
    Public entityTable As String = ""
    Public entityKey As Integer = 0
    Public entityName As String = ""
    Public dateStmt As Date = GetDefaultDate()
    Public dateItem As Date = GetDefaultDate()
    Public userIdPIC As Integer = 0
    Public state As String = DAPaymentVoucherItem.STATE_CREATED
    Public status As String = DAPaymentVoucherItem.STATUS_ACTIVE

    Public Sub New()
        MyBase.new()
    End Sub

    Public Sub New(ByVal pvObj As DAPaymentVoucherObject, ByVal dr As DocRow)
        MyBase.New()

        Me.indexId = pvObj.pkid
        Me.pcCenter = pvObj.pcCenter
        Me.branch = pvObj.branch
        Me.currency = pvObj.currency
        Me.dateStmt = pvObj.dateStmt
        Me.glCodeCredit = dr.glCodeCredit
        Me.glCodeDebit = dr.glCodeDebit
        Me.amount = dr.price
        Me.entityKey = dr.entityKey
        Me.entityName = dr.entityName
        Me.entityTable = dr.entityTable
        Me.dateItem = pvObj.dateStmt
        Me.userIdPIC = pvObj.userIdPIC
        Me.referenceNo = dr.refKey
        Me.info1 = dr.synchoKey
        Me.info2 = dr.refTable

    End Sub

End Class
