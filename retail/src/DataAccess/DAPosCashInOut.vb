Imports Utils.General

Public Class DAPosCashInOut

    'Constants for Table field mappings
    Private Const CLASSNAME = "DAPosCashInOut"

    Public Const PKID = "pkid"
    Public Const BRANCH_ID = "branch_id"
    Public Const POS_ID = "pos_id"
    Public Const USER_ID = "user_id"
    Public Const AMOUNT = "amount"
    Public Const REMARKS = "remarks"
    Public Const STATUS = "status"
    Public Const LASTUPDATE = "lastupdate"

    Public Const STATUS_CASH_IN = "CASH IN"
    Public Const STATUS_CASH_OUT = "CASH OUT"

    Public Const TABLENAME = "pos_cash_in_out"
    Public Const NO_OF_COLUMNS As Integer = 8
    Public Const APP_NAME = "ThickClient-DataAccess"
    Public Const START_ID = 1

    '***************************************************************************
    '* Create
    '**************************************************************************/
    Public Function Create(ByVal obj As DAPosCashInOutObject) As DAPosCashInOutObject

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
    Public Sub Update(ByVal obj As DAPosCashInOutObject)

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
    Public Function GetObject(ByVal id As Integer) As DAPosCashInOutObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DAPosCashInOutObject = Nothing
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
    Public Function GetObject(ByVal row As DataRow) As DAPosCashInOutObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DAPosCashInOutObject

        Try
            obj = New DAPosCashInOutObject
            obj.pkid = row(PKID)
            obj.branchId = row(BRANCH_ID)
            obj.posId = row(POS_ID)
            obj.userId = row(USER_ID)
            obj.amount = row(AMOUNT)
            obj.remarks = row(REMARKS)
            obj.status = row(STATUS)
            obj.lastupdate = row(LASTUPDATE)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetObject - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetObject")

        Return obj

    End Function


    Public Function ReplaceStatement(ByVal strSQL As String, ByVal obj As DAPosCashInOutObject) As String

        strSQL = strSQL.Replace("{T}", TABLENAME)

        strSQL = strSQL.Replace("{1}", PKID)
        strSQL = strSQL.Replace("{2}", BRANCH_ID)
        strSQL = strSQL.Replace("{3}", POS_ID)
        strSQL = strSQL.Replace("{4}", USER_ID)
        strSQL = strSQL.Replace("{5}", AMOUNT)
        strSQL = strSQL.Replace("{6}", REMARKS)
        strSQL = strSQL.Replace("{7}", STATUS)
        strSQL = strSQL.Replace("{8}", LASTUPDATE)

        strSQL = strSQL.Replace("{V1}", PreparedStatement(obj.pkid))
        strSQL = strSQL.Replace("{V2}", PreparedStatement(obj.branchId))
        strSQL = strSQL.Replace("{V3}", PreparedStatement(obj.posId))
        strSQL = strSQL.Replace("{V4}", PreparedStatement(obj.userId))
        strSQL = strSQL.Replace("{V5}", PreparedStatement(obj.amount))
        strSQL = strSQL.Replace("{V6}", PreparedStatement(obj.remarks))
        strSQL = strSQL.Replace("{V7}", PreparedStatement(obj.status))
        strSQL = strSQL.Replace("{V8}", PreparedStatement(obj.lastupdate))

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
    '* GetCashInOutSummary
    '**************************************************************************/
    Public Function GetCashInOutSummary(ByVal userId As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, _
                                            ByVal posId As Integer) As DataSet

        WriteToLogFile(CLASSNAME & " - In GetCashInOutSummary")

        Dim comm As New Commands
        Dim strSQL As String

        strSQL = "SELECT count(*) as count, sum(amount)as sum, status FROM pos_cash_in_out WHERE lastupdate >= {0} AND lastupdate < {1}"

        strSQL = String.Format(strSQL, PreparedStatement(dateFrom), PreparedStatement(dateTo))

        If userId <> 0 Then
            strSQL = strSQL & " AND user_id = " & userId
        End If

        If posId <> 0 Then
            strSQL = strSQL & " AND pos_id  = " & posId
        End If

        strSQL = strSQL & " GROUP BY status "

        Try
            WriteToLogFile(strSQL)
            Return comm.ExecuteQuery(strSQL, Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetCashInOutSummary - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetCashInOutSummary")

    End Function


End Class

