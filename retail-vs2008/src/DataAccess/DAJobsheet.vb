Imports Utils.General

Public Class DAJobsheet

    'Constants for Table field mappings
    Private Const CLASSNAME = "DAJobsheetIndex"

    Public Const PKID = "pkid"
    Public Const STMT_NO = "stmt_no"
    Public Const BRANCH = "branch"
    Public Const LOCATION = "location"
    Public Const PC_CENTER = "pc_center"
    Public Const GUID = "guid"
    Public Const TXN_TYPE = "txn_type"
    Public Const DISPLAY_FORMAT = "display_format"
    Public Const DOC_TYPE = "doc_type"
    Public Const REFERENCE_NO = "reference_no"
    Public Const REMARKS = "remarks"
    Public Const DESCRIPTION = "description"
    Public Const SALES_TXN_ID = "sales_txn_id"
    Public Const TIME_CREATED = "time_created"
    Public Const TIME_COMPLETE = "time_complete"
    Public Const USERID_SUPERVISOR = "userid_supervisor"
    Public Const USERID_TECHNICIAN = "userid_technician"
    Public Const PAYMENT_TERMS_ID = "payment_terms_id"
    Public Const CURRENCY = "currency"
    Public Const AMOUNT_TOTAL = "amount_total"
    Public Const AMOUNT_OUTSTANDING = "amount_outstanding"
    Public Const AMOUNT_OUTSTANDING_BF_PDC = "amount_outstanding_bf_pdc"
    Public Const CURRENCY2 = "currency2"
    Public Const AMOUNT_TOTAL2 = "amount_total2"
    Public Const AMOUNT_OUTSTANDING2 = "amount_outstanding2"
    Public Const AMOUNT_OUTSTANDING_BF_PDC2 = "amount_outstanding_bf_pdc2"
    Public Const ENTITY_TABLE = "entity_table"
    Public Const ENTITY_KEY = "entity_key"
    Public Const ENTITY_NAME = "entity_name"
    Public Const ENTITY_TYPE = "entity_type"
    Public Const IDENTITY_NUMBER = "identity_number"
    Public Const ENTITY_CONTACT_PERSON = "entity_contact_person"
    Public Const FOREIGN_TABLE = "foreign_table"
    Public Const FOREIGN_KEY = "foreign_key"
    Public Const FOREIGN_TEXT = "foreign_text"
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
    Public Const CODE_DEPT = "code_dept"
    Public Const CODE_PROJECT = "code_project"
    Public Const CODE_SUPPLIER = "code_supplier"
    Public Const SALES_ID = "sales_id"
    Public Const TRACKING_NO = "tracking_no"
    Public Const TAX_AMOUNT = "tax_amount"
    Public Const TAX_TYPE = "tax_type"
    Public Const JS_TYPE = "js_type"
    Public Const STATE = "state"
    Public Const STATUS = "status"
    Public Const LAST_UPDATE = "last_update"
    Public Const USERID_EDIT = "userid_edit"
    Public Const MILEAGE_LATEST = "mileage_latest"
    Public Const MILEAGE_NEXT = "mileage_next"
    Public Const REPAIR_LAST = "repair_last"
    Public Const REPAIR_NEXT = "repair_next"
    Public Const CLAIM_AMOUNT = "claim_amount"
    Public Const TIME_ACCIDENT = "time_accident"
    Public Const POLICY_NUMBER = "policy_number"
    Public Const COLLECTION_METHOD = "collection_method"
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
    Public Const PICKUP_NAME = "pickup_name"
    Public Const PICKUP_HANDPHONE = "pickup_handphone"
    Public Const PICKUP_PHONE1 = "pickup_phone1"
    Public Const PICKUP_PHONE2 = "pickup_phone2"
    Public Const PICKUP_FAX = "pickup_fax"
    Public Const PICKUP_EMAIL = "pickup_email"
    Public Const PICKUP_COMPANY_NAME = "pickup_company_name"
    Public Const PICKUP_ADD1 = "pickup_add1"
    Public Const PICKUP_ADD2 = "pickup_add2"
    Public Const PICKUP_ADD3 = "pickup_add3"
    Public Const PICKUP_CITY = "pickup_city"
    Public Const PICKUP_ZIP = "pickup_zip"
    Public Const PICKUP_STATE = "pickup_state"
    Public Const PICKUP_COUNTRY = "pickup_country"
    Public Const SYNCHRO_KEY = "synchro_key"

    Public Const DF_DEFAULT = ""
    Public Const DF_TRADING_PC = "TRADING_PC"

    Public Const STATE_CREATED = "CREATED"
    Public Const STATE_PENDING = "PENDING"
    Public Const STATE_INVOICE = "INVOICE"
    Public Const STATE_CLOSED = "CLOSED"

    Public Const STATUS_ACTIVE = "act"
    Public Const STATUS_INACTIVE = "ina"
    Public Const STATUS_CANCELLED = "cxl"

    Public Const TABLENAME = "cust_jobsheet_index"
    Public Const NO_OF_COLUMNS As Integer = 110
    Public Const APP_NAME = "ThickClient-DataAccess"
    Public Const START_ID = 1001

    '***************************************************************************
    '* Create
    '**************************************************************************/
    Public Function Create(ByVal obj As DAJobsheetObject) As DAJobsheetObject

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
    Public Sub Update(ByVal obj As DAJobsheetObject)

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
            comm.ExecuteNonQueryTransaction(strSQL)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - Update - " & ex.Message)

        End Try

        WriteToLogFile(CLASSNAME & " - Leave Update")

    End Sub


    '***************************************************************************
    '* GetObject
    '**************************************************************************/
    Public Function GetObject(ByVal id As Long) As DAJobsheetObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DAJobsheetObject = Nothing
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
    Public Function GetObject(ByVal row As DataRow) As DAJobsheetObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DAJobsheetObject

        Try
            obj = New DAJobsheetObject
            obj.pkid = row(PKID)
            obj.stmtNo = row(STMT_NO)
            obj.branch = row(BRANCH)
            obj.location = row(LOCATION)
            obj.pcCenter = row(PC_CENTER)
            obj.guid = row(Guid)
            obj.txnType = row(TXN_TYPE)
            obj.displayFormat = row(DISPLAY_FORMAT)
            obj.docType = row(DOC_TYPE)
            obj.referenceNo = row(REFERENCE_NO)
            obj.remarks = row(REMARKS)
            obj.description = row(DESCRIPTION)
            obj.salesTxnId = row(SALES_TXN_ID)
            obj.timeCreated = row(TIME_CREATED)
            obj.timeComplete = row(TIME_COMPLETE)
            obj.useridSupervisor = row(USERID_SUPERVISOR)
            obj.useridTechnician = row(USERID_TECHNICIAN)
            obj.paymentTermsId = row(PAYMENT_TERMS_ID)
            obj.currency = row(CURRENCY)
            obj.amountTotal = row(AMOUNT_TOTAL)
            obj.amountOutstanding = row(AMOUNT_OUTSTANDING)
            obj.amountOutstandingBfPdc = row(AMOUNT_OUTSTANDING_BF_PDC)
            obj.currency2 = row(CURRENCY2)
            obj.amountTotal2 = row(AMOUNT_TOTAL2)
            obj.amountOutstanding2 = row(AMOUNT_OUTSTANDING2)
            obj.amountOutstandingBfPdc2 = row(AMOUNT_OUTSTANDING_BF_PDC2)
            obj.entityTable = row(ENTITY_TABLE)
            obj.entityKey = row(ENTITY_KEY)
            obj.entityName = row(ENTITY_NAME)
            obj.entityType = row(ENTITY_TYPE)
            obj.identityNumber = row(IDENTITY_NUMBER)
            obj.entityContactPerson = row(ENTITY_CONTACT_PERSON)
            obj.foreignTable = row(FOREIGN_TABLE)
            obj.foreignKey = row(FOREIGN_KEY)
            obj.foreignText = row(FOREIGN_TEXT)
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
            obj.codeDept = row(CODE_DEPT)
            obj.codeProject = row(CODE_PROJECT)
            obj.codeSupplier = row(CODE_SUPPLIER)
            obj.salesId = row(SALES_ID)
            obj.trackingNo = row(TRACKING_NO)
            obj.taxAmount = row(TAX_AMOUNT)
            obj.taxType = row(TAX_TYPE)
            obj.jsType = row(JS_TYPE)
            obj.state = row(STATE)
            obj.status = row(STATUS)
            obj.lastUpdate = row(LAST_UPDATE)
            obj.useridEdit = row(USERID_EDIT)
            obj.mileageLatest = row(MILEAGE_LATEST)
            obj.mileageNext = row(MILEAGE_NEXT)
            obj.repairLast = row(REPAIR_LAST)
            obj.repairNext = row(REPAIR_NEXT)
            obj.claimAmount = row(CLAIM_AMOUNT)
            obj.accidentDate = row(TIME_ACCIDENT)
            obj.policyNumber = row(POLICY_NUMBER)
            obj.collectionMethod = row(COLLECTION_METHOD)
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
            obj.pickupName = row(PICKUP_NAME)
            obj.pickupHandphone = row(PICKUP_HANDPHONE)
            obj.pickupPhone1 = row(PICKUP_PHONE1)
            obj.pickupPhone2 = row(PICKUP_PHONE2)
            obj.pickupFax = row(PICKUP_FAX)
            obj.pickupEmail = row(PICKUP_EMAIL)
            obj.pickupCompanyName = row(PICKUP_COMPANY_NAME)
            obj.pickupAdd1 = row(PICKUP_ADD1)
            obj.pickupAdd2 = row(PICKUP_ADD2)
            obj.pickupAdd3 = row(PICKUP_ADD3)
            obj.pickupCity = row(PICKUP_CITY)
            obj.pickupZip = row(PICKUP_ZIP)
            obj.pickupState = row(PICKUP_STATE)
            obj.pickupCountry = row(PICKUP_COUNTRY)
            obj.synchroKey = row(SYNCHRO_KEY)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetObject - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetObject")

        Return obj

    End Function

    Public Function ReplaceStatement(ByVal strSQL As String, ByVal obj As DAJobsheetObject) As String

        strSQL = strSQL.Replace("{T}", TABLENAME)

        strSQL = strSQL.Replace("{1}", PKID)
        strSQL = strSQL.Replace("{2}", STMT_NO)
        strSQL = strSQL.Replace("{3}", BRANCH)
        strSQL = strSQL.Replace("{4}", LOCATION)
        strSQL = strSQL.Replace("{5}", PC_CENTER)
        strSQL = strSQL.Replace("{6}", GUID)
        strSQL = strSQL.Replace("{7}", TXN_TYPE)
        strSQL = strSQL.Replace("{8}", DISPLAY_FORMAT)
        strSQL = strSQL.Replace("{9}", DOC_TYPE)
        strSQL = strSQL.Replace("{10}", REFERENCE_NO)
        strSQL = strSQL.Replace("{11}", REMARKS)
        strSQL = strSQL.Replace("{12}", DESCRIPTION)
        strSQL = strSQL.Replace("{13}", SALES_TXN_ID)
        strSQL = strSQL.Replace("{14}", TIME_CREATED)
        strSQL = strSQL.Replace("{15}", TIME_COMPLETE)
        strSQL = strSQL.Replace("{16}", USERID_SUPERVISOR)
        strSQL = strSQL.Replace("{17}", USERID_TECHNICIAN)
        strSQL = strSQL.Replace("{18}", PAYMENT_TERMS_ID)
        strSQL = strSQL.Replace("{19}", CURRENCY)
        strSQL = strSQL.Replace("{20}", AMOUNT_TOTAL)
        strSQL = strSQL.Replace("{21}", AMOUNT_OUTSTANDING)
        strSQL = strSQL.Replace("{22}", AMOUNT_OUTSTANDING_BF_PDC)
        strSQL = strSQL.Replace("{23}", CURRENCY2)
        strSQL = strSQL.Replace("{24}", AMOUNT_TOTAL2)
        strSQL = strSQL.Replace("{25}", AMOUNT_OUTSTANDING2)
        strSQL = strSQL.Replace("{26}", AMOUNT_OUTSTANDING_BF_PDC2)
        strSQL = strSQL.Replace("{27}", ENTITY_TABLE)
        strSQL = strSQL.Replace("{28}", ENTITY_KEY)
        strSQL = strSQL.Replace("{29}", ENTITY_NAME)
        strSQL = strSQL.Replace("{30}", ENTITY_TYPE)
        strSQL = strSQL.Replace("{31}", IDENTITY_NUMBER)
        strSQL = strSQL.Replace("{32}", ENTITY_CONTACT_PERSON)
        strSQL = strSQL.Replace("{33}", FOREIGN_TABLE)
        strSQL = strSQL.Replace("{34}", FOREIGN_KEY)
        strSQL = strSQL.Replace("{35}", FOREIGN_TEXT)
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
        strSQL = strSQL.Replace("{63}", CODE_DEPT)
        strSQL = strSQL.Replace("{64}", CODE_PROJECT)
        strSQL = strSQL.Replace("{65}", CODE_SUPPLIER)
        strSQL = strSQL.Replace("{66}", SALES_ID)
        strSQL = strSQL.Replace("{67}", TRACKING_NO)
        strSQL = strSQL.Replace("{68}", TAX_AMOUNT)
        strSQL = strSQL.Replace("{69}", TAX_TYPE)
        strSQL = strSQL.Replace("{70}", JS_TYPE)
        strSQL = strSQL.Replace("{71}", STATE)
        strSQL = strSQL.Replace("{72}", STATUS)
        strSQL = strSQL.Replace("{73}", LAST_UPDATE)
        strSQL = strSQL.Replace("{74}", USERID_EDIT)
        strSQL = strSQL.Replace("{75}", MILEAGE_LATEST)
        strSQL = strSQL.Replace("{76}", MILEAGE_NEXT)
        strSQL = strSQL.Replace("{77}", REPAIR_LAST)
        strSQL = strSQL.Replace("{78}", REPAIR_NEXT)
        strSQL = strSQL.Replace("{79}", CLAIM_AMOUNT)
        strSQL = strSQL.Replace("{80}", TIME_ACCIDENT)
        strSQL = strSQL.Replace("{81}", POLICY_NUMBER)
        strSQL = strSQL.Replace("{82}", COLLECTION_METHOD)
        strSQL = strSQL.Replace("{83}", INCOTERMS)
        strSQL = strSQL.Replace("{84}", PERMIT_NO)
        strSQL = strSQL.Replace("{85}", PERMIT_DOC1)
        strSQL = strSQL.Replace("{86}", PERMIT_DOC2)
        strSQL = strSQL.Replace("{87}", PERMIT_DOC3)
        strSQL = strSQL.Replace("{88}", TXN_DOC1)
        strSQL = strSQL.Replace("{89}", TXN_DOC2)
        strSQL = strSQL.Replace("{90}", TXN_DOC3)
        strSQL = strSQL.Replace("{91}", TRANSPORT_DOC1)
        strSQL = strSQL.Replace("{92}", TRANSPORT_DOC2)
        strSQL = strSQL.Replace("{93}", TRANSPORT_DOC3)
        strSQL = strSQL.Replace("{94}", TRANSPORT_DATE)
        strSQL = strSQL.Replace("{95}", TRADERS_REMARKS)
        strSQL = strSQL.Replace("{96}", PICKUP_NAME)
        strSQL = strSQL.Replace("{97}", PICKUP_HANDPHONE)
        strSQL = strSQL.Replace("{98}", PICKUP_PHONE1)
        strSQL = strSQL.Replace("{99}", PICKUP_PHONE2)
        strSQL = strSQL.Replace("{100}", PICKUP_FAX)
        strSQL = strSQL.Replace("{101}", PICKUP_EMAIL)
        strSQL = strSQL.Replace("{102}", PICKUP_COMPANY_NAME)
        strSQL = strSQL.Replace("{103}", PICKUP_ADD1)
        strSQL = strSQL.Replace("{104}", PICKUP_ADD2)
        strSQL = strSQL.Replace("{105}", PICKUP_ADD3)
        strSQL = strSQL.Replace("{106}", PICKUP_CITY)
        strSQL = strSQL.Replace("{107}", PICKUP_ZIP)
        strSQL = strSQL.Replace("{108}", PICKUP_STATE)
        strSQL = strSQL.Replace("{109}", PICKUP_COUNTRY)
        strSQL = strSQL.Replace("{110}", SYNCHRO_KEY)


        strSQL = strSQL.Replace("{V1}", PreparedStatement(obj.pkid))
        strSQL = strSQL.Replace("{V2}", PreparedStatement(obj.stmtNo))
        strSQL = strSQL.Replace("{V3}", PreparedStatement(obj.branch))
        strSQL = strSQL.Replace("{V4}", PreparedStatement(obj.location))
        strSQL = strSQL.Replace("{V5}", PreparedStatement(obj.pcCenter))
        strSQL = strSQL.Replace("{V6}", PreparedStatement(obj.guid))
        strSQL = strSQL.Replace("{V7}", PreparedStatement(obj.txnType))
        strSQL = strSQL.Replace("{V8}", PreparedStatement(obj.displayFormat))
        strSQL = strSQL.Replace("{V9}", PreparedStatement(obj.docType))
        strSQL = strSQL.Replace("{V10}", PreparedStatement(obj.referenceNo))
        strSQL = strSQL.Replace("{V11}", PreparedStatement(obj.remarks))
        strSQL = strSQL.Replace("{V12}", PreparedStatement(obj.description))
        strSQL = strSQL.Replace("{V13}", PreparedStatement(obj.salesTxnId))
        strSQL = strSQL.Replace("{V14}", PreparedStatement(obj.timeCreated))
        strSQL = strSQL.Replace("{V15}", PreparedStatement(obj.timeComplete))
        strSQL = strSQL.Replace("{V16}", PreparedStatement(obj.useridSupervisor))
        strSQL = strSQL.Replace("{V17}", PreparedStatement(obj.useridTechnician))
        strSQL = strSQL.Replace("{V18}", PreparedStatement(obj.paymentTermsId))
        strSQL = strSQL.Replace("{V19}", PreparedStatement(obj.currency))
        strSQL = strSQL.Replace("{V20}", PreparedStatement(obj.amountTotal))
        strSQL = strSQL.Replace("{V21}", PreparedStatement(obj.amountOutstanding))
        strSQL = strSQL.Replace("{V22}", PreparedStatement(obj.amountOutstandingBfPdc))
        strSQL = strSQL.Replace("{V23}", PreparedStatement(obj.currency2))
        strSQL = strSQL.Replace("{V24}", PreparedStatement(obj.amountTotal2))
        strSQL = strSQL.Replace("{V25}", PreparedStatement(obj.amountOutstanding2))
        strSQL = strSQL.Replace("{V26}", PreparedStatement(obj.amountOutstandingBfPdc2))
        strSQL = strSQL.Replace("{V27}", PreparedStatement(obj.entityTable))
        strSQL = strSQL.Replace("{V28}", PreparedStatement(obj.entityKey))
        strSQL = strSQL.Replace("{V29}", PreparedStatement(obj.entityName))
        strSQL = strSQL.Replace("{V30}", PreparedStatement(obj.entityType))
        strSQL = strSQL.Replace("{V31}", PreparedStatement(obj.identityNumber))
        strSQL = strSQL.Replace("{V32}", PreparedStatement(obj.entityContactPerson))
        strSQL = strSQL.Replace("{V33}", PreparedStatement(obj.foreignTable))
        strSQL = strSQL.Replace("{V34}", PreparedStatement(obj.foreignKey))
        strSQL = strSQL.Replace("{V35}", PreparedStatement(obj.foreignText))
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
        strSQL = strSQL.Replace("{V63}", PreparedStatement(obj.codeDept))
        strSQL = strSQL.Replace("{V64}", PreparedStatement(obj.codeProject))
        strSQL = strSQL.Replace("{V65}", PreparedStatement(obj.codeSupplier))
        strSQL = strSQL.Replace("{V66}", PreparedStatement(obj.salesId))
        strSQL = strSQL.Replace("{V67}", PreparedStatement(obj.trackingNo))
        strSQL = strSQL.Replace("{V68}", PreparedStatement(obj.taxAmount))
        strSQL = strSQL.Replace("{V69}", PreparedStatement(obj.taxType))
        strSQL = strSQL.Replace("{V70}", PreparedStatement(obj.jsType))
        strSQL = strSQL.Replace("{V71}", PreparedStatement(obj.state))
        strSQL = strSQL.Replace("{V72}", PreparedStatement(obj.status))
        strSQL = strSQL.Replace("{V73}", PreparedStatement(obj.lastUpdate))
        strSQL = strSQL.Replace("{V74}", PreparedStatement(obj.useridEdit))
        strSQL = strSQL.Replace("{V75}", PreparedStatement(obj.mileageLatest))
        strSQL = strSQL.Replace("{V76}", PreparedStatement(obj.mileageNext))
        strSQL = strSQL.Replace("{V77}", PreparedStatement(obj.repairLast))
        strSQL = strSQL.Replace("{V78}", PreparedStatement(obj.repairNext))
        strSQL = strSQL.Replace("{V79}", PreparedStatement(obj.claimAmount))
        strSQL = strSQL.Replace("{V80}", PreparedStatement(obj.accidentDate))
        strSQL = strSQL.Replace("{V81}", PreparedStatement(obj.policyNumber))
        strSQL = strSQL.Replace("{V82}", PreparedStatement(obj.collectionMethod))
        strSQL = strSQL.Replace("{V83}", PreparedStatement(obj.incoterms))
        strSQL = strSQL.Replace("{V84}", PreparedStatement(obj.permitNo))
        strSQL = strSQL.Replace("{V85}", PreparedStatement(obj.permitDoc1))
        strSQL = strSQL.Replace("{V86}", PreparedStatement(obj.permitDoc2))
        strSQL = strSQL.Replace("{V87}", PreparedStatement(obj.permitDoc3))
        strSQL = strSQL.Replace("{V88}", PreparedStatement(obj.txnDoc1))
        strSQL = strSQL.Replace("{V89}", PreparedStatement(obj.txnDoc2))
        strSQL = strSQL.Replace("{V90}", PreparedStatement(obj.txnDoc3))
        strSQL = strSQL.Replace("{V91}", PreparedStatement(obj.transportDoc1))
        strSQL = strSQL.Replace("{V92}", PreparedStatement(obj.transportDoc2))
        strSQL = strSQL.Replace("{V93}", PreparedStatement(obj.transportDoc3))
        strSQL = strSQL.Replace("{V94}", PreparedStatement(obj.transportDate))
        strSQL = strSQL.Replace("{V95}", PreparedStatement(obj.tradersRemarks))
        strSQL = strSQL.Replace("{V96}", PreparedStatement(obj.pickupName))
        strSQL = strSQL.Replace("{V97}", PreparedStatement(obj.pickupHandphone))
        strSQL = strSQL.Replace("{V98}", PreparedStatement(obj.pickupPhone1))
        strSQL = strSQL.Replace("{V99}", PreparedStatement(obj.pickupPhone2))
        strSQL = strSQL.Replace("{V100}", PreparedStatement(obj.pickupFax))
        strSQL = strSQL.Replace("{V101}", PreparedStatement(obj.pickupEmail))
        strSQL = strSQL.Replace("{V102}", PreparedStatement(obj.pickupCompanyName))
        strSQL = strSQL.Replace("{V103}", PreparedStatement(obj.pickupAdd1))
        strSQL = strSQL.Replace("{V104}", PreparedStatement(obj.pickupAdd2))
        strSQL = strSQL.Replace("{V105}", PreparedStatement(obj.pickupAdd3))
        strSQL = strSQL.Replace("{V106}", PreparedStatement(obj.pickupCity))
        strSQL = strSQL.Replace("{V107}", PreparedStatement(obj.pickupZip))
        strSQL = strSQL.Replace("{V108}", PreparedStatement(obj.pickupState))
        strSQL = strSQL.Replace("{V109}", PreparedStatement(obj.pickupCountry))
        strSQL = strSQL.Replace("{V110}", PreparedStatement(obj.synchroKey))

        Return strSQL

    End Function


    '***************************************************************************
    '* GetNextID
    '**************************************************************************/
    Public Function GetNextID() As Long
        Return DAAppTableCounter.GetNextPKID(PKID, TABLENAME, "POS", START_ID)
    End Function

End Class

