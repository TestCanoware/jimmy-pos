'Imports ThickClient.EMPThickClientService
Imports ThickClient.EMPThickClientWebReference
Imports DataAccess
Imports Utils
Imports Utils.General
Imports System.Reflection
Imports System.Text

Public Class DataAccessNut

#Region " Variables "

    Private Const CLASSNAME = "DataAccessNut"
    Private Const RECEIPT_OBJECT = "com.vlee.ejb.accounting.OfficialReceiptObject"
    Private Const INVOICE_OBJECT = "com.vlee.ejb.customer.InvoiceObject"
    Private Const INVOICE_ITEM_OBJECT = "com.vlee.ejb.customer.InvoiceItemObject"
    Private Const POS_END_DAY_CLOSING_OBJECT = "com.vlee.ejb.customer.POSEndDayClosingObject"

#End Region

#Region " Get Methods "


    Public Function GetPosConfig(ByVal namespace1 As String) As String

        Dim objDA As New DAPosConfig
        Dim obj As DAPosConfigObject = Nothing

        Try
            If namespace1 = "" Then Return ""

            obj = objDA.GetObject(namespace1)
            If obj Is Nothing Then
                obj = New DAPosConfigObject
                obj.name_space = namespace1
                obj.userIdEdit = gUserObj.userid
                obj.timeEdit = Now

                Select Case namespace1
                    Case "POS_CONFIG_CURRENT_SYSTEM_LOCALE"
                        obj.content = SpecificCultures.EN_US
                    Case "POS_CONFIG_SELLING_BELOW_QTY"
                        obj.content = "True"
                    Case "POS_CONFIG_PRINTABLE_RECEIPT"
                        obj.content = "receipt.rpx"
                    Case "POS_CONFIG_PRINTABLE_DAILY_SALES_REPORT"
                        obj.content = "dailySalesReport.rpx"
                    Case "POS_CONFIG_PRINTABLE_STOCK_SUMMARY_SOLD_REPORT"
                        obj.content = "stockSummarySoldReport.rpx"
                End Select

                InsertPosConfig(obj)

                obj = objDA.GetObject(namespace1)
            End If

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetPosConfig - " & ex.Message)
        End Try

        Return obj.content

    End Function

    Public Function GetPosConfigContentFile(ByVal namespace1 As String) As Byte()

        Dim objDA As New DAPosConfig
        Dim obj As DAPosConfigObject = Nothing

        Try
            If namespace1 = "" Then Return Nothing

            obj = objDA.GetObject(namespace1)
            If obj Is Nothing Then
                obj = New DAPosConfigObject
                obj.name_space = namespace1
                obj.userIdEdit = gUserObj.userid
                obj.timeEdit = Now

                Select Case namespace1
                    Case "POS_CONFIG_CURRENT_SYSTEM_LOCALE"
                        obj.content = SpecificCultures.EN_US
                    Case "POS_CONFIG_PRINTABLE_RECEIPT"
                        obj.content = "DEFAULT"
                End Select

                InsertPosConfig(obj)

                'If namespace1 = "POS_CONFIG_CURRENT_SYSTEM_LOCALE" Then
                obj = objDA.GetObject(namespace1)
                'End If
            End If

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetPosConfigContentFile - " & ex.Message)
        End Try

        If Not obj.contentFile Is Nothing Then
            Return obj.contentFile
        Else
            Return New Byte(0) {}
        End If

    End Function

    Public Function GetUserPassword(ByVal strUsername As String, ByVal strPassword As String) As DAUserObject

        Dim objDA As New DAUser
        Dim obj As DAUserObject = Nothing

        Try
            If strUsername = "" And strPassword = "" Then Return Nothing
            obj = objDA.GetUserPassword(strUsername, strPassword)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetUserPassword - " & ex.Message)
        End Try

        Return obj

    End Function


    Public Function GetUserName(ByVal userId As Integer) As String

        Dim objDA As New DAUser
        Dim obj As DAUserObject = Nothing

        Try
            obj = objDA.GetObject(userId)
            If Not obj Is Nothing Then Return obj.username

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetUserName - " & ex.Message)
        End Try

        Return ""

    End Function


    Public Function GetBranch(ByVal pkid As Integer) As DABranchObject

        Dim objDA As New DABranch
        Dim obj As DABranchObject = Nothing

        Try
            obj = objDA.GetObject(pkid)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetBranch - " & ex.Message)
        End Try

        Return obj

    End Function


    Public Function GetAllBranch() As DataSet

        Dim objDA As New DABranch
        Dim ds As DataSet

        Try
            ds = objDA.GetDataSet()

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetBranch - " & ex.Message)
        End Try

        Return ds

    End Function


    Public Function GetLastTimeLogin(ByVal branchId As Integer, ByVal posId As Integer) As DateTime

        Dim objDA As New DAPosLogin

        Try
            Return objDA.GetLastTimeLogin(branchId, posId)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetUserPassword - " & ex.Message)
        End Try

    End Function


    Public Function GetPosLogin(ByVal branchId As Integer, ByVal posId As Integer, ByVal userId As Integer) As DAPosLoginObject

        Dim objDA As New DAPosLogin
        Dim obj As DAPosLoginObject = Nothing

        Try
            obj = objDA.GetPosLogin(branchId, posId, userId)
            If obj Is Nothing Then
                obj = New DAPosLoginObject
                obj.branchId = branchId
                obj.posId = posId
                obj.userId = userId
                obj.timeStart = Now
                obj.timeEnd = Now
                obj.status = DAPosLogin.STATUS_START

                InsertPosLogin(obj)
            End If

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetPosLogin - " & ex.Message)
        End Try

        Return obj

    End Function


    Public Function GetEndDayClosing(ByVal branchId As Integer, ByVal posId As Integer, ByVal userId As Integer) As DAPosEndDayClosingObject

        Dim objDA As New DAPosEndDayClosing
        Dim obj As DAPosEndDayClosingObject = Nothing

        Try
            obj = objDA.GetEndDayClosing(posId)
            If obj Is Nothing Then
                obj = New DAPosEndDayClosingObject
                obj.branchId = branchId
                obj.posId = posId
                obj.userId = userId
                obj.timeStart = Now
                obj.timeEnd = Now
                obj.lastupdate = Now
                obj.status = DAPosEndDayClosing.STATUS_START

                InsertPosEndDayClosing(obj)
                obj = objDA.GetEndDayClosing(posId)

            ElseIf obj.status = DAPosEndDayClosing.STATUS_END Then

                obj = New DAPosEndDayClosingObject
                obj.branchId = branchId
                obj.posId = posId
                obj.userId = userId
                obj.timeStart = Now
                obj.timeEnd = Now
                obj.lastupdate = Now
                obj.status = DAPosEndDayClosing.STATUS_START

                InsertPosEndDayClosing(obj)
                obj = objDA.GetEndDayClosing(posId)
            End If

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetEndDayClosing - " & ex.Message)
        End Try

        Return obj

    End Function


    Public Function GetCustAccount(ByVal keywords As String) As DataSet

        Dim objDA As New DACustAccount
        Dim ds As DataSet = Nothing
        Dim strWhereClause As String

        keywords = "%" & keywords & "%"
        keywords = PreparedStatement(keywords)
        strWhereClause = DACustAccount.NAME & " LIKE " & keywords & " OR " & DACustAccount.MOBILE_PHONE & " LIKE " & keywords & ""

        Try
            ds = objDA.GetDataSet(strWhereClause)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetCustAcc - " & ex.Message)
        End Try

        Return ds

    End Function


    Public Function GetJobsheet(ByVal keywords As String) As DataSet

        Dim objDA As New DAJobsheet
        Dim ds As DataSet = Nothing
        Dim strWhereClause As String

        keywords = "%" & keywords & "%"
        keywords = PreparedStatement(keywords)
        strWhereClause = "(" & DAJobsheet.ENTITY_NAME & " LIKE " & keywords & " OR " & DAJobsheet.REMARKS & " LIKE " & keywords & "" & _
                            " OR " & DAJobsheet.REFERENCE_NO & " LIKE " & keywords & " OR " & DAJobsheet.RECEIVER_NAME & " LIKE " & keywords & "" & _
                            " OR " & DAJobsheet.RECEIVER_HANDPHONE & " LIKE " & keywords & " ) "

        Try
            ds = objDA.GetDataSet(strWhereClause)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetJobsheet - " & ex.Message)
        End Try

        Return ds

    End Function


    Public Function GetDepositFuzzySearch(ByVal keywords As String) As DataSet

        Dim objDA As New DAOfficialReceipt
        Dim ds As DataSet = Nothing
        Dim newds As New DataSet
        Dim strWhereClause As String
        Dim table As DataTable

        keywords = keywords.Replace("|", "")
        keywords = "%" & keywords & "%"
        keywords = PreparedStatement(keywords)
        strWhereClause = "(" & DAOfficialReceipt.PAYMENT_REMARKS & " LIKE " & keywords & " AND " & DAOfficialReceipt.OPEN_BALANCE & " > 0 ) "

        Try
            ds = objDA.GetDataSet(strWhereClause)
            newds = ds.Clone

            table = ds.Tables(0)
            table.Columns.Add(DAOfficialReceipt.REMARKS_CUST_NAME, GetType(String))
            table.Columns.Add(DAOfficialReceipt.REMARKS_CUST_CONTACT, GetType(String))
            table.Columns.Add(DAOfficialReceipt.REMARKS_CUST_IC, GetType(String))
            table.Columns.Add(DAOfficialReceipt.TEMP_PAYMENT, GetType(Decimal))


            For Each row As DataRow In table.Rows
                Dim receiptObj As New DAOfficialReceiptObject
                receiptObj = GetOfficialReceipt(row(DAOfficialReceipt.PKID))

                If receiptObj Is Nothing Then
                    row.Delete()
                Else
                    row(DAOfficialReceipt.REMARKS_CUST_NAME) = receiptObj.GetCustName
                    row(DAOfficialReceipt.REMARKS_CUST_CONTACT) = receiptObj.GetCustContact
                    row(DAOfficialReceipt.REMARKS_CUST_IC) = receiptObj.GetCustIC
                    row(DAOfficialReceipt.PAYMENT_REMARKS) = receiptObj.GetRemarks
                    row(DAOfficialReceipt.TEMP_PAYMENT) = receiptObj.openBalance
                    row(DAOfficialReceipt.AMOUNT) = receiptObj.GetTotalBalanceAmount
                    row.AcceptChanges()
                End If
            Next

            table.AcceptChanges()

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetDepositFuzzySearch - " & ex.Message)
        End Try

        Return ds

    End Function

    Private Sub AddPaymentColumn(ByVal table As DataTable)
        Dim name As String = "payment"
        table.Columns.Add(name, GetType(Decimal))

        For Each dr As DataRow In table.Rows
            dr(name) = dr(DAOfficialReceipt.OPEN_BALANCE)
            dr.AcceptChanges()
        Next

        table.AcceptChanges()
    End Sub

    Private Sub AddOtherColumn(ByVal table As DataTable)
        Dim name As String = "customer"
        Dim remarks As String = "remarks"
        table.Columns.Add(name, GetType(String))
        table.Columns.Add(remarks, GetType(String))

        For Each dr As DataRow In table.Rows
            Try
                Dim strValue As String() = dr(DAOfficialReceipt.PAYMENT_REMARKS).Split("|")
                dr(name) = strValue(0).ToString
                dr(remarks) = strValue(3).ToString
            Catch ex As Exception

            End Try
            dr.AcceptChanges()
        Next

        table.AcceptChanges()
    End Sub

    Public Function GetCustUser(ByVal keywords As String) As DataSet

        Dim objDA As New DACustUser
        Dim ds As DataSet = Nothing
        Dim strWhereClause As String

        keywords = "%" & keywords & "%"
        keywords = PreparedStatement(keywords)
        strWhereClause = DACustUser.NAMEFIRST & " LIKE " & keywords & " OR " & DACustUser.MOBILE_PHONE & " LIKE " & keywords & "" & _
                            " OR " & DACustUser.REFERENCE_NO & " LIKE " & keywords & ""

        Try
            ds = objDA.GetDataSet(strWhereClause)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetCustUser - " & ex.Message)
        End Try

        Return ds

    End Function


    Public Function GetCustAccount(ByVal pkid As Integer) As DACustAccountObject

        Dim objDA As New DACustAccount
        Dim obj As DACustAccountObject = Nothing

        Try
            obj = objDA.GetObject(pkid)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetCustAccount - " & ex.Message)
        End Try

        Return obj

    End Function


    Public Function GetCustUser(ByVal pkid As Integer) As DACustUserObject

        Dim objDA As New DACustUser
        Dim obj As DACustUserObject = Nothing

        Try
            obj = objDA.GetObject(pkid)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetCustUser - " & ex.Message)
        End Try

        Return obj

    End Function


    Public Function GetJobsheet(ByVal pkid As Long) As DAJobsheetObject

        Dim objDA As New DAJobsheet
        Dim itemObjDA As New DAJobsheetItem
        Dim obj As DAJobsheetObject = Nothing

        Try
            obj = objDA.GetObject(pkid)
            If Not obj Is Nothing Then
                obj.arrItems = GetJobsheetItem(pkid)
            End If

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetJobsheet - " & ex.Message)
        End Try

        Return obj

    End Function

    Public Function GetJobsheetByReceipt(ByVal receiptId As Integer) As DAJobsheetObject

        Dim ds As DataSet
        Dim obj As DAJobsheetObject = Nothing

        Try
            ds = GetDocLinkBySourceDoc(DAOfficialReceipt.TABLENAME, receiptId, DAJobsheet.TABLENAME)

            For Each row As DataRow In ds.Tables(0).Rows
                obj = GetJobsheet(row(DADocLink.TGT_DOCID))
                If obj.state = DAJobsheet.STATE_CLOSED Then
                    obj = Nothing
                End If
            Next

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetJobseetByReceipt - " & ex.Message)
        End Try

        Return obj

    End Function

    Public Function GetReceiptByJobsheet(ByVal jobsheetId As Long) As DAOfficialReceiptObject

        Dim ds As DataSet
        Dim obj As DAOfficialReceiptObject = Nothing

        Try
            ds = GetDocLinkByTargetDoc(DAJobsheet.TABLENAME, jobsheetId, DAOfficialReceipt.TABLENAME)

            For Each row As DataRow In ds.Tables(0).Rows
                obj = GetOfficialReceipt(row(DADocLink.SRC_DOCID))
            Next

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetReceiptByJobsheet - " & ex.Message)
        End Try

        Return obj

    End Function


    Public Function GetItem(ByVal keywords As String, ByVal locationId As Integer) As DataSet

        Dim objDAItem As New DAItem
        Dim objDAStock As New DAStock
        Dim dsItem As DataSet = Nothing
        Dim dsNew As New DataSet
        Dim strWhereClause As String

        keywords = "%" & keywords & "%"
        keywords = PreparedStatement(keywords)
        strWhereClause = DAItem.ITEM_CODE & " LIKE " & keywords & "" & " OR " & _
                            DAItem.NAME & " LIKE " & keywords & "" & " OR " & _
                            DAItem.DESCRIPTION & " LIKE " & keywords & ""

        Try
            dsItem = objDAItem.GetDataSet(strWhereClause)
            If dsItem Is Nothing OrElse dsItem.Tables.Count = 0 OrElse dsItem.Tables(0).Rows.Count = 0 Then
                Return Nothing
            End If

            ' Create column to new dataset
            Dim dt As New DataTable()
            Dim colItemCode As New DataColumn(DAItem.ITEM_CODE)
            Dim colItemName As New DataColumn(DAItem.NAME)
            Dim colItemEAN As New DataColumn(DAItem.EANCODE)
            Dim colBalance As New DataColumn(DAStock.BALANCE, System.Type.GetType("System.Int32"))
            Dim colPrice As New DataColumn(DAItem.PRICELIST, System.Type.GetType("System.Decimal"))
            dt.Columns.Add(colItemCode)
            dt.Columns.Add(colItemName)
            dt.Columns.Add(colItemEAN)
            dt.Columns.Add(colBalance)
            dt.Columns.Add(colPrice)

            dsNew.Tables.Add(dt)

            ' Add row into new dataset
            For Each row As DataRow In dsItem.Tables(0).Rows
                Dim obj As DAStockObject
                Dim itemId As Integer = row(DAItem.PKID)

                obj = objDAStock.GetObject(itemId, locationId)
                If Not obj Is Nothing OrElse gAppConfig.SellingBelowQty Then
                    If obj Is Nothing Then
                        obj = New DAStockObject
                    End If

                    Dim rowNew As DataRow
                    rowNew = dsNew.Tables(0).NewRow
                    rowNew(DAItem.ITEM_CODE) = row(DAItem.ITEM_CODE)
                    rowNew(DAItem.NAME) = row(DAItem.NAME)
                    rowNew(DAItem.EANCODE) = row(DAItem.EANCODE)
                    rowNew(DAStock.BALANCE) = obj.balance
                    rowNew(DAItem.PRICELIST) = row(gGetPriceFieldByConfig)

                    If (obj.balance > 0 OrElse gAppConfig.SellingBelowQty OrElse (row(DAItem.ITEM_TYPE1) = DAItem.ITEM_TYPE_SERVICE)) Then
                        dsNew.Tables(0).Rows.Add(rowNew)
                    End If

                End If
            Next

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetItem - " & ex.Message)
        End Try

        Return dsNew

    End Function


    Public Function GetItemDocRow(ByVal keywords As String, ByVal locationId As Integer, _
                                        Optional ByVal ApplyFiveCent As Boolean = False) As DocRow

        Dim objDAItem As New DAItem
        Dim objDAStock As New DAStock
        Dim dsItem As DataSet = Nothing
        Dim returnDocRow As DocRow = Nothing
        Dim strWhereClause As String

        keywords = PreparedStatement(keywords)
        strWhereClause = DAItem.ITEM_CODE & " = " & keywords & "" & " OR " & _
                            DAItem.EANCODE & " = " & keywords & "" & " OR " & _
                            DAItem.ISBNCODE & " = " & keywords & ""

        Try
            dsItem = objDAItem.GetDataSet(strWhereClause)
            If dsItem Is Nothing OrElse dsItem.Tables.Count = 0 OrElse dsItem.Tables(0).Rows.Count = 0 Then
                Return Nothing
            End If

            ' Add row into new DocRow
            For Each row As DataRow In dsItem.Tables(0).Rows
                Dim obj As DAStockObject
                Dim itemId As Integer = row(DAItem.PKID)

                obj = objDAStock.GetObject(itemId, locationId)
                If Not obj Is Nothing OrElse gAppConfig.SellingBelowQty OrElse ApplyFiveCent Then

                    If obj Is Nothing Then
                        obj = New DAStockObject
                    End If

                    Dim docRowObj As New DocRow
                    With docRowObj
                        .itemId = row(DAItem.PKID)
                        .itemCode = row(DAItem.ITEM_CODE)
                        .itemName = row(DAItem.NAME)
                        .eanCode = row(DAItem.EANCODE)
                        .qty = 1
                        .price = row(gGetPriceFieldByConfig)
                        .minPrice = row(DAItem.PRICEMIN)
                        .stockId = obj.pkid
                        .balQty = obj.balance
                        .discount = 0
                        .unitCostMA = obj.unitCostMA
                        .serialized = row(DAItem.SERIALIZED)

                        If (row(DAItem.TAX_OPTION) = DAItem.TAX_ENABLED) Then
                            .taxEnabled = True
                            .taxCode = row(DAItem.TAX_CODE)
                            .taxType = row(DAItem.TAX_TYPE)
                            .taxRate = row(DAItem.TAX_RATE)
                            .taxOption = IIf(gAppConfig.PriceIncludeTax, DocRow.TAX_OPTION_INCLUDE_TAX, DocRow.TAX_OPTION_EXCLUDE_TAX)
                        End If
                    End With

                    If (obj.balance > 0 OrElse gAppConfig.SellingBelowQty OrElse (row(DAItem.ITEM_TYPE1) = DAItem.ITEM_TYPE_SERVICE) OrElse ApplyFiveCent) Then
                        returnDocRow = docRowObj
                    End If

                End If
            Next

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetItemDocRow - " & ex.Message)
        End Try

        Return returnDocRow

    End Function


    Public Function GetAllUser() As DataSet

        Dim objDA As New DAUser
        Dim ds As DataSet

        Try
            ds = objDA.GetDataSet()

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetAllUser - " & ex.Message)
        End Try

        Return ds

    End Function


    Public Function GetAllTaxConfig() As DataSet

        Dim objDA As New DATaxConfig
        Dim ds As DataSet

        Try
            ds = objDA.GetDataSet()

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetAllTaxConfig - " & ex.Message)
        End Try

        Return ds

    End Function


    Public Function GetDailySalesReport(ByVal userId As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, _
                                            ByVal posId As Integer) As DataSet

        Dim objDA As New DAInvoice
        Dim ds As DataSet

        Try
            ds = objDA.GetDailySalesReport(userId, dateFrom, dateTo, posId)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetDailySalesReport - " & ex.Message)
        End Try

        Return ds

    End Function


    Public Function GetDailySalesReportVoid(ByVal userId As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, _
                                            ByVal posId As Integer) As DataSet

        Dim objDA As New DAInvoice
        Dim ds As DataSet

        Try
            ds = objDA.GetDailySalesReportVoid(userId, dateFrom, dateTo, posId)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetDailySalesReportVoid - " & ex.Message)
        End Try

        Return ds

    End Function


    Public Function GetDailySalesReportVoidCollection(ByVal userId As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, ByVal posId As Integer) As DataSet

        Dim objDA As New DAInvoice
        Dim returnDS As New DataSet
        Dim col As New Collection

        Try
            col = GetDailySalesReportVoidCollectionDetails(userId, dateFrom, dateTo, posId)

            Dim tb As New DataTable(0)
            tb.Columns.Add("NAME", GetType(System.String))
            tb.Columns.Add("COUNT", GetType(System.Int16))
            tb.Columns.Add("AMOUNT", GetType(System.Decimal))

            For Each obj As DailySalesReportObject In col
                If obj.count <> 0 Then
                    Dim row As DataRow = tb.NewRow
                    row("NAME") = obj.name
                    row("COUNT") = obj.count
                    row("AMOUNT") = obj.amount

                    tb.Rows.Add(row)
                End If
            Next

            returnDS.Tables.Add(tb)


        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetDailySalesReportVoidCollection - " & ex.Message)
        End Try

        Return returnDS

    End Function


    Public Function GetDailySalesReportByTypeVoid(ByVal userId As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, ByVal posId As Integer, _
                                                   ByVal paymentMethod As String, Optional ByVal cardType As String = "") As DataSet

        Dim objDA As New DAInvoice
        Dim ds As DataSet

        Try
            ds = objDA.GetDailySalesReportByTypeVoid(userId, dateFrom, dateTo, posId, paymentMethod, cardType)


        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetDailySalesReportVoid - " & ex.Message)
        End Try

        Return ds

    End Function


    Public Function GetDailySalesReportByType(ByVal userId As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, ByVal posId As Integer, _
                                                    ByVal paymentMethod As String, Optional ByVal cardType As String = "") As DataSet

        Dim objDA As New DAInvoice
        Dim ds, ds1 As DataSet
        Dim count As Integer = 0
        Dim count1 As Integer = 0
        Dim amount As Decimal = 0
        Dim amount1 As Decimal = 0
        Dim returnDS As New DataSet

        Try
            'count & sum
            ds = objDA.GetDailySalesReportByType(userId, dateFrom, dateTo, posId, paymentMethod, cardType)
            If ds IsNot Nothing AndAlso Not ds.Tables(0).Rows.Count = 0 Then
                If Not ds.Tables(0).Rows(0)("sum").ToString = "" AndAlso Not ds.Tables(0).Rows(0)("sum").ToString = "0" Then
                    count = ds.Tables(0).Rows(0)("count")
                    amount = ds.Tables(0).Rows(0)("sum")
                End If
            End If

            ds1 = objDA.GetDailySalesReportByTypeVoid(userId, dateFrom, dateTo, posId, paymentMethod, cardType)
            If ds1 IsNot Nothing AndAlso Not ds1.Tables(0).Rows.Count = 0 Then
                If Not ds1.Tables(0).Rows(0)("sum").ToString = "" AndAlso Not ds1.Tables(0).Rows(0)("sum").ToString = "0" Then
                    count1 = ds1.Tables(0).Rows(0)("count")
                    amount1 = ds1.Tables(0).Rows(0)("sum")
                End If
            End If

            Dim tb As New DataTable(0)
            tb.Columns.Add("count", GetType(System.Int16))
            tb.Columns.Add("sum", GetType(System.Decimal))

            Dim row As DataRow = tb.NewRow
            row("count") = count - count1
            row("sum") = amount - amount1

            tb.Rows.Add(row)

            returnDS.Tables.Add(tb)

            Return returnDS

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetDailySalesReportByType - " & ex.Message)
        End Try

        Return ds

    End Function


    Public Function GetDailySalesReportCollection(ByVal userId As Integer, ByVal dateFrom As Date, _
                                                    ByVal dateTo As Date, ByVal posId As Integer, _
                                                    ByRef dsVoidCollection As DataSet, _
                                                    ByRef dsDepositCollection As DataSet) As DataSet

        Dim objDA As New DAInvoice
        Dim returnDS As New DataSet
        Dim colCollection As New Collection
        Dim colDepositSalesCollection As New Collection
        Dim colDepositCollection As New Collection
        Dim colVoidCollection As New Collection

        Try
            colCollection = GetDailySalesReportCollectionDetails(userId, dateFrom, dateTo, posId)
            colDepositSalesCollection = GetDailySalesReportCollectionDepositSales(userId, dateFrom, dateTo, posId)
            colDepositCollection = GetDailySalesReportCollectionDeposit(userId, dateFrom, dateTo, posId)
            colVoidCollection = GetDailySalesReportVoidCollectionDetails(userId, dateFrom, dateTo, posId)

            ' Asgin colCollection into dataset
            Dim tb As New DataTable(0)
            tb.Columns.Add("NAME", GetType(System.String))
            tb.Columns.Add("COUNT", GetType(System.Int16))
            tb.Columns.Add("AMOUNT", GetType(System.Decimal))

            For Each obj As DailySalesReportObject In colCollection
                Dim objDeposit As DailySalesReportObject = DirectCast(colDepositSalesCollection.Item(obj.key), DailySalesReportObject)
                Dim objVoid As DailySalesReportObject = DirectCast(colVoidCollection.Item(obj.key), DailySalesReportObject)

                Dim count As Integer = obj.count + objVoid.count
                Dim amount As Decimal = obj.amount + objVoid.amount
                Dim bal As Decimal = Decimal.Subtract(objDeposit.amount, objDeposit.balance)
                If (bal <> 0) Then
                    count += objDeposit.count
                    amount += bal
                End If

                If amount <> 0 Then
                    Dim row As DataRow = tb.NewRow
                    row("NAME") = obj.name
                    row("COUNT") = count
                    row("AMOUNT") = amount
                    tb.Rows.Add(row)
                End If
            Next

            returnDS.Tables.Add(tb)

            ' Asgin colVoidCollection into dataset
            Dim tb1 As New DataTable(0)
            tb1.Columns.Add("NAME", GetType(System.String))
            tb1.Columns.Add("COUNT", GetType(System.Int16))
            tb1.Columns.Add("AMOUNT", GetType(System.Decimal))

            For Each obj As DailySalesReportObject In colVoidCollection
                If obj.count <> 0 Then
                    Dim row As DataRow = tb1.NewRow
                    row("NAME") = obj.name
                    row("COUNT") = obj.count
                    row("AMOUNT") = obj.amount

                    tb1.Rows.Add(row)
                End If
            Next

            dsVoidCollection.Tables.Add(tb1)

            ' Asgin colDepositCollection into dataset
            Dim tb2 As New DataTable(0)
            tb2.Columns.Add("NAME", GetType(System.String))
            tb2.Columns.Add("COUNT", GetType(System.Int16))
            tb2.Columns.Add("AMOUNT", GetType(System.Decimal))
            tb2.Columns.Add("BALANCE", GetType(System.Decimal))

            For Each obj As DailySalesReportObject In colDepositCollection
                If obj.count <> 0 Then
                    Dim row As DataRow = tb2.NewRow
                    row("NAME") = obj.name
                    row("COUNT") = obj.count
                    row("AMOUNT") = obj.amount
                    row("BALANCE") = obj.balance

                    tb2.Rows.Add(row)
                End If
            Next

            dsDepositCollection.Tables.Add(tb2)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetDailySalesReportCollection - " & ex.Message)
        End Try

        Return returnDS

    End Function

    Public Function GetDailySalesReportCollectionDepositSales(ByVal userId As Integer, ByVal dateFrom As Date, _
                                                        ByVal dateTo As Date, ByVal posId As Integer) As Collection

        Dim objDA As New DAInvoice
        Dim col As New Collection
        Dim amount As Decimal = 0
        Dim balance As Decimal = 0
        Dim ds As New DataSet

        Try
            col.Add(New DailySalesReportObject("CASH", "CASH"), "CASH")
            col.Add(New DailySalesReportObject("VISA", "VISA"), "VISA")
            col.Add(New DailySalesReportObject("MASTER", "MASTER"), "MASTER")
            col.Add(New DailySalesReportObject("AMEX", "AMEX"), "AMEX")
            col.Add(New DailySalesReportObject("China Union Pay", "China Union Pay"), "China Union Pay")
            col.Add(New DailySalesReportObject("JCB Card", "JCB Card"), "JCB Card")
            col.Add(New DailySalesReportObject("Nets", "Nets"), "Nets")
            col.Add(New DailySalesReportObject("CHEQUE", "CHEQUE"), "CHEQUE")
            col.Add(New DailySalesReportObject("PD_CHEQUE", "PD_CHEQUE"), "PD_CHEQUE")
            col.Add(New DailySalesReportObject("COUPON", "COUPON"), "COUPON")
            col.Add(New DailySalesReportObject("OTHER", "OTHER"), "OTHER")

            ' Get Deposit
            ds = Nothing
            ds = GetDepositSummary(userId, dateFrom, dateTo, posId)
            If ds IsNot Nothing AndAlso Not ds.Tables(0).Rows.Count = 0 Then
                For Each dr As DataRow In ds.Tables(0).Rows
                    balance = dr.Item(DAOfficialReceipt.OPEN_BALANCE)
                    If dr.Item(DAOfficialReceipt.AMOUNT_CASH) > 0 Then
                        amount = dr.Item(DAOfficialReceipt.AMOUNT_CASH)
                        SetDailySalesReportObject(col, "CASH", amount, balance)
                    End If

                    If dr.Item(DAOfficialReceipt.AMOUNT_CARD) > 0 AndAlso _
                            dr.Item(DAOfficialReceipt.CARD_TYPE) = "VISA" Then
                        amount = dr.Item(DAOfficialReceipt.AMOUNT_CARD)
                        SetDailySalesReportObject(col, "VISA", amount, balance)
                    End If

                    If dr.Item(DAOfficialReceipt.AMOUNT_CARD) > 0 AndAlso _
                            dr.Item(DAOfficialReceipt.CARD_TYPE) = "MASTER" Then
                        amount = dr.Item(DAOfficialReceipt.AMOUNT_CARD)
                        SetDailySalesReportObject(col, "MASTER", amount, balance)
                    End If

                    If dr.Item(DAOfficialReceipt.AMOUNT_CARD) > 0 AndAlso _
                            dr.Item(DAOfficialReceipt.CARD_TYPE) = "AMEX" Then
                        amount = dr.Item(DAOfficialReceipt.AMOUNT_CARD)
                        SetDailySalesReportObject(col, "AMEX", amount, balance)
                    End If

                    If dr.Item(DAOfficialReceipt.AMOUNT_CARD) > 0 AndAlso _
                            dr.Item(DAOfficialReceipt.CARD_TYPE) = "China Union Pay" Then
                        amount = dr.Item(DAOfficialReceipt.AMOUNT_CARD)
                        SetDailySalesReportObject(col, "China Union Pay", amount, balance)
                    End If

                    If dr.Item(DAOfficialReceipt.AMOUNT_CARD) > 0 AndAlso _
                            dr.Item(DAOfficialReceipt.CARD_TYPE) = "JCB Card" Then
                        amount = dr.Item(DAOfficialReceipt.AMOUNT_CARD)
                        SetDailySalesReportObject(col, "JCB Card", amount, balance)
                    End If

                    If dr.Item(DAOfficialReceipt.AMOUNT_CARD) > 0 AndAlso _
                            dr.Item(DAOfficialReceipt.CARD_TYPE) = "Nets" Then
                        amount = dr.Item(DAOfficialReceipt.AMOUNT_CARD)
                        SetDailySalesReportObject(col, "Nets", amount, balance)
                    End If

                    If dr.Item(DAOfficialReceipt.AMOUNT_CHEQUE) > 0 Then
                        amount = dr.Item(DAOfficialReceipt.AMOUNT_CHEQUE)
                        SetDailySalesReportObject(col, "CHEQUE", amount, balance)
                    End If

                    If dr.Item(DAOfficialReceipt.AMOUNT_PD_CHEQUE) > 0 Then
                        amount = dr.Item(DAOfficialReceipt.AMOUNT_PD_CHEQUE)
                        SetDailySalesReportObject(col, "PD_CHEQUE", amount, balance)
                    End If

                    If dr.Item(DAOfficialReceipt.AMOUNT_COUPON) > 0 Then
                        amount = dr.Item(DAOfficialReceipt.AMOUNT_COUPON)
                        SetDailySalesReportObject(col, "COUPON", amount, balance)
                    End If

                    If dr.Item(DAOfficialReceipt.AMOUNT_OTHER) > 0 Then
                        amount = dr.Item(DAOfficialReceipt.AMOUNT_OTHER)
                        SetDailySalesReportObject(col, "OTHER", amount, balance)
                    End If
                Next
            End If

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetDailySalesReportCollection - " & ex.Message)
        End Try

        Return col
    End Function

    Public Function GetDailySalesReportCollectionDeposit(ByVal userId As Integer, ByVal dateFrom As Date, _
                                                        ByVal dateTo As Date, ByVal posId As Integer) As Collection

        Dim objDA As New DAInvoice
        Dim col As New Collection
        Dim amount As Decimal = 0
        Dim balance As Decimal = 0
        Dim ds As New DataSet

        Try
            col.Add(New DailySalesReportObject("CASH", "CASH"), "CASH")
            col.Add(New DailySalesReportObject("VISA", "VISA"), "VISA")
            col.Add(New DailySalesReportObject("MASTER", "MASTER"), "MASTER")
            col.Add(New DailySalesReportObject("AMEX", "AMEX"), "AMEX")
            col.Add(New DailySalesReportObject("China Union Pay", "China Union Pay"), "China Union Pay")
            col.Add(New DailySalesReportObject("JCB Card", "JCB Card"), "JCB Card")
            col.Add(New DailySalesReportObject("Nets", "Nets"), "Nets")
            col.Add(New DailySalesReportObject("CHEQUE", "CHEQUE"), "CHEQUE")
            col.Add(New DailySalesReportObject("PD_CHEQUE", "PD_CHEQUE"), "PD_CHEQUE")
            col.Add(New DailySalesReportObject("COUPON", "COUPON"), "COUPON")
            col.Add(New DailySalesReportObject("OTHER", "OTHER"), "OTHER")

            ' Get Deposit
            ds = Nothing
            ds = GetDepositSummary(userId, dateFrom, dateTo, posId)
            If ds IsNot Nothing AndAlso Not ds.Tables(0).Rows.Count = 0 Then
                For Each dr As DataRow In ds.Tables(0).Rows
                    balance = dr.Item(DAOfficialReceipt.OPEN_BALANCE)
                    If balance > 0 Then


                        If dr.Item(DAOfficialReceipt.AMOUNT_CASH) > 0 Then
                            amount = dr.Item(DAOfficialReceipt.AMOUNT_CASH)
                            SetDailySalesReportObject(col, "CASH", amount, balance)
                        End If

                        If dr.Item(DAOfficialReceipt.AMOUNT_CARD) > 0 AndAlso _
                                dr.Item(DAOfficialReceipt.CARD_TYPE) = "VISA" Then
                            amount = dr.Item(DAOfficialReceipt.AMOUNT_CARD)
                            SetDailySalesReportObject(col, "VISA", amount, balance)
                        End If

                        If dr.Item(DAOfficialReceipt.AMOUNT_CARD) > 0 AndAlso _
                                dr.Item(DAOfficialReceipt.CARD_TYPE) = "MASTER" Then
                            amount = dr.Item(DAOfficialReceipt.AMOUNT_CARD)
                            SetDailySalesReportObject(col, "MASTER", amount, balance)
                        End If

                        If dr.Item(DAOfficialReceipt.AMOUNT_CARD) > 0 AndAlso _
                                dr.Item(DAOfficialReceipt.CARD_TYPE) = "AMEX" Then
                            amount = dr.Item(DAOfficialReceipt.AMOUNT_CARD)
                            SetDailySalesReportObject(col, "AMEX", amount, balance)
                        End If

                        If dr.Item(DAOfficialReceipt.AMOUNT_CARD) > 0 AndAlso _
                                dr.Item(DAOfficialReceipt.CARD_TYPE) = "China Union Pay" Then
                            amount = dr.Item(DAOfficialReceipt.AMOUNT_CARD)
                            SetDailySalesReportObject(col, "China Union Pay", amount, balance)
                        End If

                        If dr.Item(DAOfficialReceipt.AMOUNT_CARD) > 0 AndAlso _
                                dr.Item(DAOfficialReceipt.CARD_TYPE) = "JCB Card" Then
                            amount = dr.Item(DAOfficialReceipt.AMOUNT_CARD)
                            SetDailySalesReportObject(col, "JCB Card", amount, balance)
                        End If

                        If dr.Item(DAOfficialReceipt.AMOUNT_CARD) > 0 AndAlso _
                                dr.Item(DAOfficialReceipt.CARD_TYPE) = "Nets" Then
                            amount = dr.Item(DAOfficialReceipt.AMOUNT_CARD)
                            SetDailySalesReportObject(col, "Nets", amount, balance)
                        End If

                        If dr.Item(DAOfficialReceipt.AMOUNT_CHEQUE) > 0 Then
                            amount = dr.Item(DAOfficialReceipt.AMOUNT_CHEQUE)
                            SetDailySalesReportObject(col, "CHEQUE", amount, balance)
                        End If

                        If dr.Item(DAOfficialReceipt.AMOUNT_PD_CHEQUE) > 0 Then
                            amount = dr.Item(DAOfficialReceipt.AMOUNT_PD_CHEQUE)
                            SetDailySalesReportObject(col, "PD_CHEQUE", amount, balance)
                        End If

                        If dr.Item(DAOfficialReceipt.AMOUNT_COUPON) > 0 Then
                            amount = dr.Item(DAOfficialReceipt.AMOUNT_COUPON)
                            SetDailySalesReportObject(col, "COUPON", amount, balance)
                        End If

                        If dr.Item(DAOfficialReceipt.AMOUNT_OTHER) > 0 Then
                            amount = dr.Item(DAOfficialReceipt.AMOUNT_OTHER)
                            SetDailySalesReportObject(col, "OTHER", amount, balance)
                        End If
                    End If
                Next
            End If

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetDailySalesReportCollection - " & ex.Message)
        End Try

        Return col
    End Function


    Public Function GetDailySalesReportCollectionDetails(ByVal userId As Integer, ByVal dateFrom As Date, _
                                                        ByVal dateTo As Date, ByVal posId As Integer) As Collection

        Dim objDA As New DAInvoice
        Dim col As New Collection
        Dim amount As Decimal = 0
        Dim ds As New DataSet

        Try
            col.Add(New DailySalesReportObject("CASH", "CASH"), "CASH")
            col.Add(New DailySalesReportObject("VISA", "VISA"), "VISA")
            col.Add(New DailySalesReportObject("MASTER", "MASTER"), "MASTER")
            col.Add(New DailySalesReportObject("AMEX", "AMEX"), "AMEX")
            col.Add(New DailySalesReportObject("China Union Pay", "China Union Pay"), "China Union Pay")
            col.Add(New DailySalesReportObject("JCB Card", "JCB Card"), "JCB Card")
            col.Add(New DailySalesReportObject("Nets", "Nets"), "Nets")
            col.Add(New DailySalesReportObject("CHEQUE", "CHEQUE"), "CHEQUE")
            col.Add(New DailySalesReportObject("PD_CHEQUE", "PD_CHEQUE"), "PD_CHEQUE")
            col.Add(New DailySalesReportObject("COUPON", "COUPON"), "COUPON")
            col.Add(New DailySalesReportObject("OTHER", "OTHER"), "OTHER")

            ' Get Daily Sales Report
            ds = Nothing
            ds = objDA.GetDailySalesReportCollection(userId, dateFrom, dateTo, posId)
            If ds IsNot Nothing AndAlso Not ds.Tables(0).Rows.Count = 0 Then
                For Each dr As DataRow In ds.Tables(0).Rows
                    If dr.Item(DAOfficialReceipt.AMOUNT_CASH) > 0 Then
                        amount = dr.Item(DAOfficialReceipt.AMOUNT_CASH)
                        SetDailySalesReportObject(col, "CASH", amount)
                    End If

                    If dr.Item(DAOfficialReceipt.AMOUNT_CARD) > 0 AndAlso _
                            dr.Item(DAOfficialReceipt.CARD_TYPE) = "VISA" Then
                        amount = dr.Item(DAOfficialReceipt.AMOUNT_CARD)
                        SetDailySalesReportObject(col, "VISA", amount)
                    End If

                    If dr.Item(DAOfficialReceipt.AMOUNT_CARD) > 0 AndAlso _
                            dr.Item(DAOfficialReceipt.CARD_TYPE) = "MASTER" Then
                        amount = dr.Item(DAOfficialReceipt.AMOUNT_CARD)
                        SetDailySalesReportObject(col, "MASTER", amount)
                    End If

                    If dr.Item(DAOfficialReceipt.AMOUNT_CARD) > 0 AndAlso _
                            dr.Item(DAOfficialReceipt.CARD_TYPE) = "AMEX" Then
                        amount = dr.Item(DAOfficialReceipt.AMOUNT_CARD)
                        SetDailySalesReportObject(col, "AMEX", amount)
                    End If

                    If dr.Item(DAOfficialReceipt.AMOUNT_CARD) > 0 AndAlso _
                            dr.Item(DAOfficialReceipt.CARD_TYPE) = "China Union Pay" Then
                        amount = dr.Item(DAOfficialReceipt.AMOUNT_CARD)
                        SetDailySalesReportObject(col, "China Union Pay", amount)
                    End If

                    If dr.Item(DAOfficialReceipt.AMOUNT_CARD) > 0 AndAlso _
                            dr.Item(DAOfficialReceipt.CARD_TYPE) = "JCB Card" Then
                        amount = dr.Item(DAOfficialReceipt.AMOUNT_CARD)
                        SetDailySalesReportObject(col, "JCB Card", amount)
                    End If

                    If dr.Item(DAOfficialReceipt.AMOUNT_CARD) > 0 AndAlso _
                            dr.Item(DAOfficialReceipt.CARD_TYPE) = "Nets" Then
                        amount = dr.Item(DAOfficialReceipt.AMOUNT_CARD)
                        SetDailySalesReportObject(col, "Nets", amount)
                    End If

                    If dr.Item(DAOfficialReceipt.AMOUNT_CHEQUE) > 0 Then
                        amount = dr.Item(DAOfficialReceipt.AMOUNT_CHEQUE)
                        SetDailySalesReportObject(col, "CHEQUE", amount)
                    End If

                    If dr.Item(DAOfficialReceipt.AMOUNT_PD_CHEQUE) > 0 Then
                        amount = dr.Item(DAOfficialReceipt.AMOUNT_PD_CHEQUE)
                        SetDailySalesReportObject(col, "PD_CHEQUE", amount)
                    End If

                    If dr.Item(DAOfficialReceipt.AMOUNT_COUPON) > 0 Then
                        amount = dr.Item(DAOfficialReceipt.AMOUNT_COUPON)
                        SetDailySalesReportObject(col, "COUPON", amount)
                    End If

                    If dr.Item(DAOfficialReceipt.AMOUNT_OTHER) > 0 Then
                        amount = dr.Item(DAOfficialReceipt.AMOUNT_OTHER)
                        SetDailySalesReportObject(col, "OTHER", amount)
                    End If
                Next
            End If

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetDailySalesReportCollection - " & ex.Message)
        End Try

        Return col
    End Function


    Public Function GetDailySalesReportVoidCollectionDetails(ByVal userId As Integer, ByVal dateFrom As Date, _
                                                                ByVal dateTo As Date, ByVal posId As Integer) As Collection

        Dim objDA As New DAInvoice
        Dim col As New Collection
        Dim amount As Decimal = 0
        Dim ds As New DataSet

        Try
            col.Add(New DailySalesReportObject("VOID (CASH)", "CASH"), "CASH")
            col.Add(New DailySalesReportObject("VOID (VISA)", "VISA"), "VISA")
            col.Add(New DailySalesReportObject("VOID (MASTER)", "MASTER"), "MASTER")
            col.Add(New DailySalesReportObject("VOID (AMEX)", "AMEX"), "AMEX")
            col.Add(New DailySalesReportObject("VOID (China Union Pay)", "China Union Pay"), "China Union Pay")
            col.Add(New DailySalesReportObject("VOID (JCB Card)", "JCB Card"), "JCB Card")
            col.Add(New DailySalesReportObject("VOID (Nets)", "Nets"), "Nets")
            col.Add(New DailySalesReportObject("VOID (CHEQUE)", "CHEQUE"), "CHEQUE")
            col.Add(New DailySalesReportObject("VOID (PD_CHEQUE)", "PD_CHEQUE"), "PD_CHEQUE")
            col.Add(New DailySalesReportObject("VOID (COUPON)", "COUPON"), "COUPON")
            col.Add(New DailySalesReportObject("VOID (OTHER)", "OTHER"), "OTHER")


            ' Get Daily Sales Report
            ds = Nothing
            ds = objDA.GetDailySalesReportVoidCollection(userId, dateFrom, dateTo, posId)
            If ds IsNot Nothing AndAlso Not ds.Tables(0).Rows.Count = 0 Then
                For Each dr As DataRow In ds.Tables(0).Rows
                    amount = Decimal.Negate(dr.Item("amount_doclink"))
                    Dim invoice_id As Long = dr.Item("invoice_id")
                    If dr.Item(DAOfficialReceipt.AMOUNT_CASH) > 0 Then
                        SetDailySalesReportObject(col, "CASH", Decimal.Negate(amount))
                    End If

                    If dr.Item(DAOfficialReceipt.AMOUNT_CARD) > 0 AndAlso _
                            dr.Item(DAOfficialReceipt.CARD_TYPE) = "VISA" Then
                        SetDailySalesReportObject(col, "VISA", Decimal.Negate(amount))
                    End If

                    If dr.Item(DAOfficialReceipt.AMOUNT_CARD) > 0 AndAlso _
                            dr.Item(DAOfficialReceipt.CARD_TYPE) = "MASTER" Then
                        SetDailySalesReportObject(col, "MASTER", Decimal.Negate(amount))
                    End If

                    If dr.Item(DAOfficialReceipt.AMOUNT_CARD) > 0 AndAlso _
                            dr.Item(DAOfficialReceipt.CARD_TYPE) = "AMEX" Then
                        SetDailySalesReportObject(col, "AMEX", Decimal.Negate(amount))
                    End If

                    If dr.Item(DAOfficialReceipt.AMOUNT_CARD) > 0 AndAlso _
                            dr.Item(DAOfficialReceipt.CARD_TYPE) = "China Union Pay" Then
                        SetDailySalesReportObject(col, "China Union Pay", Decimal.Negate(amount))
                    End If

                    If dr.Item(DAOfficialReceipt.AMOUNT_CARD) > 0 AndAlso _
                            dr.Item(DAOfficialReceipt.CARD_TYPE) = "JCB Card" Then
                        SetDailySalesReportObject(col, "JCB Card", Decimal.Negate(amount))
                    End If

                    If dr.Item(DAOfficialReceipt.AMOUNT_CARD) > 0 AndAlso _
                            dr.Item(DAOfficialReceipt.CARD_TYPE) = "Nets" Then
                        SetDailySalesReportObject(col, "Nets", Decimal.Negate(amount))
                    End If

                    If dr.Item(DAOfficialReceipt.AMOUNT_CHEQUE) > 0 Then
                        SetDailySalesReportObject(col, "CHEQUE", Decimal.Negate(amount))
                    End If

                    If dr.Item(DAOfficialReceipt.AMOUNT_PD_CHEQUE) > 0 Then
                        SetDailySalesReportObject(col, "PD_CHEQUE", Decimal.Negate(amount))
                    End If

                    If dr.Item(DAOfficialReceipt.AMOUNT_COUPON) > 0 Then
                        SetDailySalesReportObject(col, "COUPON", Decimal.Negate(amount))
                    End If

                    If dr.Item(DAOfficialReceipt.AMOUNT_OTHER) > 0 Then
                        SetDailySalesReportObject(col, "OTHER", Decimal.Negate(amount))
                    End If

                Next

            End If

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetDailySalesReportCollection - " & ex.Message)
        End Try

        Return col
    End Function

    Public Function GetDailyCardDetails(ByVal userId As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, _
                                           ByVal posId As Integer) As DataSet

        Dim objDA As New DAInvoice
        Dim ds As DataSet

        Try
            ds = objDA.GetDailyCardDetails(userId, dateFrom, dateTo, posId)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetDailySalesReport - " & ex.Message)
        End Try

        Return ds

    End Function

    Public Function GetDailySalesSummaryReport(ByVal userId As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, _
                                                ByVal posId As Integer) As DataSet

        Dim objDA As New DAInvoice
        Dim ds As DataSet

        Try
            ds = objDA.GetDailySalesSummaryReport(userId, dateFrom, dateTo, posId)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetDailySalesSummaryReport - " & ex.Message)
        End Try

        Return ds

    End Function


    Public Function GetCashInOutSummary(ByVal userId As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, _
                                                ByVal posId As Integer) As DataSet

        Dim objDA As New DAPosCashInOut
        Dim ds As DataSet

        Try
            ds = objDA.GetCashInOutSummary(userId, dateFrom, dateTo, posId)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetCashInOutSummary - " & ex.Message)
        End Try

        Return ds

    End Function


    Public Function GetEndDayClosing() As DataSet
        '"select time_start, time_end, qty_bill, amount from cust_pos_end_day_closing where branch_id={0} AND status={1} ORDER BY time_start DESC"
        Dim objDA As New DAPosEndDayClosing
        Dim ds As DataSet = Nothing
        Dim strWhereClause As String

        strWhereClause = DAPosEndDayClosing.STATUS & " = '" & DAPosEndDayClosing.STATUS_END & "' ORDER BY time_start DESC "

        Try
            ds = objDA.GetDataSet(strWhereClause)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetCustAcc - " & ex.Message)
        End Try

        Return ds

    End Function


    Public Function GetPosConuter() As Long

        Dim objDA As New DAPosCounter
        Dim obj As DAPosCounterObject
        Dim total As Long = 0
        Dim ds As DataSet

        Try
            ds = objDA.GetDataSet
            If ds.Tables(0).Rows.Count > 0 Then
                total = ds.Tables(0).Rows(0)(DAPosCounter.TOTAL_BILL)
            Else
                obj = New DAPosCounterObject
                obj.totalBill = 0
                objDA.Create(obj)
            End If

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetPosConuter - " & ex.Message)
        End Try

        Return total

    End Function


    Public Function GetHourlySalesReport(ByVal userId As Integer, ByVal dateFrom As Date, _
                                               ByVal posId As Integer) As DataSet

        Dim objDA As New DAInvoice
        Dim ds As DataSet

        Try
            ds = objDA.GetHourlySalesReport(userId, dateFrom, posId)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetHourlySalesReport - " & ex.Message)
        End Try

        Return ds

    End Function


    Public Function GetReceiptListing(ByVal userId As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, _
                                               ByVal posId As Integer) As DataSet

        Dim objDA As New DAInvoice
        Dim ds As DataSet

        Try
            ds = objDA.GetReceiptListing(userId, dateFrom, dateTo, posId)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetReceiptListing - " & ex.Message)
        End Try

        Return ds

    End Function


    Public Function GetDetailedVoidReport(ByVal userId As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, _
                                               ByVal posId As Integer) As DataSet

        Dim objDA As New DAInvoice
        Dim ds As DataSet

        Try
            ds = objDA.GetDetailedVoidReport(userId, dateFrom, dateTo, posId)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetDetailedVoidReport - " & ex.Message)
        End Try

        Return ds

    End Function

    Public Function GetVoidReport(ByVal userId As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, _
                                               ByVal posId As Integer) As DataSet

        Dim objDA As New DAInvoice
        Dim ds As DataSet

        Try
            ds = objDA.GetVoidReport(userId, dateFrom, dateTo, posId)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetVoidReport - " & ex.Message)
        End Try

        Return ds

    End Function

    Public Function GetVoidSummaryReport(ByVal userId As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, _
                                              ByVal posId As Integer) As DataSet

        Dim objDA As New DAInvoice
        Dim ds As DataSet

        Try
            ds = objDA.GetVoidSummaryReport(userId, dateFrom, dateTo, posId)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetVoidSummaryReport - " & ex.Message)
        End Try

        Return ds

    End Function

    Public Function GetPosCashInOut(ByVal pkid As Integer) As DAPosCashInOutObject

        Dim objDA As New DAPosCashInOut
        Dim obj As DAPosCashInOutObject = Nothing

        Try
            obj = objDA.GetObject(pkid)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetPosCashInOut - " & ex.Message)
        End Try

        Return obj

    End Function


    Public Function GetDeposit(ByVal custId As String) As DataSet

        Dim objDA As New DAOfficialReceipt
        Dim ds As New DataSet
        Dim strWhereClause As String

        strWhereClause = DAOfficialReceipt.ENTITY_KEY & "='" & custId & "' AND " & DAOfficialReceipt.OPEN_BALANCE & " > 0 AND " _
                            & DAOfficialReceipt.STATUS & "!='" & DAOfficialReceipt.STATUS_CANCELLED & "'"

        Try
            ds = objDA.GetDataSet(strWhereClause)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetDeposit - " & ex.Message)
        End Try

        Return ds

    End Function


    Public Function GetDepositSummary(ByVal userId As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, _
                                               ByVal posId As Integer) As DataSet

        Dim objDA As New DAOfficialReceipt
        Dim ds As New DataSet
        Dim strWhereClause As String

        'payment_time > '2010-12-28' and userid_update = 500 and pos_id = 1 and pkid not in (Select receipt_id from cust_invoice_index);
        strWhereClause = DAOfficialReceipt.STATUS & "!='" & DAOfficialReceipt.STATUS_CANCELLED & "'" & _
                            " AND " & DAOfficialReceipt.PAYMENT_TIME & ">=" & PreparedStatement(dateFrom) & _
                            " AND " & DAOfficialReceipt.PAYMENT_TIME & "<" & PreparedStatement(dateTo) & _
                            " AND " & DAOfficialReceipt.PKID & " NOT IN (SELECT " & DAInvoice.RECEIPT_ID & " FROM " & DAInvoice.TABLENAME & ")"
        Try

            If userId <> 0 Then
                strWhereClause = strWhereClause & " AND " & DAOfficialReceipt.USERID_UPDATE & "=" & userId
            End If

            If posId <> 0 Then
                strWhereClause = strWhereClause & " AND " & DAOfficialReceipt.POS_ID & "=" & posId
            End If

            ds = objDA.GetDataSet(strWhereClause)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetDepositSummary - " & ex.Message)
        End Try

        Return ds

    End Function


    Public Function GetAllDeposit() As DataSet

        Dim objDA As New DAOfficialReceipt
        Dim ds As New DataSet
        Dim strWhereClause As String

        strWhereClause = DAOfficialReceipt.STATUS & "!='" & DAOfficialReceipt.STATUS_CANCELLED & "' AND " & DAOfficialReceipt.OPEN_BALANCE & " > 0 "

        Try
            ds = objDA.GetDataSet(strWhereClause)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetDepositAll - " & ex.Message)
        End Try

        Return ds

    End Function


    Public Function GetOfficialReceipt(ByVal pkid As Integer) As DAOfficialReceiptObject

        Dim objDA As New DAOfficialReceipt
        Dim obj As DAOfficialReceiptObject = Nothing
        Dim ds As New DataSet

        Try
            obj = objDA.GetObject(pkid)
            If obj Is Nothing Then
                Return Nothing
            End If

            If obj.status = DAOfficialReceipt.STATUS_TOPUP Then
                Return Nothing
            End If

            obj.arrItems.Add(obj)
            ds = GetDocLinkByTargetDoc(DAOfficialReceipt.TABLENAME, pkid, DAOfficialReceipt.TABLENAME)

            For Each row As DataRow In ds.Tables(0).Rows
                Dim objItem As New DAOfficialReceiptObject
                objItem = objDA.GetObject(row(DADocLink.SRC_DOCID))
                obj.arrItems.Add(objItem)
            Next

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetOfficialReceipt - " & ex.Message)
        End Try

        Return obj

    End Function


    Public Function GetClientKey(ByVal serverKey As Long, ByVal tableName As String) As Long

        Dim key As Long = 0
        Dim objDA As New DAServerClientLink
        Dim obj As DAServerClientLinkObject = Nothing


        Try
            obj = objDA.GetObject(serverKey, tableName)
            If Not obj Is Nothing Then
                key = obj.clientKey
            End If

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetClientKey - " & ex.Message)
        End Try

        Return key

    End Function


    Public Function GetStock(ByVal pkid As Integer) As DAStockObject

        Dim objDA As New DAStock
        Dim obj As DAStockObject = Nothing

        Try
            obj = objDA.GetObject(pkid)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetStock - " & ex.Message)
        End Try

        Return obj

    End Function


    Public Function GetInvoice(ByVal pkid As Integer) As DAInvoiceObject

        Dim objDA As New DAInvoice
        Dim obj As DAInvoiceObject = Nothing

        Try
            obj = objDA.GetObject(pkid)
            If Not obj Is Nothing Then
                obj.arrItems = GetInvoiceItem(pkid)
            End If

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetInvoice - " & ex.Message)
        End Try

        Return obj

    End Function


    Public Function GetJobsheetItem(ByVal JobsheetId As Long) As ArrayList

        Dim objDA As New DAJobsheetItem
        Dim ds As New DataSet
        Dim arrList As New ArrayList

        Try
            ds = objDA.GetObjectsGiven(DAJobsheetItem.INDEX_ID, JobsheetId)
            If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
                For Each row As DataRow In ds.Tables(0).Rows
                    Dim obj As New DAJobsheetItemObject
                    obj = objDA.GetObject(row)
                    arrList.Add(obj)
                Next
            End If

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetJobsheetItem - " & ex.Message)
        End Try

        Return arrList

    End Function


    Public Sub GetJobsheetItem(ByVal JobsheetId As Long, ByRef ds As DataSet)

        Dim objDA As New DAJobsheetItem

        Try
            ds = objDA.GetObjectsGiven(DAJobsheetItem.INDEX_ID, JobsheetId)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetJobsheetItem - " & ex.Message)
        End Try

    End Sub


    Public Function GetCashAccount(ByVal pkid As Integer) As DACashAccountObject

        Dim objDA As New DACashAccount
        Dim obj As DACashAccountObject = Nothing

        Try
            obj = objDA.GetObject(pkid)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetCashAccount - " & ex.Message)
        End Try

        Return obj

    End Function


    Public Function GetInvoiceItem(ByVal InvoiceId As Long) As ArrayList

        Dim objDA As New DAInvoiceItem
        Dim ds As New DataSet
        Dim arrList As New ArrayList

        Try
            ds = objDA.GetObjectsGiven(DAInvoiceItem.INVOICE_ID, InvoiceId)
            If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
                For Each row As DataRow In ds.Tables(0).Rows
                    Dim obj As New DAInvoiceItemObject
                    obj = objDA.GetObject(row)
                    arrList.Add(obj)
                Next
            End If

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetInvoiceItem - " & ex.Message)
        End Try

        Return arrList

    End Function


    Public Sub GetInvoiceItem(ByVal invoiceId As Long, ByRef ds As DataSet)

        Dim objDA As New DAInvoiceItem

        Try
            ds = objDA.GetObjectsGiven(DAInvoiceItem.INVOICE_ID, invoiceId)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetInvoiceItem - " & ex.Message)
        End Try

    End Sub


    Public Function GetPaymentVoucher(ByVal pkid As Integer) As DAPaymentVoucherObject

        Dim objDA As New DAPaymentVoucher
        Dim obj As DAPaymentVoucherObject = Nothing

        Try
            obj = objDA.GetObject(pkid)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetPaymentVoucher - " & ex.Message)
        End Try

        Return obj

    End Function


    Public Sub GetPaymentVoucherItem(ByVal pvId As Long, ByRef ds As DataSet)

        Dim objDA As New DAPaymentVoucherItem

        Try
            ds = objDA.GetObjectsGiven(DAPaymentVoucherItem.INDEX_ID, pvId)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetPaymentVoucherItem - " & ex.Message)
        End Try

    End Sub


    Public Function GetTaxConfig(ByVal pkid As Long) As DATaxConfigObject

        Dim objDA As New DATaxConfig
        Dim obj As DATaxConfigObject = Nothing

        Try
            obj = objDA.GetObject(pkid)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetTaxConfig - " & ex.Message)
        End Try

        Return obj

    End Function


    Public Function GetDocLinkByTargetDoc(ByVal table As String, ByVal key As Integer, ByVal srcTable As String) As DataSet

        Dim objDA As New DADocLink
        Dim ds As New DataSet
        Dim strWhereClause As String

        strWhereClause = DADocLink.TGT_DOCID & "=" & key & " AND " & DADocLink.TGT_DOCREF & "=" & PreparedStatement(table)

        If srcTable <> "" Then strWhereClause &= " AND " & DADocLink.SRC_DOCREF & "=" & PreparedStatement(srcTable)

        Try
            ds = objDA.GetDataSet(strWhereClause)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetDocLinkByTargetDoc - " & ex.Message)
        End Try

        Return ds

    End Function


    Public Function GetDocLinkBySourceDoc(ByVal table As String, ByVal key As Integer, ByVal tgtTable As String) As DataSet

        Dim objDA As New DADocLink
        Dim ds As New DataSet
        Dim strWhereClause As String

        strWhereClause = DADocLink.SRC_DOCID & "=" & key & " AND " & DADocLink.SRC_DOCREF & "=" & PreparedStatement(table)

        If tgtTable <> "" Then strWhereClause &= " AND " & DADocLink.TGT_DOCREF & "=" & PreparedStatement(tgtTable)

        Try
            ds = objDA.GetDataSet(strWhereClause)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetDocLinkBySourceDoc - " & ex.Message)
        End Try

        Return ds

    End Function

    Public Function GetTCTxQueue(ByVal limit As Integer) As ArrayList

        Dim objDA As New DATCTxQueue
        Dim ds As New DataSet
        Dim arrList As New ArrayList

        Try
            ds = objDA.GetPendingLimit(limit)
            For Each row As DataRow In ds.Tables(0).Rows
                arrList.Add(objDA.GetObject(row))
            Next

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetTCTXQueue - " & ex.Message)
        End Try

        Return arrList

    End Function


    Public Function GetTCTxQueueByTxn() As ArrayList

        Dim objDA As New DATCTxQueue
        Dim ds As New DataSet
        Dim arrList As New ArrayList

        Try
            ds = objDA.GetTCTxQueueByTxn(1)
            For Each row As DataRow In ds.Tables(0).Rows
                arrList.Add(objDA.GetObject(row))
            Next

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetTCTxQueueByTxn - " & ex.Message)
        End Try

        Return arrList

    End Function

    Public Function GetTCTxQueueByStatus(ByVal status As String) As DataSet

        Dim objDA As New DATCTxQueue
        Dim ds As New DataSet

        Try
            ds = objDA.GetObjectsGiven(DATCTxQueue.STATUS, status)
           
        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetTCTxQueueByStatus - " & ex.Message)
        End Try

        Return ds

    End Function


    Public Function GetTCTxQueueByDate(ByVal dateFrom As Date, ByVal dateTo As Date) As DataSet

        Dim objDA As New DATCTxQueue
        Dim ds As New DataSet

        Try
            ds = objDA.GetObjectsByDate(dateFrom, dateTo)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetTCTxQueueByDate - " & ex.Message)
        End Try

        Return ds

    End Function

    Public Function GetDepositAmt(ByVal invoiceId As Long) As Decimal

        Dim objDA As New DADocLink

        Try
            Return objDA.GetPaymentInvoiceDeposit(invoiceId)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetDepositAmt - " & ex.Message)
        End Try

    End Function

    'Public Function GetPosIdByInvoiceId(ByVal invoiceId As Long) As Integer

    '    Dim objDA As New DAPosDoclink
    '    Dim ds As New DataSet
    '    Dim posId As Integer = 0

    '    Try
    '        ds = objDA.GetObjectsGiven(DAPosDoclink.INVOICE_ID, invoiceId)
    '        If Not ds Is Nothing AndAlso ds.Tables(0).Rows.Count > 0 Then
    '            posId = ds.Tables(0).Rows(0)(DAPosDoclink.POS_ID).ToString
    '        End If

    '        Return posId

    '    Catch ex As Exception
    '        Throw New Exception(CLASSNAME & " - GetPosIdByInvoiceId - " & ex.Message)
    '    End Try

    'End Function

    Public Function GetLastSyncTime() As DateTime

        Dim objDA As New DAPosSyncTiming
        Dim obj As DAPosSyncTimingObject = Nothing
        Dim dt As DateTime = GetDefaultDate()

        Try
            obj = objDA.GetLastSync()
            If obj IsNot Nothing Then
                dt = obj.timeStart
            End If

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetLastSyncTime - " & ex.Message)
        End Try

        Return dt

    End Function

    Public Function GetSummaryStockSold(ByVal userId As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, _
                                               ByVal posId As Integer) As DataSet

        Dim objDA As New DAInvoice
        Dim ds As DataSet
        Dim ds1 As DataSet
        Dim returnDS As New DataSet

        Try
            ds = objDA.GetSummaryStockSold(userId, dateFrom, dateTo, posId)
            ds1 = objDA.GetSummaryStockSoldVoid(userId, dateFrom, dateTo, posId)

            For Each dr As DataRow In ds1.Tables(0).Rows
                Dim row As DataRow = ds.Tables(0).NewRow
                row.ItemArray = dr.ItemArray
                ds.Tables(0).Rows.Add(row)                
            Next

            Dim dt As New DataTable
            Dim dsHelper As New DataSetHelper
            dt = dsHelper.SelectGroupByInto(0, ds.Tables(0), "item_code, sum(total_quantity) total_quantity, sum(total) total", "", "item_code")

            For i As Integer = dt.Rows.Count - 1 To 0 Step -1
                If dt.Rows(i)("total_quantity") = 0 Then
                    dt.Rows.RemoveAt(i)
                End If
            Next

            dt.AcceptChanges()
            returnDS.Tables.Add(dt)

            Return returnDS

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetSummaryStockSold - " & ex.Message)
        End Try

        Return returnDs

    End Function


    Public Function GetSerialNumbers(ByVal stockId As Integer) As DataSet

        Dim objDA As New DASerialNumberDelta
        Dim ds As New DataSet

        Try
            ds = objDA.GetDataSetByStockId(stockId)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetTCTxQueueByDate - " & ex.Message)
        End Try

        Return ds

    End Function

