Imports Utils
Imports Utils.General
Imports DataDynamics.ActiveReports
Imports System.IO
Imports DataAccess

Public NotInheritable Class PrintingFormat

    Public Enum PrintingType
        Receipt
        Jobsheet
        VoidReceipt
        Deposit
        PaymentVoucher
        CashInOut
        DailySalesReport
        HourlySalesReport
        VoidDetailReport
        VoidReport
        ReceiptListing
        StockSummarySoldReport
    End Enum

    Private Shared report As New DataDynamics.ActiveReports.ActiveReport3
    Private Shared objDA As New DataAccessNut
    Private Shared count As Integer = 0

    Private Shared Function getReport(ByVal printableName As String, Optional ByVal subPrintableName As String = "") _
                                            As DataDynamics.ActiveReports.ActiveReport3

        Dim filename As String = Path.Combine(gReportPath, printableName)
        Dim fi As New FileInfo(filename)
        Dim report As DataDynamics.ActiveReports.ActiveReport3 = Nothing

        If fi.Exists Then
            If subPrintableName <> "" Then
                filename = Path.Combine(gReportPath, Path.GetFileNameWithoutExtension(filename) & "_" & subPrintableName & fi.Extension)
                Dim fi1 As New FileInfo(filename)
                If fi1.Exists Then
                    report = New DataDynamics.ActiveReports.ActiveReport3
                    report.LoadLayout(filename)
                End If
            Else
                report = New DataDynamics.ActiveReports.ActiveReport3
                report.LoadLayout(filename)
            End If
        End If

        Return report

    End Function

