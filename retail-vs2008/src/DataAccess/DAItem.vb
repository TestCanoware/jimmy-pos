Imports Utils.General

Public Class DAItem

    'Constants for Table field mappings
    Private Const CLASSNAME = "Item"

    Public Const PKID = "pkid"
    Public Const ITEM_CODE = "item_code"
    Public Const NAME = "name"
    Public Const DESCRIPTION = "description"
    Public Const STATUS = "status"
    Public Const LASTUPDATE = "lastupdate"
    Public Const USERID_EDIT = "userid_edit"
    Public Const UOM = "uom"
    Public Const UNIT_OF_MEASURE = "unit_of_meas"
    Public Const INV_TYPE = "inv_type"
    Public Const ITEM_TYPE1 = "item_type1"
    Public Const ITEM_TYPE2 = "item_type2"
    Public Const ITEM_TYPE3 = "item_type3"
    Public Const GLCODE = "glcode"
    Public Const CATEGORYID = "categoryid"
    Public Const STATE = "state"
    Public Const CATEGORY1 = "category1"
    Public Const CATEGORY2 = "category2"
    Public Const CATEGORY3 = "category3"
    Public Const CATEGORY4 = "category4"
    Public Const CATEGORY5 = "category5"
    Public Const HAS_CHILDREN = "has_children"
    Public Const PARENTID = "parentid"
    Public Const PARENTRATIO = "parent_ratio"
    Public Const EANCODE = "ean_code"
    Public Const UPCCODE = "upc_code"
    Public Const ISBNCODE = "isbn_code"
    Public Const PRICELIST = "price_list"
    Public Const PRICESALE = "price_sale"
    Public Const PRICEDISC1 = "price_disc1"
    Public Const PRICEDISC2 = "price_disc2"
    Public Const PRICEDISC3 = "price_disc3"
    Public Const PRICEMIN = "price_min"
    Public Const FIFOUNITCOST = "fifo_unit_cost"
    Public Const MAUNITCOST = "ma_unit_cost"
    Public Const WAUNITCOST = "wa_unit_cost"
    Public Const LASTUNITCOST = "last_unit_cost"
    Public Const REPLACEMENTUNITCOST = "replacement_cost"
    Public Const SERIALIZED = "serialized"
    Public Const WEIGHT = "weight"
    Public Const LENGTH = "length"
    Public Const WIDTH = "width"
    Public Const DEPTH = "depth"
    Public Const PREFERREDSUPPLIER = "preferred_supplier"
    Public Const MINORDERQTY = "min_order_qty"
    Public Const LEADTIME = "lead_time"
    Public Const RESERVED1 = "reserved1"
    Public Const RESERVED2 = "reserved2"
    Public Const RESERVED3 = "reserved3"
    Public Const PIX_THUMB_NAME = "pix_thumb_name"
    Public Const PIX_FULL_NAME = "pix_full_name"
    Public Const PIX_THUMBNAIL = "pix_thumbnail"
    Public Const PIX_FULLSIZE = "pix_fullsize"
    Public Const REBATE1_PCT = "rebate1_pct"
    Public Const REBATE1_PRICE = "rebate1_price"
    Public Const REBATE1_START = "rebate1_start"
    Public Const REBATE1_END = "rebate1_end"
    Public Const DISC1_PCT = "disc1_pct"
    Public Const DISC1_AMOUNT = "disc1_amount"
    Public Const DISC1_START = "disc1_start"
    Public Const DISC1_END = "disc1_end"
    Public Const PRODUCTION_REQUIRED = "production_required"
    Public Const PRODUCTION_LEAD_TIME = "production_lead_time"
    Public Const PRODUCTION_COST = "production_cost"
    Public Const PRODUCTION_PROCESS = "production_process"
    Public Const PRODUCTION_NAME = "production_name"
    Public Const PRODUCTION_DESCRIPTION = "production_description"
    Public Const DELIVERY_REQUIRED = "delivery_required"
    Public Const DELIVERY_LEAD_TIME = "delivery_lead_time"
    Public Const DELIVERY_COST = "delivery_cost"
    Public Const DELIVERY_PROCESS = "delivery_process"
    Public Const DELIVERY_NAME = "delivery_name"
    Public Const DELIVERY_DESCRIPTION = "delivery_description"
    Public Const DELTA_PRICE_RETAIL_AMT = "delta_price_retail_amt"
    Public Const DELTA_PRICE_RETAIL_PCT = "delta_price_retail_pct"
    Public Const DELTA_PRICE_DEALER_AMT = "delta_price_dealer_amt"
    Public Const DELTA_PRICE_DEALER_PCT = "delta_price_dealer_pct"
    Public Const DELTA_PRICE_OUTLET_AMT = "delta_price_outlet_amt"
    Public Const DELTA_PRICE_OUTLET_PCT = "delta_price_outlet_pct"
    Public Const DISC_MAX_PCT = "disc_max_pct"
    Public Const WARRANTY_TYPE = "warranty_type"
    Public Const WARRANTY_PERIOD = "warranty_period"
    Public Const SHELF_LIFE = "shelf_life"
    Public Const COMMISSION_PCT_SALES1 = "commission_pct_sales1"
    Public Const COMMISSION_PCT_SALES2 = "commission_pct_sales2"
    Public Const COMMISSION_PCT_SALES3 = "commission_pct_sales3"
    Public Const COMMISSION_PCT_SALES4 = "commission_pct_sales4"
    Public Const COMMISSION_PCT_PARTNER = "commission_pct_partner"
    Public Const COMMISSION_PCT_GP = "commission_pct_gp"
    Public Const LOGIC_REORDER = "logic_reorder"
    Public Const LOGIC_MAX_QTY = "logic_max_qty"
    Public Const THRESHOLD_QTY_REORDER = "threshold_qty_reorder"
    Public Const THRESHOLD_QTY_MAX_QTY = "threshold_qty_max_qty"
    Public Const REMARKS1 = "remarks1"
    Public Const REMARKS2 = "remarks2"
    Public Const KEYWORDS = "keywords"
    Public Const PREFIX_LOGIC = "prefix_logic"
    Public Const PREFIX_LENGTH = "prefix_length"
    Public Const PREFIX_CODE = "prefix_code"
    Public Const POSTFIX_LOGIC = "postfix_logic"
    Public Const POSTFIX_LENGTH = "postfix_length"
    Public Const POSTFIX_CODE = "postfix_code"
    Public Const CODE_PROJECT = "code_project"
    Public Const CODE_DEPARTMENT = "code_department"
    Public Const CODE_DEALER = "code_dealer"
    Public Const CODE_SALESMAN = "code_salesman"
    Public Const TAX_OPTION = "tax_option"
    Public Const TAX_RATE = "tax_rate"
    Public Const PRICEECOM = "price_ecom"
    Public Const OUT_QTY = "out_qty"
    Public Const OUT_UNIT = "out_unit"
    Public Const IN_QTY = "in_qty"
    Public Const IN_UNIT = "in_unit"
    Public Const INN_QTY = "inn_qty"
    Public Const INN_UNIT = "inn_unit"
    Public Const INM_QTY = "inm_qty"
    Public Const INM_UNIT = "inm_unit"
    Public Const PURCHASE_PRICE_MINIMUM = "purchase_price_minimum"
    Public Const PURCHASE_PRICE_MAXIMUM = "purchase_price_maximum"
    Public Const TAX_CODE = "tax_code"
    Public Const TAX_TYPE = "tax_type"
    Public Const NEXT_SERVICE_MINUTE = "next_service_minute"
    Public Const NEXT_SERVICE_HOUR = "next_service_hour"
    Public Const NEXT_SERVICE_DAY = "next_service_day"
    Public Const NEXT_SERVICE_MONTH = "next_service_month"
    Public Const NEXT_SERVICE_YEAR = "next_service_year"
    Public Const NEXT_SERVICE_USAGE = "next_service_usage"

    Public Const ITEM_TYPE_INVENTORY = "inv"
    Public Const ITEM_TYPE_NON_INVENTORY = "noninv"
    Public Const ITEM_TYPE_SERVICE = "svc"
    Public Const TAX_ENABLED = "ENABLED"

    Public Const TABLENAME = "inv_item"
    Public Const NO_OF_COLUMNS As Integer = 127
    Public Const APP_NAME = "ThickClient-DataAccess"

    '***************************************************************************
    '* Create
    '**************************************************************************/
    Public Function Create(ByVal obj As DAItemObject) As DAItemObject

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
    Public Sub Update(ByVal obj As DAItemObject)

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
    Public Function GetObject(ByVal id As Integer) As DAItemObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DAItemObject = Nothing
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
    '* GetObjectByCode
    '**************************************************************************/
    Public Function GetObjectByCode(ByVal itemCode As String) As DAItemObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DAItemObject = Nothing
        Dim ds As DataSet
        Dim strSQL As String
        Dim row As DataRow

        strSQL = "SELECT * FROM {T} WHERE {1} = '{V1}' ORDER BY {1}"

        strSQL = strSQL.Replace("{T}", TABLENAME)
        strSQL = strSQL.Replace("{1}", ITEM_CODE)
        strSQL = strSQL.Replace("{V1}", itemCode)

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
        strSQL = strSQL.Replace("{1}", ITEM_CODE)

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
        strSQL = strSQL.Replace("{2}", ITEM_CODE)

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
    Public Function GetObject(ByVal row As DataRow) As DAItemObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DAItemObject

        Try
            obj = New DAItemObject
            obj.pkid = row(PKID)
            obj.code = row(ITEM_CODE)
            obj.name = row(NAME)
            obj.description = row(DESCRIPTION)
            obj.status = row(STATUS)
            obj.lastUpdate = row(LASTUPDATE)
            obj.userIdUpdate = row(USERID_EDIT)
            obj.uom = row(UOM)
            obj.unitOfMeasure = row(UNIT_OF_MEASURE)
            obj.enumInvType = row(INV_TYPE)
            obj.itemType1 = row(ITEM_TYPE1)
            obj.itemType2 = row(ITEM_TYPE2)
            obj.itemType3 = row(ITEM_TYPE3)
            obj.glcode = row(GLCODE)
            obj.categoryId = row(CATEGORYID)
            obj.state = row(STATE)
            obj.category1 = row(CATEGORY1)
            obj.category2 = row(CATEGORY2)
            obj.category3 = row(CATEGORY3)
            obj.category4 = row(CATEGORY4)
            obj.category5 = row(CATEGORY5)
            obj.hasChildren = row(HAS_CHILDREN)
            obj.parentId = row(PARENTID)
            obj.parentRatio = row(PARENTRATIO)
            obj.eanCode = row(EANCODE)
            obj.upcCode = row(UPCCODE)
            obj.isbnCode = row(ISBNCODE)
            obj.priceList = row(PRICELIST)
            obj.priceSale = row(PRICESALE)
            obj.priceDisc1 = row(PRICEDISC1)
            obj.priceDisc2 = row(PRICEDISC2)
            obj.priceDisc3 = row(PRICEDISC3)
            obj.priceMin = row(PRICEMIN)
            obj.fifoUnitCost = row(FIFOUNITCOST)
            obj.maUnitCost = row(MAUNITCOST)
            obj.waUnitCost = row(WAUNITCOST)
            obj.lastUnitCost = row(LASTUNITCOST)
            obj.replacementUnitCost = row(REPLACEMENTUNITCOST)
            obj.serialized = row(SERIALIZED)
            obj.weight = row(WEIGHT)
            obj.length = row(LENGTH)
            obj.width = row(WIDTH)
            obj.depth = row(DEPTH)
            obj.preferredSupplier = row(PREFERREDSUPPLIER)
            obj.minOrderQty = row(MINORDERQTY)
            obj.leadTime = row(LEADTIME)
            obj.reserved1 = row(RESERVED1)
            obj.reserved2 = row(RESERVED2)
            obj.reserved3 = row(RESERVED3)
            obj.pixThumbName = row(PIX_THUMB_NAME)
            obj.pixFullName = row(PIX_FULL_NAME)
            obj.pixThumbnail = row(PIX_THUMBNAIL)
            obj.pixFullsize = row(PIX_FULLSIZE)
            obj.rebate1Pct = row(REBATE1_PCT)
            obj.rebate1Price = row(REBATE1_PRICE)
            obj.rebate1Start = row(REBATE1_START)
            obj.rebate1End = row(REBATE1_END)
            obj.disc1Pct = row(DISC1_PCT)
            obj.disc1Amount = row(DISC1_AMOUNT)
            obj.disc1Start = row(DISC1_START)
            obj.disc1End = row(DISC1_END)
            obj.productionRequired = row(PRODUCTION_REQUIRED)
            obj.productionLeadTime = row(PRODUCTION_LEAD_TIME)
            obj.productionCost = row(PRODUCTION_COST)
            obj.productionProcess = row(PRODUCTION_PROCESS)
            obj.productionName = row(PRODUCTION_NAME)
            obj.productionDescription = row(PRODUCTION_DESCRIPTION)
            obj.deliveryRequired = row(DELIVERY_REQUIRED)
            obj.deliveryLeadTime = row(DELIVERY_LEAD_TIME)
            obj.deliveryCost = row(DELIVERY_COST)
            obj.deliveryProcess = row(DELIVERY_PROCESS)
            obj.deliveryName = row(DELIVERY_NAME)
            obj.deliveryDescription = row(DELIVERY_DESCRIPTION)
            obj.deltaPriceRetailAmt = row(DELTA_PRICE_RETAIL_AMT)
            obj.deltaPriceRetailPct = row(DELTA_PRICE_RETAIL_PCT)
            obj.deltaPriceDealerAmt = row(DELTA_PRICE_DEALER_AMT)
            obj.deltaPriceDealerPct = row(DELTA_PRICE_DEALER_PCT)
            obj.deltaPriceOutletAmt = row(DELTA_PRICE_OUTLET_AMT)
            obj.deltaPriceOutletPct = row(DELTA_PRICE_OUTLET_PCT)
            obj.discMaxPct = row(DISC_MAX_PCT)
            obj.warrantyType = row(WARRANTY_TYPE)
            obj.warrantyPeriod = row(WARRANTY_PERIOD)
            obj.shelfLife = row(SHELF_LIFE)
            obj.commissionPctSales1 = row(COMMISSION_PCT_SALES1)
            obj.commissionPctSales2 = row(COMMISSION_PCT_SALES2)
            obj.commissionPctSales3 = row(COMMISSION_PCT_SALES3)
            obj.commissionPctSales4 = row(COMMISSION_PCT_SALES4)
            obj.commissionPctPartner = row(COMMISSION_PCT_PARTNER)
            obj.commissionPctGP = row(COMMISSION_PCT_GP)
            obj.logicReorder = row(LOGIC_REORDER)
            obj.logicMaxQty = row(LOGIC_MAX_QTY)
            obj.thresholdQtyReorder = row(THRESHOLD_QTY_REORDER)
            obj.thresholdQtyMaxQty = row(THRESHOLD_QTY_MAX_QTY)
            obj.remarks1 = row(REMARKS1)
            obj.remarks2 = row(REMARKS2)
            obj.keywords = row(KEYWORDS)
            obj.prefixLogic = row(PREFIX_LOGIC)
            obj.prefixLength = row(PREFIX_LENGTH)
            obj.prefixCode = row(PREFIX_CODE)
            obj.postfixLogic = row(POSTFIX_LOGIC)
            obj.postfixLength = row(POSTFIX_LENGTH)
            obj.postfixCode = row(POSTFIX_CODE)
            obj.codeProject = row(CODE_PROJECT)
            obj.codeDepartment = row(CODE_DEPARTMENT)
            obj.codeDealer = row(CODE_DEALER)
            obj.codeSalesman = row(CODE_SALESMAN)
            obj.tax_option = row(TAX_OPTION)
            obj.tax_rate = row(TAX_RATE)
            obj.priceEcom = row(PRICEECOM)
            obj.outQty = row(OUT_QTY)
            obj.outUnit = row(OUT_UNIT)
            obj.inQty = row(IN_QTY)
            obj.inUnit = row(IN_UNIT)
            obj.innQty = row(INN_QTY)
            obj.innUnit = row(INN_UNIT)
            obj.inmQty = row(INM_QTY)
            obj.inmUnit = row(INM_UNIT)
            obj.purchasePriceMinimum = row(PURCHASE_PRICE_MINIMUM)
            obj.purchasePriceMaximum = row(PURCHASE_PRICE_MAXIMUM)
            obj.taxCode = row(TAX_CODE)
            obj.taxType = row(TAX_TYPE)
            obj.nextServiceMinute = row(NEXT_SERVICE_MINUTE)
            obj.nextServiceHour = row(NEXT_SERVICE_HOUR)
            obj.nextServiceDay = row(NEXT_SERVICE_DAY)
            obj.nextServiceMonth = row(NEXT_SERVICE_MONTH)
            obj.nextServiceYear = row(NEXT_SERVICE_YEAR)
            obj.nextServiceUsage = row(NEXT_SERVICE_USAGE)


        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetObject - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetObject")

        Return obj

    End Function


    Public Function ReplaceStatement(ByVal strSQL As String, ByVal obj As DAItemObject) As String

        strSQL = strSQL.Replace("{T}", TABLENAME)

        strSQL = strSQL.Replace("{1}", PKID)
        strSQL = strSQL.Replace("{2}", ITEM_CODE)
        strSQL = strSQL.Replace("{3}", NAME)
        strSQL = strSQL.Replace("{4}", DESCRIPTION)
        strSQL = strSQL.Replace("{5}", STATUS)
        strSQL = strSQL.Replace("{6}", LASTUPDATE)
        strSQL = strSQL.Replace("{7}", USERID_EDIT)
        strSQL = strSQL.Replace("{8}", UOM)
        strSQL = strSQL.Replace("{9}", UNIT_OF_MEASURE)
        strSQL = strSQL.Replace("{10}", INV_TYPE)
        strSQL = strSQL.Replace("{11}", ITEM_TYPE1)
        strSQL = strSQL.Replace("{12}", ITEM_TYPE2)
        strSQL = strSQL.Replace("{13}", ITEM_TYPE3)
        strSQL = strSQL.Replace("{14}", GLCODE)
        strSQL = strSQL.Replace("{15}", CATEGORYID)
        strSQL = strSQL.Replace("{16}", STATE)
        strSQL = strSQL.Replace("{17}", CATEGORY1)
        strSQL = strSQL.Replace("{18}", CATEGORY2)
        strSQL = strSQL.Replace("{19}", CATEGORY3)
        strSQL = strSQL.Replace("{20}", CATEGORY4)
        strSQL = strSQL.Replace("{21}", CATEGORY5)
        strSQL = strSQL.Replace("{22}", HAS_CHILDREN)
        strSQL = strSQL.Replace("{23}", PARENTID)
        strSQL = strSQL.Replace("{24}", PARENTRATIO)
        strSQL = strSQL.Replace("{25}", EANCODE)
        strSQL = strSQL.Replace("{26}", UPCCODE)
        strSQL = strSQL.Replace("{27}", ISBNCODE)
        strSQL = strSQL.Replace("{28}", PRICELIST)
        strSQL = strSQL.Replace("{29}", PRICESALE)
        strSQL = strSQL.Replace("{30}", PRICEDISC1)
        strSQL = strSQL.Replace("{31}", PRICEDISC2)
        strSQL = strSQL.Replace("{32}", PRICEDISC3)
        strSQL = strSQL.Replace("{33}", PRICEMIN)
        strSQL = strSQL.Replace("{34}", FIFOUNITCOST)
        strSQL = strSQL.Replace("{35}", MAUNITCOST)
        strSQL = strSQL.Replace("{36}", WAUNITCOST)
        strSQL = strSQL.Replace("{37}", LASTUNITCOST)
        strSQL = strSQL.Replace("{38}", REPLACEMENTUNITCOST)
        strSQL = strSQL.Replace("{39}", SERIALIZED)
        strSQL = strSQL.Replace("{40}", WEIGHT)
        strSQL = strSQL.Replace("{41}", LENGTH)
        strSQL = strSQL.Replace("{42}", WIDTH)
        strSQL = strSQL.Replace("{43}", DEPTH)
        strSQL = strSQL.Replace("{44}", PREFERREDSUPPLIER)
        strSQL = strSQL.Replace("{45}", MINORDERQTY)
        strSQL = strSQL.Replace("{46}", LEADTIME)
        strSQL = strSQL.Replace("{47}", RESERVED1)
        strSQL = strSQL.Replace("{48}", RESERVED2)
        strSQL = strSQL.Replace("{49}", RESERVED3)
        strSQL = strSQL.Replace("{50}", PIX_THUMB_NAME)
        strSQL = strSQL.Replace("{51}", PIX_FULL_NAME)
        strSQL = strSQL.Replace("{52}", PIX_THUMBNAIL)
        strSQL = strSQL.Replace("{53}", PIX_FULLSIZE)
        strSQL = strSQL.Replace("{54}", REBATE1_PCT)
        strSQL = strSQL.Replace("{55}", REBATE1_PRICE)
        strSQL = strSQL.Replace("{56}", REBATE1_START)
        strSQL = strSQL.Replace("{57}", REBATE1_END)
        strSQL = strSQL.Replace("{58}", DISC1_PCT)
        strSQL = strSQL.Replace("{59}", DISC1_AMOUNT)
        strSQL = strSQL.Replace("{60}", DISC1_START)
        strSQL = strSQL.Replace("{61}", DISC1_END)
        strSQL = strSQL.Replace("{62}", PRODUCTION_REQUIRED)
        strSQL = strSQL.Replace("{63}", PRODUCTION_LEAD_TIME)
        strSQL = strSQL.Replace("{64}", PRODUCTION_COST)
        strSQL = strSQL.Replace("{65}", PRODUCTION_PROCESS)
        strSQL = strSQL.Replace("{66}", PRODUCTION_NAME)
        strSQL = strSQL.Replace("{67}", PRODUCTION_DESCRIPTION)
        strSQL = strSQL.Replace("{68}", DELIVERY_REQUIRED)
        strSQL = strSQL.Replace("{69}", DELIVERY_LEAD_TIME)
        strSQL = strSQL.Replace("{70}", DELIVERY_COST)
        strSQL = strSQL.Replace("{71}", DELIVERY_PROCESS)
        strSQL = strSQL.Replace("{72}", DELIVERY_NAME)
        strSQL = strSQL.Replace("{73}", DELIVERY_DESCRIPTION)
        strSQL = strSQL.Replace("{74}", DELTA_PRICE_RETAIL_AMT)
        strSQL = strSQL.Replace("{75}", DELTA_PRICE_RETAIL_PCT)
        strSQL = strSQL.Replace("{76}", DELTA_PRICE_DEALER_AMT)
        strSQL = strSQL.Replace("{77}", DELTA_PRICE_DEALER_PCT)
        strSQL = strSQL.Replace("{78}", DELTA_PRICE_OUTLET_AMT)
        strSQL = strSQL.Replace("{79}", DELTA_PRICE_OUTLET_PCT)
        strSQL = strSQL.Replace("{80}", DISC_MAX_PCT)
        strSQL = strSQL.Replace("{81}", WARRANTY_TYPE)
        strSQL = strSQL.Replace("{82}", WARRANTY_PERIOD)
        strSQL = strSQL.Replace("{83}", SHELF_LIFE)
        strSQL = strSQL.Replace("{84}", COMMISSION_PCT_SALES1)
        strSQL = strSQL.Replace("{85}", COMMISSION_PCT_SALES2)
        strSQL = strSQL.Replace("{86}", COMMISSION_PCT_SALES3)
        strSQL = strSQL.Replace("{87}", COMMISSION_PCT_SALES4)
        strSQL = strSQL.Replace("{88}", COMMISSION_PCT_PARTNER)
        strSQL = strSQL.Replace("{89}", COMMISSION_PCT_GP)
        strSQL = strSQL.Replace("{90}", LOGIC_REORDER)
        strSQL = strSQL.Replace("{91}", LOGIC_MAX_QTY)
        strSQL = strSQL.Replace("{92}", THRESHOLD_QTY_REORDER)
        strSQL = strSQL.Replace("{93}", THRESHOLD_QTY_MAX_QTY)
        strSQL = strSQL.Replace("{94}", REMARKS1)
        strSQL = strSQL.Replace("{95}", REMARKS2)
        strSQL = strSQL.Replace("{96}", KEYWORDS)
        strSQL = strSQL.Replace("{97}", PREFIX_LOGIC)
        strSQL = strSQL.Replace("{98}", PREFIX_LENGTH)
        strSQL = strSQL.Replace("{99}", PREFIX_CODE)
        strSQL = strSQL.Replace("{100}", POSTFIX_LOGIC)
        strSQL = strSQL.Replace("{101}", POSTFIX_LENGTH)
        strSQL = strSQL.Replace("{102}", POSTFIX_CODE)
        strSQL = strSQL.Replace("{103}", CODE_PROJECT)
        strSQL = strSQL.Replace("{104}", CODE_DEPARTMENT)
        strSQL = strSQL.Replace("{105}", CODE_DEALER)
        strSQL = strSQL.Replace("{106}", CODE_SALESMAN)
        strSQL = strSQL.Replace("{107}", TAX_OPTION)
        strSQL = strSQL.Replace("{108}", TAX_RATE)
        strSQL = strSQL.Replace("{109}", PRICEECOM)
        strSQL = strSQL.Replace("{110}", OUT_QTY)
        strSQL = strSQL.Replace("{111}", OUT_UNIT)
        strSQL = strSQL.Replace("{112}", IN_QTY)
        strSQL = strSQL.Replace("{113}", IN_UNIT)
        strSQL = strSQL.Replace("{114}", INN_QTY)
        strSQL = strSQL.Replace("{115}", INN_UNIT)
        strSQL = strSQL.Replace("{116}", INM_QTY)
        strSQL = strSQL.Replace("{117}", INM_UNIT)
        strSQL = strSQL.Replace("{118}", PURCHASE_PRICE_MINIMUM)
        strSQL = strSQL.Replace("{119}", PURCHASE_PRICE_MAXIMUM)
        strSQL = strSQL.Replace("{120}", TAX_CODE)
        strSQL = strSQL.Replace("{121}", TAX_TYPE)
        strSQL = strSQL.Replace("{122}", NEXT_SERVICE_MINUTE)
        strSQL = strSQL.Replace("{123}", NEXT_SERVICE_HOUR)
        strSQL = strSQL.Replace("{124}", NEXT_SERVICE_DAY)
        strSQL = strSQL.Replace("{125}", NEXT_SERVICE_MONTH)
        strSQL = strSQL.Replace("{126}", NEXT_SERVICE_YEAR)
        strSQL = strSQL.Replace("{127}", NEXT_SERVICE_USAGE)

        strSQL = strSQL.Replace("{V1}", PreparedStatement(obj.pkid))
        strSQL = strSQL.Replace("{V2}", PreparedStatement(obj.code))
        strSQL = strSQL.Replace("{V3}", PreparedStatement(obj.name))
        strSQL = strSQL.Replace("{V4}", PreparedStatement(obj.description))
        strSQL = strSQL.Replace("{V5}", PreparedStatement(obj.status))
        strSQL = strSQL.Replace("{V6}", PreparedStatement(obj.lastUpdate))
        strSQL = strSQL.Replace("{V7}", PreparedStatement(obj.userIdUpdate))
        strSQL = strSQL.Replace("{V8}", PreparedStatement(obj.uom))
        strSQL = strSQL.Replace("{V9}", PreparedStatement(obj.unitOfMeasure))
        strSQL = strSQL.Replace("{V10}", PreparedStatement(obj.enumInvType))
        strSQL = strSQL.Replace("{V11}", PreparedStatement(obj.itemType1))
        strSQL = strSQL.Replace("{V12}", PreparedStatement(obj.itemType2))
        strSQL = strSQL.Replace("{V13}", PreparedStatement(obj.itemType3))
        strSQL = strSQL.Replace("{V14}", PreparedStatement(obj.glcode))
        strSQL = strSQL.Replace("{V15}", PreparedStatement(obj.categoryId))
        strSQL = strSQL.Replace("{V16}", PreparedStatement(obj.state))
        strSQL = strSQL.Replace("{V17}", PreparedStatement(obj.category1))
        strSQL = strSQL.Replace("{V18}", PreparedStatement(obj.category2))
        strSQL = strSQL.Replace("{V19}", PreparedStatement(obj.category3))
        strSQL = strSQL.Replace("{V20}", PreparedStatement(obj.category4))
        strSQL = strSQL.Replace("{V21}", PreparedStatement(obj.category5))
        strSQL = strSQL.Replace("{V22}", PreparedStatement(obj.hasChildren))
        strSQL = strSQL.Replace("{V23}", PreparedStatement(obj.parentId))
        strSQL = strSQL.Replace("{V24}", PreparedStatement(obj.parentRatio))
        strSQL = strSQL.Replace("{V25}", PreparedStatement(obj.eanCode))
        strSQL = strSQL.Replace("{V26}", PreparedStatement(obj.upcCode))
        strSQL = strSQL.Replace("{V27}", PreparedStatement(obj.isbnCode))
        strSQL = strSQL.Replace("{V28}", PreparedStatement(obj.priceList))
        strSQL = strSQL.Replace("{V29}", PreparedStatement(obj.priceSale))
        strSQL = strSQL.Replace("{V30}", PreparedStatement(obj.priceDisc1))
        strSQL = strSQL.Replace("{V31}", PreparedStatement(obj.priceDisc2))
        strSQL = strSQL.Replace("{V32}", PreparedStatement(obj.priceDisc3))
        strSQL = strSQL.Replace("{V33}", PreparedStatement(obj.priceMin))
        strSQL = strSQL.Replace("{V34}", PreparedStatement(obj.fifoUnitCost))
        strSQL = strSQL.Replace("{V35}", PreparedStatement(obj.maUnitCost))
        strSQL = strSQL.Replace("{V36}", PreparedStatement(obj.waUnitCost))
        strSQL = strSQL.Replace("{V37}", PreparedStatement(obj.lastUnitCost))
        strSQL = strSQL.Replace("{V38}", PreparedStatement(obj.replacementUnitCost))
        strSQL = strSQL.Replace("{V39}", PreparedStatement(obj.serialized))
        strSQL = strSQL.Replace("{V40}", PreparedStatement(obj.weight))
        strSQL = strSQL.Replace("{V41}", PreparedStatement(obj.length))
        strSQL = strSQL.Replace("{V42}", PreparedStatement(obj.width))
        strSQL = strSQL.Replace("{V43}", PreparedStatement(obj.depth))
        strSQL = strSQL.Replace("{V44}", PreparedStatement(obj.preferredSupplier))
        strSQL = strSQL.Replace("{V45}", PreparedStatement(obj.minOrderQty))
        strSQL = strSQL.Replace("{V46}", PreparedStatement(obj.leadTime))
        strSQL = strSQL.Replace("{V47}", PreparedStatement(obj.reserved1))
        strSQL = strSQL.Replace("{V48}", PreparedStatement(obj.reserved2))
        strSQL = strSQL.Replace("{V49}", PreparedStatement(obj.reserved3))
        strSQL = strSQL.Replace("{V50}", PreparedStatement(obj.pixThumbName))
        strSQL = strSQL.Replace("{V51}", PreparedStatement(obj.pixFullName))
        strSQL = strSQL.Replace("{V52}", PreparedStatement(obj.pixThumbnail))
        strSQL = strSQL.Replace("{V53}", PreparedStatement(obj.pixFullsize))
        strSQL = strSQL.Replace("{V54}", PreparedStatement(obj.rebate1Pct))
        strSQL = strSQL.Replace("{V55}", PreparedStatement(obj.rebate1Price))
        strSQL = strSQL.Replace("{V56}", PreparedStatement(obj.rebate1Start))
        strSQL = strSQL.Replace("{V57}", PreparedStatement(obj.rebate1End))
        strSQL = strSQL.Replace("{V58}", PreparedStatement(obj.disc1Pct))
        strSQL = strSQL.Replace("{V59}", PreparedStatement(obj.disc1Amount))
        strSQL = strSQL.Replace("{V60}", PreparedStatement(obj.disc1Start))
        strSQL = strSQL.Replace("{V61}", PreparedStatement(obj.disc1End))
        strSQL = strSQL.Replace("{V62}", PreparedStatement(obj.productionRequired))
        strSQL = strSQL.Replace("{V63}", PreparedStatement(obj.productionLeadTime))
        strSQL = strSQL.Replace("{V64}", PreparedStatement(obj.productionCost))
        strSQL = strSQL.Replace("{V65}", PreparedStatement(obj.productionProcess))
        strSQL = strSQL.Replace("{V66}", PreparedStatement(obj.productionName))
        strSQL = strSQL.Replace("{V67}", PreparedStatement(obj.productionDescription))
        strSQL = strSQL.Replace("{V68}", PreparedStatement(obj.deliveryRequired))
        strSQL = strSQL.Replace("{V69}", PreparedStatement(obj.deliveryLeadTime))
        strSQL = strSQL.Replace("{V70}", PreparedStatement(obj.deliveryCost))
        strSQL = strSQL.Replace("{V71}", PreparedStatement(obj.deliveryProcess))
        strSQL = strSQL.Replace("{V72}", PreparedStatement(obj.deliveryName))
        strSQL = strSQL.Replace("{V73}", PreparedStatement(obj.deliveryDescription))
        strSQL = strSQL.Replace("{V74}", PreparedStatement(obj.deltaPriceRetailAmt))
        strSQL = strSQL.Replace("{V75}", PreparedStatement(obj.deltaPriceRetailPct))
        strSQL = strSQL.Replace("{V76}", PreparedStatement(obj.deltaPriceDealerAmt))
        strSQL = strSQL.Replace("{V77}", PreparedStatement(obj.deltaPriceDealerPct))
        strSQL = strSQL.Replace("{V78}", PreparedStatement(obj.deltaPriceOutletAmt))
        strSQL = strSQL.Replace("{V79}", PreparedStatement(obj.deltaPriceOutletPct))
        strSQL = strSQL.Replace("{V80}", PreparedStatement(obj.discMaxPct))
        strSQL = strSQL.Replace("{V81}", PreparedStatement(obj.warrantyType))
        strSQL = strSQL.Replace("{V82}", PreparedStatement(obj.warrantyPeriod))
        strSQL = strSQL.Replace("{V83}", PreparedStatement(obj.shelfLife))
        strSQL = strSQL.Replace("{V84}", PreparedStatement(obj.commissionPctSales1))
        strSQL = strSQL.Replace("{V85}", PreparedStatement(obj.commissionPctSales2))
        strSQL = strSQL.Replace("{V86}", PreparedStatement(obj.commissionPctSales3))
        strSQL = strSQL.Replace("{V87}", PreparedStatement(obj.commissionPctSales4))
        strSQL = strSQL.Replace("{V88}", PreparedStatement(obj.commissionPctPartner))
        strSQL = strSQL.Replace("{V89}", PreparedStatement(obj.commissionPctGP))
        strSQL = strSQL.Replace("{V90}", PreparedStatement(obj.logicReorder))
        strSQL = strSQL.Replace("{V91}", PreparedStatement(obj.logicMaxQty))
        strSQL = strSQL.Replace("{V92}", PreparedStatement(obj.thresholdQtyReorder))
        strSQL = strSQL.Replace("{V93}", PreparedStatement(obj.thresholdQtyMaxQty))
        strSQL = strSQL.Replace("{V94}", PreparedStatement(obj.remarks1))
        strSQL = strSQL.Replace("{V95}", PreparedStatement(obj.remarks2))
        strSQL = strSQL.Replace("{V96}", PreparedStatement(obj.keywords))
        strSQL = strSQL.Replace("{V97}", PreparedStatement(obj.prefixLogic))
        strSQL = strSQL.Replace("{V98}", PreparedStatement(obj.prefixLength))
        strSQL = strSQL.Replace("{V99}", PreparedStatement(obj.prefixCode))
        strSQL = strSQL.Replace("{V100}", PreparedStatement(obj.postfixLogic))
        strSQL = strSQL.Replace("{V101}", PreparedStatement(obj.postfixLength))
        strSQL = strSQL.Replace("{V102}", PreparedStatement(obj.postfixCode))
        strSQL = strSQL.Replace("{V103}", PreparedStatement(obj.codeProject))
        strSQL = strSQL.Replace("{V104}", PreparedStatement(obj.codeDepartment))
        strSQL = strSQL.Replace("{V105}", PreparedStatement(obj.codeDealer))
        strSQL = strSQL.Replace("{V106}", PreparedStatement(obj.codeSalesman))
        strSQL = strSQL.Replace("{V107}", PreparedStatement(obj.tax_option))
        strSQL = strSQL.Replace("{V108}", PreparedStatement(obj.tax_rate))
        strSQL = strSQL.Replace("{V109}", PreparedStatement(obj.priceEcom))
        strSQL = strSQL.Replace("{V110}", PreparedStatement(obj.outQty))
        strSQL = strSQL.Replace("{V111}", PreparedStatement(obj.outUnit))
        strSQL = strSQL.Replace("{V112}", PreparedStatement(obj.inQty))
        strSQL = strSQL.Replace("{V113}", PreparedStatement(obj.inUnit))
        strSQL = strSQL.Replace("{V114}", PreparedStatement(obj.innQty))
        strSQL = strSQL.Replace("{V115}", PreparedStatement(obj.innUnit))
        strSQL = strSQL.Replace("{V116}", PreparedStatement(obj.inmQty))
        strSQL = strSQL.Replace("{V117}", PreparedStatement(obj.inmUnit))
        strSQL = strSQL.Replace("{V118}", PreparedStatement(obj.purchasePriceMinimum))
        strSQL = strSQL.Replace("{V119}", PreparedStatement(obj.purchasePriceMaximum))
        strSQL = strSQL.Replace("{V120}", PreparedStatement(obj.taxCode))
        strSQL = strSQL.Replace("{V121}", PreparedStatement(obj.taxType))
        strSQL = strSQL.Replace("{V122}", PreparedStatement(obj.nextServiceMinute))
        strSQL = strSQL.Replace("{V123}", PreparedStatement(obj.nextServiceHour))
        strSQL = strSQL.Replace("{V124}", PreparedStatement(obj.nextServiceDay))
        strSQL = strSQL.Replace("{V125}", PreparedStatement(obj.nextServiceMonth))
        strSQL = strSQL.Replace("{V126}", PreparedStatement(obj.nextServiceYear))
        strSQL = strSQL.Replace("{V127}", PreparedStatement(obj.nextServiceUsage))


        Return strSQL

    End Function

End Class

