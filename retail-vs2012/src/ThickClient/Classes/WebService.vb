Imports ThickClient.EMPThickClientWebReference
Imports Utils.General
Imports Utils
Imports DataAccess
Imports System.ServiceModel

Public Class WebService

    Public Event Progress(ByVal totalRecord As Integer, ByVal name As String)
    Public Event Connection(ByVal isConnected As Boolean)

    Private Const CLASSNAME = "WebService"
    'Private ws As EMPThickClientClient
    Private ws As EMPThickClientService
    Private daNut As New DataAccessNut
    Public isConnected As Boolean = False
    Public address As String
    Private isError As Boolean = False

    Public Sub New(ByVal address As String)
        MyBase.New()

        Me.address = address
    End Sub

    Public Sub MakeConnection()
        Try
            'ws = New EMPThickClientClient
            'ws.Endpoint.Address = New System.ServiceModel.EndpointAddress(address)
            ws = New EMPThickClientService
            ws.Url = address

            isConnected = ws.getAuthenticate(gUserObj.username, gUserObj.password2)

            'ws.getNextBranch(0)

            'isConnected = True

            'RaiseEvent Connection(True)

        Catch ex As Exception
            CloseConnection()
            isConnected = False
            'RaiseEvent Connection(False)
            Throw New Exception(ex.Message)
        End Try

    End Sub

    Public Sub CloseConnection()
        'ws.Close()
        'ws.Abort()
        ws.Abort()
    End Sub

    Public Function GetBranch() As Boolean

        DebugPrint(CLASSNAME & " - Starting GetBranch")

        Dim count As Long = 0
        Dim getWS As Boolean = True
        Dim branch As branchObject
        Dim pkid As Integer = 0
        Dim result As Boolean = True

        Try
            MakeConnection()
            If Not isConnected Then Exit Function

            daNut.DeleteBranch()
            While (getWS)
                branch = ws.getNextBranch(pkid, True)
                pkid = branch.pkid
                If (pkid > 0) Then
                    count += 1
                    DebugPrint(count & ": Get Branch: " & pkid)
                    getWS = daNut.InsertBranch(branch)
                    RaiseEvent Progress(count, "Branch")
                Else
                    getWS = False
                End If
            End While

        Catch ex As Exception
            DebugPrint(CLASSNAME & " - GetBranch." & "Error : " & ex.Message)
            getWS = False
            result = False
            Throw New Exception(CLASSNAME & " - GetBranch." & "Error : " & ex.Message)

        Finally
            CloseConnection()
            DebugPrint(CLASSNAME & " - Closing GetBranch")
        End Try

        Return result

    End Function


    Public Sub GetCardPaymentConfig()

        DebugPrint(CLASSNAME & " - Starting GetCardPaymentConfig")

        Dim count As Long = 0
        Dim getWS As Boolean = True
        Dim CardPaymentConfig As cardPaymentConfigObject
        Dim pkid As Integer = 0

        Try
            MakeConnection()
            If Not isConnected Then Exit Sub

            daNut.DeleteCardPaymentConfig()
            While (getWS)
                CardPaymentConfig = ws.getNextCardPaymentConfig(pkid, True)
                pkid = CardPaymentConfig.pkid
                If (pkid > 0) Then
                    count += 1
                    DebugPrint(count & ": Get CardPaymentConfig: " & pkid)
                    getWS = daNut.InsertCardPaymentConfig(CardPaymentConfig)
                    RaiseEvent Progress(count, "CardPaymentConfig")
                Else
                    getWS = False
                End If
            End While

        Catch ex As Exception
            DebugPrint(CLASSNAME & " - GetCardPaymentConfig." & "Error : " & ex.Message)
            getWS = False
            isError = True
        End Try

        CloseConnection()
        DebugPrint(CLASSNAME & " - Closing GetCardPaymentConfig")

    End Sub


    Public Sub GetCashAccount()

        DebugPrint(CLASSNAME & " - Starting GetCashAccount")

        Dim count As Long = 0
        Dim getWS As Boolean = True
        Dim CashAccount As cashAccountObject
        Dim pkid As Integer = 0

        Try
            MakeConnection()
            If Not isConnected Then Exit Sub

            daNut.DeleteCashAccount()
            While (getWS)
                CashAccount = ws.getNextCashAccount(pkid, True, gBranchObj.accPCCenterId, True)
                pkid = CashAccount.pkId
                If (pkid > 0) Then
                    count += 1
                    DebugPrint(count & ": Get CashAccount: " & pkid)
                    getWS = daNut.InsertCashAccount(CashAccount)
                    RaiseEvent Progress(count, "CashAccount")
                Else
                    getWS = False
                End If
            End While

        Catch ex As Exception
            DebugPrint(CLASSNAME & " - GetCashAccount." & "Error : " & ex.Message)
            getWS = False
            isError = True
        End Try

        CloseConnection()
        DebugPrint(CLASSNAME & " - Closing GetCashAccount")

    End Sub


    Public Sub GetCategoryTree()

        DebugPrint(CLASSNAME & " - Starting GetCategoryTree")

        Dim count As Long = 0
        Dim getWS As Boolean = True
        Dim CategoryTree As categoryTreeObject
        Dim pkid As Integer = 0

        Try
            MakeConnection()
            If Not isConnected Then Exit Sub

            daNut.DeleteCategoryTree()
            While (getWS)
                CategoryTree = ws.getNextCategoryTree(pkid, True)
                pkid = CategoryTree.pkid
                If (pkid > 0) Then
                    count += 1
                    DebugPrint(count & ": Get CategoryTree: " & pkid)
                    getWS = daNut.InsertCategoryTree(CategoryTree)
                    RaiseEvent Progress(count, "CategoryTree")
                Else
                    getWS = False
                End If
            End While

        Catch ex As Exception
            DebugPrint(CLASSNAME & " - GetCategoryTree." & "Error : " & ex.Message)
            getWS = False
            isError = True
        End Try

        CloseConnection()
        DebugPrint(CLASSNAME & " - Closing GetCategoryTree")

    End Sub


    Public Sub GetCustAccount()

        DebugPrint(CLASSNAME & " - Starting GetCustAccount")

        Dim count As Long = 0
        Dim getWS As Boolean = True
        Dim CustAccount As custAccountObject
        Dim pkid As Integer = 0

        Try
            MakeConnection()
            If Not isConnected Then Exit Sub

            daNut.DeleteCustAccount()
            While (getWS)
                CustAccount = ws.getNextCustAccount(pkid, True)
                pkid = CustAccount.pkid
                If (pkid > 0) Then
                    count += 1
                    DebugPrint(count & ": Get CustAccount: " & pkid)
                    getWS = daNut.InsertCustAccount(CustAccount)
                    RaiseEvent Progress(count, "CustAccount")
                Else
                    getWS = False
                End If
            End While

        Catch ex As Exception
            DebugPrint(CLASSNAME & " - GetCustAccount." & "Error : " & ex.Message)
            getWS = False
            isError = True
        End Try

        CloseConnection()
        DebugPrint(CLASSNAME & " - Closing GetCustAccount")

    End Sub


    Public Sub GetCustUser()

        DebugPrint(CLASSNAME & " - Starting GetCustUser")

        Dim count As Long = 0
        Dim getWS As Boolean = True
        Dim custUser As custUserObject
        Dim pkid As Integer = 0

        Try
            MakeConnection()
            If Not isConnected Then Exit Sub

            daNut.DeleteCustUser()
            While (getWS)
                custUser = ws.getNextCustUser(pkid, True)
                pkid = custUser.pkid
                If (pkid > 0) Then
                    count += 1
                    DebugPrint(count & ": Get CustUser: " & pkid)
                    getWS = daNut.InsertCustUser(custUser)
                    RaiseEvent Progress(count, "CustUser")
                Else
                    getWS = False
                End If
            End While

        Catch ex As Exception
            DebugPrint(CLASSNAME & " - GetCustUser." & "Error : " & ex.Message)
            getWS = False
            isError = True
        End Try

        CloseConnection()
        DebugPrint(CLASSNAME & " - Closing GetCustUser")

    End Sub

    Public Sub GetItem()

        DebugPrint(CLASSNAME & " - Starting GetItem")

        Dim count As Long = 0
        Dim getWS As Boolean = True
        Dim item As itemObject
        Dim pkid As Integer = 0
        Dim lastupdate As DateTime = daNut.GetLastSyncTime

        Try
            MakeConnection()
            If Not isConnected Then Exit Sub

            daNut.DeleteItem()
            While (getWS)
                item = ws.getNextItem(pkid, True, lastupdate)
                DebugPrint("Item name: " & item.name)
                pkid = item.pkid

                If (pkid > 0) Then
                    count += 1
                    DebugPrint(count & ": Get Item: " & pkid)
                    getWS = daNut.InsertItem(item)
                    RaiseEvent Progress(count, "Item")
                Else
                    getWS = False
                End If
            End While

        Catch ex As Exception
            DebugPrint(CLASSNAME & " - GetItem." & "Error : " & ex.Message)
            getWS = False
            isError = True
        End Try

        CloseConnection()
        DebugPrint(CLASSNAME & " - Closing GetItem")

    End Sub


    Public Sub GetSerialNumberDelta()

        DebugPrint(CLASSNAME & " - Starting GetSerialNumberDelta")

        Dim count As Long = 0
        Dim getWS As Boolean = True
        Dim SerialNumberDelta As serialNumberDeltaObject
        Dim guid As String = ""
        Try

            MakeConnection()
            If Not isConnected Then Exit Sub

            daNut.DeleteSerialNumber()
            While (getWS)
                SerialNumberDelta = ws.getNextSerialNumberDelta(guid, gBranchObj.invLocationId, True)
                guid = SerialNumberDelta.guid
                If (guid <> "") Then
                    count += 1
                    DebugPrint(count & ": Get SerialNumberDelta: " & guid)
                    getWS = daNut.InsertSerialNumberDelta(SerialNumberDelta)
                    RaiseEvent Progress(count, "SerialNumberDelta")
                Else
                    getWS = False
                End If
            End While

        Catch ex As Exception
            DebugPrint(CLASSNAME & " - GetSerialNumberDelta." & "Error : " & ex.Message)
            getWS = False
            isError = True
        End Try

        CloseConnection()
        DebugPrint(CLASSNAME & " - Closing GetSerialNumberDelta")

    End Sub


    Public Sub GetStock()

        DebugPrint(CLASSNAME & " - Starting GetStock")

        Dim count As Long = 0
        Dim getWS As Boolean = True
        Dim Stock As stockObject
        Dim pkid As Integer = 0

        Try
            MakeConnection()
            If Not isConnected Then Exit Sub

            daNut.DeleteStock()
            While (getWS)
                Stock = ws.getNextStock(pkid, True, gBranchObj.invLocationId, True)
                pkid = Stock.pkid
                If (pkid > 0) Then
                    count += 1
                    DebugPrint(count & ": Get Stock: " & pkid)
                    getWS = daNut.InsertStock(Stock)
                    RaiseEvent Progress(count, "Stock")
                Else
                    getWS = False
                End If
            End While

        Catch ex As Exception
            DebugPrint(CLASSNAME & " - GetStock." & "Error : " & ex.Message)
            getWS = False
            isError = True
        End Try

        CloseConnection()
        DebugPrint(CLASSNAME & " - Closing GetStock")

    End Sub


    Public Sub GetTaxConfig()

        DebugPrint(CLASSNAME & " - Starting GetTaxConfig")

        Dim count As Long = 0
        Dim getWS As Boolean = True
        Dim TaxConfig As taxConfigObject
        Dim pkid As Integer = 0

        Try
            MakeConnection()
            If Not isConnected Then Exit Sub

            daNut.DeleteTaxConfig()
            While (getWS)
                TaxConfig = ws.getNextTaxConfig(pkid, True)
                pkid = TaxConfig.pkid
                If (pkid > 0) Then
                    count += 1
                    DebugPrint(count & ": Get TaxConfig: " & pkid)
                    getWS = daNut.InsertTaxConfig(TaxConfig)
                    RaiseEvent Progress(count, "TaxConfig")
                Else
                    getWS = False
                End If
            End While

        Catch ex As Exception
            DebugPrint(CLASSNAME & " - GetTaxConfig." & "Error : " & ex.Message)
            getWS = False
            isError = True
        End Try

        CloseConnection()
        DebugPrint(CLASSNAME & " - Closing GetTaxConfig")

    End Sub


    Public Sub GetUser()

        DebugPrint(CLASSNAME & " - Starting GetUser")

        Dim count As Long = 0
        Dim getWS As Boolean = True
        Dim User As userObject
        Dim pkid As Integer = 0

        Try
            MakeConnection()
            If Not isConnected Then Exit Sub

            daNut.DeleteUser()
            daNut.DeletePermission()

            While (getWS)
                User = ws.getNextUser(pkid, True)
                pkid = User.userId
                If (pkid > 0) Then
                    count += 1
                    DebugPrint(count & ": Get User: " & pkid)
                    getWS = daNut.InsertUser(User)

                    If getWS Then
                        Dim csvString As String
                        csvString = ws.getUserPermissionList(pkid, True)
                        daNut.InsertPermission(pkid, csvString)
                    End If
                    RaiseEvent Progress(count, "User")
                Else
                    getWS = False
                End If
            End While

        Catch ex As Exception
            DebugPrint(CLASSNAME & " - GetUser." & "Error : " & ex.Message)
            getWS = False
            isError = True
        End Try

        CloseConnection()
        DebugPrint(CLASSNAME & " - Closing GetUser")

    End Sub


    Public Sub GetOfficialReceipt()

        DebugPrint(CLASSNAME & " - Starting GetOfficialReceipt")

        Dim count As Long = 0
        Dim getWS As Boolean = True
        Dim officialReceipt As officialReceiptObject
        Dim pkid As Integer = 0

        Try
            MakeConnection()
            If Not isConnected Then Exit Sub

            While (getWS)
                officialReceipt = ws.getNextOfficialReceipt(pkid, True)
                pkid = officialReceipt.pkid
                If (pkid > 0) Then
                    count += 1
                    DebugPrint(count & ": Get OfficialReceipt: " & pkid)
                    getWS = daNut.InsertOfficialReceipt(officialReceipt)
                    RaiseEvent Progress(count, "OfficialReceipt")
                Else
                    getWS = False
                End If
            End While

        Catch ex As Exception
            DebugPrint(CLASSNAME & " - GetOfficialReceipt." & "Error : " & ex.Message)
            getWS = False
            isError = True
        End Try

        CloseConnection()
        DebugPrint(CLASSNAME & " - Closing GetOfficialReceipt")

    End Sub

    '20100511 Jimmy: RISIS-92
    Public Function GetServerTime() As String

        Dim time As String = FormatDateTime(Now)
        DebugPrint(CLASSNAME & " - Starting GetServerTime")

        Try
            MakeConnection()
            If isConnected Then
                time = ws.getServerTime
            End If

        Catch ex As Exception
            DebugPrint(CLASSNAME & " - GetServerTime." & "Error : " & ex.Message)
            isError = True
        End Try

        Return time

        CloseConnection()
        DebugPrint(CLASSNAME & " - Closing GetServerTime")

    End Function
    ' End 20100511 Jimmy

    Public Sub InsertNextTransaction()

        DebugPrint(CLASSNAME & " - Starting InsertNextTransaction")

        Dim count As Long = 0
        Dim getWS As Boolean = True
        Dim ds As New DataSet
        Dim arrList As New ArrayList
        Dim arrTxnQ As New ArrayList
        Dim arrPkid As New ArrayList

        Try
            MakeConnection()
            If Not isConnected Then Exit Sub

            While (getWS)
                'ds = daNut.GetTCTxQueueByTxn
                'If ds.Tables.Count = 0 Then getWS = False

                'Dim sbPkid As New System.Text.StringBuilder
                'Dim csvString As String = gGetDataTableToCSV(ds.Tables(0), ",", sbPkid)

                'If ws.insertTransactionQueue(csvString) Then
                '    daNut.UpdateTCTxQueueByStatus(sbPkid.ToString, DATCTxQueue.STATUS_COMPLETE)
                'Else
                '    getWS = False
                '    Messenger.ShowError("Upload Transaction Error!")
                'End If
                'count += ds.Tables.Count

                arrTxnQ.Clear()
                If gAppConfig.UploadByLimit Then
                    arrList = daNut.GetTCTxQueue(gAppConfig.UploadLimit)
                Else
                    arrList = daNut.GetTCTxQueueByTxn
                End If

                If arrList.Count = 0 Then
                    getWS = False
                Else
                    For Each obj As DATCTxQueueObject In arrList

                        Dim qo As New txQueueObject
                        'qo.pkid = row(DATCTxQueue.PKID)
                        'qo.pkidSpecified = True
                        'qo.pkString = row(DATCTxQueue.PK_STRING)
                        'qo.fkString = row(DATCTxQueue.FK_STRING)
                        'qo.category = row(DATCTxQueue.CATEGORY)
                        'qo.source = row(DATCTxQueue.SOURCE)
                        'qo.type = row(DATCTxQueue.TYPE)
                        'qo.xml = row(DATCTxQueue.OBJECT_XML)
                        'qo.userid = row(DATCTxQueue.USERID)
                        'qo.useridSpecified = True
                        'qo.status = row(DATCTxQueue.STATUS)
                        'qo.date_created = row(DATCTxQueue.DATE_CREATED)
                        'qo.date_createdSpecified = True
                        'qo.date_received = Now
                        'qo.date_receivedSpecified = True
                        'qo.date_completed = row(DATCTxQueue.DATE_COMPLETED)
                        'qo.date_completedSpecified = True
                        'qo.branchid = row(DATCTxQueue.BRANCH_ID)
                        'qo.branchidSpecified = True
                        'qo.amount = row(DATCTxQueue.AMOUNT)
                        'qo.amountSpecified = True
                        'qo.status = DATCTxQueue.STATUS_PENDING
                        'qo.mode = row(DATCTxQueue.MODE)

                        qo.pkid = obj.pkid
                        qo.pkidSpecified = True
                        qo.pkString = obj.pkString
                        qo.fkString = obj.fkString
                        qo.category = obj.category
                        qo.source = obj.source
                        qo.type = obj.type
                        qo.xml = obj.objectXML
                        qo.userid = obj.userId
                        qo.useridSpecified = True
                        qo.status = obj.status
                        qo.date_created = obj.dateCreated
                        qo.date_createdSpecified = True
                        qo.date_received = Now
                        qo.date_receivedSpecified = True
                        qo.date_completed = obj.dateCompleted
                        qo.date_completedSpecified = True
                        qo.branchid = obj.branchid
                        qo.branchidSpecified = True
                        qo.amount = obj.amount
                        qo.amountSpecified = True
                        qo.status = DATCTxQueue.STATUS_PENDING
                        qo.mode = obj.mode

                        arrTxnQ.Add(qo)
                        arrPkid.Add(obj.pkid.ToString)
                    Next

                    'If ws.insertNextTransaction(qo) Then
                    'daNut.UpdateTCTxQueue(obj)
                    'End If                

                    If ws.insertTransactionQueue(arrTxnQ.ToArray(GetType(txQueueObject))) Then
                        'For Each obj As DATCTxQueueObject In arrList
                        'daNut.UpdateTCTxQueue(obj)
                        'Next
                        Dim strCsv As String = ""
                        strCsv = String.Join(",", arrPkid.ToArray(GetType(String)))
                        daNut.UpdateTCTxQueueByStatus(strCsv, DATCTxQueue.STATUS_COMPLETE)
                    Else
                        getWS = False
                        Messenger.ShowError("Upload Transaction Error!")
                    End If

                    count += arrTxnQ.Count
                    RaiseEvent Progress(count, "Transaction")
                End If

            End While

        Catch ex As Exception
            DebugPrint(CLASSNAME & " - InsertNextTransaction." & "Error : " & ex.Message)
            isError = True
            getWS = False
        End Try

        CloseConnection()
        DebugPrint(CLASSNAME & " - Closing InsertNextTransaction")

    End Sub


    Public Sub InsertAuditTrail()

        DebugPrint(CLASSNAME & " - Starting InsertAuditTrail")

        Dim count As Long = 0
        Dim getWS As Boolean = True
        Dim arrList As New ArrayList

        Try
            MakeConnection()
            If Not isConnected Then Exit Sub

            Dim atObj As New auditTrailObject

            With atObj
                .userId = gUserObj.userid
                .userIdSpecified = True
                .time = Now
                .timeSpecified = True
                .auditType = 700
                .tc_action = "synchronization"
                .remarks = "Synchronization From " & gBranchObj.code
                .tc_entity_table = DABranch.TABLENAME
                .tc_entity_id = gBranchObj.pkid
                .tc_entity_idSpecified = True
            End With

            getWS = ws.insertAuditTrail(atObj)
            RaiseEvent Progress(1, "Audit Trail")

        Catch ex As Exception
            DebugPrint(CLASSNAME & " - InsertAuditTrail." & "Error : " & ex.Message)
            getWS = False
        End Try

        CloseConnection()
        DebugPrint(CLASSNAME & " - Closing InsertAuditTrail")

    End Sub

    Public Sub InsertPosSyncTiming(ByVal startTime As DateTime, ByVal endTime As DateTime, _
                ByVal status As String)

        'insert pos_sync_timing
        Dim obj As New DAPosSyncTimingObject
        obj.branchId = gBranchObj.pkid
        obj.posId = gSysConfig.PosId
        obj.userId = gUserObj.userid
        obj.timeStart = startTime
        obj.timeEnd = endTime
        obj.status = status

        daNut.InsertPosSyncTiming(obj)

    End Sub

    Public Sub GetAll()

        'Me.GetBranch()
        'Me.GetUser()
        'Me.GetCardPaymentConfig()
        'Me.GetCashAccount()
        'Me.GetTaxConfig()
        'Me.GetCustAccount()
        'Me.GetCustUser()
        ''Me.GetOfficialReceipt()
        'Me.GetItem()
        'Me.GetCategoryTree()
        'Me.GetStock()
        'Me.GetSerialNumberDelta()

        Me.InsertNextTransaction()
        Me.InsertAuditTrail()
    End Sub


    Public Sub GetFirst()
        Dim start As DateTime = GetServerTime()
       
        Me.GetBranch()
        Me.GetUser()
        Me.GetCardPaymentConfig()
        Me.GetCashAccount()
        Me.GetTaxConfig()
        Me.GetCustAccount()
        Me.GetCustUser()
        Me.GetItem()
        Me.GetCategoryTree()
        Me.GetStock()
        Me.GetSerialNumberDelta()
        Me.InsertAuditTrail()

        If Not isError Then
            InsertPosSyncTiming(start, GetServerTime, DAPosSyncTiming.STATUS_DOWNLOAD)
        End If

    End Sub


    Public Sub Upload()
        Dim start As DateTime = GetServerTime()

        Me.InsertNextTransaction()
        Me.InsertAuditTrail()

        InsertPosSyncTiming(start, GetServerTime, DAPosSyncTiming.STATUS_UPLOAD)
    End Sub

End Class
