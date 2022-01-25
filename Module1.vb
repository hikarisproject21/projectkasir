Imports System.Data.OleDb
Module Module1
    Public cmd As OleDbCommand
    Public da As OleDbDataAdapter
    Public dt As DataTable
    Public ds As DataSet
    Public ketemu As Boolean
    Public dr As OleDbDataReader


    Public koneksi As New OleDbConnection("provider=microsoft.ace.oledb.12.0; data source=data.accdb")

    Sub konek()
        Try
            koneksi.Open()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Sub diskonek()
        koneksi.Close()

    End Sub
End Module