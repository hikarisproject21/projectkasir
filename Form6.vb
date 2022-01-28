Imports System.Data.OleDb
Public Class Form6
    Public TotalBelanja As New Integer
    Dim Barang As New ArrayList()
    Sub tampildata()
        konek()
        cmd = New OleDbCommand("SELECT * from tbl_barang", koneksi)

        dr = cmd.ExecuteReader()

        If dr.HasRows Then
            Do While dr.Read()
                ' Insert each column into a dictionary
                Dim data As New Dictionary(Of String, Object)
                For i As Integer = 0 To (dr.FieldCount - 1)
                    data.Add(dr.GetName(i), dr(i))
                Next
                ' Add the dictionary to the ArrayList
                Barang.Add(data)

                ' ComboBox1.Items.Add(dr.GetInt32(0) & " - " & dr.GetString(1))
            Loop
        End If

        dr.Close()
        diskonek()
    End Sub
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampildata()

        For Each brg As Dictionary(Of String, Object) In Barang
            ComboBox1.Items.Add(brg("kode_barang") & " - " & brg("nama_barang"))
        Next

        ListViewOutput.GridLines = True
        ListViewOutput.View = View.Details
        ListViewOutput.Columns.Add("Kode Barang")
        ListViewOutput.Columns.Add("Nama Barang")
        ListViewOutput.Columns.Add("Jumlah")
        ListViewOutput.Columns.Add("Harga")

        ComboBox1.Focus()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Arr As String() = ComboBox1.Text.Split(" - ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
        Dim Dipilih As New Dictionary(Of String, Object)

        For Each brg As Dictionary(Of String, Object) In Barang
            If brg("kode_barang") = Arr(0) Then
                Dipilih = brg
            End If
        Next

        Dim ListItem As New ListViewItem
        ListItem = ListViewOutput.Items.Add(Dipilih("kode_barang"))
        ListItem.SubItems.Add(Dipilih("nama_barang"))
        ListItem.SubItems.Add(NumericUpDown1.Value)
        ListItem.SubItems.Add(Dipilih("harga"))
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        For Each Item As ListViewItem In ListViewOutput.SelectedItems
            Item.Remove()
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        For Each Item As ListViewItem In ListViewOutput.Items
            TotalBelanja += CInt(Item.SubItems(3).Text.Replace(".", "")) * CInt(Item.SubItems(2).Text)
        Next

        Form7.Show()
    End Sub
End Class