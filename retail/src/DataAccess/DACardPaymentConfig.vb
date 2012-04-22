Imports Utils.General

Public Class DACardPaymentConfig

    'Constants for Table field mappings
    Private Const CLASSNAME = "DACardPaymentConfig"

    Public Const PKID = "pkid"
    Public Const NAME_SPACE = "namespace"
    Public Const SORTCODE = "sortcode"
    Public Const BANK_CODE = "bank_code"
    Public Const BANK_NAME = "bank_name"
    Public Const PAYMENT_MODE = "payment_mode"
    Public Const POLICY_CHARGES = "policy_charges"
    Public Const PCT_CHARGES = "pct_charges"
    Public Const LIMIT_MIN = "limit_min"
    Public Const LIMIT_MAX = "limit_max"
    Public Const PCCENTER_OPT = "pccenter_opt"
    Public Const PCCENTER = "pccenter"
    Public Const BRANCH_OPT = "branch_opt"
    Public Const BRANCH = "branch"
    Public Const CASHBOOK_OPT = "cashbook_opt"
    Public Const CASHBOOK = "cashbook"
    Public Const STATUS = "status"
    Public Const PAYMENT_TYPE = "payment_type"
    Public Const APPROVAL_PARTY = "approval_party"
    Public Const DEFAULT_PAYMENT_STATUS = "default_payment_status"
    Public Const DEFAULT_CARD_TYPE = "default_card_type"
    Public Const DEFAULT_PAYMENT_REMARKS = "default_payment_remarks"
    Public Const PROPERTY1 = "property1"
    Public Const PROPERTY2 = "property2"
    Public Const PROPERTY3 = "property3"
    Public Const CUST_ADMIN_FEE_OPTION = "cust_admin_fee_option"
    Public Const CUST_ADMIN_FEE_ABS = "cust_admin_fee_abs"
    Public Const CUST_ADMIN_FEE_RATIO = "cust_admin_fee_ratio"
    Public Const CUST_ADMIN_FEE_ITEMID = "cust_admin_fee_itemid"
    Public Const CUST_ADMIN_FEE_ROUNDING_MODE = "cust_admin_fee_rounding_mode"
    Public Const CUST_ADMIN_FEE_ROUNDING_SCALE = "cust_admin_fee_rounding_scale"
    Public Const CUST_ADMIN_FEE_MIN_AMOUNT = "cust_admin_fee_min_amount"
    Public Const CUST_ADMIN_FEE_MAX_AMOUNT = "cust_admin_fee_max_amount"
    Public Const ABS_CHARGES = "abs_charges"

    ' Constants for STATUS
    Public Const STATUS_ACTIVE = "active"
    Public Const STATUS_INACTIVE = "inactive"

    Public Const TABLENAME = "acc_card_payment_config"
    Public Const NO_OF_COLUMNS As Integer = 34
    Public Const APP_NAME = "ThickClient-DataAccess"

    '***************************************************************************
    '* Create
    '**************************************************************************/
    Public Function Create(ByVal obj As DACardPaymentConfigObject) As DACardPaymentConfigObject

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
    Public Sub Update(ByVal obj As DACardPaymentConfigObject)

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
    Public Function GetObject(ByVal id As Integer) As DACardPaymentConfigObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DACardPaymentConfigObject = Nothing
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
        strSQL = strSQL.Replace("{1}", BANK_NAME)

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
    Public Function GetObject(ByVal row As DataRow) As DACardPaymentConfigObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DACardPaymentConfigObject

        Try
            obj = New DACardPaymentConfigObject
            obj.pkid = row(PKID)
            obj.name_space = row(NAME_SPACE)
            obj.sortcode = row(SORTCODE)
            obj.bankCode = row(BANK_CODE)
            obj.bankName = row(BANK_NAME)
            obj.paymentMode = row(PAYMENT_MODE)
            obj.policyCharges = row(POLICY_CHARGES)
            obj.pctCharges = row(PCT_CHARGES)
            obj.limitMin = row(LIMIT_MIN)
            obj.limitMax = row(LIMIT_MAX)
            obj.pccenterOpt = row(PCCENTER_OPT)
            obj.pccenter = row(PCCENTER)
            obj.branchOpt = row(BRANCH_OPT)
            obj.branch = row(BRANCH)
            obj.cashbookOpt = row(CASHBOOK_OPT)
            obj.cashbook = row(CASHBOOK)
            obj.status = row(STATUS)
            obj.paymentType = row(PAYMENT_TYPE)
            obj.approvalParty = row(APPROVAL_PARTY)
            obj.defaultPaymentStatus = row(DEFAULT_PAYMENT_STATUS)
            obj.defaultCardType = row(DEFAULT_CARD_TYPE)
            obj.defaultPaymentRemarks = row(DEFAULT_PAYMENT_REMARKS)
            obj.property1 = row(PROPERTY1)
            obj.property2 = row(PROPERTY2)
            obj.property3 = row(PROPERTY3)
            obj.custAdminFeeOption = row(CUST_ADMIN_FEE_OPTION)
            obj.custAdminFeeAbs = row(CUST_ADMIN_FEE_ABS)
            obj.custAdminFeeRatio = row(CUST_ADMIN_FEE_RATIO)
            obj.custAdminFeeItemid = row(CUST_ADMIN_FEE_ITEMID)
            obj.custAdminFeeRoundingMode = row(CUST_ADMIN_FEE_ROUNDING_MODE)
            obj.custAdminFeeRoundingScale = row(CUST_ADMIN_FEE_ROUNDING_SCALE)
            obj.custAdminFeeMinAmount = row(CUST_ADMIN_FEE_MIN_AMOUNT)
            obj.custAdminFeeMaxAmount = row(CUST_ADMIN_FEE_MAX_AMOUNT)
            obj.absCharges = row(ABS_CHARGES)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetObject - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetObject")

        Return obj

    End Function


    Public Function ReplaceStatement(ByVal strSQL As String, ByVal obj As DACardPaymentConfigObject) As String

        strSQL = strSQL.Replace("{T}", TABLENAME)

        strSQL = strSQL.Replace("{1}", PKID)
        strSQL = strSQL.Replace("{2}", NAME_SPACE)
        strSQL = strSQL.Replace("{3}", SORTCODE)
        strSQL = strSQL.Replace("{4}", BANK_CODE)
        strSQL = strSQL.Replace("{5}", BANK_NAME)
        strSQL = strSQL.Replace("{6}", PAYMENT_MODE)
        strSQL = strSQL.Replace("{7}", POLICY_CHARGES)
        strSQL = strSQL.Replace("{8}", PCT_CHARGES)
        strSQL = strSQL.Replace("{9}", LIMIT_MIN)
        strSQL = strSQL.Replace("{10}", LIMIT_MAX)
        strSQL = strSQL.Replace("{11}", PCCENTER_OPT)
        strSQL = strSQL.Replace("{12}", PCCENTER)
        strSQL = strSQL.Replace("{13}", BRANCH_OPT)
        strSQL = strSQL.Replace("{14}", BRANCH)
        strSQL = strSQL.Replace("{15}", CASHBOOK_OPT)
        strSQL = strSQL.Replace("{16}", CASHBOOK)
        strSQL = strSQL.Replace("{17}", STATUS)
        strSQL = strSQL.Replace("{18}", PAYMENT_TYPE)
        strSQL = strSQL.Replace("{19}", APPROVAL_PARTY)
        strSQL = strSQL.Replace("{20}", DEFAULT_PAYMENT_STATUS)
        strSQL = strSQL.Replace("{21}", DEFAULT_CARD_TYPE)
        strSQL = strSQL.Replace("{22}", DEFAULT_PAYMENT_REMARKS)
        strSQL = strSQL.Replace("{23}", PROPERTY1)
        strSQL = strSQL.Replace("{24}", PROPERTY2)
        strSQL = strSQL.Replace("{25}", PROPERTY3)
        strSQL = strSQL.Replace("{26}", CUST_ADMIN_FEE_OPTION)
        strSQL = strSQL.Replace("{27}", CUST_ADMIN_FEE_ABS)
        strSQL = strSQL.Replace("{28}", CUST_ADMIN_FEE_RATIO)
        strSQL = strSQL.Replace("{29}", CUST_ADMIN_FEE_ITEMID)
        strSQL = strSQL.Replace("{30}", CUST_ADMIN_FEE_ROUNDING_MODE)
        strSQL = strSQL.Replace("{31}", CUST_ADMIN_FEE_ROUNDING_SCALE)
        strSQL = strSQL.Replace("{32}", CUST_ADMIN_FEE_MIN_AMOUNT)
        strSQL = strSQL.Replace("{33}", CUST_ADMIN_FEE_MAX_AMOUNT)
        strSQL = strSQL.Replace("{34}", ABS_CHARGES)

        strSQL = strSQL.Replace("{V1}", PreparedStatement(obj.pkid))
        strSQL = strSQL.Replace("{V2}", PreparedStatement(obj.name_space))
        strSQL = strSQL.Replace("{V3}", PreparedStatement(obj.sortcode))
        strSQL = strSQL.Replace("{V4}", PreparedStatement(obj.bankCode))
        strSQL = strSQL.Replace("{V5}", PreparedStatement(obj.bankName))
        strSQL = strSQL.Replace("{V6}", PreparedStatement(obj.paymentMode))
        strSQL = strSQL.Replace("{V7}", PreparedStatement(obj.policyCharges))
        strSQL = strSQL.Replace("{V8}", PreparedStatement(obj.pctCharges))
        strSQL = strSQL.Replace("{V9}", PreparedStatement(obj.limitMin))
        strSQL = strSQL.Replace("{V10}", PreparedStatement(obj.limitMax))
        strSQL = strSQL.Replace("{V11}", PreparedStatement(obj.pccenterOpt))
        strSQL = strSQL.Replace("{V12}", PreparedStatement(obj.pccenter))
        strSQL = strSQL.Replace("{V13}", PreparedStatement(obj.branchOpt))
        strSQL = strSQL.Replace("{V14}", PreparedStatement(obj.branch))
        strSQL = strSQL.Replace("{V15}", PreparedStatement(obj.cashbookOpt))
        strSQL = strSQL.Replace("{V16}", PreparedStatement(obj.cashbook))
        strSQL = strSQL.Replace("{V17}", PreparedStatement(obj.status))
        strSQL = strSQL.Replace("{V18}", PreparedStatement(obj.paymentType))
        strSQL = strSQL.Replace("{V19}", PreparedStatement(obj.approvalParty))
        strSQL = strSQL.Replace("{V20}", PreparedStatement(obj.defaultPaymentStatus))
        strSQL = strSQL.Replace("{V21}", PreparedStatement(obj.defaultCardType))
        strSQL = strSQL.Replace("{V22}", PreparedStatement(obj.defaultPaymentRemarks))
        strSQL = strSQL.Replace("{V23}", PreparedStatement(obj.property1))
        strSQL = strSQL.Replace("{V24}", PreparedStatement(obj.property2))
        strSQL = strSQL.Replace("{V25}", PreparedStatement(obj.property3))
        strSQL = strSQL.Replace("{V26}", PreparedStatement(obj.custAdminFeeOption))
        strSQL = strSQL.Replace("{V27}", PreparedStatement(obj.custAdminFeeAbs))
        strSQL = strSQL.Replace("{V28}", PreparedStatement(obj.custAdminFeeRatio))
        strSQL = strSQL.Replace("{V29}", PreparedStatement(obj.custAdminFeeItemid))
        strSQL = strSQL.Replace("{V30}", PreparedStatement(obj.custAdminFeeRoundingMode))
        strSQL = strSQL.Replace("{V31}", PreparedStatement(obj.custAdminFeeRoundingScale))
        strSQL = strSQL.Replace("{V32}", PreparedStatement(obj.custAdminFeeMinAmount))
        strSQL = strSQL.Replace("{V33}", PreparedStatement(obj.custAdminFeeMaxAmount))
        strSQL = strSQL.Replace("{V34}", PreparedStatement(obj.absCharges))

        Return strSQL

    End Function
End Class

