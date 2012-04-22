Imports Utils.General

Public Class DAPaymentVoucher

    'Constants for Table field mappings
    Private Const CLASSNAME = "DAPaymentVoucher"

    Public Const PKID = "pkid"
    Public Const STMT_NO = "stmt_no"
    Public Const UUID = "uuid"
    Public Const PC_CENTER = "pc_center"
    Public Const BRANCH = "branch"
    Public Const CURRENCY = "currency"
    Public Const AMOUNT_TOTAL = "amount_total"
    Public Const XRATE = "xrate"
    Public Const CURRENCY2 = "currency2"
    Public Const AMOUNT_TOTAL2 = "amount_total2"
    Public Const GLCODE_DEBIT = "glcode_debit"
    Public Const GLCODE_CREDIT = "glcode_credit"
    Public Const CASHBOOK_CASH = "cashbook_cash"
    Public Const CASHBOOK_CARD = "cashbook_card"
    Public Const CASHBOOK_CHEQUE = "cashbook_cheque"
    Public Const CASHBOOK_PD_CHEQUE = "cashbook_pd_cheque"
    Public Const CASHBOOK_COUPON = "cashbook_coupon"
    Public Const CASHBOOK_OTHER = "cashbook_other"
    Public Const AMOUNT_CASH = "amount_cash"
    Public Const AMOUNT_CARD = "amount_card"
    Public Const AMOUNT_CHEQUE = "amount_cheque"
    Public Const AMOUNT_PD_CHEQUE = "amount_pd_cheque"
    Public Const AMOUNT_COUPON = "amount_coupon"
    Public Const AMOUNT_OTHER = "amount_other"
    Public Const PAY_TO = "pay_to"
    Public Const REFERENCE_NO = "reference_no"
    Public Const CHEQUE_NO = "cheque_no"
    Public Const DESCRIPTION = "description"
    Public Const REMARKS = "remarks"
    Public Const INFO1 = "info1"
    Public Const INFO2 = "info2"
    Public Const DATE_STMT = "date_stmt"
    Public Const DATE_CREATED = "date_created"
    Public Const DATE_APPROVED = "date_approved"
    Public Const DATE_VERIFIED = "date_verified"
    Public Const DATE_UPDATE = "date_update"
    Public Const USERID_CREATE = "userid_create"
    Public Const USERID_PIC = "userid_pic"
    Public Const USERID_APPROVE = "userid_approve"
    Public Const USERID_VERIFIED = "userid_verified"
    Public Const USERID_UPDATE = "userid_update"
    Public Const RESERVED1 = "reserved1"
    Public Const RESERVED2 = "reserved2"
    Public Const STATE = "state"
    Public Const STATUS = "status"
    Public Const INTERNAL_STATUS = "internal_status"
    Public Const REMARK_REVERSE = "remarks_reverse"
    Public Const OPEN_BALANCE = "open_balance"
    Public Const OPEN_BALANCE2 = "open_balance2"
    Public Const SYNCHRO_KEY = "synchro_key"

    Public Const STATUS_ACTIVE = "act"
    Public Const STATUS_DELETED = "del"
    Public Const STATE_CREATED = "cre"
    Public Const STATE_REVERSED = "rvd"
    Public Const STATE_KNOCKED_OFF = "knof"


    Public Const TABLENAME = "acc_payment_voucher_index"
    Public Const NO_OF_COLUMNS As Integer = 50
    Public Const APP_NAME = "ThickClient-DataAccess"
    Public Const START_ID = 1001

    '***************************************************************************
    '* Create
    '**************************************************************************/
    Public Function Create(ByVal obj As DAPaymentVoucherObject) As DAPaymentVoucherObject

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
    Public Sub Update(ByVal obj As DAPaymentVoucherObject)

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
    Public Function GetObject(ByVal id As Integer) As DAPaymentVoucherObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DAPaymentVoucherObject = Nothing
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
    Public Function GetObject(ByVal row As DataRow) As DAPaymentVoucherObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DAPaymentVoucherObject

        Try
            obj = New DAPaymentVoucherObject
            obj.pkid = row(PKID)
            obj.stmtNo = row(STMT_NO)
            obj.uuid = row(UUID)
            obj.pcCenter = row(PC_CENTER)
            obj.branch = row(BRANCH)
            obj.currency = row(CURRENCY)
            obj.amountTotal = row(AMOUNT_TOTAL)
            obj.xrate = row(XRATE)
            obj.currency2 = row(CURRENCY2)
            obj.amountTotal2 = row(AMOUNT_TOTAL2)
            obj.glCodeDebit = row(GLCODE_DEBIT)
            obj.glCodeCredit = row(GLCODE_CREDIT)
            obj.cashbookCash = row(CASHBOOK_CASH)
            obj.cashbookCard = row(CASHBOOK_CARD)
            obj.cashbookCheque = row(CASHBOOK_CHEQUE)
            obj.cashbookPDCheque = row(CASHBOOK_PD_CHEQUE)
            obj.cashbookCoupon = row(CASHBOOK_COUPON)
            obj.cashbookOther = row(CASHBOOK_OTHER)
            obj.amountCash = row(AMOUNT_CASH)
            obj.amountCard = row(AMOUNT_CARD)
            obj.amountCheque = row(AMOUNT_CHEQUE)
            obj.amountPDCheque = row(AMOUNT_PD_CHEQUE)
            obj.amountCoupon = row(AMOUNT_COUPON)
            obj.amountOther = row(AMOUNT_OTHER)
            obj.payTo = row(PAY_TO)
            obj.referenceNo = row(REFERENCE_NO)
            obj.chequeNo = row(CHEQUE_NO)
            obj.description = row(DESCRIPTION)
            obj.remarks = row(REMARKS)
            obj.info1 = row(INFO1)
            obj.info2 = row(INFO2)
            obj.dateStmt = row(DATE_STMT)
            obj.dateCreated = row(DATE_CREATED)
            obj.dateApproved = row(DATE_APPROVED)
            obj.dateVerified = row(DATE_VERIFIED)
            obj.dateUpdate = row(DATE_UPDATE)
            obj.userIdCreate = row(USERID_CREATE)
            obj.userIdPIC = row(USERID_PIC)
            obj.userIdApprove = row(USERID_APPROVE)
            obj.userIdVerified = row(USERID_VERIFIED)
            obj.userIdUpdate = row(USERID_UPDATE)
            obj.reserved1 = row(RESERVED1)
            obj.reserved2 = row(RESERVED2)
            obj.state = row(STATE)
            obj.status = row(STATUS)
            obj.internalStatus = row(INTERNAL_STATUS)
            obj.remarksReverse = row(REMARK_REVERSE)
            obj.openBalance = row(OPEN_BALANCE)
            obj.openBalance2 = row(OPEN_BALANCE2)
            obj.synchroKey = row(SYNCHRO_KEY)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetObject - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetObject")

        Return obj

    End Function


    Public Function ReplaceStatement(ByVal strSQL As String, ByVal obj As DAPaymentVoucherObject) As String

        strSQL = strSQL.Replace("{T}", TABLENAME)

        strSQL = strSQL.Replace("{1}", PKID)
        strSQL = strSQL.Replace("{2}", STMT_NO)
        strSQL = strSQL.Replace("{3}", UUID)
        strSQL = strSQL.Replace("{4}", PC_CENTER)
        strSQL = strSQL.Replace("{5}", BRANCH)
        strSQL = strSQL.Replace("{6}", CURRENCY)
        strSQL = strSQL.Replace("{7}", AMOUNT_TOTAL)
        strSQL = strSQL.Replace("{8}", XRATE)
        strSQL = strSQL.Replace("{9}", CURRENCY2)
        strSQL = strSQL.Replace("{10}", AMOUNT_TOTAL2)
        strSQL = strSQL.Replace("{11}", GLCODE_DEBIT)
        strSQL = strSQL.Replace("{12}", GLCODE_CREDIT)
        strSQL = strSQL.Replace("{13}", CASHBOOK_CASH)
        strSQL = strSQL.Replace("{14}", CASHBOOK_CARD)
        strSQL = strSQL.Replace("{15}", CASHBOOK_CHEQUE)
        strSQL = strSQL.Replace("{16}", CASHBOOK_PD_CHEQUE)
        strSQL = strSQL.Replace("{17}", CASHBOOK_COUPON)
        strSQL = strSQL.Replace("{18}", CASHBOOK_OTHER)
        strSQL = strSQL.Replace("{19}", AMOUNT_CASH)
        strSQL = strSQL.Replace("{20}", AMOUNT_CARD)
        strSQL = strSQL.Replace("{21}", AMOUNT_CHEQUE)
        strSQL = strSQL.Replace("{22}", AMOUNT_PD_CHEQUE)
        strSQL = strSQL.Replace("{23}", AMOUNT_COUPON)
        strSQL = strSQL.Replace("{24}", AMOUNT_OTHER)
        strSQL = strSQL.Replace("{25}", PAY_TO)
        strSQL = strSQL.Replace("{26}", REFERENCE_NO)
        strSQL = strSQL.Replace("{27}", CHEQUE_NO)
        strSQL = strSQL.Replace("{28}", DESCRIPTION)
        strSQL = strSQL.Replace("{29}", REMARKS)
        strSQL = strSQL.Replace("{30}", INFO1)
        strSQL = strSQL.Replace("{31}", INFO2)
        strSQL = strSQL.Replace("{32}", DATE_STMT)
        strSQL = strSQL.Replace("{33}", DATE_CREATED)
        strSQL = strSQL.Replace("{34}", DATE_APPROVED)
        strSQL = strSQL.Replace("{35}", DATE_VERIFIED)
        strSQL = strSQL.Replace("{36}", DATE_UPDATE)
        strSQL = strSQL.Replace("{37}", USERID_CREATE)
        strSQL = strSQL.Replace("{38}", USERID_PIC)
        strSQL = strSQL.Replace("{39}", USERID_APPROVE)
        strSQL = strSQL.Replace("{40}", USERID_VERIFIED)
        strSQL = strSQL.Replace("{41}", USERID_UPDATE)
        strSQL = strSQL.Replace("{42}", RESERVED1)
        strSQL = strSQL.Replace("{43}", RESERVED2)
        strSQL = strSQL.Replace("{44}", STATE)
        strSQL = strSQL.Replace("{45}", STATUS)
        strSQL = strSQL.Replace("{46}", INTERNAL_STATUS)
        strSQL = strSQL.Replace("{47}", REMARK_REVERSE)
        strSQL = strSQL.Replace("{48}", OPEN_BALANCE)
        strSQL = strSQL.Replace("{49}", OPEN_BALANCE2)
        strSQL = strSQL.Replace("{50}", SYNCHRO_KEY)

        strSQL = strSQL.Replace("{V1}", PreparedStatement(obj.pkid))
        strSQL = strSQL.Replace("{V2}", PreparedStatement(obj.stmtNo))
        strSQL = strSQL.Replace("{V3}", PreparedStatement(obj.uuid))
        strSQL = strSQL.Replace("{V4}", PreparedStatement(obj.pcCenter))
        strSQL = strSQL.Replace("{V5}", PreparedStatement(obj.branch))
        strSQL = strSQL.Replace("{V6}", PreparedStatement(obj.currency))
        strSQL = strSQL.Replace("{V7}", PreparedStatement(obj.amountTotal))
        strSQL = strSQL.Replace("{V8}", PreparedStatement(obj.xrate))
        strSQL = strSQL.Replace("{V9}", PreparedStatement(obj.currency2))
        strSQL = strSQL.Replace("{V10}", PreparedStatement(obj.amountTotal2))
        strSQL = strSQL.Replace("{V11}", PreparedStatement(obj.glCodeDebit))
        strSQL = strSQL.Replace("{V12}", PreparedStatement(obj.glCodeCredit))
        strSQL = strSQL.Replace("{V13}", PreparedStatement(obj.cashbookCash))
        strSQL = strSQL.Replace("{V14}", PreparedStatement(obj.cashbookCard))
        strSQL = strSQL.Replace("{V15}", PreparedStatement(obj.cashbookCheque))
        strSQL = strSQL.Replace("{V16}", PreparedStatement(obj.cashbookPDCheque))
        strSQL = strSQL.Replace("{V17}", PreparedStatement(obj.cashbookCoupon))
        strSQL = strSQL.Replace("{V18}", PreparedStatement(obj.cashbookOther))
        strSQL = strSQL.Replace("{V19}", PreparedStatement(obj.amountCash))
        strSQL = strSQL.Replace("{V20}", PreparedStatement(obj.amountCard))
        strSQL = strSQL.Replace("{V21}", PreparedStatement(obj.amountCheque))
        strSQL = strSQL.Replace("{V22}", PreparedStatement(obj.amountPDCheque))
        strSQL = strSQL.Replace("{V23}", PreparedStatement(obj.amountCoupon))
        strSQL = strSQL.Replace("{V24}", PreparedStatement(obj.amountOther))
        strSQL = strSQL.Replace("{V25}", PreparedStatement(obj.payTo))
        strSQL = strSQL.Replace("{V26}", PreparedStatement(obj.referenceNo))
        strSQL = strSQL.Replace("{V27}", PreparedStatement(obj.chequeNo))
        strSQL = strSQL.Replace("{V28}", PreparedStatement(obj.description))
        strSQL = strSQL.Replace("{V29}", PreparedStatement(obj.remarks))
        strSQL = strSQL.Replace("{V30}", PreparedStatement(obj.info1))
        strSQL = strSQL.Replace("{V31}", PreparedStatement(obj.info2))
        strSQL = strSQL.Replace("{V32}", PreparedStatement(obj.dateStmt))
        strSQL = strSQL.Replace("{V33}", PreparedStatement(obj.dateCreated))
        strSQL = strSQL.Replace("{V34}", PreparedStatement(obj.dateApproved))
        strSQL = strSQL.Replace("{V35}", PreparedStatement(obj.dateVerified))
        strSQL = strSQL.Replace("{V36}", PreparedStatement(obj.dateUpdate))
        strSQL = strSQL.Replace("{V37}", PreparedStatement(obj.userIdCreate))
        strSQL = strSQL.Replace("{V38}", PreparedStatement(obj.userIdPIC))
        strSQL = strSQL.Replace("{V39}", PreparedStatement(obj.userIdApprove))
        strSQL = strSQL.Replace("{V40}", PreparedStatement(obj.userIdVerified))
        strSQL = strSQL.Replace("{V41}", PreparedStatement(obj.userIdUpdate))
        strSQL = strSQL.Replace("{V42}", PreparedStatement(obj.reserved1))
        strSQL = strSQL.Replace("{V43}", PreparedStatement(obj.reserved2))
        strSQL = strSQL.Replace("{V44}", PreparedStatement(obj.state))
        strSQL = strSQL.Replace("{V45}", PreparedStatement(obj.status))
        strSQL = strSQL.Replace("{V46}", PreparedStatement(obj.internalStatus))
        strSQL = strSQL.Replace("{V47}", PreparedStatement(obj.remarksReverse))
        strSQL = strSQL.Replace("{V48}", PreparedStatement(obj.openBalance))
        strSQL = strSQL.Replace("{V49}", PreparedStatement(obj.openBalance2))
        strSQL = strSQL.Replace("{V50}", PreparedStatement(obj.synchroKey))

        Return strSQL

    End Function


    '***************************************************************************
    '* GetNextID
    '**************************************************************************/
    Public Function GetNextID() As Long

        Return DAAppTableCounter.GetNextPKID(PKID, TABLENAME, "POS", START_ID)

    End Function

End Class

