Imports Utils.General

Public Class DATaxConfig

    'Constants for Table field mappings
    Private Const CLASSNAME = "DATaxConfig"

    Public Const PKID = "pkid"
    Public Const GUID = "guid"
    Public Const TAX_TYPE = "tax_type"
    Public Const TAX_TYPE_DESCRIPTION = "tax_type_description"
    Public Const TAX_CODE = "tax_code"
    Public Const TAX_CODE_DESCRIPTION = "tax_code_description"
    Public Const TAX_RATE = "tax_rate"
    Public Const STATUS = "status"

    Public Const TABLENAME = "acc_tax_config"
    Public Const NO_OF_COLUMNS As Integer = 8
    Public Const APP_NAME = "ThickClient-DataAccess"

    '***************************************************************************
    '* Create
    '**************************************************************************/
    Public Function Create(ByVal obj As DATaxConfigObject) As DATaxConfigObject

        WriteToLogFile(CLASSNAME & " - In Create")

        Dim comm As New Commands
        Dim strSQL, strSQL1, strSQL2 As String

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
    Public Sub Update(ByVal obj As DATaxConfigObject)

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
    Public Function GetObject(ByVal id As Integer) As DATaxConfigObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DATaxConfigObject = Nothing
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
        strSQL = strSQL.Replace("{1}", TAX_CODE)

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
    Public Function GetObject(ByVal row As DataRow) As DATaxConfigObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DATaxConfigObject

        Try
            obj = New DATaxConfigObject
            obj.pkid = row(PKID)
            obj.guid = row(GUID)
            obj.taxType = row(TAX_TYPE)
            obj.taxTypeDescription = row(TAX_TYPE_DESCRIPTION)
            obj.taxCode = row(TAX_CODE)
            obj.taxCodeDescription = row(TAX_CODE_DESCRIPTION)
            obj.taxRate = row(TAX_RATE)
            obj.status = row(STATUS)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetObject - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetObject")

        Return obj

    End Function


    Public Function ReplaceStatement(ByVal strSQL As String, ByVal obj As DATaxConfigObject) As String

        strSQL = strSQL.Replace("{T}", TABLENAME)

        strSQL = strSQL.Replace("{1}", PKID)
        strSQL = strSQL.Replace("{2}", GUID)
        strSQL = strSQL.Replace("{3}", TAX_TYPE)
        strSQL = strSQL.Replace("{4}", TAX_TYPE_DESCRIPTION)
        strSQL = strSQL.Replace("{5}", TAX_CODE)
        strSQL = strSQL.Replace("{6}", TAX_CODE_DESCRIPTION)
        strSQL = strSQL.Replace("{7}", TAX_RATE)
        strSQL = strSQL.Replace("{8}", STATUS)

        strSQL = strSQL.Replace("{V1}", PreparedStatement(obj.pkid))
        strSQL = strSQL.Replace("{V2}", PreparedStatement(obj.guid))
        strSQL = strSQL.Replace("{V3}", PreparedStatement(obj.taxType))
        strSQL = strSQL.Replace("{V4}", PreparedStatement(obj.taxTypeDescription))
        strSQL = strSQL.Replace("{V5}", PreparedStatement(obj.taxCode))
        strSQL = strSQL.Replace("{V6}", PreparedStatement(obj.taxCodeDescription))
        strSQL = strSQL.Replace("{V7}", PreparedStatement(obj.taxRate))
        strSQL = strSQL.Replace("{V8}", PreparedStatement(obj.status))


        Return strSQL

    End Function
End Class

