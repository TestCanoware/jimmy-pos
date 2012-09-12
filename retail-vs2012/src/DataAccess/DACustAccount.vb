Imports Utils.General

Public Class DACustAccount

    'Constants for Table field mappings
    Private Const CLASSNAME = "DACustAccount"

    Public Const PKID = "pkid"
    Public Const CUSTCODE = "acc_code"
    Public Const NAME = "name"
    Public Const DESCRIPTION = "description"
    Public Const ACCTYPE = "acc_type"
    Public Const STATUS = "status"
    Public Const LASTUPDATE = "last_edit"
    Public Const USERID_EDIT = "userid_edit"
    Public Const USERNAME = "username"
    Public Const PASSWORD = "password"
    Public Const NAME_FIRST = "name_first"
    Public Const NAME_LAST = "name_last"
    Public Const NICKNAME = "nickname"
    Public Const TITLE = "title"
    Public Const DESIGNATION = "designation"
    Public Const IDENTITY_NUMBER = "identity_number"
    Public Const MAIN_ADDRESS1 = "main_address1"
    Public Const MAIN_ADDRESS2 = "main_address2"
    Public Const MAIN_ADDRESS3 = "main_address3"
    Public Const MAIN_CITY = "main_city"
    Public Const MAIN_POSTCODE = "main_postcode"
    Public Const MAIN_STATE = "main_state"
    Public Const MAIN_COUNTRY = "main_country"
    Public Const SHIP_ADDRESS1 = "ship_address1"
    Public Const SHIP_ADDRESS2 = "ship_address2"
    Public Const SHIP_ADDRESS3 = "ship_address3"
    Public Const SHIP_CITY = "ship_city"
    Public Const SHIP_POSTCODE = "ship_postcode"
    Public Const SHIP_STATE = "ship_state"
    Public Const SHIP_COUNTRY = "ship_country"
    Public Const BILL_ADDRESS1 = "bill_address1"
    Public Const BILL_ADDRESS2 = "bill_address2"
    Public Const BILL_ADDRESS3 = "bill_address3"
    Public Const BILL_CITY = "bill_city"
    Public Const BILL_POSTCODE = "bill_postcode"
    Public Const BILL_STATE = "bill_state"
    Public Const BILL_COUNTRY = "bill_country"
    Public Const TELEPHONE1 = "telephone1"
    Public Const TELEPHONE2 = "telephone2"
    Public Const HOME_PHONE = "home_phone"
    Public Const MOBILE_PHONE = "mobile_phone"
    Public Const FAX_NO = "fax_no"
    Public Const HOMEPAGE = "homepage"
    Public Const EMAIL1 = "email1"
    Public Const EMAIL2 = "email2"
    Public Const EMAIL3 = "email3"
    Public Const CREDIT_LIMIT = "credit_limit"
    Public Const CREDIT_TERMS = "credit_terms"
    Public Const PROPERTY1 = "property1"
    Public Const PROPERTY2 = "property2"
    Public Const PROPERTY3 = "property3"
    Public Const PROPERTY4 = "property4"
    Public Const PROPERTY5 = "property5"
    Public Const NOTE = "note"
    Public Const SALESMAN = "salesman"
    Public Const STATE = "state"
    Public Const DEALER_CODE = "dealer_code"
    Public Const FACTOR_PRICING = "factor_pricing"
    Public Const FACTOR_DISCOUNT = "factor_discount"
    Public Const PRICING_LOGIC = "pricing_logic"
    Public Const PRICING_SCHEME = "pricing_scheme"
    Public Const AREA_CODE = "area_code"
    Public Const DEPT_CODE = "dept_code"
    Public Const SUPPLIER_ID = "supplier_id"
    Public Const BRANCH = "branch"
    Public Const PC_CENTER = "pc_center"
    Public Const MONTHLY_FEES = "monthly_fees"
    Public Const CREDIT_OPTION = "credit_option"

    Public Const STATE_OK = "OK"
    Public Const STATE_BL = "BL"
    Public Const STATUS_ACTIVE = "active"
    Public Const STATUS_INACTIVE = "inactive"
    Public Const ACCTYPE_CORPORATE = "10"
    Public Const ACCTYPE_PERSONAL = "20"

    Public Const TABLENAME = "cust_account_index"
    Public Const NO_OF_COLUMNS As Integer = 68
    Public Const APP_NAME = "ThickClient-DataAccess"
    Public Const START_ID = 1001

    '***************************************************************************
    '* Create
    '**************************************************************************/
    Public Function Create(ByVal obj As DACustAccountObject) As DACustAccountObject

        WriteToLogFile(CLASSNAME & " - In Create")

        Dim comm As New Commands
        Dim strSQL, strSQL1, strSQL2 As String

        'getNextID
        obj.pkid = GetNextID()
        obj.custAccountCode = "AUTO-" & obj.pkid

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
    Public Sub Update(ByVal obj As DACustAccountObject)

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

        strSQL = "DELETE FROM " & TABLENAME & " WHERE " & DACustAccount.PKID & " != 500"

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
    Public Function GetObject(ByVal id As Integer) As DACustAccountObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DACustAccountObject = Nothing
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
    '* GetDataset
    '**************************************************************************/
    Public Function GetDataset(ByVal whereClause As String) As DataSet

        WriteToLogFile(CLASSNAME & " - In GetDataset")

        Dim comm As New Commands
        Dim strSQL As String

        strSQL = "SELECT * FROM {T} WHERE {1} ORDER BY {2}"

        strSQL = strSQL.Replace("{T}", TABLENAME)
        strSQL = strSQL.Replace("{1}", whereClause)
        strSQL = strSQL.Replace("{2}", NAME)

        Try
            WriteToLogFile(strSQL)
            Return comm.ExecuteQuery(strSQL, Commands.ReturnType.DataSetType)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetDataset - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetDataset")

    End Function

    '***************************************************************************
    '* GetObject
    '**************************************************************************/
    Public Function GetObject(ByVal row As DataRow) As DACustAccountObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DACustAccountObject

        Try
            obj = New DACustAccountObject
            obj.pkid = row(PKID)
            obj.custAccountCode = row(CUSTCODE)
            obj.name = row(NAME)
            obj.description = row(DESCRIPTION)
            obj.accType = row(ACCTYPE)
            obj.status = row(STATUS)
            obj.lastUpdate = row(LASTUPDATE)
            obj.userIdUpdate = row(USERID_EDIT)
            obj.username = row(USERNAME)
            obj.password = row(PASSWORD)
            obj.nameFirst = row(NAME_FIRST)
            obj.nameLast = row(NAME_LAST)
            obj.nickname = row(NICKNAME)
            obj.title = row(TITLE)
            obj.designation = row(DESIGNATION)
            obj.identityNumber = row(IDENTITY_NUMBER)
            obj.mainAddress1 = row(MAIN_ADDRESS1)
            obj.mainAddress2 = row(MAIN_ADDRESS2)
            obj.mainAddress3 = row(MAIN_ADDRESS3)
            obj.mainCity = row(MAIN_CITY)
            obj.mainPostcode = row(MAIN_POSTCODE)
            obj.mainState = row(MAIN_STATE)
            obj.mainCountry = row(MAIN_COUNTRY)
            obj.shipAddress1 = row(SHIP_ADDRESS1)
            obj.shipAddress2 = row(SHIP_ADDRESS2)
            obj.shipAddress3 = row(SHIP_ADDRESS3)
            obj.shipCity = row(SHIP_CITY)
            obj.shipPostcode = row(SHIP_POSTCODE)
            obj.shipState = row(SHIP_STATE)
            obj.shipCountry = row(SHIP_COUNTRY)
            obj.billAddress1 = row(BILL_ADDRESS1)
            obj.billAddress2 = row(BILL_ADDRESS2)
            obj.billAddress3 = row(BILL_ADDRESS3)
            obj.billCity = row(BILL_CITY)
            obj.billPostcode = row(BILL_POSTCODE)
            obj.billState = row(BILL_STATE)
            obj.billCountry = row(BILL_COUNTRY)
            obj.telephone1 = row(TELEPHONE1)
            obj.telephone2 = row(TELEPHONE2)
            obj.homePhone = row(HOME_PHONE)
            obj.mobilePhone = row(MOBILE_PHONE)
            obj.faxNo = row(FAX_NO)
            obj.homepage = row(HOMEPAGE)
            obj.email1 = row(EMAIL1)
            obj.email2 = row(EMAIL2)
            obj.email3 = row(EMAIL3)
            obj.creditLimit = row(CREDIT_LIMIT)
            obj.creditTerms = row(CREDIT_TERMS)
            obj.property1 = row(PROPERTY1)
            obj.property2 = row(PROPERTY2)
            obj.property3 = row(PROPERTY3)
            obj.property4 = row(PROPERTY4)
            obj.property5 = row(PROPERTY5)
            obj.note = row(NOTE)
            obj.salesman = row(SALESMAN)
            obj.state = row(STATE)
            obj.dealerCode = row(DEALER_CODE)
            obj.factorPricing = row(FACTOR_PRICING)
            obj.factorDiscount = row(FACTOR_DISCOUNT)
            obj.pricingLogic = row(PRICING_LOGIC)
            obj.pricingScheme = row(PRICING_SCHEME)
            obj.areaCode = row(AREA_CODE)
            obj.deptCode = row(DEPT_CODE)
            obj.supplierId = row(SUPPLIER_ID)
            obj.branch = row(BRANCH)
            obj.pcCenter = row(PC_CENTER)
            obj.monthlyFees = row(MONTHLY_FEES)
            obj.creditOption = row(CREDIT_OPTION)


        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetObject - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetObject")

        Return obj

    End Function


    Public Function ReplaceStatement(ByVal strSQL As String, ByVal obj As DACustAccountObject) As String

        strSQL = strSQL.Replace("{T}", TABLENAME)


        strSQL = strSQL.Replace("{1}", PKID)
        strSQL = strSQL.Replace("{2}", CUSTCODE)
        strSQL = strSQL.Replace("{3}", NAME)
        strSQL = strSQL.Replace("{4}", DESCRIPTION)
        strSQL = strSQL.Replace("{5}", ACCTYPE)
        strSQL = strSQL.Replace("{6}", STATUS)
        strSQL = strSQL.Replace("{7}", LASTUPDATE)
        strSQL = strSQL.Replace("{8}", USERID_EDIT)
        strSQL = strSQL.Replace("{9}", USERNAME)
        strSQL = strSQL.Replace("{10}", PASSWORD)
        strSQL = strSQL.Replace("{11}", NAME_FIRST)
        strSQL = strSQL.Replace("{12}", NAME_LAST)
        strSQL = strSQL.Replace("{13}", NICKNAME)
        strSQL = strSQL.Replace("{14}", TITLE)
        strSQL = strSQL.Replace("{15}", DESIGNATION)
        strSQL = strSQL.Replace("{16}", IDENTITY_NUMBER)
        strSQL = strSQL.Replace("{17}", MAIN_ADDRESS1)
        strSQL = strSQL.Replace("{18}", MAIN_ADDRESS2)
        strSQL = strSQL.Replace("{19}", MAIN_ADDRESS3)
        strSQL = strSQL.Replace("{20}", MAIN_CITY)
        strSQL = strSQL.Replace("{21}", MAIN_POSTCODE)
        strSQL = strSQL.Replace("{22}", MAIN_STATE)
        strSQL = strSQL.Replace("{23}", MAIN_COUNTRY)
        strSQL = strSQL.Replace("{24}", SHIP_ADDRESS1)
        strSQL = strSQL.Replace("{25}", SHIP_ADDRESS2)
        strSQL = strSQL.Replace("{26}", SHIP_ADDRESS3)
        strSQL = strSQL.Replace("{27}", SHIP_CITY)
        strSQL = strSQL.Replace("{28}", SHIP_POSTCODE)
        strSQL = strSQL.Replace("{29}", SHIP_STATE)
        strSQL = strSQL.Replace("{30}", SHIP_COUNTRY)
        strSQL = strSQL.Replace("{31}", BILL_ADDRESS1)
        strSQL = strSQL.Replace("{32}", BILL_ADDRESS2)
        strSQL = strSQL.Replace("{33}", BILL_ADDRESS3)
        strSQL = strSQL.Replace("{34}", BILL_CITY)
        strSQL = strSQL.Replace("{35}", BILL_POSTCODE)
        strSQL = strSQL.Replace("{36}", BILL_STATE)
        strSQL = strSQL.Replace("{37}", BILL_COUNTRY)
        strSQL = strSQL.Replace("{38}", TELEPHONE1)
        strSQL = strSQL.Replace("{39}", TELEPHONE2)
        strSQL = strSQL.Replace("{40}", HOME_PHONE)
        strSQL = strSQL.Replace("{41}", MOBILE_PHONE)
        strSQL = strSQL.Replace("{42}", FAX_NO)
        strSQL = strSQL.Replace("{43}", HOMEPAGE)
        strSQL = strSQL.Replace("{44}", EMAIL1)
        strSQL = strSQL.Replace("{45}", EMAIL2)
        strSQL = strSQL.Replace("{46}", EMAIL3)
        strSQL = strSQL.Replace("{47}", CREDIT_LIMIT)
        strSQL = strSQL.Replace("{48}", CREDIT_TERMS)
        strSQL = strSQL.Replace("{49}", PROPERTY1)
        strSQL = strSQL.Replace("{50}", PROPERTY2)
        strSQL = strSQL.Replace("{51}", PROPERTY3)
        strSQL = strSQL.Replace("{52}", PROPERTY4)
        strSQL = strSQL.Replace("{53}", PROPERTY5)
        strSQL = strSQL.Replace("{54}", NOTE)
        strSQL = strSQL.Replace("{55}", SALESMAN)
        strSQL = strSQL.Replace("{56}", STATE)
        strSQL = strSQL.Replace("{57}", DEALER_CODE)
        strSQL = strSQL.Replace("{58}", FACTOR_PRICING)
        strSQL = strSQL.Replace("{59}", FACTOR_DISCOUNT)
        strSQL = strSQL.Replace("{60}", PRICING_LOGIC)
        strSQL = strSQL.Replace("{61}", PRICING_SCHEME)
        strSQL = strSQL.Replace("{62}", AREA_CODE)
        strSQL = strSQL.Replace("{63}", DEPT_CODE)
        strSQL = strSQL.Replace("{64}", SUPPLIER_ID)
        strSQL = strSQL.Replace("{65}", BRANCH)
        strSQL = strSQL.Replace("{66}", PC_CENTER)
        strSQL = strSQL.Replace("{67}", MONTHLY_FEES)
        strSQL = strSQL.Replace("{68}", CREDIT_OPTION)


        strSQL = strSQL.Replace("{V1}", PreparedStatement(obj.pkid))
        strSQL = strSQL.Replace("{V2}", PreparedStatement(obj.custAccountCode))
        strSQL = strSQL.Replace("{V3}", PreparedStatement(obj.name))
        strSQL = strSQL.Replace("{V4}", PreparedStatement(obj.description))
        strSQL = strSQL.Replace("{V5}", PreparedStatement(obj.accType))
        strSQL = strSQL.Replace("{V6}", PreparedStatement(obj.status))
        strSQL = strSQL.Replace("{V7}", PreparedStatement(obj.lastUpdate))
        strSQL = strSQL.Replace("{V8}", PreparedStatement(obj.userIdUpdate))
        strSQL = strSQL.Replace("{V9}", PreparedStatement(obj.username))
        strSQL = strSQL.Replace("{V10}", PreparedStatement(obj.password))
        strSQL = strSQL.Replace("{V11}", PreparedStatement(obj.nameFirst))
        strSQL = strSQL.Replace("{V12}", PreparedStatement(obj.nameLast))
        strSQL = strSQL.Replace("{V13}", PreparedStatement(obj.nickname))
        strSQL = strSQL.Replace("{V14}", PreparedStatement(obj.title))
        strSQL = strSQL.Replace("{V15}", PreparedStatement(obj.designation))
        strSQL = strSQL.Replace("{V16}", PreparedStatement(obj.identityNumber))
        strSQL = strSQL.Replace("{V17}", PreparedStatement(obj.mainAddress1))
        strSQL = strSQL.Replace("{V18}", PreparedStatement(obj.mainAddress2))
        strSQL = strSQL.Replace("{V19}", PreparedStatement(obj.mainAddress3))
        strSQL = strSQL.Replace("{V20}", PreparedStatement(obj.mainCity))
        strSQL = strSQL.Replace("{V21}", PreparedStatement(obj.mainPostcode))
        strSQL = strSQL.Replace("{V22}", PreparedStatement(obj.mainState))
        strSQL = strSQL.Replace("{V23}", PreparedStatement(obj.mainCountry))
        strSQL = strSQL.Replace("{V24}", PreparedStatement(obj.shipAddress1))
        strSQL = strSQL.Replace("{V25}", PreparedStatement(obj.shipAddress2))
        strSQL = strSQL.Replace("{V26}", PreparedStatement(obj.shipAddress3))
        strSQL = strSQL.Replace("{V27}", PreparedStatement(obj.shipCity))
        strSQL = strSQL.Replace("{V28}", PreparedStatement(obj.shipPostcode))
        strSQL = strSQL.Replace("{V29}", PreparedStatement(obj.shipState))
        strSQL = strSQL.Replace("{V30}", PreparedStatement(obj.shipCountry))
        strSQL = strSQL.Replace("{V31}", PreparedStatement(obj.billAddress1))
        strSQL = strSQL.Replace("{V32}", PreparedStatement(obj.billAddress2))
        strSQL = strSQL.Replace("{V33}", PreparedStatement(obj.billAddress3))
        strSQL = strSQL.Replace("{V34}", PreparedStatement(obj.billCity))
        strSQL = strSQL.Replace("{V35}", PreparedStatement(obj.billPostcode))
        strSQL = strSQL.Replace("{V36}", PreparedStatement(obj.billState))
        strSQL = strSQL.Replace("{V37}", PreparedStatement(obj.billCountry))
        strSQL = strSQL.Replace("{V38}", PreparedStatement(obj.telephone1))
        strSQL = strSQL.Replace("{V39}", PreparedStatement(obj.telephone2))
        strSQL = strSQL.Replace("{V40}", PreparedStatement(obj.homePhone))
        strSQL = strSQL.Replace("{V41}", PreparedStatement(obj.mobilePhone))
        strSQL = strSQL.Replace("{V42}", PreparedStatement(obj.faxNo))
        strSQL = strSQL.Replace("{V43}", PreparedStatement(obj.homepage))
        strSQL = strSQL.Replace("{V44}", PreparedStatement(obj.email1))
        strSQL = strSQL.Replace("{V45}", PreparedStatement(obj.email2))
        strSQL = strSQL.Replace("{V46}", PreparedStatement(obj.email3))
        strSQL = strSQL.Replace("{V47}", PreparedStatement(obj.creditLimit))
        strSQL = strSQL.Replace("{V48}", PreparedStatement(obj.creditTerms))
        strSQL = strSQL.Replace("{V49}", PreparedStatement(obj.property1))
        strSQL = strSQL.Replace("{V50}", PreparedStatement(obj.property2))
        strSQL = strSQL.Replace("{V51}", PreparedStatement(obj.property3))
        strSQL = strSQL.Replace("{V52}", PreparedStatement(obj.property4))
        strSQL = strSQL.Replace("{V53}", PreparedStatement(obj.property5))
        strSQL = strSQL.Replace("{V54}", PreparedStatement(obj.note))
        strSQL = strSQL.Replace("{V55}", PreparedStatement(obj.salesman))
        strSQL = strSQL.Replace("{V56}", PreparedStatement(obj.state))
        strSQL = strSQL.Replace("{V57}", PreparedStatement(obj.dealerCode))
        strSQL = strSQL.Replace("{V58}", PreparedStatement(obj.factorPricing))
        strSQL = strSQL.Replace("{V59}", PreparedStatement(obj.factorDiscount))
        strSQL = strSQL.Replace("{V60}", PreparedStatement(obj.pricingLogic))
        strSQL = strSQL.Replace("{V61}", PreparedStatement(obj.pricingScheme))
        strSQL = strSQL.Replace("{V62}", PreparedStatement(obj.areaCode))
        strSQL = strSQL.Replace("{V63}", PreparedStatement(obj.deptCode))
        strSQL = strSQL.Replace("{V64}", PreparedStatement(obj.supplierId))
        strSQL = strSQL.Replace("{V65}", PreparedStatement(obj.branch))
        strSQL = strSQL.Replace("{V66}", PreparedStatement(obj.pcCenter))
        strSQL = strSQL.Replace("{V67}", PreparedStatement(obj.monthlyFees))
        strSQL = strSQL.Replace("{V68}", PreparedStatement(obj.creditOption))

        Return strSQL

    End Function

    '***************************************************************************
    '* GetNextID
    '**************************************************************************/
    Public Function GetNextID() As Long

        WriteToLogFile(CLASSNAME & " - In GetNextID")

        Dim comm As New Commands
        Dim ds As New DataSet
        Dim strSQL As String
        Dim nextID As Long = START_ID

        strSQL = "SELECT MAX({1}) FROM {T} "

        strSQL = strSQL.Replace("{T}", TABLENAME)
        strSQL = strSQL.Replace("{1}", PKID)

        Try
            WriteToLogFile(strSQL)
            ds = comm.ExecuteQuery(strSQL, Commands.ReturnType.DataSetType)
            If ds.Tables(0).Rows(0)(0).ToString <> "" Then
                nextID = ds.Tables(0).Rows(0)(0)
                If nextID = 500 Then
                    nextID = START_ID
                Else
                    nextID += 1
                End If

            End If

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetNextID - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetNextID")

        Return nextID

    End Function

End Class

