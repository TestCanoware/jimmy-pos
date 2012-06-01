-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.0.51b-community-nt


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema wsemp
--

CREATE DATABASE IF NOT EXISTS wsemp;
USE wsemp;

--
-- Definition of table `acc_branch_index`
--
CREATE TABLE `acc_branch_index` (
  `pkid` int(11) NOT NULL,
  `code` varchar(50) default NULL,
  `reg_no` varchar(20) default NULL,
  `name` varchar(100) default NULL,
  `description` varchar(300) default NULL,
  `addr1` varchar(100) default NULL,
  `addr2` varchar(100) default NULL,
  `addr3` varchar(100) default NULL,
  `zip` varchar(10) default NULL,
  `state` varchar(20) default NULL,
  `countrycode` varchar(2) default NULL,
  `phone_no` varchar(30) default NULL,
  `fax_no` varchar(30) default NULL,
  `web_url` varchar(120) default NULL,
  `acc_pccenterid` int(11) default '0',
  `inv_locationid` int(11) default '0',
  `status` varchar(10) default 'active',
  `lastupdate` timestamp NOT NULL default '0000-00-00 00:00:00',
  `userid_edit` int(11) default '0',
  `cashbook_cash` int(11) default '0',
  `cashbook_card` int(11) default '0',
  `cashbook_cheque` int(11) default '0',
  `cashbook_pd_cheque` int(11) default '0',
  `cashbook_coupon` int(11) default '0',
  `cashbook_other` int(11) default '0',
  `cashbook_payment` int(11) default '0',
  `logo_url` varchar(100) default '',
  `currency` varchar(3) default 'MYR',
  `pricing` varchar(10) default '',
  `hotlines` varchar(30) default '',
  `default_visa_rate` decimal(20,4) default '0.0000',
  `default_master_rate` decimal(20,4) default '0.0000',
  `default_amex_rate` decimal(20,4) default '0.0000',
  `default_diner_rate` decimal(20,4) default '0.0000',
  `default_card1_rate` decimal(20,4) default '0.0000',
  `default_card2_rate` decimal(20,4) default '0.0000',
  `default_card3_rate` decimal(20,4) default '0.0000',
  `default_other_rate` decimal(20,4) default '0.0000',
  `format_invoice_header_text` text default NULL,
  `format_invoice_footer_text` text default NULL,
  `format_invoice_entity_address` varchar(20) default NULL,
  `format_invoice_row` int(11) default NULL,
  `format_invoice_type` varchar(100) default NULL,
  `format_cashsale_header_text` text default NULL,
  `format_cashsale_footer_text` text default NULL,
  `format_cashsale_entity_address` varchar(20) default NULL,
  `format_cashsale_row` int(11) default NULL,
  `format_cashsale_type` varchar(100) default NULL,
  `format_receipt_header_text` text default NULL,
  `format_receipt_footer_text` text default NULL,
  `format_receipt_entity_address` varchar(20) default NULL,
  `format_receipt_row` int(11) default NULL,
  `format_receipt_type` varchar(100) default NULL,
  `format_purchase_order_header_text` text default NULL,
  `format_purchase_order_footer_text` text default NULL,
  `format_purchase_order_row` int(11) default NULL,
  `format_purchase_order_type` varchar(100) default NULL,
  `format_salary_slip_header_text` text default NULL,
  `format_salary_slip_footer_text` text default NULL,
  `format_salary_slip_row` int(11) default NULL,
  `format_salary_slip_type` varchar(100) default NULL,
  `format_payment_voucher_header_text` text default NULL,
  `format_payment_voucher_footer_text` text default NULL,
  `format_payment_voucher_row` int(11) default NULL,
  `format_payment_voucher_type` varchar(100) default NULL,
  `format_credit_memo_header_text` text default NULL,
  `format_credit_memo_footer_text` text default NULL,
  `format_credit_memo_row` int(11) default NULL,
  `format_credit_memo_type` varchar(100) default NULL,
  `default_rma_location_cust` int(11) default NULL,
  `default_rma_location_supp` int(11) default NULL,
  `default_rma_location_hq` int(11) default NULL,
  `default_rma_location_branch` int(11) default NULL,
  `manager_password01` varchar(100) default NULL,
  `manager_password02` varchar(100) default NULL,
  `manager_password03` varchar(100) default NULL,
  `manager_password04` varchar(100) default NULL,
  `manager_password05` varchar(100) default NULL,
  `manager_password06` varchar(100) default NULL,
  `manager_password07` varchar(100) default NULL,
  `manager_password08` varchar(100) default NULL,
  `manager_password09` varchar(100) default NULL,
  `telephone_developer` varchar(30) default NULL,
  `telephone_sysadmin` varchar(30) default NULL,
  `telephone_clerk` varchar(30) default NULL,
  `telephone_admin` varchar(30) default NULL,
  `telephone_manager` varchar(30) default NULL,
  `telephone_sales` varchar(30) default NULL,
  `telephone_tech_support` varchar(30) default NULL,
  `telephone_director` varchar(30) default NULL,
  `mobilephone_developer` varchar(30) default NULL,
  `mobilephone_sysadmin` varchar(30) default NULL,
  `mobilephone_clerk` varchar(30) default NULL,
  `mobilephone_admin` varchar(30) default NULL,
  `mobilephone_manager` varchar(30) default NULL,
  `mobilephone_sales` varchar(30) default NULL,
  `mobilephone_tech_support` varchar(30) default NULL,
  `mobilephone_director` varchar(30) default NULL,
  `email_system` varchar(255) default NULL,
  `email_developer` varchar(255) default NULL,
  `email_sysadmin` varchar(255) default NULL,
  `email_clerk` varchar(255) default NULL,
  `email_admin` varchar(255) default NULL,
  `email_manager` varchar(255) default NULL,
  `email_sales` varchar(255) default NULL,
  `email_tech_support` varchar(255) default NULL,
  `email_director` varchar(255) default NULL,
  `customer_id` int(11) default NULL,
  `supplier_id` int(11) default NULL,
  `loyalty_card_no_prefix` varchar(10) default NULL,
  `loyalty_card_no_postfix` varchar(10) default NULL,
  `crv_day_from` int(11) default NULL,
  `crv_day_to` int(11) default NULL,
  `format_proforma_invoice_type` varchar(100) default NULL,
  `format_proforma_invoice_footer_text` text default NULL,
  `format_proforma_invoice_header_text` text default NULL,
  `format_proforma_invoice_row` int(11) default NULL,
  `format_service_note_type` varchar(100) default NULL,
  `format_service_note_footer_text` text default NULL,
  `format_service_note_header_text` text default NULL,
  `format_service_note_row` int(11) default NULL,
  `format_packing_list_type` varchar(100) default NULL,
  `format_packing_list_footer_text` text default NULL,
  `format_packing_list_header_text` text default NULL,
  `format_packing_list_row` int(11) default NULL,
  `format_jobsheet_type` varchar(100) default NULL,
  `format_jobsheet_footer_text` text default NULL,
  `format_jobsheet_header_text` text default NULL,
  `format_jobsheet_row` int(11) default NULL,
  `format_grn_type` varchar(100) default NULL,
  `format_grn_footer_text` text default NULL,
  `format_grn_header_text` text default NULL,
  `format_grn_row` int(11) default NULL,
  `tax_reg_number` varchar(25) default NULL,
  PRIMARY KEY  (`pkid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `acc_branch_index`
--

--
-- Definition of table `acc_card_payment_config`
--
CREATE TABLE `acc_card_payment_config` (
  `pkid` int(11) NOT NULL,
  `namespace` varchar(20) default NULL,
  `sortcode` varchar(20) default NULL,
  `bank_code` varchar(20) default NULL,
  `bank_name` varchar(500) default NULL,
  `payment_mode` varchar(20) default NULL,
  `policy_charges` varchar(20) default NULL,
  `pct_charges` decimal(20,4) default NULL,
  `limit_min` decimal(20,4) default NULL,
  `limit_max` decimal(20,4) default NULL,
  `pccenter_opt` varchar(20) default NULL,
  `pccenter` int(11) default NULL,
  `branch_opt` varchar(20) default NULL,
  `branch` int(11) default NULL,
  `cashbook_opt` varchar(20) default NULL,
  `cashbook` int(11) default NULL,
  `status` varchar(20) default NULL,
  `payment_type` varchar(20) default NULL,
  `approval_party` varchar(20) default NULL,
  `default_payment_status` varchar(20) default NULL,
  `default_card_type` varchar(20) default NULL,
  `default_payment_remarks` varchar(50) default NULL,
  `property1` varchar(50) default NULL,
  `property2` varchar(50) default NULL,
  `property3` varchar(50) default NULL,
  `cust_admin_fee_option` varchar(50) default NULL,
  `cust_admin_fee_abs` decimal(20,4) default NULL,
  `cust_admin_fee_ratio` decimal(20,4) default NULL,
  `cust_admin_fee_itemid` int(11) default NULL,
  `cust_admin_fee_rounding_mode` int(11) default NULL,
  `cust_admin_fee_rounding_scale` int(11) default NULL,
  `cust_admin_fee_min_amount` decimal(20,4) default NULL,
  `cust_admin_fee_max_amount` decimal(20,4) default NULL,
  `abs_charges` decimal(20,4) default NULL,
  PRIMARY KEY  (`pkid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `acc_card_payment_config`
--

--
-- Definition of table `acc_cash_account`
--
CREATE TABLE `acc_cash_account` (
  `pkid` int(11) NOT NULL,
  `code` varchar(20) default NULL,
  `name` varchar(100) default NULL,
  `description` varchar(100) default NULL,
  `acc_number` varchar(100) default NULL,
  `acc_type` varchar(50) default NULL,
  `currency` varchar(3) default NULL,
  `level_low` decimal(20,4) default NULL,
  `level_high` decimal(20,4) default NULL,
  `facility_amount` decimal(20,4) default NULL,
  `overdraft_limit` decimal(20,4) default NULL,
  `signatory1` varchar(100) default NULL,
  `signatory2` varchar(100) default NULL,
  `signatory3` varchar(100) default NULL,
  `signatory4` varchar(100) default NULL,
  `signature` varchar(100) default NULL,
  `pc_center` int(11) default NULL,
  `add1` varchar(100) default NULL,
  `add2` varchar(100) default NULL,
  `add3` varchar(100) default NULL,
  `state` varchar(100) default NULL,
  `country` varchar(50) default NULL,
  `phone` varchar(30) default NULL,
  `contact_person` varchar(100) default NULL,
  `fax` varchar(30) default NULL,
  `userid_create` int(11) default NULL,
  `userid_update` int(11) default NULL,
  `createtime` timestamp NOT NULL default '0000-00-00 00:00:00',
  `lastupdate` timestamp NOT NULL default '0000-00-00 00:00:00',
  `status` varchar(20) default NULL,
  PRIMARY KEY  (`pkid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `acc_cash_account`
--

--
-- Definition of table `acc_doclink`
--
CREATE TABLE `acc_doclink` (
  `pkid` bigint(20) NOT NULL,
  `namespace` varchar(20) default NULL,
  `reference` varchar(100) default NULL,
  `rel_type` varchar(20) default NULL,
  `src_docref` varchar(100) default NULL,
  `src_docid` bigint(20) default NULL,
  `tgt_docref` varchar(100) default NULL,
  `tgt_docid` bigint(20) default NULL,
  `currency` varchar(3) default NULL,
  `amount` decimal(20,4) default NULL,
  `currency2` varchar(3) default NULL,
  `amount2` decimal(20,4) default NULL,
  `remarks` varchar(200) default NULL,
  `status` varchar(20) default NULL,
  `userid_edit` int(11) default NULL,
  `lastupdate` timestamp NOT NULL default '0000-00-00 00:00:00',
  PRIMARY KEY  (`pkid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `acc_doclink`
--

--
-- Definition of table `acc_payment_voucher_index`
--
CREATE TABLE `acc_payment_voucher_index` (
  `pkid` bigint(20) NOT NULL,
  `stmt_no` bigint(20) default NULL,
  `uuid` varchar(50) default NULL,
  `pc_center` int(11) default NULL,
  `branch` int(11) default NULL,
  `currency` varchar(3) default NULL,
  `amount_total` decimal(20,4) default NULL,
  `xrate` decimal(32,12) default NULL,
  `currency2` varchar(3) default NULL,
  `amount_total2` decimal(20,4) default NULL,
  `glcode_debit` varchar(50) default NULL,
  `glcode_credit` varchar(50) default NULL,
  `cashbook_cash` int(11) default NULL,
  `cashbook_card` int(11) default NULL,
  `cashbook_cheque` int(11) default NULL,
  `cashbook_pd_cheque` int(11) default NULL,
  `cashbook_coupon` int(11) default NULL,
  `cashbook_other` int(11) default NULL,
  `amount_cash` decimal(20,4) default NULL,
  `amount_card` decimal(20,4) default NULL,
  `amount_cheque` decimal(20,4) default NULL,
  `amount_pd_cheque` decimal(20,4) default NULL,
  `amount_coupon` decimal(20,4) default NULL,
  `amount_other` decimal(20,4) default NULL,
  `pay_to` varchar(100) default NULL,
  `reference_no` varchar(100) default NULL,
  `cheque_no` varchar(50) default NULL,
  `description` varchar(500) default NULL,
  `remarks` varchar(500) default NULL,
  `info1` varchar(250) default NULL,
  `info2` varchar(250) default NULL,
  `date_stmt` timestamp NOT NULL default '0000-00-00 00:00:00',
  `date_created` timestamp NOT NULL default '0000-00-00 00:00:00',
  `date_approved` timestamp NOT NULL default '0000-00-00 00:00:00',
  `date_verified` timestamp NOT NULL default '0000-00-00 00:00:00',
  `date_update` timestamp NOT NULL default '0000-00-00 00:00:00',
  `userid_create` int(11) default NULL,
  `userid_pic` int(11) default NULL,
  `userid_approve` int(11) default NULL,
  `userid_verified` int(11) default NULL,
  `userid_update` int(11) default NULL,
  `reserved1` varchar(50) default NULL,
  `reserved2` varchar(50) default NULL,
  `state` varchar(20) default NULL,
  `internal_status` varchar(50) default NULL,
  `status` varchar(20) default NULL,
  `open_balance` decimal(20,4) default NULL,
  `open_balance2` decimal(20,4) default NULL,
  `remarks_reverse` varchar(500) default NULL,
  `synchro_key` varchar(50) default NULL,
  PRIMARY KEY  (`pkid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `acc_payment_voucher_index`
--

--
-- Definition of table `acc_payment_voucher_item`
--
CREATE TABLE `acc_payment_voucher_item` (
  `pkid` bigint(20) NOT NULL,
  `index_id` bigint(20) default NULL,
  `position` int(11) default NULL,
  `uuid` varchar(50) default NULL,
  `txn_type` varchar(50) default NULL,
  `txn_code` varchar(50) default NULL,
  `cheque_no` varchar(50) default NULL,
  `pc_center` int(11) default NULL,
  `branch` int(11) default NULL,
  `category` varchar(50) default NULL,
  `project` varchar(50) default NULL,
  `glcode_debit` varchar(50) default NULL,
  `glcode_credit` varchar(50) default NULL,
  `currency` varchar(3) default NULL,
  `amount` decimal(20,4) default NULL,
  `xrate` decimal(32,12) default NULL,
  `currency2` varchar(3) default NULL,
  `amount2` decimal(20,4) default NULL,
  `reference_no` varchar(100) default NULL,
  `description` varchar(500) default NULL,
  `remarks` varchar(8000) default NULL,
  `info1` varchar(250) default NULL,
  `info2` varchar(250) default NULL,
  `entity_table` varchar(50) default NULL,
  `entity_key` int(11) default NULL,
  `entity_name` varchar(150) default NULL,
  `date_stmt` timestamp NOT NULL default '0000-00-00 00:00:00',
  `date_item` timestamp NOT NULL default '0000-00-00 00:00:00',
  `userid_pic` int(11) default NULL,
  `state` varchar(20) default NULL,
  `status` varchar(20) default NULL,
  PRIMARY KEY  (`pkid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `acc_payment_voucher_item`
--

--
-- Definition of table `acc_receipt_index`
--
CREATE TABLE `acc_receipt_index` (
  `pkid` bigint(20) NOT NULL,
  `stmt_no` bigint(20) default '0',
  `entity_table` varchar(50) default '',
  `entity_key` int(11) default '0',
  `entity_name` text default '',
  `int_reserved1` int(11) default '0',
  `str_reserved1` varchar(100) default '',
  `currency` varchar(3) default '',
  `amount` decimal(20,4) default '0.0000',
  `currency2` varchar(3) default '',
  `amount2` decimal(20,4) default '0.0000',
  `payment_time` timestamp NOT NULL default '0000-00-00 00:00:00',
  `payment_method` varchar(100) default '',
  `payment_remarks` varchar(300) default '',
  `cheque_number` varchar(30) default '',
  `state` varchar(20) default '',
  `status` varchar(20) default 'active',
  `lastupdate` timestamp NOT NULL default '0000-00-00 00:00:00',
  `userid_update` int(11) default '500',
  `cb_cash` int(11) default '0',
  `cb_card` int(11) default '0',
  `cb_cheque` int(11) default '0',
  `cb_pd_cheque` int(11) default '0',
  `cb_coupon` int(11) default '0',
  `cb_other` int(11) default '0',
  `amount_cash` decimal(20,4) default '0.0000',
  `amount_card` decimal(20,4) default '0.0000',
  `amount_cheque` decimal(20,4) default '0.0000',
  `amount_pd_cheque` decimal(20,4) default '0.0000',
  `amount_coupon` decimal(20,4) default '0.0000',
  `amount_other` decimal(20,4) default '0.0000',
  `date_pd_cheque` timestamp NOT NULL default '0000-00-00 00:00:00',
  `cheque_number_pd` varchar(30) default '',
  `branch` int(11) default '0',
  `pc_center` int(11) default '0',
  `card_pct_charges` decimal(20,4) default '0.0000',
  `card_charges` decimal(20,4) default '0.0000',
  `card_type` varchar(500) default '',
  `card_cb` int(11) default '0',
  `pdc_exist` tinyint(1) default '0',
  `pdc_clear` tinyint(1) default '0',
  `glcode_credit` varchar(50) default 'accReceivable',
  `open_balance` decimal(20,4) default '0.0000',
  `card_surcharge` decimal(20,4) default '0.0000',
  `cheque_charges_amount` decimal(20,4) default '0.0000',
  `reverse_payment` bigint(20) default '0',
  `e_tfr_cashbook` int(11) default '0',
  `e_tfr_reference` varchar(100) default '',
  `e_tfr_bank` varchar(50) default '',
  `e_tfr_rmks` varchar(200) default '',
  `e_tfr_date` timestamp NOT NULL default '0000-00-00 00:00:00',
  `e_tfr_amount` decimal(20,4) default '0.0000',
  `e_tfr_charges` decimal(20,4) default '0.0000',
  `card_bank` varchar(50) default '',
  `card_name` varchar(100) default '',
  `card_number` varchar(20) default '',
  `card_security_num` varchar(20) default '',
  `card_valid_from` timestamp NOT NULL default '0000-00-00 00:00:00',
  `card_valid_thru` timestamp NOT NULL default '0000-00-00 00:00:00',
  `pic1` int(11) default '0',
  `pic2` int(11) default '0',
  `pic3` int(11) default '0',
  `format` varchar(20) default '',
  `cheque_status` varchar(50) default '',
  `cheque_bank_in_cb` int(11) default '0',
  `pd_cheque_status` varchar(50) default '',
  `pd_cheque_bank_in_cb` int(11) default '0',
  `card_approval_party` varchar(50) default '',
  `card_approval_code` varchar(50) default '',
  `card_approval_time` timestamp NOT NULL default '0000-00-00 00:00:00',
  `status_payment` varchar(20) default '',
  `cash_drawer` varchar(50) default '',
  `remarks_reverse` text default '',
  `card_id` int(11) default '0',
  `cash_notes_received` decimal(20,4) default '0.0000',
  `cash_notes_change` decimal(20,4) default '0.0000',
  `synchro_key` varchar(50) default NULL,
  `pos_id` int(10) unsigned NOT NULL,
  PRIMARY KEY  (`pkid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `acc_receipt_index`
--

--
-- Definition of table `acc_tax_config`
--
CREATE TABLE `acc_tax_config` (
  `pkid` int(11) NOT NULL,
  `guid` varchar(100) default NULL,
  `tax_type` varchar(100) default NULL,
  `tax_type_description` text default NULL,
  `tax_code` varchar(100) default NULL,
  `tax_code_description` text default NULL,
  `tax_rate` decimal(20,4) default NULL,
  `status` varchar(50) default NULL,
  PRIMARY KEY  (`pkid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `acc_tax_config`
--

--
-- Definition of table `app_server_client_link`
--
CREATE TABLE `app_server_client_link` (
  `pkid` bigint(20) default NULL,
  `table_name` varchar(100) default NULL,
  `server_key` bigint(20) default NULL,
  `client_key` bigint(20) default NULL,
  `branch_id` int(11) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `app_server_client_link`
--

--
-- Definition of table `cust_account_index`
--
CREATE TABLE `cust_account_index` (
  `pkid` int(11) NOT NULL,
  `acc_code` varchar(50) default NULL,
  `name` varchar(100) default NULL,
  `description` varchar(300) default NULL,
  `acc_type` int(11) default NULL,
  `status` varchar(20) default NULL,
  `last_edit` timestamp NOT NULL default '0000-00-00 00:00:00',
  `userid_edit` int(11) default NULL,
  `username` varchar(255) default NULL,
  `password` blob,
  `name_first` varchar(255) default NULL,
  `name_last` varchar(255) default NULL,
  `nickname` varchar(255) default NULL,
  `title` varchar(255) default NULL,
  `designation` varchar(255) default NULL,
  `identity_number` varchar(30) default NULL,
  `main_address1` varchar(100) default NULL,
  `main_address2` varchar(100) default NULL,
  `main_address3` varchar(100) default NULL,
  `main_city` varchar(100) default NULL,
  `main_postcode` varchar(20) default NULL,
  `main_state` varchar(20) default NULL,
  `main_country` varchar(40) default NULL,
  `ship_address1` varchar(100) default NULL,
  `ship_address2` varchar(100) default NULL,
  `ship_address3` varchar(100) default NULL,
  `ship_city` varchar(100) default NULL,
  `ship_postcode` varchar(20) default NULL,
  `ship_state` varchar(20) default NULL,
  `ship_country` varchar(40) default NULL,
  `bill_address1` varchar(100) default NULL,
  `bill_address2` varchar(100) default NULL,
  `bill_address3` varchar(100) default NULL,
  `bill_city` varchar(100) default NULL,
  `bill_postcode` varchar(20) default NULL,
  `bill_state` varchar(20) default NULL,
  `bill_country` varchar(40) default NULL,
  `telephone1` varchar(30) default NULL,
  `telephone2` varchar(30) default NULL,
  `home_phone` varchar(30) default NULL,
  `mobile_phone` varchar(30) default NULL,
  `fax_no` varchar(30) default NULL,
  `homepage` varchar(255) default NULL,
  `email1` varchar(255) default NULL,
  `email2` varchar(255) default NULL,
  `email3` varchar(255) default NULL,
  `credit_limit` decimal(20,4) default NULL,
  `credit_terms` int(11) default NULL,
  `property1` varchar(255) default NULL,
  `property2` varchar(255) default NULL,
  `property3` varchar(255) default NULL,
  `property4` varchar(255) default NULL,
  `property5` varchar(255) default NULL,
  `note` varchar(200) default NULL,
  `salesman` int(11) default NULL,
  `state` varchar(20) default NULL,
  `dealer_code` varchar(20) default NULL,
  `factor_pricing` decimal(12,4) default NULL,
  `factor_discount` decimal(12,4) default NULL,
  `pricing_logic` varchar(100) default NULL,
  `pricing_scheme` varchar(100) default NULL,
  `area_code` varchar(100) default NULL,
  `dept_code` varchar(100) default NULL,
  `supplier_id` int(11) default NULL,
  `branch` int(11) default NULL,
  `pc_center` int(11) default NULL,
  `credit_option` varchar(50) default NULL,
  `monthly_fees` decimal(20,4) default NULL,
  PRIMARY KEY  (`pkid`),
  UNIQUE KEY `acc_code` (`acc_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `cust_account_index`
--
INSERT INTO `cust_account_index` (`pkid`,`acc_code`,`name`,`description`,`acc_type`,`status`,`last_edit`,`userid_edit`,`username`,`password`,`name_first`,`name_last`,`nickname`,`title`,`designation`,`identity_number`,`main_address1`,`main_address2`,`main_address3`,`main_city`,`main_postcode`,`main_state`,`main_country`,`ship_address1`,`ship_address2`,`ship_address3`,`ship_city`,`ship_postcode`,`ship_state`,`ship_country`,`bill_address1`,`bill_address2`,`bill_address3`,`bill_city`,`bill_postcode`,`bill_state`,`bill_country`,`telephone1`,`telephone2`,`home_phone`,`mobile_phone`,`fax_no`,`homepage`,`email1`,`email2`,`email3`,`credit_limit`,`credit_terms`,`property1`,`property2`,`property3`,`property4`,`property5`,`note`,`salesman`,`state`,`dealer_code`,`factor_pricing`,`factor_discount`,`pricing_logic`,`pricing_scheme`,`area_code`,`dept_code`,`supplier_id`,`branch`,`pc_center`,`credit_option`,`monthly_fees`) VALUES 
 (500,'cash','Cash','This is meant for one time customers that pay cash',20,'active','2001-01-01 00:00:01',500,'','','','','','','','','','','','','','','','','','','','','','','','','','','','','','-','-','-','-','-','','','','','10000000.0000',0,'','','','','','',0,'OK','','0.0000','0.0000','','','','',0,0,0,'','0.0000');

--
-- Definition of table `cust_invoice_index`
--
CREATE TABLE `cust_invoice_index` (
  `pkid` bigint(20) NOT NULL,
  `stmt_no` bigint(20) default NULL,
  `sales_txn_id` bigint(20) default NULL,
  `time_issued` timestamp NOT NULL default '0000-00-00 00:00:00',
  `currency` varchar(3) default NULL,
  `ccy_pair` varchar(6) default NULL,
  `xrate` decimal(32,12) default NULL,
  `payment_terms_id` int(11) default NULL,
  `total_amt` decimal(20,4) default NULL,
  `outstanding_amt` decimal(20,4) default NULL,
  `outstanding_bf_pdc` decimal(20,4) default NULL,
  `remarks` text default NULL,
  `state` varchar(20) default NULL,
  `status` varchar(20) default NULL,
  `userid_edit` int(11) default NULL,
  `lastupdate` timestamp NOT NULL default '0000-00-00 00:00:00',
  `entity_table` varchar(50) default NULL,
  `entity_key` int(11) default NULL,
  `entity_name` text default NULL,
  `entity_code` varchar(50) default NULL,
  `identity_number` varchar(30) default NULL,
  `entity_contact_person` varchar(100) default NULL,
  `foreign_table` varchar(50) default NULL,
  `foreign_key` int(11) default NULL,
  `foreign_text` varchar(50) default NULL,
  `cust_svcctr_id` int(11) default NULL,
  `location_id` int(11) default NULL,
  `pc_center` int(11) default NULL,
  `txntype` varchar(20) default NULL,
  `stmt_type` varchar(20) default NULL,
  `reference_no` varchar(100) default NULL,
  `description` varchar(500) default NULL,
  `work_order` bigint(20) default NULL,
  `delivery_order` bigint(20) default NULL,
  `receipt_id` bigint(20) default NULL,
  `display_format` varchar(100) default NULL,
  `doc_type` varchar(30) default NULL,
  `billing_handphone` varchar(30) default NULL,
  `billing_phone1` varchar(30) default NULL,
  `billing_phone2` varchar(30) default NULL,
  `billing_fax` varchar(30) default NULL,
  `billing_email` varchar(255) default NULL,
  `billing_company_name` varchar(100) default NULL,
  `billing_add1` varchar(100) default NULL,
  `billing_add2` varchar(100) default NULL,
  `billing_add3` varchar(100) default NULL,
  `billing_city` varchar(100) default NULL,
  `billing_zip` varchar(20) default NULL,
  `billing_state` varchar(20) default NULL,
  `billing_country` varchar(40) default NULL,
  `receiver_name` varchar(100) default NULL,
  `receiver_handphone` varchar(30) default NULL,
  `receiver_phone1` varchar(30) default NULL,
  `receiver_phone2` varchar(30) default NULL,
  `receiver_fax` varchar(30) default NULL,
  `receiver_email` varchar(255) default NULL,
  `receiver_company_name` varchar(100) default NULL,
  `receiver_add1` varchar(100) default NULL,
  `receiver_add2` varchar(100) default NULL,
  `receiver_add3` varchar(100) default NULL,
  `receiver_city` varchar(100) default NULL,
  `receiver_zip` varchar(20) default NULL,
  `receiver_state` varchar(20) default NULL,
  `receiver_country` varchar(40) default NULL,
  `terms1_option` varchar(30) default NULL,
  `terms1_date` timestamp NOT NULL default '0000-00-00 00:00:00',
  `terms1_disc_pct` decimal(20,4) default NULL,
  `terms1_disc_amt` decimal(20,4) default NULL,
  `terms2_option` varchar(30) default NULL,
  `terms2_date` timestamp NOT NULL default '0000-00-00 00:00:00',
  `terms2_disc_pct` decimal(20,4) default NULL,
  `terms2_disc_amt` decimal(20,4) default NULL,
  `rebate1_option` varchar(30) default NULL,
  `rebate1_date` timestamp NOT NULL default '0000-00-00 00:00:00',
  `rebate1_gain` decimal(20,4) default NULL,
  `rebate1_consume` decimal(20,4) default NULL,
  `rebate2_option` varchar(30) default NULL,
  `rebate2_date` timestamp NOT NULL default '0000-00-00 00:00:00',
  `rebate2_gain` decimal(20,4) default NULL,
  `rebate2_consume` decimal(20,4) default NULL,
  `code_dept` varchar(50) default NULL,
  `code_project` varchar(50) default NULL,
  `code_supplier` varchar(50) default NULL,
  `sales_id` int(11) default NULL,
  `tracking_no` varchar(100) default NULL,
  `guid` varchar(50) default NULL,
  `tax_amount` decimal(20,4) default NULL,
  `tax_type` varchar(50) default NULL,
  `subtype1` varchar(30) default NULL,
  `subtype2` varchar(30) default NULL,
  `subtype3` varchar(30) default NULL,
  `time_accident` timestamp NOT NULL default '0000-00-00 00:00:00',
  `claim_amount` decimal(20,4) default NULL,
  `policy_number` varchar(30) default NULL,
  `loyalty_card_status` varchar(10) default NULL,
  `loyalty_card_pkid` bigint(20) default NULL,
  `tc_stmt_no` varchar(50) default NULL,
  `loyalty_process_status` varchar(15) default NULL,
  `loyalty_process_reversal_status` varchar(15) default NULL,
  `loyalty_points_awarded` decimal(20,4) default NULL,
  `loyalty_points_redeemed` decimal(20,4) default NULL,
  `loyalty_jtxn_status` varchar(15) default NULL,
  `loyalty_jtxn_reversal_status` varchar(15) default NULL,
  `currency2` varchar(3) default NULL,
  `total_amt2` decimal(20,4) default NULL,
  `outstanding_amt2` decimal(20,4) default NULL,
  `tax_amount2` decimal(20,4) default NULL,
  `incoterms` varchar(100) default NULL,
  `permit_no` text default NULL,
  `permit_doc1` text default NULL,
  `permit_doc2` text default NULL,
  `permit_doc3` text default NULL,
  `txn_doc1` text default NULL,
  `txn_doc2` text default NULL,
  `txn_doc3` text default NULL,
  `transport_doc1` text default NULL,
  `transport_doc2` text default NULL,
  `transport_doc3` text default NULL,
  `transport_date` timestamp NOT NULL default '0000-00-00 00:00:00',
  `traders_remarks` varchar(5000) default NULL,
  `synchro_key` varchar(50) default NULL,
  `membershipcard_pkid` bigint(20) default '0',
  `group_discount` decimal(20,4) default '0.0000',
  `consignment_id` bigint(20) default '0',
  `pos_id` int(11) default '0',
  PRIMARY KEY  (`pkid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `cust_invoice_index`
--

--
-- Definition of table `cust_invoice_item`
--
CREATE TABLE `cust_invoice_item` (
  `pkid` bigint(20) NOT NULL,
  `invoice_id` bigint(20) default NULL,
  `pos_item_id` int(11) default NULL,
  `remarks` varchar(3000) default NULL,
  `total_quantity` decimal(20,4) default NULL,
  `currency` varchar(3) default NULL,
  `unit_price_quoted` decimal(20,4) default NULL,
  `str_name_1` varchar(50) default NULL,
  `str_value_1` varchar(100) default NULL,
  `pic1` int(11) default NULL,
  `pic2` int(11) default NULL,
  `pic3` int(11) default NULL,
  `currency2` varchar(3) default NULL,
  `unit_price_quoted2` decimal(20,4) default NULL,
  `taxamt` decimal(20,4) default NULL,
  `taxamt2` decimal(20,4) default NULL,
  `str_name_2` varchar(50) default NULL,
  `str_value_2` varchar(100) default NULL,
  `str_name_3` varchar(50) default NULL,
  `str_value_3` varchar(100) default NULL,
  `int_name_1` varchar(50) default NULL,
  `int_value_1` int(11) default NULL,
  `int_name_2` varchar(50) default NULL,
  `int_value_2` int(11) default NULL,
  `bd_name_1` varchar(50) default NULL,
  `bd_value_1` decimal(20,4) default NULL,
  `status` varchar(10) default NULL,
  `state` varchar(20) default NULL,
  `pos_item_type` varchar(20) default NULL,
  `item_id` int(11) default NULL,
  `item_code` varchar(50) default NULL,
  `bar_code` varchar(50) default NULL,
  `serialized` tinyint(1) default NULL,
  `name` text default NULL,
  `outstanding_qty` decimal(20,4) default NULL,
  `package` tinyint(1) default NULL,
  `parent_id` bigint(20) default NULL,
  `unit_cost_ma` decimal(20,4) default NULL,
  `unit_price_std` decimal(20,4) default NULL,
  `unit_price_std2` decimal(20,4) default NULL,
  `unit_discount` decimal(20,4) default NULL,
  `unit_commission` decimal(20,4) default NULL,
  `code_project` varchar(50) default NULL,
  `code_department` varchar(50) default NULL,
  `code_dealer` varchar(50) default NULL,
  `code_salesman` varchar(50) default NULL,
  `stk_id` int(11) default NULL,
  `stk_location_id` int(11) default NULL,
  `stk_location_code` varchar(50) default NULL,
  `bom_convert_mode` varchar(50) default NULL,
  `bom_id` int(11) default NULL,
  `bom_convert_status` varchar(20) default NULL,
  `bom_convert_time` timestamp NOT NULL default '0000-00-00 00:00:00',
  `bom_convert_user` int(11) default NULL,
  `bom_target_loc` int(11) default NULL,
  `bom_source_loc` int(11) default NULL,
  `warranty_type` varchar(50) default NULL,
  `warranty_option` varchar(50) default NULL,
  `warranty_expiry` timestamp NOT NULL default '0000-00-00 00:00:00',
  `pseudo_logic` varchar(50) default NULL,
  `pseudo_code` varchar(50) default NULL,
  `pseudo_name` text default NULL,
  `pseudo_description` text default NULL,
  `pseudo_currency` varchar(3) default NULL,
  `pseudo_price` decimal(20,4) default NULL,
  `pseudo_qty` decimal(20,4) default NULL,
  `package_group` varchar(50) default 'NONE',
  `loyalty_logic` varchar(50) default NULL,
  `loyalty_points_awarded` decimal(20,4) default NULL,
  `loyalty_points_redeemed` decimal(20,4) default NULL,
  `loyalty_process_status` varchar(15) default NULL,
  `loyalty_process_reversal_status` varchar(15) default NULL,
  `loyalty_jtxn_status` varchar(15) default NULL,
  `loyalty_jtxn_reversal_status` varchar(15) default NULL,
  `jobsheet_index_pkid` bigint(20) default NULL,
  `unit_discount2` decimal(20,4) default NULL,
  `date_start` timestamp NOT NULL default '0000-00-00 00:00:00',
  `date_end` timestamp NOT NULL default '0000-00-00 00:00:00',
  `tax_code` varchar(100) default NULL,
  `tax_type` varchar(100) default NULL,
  `tax_rate` decimal(20,4) default NULL,
  `jobsheet_item_id` bigint(20) default '0',
  `tax_option` varchar(50) default '',
  `uom` varchar(50) default '',
  `serial_numbers` text default '',
  PRIMARY KEY  (`pkid`),
  KEY `fk_invoice_id` (`invoice_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `cust_invoice_item`
--

--
-- Definition of table `cust_jobsheet_index`
--
CREATE TABLE `cust_jobsheet_index` (
  `pkid` bigint(20) NOT NULL,
  `stmt_no` bigint(20) default NULL,
  `branch` int(11) default NULL,
  `location` int(11) default NULL,
  `pc_center` int(11) default NULL,
  `guid` varchar(50) default NULL,
  `txn_type` varchar(20) default NULL,
  `display_format` varchar(30) default NULL,
  `doc_type` varchar(30) default NULL,
  `reference_no` varchar(100) default NULL,
  `remarks` text default NULL,
  `description` varchar(300) default NULL,
  `sales_txn_id` bigint(20) default NULL,
  `time_created` timestamp NOT NULL default '0000-00-00 00:00:00',
  `time_complete` timestamp NOT NULL default '0000-00-00 00:00:00',
  `userid_supervisor` int(11) default NULL,
  `userid_technician` int(11) default NULL,
  `payment_terms_id` int(11) default NULL,
  `currency` varchar(3) default NULL,
  `amount_total` decimal(20,4) default NULL,
  `amount_outstanding` decimal(20,4) default NULL,
  `amount_outstanding_bf_pdc` decimal(20,4) default NULL,
  `currency2` varchar(3) default NULL,
  `amount_total2` decimal(20,4) default NULL,
  `amount_outstanding2` decimal(20,4) default NULL,
  `amount_outstanding_bf_pdc2` decimal(20,4) default NULL,
  `entity_table` varchar(50) default NULL,
  `entity_key` int(11) default NULL,
  `entity_name` text default NULL,
  `entity_type` varchar(20) default NULL,
  `identity_number` varchar(30) default NULL,
  `entity_contact_person` varchar(100) default NULL,
  `foreign_table` varchar(50) default NULL,
  `foreign_key` int(11) default NULL,
  `foreign_text` varchar(50) default NULL,
  `billing_handphone` varchar(30) default NULL,
  `billing_phone1` varchar(30) default NULL,
  `billing_phone2` varchar(30) default NULL,
  `billing_fax` varchar(30) default NULL,
  `billing_email` varchar(255) default NULL,
  `billing_company_name` varchar(100) default NULL,
  `billing_add1` varchar(100) default NULL,
  `billing_add2` varchar(100) default NULL,
  `billing_add3` varchar(100) default NULL,
  `billing_city` varchar(100) default NULL,
  `billing_zip` varchar(20) default NULL,
  `billing_state` varchar(20) default NULL,
  `billing_country` varchar(40) default NULL,
  `receiver_name` varchar(100) default NULL,
  `receiver_handphone` varchar(30) default NULL,
  `receiver_phone1` varchar(30) default NULL,
  `receiver_phone2` varchar(30) default NULL,
  `receiver_fax` varchar(30) default NULL,
  `receiver_email` varchar(255) default NULL,
  `receiver_company_name` varchar(100) default NULL,
  `receiver_add1` varchar(100) default NULL,
  `receiver_add2` varchar(100) default NULL,
  `receiver_add3` varchar(100) default NULL,
  `receiver_city` varchar(100) default NULL,
  `receiver_zip` varchar(20) default NULL,
  `receiver_state` varchar(20) default NULL,
  `receiver_country` varchar(40) default NULL,
  `code_dept` varchar(50) default NULL,
  `code_project` varchar(50) default NULL,
  `code_supplier` varchar(50) default NULL,
  `sales_id` int(11) default NULL,
  `tracking_no` varchar(100) default NULL,
  `tax_amount` decimal(20,4) default NULL,
  `tax_type` varchar(50) default NULL,
  `js_type` varchar(20) default NULL,
  `state` varchar(20) default NULL,
  `status` varchar(20) default NULL,
  `last_update` timestamp NOT NULL default '0000-00-00 00:00:00',
  `userid_edit` int(11) default NULL,
  `mileage_latest` decimal(20,4) default NULL,
  `mileage_next` decimal(20,4) default NULL,
  `repair_last` timestamp NOT NULL default '0000-00-00 00:00:00',
  `repair_next` timestamp NOT NULL default '0000-00-00 00:00:00',
  `time_accident` timestamp NOT NULL default '0000-00-00 00:00:00',
  `claim_amount` decimal(20,4) default NULL,
  `incoterms` varchar(100) default NULL,
  `permit_no` text default NULL,
  `permit_doc1` text default NULL,
  `permit_doc2` text default NULL,
  `permit_doc3` text default NULL,
  `txn_doc1` text default NULL,
  `txn_doc2` text default NULL,
  `txn_doc3` text default NULL,
  `transport_doc1` text default NULL,
  `transport_doc2` text default NULL,
  `transport_doc3` text default NULL,
  `transport_date` timestamp NOT NULL default '0000-00-00 00:00:00',
  `traders_remarks` varchar(5000) default NULL,
  `collection_method` varchar(50) default NULL,
  `policy_number` varchar(30) default NULL,
  `pickup_name` varchar(100) default NULL,
  `pickup_handphone` varchar(30) default NULL,
  `pickup_phone1` varchar(30) default NULL,
  `pickup_phone2` varchar(30) default NULL,
  `pickup_fax` varchar(30) default NULL,
  `pickup_email` varchar(255) default NULL,
  `pickup_company_name` varchar(100) default NULL,
  `pickup_add1` varchar(100) default NULL,
  `pickup_add2` varchar(100) default NULL,
  `pickup_add3` varchar(100) default NULL,
  `pickup_city` varchar(100) default NULL,
  `pickup_zip` varchar(20) default NULL,
  `pickup_state` varchar(20) default NULL,
  `pickup_country` varchar(40) default NULL,
  `synchro_key` varchar(50) default NULL,
  PRIMARY KEY  (`pkid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `cust_jobsheet_index`
--

--
-- Definition of table `cust_jobsheet_item`
--
CREATE TABLE `cust_jobsheet_item` (
  `pkid` bigint(20) NOT NULL,
  `index_id` bigint(20) default NULL,
  `item_type` varchar(50) default NULL,
  `item_id` int(11) default NULL,
  `item_code` varchar(50) default NULL,
  `bar_code` varchar(50) default NULL,
  `serialized` tinyint(1) default NULL,
  `name` text default NULL,
  `is_package` tinyint(1) default NULL,
  `parent_id` bigint(20) default NULL,
  `position` int(11) default NULL,
  `remarks` varchar(3000) default NULL,
  `description` varchar(3000) default NULL,
  `pic1` int(11) default NULL,
  `pic2` int(11) default NULL,
  `pic3` int(11) default NULL,
  `quantity` decimal(20,4) default NULL,
  `currency` varchar(3) default NULL,
  `unit_price_list` decimal(20,4) default NULL,
  `unit_discount` decimal(20,4) default NULL,
  `unit_price_net` decimal(20,4) default NULL,
  `tax_type` varchar(50) default NULL,
  `unit_tax` decimal(20,4) default NULL,
  `currency2` varchar(3) default NULL,
  `unit_price_list2` decimal(20,4) default NULL,
  `unit_discount2` decimal(20,4) default NULL,
  `unit_price_net2` decimal(20,4) default NULL,
  `tax_type2` varchar(50) default NULL,
  `unit_tax2` decimal(20,4) default NULL,
  `unit_cost_ma` decimal(20,4) default NULL,
  `unit_price_std` decimal(20,4) default NULL,
  `unit_commission` decimal(20,4) default NULL,
  `code_project` varchar(50) default NULL,
  `code_department` varchar(50) default NULL,
  `code_dealer` varchar(50) default NULL,
  `code_salesman` varchar(50) default NULL,
  `stk_id` int(11) default NULL,
  `stk_location_id` int(11) default NULL,
  `stk_location_code` varchar(50) default NULL,
  `bom_convert_mode` varchar(50) default NULL,
  `bom_id` int(11) default NULL,
  `bom_convert_status` varchar(20) default NULL,
  `bom_convert_time` timestamp NOT NULL default '0000-00-00 00:00:00',
  `bom_convert_user` int(11) default NULL,
  `bom_target_loc` int(11) default NULL,
  `bom_source_loc` int(11) default NULL,
  `warranty_type` varchar(50) default NULL,
  `warranty_option` varchar(50) default NULL,
  `warranty_expiry` timestamp NOT NULL default '0000-00-00 00:00:00',
  `status` varchar(10) default NULL,
  `pseudo_logic` varchar(50) default NULL,
  `pseudo_code` varchar(50) default NULL,
  `pseudo_name` text default NULL,
  `pseudo_description` varchar(3000) default NULL,
  `pseudo_currency` varchar(3) default NULL,
  `pseudo_price` decimal(20,4) default NULL,
  `pseudo_qty` decimal(20,4) default NULL,
  `loyalty_logic` varchar(50) default NULL,
  `loyalty_points_awarded` decimal(20,4) default NULL,
  `loyalty_points_redeemed` decimal(20,4) default NULL,
  `package_group` varchar(50) default NULL,
  `expiry_status` varchar(100) default NULL,
  `tax_code` varchar(100) default NULL,
  `tax_rate` decimal(20,4) default NULL,
  `taxamt2` decimal(20,4) default '0.0000',
  `taxamt` decimal(20,4) default '0.0000',
  `tax_option` varchar(50) default '',
  PRIMARY KEY  (`pkid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `cust_jobsheet_item`
--

--
-- Definition of table `cust_user_index`
--
CREATE TABLE `cust_user_index` (
  `pkid` int(11) NOT NULL,
  `username` varchar(255) default NULL,
  `password` varchar(50) default NULL,
  `namefirst` varchar(50) default NULL,
  `namelast` varchar(50) default NULL,
  `acc_id` int(11) default NULL,
  `dob` timestamp NOT NULL default '0000-00-00 00:00:00',
  `expiry` timestamp NOT NULL default '0000-00-00 00:00:00',
  `title` varchar(20) default NULL,
  `designation` varchar(30) default NULL,
  `sex` varchar(10) default NULL,
  `ethnic` varchar(20) default NULL,
  `reference_no` varchar(30) default NULL,
  `ic_type` varchar(30) default NULL,
  `main_address1` varchar(100) default NULL,
  `main_address2` varchar(100) default NULL,
  `main_address3` varchar(100) default NULL,
  `main_city` varchar(100) default NULL,
  `main_postcode` varchar(20) default NULL,
  `main_state` varchar(20) default NULL,
  `main_country` varchar(40) default NULL,
  `telephone1` varchar(30) default NULL,
  `telephone2` varchar(30) default NULL,
  `home_phone` varchar(30) default NULL,
  `mobile_phone` varchar(30) default NULL,
  `fax_no` varchar(30) default NULL,
  `homepage` varchar(255) default NULL,
  `email1` varchar(255) default NULL,
  `email2` varchar(255) default NULL,
  `email3` varchar(255) default NULL,
  `preference` text default NULL,
  `default_payment_mode` varchar(50) default '',
  `default_card_type` varchar(50) default '',
  `default_card_bank` varchar(50) default '',
  `default_card_name` varchar(100) default '',
  `default_card_number` varchar(50) default '',
  `default_card_security_number` varchar(20) default '',
  `default_card_valid_from` timestamp NOT NULL default '2001-01-01 00:00:00',
  `default_card_good_thru` timestamp NOT NULL default '2001-01-01 00:00:00',
  `loyalty_card_name1` varchar(50) default NULL,
  `loyalty_card_number1` varchar(50) default NULL,
  `loyalty_card_name2` varchar(50) default NULL,
  `loyalty_card_number2` varchar(50) default NULL,
  `loyalty_card_name3` varchar(50) default NULL,
  `loyalty_card_number3` varchar(50) default NULL,
  `loyalty_card_name4` varchar(50) default NULL,
  `loyalty_card_number4` varchar(50) default NULL,
  `security_check` varchar(20) default NULL,
  `state` varchar(20) default NULL,
  `status` varchar(20) default NULL,
  `lastupdate` timestamp NOT NULL default '0000-00-00 00:00:00',
  `userid_edit` int(11) default NULL,
  `nationality` varchar(50) default NULL,
  `marital_status` varchar(50) default NULL,
  `education_level` varchar(100) default NULL,
  `gross_household_income` varchar(100) default NULL,
  `profession` varchar(100) default NULL,
  `household_number` int(11) default NULL,
  `household_junior` int(11) default NULL,
  `household_senior` int(11) default NULL,
  `contact_address1` varchar(100) default NULL,
  `contact_address2` varchar(100) default NULL,
  `contact_address3` varchar(100) default NULL,
  `contact_city` varchar(100) default NULL,
  `contact_postcode` varchar(20) default NULL,
  `contact_state` varchar(20) default NULL,
  `contact_country` varchar(40) default NULL,
  `business_address1` varchar(100) default NULL,
  `business_address2` varchar(100) default NULL,
  `business_address3` varchar(100) default NULL,
  `business_city` varchar(100) default NULL,
  `business_postcode` varchar(20) default NULL,
  `business_state` varchar(20) default NULL,
  `business_country` varchar(40) default NULL,
  `business_nature` varchar(100) default NULL,
  `salesman` int(11) default NULL,
  `credit_terms` int(11) default NULL,
  PRIMARY KEY  (`pkid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `cust_user_index`
--

--
-- Definition of table `inv_category_tree`
--
CREATE TABLE `inv_category_tree` (
  `pkid` bigint(20) NOT NULL,
  `parent_id` bigint(20) default NULL,
  `cat_level` int(11) default NULL,
  `code` varchar(36) default NULL,
  `sort` varchar(20) default NULL,
  `name` varchar(100) default NULL,
  `description` varchar(500) default NULL,
  PRIMARY KEY  (`pkid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `inv_category_tree`
--

--
-- Definition of table `inv_item`
--
CREATE TABLE `inv_item` (
  `pkid` int(11) NOT NULL,
  `item_code` varchar(50) default NULL,
  `name` text default NULL,
  `description` varchar(3000) default NULL,
  `status` varchar(20) default NULL,
  `lastupdate` timestamp NOT NULL default '0000-00-00 00:00:00',
  `userid_edit` int(11) default NULL,
  `uom` varchar(20) default NULL,
  `unit_of_meas` int(11) default NULL,
  `inv_type` int(11) default NULL,
  `item_type1` varchar(50) default NULL,
  `item_type2` varchar(50) default NULL,
  `item_type3` varchar(50) default NULL,
  `glcode` varchar(50) default NULL,
  `state` varchar(20) default NULL,
  `categoryid` int(11) default NULL,
  `category1` varchar(36) default NULL,
  `category2` varchar(36) default NULL,
  `category3` varchar(36) default NULL,
  `category4` varchar(36) default NULL,
  `category5` varchar(36) default NULL,
  `has_children` tinyint(1) default NULL,
  `parentid` int(11) default NULL,
  `parent_ratio` decimal(20,4) default NULL,
  `ean_code` varchar(100) default NULL,
  `upc_code` varchar(100) default NULL,
  `isbn_code` varchar(100) default NULL,
  `price_list` decimal(20,4) default NULL,
  `price_sale` decimal(20,4) default NULL,
  `price_disc1` decimal(20,4) default NULL,
  `price_disc2` decimal(20,4) default NULL,
  `price_disc3` decimal(20,4) default NULL,
  `price_min` decimal(20,4) default NULL,
  `fifo_unit_cost` decimal(20,4) default NULL,
  `ma_unit_cost` decimal(20,4) default NULL,
  `wa_unit_cost` decimal(20,4) default NULL,
  `last_unit_cost` decimal(20,4) default NULL,
  `replacement_cost` decimal(20,4) default NULL,
  `serialized` tinyint(1) default NULL,
  `weight` decimal(20,4) default NULL,
  `length` decimal(20,4) default NULL,
  `width` decimal(20,4) default NULL,
  `depth` decimal(20,4) default NULL,
  `preferred_supplier` int(11) default NULL,
  `min_order_qty` decimal(20,4) default NULL,
  `lead_time` bigint(20) default NULL,
  `reserved1` varchar(36) default NULL,
  `reserved2` varchar(36) default NULL,
  `reserved3` varchar(36) default NULL,
  `pix_thumb_name` varchar(100) default '',
  `pix_full_name` varchar(100) default '',
  `pix_thumbnail` text default '',
  `pix_fullsize` text default '',
  `rebate1_pct` decimal(20,4) default '0.0000',
  `rebate1_price` decimal(20,4) default '0.0000',
  `rebate1_start` timestamp NOT NULL default '0000-00-00 00:00:00',
  `rebate1_end` timestamp NOT NULL default '0000-00-00 00:00:00',
  `disc1_pct` decimal(20,4) default '0.0000',
  `disc1_amount` decimal(20,4) default '0.0000',
  `disc1_start` timestamp NOT NULL default '0000-00-00 00:00:00',
  `disc1_end` timestamp NOT NULL default '0000-00-00 00:00:00',
  `production_required` tinyint(1) default NULL,
  `production_lead_time` bigint(20) default NULL,
  `production_cost` decimal(20,4) default NULL,
  `production_process` varchar(50) default NULL,
  `production_name` varchar(100) default NULL,
  `production_description` varchar(300) default NULL,
  `delivery_required` tinyint(1) default NULL,
  `delivery_lead_time` bigint(20) default NULL,
  `delivery_cost` decimal(20,4) default NULL,
  `delivery_process` varchar(50) default NULL,
  `delivery_name` varchar(100) default NULL,
  `delivery_description` varchar(300) default NULL,
  `delta_price_retail_amt` decimal(20,4) default NULL,
  `delta_price_retail_pct` decimal(20,4) default NULL,
  `delta_price_dealer_amt` decimal(20,4) default NULL,
  `delta_price_dealer_pct` decimal(20,4) default NULL,
  `delta_price_outlet_amt` decimal(20,4) default NULL,
  `delta_price_outlet_pct` decimal(20,4) default NULL,
  `disc_max_pct` decimal(20,4) default NULL,
  `warranty_type` varchar(20) default NULL,
  `warranty_period` int(11) default NULL,
  `shelf_life` int(11) default NULL,
  `commission_pct_sales1` decimal(20,4) default NULL,
  `commission_pct_sales2` decimal(20,4) default NULL,
  `commission_pct_sales3` decimal(20,4) default NULL,
  `commission_pct_sales4` decimal(20,4) default NULL,
  `commission_pct_partner` decimal(20,4) default NULL,
  `commission_pct_gp` decimal(20,4) default NULL,
  `logic_reorder` varchar(20) default NULL,
  `logic_max_qty` varchar(20) default NULL,
  `threshold_qty_reorder` decimal(20,4) default NULL,
  `threshold_qty_max_qty` decimal(20,4) default NULL,
  `remarks1` varchar(500) default NULL,
  `remarks2` varchar(500) default NULL,
  `keywords` varchar(500) default NULL,
  `prefix_logic` varchar(20) default NULL,
  `prefix_length` int(11) default NULL,
  `prefix_code` varchar(50) default NULL,
  `postfix_logic` varchar(20) default NULL,
  `postfix_length` int(11) default NULL,
  `postfix_code` varchar(50) default NULL,
  `code_project` varchar(50) default NULL,
  `code_department` varchar(50) default NULL,
  `code_dealer` varchar(50) default NULL,
  `code_salesman` varchar(50) default NULL,
  `tax_option` varchar(50) default NULL,
  `tax_rate` decimal(20,4) default NULL,
  `price_ecom` decimal(20,4) default NULL,
  `out_qty` decimal(20,4) default '0.0000',
  `out_unit` varchar(50) default '',
  `in_qty` decimal(20,4) default '0.0000',
  `in_unit` varchar(50) default '',
  `inn_qty` decimal(20,4) default '0.0000',
  `inn_unit` varchar(50) default '',
  `inm_qty` decimal(20,4) default '0.0000',
  `inm_unit` varchar(50) default '',
  `purchase_price_minimum` decimal(20,4) default '0.0000',
  `purchase_price_maximum` decimal(20,4) default '0.0000',
  `tax_code` varchar(100) default '',
  `tax_type` varchar(100) default '',
  `next_service_minute` int(11) default NULL,
  `next_service_hour` int(11) default NULL,
  `next_service_day` int(11) default NULL,
  `next_service_month` int(11) default NULL,
  `next_service_year` int(11) default NULL,
  `next_service_usage` decimal(20,4) default '0.0000',
  PRIMARY KEY  (`pkid`),
  UNIQUE KEY `item_code` (`item_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `inv_item`
--

--
-- Definition of table `inv_serial_number_delta`
--
CREATE TABLE `inv_serial_number_delta` (
  `guid` varchar(36) NOT NULL,
  `parent_guid` varchar(36) default NULL,
  `namespace` varchar(50) default NULL,
  `tx_type` varchar(50) default NULL,
  `tx_code` varchar(50) default NULL,
  `serial` varchar(100) default NULL,
  `person_in_charge` int(11) default NULL,
  `process_node` int(11) default NULL,
  `stockid` int(11) default NULL,
  `itemcode` varchar(50) default NULL,
  `ref_stockid` int(11) default NULL,
  `itemid` int(11) default NULL,
  `qty` decimal(20,4) default NULL,
  `currency` varchar(3) default NULL,
  `unit_price` decimal(20,4) default NULL,
  `currency2` varchar(3) default NULL,
  `unit_price2` decimal(20,4) default NULL,
  `tx_time` timestamp NOT NULL default '0000-00-00 00:00:00',
  `sch_time` timestamp NOT NULL default '0000-00-00 00:00:00',
  `warranty_start` timestamp NOT NULL default '0000-00-00 00:00:00',
  `warranty_end` timestamp NOT NULL default '0000-00-00 00:00:00',
  `remarks` varchar(250) default NULL,
  `int_reserved1` int(11) default NULL,
  `str_reserved1` varchar(100) default NULL,
  `str_reserved2` varchar(100) default NULL,
  `str_reserved3` varchar(100) default NULL,
  `str_reserved4` varchar(100) default NULL,
  `entity_table` varchar(100) default NULL,
  `entity_id` int(11) default NULL,
  `doc_table` varchar(100) default NULL,
  `doc_key` bigint(20) default NULL,
  `state` varchar(20) default NULL,
  `status` varchar(20) default NULL,
  `userid_edit` int(11) default NULL,
  `time_edit` timestamp NOT NULL default '0000-00-00 00:00:00',
  `stock_delta` bigint(20) default NULL,
  `loyalty_logic` varchar(50) default NULL,
  `loyalty_points_awarded` decimal(20,4) default NULL,
  `loyalty_points_redeemed` decimal(20,4) default NULL,
  PRIMARY KEY  (`guid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `inv_serial_number_delta`
--

--
-- Definition of table `inv_stock`
--
CREATE TABLE `inv_stock` (
  `guid` varchar(36) default NULL,
  `pkid` int(11) NOT NULL,
  `stock_code` varchar(50) default NULL,
  `description` varchar(5000) default NULL,
  `itemid` int(11) default NULL,
  `locationid` int(11) default NULL,
  `acc_pccenter_id` int(11) default NULL,
  `pc_center` int(11) default NULL,
  `bal` decimal(20,4) default NULL,
  `conditionid` int(11) default NULL,
  `str_name_1` varchar(50) default NULL,
  `str_value_1` varchar(50) default NULL,
  `int_name_1` varchar(50) default NULL,
  `int_value_1` int(11) default NULL,
  `bd_name_1` varchar(50) default NULL,
  `bd_name_2` varchar(50) default NULL,
  `bd_name_3` varchar(50) default NULL,
  `bd_name_4` varchar(50) default NULL,
  `bd_name_5` varchar(50) default NULL,
  `bd_value_1` decimal(20,4) default NULL,
  `bd_value_2` decimal(20,4) default NULL,
  `bd_value_3` decimal(20,4) default NULL,
  `bd_value_4` decimal(20,4) default NULL,
  `bd_value_5` decimal(20,4) default NULL,
  `status` varchar(20) default NULL,
  `lastupdate` timestamp NOT NULL default '0000-00-00 00:00:00',
  `userid_edit` int(11) default NULL,
  `min_qty` int(11) default NULL,
  `max_qty` int(11) default NULL,
  `unit_cost_fifo` decimal(20,4) default NULL,
  `unit_cost_ma` decimal(20,4) default NULL,
  `unit_cost_wa` decimal(20,4) default NULL,
  `unit_cost_last` decimal(20,4) default NULL,
  `unit_cost_replacement` decimal(20,4) default NULL,
  `last_purchase_date` timestamp NOT NULL default '0000-00-00 00:00:00',
  `sub_location` varchar(50) default NULL,
  PRIMARY KEY  (`pkid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `inv_stock`
--

--
-- Definition of table `pos_cash_in_out`
--
CREATE TABLE `pos_cash_in_out` (
  `pkid` int(11) NOT NULL,
  `branch_id` int(11) default NULL,
  `pos_id` int(11) default NULL,
  `user_id` int(11) default NULL,
  `amount` decimal(20,4) default NULL,
  `remarks` varchar(100) default NULL,
  `status` varchar(20) default NULL,
  `lastupdate` timestamp NOT NULL default '0000-00-00 00:00:00',
  PRIMARY KEY  (`pkid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `pos_cash_in_out`
--

--
-- Definition of table `pos_config`
--
CREATE TABLE `pos_config` (
  `pkid` int(11) NOT NULL,
  `namespace` varchar(50) default NULL,
  `content` varchar(100) default NULL,
  `remarks` varchar(50) default NULL,
  `userid_edit` int(11) default '0',
  `time_edit` timestamp NOT NULL default '0000-00-00 00:00:00',
  `content_file` longblob,
  PRIMARY KEY  (`pkid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `pos_config`
--

--
-- Definition of table `pos_counter`
--
CREATE TABLE `pos_counter` (
  `pkid` int(11) NOT NULL,
  `total_bill` mediumtext,
  PRIMARY KEY  (`pkid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `pos_counter`
--

--
-- Definition of table `pos_doclink`
--
CREATE TABLE `pos_doclink` (
  `pkid` bigint(20) NOT NULL,
  `invoice_id` bigint(20) default NULL,
  `pos_id` int(11) default NULL,
  PRIMARY KEY  (`pkid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `pos_doclink`
--

--
-- Definition of table `pos_end_day_closing`
--
CREATE TABLE `pos_end_day_closing` (
  `pkid` int(11) NOT NULL,
  `branch_id` int(11) default NULL,
  `pos_id` int(11) default NULL,
  `user_id` int(11) default NULL,
  `time_start` timestamp NOT NULL default '0000-00-00 00:00:00',
  `time_end` timestamp NOT NULL default '0000-00-00 00:00:00',
  `qty_bill` int(11) default NULL,
  `qty_item` int(11) default NULL,
  `cash_in` decimal(20,4) default NULL,
  `cash_out` decimal(20,4) default NULL,
  `amount` decimal(20,4) default NULL,
  `status` varchar(20) default NULL,
  `lastupdate` timestamp NOT NULL default '0000-00-00 00:00:00',
  PRIMARY KEY  (`pkid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `pos_end_day_closing`
--

--
-- Definition of table `pos_login`
--
CREATE TABLE `pos_login` (
  `pkid` int(11) NOT NULL,
  `branch_id` int(11) default NULL,
  `pos_id` int(11) default NULL,
  `user_id` int(11) default NULL,
  `time_start` timestamp NOT NULL default '2001-01-01 00:00:00',
  `time_end` timestamp NOT NULL default '2001-01-01 00:00:00',
  `status` varchar(20) default NULL,
  PRIMARY KEY  (`pkid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `pos_login`
--

--
-- Definition of table `pos_permission`
--
CREATE TABLE `pos_permission` (
  `pkid` int(10) unsigned NOT NULL,
  `userid` int(10) unsigned NOT NULL,
  `permission` varchar(100) NOT NULL,
  `value` varchar(45) NOT NULL,
  PRIMARY KEY  (`pkid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `pos_permission`
--

--
-- Definition of table `pos_sync_timing`
--
CREATE TABLE `pos_sync_timing` (
  `pkid` int(10) unsigned NOT NULL,
  `branch_id` int(10) unsigned NOT NULL,
  `pos_id` int(10) unsigned NOT NULL,
  `user_id` int(10) unsigned NOT NULL,
  `time_start` timestamp NOT NULL default '0000-00-00 00:00:00',
  `time_end` timestamp NOT NULL default '0000-00-00 00:00:00',
  `status` varchar(100) NOT NULL,
  PRIMARY KEY  (`pkid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `pos_sync_timing`
--

--
-- Definition of table `tc_tx_queue`
--
CREATE TABLE `tc_tx_queue` (
  `pkid` bigint(20) NOT NULL,
  `pk_string` varchar(50) default NULL,
  `fk_string` varchar(50) default NULL,
  `category` varchar(30) default NULL,
  `source` varchar(30) default NULL,
  `type` varchar(30) default NULL,
  `object_xml` varchar(32000) default NULL,
  `userid` int(11) default NULL,
  `status` varchar(20) default NULL,
  `date_created` timestamp NOT NULL default '0000-00-00 00:00:00',
  `date_received` timestamp NOT NULL default '0000-00-00 00:00:00',
  `date_completed` timestamp NOT NULL default '0000-00-00 00:00:00',
  `branch_id` int(10) unsigned NOT NULL,
  `amount` decimal(20,4) NOT NULL,
  `mode` varchar(50) default NULL,
  PRIMARY KEY  (`pkid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tc_tx_queue`
--

--
-- Definition of table `user_index`
--
CREATE TABLE `user_index` (
  `userid` int(11) NOT NULL,
  `username` varchar(25) default NULL,
  `password` blob,
  `namefirst` varchar(50) default NULL,
  `namelast` varchar(50) default NULL,
  `status` varchar(20) default NULL,
  `password2` varchar(50) default NULL,
  PRIMARY KEY  (`userid`),
  UNIQUE KEY `username` (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `user_index`
--
INSERT INTO `user_index` (`userid`,`username`,`password`,`namefirst`,`namelast`,`status`,`password2`) VALUES 
 (0,'nobody','na','nobody','nobody','default','f9de48a18d041cf0eedc2e4002a2035bba380b97'),
 (500,'developer','96-22-B6-77-FA-9E-12-B9','Developer','Programmer','active','f9de48a18d041cf0eedc2e4002a2035bba380b97'),
 (501,'leehongfay','AE-2A-FA-A0-6E-87-21-D8','Vincent','Lee','hidden','f9de48a18d041cf0eedc2e4002a2035bba380b97');

 
create table app_table_counter
(
    pkid integer primary key,
    category varchar(50),
    modulename varchar(50),
    tablename varchar(50),
    entityname varchar(50),
    foreign_table1 varchar(50),
    foreign_key1 varchar(20),
    foreign_table2 varchar(50),
    foreign_key2 varchar(20),
    flag integer, -- to indicate if row table is currently being updated
    state varchar(20),
    running_number bigint,
    value1 text,
    value2 text,
    value3 text,
    value4 text,
    value5 text,
    binary_data text,
    status varchar(20),
    userid_edit integer,
    time_edit timestamp,
  time_effective timestamp
);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