#End Region

#Region " Insert Methods "


    Public Function InsertBranch(ByVal branch As branchObject) As Boolean

        Try
            Dim pkid As Integer = branch.pkid
            If pkid = 0 Then Return False

            Dim objDA As New DABranch
            Dim obj As New DABranchObject

            AssignFieldsValue(branch, obj)
            obj = objDA.Create(obj)
            If obj Is Nothing Then
                Throw New Exception("Insert Branch Failed!")
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - InsertBranch - " & ex.Message)
            Return False
        End Try

    End Function


    Public Function InsertCardPaymentConfig(ByVal cardPaymentConfig As cardPaymentConfigObject) As Boolean

        Try
            Dim pkid As Integer = cardPaymentConfig.pkid
            If pkid = 0 Then Return False

            Dim objDA As New DACardPaymentConfig
            Dim obj As New DACardPaymentConfigObject

            AssignFieldsValue(cardPaymentConfig, obj)
            obj = objDA.Create(obj)
            If obj Is Nothing Then
                Throw New Exception("Insert CardPaymentConfig Failed!")
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - InsertCardPaymentConfig - " & ex.Message)
            Return False
        End Try

    End Function


    Public Function InsertCashAccount(ByVal cashAccount As cashAccountObject) As Boolean

        Try
            Dim pkid As Integer = cashAccount.pkId
            If pkid = 0 Then Return False

            Dim objDA As New DACashAccount
            Dim obj As New DACashAccountObject

            AssignFieldsValue(cashAccount, obj)
            obj = objDA.Create(obj)
            If obj Is Nothing Then
                Throw New Exception("Insert CashAccount Failed!")
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - InsertCashAccount - " & ex.Message)
            Return False
        End Try

    End Function


    Public Function InsertCategoryTree(ByVal categoryTree As categoryTreeObject) As Boolean

        Try
            Dim pkid As Integer = categoryTree.pkid
            If pkid = 0 Then Return False

            Dim objDA As New DACategoryTree
            Dim obj As New DACategoryTreeObject

            AssignFieldsValue(categoryTree, obj)
            obj = objDA.Create(obj)
            If obj Is Nothing Then
                Throw New Exception("Insert CategoryTree Failed!")
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - InsertCategoryTree - " & ex.Message)
            Return False
        End Try

    End Function


    Public Function InsertCustAccount(ByVal custAccount As custAccountObject) As Boolean

        Try
            Dim pkid As Integer = custAccount.pkid
            If pkid = 0 Then Return False

            Dim objDA As New DACustAccount
            Dim obj As New DACustAccountObject

            AssignFieldsValue(custAccount, obj)
            obj = objDA.Create(obj)
            If obj Is Nothing Then
                Throw New Exception("Insert CustAccount Failed!")
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - InsertCustAccount - " & ex.Message)
            Return False
        End Try

    End Function


    Public Function InsertCustUser(ByVal custUser As custUserObject) As Boolean

        Try
            Dim pkid As Integer = custUser.pkid
            If pkid = 0 Then Return False

            Dim objDA As New DACustUser
            Dim obj As New DACustUserObject

            AssignFieldsValue(custUser, obj)
            obj = objDA.Create(obj)
            If obj Is Nothing Then
                Throw New Exception("Insert CustUser Failed!")
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - InsertCustUser - " & ex.Message)
            Return False
        End Try

    End Function


    Public Function InsertOfficialReceipt(ByVal OfficialReceipt As officialReceiptObject) As Boolean

        Try
            Dim pkid As Integer = OfficialReceipt.pkid
            If pkid = 0 Then Return False

            'Check exist
            Dim clientKey As Long = 0
            clientKey = GetClientKey(pkid, DAOfficialReceipt.TABLENAME)

            Dim objDA As New DAOfficialReceipt
            Dim obj As New DAOfficialReceiptObject

            If clientKey = 0 Then
                AssignFieldsValue(OfficialReceipt, obj)
                obj = objDA.Create(obj)
                If obj Is Nothing Then
                    Throw New Exception("Insert OfficialReceipt Failed!")
                    Return False
                End If
                'InsertServerClientLink(DAOfficialReceipt.TABLENAME, pkid, obj.pkid)
            Else
                AssignFieldsValue(OfficialReceipt, obj)
                objDA.Update(obj)
            End If

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - InsertOfficialReceipt - " & ex.Message)
            Return False
        End Try

    End Function


    Public Function InsertInvoice(ByRef obj As DAInvoiceObject, ByVal guid As String) As Boolean

        Try
            Dim objDA As New DAInvoice
            Dim objInvoiceItem As New DAInvoiceItem
            Dim objStock As New DAStock

            obj = objDA.Create(obj)
            If obj Is Nothing Then
                Throw New Exception("Insert Invoice Failed!")
                Return False
            End If

            InsertTCTxQueue(obj, guid, "", DATCTxQueue.CATEGORY_INDEX, DAInvoice.TABLENAME, obj.mTotalAmt, DATCTxQueue.MODE_ADD)

            Dim count As Integer = 0
            For Each invItemObj As DAInvoiceItemObject In obj.arrItems
                count += 1
                invItemObj.mInvoiceId = obj.mPkid
                invItemObj.mPosItemId = count
                objInvoiceItem.Create(invItemObj)

                InsertTCTxQueue(invItemObj, guid, "", DATCTxQueue.CATEGORY_ITEM, DAInvoiceItem.TABLENAME, invItemObj.mUnitPriceQuoted * invItemObj.mTotalQty, DATCTxQueue.MODE_ADD)

                objStock.UpdateStockBalance(invItemObj.stkId, invItemObj.mTotalQty)

                'invItemObj.serialNumbers
            Next

            'Dim objPosDoclink As New DAPosDoclinkObject
            'objPosDoclink.invoiceId = obj.mPkid
            'objPosDoclink.posId = gSysConfig.PosId

            'InsertPosDoclink(objPosDoclink)

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - InsertInvoice - " & ex.Message)
            Return False
        End Try

    End Function


    Public Function InsertInvoiceItem(ByVal invoiceItem As DAInvoiceItemObject) As Boolean

        Try
            Dim objDA As New DAInvoiceItem
            Dim obj As DAInvoiceItemObject

            obj = objDA.Create(invoiceItem)
            If obj Is Nothing Then
                Throw New Exception("Insert InvoiceItem Failed!")
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - InsertInvoiceItem - " & ex.Message)
            Return False
        End Try

    End Function


    Public Function InsertJobsheet(ByRef obj As DAJobsheetObject) As Boolean

        Try
            Dim objDA As New DAJobsheet
            Dim objJobsheetItem As New DAJobsheetItem
            Dim guid As String = GetGuid()

            obj = objDA.Create(obj)
            If obj Is Nothing Then
                Throw New Exception("Insert Jobsheet Failed!")
                Return False
            End If

            InsertTCTxQueue(obj, guid, "", DATCTxQueue.CATEGORY_INDEX, DAJobsheet.TABLENAME, obj.amountTotal, DATCTxQueue.MODE_ADD)

            Dim count As Integer = 0
            For Each jsItemObj As DAJobsheetItemObject In obj.arrItems
                count += 1
                jsItemObj.indexId = obj.pkid
                jsItemObj.position = count
                objJobsheetItem.Create(jsItemObj)

                InsertTCTxQueue(jsItemObj, guid, "", DATCTxQueue.CATEGORY_ITEM, DAJobsheetItem.TABLENAME, jsItemObj.unitPriceNet * jsItemObj.quantity, DATCTxQueue.MODE_ADD)
            Next

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - InsertJobsheet - " & ex.Message)
            Return False
        End Try

    End Function


    Public Function InsertJobsheetItem(ByVal JobsheetItem As DAJobsheetItemObject) As Boolean

        Try
            Dim objDA As New DAJobsheetItem
            Dim obj As DAJobsheetItemObject

            obj = objDA.Create(JobsheetItem)
            If obj Is Nothing Then
                Throw New Exception("Insert JobsheetItem Failed!")
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - InsertJobsheetItem - " & ex.Message)
            Return False
        End Try

    End Function


    Public Function InsertItem(ByVal item As itemObject) As Boolean

        Try
            Dim pkid As Integer = item.pkid
            If pkid = 0 Then Return False

            Dim objDA As New DAItem
            Dim obj As New DAItemObject

            obj = objDA.GetObject(pkid)
            If obj Is Nothing Then
                obj = New DAItemObject
                AssignFieldsValue(item, obj)
                obj = objDA.Create(obj)
            Else
                AssignFieldsValue(item, obj)
                objDA.Update(obj)
            End If

            If obj Is Nothing Then
                Throw New Exception("Insert Item Failed!")
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - InsertItem - " & ex.Message)
            Return False
        End Try

    End Function


    Public Function InsertOfficialReceipt(ByVal officialReceipt As DAOfficialReceiptObject, ByRef pkid As Integer, Optional ByVal guid As String = "") As Boolean

        Try
            Dim objDA As New DAOfficialReceipt
            Dim obj As DAOfficialReceiptObject

            obj = objDA.Create(officialReceipt)
            If obj Is Nothing Then
                Throw New Exception("Insert OfficialReceipt Failed!")
                Return False
            End If

            'InsertServerClientLink(DAOfficialReceipt.TABLENAME, 0, obj.pkid)
            pkid = obj.pkid

            If guid = "" Then
                InsertTCTxQueue(obj, GetGuid, "", DATCTxQueue.CATEGORY_INDEX, DAOfficialReceipt.TABLENAME, obj.amount, DATCTxQueue.MODE_ADD)
            Else
                InsertTCTxQueue(obj, guid, "", DATCTxQueue.CATEGORY_ITEM, DAOfficialReceipt.TABLENAME, obj.amount, DATCTxQueue.MODE_ADD)
            End If

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - InsertOfficialReceipt - " & ex.Message)
            Return False
        End Try

    End Function


    Public Function InsertPosCashInOut(ByVal posCashInOut As DAPosCashInOutObject, ByRef pkid As Integer) As Boolean

        Try
            Dim objDA As New DAPosCashInOut
            Dim obj As DAPosCashInOutObject

            obj = objDA.Create(posCashInOut)
            If obj Is Nothing Then
                Throw New Exception("Insert PosCashInOut Failed!")
                Return False
            End If

            pkid = obj.pkid
            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - InsertPosCashInOut - " & ex.Message)
            Return False
        End Try

    End Function


    Public Function InsertPosConfig(ByVal posConfig As DAPosConfigObject) As Boolean

        Try
            Dim objDA As New DAPosConfig
            Dim obj As DAPosConfigObject

            obj = objDA.Create(posConfig)
            If obj Is Nothing Then
                Throw New Exception("Insert PosConfig Failed!")
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - InsertPosConfig - " & ex.Message)
            Return False
        End Try

    End Function


    Public Function InsertPosCounter(ByVal posCounter As DAPosCounterObject) As Boolean

        Try
            Dim objDA As New DAPosCounter
            Dim obj As DAPosCounterObject

            obj = objDA.Create(posCounter)
            If obj Is Nothing Then
                Throw New Exception("Insert PosCounter Failed!")
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - InsertPosCounter - " & ex.Message)
            Return False
        End Try

    End Function


    Public Function InsertPosEndDayClosing(ByVal posEndDayClosing As DAPosEndDayClosingObject) As Boolean

        Try
            Dim objDA As New DAPosEndDayClosing
            Dim obj As DAPosEndDayClosingObject

            obj = objDA.Create(posEndDayClosing)
            If obj Is Nothing Then
                Throw New Exception("Insert PosEndDayClosing Failed!")
                Return False
            End If

            'InsertTCTxQueue(obj, System.Guid.NewGuid.ToString, "", DATCTxQueue.CATEGORY_INDEX, DAPosEndDayClosing.TABLENAME, 0, DATCTxQueue.MODE_ADD)

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - InsertPosEndDayClosing - " & ex.Message)
            Return False
        End Try

    End Function


    Public Function InsertPosLogin(ByVal posLogin As DAPosLoginObject) As Boolean

        Try
            Dim objDA As New DAPosLogin
            Dim obj As DAPosLoginObject

            obj = objDA.Create(posLogin)
            If obj Is Nothing Then
                Throw New Exception("Insert PosLogin Failed!")
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - InsertPosLogin - " & ex.Message)
            Return False
        End Try

    End Function


    Public Function InsertPosSyncTiming(ByVal posSyncTiming As DAPosSyncTimingObject) As Boolean

        Try
            Dim objDA As New DAPosSyncTiming
            Dim obj As DAPosSyncTimingObject

            obj = objDA.Create(posSyncTiming)
            If obj Is Nothing Then
                Throw New Exception("Insert PosSyncTiming Failed!")
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - InsertPosSyncTiming - " & ex.Message)
            Return False
        End Try

    End Function

    Public Function InsertSerialNumberDelta(ByVal serialNumberDelta As serialNumberDeltaObject) As Boolean

        Try
            Dim guid As String = serialNumberDelta.guid
            If guid = "" Then Return False

            Dim objDA As New DASerialNumberDelta
            Dim obj As New DASerialNumberDeltaObject

            AssignFieldsValue(serialNumberDelta, obj)
            obj = objDA.Create(obj)
            If obj Is Nothing Then
                Throw New Exception("Insert Serial Number Failed!")
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - InsertSerialNumberDelta - " & ex.Message)
            Return False
        End Try

    End Function


    Public Function InsertStock(ByVal stock As stockObject) As Boolean

        Try
            Dim pkid As Integer = stock.pkid
            If pkid = 0 Then Return False

            Dim objDA As New DAStock
            Dim obj As New DAStockObject

            AssignFieldsValue(stock, obj)
            obj = objDA.Create(obj)
            If obj Is Nothing Then
                Throw New Exception("Insert Stock Failed!")
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - InsertStock - " & ex.Message)
            Return False
        End Try

    End Function


    Public Function InsertTaxConfig(ByVal taxConfig As taxConfigObject) As Boolean

        Try
            Dim pkid As Integer = taxConfig.pkid
            If pkid = 0 Then Return False

            Dim objDA As New DATaxConfig
            Dim obj As New DATaxConfigObject

            AssignFieldsValue(taxConfig, obj)
            obj = objDA.Create(obj)
            If obj Is Nothing Then
                Throw New Exception("Insert Tax Config Failed!")
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - InsertTaxConfig - " & ex.Message)
            Return False
        End Try

    End Function


    Public Function InsertUser(ByVal user As userObject) As Boolean

        Try
            Dim pkid As Integer = user.userId
            If pkid = 0 Then Return False

            Dim objDA As New DAUser
            Dim obj As New DAUserObject

            AssignFieldsValue(user, obj)
            obj = objDA.Create(obj)            
            If obj Is Nothing Then
                Throw New Exception("Insert User Failed!")
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - InsertUser - " & ex.Message)
            Return False
        End Try

    End Function

    Public Function InsertTCTxQueue(ByVal valueObj As Object, ByVal pkString As String, ByVal fkString As String, ByVal category As String, _
                                        ByVal tableName As String, ByVal amount As String, ByVal mode As String) As Boolean
        '(pkid, pk_string, fk_string, category, source, type, object_xml, userid, status, date_created, date_received, date_completed) " 

        Dim objName As String = ""
        Select Case tableName
            Case DAOfficialReceipt.TABLENAME
                objName = "com.vlee.ejb.accounting.OfficialReceiptObject"
            Case DAInvoice.TABLENAME
                objName = "com.vlee.ejb.customer.InvoiceObject"
            Case DAInvoiceItem.TABLENAME
                objName = "com.vlee.ejb.customer.InvoiceItemObject"
            Case DAJobsheet.TABLENAME
                objName = "com.vlee.ejb.customer.JobsheetIndexObject"
            Case DAJobsheetItem.TABLENAME
                objName = "com.vlee.ejb.customer.JobsheetItemObject"
            Case DAPaymentVoucher.TABLENAME
                objName = "com.vlee.ejb.accounting.PaymentVoucherIndexObject"
            Case DAPaymentVoucherItem.TABLENAME
                objName = "com.vlee.ejb.accounting.PaymentVoucherItemObject"
            Case DAPosEndDayClosing.TABLENAME
                objName = "com.vlee.ejb.customer.POSEndDayClosingObject"
        End Select

        Dim obj As New DATCTxQueueObject
        With obj
            .pkString = pkString
            .fkString = fkString
            .branchid = gBranchObj.pkid
            .source = DATCTxQueue.SOURCE_THICK_CLIENT
            .category = category
            .amount = amount
            .type = tableName
            .objectXML = GetXML(valueObj, tableName, objName)
            .userId = gUserObj.userid
            .dateCreated = Now
            .status = DATCTxQueue.STATUS_PENDING
            .mode = mode
        End With

        Return InsertTCTxQueue(obj)

    End Function

    Public Function InsertTCTxQueue(ByVal tcTxQueue As DATCTxQueueObject) As Boolean

        Try
            Dim objDA As New DATCTxQueue
            Dim obj As DATCTxQueueObject

            obj = objDA.Create(tcTxQueue)
            If obj Is Nothing Then
                Throw New Exception("Insert TCTxQueue Failed!")
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - InsertTCTxQueue - " & ex.Message)
            Return False
        End Try

    End Function


    Public Function InsertSerialNumberDelta(ByVal theSerial As String, ByVal invoiceItem As DAInvoiceItemObject, ByVal invoice As DAInvoiceObject) As Boolean

        Try
            Dim objDA As New DASerialNumberDelta
            Dim obj As DASerialNumberDeltaObject

            Dim sndObj As New DASerialNumberDeltaObject
            sndObj.name_space = DASerialNumberDelta.NS_CUSTOMER
            sndObj.txnType = DASerialNumberDelta.TT_SALES
            sndObj.serialNumber = theSerial
            sndObj.personInCharge = invoiceItem.mPic1
            sndObj.itemId = invoiceItem.mItemId
            sndObj.itemCode = invoiceItem.mItemCode
            sndObj.quantity = -1
            sndObj.currency = invoice.mCurrency
            sndObj.unitPrice = invoiceItem.mUnitPriceQuoted
            sndObj.txnTime = invoice.mTimeIssued
            sndObj.remarks = invoiceItem.mRemarks
            sndObj.entityTable = invoice.mEntityTable
            sndObj.entityId = invoice.mEntityKey
            sndObj.userIdEdit = invoice.mUserIdUpdate
            sndObj.timeEdit = Now

            obj = objDA.Create(sndObj)
            If obj Is Nothing Then
                Throw New Exception("Insert InsertSerialNumberDelta Failed!")
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - InsertSerialNumberDelta - " & ex.Message)
            Return False
        End Try

    End Function


    'Public Function InsertPosDoclink(ByVal posDoclink As DAPosDoclinkObject) As Boolean

    '    Try
    '        Dim objDA As New DAPosDoclink
    '        Dim obj As DAPosDoclinkObject

    '        obj = objDA.Create(posDoclink)
    '        If obj Is Nothing Then
    '            Throw New Exception("Insert PosDoclink Failed!")
    '            Return False
    '        End If

    '        Return True

    '    Catch ex As Exception
    '        Throw New Exception(CLASSNAME & " - InsertPosDoclink - " & ex.Message)
    '        Return False
    '    End Try

    'End Function


    Public Function InsertServerClientLink(ByVal tableName As String, ByVal serverKey As Long, _
                                            ByVal clientKey As Long) As Boolean

        Try
            Dim objDA As New DAServerClientLink
            Dim obj As New DAServerClientLinkObject

            obj.branchId = gBranchObj.pkid
            obj.clientKey = clientKey
            obj.serverKey = serverKey
            obj.tableName = tableName

            obj = objDA.Create(obj)
            If obj Is Nothing Then
                Throw New Exception("Insert ServerClientLink Failed!")
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - InsertServerClientLink - " & ex.Message)
            Return False
        End Try

    End Function


    Public Function InsertCustAccount(ByVal custAccount As DACustAccountObject) As Integer

        Try
            Dim objDA As New DACustAccount
            Dim obj As DACustAccountObject

            obj = objDA.Create(custAccount)
            If obj Is Nothing Then
                Throw New Exception("Insert CustAccount Failed!")
                Return 0
            End If

            'InsertServerClientLink(DACustAccount.TABLENAME, 0, obj.pkid)

            Return obj.pkid

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - InsertCustAccount - " & ex.Message)
            Return False
        End Try

    End Function


    Public Function InsertCustUser(ByVal custUser As DACustUserObject) As Integer

        Try
            Dim objDA As New DACustUser
            Dim obj As DACustUserObject
            Dim accId As Integer

            If custUser.accId = 0 Then
                Dim objCustAcc As New DACustAccountObject
                objCustAcc.name = custUser.nameFirst
                objCustAcc.accType = DACustAccount.ACCTYPE_PERSONAL
                objCustAcc.lastUpdate = Now
                objCustAcc.userIdUpdate = gUserObj.userid
                objCustAcc.salesman = gUserObj.userid
                objCustAcc.mobilePhone = custUser.mobilePhone

                accId = InsertCustAccount(objCustAcc)
                If accId = 0 Then
                    Throw New Exception("Insert CustAccount Failed!")
                    Return 0
                End If

                custUser.accId = accId
            End If

            obj = objDA.Create(custUser)
            If obj Is Nothing Then
                Throw New Exception("Insert CustUser Failed!")
                Return 0
            End If

            'InsertServerClientLink(DACustUser.TABLENAME, 0, obj.pkid)

            Return obj.pkid

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - InsertCustUser - " & ex.Message)
            Return False
        End Try

    End Function


    Public Function InsertDocLink(ByVal docLink As DADocLinkObject) As Boolean

        Try
            Dim objDA As New DADocLink
            Dim obj As DADocLinkObject

            obj = objDA.Create(docLink)
            If obj Is Nothing Then
                Throw New Exception("Insert DocLink Failed!")
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - InsertDocLink - " & ex.Message)
            Return False
        End Try

    End Function


    Public Function InsertPaymentVoucher(ByRef obj As DAPaymentVoucherObject, ByVal guid As String) As Boolean


        Dim objDA As New DAPaymentVoucher
        Dim objDAPVItem As New DAPaymentVoucherItem
        Dim comm As New Commands

        Try

            obj = objDA.Create(obj)
            If obj Is Nothing Then
                Throw New Exception("Insert PaymentVoucher Failed!")
                Return False
            End If

            InsertTCTxQueue(obj, guid, "", DATCTxQueue.CATEGORY_INDEX, DAPaymentVoucher.TABLENAME, obj.amountTotal, DATCTxQueue.MODE_ADD)

            Dim count As Integer = 0
            For Each pviObj As DAPaymentVoucherItemObject In obj.arrItems
                count += 1
                pviObj.indexId = obj.pkid
                pviObj.position = count
                pviObj = objDAPVItem.Create(pviObj)
                'InsertPaymentVoucherItem(pviObj)

                Dim doclinkObj As New DADocLinkObject
                With doclinkObj
                    .srcDocRef = DAPaymentVoucherItem.TABLENAME
                    .srcDocId = pviObj.pkid
                    .tgtDocRef = pviObj.info2
                    .tgtDocId = pviObj.referenceNo
                    .currency = pviObj.currency
                    .lastUpdate = Now
                    .userIdUpdate = gUserObj.userid

                    If .tgtDocRef = DAOfficialReceipt.TABLENAME Then
                        .name_space = DADocLink.NS_CUSTOMER
                        .relType = DADocLink.RELTYPE_PYMT_CN
                        .amount = Decimal.Negate(pviObj.amount)
                    End If
                End With

                InsertDocLink(doclinkObj)

                InsertTCTxQueue(pviObj, guid, "", DATCTxQueue.CATEGORY_ITEM, DAPaymentVoucherItem.TABLENAME, pviObj.amount, DATCTxQueue.MODE_ADD)

            Next


            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - InsertPaymentVoucher - " & ex.Message)
            Return False
        End Try

    End Function


    Public Function InsertPaymentVoucherItem(ByRef paymentVoucherItem As DAPaymentVoucherItemObject) As Boolean

        Try
            Dim objDA As New DAPaymentVoucherItem
            'Dim obj As DAPaymentVoucherItemObject

            paymentVoucherItem = objDA.Create(paymentVoucherItem)
            If paymentVoucherItem Is Nothing Then
                Throw New Exception("Insert PaymentVoucherItem Failed!")
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - InsertPaymentVoucherItem - " & ex.Message)
            Return False
        End Try

    End Function


    Public Function InsertPermission(ByVal userId As Integer, ByVal csvString As String) As Boolean

        Try
            If csvString = "" Then Exit Function

            Dim objDA As New DAPosPermission
            Dim obj As DAPosPermissionObject = Nothing

            Dim permission() As String
            permission = csvString.Split(",")

            'objDA.UpdateUserPermissionDefault(userId)
            For i As Integer = 0 To permission.Length - 1

                'obj = objDA.GetExistUserPermission(userId, permission(i))
                obj = New DAPosPermissionObject
                obj.userId = userId
                obj.permission = permission(i)
                obj.value = "TRUE"
                objDA.Create(obj)
                
            Next

            If obj Is Nothing Then
                Throw New Exception("Insert Permission Failed!")
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - InsertPermission - " & ex.Message)
            Return False
        End Try

    End Function

