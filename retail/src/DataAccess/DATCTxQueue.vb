Imports Utils.General

Public Class DATCTxQueue

    'Constants for Table field mappings
    Private Const CLASSNAME = "DATCTxQueue"

    Public Const PKID = "pkid"
    Public Const PK_STRING = "pk_string"
    Public Const FK_STRING = "fk_string"
    Public Const CATEGORY = "category"
    Public Const SOURCE = "source"
    Public Const TYPE = "type"
    Public Const OBJECT_XML = "object_xml"
    Public Const USERID = "userid"
    Public Const STATUS = "status"
    Public Const DATE_CREATED = "date_created"
    Public Const DATE_RECEIVED = "date_received"
    Public Const DATE_COMPLETED = "date_completed"
    Public Const BRANCH_ID = "branch_id"
    Public Const AMOUNT = "amount"
    Public Const MODE = "mode"

    Public Const STATUS_COMPLETE As String = "complete"
    Public Const STATUS_PENDING As String = "pending"
    Public Const STATUS_EXPORT As String = "export"

    Public Const SOURCE_EMP = "emp"
    Public Const SOURCE_THICK_CLIENT = "thick_client"

    Public Const CATEGORY_INDEX = "index"
    Public Const CATEGORY_INTERIM = "interim"
    Public Const CATEGORY_ITEM = "item"

    Public Const MODE_ADD = "ADD"
    Public Const MODE_UPDATE = "UPDATE"
    Public Const MODE_CANCEL = "CANCEL"

    Public Const TABLENAME = "tc_tx_queue"
    Public Const NO_OF_COLUMNS As Integer = 15
    Public Const APP_NAME = "ThickClient-DataAccess"
    Public Const START_ID = 1001

    '***************************************************************************
    '* Create
    '**************************************************************************/
    Public Function Create(ByVal obj As DATCTxQueueObject) As DATCTxQueueObject

        WriteToLogFile(CLASSNAME & " - In Create")

        Dim comm As New Commands
        Dim strSQL, strSQL1, strSQL2 As String

        'getNextID
        obj.pkid = GetNextID()

        strSQL = ""
        strSQL1 = "("
        strSQL2 = "("

        For i As Integer = 1 To NO_OF_COLUMNS - 1
            strSQL1 &= "{" & i & "},"
            strSQL2 &= "{V" & i & "},"
        Next i

        strSQL1 &= "{" & NO_OF_COLUMNS & "})"
        strSQL2 &= "{V" & NO_OF_COLUMNS & "})"

        strSQL = " INSERT INTO {T} " & strSQL1 & " VALUES " & strSQL2
        strSQL = ReplaceStatement(strSQL, obj)

        Try
            WriteToLogFile(strSQL)
            comm.ExecuteNonQueryTransaction(strSQL)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - Create - " & ex.Message)
            Return Nothing
        End Try

        WriteToLogFile(CLASSNAME & " - Leave Create")

        Return obj

    End Function


    '***************************************************************************
    '* Update
    '**************************************************************************/
    Public Sub Update(ByVal obj As DATCTxQueueObject)

        WriteToLogFile(CLASSNAME & " - In Update")

        Dim comm As New Commands
        Dim strSQL, strSQL1 As String

        strSQL = ""
        strSQL1 = ""

        For i As Integer = 1 To NO_OF_COLUMNS - 1
            strSQL1 &= "{" & i & "}={V" & i & "},"
        Next i

        strSQL1 &= "{" & NO_OF_COLUMNS & "}={V" & NO_OF_COLUMNS & "}"
        strSQL = " UPDATE {T} SET " & strSQL1 & " WHERE {1}={V1} "
        strSQL = ReplaceStatement(strSQL, obj)

        Try
            WriteToLogFile(strSQL)
            comm.ExecuteNonQuery(strSQL)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - Update - " & ex.Message)

        End Try

        WriteToLogFile(CLASSNAME & " - Leave Update")

    End Sub

    '***************************************************************************
    '* UpdateWithObjectGiven
    '**************************************************************************/
    Public Sub UpdateWithObjectGiven(ByVal idLogic As String, ByVal fieldName As String, ByVal value As Object, _
                                     ByVal fieldName2 As String, ByVal value2 As Object)

        WriteToLogFile(CLASSNAME & " - In Update")

        Dim comm As New Commands
        Dim strSQL As String

        strSQL = " UPDATE {T} SET {2} = {V2}"
        If fieldName2.Length > 0 AndAlso value2.ToString.Length > 0 Then
            strSQL += ",{3} = {V3} "
        End If
        strSQL += "WHERE {1} IN ({V1}) "

        strSQL = strSQL.Replace("{T}", TABLENAME)
        strSQL = strSQL.Replace("{1}", PKID)
        strSQL = strSQL.Replace("{V1}", idLogic)
        strSQL = strSQL.Replace("{2}", fieldName)
        strSQL = strSQL.Replace("{V2}", PreparedStatement(value))
        If fieldName2.Length > 0 AndAlso value2.ToString.Length > 0 Then
            strSQL = strSQL.Replace("{3}", fieldName2)
            strSQL = strSQL.Replace("{V3}", PreparedStatement(value2))
        End If
        Try
            WriteToLogFile(strSQL)
            comm.ExecuteNonQuery(strSQL)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - Update - " & ex.Message)

        End Try

        WriteToLogFile(CLASSNAME & " - Leave Update")

    End Sub

    '***************************************************************************
    '* GetObject
    '**************************************************************************/
    Public Function GetObject(ByVal id As Integer) As DATCTxQueueObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DATCTxQueueObject = Nothing
        Dim ds As DataSet
        Dim strSQL As String
        Dim row As DataRow

        strSQL = "SELECT * FROM {T} WHERE {1} = '{V1}' ORDER BY {1}"

        strSQL = strSQL.Replace("{T}", TABLENAME)
        strSQL = strSQL.Replace("{1}", PKID)
        strSQL = strSQL.Replace("{V1}", id)

        Try
            WriteToLogFile(strSQL)
            ds = comm.ExecuteQuery(strSQL, Commands.ReturnType.DataSetType)

            If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
                row = ds.Tables(0).Rows(0)
                obj = GetObject(row)
            End If

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetObject - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetObject")

        Return obj

    End Function


    '***************************************************************************
    '* GetDataSet
    '**************************************************************************/
    Public Function GetDataSet() As DataSet

        WriteToLogFile(CLASSNAME & " - In GetDataSet")

        Dim comm As New Commands
        Dim strSQL As String

        strSQL = "SELECT * FROM {T} ORDER BY {1}"

        strSQL = strSQL.Replace("{T}", TABLENAME)
        strSQL = strSQL.Replace("{1}", PKID)

        Try
            WriteToLogFile(strSQL)
            Return comm.ExecuteQuery(strSQL, Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetDataSet - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetDataSet")

    End Function


    '***************************************************************************
    '* GetObjectsGiven
    '**************************************************************************/
    Public Function GetObjectsGiven(ByVal fieldName As String, ByVal value As String) As DataSet

        WriteToLogFile(CLASSNAME & " - In GetObjectsGiven")

        Dim comm As New Commands
        Dim strSQL As String

        strSQL = "SELECT * FROM {T} WHERE {1} = '{V1}' ORDER BY {1}"

        strSQL = strSQL.Replace("{T}", TABLENAME)
        strSQL = strSQL.Replace("{1}", fieldName)
        strSQL = strSQL.Replace("{V1}", value)

        Try
            WriteToLogFile(strSQL)
            Return comm.ExecuteQuery(strSQL, Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetObjectsGiven - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetObjectsGiven")

    End Function


    '***************************************************************************
    '* GetObject
    '**************************************************************************/
    Public Function GetObject(ByVal row As DataRow) As DATCTxQueueObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DATCTxQueueObject

        Try
            obj = New DATCTxQueueObject
            obj.pkid = row(PKID)
            obj.pkString = row(PK_STRING)
            obj.fkString = row(FK_STRING)
            obj.category = row(CATEGORY)
            obj.source = row(SOURCE)
            obj.type = row(TYPE)
            obj.objectXML = row(OBJECT_XML)
            obj.userId = row(USERID)
            obj.status = row(STATUS)
            obj.dateCreated = row(DATE_CREATED)
            obj.dateReceived = row(DATE_RECEIVED)
            obj.dateCompleted = row(DATE_COMPLETED)
            obj.branchid = row(BRANCH_ID)
            obj.amount = row(AMOUNT)
            obj.mode = row(MODE)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetObject - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetObject")

        Return obj

    End Function


    Public Function ReplaceStatement(ByVal strSQL As String, ByVal obj As DATCTxQueueObject) As String

        strSQL = strSQL.Replace("{T}", TABLENAME)

        strSQL = strSQL.Replace("{1}", PKID)
        strSQL = strSQL.Replace("{2}", PK_STRING)
        strSQL = strSQL.Replace("{3}", FK_STRING)
        strSQL = strSQL.Replace("{4}", CATEGORY)
        strSQL = strSQL.Replace("{5}", SOURCE)
        strSQL = strSQL.Replace("{6}", TYPE)
        strSQL = strSQL.Replace("{7}", OBJECT_XML)
        strSQL = strSQL.Replace("{8}", USERID)
        strSQL = strSQL.Replace("{9}", STATUS)
        strSQL = strSQL.Replace("{10}", DATE_CREATED)
        strSQL = strSQL.Replace("{11}", DATE_RECEIVED)
        strSQL = strSQL.Replace("{12}", DATE_COMPLETED)
        strSQL = strSQL.Replace("{13}", BRANCH_ID)
        strSQL = strSQL.Replace("{14}", AMOUNT)
        strSQL = strSQL.Replace("{15}", MODE)

        strSQL = strSQL.Replace("{V1}", PreparedStatement(obj.pkid))
        strSQL = strSQL.Replace("{V2}", PreparedStatement(obj.pkString))
        strSQL = strSQL.Replace("{V3}", PreparedStatement(obj.fkString))
        strSQL = strSQL.Replace("{V4}", PreparedStatement(obj.category))
        strSQL = strSQL.Replace("{V5}", PreparedStatement(obj.source))
        strSQL = strSQL.Replace("{V6}", PreparedStatement(obj.type))
        strSQL = strSQL.Replace("{V7}", PreparedStatement(obj.objectXML))
        strSQL = strSQL.Replace("{V8}", PreparedStatement(obj.userId))
        strSQL = strSQL.Replace("{V9}", PreparedStatement(obj.status))
        strSQL = strSQL.Replace("{V10}", PreparedStatement(obj.dateCreated))
        strSQL = strSQL.Replace("{V11}", PreparedStatement(obj.dateReceived))
        strSQL = strSQL.Replace("{V12}", PreparedStatement(obj.dateCompleted))
        strSQL = strSQL.Replace("{V13}", PreparedStatement(obj.branchid))
        strSQL = strSQL.Replace("{V14}", PreparedStatement(obj.amount))
        strSQL = strSQL.Replace("{V15}", PreparedStatement(obj.mode))

        Return strSQL

    End Function

    '***************************************************************************
    '* GetNextID
    '**************************************************************************/
    Public Function GetNextID() As Long

         Return DAAppTableCounter.GetNextPKID(PKID, TABLENAME, "POS", START_ID)

    End Function


    '***************************************************************************
    '* GetPendingLimit
    '**************************************************************************/
    Public Function GetTCTxQueueByTxn(ByVal limit As Integer) As DataSet

        WriteToLogFile(CLASSNAME & " - In GetDataSet")

        Dim comm As New Commands
        Dim strSQL As String

        strSQL = " SELECT t.* FROM {T} t INNER JOIN (" & _
                " SELECT distinct pk_string FROM tc_tx_queue WHERE {1} = {V1} ORDER BY pkid LIMIT " & limit & _
                " ) AS rpt ON rpt.pk_string = t.pk_string " & _
                " ORDER BY t.pkid"

        strSQL = strSQL.Replace("{T}", TABLENAME)
        strSQL = strSQL.Replace("{1}", STATUS)
        strSQL = strSQL.Replace("{V1}", PreparedStatement(DATCTxQueue.STATUS_PENDING))

        Try
            WriteToLogFile(strSQL)
            Return comm.ExecuteQuery(strSQL, Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetDataSet - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetDataSet")

    End Function


    '***************************************************************************
    '* GetPendingLimit
    '**************************************************************************/
    Public Function GetPendingLimit(ByVal limit As Integer) As DataSet

        WriteToLogFile(CLASSNAME & " - In GetDataSet")

        Dim comm As New Commands
        Dim strSQL As String

        strSQL = "SELECT * FROM {T} WHERE {1} = {V1} LIMIT " & limit
    
        strSQL = strSQL.Replace("{T}", TABLENAME)
        strSQL = strSQL.Replace("{1}", STATUS)
        strSQL = strSQL.Replace("{V1}", PreparedStatement(DATCTxQueue.STATUS_PENDING))

        Try
            WriteToLogFile(strSQL)
            Return comm.ExecuteQuery(strSQL, Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetDataSet - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetDataSet")

    End Function


    '***************************************************************************
    '* GetObjectsByDate
    '**************************************************************************/
    Public Function GetObjectsByDate(ByVal dateFrom As Date, ByVal dateTo As Date) As DataSet

        WriteToLogFile(CLASSNAME & " - In GetObjectsByDate")

        Dim comm As New Commands
        Dim strSQL As String
        Dim nextDay As Date = dateTo.AddDays(1)


        strSQL = "SELECT * FROM {T} WHERE {1} > {V1} AND {2} < {V2} ORDER BY {3}"

        strSQL = strSQL.Replace("{T}", TABLENAME)
        strSQL = strSQL.Replace("{1}", DATCTxQueue.DATE_CREATED)
        strSQL = strSQL.Replace("{V1}", PreparedStatement(Utils.General.FormatDate(dateFrom)))
        strSQL = strSQL.Replace("{2}", DATCTxQueue.DATE_CREATED)
        strSQL = strSQL.Replace("{V2}", PreparedStatement(Utils.General.FormatDate(nextDay)))
        strSQL = strSQL.Replace("{3}", PKID)


        Try
            WriteToLogFile(strSQL)
            Return comm.ExecuteQuery(strSQL, Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetObjectsGiven - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetObjectsGiven")

    End Function

End Class

