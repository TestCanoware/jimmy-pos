'* Start sentinel — one character (generally '%')
'* Format code="B" — one character (alpha only)
'* Primary account number (PAN) — up to 19 characters. Usually, but not always, matches the credit card number printed on the front of the card.
'* Field Separator — one character (generally '^')
'* Name — two to 26 characters
'* Field Separator — one character (generally '^')
'* Expiration date — four characters in the form YYMM.
'* Service code — three characters
'* Discretionary data — may include Pin Verification Key Indicator (PVKI, 1 character), PIN Verification Value (PVV, 4 characters), Card Verification Value or Card Verification Code (CVV or CVK, 3 characters)
'* End sentinel — one character (generally '?')
'* Longitudinal redundancy check (LRC) — one character (Most reader devices do not return this value when the card is swiped to the presentation layer, and use it only to verify the input internally to the reader.)

'%B4966230232034824^WIN/TAN KEH              ^12082010000001000000000128000000?;4966230232034824=12082010000001000128?
'b5048771027096881^ /                        ^49121200000000000000  924 (nets card)
Public Class CreditCard

    Private mNo As String
    Private mName As String
    Private mExpiryMonth As String
    Private mExpiryYear As String

    Public Sub New(ByVal val As String)
        'b5521632020085113^ABC                       ^1010201000000000000000448000000
        'val = "%B4966230232034824^WIN/TAN KEH              ^12082010000001000000000128000000?;4966230232034824=12082010000001000128?"
        Dim str As String() = val.Split("^")
        Try

            If str.Length > 0 Then
                mNo = str(0).ToString.Replace("%B", "")
                mNo = mNo.ToString.Replace("B", "")
                mNo = mNo.ToString.Replace("%b", "")
                mNo = mNo.ToString.Replace("b", "")
                mName = str(1).ToString.Trim
                mExpiryMonth = str(2).ToString.Substring(2, 2)
                mExpiryYear = "20" & str(2).ToString.Substring(0, 2)
            End If
        Catch ex As Exception
            Messenger.ShowError("Get Credit Card Particulars Error!")
        End Try
    End Sub


    Public Property No() As String
        Get
            Return mNo
        End Get
        Set(ByVal value As String)
            mNo = value
        End Set
    End Property

    Public Property Name() As String
        Get
            Return mName
        End Get
        Set(ByVal value As String)
            mName = value
        End Set
    End Property

    Public Property ExpiryMonth() As String
        Get
            Return mExpiryMonth
        End Get
        Set(ByVal value As String)
            mExpiryMonth = value
        End Set
    End Property

    Public Property ExpiryYear() As String
        Get
            Return mExpiryYear
        End Get
        Set(ByVal value As String)
            mExpiryYear = value
        End Set
    End Property

End Class
