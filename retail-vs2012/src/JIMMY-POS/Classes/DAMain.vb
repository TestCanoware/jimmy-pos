Imports Utils.General
Imports Utils
Imports DataAccess
Imports ThickClient.EMPThickClientService

Public Class DAMain

    Public Const STATE_CANCELLED As String = "cancelled"
    Public Const STATE_ACTIVE As String = "active"
    Public Const STATUS_CASH_OUT As String = "cash out"
    Public Const STATUS_CASH_IN As String = "cash in"
    Public Const STATUS_START As String = "start"
    Public Const STATUS_END As String = "end"
    Public Const STATUS_COMPLETE As String = "complete"
    Public Const STATUS_PENDING As String = "pending"

    Public objDA As New DataAccess.Commands

    Public Sub getBranchObject(ByVal pkid As Integer, ByRef ds As DataSet)

        Dim strSQL As String

        Try
            'strSQL = "SELECT name, addr1, addr2, addr3, phone_no FROM acc_branch_index WHERE pkid = " & pkid
            strSQL = "SELECT * FROM acc_branch_index WHERE pkid = " & pkid
            ds = objDA.ExecuteQuery(strSQL, "0", DataAccess.Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Messenger.ShowError("getBranchObject: " & ex.Message)
        End Try

    End Sub

    Public Sub getBranchObject(ByRef ds As DataSet)

        Dim strSQL As String

        Try
            strSQL = "SELECT * FROM acc_branch_index"
            ds = objDA.ExecuteQuery(strSQL, "0", DataAccess.Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Messenger.ShowError("getBranchObject : " & ex.Message)
        End Try

    End Sub

    Public Sub getUserObject(ByRef ds As DataSet)

        Dim strSQL As String

        Try
            strSQL = "SELECT userid, username FROM user_index WHERE userId != 500 AND userId != 501 ORDER BY username"
            ds = objDA.ExecuteQuery(strSQL, "0", DataAccess.Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Messenger.ShowError("getUserObject: " & ex.Message)
        End Try

    End Sub

    Public Function getUserName(ByVal userId As Integer) As String

        Dim strSQL As String
        Dim ds As DataSet = Nothing
        Dim strName As String = ""
        Try
            strSQL = "SELECT * FROM user_index WHERE userid = " & userId
            ds = objDA.ExecuteQuery(strSQL, "0", DataAccess.Commands.ReturnType.DataSetType)
            If ds IsNot Nothing Then
                If ds.Tables(0).Rows.Count > 0 Then
                    strName = ds.Tables(0).Rows(0)("username")
                End If
            End If

        Catch ex As Exception
            Messenger.ShowError("getUserName: " & ex.Message)
        End Try

        Return strName
    End Function

    Public Function deleteUser(ByVal userId As Integer) As Boolean

        Dim strSQL As String

        Try
            strSQL = "DELETE FROM user_index WHERE userid = " & userId
            objDA.ExecuteNonQuery(strSQL)
            Return True

        Catch ex As Exception
            Messenger.ShowError("deleteUser: " & ex.Message)
            Return False
        End Try

    End Function

    Public Function insertUser(ByVal user As userObject) As Boolean

        Dim strSQL As String

        Try
            strSQL = "INSERT INTO user_index VALUES({0},{1},{2},{3},{4},{5},{6})"
            strSQL = String.Format(strSQL, PreparedStatement(user.userId), _
                                            PreparedStatement(user.userName), _
                                            PreparedStatement(user.password), _
                                            PreparedStatement(user.nameFirst), _
                                            PreparedStatement(user.nameLast), _
                                            PreparedStatement(user.status), _
                                            PreparedStatement(user.password2))
            objDA.ExecuteNonQuery(strSQL)

            Dim pkid As Integer = getMaxPkid("user_config_registry")
            strSQL = "INSERT INTO user_config_registry (pkid, userid, category, namespace, value1, status, userid_edit, time_edit) " & _
                        "VALUES ({0}, {1}, 'DEFAULT', 'CUSTSVCCTR', {2}, 'active', {3}, {4} )"
            strSQL = String.Format(strSQL, PreparedStatement(pkid), _
                                            PreparedStatement(user.userId), _
                                            gBranchID, _
                                            gUserID, _
                                            PreparedStatement(Now))
            objDA.ExecuteNonQuery(strSQL)
            Return True

        Catch ex As Exception
            Messenger.ShowError("insertUser: " & ex.Message)
            Return False
        End Try

    End Function

    Public Function insertItem(ByVal item As itemObject) As Boolean

        Dim strSQL As String
        'Dim pkid As Long
        Try
            'pkid = getMaxPkid("inv_item", 1001)

            strSQL = "INSERT INTO inv_item (pkid,item_code,name,description,status,lastupdate,userid_edit,uom,unit_of_meas,inv_type,item_type1,item_type2,item_type3,glcode,state,categoryid,category1,category2,category3,category4,category5,has_children,parentid,parent_ratio,ean_code,upc_code,isbn_code,price_list,price_sale,price_disc1,price_disc2,price_disc3,price_min,fifo_unit_cost,ma_unit_cost,wa_unit_cost,last_unit_cost,replacement_cost,serialized,weight,length,width,depth,preferred_supplier,min_order_qty,lead_time,reserved1,reserved2,reserved3,pix_thumb_name,pix_full_name,pix_thumbnail,pix_fullsize,rebate1_pct,rebate1_price,rebate1_start,rebate1_end,disc1_pct,disc1_amount,disc1_start,disc1_end,production_required,production_lead_time,production_cost,production_process,production_name,production_description,delivery_required,delivery_lead_time,delivery_cost,delivery_process,delivery_name,delivery_description,delta_price_retail_amt,delta_price_retail_pct,delta_price_dealer_amt,delta_price_dealer_pct,delta_price_outlet_amt,delta_price_outlet_pct,disc_max_pct,warranty_type,warranty_period,shelf_life,commission_pct_sales1,commission_pct_sales2,commission_pct_sales3,commission_pct_sales4,commission_pct_partner,commission_pct_gp,logic_reorder,logic_max_qty,threshold_qty_reorder,threshold_qty_max_qty,remarks1,remarks2,keywords,prefix_logic,prefix_length,prefix_code,postfix_logic,postfix_length,postfix_code,code_project,code_department,code_dealer,code_salesman,tax_option,tax_rate,price_ecom,out_qty,out_unit,in_qty,in_unit,inn_qty,inn_unit,inm_qty,inm_unit) " & _
                        " VALUES ("
            Dim noOfColumns As Integer = 117
            For i As Integer = 1 To noOfColumns - 1
                strSQL &= "{" & i & "},"
            Next i

            strSQL &= "{" & noOfColumns & "})"
            ' end column

            strSQL = strSQL.Replace("{1}", item.pkid)
            strSQL = strSQL.Replace("{2}", PreparedStatement(item.code))
            strSQL = strSQL.Replace("{3}", PreparedStatement(item.name))
            strSQL = strSQL.Replace("{4}", PreparedStatement(item.description))
            strSQL = strSQL.Replace("{5}", PreparedStatement(item.status))
            strSQL = strSQL.Replace("{6}", PreparedStatement(item.lastUpdate))
            strSQL = strSQL.Replace("{7}", PreparedStatement(item.userIdUpdate))
            strSQL = strSQL.Replace("{8}", PreparedStatement(item.uom))
            strSQL = strSQL.Replace("{9}", PreparedStatement(item.unitOfMeasure))
            strSQL = strSQL.Replace("{10}", PreparedStatement(item.enumInvType))
            strSQL = strSQL.Replace("{11}", PreparedStatement(item.itemType1))
            strSQL = strSQL.Replace("{12}", PreparedStatement(item.itemType2))
            strSQL = strSQL.Replace("{13}", PreparedStatement(item.itemType3))
            strSQL = strSQL.Replace("{14}", PreparedStatement(item.glcode))
            strSQL = strSQL.Replace("{15}", PreparedStatement(item.state))
            strSQL = strSQL.Replace("{16}", PreparedStatement(item.categoryId))
            strSQL = strSQL.Replace("{17}", PreparedStatement(item.category1))
            strSQL = strSQL.Replace("{18}", PreparedStatement(item.category2))
            strSQL = strSQL.Replace("{19}", PreparedStatement(item.category3))
            strSQL = strSQL.Replace("{20}", PreparedStatement(item.category4))
            strSQL = strSQL.Replace("{21}", PreparedStatement(item.category5))
            strSQL = strSQL.Replace("{22}", PreparedStatement(item.hasChildren))
            strSQL = strSQL.Replace("{23}", PreparedStatement(item.parentId))
            strSQL = strSQL.Replace("{24}", PreparedStatement(item.parentRatio))
            strSQL = strSQL.Replace("{25}", PreparedStatement(item.EANCode))
            strSQL = strSQL.Replace("{26}", PreparedStatement(item.upcCode))
            strSQL = strSQL.Replace("{27}", PreparedStatement(item.isbnCode))
            strSQL = strSQL.Replace("{28}", PreparedStatement(item.priceList))
            strSQL = strSQL.Replace("{29}", PreparedStatement(item.priceSale))
            strSQL = strSQL.Replace("{30}", PreparedStatement(item.priceDisc1))
            strSQL = strSQL.Replace("{31}", PreparedStatement(item.priceDisc2))
            strSQL = strSQL.Replace("{32}", PreparedStatement(item.priceDisc3))
            strSQL = strSQL.Replace("{33}", PreparedStatement(item.priceMin))
            strSQL = strSQL.Replace("{34}", PreparedStatement(item.fifoUnitCost))
            strSQL = strSQL.Replace("{35}", PreparedStatement(item.maUnitCost))
            strSQL = strSQL.Replace("{36}", PreparedStatement(item.waUnitCost))
            strSQL = strSQL.Replace("{37}", PreparedStatement(item.lastUnitCost))
            strSQL = strSQL.Replace("{38}", PreparedStatement(item.replacementUnitCost))
            strSQL = strSQL.Replace("{39}", PreparedStatement(item.serialized))
            strSQL = strSQL.Replace("{40}", PreparedStatement(item.weight))
            strSQL = strSQL.Replace("{41}", PreparedStatement(item.length))
            strSQL = strSQL.Replace("{42}", PreparedStatement(item.width))
            strSQL = strSQL.Replace("{43}", PreparedStatement(item.depth))
            strSQL = strSQL.Replace("{44}", PreparedStatement(item.minOrderQty))
            strSQL = strSQL.Replace("{45}", PreparedStatement(item.preferredSupplier))
            strSQL = strSQL.Replace("{46}", PreparedStatement(item.leadTime))
            strSQL = strSQL.Replace("{47}", PreparedStatement(item.reserved1))
            strSQL = strSQL.Replace("{48}", PreparedStatement(item.reserved2))
            strSQL = strSQL.Replace("{49}", PreparedStatement(item.reserved3))
            strSQL = strSQL.Replace("{50}", PreparedStatement(item.pixThumbName))
            strSQL = strSQL.Replace("{51}", PreparedStatement(item.pixFullName))
            strSQL = strSQL.Replace("{52}", PreparedStatement(item.pixThumbnail))
            strSQL = strSQL.Replace("{53}", PreparedStatement(item.pixFullsize))
            strSQL = strSQL.Replace("{54}", PreparedStatement(item.rebate1Pct))
            strSQL = strSQL.Replace("{55}", PreparedStatement(item.rebate1Price))
            strSQL = strSQL.Replace("{56}", PreparedStatement(item.rebate1Start))
            strSQL = strSQL.Replace("{57}", PreparedStatement(item.rebate1End))
            strSQL = strSQL.Replace("{58}", PreparedStatement(item.disc1Pct))
            strSQL = strSQL.Replace("{59}", PreparedStatement(item.disc1Amount))
            strSQL = strSQL.Replace("{60}", PreparedStatement(item.disc1Start))
            strSQL = strSQL.Replace("{61}", PreparedStatement(item.disc1End))
            strSQL = strSQL.Replace("{62}", PreparedStatement(item.productionRequired))
            strSQL = strSQL.Replace("{63}", PreparedStatement(item.productionLeadTime))
            strSQL = strSQL.Replace("{64}", PreparedStatement(item.productionCost))
            strSQL = strSQL.Replace("{65}", PreparedStatement(item.productionProcess))
            strSQL = strSQL.Replace("{66}", PreparedStatement(item.productionName))
            strSQL = strSQL.Replace("{67}", PreparedStatement(item.productionDescription))
            strSQL = strSQL.Replace("{68}", PreparedStatement(item.deliveryRequired))
            strSQL = strSQL.Replace("{69}", PreparedStatement(item.deliveryLeadTime))
            strSQL = strSQL.Replace("{70}", PreparedStatement(item.deliveryCost))
            strSQL = strSQL.Replace("{71}", PreparedStatement(item.deliveryProcess))
            strSQL = strSQL.Replace("{72}", PreparedStatement(item.deliveryName))
            strSQL = strSQL.Replace("{73}", PreparedStatement(item.deliveryDescription))
            strSQL = strSQL.Replace("{74}", PreparedStatement(item.deltaPriceRetailAmt))
            strSQL = strSQL.Replace("{75}", PreparedStatement(item.deltaPriceRetailPct))
            strSQL = strSQL.Replace("{76}", PreparedStatement(item.deltaPriceDealerAmt))
            strSQL = strSQL.Replace("{77}", PreparedStatement(item.deltaPriceDealerPct))
            strSQL = strSQL.Replace("{78}", PreparedStatement(item.deltaPriceOutletAmt))
            strSQL = strSQL.Replace("{79}", PreparedStatement(item.deltaPriceOutletPct))
            strSQL = strSQL.Replace("{80}", PreparedStatement(item.discMaxPct))
            strSQL = strSQL.Replace("{81}", PreparedStatement(item.warrantyType))
            strSQL = strSQL.Replace("{82}", PreparedStatement(item.warrantyPeriod))
            strSQL = strSQL.Replace("{83}", PreparedStatement(item.shelfLife))
            strSQL = strSQL.Replace("{84}", PreparedStatement(item.commissionPctSales1))
            strSQL = strSQL.Replace("{85}", PreparedStatement(item.commissionPctSales2))
            strSQL = strSQL.Replace("{86}", PreparedStatement(item.commissionPctSales3))
            strSQL = strSQL.Replace("{87}", PreparedStatement(item.commissionPctSales4))
            strSQL = strSQL.Replace("{88}", PreparedStatement(item.commissionPctPartner))
            strSQL = strSQL.Replace("{89}", PreparedStatement(item.commissionPctGP))
            strSQL = strSQL.Replace("{90}", PreparedStatement(item.logicReorder))
            strSQL = strSQL.Replace("{91}", PreparedStatement(item.logicMaxQty))
            strSQL = strSQL.Replace("{92}", PreparedStatement(item.thresholdQtyReorder))
            strSQL = strSQL.Replace("{93}", PreparedStatement(item.thresholdQtyMaxQty))
            strSQL = strSQL.Replace("{94}", PreparedStatement(item.remarks1))
            strSQL = strSQL.Replace("{95}", PreparedStatement(item.remarks2))
            strSQL = strSQL.Replace("{96}", PreparedStatement(item.keywords))
            strSQL = strSQL.Replace("{97}", PreparedStatement(item.prefixLogic))
            strSQL = strSQL.Replace("{98}", PreparedStatement(item.prefixLength))
            strSQL = strSQL.Replace("{99}", PreparedStatement(item.prefixCode))
            strSQL = strSQL.Replace("{100}", PreparedStatement(item.postfixLogic))
            strSQL = strSQL.Replace("{101}", PreparedStatement(item.postfixLength))
            strSQL = strSQL.Replace("{102}", PreparedStatement(item.postfixCode))
            strSQL = strSQL.Replace("{103}", PreparedStatement(item.codeProject))
            strSQL = strSQL.Replace("{104}", PreparedStatement(item.codeDepartment))
            strSQL = strSQL.Replace("{105}", PreparedStatement(item.codeDealer))
            strSQL = strSQL.Replace("{106}", PreparedStatement(item.codeSalesman))
            strSQL = strSQL.Replace("{107}", PreparedStatement(item.tax_option))
            strSQL = strSQL.Replace("{108}", PreparedStatement(item.tax_rate))
            strSQL = strSQL.Replace("{109}", PreparedStatement(item.priceEcom))
            strSQL = strSQL.Replace("{110}", PreparedStatement(item.outQty))
            strSQL = strSQL.Replace("{111}", PreparedStatement(item.outUnit))
            strSQL = strSQL.Replace("{112}", PreparedStatement(item.inQty))
            strSQL = strSQL.Replace("{113}", PreparedStatement(item.inUnit))
            strSQL = strSQL.Replace("{114}", PreparedStatement(item.innQty))
            strSQL = strSQL.Replace("{115}", PreparedStatement(item.innUnit))
            strSQL = strSQL.Replace("{116}", PreparedStatement(item.inmQty))
            strSQL = strSQL.Replace("{117}", PreparedStatement(item.inmUnit))

            objDA.ExecuteNonQuery(strSQL)
            Return True

        Catch ex As Exception
            Messenger.ShowError("insertItem: " & ex.Message)
            Return False
        End Try

    End Function

    Public Function insertBranch(ByVal newObj As branchObject) As Boolean

        Dim strSQL As String
        'Dim pkid As Long
        Try
            'pkid = getMaxPkid("acc_branch_index", 1)

            strSQL = "INSERT INTO acc_branch_index (pkid,code,reg_no,name,description,addr1,addr2,addr3,zip,state,countrycode,phone_no,fax_no,web_url,acc_pccenterid,inv_locationid,status,lastupdate,userid_edit,cashbook_cash,cashbook_card,cashbook_cheque,cashbook_pd_cheque,cashbook_coupon,cashbook_other,cashbook_payment,logo_url,currency,pricing,hotlines,default_visa_rate,default_master_rate,default_amex_rate,default_diner_rate,default_card1_rate,default_card2_rate,default_card3_rate,default_other_rate,format_invoice_header_text,format_invoice_footer_text,format_invoice_entity_address,format_invoice_row,format_invoice_type,format_cashsale_header_text,format_cashsale_footer_text,format_cashsale_entity_address,format_cashsale_row,format_cashsale_type,format_receipt_header_text,format_receipt_footer_text,format_receipt_entity_address,format_receipt_row,format_receipt_type,format_purchase_order_header_text,format_purchase_order_footer_text,format_purchase_order_row,format_purchase_order_type,format_salary_slip_header_text,format_salary_slip_footer_text,format_salary_slip_row,format_salary_slip_type,format_payment_voucher_header_text,format_payment_voucher_footer_text,format_payment_voucher_row,format_payment_voucher_type,format_credit_memo_header_text,format_credit_memo_footer_text,format_credit_memo_row,format_credit_memo_type,default_rma_location_cust,default_rma_location_supp,default_rma_location_hq,default_rma_location_branch,manager_password01,manager_password02,manager_password03,manager_password04,manager_password05,manager_password06,manager_password07,manager_password08,manager_password09,telephone_developer,telephone_sysadmin,telephone_clerk,telephone_admin,telephone_manager,telephone_sales,telephone_tech_support,telephone_director,mobilephone_developer,mobilephone_sysadmin,mobilephone_clerk,mobilephone_admin,mobilephone_manager,mobilephone_sales,mobilephone_tech_support,mobilephone_director,email_system,email_developer,email_sysadmin,email_clerk,email_admin,email_manager,email_sales,email_tech_support,email_director,customer_id,supplier_id,loyalty_card_no_prefix,loyalty_card_no_postfix,crv_day_from,crv_day_to,format_proforma_invoice_type,format_proforma_invoice_footer_text,format_proforma_invoice_header_text,format_proforma_invoice_row,format_service_note_type,format_service_note_footer_text,format_service_note_header_text,format_service_note_row,tax_reg_number) " & _
                        " VALUES ("
            Dim noOfColumns As Integer = 122
            For i As Integer = 0 To noOfColumns - 2
                strSQL &= "{" & i & "},"
            Next i

            strSQL &= "{" & noOfColumns - 1 & "})"
            ' end column

            strSQL = String.Format(strSQL, newObj.pkid, _
                                    PreparedStatement(newObj.code), _
                                    PreparedStatement(newObj.regNo), _
                                    PreparedStatement(newObj.name), _
                                    PreparedStatement(newObj.description), _
                                    PreparedStatement(newObj.addr1), _
                                    PreparedStatement(newObj.addr2), _
                                    PreparedStatement(newObj.addr3), _
                                    PreparedStatement(newObj.zip), _
                                    PreparedStatement(newObj.state), _
                                    PreparedStatement(newObj.countryCode), _
                                    PreparedStatement(newObj.phoneNo), _
                                    PreparedStatement(newObj.faxNo), _
                                    PreparedStatement(newObj.webUrl), _
                                    PreparedStatement(newObj.accPCCenterId), _
                                    PreparedStatement(newObj.invLocationId), _
                                    PreparedStatement(newObj.status), _
                                    PreparedStatement(newObj.lastUpdate), _
                                    PreparedStatement(newObj.userIdUpdate), _
                                    PreparedStatement(newObj.cashbookCash), _
                                    PreparedStatement(newObj.cashbookCard), _
                                    PreparedStatement(newObj.cashbookCheque), _
                                    PreparedStatement(newObj.cashbookPDCheque), _
                                    PreparedStatement(newObj.cashbookCoupon), _
                                    PreparedStatement(newObj.cashbookOther), _
                                    PreparedStatement(newObj.cashbookPayment), _
                                    PreparedStatement(newObj.logoURL), _
                                    PreparedStatement(newObj.currency), _
                                    PreparedStatement(newObj.pricing), _
                                    PreparedStatement(newObj.hotlines), _
                                    PreparedStatement(newObj.defaultVisaRate), _
                                    PreparedStatement(newObj.defaultMasterRate), _
                                    PreparedStatement(newObj.defaultAmexRate), _
                                    PreparedStatement(newObj.defaultDinerRate), _
                                    PreparedStatement(newObj.defaultCard1Rate), _
                                    PreparedStatement(newObj.defaultCard2Rate), _
                                    PreparedStatement(newObj.defaultCard3Rate), _
                                    PreparedStatement(newObj.defaultOtherRate), _
                                    PreparedStatement(newObj.formatInvoiceHeaderText), _
                                    PreparedStatement(newObj.formatInvoiceFooterText), _
                                    PreparedStatement(newObj.formatInvoiceEntityAddress), _
                                    PreparedStatement(newObj.formatInvoiceRow), _
                                    PreparedStatement(newObj.formatInvoiceType), _
                                    PreparedStatement(newObj.formatCashsaleHeaderText), _
                                    PreparedStatement(newObj.formatCashsaleFooterText), _
                                    PreparedStatement(newObj.formatCashsaleEntityAddress), _
                                    PreparedStatement(newObj.formatCashsaleRow), _
                                    PreparedStatement(newObj.formatCashsaleType), _
                                    PreparedStatement(newObj.formatReceiptHeaderText), _
                                    PreparedStatement(newObj.formatReceiptFooterText), _
                                    PreparedStatement(newObj.formatReceiptEntityAddress), _
                                    PreparedStatement(newObj.formatReceiptRow), _
                                    PreparedStatement(newObj.formatReceiptType), _
                                    PreparedStatement(newObj.formatPurchaseOrderHeaderText), _
                                    PreparedStatement(newObj.formatPurchaseOrderFooterText), _
                                    PreparedStatement(newObj.formatPurchaseOrderRow), _
                                    PreparedStatement(newObj.formatPurchaseOrderType), _
                                    PreparedStatement(newObj.formatSalarySlipHeaderText), _
                                    PreparedStatement(newObj.formatSalarySlipFooterText), _
                                    PreparedStatement(newObj.formatSalarySlipRow), _
                                    PreparedStatement(newObj.formatSalarySlipType), _
                                    PreparedStatement(newObj.formatPaymentVoucherHeaderText), _
                                    PreparedStatement(newObj.formatPaymentVoucherFooterText), _
                                    PreparedStatement(newObj.formatPaymentVoucherRow), _
                                    PreparedStatement(newObj.formatPaymentVoucherType), _
                                    PreparedStatement(newObj.formatCreditMemoHeaderText), _
                                    PreparedStatement(newObj.formatCreditMemoFooterText), _
                                    PreparedStatement(newObj.formatCreditMemoRow), _
                                    PreparedStatement(newObj.formatCreditMemoType), _
                                    PreparedStatement(newObj.defaultRmaLocationCust), _
                                    PreparedStatement(newObj.defaultRmaLocationSupp), _
                                    PreparedStatement(newObj.defaultRmaLocationHq), _
                                    PreparedStatement(newObj.defaultRmaLocationBranch), _
                                    PreparedStatement(newObj.managerPassword01), _
                                    PreparedStatement(newObj.managerPassword02), _
                                    PreparedStatement(newObj.managerPassword03), _
                                    PreparedStatement(newObj.managerPassword04), _
                                    PreparedStatement(newObj.managerPassword05), _
                                    PreparedStatement(newObj.managerPassword06), _
                                    PreparedStatement(newObj.managerPassword07), _
                                    PreparedStatement(newObj.managerPassword08), _
                                    PreparedStatement(newObj.managerPassword09), _
                                    PreparedStatement(newObj.telephoneDeveloper), _
                                    PreparedStatement(newObj.telephoneSysadmin), _
                                    PreparedStatement(newObj.telephoneClerk), _
                                    PreparedStatement(newObj.telephoneAdmin), _
                                    PreparedStatement(newObj.telephoneManager), _
                                    PreparedStatement(newObj.telephoneSales), _
                                    PreparedStatement(newObj.telephoneTechSupport), _
                                    PreparedStatement(newObj.telephoneDirector), _
                                    PreparedStatement(newObj.mobilephoneDeveloper), _
                                    PreparedStatement(newObj.mobilephoneSysadmin), _
                                    PreparedStatement(newObj.mobilephoneClerk), _
                                    PreparedStatement(newObj.mobilephoneAdmin), _
                                    PreparedStatement(newObj.mobilephoneManager), _
                                    PreparedStatement(newObj.mobilephoneSales), _
                                    PreparedStatement(newObj.mobilephoneTechSupport), _
                                    PreparedStatement(newObj.mobilephoneDirector), _
                                    PreparedStatement(newObj.emailSystem), _
                                    PreparedStatement(newObj.emailDeveloper), _
                                    PreparedStatement(newObj.emailSysadmin), _
                                    PreparedStatement(newObj.emailClerk), _
                                    PreparedStatement(newObj.emailAdmin), _
                                    PreparedStatement(newObj.emailManager), _
                                    PreparedStatement(newObj.emailSales), _
                                    PreparedStatement(newObj.emailTechSupport), _
                                    PreparedStatement(newObj.emailDirector), _
                                    PreparedStatement(newObj.customerId), _
                                    PreparedStatement(newObj.supplierId), _
                                    PreparedStatement(newObj.loyaltyCardNoPrefix), _
                                    PreparedStatement(newObj.loyaltyCardNoPostfix), _
                                    PreparedStatement(newObj.crvDayFrom), _
                                    PreparedStatement(newObj.crvDayTo), _
                                    PreparedStatement(newObj.formatProformaInvoiceType), _
                                    PreparedStatement(newObj.formatProformaInvoiceFooterText), _
                                    PreparedStatement(newObj.formatProformaInvoiceHeaderText), _
                                    PreparedStatement(newObj.formatProformaInvoiceRow), _
                                    PreparedStatement(newObj.formatServiceNoteType), _
                                    PreparedStatement(newObj.formatServiceNoteFooterText), _
                                    PreparedStatement(newObj.formatServiceNoteHeaderText), _
                                    PreparedStatement(newObj.formatServiceNoteRow), _
                                    PreparedStatement(newObj.taxRegNumber))

            objDA.ExecuteNonQuery(strSQL)
            Return True

        Catch ex As Exception
            Messenger.ShowError("insertBranch: " & ex.Message)
            Return False
        End Try

    End Function

    Public Function insertStock(ByVal newObj As stockObject) As Boolean

        Dim strSQL As String
        'Dim pkid As Long
        Try
            'pkid = getMaxPkid("inv_stock", 1001)

            strSQL = "INSERT INTO inv_stock (pkid,stock_code,description,itemid,locationid,acc_pccenter_id,bal,conditionid,guid," & _
                        " unit_cost_fifo,unit_cost_ma,unit_cost_wa,unit_cost_last,unit_cost_replacement,last_purchase_date,status,lastupdate,userid_edit, min_qty, max_qty) " & _
                        " VALUES("
            Dim noOfColumns As Integer = 20
            For i As Integer = 0 To noOfColumns - 2
                strSQL &= "{" & i & "},"
            Next i

            strSQL &= "{" & noOfColumns - 1 & "})"
            ' end column

            strSQL = String.Format(strSQL, _
                           PreparedStatement(newObj.pkid), _
                           PreparedStatement(newObj.stockCode), _
                           PreparedStatement(newObj.description), _
                           PreparedStatement(newObj.itemId), _
                           PreparedStatement(newObj.locationId), _
                           PreparedStatement(newObj.accPCCenterId), _
                           PreparedStatement(newObj.balance), _
                           PreparedStatement(newObj.conditionId), _
                           PreparedStatement(newObj.guid), _
                           PreparedStatement(newObj.unitCostFifo), _
                           PreparedStatement(newObj.unitCostMA), _
                           PreparedStatement(newObj.unitCostWA), _
                           PreparedStatement(newObj.unitCostLast), _
                           PreparedStatement(newObj.unitCostReplacement), _
                           PreparedStatement(newObj.lastPurchaseDate), _
                           PreparedStatement(newObj.status), _
                           PreparedStatement(newObj.lastUpdate), _
                           PreparedStatement(newObj.userIdUpdate), _
                            0, 0)

            objDA.ExecuteNonQuery(strSQL)
            Return True

        Catch ex As Exception
            Messenger.ShowError("insertStock: " & ex.Message)
            Return False
        End Try

    End Function

    Public Function insertCashAccount(ByVal newObj As cashAccountObject) As Boolean

        Dim strSQL As String
        Try

            strSQL = "INSERT INTO acc_cash_account (pkid,code,name,description,acc_number,acc_type,currency,level_low,level_high,facility_amount,overdraft_limit,signatory1,signatory2,signatory3,signatory4,signature,pc_center,add1,add2,add3,state,country,phone,contact_person,fax,userid_create,userid_update,createtime,lastupdate,status) " & _
                    " VALUES("
            Dim noOfColumns As Integer = 30
            For i As Integer = 0 To noOfColumns - 2
                strSQL &= "{" & i & "},"
            Next i

            strSQL &= "{" & noOfColumns - 1 & "})"
            ' end column

            strSQL = String.Format(strSQL, _
                           PreparedStatement(newObj.pkId), _
                           PreparedStatement(newObj.code), _
                           PreparedStatement(newObj.name), _
                           PreparedStatement(newObj.description), _
                           PreparedStatement(newObj.accountNumber), _
                           PreparedStatement(newObj.accountType), _
                           PreparedStatement(newObj.currency), _
                           PreparedStatement(newObj.levelLow), _
                           PreparedStatement(newObj.levelHigh), _
                           PreparedStatement(newObj.facilityAmount), _
                           PreparedStatement(newObj.overdraftLimit), _
                           PreparedStatement(newObj.signatory1), _
                           PreparedStatement(newObj.signatory2), _
                           PreparedStatement(newObj.signatory3), _
                           PreparedStatement(newObj.signatory4), _
                           PreparedStatement(newObj.signature), _
                           PreparedStatement(newObj.pcCenter), _
                           PreparedStatement(newObj.add1), _
                           PreparedStatement(newObj.add2), _
                           PreparedStatement(newObj.add3), _
                           PreparedStatement(newObj.state), _
                           PreparedStatement(newObj.country), _
                           PreparedStatement(newObj.phone), _
                           PreparedStatement(newObj.contactPerson), _
                           PreparedStatement(newObj.fax), _
                           PreparedStatement(newObj.userIdCreate), _
                           PreparedStatement(newObj.userIdUpdate), _
                           PreparedStatement(newObj.createTime), _
                           PreparedStatement(newObj.lastUpdate), _
                           PreparedStatement(newObj.status))

            objDA.ExecuteNonQuery(strSQL)
            Return True

        Catch ex As Exception
            Messenger.ShowError("insertStock: " & ex.Message)
            Return False
        End Try

    End Function

    Public Function insertCategoryTree(ByVal newObj As categoryTreeObject) As Boolean

        Dim strSQL As String
        Try

            strSQL = "INSERT INTO inv_category_tree (pkid, parent_id, cat_level, code, sort, name, description) " & _
                    " VALUES("
            Dim noOfColumns As Integer = 7
            For i As Integer = 0 To noOfColumns - 2
                strSQL &= "{" & i & "},"
            Next i

            strSQL &= "{" & noOfColumns - 1 & "})"
            ' end column

            strSQL = String.Format(strSQL, _
                           PreparedStatement(newObj.pkid), _
                           PreparedStatement(newObj.parentId), _
                           PreparedStatement(newObj.catLevel), _
                           PreparedStatement(newObj.code), _
                           PreparedStatement(newObj.sort), _
                           PreparedStatement(newObj.name), _
                           PreparedStatement(newObj.description))

            objDA.ExecuteNonQuery(strSQL)
            Return True

        Catch ex As Exception
            Messenger.ShowError("insertCategoryTree: " & ex.Message)
            Return False
        End Try

    End Function

    'Public Function insertUserPermission(ByVal newObj As TCSync.userPermissionListObject) As Boolean

    '    Dim strSQL As String
    '    Dim userid As Integer = newObj.userID
    '    Dim permList() As String = newObj.permList.Split(",")
    '    Dim pkid As Integer
    '    Dim permissionName As String
    '    Dim value As String = "TRUE"

    '    Try

    '        updateUserPermissionDefault(userid)
    '        For i As Integer = 0 To permList.Length - 1
    '            permissionName = permList(i)

    '            If isExistUserPermission(userid, permissionName) Then
    '                strSQL = "UPDATE cust_pos_permission SET value={0} WHERE userId={1} AND permission={2}"

    '                strSQL = String.Format(strSQL, PreparedStatement(value), userid, PreparedStatement(permissionName))
    '            Else
    '                pkid = getMaxPkid("cust_pos_permission", 1)
    '                strSQL = "INSERT INTO cust_pos_permission (pkid, userid, permission, value)" & _
    '                         " VALUES({0}, {1}, {2}, {3})"

    '                strSQL = String.Format(strSQL, pkid, userid, PreparedStatement(permissionName), PreparedStatement(value))
    '            End If


    '            objDA.ExecuteNonQuery(strSQL)
    '        Next


    '        Return True

    '    Catch ex As Exception
    '        Messenger.ShowError("insertUserPermission: " & ex.Message)
    '        Return False
    '    End Try

    'End Function

    Public Function updateUserPermissionDefault(ByVal userid As Integer) As Boolean

        Dim strSQL As String

        Try

            strSQL = "UPDATE cust_pos_permission SET value={0} WHERE userId={1}"

            strSQL = String.Format(strSQL, PreparedStatement("TRUE"), userid)

            objDA.ExecuteNonQuery(strSQL)


        Catch ex As Exception
            Messenger.ShowError("updateUserPermission: " & ex.Message)
            Return False
        End Try

    End Function

    Public Function updateUserPermission(ByVal userid As Integer, ByVal permission() As String) As Boolean

        Dim strSQL As String
        Dim arrList As New ArrayList(permission)

        Try

            For i As Integer = 0 To arrList.Count - 1
                strSQL = "UPDATE cust_pos_permission SET value={0} WHERE userId={1} AND permission={2}"

                strSQL = String.Format(strSQL, PreparedStatement("TRUE"), userid, PreparedStatement(arrList(i)))

                objDA.ExecuteNonQuery(strSQL)

            Next

        Catch ex As Exception
            Messenger.ShowError("updateUserPermission: " & ex.Message)
            Return False
        End Try

    End Function

    Public Sub getInvoiceObject(ByVal pkid As Long, ByRef ds As DataSet)

        Dim strSQL As String

        Try
            strSQL = "SELECT pkid, time_issued, sales_id, remarks FROM cust_invoice_index WHERE pkid = {0}"
            strSQL = String.Format(strSQL, pkid)
            ds = objDA.ExecuteQuery(strSQL, "0", DataAccess.Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Messenger.ShowError("getInvoiceObject: " & ex.Message)
        End Try

    End Sub

    Public Sub getInvoiceObject(ByVal pkid As Long, ByVal state As String, ByRef ds As DataSet)

        Dim strSQL As String

        Try
            strSQL = "SELECT pkid, total_amt, receipt_id FROM cust_invoice_index WHERE status = {0} AND pkid = {1}"
            strSQL = String.Format(strSQL, PreparedStatement(state), pkid)
            ds = objDA.ExecuteQuery(strSQL, "0", DataAccess.Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Messenger.ShowError("getInvoiceObject: " & ex.Message)
        End Try

    End Sub


    Public Sub getInvoiceItemObject(ByVal invoiceId As Long, ByRef ds As DataSet)

        Dim strSQL As String

        Try
            strSQL = "SELECT pkid, invoice_id, item_id, item_code, name, total_quantity, unit_price_quoted, stk_id, (total_quantity*unit_price_quoted) AS total FROM cust_invoice_item WHERE invoice_id = " & invoiceId
            ds = objDA.ExecuteQuery(strSQL, "0", DataAccess.Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Messenger.ShowError("getInvoiceItemObject: " & ex.Message)
        End Try

    End Sub

    Public Function CancelInvoice(ByVal pkid As Long) As Boolean

        Dim strSQL As String
        Dim ds As DataSet = Nothing

        Try
            getInvoiceItemObject(pkid, ds)
            If ds IsNot Nothing Then
                For Each row As DataRow In ds.Tables(0).Rows
                    Dim qty As Decimal = Decimal.Negate(row("total_quantity"))
                    updateBalanceInventory(row.Item("stk_id"), qty)
                Next
            End If

            strSQL = "UPDATE cust_invoice_index SET status = {0}, lastupdate = {1}, userid_edit = {2} WHERE pkid = {3}"
            strSQL = String.Format(strSQL, PreparedStatement(STATE_CANCELLED), PreparedStatement(Now), PreparedStatement(gUserID), PreparedStatement(pkid))

            objDA.ExecuteNonQuery(strSQL)
            Return True

        Catch ex As Exception
            Messenger.ShowError("CancelInvoice: " & ex.Message)
            Return False
        End Try

    End Function

    Public Sub getItemObject(ByVal keyword As String, ByVal locationId As Integer, ByRef ds As DataSet)

        Dim strSQL As String
        Dim priceField As String = getPriceFieldByConfig()

        Try
            strSQL = " SELECT i.item_code, i.name," & priceField & " AS price_list, s.bal FROM inv_item AS i" & _
                        " INNER JOIN inv_stock AS s ON s.itemid = i.pkid " & _
                        " WHERE s.locationid = {0} AND (item_code LIKE '%{1}%' OR name LIKE '%{1}%')"

            If Not gConfigObj.SellingBelowQty Then
                strSQL &= " AND s.bal > 0"
            End If

            strSQL = String.Format(strSQL, locationId, keyword)
            ds = objDA.ExecuteQuery(strSQL, "0", DataAccess.Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Messenger.ShowError("getItemObject: " & ex.Message)
        End Try

    End Sub

    Public Sub getItemPosObject(ByVal keyword As String, ByVal locationId As Integer, ByRef ds As DataSet)

        Dim strSQL As String
        Dim priceField As String = getPriceFieldByConfig()

        Try
            strSQL = " SELECT i.pkid, i.item_code, i.name, i.ean_code, " & priceField & " AS price_list, i.price_min AS price_min, s.pkid AS stockId, s.bal, s.unit_cost_ma FROM inv_item AS i" & _
                        " INNER JOIN inv_stock AS s ON s.itemid = i.pkid " & _
                        " WHERE s.locationid = {0} AND (item_code = '{1}' OR ean_code = '{2}' OR isbn_code = '{3}')"
            strSQL = String.Format(strSQL, gLocationID, keyword, keyword, keyword)

            strSQL = String.Format(strSQL, locationId, keyword)
            ds = objDA.ExecuteQuery(strSQL, "0", DataAccess.Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Messenger.ShowError("getItemObject: " & ex.Message)
        End Try

    End Sub

    Public Function getMaxPkid(ByVal tableName As String) As Long

        Dim strSQL As String
        Dim ds As DataSet
        Dim pkid As Long = 100000

        Try
            strSQL = "SELECT MAX(pkid) from {0}"
            strSQL = String.Format(strSQL, tableName)

            ds = objDA.ExecuteQuery(strSQL, "0", DataAccess.Commands.ReturnType.DataSetType)
            If ds IsNot Nothing Then
                If ds.Tables(0).Rows.Count > 0 AndAlso ds.Tables(0).Rows(0)(0).ToString <> "" Then
                    pkid = ds.Tables(0).Rows(0).Item(0) + 1
                End If
            End If
            Return pkid

        Catch ex As Exception
            Messenger.ShowError("getMaxPkid: " & ex.Message)
            Return -1
        End Try

    End Function

    Public Function getMaxPkid(ByVal tableName As String, ByVal startNo As Long) As Long

        Dim strSQL As String
        Dim ds As DataSet
        Dim pkid As Long = startNo

        Try
            strSQL = "SELECT MAX(pkid) from {0}"
            strSQL = String.Format(strSQL, tableName)

            ds = objDA.ExecuteQuery(strSQL, "0", DataAccess.Commands.ReturnType.DataSetType)
            If ds IsNot Nothing Then
                If ds.Tables(0).Rows.Count > 0 AndAlso ds.Tables(0).Rows(0)(0).ToString <> "" Then
                    pkid = ds.Tables(0).Rows(0).Item(0) + 1
                End If
            End If
            Return pkid

        Catch ex As Exception
            Messenger.ShowError("getMaxPkid: " & ex.Message)
            Return -1
        End Try

    End Function

    Public Function insertInvoice(ByVal totalTxn As Decimal, ByVal salesId As Integer) As Long

        Dim strSQL As String
        Dim pkid As Long

        Try
            pkid = getMaxPkid("cust_invoice_index")

            strSQL = "INSERT INTO cust_invoice_index (pkid, time_issued, total_amt, outstanding_amt, userid_edit, lastupdate, cust_svcctr_id," & _
                        " location_id, pc_center, status, pos_id, sales_id) " & _
                        " VALUES({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11})"

            strSQL = String.Format(strSQL, pkid, _
                                        PreparedStatement(Now), _
                                        PreparedStatement(totalTxn), _
                                        PreparedStatement(0), _
                                        PreparedStatement(gUserID), _
                                        PreparedStatement(Now), _
                                        PreparedStatement(gBranchID), _
                                        PreparedStatement(gLocationID), _
                                        PreparedStatement(gPCCenterID), _
                                        PreparedStatement(STATE_ACTIVE), _
                                        PreparedStatement(gConfigObj.PosId), _
                                        PreparedStatement(salesId))

            objDA.ExecuteNonQuery(strSQL)

            Return pkid

        Catch ex As Exception
            Messenger.ShowError("insertInvoice: " & ex.Message)
            Return -1
        End Try

    End Function

    Public Function insertInvoiceItem(ByVal invoiceId As Long, ByVal docrow As DocRow) As Long

        Dim strSQL As String
        Dim pkid As Long

        Try
            pkid = getMaxPkid("cust_invoice_item")

            strSQL = "INSERT INTO cust_invoice_item (pkid, invoice_id, total_quantity, unit_price_quoted, " & _
                        "pic1,pic2,pic3,item_id,item_code,bar_code,unit_cost_ma,unit_price_std,stk_id,stk_location_id, " & _
                        "pos_item_id, currency, status, pos_item_type, name, package_group)" & _
                        " VALUES({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}," & _
                        "{14},{15},{16},{17},{18},{19})"

            strSQL = String.Format(strSQL, pkid, _
                                        PreparedStatement(invoiceId), _
                                        PreparedStatement(docrow.qty), _
                                        PreparedStatement(docrow.price), _
                                        PreparedStatement(gUserID), _
                                        PreparedStatement(gUserID), _
                                        PreparedStatement(gUserID), _
                                        PreparedStatement(docrow.itemId), _
                                        PreparedStatement(docrow.itemCode), _
                                        PreparedStatement(docrow.eanCode), _
                                        PreparedStatement(docrow.unitCostMA), _
                                        PreparedStatement(docrow.price), _
                                        PreparedStatement(docrow.stockId), _
                                        PreparedStatement(gLocationID), _
                                        PreparedStatement(0), _
                                        PreparedStatement("MYR"), _
                                        PreparedStatement("act"), _
                                        PreparedStatement("inv"), _
                                        PreparedStatement(docrow.itemName), _
                                        PreparedStatement(""))


            objDA.ExecuteNonQuery(strSQL)

            Return pkid
        Catch ex As Exception
            Messenger.ShowError("insertInvoiceItem: " & ex.Message)
            Return -1
        End Try

    End Function


    Public Function insertReceipt(ByVal totalTxn As Decimal) As Long

        Dim strSQL As String
        Dim pkid As Long

        Try
            pkid = getMaxPkid("acc_receipt_index")

            strSQL = "INSERT INTO acc_receipt_index (pkid,entity_name,amount,payment_time,lastupdate,userid_update,amount_cash,branch,pc_center,cb_cash) " & _
                   " VALUES({0},{1},{2},{3},{4},{5},{6},{7},{8},{9})"

            strSQL = String.Format(strSQL, pkid, _
                                        PreparedStatement("cash"), _
                                        PreparedStatement(totalTxn), _
                                        PreparedStatement(Now), _
                                        PreparedStatement(Now), _
                                        PreparedStatement(gUserID), _
                                        PreparedStatement(totalTxn), _
                                        PreparedStatement(gBranchID), _
                                        PreparedStatement(gPCCenterID), _
                                        PreparedStatement(gCashAccountID))

            objDA.ExecuteNonQuery(strSQL)

            Return pkid
        Catch ex As Exception
            Messenger.ShowError("insertReceipt: " & ex.Message)
            Return -1
        End Try

    End Function

    Public Function insertReceiptCC(ByVal totalTxn As Decimal, ByVal cardNumber As String, ByVal cardName As String, ByVal cardValid As DateTime, ByVal cardApproval As String) As Long

        Dim strSQL As String
        Dim pkid As Long

        Try
            pkid = getMaxPkid("acc_receipt_index")

            strSQL = "INSERT INTO acc_receipt_index (pkid,entity_name,amount,payment_time,lastupdate,userid_update,amount_card,branch,pc_center,cb_card,card_number,card_name,card_valid_thru,card_approval_code) " & _
                   " VALUES({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13})"

            strSQL = String.Format(strSQL, pkid, _
                                        PreparedStatement("card"), _
                                        PreparedStatement(totalTxn), _
                                        PreparedStatement(Now), _
                                        PreparedStatement(Now), _
                                        PreparedStatement(gUserID), _
                                        PreparedStatement(totalTxn), _
                                        PreparedStatement(gBranchID), _
                                        PreparedStatement(gPCCenterID), _
                                        PreparedStatement(gCardAccountID), _
                                        PreparedStatement(cardNumber), _
                                        PreparedStatement(cardName), _
                                        PreparedStatement(cardValid), _
                                        PreparedStatement(cardApproval))

            objDA.ExecuteNonQuery(strSQL)

            Return pkid
        Catch ex As Exception
            Messenger.ShowError("insertReceipt: " & ex.Message)
            Return -1
        End Try

    End Function

    Public Sub updateBalanceInventory(ByVal stockId As Integer, ByVal qty As Integer)

        Dim strSQL As String
        Dim bal As Integer
        Dim ds As DataSet

        Try
            strSQL = "SELECT bal FROM inv_stock WHERE pkid =" & stockId
            ds = objDA.ExecuteQuery(strSQL, "0", DataAccess.Commands.ReturnType.DataSetType)
            bal = ds.Tables(0).Rows(0)(0)

            bal = bal - qty
            strSQL = "UPDATE inv_stock SET bal=" & bal & " WHERE pkid=" & stockId

            objDA.ExecuteNonQuery(strSQL)

        Catch ex As Exception
            Messenger.ShowError("updateBalanceInventory: " & ex.Message)
        End Try

    End Sub

    Public Sub updateInvoice(ByVal pkid As Long, ByVal field As String, ByVal value As String)

        Dim strSQL As String

        Try
            strSQL = "UPDATE cust_invoice_index SET {0} = {1} WHERE pkid = {2}"
            strSQL = String.Format(strSQL, field, PreparedStatement(value), pkid)

            objDA.ExecuteNonQuery(strSQL)

        Catch ex As Exception
            Messenger.ShowError("updateInvoice: " & ex.Message)
        End Try

    End Sub

    Public Sub getUserObjectByBranch(ByVal branchId As Integer, ByRef ds As DataSet)

        Dim strSQL As String

        Try
            strSQL = "SELECT * FROM user_index WHERE userid in ( " & _
                        "SELECT userid FROM user_config_registry WHERE namespace = 'CUSTSVCCTR' AND value1 = '{0}')"

            strSQL = String.Format(strSQL, branchId)

            ds = objDA.ExecuteQuery(strSQL, "0", DataAccess.Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Messenger.ShowError("getUserObjectByBranch:" & ex.Message)
        End Try

    End Sub

    'SELECT count(pkid), sum(total_amt) FROM cust_invoice_index WHERE time_issued >= '2008-10-22' AND time_issued < '2008-10-23' AND pos_id = 1

    Public Sub getDailySalesReport(ByVal userId As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, _
                                            ByVal posId As Integer, ByRef ds As DataSet)

        Dim strSQL As String
        'Dim nextDay As Date = dateTo.AddDays(1)

        Try
            strSQL = "SELECT count(pkid)as count, sum(total_amt) as sum FROM cust_invoice_index WHERE time_issued >= {0} " & _
                        " AND time_issued <= {1} "

            strSQL = String.Format(strSQL, PreparedStatement(dateFrom.ToString("yyyy-MM-dd HH:mm:ss")), PreparedStatement(dateTo.ToString("yyyy-MM-dd HH:mm:ss")))

            If userId <> 0 Then
                strSQL = strSQL & " AND userid_edit = " & userId
            End If

            If posId <> 0 Then
                strSQL = strSQL & " AND pos_id = " & posId
            End If

            ds = objDA.ExecuteQuery(strSQL, "0", DataAccess.Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Messenger.ShowError("getDailySalesReport: " & ex.Message)
        End Try
    End Sub

    Public Sub getDailySalesSummaryReport(ByVal userId As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, _
                                                        ByVal posId As Integer, ByRef ds As DataSet)

        Dim strSQL As String
        'Dim nextDay As Date = dateTo.AddDays(1)

        Try
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

            ds = objDA.ExecuteQuery(strSQL, "0", DataAccess.Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Messenger.ShowError("getDailySalesSummaryReport: " & ex.Message)
        End Try
    End Sub

    Public Sub getVoidReport(ByVal userId As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, _
                                           ByVal posId As Integer, ByRef ds As DataSet)

        Dim strSQL As String
        Dim nextDay As Date = dateTo.AddDays(1)

        Try
            strSQL = "SELECT rpt1.*, usr.username FROM " & _
                        "(SELECT iidx.pkid AS invoiceId, iidx.remarks, iidx.userid_edit AS userId, iidx.time_issued, iitm.item_code, iitm.name, iitm.total_quantity, iitm.unit_price_quoted, (iitm.total_quantity*iitm.unit_price_quoted) AS total " & _
                        " FROM cust_invoice_index AS iidx, cust_invoice_item AS iitm " & _
                        " WHERE iidx.pkid = iitm.invoice_id AND iidx.lastupdate >= {0} AND iidx.lastupdate <= {1} AND iidx.status = {2}"

            strSQL = String.Format(strSQL, PreparedStatement(dateFrom), PreparedStatement(nextDay), PreparedStatement(STATE_CANCELLED))

            If userId <> 0 Then
                strSQL = strSQL & " AND userid_edit = " & userId
            End If

            If posId <> 0 Then
                strSQL = strSQL & " AND pos_id = " & posId
            End If

            strSQL = strSQL & " ) AS rpt1 INNER JOIN  user_index AS usr ON (rpt1.userId = usr.userid)"

            WriteToLogFile(strSQL)

            ds = objDA.ExecuteQuery(strSQL, "0", DataAccess.Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Messenger.ShowError("getVoidReport: " & ex.Message)
        End Try
    End Sub

    Public Sub getReceiptListing(ByVal userId As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, _
                                           ByVal posId As Integer, ByRef ds As DataSet)

        Dim strSQL As String
        'Dim nextDay As Date = dateTo.AddDays(1)

        Try
            'strSQL = "SELECT iidx.pkid AS invoiceId, iidx.userid_edit AS userId, iidx.time_issued, iitm.item_code, iitm.name, iitm.total_quantity, iitm.unit_price_quoted, (iitm.total_quantity*iitm.unit_price_quoted) AS total FROM cust_invoice_index AS iidx, cust_invoice_item AS iitm " & _
            '            " WHERE iidx.pkid = iitm.invoice_id AND iidx.time_issued >= {0} AND iidx.time_issued <= {1} AND iidx.status = {2}"

            'strSQL = String.Format(strSQL, PreparedStatement(dateFrom.ToString("yyyy-MM-dd HH:mm:ss")), PreparedStatement(dateTo.ToString("yyyy-MM-dd HH:mm:ss")), PreparedStatement(STATE_ACTIVE))

            strSQL = "SELECT iidx.pkid AS invoiceId, iidx.userid_edit AS userId, iidx.time_issued, iitm.item_code, iitm.name, iitm.total_quantity, iitm.unit_price_quoted, (iitm.total_quantity*iitm.unit_price_quoted) AS total FROM cust_invoice_index AS iidx, cust_invoice_item AS iitm " & _
                        " WHERE iidx.pkid = iitm.invoice_id AND iidx.time_issued >= {0} AND iidx.time_issued <= {1}"

            strSQL = String.Format(strSQL, PreparedStatement(dateFrom.ToString("yyyy-MM-dd HH:mm:ss")), PreparedStatement(dateTo.ToString("yyyy-MM-dd HH:mm:ss")))

            If userId <> 0 Then
                strSQL = strSQL & " AND iidx.userid_edit = " & userId
            End If

            If posId <> 0 Then
                strSQL = strSQL & " AND pos_id = " & posId
            End If

            ds = objDA.ExecuteQuery(strSQL, "0", DataAccess.Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Messenger.ShowError("getReceiptListing: " & ex.Message)
        End Try
    End Sub

    Public Sub getHourlySalesReport(ByVal userId As Integer, ByVal dateFrom As Date, _
                                                     ByVal posId As Integer, ByRef ds As DataSet)

        Dim strSQL As String
        Dim nextDay As Date = dateFrom.AddDays(1)

        Try
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

            WriteToLogFile(strSQL)

            ds = objDA.ExecuteQuery(strSQL, "0", DataAccess.Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Messenger.ShowError("getHourlySalesReport: " & ex.Message)
        End Try
    End Sub

    Public Sub getDetailedVoidReport(ByVal userId As Integer, ByVal dateFrom As Date, ByVal dateTo As Date, _
                                                        ByVal posId As Integer, ByRef ds As DataSet)

        Dim strSQL As String
        Dim nextDay As Date = dateTo.AddDays(1)

        Try
            strSQL = "SELECT rpt2.*, categorytree.name FROM ( " & _
                        " SELECT item_code.category1, sum(rpt1.sum_qty) AS total_qty, sum(rpt1.sum_amount) AS total_amt FROM ( " & _
                        " SELECT iitm.item_id,sum(iitm.total_quantity) as sum_qty,sum(iitm.unit_price_quoted*iitm.total_quantity) as sum_amount FROM cust_invoice_item AS iitm INNER JOIN cust_invoice_index AS iidx " & _
                        " ON (iitm.invoice_id = iidx.pkid) WHERE iidx.time_issued >= {0} AND iidx.time_issued < {1} AND iidx.status = 'cancelled' {A} {B} GROUP BY iitm.item_id " & _
                        " ) AS rpt1 " & _
                        " INNER JOIN inv_item AS item_code ON (rpt1.item_id = item_code.pkid) GROUP BY item_code.category1 " & _
                        " ) AS rpt2 INNER JOIN inv_category_tree AS categorytree ON (rpt2.category1 = categorytree.code) WHERE categorytree.cat_level='1' "

            'strSQL = String.Format(strSQL, PreparedStatement(dateFrom.ToString("yyyy-MM-dd")), PreparedStatement(nextDay.ToString("yyyy-MM-dd")))
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

            WriteToLogFile(strSQL)

            ds = objDA.ExecuteQuery(strSQL, "0", DataAccess.Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Messenger.ShowError("getDetailedVoidReport: " & ex.Message)
        End Try
    End Sub

    Public Function insertCashInOut(ByVal total As Decimal, ByVal remark As String, ByVal status As String) As Long

        Dim strSQL As String
        Dim pkid As Long

        Try
            pkid = getMaxPkid("cust_pos_cash_in_out")

            If status = STATUS_CASH_OUT Then
                total = Decimal.Negate(total)
            End If

            strSQL = "INSERT INTO cust_pos_cash_in_out (pkid, branch_id, remark, amount, user_id, lastupdate, status, pos_id)" & _
                        " VALUES({0},{1},{2},{3},{4},{5},{6},{7})"

            strSQL = String.Format(strSQL, pkid, _
                                        PreparedStatement(gBranchID), _
                                        PreparedStatement(remark), _
                                        PreparedStatement(total), _
                                        PreparedStatement(gUserID), _
                                        PreparedStatement(Now), _
                                        PreparedStatement(status), _
                                        PreparedStatement(gConfigObj.PosId))

            objDA.ExecuteNonQuery(strSQL)

            Return pkid

        Catch ex As Exception
            Messenger.ShowError("insertCashInOut: " & ex.Message)
            Return -1
        End Try

    End Function


    Public Sub getCashInOutObject(ByVal pkid As Long, ByRef ds As DataSet)

        Dim strSQL As String

        Try
            strSQL = "SELECT * FROM cust_pos_cash_in_out WHERE pkid = " & pkid
            ds = objDA.ExecuteQuery(strSQL, "0", DataAccess.Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Messenger.ShowError("getCashInOutObject: " & ex.Message)
        End Try

    End Sub

    Public Sub getCashInOutSummaryObject(ByVal branchId As Integer, ByVal userId As Integer, ByVal posId As Integer, _
                                                                    ByVal startTime As DateTime, ByVal endTime As DateTime, ByRef ds As DataSet)

        Dim strSQL As String

        Try
            strSQL = "SELECT count(*) as count, sum(amount)as sum, status FROM cust_pos_cash_in_out WHERE lastupdate >= {0} AND lastupdate < {1} AND branch_id = {2}"

            strSQL = String.Format(strSQL, PreparedStatement(startTime), PreparedStatement(endTime), branchId)

            If userId <> 0 Then
                strSQL = strSQL & " AND user_id = " & userId
            End If

            If posId <> 0 Then
                strSQL = strSQL & " AND pos_id = " & posId
            End If

            strSQL = strSQL & " GROUP BY status "

            ds = objDA.ExecuteQuery(strSQL, "0", DataAccess.Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Messenger.ShowError("getCashInOutSummaryObject: " & ex.Message)
        End Try

    End Sub

    Public Function getCustPosLogin(ByVal branch_id As Integer, ByVal pos_id As Integer, _
                                                    ByVal user_id As Integer, ByRef ds As DataSet) As Integer

        Dim strSQL As String

        Try
            strSQL = "SELECT * FROM cust_pos_login WHERE branch_id = {0} AND pos_id = {1} AND user_id = {2} AND status = {3}"
            strSQL = String.Format(strSQL, branch_id, pos_id, user_id, PreparedStatement(STATUS_START))

            ds = objDA.ExecuteQuery(strSQL, "0", DataAccess.Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Messenger.ShowError("getCustPosLogin: " & ex.Message)
        End Try

    End Function

    Public Function getLastTimeLogin(ByVal branch_id As Integer, ByVal pos_id As Integer) As DateTime

        Dim strSQL As String
        Dim ds As DataSet
        Dim dt As Date

        dt = New Date(1, 1, 1)
        Try
            strSQL = "SELECT MAX(time_end) FROM cust_pos_login WHERE branch_id = {0} AND pos_id = {1}"
            strSQL = String.Format(strSQL, branch_id, pos_id)

            ds = objDA.ExecuteQuery(strSQL, "0", DataAccess.Commands.ReturnType.DataSetType)
            If ds IsNot Nothing AndAlso ds.Tables(0).Rows.Count > 0 Then
                If ds.Tables(0).Rows(0)(0).ToString <> "" Then
                    dt = ds.Tables(0).Rows(0)(0)
                End If
            End If

            Return dt

        Catch ex As Exception
            Messenger.ShowError("getLastTimeLogin: " & ex.Message)
        End Try

    End Function

    Public Function insertCustPosLogin(ByVal branch_id As Integer, ByVal pos_id As Integer, _
                                                ByVal user_id As Integer) As Integer

        Dim strSQL As String = ""
        Dim pkid As Integer = 0
        Dim ds As DataSet = Nothing
        Dim status As String = ""

        Try
            getCustPosLogin(branch_id, pos_id, user_id, ds)
            If ds Is Nothing Then Exit Function

            If ds.Tables(0).Rows.Count > 0 Then
                pkid = ds.Tables(0).Rows(0)("pkid")
            Else
                pkid = getMaxPkid("cust_pos_login")
                strSQL = "INSERT INTO cust_pos_login (pkid, branch_id, pos_id, user_id, time_start, time_end, status)" & _
                            " VALUES({0},{1},{2},{3},{4},{5},{6})"

                strSQL = String.Format(strSQL, pkid, _
                                            PreparedStatement(gBranchID), _
                                            PreparedStatement(gConfigObj.PosId), _
                                            PreparedStatement(gUserID), _
                                            PreparedStatement(Now), _
                                            PreparedStatement(Now), _
                                            PreparedStatement(STATUS_START))

                objDA.ExecuteNonQuery(strSQL)
            End If

            Return pkid

        Catch ex As Exception
            Messenger.ShowError("insertCustPosLogin: " & ex.Message)
            Return -1
        End Try
    End Function

    Public Function updateCustPosLogin(ByVal branch_id As Integer, ByVal pos_id As Integer, _
                                            ByVal user_id As Integer) As Integer

        Dim strSQL As String = ""
        Dim pkid As Integer = 0
        Dim ds As DataSet = Nothing

        Try
            getCustPosLogin(branch_id, pos_id, user_id, ds)
            If ds Is Nothing Then Exit Function

            If ds.Tables(0).Rows.Count > 0 Then
                pkid = ds.Tables(0).Rows(0)("pkid")
            End If

            strSQL = "UPDATE cust_pos_login SET time_end = {0}, status = {1} WHERE pkid = {2}"
            strSQL = String.Format(strSQL, PreparedStatement(Now), _
                                            PreparedStatement(STATUS_END), _
                                            PreparedStatement(pkid))

            objDA.ExecuteNonQuery(strSQL)

            Return pkid

        Catch ex As Exception
            Messenger.ShowError("updateCustPosLogin: " & ex.Message)
            Return -1
        End Try
    End Function


    Public Function getEndDayClosing(ByVal branch_id As Integer, ByRef ds As DataSet) As Integer
        Dim strSQL As String

        Try
            strSQL = "select time_start, time_end, qty_bill, amount from cust_pos_end_day_closing where branch_id={0} AND status={1} ORDER BY time_start DESC"
            strSQL = String.Format(strSQL, branch_id, PreparedStatement(STATUS_END))

            ds = objDA.ExecuteQuery(strSQL, "0", DataAccess.Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Messenger.ShowError("getEndDayClosing: " & ex.Message)
        End Try

    End Function

    Public Function getEndDayClosingByPos(ByVal branch_id As Integer, ByVal pos_id As Integer, _
                                                    ByRef ds As DataSet) As Integer
        Dim strSQL As String

        Try
            strSQL = "select * from cust_pos_end_day_closing where pkid in (select max(pkid) from cust_pos_end_day_closing where branch_id ={0} and pos_id ={1})"
            strSQL = String.Format(strSQL, branch_id, pos_id)

            ds = objDA.ExecuteQuery(strSQL, "0", DataAccess.Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Messenger.ShowError("getEndDayClosingByPos: " & ex.Message)
        End Try

    End Function

    Public Function insertEndDayClosing(ByVal branch_id As Integer, ByVal pos_id As Integer, _
                                                    ByVal user_id As Integer) As Long

        Dim strSQL As String = ""
        Dim pkid As Long = 0
        Dim ds As DataSet = Nothing

        Try

            pkid = getMaxPkid("cust_pos_end_day_closing")

            strSQL = "INSERT INTO cust_pos_end_day_closing (pkid, branch_id, pos_id, userid_edit, time_start, time_end, lastupdate, status, qty_bill)" & _
                        " VALUES({0},{1},{2},{3},{4},{5},{6},{7},{8})"

            strSQL = String.Format(strSQL, pkid, _
                                        PreparedStatement(gBranchID), _
                                        PreparedStatement(gConfigObj.PosId), _
                                        PreparedStatement(gUserID), _
                                        PreparedStatement(Now), _
                                        PreparedStatement(Now), _
                                        PreparedStatement(Now), _
                                        PreparedStatement(STATUS_START), _
                                        0)
            objDA.ExecuteNonQuery(strSQL)

            Return pkid

        Catch ex As Exception
            Messenger.ShowError("insertEndDayClosing: " & ex.Message)
            Return -1
        End Try

    End Function

    Public Sub updateEndDayClosing(ByVal branch_id As Integer, ByVal pos_id As Integer, _
                                                    ByVal user_id As Integer)

        Dim strSQL As String = ""
        Dim pkid As Long = 0
        Dim ds As DataSet = Nothing
        Dim status As String = ""
        Dim timeStart As DateTime
        Dim amount As Decimal = 0

        Try
            getEndDayClosingByPos(branch_id, pos_id, ds)
            If ds Is Nothing Then Exit Sub

            If ds.Tables(0).Rows.Count > 0 Then
                pkid = ds.Tables(0).Rows(0)("pkid")
                status = ds.Tables(0).Rows(0)("status").ToString
                timeStart = ds.Tables(0).Rows(0)("time_start")
            End If

            If status = STATUS_END Then Exit Sub

            ds = Nothing
            getDailySalesReport(0, timeStart, Now, pos_id, ds)
            If ds Is Nothing Then Exit Sub
            If ds.Tables(0).Rows(0)("sum").ToString <> "" Then
                amount = ds.Tables(0).Rows(0)("sum")
            End If

            strSQL = "UPDATE cust_pos_end_day_closing SET time_end = {0}, status = {1}, userid_edit = {2}, lastupdate= {3}, amount = {4} WHERE pkid = {5}"
            strSQL = String.Format(strSQL, PreparedStatement(Now), _
                                            PreparedStatement(STATUS_END), _
                                            PreparedStatement(user_id), _
                                            PreparedStatement(Now), _
                                            PreparedStatement(amount), _
                                            PreparedStatement(pkid))
            objDA.ExecuteNonQuery(strSQL)

        Catch ex As Exception
            Messenger.ShowError("updateEndDayClosing: " & ex.Message)
        End Try

    End Sub


    Public Sub addQtyBill(ByVal branch_id As Integer, ByVal pos_id As Integer, _
                                                 ByVal qtyBill As Integer)

        Dim strSQL As String = ""
        Dim pkid As Long = 0
        Dim ds As DataSet = Nothing
        Dim status As String = ""
        Dim qty As Integer

        Try
            getEndDayClosingByPos(branch_id, pos_id, ds)
            If ds Is Nothing Then Exit Sub

            If ds.Tables(0).Rows.Count > 0 Then
                pkid = ds.Tables(0).Rows(0)("pkid")
                status = ds.Tables(0).Rows(0)("status").ToString
                qty = ds.Tables(0).Rows(0)("qty_bill")
            End If

            If status = STATUS_END Then Exit Sub

            strSQL = "UPDATE cust_pos_end_day_closing SET qty_bill = {0}, lastupdate= {1} WHERE pkid = {2}"
            strSQL = String.Format(strSQL, PreparedStatement(qty + qtyBill), _
                                            PreparedStatement(Now), _
                                            PreparedStatement(pkid))
            objDA.ExecuteNonQuery(strSQL)

        Catch ex As Exception
            Messenger.ShowError("addQtyBill: " & ex.Message)
        End Try

    End Sub

    Public Function getConuter() As Long

        Dim strSQL As String
        Dim total As Long = 0
        Dim ds As DataSet

        Try
            strSQL = "SELECT * FROM cust_pos_counter"
            strSQL = String.Format(strSQL, total)
            ds = objDA.ExecuteQuery(strSQL, "0", DataAccess.Commands.ReturnType.DataSetType)
            If ds.Tables(0).Rows.Count > 0 Then
                total = ds.Tables(0).Rows(0)("total_bill")
            Else
                strSQL = "INSERT cust_pos_counter VALUES (1, 0)"
                objDA.ExecuteNonQuery(strSQL)
            End If

            Return total

        Catch ex As Exception
            Messenger.ShowError("getConuter: " & ex.Message)
            Return 0
        End Try

    End Function

    Public Sub updateConuter()

        Dim strSQL As String
        Dim total As Long

        Try
            total = getConuter() + 1
            strSQL = "UPDATE cust_pos_counter SET total_bill = {0}"
            strSQL = String.Format(strSQL, total)
            objDA.ExecuteNonQuery(strSQL)

        Catch ex As Exception
            Messenger.ShowError("updateConuter: " & ex.Message)
        End Try

    End Sub

    Public Function insertTC(ByVal invoiceId As Long, ByVal salesId As Integer) As Boolean

        Dim ds As DataSet = Nothing
        Dim strSQLx As String = ""
        Dim strSQL As String = ""
        Dim pkid As Integer = 0
        Dim guid As String = System.Guid.NewGuid.ToString

        Try

            pkid = getMaxPkid("tc_tx_queue")

            getInvoiceObject(invoiceId, STATE_ACTIVE, ds)
            If ds Is Nothing Then Exit Function

            Dim receiptId As Long = ds.Tables(0).Rows(0)("receipt_id")

            strSQLx = "INSERT INTO tc_tx_queue (pkid, pk_string, fk_string, category, source, type, object_xml, userid, status, date_created, date_received, date_completed) " & _
                     " VALUES ({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11})"


            strSQL = String.Format(strSQLx, PreparedStatement(pkid), _
                                            PreparedStatement(guid), _
                                            PreparedStatement(""), _
                                            PreparedStatement("index"), _
                                            PreparedStatement(""), _
                                            PreparedStatement("cashsale"), _
                                            PreparedStatement(getXMLIndex(invoiceId, receiptId, salesId)), _
                                            PreparedStatement(gUserID), _
                                            PreparedStatement(STATUS_PENDING), _
                                            PreparedStatement(Now), _
                                            PreparedStatement(Now), _
                                            PreparedStatement(Now))

            objDA.ExecuteNonQuery(strSQL)

            ds = Nothing
            getInvoiceItemObject(invoiceId, ds)
            If ds Is Nothing Then Exit Function

            For Each row As DataRow In ds.Tables(0).Rows

                pkid = getMaxPkid("tc_tx_queue")

                strSQL = String.Format(strSQLx, PreparedStatement(pkid), _
                                            PreparedStatement(""), _
                                            PreparedStatement(guid), _
                                            PreparedStatement("item"), _
                                            PreparedStatement(""), _
                                            PreparedStatement("cashsale"), _
                                            PreparedStatement(getXMLItem(row)), _
                                            PreparedStatement(gUserID), _
                                            PreparedStatement(STATUS_PENDING), _
                                            PreparedStatement(Now), _
                                            PreparedStatement(Now), _
                                            PreparedStatement(Now))

                objDA.ExecuteNonQuery(strSQL)

            Next


        Catch ex As Exception
            Messenger.ShowError("insertTC: " & ex.Message)
        End Try

    End Function

    Public Sub updateTC(ByVal pkid As Long)

        Dim strSQL As String

        Try
            strSQL = "UPDATE tc_tx_queue SET status = {0} WHERE pkid = {1}"
            strSQL = String.Format(strSQL, PreparedStatement(STATUS_COMPLETE), pkid)
            objDA.ExecuteNonQuery(strSQL)

        Catch ex As Exception
            Messenger.ShowError("updateTC: " & ex.Message)
        End Try

    End Sub

    Public Sub getTCObject(ByRef ds As DataSet)

        Dim strSQL As String

        Try
            strSQL = "SELECT * FROM tc_tx_queue WHERE status = {0} ORDER BY pkid"
            strSQL = String.Format(strSQL, PreparedStatement(STATUS_PENDING))
            ds = objDA.ExecuteQuery(strSQL, "0", DataAccess.Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Messenger.ShowError("getTCObject: " & ex.Message)
        End Try

    End Sub

    Public Sub getAccReceipt(ByVal pkid As Long, ByRef ds As DataSet)

        Dim strSQL As String

        Try
            strSQL = "SELECT * FROM acc_receipt_index WHERE pkid = {0}"
            strSQL = String.Format(strSQL, PreparedStatement(pkid))
            ds = objDA.ExecuteQuery(strSQL, "0", DataAccess.Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Messenger.ShowError("getAccReceipt: " & ex.Message)
        End Try

    End Sub

    Public Function getXMLIndex(ByVal invoiceId As Long, ByVal receiptId As Long, ByVal salesId As Integer) As String

        Dim strXML As String
        Dim defaultDate As Long = GetTimeLong(New Date(1, 1, 1, 0, 0, 0))
        Dim ds As DataSet = Nothing

        Try
            getAccReceipt(receiptId, ds)
            If ds Is Nothing Then Return ""
            Dim row As DataRow = ds.Tables(0).Rows(0)

            strXML = "<com.vlee.ejb.customer.SalesTransactionIndexObject>"
            strXML &= "<pkid>" & invoiceId & "</pkid>"
            strXML &= "<cashaccountId>" & row("cb_cash").ToString & "</cashaccountId>"
            strXML &= "<branchId>" & gBranchID & "</branchId>"
            strXML &= "<remarks></remarks>"
            strXML &= "<userid>" & gUserID & "</userid>"
            strXML &= "<salesId>" & salesId & "</salesId>"
            strXML &= "<invoiceAmount>" & row("amount").ToString & "</invoiceAmount>"
            strXML &= "<outstandingAmount>0</outstandingAmount>"
            strXML &= "<status>" & STATUS_PENDING & "</status>"
            strXML &= "<dateCreated>" & GetTimeLong(Now) & "</dateCreated>"
            strXML &= "<paymentMethod>BLANK</paymentMethod>"
            strXML &= "<ccNumber>" & row("card_number").ToString & "</ccNumber>"
            strXML &= "<ccName>" & row("card_name").ToString & "</ccName>"
            strXML &= "<ccApproval>" & row("card_approval_code").ToString & "</ccApproval>"
            strXML &= "<ccSecurityNumber>" & row("card_security_num").ToString & "</ccSecurityNumber>"
            strXML &= "<dateCcExpiry>" & GetTimeLong(row("card_valid_thru")) & "</dateCcExpiry>"
            strXML &= "<creditaccountId>" & row("cb_card").ToString & "</creditaccountId>"
            strXML &= "<cashAmount>" & row("amount_cash").ToString & "</cashAmount>"
            strXML &= "<creditAmount>" & row("amount_card").ToString & "</creditAmount>"
            strXML &= "<chequeAmount>" & row("amount_cheque").ToString & "</chequeAmount>"
            strXML &= "<pdchequeAmount>" & row("amount_pd_cheque").ToString & "</pdchequeAmount>"
            strXML &= "<chequeaccountId>" & row("cb_cheque").ToString & "</chequeaccountId>"
            strXML &= "<pdchequeaccountId>" & row("cb_pd_cheque").ToString & "</pdchequeaccountId>"
            strXML &= "<pdChequeDate>" & defaultDate & "</pdChequeDate>"
            strXML &= "</com.vlee.ejb.customer.SalesTransactionIndexObject>"

            Return strXML
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function getXMLItem(ByVal row As DataRow) As String

        Dim strXML As String = ""

        strXML = "<com.vlee.ejb.customer.SalesTransactionItemObject>"
        strXML &= "<pkid>" & row("pkid").ToString & "</pkid>"
        strXML &= "<transactionId>" & row("invoice_id") & "</transactionId>"
        strXML &= "<itemId>" & row("item_id") & "</itemId>"
        strXML &= "<qty>" & Format(row("total_quantity"), 0) & "</qty>"
        strXML &= "<locationId>" & gLocationID & "</locationId>"
        strXML &= "<price>" & row("unit_price_quoted") & "</price>"
        strXML &= "<dateCreated>" & GetTimeLong(Now) & "</dateCreated>"
        strXML &= "</com.vlee.ejb.customer.SalesTransactionItemObject>"

        Return strXML
    End Function

    Public Sub getUserObject(ByVal pkid As Long, ByRef ds As DataSet)

        Dim strSQL As String

        Try
            strSQL = "SELECT * FROM user_index WHERE pkid = " & pkid
            ds = objDA.ExecuteQuery(strSQL, "0", DataAccess.Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Messenger.ShowError("getUserObject: " & ex.Message)
        End Try

    End Sub

    Public Sub getUserPassword(ByVal username As String, ByVal password As String, ByRef ds As DataSet)

        Dim strSQL As String

        Try
            strSQL = "SElECT * FROM user_index WHERE username='{0}' and password2='{1}'"
            strSQL = String.Format(strSQL, username, GetSHA1(password))

            ds = objDA.ExecuteQuery(strSQL, "0", DataAccess.Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Messenger.ShowError("GetUserPassword: " & ex.Message)
        End Try

    End Sub

    Public Sub getCashAccountObject(ByRef ds As DataSet)

        Dim strSQL As String

        Try
            strSQL = "SELECT * FROM acc_cash_account"
            ds = objDA.ExecuteQuery(strSQL, "0", DataAccess.Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Messenger.ShowError("getUserObject: " & ex.Message)
        End Try

    End Sub

    Public Function isExistTC(ByVal pkid As Long, ByVal tableName As String) As Boolean

        Dim strSQL As String
        Dim ds As DataSet = Nothing

        Try
            strSQL = "SELECT * FROM {0} WHERE pkid = {1}"
            strSQL = String.Format(strSQL, tableName, pkid)

            ds = objDA.ExecuteQuery(strSQL, "0", DataAccess.Commands.ReturnType.DataSetType)
            If ds.Tables(0).Rows.Count > 0 Then
                Return True
            End If
            Return False

        Catch ex As Exception
            Messenger.ShowError("isExistTC: " & ex.Message)
            Return False
        End Try

    End Function

    Public Function isExistTC(ByVal pkid As Long, ByVal lastUpdate As DateTime, ByVal tableName As String) As Boolean

        Dim strSQL As String
        Dim ds As DataSet = Nothing

        Try
            strSQL = "SELECT * FROM {0} WHERE pkid = {1} AND lastupdate = {2}"
            strSQL = String.Format(strSQL, tableName, pkid, PreparedStatement(lastUpdate))

            ds = objDA.ExecuteQuery(strSQL, "0", DataAccess.Commands.ReturnType.DataSetType)
            If ds.Tables(0).Rows.Count > 0 Then
                Return True
            End If
            Return False

        Catch ex As Exception
            Messenger.ShowError("isExistTC: " & ex.Message)
            Return False
        End Try

    End Function

    Public Function isExistUserPermission(ByVal userId As Integer, ByVal permission As String) As Boolean

        Dim strSQL As String
        Dim ds As DataSet = Nothing

        Try
            strSQL = "SELECT * FROM cust_pos_permission WHERE userId = {0} AND permission = {1} AND value = {2}"
            strSQL = String.Format(strSQL, userId, PreparedStatement(permission), PreparedStatement("TRUE"))

            ds = objDA.ExecuteQuery(strSQL, "0", DataAccess.Commands.ReturnType.DataSetType)
            If ds.Tables(0).Rows.Count > 0 Then
                Return True
            End If
            Return False

        Catch ex As Exception
            Messenger.ShowError("isExistUserPermission: " & ex.Message)
            Return False
        End Try

    End Function

    Public Function isExistUserPassword(ByVal username As String, ByVal password As String) As Boolean

        Dim strSQL As String
        Dim ds As DataSet = Nothing

        Try
            strSQL = "SElECT * FROM user_index WHERE username='{0}' and username='{1}'"
            strSQL = String.Format(strSQL, username, password)

            ds = objDA.ExecuteQuery(strSQL, "0", DataAccess.Commands.ReturnType.DataSetType)
            If ds.Tables(0).Rows.Count > 0 Then
                Return True
            End If
            Return False

        Catch ex As Exception
            Messenger.ShowError("isExistUserPassword: " & ex.Message)
            Return False
        End Try

    End Function

    Public Function updateUser(ByVal user As userObject) As Boolean

        Dim strSQL As String

        Try
            strSQL = "UPDATE user_index SET username = {0}, namefirst = {1}, namelast = {2}, status = {3}, password2 = {4} WHERE userid = {5}"

            strSQL = String.Format(strSQL, PreparedStatement(user.userName), _
                                            PreparedStatement(user.nameFirst), _
                                            PreparedStatement(user.nameLast), _
                                            PreparedStatement(user.status), _
                                            PreparedStatement(user.password2), _
                                            PreparedStatement(user.userId))

            objDA.ExecuteNonQuery(strSQL)

        Catch ex As Exception
            Messenger.ShowError("updateStock: " & ex.Message)
        End Try

    End Function

    Public Function updateStock(ByVal stock As stockObject) As Boolean

        Dim strSQL As String

        Try
            strSQL = "UPDATE inv_stock SET bal = {0}, lastupdate = {1} WHERE pkid = {2}"
            strSQL = String.Format(strSQL, stock.balance, PreparedStatement(Now), stock.pkid)

            objDA.ExecuteNonQuery(strSQL)

        Catch ex As Exception
            Messenger.ShowError("updateStock: " & ex.Message)
        End Try

    End Function

    Public Function updateBranch(ByVal newObj As branchObject) As Boolean

        Dim strSQL As String

        Try
            strSQL = "UPDATE acc_branch_index SET code={0}, reg_no={1}, name={2}, description={3}, addr1={4}, addr2={5}, addr3={6}, zip={7}, state={8}, countrycode={9}, phone_no={10}, " & _
                        " fax_no={11}, web_url={12}, acc_pccenterid={13}, inv_locationid={14}, status={15}, lastupdate={16}, userid_edit={17}, cashbook_cash={18}, cashbook_card={19}, cashbook_cheque={20}, " & _
                        " cashbook_pd_cheque={21}, cashbook_coupon={22}, cashbook_other={23}, cashbook_payment={24}, logo_url={25}, currency={26}, pricing={27}, hotlines={28}, default_visa_rate={29}, default_master_rate={30}, " & _
                        " default_amex_rate={31}, default_diner_rate={32}, default_card1_rate={33}, default_card2_rate={34}, default_card3_rate={35}, default_other_rate={36}, format_invoice_header_text={37}, format_invoice_footer_text={38}, format_invoice_entity_address={39}, format_invoice_row={40}, " & _
                        " format_invoice_type={41}, format_cashsale_header_text={42}, format_cashsale_footer_text={43}, format_cashsale_entity_address={44}, format_cashsale_row={45}, format_cashsale_type={46}, format_receipt_header_text={47}, format_receipt_footer_text={48}, format_receipt_entity_address={49}, format_receipt_row={50}, " & _
                        " format_receipt_type={51}, format_purchase_order_header_text={52}, format_purchase_order_footer_text={53}, format_purchase_order_row={54}, format_purchase_order_type={55}, format_salary_slip_header_text={56}, format_salary_slip_footer_text={57}, format_salary_slip_row={58}, format_salary_slip_type={59}, format_payment_voucher_header_text={60}, " & _
                        " format_payment_voucher_footer_text={61}, format_payment_voucher_row={62}, format_payment_voucher_type={63}, format_credit_memo_header_text={64}, format_credit_memo_footer_text={65}, format_credit_memo_row={66}, format_credit_memo_type={67}, default_rma_location_cust={68}, default_rma_location_supp={69}, default_rma_location_hq={70}, " & _
                        " default_rma_location_branch={71}, manager_password01={72}, manager_password02={73}, manager_password03={74}, manager_password04={75}, manager_password05={76}, manager_password06={77}, manager_password07={78}, manager_password08={79}, manager_password09={80}, " & _
                        " telephone_developer={81}, telephone_sysadmin={82}, telephone_clerk={83}, telephone_admin={84}, telephone_manager={85}, telephone_sales={86}, telephone_tech_support={87}, telephone_director={88}, mobilephone_developer={89}, mobilephone_sysadmin={90}, " & _
                        " mobilephone_clerk={91}, mobilephone_admin={92}, mobilephone_manager={93}, mobilephone_sales={94}, mobilephone_tech_support={95}, mobilephone_director={96}, email_system={97}, email_developer={98}, email_sysadmin={99}, email_clerk={100}, " & _
                        " email_admin={101}, email_manager={102}, email_sales={103}, email_tech_support={104}, email_director={105}, customer_id={106}, supplier_id={107}, loyalty_card_no_prefix={108}, loyalty_card_no_postfix={109}, crv_day_from={110}, " & _
                        " crv_day_to={111}, format_proforma_invoice_type={112}, format_proforma_invoice_footer_text={113}, format_proforma_invoice_header_text={114}, format_proforma_invoice_row={115}, format_service_note_type={116}, format_service_note_footer_text={117}, format_service_note_header_text={118}, format_service_note_row={119}, tax_reg_number={120} " & _
                        " WHERE pkid = {121}"

            strSQL = String.Format(strSQL, PreparedStatement(newObj.code), _
                                    PreparedStatement(newObj.regNo), _
                                    PreparedStatement(newObj.name), _
                                    PreparedStatement(newObj.description), _
                                    PreparedStatement(newObj.addr1), _
                                    PreparedStatement(newObj.addr2), _
                                    PreparedStatement(newObj.addr3), _
                                    PreparedStatement(newObj.zip), _
                                    PreparedStatement(newObj.state), _
                                    PreparedStatement(newObj.countryCode), _
                                    PreparedStatement(newObj.phoneNo), _
                                    PreparedStatement(newObj.faxNo), _
                                    PreparedStatement(newObj.webUrl), _
                                    PreparedStatement(newObj.accPCCenterId), _
                                    PreparedStatement(newObj.invLocationId), _
                                    PreparedStatement(newObj.status), _
                                    PreparedStatement(newObj.lastUpdate), _
                                    PreparedStatement(newObj.userIdUpdate), _
                                    PreparedStatement(newObj.cashbookCash), _
                                    PreparedStatement(newObj.cashbookCard), _
                                    PreparedStatement(newObj.cashbookCheque), _
                                    PreparedStatement(newObj.cashbookPDCheque), _
                                    PreparedStatement(newObj.cashbookCoupon), _
                                    PreparedStatement(newObj.cashbookOther), _
                                    PreparedStatement(newObj.cashbookPayment), _
                                    PreparedStatement(newObj.logoURL), _
                                    PreparedStatement(newObj.currency), _
                                    PreparedStatement(newObj.pricing), _
                                    PreparedStatement(newObj.hotlines), _
                                    PreparedStatement(newObj.defaultVisaRate), _
                                    PreparedStatement(newObj.defaultMasterRate), _
                                    PreparedStatement(newObj.defaultAmexRate), _
                                    PreparedStatement(newObj.defaultDinerRate), _
                                    PreparedStatement(newObj.defaultCard1Rate), _
                                    PreparedStatement(newObj.defaultCard2Rate), _
                                    PreparedStatement(newObj.defaultCard3Rate), _
                                    PreparedStatement(newObj.defaultOtherRate), _
                                    PreparedStatement(newObj.formatInvoiceHeaderText), _
                                    PreparedStatement(newObj.formatInvoiceFooterText), _
                                    PreparedStatement(newObj.formatInvoiceEntityAddress), _
                                    PreparedStatement(newObj.formatInvoiceRow), _
                                    PreparedStatement(newObj.formatInvoiceType), _
                                    PreparedStatement(newObj.formatCashsaleHeaderText), _
                                    PreparedStatement(newObj.formatCashsaleFooterText), _
                                    PreparedStatement(newObj.formatCashsaleEntityAddress), _
                                    PreparedStatement(newObj.formatCashsaleRow), _
                                    PreparedStatement(newObj.formatCashsaleType), _
                                    PreparedStatement(newObj.formatReceiptHeaderText), _
                                    PreparedStatement(newObj.formatReceiptFooterText), _
                                    PreparedStatement(newObj.formatReceiptEntityAddress), _
                                    PreparedStatement(newObj.formatReceiptRow), _
                                    PreparedStatement(newObj.formatReceiptType), _
                                    PreparedStatement(newObj.formatPurchaseOrderHeaderText), _
                                    PreparedStatement(newObj.formatPurchaseOrderFooterText), _
                                    PreparedStatement(newObj.formatPurchaseOrderRow), _
                                    PreparedStatement(newObj.formatPurchaseOrderType), _
                                    PreparedStatement(newObj.formatSalarySlipHeaderText), _
                                    PreparedStatement(newObj.formatSalarySlipFooterText), _
                                    PreparedStatement(newObj.formatSalarySlipRow), _
                                    PreparedStatement(newObj.formatSalarySlipType), _
                                    PreparedStatement(newObj.formatPaymentVoucherHeaderText), _
                                    PreparedStatement(newObj.formatPaymentVoucherFooterText), _
                                    PreparedStatement(newObj.formatPaymentVoucherRow), _
                                    PreparedStatement(newObj.formatPaymentVoucherType), _
                                    PreparedStatement(newObj.formatCreditMemoHeaderText), _
                                    PreparedStatement(newObj.formatCreditMemoFooterText), _
                                    PreparedStatement(newObj.formatCreditMemoRow), _
                                    PreparedStatement(newObj.formatCreditMemoType), _
                                    PreparedStatement(newObj.defaultRmaLocationCust), _
                                    PreparedStatement(newObj.defaultRmaLocationSupp), _
                                    PreparedStatement(newObj.defaultRmaLocationHq), _
                                    PreparedStatement(newObj.defaultRmaLocationBranch), _
                                    PreparedStatement(newObj.managerPassword01), _
                                    PreparedStatement(newObj.managerPassword02), _
                                    PreparedStatement(newObj.managerPassword03), _
                                    PreparedStatement(newObj.managerPassword04), _
                                    PreparedStatement(newObj.managerPassword05), _
                                    PreparedStatement(newObj.managerPassword06), _
                                    PreparedStatement(newObj.managerPassword07), _
                                    PreparedStatement(newObj.managerPassword08), _
                                    PreparedStatement(newObj.managerPassword09), _
                                    PreparedStatement(newObj.telephoneDeveloper), _
                                    PreparedStatement(newObj.telephoneSysadmin), _
                                    PreparedStatement(newObj.telephoneClerk), _
                                    PreparedStatement(newObj.telephoneAdmin), _
                                    PreparedStatement(newObj.telephoneManager), _
                                    PreparedStatement(newObj.telephoneSales), _
                                    PreparedStatement(newObj.telephoneTechSupport), _
                                    PreparedStatement(newObj.telephoneDirector), _
                                    PreparedStatement(newObj.mobilephoneDeveloper), _
                                    PreparedStatement(newObj.mobilephoneSysadmin), _
                                    PreparedStatement(newObj.mobilephoneClerk), _
                                    PreparedStatement(newObj.mobilephoneAdmin), _
                                    PreparedStatement(newObj.mobilephoneManager), _
                                    PreparedStatement(newObj.mobilephoneSales), _
                                    PreparedStatement(newObj.mobilephoneTechSupport), _
                                    PreparedStatement(newObj.mobilephoneDirector), _
                                    PreparedStatement(newObj.emailSystem), _
                                    PreparedStatement(newObj.emailDeveloper), _
                                    PreparedStatement(newObj.emailSysadmin), _
                                    PreparedStatement(newObj.emailClerk), _
                                    PreparedStatement(newObj.emailAdmin), _
                                    PreparedStatement(newObj.emailManager), _
                                    PreparedStatement(newObj.emailSales), _
                                    PreparedStatement(newObj.emailTechSupport), _
                                    PreparedStatement(newObj.emailDirector), _
                                    PreparedStatement(newObj.customerId), _
                                    PreparedStatement(newObj.supplierId), _
                                    PreparedStatement(newObj.loyaltyCardNoPrefix), _
                                    PreparedStatement(newObj.loyaltyCardNoPostfix), _
                                    PreparedStatement(newObj.crvDayFrom), _
                                    PreparedStatement(newObj.crvDayTo), _
                                    PreparedStatement(newObj.formatProformaInvoiceType), _
                                    PreparedStatement(newObj.formatProformaInvoiceFooterText), _
                                    PreparedStatement(newObj.formatProformaInvoiceHeaderText), _
                                    PreparedStatement(newObj.formatProformaInvoiceRow), _
                                    PreparedStatement(newObj.formatServiceNoteType), _
                                    PreparedStatement(newObj.formatServiceNoteFooterText), _
                                    PreparedStatement(newObj.formatServiceNoteHeaderText), _
                                    PreparedStatement(newObj.formatServiceNoteRow), _
                                    PreparedStatement(newObj.taxRegNumber), _
                                    PreparedStatement(newObj.pkid))


            objDA.ExecuteNonQuery(strSQL)

        Catch ex As Exception
            Messenger.ShowError("updateBranch: " & ex.Message)
        End Try

    End Function

    Public Function updateItem(ByVal item As itemObject) As Boolean

        Dim strSQL As String

        Try
            strSQL = "UPDATE inv_item SET inm_unit={0}, item_code={1}, name={2}, description={3}, status={4}, lastupdate={5}, userid_edit={6}, uom={7}, unit_of_meas={8}, inv_type={9}, item_type1={10}, " & _
                        " item_type2={11}, item_type3={12}, glcode={13}, state={14}, categoryid={15}, category1={16}, category2={17}, category3={18}, category4={19}, category5={20}, " & _
                        " has_children={21}, parentid={22}, parent_ratio={23}, ean_code={24}, upc_code={25}, isbn_code={26}, price_list={27}, price_sale={28}, price_disc1={29}, price_disc2={30}, " & _
                        " price_disc3={31}, price_min={32}, fifo_unit_cost={33}, ma_unit_cost={34}, wa_unit_cost={35}, last_unit_cost={36}, replacement_cost={37}, serialized={38}, weight={39}, length={40}, " & _
                        " width={41}, depth={42}, preferred_supplier={43}, min_order_qty={44}, lead_time={45}, reserved1={46}, reserved2={47}, reserved3={48}, pix_thumb_name={49}, pix_full_name={50}, " & _
                        " pix_thumbnail={51}, pix_fullsize={52}, rebate1_pct={53}, rebate1_price={54}, rebate1_start={55}, rebate1_end={56}, disc1_pct={57}, disc1_amount={58}, disc1_start={59}, disc1_end={60}, " & _
                        " production_required={61}, production_lead_time={62}, production_cost={63}, production_process={64}, production_name={65}, production_description={66}, delivery_required={67}, delivery_lead_time={68}, delivery_cost={69}, delivery_process={70}, " & _
                        " delivery_name={71}, delivery_description={72}, delta_price_retail_amt={73}, delta_price_retail_pct={74}, delta_price_dealer_amt={75}, delta_price_dealer_pct={76}, delta_price_outlet_amt={77}, delta_price_outlet_pct={78}, disc_max_pct={79}, warranty_type={80}, " & _
                        " warranty_period={81}, shelf_life={82}, commission_pct_sales1={83}, commission_pct_sales2={84}, commission_pct_sales3={85}, commission_pct_sales4={86}, commission_pct_partner={87}, commission_pct_gp={88}, logic_reorder={89}, logic_max_qty={90}, " & _
                        " threshold_qty_reorder={91}, threshold_qty_max_qty={92}, remarks1={93}, remarks2={94}, keywords={95}, prefix_logic={96}, prefix_length={97}, prefix_code={98}, postfix_logic={99}, postfix_length={100}, " & _
                        " postfix_code={101}, code_project={102}, code_department={103}, code_dealer={104}, code_salesman={105}, tax_option={106}, tax_rate={107}, price_ecom={108}, out_qty={109}, out_unit={110}, " & _
                        " in_qty={110}, in_unit={111}, inn_qty={112}, inn_unit={113}, inm_qty={114} WHERE pkid={115} "

            strSQL = String.Format(strSQL, PreparedStatement(item.inmUnit), _
                                PreparedStatement(item.code), _
                                PreparedStatement(item.name), _
                                PreparedStatement(item.description), _
                                PreparedStatement(item.status), _
                                PreparedStatement(item.lastUpdate), _
                                PreparedStatement(item.userIdUpdate), _
                                PreparedStatement(item.uom), _
                                PreparedStatement(item.unitOfMeasure), _
                                PreparedStatement(item.enumInvType), _
                                PreparedStatement(item.itemType1), _
                                PreparedStatement(item.itemType2), _
                                PreparedStatement(item.itemType3), _
                                PreparedStatement(item.glcode), _
                                PreparedStatement(item.state), _
                                PreparedStatement(item.categoryId), _
                                PreparedStatement(item.category1), _
                                PreparedStatement(item.category2), _
                                PreparedStatement(item.category3), _
                                PreparedStatement(item.category4), _
                                PreparedStatement(item.category5), _
                                PreparedStatement(item.hasChildren), _
                                PreparedStatement(item.parentId), _
                                PreparedStatement(item.parentRatio), _
                                PreparedStatement(item.EANCode), _
                                PreparedStatement(item.upcCode), _
                                PreparedStatement(item.isbnCode), _
                                PreparedStatement(item.priceList), _
                                PreparedStatement(item.priceSale), _
                                PreparedStatement(item.priceDisc1), _
                                PreparedStatement(item.priceDisc2), _
                                PreparedStatement(item.priceDisc3), _
                                PreparedStatement(item.priceMin), _
                                PreparedStatement(item.fifoUnitCost), _
                                PreparedStatement(item.maUnitCost), _
                                PreparedStatement(item.waUnitCost), _
                                PreparedStatement(item.lastUnitCost), _
                                PreparedStatement(item.replacementUnitCost), _
                                PreparedStatement(item.serialized), _
                                PreparedStatement(item.weight), _
                                PreparedStatement(item.length), _
                                PreparedStatement(item.width), _
                                PreparedStatement(item.depth), _
                                PreparedStatement(item.minOrderQty), _
                                PreparedStatement(item.preferredSupplier), _
                                PreparedStatement(item.leadTime), _
                                PreparedStatement(item.reserved1), _
                                PreparedStatement(item.reserved2), _
                                PreparedStatement(item.reserved3), _
                                PreparedStatement(item.pixThumbName), _
                                PreparedStatement(item.pixFullName), _
                                PreparedStatement(item.pixThumbnail), _
                                PreparedStatement(item.pixFullsize), _
                                PreparedStatement(item.rebate1Pct), _
                                PreparedStatement(item.rebate1Price), _
                                PreparedStatement(item.rebate1Start), _
                                PreparedStatement(item.rebate1End), _
                                PreparedStatement(item.disc1Pct), _
                                PreparedStatement(item.disc1Amount), _
                                PreparedStatement(item.disc1Start), _
                                PreparedStatement(item.disc1End), _
                                PreparedStatement(item.productionRequired), _
                                PreparedStatement(item.productionLeadTime), _
                                PreparedStatement(item.productionCost), _
                                PreparedStatement(item.productionProcess), _
                                PreparedStatement(item.productionName), _
                                PreparedStatement(item.productionDescription), _
                                PreparedStatement(item.deliveryRequired), _
                                PreparedStatement(item.deliveryLeadTime), _
                                PreparedStatement(item.deliveryCost), _
                                PreparedStatement(item.deliveryProcess), _
                                PreparedStatement(item.deliveryName), _
                                PreparedStatement(item.deliveryDescription), _
                                PreparedStatement(item.deltaPriceRetailAmt), _
                                PreparedStatement(item.deltaPriceRetailPct), _
                                PreparedStatement(item.deltaPriceDealerAmt), _
                                PreparedStatement(item.deltaPriceDealerPct), _
                                PreparedStatement(item.deltaPriceOutletAmt), _
                                PreparedStatement(item.deltaPriceOutletPct), _
                                PreparedStatement(item.discMaxPct), _
                                PreparedStatement(item.warrantyType), _
                                PreparedStatement(item.warrantyPeriod), _
                                PreparedStatement(item.shelfLife), _
                                PreparedStatement(item.commissionPctSales1), _
                                PreparedStatement(item.commissionPctSales2), _
                                PreparedStatement(item.commissionPctSales3), _
                                PreparedStatement(item.commissionPctSales4), _
                                PreparedStatement(item.commissionPctPartner), _
                                PreparedStatement(item.commissionPctGP), _
                                PreparedStatement(item.logicReorder), _
                                PreparedStatement(item.logicMaxQty), _
                                PreparedStatement(item.thresholdQtyReorder), _
                                PreparedStatement(item.thresholdQtyMaxQty), _
                                PreparedStatement(item.remarks1), _
                                PreparedStatement(item.remarks2), _
                                PreparedStatement(item.keywords), _
                                PreparedStatement(item.prefixLogic), _
                                PreparedStatement(item.prefixLength), _
                                PreparedStatement(item.prefixCode), _
                                PreparedStatement(item.postfixLogic), _
                                PreparedStatement(item.postfixLength), _
                                PreparedStatement(item.postfixCode), _
                                PreparedStatement(item.codeProject), _
                                PreparedStatement(item.codeDepartment), _
                                PreparedStatement(item.codeDealer), _
                                PreparedStatement(item.codeSalesman), _
                                PreparedStatement(item.tax_option), _
                                PreparedStatement(item.tax_rate), _
                                PreparedStatement(item.priceEcom), _
                                PreparedStatement(item.outQty), _
                                PreparedStatement(item.outUnit), _
                                PreparedStatement(item.inQty), _
                                PreparedStatement(item.inUnit), _
                                PreparedStatement(item.innQty), _
                                PreparedStatement(item.innUnit), _
                                PreparedStatement(item.inmQty), _
                                item.pkid)

            objDA.ExecuteNonQuery(strSQL)

        Catch ex As Exception
            Messenger.ShowError("updateItem: " & ex.Message)
        End Try

    End Function

    Public Function updateCashAccount(ByVal newObj As cashAccountObject) As Boolean

        Dim strSQL As String

        Try
            strSQL = "UPDATE acc_cash_account SET code={0}, name={1}, description={2}, acc_number={3}, acc_type={4}, currency={5}, level_low={6}, level_high={7}, facility_amount={8}, overdraft_limit={9}, signatory1={10}, " & _
                        " signatory2={11}, signatory3={12}, signatory4={13}, signature={14}, pc_center={15}, add1={16}, add2={17}, add3={18}, state={19}, country={20}, " & _
                        " phone={21}, contact_person={22}, fax={23}, userid_create={24}, userid_update={25}, createtime={26}, lastupdate={27}, status={28} " & _
                        " WHERE pkid={29}"

            strSQL = String.Format(strSQL, _
                           PreparedStatement(newObj.code), _
                           PreparedStatement(newObj.name), _
                           PreparedStatement(newObj.description), _
                           PreparedStatement(newObj.accountNumber), _
                           PreparedStatement(newObj.accountType), _
                           PreparedStatement(newObj.currency), _
                           PreparedStatement(newObj.levelLow), _
                           PreparedStatement(newObj.levelHigh), _
                           PreparedStatement(newObj.facilityAmount), _
                           PreparedStatement(newObj.overdraftLimit), _
                           PreparedStatement(newObj.signatory1), _
                           PreparedStatement(newObj.signatory2), _
                           PreparedStatement(newObj.signatory3), _
                           PreparedStatement(newObj.signatory4), _
                           PreparedStatement(newObj.signature), _
                           PreparedStatement(newObj.pcCenter), _
                           PreparedStatement(newObj.add1), _
                           PreparedStatement(newObj.add2), _
                           PreparedStatement(newObj.add3), _
                           PreparedStatement(newObj.state), _
                           PreparedStatement(newObj.country), _
                           PreparedStatement(newObj.phone), _
                           PreparedStatement(newObj.contactPerson), _
                           PreparedStatement(newObj.fax), _
                           PreparedStatement(newObj.userIdCreate), _
                           PreparedStatement(newObj.userIdUpdate), _
                           PreparedStatement(newObj.createTime), _
                           PreparedStatement(newObj.lastUpdate), _
                           PreparedStatement(newObj.status), _
                           PreparedStatement(newObj.pkId))

            objDA.ExecuteNonQuery(strSQL)

        Catch ex As Exception
            Messenger.ShowError("updateStock: " & ex.Message)
        End Try

    End Function


    Public Function updateCategoryTree(ByVal newObj As categoryTreeObject) As Boolean

        Dim strSQL As String

        Try
            strSQL = "UPDATE inv_category_tree SET parent_id={0}, cat_level={1}, code={2}, sort={3}, name={4}, description={5} " & _
                        " WHERE pkid={6}"

            strSQL = String.Format(strSQL, _
                           PreparedStatement(newObj.pkid), _
                           PreparedStatement(newObj.parentId), _
                           PreparedStatement(newObj.catLevel), _
                           PreparedStatement(newObj.code), _
                           PreparedStatement(newObj.sort), _
                           PreparedStatement(newObj.name), _
                           PreparedStatement(newObj.description), _
                           PreparedStatement(newObj.pkid))

            objDA.ExecuteNonQuery(strSQL)

        Catch ex As Exception
            Messenger.ShowError("updateCategoryTree: " & ex.Message)
        End Try

    End Function


    Public Function getConfig(ByVal namespace1 As String) As String
        Dim strSQL As String
        Dim ds As DataSet
        Dim returnValue As String = ""
        Dim pkid As Long

        Try
            strSQL = "select * from cust_pos_config where namespace = {0}"
            strSQL = String.Format(strSQL, PreparedStatement(namespace1))

            ds = objDA.ExecuteQuery(strSQL, "0", DataAccess.Commands.ReturnType.DataSetType)
            If ds Is Nothing Then Return returnValue

            If ds.Tables(0).Rows.Count > 0 Then
                returnValue = ds.Tables(0).Rows(0)("content").ToString()
            Else
                pkid = getMaxPkid("cust_pos_config")
                strSQL = "INSERT INTO cust_pos_config (pkid, namespace, content, remarks, userid_edit, time_edit) " & _
                            " VALUES ({0}, {1}, {2}, {3}, {4}, {5} )"
                strSQL = String.Format(strSQL, pkid, PreparedStatement(namespace1), _
                                                    PreparedStatement(""), _
                                                    PreparedStatement(""), _
                                                    gUserID, _
                                                    PreparedStatement(Now))

            End If

            objDA.ExecuteNonQuery(strSQL)

        Catch ex As Exception
            Messenger.ShowError("getConfig: " & ex.Message)
        End Try

        Return returnValue

    End Function

    Public Function updateConfig(ByVal namespace1 As String, ByVal content As String) As Integer
        Dim strSQL As String

        Try
            strSQL = "UPDATE cust_pos_config SET content = {0} WHERE namespace = {1}"
            strSQL = String.Format(strSQL, PreparedStatement(content), PreparedStatement(namespace1))
            objDA.ExecuteNonQuery(strSQL)

        Catch ex As Exception
            Messenger.ShowError("updateConfig: " & ex.Message)
        End Try

    End Function


    Private Function getPriceFieldByConfig() As String

        Select Case gConfigObj.PriceSchema
            Case "Price List"
                Return "i.price_list"
            Case "Price Sale"
                Return "i.price_sale"
            Case "Price Disc1"
                Return "i.price_disc1"
            Case "Price Disc2"
                Return "i.price_disc2"
            Case "Price Disc3"
                Return "i.price_disc3"
            Case Else
                Return "i.price_list"
        End Select

    End Function

End Class