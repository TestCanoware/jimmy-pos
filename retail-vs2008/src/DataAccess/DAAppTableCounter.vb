Imports Utils.General

Public NotInheritable Class DAAppTableCounter

    Private Const CLASSNAME = "AppTableCounterUtil "

    Public Const PKID = "pkid"
    Public Const CATEGORY = "category"
    Public Const MODULE_NAME = "modulename"
    Public Const TABLE_NAME = "tablename"
    Public Const ENTITY_NAME = "entityname"
    Public Const FOREIGN_TABLE1 = "foreign_table1"
    Public Const FOREIGN_KEY1 = "foreign_key1"
    Public Const FOREIGN_TABLE2 = "foreign_table2"
    Public Const FOREIGN_KEY2 = "foreign_key2"
    Public Const FLAG = "flag"
    Public Const STATE = "state"
    Public Const RUNNING_NUMBER = "running_number"
    Public Const VALUE1 = "value1"
    Public Const VALUE2 = "value2"
    Public Const VALUE3 = "value3"
    Public Const VALUE4 = "value4"
    Public Const VALUE5 = "value5"
    Public Const BINARY_DATA = "binary_data"
    Public Const STATUS = "status"
    Public Const USERID_EDIT = "userid_edit"
    Public Const TIME_EDIT = "time_edit"
    Public Const TIME_EFFECTIVE = "time_effective"
    Public Const TABLENAME = "app_table_counter"

    ' Constants for STATUS
    Public Const STATUS_ACTIVE = "active"
    Public Const STATUS_INACTIVE = "inactive"

    ' Constants for PKID
    Public Shared PKID_START As Integer = 1001
    Public Shared DEF_PKID_START As Long = 1001



    Public Shared Function GetNextPKID(ByVal entityName As String, ByVal strTableName As String, ByVal moduleName As String, ByVal lpkid As Long)

        WriteToLogFile(CLASSNAME & " - In GetNextPKID")

        Dim pkidStart As Long
        Dim comm As New Commands
        Dim ds As New DataSet
        Dim strSQL As String

        If (lpkid = Nothing) Then
            pkidStart = lpkid
        Else
            pkidStart = DEF_PKID_START
        End If

        strSQL = " UPDATE " & TABLENAME & " SET " & RUNNING_NUMBER & " = " & RUNNING_NUMBER & "+1" & _
                 " WHERE " & ENTITY_NAME & " = '" & entityName & "' " & " AND " & TABLE_NAME & " = '" & strTableName & "'"


        Dim rowCount As Integer = comm.ExecuteNonQueryTransaction(strSQL)

        If rowCount = 0 Then

            strSQL = "INSERT INTO " & TABLENAME & " (" & PKID & ", " & MODULE_NAME & ", " & TABLE_NAME & _
                          ", " & ENTITY_NAME & ", " & RUNNING_NUMBER & ", " & STATUS & ", " & TIME_EDIT & ") VALUES ( {1}, {2}, {3}, {4}, {5}, {6}, {7})"

            strSQL = strSQL.Replace("{1}", GetNextID())
            strSQL = strSQL.Replace("{2}", PreparedStatement(moduleName))
            strSQL = strSQL.Replace("{3}", PreparedStatement(strTableName))
            strSQL = strSQL.Replace("{4}", PreparedStatement(entityName))
            strSQL = strSQL.Replace("{5}", GetNextPKIdByMax(strTableName, pkidStart))
            strSQL = strSQL.Replace("{6}", PreparedStatement(STATUS_ACTIVE))
            strSQL = strSQL.Replace("{7}", PreparedStatement(Now))


            comm.ExecuteNonQueryTransaction(strSQL)

        End If


        strSQL = " SELECT " & RUNNING_NUMBER & " FROM " & TABLENAME & " WHERE " & ENTITY_NAME & " = '" & _
                    entityName & "' " & " AND " & TABLE_NAME & " = '" & strTableName & "' "

        ds = comm.ExecuteQueryTransaction(strSQL, Commands.ReturnType.DataSetType)
        If ds.Tables(0).Rows(0)(0).ToString <> "" Then
            pkidStart = ds.Tables(0).Rows(0)(0)
        End If

        Return pkidStart

    End Function

    '***************************************************************************
    '* GetNextID
    '**************************************************************************/
    Public Shared Function GetNextID() As Long

        WriteToLogFile(CLASSNAME & " - In GetNextID")

        Dim comm As New Commands
        Dim ds As New DataSet
        Dim strSQL As String
        Dim nextID As Long = PKID_START

        strSQL = "SELECT MAX({1}) FROM {T} "

        strSQL = strSQL.Replace("{T}", TABLENAME)
        strSQL = strSQL.Replace("{1}", PKID)

        Try
            WriteToLogFile(strSQL)
            ds = comm.ExecuteQueryTransaction(strSQL, Commands.ReturnType.DataSetType)
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
    '* GetNextID
    '**************************************************************************/
    Public Shared Function GetNextPKIdByMax(ByVal tableName As String, ByVal pkidStart As Long) As Long

        WriteToLogFile(CLASSNAME & " - In GetNextPKIdByMax")

        Dim comm As New Commands
        Dim ds As New DataSet
        Dim strSQL As String
        Dim nextID As Long = PKID_START

        strSQL = "SELECT MAX({1}) FROM {T} "

        strSQL = strSQL.Replace("{T}", tableName)
        strSQL = strSQL.Replace("{1}", PKID)

        Try
            WriteToLogFile(strSQL)
            ds = comm.ExecuteQueryTransaction(strSQL, Commands.ReturnType.DataSetType)
            If ds.Tables(0).Rows(0)(0).ToString <> "" Then
                nextID = ds.Tables(0).Rows(0)(0)
                nextID += 1
            End If

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetNextPKIdByMax - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetNextPKIdByMax")

        Return nextID

    End Function
End Class
