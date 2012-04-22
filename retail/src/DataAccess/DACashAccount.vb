Imports Utils.General

Public Class DACashAccount

    'Constants for Table field mappings
    Private Const CLASSNAME = "DACashAccount"

    Public Const PKID = "pkid"
    Public Const CODE = "code"
    Public Const NAME = "name"
    Public Const DESCRIPTION = "description"
    Public Const ACC_NUMBER = "acc_number"
    Public Const ACC_TYPE = "acc_type"
    Public Const CURRENCY = "currency"
    Public Const LEVEL_LOW = "level_low"
    Public Const LEVEL_HIGH = "level_high"
    Public Const FACILITY_AMOUNT = "facility_amount"
    Public Const OVERDRAFT_LIMIT = "overdraft_limit"
    Public Const SIGNATORY1 = "signatory1"
    Public Const SIGNATORY2 = "signatory2"
    Public Const SIGNATORY3 = "signatory3"
    Public Const SIGNATORY4 = "signatory4"
    Public Const SIGNATURE = "signature"
    Public Const PC_CENTER = "pc_center"
    Public Const ADD1 = "add1"
    Public Const ADD2 = "add2"
    Public Const ADD3 = "add3"
    Public Const STATE = "state"
    Public Const COUNTRY = "country"
    Public Const PHONE = "phone"
    Public Const CONTACT_PERSON = "contact_person"
    Public Const FAX = "fax"
    Public Const USERID_CREATE = "userid_create"
    Public Const USERID_UPDATE = "userid_update"
    Public Const CREATE_TIME = "createtime"
    Public Const LAST_UPDATE = "lastupdate"
    Public Const STATUS = "status"

    ' Constants for STATUS
    Public Const STATUS_ACTIVE = "active"
    Public Const STATUS_INACTIVE = "inactive"

    Public Const TABLENAME = "acc_cash_account"
    Public Const NO_OF_COLUMNS As Integer = 30
    Public Const APP_NAME = "ThickClient-DataAccess"

    '***************************************************************************
    '* Create
    '**************************************************************************/
    Public Function Create(ByVal obj As DACashAccountObject) As DACashAccountObject

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
    Public Sub Update(ByVal obj As DACashAccountObject)

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
    Public Function GetObject(ByVal id As Integer) As DACashAccountObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DACashAccountObject = Nothing
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
    '* GetObject
    '**************************************************************************/
    Public Function GetObject(ByVal row As DataRow) As DACashAccountObject

        WriteToLogFile(CLASSNAME & " - In GetObject")

        Dim comm As New Commands
        Dim obj As DACashAccountObject

        Try
            obj = New DACashAccountObject
            obj.pkId = row(PKID)
            obj.code = row(CODE)
            obj.name = row(NAME)
            obj.description = row(DESCRIPTION)
            obj.accountNumber = row(ACC_NUMBER)
            obj.accountType = row(ACC_TYPE)
            obj.currency = row(CURRENCY)
            obj.levelLow = row(LEVEL_LOW)
            obj.levelHigh = row(LEVEL_HIGH)
            obj.facilityAmount = row(FACILITY_AMOUNT)
            obj.overdraftLimit = row(OVERDRAFT_LIMIT)
            obj.signatory1 = row(SIGNATORY1)
            obj.signatory2 = row(SIGNATORY2)
            obj.signatory3 = row(SIGNATORY3)
            obj.signatory4 = row(SIGNATORY4)
            obj.signature = row(SIGNATURE)
            obj.pcCenter = row(PC_CENTER)
            obj.add1 = row(ADD1)
            obj.add2 = row(ADD2)
            obj.add3 = row(ADD3)
            obj.state = row(STATE)
            obj.country = row(COUNTRY)
            obj.phone = row(PHONE)
            obj.contactPerson = row(CONTACT_PERSON)
            obj.fax = row(FAX)
            obj.userIdCreate = row(USERID_CREATE)
            obj.userIdUpdate = row(USERID_UPDATE)
            obj.createTime = row(CREATE_TIME)
            obj.lastUpdate = row(LAST_UPDATE)
            obj.status = row(STATUS)

        Catch ex As Exception
            Throw New Exception(CLASSNAME & " - GetObject - " & ex.Message)
        End Try

        WriteToLogFile(CLASSNAME & " - Leave GetObject")

        Return obj

    End Function


    Public Function ReplaceStatement(ByVal strSQL As String, ByVal obj As DACashAccountObject) As String

        strSQL = strSQL.Replace("{T}", TABLENAME)

        strSQL = strSQL.Replace("{1}", PKID)
        strSQL = strSQL.Replace("{2}", CODE)
        strSQL = strSQL.Replace("{3}", NAME)
        strSQL = strSQL.Replace("{4}", DESCRIPTION)
        strSQL = strSQL.Replace("{5}", ACC_NUMBER)
        strSQL = strSQL.Replace("{6}", ACC_TYPE)
        strSQL = strSQL.Replace("{7}", CURRENCY)
        strSQL = strSQL.Replace("{8}", LEVEL_LOW)
        strSQL = strSQL.Replace("{9}", LEVEL_HIGH)
        strSQL = strSQL.Replace("{10}", FACILITY_AMOUNT)
        strSQL = strSQL.Replace("{11}", OVERDRAFT_LIMIT)
        strSQL = strSQL.Replace("{12}", SIGNATORY1)
        strSQL = strSQL.Replace("{13}", SIGNATORY2)
        strSQL = strSQL.Replace("{14}", SIGNATORY3)
        strSQL = strSQL.Replace("{15}", SIGNATORY4)
        strSQL = strSQL.Replace("{16}", SIGNATURE)
        strSQL = strSQL.Replace("{17}", PC_CENTER)
        strSQL = strSQL.Replace("{18}", ADD1)
        strSQL = strSQL.Replace("{19}", ADD2)
        strSQL = strSQL.Replace("{20}", ADD3)
        strSQL = strSQL.Replace("{21}", STATE)
        strSQL = strSQL.Replace("{22}", COUNTRY)
        strSQL = strSQL.Replace("{23}", PHONE)
        strSQL = strSQL.Replace("{24}", CONTACT_PERSON)
        strSQL = strSQL.Replace("{25}", FAX)
        strSQL = strSQL.Replace("{26}", USERID_CREATE)
        strSQL = strSQL.Replace("{27}", USERID_UPDATE)
        strSQL = strSQL.Replace("{28}", CREATE_TIME)
        strSQL = strSQL.Replace("{29}", LAST_UPDATE)
        strSQL = strSQL.Replace("{30}", STATUS)

        strSQL = strSQL.Replace("{V1}", PreparedStatement(obj.pkId))
        strSQL = strSQL.Replace("{V2}", PreparedStatement(obj.code))
        strSQL = strSQL.Replace("{V3}", PreparedStatement(obj.name))
        strSQL = strSQL.Replace("{V4}", PreparedStatement(obj.description))
        strSQL = strSQL.Replace("{V5}", PreparedStatement(obj.accountNumber))
        strSQL = strSQL.Replace("{V6}", PreparedStatement(obj.accountType))
        strSQL = strSQL.Replace("{V7}", PreparedStatement(obj.currency))
        strSQL = strSQL.Replace("{V8}", PreparedStatement(obj.levelLow))
        strSQL = strSQL.Replace("{V9}", PreparedStatement(obj.levelHigh))
        strSQL = strSQL.Replace("{V10}", PreparedStatement(obj.facilityAmount))
        strSQL = strSQL.Replace("{V11}", PreparedStatement(obj.overdraftLimit))
        strSQL = strSQL.Replace("{V12}", PreparedStatement(obj.signatory1))
        strSQL = strSQL.Replace("{V13}", PreparedStatement(obj.signatory2))
        strSQL = strSQL.Replace("{V14}", PreparedStatement(obj.signatory3))
        strSQL = strSQL.Replace("{V15}", PreparedStatement(obj.signatory4))
        strSQL = strSQL.Replace("{V16}", PreparedStatement(obj.signature))
        strSQL = strSQL.Replace("{V17}", PreparedStatement(obj.pcCenter))
        strSQL = strSQL.Replace("{V18}", PreparedStatement(obj.add1))
        strSQL = strSQL.Replace("{V19}", PreparedStatement(obj.add2))
        strSQL = strSQL.Replace("{V20}", PreparedStatement(obj.add3))
        strSQL = strSQL.Replace("{V21}", PreparedStatement(obj.state))
        strSQL = strSQL.Replace("{V22}", PreparedStatement(obj.country))
        strSQL = strSQL.Replace("{V23}", PreparedStatement(obj.phone))
        strSQL = strSQL.Replace("{V24}", PreparedStatement(obj.contactPerson))
        strSQL = strSQL.Replace("{V25}", PreparedStatement(obj.fax))
        strSQL = strSQL.Replace("{V26}", PreparedStatement(obj.userIdCreate))
        strSQL = strSQL.Replace("{V27}", PreparedStatement(obj.userIdUpdate))
        strSQL = strSQL.Replace("{V28}", PreparedStatement(obj.createTime))
        strSQL = strSQL.Replace("{V29}", PreparedStatement(obj.lastUpdate))
        strSQL = strSQL.Replace("{V30}", PreparedStatement(obj.status))

        Return strSQL

    End Function
End Class

