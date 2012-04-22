Imports Utils.General

Public Class DAPaymentVoucherItem

    'Constants for Table field mappings
    Private Const CLASSNAME = "DAPaymentVoucherItem"

    Public Const PKID = "pkid"
    Public Const INDEX_ID = "index_id"
    Public Const POSITION = "position"
    Public Const UUID = "uuid"
    Public Const TXN_TYPE = "txn_type"
    Public Const TXN_CODE = "txn_code"
    Public Const CHEQUE_NO = "cheque_no"
    Public Const PC_CENTER = "pc_center"
    Public Const BRANCH = "branch"
    Public Const CATEGORY = "category"
    Public Const PROJECT = "project"
    Public Const GLCODE_DEBIT = "glcode_debit"
    Public Const GLCODE_CREDIT = "glcode_credit"
    Public Const CURRENCY = "currency"
    Public Const AMOUNT = "amount"
    Public Const XRATE = "xrate"
    Public Const CURRENCY2 = "currency2"
    Public Const AMOUNT2 = "amount2"
    Public Const REFERENCE_NO = "reference_no"
    Public Const DESCRIPTION = "description"
    Public Const REMARKS = "remarks"
    Public Const INFO1 = "info1"
    Public Const INFO2 = "info2"
    Public Const ENTITY_TABLE = "entity_table"
    Public Const ENTITY_KEY = "entity_key"
    Public Const ENTITY_NAME = "entity_name"
    Public Const DATE_STMT = "date_stmt"
    Public Const DATE_ITEM = "date_item"
    Public Const USERID_PIC = "userid_pic"
    Public Const STATE = "state"
    Public Const STATUS = "status"

    Public Const STATUS_ACTIVE = "act"
    Public Const STATUS_DELETED = "del"
    Public Const STATUS_INACTIVE = "ina"
    Public Const STATE_CREATED = "cre"
    Public Const STATE_REVERSED = "rvd"

    Public Const TABLENAME = "acc_payment_voucher_item"
    Public Const NO_OF_COLUMNS As Integer = 31
    Public Const APP_NAME = "ThickClient-DataAccess"
    Public Const START_ID = 1001

    '***************************************************************************
    '* Create
    '**************************************************************************/
    Public Function Create(ByVal obj As DAPaymentVoucherItemObject) As DAPaymentVoucherItemObject

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
    Public Sub Update(ByVal obj As DAPaymentVoucherItemObject)

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
    Public Function GetObject(ByVal id As Integer) As DAPaymentVoucherItemObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DAPaymentVoucherItemObject = Nothing
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
    Public Function GetObject(ByVal row As DataRow) As DAPaymentVoucherItemObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DAPaymentVoucherItemObject

        Try
            obj = New DAPaymentVoucherItemObject
            obj.pkid = row(PKID)
            obj.indexId = row(INDEX_ID)
            obj.position = row(POSITION)
            obj.uuid = row(UUID)
            obj.txnType = row(TXN_TYPE)
            obj.txnCode = row(TXN_CODE)
            obj.chequeNo = row(CHEQUE_NO)
            obj.pcCenter = row(PC_CENTER)
            obj.branch = row(BRANCH)
            obj.category = row(CATEGORY)
            obj.project = row(PROJECT)
            obj.glCodeDebit = row(GLCODE_DEBIT)
            obj.glCodeCredit = row(GLCODE_CREDIT)
            obj.currency = row(CURRENCY)
            obj.amount = row(AMOUNT)
            obj.xrate = row(XRATE)
            obj.currency2 = row(CURRENCY2)
            obj.amount2 = row(AMOUNT2)
            obj.referenceNo = row(REFERENCE_NO)
            obj.description = row(DESCRIPTION)
            obj.remarks = row(REMARKS)
            obj.info1 = row(INFO1)
            obj.info2 = row(INFO2)
            obj.entityTable = row(ENTITY_TABLE)
            obj.entityKey = row(ENTITY_KEY)
            obj.entityName = row(ENTITY_NAME)
            obj.dateStmt = row(DATE_STMT)
            obj.dateItem = row(DATE_ITEM)
            obj.userIdPIC = row(USERID_PIC)
            obj.state = row(STATE)
            obj.status = row(STATUS)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetObject - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetObject")

        Return obj

    End Function


    Public Function ReplaceStatement(ByVal strSQL As String, ByVal obj As DAPaymentVoucherItemObject) As String

        strSQL = strSQL.Replace("{T}", TABLENAME)

        strSQL = strSQL.Replace("{1}", PKID)
        strSQL = strSQL.Replace("{2}", INDEX_ID)
        strSQL = strSQL.Replace("{3}", POSITION)
        strSQL = strSQL.Replace("{4}", UUID)
        strSQL = strSQL.Replace("{5}", TXN_TYPE)
        strSQL = strSQL.Replace("{6}", TXN_CODE)
        strSQL = strSQL.Replace("{7}", CHEQUE_NO)
        strSQL = strSQL.Replace("{8}", PC_CENTER)
        strSQL = strSQL.Replace("{9}", BRANCH)
        strSQL = strSQL.Replace("{10}", CATEGORY)
        strSQL = strSQL.Replace("{11}", PROJECT)
        strSQL = strSQL.Replace("{12}", GLCODE_DEBIT)
        strSQL = strSQL.Replace("{13}", GLCODE_CREDIT)
        strSQL = strSQL.Replace("{14}", CURRENCY)
        strSQL = strSQL.Replace("{15}", AMOUNT)
        strSQL = strSQL.Replace("{16}", XRATE)
        strSQL = strSQL.Replace("{17}", CURRENCY2)
        strSQL = strSQL.Replace("{18}", AMOUNT2)
        strSQL = strSQL.Replace("{19}", REFERENCE_NO)
        strSQL = strSQL.Replace("{20}", DESCRIPTION)
        strSQL = strSQL.Replace("{21}", REMARKS)
        strSQL = strSQL.Replace("{22}", INFO1)
        strSQL = strSQL.Replace("{23}", INFO2)
        strSQL = strSQL.Replace("{24}", ENTITY_TABLE)
        strSQL = strSQL.Replace("{25}", ENTITY_KEY)
        strSQL = strSQL.Replace("{26}", ENTITY_NAME)
        strSQL = strSQL.Replace("{27}", DATE_STMT)
        strSQL = strSQL.Replace("{28}", DATE_ITEM)
        strSQL = strSQL.Replace("{29}", USERID_PIC)
        strSQL = strSQL.Replace("{30}", STATE)
        strSQL = strSQL.Replace("{31}", STATUS)

        strSQL = strSQL.Replace("{V1}", PreparedStatement(obj.pkid))
        strSQL = strSQL.Replace("{V2}", PreparedStatement(obj.indexId))
        strSQL = strSQL.Replace("{V3}", PreparedStatement(obj.position))
        strSQL = strSQL.Replace("{V4}", PreparedStatement(obj.uuid))
        strSQL = strSQL.Replace("{V5}", PreparedStatement(obj.txnType))
        strSQL = strSQL.Replace("{V6}", PreparedStatement(obj.txnCode))
        strSQL = strSQL.Replace("{V7}", PreparedStatement(obj.chequeNo))
        strSQL = strSQL.Replace("{V8}", PreparedStatement(obj.pcCenter))
        strSQL = strSQL.Replace("{V9}", PreparedStatement(obj.branch))
        strSQL = strSQL.Replace("{V10}", PreparedStatement(obj.category))
        strSQL = strSQL.Replace("{V11}", PreparedStatement(obj.project))
        strSQL = strSQL.Replace("{V12}", PreparedStatement(obj.glCodeDebit))
        strSQL = strSQL.Replace("{V13}", PreparedStatement(obj.glCodeCredit))
        strSQL = strSQL.Replace("{V14}", PreparedStatement(obj.currency))
        strSQL = strSQL.Replace("{V15}", PreparedStatement(obj.amount))
        strSQL = strSQL.Replace("{V16}", PreparedStatement(obj.xrate))
        strSQL = strSQL.Replace("{V17}", PreparedStatement(obj.currency2))
        strSQL = strSQL.Replace("{V18}", PreparedStatement(obj.amount2))
        strSQL = strSQL.Replace("{V19}", PreparedStatement(obj.referenceNo))
        strSQL = strSQL.Replace("{V20}", PreparedStatement(obj.description))
        strSQL = strSQL.Replace("{V21}", PreparedStatement(obj.remarks))
        strSQL = strSQL.Replace("{V22}", PreparedStatement(obj.info1))
        strSQL = strSQL.Replace("{V23}", PreparedStatement(obj.info2))
        strSQL = strSQL.Replace("{V24}", PreparedStatement(obj.entityTable))
        strSQL = strSQL.Replace("{V25}", PreparedStatement(obj.entityKey))
        strSQL = strSQL.Replace("{V26}", PreparedStatement(obj.entityName))
        strSQL = strSQL.Replace("{V27}", PreparedStatement(obj.dateStmt))
        strSQL = strSQL.Replace("{V28}", PreparedStatement(obj.dateItem))
        strSQL = strSQL.Replace("{V29}", PreparedStatement(obj.userIdPIC))
        strSQL = strSQL.Replace("{V30}", PreparedStatement(obj.state))
        strSQL = strSQL.Replace("{V31}", PreparedStatement(obj.status))

        Return strSQL

    End Function


    '***************************************************************************
    '* GetNextID
    '**************************************************************************/
    Public Function GetNextID() As Long

         Return DAAppTableCounter.GetNextPKID(PKID, TABLENAME, "POS", START_ID)

    End Function

End Class

