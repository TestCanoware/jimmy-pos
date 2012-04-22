Imports Utils.General

Public Class DASerialNumberDelta

    'Constants for Table field mappings
    Private Const CLASSNAME = "DASerialNumberDelta"

    Public Const GUID = "guid"
    Public Const PARENT_GUID = "parent_guid"
    Public Const NAME_SPACE = "namespace"
    Public Const TXN_TYPE = "tx_type"
    Public Const TXN_CODE = "tx_code"
    Public Const SERIAL = "serial"
    Public Const PIC = "person_in_charge"
    Public Const PNODE = "process_node"
    Public Const STOCKID = "stockid"
    Public Const ITEMCODE = "itemcode"
    Public Const REF_STOCKID = "ref_stockid"
    Public Const ITEMID = "itemid"
    Public Const QUANTITY = "qty"
    Public Const CURRENCY = "currency"
    Public Const UNIT_PRICE = "unit_price"
    Public Const CURRENCY2 = "currency2"
    Public Const UNIT_PRICE2 = "unit_price2"
    Public Const TXN_TIME = "tx_time"
    Public Const SCH_TIME = "sch_time"
    Public Const WARRANTY_START = "warranty_start"
    Public Const WARRANTY_END = "warranty_end"
    Public Const REMARKS = "remarks"
    Public Const INT_RESERVED1 = "int_reserved1"
    Public Const STR_RESERVED1 = "str_reserved1"
    Public Const STR_RESERVED2 = "str_reserved2"
    Public Const STR_RESERVED3 = "str_reserved3"
    Public Const STR_RESERVED4 = "str_reserved4"
    Public Const ENTITY_TABLE = "entity_table"
    Public Const ENTITY_ID = "entity_id"
    Public Const DOC_TABLE = "doc_table"
    Public Const DOC_KEY = "doc_key"
    Public Const STATE = "state"
    Public Const STATUS = "status"
    Public Const USERID_EDIT = "userid_edit"
    Public Const TIME_EDIT = "time_edit"
    Public Const STOCK_DELTA = "stock_delta"
    Public Const LOYALTY_LOGIC = "loyalty_logic"
    Public Const LOYALTY_POINTS_AWARDED = "loyalty_points_awarded"
    Public Const LOYALTY_POINTS_REDEEMED = "loyalty_points_redeemed"


    Public Const TABLENAME = "inv_serial_number_delta"
    Public Const NO_OF_COLUMNS As Integer = 39
    Public Const APP_NAME = "ThickClient-DataAccess"

    '***************************************************************************
    '* Create
    '**************************************************************************/
    Public Function Create(ByVal obj As DASerialNumberDeltaObject) As DASerialNumberDeltaObject

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
    Public Sub Update(ByVal obj As DASerialNumberDeltaObject)

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
    Public Function GetObject(ByVal strGuid As String, ByVal intItemId As Integer) As DASerialNumberDeltaObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DASerialNumberDeltaObject = Nothing
        Dim ds As DataSet
        Dim strSQL As String
        Dim row As DataRow

        strSQL = "SELECT * FROM {T} WHERE {1} = '{V1}' AND {2} = {V2} ORDER BY {1}"

        strSQL = strSQL.Replace("{T}", TABLENAME)
        strSQL = strSQL.Replace("{1}", GUID)
        strSQL = strSQL.Replace("{V1}", strGuid)
        strSQL = strSQL.Replace("{2}", ITEMID)
        strSQL = strSQL.Replace("{V2}", intItemId)

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
        strSQL = strSQL.Replace("{1}", SERIAL)

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
    Public Function GetObject(ByVal row As DataRow) As DASerialNumberDeltaObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DASerialNumberDeltaObject

        Try
            obj = New DASerialNumberDeltaObject
            obj.guid = row(GUID)
            obj.parentGuid = row(PARENT_GUID)
            obj.name_space = row(NAME_SPACE)
            obj.txnType = row(TXN_TYPE)
            obj.txnCode = row(TXN_CODE)
            obj.serialNumber = row(SERIAL)
            obj.personInCharge = row(PIC)
            obj.processNode = row(PNODE)
            obj.stockId = row(STOCKID)
            obj.itemId = row(ITEMID)
            obj.itemCode = row(ITEMCODE)
            obj.refStockId = row(REF_STOCKID)
            obj.quantity = row(QUANTITY)
            obj.currency = row(CURRENCY)
            obj.unitPrice = row(UNIT_PRICE)
            obj.currency2 = row(CURRENCY2)
            obj.unitPrice2 = row(UNIT_PRICE2)
            obj.txnTime = row(TXN_TIME)
            obj.schTime = row(SCH_TIME)
            obj.warrantyStart = row(WARRANTY_START)
            obj.warrantyEnd = row(WARRANTY_END)
            obj.remarks = row(REMARKS)
            obj.intReserved1 = row(INT_RESERVED1)
            obj.strReserved1 = row(STR_RESERVED1)
            obj.strReserved2 = row(STR_RESERVED2)
            obj.strReserved3 = row(STR_RESERVED3)
            obj.strReserved4 = row(STR_RESERVED4)
            obj.entityTable = row(ENTITY_TABLE)
            obj.entityId = row(ENTITY_ID)
            obj.docTable = row(DOC_TABLE)
            obj.docKey = row(DOC_KEY)
            obj.state = row(STATE)
            obj.status = row(STATUS)
            obj.userIdEdit = row(USERID_EDIT)
            obj.timeEdit = row(TIME_EDIT)
            obj.stockDelta = row(STOCK_DELTA)
            obj.loyaltyLogic = row(LOYALTY_LOGIC)
            obj.loyaltyPointsAwarded = row(LOYALTY_POINTS_AWARDED)
            obj.loyaltyPointsRedeemed = row(LOYALTY_POINTS_REDEEMED)


        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetObject - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetObject")

        Return obj

    End Function


    Public Function ReplaceStatement(ByVal strSQL As String, ByVal obj As DASerialNumberDeltaObject) As String

        strSQL = strSQL.Replace("{T}", TABLENAME)

        strSQL = strSQL.Replace("{1}", GUID)
        strSQL = strSQL.Replace("{2}", PARENT_GUID)
        strSQL = strSQL.Replace("{3}", NAME_SPACE)
        strSQL = strSQL.Replace("{4}", TXN_TYPE)
        strSQL = strSQL.Replace("{5}", TXN_CODE)
        strSQL = strSQL.Replace("{6}", SERIAL)
        strSQL = strSQL.Replace("{7}", PIC)
        strSQL = strSQL.Replace("{8}", PNODE)
        strSQL = strSQL.Replace("{9}", STOCKID)
        strSQL = strSQL.Replace("{10}", ITEMID)
        strSQL = strSQL.Replace("{11}", ITEMCODE)
        strSQL = strSQL.Replace("{12}", REF_STOCKID)
        strSQL = strSQL.Replace("{13}", QUANTITY)
        strSQL = strSQL.Replace("{14}", CURRENCY)
        strSQL = strSQL.Replace("{15}", UNIT_PRICE)
        strSQL = strSQL.Replace("{16}", CURRENCY2)
        strSQL = strSQL.Replace("{17}", UNIT_PRICE2)
        strSQL = strSQL.Replace("{18}", TXN_TIME)
        strSQL = strSQL.Replace("{19}", SCH_TIME)
        strSQL = strSQL.Replace("{20}", WARRANTY_START)
        strSQL = strSQL.Replace("{21}", WARRANTY_END)
        strSQL = strSQL.Replace("{22}", REMARKS)
        strSQL = strSQL.Replace("{23}", INT_RESERVED1)
        strSQL = strSQL.Replace("{24}", STR_RESERVED1)
        strSQL = strSQL.Replace("{25}", STR_RESERVED2)
        strSQL = strSQL.Replace("{26}", STR_RESERVED3)
        strSQL = strSQL.Replace("{27}", STR_RESERVED4)
        strSQL = strSQL.Replace("{28}", ENTITY_TABLE)
        strSQL = strSQL.Replace("{29}", ENTITY_ID)
        strSQL = strSQL.Replace("{30}", DOC_TABLE)
        strSQL = strSQL.Replace("{31}", DOC_KEY)
        strSQL = strSQL.Replace("{32}", STATE)
        strSQL = strSQL.Replace("{33}", STATUS)
        strSQL = strSQL.Replace("{34}", USERID_EDIT)
        strSQL = strSQL.Replace("{35}", TIME_EDIT)
        strSQL = strSQL.Replace("{36}", STOCK_DELTA)
        strSQL = strSQL.Replace("{37}", LOYALTY_LOGIC)
        strSQL = strSQL.Replace("{38}", LOYALTY_POINTS_AWARDED)
        strSQL = strSQL.Replace("{39}", LOYALTY_POINTS_REDEEMED)

        strSQL = strSQL.Replace("{V1}", PreparedStatement(obj.guid))
        strSQL = strSQL.Replace("{V2}", PreparedStatement(obj.parentGuid))
        strSQL = strSQL.Replace("{V3}", PreparedStatement(obj.name_space))
        strSQL = strSQL.Replace("{V4}", PreparedStatement(obj.txnType))
        strSQL = strSQL.Replace("{V5}", PreparedStatement(obj.txnCode))
        strSQL = strSQL.Replace("{V6}", PreparedStatement(obj.serialNumber))
        strSQL = strSQL.Replace("{V7}", PreparedStatement(obj.personInCharge))
        strSQL = strSQL.Replace("{V8}", PreparedStatement(obj.processNode))
        strSQL = strSQL.Replace("{V9}", PreparedStatement(obj.stockId))
        strSQL = strSQL.Replace("{V10}", PreparedStatement(obj.itemId))
        strSQL = strSQL.Replace("{V11}", PreparedStatement(obj.itemCode))
        strSQL = strSQL.Replace("{V12}", PreparedStatement(obj.refStockId))
        strSQL = strSQL.Replace("{V13}", PreparedStatement(obj.quantity))
        strSQL = strSQL.Replace("{V14}", PreparedStatement(obj.currency))
        strSQL = strSQL.Replace("{V15}", PreparedStatement(obj.unitPrice))
        strSQL = strSQL.Replace("{V16}", PreparedStatement(obj.currency2))
        strSQL = strSQL.Replace("{V17}", PreparedStatement(obj.unitPrice2))
        strSQL = strSQL.Replace("{V18}", PreparedStatement(obj.txnTime))
        strSQL = strSQL.Replace("{V19}", PreparedStatement(obj.schTime))
        strSQL = strSQL.Replace("{V20}", PreparedStatement(obj.warrantyStart))
        strSQL = strSQL.Replace("{V21}", PreparedStatement(obj.warrantyEnd))
        strSQL = strSQL.Replace("{V22}", PreparedStatement(obj.remarks))
        strSQL = strSQL.Replace("{V23}", PreparedStatement(obj.intReserved1))
        strSQL = strSQL.Replace("{V24}", PreparedStatement(obj.strReserved1))
        strSQL = strSQL.Replace("{V25}", PreparedStatement(obj.strReserved2))
        strSQL = strSQL.Replace("{V26}", PreparedStatement(obj.strReserved3))
        strSQL = strSQL.Replace("{V27}", PreparedStatement(obj.strReserved4))
        strSQL = strSQL.Replace("{V28}", PreparedStatement(obj.entityTable))
        strSQL = strSQL.Replace("{V29}", PreparedStatement(obj.entityId))
        strSQL = strSQL.Replace("{V30}", PreparedStatement(obj.docTable))
        strSQL = strSQL.Replace("{V31}", PreparedStatement(obj.docKey))
        strSQL = strSQL.Replace("{V32}", PreparedStatement(obj.state))
        strSQL = strSQL.Replace("{V33}", PreparedStatement(obj.status))
        strSQL = strSQL.Replace("{V34}", PreparedStatement(obj.userIdEdit))
        strSQL = strSQL.Replace("{V35}", PreparedStatement(obj.timeEdit))
        strSQL = strSQL.Replace("{V36}", PreparedStatement(obj.stockDelta))
        strSQL = strSQL.Replace("{V37}", PreparedStatement(obj.loyaltyLogic))
        strSQL = strSQL.Replace("{V38}", PreparedStatement(obj.loyaltyPointsAwarded))
        strSQL = strSQL.Replace("{V39}", PreparedStatement(obj.loyaltyPointsRedeemed))


        Return strSQL

    End Function

End Class

