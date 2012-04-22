Imports Utils.General

Public Class DADocLinkObject

    Public pkid As Long = 0
    Public name_space As String = ""
    Public reference As String = ""
    Public relType As String = ""
    Public srcDocRef As String = ""
    Public srcDocId As Long = 0
    Public tgtDocRef As String = ""
    Public tgtDocId As Long = 0
    Public currency As String = ""
    Public amount As Decimal = 0
    Public currency2 As String = ""
    Public amount2 As Decimal = 0
    Public remarks As String = ""
    Public status As String = DADocLink.STATUS_ACTIVE
    Public lastUpdate As Date = GetDefaultDate()
    Public userIdUpdate As Integer = 0

End Class
