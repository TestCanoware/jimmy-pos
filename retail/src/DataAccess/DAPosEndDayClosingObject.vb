Public Class DAPosEndDayClosingObject

    Public pkid As Integer = 0
    Public branchId As Integer = 0
    Public posId As Integer = 0
    Public userId As Integer = 0
    Public timeStart As New Date(2001, 1, 1, 0, 0, 1)
    Public timeEnd As New Date(2001, 1, 1, 0, 0, 1)
    Public qtyBill As Integer = 0
    Public qtyItem As Integer = 0
    Public cashIn As Decimal = 0
    Public cashOut As Decimal = 0
    Public amount As Decimal = 0
    Public status As String = ""
    Public lastUpdate As New Date(2001, 1, 1, 0, 0, 1)

End Class
