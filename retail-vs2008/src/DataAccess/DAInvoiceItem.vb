Imports Utils.General

Public Class DAInvoiceItem

    'Constants for Table field mappings
    Private Const CLASSNAME = "DAInvoiceItem"

    Public Const PKID = "pkid"
    Public Const INVOICE_ID = "invoice_id"
    Public Const POS_ITEM_ID = "pos_item_id"
    Public Const REMARKS = "remarks"
    Public Const TOTALQTY = "total_quantity"
    Public Const CURRENCY = "currency"
    Public Const UNIT_PRICE_QUOTED = "unit_price_quoted"
    Public Const STR_NAME_1 = "str_name_1"
    Public Const STR_VALUE_1 = "str_value_1"
    Public Const PIC1 = "pic1"
    Public Const PIC2 = "pic2"
    Public Const PIC3 = "pic3"
    Public Const CURRENCY2 = "currency2"
    Public Const UNIT_PRICE_QUOTED2 = "unit_price_quoted2"
    Public Const TAXAMT = "taxamt"
    Public Const TAXAMT2 = "taxamt2"
    Public Const STR_NAME_2 = "str_name_2"
    Public Const STR_VALUE_2 = "str_value_2"
    Public Const STR_NAME_3 = "str_name_3"
    Public Const STR_VALUE_3 = "str_value_3"
    Public Const INT_NAME_1 = "int_name_1"
    Public Const INT_VALUE_1 = "int_value_1"
    Public Const INT_NAME_2 = "int_name_2"
    Public Const INT_VALUE_2 = "int_value_2"
    Public Const BD_NAME_1 = "bd_name_1"
    Public Const BD_VALUE_1 = "bd_value_1"
    Public Const STATUS = "status"
    Public Const STATE = "state"
    Public Const POS_ITEM_TYPE = "pos_item_type"
    Public Const ITEM_ID = "item_id"
    Public Const ITEM_CODE = "item_code"
    Public Const BAR_CODE = "bar_code"
    Public Const SERIALIZED = "serialized"
    Public Const NAME = "name"
    Public Const OUTSTANDING_QTY = "outstanding_qty"
    Public Const PACKAGE = "package"
    Public Const PARENT_ID = "parent_id"
    Public Const UNIT_COST_MA = "unit_cost_ma"
    Public Const UNIT_PRICE_STD = "unit_price_std"
    Public Const UNIT_PRICE_STD2 = "unit_price_std2"
    Public Const UNIT_DISCOUNT = "unit_discount"
    Public Const UNIT_COMMISSION = "unit_commission"
    Public Const CODE_PROJECT = "code_project"
    Public Const CODE_DEPARTMENT = "code_department"
    Public Const CODE_DEALER = "code_dealer"
    Public Const CODE_SALESMAN = "code_salesman"
    Public Const STK_ID = "stk_id"
    Public Const STK_LOCATION_ID = "stk_location_id"
    Public Const STK_LOCATION_CODE = "stk_location_code"
    Public Const BOM_CONVERT_MODE = "bom_convert_mode"
    Public Const BOM_ID = "bom_id"
    Public Const BOM_CONVERT_STATUS = "bom_convert_status"
    Public Const BOM_CONVERT_TIME = "bom_convert_time"
    Public Const BOM_CONVERT_USER = "bom_convert_user"
    Public Const BOM_TARGET_LOC = "bom_target_loc"
    Public Const BOM_SOURCE_LOC = "bom_source_loc"
    Public Const WARRANTY_TYPE = "warranty_type"
    Public Const WARRANTY_OPTION = "warranty_option"
    Public Const WARRANTY_EXPIRY = "warranty_expiry"
    Public Const PSEUDO_LOGIC = "pseudo_logic"
    Public Const PSEUDO_CODE = "pseudo_code"
    Public Const PSEUDO_NAME = "pseudo_name"
    Public Const PSEUDO_DESCRIPTION = "pseudo_description"
    Public Const PSEUDO_CURRENCY = "pseudo_currency"
    Public Const PSEUDO_PRICE = "pseudo_price"
    Public Const PSEUDO_QTY = "pseudo_qty"
    Public Const LOYALTY_LOGIC = "loyalty_logic"
    Public Const LOYALTY_POINTS_AWARDED = "loyalty_points_awarded"
    Public Const LOYALTY_POINTS_REDEEMED = "loyalty_points_redeemed"
    Public Const LOYALTY_PROCESS_STATUS = "loyalty_process_status"
    Public Const LOYALTY_PROCESS_REVERSAL_STATUS = "loyalty_process_reversal_status"
    Public Const LOYALTY_JTXN_STATUS = "loyalty_jtxn_status"
    Public Const LOYALTY_JTXN_REVERSAL_STATUS = "loyalty_jtxn_reversal_status"
    Public Const JOBSHEET_INDEX_PKID = "jobsheet_index_pkid"
    Public Const PACKAGE_GROUP = "package_group"
    Public Const UNIT_DISCOUNT2 = "unit_discount2"
    Public Const TAX_CODE = "tax_code"
    Public Const TAX_TYPE = "tax_type"
    Public Const TAX_RATE = "tax_rate"
    Public Const DATE_START = "date_start"
    Public Const DATE_END = "date_end"

    Public Const UOM = "uom"
    Public Const TAX_OPTION = "tax_option"
    Public Const JOBSHEET_ITEM_ID = "jobsheet_item_id"
    Public Const SERIAL_NUMBERS = "serial_numbers"

    Public Const STATUS_ACTIVE = "act"
    Public Const STATUS_INACTIVE = "ina"
    Public Const STATUS_CANCELLED = "cxl"

    Public Const TABLENAME = "cust_invoice_item"
    Public Const NO_OF_COLUMNS As Integer = 85
    Public Const APP_NAME = "ThickClient-DataAccess"
    Public Const START_ID = 1001

    '***************************************************************************
    '* Create
    '**************************************************************************/
    Public Function Create(ByVal obj As DAInvoiceItemObject) As DAInvoiceItemObject

        WriteToLogFile(CLASSNAME & " - In Create")

        Dim comm As New Commands
        Dim strSQL, strSQL1, strSQL2 As String

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
    Public Sub Update(ByVal obj As DAInvoiceItemObject)

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
    Public Function GetObject(ByVal id As Integer) As DAInvoiceItemObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DAInvoiceItemObject = Nothing
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
        strSQL = strSQL.Replace("{1}", TAX_CODE)

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
    Public Function GetObject(ByVal row As DataRow) As DAInvoiceItemObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DAInvoiceItemObject

        Try
            obj = New DAInvoiceItemObject
            obj.mPkid = row(PKID)
            obj.mInvoiceId = row(INVOICE_ID)
            obj.mPosItemId = row(POS_ITEM_ID)
            obj.mRemarks = row(REMARKS)
            obj.mTotalQty = row(TOTALQTY)
            obj.mCurrency = row(CURRENCY)
            obj.mUnitPriceQuoted = row(UNIT_PRICE_QUOTED)
            obj.mStrName1 = row(STR_NAME_1)
            obj.mStrValue1 = row(STR_VALUE_1)
            obj.mPic1 = row(PIC1)
            obj.mPic2 = row(PIC2)
            obj.mPic3 = row(PIC3)
            obj.mCurrency2 = row(CURRENCY2)
            obj.mUnitPriceQuoted2 = row(UNIT_PRICE_QUOTED2)
            obj.mTaxAmt = row(TAXAMT)
            obj.mTaxAmt2 = row(TAXAMT2)
            obj.mStrName2 = row(STR_NAME_2)
            obj.mStrValue2 = row(STR_VALUE_2)
            obj.mStrName3 = row(STR_NAME_3)
            obj.mStrValue3 = row(STR_VALUE_3)
            obj.mIntName1 = row(INT_NAME_1)
            obj.mIntValue1 = row(INT_VALUE_1)
            obj.mIntName2 = row(INT_NAME_2)
            obj.mIntValue2 = row(INT_VALUE_2)
            obj.mBdName1 = row(BD_NAME_1)
            obj.mBdValue1 = row(BD_VALUE_1)
            obj.mStatus = row(STATUS)
            obj.mState = row(STATE)
            obj.mPosItemType = row(POS_ITEM_TYPE)
            obj.mItemId = row(ITEM_ID)
            obj.mItemCode = row(ITEM_CODE)
            obj.mBarCode = row(BAR_CODE)
            obj.mSerialized = row(SERIALIZED)
            obj.mName = row(NAME)
            obj.mOutstandingQty = row(OUTSTANDING_QTY)
            obj.mPackage = row(PACKAGE)
            obj.mParentId = row(PARENT_ID)
            obj.mUnitCostMa = row(UNIT_COST_MA)
            obj.mUnitPriceStd = row(UNIT_PRICE_STD)
            obj.mUnitPriceStd2 = row(UNIT_PRICE_STD2)
            obj.mUnitDiscount = row(UNIT_DISCOUNT)
            obj.mUnitDiscount2 = row(UNIT_DISCOUNT2)
            obj.mUnitCommission = row(UNIT_COMMISSION)
            obj.codeProject = row(CODE_PROJECT)
            obj.codeDepartment = row(CODE_DEPARTMENT)
            obj.codeDealer = row(CODE_DEALER)
            obj.codeSalesman = row(CODE_SALESMAN)
            obj.stkId = row(STK_ID)
            obj.stkLocationId = row(STK_LOCATION_ID)
            obj.stkLocationCode = row(STK_LOCATION_CODE)
            obj.bomConvertMode = row(BOM_CONVERT_MODE)
            obj.bomId = row(BOM_ID)
            obj.bomConvertStatus = row(BOM_CONVERT_STATUS)
            obj.bomConvertTime = row(BOM_CONVERT_TIME)
            obj.bomConvertUser = row(BOM_CONVERT_USER)
            obj.bomTargetLoc = row(BOM_TARGET_LOC)
            obj.bomSourceLoc = row(BOM_SOURCE_LOC)
            obj.warrantyType = row(WARRANTY_TYPE)
            obj.warrantyOption = row(WARRANTY_OPTION)
            obj.warrantyExpiry = row(WARRANTY_EXPIRY)
            obj.pseudoLogic = row(PSEUDO_LOGIC)
            obj.pseudoCode = row(PSEUDO_CODE)
            obj.pseudoName = row(PSEUDO_NAME)
            obj.pseudoDescription = row(PSEUDO_DESCRIPTION)
            obj.pseudoCurrency = row(PSEUDO_CURRENCY)
            obj.pseudoPrice = row(PSEUDO_PRICE)
            obj.pseudoQty = row(PSEUDO_QTY)
            obj.loyaltyLogic = row(LOYALTY_LOGIC)
            obj.loyaltyPointsAwarded = row(LOYALTY_POINTS_AWARDED)
            obj.loyaltyPointsRedeemed = row(LOYALTY_POINTS_REDEEMED)
            obj.loyaltyProcessStatus = row(LOYALTY_PROCESS_STATUS)
            obj.loyaltyProcessReversalStatus = row(LOYALTY_PROCESS_REVERSAL_STATUS)
            obj.loyaltyJTxnStatus = row(LOYALTY_JTXN_STATUS)
            obj.loyaltyJTxnReversalStatus = row(LOYALTY_JTXN_REVERSAL_STATUS)
            obj.jobsheet_index_pkid = row(JOBSHEET_INDEX_PKID)
            obj.package_group = row(PACKAGE_GROUP)
            obj.taxCode = row(TAX_CODE)
            obj.taxType = row(TAX_TYPE)
            obj.taxRate = row(TAX_RATE)
            obj.date_start = row(DATE_START)
            obj.date_end = row(DATE_END)
            obj.uom = row(UOM)
            obj.taxOption = row(TAX_OPTION)
            obj.jobsheetItemId = row(JOBSHEET_ITEM_ID)
            obj.serialNumbers = row(SERIAL_NUMBERS)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetObject - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetObject")

        Return obj

    End Function


    Public Function ReplaceStatement(ByVal strSQL As String, ByVal obj As DAInvoiceItemObject) As String

        strSQL = strSQL.Replace("{T}", TABLENAME)

        strSQL = strSQL.Replace("{1}", PKID)
        strSQL = strSQL.Replace("{2}", INVOICE_ID)
        strSQL = strSQL.Replace("{3}", POS_ITEM_ID)
        strSQL = strSQL.Replace("{4}", REMARKS)
        strSQL = strSQL.Replace("{5}", TOTALQTY)
        strSQL = strSQL.Replace("{6}", CURRENCY)
        strSQL = strSQL.Replace("{7}", UNIT_PRICE_QUOTED)
        strSQL = strSQL.Replace("{8}", STR_NAME_1)
        strSQL = strSQL.Replace("{9}", STR_VALUE_1)
        strSQL = strSQL.Replace("{10}", PIC1)
        strSQL = strSQL.Replace("{11}", PIC2)
        strSQL = strSQL.Replace("{12}", PIC3)
        strSQL = strSQL.Replace("{13}", CURRENCY2)
        strSQL = strSQL.Replace("{14}", UNIT_PRICE_QUOTED2)
        strSQL = strSQL.Replace("{15}", TAXAMT)
        strSQL = strSQL.Replace("{16}", TAXAMT2)
        strSQL = strSQL.Replace("{17}", STR_NAME_2)
        strSQL = strSQL.Replace("{18}", STR_VALUE_2)
        strSQL = strSQL.Replace("{19}", STR_NAME_3)
        strSQL = strSQL.Replace("{20}", STR_VALUE_3)
        strSQL = strSQL.Replace("{21}", INT_NAME_1)
        strSQL = strSQL.Replace("{22}", INT_VALUE_1)
        strSQL = strSQL.Replace("{23}", INT_NAME_2)
        strSQL = strSQL.Replace("{24}", INT_VALUE_2)
        strSQL = strSQL.Replace("{25}", BD_NAME_1)
        strSQL = strSQL.Replace("{26}", BD_VALUE_1)
        strSQL = strSQL.Replace("{27}", STATUS)
        strSQL = strSQL.Replace("{28}", STATE)
        strSQL = strSQL.Replace("{29}", POS_ITEM_TYPE)
        strSQL = strSQL.Replace("{30}", ITEM_ID)
        strSQL = strSQL.Replace("{31}", ITEM_CODE)
        strSQL = strSQL.Replace("{32}", BAR_CODE)
        strSQL = strSQL.Replace("{33}", SERIALIZED)
        strSQL = strSQL.Replace("{34}", NAME)
        strSQL = strSQL.Replace("{35}", OUTSTANDING_QTY)
        strSQL = strSQL.Replace("{36}", PACKAGE)
        strSQL = strSQL.Replace("{37}", PARENT_ID)
        strSQL = strSQL.Replace("{38}", UNIT_COST_MA)
        strSQL = strSQL.Replace("{39}", UNIT_PRICE_STD)
        strSQL = strSQL.Replace("{40}", UNIT_PRICE_STD2)
        strSQL = strSQL.Replace("{41}", UNIT_DISCOUNT)
        strSQL = strSQL.Replace("{42}", UNIT_DISCOUNT2)
        strSQL = strSQL.Replace("{43}", UNIT_COMMISSION)
        strSQL = strSQL.Replace("{44}", CODE_PROJECT)
        strSQL = strSQL.Replace("{45}", CODE_DEPARTMENT)
        strSQL = strSQL.Replace("{46}", CODE_DEALER)
        strSQL = strSQL.Replace("{47}", CODE_SALESMAN)
        strSQL = strSQL.Replace("{48}", STK_ID)
        strSQL = strSQL.Replace("{49}", STK_LOCATION_ID)
        strSQL = strSQL.Replace("{50}", STK_LOCATION_CODE)
        strSQL = strSQL.Replace("{51}", BOM_CONVERT_MODE)
        strSQL = strSQL.Replace("{52}", BOM_ID)
        strSQL = strSQL.Replace("{53}", BOM_CONVERT_STATUS)
        strSQL = strSQL.Replace("{54}", BOM_CONVERT_TIME)
        strSQL = strSQL.Replace("{55}", BOM_CONVERT_USER)
        strSQL = strSQL.Replace("{56}", BOM_TARGET_LOC)
        strSQL = strSQL.Replace("{57}", BOM_SOURCE_LOC)
        strSQL = strSQL.Replace("{58}", WARRANTY_TYPE)
        strSQL = strSQL.Replace("{59}", WARRANTY_OPTION)
        strSQL = strSQL.Replace("{60}", WARRANTY_EXPIRY)
        strSQL = strSQL.Replace("{61}", PSEUDO_LOGIC)
        strSQL = strSQL.Replace("{62}", PSEUDO_CODE)
        strSQL = strSQL.Replace("{63}", PSEUDO_NAME)
        strSQL = strSQL.Replace("{64}", PSEUDO_DESCRIPTION)
        strSQL = strSQL.Replace("{65}", PSEUDO_CURRENCY)
        strSQL = strSQL.Replace("{66}", PSEUDO_PRICE)
        strSQL = strSQL.Replace("{67}", PSEUDO_QTY)
        strSQL = strSQL.Replace("{68}", LOYALTY_LOGIC)
        strSQL = strSQL.Replace("{69}", LOYALTY_POINTS_AWARDED)
        strSQL = strSQL.Replace("{70}", LOYALTY_POINTS_REDEEMED)
        strSQL = strSQL.Replace("{71}", LOYALTY_PROCESS_STATUS)
        strSQL = strSQL.Replace("{72}", LOYALTY_PROCESS_REVERSAL_STATUS)
        strSQL = strSQL.Replace("{73}", LOYALTY_JTXN_STATUS)
        strSQL = strSQL.Replace("{74}", LOYALTY_JTXN_REVERSAL_STATUS)
        strSQL = strSQL.Replace("{75}", JOBSHEET_INDEX_PKID)
        strSQL = strSQL.Replace("{76}", PACKAGE_GROUP)
        strSQL = strSQL.Replace("{77}", TAX_CODE)
        strSQL = strSQL.Replace("{78}", TAX_TYPE)
        strSQL = strSQL.Replace("{79}", TAX_RATE)
        strSQL = strSQL.Replace("{80}", DATE_START)
        strSQL = strSQL.Replace("{81}", DATE_END)
        strSQL = strSQL.Replace("{82}", UOM)
        strSQL = strSQL.Replace("{83}", TAX_OPTION)
        strSQL = strSQL.Replace("{84}", JOBSHEET_ITEM_ID)
        strSQL = strSQL.Replace("{85}", SERIAL_NUMBERS)

        strSQL = strSQL.Replace("{V1}", PreparedStatement(obj.mPkid))
        strSQL = strSQL.Replace("{V2}", PreparedStatement(obj.mInvoiceId))
        strSQL = strSQL.Replace("{V3}", PreparedStatement(obj.mPosItemId))
        strSQL = strSQL.Replace("{V4}", PreparedStatement(obj.mRemarks))
        strSQL = strSQL.Replace("{V5}", PreparedStatement(obj.mTotalQty))
        strSQL = strSQL.Replace("{V6}", PreparedStatement(obj.mCurrency))
        strSQL = strSQL.Replace("{V7}", PreparedStatement(obj.mUnitPriceQuoted))
        strSQL = strSQL.Replace("{V8}", PreparedStatement(obj.mStrName1))
        strSQL = strSQL.Replace("{V9}", PreparedStatement(obj.mStrValue1))
        strSQL = strSQL.Replace("{V10}", PreparedStatement(obj.mPic1))
        strSQL = strSQL.Replace("{V11}", PreparedStatement(obj.mPic2))
        strSQL = strSQL.Replace("{V12}", PreparedStatement(obj.mPic3))
        strSQL = strSQL.Replace("{V13}", PreparedStatement(obj.mCurrency2))
        strSQL = strSQL.Replace("{V14}", PreparedStatement(obj.mUnitPriceQuoted2))
        strSQL = strSQL.Replace("{V15}", PreparedStatement(obj.mTaxAmt))
        strSQL = strSQL.Replace("{V16}", PreparedStatement(obj.mTaxAmt2))
        strSQL = strSQL.Replace("{V17}", PreparedStatement(obj.mStrName2))
        strSQL = strSQL.Replace("{V18}", PreparedStatement(obj.mStrValue2))
        strSQL = strSQL.Replace("{V19}", PreparedStatement(obj.mStrName3))
        strSQL = strSQL.Replace("{V20}", PreparedStatement(obj.mStrValue3))
        strSQL = strSQL.Replace("{V21}", PreparedStatement(obj.mIntName1))
        strSQL = strSQL.Replace("{V22}", PreparedStatement(obj.mIntValue1))
        strSQL = strSQL.Replace("{V23}", PreparedStatement(obj.mIntName2))
        strSQL = strSQL.Replace("{V24}", PreparedStatement(obj.mIntValue2))
        strSQL = strSQL.Replace("{V25}", PreparedStatement(obj.mBdName1))
        strSQL = strSQL.Replace("{V26}", PreparedStatement(obj.mBdValue1))
        strSQL = strSQL.Replace("{V27}", PreparedStatement(obj.mStatus))
        strSQL = strSQL.Replace("{V28}", PreparedStatement(obj.mState))
        strSQL = strSQL.Replace("{V29}", PreparedStatement(obj.mPosItemType))
        strSQL = strSQL.Replace("{V30}", PreparedStatement(obj.mItemId))
        strSQL = strSQL.Replace("{V31}", PreparedStatement(obj.mItemCode))
        strSQL = strSQL.Replace("{V32}", PreparedStatement(obj.mBarCode))
        strSQL = strSQL.Replace("{V33}", PreparedStatement(obj.mSerialized))
        strSQL = strSQL.Replace("{V34}", PreparedStatement(obj.mName))
        strSQL = strSQL.Replace("{V35}", PreparedStatement(obj.mOutstandingQty))
        strSQL = strSQL.Replace("{V36}", PreparedStatement(obj.mPackage))
        strSQL = strSQL.Replace("{V37}", PreparedStatement(obj.mParentId))
        strSQL = strSQL.Replace("{V38}", PreparedStatement(obj.mUnitCostMa))
        strSQL = strSQL.Replace("{V39}", PreparedStatement(obj.mUnitPriceStd))
        strSQL = strSQL.Replace("{V40}", PreparedStatement(obj.mUnitPriceStd2))
        strSQL = strSQL.Replace("{V41}", PreparedStatement(obj.mUnitDiscount))
        strSQL = strSQL.Replace("{V42}", PreparedStatement(obj.mUnitDiscount2))
        strSQL = strSQL.Replace("{V43}", PreparedStatement(obj.mUnitCommission))
        strSQL = strSQL.Replace("{V44}", PreparedStatement(obj.codeProject))
        strSQL = strSQL.Replace("{V45}", PreparedStatement(obj.codeDepartment))
        strSQL = strSQL.Replace("{V46}", PreparedStatement(obj.codeDealer))
        strSQL = strSQL.Replace("{V47}", PreparedStatement(obj.codeSalesman))
        strSQL = strSQL.Replace("{V48}", PreparedStatement(obj.stkId))
        strSQL = strSQL.Replace("{V49}", PreparedStatement(obj.stkLocationId))
        strSQL = strSQL.Replace("{V50}", PreparedStatement(obj.stkLocationCode))
        strSQL = strSQL.Replace("{V51}", PreparedStatement(obj.bomConvertMode))
        strSQL = strSQL.Replace("{V52}", PreparedStatement(obj.bomId))
        strSQL = strSQL.Replace("{V53}", PreparedStatement(obj.bomConvertStatus))
        strSQL = strSQL.Replace("{V54}", PreparedStatement(obj.bomConvertTime))
        strSQL = strSQL.Replace("{V55}", PreparedStatement(obj.bomConvertUser))
        strSQL = strSQL.Replace("{V56}", PreparedStatement(obj.bomTargetLoc))
        strSQL = strSQL.Replace("{V57}", PreparedStatement(obj.bomSourceLoc))
        strSQL = strSQL.Replace("{V58}", PreparedStatement(obj.warrantyType))
        strSQL = strSQL.Replace("{V59}", PreparedStatement(obj.warrantyOption))
        strSQL = strSQL.Replace("{V60}", PreparedStatement(obj.warrantyExpiry))
        strSQL = strSQL.Replace("{V61}", PreparedStatement(obj.pseudoLogic))
        strSQL = strSQL.Replace("{V62}", PreparedStatement(obj.pseudoCode))
        strSQL = strSQL.Replace("{V63}", PreparedStatement(obj.pseudoName))
        strSQL = strSQL.Replace("{V64}", PreparedStatement(obj.pseudoDescription))
        strSQL = strSQL.Replace("{V65}", PreparedStatement(obj.pseudoCurrency))
        strSQL = strSQL.Replace("{V66}", PreparedStatement(obj.pseudoPrice))
        strSQL = strSQL.Replace("{V67}", PreparedStatement(obj.pseudoQty))
        strSQL = strSQL.Replace("{V68}", PreparedStatement(obj.loyaltyLogic))
        strSQL = strSQL.Replace("{V69}", PreparedStatement(obj.loyaltyPointsAwarded))
        strSQL = strSQL.Replace("{V70}", PreparedStatement(obj.loyaltyPointsRedeemed))
        strSQL = strSQL.Replace("{V71}", PreparedStatement(obj.loyaltyProcessStatus))
        strSQL = strSQL.Replace("{V72}", PreparedStatement(obj.loyaltyProcessReversalStatus))
        strSQL = strSQL.Replace("{V73}", PreparedStatement(obj.loyaltyJTxnStatus))
        strSQL = strSQL.Replace("{V74}", PreparedStatement(obj.loyaltyJTxnReversalStatus))
        strSQL = strSQL.Replace("{V75}", PreparedStatement(obj.jobsheet_index_pkid))
        strSQL = strSQL.Replace("{V76}", PreparedStatement(obj.package_group))
        strSQL = strSQL.Replace("{V77}", PreparedStatement(obj.taxCode))
        strSQL = strSQL.Replace("{V78}", PreparedStatement(obj.taxType))
        strSQL = strSQL.Replace("{V79}", PreparedStatement(obj.taxRate))
        strSQL = strSQL.Replace("{V80}", PreparedStatement(obj.date_start))
        strSQL = strSQL.Replace("{V81}", PreparedStatement(obj.date_end))
        strSQL = strSQL.Replace("{V82}", PreparedStatement(obj.uom))
        strSQL = strSQL.Replace("{V83}", PreparedStatement(obj.taxOption))
        strSQL = strSQL.Replace("{V84}", PreparedStatement(obj.jobsheetItemId))
        strSQL = strSQL.Replace("{V85}", PreparedStatement(obj.serialNumbers))

        Return strSQL

    End Function


    '***************************************************************************
    '* GetNextID
    '**************************************************************************/
    Public Function GetNextID() As Long

        Return DAAppTableCounter.GetNextPKID(PKID, TABLENAME, "POS", START_ID)

    End Function


    '***************************************************************************
    '* GetObjectsGiven
    '**************************************************************************/
    Public Function GetDataSet(ByVal invoiceId As Long) As DataSet

        WriteToLogFile(CLASSNAME & " - In GetObjectsGiven")

        Dim comm As New Commands
        Dim strSQL As String

        strSQL = "SELECT pkid, invoice_id, item_id, item_code, name, total_quantity, unit_price_quoted, stk_id, (total_quantity*unit_price_quoted) AS total FROM cust_invoice_item WHERE invoice_id = " & invoiceid

        Try
            WriteToLogFile(strSQL)
            Return comm.ExecuteQuery(strSQL, Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetObjectsGiven - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetObjectsGiven")

    End Function

End Class

