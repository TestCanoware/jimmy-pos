Imports Utils.General

Public Class DAPosSyncTiming

    'Constants for Table field mappings
    Private Const CLASSNAME = "DAPosSyncTiming"

    Public Const PKID = "pkid"
    Public Const BRANCH_ID = "branch_id"
    Public Const POS_ID = "pos_id"
    Public Const USER_ID = "user_id"
    Public Const TIME_START = "time_start"
    Public Const TIME_END = "time_end"
    Public Const STATUS = "status"

    Public Const STATUS_DOWNLOAD = "DOWNLOAD"
    Public Const STATUS_UPLOAD = "UPLOAD"

    Public Const TABLENAME = "pos_sync_timing"
    Public Const NO_OF_COLUMNS As Integer = 7
    Public Const APP_NAME = "ThickClient-DataAccess"
    Public Const START_ID = 1

    '***************************************************************************
    '* Create
    '**************************************************************************/
    Public Function Create(ByVal obj As DAPosSyncTimingObject) As DAPosSyncTimingObject

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
            comm.ExecuteNonQuery(strSQL)

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
    Public Sub Update(ByVal obj As DAPosSyncTimingObject)

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
    '* GetObject
    '**************************************************************************/
    Public Function GetObject(ByVal id As Integer) As DAPosSyncTimingObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DAPosSyncTimingObject = Nothing
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
    Public Function GetObject(ByVal row As DataRow) As DAPosSyncTimingObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DAPosSyncTimingObject

        Try
            obj = New DAPosSyncTimingObject
            obj.pkid = row(PKID)
            obj.branchId = row(BRANCH_ID)
            obj.posId = row(POS_ID)
            obj.userId = row(USER_ID)
            obj.timeStart = row(TIME_START)
            obj.timeEnd = row(TIME_END)
            obj.status = row(STATUS)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetObject - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetObject")

        Return obj

    End Function



    '***************************************************************************
    '* ReplaceStatement
    '**************************************************************************/
    Public Function ReplaceStatement(ByVal strSQL As String, ByVal obj As DAPosSyncTimingObject) As String

        strSQL = strSQL.Replace("{T}", TABLENAME)

        strSQL = strSQL.Replace("{1}", PKID)
        strSQL = strSQL.Replace("{2}", BRANCH_ID)
        strSQL = strSQL.Replace("{3}", POS_ID)
        strSQL = strSQL.Replace("{4}", USER_ID)
        strSQL = strSQL.Replace("{5}", TIME_START)
        strSQL = strSQL.Replace("{6}", TIME_END)
        strSQL = strSQL.Replace("{7}", STATUS)

        strSQL = strSQL.Replace("{V1}", PreparedStatement(obj.pkid))
        strSQL = strSQL.Replace("{V2}", PreparedStatement(obj.branchId))
        strSQL = strSQL.Replace("{V3}", PreparedStatement(obj.posId))
        strSQL = strSQL.Replace("{V4}", PreparedStatement(obj.userId))
        strSQL = strSQL.Replace("{V5}", PreparedStatement(obj.timeStart))
        strSQL = strSQL.Replace("{V6}", PreparedStatement(obj.timeEnd))
        strSQL = strSQL.Replace("{V7}", PreparedStatement(obj.status))

        Return strSQL

    End Function


    '***************************************************************************
    '* GetNextID
    '**************************************************************************/
    Public Function GetNextID() As Long

        WriteToLogFile(CLASSNAME & " - In GetNextID")

        Dim comm As New Commands
        Dim ds As New DataSet
        Dim strSQL As String
        Dim nextID As Long = START_ID

        strSQL = "SELECT MAX({1}) FROM {T} "

        strSQL = strSQL.Replace("{T}", TABLENAME)
        strSQL = strSQL.Replace("{1}", PKID)

        Try
            WriteToLogFile(strSQL)
            ds = comm.ExecuteQuery(strSQL, Commands.ReturnType.DataSetType)
            If ds.Tables(0).Rows(0)(0).ToString <> "" Then
                nextID = ds.Tables(0).Rows(0)(0)
                nextID += 1
            End If

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetNextID - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetNextID")

        Return nextID

    End Function

    '***************************************************************************
    '* GetLastSync
    '**************************************************************************/
    Public Function GetLastSync() As DAPosSyncTimingObject

        WriteToLogFile(CLASSNAME & " - In GetLastSync")

        Dim comm As New Commands
        Dim obj As DAPosSyncTimingObject = Nothing
        Dim ds As DataSet
        Dim strSQL As String
        Dim row As DataRow

        strSQL = "SELECT * FROM {T} WHERE {1} IN (SELECT MAX({1}) FROM {T} WHERE {2}='{V2}')"

        strSQL = strSQL.Replace("{T}", TABLENAME)
        strSQL = strSQL.Replace("{1}", PKID)
        strSQL = strSQL.Replace("{2}", STATUS)
        strSQL = strSQL.Replace("{V2}", STATUS_DOWNLOAD)

        Try
            WriteToLogFile(strSQL)
            ds = comm.ExecuteQuery(strSQL, Commands.ReturnType.DataSetType)

            If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
                row = ds.Tables(0).Rows(0)
                obj = GetObject(row)
            End If

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetLastSync - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetLastSync")

        Return obj

    End Function

End Class

