Imports Utils.General

Public Class DAJobsheetItem

    'Constants for Table field mappings
    Private Const CLASSNAME = "DAJobsheetItem"

    Public Const PKID = "pkid"
    Public Const INDEX_ID = "index_id"
    Public Const ITEM_TYPE = "item_type"
    Public Const ITEM_ID = "item_id"
    Public Const ITEM_CODE = "item_code"
    Public Const BAR_CODE = "bar_code"
    Public Const SERIALIZED = "serialized"
    Public Const NAME = "name"
    Public Const IS_PACKAGE = "is_package"
    Public Const PARENT_ID = "parent_id"
    Public Const POSITION = "position"
    Public Const REMARKS = "remarks"
    Public Const DESCRIPTION = "description"
    Public Const PIC1 = "pic1"
    Public Const PIC2 = "pic2"
    Public Const PIC3 = "pic3"
    Public Const QUANTITY = "quantity"
    Public Const CURRENCY = "currency"
    Public Const UNIT_PRICE_LIST = "unit_price_list"
    Public Const UNIT_DISCOUNT = "unit_discount"
    Public Const UNIT_PRICE_NET = "unit_price_net"
    Public Const TAX_TYPE = "tax_type"
    Public Const UNIT_TAX = "unit_tax"
    Public Const CURRENCY2 = "currency2"
    Public Const UNIT_PRICE_LIST2 = "unit_price_list2"
    Public Const UNIT_DISCOUNT2 = "unit_discount2"
    Public Const UNIT_PRICE_NET2 = "unit_price_net2"
    Public Const TAX_TYPE2 = "tax_type2"
    Public Const UNIT_TAX2 = "unit_tax2"
    Public Const UNIT_COST_MA = "unit_cost_ma"
    Public Const UNIT_PRICE_STD = "unit_price_std"
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
    Public Const STATUS = "status"
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
    Public Const PACKAGE_GROUP = "package_group"
    Public Const EXPIRY_STATUS = "expiry_status"
    Public Const TAX_CODE = "tax_code"
    Public Const TAX_RATE = "tax_rate"
    Public Const TAX_OPTION = "tax_option"
    Public Const TAX_AMT = "taxamt"
    Public Const TAX_AMT2 = "taxamt2"

    Public Const STATUS_ACTIVE = "act"
    Public Const STATUS_DELETED = "del"
    Public Const STATUS_INACTIVE = "ina"
    Public Const STATE_CREATED = "cre"

    Public Const TABLENAME = "cust_jobsheet_item"
    Public Const NO_OF_COLUMNS As Integer = 67
    Public Const APP_NAME = "ThickClient-DataAccess"
    Public Const START_ID = 1

    '***************************************************************************
    '* Create
    '**************************************************************************/
    Public Function Create(ByVal obj As DAJobsheetItemObject) As DAJobsheetItemObject

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
    Public Sub Update(ByVal obj As DAJobsheetItemObject)

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
    '* Renove
    '**************************************************************************/
    Public Sub Remove(ByVal id As Long)

        WriteToLogFile(CLASSNAME & " - In Remove")

        Dim comm As New Commands
        Dim strSQL As String

        strSQL = "DELETE FROM {T} WHERE {1} = {V1}"

        strSQL = strSQL.Replace("{T}", TABLENAME)
        strSQL = strSQL.Replace("{1}", pkid)
        strSQL = strSQL.Replace("{V1}", id)

        Try
            WriteToLogFile(strSQL)
            comm.ExecuteNonQueryTransaction(strSQL)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - Remove - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave Remove")

    End Sub

    '***************************************************************************
    '* GetObject
    '**************************************************************************/
    Public Function GetObject(ByVal id As Long) As DAJobsheetItemObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DAJobsheetItemObject = Nothing
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
    Public Function GetObject(ByVal row As DataRow) As DAJobsheetItemObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DAJobsheetItemObject

        Try
            obj = New DAJobsheetItemObject
            obj.pkid = row(PKID)
            obj.indexId = row(INDEX_ID)
            obj.itemType = row(ITEM_TYPE)
            obj.itemId = row(ITEM_ID)
            obj.itemCode = row(ITEM_CODE)
            obj.barCode = row(BAR_CODE)
            obj.serialized = row(SERIALIZED)
            obj.name = row(NAME)
            obj.isPackage = row(IS_PACKAGE)
            obj.parentId = row(PARENT_ID)
            obj.position = row(POSITION)
            obj.remarks = row(REMARKS)
            obj.description = row(DESCRIPTION)
            obj.pic1 = row(PIC1)
            obj.pic2 = row(PIC2)
            obj.pic3 = row(PIC3)
            obj.quantity = row(QUANTITY)
            obj.currency = row(CURRENCY)
            obj.unitPriceList = row(UNIT_PRICE_LIST)
            obj.unitDiscount = row(UNIT_DISCOUNT)
            obj.unitPriceNet = row(UNIT_PRICE_NET)
            obj.taxType = row(TAX_TYPE)
            obj.unitTax = row(UNIT_TAX)
            obj.currency2 = row(CURRENCY2)
            obj.unitPriceList2 = row(UNIT_PRICE_LIST2)
            obj.unitDiscount2 = row(UNIT_DISCOUNT2)
            obj.unitPriceNet2 = row(UNIT_PRICE_NET2)
            obj.taxType2 = row(TAX_TYPE2)
            obj.unitTax2 = row(UNIT_TAX2)
            obj.unitCostMA = row(UNIT_COST_MA)
            obj.unitPriceStd = row(UNIT_PRICE_STD)
            obj.unitCommission = row(UNIT_COMMISSION)
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
            obj.status = row(STATUS)
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
            obj.package_group = row(PACKAGE_GROUP)
            obj.expiryStatus = row(EXPIRY_STATUS)
            obj.taxCode = row(TAX_CODE)
            obj.taxRate = row(TAX_RATE)
            obj.taxOption = row(TAX_OPTION)
            obj.taxAmt = row(TAX_AMT)
            obj.taxAmt2 = row(TAX_AMT2)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetObject - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetObject")

        Return obj

    End Function


    '***************************************************************************
    '* ReplaceStatement
    '**************************************************************************/
    Public Function ReplaceStatement(ByVal strSQL As String, ByVal obj As DAJobsheetItemObject) As String

        strSQL = strSQL.Replace("{T}", TABLENAME)

        strSQL = strSQL.Replace("{1}", PKID)
        strSQL = strSQL.Replace("{1}", PKID)
        strSQL = strSQL.Replace("{2}", INDEX_ID)
        strSQL = strSQL.Replace("{3}", ITEM_TYPE)
        strSQL = strSQL.Replace("{4}", ITEM_ID)
        strSQL = strSQL.Replace("{5}", ITEM_CODE)
        strSQL = strSQL.Replace("{6}", BAR_CODE)
        strSQL = strSQL.Replace("{7}", SERIALIZED)
        strSQL = strSQL.Replace("{8}", NAME)
        strSQL = strSQL.Replace("{9}", IS_PACKAGE)
        strSQL = strSQL.Replace("{10}", PARENT_ID)
        strSQL = strSQL.Replace("{11}", POSITION)
        strSQL = strSQL.Replace("{12}", REMARKS)
        strSQL = strSQL.Replace("{13}", DESCRIPTION)
        strSQL = strSQL.Replace("{14}", PIC1)
        strSQL = strSQL.Replace("{15}", PIC2)
        strSQL = strSQL.Replace("{16}", PIC3)
        strSQL = strSQL.Replace("{17}", QUANTITY)
        strSQL = strSQL.Replace("{18}", CURRENCY)
        strSQL = strSQL.Replace("{19}", UNIT_PRICE_LIST)
        strSQL = strSQL.Replace("{20}", UNIT_DISCOUNT)
        strSQL = strSQL.Replace("{21}", UNIT_PRICE_NET)
        strSQL = strSQL.Replace("{22}", TAX_TYPE)
        strSQL = strSQL.Replace("{23}", UNIT_TAX)
        strSQL = strSQL.Replace("{24}", CURRENCY2)
        strSQL = strSQL.Replace("{25}", UNIT_PRICE_LIST2)
        strSQL = strSQL.Replace("{26}", UNIT_DISCOUNT2)
        strSQL = strSQL.Replace("{27}", UNIT_PRICE_NET2)
        strSQL = strSQL.Replace("{28}", TAX_TYPE2)
        strSQL = strSQL.Replace("{29}", UNIT_TAX2)
        strSQL = strSQL.Replace("{30}", UNIT_COST_MA)
        strSQL = strSQL.Replace("{31}", UNIT_PRICE_STD)
        strSQL = strSQL.Replace("{32}", UNIT_COMMISSION)
        strSQL = strSQL.Replace("{33}", CODE_PROJECT)
        strSQL = strSQL.Replace("{34}", CODE_DEPARTMENT)
        strSQL = strSQL.Replace("{35}", CODE_DEALER)
        strSQL = strSQL.Replace("{36}", CODE_SALESMAN)
        strSQL = strSQL.Replace("{37}", STK_ID)
        strSQL = strSQL.Replace("{38}", STK_LOCATION_ID)
        strSQL = strSQL.Replace("{39}", STK_LOCATION_CODE)
        strSQL = strSQL.Replace("{40}", BOM_CONVERT_MODE)
        strSQL = strSQL.Replace("{41}", BOM_ID)
        strSQL = strSQL.Replace("{42}", BOM_CONVERT_STATUS)
        strSQL = strSQL.Replace("{43}", BOM_CONVERT_TIME)
        strSQL = strSQL.Replace("{44}", BOM_CONVERT_USER)
        strSQL = strSQL.Replace("{45}", BOM_TARGET_LOC)
        strSQL = strSQL.Replace("{46}", BOM_SOURCE_LOC)
        strSQL = strSQL.Replace("{47}", WARRANTY_TYPE)
        strSQL = strSQL.Replace("{48}", WARRANTY_OPTION)
        strSQL = strSQL.Replace("{49}", WARRANTY_EXPIRY)
        strSQL = strSQL.Replace("{50}", STATUS)
        strSQL = strSQL.Replace("{51}", PSEUDO_LOGIC)
        strSQL = strSQL.Replace("{52}", PSEUDO_CODE)
        strSQL = strSQL.Replace("{53}", PSEUDO_NAME)
        strSQL = strSQL.Replace("{54}", PSEUDO_DESCRIPTION)
        strSQL = strSQL.Replace("{55}", PSEUDO_CURRENCY)
        strSQL = strSQL.Replace("{56}", PSEUDO_PRICE)
        strSQL = strSQL.Replace("{57}", PSEUDO_QTY)
        strSQL = strSQL.Replace("{58}", LOYALTY_LOGIC)
        strSQL = strSQL.Replace("{59}", LOYALTY_POINTS_AWARDED)
        strSQL = strSQL.Replace("{60}", LOYALTY_POINTS_REDEEMED)
        strSQL = strSQL.Replace("{61}", PACKAGE_GROUP)
        strSQL = strSQL.Replace("{62}", EXPIRY_STATUS)
        strSQL = strSQL.Replace("{63}", TAX_CODE)
        strSQL = strSQL.Replace("{64}", TAX_RATE)
        strSQL = strSQL.Replace("{65}", TAX_OPTION)
        strSQL = strSQL.Replace("{66}", TAX_AMT)
        strSQL = strSQL.Replace("{67}", TAX_AMT2)


        strSQL = strSQL.Replace("{V1}", PreparedStatement(obj.pkid))
        strSQL = strSQL.Replace("{V2}", PreparedStatement(obj.indexId))
        strSQL = strSQL.Replace("{V3}", PreparedStatement(obj.itemType))
        strSQL = strSQL.Replace("{V4}", PreparedStatement(obj.itemId))
        strSQL = strSQL.Replace("{V5}", PreparedStatement(obj.itemCode))
        strSQL = strSQL.Replace("{V6}", PreparedStatement(obj.barCode))
        strSQL = strSQL.Replace("{V7}", PreparedStatement(obj.serialized))
        strSQL = strSQL.Replace("{V8}", PreparedStatement(obj.name))
        strSQL = strSQL.Replace("{V9}", PreparedStatement(obj.isPackage))
        strSQL = strSQL.Replace("{V10}", PreparedStatement(obj.parentId))
        strSQL = strSQL.Replace("{V11}", PreparedStatement(obj.position))
        strSQL = strSQL.Replace("{V12}", PreparedStatement(obj.remarks))
        strSQL = strSQL.Replace("{V13}", PreparedStatement(obj.description))
        strSQL = strSQL.Replace("{V14}", PreparedStatement(obj.pic1))
        strSQL = strSQL.Replace("{V15}", PreparedStatement(obj.pic2))
        strSQL = strSQL.Replace("{V16}", PreparedStatement(obj.pic3))
        strSQL = strSQL.Replace("{V17}", PreparedStatement(obj.quantity))
        strSQL = strSQL.Replace("{V18}", PreparedStatement(obj.currency))
        strSQL = strSQL.Replace("{V19}", PreparedStatement(obj.unitPriceList))
        strSQL = strSQL.Replace("{V20}", PreparedStatement(obj.unitDiscount))
        strSQL = strSQL.Replace("{V21}", PreparedStatement(obj.unitPriceNet))
        strSQL = strSQL.Replace("{V22}", PreparedStatement(obj.taxType))
        strSQL = strSQL.Replace("{V23}", PreparedStatement(obj.unitTax))
        strSQL = strSQL.Replace("{V24}", PreparedStatement(obj.currency2))
        strSQL = strSQL.Replace("{V25}", PreparedStatement(obj.unitPriceList2))
        strSQL = strSQL.Replace("{V26}", PreparedStatement(obj.unitDiscount2))
        strSQL = strSQL.Replace("{V27}", PreparedStatement(obj.unitPriceNet2))
        strSQL = strSQL.Replace("{V28}", PreparedStatement(obj.taxType2))
        strSQL = strSQL.Replace("{V29}", PreparedStatement(obj.unitTax2))
        strSQL = strSQL.Replace("{V30}", PreparedStatement(obj.unitCostMA))
        strSQL = strSQL.Replace("{V31}", PreparedStatement(obj.unitPriceStd))
        strSQL = strSQL.Replace("{V32}", PreparedStatement(obj.unitCommission))
        strSQL = strSQL.Replace("{V33}", PreparedStatement(obj.codeProject))
        strSQL = strSQL.Replace("{V34}", PreparedStatement(obj.codeDepartment))
        strSQL = strSQL.Replace("{V35}", PreparedStatement(obj.codeDealer))
        strSQL = strSQL.Replace("{V36}", PreparedStatement(obj.codeSalesman))
        strSQL = strSQL.Replace("{V37}", PreparedStatement(obj.stkId))
        strSQL = strSQL.Replace("{V38}", PreparedStatement(obj.stkLocationId))
        strSQL = strSQL.Replace("{V39}", PreparedStatement(obj.stkLocationCode))
        strSQL = strSQL.Replace("{V40}", PreparedStatement(obj.bomConvertMode))
        strSQL = strSQL.Replace("{V41}", PreparedStatement(obj.bomId))
        strSQL = strSQL.Replace("{V42}", PreparedStatement(obj.bomConvertStatus))
        strSQL = strSQL.Replace("{V43}", PreparedStatement(obj.bomConvertTime))
        strSQL = strSQL.Replace("{V44}", PreparedStatement(obj.bomConvertUser))
        strSQL = strSQL.Replace("{V45}", PreparedStatement(obj.bomTargetLoc))
        strSQL = strSQL.Replace("{V46}", PreparedStatement(obj.bomSourceLoc))
        strSQL = strSQL.Replace("{V47}", PreparedStatement(obj.warrantyType))
        strSQL = strSQL.Replace("{V48}", PreparedStatement(obj.warrantyOption))
        strSQL = strSQL.Replace("{V49}", PreparedStatement(obj.warrantyExpiry))
        strSQL = strSQL.Replace("{V50}", PreparedStatement(obj.status))
        strSQL = strSQL.Replace("{V51}", PreparedStatement(obj.pseudoLogic))
        strSQL = strSQL.Replace("{V52}", PreparedStatement(obj.pseudoCode))
        strSQL = strSQL.Replace("{V53}", PreparedStatement(obj.pseudoName))
        strSQL = strSQL.Replace("{V54}", PreparedStatement(obj.pseudoDescription))
        strSQL = strSQL.Replace("{V55}", PreparedStatement(obj.pseudoCurrency))
        strSQL = strSQL.Replace("{V56}", PreparedStatement(obj.pseudoPrice))
        strSQL = strSQL.Replace("{V57}", PreparedStatement(obj.pseudoQty))
        strSQL = strSQL.Replace("{V58}", PreparedStatement(obj.loyaltyLogic))
        strSQL = strSQL.Replace("{V59}", PreparedStatement(obj.loyaltyPointsAwarded))
        strSQL = strSQL.Replace("{V60}", PreparedStatement(obj.loyaltyPointsRedeemed))
        strSQL = strSQL.Replace("{V61}", PreparedStatement(obj.package_group))
        strSQL = strSQL.Replace("{V62}", PreparedStatement(obj.expiryStatus))
        strSQL = strSQL.Replace("{V63}", PreparedStatement(obj.taxCode))
        strSQL = strSQL.Replace("{V64}", PreparedStatement(obj.taxRate))
        strSQL = strSQL.Replace("{V65}", PreparedStatement(obj.taxOption))
        strSQL = strSQL.Replace("{V66}", PreparedStatement(obj.taxAmt))
        strSQL = strSQL.Replace("{V67}", PreparedStatement(obj.taxAmt2))

        Return strSQL

    End Function


    '***************************************************************************
    '* GetNextID
    '**************************************************************************/
    Public Function GetNextID() As Long
        Return DAAppTableCounter.GetNextPKID(PKID, TABLENAME, "POS", START_ID)
    End Function

End Class