#Region " PrintReceipt "

    Public Shared Sub PrintReceipt(ByVal pkid As Long, ByVal directPrint As Boolean)
        Dim myCursor As New WaitCursor

        Try
            report = getReport(gAppConfig.PrintableReceipt)
            If report Is Nothing Then Exit Sub

            'Get Invoice
            Dim invObj As New DAInvoiceObject
            invObj = objDA.GetInvoice(pkid)

            Dim receiptObj As New DAOfficialReceiptObject
            receiptObj = objDA.GetOfficialReceipt(invObj.mReceiptId)

            Dim depositAmt As Decimal = objDA.GetDepositAmt(pkid)

            If invObj.mStatus = DAInvoice.STATUS_CANCELLED Then
                GetTextBox(report, "txtReportName").Text = "VOID REPORT"
                'txtRemarks.Text = "Remarks: " & receiptObj.remarksReverse
            Else
                GetTextBox(report, "txtReportName").Text = ""
                'txtRemarks.Text = "Remarks: " & invObj.mRemarks
            End If

            AddHandler report.DataInitialize, AddressOf PrintReceipt_DataInitialize
            AddHandler report.FetchData, AddressOf PrintReceipt_FetchData

            'Dim reportHeader As DataDynamics.ActiveReports.Section = report.Sections(0)
            'For Each ctl As DataDynamics.ActiveReports.ARControl In reportHeader.Controls
            '    If ctl.GetType Is GetType(DataDynamics.ActiveReports.SubReport) Then
            '        Dim subRpt As DataDynamics.ActiveReports.SubReport = DirectCast(ctl, DataDynamics.ActiveReports.SubReport)
            '        subRpt.Report = New rptHeader
            '        subRpt.Report.PageSettings.Margins.Left = 0
            '        subRpt.Report.PageSettings.Margins.Right = 0
            '        subRpt.Report.PageSettings.Margins.Top = 0
            '        subRpt.Report.PageSettings.Margins.Bottom = 0
            '    End If
            'Next

            ' Report Header
            SetReportHeader(report)

            GetTextBox(report, "txtReceiptId").Text = pkid
            GetTextBox(report, "txtTime").Text = FormatDateTime(invObj.mTimeIssued)
            'GetTextBox(User.Text = objDA.GetUserName(invObj.mUserIdUpdate)
            'GetTextBox(Counter.Text = objDA.GetPosIdByInvoiceId(pkid)

            Dim salesman As String = objDA.GetUserName(invObj.salesId)
            GetTextBox(report, "txtSales").Text = "Svr:" & objDA.GetUserName(invObj.salesId)
            GetTextBox(report, "txtCashier").Text = "Csh:" & objDA.GetUserName(invObj.mUserIdUpdate)
            GetTextBox(report, "txtPos").Text = "POS:" & invObj.posId

            GetTextBox(report, "txtPosMsg1").Text = gAppConfig.MsgBottom1
            GetTextBox(report, "txtPosMsg2").Text = gAppConfig.MsgBottom2
            GetTextBox(report, "txtPosMsg3").Text = gAppConfig.MsgBottom3
            GetTextBox(report, "txtPosMsg4").Text = gAppConfig.MsgBottom4

            ' Set data field 
            GetTextBox(report, "txtDesc").DataField = DAInvoiceItem.NAME
            GetTextBox(report, "txtCode").DataField = DAInvoiceItem.ITEM_CODE
            'GetTextBox(report,"txtNo").DataField = NO_FIELD
            GetTextBox(report, "txtQty").DataField = DAInvoiceItem.TOTALQTY
            GetTextBox(report, "txtPrice").DataField = DAInvoiceItem.UNIT_PRICE_QUOTED
            GetTextBox(report, "txtDisc").DataField = DAInvoiceItem.UNIT_DISCOUNT
            GetTextBox(report, "txtAmount").DataField = "AMOUNT_FIELD"


            GetTextBox(report, "txtTotalQty").DataField = DAInvoiceItem.TOTALQTY
            GetTextBox(report, "txtTotalQty").SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
            GetTextBox(report, "txtTotalQty").SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal

            'GetTextBox(report,"txtTotal.DataField = AMOUNT_FIELD
            'GetTextBox(report,"txtTotal.SummaryRunning = SummaryRunning.All
            'GetTextBox(report,"txtTotal.SummaryType = SummaryType.GrandTotal

            GetTextBox(report, "txtTax").Text = FormatCurrency(invObj.taxAmount)
            GetTextBox(report, "txtDeposit").Text = FormatCurrency(Math.Abs(depositAmt))
            GetTextBox(report, "txtNetTotal").Text = FormatCurrency(invObj.mTotalAmt)

            GetTextBox(report, "txtPay1").Text = ""
            GetTextBox(report, "txtPay2").Text = ""
            GetTextBox(report, "txtPay1Amt").Text = ""
            GetTextBox(report, "txtPay2Amt").Text = ""
            'GetTextBox(report,"txtPayment").Text = "Payment Mode: " & receiptObj.paymentMethod

            If Not receiptObj Is Nothing Then

                If receiptObj.paymentMethod <> "" Then
                    GetTextBox(report, "txtPay1").Text = receiptObj.paymentMethod
                    GetTextBox(report, "txtPay1Amt").Text = FormatCurrency(receiptObj.amount)
                End If

                If receiptObj.cardNumber <> "" Then
                    Dim txt As String = receiptObj.cardType

                    If receiptObj.cardNumber.Length >= 12 Then
                        txt = txt & " " & receiptObj.GetCardNo(4)
                    End If
                    GetTextBox(report, "txtPay1").Text = txt

                    GetTextBox(report, "txtPay1Amt").Text = ""
                    GetTextBox(report, "txtPay2").Text = ""
                    GetTextBox(report, "txtPay2Amt").Text = FormatCurrency(receiptObj.amountCard)

                ElseIf receiptObj.cashNotesChange <> 0 Then
                    GetTextBox(report, "txtPay1").Text = "CASH"
                    GetTextBox(report, "txtPay1Amt").Text = FormatCurrency(receiptObj.cashNotesReceived)
                    GetTextBox(report, "txtPay2").Text = "CHANGE"
                    GetTextBox(report, "txtPay2Amt").Text = FormatCurrency(receiptObj.cashNotesChange)
                End If
            End If

            ' Get Receipt transaction
            Dim ds As DataSet = Nothing
            objDA.GetInvoiceItem(pkid, ds)
            report.DataSource = ds.Tables(0)

            With report.Document.Printer
                .PrinterName = "" 'use the virtual print driver for paper sizes not supported by the local printer
                '.PaperKind = Printing.PaperKind.Custom
                '.PaperSize = p
                '.Landscape = True
                '.PrinterSettings.
                '.pDataType = "RAW"                
            End With

            report.Run()


            If directPrint Then
                report.Document.Print(False, False, False)
                'report.Document.Printer.Print()
            Else
                Dim viewerForm As New frmPreview()
                viewerForm.rpt = report
                viewerForm.ShowDialog()
            End If

        Catch ex As System.Exception
            Messenger.Caption = "Print Receipt Error!"
            Messenger.ShowError(ex.Message)

        Finally
            myCursor.Dispose()
        End Try

    End Sub

    Private Shared Sub PrintReceipt_DataInitialize()
        report.Fields.Add("AMOUNT_FIELD")
        'rpt.Fields.Add(UNIT_PRICE_FIELD)
        'rpt.Fields.Add(NO_FIELD)
        'rpt.Fields.Add(DESC_FIELD)
    End Sub

    Private Shared Sub PrintReceipt_FetchData()
        Dim qty As Integer = report.Fields(DAInvoiceItem.TOTALQTY).Value
        Dim price As Decimal = report.Fields(DAInvoiceItem.UNIT_PRICE_QUOTED).Value
        Dim tax As Decimal = report.Fields(DAInvoiceItem.TAXAMT).Value
        Dim disc As Decimal = report.Fields(DAInvoiceItem.UNIT_DISCOUNT).Value
        Dim itemName As String = report.Fields(DAInvoiceItem.NAME).Value
        Dim remarks As String = report.Fields(DAInvoiceItem.REMARKS).Value
        Dim itemCode As String = report.Fields(DAInvoiceItem.ITEM_CODE).Value

        'If remarks <> salesman Then
        '    Me.Fields(DESC_FIELD).Value = itemCode & " " & itemName & " (" & remarks & ")"
        'Else
        '    Me.Fields(DESC_FIELD).Value = itemCode & " " & itemName
        'End If

        'Me.Fields(UNIT_PRICE_FIELD).Value = price
        report.Fields("AMOUNT_FIELD").Value = qty * price

        'row += 1
        'Me.Fields(NO_FIELD).Value = row
    End Sub
