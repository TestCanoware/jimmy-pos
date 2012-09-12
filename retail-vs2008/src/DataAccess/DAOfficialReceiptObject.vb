Imports Utils
Imports Utils.General

Public Class DAOfficialReceiptObject

    Public pkid As Long = 0
    Public stmtNumber As Long = 0
    Public entityTable As String = ""
    Public entityKey As Integer = 0
    Public entityName As String = ""
    Public intReserved1 As Integer = 0
    Public strReserved1 As String = ""
    Public currency As String = ""
    Public amount As Decimal = 0
    Public currency2 As String = ""
    Public amount2 As Decimal = 0
    Public paymentTime As Date = GetDefaultDate()
    Public paymentMethod As String = ""
    Public paymentRemarks As String = ""
    Public chequeNumber As String = ""
    Public state As String = ""
    Public status As String = DAOfficialReceipt.STATUS_ACTIVE
    Public lastUpdate As Date = GetDefaultDate()
    Public userIdUpdate As Integer = 0
    Public cbCash As Integer = 0
    Public cbCard As Integer = 0
    Public cbCheque As Integer = 0
    Public cbPDCheque As Integer = 0
    Public cbCoupon As Integer = 0
    Public cbOther As Integer = 0
    Public amountCash As Decimal = 0
    Public amountCard As Decimal = 0
    Public amountCheque As Decimal = 0
    Public amountPDCheque As Decimal = 0
    Public amountCoupon As Decimal = 0
    Public amountOther As Decimal = 0
    Public datePDCheque As Date = GetDefaultDate()
    Public chequeNumberPD As String = ""
    Public branch As Integer = 0
    Public pcCenter As Integer = 0
    Public cardPctCharges As Decimal = 0
    Public cardCharges As Decimal = 0
    Public cardType As String = ""
    Public cardCB As Integer = 0
    Public pdcExist As Boolean
    Public pdcClear As Boolean
    Public glCodeCredit As String = "accReceivable"
    Public openBalance As Decimal = 0
    Public cardSurcharge As Decimal = 0
    Public chequeChargesAmount As Decimal = 0
    Public reversePayment As Long = 0
    Public eTfrCashbook As Integer = 0
    Public eTfrReference As String = ""
    Public eTfrBank As String = ""
    Public eTfrRmks As String = ""
    Public eTfrDate As Date = GetDefaultDate()
    Public eTfrAmount As Decimal = 0
    Public eTfrCharges As Decimal = 0
    Public cardBank As String = ""
    Public cardName As String = ""
    Public cardNumber As String = ""
    Public cardSecurityNum As String = ""
    Public cardValidFrom As Date = GetDefaultDate()
    Public cardValidThru As Date = GetDefaultDate()
    Public pic1 As Integer = 0
    Public pic2 As Integer = 0
    Public pic3 As Integer = 0
    Public format As String = ""
    Public chequeStatus As String = ""
    Public chequeBankInCb As Integer = 0
    Public pdChequeStatus As String = ""
    Public pdChequeBankInCb As Integer = 0
    Public cardApprovalParty As String = ""
    Public cardApprovalCode As String = ""
    Public cardApprovalTime As Date = GetDefaultDate()
    Public statusPayment As String = ""
    Public cashDrawer As String = ""
    Public remarksReverse As String = ""
    Public cardId As Integer = 0
    Public cashNotesReceived As Decimal = 0
    Public cashNotesChange As Decimal = 0
    Public synchroKey As String = System.Guid.NewGuid.ToString
    Public posId As Integer = 0

    Public arrItems As New ArrayList


    Public Function GetCustName() As String
        Dim strValue As String() = Me.paymentRemarks.Split("|")

        If strValue.Count = 4 Then
            Return strValue(0).ToString
        End If

        Return ""
    End Function

    Public Function GetCustContact() As String
        Dim strValue As String() = Me.paymentRemarks.Split("|")

        If strValue.Count = 4 Then
            Return strValue(1).ToString
        End If

        Return ""
    End Function

    Public Function GetCustIC() As String
        Dim strValue As String() = Me.paymentRemarks.Split("|")

        If strValue.Count = 4 Then
            Return strValue(2).ToString
        End If

        Return ""
    End Function

    Public Function GetRemarks() As String
        Dim strValue As String() = Me.paymentRemarks.Split("|")

        If strValue.Count = 4 Then
            Return strValue(3).ToString
        End If

        Return Me.paymentRemarks
    End Function

    Public Function GetTotalAmount() As Decimal

        Dim amount As Decimal = 0
        For Each obj As DAOfficialReceiptObject In arrItems
            amount += obj.amount
        Next

        Return amount
    End Function

    Public Function GetTotalBalanceAmount() As Decimal

        Dim amount As Decimal = 0
        For Each obj As DAOfficialReceiptObject In arrItems
            amount += obj.openBalance
        Next

        Return amount
    End Function

    Public Function GetTotalAmountCash() As Decimal

        Dim amount As Decimal = 0
        For Each obj As DAOfficialReceiptObject In arrItems
            amount += obj.amountCash
        Next

        Return amount
    End Function

    Public Function GetTotalAmountCard() As Decimal

        Dim amount As Decimal = 0
        For Each obj As DAOfficialReceiptObject In arrItems
            amount += obj.amountCard
        Next

        Return amount
    End Function

    Public Function GetTotalAmountCheque() As Decimal

        Dim amount As Decimal = 0
        For Each obj As DAOfficialReceiptObject In arrItems
            amount += obj.amountCheque
        Next

        Return amount
    End Function

    Public Function GetTotalAmountPDCheque() As Decimal

        Dim amount As Decimal = 0
        For Each obj As DAOfficialReceiptObject In arrItems
            amount += obj.amountPDCheque
        Next

        Return amount
    End Function

    Public Function GetTotalAmountCoupon() As Decimal

        Dim amount As Decimal = 0
        For Each obj As DAOfficialReceiptObject In arrItems
            amount += obj.amountCoupon
        Next

        Return amount
    End Function

    Public Function GetTotalAmountOther() As Decimal

        Dim amount As Decimal = 0
        For Each obj As DAOfficialReceiptObject In arrItems
            amount += obj.amountOther
        Next

        Return amount
    End Function


    Public Sub SetPaymentRemarks(ByVal custName As String, ByVal custContact As String, ByVal custIC As String, ByVal remarks As String)

        custName = custName.Replace("|", "")
        custContact = custContact.Replace("|", "")
        custIC = custIC.Replace("|", "")
        remarks = remarks.Replace("|", "")

        Me.paymentRemarks = custName & "|" & custContact & "|" & custIC & "|" & remarks

    End Sub


    Public Function GetCardNo(ByVal lastDigit As Integer)

        Dim count As Integer = cardNumber.Length - lastDigit
        Dim str As New String("X"c, count)

        Return str & cardNumber.Substring(count, lastDigit)

    End Function
End Class
