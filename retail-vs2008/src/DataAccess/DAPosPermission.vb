Imports Utils.General

Public Class DAPosPermission

    'Constants for Table field mappings
    Private Const CLASSNAME = "DAPosPermission"

    Public Const PKID = "pkid"
    Public Const USER_ID = "userid"
    Public Const PERMISSION = "permission"
    Public Const VALUE = "value"

    Public Const TABLENAME = "pos_Permission"
    Public Const NO_OF_COLUMNS As Integer = 4
    Public Const APP_NAME = "ThickClient-DataAccess"
    Public Const START_ID = 1

    '***************************************************************************
    '* Create
    '**************************************************************************/
    Public Function Create(ByVal obj As DAPosPermissionObject) As DAPosPermissionObject

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
    Public Sub Update(ByVal obj As DAPosPermissionObject)

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
            'WriteToLogFile(strSQL)
            comm.ExecuteNonQuery(strSQL)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - Update - " & ex.Message)

        End Try

        WriteToLogFile(CLASSNAME & " - Leave Update")

    End Sub


    '***************************************************************************
    '* Delete
    '**************************************************************************/
    Public Sub Delete()

        WriteToLogFile(CLASSNAME & " - In Delete")

        Dim comm As New Commands
        Dim strSQL As String

        strSQL = "DELETE FROM " & TABLENAME

        Try
            'WriteToLogFile(strSQL)
            comm.ExecuteNonQuery(strSQL)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - Delete - " & ex.Message)

        End Try

        WriteToLogFile(CLASSNAME & " - Leave Delete")

    End Sub


    '***************************************************************************
    '* GetObject
    '**************************************************************************/
    Public Function GetObject(ByVal id As Integer) As DAPosPermissionObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DAPosPermissionObject = Nothing
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
    Public Function GetObject(ByVal row As DataRow) As DAPosPermissionObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DAPosPermissionObject

        Try
            obj = New DAPosPermissionObject
            obj.pkid = row(PKID)
            obj.userId = row(USER_ID)
            obj.permission = row(PERMISSION)
            obj.value = row(VALUE)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetObject - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetObject")

        Return obj

    End Function


    '***************************************************************************
    '* ReplaceStatement
    '**************************************************************************/
    Public Function ReplaceStatement(ByVal strSQL As String, ByVal obj As DAPosPermissionObject) As String

        strSQL = strSQL.Replace("{T}", TABLENAME)

        strSQL = strSQL.Replace("{1}", PKID)
        strSQL = strSQL.Replace("{2}", USER_ID)
        strSQL = strSQL.Replace("{3}", PERMISSION)
        strSQL = strSQL.Replace("{4}", VALUE)

        strSQL = strSQL.Replace("{V1}", PreparedStatement(obj.pkid))
        strSQL = strSQL.Replace("{V2}", PreparedStatement(obj.userId))
        strSQL = strSQL.Replace("{V3}", PreparedStatement(obj.permission))
        strSQL = strSQL.Replace("{V4}", PreparedStatement(obj.value))

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
    '* GetExistUserPermission
    '**************************************************************************/
    Public Function GetExistUserPermission(ByVal userId As Integer, ByVal strPermission As String) As DAPosPermissionObject

        WriteToLogFile(CLASSNAME & " - In GetExistUserPermission")

        Dim comm As New Commands
        Dim strSQL As String
        Dim ds As New DataSet
        Dim obj As DAPosPermissionObject = Nothing

        strSQL = "SELECT * FROM {T} WHERE {1} = {V1} AND {2} = {V2}"

        strSQL = strSQL.Replace("{T}", TABLENAME)
        strSQL = strSQL.Replace("{1}", USER_ID)
        strSQL = strSQL.Replace("{2}", PERMISSION)

        strSQL = strSQL.Replace("{V1}", PreparedStatement(userId))
        strSQL = strSQL.Replace("{V2}", PreparedStatement(strPermission))

        Try
            'WriteToLogFile(strSQL)
            ds = comm.ExecuteQuery(strSQL, Commands.ReturnType.DataSetType)
            If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
                obj = GetObject(ds.Tables(0).Rows(0))
            End If

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetExistUserPermission - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetExistUserPermission")

        Return obj

    End Function


    '***************************************************************************
    '* UpdateUserPermissionDefault
    '**************************************************************************/
    Public Sub UpdateUserPermissionDefault(ByVal userId As Integer)

        WriteToLogFile(CLASSNAME & " - In UpdateUserPermissionDefault")

        Dim comm As New Commands
        Dim strSQL As String

        strSQL = "UPDATE {T} SET {1}={V1} WHERE {2}={V2}"

        Try
            'WriteToLogFile(strSQL)
            strSQL = strSQL.Replace("{T}", TABLENAME)
            strSQL = strSQL.Replace("{1}", VALUE)
            strSQL = strSQL.Replace("{2}", USER_ID)

            strSQL = strSQL.Replace("{V1}", PreparedStatement("FALSE"))
            strSQL = strSQL.Replace("{V2}", PreparedStatement(userId))

            comm.ExecuteNonQuery(strSQL)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - UpdateUserPermissionDefault - " & ex.Message)

        End Try

        WriteToLogFile(CLASSNAME & " - Leave UpdateUserPermissionDefault")

    End Sub

End Class