#End Region

#Region " Update Methods"

    Public Function UpdatePosConfigContentFile(ByVal namespace1 As String, ByVal content As String, ByVal contentFile As Byte()) As String

        Dim objDA As New DAPosConfig
        Dim obj As DAPosConfigObject = Nothing

        Try
            If namespace1 = "" Then Return ""

            obj = objDA.GetObject(namespace1)
            If (Not obj Is Nothing) Then
                obj.content = content
                obj.timeEdit = GetNow()
                obj.contentFile = contentFile
                objDA.Update(obj)
                objDA.UpdateContentFile(obj)
            Else
                Return ""
            End If

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - UpdatePosConfigContentFile - " & ex.Message)
            Return ""
        End Try

        Return obj.content

    End Function

    Public Function UpdatePosConfig(ByVal namespace1 As String, ByVal content As String) As String

        Dim objDA As New DAPosConfig
        Dim obj As DAPosConfigObject = Nothing

        Try
            If namespace1 = "" Then Return ""

            obj = objDA.GetObject(namespace1)
            If (Not obj Is Nothing) Then
                obj.content = content
                obj.timeEdit = GetNow()
                objDA.Update(obj)
            Else
                Return ""
            End If

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - UpdatePosConfig - " & ex.Message)
            Return ""
        End Try

        Return obj.content

    End Function


    Public Sub UpdatePosLogin(ByVal obj As DAPosLoginObject)

        Dim objDA As New DAPosLogin

        Try
            obj.timeEnd = Now
            obj.status = DAPosLogin.STATUS_END

            objDA.Update(obj)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - UpdatePosLogin - " & ex.Message)
        End Try

    End Sub


    Public Sub UpdateEndDayClosing(ByVal obj As DAPosEndDayClosingObject)

        Dim objDA As New DAPosEndDayClosing
        Dim ds As DataSet = Nothing
        Dim amount As Decimal = 0
        Dim comm As New Commands

        Try
            If gPosEndDayClosingObj.status = DAPosEndDayClosing.STATUS_END Then Exit Sub

            ds = Nothing
            ds = GetDailySalesReport(0, obj.timeStart, Now, obj.posId)
            If ds Is Nothing Then Exit Sub
            If ds.Tables(0).Rows(0)("sum").ToString <> "" Then
                amount = ds.Tables(0).Rows(0)("sum")
            End If

            ' get void sales
            ds = Nothing
            ds = GetDailySalesReportVoid(0, obj.timeStart, Now, obj.posId)
            If ds Is Nothing Then Exit Sub
            If ds.Tables(0).Rows(0)("sum").ToString <> "" Then
                amount = Decimal.Subtract(amount, ds.Tables(0).Rows(0)("sum"))
            End If

            obj.status = DAPosEndDayClosing.STATUS_END
            obj.lastUpdate = Now
            obj.amount = amount

            objDA.Update(obj)

            comm.BeginTransaction()
            InsertTCTxQueue(obj, System.Guid.NewGuid.ToString, "", DATCTxQueue.CATEGORY_INDEX, DAPosEndDayClosing.TABLENAME, amount, DATCTxQueue.MODE_ADD)
            comm.Commit()

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - UpdateEndDayClosing - " & ex.Message)
        End Try
    End Sub


    Public Sub UpdateQtyBill(ByVal obj As DAPosEndDayClosingObject)

        Dim objDA As New DAPosEndDayClosing
        Dim amount As Decimal = 0

        Try
            If gPosEndDayClosingObj.status = DAPosEndDayClosing.STATUS_END Then Exit Sub

            obj.timeEnd = Now
            obj.lastUpdate = Now
            obj.qtyBill = obj.qtyBill + 1

            objDA.Update(obj)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - UpdateQtyBill - " & ex.Message)
        End Try
    End Sub


    Public Sub UpdatePosCounter()

        Dim objDA As New DAPosCounter
        Dim obj As DAPosCounterObject

        Try
            obj = objDA.GetObject(1)
            obj.totalBill = obj.totalBill + 1

            objDA.Update(obj)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - UpdatePosCounter - " & ex.Message)
        End Try
    End Sub

    Public Sub UpdateOfficialReceipt(ByVal obj As DAOfficialReceiptObject, ByVal payment As Decimal, Optional ByVal guid As String = "")

        Dim objDA As New DAOfficialReceipt
        Dim comm As New Commands

        Try
            comm.BeginTransaction()

            objDA.Update(obj)

            If guid = "" Then
                InsertTCTxQueue(obj, GetGuid, "", DATCTxQueue.CATEGORY_INDEX, DAOfficialReceipt.TABLENAME, obj.amount, DATCTxQueue.MODE_UPDATE)
            Else
                InsertTCTxQueue(obj, guid, "", DATCTxQueue.CATEGORY_ITEM, DAOfficialReceipt.TABLENAME, payment, DATCTxQueue.MODE_UPDATE)
            End If

            comm.Commit()

        Catch ex As Exception
            comm.Rollback()
            Throw New Exception(CLASSNAME & " - UpdateOfficialReceipt - " & ex.Message)
        End Try
    End Sub


    Public Sub UpdateStock(ByVal obj As DAStockObject)

        Dim objDA As New DAStock

        Try

            objDA.Update(obj)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - UpdateStock - " & ex.Message)
        End Try
    End Sub


    Public Sub UpdateStockBalance(ByVal pkid As Integer, ByVal qty As Integer)

        Dim objDA As New DAStock
        Dim obj As New DAStockObject

        Try

            obj = objDA.GetObject(pkid)
            If obj Is Nothing Then Exit Sub

            obj.balance = obj.balance - qty

            objDA.Update(obj)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - UpdateStockBalance - " & ex.Message)
        End Try

    End Sub


    Public Sub UpdateInvoice(ByVal obj As DAInvoiceObject)

        Dim objDA As New DAInvoice

        Try
            objDA.Update(obj)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - UpdateDAInvoice - " & ex.Message)
        End Try

    End Sub


    Public Function UpdateJobsheet(ByVal obj As DAJobsheetObject, Optional ByVal guid As String = "") As Boolean

        Dim objDA As New DAJobsheet

        Try
            objDA.Update(obj)

            If guid = "" Then
                guid = GetGuid()
                InsertTCTxQueue(obj, guid, "", DATCTxQueue.CATEGORY_INDEX, DAJobsheet.TABLENAME, obj.amountTotal, DATCTxQueue.MODE_UPDATE)
                'GetJobsheet(obj.pkid)
                For Each jobsheetItemObj As DAJobsheetItemObject In obj.arrItems
                    InsertTCTxQueue(jobsheetItemObj, guid, "", DATCTxQueue.CATEGORY_ITEM, DAJobsheetItem.TABLENAME, jobsheetItemObj.unitPriceNet * jobsheetItemObj.quantity, DATCTxQueue.MODE_UPDATE)
                Next
            Else
                InsertTCTxQueue(obj, guid, "", DATCTxQueue.CATEGORY_ITEM, DAJobsheet.TABLENAME, obj.amountTotal, DATCTxQueue.MODE_UPDATE)
            End If

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - UpdateDAJobsheet - " & ex.Message)
            Return False
        End Try

    End Function


    Public Function UpdateJobsheetItem(ByVal obj As DAJobsheetItemObject) As Boolean

        Dim objDA As New DAJobsheetItem

        Try
            objDA.Update(obj)

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - UpdateDAJobsheetItem - " & ex.Message)
            Return False
        End Try

    End Function


    Public Sub UpdateDocLink(ByVal obj As DADocLinkObject)

        Dim objDA As New DADocLink

        Try

            objDA.Update(obj)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - UpdateStock - " & ex.Message)
        End Try
    End Sub

    Public Sub UpdateTCTxQueue(ByVal obj As DATCTxQueueObject)

        Dim objDA As New DATCTxQueue

        Try
            obj.status = DATCTxQueue.STATUS_COMPLETE
            obj.dateCompleted = Now

            objDA.Update(obj)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - UpdateTCTxQueue - " & ex.Message)
        End Try

    End Sub

    Public Sub UpdateTCTxQueueByStatus(ByVal pkid As String, ByVal status As String)

        Dim objDA As New DATCTxQueue

        Try
            objDA.UpdateWithObjectGiven(pkid, DATCTxQueue.STATUS, status, DATCTxQueue.DATE_COMPLETED, Now)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - UpdateTCTxQueue - " & ex.Message)
        End Try

    End Sub