#End Region

#Region " PrintDailySalesReport "

    Private Const CARD_DETAILS_FIELD = "card_details"

    Public Shared Sub PrintDailySalesReport(ByVal userId As Integer, ByVal dateFrom As Date, _
                                            ByVal dateTo As Date, ByVal posId As Integer, _
                                            Optional ByVal strReportName As String = "")
        Dim myCursor As New WaitCursor

        Dim ds As New DataSet
        Dim dsDailySales As New DataSet
        Dim dsCollection As New DataSet
        Dim dsDepositCollection As New DataSet
        Dim dsVoidCollection As New DataSet

        Dim totalSales As Decimal
        Dim totalBill As Integer
        Dim totalSalesBeforeTax As Decimal

        Dim totalSalesVoid As Decimal
        Dim totalBillVoid As Integer
        Dim totalSalesBeforeTaxVoid As Decimal

        Try
            report = getReport(gAppConfig.PrintableDailySalesReport)
            If report Is Nothing Then Exit Sub

            AddHandler report.DataInitialize, AddressOf PrintDailySalesReport_DataInitialize
            AddHandler report.FetchData, AddressOf PrintDailySalesReport_FetchData

            ' Report Header
            SetReportHeader(report)

            If strReportName <> "" Then
                GetTextBox(report, "txtReportName").Text = strReportName
            End If

            GetTextBox(report, "txtDate").Text = FormatDateTime(dateFrom) & " TO " & FormatDateTime(dateTo)
            GetTextBox(report, "txtTime").Text = FormatShortDate(Now) & Space(10) & FormatTime(Now)
            GetTextBox(report, "txtUser").Text = IIf(userId = 0, "ALL", objDA.GetUserName(userId)) & " / " & IIf(posId = 0, "ALL", posId)
            GetTextBox(report, "txtBranch").Text = gBranchObj.code

            GetTextBox(report, "txtInvoiceNo").DataField = "invoice_no"
            GetTextBox(report, "txtAmt").DataField = DAOfficialReceipt.AMOUNT_CARD
            GetTextBox(report, "txtCardDetails").DataField = CARD_DETAILS_FIELD

            ' Total Sales
            ds = Nothing
            ds = objDA.GetDailySalesReport(userId, dateFrom, dateTo, posId)
            If ds IsNot Nothing AndAlso Not ds.Tables(0).Rows.Count = 0 Then
                If Not ds.Tables(0).Rows(0)("sum").ToString = "" AndAlso Not ds.Tables(0).Rows(0)("sum").ToString = "0" Then
                    totalBill = ds.Tables(0).Rows(0)("count")
                    totalSales = ds.Tables(0).Rows(0)("sum")
                    totalSalesBeforeTax = ds.Tables(0).Rows(0)("sum_no_gst")
                End If
            End If

            ' Total Void Sales
            ds = Nothing
            ds = objDA.GetDailySalesReportVoid(userId, dateFrom, dateTo, posId)
            If ds IsNot Nothing AndAlso Not ds.Tables(0).Rows.Count = 0 Then
                If Not ds.Tables(0).Rows(0)("sum").ToString = "" AndAlso Not ds.Tables(0).Rows(0)("sum").ToString = "0" Then
                    totalBillVoid = ds.Tables(0).Rows(0)("count")
                    totalSalesVoid = ds.Tables(0).Rows(0)("sum")
                    totalSalesBeforeTaxVoid = ds.Tables(0).Rows(0)("sum_no_gst")
                End If
            End If


            ' Collection Details Sub Report
            Dim srptCollection As New DataDynamics.ActiveReports.ActiveReport3
            srptCollection = getReport(gAppConfig.PrintableDailySalesReport, "collection")
            If Not srptCollection Is Nothing Then

                GetSubReport(report, "srptCollection").Report = srptCollection

                GetTextBox(srptCollection, "txtName").DataField = "NAME"
                GetTextBox(srptCollection, "txtQty").DataField = "COUNT"
                GetTextBox(srptCollection, "txtAmt").DataField = "AMOUNT"
                GetTextBox(srptCollection, "txtTotalQty").DataField = "COUNT"
                GetTextBox(srptCollection, "txtTotalAmt").DataField = "AMOUNT"

                dsCollection = objDA.GetDailySalesReportCollection(userId, dateFrom, dateTo, posId, _
                                                                   dsVoidCollection, dsDepositCollection)
                If Not dsCollection.Tables(0).Rows.Count = 0 Then
                    srptCollection.DataSource = dsCollection.Tables(0)
                End If

            End If


            ' Collection Deposit Sub Report
            Dim srptCollectionDeposit As New DataDynamics.ActiveReports.ActiveReport3
            srptCollectionDeposit = getReport(gAppConfig.PrintableDailySalesReport, "collection_deposit")
            If Not srptCollectionDeposit Is Nothing Then

                GetSubReport(report, "srptCollectionDeposit").Report = srptCollectionDeposit

                GetTextBox(srptCollectionDeposit, "txtName").DataField = "NAME"
                GetTextBox(srptCollectionDeposit, "txtQty").DataField = "COUNT"
                GetTextBox(srptCollectionDeposit, "txtAmt").DataField = "BALANCE"
                GetTextBox(srptCollectionDeposit, "txtTotalQty").DataField = "COUNT"
                GetTextBox(srptCollectionDeposit, "txtTotalAmt").DataField = "BALANCE"

                If Not dsDepositCollection.Tables(0).Rows.Count = 0 Then
                    srptCollectionDeposit.DataSource = dsDepositCollection.Tables(0)
                End If

            End If

            ' Get Card Details Sales
            ds = Nothing
            ds = objDA.GetDailyCardDetails(userId, dateFrom, dateTo, posId)
            If Not ds.Tables(0).Rows.Count = 0 Then
                report.DataSource = ds.Tables(0)
            End If

            ' Get Cash In and Out
            ds = Nothing
            Dim totalAmt As Decimal = 0
            ds = objDA.GetCashInOutSummary(userId, dateFrom, dateTo, posId)
            If ds IsNot Nothing Then
                For Each row As DataRow In ds.Tables(0).Rows
                    If row("status").ToString = DAPosCashInOut.STATUS_CASH_IN Then
                        'txtQtyCashIn.Text = row("count").ToString
                        GetTextBox(report, "txtAmtCashIn").Text = FormatCurrency(row("sum"))
                    Else
                        'txtQtyCashOut.Text = row("count").ToString
                        GetTextBox(report, "txtAmtCashOut").Text = FormatCurrency(row("sum"))
                    End If
                    totalAmt += row("sum")
                Next
            End If

            ' Get Deposit
            Dim totalDeposit As Decimal = 0
            If dsDepositCollection IsNot Nothing AndAlso Not dsDepositCollection.Tables(0).Rows.Count = 0 Then
                For Each row As DataRow In dsDepositCollection.Tables(0).Rows
                    If row("NAME") = "CASH" AndAlso row("BALANCE") <> 0 Then
                        totalDeposit = row("BALANCE")
                        GetTextBox(report, "txtAmtDeposit").Text = FormatCurrency(totalDeposit)
                        Exit For
                    End If
                Next
            End If

            ' Get Cash Sales
            If dsCollection IsNot Nothing AndAlso Not dsCollection.Tables(0).Rows.Count = 0 Then
                For Each row As DataRow In dsCollection.Tables(0).Rows
                    If row("NAME") = "CASH" AndAlso row("AMOUNT") <> 0 Then
                        GetTextBox(report, "txtAmtCashSales").Text = FormatCurrency(row("AMOUNT"))
                        Exit For
                    End If
                Next
            End If

            ' Get Total Cash Drawer
            GetTextBox(report, "txtTotalDrawer").Text = FormatCurrency(totalAmt + totalDeposit + Convert.ToDecimal(GetTextBox(report, "txtAmtCashSales").Text))

            ' Get Summary subreport
            Dim srptSummary As New DataDynamics.ActiveReports.ActiveReport3
            srptSummary = getReport(gAppConfig.PrintableDailySalesReport, "summary")

            If Not srptSummary Is Nothing Then

                GetSubReport(report, "srptSummary").Report = srptSummary

                GetTextBox(srptSummary, "txtName").DataField = "NAME"
                GetTextBox(srptSummary, "txtQty").DataField = "COUNT"
                GetTextBox(srptSummary, "txtAmt").DataField = "AMOUNT"

                ' Void Collection
                If Not dsVoidCollection.Tables(0).Rows.Count = 0 Then
                    srptSummary.DataSource = dsVoidCollection.Tables(0)
                End If

                ' Gross Sales
                GetTextBox(srptSummary, "txtGrossSalesQty").Text = FormatInt(totalBill)
                GetTextBox(srptSummary, "txtGrossSalesAmt").Text = FormatCurrency(totalSales)

                GetTextBox(srptSummary, "txtTotalAmt").Text = FormatCurrency(totalSales - totalSalesVoid)
                GetTextBox(srptSummary, "txtTotalAmtBeforeTax").Text = FormatCurrency(totalSalesBeforeTax - totalSalesBeforeTaxVoid)
            End If

            report.Run()

            Dim viewerForm As New frmPreview()
            viewerForm.rpt = report
            viewerForm.ShowDialog()

        Catch ex As Exception
            Messenger.Caption = "Daily Sales Report Error!"
            Messenger.ShowError(ex)

        Finally
            myCursor.Dispose()
        End Try

    End Sub

    Private Shared Sub PrintDailySalesReport_DataInitialize()
        report.Fields.Add(CARD_DETAILS_FIELD)
    End Sub

    Private Shared Sub PrintDailySalesReport_FetchData()
        Try
            If report.DataSource Is Nothing Then Exit Sub

            Dim cardType As String = report.Fields(DAOfficialReceipt.CARD_TYPE).Value
            Dim cardNo As String = report.Fields(DAOfficialReceipt.CARD_NUMBER).Value
            Dim cardValidThru As DateTime = report.Fields(DAOfficialReceipt.CARD_VALID_THRU).Value

            report.Fields(CARD_DETAILS_FIELD).Value = ""
            If cardType <> "" Then
                report.Fields(CARD_DETAILS_FIELD).Value &= cardType
            End If

            If cardNo.Length >= 12 Then
                report.Fields(CARD_DETAILS_FIELD).Value &= " XXXX XXXX " & cardNo.Substring(cardNo.Length - 4, 4)
            End If

            report.Fields(CARD_DETAILS_FIELD).Value &= " " & Utils.General.FormatDateTime2(cardValidThru)

        Catch ex As Exception
            Utils.General.WriteToLogFile(ex.Message)
        End Try
    End Sub

