Imports Utils.General

Public Class DABranch

    'Constants for Table field mappings
    Private Const CLASSNAME = "DABranch"

    Public Const PKID = "pkid"
    Public Const CODE = "code"
    Public Const REG_NO = "reg_no"
    Public Const NAME = "name"
    Public Const DESCRIPTION = "description"
    Public Const ADDR1 = "addr1"
    Public Const ADDR2 = "addr2"
    Public Const ADDR3 = "addr3"
    Public Const ZIP = "zip"
    Public Const STATE = "state"
    Public Const COUNTRYCODE = "countrycode"
    Public Const PHONENO = "phone_no"
    Public Const FAXNO = "fax_no"
    Public Const WEB_URL = "web_url"
    Public Const ACC_PCCENTER_ID = "acc_pccenterid"
    Public Const INV_LOCATION_ID = "inv_locationid"
    Public Const STATUS = "status"
    Public Const LASTUPDATE = "lastupdate"
    Public Const USERID_EDIT = "userid_edit"
    Public Const CASHBOOK_CASH = "cashbook_cash"
    Public Const CASHBOOK_CARD = "cashbook_card"
    Public Const CASHBOOK_CHEQUE = "cashbook_cheque"
    Public Const CASHBOOK_PD_CHEQUE = "cashbook_pd_cheque"
    Public Const CASHBOOK_COUPON = "cashbook_coupon"
    Public Const CASHBOOK_OTHER = "cashbook_other"
    Public Const CASHBOOK_PAYMENT = "cashbook_payment"
    Public Const LOGO_URL = "logo_url"
    Public Const CURRENCY = "currency"
    Public Const PRICING = "pricing"
    Public Const HOTLINES = "hotlines"
    Public Const DEFAULT_VISA_RATE = "default_visa_rate"
    Public Const DEFAULT_MASTER_RATE = "default_master_rate"
    Public Const DEFAULT_AMEX_RATE = "default_amex_rate"
    Public Const DEFAULT_DINER_RATE = "default_diner_rate"
    Public Const DEFAULT_CARD1_RATE = "default_card1_rate"
    Public Const DEFAULT_CARD2_RATE = "default_card2_rate"
    Public Const DEFAULT_CARD3_RATE = "default_card3_rate"
    Public Const DEFAULT_OTHER_RATE = "default_other_rate"
    Public Const FORMAT_INVOICE_HEADER_TEXT = "format_invoice_header_text"
    Public Const FORMAT_INVOICE_FOOTER_TEXT = "format_invoice_footer_text"
    Public Const FORMAT_INVOICE_ENTITY_ADDRESS = "format_invoice_entity_address"
    Public Const FORMAT_INVOICE_ROW = "format_invoice_row"
    Public Const FORMAT_INVOICE_TYPE = "format_invoice_type"
    Public Const FORMAT_CASHSALE_HEADER_TEXT = "format_cashsale_header_text"
    Public Const FORMAT_CASHSALE_FOOTER_TEXT = "format_cashsale_footer_text"
    Public Const FORMAT_CASHSALE_ENTITY_ADDRESS = "format_cashsale_entity_address"
    Public Const FORMAT_CASHSALE_ROW = "format_cashsale_row"
    Public Const FORMAT_CASHSALE_TYPE = "format_cashsale_type"
    Public Const FORMAT_RECEIPT_HEADER_TEXT = "format_receipt_header_text"
    Public Const FORMAT_RECEIPT_FOOTER_TEXT = "format_receipt_footer_text"
    Public Const FORMAT_RECEIPT_ENTITY_ADDRESS = "format_receipt_entity_address"
    Public Const FORMAT_RECEIPT_ROW = "format_receipt_row"
    Public Const FORMAT_RECEIPT_TYPE = "format_receipt_type"
    Public Const FORMAT_PURCHASE_ORDER_HEADER_TEXT = "format_purchase_order_header_text"
    Public Const FORMAT_PURCHASE_ORDER_FOOTER_TEXT = "format_purchase_order_footer_text"
    Public Const FORMAT_PURCHASE_ORDER_ROW = "format_purchase_order_row"
    Public Const FORMAT_PURCHASE_ORDER_TYPE = "format_purchase_order_type"
    Public Const FORMAT_SALARY_SLIP_HEADER_TEXT = "format_salary_slip_header_text"
    Public Const FORMAT_SALARY_SLIP_FOOTER_TEXT = "format_salary_slip_footer_text"
    Public Const FORMAT_SALARY_SLIP_ROW = "format_salary_slip_row"
    Public Const FORMAT_SALARY_SLIP_TYPE = "format_salary_slip_type"
    Public Const FORMAT_PAYMENT_VOUCHER_HEADER_TEXT = "format_payment_voucher_header_text"
    Public Const FORMAT_PAYMENT_VOUCHER_FOOTER_TEXT = "format_payment_voucher_footer_text"
    Public Const FORMAT_PAYMENT_VOUCHER_ROW = "format_payment_voucher_row"
    Public Const FORMAT_PAYMENT_VOUCHER_TYPE = "format_payment_voucher_type"
    Public Const FORMAT_CREDIT_MEMO_HEADER_TEXT = "format_credit_memo_header_text"
    Public Const FORMAT_CREDIT_MEMO_FOOTER_TEXT = "format_credit_memo_footer_text"
    Public Const FORMAT_CREDIT_MEMO_ROW = "format_credit_memo_row"
    Public Const FORMAT_CREDIT_MEMO_TYPE = "format_credit_memo_type"
    Public Const DEFAULT_RMA_LOCATION_CUST = "default_rma_location_cust"
    Public Const DEFAULT_RMA_LOCATION_SUPP = "default_rma_location_supp"
    Public Const DEFAULT_RMA_LOCATION_HQ = "default_rma_location_hq"
    Public Const DEFAULT_RMA_LOCATION_BRANCH = "default_rma_location_branch"
    Public Const MANAGER_PASSWORD01 = "manager_password01"
    Public Const MANAGER_PASSWORD02 = "manager_password02"
    Public Const MANAGER_PASSWORD03 = "manager_password03"
    Public Const MANAGER_PASSWORD04 = "manager_password04"
    Public Const MANAGER_PASSWORD05 = "manager_password05"
    Public Const MANAGER_PASSWORD06 = "manager_password06"
    Public Const MANAGER_PASSWORD07 = "manager_password07"
    Public Const MANAGER_PASSWORD08 = "manager_password08"
    Public Const MANAGER_PASSWORD09 = "manager_password09"
    Public Const TELEPHONE_DEVELOPER = "telephone_developer"
    Public Const TELEPHONE_SYSADMIN = "telephone_sysadmin"
    Public Const TELEPHONE_CLERK = "telephone_clerk"
    Public Const TELEPHONE_ADMIN = "telephone_admin"
    Public Const TELEPHONE_MANAGER = "telephone_manager"
    Public Const TELEPHONE_SALES = "telephone_sales"
    Public Const TELEPHONE_TECH_SUPPORT = "telephone_tech_support"
    Public Const TELEPHONE_DIRECTOR = "telephone_director"
    Public Const MOBILEPHONE_DEVELOPER = "mobilephone_developer"
    Public Const MOBILEPHONE_SYSADMIN = "mobilephone_sysadmin"
    Public Const MOBILEPHONE_CLERK = "mobilephone_clerk"
    Public Const MOBILEPHONE_ADMIN = "mobilephone_admin"
    Public Const MOBILEPHONE_MANAGER = "mobilephone_manager"
    Public Const MOBILEPHONE_SALES = "mobilephone_sales"
    Public Const MOBILEPHONE_TECH_SUPPORT = "mobilephone_tech_support"
    Public Const MOBILEPHONE_DIRECTOR = "mobilephone_director"
    Public Const EMAIL_SYSTEM = "email_system"
    Public Const EMAIL_DEVELOPER = "email_developer"
    Public Const EMAIL_SYSADMIN = "email_sysadmin"
    Public Const EMAIL_CLERK = "email_clerk"
    Public Const EMAIL_ADMIN = "email_admin"
    Public Const EMAIL_MANAGER = "email_manager"
    Public Const EMAIL_SALES = "email_sales"
    Public Const EMAIL_TECH_SUPPORT = "email_tech_support"
    Public Const EMAIL_DIRECTOR = "email_director"
    Public Const CUSTOMER_ID = "customer_id"
    Public Const SUPPLIER_ID = "supplier_id"
    Public Const LOYALTY_CARD_NO_PREFIX = "loyalty_card_no_prefix"
    Public Const LOYALTY_CARD_NO_POSTFIX = "loyalty_card_no_postfix"
    Public Const CRV_DAY_FROM = "crv_day_from"
    Public Const CRV_DAY_TO = "crv_day_to"
    Public Const FORMAT_PROFORMA_INVOICE_TYPE = "format_proforma_invoice_type"
    Public Const FORMAT_PROFORMA_INVOICE_FOOTER_TEXT = "format_proforma_invoice_footer_text"
    Public Const FORMAT_PROFORMA_INVOICE_HEADER_TEXT = "format_proforma_invoice_header_text"
    Public Const FORMAT_PROFORMA_INVOICE_ROW = "format_proforma_invoice_row"
    Public Const FORMAT_SERVICE_NOTE_TYPE = "format_service_note_type"
    Public Const FORMAT_SERVICE_NOTE_FOOTER_TEXT = "format_service_note_footer_text"
    Public Const FORMAT_SERVICE_NOTE_HEADER_TEXT = "format_service_note_header_text"
    Public Const FORMAT_SERVICE_NOTE_ROW = "format_service_note_row"
    Public Const FORMAT_PACKING_LIST_TYPE = "format_packing_list_type"
    Public Const FORMAT_PACKING_LIST_FOOTER_TEXT = "format_packing_list_footer_text"
    Public Const FORMAT_PACKING_LIST_HEADER_TEXT = "format_packing_list_header_text"
    Public Const FORMAT_PACKING_LIST_ROW = "format_packing_list_row"
    Public Const FORMAT_JOBSHEET_TYPE = "format_jobsheet_type"
    Public Const FORMAT_JOBSHEET_FOOTER_TEXT = "format_jobsheet_footer_text"
    Public Const FORMAT_JOBSHEET_HEADER_TEXT = "format_jobsheet_header_text"
    Public Const FORMAT_JOBSHEET_ROW = "format_jobsheet_row"
    Public Const FORMAT_GRN_TYPE = "format_grn_type"
    Public Const FORMAT_GRN_FOOTER_TEXT = "format_grn_footer_text"
    Public Const FORMAT_GRN_HEADER_TEXT = "format_grn_header_text"
    Public Const FORMAT_GRN_ROW = "format_grn_row"
    Public Const TAX_REG_NUMBER = "tax_reg_number"

    ' Constants for STATUS
    Public Const STATUS_ACTIVE = "active"
    Public Const STATUS_INACTIVE = "inactive"

    Public Const TABLENAME = "acc_branch_index"
    Public Const NO_OF_COLUMNS As Integer = 134
    Public Const APP_NAME = "ThickClient-DataAccess"

    '***************************************************************************
    '* Create
    '**************************************************************************/
    Public Function Create(ByVal obj As DABranchObject) As DABranchObject

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
    Public Sub Update(ByVal obj As DABranchObject)

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
    Public Function GetObject(ByVal id As Integer) As DABranchObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DABranchObject = Nothing
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
        strSQL = strSQL.Replace("{1}", NAME)

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
    Public Function GetObject(ByVal row As DataRow) As DABranchObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DABranchObject

        Try
            obj = New DABranchObject
            obj.pkid = row(PKID)
            obj.code = row(CODE)
            obj.regNo = row(REG_NO)
            obj.name = row(NAME)
            obj.description = row(DESCRIPTION)
            obj.addr1 = row(ADDR1)
            obj.addr2 = row(ADDR2)
            obj.addr3 = row(ADDR3)
            obj.zip = row(ZIP)
            obj.state = row(STATE)
            obj.countryCode = row(COUNTRYCODE)
            obj.phoneNo = row(PHONENO)
            obj.faxNo = row(FAXNO)
            obj.webUrl = row(WEB_URL)
            obj.accPCCenterId = row(ACC_PCCENTER_ID)
            obj.invLocationId = row(INV_LOCATION_ID)
            obj.status = row(STATUS)
            obj.lastUpdate = row(LASTUPDATE)
            obj.userIdUpdate = row(USERID_EDIT)
            obj.cashbookCash = row(CASHBOOK_CASH)
            obj.cashbookCard = row(CASHBOOK_CARD)
            obj.cashbookCheque = row(CASHBOOK_CHEQUE)
            obj.cashbookPDCheque = row(CASHBOOK_PD_CHEQUE)
            obj.cashbookCoupon = row(CASHBOOK_COUPON)
            obj.cashbookOther = row(CASHBOOK_OTHER)
            obj.cashbookPayment = row(CASHBOOK_PAYMENT)
            obj.logoURL = row(LOGO_URL)
            obj.currency = row(CURRENCY)
            obj.pricing = row(PRICING)
            obj.hotlines = row(HOTLINES)
            obj.defaultVisaRate = row(DEFAULT_VISA_RATE)
            obj.defaultMasterRate = row(DEFAULT_MASTER_RATE)
            obj.defaultAmexRate = row(DEFAULT_AMEX_RATE)
            obj.defaultDinerRate = row(DEFAULT_DINER_RATE)
            obj.defaultCard1Rate = row(DEFAULT_CARD1_RATE)
            obj.defaultCard2Rate = row(DEFAULT_CARD2_RATE)
            obj.defaultCard3Rate = row(DEFAULT_CARD3_RATE)
            obj.defaultOtherRate = row(DEFAULT_OTHER_RATE)
            obj.formatInvoiceHeaderText = row(FORMAT_INVOICE_HEADER_TEXT)
            obj.formatInvoiceFooterText = row(FORMAT_INVOICE_FOOTER_TEXT)
            obj.formatInvoiceEntityAddress = row(FORMAT_INVOICE_ENTITY_ADDRESS)
            obj.formatInvoiceRow = row(FORMAT_INVOICE_ROW)
            obj.formatInvoiceType = row(FORMAT_INVOICE_TYPE)
            obj.formatCashsaleHeaderText = row(FORMAT_CASHSALE_HEADER_TEXT)
            obj.formatCashsaleFooterText = row(FORMAT_CASHSALE_FOOTER_TEXT)
            obj.formatCashsaleEntityAddress = row(FORMAT_CASHSALE_ENTITY_ADDRESS)
            obj.formatCashsaleRow = row(FORMAT_CASHSALE_ROW)
            obj.formatCashsaleType = row(FORMAT_CASHSALE_TYPE)
            obj.formatReceiptHeaderText = row(FORMAT_RECEIPT_HEADER_TEXT)
            obj.formatReceiptFooterText = row(FORMAT_RECEIPT_FOOTER_TEXT)
            obj.formatReceiptEntityAddress = row(FORMAT_RECEIPT_ENTITY_ADDRESS)
            obj.formatReceiptRow = row(FORMAT_RECEIPT_ROW)
            obj.formatReceiptType = row(FORMAT_RECEIPT_TYPE)
            obj.formatPurchaseOrderHeaderText = row(FORMAT_PURCHASE_ORDER_HEADER_TEXT)
            obj.formatPurchaseOrderFooterText = row(FORMAT_PURCHASE_ORDER_FOOTER_TEXT)
            obj.formatPurchaseOrderRow = row(FORMAT_PURCHASE_ORDER_ROW)
            obj.formatPurchaseOrderType = row(FORMAT_PURCHASE_ORDER_TYPE)
            obj.formatSalarySlipHeaderText = row(FORMAT_SALARY_SLIP_HEADER_TEXT)
            obj.formatSalarySlipFooterText = row(FORMAT_SALARY_SLIP_FOOTER_TEXT)
            obj.formatSalarySlipRow = row(FORMAT_SALARY_SLIP_ROW)
            obj.formatSalarySlipType = row(FORMAT_SALARY_SLIP_TYPE)
            obj.formatPaymentVoucherHeaderText = row(FORMAT_PAYMENT_VOUCHER_HEADER_TEXT)
            obj.formatPaymentVoucherFooterText = row(FORMAT_PAYMENT_VOUCHER_FOOTER_TEXT)
            obj.formatPaymentVoucherRow = row(FORMAT_PAYMENT_VOUCHER_ROW)
            obj.formatPaymentVoucherType = row(FORMAT_PAYMENT_VOUCHER_TYPE)
            obj.formatCreditMemoHeaderText = row(FORMAT_CREDIT_MEMO_HEADER_TEXT)
            obj.formatCreditMemoFooterText = row(FORMAT_CREDIT_MEMO_FOOTER_TEXT)
            obj.formatCreditMemoRow = row(FORMAT_CREDIT_MEMO_ROW)
            obj.formatCreditMemoType = row(FORMAT_CREDIT_MEMO_TYPE)
            obj.defaultRmaLocationCust = row(DEFAULT_RMA_LOCATION_CUST)
            obj.defaultRmaLocationSupp = row(DEFAULT_RMA_LOCATION_SUPP)
            obj.defaultRmaLocationHq = row(DEFAULT_RMA_LOCATION_HQ)
            obj.defaultRmaLocationBranch = row(DEFAULT_RMA_LOCATION_BRANCH)
            obj.managerPassword01 = row(MANAGER_PASSWORD01)
            obj.managerPassword02 = row(MANAGER_PASSWORD02)
            obj.managerPassword03 = row(MANAGER_PASSWORD03)
            obj.managerPassword04 = row(MANAGER_PASSWORD04)
            obj.managerPassword05 = row(MANAGER_PASSWORD05)
            obj.managerPassword06 = row(MANAGER_PASSWORD06)
            obj.managerPassword07 = row(MANAGER_PASSWORD07)
            obj.managerPassword08 = row(MANAGER_PASSWORD08)
            obj.managerPassword09 = row(MANAGER_PASSWORD09)
            obj.telephoneDeveloper = row(TELEPHONE_DEVELOPER)
            obj.telephoneSysadmin = row(TELEPHONE_SYSADMIN)
            obj.telephoneClerk = row(TELEPHONE_CLERK)
            obj.telephoneAdmin = row(TELEPHONE_ADMIN)
            obj.telephoneManager = row(TELEPHONE_MANAGER)
            obj.telephoneSales = row(TELEPHONE_SALES)
            obj.telephoneTechSupport = row(TELEPHONE_TECH_SUPPORT)
            obj.telephoneDirector = row(TELEPHONE_DIRECTOR)
            obj.mobilephoneDeveloper = row(MOBILEPHONE_DEVELOPER)
            obj.mobilephoneSysadmin = row(MOBILEPHONE_SYSADMIN)
            obj.mobilephoneClerk = row(MOBILEPHONE_CLERK)
            obj.mobilephoneAdmin = row(MOBILEPHONE_ADMIN)
            obj.mobilephoneManager = row(MOBILEPHONE_MANAGER)
            obj.mobilephoneSales = row(MOBILEPHONE_SALES)
            obj.mobilephoneTechSupport = row(MOBILEPHONE_TECH_SUPPORT)
            obj.mobilephoneDirector = row(MOBILEPHONE_DIRECTOR)
            obj.emailSystem = row(EMAIL_SYSTEM)
            obj.emailDeveloper = row(EMAIL_DEVELOPER)
            obj.emailSysadmin = row(EMAIL_SYSADMIN)
            obj.emailClerk = row(EMAIL_CLERK)
            obj.emailAdmin = row(EMAIL_ADMIN)
            obj.emailManager = row(EMAIL_MANAGER)
            obj.emailSales = row(EMAIL_SALES)
            obj.emailTechSupport = row(EMAIL_TECH_SUPPORT)
            obj.emailDirector = row(EMAIL_DIRECTOR)
            obj.customerId = row(CUSTOMER_ID)
            obj.supplierId = row(SUPPLIER_ID)
            obj.loyaltyCardNoPrefix = row(LOYALTY_CARD_NO_PREFIX)
            obj.loyaltyCardNoPostfix = row(LOYALTY_CARD_NO_POSTFIX)
            obj.crvDayFrom = row(CRV_DAY_FROM)
            obj.crvDayTo = row(CRV_DAY_TO)
            obj.taxRegNumber = row(TAX_REG_NUMBER)
            obj.formatProformaInvoiceType = row(FORMAT_PROFORMA_INVOICE_TYPE)
            obj.formatProformaInvoiceFooterText = row(FORMAT_PROFORMA_INVOICE_FOOTER_TEXT)
            obj.formatProformaInvoiceHeaderText = row(FORMAT_PROFORMA_INVOICE_HEADER_TEXT)
            obj.formatProformaInvoiceRow = row(FORMAT_PROFORMA_INVOICE_ROW)
            obj.formatServiceNoteType = row(FORMAT_SERVICE_NOTE_TYPE)
            obj.formatServiceNoteFooterText = row(FORMAT_SERVICE_NOTE_FOOTER_TEXT)
            obj.formatServiceNoteHeaderText = row(FORMAT_SERVICE_NOTE_HEADER_TEXT)
            obj.formatServiceNoteRow = row(FORMAT_SERVICE_NOTE_ROW)
            obj.formatServiceNoteType = row(FORMAT_PACKING_LIST_TYPE)
            obj.formatServiceNoteFooterText = row(FORMAT_PACKING_LIST_FOOTER_TEXT)
            obj.formatServiceNoteHeaderText = row(FORMAT_PACKING_LIST_HEADER_TEXT)
            obj.formatServiceNoteRow = row(FORMAT_PACKING_LIST_ROW)
            obj.formatServiceNoteType = row(FORMAT_JOBSHEET_TYPE)
            obj.formatServiceNoteFooterText = row(FORMAT_JOBSHEET_FOOTER_TEXT)
            obj.formatServiceNoteHeaderText = row(FORMAT_JOBSHEET_HEADER_TEXT)
            obj.formatServiceNoteRow = row(FORMAT_JOBSHEET_ROW)
            obj.formatServiceNoteType = row(FORMAT_GRN_TYPE)
            obj.formatServiceNoteFooterText = row(FORMAT_GRN_FOOTER_TEXT)
            obj.formatServiceNoteHeaderText = row(FORMAT_GRN_HEADER_TEXT)
            obj.formatServiceNoteRow = row(FORMAT_GRN_ROW)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetObject - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetObject")

        Return obj

    End Function


    Public Function ReplaceStatement(ByVal strSQL As String, ByVal obj As DABranchObject) As String

        strSQL = strSQL.Replace("{T}", TABLENAME)
        strSQL = strSQL.Replace("{1}", PKID)
        strSQL = strSQL.Replace("{2}", CODE)
        strSQL = strSQL.Replace("{3}", REG_NO)
        strSQL = strSQL.Replace("{4}", NAME)
        strSQL = strSQL.Replace("{5}", DESCRIPTION)
        strSQL = strSQL.Replace("{6}", ADDR1)
        strSQL = strSQL.Replace("{7}", ADDR2)
        strSQL = strSQL.Replace("{8}", ADDR3)
        strSQL = strSQL.Replace("{9}", ZIP)
        strSQL = strSQL.Replace("{10}", STATE)
        strSQL = strSQL.Replace("{11}", COUNTRYCODE)
        strSQL = strSQL.Replace("{12}", PHONENO)
        strSQL = strSQL.Replace("{13}", FAXNO)
        strSQL = strSQL.Replace("{14}", WEB_URL)
        strSQL = strSQL.Replace("{15}", ACC_PCCENTER_ID)
        strSQL = strSQL.Replace("{16}", INV_LOCATION_ID)
        strSQL = strSQL.Replace("{17}", STATUS)
        strSQL = strSQL.Replace("{18}", LASTUPDATE)
        strSQL = strSQL.Replace("{19}", USERID_EDIT)
        strSQL = strSQL.Replace("{20}", CASHBOOK_CASH)
        strSQL = strSQL.Replace("{21}", CASHBOOK_CARD)
        strSQL = strSQL.Replace("{22}", CASHBOOK_CHEQUE)
        strSQL = strSQL.Replace("{23}", CASHBOOK_PD_CHEQUE)
        strSQL = strSQL.Replace("{24}", CASHBOOK_COUPON)
        strSQL = strSQL.Replace("{25}", CASHBOOK_OTHER)
        strSQL = strSQL.Replace("{26}", CASHBOOK_PAYMENT)
        strSQL = strSQL.Replace("{27}", LOGO_URL)
        strSQL = strSQL.Replace("{28}", CURRENCY)
        strSQL = strSQL.Replace("{29}", PRICING)
        strSQL = strSQL.Replace("{30}", HOTLINES)
        strSQL = strSQL.Replace("{31}", DEFAULT_VISA_RATE)
        strSQL = strSQL.Replace("{32}", DEFAULT_MASTER_RATE)
        strSQL = strSQL.Replace("{33}", DEFAULT_AMEX_RATE)
        strSQL = strSQL.Replace("{34}", DEFAULT_DINER_RATE)
        strSQL = strSQL.Replace("{35}", DEFAULT_CARD1_RATE)
        strSQL = strSQL.Replace("{36}", DEFAULT_CARD2_RATE)
        strSQL = strSQL.Replace("{37}", DEFAULT_CARD3_RATE)
        strSQL = strSQL.Replace("{38}", DEFAULT_OTHER_RATE)
        strSQL = strSQL.Replace("{39}", FORMAT_INVOICE_HEADER_TEXT)
        strSQL = strSQL.Replace("{40}", FORMAT_INVOICE_FOOTER_TEXT)
        strSQL = strSQL.Replace("{41}", FORMAT_INVOICE_ENTITY_ADDRESS)
        strSQL = strSQL.Replace("{42}", FORMAT_INVOICE_ROW)
        strSQL = strSQL.Replace("{43}", FORMAT_INVOICE_TYPE)
        strSQL = strSQL.Replace("{44}", FORMAT_CASHSALE_HEADER_TEXT)
        strSQL = strSQL.Replace("{45}", FORMAT_CASHSALE_FOOTER_TEXT)
        strSQL = strSQL.Replace("{46}", FORMAT_CASHSALE_ENTITY_ADDRESS)
        strSQL = strSQL.Replace("{47}", FORMAT_CASHSALE_ROW)
        strSQL = strSQL.Replace("{48}", FORMAT_CASHSALE_TYPE)
        strSQL = strSQL.Replace("{49}", FORMAT_RECEIPT_HEADER_TEXT)
        strSQL = strSQL.Replace("{50}", FORMAT_RECEIPT_FOOTER_TEXT)
        strSQL = strSQL.Replace("{51}", FORMAT_RECEIPT_ENTITY_ADDRESS)
        strSQL = strSQL.Replace("{52}", FORMAT_RECEIPT_ROW)
        strSQL = strSQL.Replace("{53}", FORMAT_RECEIPT_TYPE)
        strSQL = strSQL.Replace("{54}", FORMAT_PURCHASE_ORDER_HEADER_TEXT)
        strSQL = strSQL.Replace("{55}", FORMAT_PURCHASE_ORDER_FOOTER_TEXT)
        strSQL = strSQL.Replace("{56}", FORMAT_PURCHASE_ORDER_ROW)
        strSQL = strSQL.Replace("{57}", FORMAT_PURCHASE_ORDER_TYPE)
        strSQL = strSQL.Replace("{58}", FORMAT_SALARY_SLIP_HEADER_TEXT)
        strSQL = strSQL.Replace("{59}", FORMAT_SALARY_SLIP_FOOTER_TEXT)
        strSQL = strSQL.Replace("{60}", FORMAT_SALARY_SLIP_ROW)
        strSQL = strSQL.Replace("{61}", FORMAT_SALARY_SLIP_TYPE)
        strSQL = strSQL.Replace("{62}", FORMAT_PAYMENT_VOUCHER_HEADER_TEXT)
        strSQL = strSQL.Replace("{63}", FORMAT_PAYMENT_VOUCHER_FOOTER_TEXT)
        strSQL = strSQL.Replace("{64}", FORMAT_PAYMENT_VOUCHER_ROW)
        strSQL = strSQL.Replace("{65}", FORMAT_PAYMENT_VOUCHER_TYPE)
        strSQL = strSQL.Replace("{66}", FORMAT_CREDIT_MEMO_HEADER_TEXT)
        strSQL = strSQL.Replace("{67}", FORMAT_CREDIT_MEMO_FOOTER_TEXT)
        strSQL = strSQL.Replace("{68}", FORMAT_CREDIT_MEMO_ROW)
        strSQL = strSQL.Replace("{69}", FORMAT_CREDIT_MEMO_TYPE)
        strSQL = strSQL.Replace("{70}", DEFAULT_RMA_LOCATION_CUST)
        strSQL = strSQL.Replace("{71}", DEFAULT_RMA_LOCATION_SUPP)
        strSQL = strSQL.Replace("{72}", DEFAULT_RMA_LOCATION_HQ)
        strSQL = strSQL.Replace("{73}", DEFAULT_RMA_LOCATION_BRANCH)
        strSQL = strSQL.Replace("{74}", MANAGER_PASSWORD01)
        strSQL = strSQL.Replace("{75}", MANAGER_PASSWORD02)
        strSQL = strSQL.Replace("{76}", MANAGER_PASSWORD03)
        strSQL = strSQL.Replace("{77}", MANAGER_PASSWORD04)
        strSQL = strSQL.Replace("{78}", MANAGER_PASSWORD05)
        strSQL = strSQL.Replace("{79}", MANAGER_PASSWORD06)
        strSQL = strSQL.Replace("{80}", MANAGER_PASSWORD07)
        strSQL = strSQL.Replace("{81}", MANAGER_PASSWORD08)
        strSQL = strSQL.Replace("{82}", MANAGER_PASSWORD09)
        strSQL = strSQL.Replace("{83}", TELEPHONE_DEVELOPER)
        strSQL = strSQL.Replace("{84}", TELEPHONE_SYSADMIN)
        strSQL = strSQL.Replace("{85}", TELEPHONE_CLERK)
        strSQL = strSQL.Replace("{86}", TELEPHONE_ADMIN)
        strSQL = strSQL.Replace("{87}", TELEPHONE_MANAGER)
        strSQL = strSQL.Replace("{88}", TELEPHONE_SALES)
        strSQL = strSQL.Replace("{89}", TELEPHONE_TECH_SUPPORT)
        strSQL = strSQL.Replace("{90}", TELEPHONE_DIRECTOR)
        strSQL = strSQL.Replace("{91}", MOBILEPHONE_DEVELOPER)
        strSQL = strSQL.Replace("{92}", MOBILEPHONE_SYSADMIN)
        strSQL = strSQL.Replace("{93}", MOBILEPHONE_CLERK)
        strSQL = strSQL.Replace("{94}", MOBILEPHONE_ADMIN)
        strSQL = strSQL.Replace("{95}", MOBILEPHONE_MANAGER)
        strSQL = strSQL.Replace("{96}", MOBILEPHONE_SALES)
        strSQL = strSQL.Replace("{97}", MOBILEPHONE_TECH_SUPPORT)
        strSQL = strSQL.Replace("{98}", MOBILEPHONE_DIRECTOR)
        strSQL = strSQL.Replace("{99}", EMAIL_SYSTEM)
        strSQL = strSQL.Replace("{100}", EMAIL_DEVELOPER)
        strSQL = strSQL.Replace("{101}", EMAIL_SYSADMIN)
        strSQL = strSQL.Replace("{102}", EMAIL_CLERK)
        strSQL = strSQL.Replace("{103}", EMAIL_ADMIN)
        strSQL = strSQL.Replace("{104}", EMAIL_MANAGER)
        strSQL = strSQL.Replace("{105}", EMAIL_SALES)
        strSQL = strSQL.Replace("{106}", EMAIL_TECH_SUPPORT)
        strSQL = strSQL.Replace("{107}", EMAIL_DIRECTOR)
        strSQL = strSQL.Replace("{108}", CUSTOMER_ID)
        strSQL = strSQL.Replace("{109}", SUPPLIER_ID)
        strSQL = strSQL.Replace("{110}", LOYALTY_CARD_NO_PREFIX)
        strSQL = strSQL.Replace("{111}", LOYALTY_CARD_NO_POSTFIX)
        strSQL = strSQL.Replace("{112}", CRV_DAY_FROM)
        strSQL = strSQL.Replace("{113}", CRV_DAY_TO)
        strSQL = strSQL.Replace("{114}", TAX_REG_NUMBER)
        strSQL = strSQL.Replace("{115}", FORMAT_PROFORMA_INVOICE_TYPE)
        strSQL = strSQL.Replace("{116}", FORMAT_PROFORMA_INVOICE_FOOTER_TEXT)
        strSQL = strSQL.Replace("{117}", FORMAT_PROFORMA_INVOICE_HEADER_TEXT)
        strSQL = strSQL.Replace("{118}", FORMAT_PROFORMA_INVOICE_ROW)
        strSQL = strSQL.Replace("{119}", FORMAT_SERVICE_NOTE_TYPE)
        strSQL = strSQL.Replace("{120}", FORMAT_SERVICE_NOTE_FOOTER_TEXT)
        strSQL = strSQL.Replace("{121}", FORMAT_SERVICE_NOTE_HEADER_TEXT)
        strSQL = strSQL.Replace("{122}", FORMAT_SERVICE_NOTE_ROW)
        strSQL = strSQL.Replace("{123}", FORMAT_PACKING_LIST_TYPE)
        strSQL = strSQL.Replace("{124}", FORMAT_PACKING_LIST_FOOTER_TEXT)
        strSQL = strSQL.Replace("{125}", FORMAT_PACKING_LIST_HEADER_TEXT)
        strSQL = strSQL.Replace("{126}", FORMAT_PACKING_LIST_ROW)
        strSQL = strSQL.Replace("{127}", FORMAT_JOBSHEET_TYPE)
        strSQL = strSQL.Replace("{128}", FORMAT_JOBSHEET_FOOTER_TEXT)
        strSQL = strSQL.Replace("{129}", FORMAT_JOBSHEET_HEADER_TEXT)
        strSQL = strSQL.Replace("{130}", FORMAT_JOBSHEET_ROW)
        strSQL = strSQL.Replace("{131}", FORMAT_GRN_TYPE)
        strSQL = strSQL.Replace("{132}", FORMAT_GRN_FOOTER_TEXT)
        strSQL = strSQL.Replace("{133}", FORMAT_GRN_HEADER_TEXT)
        strSQL = strSQL.Replace("{134}", FORMAT_GRN_ROW)


        strSQL = strSQL.Replace("{V1}", PreparedStatement(obj.pkid))
        strSQL = strSQL.Replace("{V2}", PreparedStatement(obj.code))
        strSQL = strSQL.Replace("{V3}", PreparedStatement(obj.regNo))
        strSQL = strSQL.Replace("{V4}", PreparedStatement(obj.name))
        strSQL = strSQL.Replace("{V5}", PreparedStatement(obj.description))
        strSQL = strSQL.Replace("{V6}", PreparedStatement(obj.addr1))
        strSQL = strSQL.Replace("{V7}", PreparedStatement(obj.addr2))
        strSQL = strSQL.Replace("{V8}", PreparedStatement(obj.addr3))
        strSQL = strSQL.Replace("{V9}", PreparedStatement(obj.zip))
        strSQL = strSQL.Replace("{V10}", PreparedStatement(obj.state))
        strSQL = strSQL.Replace("{V11}", PreparedStatement(obj.countryCode))
        strSQL = strSQL.Replace("{V12}", PreparedStatement(obj.phoneNo))
        strSQL = strSQL.Replace("{V13}", PreparedStatement(obj.faxNo))
        strSQL = strSQL.Replace("{V14}", PreparedStatement(obj.webUrl))
        strSQL = strSQL.Replace("{V15}", PreparedStatement(obj.accPCCenterId))
        strSQL = strSQL.Replace("{V16}", PreparedStatement(obj.invLocationId))
        strSQL = strSQL.Replace("{V17}", PreparedStatement(obj.status))
        strSQL = strSQL.Replace("{V18}", PreparedStatement(obj.lastUpdate))
        strSQL = strSQL.Replace("{V19}", PreparedStatement(obj.userIdUpdate))
        strSQL = strSQL.Replace("{V20}", PreparedStatement(obj.cashbookCash))
        strSQL = strSQL.Replace("{V21}", PreparedStatement(obj.cashbookCard))
        strSQL = strSQL.Replace("{V22}", PreparedStatement(obj.cashbookCheque))
        strSQL = strSQL.Replace("{V23}", PreparedStatement(obj.cashbookPDCheque))
        strSQL = strSQL.Replace("{V24}", PreparedStatement(obj.cashbookCoupon))
        strSQL = strSQL.Replace("{V25}", PreparedStatement(obj.cashbookOther))
        strSQL = strSQL.Replace("{V26}", PreparedStatement(obj.cashbookPayment))
        strSQL = strSQL.Replace("{V27}", PreparedStatement(obj.logoURL))
        strSQL = strSQL.Replace("{V28}", PreparedStatement(obj.currency))
        strSQL = strSQL.Replace("{V29}", PreparedStatement(obj.pricing))
        strSQL = strSQL.Replace("{V30}", PreparedStatement(obj.hotlines))
        strSQL = strSQL.Replace("{V31}", PreparedStatement(obj.defaultVisaRate))
        strSQL = strSQL.Replace("{V32}", PreparedStatement(obj.defaultMasterRate))
        strSQL = strSQL.Replace("{V33}", PreparedStatement(obj.defaultAmexRate))
        strSQL = strSQL.Replace("{V34}", PreparedStatement(obj.defaultDinerRate))
        strSQL = strSQL.Replace("{V35}", PreparedStatement(obj.defaultCard1Rate))
        strSQL = strSQL.Replace("{V36}", PreparedStatement(obj.defaultCard2Rate))
        strSQL = strSQL.Replace("{V37}", PreparedStatement(obj.defaultCard3Rate))
        strSQL = strSQL.Replace("{V38}", PreparedStatement(obj.defaultOtherRate))
        strSQL = strSQL.Replace("{V39}", PreparedStatement(obj.formatInvoiceHeaderText))
        strSQL = strSQL.Replace("{V40}", PreparedStatement(obj.formatInvoiceFooterText))
        strSQL = strSQL.Replace("{V41}", PreparedStatement(obj.formatInvoiceEntityAddress))
        strSQL = strSQL.Replace("{V42}", PreparedStatement(obj.formatInvoiceRow))
        strSQL = strSQL.Replace("{V43}", PreparedStatement(obj.formatInvoiceType))
        strSQL = strSQL.Replace("{V44}", PreparedStatement(obj.formatCashsaleHeaderText))
        strSQL = strSQL.Replace("{V45}", PreparedStatement(obj.formatCashsaleFooterText))
        strSQL = strSQL.Replace("{V46}", PreparedStatement(obj.formatCashsaleEntityAddress))
        strSQL = strSQL.Replace("{V47}", PreparedStatement(obj.formatCashsaleRow))
        strSQL = strSQL.Replace("{V48}", PreparedStatement(obj.formatCashsaleType))
        strSQL = strSQL.Replace("{V49}", PreparedStatement(obj.formatReceiptHeaderText))
        strSQL = strSQL.Replace("{V50}", PreparedStatement(obj.formatReceiptFooterText))
        strSQL = strSQL.Replace("{V51}", PreparedStatement(obj.formatReceiptEntityAddress))
        strSQL = strSQL.Replace("{V52}", PreparedStatement(obj.formatReceiptRow))
        strSQL = strSQL.Replace("{V53}", PreparedStatement(obj.formatReceiptType))
        strSQL = strSQL.Replace("{V54}", PreparedStatement(obj.formatPurchaseOrderHeaderText))
        strSQL = strSQL.Replace("{V55}", PreparedStatement(obj.formatPurchaseOrderFooterText))
        strSQL = strSQL.Replace("{V56}", PreparedStatement(obj.formatPurchaseOrderRow))
        strSQL = strSQL.Replace("{V57}", PreparedStatement(obj.formatPurchaseOrderType))
        strSQL = strSQL.Replace("{V58}", PreparedStatement(obj.formatSalarySlipHeaderText))
        strSQL = strSQL.Replace("{V59}", PreparedStatement(obj.formatSalarySlipFooterText))
        strSQL = strSQL.Replace("{V60}", PreparedStatement(obj.formatSalarySlipRow))
        strSQL = strSQL.Replace("{V61}", PreparedStatement(obj.formatSalarySlipType))
        strSQL = strSQL.Replace("{V62}", PreparedStatement(obj.formatPaymentVoucherHeaderText))
        strSQL = strSQL.Replace("{V63}", PreparedStatement(obj.formatPaymentVoucherFooterText))
        strSQL = strSQL.Replace("{V64}", PreparedStatement(obj.formatPaymentVoucherRow))
        strSQL = strSQL.Replace("{V65}", PreparedStatement(obj.formatPaymentVoucherType))
        strSQL = strSQL.Replace("{V66}", PreparedStatement(obj.formatCreditMemoHeaderText))
        strSQL = strSQL.Replace("{V67}", PreparedStatement(obj.formatCreditMemoFooterText))
        strSQL = strSQL.Replace("{V68}", PreparedStatement(obj.formatCreditMemoRow))
        strSQL = strSQL.Replace("{V69}", PreparedStatement(obj.formatCreditMemoType))
        strSQL = strSQL.Replace("{V70}", PreparedStatement(obj.defaultRmaLocationCust))
        strSQL = strSQL.Replace("{V71}", PreparedStatement(obj.defaultRmaLocationSupp))
        strSQL = strSQL.Replace("{V72}", PreparedStatement(obj.defaultRmaLocationHq))
        strSQL = strSQL.Replace("{V73}", PreparedStatement(obj.defaultRmaLocationBranch))
        strSQL = strSQL.Replace("{V74}", PreparedStatement(obj.managerPassword01))
        strSQL = strSQL.Replace("{V75}", PreparedStatement(obj.managerPassword02))
        strSQL = strSQL.Replace("{V76}", PreparedStatement(obj.managerPassword03))
        strSQL = strSQL.Replace("{V77}", PreparedStatement(obj.managerPassword04))
        strSQL = strSQL.Replace("{V78}", PreparedStatement(obj.managerPassword05))
        strSQL = strSQL.Replace("{V79}", PreparedStatement(obj.managerPassword06))
        strSQL = strSQL.Replace("{V80}", PreparedStatement(obj.managerPassword07))
        strSQL = strSQL.Replace("{V81}", PreparedStatement(obj.managerPassword08))
        strSQL = strSQL.Replace("{V82}", PreparedStatement(obj.managerPassword09))
        strSQL = strSQL.Replace("{V83}", PreparedStatement(obj.telephoneDeveloper))
        strSQL = strSQL.Replace("{V84}", PreparedStatement(obj.telephoneSysadmin))
        strSQL = strSQL.Replace("{V85}", PreparedStatement(obj.telephoneClerk))
        strSQL = strSQL.Replace("{V86}", PreparedStatement(obj.telephoneAdmin))
        strSQL = strSQL.Replace("{V87}", PreparedStatement(obj.telephoneManager))
        strSQL = strSQL.Replace("{V88}", PreparedStatement(obj.telephoneSales))
        strSQL = strSQL.Replace("{V89}", PreparedStatement(obj.telephoneTechSupport))
        strSQL = strSQL.Replace("{V90}", PreparedStatement(obj.telephoneDirector))
        strSQL = strSQL.Replace("{V91}", PreparedStatement(obj.mobilephoneDeveloper))
        strSQL = strSQL.Replace("{V92}", PreparedStatement(obj.mobilephoneSysadmin))
        strSQL = strSQL.Replace("{V93}", PreparedStatement(obj.mobilephoneClerk))
        strSQL = strSQL.Replace("{V94}", PreparedStatement(obj.mobilephoneAdmin))
        strSQL = strSQL.Replace("{V95}", PreparedStatement(obj.mobilephoneManager))
        strSQL = strSQL.Replace("{V96}", PreparedStatement(obj.mobilephoneSales))
        strSQL = strSQL.Replace("{V97}", PreparedStatement(obj.mobilephoneTechSupport))
        strSQL = strSQL.Replace("{V98}", PreparedStatement(obj.mobilephoneDirector))
        strSQL = strSQL.Replace("{V99}", PreparedStatement(obj.emailSystem))
        strSQL = strSQL.Replace("{V100}", PreparedStatement(obj.emailDeveloper))
        strSQL = strSQL.Replace("{V101}", PreparedStatement(obj.emailSysadmin))
        strSQL = strSQL.Replace("{V102}", PreparedStatement(obj.emailClerk))
        strSQL = strSQL.Replace("{V103}", PreparedStatement(obj.emailAdmin))
        strSQL = strSQL.Replace("{V104}", PreparedStatement(obj.emailManager))
        strSQL = strSQL.Replace("{V105}", PreparedStatement(obj.emailSales))
        strSQL = strSQL.Replace("{V106}", PreparedStatement(obj.emailTechSupport))
        strSQL = strSQL.Replace("{V107}", PreparedStatement(obj.emailDirector))
        strSQL = strSQL.Replace("{V108}", PreparedStatement(obj.customerId))
        strSQL = strSQL.Replace("{V109}", PreparedStatement(obj.supplierId))
        strSQL = strSQL.Replace("{V110}", PreparedStatement(obj.loyaltyCardNoPrefix))
        strSQL = strSQL.Replace("{V111}", PreparedStatement(obj.loyaltyCardNoPostfix))
        strSQL = strSQL.Replace("{V112}", PreparedStatement(obj.crvDayFrom))
        strSQL = strSQL.Replace("{V113}", PreparedStatement(obj.crvDayTo))
        strSQL = strSQL.Replace("{V114}", PreparedStatement(obj.taxRegNumber))
        strSQL = strSQL.Replace("{V115}", PreparedStatement(obj.formatProformaInvoiceType))
        strSQL = strSQL.Replace("{V116}", PreparedStatement(obj.formatProformaInvoiceFooterText))
        strSQL = strSQL.Replace("{V117}", PreparedStatement(obj.formatProformaInvoiceHeaderText))
        strSQL = strSQL.Replace("{V118}", PreparedStatement(obj.formatProformaInvoiceRow))
        strSQL = strSQL.Replace("{V119}", PreparedStatement(obj.formatServiceNoteType))
        strSQL = strSQL.Replace("{V120}", PreparedStatement(obj.formatServiceNoteFooterText))
        strSQL = strSQL.Replace("{V121}", PreparedStatement(obj.formatServiceNoteHeaderText))
        strSQL = strSQL.Replace("{V122}", PreparedStatement(obj.formatServiceNoteRow))
        strSQL = strSQL.Replace("{V123}", PreparedStatement(obj.formatPackingListType))
        strSQL = strSQL.Replace("{V124}", PreparedStatement(obj.formatPackingListFooterText))
        strSQL = strSQL.Replace("{V125}", PreparedStatement(obj.formatPackingListHeaderText))
        strSQL = strSQL.Replace("{V126}", PreparedStatement(obj.formatPackingListRow))
        strSQL = strSQL.Replace("{V127}", PreparedStatement(obj.formatJobsheetType))
        strSQL = strSQL.Replace("{V128}", PreparedStatement(obj.formatJobsheetFooterText))
        strSQL = strSQL.Replace("{V129}", PreparedStatement(obj.formatJobsheetHeaderText))
        strSQL = strSQL.Replace("{V130}", PreparedStatement(obj.formatJobsheetRow))
        strSQL = strSQL.Replace("{V131}", PreparedStatement(obj.formatGRNType))
        strSQL = strSQL.Replace("{V132}", PreparedStatement(obj.formatGRNFooterText))
        strSQL = strSQL.Replace("{V133}", PreparedStatement(obj.formatGRNHeaderText))
        strSQL = strSQL.Replace("{V134}", PreparedStatement(obj.formatGRNRow))

        Return strSQL

    End Function
End Class
