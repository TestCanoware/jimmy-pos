Imports Utils.General

Public Class DACustUser

    'Constants for Table field mappings
    Private Const CLASSNAME = "DACustUserIndex"

    Public Const PKID = "pkid"
    Public Const USERNAME = "username"
    Public Const PASSWORD = "password"
    Public Const NAMEFIRST = "namefirst"
    Public Const NAMELAST = "namelast"
    Public Const ACC_ID = "acc_id"
    Public Const DOB = "dob"
    Public Const EXPIRY = "expiry"
    Public Const TITLE = "title"
    Public Const DESIGNATION = "designation"
    Public Const SEX = "sex"
    Public Const ETHNIC = "ethnic"
    Public Const REFERENCE_NO = "reference_no"
    Public Const IC_TYPE = "ic_type"
    Public Const MAIN_ADDRESS1 = "main_address1"
    Public Const MAIN_ADDRESS2 = "main_address2"
    Public Const MAIN_ADDRESS3 = "main_address3"
    Public Const MAIN_CITY = "main_city"
    Public Const MAIN_POSTCODE = "main_postcode"
    Public Const MAIN_STATE = "main_state"
    Public Const MAIN_COUNTRY = "main_country"
    Public Const TELEPHONE1 = "telephone1"
    Public Const TELEPHONE2 = "telephone2"
    Public Const HOME_PHONE = "home_phone"
    Public Const MOBILE_PHONE = "mobile_phone"
    Public Const FAX_NO = "fax_no"
    Public Const HOMEPAGE = "homepage"
    Public Const EMAIL1 = "email1"
    Public Const EMAIL2 = "email2"
    Public Const EMAIL3 = "email3"
    Public Const PREFERENCE = "preference"
    Public Const DEFAULT_PAYMENT_MODE = "default_payment_mode"
    Public Const DEFAULT_CARD_TYPE = "default_card_type"
    Public Const DEFAULT_CARD_BANK = "default_card_bank"
    Public Const DEFAULT_CARD_NAME = "default_card_name"
    Public Const DEFAULT_CARD_NUMBER = "default_card_number"
    Public Const DEFAULT_CARD_SECURITY_NUMBER = "default_card_security_number"
    Public Const DEFAULT_CARD_VALID_FROM = "default_card_valid_from"
    Public Const DEFAULT_CARD_GOOD_THRU = "default_card_good_thru"
    Public Const LOYALTY_CARD_NAME1 = "loyalty_card_name1"
    Public Const LOYALTY_CARD_NUMBER1 = "loyalty_card_number1"
    Public Const LOYALTY_CARD_NAME2 = "loyalty_card_name2"
    Public Const LOYALTY_CARD_NUMBER2 = "loyalty_card_number2"
    Public Const LOYALTY_CARD_NAME3 = "loyalty_card_name3"
    Public Const LOYALTY_CARD_NUMBER3 = "loyalty_card_number3"
    Public Const LOYALTY_CARD_NAME4 = "loyalty_card_name4"
    Public Const LOYALTY_CARD_NUMBER4 = "loyalty_card_number4"
    Public Const SECURITY_CHECK = "security_check"
    Public Const STATE = "state"
    Public Const STATUS = "status"
    Public Const LASTUPDATE = "lastupdate"
    Public Const USERID_EDIT = "userid_edit"
    Public Const NATIONALITY = "nationality"
    Public Const MARITAL_STATUS = "marital_status"
    Public Const EDUCATION_LEVEL = "education_level"
    Public Const GROSS_HOUSEHOLD_INCOME = "gross_household_income"
    Public Const PROFESSION = "profession"
    Public Const HOUSEHOLD_NUMBER = "household_number"
    Public Const HOUSEHOLD_JUNIOR = "household_junior"
    Public Const HOUSEHOLD_SENIOR = "household_senior"
    Public Const CONTACT_ADDRESS1 = "contact_address1"
    Public Const CONTACT_ADDRESS2 = "contact_address2"
    Public Const CONTACT_ADDRESS3 = "contact_address3"
    Public Const CONTACT_CITY = "contact_city"
    Public Const CONTACT_POSTCODE = "contact_postcode"
    Public Const CONTACT_STATE = "contact_state"
    Public Const CONTACT_COUNTRY = "contact_country"
    Public Const BUSINESS_ADDRESS1 = "business_address1"
    Public Const BUSINESS_ADDRESS2 = "business_address2"
    Public Const BUSINESS_ADDRESS3 = "business_address3"
    Public Const BUSINESS_CITY = "business_city"
    Public Const BUSINESS_POSTCODE = "business_postcode"
    Public Const BUSINESS_STATE = "business_state"
    Public Const BUSINESS_COUNTRY = "business_country"
    Public Const BUSINESS_NATURE = "business_nature"
    Public Const SALESMAN = "salesman"
    Public Const CREDIT_TERMS = "credit_terms"

    Public Const TABLENAME = "cust_user_index"
    Public Const NO_OF_COLUMNS As Integer = 77
    Public Const APP_NAME = "ThickClient-DataAccess"
    Public Const START_ID = 1001

    '***************************************************************************
    '* Create
    '**************************************************************************/
    Public Function Create(ByVal obj As DACustUserObject) As DACustUserObject

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
    Public Sub Update(ByVal obj As DACustUserObject)

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
    Public Function GetObject(ByVal id As Integer) As DACustUserObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DACustUserObject = Nothing
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
        strSQL = strSQL.Replace("{1}", NAMEFIRST)

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
        strSQL = strSQL.Replace("{2}", NAMEFIRST)

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
    Public Function GetObject(ByVal row As DataRow) As DACustUserObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DACustUserObject

        Try
            obj = New DACustUserObject
            obj.pkid = row(PKID)
            obj.username = row(USERNAME)
            obj.password = row(PASSWORD)
            obj.nameFirst = row(NAMEFIRST)
            obj.nameLast = row(NAMELAST)
            obj.accId = row(ACC_ID)
            obj.dob = row(DOB)
            obj.expiry = row(EXPIRY)
            obj.title = row(TITLE)
            obj.designation = row(DESIGNATION)
            obj.sex = row(SEX)
            obj.ethnic = row(ETHNIC)
            obj.referenceNo = row(REFERENCE_NO)
            obj.icType = row(IC_TYPE)
            obj.mainAddress1 = row(MAIN_ADDRESS1)
            obj.mainAddress2 = row(MAIN_ADDRESS2)
            obj.mainAddress3 = row(MAIN_ADDRESS3)
            obj.mainCity = row(MAIN_CITY)
            obj.mainPostcode = row(MAIN_POSTCODE)
            obj.mainState = row(MAIN_STATE)
            obj.mainCountry = row(MAIN_COUNTRY)
            obj.telephone1 = row(TELEPHONE1)
            obj.telephone2 = row(TELEPHONE2)
            obj.homePhone = row(HOME_PHONE)
            obj.mobilePhone = row(MOBILE_PHONE)
            obj.faxNo = row(FAX_NO)
            obj.homepage = row(HOMEPAGE)
            obj.email1 = row(EMAIL1)
            obj.email2 = row(EMAIL2)
            obj.email3 = row(EMAIL3)
            obj.preference = row(PREFERENCE)
            obj.defaultPaymentMode = row(DEFAULT_PAYMENT_MODE)
            obj.defaultCardType = row(DEFAULT_CARD_TYPE)
            obj.defaultCardBank = row(DEFAULT_CARD_BANK)
            obj.defaultCardName = row(DEFAULT_CARD_NAME)
            obj.defaultCardNumber = row(DEFAULT_CARD_NUMBER)
            obj.defaultCardSecurityNum = row(DEFAULT_CARD_SECURITY_NUMBER)
            obj.defaultCardValidFrom = row(DEFAULT_CARD_VALID_FROM)
            obj.defaultCardGoodThru = row(DEFAULT_CARD_GOOD_THRU)
            obj.loyaltyCardName1 = row(LOYALTY_CARD_NAME1)
            obj.loyaltyCardNumber1 = row(LOYALTY_CARD_NUMBER1)
            obj.loyaltyCardName2 = row(LOYALTY_CARD_NAME2)
            obj.loyaltyCardNumber2 = row(LOYALTY_CARD_NUMBER2)
            obj.loyaltyCardName3 = row(LOYALTY_CARD_NAME3)
            obj.loyaltyCardNumber3 = row(LOYALTY_CARD_NUMBER3)
            obj.loyaltyCardName4 = row(LOYALTY_CARD_NAME4)
            obj.loyaltyCardNumber4 = row(LOYALTY_CARD_NUMBER4)
            obj.securityCheck = row(SECURITY_CHECK)
            obj.state = row(STATE)
            obj.status = row(STATUS)
            obj.lastupdate = row(LASTUPDATE)
            obj.useridEdit = row(USERID_EDIT)
            obj.nationality = row(NATIONALITY)
            obj.maritalStatus = row(MARITAL_STATUS)
            obj.educationLevel = row(EDUCATION_LEVEL)
            obj.grossHouseholdIncome = row(GROSS_HOUSEHOLD_INCOME)
            obj.profession = row(PROFESSION)
            obj.householdNumber = row(HOUSEHOLD_NUMBER)
            obj.householdJunior = row(HOUSEHOLD_JUNIOR)
            obj.householdSenior = row(HOUSEHOLD_SENIOR)
            obj.contactAddress1 = row(CONTACT_ADDRESS1)
            obj.contactAddress2 = row(CONTACT_ADDRESS2)
            obj.contactAddress3 = row(CONTACT_ADDRESS3)
            obj.contactCity = row(CONTACT_CITY)
            obj.contactPostcode = row(CONTACT_POSTCODE)
            obj.contactState = row(CONTACT_STATE)
            obj.contactCountry = row(CONTACT_COUNTRY)
            obj.businessAddress1 = row(BUSINESS_ADDRESS1)
            obj.businessAddress2 = row(BUSINESS_ADDRESS2)
            obj.businessAddress3 = row(BUSINESS_ADDRESS3)
            obj.businessCity = row(BUSINESS_CITY)
            obj.businessPostcode = row(BUSINESS_POSTCODE)
            obj.businessState = row(BUSINESS_STATE)
            obj.businessCountry = row(BUSINESS_COUNTRY)
            obj.businessNature = row(BUSINESS_NATURE)
            obj.salesman = row(SALESMAN)
            obj.creditTerms = row(CREDIT_TERMS)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetObject - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetObject")

        Return obj

    End Function

    Public Function ReplaceStatement(ByVal strSQL As String, ByVal obj As DACustUserObject) As String

        strSQL = strSQL.Replace("{T}", TABLENAME)

        strSQL = strSQL.Replace("{1}", PKID)
        strSQL = strSQL.Replace("{2}", USERNAME)
        strSQL = strSQL.Replace("{3}", PASSWORD)
        strSQL = strSQL.Replace("{4}", NAMEFIRST)
        strSQL = strSQL.Replace("{5}", NAMELAST)
        strSQL = strSQL.Replace("{6}", ACC_ID)
        strSQL = strSQL.Replace("{7}", DOB)
        strSQL = strSQL.Replace("{8}", EXPIRY)
        strSQL = strSQL.Replace("{9}", TITLE)
        strSQL = strSQL.Replace("{10}", DESIGNATION)
        strSQL = strSQL.Replace("{11}", SEX)
        strSQL = strSQL.Replace("{12}", ETHNIC)
        strSQL = strSQL.Replace("{13}", REFERENCE_NO)
        strSQL = strSQL.Replace("{14}", IC_TYPE)
        strSQL = strSQL.Replace("{15}", MAIN_ADDRESS1)
        strSQL = strSQL.Replace("{16}", MAIN_ADDRESS2)
        strSQL = strSQL.Replace("{17}", MAIN_ADDRESS3)
        strSQL = strSQL.Replace("{18}", MAIN_CITY)
        strSQL = strSQL.Replace("{19}", MAIN_POSTCODE)
        strSQL = strSQL.Replace("{20}", MAIN_STATE)
        strSQL = strSQL.Replace("{21}", MAIN_COUNTRY)
        strSQL = strSQL.Replace("{22}", TELEPHONE1)
        strSQL = strSQL.Replace("{23}", TELEPHONE2)
        strSQL = strSQL.Replace("{24}", HOME_PHONE)
        strSQL = strSQL.Replace("{25}", MOBILE_PHONE)
        strSQL = strSQL.Replace("{26}", FAX_NO)
        strSQL = strSQL.Replace("{27}", HOMEPAGE)
        strSQL = strSQL.Replace("{28}", EMAIL1)
        strSQL = strSQL.Replace("{29}", EMAIL2)
        strSQL = strSQL.Replace("{30}", EMAIL3)
        strSQL = strSQL.Replace("{31}", PREFERENCE)
        strSQL = strSQL.Replace("{32}", DEFAULT_PAYMENT_MODE)
        strSQL = strSQL.Replace("{33}", DEFAULT_CARD_TYPE)
        strSQL = strSQL.Replace("{34}", DEFAULT_CARD_BANK)
        strSQL = strSQL.Replace("{35}", DEFAULT_CARD_NAME)
        strSQL = strSQL.Replace("{36}", DEFAULT_CARD_NUMBER)
        strSQL = strSQL.Replace("{37}", DEFAULT_CARD_SECURITY_NUMBER)
        strSQL = strSQL.Replace("{38}", DEFAULT_CARD_VALID_FROM)
        strSQL = strSQL.Replace("{39}", DEFAULT_CARD_GOOD_THRU)
        strSQL = strSQL.Replace("{40}", LOYALTY_CARD_NAME1)
        strSQL = strSQL.Replace("{41}", LOYALTY_CARD_NUMBER1)
        strSQL = strSQL.Replace("{42}", LOYALTY_CARD_NAME2)
        strSQL = strSQL.Replace("{43}", LOYALTY_CARD_NUMBER2)
        strSQL = strSQL.Replace("{44}", LOYALTY_CARD_NAME3)
        strSQL = strSQL.Replace("{45}", LOYALTY_CARD_NUMBER3)
        strSQL = strSQL.Replace("{46}", LOYALTY_CARD_NAME4)
        strSQL = strSQL.Replace("{47}", LOYALTY_CARD_NUMBER4)
        strSQL = strSQL.Replace("{48}", SECURITY_CHECK)
        strSQL = strSQL.Replace("{49}", STATE)
        strSQL = strSQL.Replace("{50}", STATUS)
        strSQL = strSQL.Replace("{51}", LASTUPDATE)
        strSQL = strSQL.Replace("{52}", USERID_EDIT)
        strSQL = strSQL.Replace("{53}", NATIONALITY)
        strSQL = strSQL.Replace("{54}", MARITAL_STATUS)
        strSQL = strSQL.Replace("{55}", EDUCATION_LEVEL)
        strSQL = strSQL.Replace("{56}", GROSS_HOUSEHOLD_INCOME)
        strSQL = strSQL.Replace("{57}", PROFESSION)
        strSQL = strSQL.Replace("{58}", HOUSEHOLD_NUMBER)
        strSQL = strSQL.Replace("{59}", HOUSEHOLD_JUNIOR)
        strSQL = strSQL.Replace("{60}", HOUSEHOLD_SENIOR)
        strSQL = strSQL.Replace("{61}", CONTACT_ADDRESS1)
        strSQL = strSQL.Replace("{62}", CONTACT_ADDRESS2)
        strSQL = strSQL.Replace("{63}", CONTACT_ADDRESS3)
        strSQL = strSQL.Replace("{64}", CONTACT_CITY)
        strSQL = strSQL.Replace("{65}", CONTACT_POSTCODE)
        strSQL = strSQL.Replace("{66}", CONTACT_STATE)
        strSQL = strSQL.Replace("{67}", CONTACT_COUNTRY)
        strSQL = strSQL.Replace("{68}", BUSINESS_ADDRESS1)
        strSQL = strSQL.Replace("{69}", BUSINESS_ADDRESS2)
        strSQL = strSQL.Replace("{70}", BUSINESS_ADDRESS3)
        strSQL = strSQL.Replace("{71}", BUSINESS_CITY)
        strSQL = strSQL.Replace("{72}", BUSINESS_POSTCODE)
        strSQL = strSQL.Replace("{73}", BUSINESS_STATE)
        strSQL = strSQL.Replace("{74}", BUSINESS_COUNTRY)
        strSQL = strSQL.Replace("{75}", BUSINESS_NATURE)
        strSQL = strSQL.Replace("{76}", SALESMAN)
        strSQL = strSQL.Replace("{77}", CREDIT_TERMS)


        strSQL = strSQL.Replace("{V1}", PreparedStatement(obj.pkid))
        strSQL = strSQL.Replace("{V2}", PreparedStatement(obj.username))
        strSQL = strSQL.Replace("{V3}", PreparedStatement(obj.password))
        strSQL = strSQL.Replace("{V4}", PreparedStatement(obj.nameFirst))
        strSQL = strSQL.Replace("{V5}", PreparedStatement(obj.nameLast))
        strSQL = strSQL.Replace("{V6}", PreparedStatement(obj.accId))
        strSQL = strSQL.Replace("{V7}", PreparedStatement(obj.dob))
        strSQL = strSQL.Replace("{V8}", PreparedStatement(obj.expiry))
        strSQL = strSQL.Replace("{V9}", PreparedStatement(obj.title))
        strSQL = strSQL.Replace("{V10}", PreparedStatement(obj.designation))
        strSQL = strSQL.Replace("{V11}", PreparedStatement(obj.sex))
        strSQL = strSQL.Replace("{V12}", PreparedStatement(obj.ethnic))
        strSQL = strSQL.Replace("{V13}", PreparedStatement(obj.referenceNo))
        strSQL = strSQL.Replace("{V14}", PreparedStatement(obj.icType))
        strSQL = strSQL.Replace("{V15}", PreparedStatement(obj.mainAddress1))
        strSQL = strSQL.Replace("{V16}", PreparedStatement(obj.mainAddress2))
        strSQL = strSQL.Replace("{V17}", PreparedStatement(obj.mainAddress3))
        strSQL = strSQL.Replace("{V18}", PreparedStatement(obj.mainCity))
        strSQL = strSQL.Replace("{V19}", PreparedStatement(obj.mainPostcode))
        strSQL = strSQL.Replace("{V20}", PreparedStatement(obj.mainState))
        strSQL = strSQL.Replace("{V21}", PreparedStatement(obj.mainCountry))
        strSQL = strSQL.Replace("{V22}", PreparedStatement(obj.telephone1))
        strSQL = strSQL.Replace("{V23}", PreparedStatement(obj.telephone2))
        strSQL = strSQL.Replace("{V24}", PreparedStatement(obj.homePhone))
        strSQL = strSQL.Replace("{V25}", PreparedStatement(obj.mobilePhone))
        strSQL = strSQL.Replace("{V26}", PreparedStatement(obj.faxNo))
        strSQL = strSQL.Replace("{V27}", PreparedStatement(obj.homepage))
        strSQL = strSQL.Replace("{V28}", PreparedStatement(obj.email1))
        strSQL = strSQL.Replace("{V29}", PreparedStatement(obj.email2))
        strSQL = strSQL.Replace("{V30}", PreparedStatement(obj.email3))
        strSQL = strSQL.Replace("{V31}", PreparedStatement(obj.preference))
        strSQL = strSQL.Replace("{V32}", PreparedStatement(obj.defaultPaymentMode))
        strSQL = strSQL.Replace("{V33}", PreparedStatement(obj.defaultCardType))
        strSQL = strSQL.Replace("{V34}", PreparedStatement(obj.defaultCardBank))
        strSQL = strSQL.Replace("{V35}", PreparedStatement(obj.defaultCardName))
        strSQL = strSQL.Replace("{V36}", PreparedStatement(obj.defaultCardNumber))
        strSQL = strSQL.Replace("{V37}", PreparedStatement(obj.defaultCardSecurityNum))
        strSQL = strSQL.Replace("{V38}", PreparedStatement(obj.defaultCardValidFrom))
        strSQL = strSQL.Replace("{V39}", PreparedStatement(obj.defaultCardGoodThru))
        strSQL = strSQL.Replace("{V40}", PreparedStatement(obj.loyaltyCardName1))
        strSQL = strSQL.Replace("{V41}", PreparedStatement(obj.loyaltyCardNumber1))
        strSQL = strSQL.Replace("{V42}", PreparedStatement(obj.loyaltyCardName2))
        strSQL = strSQL.Replace("{V43}", PreparedStatement(obj.loyaltyCardNumber2))
        strSQL = strSQL.Replace("{V44}", PreparedStatement(obj.loyaltyCardName3))
        strSQL = strSQL.Replace("{V45}", PreparedStatement(obj.loyaltyCardNumber3))
        strSQL = strSQL.Replace("{V46}", PreparedStatement(obj.loyaltyCardName4))
        strSQL = strSQL.Replace("{V47}", PreparedStatement(obj.loyaltyCardNumber4))
        strSQL = strSQL.Replace("{V48}", PreparedStatement(obj.securityCheck))
        strSQL = strSQL.Replace("{V49}", PreparedStatement(obj.state))
        strSQL = strSQL.Replace("{V50}", PreparedStatement(obj.status))
        strSQL = strSQL.Replace("{V51}", PreparedStatement(obj.lastupdate))
        strSQL = strSQL.Replace("{V52}", PreparedStatement(obj.useridEdit))
        strSQL = strSQL.Replace("{V53}", PreparedStatement(obj.nationality))
        strSQL = strSQL.Replace("{V54}", PreparedStatement(obj.maritalStatus))
        strSQL = strSQL.Replace("{V55}", PreparedStatement(obj.educationLevel))
        strSQL = strSQL.Replace("{V56}", PreparedStatement(obj.grossHouseholdIncome))
        strSQL = strSQL.Replace("{V57}", PreparedStatement(obj.profession))
        strSQL = strSQL.Replace("{V58}", PreparedStatement(obj.householdNumber))
        strSQL = strSQL.Replace("{V59}", PreparedStatement(obj.householdJunior))
        strSQL = strSQL.Replace("{V60}", PreparedStatement(obj.householdSenior))
        strSQL = strSQL.Replace("{V61}", PreparedStatement(obj.contactAddress1))
        strSQL = strSQL.Replace("{V62}", PreparedStatement(obj.contactAddress2))
        strSQL = strSQL.Replace("{V63}", PreparedStatement(obj.contactAddress3))
        strSQL = strSQL.Replace("{V64}", PreparedStatement(obj.contactCity))
        strSQL = strSQL.Replace("{V65}", PreparedStatement(obj.contactPostcode))
        strSQL = strSQL.Replace("{V66}", PreparedStatement(obj.contactState))
        strSQL = strSQL.Replace("{V67}", PreparedStatement(obj.contactCountry))
        strSQL = strSQL.Replace("{V68}", PreparedStatement(obj.businessAddress1))
        strSQL = strSQL.Replace("{V69}", PreparedStatement(obj.businessAddress2))
        strSQL = strSQL.Replace("{V70}", PreparedStatement(obj.businessAddress3))
        strSQL = strSQL.Replace("{V71}", PreparedStatement(obj.businessCity))
        strSQL = strSQL.Replace("{V72}", PreparedStatement(obj.businessPostcode))
        strSQL = strSQL.Replace("{V73}", PreparedStatement(obj.businessState))
        strSQL = strSQL.Replace("{V74}", PreparedStatement(obj.businessCountry))
        strSQL = strSQL.Replace("{V75}", PreparedStatement(obj.businessNature))
        strSQL = strSQL.Replace("{V76}", PreparedStatement(obj.salesman))
        strSQL = strSQL.Replace("{V77}", PreparedStatement(obj.creditTerms))

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
                nextID += 1
            End If

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetNextID - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetNextID")

        Return nextID

    End Function

End Class