#End Region

#Region " PrintStockSummarySoldReport "

    Public Shared Sub PrintStockSummarySoldReport(ByVal userId As Integer, ByVal dateFrom As Date, _
                                                ByVal dateTo As Date, ByVal posId As Integer)

        Try
            count = 0
            report = getReport(gAppConfig.PrintableStockSummarySoldReport)
            If report Is Nothing Then Exit Sub

            AddHandler report.DataInitialize, AddressOf PrintStockSummaryReport_DataInitialize
            AddHandler report.FetchData, AddressOf PrintStockSummaryReport_FetchData

            ' Report Header
            SetReportHeader(report)

            Dim ds As DataSet = Nothing
            Try
                GetTextBox(report, "txtDate").Text = FormatDateTime(dateFrom) & " TO " & FormatDateTime(dateTo)
                GetTextBox(report, "txtTime").Text = FormatShortDate(Now) & Space(10) & FormatTime(Now)
                GetTextBox(report, "txtUser").Text = IIf(userId = 0, "ALL", objDA.GetUserName(userId)) & " / " & IIf(posId = 0, "ALL", posId)

                ' get transaction
                ds = Nothing
                ds = objDA.GetSummaryStockSold(userId, dateFrom, dateTo, posId)
                report.DataSource = ds.Tables(0)

                report.Run()

                Dim viewerForm As New frmPreview()
                viewerForm.rpt = report
                viewerForm.ShowDialog()

            Catch ex As Exception
                Messenger.ShowError("Summary Stock Sold Printable Error!")
                WriteToLogFile(ex.Message)
            End Try

        Catch ex As Exception
            Utils.General.WriteToLogFile(ex.Message)
        End Try

    End Sub

    Private Shared Sub PrintStockSummaryReport_DataInitialize()
        report.Fields.Add("NO")
    End Sub

    Private Shared Sub PrintStockSummaryReport_FetchData()
        count += 1
        report.Fields("NO").Value = count
    End Sub

