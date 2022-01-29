
Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call konek()
        textuser.Focus()
        Call diskonek()
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
            If dr(3) = "1" Then
                Me.Visible = False
                Form3.Show()
            ElseIf dr(3) = "2" Then
                MsgBox("Login gagal, hanya admin yang boleh masuk")
                textuser.Clear()
                textpass.Clear()
                textuser.Focus()
            End If
        End If
        Call diskonek()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
    End Sub
End Class