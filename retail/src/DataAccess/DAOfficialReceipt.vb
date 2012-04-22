Imports Utils.General

Public Class DAOfficialReceipt

    'Constants for Table field mappings
    Private Const CLASSNAME = "DAOfficialReceipt"

    Public Const PKID = "pkid"
    Public Const STMT_NO = "stmt_no"
    Public Const ENTITY_TABLE = "entity_table"
    Public Const ENTITY_KEY = "entity_key"
    Public Const ENTITY_NAME = "entity_name"
    Public Const INT_RESERVED1 = "int_reserved1"
    Public Const STR_RESERVED1 = "str_reserved1"
    Public Const CURRENCY = "currency"
    Public Const AMOUNT = "amount"
    Public Const CURRENCY2 = "currency2"
    Public Const AMOUNT2 = "amount2"
    Public Const PAYMENT_TIME = "payment_time"
    Public Const PAYMENT_METHOD = "payment_method"
    Public Const PAYMENT_REMARKS = "payment_remarks"
    Public Const CHEQUE_NUMBER = "cheque_number"
    Public Const STATE = "state"
    Public Const STATUS = "status"
    Public Const LASTUPDATE = "lastupdate"
    Public Const USERID_UPDATE = "userid_update"
    Public Const CB_CASH = "cb_cash"
    Public Const CB_CARD = "cb_card"
    Public Const CB_CHEQUE = "cb_cheque"
    Public Const CB_PD_CHEQUE = "cb_pd_cheque"
    Public Const CB_COUPON = "cb_coupon"
    Public Const CB_OTHER = "cb_other"
    Public Const AMOUNT_CASH = "amount_cash"
    Public Const AMOUNT_CARD = "amount_card"
    Public Const AMOUNT_CHEQUE = "amount_cheque"
    Public Const AMOUNT_PD_CHEQUE = "amount_pd_cheque"
    Public Const AMOUNT_COUPON = "amount_coupon"
    Public Const AMOUNT_OTHER = "amount_other"
    Public Const DATE_PD_CHEQUE = "date_pd_cheque"
    Public Const CHEQUE_NUMBER_PD = "cheque_number_pd"
    Public Const BRANCH = "branch"
    Public Const PC_CENTER = "pc_center"
    Public Const CARD_PCT_CHARGES = "card_pct_charges"
    Public Const CARD_CHARGES = "card_charges"
    Public Const CARD_TYPE = "card_type"
    Public Const CARD_CB = "card_cb"
    Public Const PDC_EXIST = "pdc_exist"
    Public Const PDC_CLEAR = "pdc_clear"
    Public Const GLCODE_CREDIT = "glcode_credit"
    Public Const OPEN_BALANCE = "open_balance"
    Public Const CARD_SURCHARGE = "card_surcharge"
    Public Const CHEQUE_CHARGES_AMOUNT = "cheque_charges_amount"
    Public Const REVERSE_PAYMENT = "reverse_payment"
    Public Const E_TFR_CASHBOOK = "e_tfr_cashbook"
    Public Const E_TFR_REFERENCE = "e_tfr_reference"
    Public Const E_TFR_BANK = "e_tfr_bank"
    Public Const E_TFR_RMKS = "e_tfr_rmks"
    Public Const E_TFR_DATE = "e_tfr_date"
    Public Const E_TFR_AMOUNT = "e_tfr_amount"
    Public Const E_TFR_CHARGES = "e_tfr_charges"
    Public Const CARD_BANK = "card_bank"
    Public Const CARD_NAME = "card_name"
    Public Const CARD_NUMBER = "card_number"
    Public Const CARD_SECURITY_NUM = "card_security_num"
    Public Const CARD_VALID_FROM = "card_valid_from"
    Public Const CARD_VALID_THRU = "card_valid_thru"
    Public Const PIC1 = "pic1"
    Public Const PIC2 = "pic2"
    Public Const PIC3 = "pic3"
    Public Const FORMAT = "format"
    Public Const CHEQUE_STATUS = "cheque_status"
    Public Const CHEQUE_BANK_IN_CB = "cheque_bank_in_cb"
    Public Const PD_CHEQUE_STATUS = "pd_cheque_status"
    Public Const PD_CHEQUE_BANK_IN_CB = "pd_cheque_bank_in_cb"
    Public Const CARD_APPROVAL_PARTY = "card_approval_party"
    Public Const CARD_APPROVAL_CODE = "card_approval_code"
    Public Const CARD_APPROVAL_TIME = "card_approval_time"
    Public Const STATUS_PAYMENT = "status_payment"
    Public Const CASH_DRAWER = "cash_drawer"
    Public Const REMARK_REVERSE = "remarks_reverse"
    Public Const CARD_ID = "card_id"
    Public Const CASH_NOTES_RECEIVED = "cash_notes_received"
    Public Const CASH_NOTES_CHANGE = "cash_notes_change"
    Public Const SYNCHRO_KEY = "synchro_key"
    Public Const POS_ID = "pos_id"

    Public Const STATUS_ACTIVE = "active"
    Public Const STATUS_INACTIVE = "inactive"
    Public Const STATUS_CANCELLED = "cancelled"
    Public Const STATUS_TOPUP = "topup"

    Public Const REMARKS_CUST_NAME = "cust_name"
    Public Const REMARKS_CUST_CONTACT = "cust_contact"
    Public Const REMARKS_CUST_IC = "cust_ic"
    Public Const TEMP_PAYMENT = "payment"

    Public Const TABLENAME = "acc_receipt_index"
    Public Const NO_OF_COLUMNS As Integer = 78
    Public Const APP_NAME = "ThickClient-DataAccess"
    Public Const START_ID = 1001

    '***************************************************************************
    '* Create
    '**************************************************************************/
    Public Function Create(ByVal obj As DAOfficialReceiptObject) As DAOfficialReceiptObject

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
    Public Sub Update(ByVal obj As DAOfficialReceiptObject)

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
            comm.ExecuteNonQueryTransaction(strSQL)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - Update - " & ex.Message)

        End Try

        WriteToLogFile(CLASSNAME & " - Leave Update")

    End Sub


    '***************************************************************************
    '* GetObject
    '**************************************************************************/
    Public Function GetObject(ByVal id As Integer) As DAOfficialReceiptObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DAOfficialReceiptObject = Nothing
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
    Public Function GetObject(ByVal row As DataRow) As DAOfficialReceiptObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DAOfficialReceiptObject

        Try
            obj = New DAOfficialReceiptObject
            obj.pkid = row(PKID)
            obj.stmtNumber = row(STMT_NO)
            obj.entityTable = row(ENTITY_TABLE)
            obj.entityKey = row(ENTITY_KEY)
            obj.entityName = row(ENTITY_NAME)
            obj.intReserved1 = row(INT_RESERVED1)
            obj.strReserved1 = row(STR_RESERVED1)
            obj.currency = row(CURRENCY)
            obj.amount = row(AMOUNT)
            obj.currency2 = row(CURRENCY2)
            obj.amount2 = row(AMOUNT2)
            obj.paymentTime = row(PAYMENT_TIME)
            obj.paymentMethod = row(PAYMENT_METHOD)
            obj.paymentRemarks = row(PAYMENT_REMARKS)
            obj.chequeNumber = row(CHEQUE_NUMBER)
            obj.state = row(STATE)
            obj.status = row(STATUS)
            obj.lastUpdate = row(LASTUPDATE)
            obj.userIdUpdate = row(USERID_UPDATE)
            obj.cbCash = row(CB_CASH)
            obj.cbCard = row(CB_CARD)
            obj.cbCheque = row(CB_CHEQUE)
            obj.cbPDCheque = row(CB_PD_CHEQUE)
            obj.cbCoupon = row(CB_COUPON)
            obj.cbOther = row(CB_OTHER)
            obj.amountCash = row(AMOUNT_CASH)
            obj.amountCard = row(AMOUNT_CARD)
            obj.amountCheque = row(AMOUNT_CHEQUE)
            obj.amountPDCheque = row(AMOUNT_PD_CHEQUE)
            obj.amountCoupon = row(AMOUNT_COUPON)
            obj.amountOther = row(AMOUNT_OTHER)
            obj.DatePDCheque = row(DATE_PD_CHEQUE)
            obj.chequeNumberPD = row(CHEQUE_NUMBER_PD)
            obj.branch = row(BRANCH)
            obj.pcCenter = row(PC_CENTER)
            obj.cardPctCharges = row(CARD_PCT_CHARGES)
            obj.cardCharges = row(CARD_CHARGES)
            obj.cardType = row(CARD_TYPE)
            obj.cardCB = row(CARD_CB)
            obj.pdcExist = row(PDC_EXIST)
            obj.pdcClear = row(PDC_CLEAR)
            obj.glCodeCredit = row(GLCODE_CREDIT)
            obj.openBalance = row(OPEN_BALANCE)
            obj.cardSurcharge = row(CARD_SURCHARGE)
            obj.chequeChargesAmount = row(CHEQUE_CHARGES_AMOUNT)
            obj.reversePayment = row(REVERSE_PAYMENT)
            obj.eTfrCashbook = row(E_TFR_CASHBOOK)
            obj.eTfrReference = row(E_TFR_REFERENCE)
            obj.eTfrBank = row(E_TFR_BANK)
            obj.eTfrRmks = row(E_TFR_RMKS)
            obj.eTfrDate = row(E_TFR_DATE)
            obj.eTfrAmount = row(E_TFR_AMOUNT)
            obj.eTfrCharges = row(E_TFR_CHARGES)
            obj.cardBank = row(CARD_BANK)
            obj.cardName = row(CARD_NAME)
            obj.cardNumber = row(CARD_NUMBER)
            obj.cardSecurityNum = row(CARD_SECURITY_NUM)
            obj.cardValidFrom = row(CARD_VALID_FROM)
            obj.cardValidThru = row(CARD_VALID_THRU)
            obj.pic1 = row(PIC1)
            obj.pic2 = row(PIC2)
            obj.pic3 = row(PIC3)
            obj.format = row(FORMAT)
            obj.chequeStatus = row(CHEQUE_STATUS)
            obj.chequeBankInCb = row(CHEQUE_BANK_IN_CB)
            obj.pdChequeStatus = row(PD_CHEQUE_STATUS)
            obj.pdChequeBankInCb = row(PD_CHEQUE_BANK_IN_CB)
            obj.cardApprovalParty = row(CARD_APPROVAL_PARTY)
            obj.cardApprovalCode = row(CARD_APPROVAL_CODE)
            obj.cardApprovalTime = row(CARD_APPROVAL_TIME)
            obj.statusPayment = row(STATUS_PAYMENT)
            obj.cashDrawer = row(CASH_DRAWER)
            obj.remarksReverse = row(REMARK_REVERSE)
            obj.cardId = row(CARD_ID)
            obj.cashNotesReceived = row(CASH_NOTES_RECEIVED)
            obj.cashNotesChange = row(CASH_NOTES_CHANGE)
            obj.synchroKey = row(SYNCHRO_KEY)
            obj.posId = row(POS_ID)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetObject - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetObject")

        Return obj

    End Function


    Public Function ReplaceStatement(ByVal strSQL As String, ByVal obj As DAOfficialReceiptObject) As String

        strSQL = strSQL.Replace("{T}", TABLENAME)

        strSQL = strSQL.Replace("{1}", PKID)
        strSQL = strSQL.Replace("{2}", STMT_NO)
        strSQL = strSQL.Replace("{3}", ENTITY_TABLE)
        strSQL = strSQL.Replace("{4}", ENTITY_KEY)
        strSQL = strSQL.Replace("{5}", ENTITY_NAME)
        strSQL = strSQL.Replace("{6}", INT_RESERVED1)
        strSQL = strSQL.Replace("{7}", STR_RESERVED1)
        strSQL = strSQL.Replace("{8}", CURRENCY)
        strSQL = strSQL.Replace("{9}", AMOUNT)
        strSQL = strSQL.Replace("{10}", CURRENCY2)
        strSQL = strSQL.Replace("{11}", AMOUNT2)
        strSQL = strSQL.Replace("{12}", PAYMENT_TIME)
        strSQL = strSQL.Replace("{13}", PAYMENT_METHOD)
        strSQL = strSQL.Replace("{14}", PAYMENT_REMARKS)
        strSQL = strSQL.Replace("{15}", CHEQUE_NUMBER)
        strSQL = strSQL.Replace("{16}", STATE)
        strSQL = strSQL.Replace("{17}", STATUS)
        strSQL = strSQL.Replace("{18}", LASTUPDATE)
        strSQL = strSQL.Replace("{19}", USERID_UPDATE)
        strSQL = strSQL.Replace("{20}", CB_CASH)
        strSQL = strSQL.Replace("{21}", CB_CARD)
        strSQL = strSQL.Replace("{22}", CB_CHEQUE)
        strSQL = strSQL.Replace("{23}", CB_PD_CHEQUE)
        strSQL = strSQL.Replace("{24}", CB_COUPON)
        strSQL = strSQL.Replace("{25}", CB_OTHER)
        strSQL = strSQL.Replace("{26}", AMOUNT_CASH)
        strSQL = strSQL.Replace("{27}", AMOUNT_CARD)
        strSQL = strSQL.Replace("{28}", AMOUNT_CHEQUE)
        strSQL = strSQL.Replace("{29}", AMOUNT_PD_CHEQUE)
        strSQL = strSQL.Replace("{30}", AMOUNT_COUPON)
        strSQL = strSQL.Replace("{31}", AMOUNT_OTHER)
        strSQL = strSQL.Replace("{32}", DATE_PD_CHEQUE)
        strSQL = strSQL.Replace("{33}", CHEQUE_NUMBER_PD)
        strSQL = strSQL.Replace("{34}", BRANCH)
        strSQL = strSQL.Replace("{35}", PC_CENTER)
        strSQL = strSQL.Replace("{36}", CARD_PCT_CHARGES)
        strSQL = strSQL.Replace("{37}", CARD_CHARGES)
        strSQL = strSQL.Replace("{38}", CARD_TYPE)
        strSQL = strSQL.Replace("{39}", CARD_CB)
        strSQL = strSQL.Replace("{40}", PDC_EXIST)
        strSQL = strSQL.Replace("{41}", PDC_CLEAR)
        strSQL = strSQL.Replace("{42}", GLCODE_CREDIT)
        strSQL = strSQL.Replace("{43}", OPEN_BALANCE)
        strSQL = strSQL.Replace("{44}", CARD_SURCHARGE)
        strSQL = strSQL.Replace("{45}", CHEQUE_CHARGES_AMOUNT)
        strSQL = strSQL.Replace("{46}", REVERSE_PAYMENT)
        strSQL = strSQL.Replace("{47}", E_TFR_CASHBOOK)
        strSQL = strSQL.Replace("{48}", E_TFR_REFERENCE)
        strSQL = strSQL.Replace("{49}", E_TFR_BANK)
        strSQL = strSQL.Replace("{50}", E_TFR_RMKS)
        strSQL = strSQL.Replace("{51}", E_TFR_DATE)
        strSQL = strSQL.Replace("{52}", E_TFR_AMOUNT)
        strSQL = strSQL.Replace("{53}", E_TFR_CHARGES)
        strSQL = strSQL.Replace("{54}", CARD_BANK)
        strSQL = strSQL.Replace("{55}", CARD_NAME)
        strSQL = strSQL.Replace("{56}", CARD_NUMBER)
        strSQL = strSQL.Replace("{57}", CARD_SECURITY_NUM)
        strSQL = strSQL.Replace("{58}", CARD_VALID_FROM)
        strSQL = strSQL.Replace("{59}", CARD_VALID_THRU)
        strSQL = strSQL.Replace("{60}", PIC1)
        strSQL = strSQL.Replace("{61}", PIC2)
        strSQL = strSQL.Replace("{62}", PIC3)
        strSQL = strSQL.Replace("{63}", FORMAT)
        strSQL = strSQL.Replace("{64}", CHEQUE_STATUS)
        strSQL = strSQL.Replace("{65}", CHEQUE_BANK_IN_CB)
        strSQL = strSQL.Replace("{66}", PD_CHEQUE_STATUS)
        strSQL = strSQL.Replace("{67}", PD_CHEQUE_BANK_IN_CB)
        strSQL = strSQL.Replace("{68}", CARD_APPROVAL_PARTY)
        strSQL = strSQL.Replace("{69}", CARD_APPROVAL_CODE)
        strSQL = strSQL.Replace("{70}", CARD_APPROVAL_TIME)
        strSQL = strSQL.Replace("{71}", STATUS_PAYMENT)
        strSQL = strSQL.Replace("{72}", CASH_DRAWER)
        strSQL = strSQL.Replace("{73}", REMARK_REVERSE)
        strSQL = strSQL.Replace("{74}", CARD_ID)
        strSQL = strSQL.Replace("{75}", CASH_NOTES_RECEIVED)
        strSQL = strSQL.Replace("{76}", CASH_NOTES_CHANGE)
        strSQL = strSQL.Replace("{77}", SYNCHRO_KEY)
        strSQL = strSQL.Replace("{78}", POS_ID)

        strSQL = strSQL.Replace("{V1}", PreparedStatement(obj.pkid))
        strSQL = strSQL.Replace("{V2}", PreparedStatement(obj.stmtNumber))
        strSQL = strSQL.Replace("{V3}", PreparedStatement(obj.entityTable))
        strSQL = strSQL.Replace("{V4}", PreparedStatement(obj.entityKey))
        strSQL = strSQL.Replace("{V5}", PreparedStatement(obj.entityName))
        strSQL = strSQL.Replace("{V6}", PreparedStatement(obj.intReserved1))
        strSQL = strSQL.Replace("{V7}", PreparedStatement(obj.strReserved1))
        strSQL = strSQL.Replace("{V8}", PreparedStatement(obj.currency))
        strSQL = strSQL.Replace("{V9}", PreparedStatement(obj.amount))
        strSQL = strSQL.Replace("{V10}", PreparedStatement(obj.currency2))
        strSQL = strSQL.Replace("{V11}", PreparedStatement(obj.amount2))
        strSQL = strSQL.Replace("{V12}", PreparedStatement(obj.paymentTime))
        strSQL = strSQL.Replace("{V13}", PreparedStatement(obj.paymentMethod))
        strSQL = strSQL.Replace("{V14}", PreparedStatement(obj.paymentRemarks))
        strSQL = strSQL.Replace("{V15}", PreparedStatement(obj.chequeNumber))
        strSQL = strSQL.Replace("{V16}", PreparedStatement(obj.state))
        strSQL = strSQL.Replace("{V17}", PreparedStatement(obj.status))
        strSQL = strSQL.Replace("{V18}", PreparedStatement(obj.lastUpdate))
        strSQL = strSQL.Replace("{V19}", PreparedStatement(obj.userIdUpdate))
        strSQL = strSQL.Replace("{V20}", PreparedStatement(obj.cbCash))
        strSQL = strSQL.Replace("{V21}", PreparedStatement(obj.cbCard))
        strSQL = strSQL.Replace("{V22}", PreparedStatement(obj.cbCheque))
        strSQL = strSQL.Replace("{V23}", PreparedStatement(obj.cbPDCheque))
        strSQL = strSQL.Replace("{V24}", PreparedStatement(obj.cbCoupon))
        strSQL = strSQL.Replace("{V25}", PreparedStatement(obj.cbOther))
        strSQL = strSQL.Replace("{V26}", PreparedStatement(obj.amountCash))
        strSQL = strSQL.Replace("{V27}", PreparedStatement(obj.amountCard))
        strSQL = strSQL.Replace("{V28}", PreparedStatement(obj.amountCheque))
        strSQL = strSQL.Replace("{V29}", PreparedStatement(obj.amountPDCheque))
        strSQL = strSQL.Replace("{V30}", PreparedStatement(obj.amountCoupon))
        strSQL = strSQL.Replace("{V31}", PreparedStatement(obj.amountOther))
        strSQL = strSQL.Replace("{V32}", PreparedStatement(obj.DatePDCheque))
        strSQL = strSQL.Replace("{V33}", PreparedStatement(obj.chequeNumberPD))
        strSQL = strSQL.Replace("{V34}", PreparedStatement(obj.branch))
        strSQL = strSQL.Replace("{V35}", PreparedStatement(obj.pcCenter))
        strSQL = strSQL.Replace("{V36}", PreparedStatement(obj.cardPctCharges))
        strSQL = strSQL.Replace("{V37}", PreparedStatement(obj.cardCharges))
        strSQL = strSQL.Replace("{V38}", PreparedStatement(obj.cardType))
        strSQL = strSQL.Replace("{V39}", PreparedStatement(obj.cardCB))
        strSQL = strSQL.Replace("{V40}", PreparedStatement(obj.pdcExist))
        strSQL = strSQL.Replace("{V41}", PreparedStatement(obj.pdcClear))
        strSQL = strSQL.Replace("{V42}", PreparedStatement(obj.glCodeCredit))
        strSQL = strSQL.Replace("{V43}", PreparedStatement(obj.openBalance))
        strSQL = strSQL.Replace("{V44}", PreparedStatement(obj.cardSurcharge))
        strSQL = strSQL.Replace("{V45}", PreparedStatement(obj.chequeChargesAmount))
        strSQL = strSQL.Replace("{V46}", PreparedStatement(obj.reversePayment))
        strSQL = strSQL.Replace("{V47}", PreparedStatement(obj.eTfrCashbook))
        strSQL = strSQL.Replace("{V48}", PreparedStatement(obj.eTfrReference))
        strSQL = strSQL.Replace("{V49}", PreparedStatement(obj.eTfrBank))
        strSQL = strSQL.Replace("{V50}", PreparedStatement(obj.eTfrRmks))
        strSQL = strSQL.Replace("{V51}", PreparedStatement(obj.eTfrDate))
        strSQL = strSQL.Replace("{V52}", PreparedStatement(obj.eTfrAmount))
        strSQL = strSQL.Replace("{V53}", PreparedStatement(obj.eTfrCharges))
        strSQL = strSQL.Replace("{V54}", PreparedStatement(obj.cardBank))
        strSQL = strSQL.Replace("{V55}", PreparedStatement(obj.cardName))
        strSQL = strSQL.Replace("{V56}", PreparedStatement(obj.cardNumber))
        strSQL = strSQL.Replace("{V57}", PreparedStatement(obj.cardSecurityNum))
        strSQL = strSQL.Replace("{V58}", PreparedStatement(obj.cardValidFrom))
        strSQL = strSQL.Replace("{V59}", PreparedStatement(obj.cardValidThru))
        strSQL = strSQL.Replace("{V60}", PreparedStatement(obj.pic1))
        strSQL = strSQL.Replace("{V61}", PreparedStatement(obj.pic2))
        strSQL = strSQL.Replace("{V62}", PreparedStatement(obj.pic3))
        strSQL = strSQL.Replace("{V63}", PreparedStatement(obj.format))
        strSQL = strSQL.Replace("{V64}", PreparedStatement(obj.chequeStatus))
        strSQL = strSQL.Replace("{V65}", PreparedStatement(obj.chequeBankInCb))
        strSQL = strSQL.Replace("{V66}", PreparedStatement(obj.pdChequeStatus))
        strSQL = strSQL.Replace("{V67}", PreparedStatement(obj.pdChequeBankInCb))
        strSQL = strSQL.Replace("{V68}", PreparedStatement(obj.cardApprovalParty))
        strSQL = strSQL.Replace("{V69}", PreparedStatement(obj.cardApprovalCode))
        strSQL = strSQL.Replace("{V70}", PreparedStatement(obj.cardApprovalTime))
        strSQL = strSQL.Replace("{V71}", PreparedStatement(obj.statusPayment))
        strSQL = strSQL.Replace("{V72}", PreparedStatement(obj.cashDrawer))
        strSQL = strSQL.Replace("{V73}", PreparedStatement(obj.remarksReverse))
        strSQL = strSQL.Replace("{V74}", PreparedStatement(obj.cardId))
        strSQL = strSQL.Replace("{V75}", PreparedStatement(obj.cashNotesReceived))
        strSQL = strSQL.Replace("{V76}", PreparedStatement(obj.cashNotesChange))
        strSQL = strSQL.Replace("{V77}", PreparedStatement(obj.synchroKey))
        strSQL = strSQL.Replace("{V78}", PreparedStatement(obj.posId))

        Return strSQL

    End Function


    '***************************************************************************
    '* GetNextID
    '**************************************************************************/
    Public Function GetNextID() As Long

        Return DAAppTableCounter.GetNextPKID(PKID, TABLENAME, "POS", START_ID)

    End Function


    '***************************************************************************
    '* GetDataset
    '**************************************************************************/
    Public Function GetDataset(ByVal whereClause As String) As DataSet

        WriteToLogFile(CLASSNAME & " - In GetDataset")

        Dim comm As New Commands
        Dim strSQL As String

        strSQL = "SELECT * FROM {T} WHERE {1} ORDER BY {2}"

        strSQL = strSQL.Replace("{T}", TABLENAME)
        strSQL = strSQL.Replace("{1}", whereClause)
        strSQL = strSQL.Replace("{2}", PKID)

        Try
            WriteToLogFile(strSQL)
            Return comm.ExecuteQuery(strSQL, Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetDataset - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetDataset")

    End Function

End Class

