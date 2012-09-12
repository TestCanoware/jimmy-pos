﻿Public Class DACustAccountObject

    Public pkid As Integer = 0
    Public custAccountCode As String = ""
    Public name As String = ""
    Public description As String = ""
    Public accType As Integer = 0
    Public status As String = DACustAccount.STATUS_ACTIVE
    Public lastUpdate As New Date(2001, 1, 1, 0, 0, 1)
    Public userIdUpdate As Integer = 0
    Public username As String = ""
    Public password() As Byte
    Public nameFirst As String = ""
    Public nameLast As String = ""
    Public nickname As String = ""
    Public title As String = ""
    Public designation As String = ""
    Public identityNumber As String = ""
    Public mainAddress1 As String = ""
    Public mainAddress2 As String = ""
    Public mainAddress3 As String = ""
    Public mainCity As String = ""
    Public mainPostcode As String = ""
    Public mainState As String = ""
    Public mainCountry As String = ""
    Public shipAddress1 As String = ""
    Public shipAddress2 As String = ""
    Public shipAddress3 As String = ""
    Public shipCity As String = ""
    Public shipPostcode As String = ""
    Public shipState As String = ""
    Public shipCountry As String = ""
    Public billAddress1 As String = ""
    Public billAddress2 As String = ""
    Public billAddress3 As String = ""
    Public billCity As String = ""
    Public billPostcode As String = ""
    Public billState As String = ""
    Public billCountry As String = ""
    Public telephone1 As String = ""
    Public telephone2 As String = ""
    Public homePhone As String = ""
    Public mobilePhone As String = ""
    Public faxNo As String = ""
    Public homepage As String = ""
    Public email1 As String = ""
    Public email2 As String = ""
    Public email3 As String = ""
    Public creditLimit As Decimal = 0
    Public creditTerms As Integer = 0
    Public property1 As String = ""
    Public property2 As String = ""
    Public property3 As String = ""
    Public property4 As String = ""
    Public property5 As String = ""
    Public note As String = ""
    Public salesman As Integer = 0
    Public state As String = DACustAccount.STATE_OK
    Public dealerCode As String = ""
    Public factorPricing As Decimal = 0
    Public factorDiscount As Decimal = 0
    Public pricingLogic As String = ""
    Public pricingScheme As String = ""
    Public areaCode As String = ""
    Public deptCode As String = ""
    Public supplierId As Integer = 0
    Public branch As Integer = 0
    Public pcCenter As Integer = 0
    Public monthlyFees As Decimal = 0
    Public creditOption As String = ""

End Class