#End Region

    Private Shared Function GetTextBox(ByVal report As DataDynamics.ActiveReports.ActiveReport3, ByVal name As String) As DataDynamics.ActiveReports.TextBox
        Dim txtBox As New DataDynamics.ActiveReports.TextBox

        For Each section As DataDynamics.ActiveReports.Section In report.Sections
            For Each ctl As DataDynamics.ActiveReports.ARControl In section.Controls
                If ctl.Name = name AndAlso TypeOf (ctl) Is DataDynamics.ActiveReports.TextBox Then
                    txtBox = DirectCast(ctl, DataDynamics.ActiveReports.TextBox)
                    'txtBox.Font = System.Drawing.Font("Courier")
                    'txtBox.Font = New System.Drawing.Font("Courier", 8, FontStyle.Regular)
                End If
            Next
        Next

        Return txtBox
    End Function

    Private Shared Function GetSubReport(ByVal report As DataDynamics.ActiveReports.ActiveReport3, _
                                            ByVal name As String) As DataDynamics.ActiveReports.SubReport
        Dim srpt As New DataDynamics.ActiveReports.SubReport

        For Each section As DataDynamics.ActiveReports.Section In report.Sections
            For Each ctl As DataDynamics.ActiveReports.ARControl In section.Controls
                If ctl.Name = name AndAlso TypeOf (ctl) Is DataDynamics.ActiveReports.SubReport Then
                    srpt = DirectCast(ctl, DataDynamics.ActiveReports.SubReport)
                End If
            Next
        Next

        Return srpt
    End Function


    Private Shared Sub SetReportHeader(ByVal report As DataDynamics.ActiveReports.ActiveReport3)

        GetTextBox(report, "txtRegNo").Text = ""
        GetTextBox(report, "txtBranchName").Text = gBranchObj.name
        GetTextBox(report, "txtAdd1").Text = gBranchObj.addr1
        GetTextBox(report, "txtAdd2").Text = gBranchObj.addr2

        If gBranchObj.addr3 <> "" Then
            GetTextBox(report, "txtAdd2").Text &= " " & gBranchObj.addr3
        End If
        If gBranchObj.state <> "" Then
            GetTextBox(report, "txtAdd2").Text &= " " & gBranchObj.state
        End If
        If gBranchObj.zip <> "" Then
            GetTextBox(report, "txtAdd2").Text &= " " & gBranchObj.zip
        End If
        If gBranchObj.taxRegNumber <> "" Then
            GetTextBox(report, "txtRegNo").Text = "GST Reg No.: " & gBranchObj.taxRegNumber
        End If

        GetTextBox(report, "txtTel").Text = "Tel:" & gBranchObj.phoneNo

    End Sub

End Class
