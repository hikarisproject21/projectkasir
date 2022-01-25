Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbException
Public Class form_product
    Sub kondisiawal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        tampildata()

    End Sub
    Sub tampildata()
        konek()
        da = New OleDbDataAdapter("SELECT * from tbl_barang", koneksi)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbl_barang")
        DataGridView1.DataSource = (ds.Tables("tbl_barang"))
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Pastikan data diisi lengkap")
        Else
            konek()
            cmd = New OleDb.OleDbCommand("Insert into tbl_barang values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')", koneksi)
            cmd.ExecuteNonQuery()
            MsgBox("data berhasil ditambahkan")
            Call kondisiawal()
        End If
    End Sub

    Private Sub form_product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiawal()
    End Sub
End Class