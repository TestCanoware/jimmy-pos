Imports Utils.General

Public Class DADocLink

    'Constants for Table field mappings
    Private Const CLASSNAME = "DADocLink"

    Public Const PKID = "pkid"
    Public Const NAME_SPACE = "namespace"
    Public Const REFERENCE = "reference"
    Public Const RELTYPE = "rel_type"
    Public Const SRC_DOCREF = "src_docref"
    Public Const SRC_DOCID = "src_docid"
    Public Const TGT_DOCREF = "tgt_docref"
    Public Const TGT_DOCID = "tgt_docid"
    Public Const CURRENCY = "currency"
    Public Const AMOUNT = "amount"
    Public Const CURRENCY2 = "currency2"
    Public Const AMOUNT2 = "amount2"
    Public Const REMARKS = "remarks"
    Public Const STATUS = "status"
    Public Const LASTUPDATE = "lastupdate"
    Public Const USERID_EDIT = "userid_edit"

    ' Constants for STATUS
    Public Const STATUS_ACTIVE = "active"
    Public Const STATUS_INACTIVE = "inactive"

    ' Constants for NAMESPACE
    Public Const NS_CUSTOMER = "customer"
    Public Const NS_SUPPLIER = "supplier"
    Public Const NS_GENERAL = "general"
    Public Const NS_FINANCE = "finance"
    Public Const NS_SHAREHOLDER = "shareholder"
    Public Const NS_ADMIN = "admin"
    Public Const NS_EMPLOYEE = "employee"
    Public Const NS_MISC = "miscellaneous"

    ' Constants for RELTYPE
    Public Const RELTYPE_PYMT_INV = "payment_inv"
    Public Const JS_CONVERT_INV = "js_convert_inv" 'jobsheet converted to invoice
    Public Const RELTYPE_RP_INV = "rp_inv" ' reverse payment to invoice
    Public Const RELTYPE_RP_PMT = "rp_pmt" ' reverse payment to receipt
    Public Const RELTYPE_PYMT_DN = "payment_dn"
    Public Const RELTYPE_PYMT_CN = "payment_cn"
    Public Const RELTYPE_CN_INV = "cn_inv"
    Public Const RELTYPE_CN_DN = "cn_dn"
    Public Const RELTYPE_REV_PYMT = "rev_payment"
    Public Const RELTYPE_REV_CN = "rev_cn"
    Public Const RELTYPE_DN_INV = "dn_inv"
    Public Const RELTYPE_ADJ = "adj"
    Public Const RELTYPE_PYMT_SR = "payment_sr"  'payment to sales returned
    Public Const RELTYPE_SINV_GRN = "sinv_grn"
    Public Const RELTYPE_PYMT_SINV = "pmt_sinv"
    Public Const RELTYPE_CM_CONTRA = "cm_contra"
    Public Const RELTYPE_PYMT_SO = "pmt_so"
    Public Const RELTYPE_CHEQUE_BANK_IN = "cheque_bank_in"
    Public Const RELTYPE_JS_TO_INVOICE = "js_to_invoice"
    Public Const RELTYPE_BOOKING_TO_INVOICE = "bk_item_to_inv"
    Public Const RELTYPE_SINV_INV = "sinv_inv"
    Public Const RELTYPE_PYMT_PSLIP = "pmt_pslip"
    Public Const RELTYPE_PYMT_INV_DEPOSIT = "payment_inv_deposit"
    Public Const RELTYPE_PYMT_JOBSHEET_DEPOSIT = "payment_js_deposit"

    Public Const TABLENAME = "acc_doclink"
    Public Const NO_OF_COLUMNS As Integer = 16
    Public Const APP_NAME = "ThickClient-DataAccess"
    Public Const START_ID = 1001

    '***************************************************************************
    '* Create
    '**************************************************************************/
    Public Function Create(ByVal obj As DADocLinkObject) As DADocLinkObject

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
    Public Sub Update(ByVal obj As DADocLinkObject)

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
    '* GetObject
    '**************************************************************************/
    Public Function GetObject(ByVal id As Integer) As DADocLinkObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DADocLinkObject = Nothing
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
    Public Function GetObject(ByVal row As DataRow) As DADocLinkObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DADocLinkObject

        Try
            obj = New DADocLinkObject
            obj.pkid = row(PKID)
            obj.name_space = row(NAME_SPACE)
            obj.reference = row(REFERENCE)
            obj.relType = row(RELTYPE)
            obj.srcDocRef = row(SRC_DOCREF)
            obj.srcDocId = row(SRC_DOCID)
            obj.tgtDocRef = row(TGT_DOCREF)
            obj.tgtDocId = row(TGT_DOCID)
            obj.currency = row(CURRENCY)
            obj.amount = row(AMOUNT)
            obj.currency2 = row(CURRENCY2)
            obj.amount2 = row(AMOUNT2)
            obj.remarks = row(REMARKS)
            obj.status = row(STATUS)
            obj.lastUpdate = row(LASTUPDATE)
            obj.userIdUpdate = row(USERID_EDIT)


        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetObject - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetObject")

        Return obj

    End Function


    '***************************************************************************
    '* ReplaceStatement
    '**************************************************************************/
    Public Function ReplaceStatement(ByVal strSQL As String, ByVal obj As DADocLinkObject) As String

        strSQL = strSQL.Replace("{T}", TABLENAME)

        strSQL = strSQL.Replace("{1}", PKID)
        strSQL = strSQL.Replace("{2}", NAME_SPACE)
        strSQL = strSQL.Replace("{3}", REFERENCE)
        strSQL = strSQL.Replace("{4}", RELTYPE)
        strSQL = strSQL.Replace("{5}", SRC_DOCREF)
        strSQL = strSQL.Replace("{6}", SRC_DOCID)
        strSQL = strSQL.Replace("{7}", TGT_DOCREF)
        strSQL = strSQL.Replace("{8}", TGT_DOCID)
        strSQL = strSQL.Replace("{9}", CURRENCY)
        strSQL = strSQL.Replace("{10}", AMOUNT)
        strSQL = strSQL.Replace("{11}", CURRENCY2)
        strSQL = strSQL.Replace("{12}", AMOUNT2)
        strSQL = strSQL.Replace("{13}", REMARKS)
        strSQL = strSQL.Replace("{14}", STATUS)
        strSQL = strSQL.Replace("{15}", LASTUPDATE)
        strSQL = strSQL.Replace("{16}", USERID_EDIT)

        strSQL = strSQL.Replace("{V1}", PreparedStatement(obj.pkid))
        strSQL = strSQL.Replace("{V2}", PreparedStatement(obj.name_space))
        strSQL = strSQL.Replace("{V3}", PreparedStatement(obj.reference))
        strSQL = strSQL.Replace("{V4}", PreparedStatement(obj.relType))
        strSQL = strSQL.Replace("{V5}", PreparedStatement(obj.srcDocRef))
        strSQL = strSQL.Replace("{V6}", PreparedStatement(obj.srcDocId))
        strSQL = strSQL.Replace("{V7}", PreparedStatement(obj.tgtDocRef))
        strSQL = strSQL.Replace("{V8}", PreparedStatement(obj.tgtDocId))
        strSQL = strSQL.Replace("{V9}", PreparedStatement(obj.currency))
        strSQL = strSQL.Replace("{V10}", PreparedStatement(obj.amount))
        strSQL = strSQL.Replace("{V11}", PreparedStatement(obj.currency2))
        strSQL = strSQL.Replace("{V12}", PreparedStatement(obj.amount2))
        strSQL = strSQL.Replace("{V13}", PreparedStatement(obj.remarks))
        strSQL = strSQL.Replace("{V14}", PreparedStatement(obj.status))
        strSQL = strSQL.Replace("{V15}", PreparedStatement(obj.lastUpdate))
        strSQL = strSQL.Replace("{V16}", PreparedStatement(obj.userIdUpdate))
        Return strSQL

    End Function


    '***************************************************************************
    '* GetNextID
    '**************************************************************************/
    Public Function GetNextID() As Long

       Return DAAppTableCounter.GetNextPKID(PKID, TABLENAME, "POS", START_ID)

    End Function


    '***************************************************************************
    '* GetPaymentInvoiceDeposit
    '**************************************************************************/
    Public Function GetPaymentInvoiceDeposit(ByVal invoiceId As Long) As Decimal

        WriteToLogFile(CLASSNAME & " - In GetPaymentInvoiceDeposit")

        Dim comm As New Commands
        Dim strSQL As String
        Dim ds As New DataSet
        Dim amt As Decimal = 0

        strSQL = "SELECT SUM({1}) FROM {T} WHERE {2} = {V2} AND {3} = {V3} AND {4} = {V4} AND {5} = {V5}"

        strSQL = strSQL.Replace("{T}", TABLENAME)
        strSQL = strSQL.Replace("{1}", AMOUNT)
        strSQL = strSQL.Replace("{2}", TGT_DOCREF)
        strSQL = strSQL.Replace("{3}", TGT_DOCID)
        strSQL = strSQL.Replace("{4}", RELTYPE)
        strSQL = strSQL.Replace("{5}", SRC_DOCREF)

        strSQL = strSQL.Replace("{V2}", PreparedStatement(DAInvoice.TABLENAME))
        strSQL = strSQL.Replace("{V3}", PreparedStatement(invoiceId))
        strSQL = strSQL.Replace("{V4}", PreparedStatement(RELTYPE_PYMT_INV_DEPOSIT))
        strSQL = strSQL.Replace("{V5}", PreparedStatement(DAOfficialReceipt.TABLENAME))

        Try
            WriteToLogFile(strSQL)
            ds = comm.ExecuteQuery(strSQL, Commands.ReturnType.DataSetType)
            If ds.Tables(0).Rows.Count > 0 Then
                If ds.Tables(0).Rows(0)(0).ToString <> "" Then
                    amt = ds.Tables(0).Rows(0)(0)
                End If
            End If

            Return amt

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetPaymentInvoiceDeposit - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetPaymentInvoiceDeposit")

    End Function

End Class

