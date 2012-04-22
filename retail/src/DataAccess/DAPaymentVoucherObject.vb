Imports Utils.General

Public Class DAPaymentVoucherObject

    Public pkid As Long = 0
    Public stmtNo As Long = 0
    Public uuid As String = System.Guid.NewGuid.ToString
    Public pcCenter As Integer = 0
    Public branch As Integer = 0
    Public currency As String = ""
    Public amountTotal As Decimal = 0
    Public xrate As Decimal = 0
    Public currency2 As String = ""
    Public amountTotal2 As Decimal = 0
    Public glCodeDebit As String = ""
    Public glCodeCredit As String = ""
    Public cashbookCash As Integer = 0
    Public cashbookCard As Integer = 0
    Public cashbookCheque As Integer = 0
    Public cashbookPDCheque As Integer = 0
    Public cashbookCoupon As Integer = 0
    Public cashbookOther As Integer = 0
    Public amountCash As Decimal = 0
    Public amountCard As Decimal = 0
    Public amountCheque As Decimal = 0
    Public amountPDCheque As Decimal = 0
    Public amountCoupon As Decimal = 0
    Public amountOther As Decimal = 0
    Public payTo As String = ""
    Public referenceNo As String = ""
    Public chequeNo As String = ""
    Public description As String = ""
    Public remarks As String = ""
    Public info1 As String = ""
    Public info2 As String = ""
    Public dateStmt As Date = GetDefaultDate()
    Public dateCreated As Date = GetDefaultDate()
    Public dateApproved As Date = GetDefaultDate()
    Public dateVerified As Date = GetDefaultDate()
    Public dateUpdate As Date = GetDefaultDate()
    Public userIdCreate As Integer = 0
    Public userIdPIC As Integer = 0
    Public userIdApprove As Integer = 0
    Public userIdVerified As Integer = 0
    Public userIdUpdate As Integer = 0
    Public reserved1 As String = ""
    Public reserved2 As String = ""
    Public state As String = DAPaymentVoucher.STATE_CREATED
    Public status As String = DAPaymentVoucher.STATUS_ACTIVE
    Public remarksReverse As String = ""
    Public openBalance As Decimal = 0
    Public openBalance2 As Decimal = 0
    Public internalStatus As String = ""
    Public synchroKey As String = System.Guid.NewGuid.ToString

    Public arrItems As New ArrayList

End Class
