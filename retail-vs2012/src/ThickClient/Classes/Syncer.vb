Imports ThickClient.EMPThickClientService
Imports Utils.General

Public Class Syncer



    Private objDA As New DAMain
    Public updateDate As Date = Now
    Public ctl As Control

    Public Declare Function GetInputState Lib "user32" () As Long

    Public Sub New()
        MyBase.New()
        'ss = New EMPThickClientClient
        'ss.Endpoint.Address = New System.ServiceModel.EndpointAddress(webService)
    End Sub

    Public Sub makeConnection()

    End Sub


    Public Sub Sync_Branch(ByVal webService As String)
        Dim ds As DataSet = Nothing
        Dim count As Integer
        Dim syncBranch As Boolean = True

        Dim ss As New EMPThickClientClient
        ss.Endpoint.Address = New System.ServiceModel.EndpointAddress(webService)

        'Sync Branch
        DebugPrint("Starting Branch Sync")
        Dim branchID As Integer = 0
        count = 0
        While (syncBranch)
            Try
                Dim branch As branchObject
                branch = ss.getNextBranch(branchID)

                If (branch.pkid > 0) Then
                    count += 1
                    branchID = branch.pkid
                    DebugPrint(count & ": Got Branch: " & branchID)
                    If objDA.isExistTC(branchID, "acc_branch_index") Then
                        objDA.updateBranch(branch)
                        DebugPrint("Branch " & branchID & " updated.")
                    Else
                        objDA.insertBranch(branch)
                        DebugPrint("Branch " & branchID & " inserted.")
                    End If
                Else
                    syncBranch = False
                End If

            Catch ex As Exception
                DebugPrint("Error Branch Sync : " & ex.Message)
                syncBranch = False
                Throw New Exception(ex.Message)
            End Try

        End While
        DebugPrint("Closing Branch Sync")
        ss.Close()
        ss.Abort()
    End Sub


    Public Sub Sync_User(ByVal webService As String, Optional ByRef userControl As Control = Nothing)

        Dim ds As DataSet = Nothing
        Dim count As Integer
        Dim syncUser As Boolean = True

        Dim ss As New EMPThickClientClient
        ss.Endpoint.Address = New System.ServiceModel.EndpointAddress(webService)

        'Sync User
        DebugPrint("Starting User Sync")
        Dim userId As Integer = 0
        count = 0
        While (syncUser)
            Try
                Dim user As userObject
                user = ss.getNextUser(userId)

                If (user.userId > 0) Then
                    count += 1
                    userId = user.userId
                    DebugPrint(count & ": Got User: " & user.userId & ", " & user.userName)

                    If userControl IsNot Nothing Then
                        userControl.Text = "User's Records: " & count
                        newDoEvents()
                    End If

                    If objDA.getUserName(userId) <> "" Then
                        If userId <> 500 And userId <> 501 Then
                            objDA.updateUser(user)
                            DebugPrint("User " & userId & " updated.")
                        End If
                    Else
                        objDA.insertUser(user)
                        DebugPrint("User " & userId & " inserted.")
                    End If

                    'Sync User Permission
                    'DebugPrint("Starting User Permission")
                    'Dim permissionList As userPermissionListObject

                    'Try
                    '    permissionList = ss.getUserPermissionList(userId)
                    '    If permissionList.permList <> "" Then
                    '        objDA.insertUserPermission(permissionList)
                    '        DebugPrint("Insert / Update User Permission")
                    '    End If
                    'Catch ex As Exception

                    'End Try
                    'DebugPrint("Closing User Permission")
                Else
                    syncUser = False
                End If
            Catch ex As Exception
                DebugPrint("Error User Sync: " & ex.Message)
                syncUser = False
            End Try
        End While
        DebugPrint("Closing User Sync")
    End Sub


    Public Sub Sync_Item(ByVal webService As String, Optional ByRef itemControl As Control = Nothing)

        Dim ds As DataSet = Nothing
        Dim count As Integer
        Dim syncItem As Boolean = True

        Dim ss As New EMPThickClientClient
        ss.Endpoint.Address = New System.ServiceModel.EndpointAddress(webService)

        'Sync Inventory item
        DebugPrint("Starting Inventory Item Sync")
        Dim itemID As Integer = 0
        count = 0
        While (syncItem)
            Try
                Dim itemObj As itemObject
                itemObj = ss.getNextItem(itemID)
                If (itemObj.pkid > 0) Then
                    count += 1
                    itemID = itemObj.pkid
                    DebugPrint(count & ": Got Item: " & itemID)

                    If itemControl IsNot Nothing Then
                        itemControl.Text = "Item's Records: " & count
                        newDoEvents()
                    End If

                    If objDA.isExistTC(itemID, "inv_item") Then
                        objDA.updateItem(itemObj)
                        DebugPrint("Item " & itemID & " updated.")
                    Else
                        objDA.insertItem(itemObj)
                        DebugPrint("Item " & itemID & " inserted.")
                    End If
                Else
                    syncItem = False
                End If
            Catch ex As Exception
                DebugPrint("Error Inventory Item Sync : " & ex.Message)
                syncItem = False
            End Try
        End While
        DebugPrint("Closing Inventory Item Sync")
    End Sub


    Public Sub Sync_Stock(ByVal webService As String, Optional ByRef stockControl As Control = Nothing)
        Dim ds As DataSet = Nothing
        Dim count As Integer
        Dim syncStock As Boolean = True

        Dim ss As New EMPThickClientClient
        ss.Endpoint.Address = New System.ServiceModel.EndpointAddress(webService)

        'Sync Balance of Inv_stock
        DebugPrint("Starting Inv_Stock Sync")
        Dim stockID As Integer = 0
        count = 0
        While (syncStock)
            Try
                Dim stock As stockObject
                stock = ss.getNextStock(stockID, gLocationID)

                If (stock.pkid > 0) Then
                    count += 1
                    stockID = stock.pkid
                    DebugPrint(count & ": Got Stock: " & stock.pkid)
                    If stockControl IsNot Nothing Then
                        stockControl.Text = "Stock's Records: " & count
                        newDoEvents()
                    End If
                    If objDA.isExistTC(stock.pkid, "inv_stock") Then
                        objDA.updateStock(stock)
                        DebugPrint("Stock " & stockID & " updated.")
                    Else
                        objDA.insertStock(stock)
                        DebugPrint("Stock " & stockID & " inserted.")
                    End If
                Else
                    syncStock = False
                End If
            Catch ex As Exception
                DebugPrint("Error Inv_stock Sync : " & ex.Message)
                syncStock = False
            End Try
        End While
        DebugPrint("Closing Inv_stock Sync")

    End Sub

    Public Sub Sync_CashAcc(ByVal webService As String, Optional ByRef cashAccControl As Control = Nothing)

        Dim ds As DataSet = Nothing
        Dim count As Integer
        Dim syncCashAcc As Boolean = True

        Dim ss As New EMPThickClientClient
        ss.Endpoint.Address = New System.ServiceModel.EndpointAddress(webService)

        'Sync Cash Account
        DebugPrint("Starting Cash Account Sync")
        Dim cashAccID As Integer = 0
        count = 0
        While (syncCashAcc)
            Try
                Dim cashAcc As cashAccountObject
                cashAcc = ss.getNextCashAccount(cashAccID, gPCCenterID)

                If (cashAcc.pkId > 0) Then
                    count += 1
                    cashAccID = cashAcc.pkId
                    DebugPrint(count & ": Got Cash Account: " & cashAccID)

                    If cashAccControl IsNot Nothing Then
                        cashAccControl.Text = "Cash Account's Records: " & count
                        newDoEvents()
                    End If

                    If objDA.isExistTC(cashAcc.pkId, "acc_cash_account") Then
                        objDA.updateCashAccount(cashAcc)
                        DebugPrint("Cash Account " & cashAccID & " updated.")
                    Else
                        objDA.insertCashAccount(cashAcc)
                        DebugPrint("Cash Account " & cashAccID & " inserted.")
                    End If
                    'lastUpdateCashAcc = cashAcc.lastUpdate
                Else
                    syncCashAcc = False
                End If
            Catch ex As Exception
                DebugPrint("Error Cash Account Sync : " & ex.Message)
                syncCashAcc = False
            End Try
        End While
        DebugPrint("Closing Cash Account Sync")
    End Sub

    Public Sub Sync_CategoryTree(ByVal webService As String, Optional ByRef categoryTreeControl As Control = Nothing)

        Dim ds As DataSet = Nothing
        Dim count As Integer
        Dim syncCategoryTree As Boolean = True

        Dim ss As New EMPThickClientClient
        ss.Endpoint.Address = New System.ServiceModel.EndpointAddress(webService)

        'Sync Cash Account
        DebugPrint("Starting Categpory Tree Sync")
        Dim categoryTreeID As Integer = 0
        count = 0
        While (syncCategoryTree)
            Try
                Dim categoryTree As categoryTreeObject
                categoryTree = ss.getNextCategoryTree(categoryTreeID)

                If (categoryTree.pkid > 0) Then
                    count += 1
                    categoryTreeID = categoryTree.pkid
                    DebugPrint(count & ": Got Category Tree: " & categoryTreeID)

                    If categoryTreeControl IsNot Nothing Then
                        categoryTreeControl.Text = "Category Tree's Records: " & count
                        newDoEvents()
                    End If

                    If objDA.isExistTC(categoryTree.pkid, "inv_category_tree") Then
                        objDA.updateCategoryTree(categoryTree)
                        DebugPrint("Category Tree " & categoryTreeID & " updated.")
                    Else
                        objDA.insertCategoryTree(categoryTree)
                        DebugPrint("Category Tree " & categoryTreeID & " inserted.")
                    End If
                    'lastUpdateCashAcc = cashAcc.lastUpdate
                Else
                    syncCategoryTree = False
                End If
            Catch ex As Exception
                DebugPrint("Error Category Tree Sync : " & ex.Message)
                syncCategoryTree = False
            End Try
        End While
        DebugPrint("Closing Category Tree Sync")
    End Sub

    Public Sub Sync_TC(ByVal webService As String)
        Dim ds As DataSet = Nothing
        Dim syncDatabase As Boolean = True

        Dim ss As New EMPThickClientClient
        ss.Endpoint.Address = New System.ServiceModel.EndpointAddress(webService)

        DebugPrint("Starting TC Sync")
        'Sync TC
        objDA.getTCObject(ds)
        If ds.Tables(0).Rows.Count = 0 Then
            DebugPrint(" 0 records")
        Else
            DebugPrint(ds.Tables(0).Rows.Count.ToString & " records")
            For Each row As DataRow In ds.Tables(0).Rows
                Dim qo As New txQueueObject
                qo.pkid = row("pkid")
                qo.pkidSpecified = True
                qo.pkString = row("pk_string")
                qo.fkString = row("fk_string")
                qo.category = row("category")
                qo.source = row("source")
                qo.type = row("type")
                qo.xml = row("object_xml")
                qo.userid = row("userid")
                qo.useridSpecified = True
                qo.status = row("status")
                qo.date_created = row("date_created")
                qo.date_createdSpecified = True
                qo.date_received = row("date_received")
                qo.date_receivedSpecified = True
                qo.date_completed = row("date_completed")
                qo.date_completedSpecified = True

                DebugPrint("TC: " & qo.pkid & " " & qo.userid)
                Dim returnValue As Boolean = ss.insertNextTransaction(qo)
                gConnectWS = True
                DebugPrint(returnValue.ToString)
                If returnValue Then
                    objDA.updateTC(row("pkid"))
                    DebugPrint("Update TC: " & row("pkid"))
                End If
            Next
        End If
        DebugPrint("Closing TC Sync")

    End Sub

    Public Sub Sync_First(ByVal webService As String, ByRef userControl As Control, ByRef itemControl As Control, _
                            ByRef stockControl As Control, ByRef cashAccControl As Control, ByRef categoryTreeControl As Control)

        DebugPrint("Starting Sync...")

        Sync_User(webService, userControl)
        Sync_Item(webService, itemControl)
        Sync_Stock(webService, stockControl)
        Sync_CashAcc(webService, cashAccControl)
        Sync_CategoryTree(webService, categoryTreeControl)

        DebugPrint("Closing Sync")

    End Sub


    Public Sub Sync()

        Dim ss As New EMPThickClientClient
        ss.Endpoint.Address = New System.ServiceModel.EndpointAddress(gConfigObj.WebService)

        DebugPrint("Starting Sync...")
        Dim ds As DataSet = Nothing
        Dim syncDatabase As Boolean = True


        DebugPrint("Starting TC Sync")
        'Sync TC
        objDA.getTCObject(ds)
        If ds.Tables(0).Rows.Count = 0 Then
            DebugPrint(" 0 records")
        Else
            DebugPrint(ds.Tables(0).Rows.Count.ToString & " records")
            For Each row As DataRow In ds.Tables(0).Rows
                Dim qo As New txQueueObject
                qo.pkid = row("pkid")
                qo.pkidSpecified = True
                qo.pkString = row("pk_string")
                qo.fkString = row("fk_string")
                qo.category = row("category")
                qo.source = row("source")
                qo.type = row("type")
                qo.xml = row("object_xml")
                qo.userid = row("userid")
                qo.useridSpecified = True
                qo.status = row("status")
                qo.date_created = row("date_created")
                qo.date_createdSpecified = True
                qo.date_received = row("date_received")
                qo.date_receivedSpecified = True
                qo.date_completed = row("date_completed")
                qo.date_completedSpecified = True

                DebugPrint("TC: " & qo.pkid & " " & qo.userid)
                Dim returnValue As Boolean = ss.insertNextTransaction(qo)
                gConnectWS = True
                DebugPrint(returnValue.ToString)
                If returnValue Then
                    objDA.updateTC(row("pkid"))
                    DebugPrint("Update TC: " & row("pkid"))
                End If
            Next
        End If
        DebugPrint("Closing TC Sync")

        ss.Close()
        DebugPrint("Closing Sync")

    End Sub

    Public Sub Run()
        While (True)
            Try
                System.Threading.Thread.Sleep(gConfigObj.SyncerTiming)
                Sync()
                gConnectWS = True
            Catch ex As Exception
                DebugPrint("Error run: " & ex.Message)
                gConnectWS = False
                'DebugPrint("Error : " & gConnectWS)
            End Try
        End While
    End Sub

    'Public Sub StopRun()

    '    Try
    '        If ss.State <> ServiceModel.CommunicationState.Closed Then
    '            ss.Close()
    '        End If
    '    Catch ex As Exception
    '        DebugPrint("Error StopRun: " & ex.Message)
    '    End Try

    'End Sub

    Public Sub DebugPrint(ByVal msg As String)
        Debug.Print(msg)

        'If ctl IsNot Nothing Then
        '    ctl.Text = msg
        'End If

        'If msg.Contains("Error") Then
        '    WriteToEventLog(msg, "VB.NET Application", EventLogEntryType.Error)
        'Else
        '    WriteToEventLog(msg)
        'End If

        WriteToLogFile(msg)

    End Sub

    Public Sub newDoEvents()
        'If GetInputState() <> 0 Then Application.DoEvents()
        Application.DoEvents()
    End Sub

End Class