#End Region

#Region " Delete Methods "


    Public Function DeleteJobsheetItem(ByVal pkid As Long) As Boolean

        Dim objDA As New DAJobsheetItem

        Try
            objDA.Remove(pkid)

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - DeleteJobsheetItem - " & ex.Message)
            Return False
        End Try

    End Function

    Public Function DeleteBranch() As Boolean

        Dim objDA As New DABranch

        Try
            objDA.Delete()

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - DeleteBranch - " & ex.Message)
            Return False
        End Try

    End Function

    Public Function DeleteCashAccount() As Boolean

        Dim objDA As New DACashAccount

        Try
            objDA.Delete()

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - DeleteCashAccount - " & ex.Message)
            Return False
        End Try

    End Function

    Public Function DeleteCardPaymentConfig() As Boolean

        Dim objDA As New DACardPaymentConfig

        Try
            objDA.Delete()

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - DeleteCardPaymentConfig - " & ex.Message)
            Return False
        End Try

    End Function

    Public Function DeleteCategoryTree() As Boolean

        Dim objDA As New DACategoryTree

        Try
            objDA.Delete()

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - DeleteCategoryTree - " & ex.Message)
            Return False
        End Try

    End Function

    Public Function DeleteCustAccount() As Boolean

        Dim objDA As New DACustAccount

        Try
            objDA.Delete()

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - DeleteCustAccount - " & ex.Message)
            Return False
        End Try

    End Function

    Public Function DeleteCustUser() As Boolean

        Dim objDA As New DACustUser

        Try
            objDA.Delete()

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - DeleteCustUser - " & ex.Message)
            Return False
        End Try

    End Function


    Public Function DeleteItem() As Boolean

        Dim objDA As New DAItem

        Try
            objDA.Delete()

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - DeleteItem - " & ex.Message)
            Return False
        End Try

    End Function

    Public Function DeleteSerialNumber() As Boolean

        Dim objDA As New DASerialNumberDelta

        Try
            objDA.Delete()

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - DeleteSerialNumber - " & ex.Message)
            Return False
        End Try

    End Function

    Public Function DeleteStock() As Boolean

        Dim objDA As New DAStock

        Try
            objDA.Delete()

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - DeleteStock - " & ex.Message)
            Return False
        End Try

    End Function

    Public Function DeleteTaxConfig() As Boolean

        Dim objDA As New DATaxConfig

        Try
            objDA.Delete()

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - DeleteTaxConfig - " & ex.Message)
            Return False
        End Try

    End Function

    Public Function DeleteUser() As Boolean

        Dim objDA As New DAUser

        Try
            objDA.Delete()

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - DeleteUser - " & ex.Message)
            Return False
        End Try

    End Function

    Public Function DeletePermission() As Boolean

        Dim objDA As New DAPosPermission

        Try
            objDA.Delete()

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - DeletePermission - " & ex.Message)
            Return False
        End Try

    End Function

