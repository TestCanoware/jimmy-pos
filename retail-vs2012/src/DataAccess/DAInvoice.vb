Imports Utils.General

Public Class DAInvoice

    'Constants for Table field mappings
    Private Const CLASSNAME = "DAInvoice"

    Public Const PKID = "pkid"
    Public Const STMT_NO = "stmt_no"
    Public Const SALES_TXN_ID = "sales_txn_id"
    Public Const PAYMENT_TERMS_ID = "payment_terms_id"
    Public Const TIMEISSUED = "time_issued"
    Public Const CURRENCY = "currency"
    Public Const TOTAL_AMT = "total_amt"
    Public Const OUTSTANDING_AMT = "outstanding_amt"
    Public Const OUTSTANDING_BF_PDC = "outstanding_bf_pdc"
    Public Const REMARKS = "remarks"
    Public Const STATE = "state"
    Public Const STATUS = "status"
    Public Const LASTUPDATE = "lastupdate"
    Public Const USERID_EDIT = "userid_edit"
    Public Const ENTITY_TABLE = "entity_table"
    Public Const ENTITY_KEY = "entity_key"
    Public Const ENTITY_NAME = "entity_name"
    Public Const ENTITY_CODE = "entity_code"
    Public Const IDENTITY_NUMBER = "identity_number"
    Public Const ENTITY_CONTACT_PERSON = "entity_contact_person"
    Public Const FOREIGN_TABLE = "foreign_table"
    Public Const FOREIGN_KEY = "foreign_key"
    Public Const FOREIGN_TEXT = "foreign_text"
    Public Const CUST_SVCCTR_ID = "cust_svcctr_id"
    Public Const LOCATION_ID = "location_id"
    Public Const PC_CENTER = "pc_center"
    Public Const TXNTYPE = "txntype"
    Public Const STMT_TYPE = "stmt_type"
    Public Const REFERENCE_NO = "reference_no"
    Public Const DESCRIPTION = "description"
    Public Const WORK_ORDER = "work_order"
    Public Const DELIVERY_ORDER = "delivery_order"
    Public Const RECEIPT_ID = "receipt_id"
    Public Const DISPLAY_FORMAT = "display_format"
    Public Const DOC_TYPE = "doc_type"
    Public Const BILLING_HANDPHONE = "billing_handphone"
    Public Const BILLING_PHONE1 = "billing_phone1"
    Public Const BILLING_PHONE2 = "billing_phone2"
    Public Const BILLING_FAX = "billing_fax"
    Public Const BILLING_EMAIL = "billing_email"
    Public Const BILLING_COMPANY_NAME = "billing_company_name"
    Public Const BILLING_ADD1 = "billing_add1"
    Public Const BILLING_ADD2 = "billing_add2"
    Public Const BILLING_ADD3 = "billing_add3"
    Public Const BILLING_CITY = "billing_city"
    Public Const BILLING_ZIP = "billing_zip"
    Public Const BILLING_STATE = "billing_state"
    Public Const BILLING_COUNTRY = "billing_country"
    Public Const RECEIVER_NAME = "receiver_name"
    Public Const RECEIVER_HANDPHONE = "receiver_handphone"
    Public Const RECEIVER_PHONE1 = "receiver_phone1"
    Public Const RECEIVER_PHONE2 = "receiver_phone2"
    Public Const RECEIVER_FAX = "receiver_fax"
    Public Const RECEIVER_EMAIL = "receiver_email"
    Public Const RECEIVER_COMPANY_NAME = "receiver_company_name"
    Public Const RECEIVER_ADD1 = "receiver_add1"
    Public Const RECEIVER_ADD2 = "receiver_add2"
    Public Const RECEIVER_ADD3 = "receiver_add3"
    Public Const RECEIVER_CITY = "receiver_city"
    Public Const RECEIVER_ZIP = "receiver_zip"
    Public Const RECEIVER_STATE = "receiver_state"
    Public Const RECEIVER_COUNTRY = "receiver_country"
    Public Const TERMS1_OPTION = "terms1_option"
    Public Const TERMS1_DATE = "terms1_date"
    Public Const TERMS1_DISC_PCT = "terms1_disc_pct"
    Public Const TERMS1_DISC_AMT = "terms1_disc_amt"
    Public Const TERMS2_OPTION = "terms2_option"
    Public Const TERMS2_DATE = "terms2_date"
    Public Const TERMS2_DISC_PCT = "terms2_disc_pct"
    Public Const TERMS2_DISC_AMT = "terms2_disc_amt"
    Public Const REBATE1_OPTION = "rebate1_option"
    Public Const REBATE1_DATE = "rebate1_date"
    Public Const REBATE1_GAIN = "rebate1_gain"
    Public Const REBATE1_CONSUME = "rebate1_consume"
    Public Const REBATE2_OPTION = "rebate2_option"
    Public Const REBATE2_DATE = "rebate2_date"
    Public Const REBATE2_GAIN = "rebate2_gain"
    Public Const REBATE2_CONSUME = "rebate2_consume"
    Public Const CODE_DEPT = "code_dept"
    Public Const CODE_PROJECT = "code_project"
    Public Const CODE_SUPPLIER = "code_supplier"
    Public Const SALES_ID = "sales_id"
    Public Const TRACKING_NO = "tracking_no"
    Public Const GUID = "guid"
    Public Const TAX_AMOUNT = "tax_amount"
    Public Const TAX_TYPE = "tax_type"
    Public Const SUBTYPE_1 = "subtype1"
    Public Const SUBTYPE_2 = "subtype2"
    Public Const SUBTYPE_3 = "subtype3"
    Public Const CLAIM_AMOUNT = "claim_amount"
    Public Const TIME_ACCIDENT = "time_accident"
    Public Const POLICY_NUMBER = "policy_number"
    Public Const LOYALTY_CARD_STATUS = "loyalty_card_status"
    Public Const LOYALTY_CARD_PKID = "loyalty_card_pkid"
    Public Const LOYALTY_PROCESS_STATUS = "loyalty_process_status"
    Public Const LOYALTY_PROCESS_REVERSAL_STATUS = "loyalty_process_reversal_status"
    Public Const LOYALTY_JTXN_STATUS = "loyalty_jtxn_status"
    Public Const LOYALTY_JTXN_REVERSAL_STATUS = "loyalty_jtxn_reversal_status"
    Public Const LOYALTY_POINTS_AWARDED = "loyalty_points_awarded"
    Public Const LOYALTY_POINTS_REDEEMED = "loyalty_points_redeemed"
    Public Const CURRENCY2 = "currency2"
    Public Const TOTAL_AMT2 = "total_amt2"
    Public Const OUTSTANDING_AMT2 = "outstanding_amt2"
    Public Const TAX_AMOUNT2 = "tax_amount2"
    Public Const XRATE = "xrate"
    Public Const INCOTERMS = "incoterms"
    Public Const PERMIT_NO = "permit_no"
    Public Const PERMIT_DOC1 = "permit_doc1"
    Public Const PERMIT_DOC2 = "permit_doc2"
    Public Const PERMIT_DOC3 = "permit_doc3"
    Public Const TXN_DOC1 = "txn_doc1"
    Public Const TXN_DOC2 = "txn_doc2"
    Public Const TXN_DOC3 = "txn_doc3"
    Public Const TRANSPORT_DOC1 = "transport_doc1"
    Public Const TRANSPORT_DOC2 = "transport_doc2"
    Public Const TRANSPORT_DOC3 = "transport_doc3"
    Public Const TRANSPORT_DATE = "transport_date"
    Public Const TRADERS_REMARKS = "traders_remarks"
    Public Const SYNCHRO_KEY = "synchro_key"

    '20100226 Jimmy
    Public Const MEMBERSHIPCARD_PKID = "membershipcard_pkid"
    Public Const GROUP_DISCOUNT = "group_discount"
    Public Const CONSIGNMENT_ID = "consignment_id"
    Public Const POS_ID = "pos_id"

    Public Const ST_CREATED = "created" ' invoice created

    Public Const STATUS_ACTIVE = "active"
    Public Const STATUS_INACTIVE = "inactive"
    Public Const STATUS_CANCELLED = "cancelled"

    Public Const TABLENAME = "cust_invoice_index"
    Public Const NO_OF_COLUMNS As Integer = 123
    Public Const APP_NAME = "ThickClient-DataAccess"
    Public Const START_ID = 1001

    '***************************************************************************
    '* Create
    '**************************************************************************/
    Public Function Create(ByVal obj As DAInvoiceObject) As DAInvoiceObject

        WriteToLogFile(CLASSNAME & " - In Create")

        Dim comm As New Commands
        Dim strSQL, strSQL1, strSQL2 As String
        Dim isLoop As Boolean = True


        While isLoop

            'getNextID
            obj.mPkid = GetNextID()

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
                isLoop = False

            Catch ex As MySql.Data.MySqlClient.MySqlException
                'MsgBox(ex.ErrorCode.ToString & " " & ex.Number.ToString & " " & ex.Message)
                'ex.Number = 1062 -> Duplicate Entry
                If ex.Number <> 1062 Then
                    isLoop = False
                    Throw New Exception(CLASSNAME & " - Create - " & ex.Message)
                    Return Nothing
                Else
                    'MsgBox(ex.ErrorCode.ToString & " " & ex.Number.ToString & " " & ex.Message)
                End If

            Catch ex As Exception
                isLoop = False
                Throw New Exception(CLASSNAME & " - Create - " & ex.Message)
                Return Nothing
            End Try


        End While
        WriteToLogFile(CLASSNAME & " - Leave Create")

        Return obj

    End Function


    '***************************************************************************
    '* Update
    '**************************************************************************/
    Public Sub Update(ByVal obj As DAInvoiceObject)

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
    Public Function GetObject(ByVal id As Integer) As DAInvoiceObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DAInvoiceObject = Nothing
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
    Public Function GetObject(ByVal row As DataRow) As DAInvoiceObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DAInvoiceObject

        Try
            obj = New DAInvoiceObject
            obj.mPkid = row(PKID)
            obj.mStmtNumber = row(STMT_NO)
            obj.mSalesTxnId = row(SALES_TXN_ID)
            obj.mPaymentTermsId = row(PAYMENT_TERMS_ID)
            obj.mTimeIssued = row(TIMEISSUED)
            obj.mCurrency = row(CURRENCY)
            obj.mTotalAmt = row(TOTAL_AMT)
            obj.mOutstandingAmt = row(OUTSTANDING_AMT)
            obj.mOutstandingBfPdc = row(OUTSTANDING_BF_PDC)
            obj.mRemarks = row(REMARKS)
            obj.mState = row(STATE)
            obj.mStatus = row(STATUS)
            obj.mLastUpdate = row(LASTUPDATE)
            obj.mUserIdUpdate = row(USERID_EDIT)
            obj.mEntityTable = row(ENTITY_TABLE)
            obj.mEntityKey = row(ENTITY_KEY)
            obj.mEntityName = row(ENTITY_NAME)
            obj.mEntityCode = row(ENTITY_CODE)
            obj.mIdentityNumber = row(IDENTITY_NUMBER)
            obj.mEntityContactPerson = row(ENTITY_CONTACT_PERSON)
            obj.mForeignTable = row(FOREIGN_TABLE)
            obj.mForeignKey = row(FOREIGN_KEY)
            obj.mForeignText = row(FOREIGN_TEXT)
            obj.mCustSvcCtrId = row(CUST_SVCCTR_ID)
            obj.mLocationId = row(LOCATION_ID)
            obj.mPCCenter = row(PC_CENTER)
            obj.mTxnType = row(TXNTYPE)
            obj.mStmtType = row(STMT_TYPE)
            obj.mReferenceNo = row(REFERENCE_NO)
            obj.mDescription = row(DESCRIPTION)
            obj.mWorkOrder = row(WORK_ORDER)
            obj.mDeliveryOrder = row(DELIVERY_ORDER)
            obj.mReceiptId = row(RECEIPT_ID)
            obj.mDisplayFormat = row(DISPLAY_FORMAT)
            obj.mDocType = row(DOC_TYPE)
            obj.billingHandphone = row(BILLING_HANDPHONE)
            obj.billingPhone1 = row(BILLING_PHONE1)
            obj.billingPhone2 = row(BILLING_PHONE2)
            obj.billingFax = row(BILLING_FAX)
            obj.billingEmail = row(BILLING_EMAIL)
            obj.billingCompanyName = row(BILLING_COMPANY_NAME)
            obj.billingAdd1 = row(BILLING_ADD1)
            obj.billingAdd2 = row(BILLING_ADD2)
            obj.billingAdd3 = row(BILLING_ADD3)
            obj.billingCity = row(BILLING_CITY)
            obj.billingZip = row(BILLING_ZIP)
            obj.billingState = row(BILLING_STATE)
            obj.billingCountry = row(BILLING_COUNTRY)
            obj.receiverName = row(RECEIVER_NAME)
            obj.receiverHandphone = row(RECEIVER_HANDPHONE)
            obj.receiverPhone1 = row(RECEIVER_PHONE1)
            obj.receiverPhone2 = row(RECEIVER_PHONE2)
            obj.receiverFax = row(RECEIVER_FAX)
            obj.receiverEmail = row(RECEIVER_EMAIL)
            obj.receiverCompanyName = row(RECEIVER_COMPANY_NAME)
            obj.receiverAdd1 = row(RECEIVER_ADD1)
            obj.receiverAdd2 = row(RECEIVER_ADD2)
            obj.receiverAdd3 = row(RECEIVER_ADD3)
            obj.receiverCity = row(RECEIVER_CITY)
            obj.receiverZip = row(RECEIVER_ZIP)
            obj.receiverState = row(RECEIVER_STATE)
            obj.receiverCountry = row(RECEIVER_COUNTRY)
            obj.terms1Option = row(TERMS1_OPTION)
            obj.terms1Date = row(TERMS1_DATE)
            obj.terms1DiscPct = row(TERMS1_DISC_PCT)
            obj.terms1DiscAmt = row(TERMS1_DISC_AMT)
            obj.terms2Option = row(TERMS2_OPTION)
            obj.terms2Date = row(TERMS2_DATE)
            obj.terms2DiscPct = row(TERMS2_DISC_PCT)
            obj.terms2DiscAmt = row(TERMS2_DISC_AMT)
            obj.rebate1Option = row(REBATE1_OPTION)
            obj.rebate1Date = row(REBATE1_DATE)
            obj.rebate1Gain = row(REBATE1_GAIN)
            obj.rebate1Consume = row(REBATE1_CONSUME)
            obj.rebate2Option = row(REBATE2_OPTION)
            obj.rebate2Date = row(REBATE2_DATE)
            obj.rebate2Gain = row(REBATE2_GAIN)
            obj.rebate2Consume = row(REBATE2_CONSUME)
            obj.codeDept = row(CODE_DEPT)
            obj.codeProject = row(CODE_PROJECT)
            obj.codeSupplier = row(CODE_SUPPLIER)
            obj.salesId = row(SALES_ID)
            obj.trackingNo = row(TRACKING_NO)
            obj.guid = row(GUID)
            obj.taxAmount = row(TAX_AMOUNT)
            obj.taxType = row(TAX_TYPE)
            obj.subtype1 = row(SUBTYPE_1)
            obj.subtype2 = row(SUBTYPE_2)
            obj.subtype3 = row(SUBTYPE_3)
            obj.claimAmount = row(CLAIM_AMOUNT)
            obj.accidentDate = row(TIME_ACCIDENT)
            obj.policyNumber = row(POLICY_NUMBER)
            obj.loyaltyCardStatus = row(LOYALTY_CARD_STATUS)
            obj.loyaltyCardPkid = row(LOYALTY_CARD_PKID)
            obj.loyaltyProcessStatus = row(LOYALTY_PROCESS_STATUS)
            obj.loyaltyProcessReversalStatus = row(LOYALTY_PROCESS_REVERSAL_STATUS)
            obj.loyaltyJTxnStatus = row(LOYALTY_JTXN_STATUS)
            obj.loyaltyJTxnReversalStatus = row(LOYALTY_JTXN_REVERSAL_STATUS)
            obj.loyaltyPointsAwarded = row(LOYALTY_POINTS_AWARDED)
            obj.loyaltyPointsRedeemed = row(LOYALTY_POINTS_REDEEMED)
            obj.mCurrency2 = row(CURRENCY2)
            obj.mTotalAmt2 = row(TOTAL_AMT2)
            obj.mOutstandingAmt2 = row(OUTSTANDING_AMT2)
            obj.taxAmount2 = row(TAX_AMOUNT2)
            obj.xrate = row(XRATE)
            obj.incoterms = row(INCOTERMS)
            obj.permitNo = row(PERMIT_NO)
            obj.permitDoc1 = row(PERMIT_DOC1)
            obj.permitDoc2 = row(PERMIT_DOC2)
            obj.permitDoc3 = row(PERMIT_DOC3)
            obj.txnDoc1 = row(TXN_DOC1)
            obj.txnDoc2 = row(TXN_DOC2)
            obj.txnDoc3 = row(TXN_DOC3)
            obj.transportDoc1 = row(TRANSPORT_DOC1)
            obj.transportDoc2 = row(TRANSPORT_DOC2)
            obj.transportDoc3 = row(TRANSPORT_DOC3)
            obj.transportDate = row(TRANSPORT_DATE)
            obj.tradersRemarks = row(TRADERS_REMARKS)
            obj.synchroKey = row(SYNCHRO_KEY)
            obj.membershipCardPkid = row(MEMBERSHIPCARD_PKID)
            obj.groupDiscount = row(GROUP_DISCOUNT)
            obj.consignmentId = row(CONSIGNMENT_ID)
            obj.posId = row(POS_ID)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetObject - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetObject")

        Return obj

    End Function


    Public Function ReplaceStatement(ByVal strSQL As String, ByVal obj As DAInvoiceObject) As String

        strSQL = strSQL.Replace("{T}", TABLENAME)

        strSQL = strSQL.Replace("{1}", PKID)
        strSQL = strSQL.Replace("{2}", STMT_NO)
        strSQL = strSQL.Replace("{3}", SALES_TXN_ID)
        strSQL = strSQL.Replace("{4}", PAYMENT_TERMS_ID)
        strSQL = strSQL.Replace("{5}", TIMEISSUED)
        strSQL = strSQL.Replace("{6}", CURRENCY)
        strSQL = strSQL.Replace("{7}", TOTAL_AMT)
        strSQL = strSQL.Replace("{8}", OUTSTANDING_AMT)
        strSQL = strSQL.Replace("{9}", OUTSTANDING_BF_PDC)
        strSQL = strSQL.Replace("{10}", REMARKS)
        strSQL = strSQL.Replace("{11}", STATE)
        strSQL = strSQL.Replace("{12}", STATUS)
        strSQL = strSQL.Replace("{13}", LASTUPDATE)
        strSQL = strSQL.Replace("{14}", USERID_EDIT)
        strSQL = strSQL.Replace("{15}", ENTITY_TABLE)
        strSQL = strSQL.Replace("{16}", ENTITY_KEY)
        strSQL = strSQL.Replace("{17}", ENTITY_NAME)
        strSQL = strSQL.Replace("{18}", ENTITY_CODE)
        strSQL = strSQL.Replace("{19}", IDENTITY_NUMBER)
        strSQL = strSQL.Replace("{20}", ENTITY_CONTACT_PERSON)
        strSQL = strSQL.Replace("{21}", FOREIGN_TABLE)
        strSQL = strSQL.Replace("{22}", FOREIGN_KEY)
        strSQL = strSQL.Replace("{23}", FOREIGN_TEXT)
        strSQL = strSQL.Replace("{24}", CUST_SVCCTR_ID)
        strSQL = strSQL.Replace("{25}", LOCATION_ID)
        strSQL = strSQL.Replace("{26}", PC_CENTER)
        strSQL = strSQL.Replace("{27}", TXNTYPE)
        strSQL = strSQL.Replace("{28}", STMT_TYPE)
        strSQL = strSQL.Replace("{29}", REFERENCE_NO)
        strSQL = strSQL.Replace("{30}", DESCRIPTION)
        strSQL = strSQL.Replace("{31}", WORK_ORDER)
        strSQL = strSQL.Replace("{32}", DELIVERY_ORDER)
        strSQL = strSQL.Replace("{33}", RECEIPT_ID)
        strSQL = strSQL.Replace("{34}", DISPLAY_FORMAT)
        strSQL = strSQL.Replace("{35}", DOC_TYPE)
        strSQL = strSQL.Replace("{36}", BILLING_HANDPHONE)
        strSQL = strSQL.Replace("{37}", BILLING_PHONE1)
        strSQL = strSQL.Replace("{38}", BILLING_PHONE2)
        strSQL = strSQL.Replace("{39}", BILLING_FAX)
        strSQL = strSQL.Replace("{40}", BILLING_EMAIL)
        strSQL = strSQL.Replace("{41}", BILLING_COMPANY_NAME)
        strSQL = strSQL.Replace("{42}", BILLING_ADD1)
        strSQL = strSQL.Replace("{43}", BILLING_ADD2)
        strSQL = strSQL.Replace("{44}", BILLING_ADD3)
        strSQL = strSQL.Replace("{45}", BILLING_CITY)
        strSQL = strSQL.Replace("{46}", BILLING_ZIP)
        strSQL = strSQL.Replace("{47}", BILLING_STATE)
        strSQL = strSQL.Replace("{48}", BILLING_COUNTRY)
        strSQL = strSQL.Replace("{49}", RECEIVER_NAME)
        strSQL = strSQL.Replace("{50}", RECEIVER_HANDPHONE)
        strSQL = strSQL.Replace("{51}", RECEIVER_PHONE1)
        strSQL = strSQL.Replace("{52}", RECEIVER_PHONE2)
        strSQL = strSQL.Replace("{53}", RECEIVER_FAX)
        strSQL = strSQL.Replace("{54}", RECEIVER_EMAIL)
        strSQL = strSQL.Replace("{55}", RECEIVER_COMPANY_NAME)
        strSQL = strSQL.Replace("{56}", RECEIVER_ADD1)
        strSQL = strSQL.Replace("{57}", RECEIVER_ADD2)
        strSQL = strSQL.Replace("{58}", RECEIVER_ADD3)
        strSQL = strSQL.Replace("{59}", RECEIVER_CITY)
        strSQL = strSQL.Replace("{60}", RECEIVER_ZIP)
        strSQL = strSQL.Replace("{61}", RECEIVER_STATE)
        strSQL = strSQL.Replace("{62}", RECEIVER_COUNTRY)
        strSQL = strSQL.Replace("{63}", TERMS1_OPTION)
        strSQL = strSQL.Replace("{64}", TERMS1_DATE)
        strSQL = strSQL.Replace("{65}", TERMS1_DISC_PCT)
        strSQL = strSQL.Replace("{66}", TERMS1_DISC_AMT)
        strSQL = strSQL.Replace("{67}", TERMS2_OPTION)
        strSQL = strSQL.Replace("{68}", TERMS2_DATE)
        strSQL = strSQL.Replace("{69}", TERMS2_DISC_PCT)
        strSQL = strSQL.Replace("{70}", TERMS2_DISC_AMT)
        strSQL = strSQL.Replace("{71}", REBATE1_OPTION)
        strSQL = strSQL.Replace("{72}", REBATE1_DATE)
        strSQL = strSQL.Replace("{73}", REBATE1_GAIN)
        strSQL = strSQL.Replace("{74}", REBATE1_CONSUME)
        strSQL = strSQL.Replace("{75}", REBATE2_OPTION)
        strSQL = strSQL.Replace("{76}", REBATE2_DATE)
        strSQL = strSQL.Replace("{77}", REBATE2_GAIN)
        strSQL = strSQL.Replace("{78}", REBATE2_CONSUME)
        strSQL = strSQL.Replace("{79}", CODE_DEPT)
        strSQL = strSQL.Replace("{80}", CODE_PROJECT)
        strSQL = strSQL.Replace("{81}", CODE_SUPPLIER)
        strSQL = strSQL.Replace("{82}", SALES_ID)
        strSQL = strSQL.Replace("{83}", TRACKING_NO)
        strSQL = strSQL.Replace("{84}", GUID)
        strSQL = strSQL.Replace("{85}", TAX_AMOUNT)
        strSQL = strSQL.Replace("{86}", TAX_TYPE)
        strSQL = strSQL.Replace("{87}", SUBTYPE_1)
        strSQL = strSQL.Replace("{88}", SUBTYPE_2)
        strSQL = strSQL.Replace("{89}", SUBTYPE_3)
        strSQL = strSQL.Replace("{90}", CLAIM_AMOUNT)
        strSQL = strSQL.Replace("{91}", TIME_ACCIDENT)
        strSQL = strSQL.Replace("{92}", POLICY_NUMBER)
        strSQL = strSQL.Replace("{93}", LOYALTY_CARD_STATUS)
        strSQL = strSQL.Replace("{94}", LOYALTY_CARD_PKID)
        strSQL = strSQL.Replace("{95}", LOYALTY_PROCESS_STATUS)
        strSQL = strSQL.Replace("{96}", LOYALTY_PROCESS_REVERSAL_STATUS)
        strSQL = strSQL.Replace("{97}", LOYALTY_JTXN_STATUS)
        strSQL = strSQL.Replace("{98}", LOYALTY_JTXN_REVERSAL_STATUS)
        strSQL = strSQL.Replace("{99}", LOYALTY_POINTS_AWARDED)
        strSQL = strSQL.Replace("{100}", LOYALTY_POINTS_REDEEMED)
        strSQL = strSQL.Replace("{101}", CURRENCY2)
        strSQL = strSQL.Replace("{102}", TOTAL_AMT2)
        strSQL = strSQL.Replace("{103}", OUTSTANDING_AMT2)
        strSQL = strSQL.Replace("{104}", TAX_AMOUNT2)
        strSQL = strSQL.Replace("{105}", XRATE)
        strSQL = strSQL.Replace("{106}", INCOTERMS)
        strSQL = strSQL.Replace("{107}", PERMIT_NO)
        strSQL = strSQL.Replace("{108}", PERMIT_DOC1)
        strSQL = strSQL.Replace("{109}", PERMIT_DOC2)
        strSQL = strSQL.Replace("{110}", PERMIT_DOC3)
        strSQL = strSQL.Replace("{111}", TXN_DOC1)
        strSQL = strSQL.Replace("{112}", TXN_DOC2)
        strSQL = strSQL.Replace("{113}", TXN_DOC3)
        strSQL = strSQL.Replace("{114}", TRANSPORT_DOC1)
        strSQL = strSQL.Replace("{115}", TRANSPORT_DOC2)
        strSQL = strSQL.Replace("{116}", TRANSPORT_DOC3)
        strSQL = strSQL.Replace("{117}", TRANSPORT_DATE)
        strSQL = strSQL.Replace("{118}", TRADERS_REMARKS)
        strSQL = strSQL.Replace("{119}", SYNCHRO_KEY)
        strSQL = strSQL.Replace("{120}", MEMBERSHIPCARD_PKID)
        strSQL = strSQL.Replace("{121}", GROUP_DISCOUNT)
        strSQL = strSQL.Replace("{122}", CONSIGNMENT_ID)
        strSQL = strSQL.Replace("{123}", POS_ID)


        strSQL = strSQL.Replace("{V1}", PreparedStatement(obj.mPkid))
        strSQL = strSQL.Replace("{V2}", PreparedStatement(obj.mStmtNumber))
        strSQL = strSQL.Replace("{V3}", PreparedStatement(obj.mSalesTxnId))
        strSQL = strSQL.Replace("{V4}", PreparedStatement(obj.mPaymentTermsId))
        strSQL = strSQL.Replace("{V5}", PreparedStatement(obj.mTimeIssued))
        strSQL = strSQL.Replace("{V6}", PreparedStatement(obj.mCurrency))
        strSQL = strSQL.Replace("{V7}", PreparedStatement(obj.mTotalAmt))
        strSQL = strSQL.Replace("{V8}", PreparedStatement(obj.mOutstandingAmt))
        strSQL = strSQL.Replace("{V9}", PreparedStatement(obj.mOutstandingBfPdc))
        strSQL = strSQL.Replace("{V10}", PreparedStatement(obj.mRemarks))
        strSQL = strSQL.Replace("{V11}", PreparedStatement(obj.mState))
        strSQL = strSQL.Replace("{V12}", PreparedStatement(obj.mStatus))
        strSQL = strSQL.Replace("{V13}", PreparedStatement(obj.mLastUpdate))
        strSQL = strSQL.Replace("{V14}", PreparedStatement(obj.mUserIdUpdate))
        strSQL = strSQL.Replace("{V15}", PreparedStatement(obj.mEntityTable))
        strSQL = strSQL.Replace("{V16}", PreparedStatement(obj.mEntityKey))
        strSQL = strSQL.Replace("{V17}", PreparedStatement(obj.mEntityName))
        strSQL = strSQL.Replace("{V18}", PreparedStatement(obj.mEntityCode))
        strSQL = strSQL.Replace("{V19}", PreparedStatement(obj.mIdentityNumber))
        strSQL = strSQL.Replace("{V20}", PreparedStatement(obj.mEntityContactPerson))
        strSQL = strSQL.Replace("{V21}", PreparedStatement(obj.mForeignTable))
        strSQL = strSQL.Replace("{V22}", PreparedStatement(obj.mForeignKey))
        strSQL = strSQL.Replace("{V23}", PreparedStatement(obj.mForeignText))
        strSQL = strSQL.Replace("{V24}", PreparedStatement(obj.mCustSvcCtrId))
        strSQL = strSQL.Replace("{V25}", PreparedStatement(obj.mLocationId))
        strSQL = strSQL.Replace("{V26}", PreparedStatement(obj.mPCCenter))
        strSQL = strSQL.Replace("{V27}", PreparedStatement(obj.mTxnType))
        strSQL = strSQL.Replace("{V28}", PreparedStatement(obj.mStmtType))
        strSQL = strSQL.Replace("{V29}", PreparedStatement(obj.mReferenceNo))
        strSQL = strSQL.Replace("{V30}", PreparedStatement(obj.mDescription))
        strSQL = strSQL.Replace("{V31}", PreparedStatement(obj.mWorkOrder))
        strSQL = strSQL.Replace("{V32}", PreparedStatement(obj.mDeliveryOrder))
        strSQL = strSQL.Replace("{V33}", PreparedStatement(obj.mReceiptId))
        strSQL = strSQL.Replace("{V34}", PreparedStatement(obj.mDisplayFormat))
        strSQL = strSQL.Replace("{V35}", PreparedStatement(obj.mDocType))
        strSQL = strSQL.Replace("{V36}", PreparedStatement(obj.billingHandphone))
        strSQL = strSQL.Replace("{V37}", PreparedStatement(obj.billingPhone1))
        strSQL = strSQL.Replace("{V38}", PreparedStatement(obj.billingPhone2))
        strSQL = strSQL.Replace("{V39}", PreparedStatement(obj.billingFax))
        strSQL = strSQL.Replace("{V40}", PreparedStatement(obj.billingEmail))
        strSQL = strSQL.Replace("{V41}", PreparedStatement(obj.billingCompanyName))
        strSQL = strSQL.Replace("{V42}", PreparedStatement(obj.billingAdd1))
        strSQL = strSQL.Replace("{V43}", PreparedStatement(obj.billingAdd2))
        strSQL = strSQL.Replace("{V44}", PreparedStatement(obj.billingAdd3))
        strSQL = strSQL.Replace("{V45}", PreparedStatement(obj.billingCity))
        strSQL = strSQL.Replace("{V46}", PreparedStatement(obj.billingZip))
        strSQL = strSQL.Replace("{V47}", PreparedStatement(obj.billingState))
        strSQL = strSQL.Replace("{V48}", PreparedStatement(obj.billingCountry))
        strSQL = strSQL.Replace("{V49}", PreparedStatement(obj.receiverName))
        strSQL = strSQL.Replace("{V50}", PreparedStatement(obj.receiverHandphone))
        strSQL = strSQL.Replace("{V51}", PreparedStatement(obj.receiverPhone1))
        strSQL = strSQL.Replace("{V52}", PreparedStatement(obj.receiverPhone2))
        strSQL = strSQL.Replace("{V53}", PreparedStatement(obj.receiverFax))
        strSQL = strSQL.Replace("{V54}", PreparedStatement(obj.receiverEmail))
        strSQL = strSQL.Replace("{V55}", PreparedStatement(obj.receiverCompanyName))
        strSQL = strSQL.Replace("{V56}", PreparedStatement(obj.receiverAdd1))
        strSQL = strSQL.Replace("{V57}", PreparedStatement(obj.receiverAdd2))
        strSQL = strSQL.Replace("{V58}", PreparedStatement(obj.receiverAdd3))
        strSQL = strSQL.Replace("{V59}", PreparedStatement(obj.receiverCity))
        strSQL = strSQL.Replace("{V60}", PreparedStatement(obj.receiverZip))
        strSQL = strSQL.Replace("{V61}", PreparedStatement(obj.receiverState))
        strSQL = strSQL.Replace("{V62}", PreparedStatement(obj.receiverCountry))
        strSQL = strSQL.Replace("{V63}", PreparedStatement(obj.terms1Option))
        strSQL = strSQL.Replace("{V64}", PreparedStatement(obj.terms1Date))
        strSQL = strSQL.Replace("{V65}", PreparedStatement(obj.terms1DiscPct))
        strSQL = strSQL.Replace("{V66}", PreparedStatement(obj.terms1DiscAmt))
        strSQL = strSQL.Replace("{V67}", PreparedStatement(obj.terms2Option))
        strSQL = strSQL.Replace("{V68}", PreparedStatement(obj.terms2Date))
        strSQL = strSQL.Replace("{V69}", PreparedStatement(obj.terms2DiscPct))
        strSQL = strSQL.Replace("{V70}", PreparedStatement(obj.terms2DiscAmt))
        strSQL = strSQL.Replace("{V71}", PreparedStatement(obj.rebate1Option))
        strSQL = strSQL.Replace("{V72}", PreparedStatement(obj.rebate1Date))
        strSQL = strSQL.Replace("{V73}", PreparedStatement(obj.rebate1Gain))
        strSQL = strSQL.Replace("{V74}", PreparedStatement(obj.rebate1Consume))
        strSQL = strSQL.Replace("{V75}", PreparedStatement(obj.rebate2Option))
        strSQL = strSQL.Replace("{V76}", PreparedStatement(obj.rebate2Date))
        strSQL = strSQL.Replace("{V77}", PreparedStatement(obj.rebate2Gain))
        strSQL = strSQL.Replace("{V78}", PreparedStatement(obj.rebate2Consume))
        strSQL = strSQL.Replace("{V79}", PreparedStatement(obj.codeDept))
        strSQL = strSQL.Replace("{V80}", PreparedStatement(obj.codeProject))
        strSQL = strSQL.Replace("{V81}", PreparedStatement(obj.codeSupplier))
        strSQL = strSQL.Replace("{V82}", PreparedStatement(obj.salesId))
        strSQL = strSQL.Replace("{V83}", PreparedStatement(obj.trackingNo))
        strSQL = strSQL.Replace("{V84}", PreparedStatement(obj.guid))
        strSQL = strSQL.Replace("{V85}", PreparedStatement(obj.taxAmount))
        strSQL = strSQL.Replace("{V86}", PreparedStatement(obj.taxType))
        strSQL = strSQL.Replace("{V87}", PreparedStatement(obj.subtype1))
        strSQL = strSQL.Replace("{V88}", PreparedStatement(obj.subtype2))
        strSQL = strSQL.Replace("{V89}", PreparedStatement(obj.subtype3))
        strSQL = strSQL.Replace("{V90}", PreparedStatement(obj.claimAmount))
        strSQL = strSQL.Replace("{V91}", PreparedStatement(obj.accidentDate))
        strSQL = strSQL.Replace("{V92}", PreparedStatement(obj.policyNumber))
        strSQL = strSQL.Replace("{V93}", PreparedStatement(obj.loyaltyCardStatus))
        strSQL = strSQL.Replace("{V94}", PreparedStatement(obj.loyaltyCardPkid))
        strSQL = strSQL.Replace("{V95}", PreparedStatement(obj.loyaltyProcessStatus))
        strSQL = strSQL.Replace("{V96}", PreparedStatement(obj.loyaltyProcessReversalStatus))
        strSQL = strSQL.Replace("{V97}", PreparedStatement(obj.loyaltyJTxnStatus))
        strSQL = strSQL.Replace("{V98}", PreparedStatement(obj.loyaltyJTxnReversalStatus))
        strSQL = strSQL.Replace("{V99}", PreparedStatement(obj.loyaltyPointsAwarded))
        strSQL = strSQL.Replace("{V100}", PreparedStatement(obj.loyaltyPointsRedeemed))
        strSQL = strSQL.Replace("{V101}", PreparedStatement(obj.mCurrency2))
        strSQL = strSQL.Replace("{V102}", PreparedStatement(obj.mTotalAmt2))
        strSQL = strSQL.Replace("{V103}", PreparedStatement(obj.mOutstandingAmt2))
        strSQL = strSQL.Replace("{V104}", PreparedStatement(obj.taxAmount2))
        strSQL = strSQL.Replace("{V105}", PreparedStatement(obj.xrate))
        strSQL = strSQL.Replace("{V106}", PreparedStatement(obj.incoterms))
        strSQL = strSQL.Replace("{V107}", PreparedStatement(obj.permitNo))
        strSQL = strSQL.Replace("{V108}", PreparedStatement(obj.permitDoc1))
        strSQL = strSQL.Replace("{V109}", PreparedStatement(obj.permitDoc2))
        strSQL = strSQL.Replace("{V110}", PreparedStatement(obj.permitDoc3))
        strSQL = strSQL.Replace("{V111}", PreparedStatement(obj.txnDoc1))
        strSQL = strSQL.Replace("{V112}", PreparedStatement(obj.txnDoc2))
        strSQL = strSQL.Replace("{V113}", PreparedStatement(obj.txnDoc3))
        strSQL = strSQL.Replace("{V114}", PreparedStatement(obj.transportDoc1))
        strSQL = strSQL.Replace("{V115}", PreparedStatement(obj.transportDoc2))
        strSQL = strSQL.Replace("{V116}", PreparedStatement(obj.transportDoc3))
        strSQL = strSQL.Replace("{V117}", PreparedStatement(obj.transportDate))
        strSQL = strSQL.Replace("{V118}", PreparedStatement(obj.tradersRemarks))
        strSQL = strSQL.Replace("{V119}", PreparedStatement(obj.synchroKey))
        strSQL = strSQL.Replace("{V120}", PreparedStatement(obj.membershipCardPkid))
        strSQL = strSQL.Replace("{V121}", PreparedStatement(obj.groupDiscount))
        strSQL = strSQL.Replace("{V122}", PreparedStatement(obj.consignmentId))
        strSQL = strSQL.Replace("{V123}", PreparedStatement(obj.posId))
        Return strSQL

    End Function


    '***************************************************************************
    '* GetNextID
    '**************************************************************************/
    Public Function GetNextID() As Long

        Return DAAppTableCounter.GetNextPKID(PKID, TABLENAME, "POS", START_ID)

    End Function


    '***************************************************************************
    '* GetDailySalesReport
    '**************************************************************************/
    Public Function GetDailySalesReport(ByVal userId As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, _
                                            ByVal posId As Integer) As DataSet

        WriteToLogFile(CLASSNAME & " - In GetDailySalesReport")

        Dim comm As New Commands
        Dim strSQL As String

        strSQL = "SELECT COUNT(*) AS count, SUM({0}) AS sum, SUM({0}-{4}) as sum_no_gst FROM {T} " & _
                 "WHERE {1} >= {V1} AND {1} < {V2} "

        If userId <> 0 Then
            strSQL = strSQL & " AND userid_edit = " & userId
        End If

        If posId <> 0 Then
            strSQL = strSQL & " AND pos_id = " & posId
        End If

        strSQL = strSQL.Replace("{T}", TABLENAME)
        strSQL = strSQL.Replace("{0}", TOTAL_AMT)
        strSQL = strSQL.Replace("{1}", TIMEISSUED)
        strSQL = strSQL.Replace("{V1}", PreparedStatement(dateFrom))
        strSQL = strSQL.Replace("{V2}", PreparedStatement(dateTo))
        strSQL = strSQL.Replace("{4}", TAX_AMOUNT)

        Try
            WriteToLogFile(strSQL)
            Return comm.ExecuteQuery(strSQL, Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetDailySalesReport - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetDailySalesReport")

    End Function


    '***************************************************************************
    '* GetDailySalesReport
    '**************************************************************************/
    Public Function GetDailySalesReportVoid(ByVal userId As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, _
                                            ByVal posId As Integer) As DataSet

        WriteToLogFile(CLASSNAME & " - In GetDailySalesReportVoid")

        Dim comm As New Commands
        Dim strSQL As String

        strSQL = "SELECT COUNT(*) AS count, SUM({0}) AS sum, SUM({0}-{4}) as sum_no_gst FROM {T} " & _
                 " WHERE {1} >= {V1} AND {1} < {V2} AND status = 'cancelled'"

        If userId <> 0 Then
            strSQL = strSQL & " AND userid_edit = " & userId
        End If

        If posId <> 0 Then
            strSQL = strSQL & " AND pos_id = " & posId
        End If

        strSQL = strSQL.Replace("{T}", TABLENAME)
        strSQL = strSQL.Replace("{0}", TOTAL_AMT)
        strSQL = strSQL.Replace("{1}", LASTUPDATE)
        strSQL = strSQL.Replace("{V1}", PreparedStatement(dateFrom))
        strSQL = strSQL.Replace("{V2}", PreparedStatement(dateTo))
        strSQL = strSQL.Replace("{4}", TAX_AMOUNT)

        Try
            WriteToLogFile(strSQL)
            Return comm.ExecuteQuery(strSQL, Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetDailySalesReportVoid - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetDailySalesReportVoid")

    End Function

    '***************************************************************************
    '* GetDailySalesReportCollection
    '**************************************************************************/
    Public Function GetDailySalesReportCollection(ByVal userId As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, _
                                                    ByVal posId As Integer) As DataSet

        WriteToLogFile(CLASSNAME & " - In GetDailySalesReportCollection")

        Dim comm As New Commands
        Dim strSQL As String

        strSQL = "SELECT receipt.*, inv.status AS {T}_status FROM acc_receipt_index receipt INNER JOIN {T} inv " & _
                    " ON receipt.pkid = inv.receipt_id " & _
                    " WHERE {1} >= {V1} AND {1} < {V2} "

        If userId <> 0 Then
            strSQL = strSQL & " AND userid_edit = " & userId
        End If

        If posId <> 0 Then
            strSQL = strSQL & " AND inv.pos_id = " & posId
        End If

        strSQL = strSQL.Replace("{T}", TABLENAME)
        strSQL = strSQL.Replace("{0}", TOTAL_AMT)
        strSQL = strSQL.Replace("{1}", TIMEISSUED)
        strSQL = strSQL.Replace("{V1}", PreparedStatement(dateFrom))
        strSQL = strSQL.Replace("{V2}", PreparedStatement(dateTo))

        Try
            WriteToLogFile(strSQL)
            Return comm.ExecuteQuery(strSQL, Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetDailySalesReportCollection - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetDailySalesReportCollection")

    End Function


    '***************************************************************************
    '* GetDailySalesReportCollection
    '**************************************************************************/
    Public Function GetDailySalesReportVoidCollection(ByVal userId As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, _
                                                    ByVal posId As Integer) As DataSet

        WriteToLogFile(CLASSNAME & " - In GetDailySalesReportVoidCollection")

        Dim comm As New Commands
        Dim strSQL As String

        'SELECT receipt.* FROM acc_receipt_index receipt INNER JOIN (
        'SELECT src_docid AS receipt_id FROM acc_doclink 
        'WHERE src_docref = 'acc_receipt_index' AND  tgt_docref = 'cust_invoice_index' 
        'AND tgt_docid IN (
        'SELECT pkid FROM cust_invoice_index
        'WHERE lastupdate >= '2011-01-05 00:00:00'
        'AND lastupdate < '2011-01-05 10:14:01' AND status = 'cancelled')
        ') AS rpt ON receipt.pkid = rpt.receipt_id;

        strSQL = "SELECT * FROM acc_receipt_index receipt INNER JOIN (" & _
                    "SELECT src_docid AS receipt_id, amount AS amount_doclink, tgt_docid AS invoice_id FROM acc_doclink " & _
                    "WHERE src_docref = 'acc_receipt_index' AND  tgt_docref = 'cust_invoice_index' " & _
                    "AND amount != 0 AND tgt_docid IN ( " & _
                    "SELECT pkid FROM {T} " & _
                    "WHERE {1} >= {V1} AND {1} < {V2} AND {3} = {V3}"

        If userId <> 0 Then
            strSQL = strSQL & " AND userid_edit = " & userId
        End If

        If posId <> 0 Then
            strSQL = strSQL & " AND pos_id = " & posId
        End If

        strSQL = strSQL & ") ) as rpt ON receipt.pkid = rpt.receipt_id"

        strSQL = strSQL.Replace("{T}", TABLENAME)
        strSQL = strSQL.Replace("{0}", TOTAL_AMT)
        strSQL = strSQL.Replace("{1}", LASTUPDATE)
        strSQL = strSQL.Replace("{3}", STATUS)
        strSQL = strSQL.Replace("{V1}", PreparedStatement(dateFrom))
        strSQL = strSQL.Replace("{V2}", PreparedStatement(dateTo))
        strSQL = strSQL.Replace("{V3}", PreparedStatement(STATUS_CANCELLED))


        Try
            WriteToLogFile(strSQL)
            Return comm.ExecuteQuery(strSQL, Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetDailySalesReportVoidCollection - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetDailySalesReportVoidCollection")

    End Function

    '***************************************************************************
    '* GetDailySalesReportByType
    '**************************************************************************/
    Public Function GetDailySalesReportByType(ByVal userId As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, _
                                                ByVal posId As Integer, ByVal paymentMethod As String, ByVal cardType As String) As DataSet

        WriteToLogFile(CLASSNAME & " - In GetDailySalesReportByType")

        Dim comm As New Commands
        Dim strSQL As String

        strSQL = "SELECT count(pkid) AS count, sum({A}) AS sum FROM acc_receipt_index receipt INNER JOIN " & _
                    "(SELECT receipt_id FROM {T} " & _
                    " WHERE {1} >= {V1} AND {1} < {V2} " ' & _
        '" AND (status != 'cancelled' OR lastupdate >= {V2})"

        If userId <> 0 Then
            strSQL = strSQL & " AND userid_edit = " & userId
        End If

        If posId <> 0 Then
            strSQL = strSQL & " AND pos_id = " & posId
        End If

        strSQL = strSQL & ") as rpt ON receipt.pkid = rpt.receipt_id WHERE {A} > 0"

        If cardType <> "" Then
            strSQL = strSQL & " AND " & DAOfficialReceipt.CARD_TYPE & "=" & PreparedStatement(cardType)
        End If

        Select Case paymentMethod
            Case "CASH"
                strSQL = strSQL.Replace("{A}", DAOfficialReceipt.AMOUNT_CASH)
            Case "CARD"
                strSQL = strSQL.Replace("{A}", DAOfficialReceipt.AMOUNT_CARD)
            Case "CHEQUE"
                strSQL = strSQL.Replace("{A}", DAOfficialReceipt.AMOUNT_CHEQUE)
            Case "PDCHEQUE"
                strSQL = strSQL.Replace("{A}", DAOfficialReceipt.AMOUNT_PD_CHEQUE)
            Case "COUPON"
                strSQL = strSQL.Replace("{A}", DAOfficialReceipt.AMOUNT_COUPON)
            Case "OTHER"
                strSQL = strSQL.Replace("{A}", DAOfficialReceipt.AMOUNT_OTHER)
        End Select

        strSQL = strSQL.Replace("{T}", TABLENAME)
        strSQL = strSQL.Replace("{0}", TOTAL_AMT)
        strSQL = strSQL.Replace("{1}", TIMEISSUED)
        strSQL = strSQL.Replace("{V1}", PreparedStatement(dateFrom))
        strSQL = strSQL.Replace("{V2}", PreparedStatement(dateTo))

        Try
            WriteToLogFile(strSQL)
            Return comm.ExecuteQuery(strSQL, Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetDailySalesReportByType - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetDailySalesReportByType")

    End Function

    '***************************************************************************
    '* GetDailySalesSummaryReport
    '**************************************************************************/
    Public Function GetDailySalesSummaryReport(ByVal userId As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, _
                                            ByVal posId As Integer) As DataSet

        WriteToLogFile(CLASSNAME & " - In GetDailySalesSummaryReport")

        Dim comm As New Commands
        Dim strSQL As String

        strSQL = "SELECT rpt2.*, categorytree.name FROM ( " & _
                       " SELECT item_code.category1, sum(rpt1.sum_qty) AS total_qty, sum(rpt1.sum_amount) AS total_amt FROM ( " & _
                       " SELECT iitm.item_id,sum(iitm.total_quantity) as sum_qty,sum(iitm.unit_price_quoted*iitm.total_quantity) as sum_amount FROM cust_invoice_item AS iitm INNER JOIN cust_invoice_index AS iidx " & _
                       " ON (iitm.invoice_id = iidx.pkid) WHERE iidx.time_issued >= {0} AND iidx.time_issued <= {1} {A} {B} GROUP BY iitm.item_id " & _
                       " ) AS rpt1 " & _
                       " INNER JOIN inv_item AS item_code ON (rpt1.item_id = item_code.pkid) GROUP BY item_code.category1 " & _
                       " ) AS rpt2 INNER JOIN inv_category_tree AS categorytree ON (rpt2.category1 = categorytree.code) WHERE categorytree.cat_level='1' "

        'strSQL = String.Format(strSQL, PreparedStatement(dateFrom.ToString("yyyy-MM-dd")), PreparedStatement(nextDay.ToString("yyyy-MM-dd")))
        strSQL = strSQL.Replace("{0}", PreparedStatement(dateFrom.ToString("yyyy-MM-dd HH:mm:ss")))
        strSQL = strSQL.Replace("{1}", PreparedStatement(dateTo.ToString("yyyy-MM-dd HH:mm:ss")))

        If userId <> 0 Then
            strSQL = strSQL.Replace("{A}", " AND userid_edit = " & userId)
        Else
            strSQL = strSQL.Replace("{A}", "")
        End If

        If posId <> 0 Then
            strSQL = strSQL.Replace("{B}", " AND pos_id = " & posId)
        Else
            strSQL = strSQL.Replace("{B}", "")
        End If

        Try
            WriteToLogFile(strSQL)
            Return comm.ExecuteQuery(strSQL, Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetDailySalesSummaryReport - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetDailySalesSummaryReport")

    End Function


    '***************************************************************************
    '* GetHourlySalesReport
    '**************************************************************************/
    Public Function GetHourlySalesReport(ByVal userId As Integer, ByVal dateFrom As Date, _
                                            ByVal posId As Integer) As DataSet

        WriteToLogFile(CLASSNAME & " - In GetHourlySalesReport")

        Dim comm As New Commands
        Dim strSQL As String
        Dim nextDay As Date = dateFrom.AddDays(1)

        strSQL = " SELECT usr.username, rpt1.* FROM ( " & _
                         " SELECT count(*) as count, idx.userid_edit, substring(idx.time_issued from 12 for 2) AS hour, sum(idx.total_amt) AS amount FROM cust_invoice_index AS idx  " & _
                         " WHERE idx.time_issued >= {0} AND idx.time_issued < {1} {2} {3} " & _
                         " GROUP BY idx.userid_edit, " & _
                         " substring(idx.time_issued from 12 for 2) " & _
                         " ) AS rpt1 INNER JOIN  user_index AS usr ON (rpt1.userid_edit = usr.userid)"
        'strSQL = String.Format(strSQL, PreparedStatement(dateFrom.ToString("yyyy-MM-dd")), PreparedStatement(nextDay.ToString("yyyy-MM-dd")))
        strSQL = strSQL.Replace("{0}", PreparedStatement(dateFrom.ToString("yyyy-MM-dd")))
        strSQL = strSQL.Replace("{1}", PreparedStatement(nextDay.ToString("yyyy-MM-dd")))

        If userId <> 0 Then
            strSQL = strSQL.Replace("{2}", " AND userid_edit = " & userId)
        Else
            strSQL = strSQL.Replace("{2}", "")
        End If

        If posId <> 0 Then
            strSQL = strSQL.Replace("{3}", " AND pos_id = " & posId)
        Else
            strSQL = strSQL.Replace("{3}", "")
        End If

        Try
            WriteToLogFile(strSQL)
            Return comm.ExecuteQuery(strSQL, Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetHourlySalesReport - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetHourlySalesReport")

    End Function


    '***************************************************************************
    '* GetReceiptListing
    '**************************************************************************/
    Public Function GetReceiptListing(ByVal userId As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, _
                                            ByVal posId As Integer) As DataSet

        WriteToLogFile(CLASSNAME & " - In GetReceiptListing")

        Dim comm As New Commands
        Dim strSQL As String
        'Dim nextDay As Date = dateFrom.AddDays(1)

        strSQL = "SELECT iidx.pkid AS invoiceId, iidx.userid_edit AS userId, iidx.time_issued, iitm.item_code, iitm.name, iitm.total_quantity, iitm.unit_price_quoted, (iitm.total_quantity*iitm.unit_price_quoted) AS total FROM cust_invoice_index AS iidx, cust_invoice_item AS iitm " & _
                         " WHERE iidx.pkid = iitm.invoice_id AND iidx.time_issued >= {0} AND iidx.time_issued <= {1}"

        strSQL = String.Format(strSQL, PreparedStatement(dateFrom.ToString("yyyy-MM-dd HH:mm:ss")), PreparedStatement(dateTo.ToString("yyyy-MM-dd HH:mm:ss")))

        If userId <> 0 Then
            strSQL = strSQL & " AND iidx.userid_edit = " & userId
        End If

        If posId <> 0 Then
            strSQL = strSQL & " AND pos_id = " & posId
        End If

        Try
            WriteToLogFile(strSQL)
            Return comm.ExecuteQuery(strSQL, Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetReceiptListing - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetReceiptListing")

    End Function


    '***************************************************************************
    '* GetDetailedVoidReport
    '**************************************************************************/
    Public Function GetDetailedVoidReport(ByVal userId As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, _
                                                        ByVal posId As Integer) As DataSet

        WriteToLogFile(CLASSNAME & " - In GetDetailedVoidReport")

        Dim comm As New Commands
        Dim strSQL As String
        Dim nextDay As Date = dateFrom.AddDays(1)

        strSQL = "SELECT rpt2.*, categorytree.name FROM ( " & _
                        " SELECT item_code.category1, sum(rpt1.sum_qty) AS total_qty, sum(rpt1.sum_amount) AS total_amt FROM ( " & _
                        " SELECT iitm.item_id,sum(iitm.total_quantity) as sum_qty,sum(iitm.unit_price_quoted*iitm.total_quantity) as sum_amount FROM cust_invoice_item AS iitm INNER JOIN cust_invoice_index AS iidx " & _
                        " ON (iitm.invoice_id = iidx.pkid) WHERE iidx.time_issued >= {0} AND iidx.time_issued < {1} AND iidx.status = 'cancelled' {A} {B} GROUP BY iitm.item_id " & _
                        " ) AS rpt1 " & _
                        " INNER JOIN inv_item AS item_code ON (rpt1.item_id = item_code.pkid) GROUP BY item_code.category1 " & _
                        " ) AS rpt2 INNER JOIN inv_category_tree AS categorytree ON (rpt2.category1 = categorytree.code) WHERE categorytree.cat_level='1' "

        strSQL = strSQL.Replace("{0}", PreparedStatement(dateFrom.ToString("yyyy-MM-dd")))
        strSQL = strSQL.Replace("{1}", PreparedStatement(nextDay.ToString("yyyy-MM-dd")))

        If userId <> 0 Then
            strSQL = strSQL.Replace("{A}", " AND userid_edit = " & userId)
        Else
            strSQL = strSQL.Replace("{A}", "")
        End If

        If posId <> 0 Then
            strSQL = strSQL.Replace("{B}", " AND pos_id = " & posId)
        Else
            strSQL = strSQL.Replace("{B}", "")
        End If

        Try
            WriteToLogFile(strSQL)
            Return comm.ExecuteQuery(strSQL, Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetDetailedVoidReport - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetDetailedVoidReport")

    End Function


    '***************************************************************************
    '* GetDailySalesReportVoid
    '**************************************************************************/
    Public Function GetDailySalesReportByTypeVoid(ByVal userId As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, _
                                            ByVal posId As Integer, ByVal paymentMethod As String, ByVal cardType As String) As DataSet

        WriteToLogFile(CLASSNAME & " - In GetDailySalesReportByTypeVoid")

        Dim comm As New Commands
        Dim strSQL As String

        strSQL = "SELECT count(pkid) AS count, sum({A}) AS sum FROM acc_receipt_index receipt INNER JOIN " & _
                    "(SELECT receipt_id FROM {T} " & _
                    " WHERE {1} >= {V1} AND {1} < {V2} AND status = 'cancelled'"

        If userId <> 0 Then
            strSQL = strSQL & " AND userid_edit = " & userId
        End If

        If posId <> 0 Then
            strSQL = strSQL & " AND pos_id = " & posId
        End If

        strSQL = strSQL & ") as rpt ON receipt.pkid = rpt.receipt_id WHERE {A} > 0"

        If cardType <> "" Then
            strSQL = strSQL & " AND " & DAOfficialReceipt.CARD_TYPE & "=" & PreparedStatement(cardType)
        End If

        Select Case paymentMethod
            Case "CASH"
                strSQL = strSQL.Replace("{A}", DAOfficialReceipt.AMOUNT_CASH)
            Case "CARD"
                strSQL = strSQL.Replace("{A}", DAOfficialReceipt.AMOUNT_CARD)
            Case "CHEQUE"
                strSQL = strSQL.Replace("{A}", DAOfficialReceipt.AMOUNT_CHEQUE)
            Case "PDCHEQUE"
                strSQL = strSQL.Replace("{A}", DAOfficialReceipt.AMOUNT_PD_CHEQUE)
            Case "COUPON"
                strSQL = strSQL.Replace("{A}", DAOfficialReceipt.AMOUNT_COUPON)
            Case "OTHER"
                strSQL = strSQL.Replace("{A}", DAOfficialReceipt.AMOUNT_OTHER)

        End Select

        strSQL = strSQL.Replace("{T}", TABLENAME)
        strSQL = strSQL.Replace("{0}", TOTAL_AMT)
        strSQL = strSQL.Replace("{1}", LASTUPDATE)
        strSQL = strSQL.Replace("{V1}", PreparedStatement(dateFrom))
        strSQL = strSQL.Replace("{V2}", PreparedStatement(dateTo))


        Try
            WriteToLogFile(strSQL)
            Return comm.ExecuteQuery(strSQL, Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetDailySalesReportByTypeVoid - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetDailySalesReportByTypeVoid")

    End Function

    '***************************************************************************
    '* GetVoidReport
    '**************************************************************************/
    Public Function GetVoidReport(ByVal userId As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, _
                                                        ByVal posId As Integer) As DataSet

        WriteToLogFile(CLASSNAME & " - In GetVoidReport")

        Dim comm As New Commands
        Dim strSQL As String
        Dim nextDay As Date = dateTo.AddDays(1)

        strSQL = "SELECT rpt1.*, usr.username FROM " & _
                        "(SELECT iidx.pkid AS invoiceId, iidx.remarks, iidx.userid_edit AS userId, iidx.time_issued, iitm.item_code, iitm.name, iitm.total_quantity, iitm.unit_price_quoted, (iitm.total_quantity*iitm.unit_price_quoted) AS total " & _
                        " FROM cust_invoice_index AS iidx, cust_invoice_item AS iitm " & _
                        " WHERE iidx.pkid = iitm.invoice_id AND iidx.lastupdate >= {0} AND iidx.lastupdate <= {1} AND iidx.status = {2}"

        strSQL = String.Format(strSQL, PreparedStatement(dateFrom), PreparedStatement(nextDay), PreparedStatement(DAInvoice.STATUS_CANCELLED))

        If userId <> 0 Then
            strSQL = strSQL & " AND userid_edit = " & userId
        End If

        If posId <> 0 Then
             strSQL = strSQL & " AND pos_id = " & posId
        End If

        strSQL = strSQL & " ) AS rpt1 INNER JOIN  user_index AS usr ON (rpt1.userId = usr.userid)"


        Try
            WriteToLogFile(strSQL)
            Return comm.ExecuteQuery(strSQL, Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetVoidReport - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetVoidReport")

    End Function


    '***************************************************************************
    '* GetVoidSummaryReport
    '**************************************************************************/
    Public Function GetVoidSummaryReport(ByVal userId As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, _
                                                        ByVal posId As Integer) As DataSet

        WriteToLogFile(CLASSNAME & " - In GetVoidSummaryReport")

        Dim comm As New Commands
        Dim strSQL As String
        Dim nextDay As Date = dateTo.AddDays(1)

        strSQL = "SELECT count(*) AS count, sum(total_amt)as sum FROM cust_invoice_index" & _
                        " WHERE lastupdate >= {0} AND lastupdate <= {1} AND status = {2}"

        strSQL = String.Format(strSQL, PreparedStatement(dateFrom), PreparedStatement(nextDay), PreparedStatement(DAInvoice.STATUS_CANCELLED))

        If userId <> 0 Then
            strSQL = strSQL & " AND userid_edit = " & userId
        End If

        If posId <> 0 Then
            strSQL = strSQL & " AND pos_id = " & posId
        End If

        Try
            WriteToLogFile(strSQL)
            Return comm.ExecuteQuery(strSQL, Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetVoidSummaryReport - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetVoidSummaryReport")

    End Function


    '***************************************************************************
    '* GetDailyCardDetails
    '**************************************************************************/
    Public Function GetDailyCardDetails(ByVal userId As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, _
                                            ByVal posId As Integer) As DataSet

        WriteToLogFile(CLASSNAME & " - In GetDailyCardDetails")

        Dim comm As New Commands
        Dim strSQL As String

        strSQL = "SELECT inv.pkid AS invoice_no, rpt.*" & _
                    " FROM acc_receipt_index rpt" & _
                    " INNER JOIN cust_invoice_index inv " & _
                    " ON inv.receipt_id = rpt.pkid " & _
                    " WHERE rpt.amount_card > 0 AND {1} >= {V1} AND {1} < {V2} "

        If userId <> 0 Then
            strSQL = strSQL & " AND userid_edit = " & userId
        End If

        If posId <> 0 Then
            strSQL = strSQL & " AND inv.pos_id = " & posId
        End If

        strSQL = strSQL.Replace("{T}", TABLENAME)
        strSQL = strSQL.Replace("{0}", TOTAL_AMT)
        strSQL = strSQL.Replace("{1}", TIMEISSUED)
        strSQL = strSQL.Replace("{V1}", PreparedStatement(dateFrom))
        strSQL = strSQL.Replace("{V2}", PreparedStatement(dateTo))


        Try
            WriteToLogFile(strSQL)
            Return comm.ExecuteQuery(strSQL, Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetDailyCardDetails - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetDailyCardDetails")

    End Function


    '***************************************************************************
    '* GetSummaryStockSold
    '**************************************************************************/
    Public Function GetSummaryStockSold(ByVal userId As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, _
                                            ByVal posId As Integer) As DataSet

        WriteToLogFile(CLASSNAME & " - In GetSummaryStockSold")

        Dim comm As New Commands
        Dim strSQL As String
        'Dim nextDay As Date = dateFrom.AddDays(1)

        strSQL = "SELECT iitm.item_code, SUM(iitm.total_quantity) AS total_quantity, SUM(iitm.total_quantity*iitm.unit_price_quoted) AS total FROM cust_invoice_index AS iidx, cust_invoice_item AS iitm " & _
                   " WHERE iidx.pkid = iitm.invoice_id AND iidx.time_issued >= {0} AND iidx.time_issued <= {1} " & _
                   " GROUP BY iitm.item_code"

        strSQL = String.Format(strSQL, PreparedStatement(dateFrom.ToString("yyyy-MM-dd HH:mm:ss")), PreparedStatement(dateTo.ToString("yyyy-MM-dd HH:mm:ss")))

        If userId <> 0 Then
            strSQL = strSQL & " AND iidx.userid_edit = " & userId
        End If

        If posId <> 0 Then
            strSQL = strSQL & " AND pos_id = " & posId
        End If

        Try
            WriteToLogFile(strSQL)
            Return comm.ExecuteQuery(strSQL, Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetSummaryStockSold - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetSummaryStockSold")

    End Function


    '***************************************************************************
    '* GetSummaryStockSoldVoid
    '**************************************************************************/
    Public Function GetSummaryStockSoldVoid(ByVal userId As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, _
                                            ByVal posId As Integer) As DataSet

        WriteToLogFile(CLASSNAME & " - In GetSummaryStockSoldVoid")

        Dim comm As New Commands
        Dim strSQL As String
        'Dim nextDay As Date = dateFrom.AddDays(1)

        strSQL = "SELECT item_code, SUM(iitm.total_quantity) * -1 AS total_quantity, SUM(iitm.total_quantity*iitm.unit_price_quoted) * -1 AS total FROM cust_invoice_index AS iidx, cust_invoice_item AS iitm " & _
                   " WHERE iidx.pkid = iitm.invoice_id AND iidx.lastupdate >= {0} AND iidx.lastupdate <= {1} " & _
                   " AND iidx.status = '" & DAInvoice.STATUS_CANCELLED & "'" & _
                   " GROUP BY iitm.item_code"

        strSQL = String.Format(strSQL, PreparedStatement(dateFrom.ToString("yyyy-MM-dd HH:mm:ss")), PreparedStatement(dateTo.ToString("yyyy-MM-dd HH:mm:ss")))

        If userId <> 0 Then
            strSQL = strSQL & " AND iidx.userid_edit = " & userId
        End If

        If posId <> 0 Then
            strSQL = strSQL & " AND pos_id = " & posId
        End If

        Try
            WriteToLogFile(strSQL)
            Return comm.ExecuteQuery(strSQL, Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetSummaryStockSoldVoid - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetSummaryStockSoldVoid")

    End Function

    '***************************************************************************
    '* CreateSalesTransaction
    '**************************************************************************/
    Public Function CreateSalesTransaction(ByVal invoiceObj As DAInvoiceObject, _
                                            ByVal receiptObj As DAOfficialReceiptObject, _
                                            ByVal posId As Integer) As DataSet

        WriteToLogFile(CLASSNAME & " - In CreateSalesTransaction")

        Dim guid As String = System.Guid.NewGuid.ToString
        Dim comm As New Commands
        Dim daReceipt As New DAOfficialReceipt
        Dim txQueueObj As New DATCTxQueueObject

        Try
            comm.BeginTransaction()

            Create(invoiceObj)
            'InsertTCTxQueue(obj, guid, "", DATCTxQueue.CATEGORY_INDEX, DAInvoice.TABLENAME, obj.mTotalAmt, DATCTxQueue.MODE_ADD)

            daReceipt.Create(receiptObj)

            comm.Commit()

        Catch ex As Exception
            comm.Rollback()
            Throw New Exception(CLASSNAME & " - CreateSalesTransaction - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave CreateSalesTransaction")

    End Function


End Class

