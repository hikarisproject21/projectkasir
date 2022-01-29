Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbException

Public Class formloginkasir
    Sub kondisiawal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = "- Pilih -"

        tampildata()
        diskonek()
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

        ComboBox1.Items.Add("Admin")
        ComboBox1.Items.Add("Kasir")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "- Pilih -" Then
            MsgBox("Pastikan data diisi lengkap")
        Else
            konek()
            If ComboBox1.Text = "Admin" Then
                cmd = New OleDbCommand("Insert into login values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & 1 & "')", koneksi)
                cmd.ExecuteNonQuery()
            ElseIf ComboBox1.Text = "Kasir" Then
                cmd = New OleDbCommand("Insert into login values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & 2 & "')", koneksi)
                cmd.ExecuteNonQuery()
            End If
            MsgBox("data berhasil ditambahkan")
            diskonek()
            Call kondisiawal()
        End If
    End Sub

    Private Sub dataloginkasir_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataloginkasir.CellContentClick
        TextBox1.Text = dataloginkasir.Rows(e.RowIndex).Cells(0).Value
        TextBox2.Text = dataloginkasir.Rows(e.RowIndex).Cells(1).Value
        TextBox3.Text = dataloginkasir.Rows(e.RowIndex).Cells(2).Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "- Pilih -" Then
            MsgBox("Pastikan data diisi lengkap")
        Else
            konek()
            If ComboBox1.Text = "Admin" Then
                cmd = New OleDbCommand("UPDATE login SET [username]='" & TextBox2.Text & "', [password]='" & TextBox3.Text & "', [role]='1' WHERE kode_login=" & TextBox1.Text, koneksi)
                cmd.ExecuteNonQuery()
            ElseIf ComboBox1.Text = "Kasir" Then
                cmd = New OleDbCommand("UPDATE login SET [username]='" & TextBox2.Text & "', [password]='" & TextBox3.Text & "', [role]='2' WHERE kode_login=" & TextBox1.Text, koneksi)
                cmd.ExecuteNonQuery()
            End If
            diskonek()
            MsgBox("data berhasil diedit")
            tampildata()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        konek()
        cmd = New OleDbCommand("DELETE FROM login WHERE kode_login=" & TextBox1.Text, koneksi)
        cmd.ExecuteNonQuery()
        MsgBox("Data berhasil Dihapus")
        diskonek()
        kondisiawal()
    End Sub
End Class