#End Region

#Region " Others Methods "


    Public Sub AssignFieldsValue(ByVal objFrom As Object, ByRef objTo As Object)

        Dim FieldFrom As FieldInfo() = objFrom.GetType.GetFields(BindingFlags.NonPublic Or BindingFlags.Public Or BindingFlags.Instance)
        Dim FieldTo As FieldInfo() = objTo.GetType.GetFields(BindingFlags.NonPublic Or BindingFlags.Public Or BindingFlags.Instance)
        Dim nameField As String

        For i As Integer = 0 To FieldTo.Length - 1
            nameField = FieldTo(i).Name
            If nameField = "name_space" Then
                nameField = "namespace"
            End If
            nameField &= "Field"

            For j As Integer = 0 To FieldFrom.Length - 1
                If (nameField.ToLower = FieldFrom(j).Name.ToLower) Then
                    'string s = Encoding..ASCII.GetString( byteData);
                    Dim strValue As Object = FieldFrom(j).GetValue(objFrom)
                    If strValue Is Nothing Then
                        Exit For
                    End If
                    Select Case strValue.ToString()
                        'Case "System.Byte[]"
                        'strValue = Encoding.ASCII.GetString(strValue)
                        'strValue = BitConverter.ToString(strValue)
                    End Select
                    FieldTo(i).SetValue(objTo, strValue) 'itemobj.pkid = itmobjemp.pkid, 
                    Exit For
                End If
            Next
        Next i

    End Sub


    Public Function CancelInvoice(ByVal pkid As Long, ByVal remarks As String) As Boolean
        Dim comm As New Commands
        Dim ds As DataSet = Nothing
        Dim objDA As New DAInvoice
        Dim obj As DAInvoiceObject
        Dim objReceipt As DAOfficialReceiptObject
        Dim objDAReceipt As New DAOfficialReceipt

        Try
            obj = GetInvoice(pkid)
            objReceipt = objDAReceipt.GetObject(obj.mReceiptId)

            obj.mStatus = DAInvoice.STATUS_CANCELLED
            obj.mLastUpdate = Now
            obj.mUserIdUpdate = gUserObj.userid
            obj.mRemarks = obj.mRemarks

            comm.BeginTransaction()
            objDA.Update(obj)

            InsertTCTxQueue(obj, GetGuid, "", DATCTxQueue.CATEGORY_INDEX, DAInvoice.TABLENAME, obj.mTotalAmt, DATCTxQueue.MODE_CANCEL)

            If Not objReceipt Is Nothing Then
                objReceipt.state = DAOfficialReceipt.STATUS_CANCELLED
                objReceipt.lastUpdate = Now
                objReceipt.userIdUpdate = gUserObj.userid
                objReceipt.remarksReverse = remarks

                objDAReceipt.Update(objReceipt)
            End If

            comm.Commit()

            For Each invItemObj As DAInvoiceItemObject In obj.arrItems
                UpdateStockBalance(invItemObj.stkId, Decimal.Negate(invItemObj.mTotalQty))
            Next

            Return True

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - CancelInvoice - " & ex.Message)
            Return False
        End Try

    End Function


    Public Function IsExistUserPermission(ByVal userId As Integer, ByVal permission As String) As Boolean

        Dim objDA As New DAPosPermission
        Dim obj As DAPosPermissionObject

        Try
            obj = objDA.GetExistUserPermission(userId, permission)
            If obj Is Nothing Then
                Return False
            ElseIf obj.value = "TRUE" Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - IsExistUserPermission - " & ex.Message)
            Return False
        End Try

    End Function

