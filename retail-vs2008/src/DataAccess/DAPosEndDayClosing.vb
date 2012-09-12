Imports Utils.General

Public Class DAPosEndDayClosing

    'Constants for Table field mappings
    Private Const CLASSNAME = "DAPosEndDayClosing"

    Public Const PKID = "pkid"
    Public Const BRANCH_ID = "branch_id"
    Public Const POS_ID = "pos_id"
    Public Const USER_ID = "user_id"
    Public Const TIME_START = "time_start"
    Public Const TIME_END = "time_end"
    Public Const QTY_BILL = "qty_bill"
    Public Const QTY_ITEM = "qty_item"
    Public Const CASH_IN = "cash_in"
    Public Const CASH_OUT = "cash_out"
    Public Const AMOUNT = "amount"
    Public Const STATUS = "status"
    Public Const LASTUPDATE = "lastupdate"

    Public Const STATUS_START = "STATUS_START"
    Public Const STATUS_END = "STATUS_END"

    Public Const TABLENAME = "pos_end_day_closing"
    Public Const NO_OF_COLUMNS As Integer = 13
    Public Const APP_NAME = "ThickClient-DataAccess"
    Public Const START_ID = 1

    '***************************************************************************
    '* Create
    '**************************************************************************/
    Public Function Create(ByVal obj As DAPosEndDayClosingObject) As DAPosEndDayClosingObject

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
    Public Sub Update(ByVal obj As DAPosEndDayClosingObject)

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
    Public Function GetObject(ByVal id As Integer) As DAPosEndDayClosingObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DAPosEndDayClosingObject = Nothing
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
    Public Function GetObject(ByVal row As DataRow) As DAPosEndDayClosingObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DAPosEndDayClosingObject

        Try
            obj = New DAPosEndDayClosingObject
            obj.PKID = row(PKID)
            obj.branchId = row(BRANCH_ID)
            obj.posId = row(POS_ID)
            obj.userId = row(USER_ID)
            obj.timeStart = row(TIME_START)
            obj.timeEnd = row(TIME_END)
            obj.qtyBill = row(QTY_BILL)
            obj.qtyItem = row(QTY_ITEM)
            obj.cashIn = row(CASH_IN)
            obj.cashOut = row(CASH_OUT)
            obj.amount = row(AMOUNT)
            obj.status = row(STATUS)
            obj.LASTUPDATE = row(LASTUPDATE)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetObject - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetObject")

        Return obj

    End Function

    '***************************************************************************
    '* GetEndDayClosing
    '**************************************************************************/
    Public Function GetEndDayClosing(ByVal posId As Integer) As DAPosEndDayClosingObject

        WriteToLogFile(CLASSNAME & " - In GetEndDayClosing")

        Dim comm As New Commands
        Dim obj As DAPosEndDayClosingObject = Nothing
        Dim ds As DataSet
        Dim strSQL As String
        Dim row As DataRow

        strSQL = "SELECT * FROM {T} WHERE {1} IN (SELECT MAX({1}) FROM {T} WHERE {3} = {V3})"

        strSQL = strSQL.Replace("{T}", TABLENAME)
        strSQL = strSQL.Replace("{1}", PKID)
        strSQL = strSQL.Replace("{3}", POS_ID)

        strSQL = strSQL.Replace("{V3}", PreparedStatement(posId))

        Try
            WriteToLogFile(strSQL)
            ds = comm.ExecuteQuery(strSQL, Commands.ReturnType.DataSetType)

            If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
                row = ds.Tables(0).Rows(0)
                obj = GetObject(row)
            End If

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetEndDayClosing - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetEndDayClosing")

        Return obj

    End Function

    '***************************************************************************
    '* ReplaceStatement
    '**************************************************************************/
    Public Function ReplaceStatement(ByVal strSQL As String, ByVal obj As DAPosEndDayClosingObject) As String

        strSQL = strSQL.Replace("{T}", TABLENAME)

        strSQL = strSQL.Replace("{1}", PKID)
        strSQL = strSQL.Replace("{2}", BRANCH_ID)
        strSQL = strSQL.Replace("{3}", POS_ID)
        strSQL = strSQL.Replace("{4}", USER_ID)
        strSQL = strSQL.Replace("{5}", TIME_START)
        strSQL = strSQL.Replace("{6}", TIME_END)
        strSQL = strSQL.Replace("{7}", QTY_BILL)
        strSQL = strSQL.Replace("{8}", QTY_ITEM)
        strSQL = strSQL.Replace("{9}", CASH_IN)
        strSQL = strSQL.Replace("{10}", CASH_OUT)
        strSQL = strSQL.Replace("{11}", AMOUNT)
        strSQL = strSQL.Replace("{12}", STATUS)
        strSQL = strSQL.Replace("{13}", LASTUPDATE)

        strSQL = strSQL.Replace("{V1}", PreparedStatement(obj.pkid))
        strSQL = strSQL.Replace("{V2}", PreparedStatement(obj.branchId))
        strSQL = strSQL.Replace("{V3}", PreparedStatement(obj.posId))
        strSQL = strSQL.Replace("{V4}", PreparedStatement(obj.userId))
        strSQL = strSQL.Replace("{V5}", PreparedStatement(obj.timeStart))
        strSQL = strSQL.Replace("{V6}", PreparedStatement(obj.timeEnd))
        strSQL = strSQL.Replace("{V7}", PreparedStatement(obj.qtyBill))
        strSQL = strSQL.Replace("{V8}", PreparedStatement(obj.qtyItem))
        strSQL = strSQL.Replace("{V9}", PreparedStatement(obj.cashIn))
        strSQL = strSQL.Replace("{V10}", PreparedStatement(obj.cashOut))
        strSQL = strSQL.Replace("{V11}", PreparedStatement(obj.amount))
        strSQL = strSQL.Replace("{V12}", PreparedStatement(obj.status))
        strSQL = strSQL.Replace("{V13}", PreparedStatement(obj.lastupdate))

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
    '* GetDataset
    '**************************************************************************/
    Public Function GetDataset(ByVal whereClause As String) As DataSet

        WriteToLogFile(CLASSNAME & " - In GetDataset")

        Dim comm As New Commands
        Dim strSQL As String

        strSQL = "SELECT * FROM {T} WHERE {1} "

        strSQL = strSQL.Replace("{T}", TABLENAME)
        strSQL = strSQL.Replace("{1}", whereClause)

        Try
            WriteToLogFile(strSQL)
            Return comm.ExecuteQuery(strSQL, Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetDataset - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetDataset")

    End Function

End Class

