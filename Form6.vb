Imports System.Data.OleDb
Public Class Form6
    Dim Barang As ArrayList = New ArrayList()
    Sub tampildata()
        konek()
        Dim cmd As New OleDbCommand("SELECT * from tbl_barang", koneksi)

        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        While reader.Read()
            ComboBox1.Items.Add((reader.GetString(0), reader.GetString(1), reader.GetString(2)))
        End While

        diskonek()
    End Sub
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListViewOutput.GridLines = True
        ListViewOutput.View = View.Details
        ListViewOutput.Columns.Add("Kode Barang")
        ListViewOutput.Columns.Add("Nama Barang")
        ListViewOutput.Columns.Add("Jumlah")
        ListViewOutput.Columns.Add("Harga")
        ListViewOutput.AutoResizeColumns(0)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        For Each Item As ListViewItem In ListViewOutput.SelectedItems
            Item.Remove()
        Next
    End Sub
End Class