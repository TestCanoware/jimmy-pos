Imports Utils.General

Public Class DAStock

    'Constants for Table field mappings
    Private Const CLASSNAME = "DAStock"

    Public Const PKID = "pkid"
    Public Const STOCK_CODE = "stock_code"
    Public Const DESCRIPTION = "description"
    Public Const ITEM_ID = "itemid"
    Public Const LOCATION_ID = "locationid"
    Public Const ACC_PCCENTER_ID = "acc_pccenter_id"
    Public Const BALANCE = "bal"
    Public Const CONDITIONID = "conditionid"
    Public Const STATUS = "status"
    Public Const LASTUPDATE = "lastupdate"
    Public Const USERID_EDIT = "userid_edit"
    Public Const GUID = "guid"
    Public Const UNIT_COST_FIFO = "unit_cost_fifo"
    Public Const UNIT_COST_MA = "unit_cost_ma"
    Public Const UNIT_COST_WA = "unit_cost_wa"
    Public Const UNIT_COST_LAST = "unit_cost_last"
    Public Const UNIT_COST_REPLACEMENT = "unit_cost_replacement"
    Public Const LAST_PURCHASE_DATE = "last_purchase_date"
    Public Const MIN_QTY = "min_qty"
    Public Const MAX_QTY = "max_qty"
    Public Const SUB_LOCATION = "sub_location"


    Public Const TABLENAME = "inv_stock"
    Public Const NO_OF_COLUMNS As Integer = 21
    Public Const APP_NAME = "ThickClient-DataAccess"

    '***************************************************************************
    '* Create
    '**************************************************************************/
    Public Function Create(ByVal obj As DAStockObject) As DAStockObject

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
    Public Sub Update(ByVal obj As DAStockObject)

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
    Public Function GetObject(ByVal id As Integer) As DAStockObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DAStockObject = Nothing
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
    '* GetObject
    '**************************************************************************/
    Public Function GetObject(ByVal itemId As Integer, ByVal locationid As Integer) As DAStockObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DAStockObject = Nothing
        Dim ds As DataSet
        Dim strSQL As String
        Dim row As DataRow

        strSQL = "SELECT * FROM {T} WHERE {1} = {V1} AND {2} = {V2} ORDER BY {1}"

        strSQL = strSQL.Replace("{T}", TABLENAME)
        strSQL = strSQL.Replace("{1}", ITEM_ID)
        strSQL = strSQL.Replace("{V1}", itemId)
        strSQL = strSQL.Replace("{2}", LOCATION_ID)
        strSQL = strSQL.Replace("{V2}", locationid)

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
    Public Function GetObject(ByVal row As DataRow) As DAStockObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DAStockObject

        Try
            obj = New DAStockObject
            obj.pkid = row(PKID)
            obj.stockCode = row(STOCK_CODE)
            obj.description = row(DESCRIPTION)
            obj.itemId = row(ITEM_ID)
            obj.locationId = row(LOCATION_ID)
            obj.accPCCenterId = row(ACC_PCCENTER_ID)
            obj.balance = row(BALANCE)
            obj.conditionId = row(CONDITIONID)
            obj.status = row(STATUS)
            obj.lastUpdate = row(LASTUPDATE)
            obj.userIdUpdate = row(USERID_EDIT)
            obj.guid = row(GUID)
            obj.unitCostFifo = row(UNIT_COST_FIFO)
            obj.unitCostMA = row(UNIT_COST_MA)
            obj.unitCostWA = row(UNIT_COST_WA)
            obj.unitCostLast = row(UNIT_COST_LAST)
            obj.unitCostReplacement = row(UNIT_COST_REPLACEMENT)
            obj.lastPurchaseDate = row(LAST_PURCHASE_DATE)
            obj.minQty = row(MIN_QTY)
            obj.maxQty = row(MAX_QTY)
            obj.subLocation = row(SUB_LOCATION)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetObject - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetObject")

        Return obj

    End Function


    Public Function ReplaceStatement(ByVal strSQL As String, ByVal obj As DAStockObject) As String

        strSQL = strSQL.Replace("{T}", TABLENAME)

        strSQL = strSQL.Replace("{1}", PKID)
        strSQL = strSQL.Replace("{2}", STOCK_CODE)
        strSQL = strSQL.Replace("{3}", DESCRIPTION)
        strSQL = strSQL.Replace("{4}", ITEM_ID)
        strSQL = strSQL.Replace("{5}", LOCATION_ID)
        strSQL = strSQL.Replace("{6}", ACC_PCCENTER_ID)
        strSQL = strSQL.Replace("{7}", BALANCE)
        strSQL = strSQL.Replace("{8}", CONDITIONID)
        strSQL = strSQL.Replace("{9}", STATUS)
        strSQL = strSQL.Replace("{10}", LASTUPDATE)
        strSQL = strSQL.Replace("{11}", USERID_EDIT)
        strSQL = strSQL.Replace("{12}", GUID)
        strSQL = strSQL.Replace("{13}", UNIT_COST_FIFO)
        strSQL = strSQL.Replace("{14}", UNIT_COST_MA)
        strSQL = strSQL.Replace("{15}", UNIT_COST_WA)
        strSQL = strSQL.Replace("{16}", UNIT_COST_LAST)
        strSQL = strSQL.Replace("{17}", UNIT_COST_REPLACEMENT)
        strSQL = strSQL.Replace("{18}", LAST_PURCHASE_DATE)
        strSQL = strSQL.Replace("{19}", MIN_QTY)
        strSQL = strSQL.Replace("{20}", MAX_QTY)
        strSQL = strSQL.Replace("{21}", SUB_LOCATION)

        strSQL = strSQL.Replace("{V1}", PreparedStatement(obj.pkid))
        strSQL = strSQL.Replace("{V2}", PreparedStatement(obj.stockCode))
        strSQL = strSQL.Replace("{V3}", PreparedStatement(obj.description))
        strSQL = strSQL.Replace("{V4}", PreparedStatement(obj.itemId))
        strSQL = strSQL.Replace("{V5}", PreparedStatement(obj.locationId))
        strSQL = strSQL.Replace("{V6}", PreparedStatement(obj.accPCCenterId))
        strSQL = strSQL.Replace("{V7}", PreparedStatement(obj.balance))
        strSQL = strSQL.Replace("{V8}", PreparedStatement(obj.conditionId))
        strSQL = strSQL.Replace("{V9}", PreparedStatement(obj.status))
        strSQL = strSQL.Replace("{V10}", PreparedStatement(obj.lastUpdate))
        strSQL = strSQL.Replace("{V11}", PreparedStatement(obj.userIdUpdate))
        strSQL = strSQL.Replace("{V12}", PreparedStatement(obj.guid))
        strSQL = strSQL.Replace("{V13}", PreparedStatement(obj.unitCostFifo))
        strSQL = strSQL.Replace("{V14}", PreparedStatement(obj.unitCostMA))
        strSQL = strSQL.Replace("{V15}", PreparedStatement(obj.unitCostWA))
        strSQL = strSQL.Replace("{V16}", PreparedStatement(obj.unitCostLast))
        strSQL = strSQL.Replace("{V17}", PreparedStatement(obj.unitCostReplacement))
        strSQL = strSQL.Replace("{V18}", PreparedStatement(obj.lastPurchaseDate))
        strSQL = strSQL.Replace("{V19}", PreparedStatement(obj.minQty))
        strSQL = strSQL.Replace("{V20}", PreparedStatement(obj.maxQty))
        strSQL = strSQL.Replace("{V21}", PreparedStatement(obj.subLocation))


        Return strSQL

    End Function


    Public Sub UpdateStockBalance(ByVal pkid As Integer, ByVal qty As Integer)

        WriteToLogFile(CLASSNAME & " - In UpdateStockBalance")

        Dim comm As New Commands
        Dim strSQL As String

        strSQL = " UPDATE {T} SET bal = bal - " & qty & " WHERE pkid = " & pkid
        strSQL = strSQL.Replace("{T}", TABLENAME)

        Try
            WriteToLogFile(strSQL)
            comm.ExecuteNonQueryTransaction(strSQL)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - Update - " & ex.Message)

        End Try

        WriteToLogFile(CLASSNAME & " - Leave UpdateStockBalance")

    End Sub

End Class

