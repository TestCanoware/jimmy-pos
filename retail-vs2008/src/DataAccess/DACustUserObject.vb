Public Class DACustUserObject

    Public pkid As Integer = 0
    Public username As String = ""
    Public password As Byte()
    Public nameFirst As String = ""
    Public nameLast As String = ""
    Public accId As Integer = 0
    Public dob As New Date(2001, 1, 1, 0, 0, 1)
    Public expiry As New Date(2001, 1, 1, 0, 0, 1)
    Public title As String = ""
    Public designation As String = ""
    Public sex As String = ""
    Public ethnic As String = ""
    Public referenceNo As String = ""
    Public icType As String = ""
    Public mainAddress1 As String = ""
    Public mainAddress2 As String = ""
    Public mainAddress3 As String = ""
    Public mainCity As String = ""
    Public mainPostcode As String = ""
    Public mainState As String = ""
    Public mainCountry As String = ""
    Public telephone1 As String = ""
    Public telephone2 As String = ""
    Public homePhone As String = ""
    Public mobilePhone As String = ""
    Public faxNo As String = ""
    Public homepage As String = ""
    Public email1 As String = ""
    Public email2 As String = ""
    Public email3 As String = ""
    Public preference As String = ""
    Public defaultPaymentMode As String = ""
    Public defaultCardType As String = ""
    Public defaultCardBank As String = ""
    Public defaultCardName As String = ""
    Public defaultCardNumber As String = ""
    Public defaultCardSecurityNum As String = ""
    Public defaultCardValidFrom As New Date(2001, 1, 1, 0, 0, 1)
    Public defaultCardGoodThru As New Date(2001, 1, 1, 0, 0, 1)
    Public loyaltyCardName1 As String = ""
    Public loyaltyCardNumber1 As String = ""
    Public loyaltyCardName2 As String = ""
    Public loyaltyCardNumber2 As String = ""
    Public loyaltyCardName3 As String = ""
    Public loyaltyCardNumber3 As String = ""
    Public loyaltyCardName4 As String = ""
    Public loyaltyCardNumber4 As String = ""
    Public securityCheck As String = ""
    Public state As String = ""
    Public status As String = ""
    Public lastupdate As New Date(2001, 1, 1, 0, 0, 1)
    Public useridEdit As Integer = 0
    Public nationality As String = ""
    Public maritalStatus As String = ""
    Public educationLevel As String = ""
    Public grossHouseholdIncome As String = ""
    Public profession As String = ""
    Public householdNumber As Integer = 0
    Public householdJunior As Integer = 0
    Public householdSenior As Integer = 0
    Public contactAddress1 As String = ""
    Public contactAddress2 As String = ""
    Public contactAddress3 As String = ""
    Public contactCity As String = ""
    Public contactPostcode As String = ""
    Public contactState As String = ""
    Public contactCountry As String = ""
    Public businessAddress1 As String = ""
    Public businessAddress2 As String = ""
    Public businessAddress3 As String = ""
    Public businessCity As String = ""
    Public businessPostcode As String = ""
    Public businessState As String = ""
    Public businessCountry As String = ""
    Public businessNature As String = ""
    Public salesman As Integer = 0
    Public creditTerms As Integer = 0


    Public Function GetName() As String
        Return Me.nameFirst & " " & nameLast
    End Function

End Class
