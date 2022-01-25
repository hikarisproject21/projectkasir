Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbException

Public Class formloginkasir
    Sub kondisiawal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        tampildata()

    End Sub
    Sub tampildata()
        konek()
        da = New OleDbDataAdapter("SELECT * from login", koneksi)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "login")
        dataloginkasir.DataSource = (ds.Tables("login"))

    End Sub

    Private Sub formloginkasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiawal()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Pastikan data diisi lengkap")
        Else
            konek()
            cmd = New OleDb.OleDbCommand("Insert into login values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')", koneksi)
            cmd.ExecuteNonQuery()
            MsgBox("data berhasil ditambahkan")
            Call kondisiawal()
        End If
    End Sub

    Private Sub dataloginkasir_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataloginkasir.CellContentClick
        TextBox1.Text = dataloginkasir.Rows(e.RowIndex).Cells(0).Value
        TextBox2.Text = dataloginkasir.Rows(e.RowIndex).Cells(1).Value
        TextBox3.Text = dataloginkasir.Rows(e.RowIndex).Cells(2).Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        konek()
        cmd = New OleDb.OleDbCommand("UPDATE login SET username='" & TextBox2.Text & "',password='" & TextBox3.Text & "'WHERE kode_login='" & TextBox1.Text & "',", koneksi)
        cmd.ExecuteNonQuery()
        MsgBox("data berhasil diedit")
        diskonek()
        tampildata()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        konek()
        cmd = New OleDbCommand("DELETE FROM login WHERE username='" & TextBox2.Text & "'", koneksi)
        cmd.ExecuteNonQuery()
        MsgBox("Data berhasil Dihapus")
        diskonek()
        tampildata()
        kondisiawal()
    End Sub
End Class