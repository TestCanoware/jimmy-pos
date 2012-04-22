Imports MySql.Data.MySqlClient
Imports Utils
Imports System.IO

Public Class Commands

    Public Enum ReturnType
        DataReaderType
        DataSetType
    End Enum

    Public Shared conn As New MySqlConnection
    Public Shared config As New SysConfig

    Private strConnect As String

    Public Sub ConnectDatabase()
        'strConnect = "Database={0};Data Source={1};User Id={2};Password={3}"
        strConnect = "Database={0};Server={1};Uid={2};Pwd={3};Connection Timeout=3600;charset=utf8"
        strConnect = String.Format(strConnect, config.DB, config.Server, config.UserId, config.Password)

        If conn.State = ConnectionState.Closed Then
            conn.ConnectionString = strConnect
            conn.Open()
        End If

    End Sub

    '------------------------------------------------------------
    ' Overload Procedure
    ' Used when accessing database not defined in sysconfig
    ' User need to supply database name is DA class
    '------------------------------------------------------------
    Public Sub ConnectDatabase(ByVal database As String)
        strConnect = "Database={0};Server={1};Uid={2};Pwd={3};Connection Timeout=3600;charset=utf8"
        strConnect = String.Format(strConnect, database, config.Server, config.UserId, config.Password)

        If conn.State = ConnectionState.Closed Then
            conn.ConnectionString = strConnect
            conn.Open()
        End If

    End Sub

    Public Sub DisconnectDatabase()
        Try
            conn.Close()
        Catch ex As MySqlException

        Finally
            conn.Dispose()
        End Try

    End Sub

    Public Function ExecuteQuery(ByVal CommandText As String, ByVal ResultType As ReturnType) As Object

        Try
            ConnectDatabase()

            Select Case ResultType
                Case ReturnType.DataSetType
                    Dim ds As New DataSet
                    Dim da As MySqlDataAdapter

                    ' Create the dataset
                    da = New MySqlDataAdapter(CommandText, conn)
                    da.Fill(ds)
                    da.Dispose()
                    DisconnectDatabase()
                    Return ds

                Case ReturnType.DataReaderType
                    Dim com As New MySqlCommand(CommandText, conn)
                    Return com.ExecuteReader

            End Select

            DisconnectDatabase()
            Return Nothing

        Catch ex As Exception
            Throw New System.Exception(ex.Message, ex.InnerException)
            DisconnectDatabase()
            Return Nothing
        End Try


    End Function


    ' temp - need delete
    Public Function ExecuteQuery(ByVal CommandText As String, ByVal strTableName As String, ByVal ResultType As ReturnType) As Object

        Try
            ConnectDatabase()

            Select Case ResultType
                Case ReturnType.DataSetType
                    Dim ds As New DataSet
                    Dim da As MySqlDataAdapter

                    ' Create the dataset
                    da = New MySqlDataAdapter(CommandText, conn)
                    da.Fill(ds)
                    da.Dispose()
                    DisconnectDatabase()
                    Return ds

                Case ReturnType.DataReaderType
                    Dim com As New MySqlCommand(CommandText, conn)
                    Return com.ExecuteReader

            End Select

            DisconnectDatabase()
            Return Nothing

        Catch ex As Exception
            Throw New System.Exception(ex.Message, ex.InnerException)
            DisconnectDatabase()
            Return Nothing
        End Try

    End Function

    Public Function ExecuteNonQuery(ByVal commandText As String) As Integer

        Dim intUpdated As Integer = 0
        ConnectDatabase()

        Dim com As MySqlCommand

        com = New MySqlCommand(commandText, conn)

        'Timeout expired.  The timeout period elapsed prior to completion of the operation or the server is not responding.
        'com.CommandTimeout = 120

        intUpdated = com.ExecuteNonQuery()
        DisconnectDatabase()

        com.Dispose()

        Return intUpdated

    End Function


    Public Sub ExecuteNonQueryWithParameters(ByVal commandText As String, ByVal paraName As String, ByVal paraValue As Object)

        ConnectDatabase()

        Dim com As MySqlCommand

        com = New MySqlCommand(commandText, conn)
        com.Parameters.AddWithValue(paraName, paraValue)

        com.ExecuteNonQuery()
        DisconnectDatabase()

        com.Dispose()

    End Sub

    ' Example using Transaction
    Public Sub RunTransaction(ByVal myConnString As String)
        Dim myConnection As New MySqlConnection(myConnString)
        myConnection.Open()

        Dim myCommand As MySqlCommand = myConnection.CreateCommand()
        Dim myTrans As MySqlTransaction

        ' Start a local transaction
        myTrans = myConnection.BeginTransaction()
        ' Must assign both transaction object and connection
        ' to Command object for a pending local transaction
        myCommand.Connection = myConnection
        myCommand.Transaction = myTrans

        Try
            myCommand.CommandText = "Insert into Region (RegionID, RegionDescription) VALUES (100, 'Description')"
            myCommand.ExecuteNonQuery()
            myCommand.CommandText = "Insert into Region (RegionID, RegionDescription) VALUES (101, 'Description')"
            myCommand.ExecuteNonQuery()
            myTrans.Commit()
            Console.WriteLine("Both records are written to database.")
        Catch e As Exception
            Try
                myTrans.Rollback()
            Catch ex As MySqlException
                If Not myTrans.Connection Is Nothing Then
                    Console.WriteLine("An exception of type " & ex.GetType().ToString() & _
                    " was encountered while attempting to roll back the transaction.")
                End If
            End Try
            Console.WriteLine("An exception of type " & e.GetType().ToString() & _
         "was encountered while inserting the data.")
            Console.WriteLine("Neither record was written to database.")
        Finally
            myConnection.Close()
        End Try
    End Sub 'RunTransaction

    Private Shared myTrans As MySqlTransaction

    Public Sub BeginTransaction()
        ConnectDatabase()
        myTrans = conn.BeginTransaction()
    End Sub

    Public Sub Rollback()
        Try
            myTrans.Rollback()
        Catch ex As MySqlException
            If Not myTrans.Connection Is Nothing Then
                Console.WriteLine("An exception of type " & ex.GetType().ToString() & _
                " was encountered while attempting to roll back the transaction.")
            End If
        End Try
        DisconnectDatabase()
    End Sub

    Public Sub Commit()
        myTrans.Commit()
        DisconnectDatabase()
    End Sub

    Public Function ExecuteNonQueryTransaction(ByVal commandText As String) As Integer

        Dim intUpdated As Integer = 0
        Dim com As MySqlCommand

        com = New MySqlCommand(commandText, conn)
        com.Transaction = myTrans

        'Timeout expired.  The timeout period elapsed prior to completion of the operation or the server is not responding.
        'com.CommandTimeout = 120

        intUpdated = com.ExecuteNonQuery()
        'DisconnectDatabase()

        com.Dispose()

        Return intUpdated

    End Function

    Public Function ExecuteQueryTransaction(ByVal CommandText As String, ByVal ResultType As ReturnType) As Object

        Try

            Select Case ResultType
                Case ReturnType.DataSetType
                    Dim ds As New DataSet
                    Dim da As MySqlDataAdapter

                    ' Create the dataset
                    da = New MySqlDataAdapter(CommandText, conn)
                    da.Fill(ds)
                    da.Dispose()
                    Return ds

                Case ReturnType.DataReaderType
                    Dim com As New MySqlCommand(CommandText, conn)
                    'com.Transaction = myTrans
                    Return com.ExecuteReader

            End Select

            Return Nothing

        Catch ex As Exception
            Throw New System.Exception(ex.Message, ex.InnerException)
            Return Nothing
        End Try


    End Function

    Public Sub BackupMySql()

        Dim localDir As String = "path to where to save file"
        Dim strDate As String = Date.Now.ToShortDateString   'Prepend file with date for dated backups
        Dim fileName As String = strDate.Replace("/", "-") & "_" & "wsemp" & ".sql"
        Dim saveFile As String = localDir & fileName

        Dim tablesCommand As MySqlCommand = conn.CreateCommand()
        Dim rowsCommand As MySqlCommand = conn.CreateCommand()
        Dim tablesReader As MySqlDataReader
        Dim rowsReader As MySqlDataReader

        tablesCommand.CommandText = "SHOW TABLES FROM " & config.DB
        conn.Open()
        tablesReader = tablesCommand.ExecuteReader()

        Dim query As String = ""
        Dim tablesArray As New ArrayList()
        While tablesReader.Read()
            tablesArray.Add(tablesReader.GetValue(0).ToString())
        End While

        tablesReader.Close()

        For i = 0 To tablesArray.Count - 1
            query += "DROP TABLE IF EXISTS `" & tablesArray(i) & "`;" & vbCrLf '& Database & "."
            query += vbCrLf & "CREATE TABLE `" & tablesArray(i) & "` (" & vbCrLf
            rowsCommand.CommandText = "DESCRIBE " & tablesArray(i)
            rowsReader = rowsCommand.ExecuteReader()

            Dim temp As String = ""
            While rowsReader.Read()
                query += "`" & rowsReader.GetString("Field") & "` " & rowsReader.GetString("Type")

                If Not rowsReader.GetString("Null") = "YES" Then
                    query += " NOT NULL"
                End If

                If IsDBNull(rowsReader.Item("Default")) = False Then
                    query += " DEFAULT '" & rowsReader.GetString("Default") & "'"
                End If

                If Not rowsReader.GetString("Extra") = Nothing Then
                    query += " " & rowsReader.GetString("Extra").ToUpper()
                End If

                If rowsReader.GetString("Key") = "PRI" Then
                    temp = "primary key(" & rowsReader.GetString("Field") & ")"
                End If

                query += "," & vbCrLf
            End While

            query += temp & vbCrLf & ");" & vbCrLf & vbCrLf
            rowsReader.Close()

            rowsCommand.CommandText = "SELECT * FROM " & tablesArray(i)
            rowsReader = rowsCommand.ExecuteReader()

            While rowsReader.Read()
                query += "INSERT INTO `" & tablesArray(i) & "` ("
                Dim count As Integer = rowsReader.FieldCount - 1
                Dim keys(count) As String
                Dim values(count) As String

                For n = 0 To count
                    keys(n) = rowsReader.GetName(n)
                    values(n) = rowsReader.Item(n)
                Next

                query += Join(keys, ", ") & ")" & vbCrLf & "VALUES ('" & Join(values, "', '") & "');" & vbCrLf
            End While

            rowsReader.Close()

            query += vbCrLf & vbCrLf
        Next

        conn.Close()
        conn.Dispose()

        If File.Exists(saveFile) Then
            File.Delete(saveFile)
        End If


        Dim objWriter As New System.IO.StreamWriter(saveFile)
        objWriter.Write(query)
        objWriter.Close()

    End Sub

End Class
