
Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call konek()
        textuser.Focus()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call konek()
        cmd = New OleDb.OleDbCommand("SELECT * from login where username='" & textuser.Text & "'and password='" & textpass.Text & "'", koneksi)
        dr = cmd.ExecuteReader
        dr.Read()

        If Not dr.HasRows Then
            MsgBox("login Gagal")
            textuser.Clear()
            textpass.Clear()
            textuser.Focus()
        Else
            Me.Visible = False
            Form3.Show()


        End If

    End Sub
End Class