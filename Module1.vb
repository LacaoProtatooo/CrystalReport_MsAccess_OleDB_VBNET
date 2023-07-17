Imports System.Data.OleDb

Module Module1
    ' Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\vince\Documents\MyDatabase.accdb

    Public connStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\vince\Documents\MyDatabase.accdb"
    Public conn As New OleDbConnection(connStr)

    ' Your Database Content
    Public aid As String
    Public aname As String
    Public aage As String
    Public aaddress As String

    Function connect()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Return True
    End Function

End Module
