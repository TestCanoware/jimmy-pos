Imports System.Reflection

Public Class DATCTxQueueObject

    Public pkid As Long = 0
    Public pkString As String = ""
    Public fkString As String = ""
    Public category As String = ""
    Public type As String = ""
    Public source As String = ""
    Public objectXML As String = ""
    Public userId As Integer = 0
    Public status As String = ""
    Public dateCreated As Date
    Public dateReceived As Date
    Public dateCompleted As Date
    Public branchid As Integer = 0
    Public amount As Decimal = 0
    Public mode As String = DATCTxQueue.MODE_ADD

    Public Function getObject(ByVal valueObj As Object, ByVal pkString As String, ByVal fkString As String, ByVal branch As Integer, _
                                    ByVal category As String, ByVal tableName As String, ByVal amount As String, _
                                    ByVal mode As String, ByVal userId As Integer) As DATCTxQueueObject
        '(pkid, pk_string, fk_string, category, source, type, object_xml, userid, status, date_created, date_received, date_completed) " 

        Dim objName As String = ""
        Select Case tableName
            Case DAOfficialReceipt.TABLENAME
                objName = "com.vlee.ejb.accounting.OfficialReceiptObject"
            Case DAInvoice.TABLENAME
                objName = "com.vlee.ejb.customer.InvoiceObject"
            Case DAInvoiceItem.TABLENAME
                objName = "com.vlee.ejb.customer.InvoiceItemObject"
            Case DAJobsheet.TABLENAME
                objName = "com.vlee.ejb.customer.JobsheetIndexObject"
            Case DAJobsheetItem.TABLENAME
                objName = "com.vlee.ejb.customer.JobsheetItemObject"
            Case DAPaymentVoucher.TABLENAME
                objName = "com.vlee.ejb.accounting.PaymentVoucherIndexObject"
            Case DAPaymentVoucherItem.TABLENAME
                objName = "com.vlee.ejb.accounting.PaymentVoucherItemObject"
            Case DAPosEndDayClosing.TABLENAME
                objName = "com.vlee.ejb.customer.POSEndDayClosingObject"
        End Select

        Dim obj As New DATCTxQueueObject
        With obj
            .pkString = pkString
            .fkString = fkString
            .branchid = branch
            .source = DATCTxQueue.SOURCE_THICK_CLIENT
            .category = category
            .amount = amount
            .type = tableName
            .objectXML = GetXML(valueObj, tableName, objName)
            .userId = userId
            .dateCreated = Now
            .status = DATCTxQueue.STATUS_PENDING
            .mode = mode
        End With

        Return obj

    End Function

    Public Shared Function GetXML(ByVal obj As Object, ByVal tableName As String, ByVal objName As String) As String
        Dim FieldFrom As FieldInfo() = obj.GetType.GetFields(BindingFlags.NonPublic Or BindingFlags.Public Or BindingFlags.Instance)
        Dim strXML As String = ""

        strXML = "<" & objName & ">"

        For i As Integer = 0 To FieldFrom.Length - 1
            Dim nameField As String = FieldFrom(i).Name
            Dim strValue As Object = FieldFrom(i).GetValue(obj)

            Select Case strValue.GetType.ToString
                Case "System.Collections.ArrayList"

                Case "System.DateTime"
                    Dim dtValue As Date = CType(strValue, Date)
                    If dtValue.ToString("yyyy-MM-dd HH:mm:ss") = "2001-01-01 00:00:01" Then
                        strValue = "0001-01-01 00:00:00"
                    Else
                        ' Convert to universal datetime format (will work on all databases in all countries)
                        strValue = dtValue.ToString("yyyy-MM-dd HH:mm:ss")
                    End If

                    strXML &= "<" & nameField & ">" & strValue & "</" & nameField & ">"

                Case Else
                    strXML &= "<" & nameField & ">" & strValue & "</" & nameField & ">"
            End Select


        Next

        strXML &= "</" & objName & ">"

        Return strXML

    End Function
End Class