#End Region

#Region " Transaction Methods "

    ' TODO - need combine all txn into one function
    Public Function CreateCashsale(ByVal invObj As DAInvoiceObject, ByVal receiptObj As DAOfficialReceiptObject, _
                                   ByVal guid As String) As Boolean
        Dim comm As New Commands

        Try
            comm.BeginTransaction()

            ' Create Invoice
            If Not InsertInvoice(invObj, guid) Then
                comm.Rollback()
                Return False
            End If

            ' Create receipt
            receiptObj.entityKey = invObj.mEntityKey
            receiptObj.entityName = invObj.mEntityName
            receiptObj.entityTable = invObj.mEntityTable
            receiptObj.currency = invObj.mCurrency
            receiptObj.paymentTime = invObj.mTimeIssued
            receiptObj.paymentRemarks = invObj.mRemarks
            receiptObj.lastUpdate = Now
            receiptObj.userIdUpdate = gUserObj.userid
            receiptObj.cbCash = gBranchObj.cashbookCash
            receiptObj.cbCard = gBranchObj.cashbookCard
            receiptObj.cbCheque = gBranchObj.cashbookCheque
            receiptObj.cbCoupon = gBranchObj.cashbookCoupon
            receiptObj.cbPDCheque = gBranchObj.cashbookPDCheque
            receiptObj.cbOther = gBranchObj.cashbookOther
            receiptObj.branch = gBranchObj.pkid
            receiptObj.pcCenter = gBranchObj.accPCCenterId
            receiptObj.posId = gSysConfig.PosId

            InsertOfficialReceipt(receiptObj, receiptObj.pkid, guid)

            ' Update Receipt Id at Invoice
            invObj.mReceiptId = receiptObj.pkid

            UpdateInvoice(invObj)

            ' Create doclink
            Dim docLinkObj As New DADocLinkObject

            docLinkObj.name_space = DADocLink.NS_CUSTOMER
            docLinkObj.relType = DADocLink.RELTYPE_PYMT_INV
            docLinkObj.srcDocRef = DAOfficialReceipt.TABLENAME
            docLinkObj.srcDocId = receiptObj.pkid
            docLinkObj.tgtDocRef = DAInvoice.TABLENAME
            docLinkObj.tgtDocId = invObj.mPkid
            docLinkObj.currency = invObj.mCurrency
            docLinkObj.amount = Decimal.Negate(receiptObj.amount)
            docLinkObj.lastUpdate = Now
            docLinkObj.userIdUpdate = gUserObj.userid

            InsertDocLink(docLinkObj)

            comm.Commit()
            Return True

        Catch ex As Exception
            comm.Rollback()
            Throw New Exception(CLASSNAME & " - CreateCashsale - " & ex.Message)
            Return False
        End Try

    End Function

    Public Function CreateDocLink(ByVal docLinkObj As DADocLinkObject) As Boolean
        Dim comm As New Commands

        Try
            comm.BeginTransaction()

            ' Create receipt
            InsertDocLink(docLinkObj)

            comm.Commit()
            Return True

        Catch ex As Exception
            comm.Rollback()
            Throw New Exception(CLASSNAME & " - CreateDoclink - " & ex.Message)
            Return False
        End Try

    End Function

    Public Function CreateDeposit(ByVal receiptObj As DAOfficialReceiptObject) As Boolean
        Dim comm As New Commands

        Try
            comm.BeginTransaction()

            ' Create receipt
            InsertOfficialReceipt(receiptObj, receiptObj.pkid)

            comm.Commit()
            Return True

        Catch ex As Exception
            comm.Rollback()
            Throw New Exception(CLASSNAME & " - CreateDeposit - " & ex.Message)
            Return False
        End Try

    End Function


    Public Function CreateJobsheet(ByRef obj As DAJobsheetObject, ByVal receiptObj As DAOfficialReceiptObject) As Boolean
        Dim comm As New Commands

        Try
            comm.BeginTransaction()

            ' Create Jobsheet
            InsertJobsheet(obj)

            ' Create doclink
            Dim docLinkObj As New DADocLinkObject
            docLinkObj.name_space = DADocLink.NS_CUSTOMER
            docLinkObj.relType = DADocLink.RELTYPE_PYMT_JOBSHEET_DEPOSIT
            docLinkObj.srcDocRef = DAOfficialReceipt.TABLENAME
            docLinkObj.srcDocId = receiptObj.pkid
            docLinkObj.tgtDocRef = DAJobsheet.TABLENAME
            docLinkObj.tgtDocId = obj.pkid
            docLinkObj.currency = obj.currency
            docLinkObj.amount = Decimal.Negate(receiptObj.openBalance)
            docLinkObj.lastUpdate = Now
            docLinkObj.userIdUpdate = gUserObj.userid

            InsertDocLink(docLinkObj)

            comm.Commit()

            Return True

        Catch ex As Exception
            comm.Rollback()
            Throw New Exception(CLASSNAME & " - CreateJobsheet - " & ex.Message)
            Return False
        End Try

    End Function

    Public Function ModifyJobsheet(ByRef obj As DAJobsheetObject, ByVal arrDocRow As ArrayList) As Boolean
        Dim comm As New Commands

        Try
            comm.BeginTransaction()

            ' Update JobsheetItem
            For Each dr As DocRow In arrDocRow
                If dr.refKey = 0 Then
                    'insert
                    Dim jbosheetItemObj As New DAJobsheetItemObject(obj, dr)
                    InsertJobsheetItem(jbosheetItemObj)
                Else
                    If dr.isDeleted Then
                        'delete
                        DeleteJobsheetItem(dr.refKey)
                    Else
                        'update
                        Dim jbosheetItemObj As New DAJobsheetItemObject(obj, dr)
                        jbosheetItemObj.pkid = dr.refKey
                        UpdateJobsheetItem(jbosheetItemObj)
                    End If
                End If
            Next

            ' Update Jobsheet
            UpdateJobsheet(obj)

            comm.Commit()
            Return True

        Catch ex As Exception
            comm.Rollback()
            Throw New Exception(CLASSNAME & " - ModifyJobsheet - " & ex.Message)
            Return False
        End Try

    End Function

    Public Function ModifyJobsheetState(ByVal jobsheetObj As DAJobsheetObject, ByVal invObj As DAInvoiceObject, _
                                            ByVal guid As String)
        Dim comm As New Commands

        Try
            comm.BeginTransaction()

            ' Update Jobsheet State
            jobsheetObj.state = DAJobsheet.STATE_INVOICE
            UpdateJobsheet(jobsheetObj, guid)

            ' Create doclink
            Dim doclinkObj As New DADocLinkObject
            doclinkObj.name_space = DADocLink.NS_CUSTOMER
            doclinkObj.relType = DADocLink.RELTYPE_JS_TO_INVOICE
            doclinkObj.srcDocRef = DAInvoice.TABLENAME
            doclinkObj.srcDocId = invObj.mPkid
            doclinkObj.tgtDocRef = DAJobsheet.TABLENAME
            doclinkObj.tgtDocId = jobsheetObj.pkid
            doclinkObj.currency = invObj.mCurrency
            doclinkObj.amount = jobsheetObj.amountTotal
            doclinkObj.lastUpdate = Now
            doclinkObj.userIdUpdate = gUserObj.userid

            InsertDocLink(doclinkObj)

            comm.Commit()

            Return True

        Catch ex As Exception
            comm.Rollback()
            Throw New Exception(CLASSNAME & " - ModifyJobsheetState - " & ex.Message)
            Return False
        End Try

    End Function


    Public Function CreatePaymentVoucher(ByRef pvObj As DAPaymentVoucherObject, ByVal guid As String) As Boolean
        Dim comm As New Commands

        Try
            comm.BeginTransaction()

            ' Create Payment Voucher
            InsertPaymentVoucher(pvObj, guid)

            comm.Commit()
            Return True

        Catch ex As Exception
            comm.Rollback()
            Throw New Exception(CLASSNAME & " - CreateDeposit - " & ex.Message)
            Return False
        End Try

    End Function

#End Region

#Region " Daily Sales Report Method "

    Public Class DailySalesReportObject

        Public name As String
        Public count As Integer
        Public amount As Decimal
        Public balance As Decimal
        Public key As String

        Public Sub New(ByVal name As String, ByVal key As String)
            MyBase.new()
            Me.name = name
            Me.count = 0
            Me.amount = 0
            Me.balance = 0
            Me.key = key
        End Sub

        Public Sub update(ByVal amount As Decimal, ByVal balance As Decimal)
            If amount > 0 Then
                Me.count += 1
            Else
                Me.count -= 1
            End If
            Me.balance += balance
            Me.amount += amount
        End Sub

    End Class

    Private Sub SetDailySalesReportObject(ByVal col As Collection, ByVal type As String, _
                                          ByVal amount As Decimal, Optional ByVal balance As Decimal = 0)
        Dim obj As DailySalesReportObject = DirectCast(col.Item(type), DailySalesReportObject)
        obj.update(amount, balance)
    End Sub

#End Region

End Class
