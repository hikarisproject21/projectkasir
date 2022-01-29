Imports System.Data.OleDb
Public Class Form6
    Public Belanjaan As New ArrayList()
    Public CheckedOut As New Boolean
    Public TotalBelanja As New Integer

    Dim Barang As New ArrayList()

    Dim KodeBarang As String
    Dim NamaBarang As String
    Dim JumlahBarang As String

    Dim kode_barang As String
    Dim nama_barang As String
    Dim jumlah_barang As String
    Dim total_harga As Integer
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
            Dim belanja As New Dictionary(Of String, Object)
            belanja.Add("kode_barang", Item.SubItems(0).Text)
            belanja.Add("nama_barang", Item.SubItems(1).Text)
            belanja.Add("jumlah_barang", Item.SubItems(2).Text)
            belanja.Add("total_harga", CInt(Item.SubItems(3).Text.Replace(".", "")) * CInt(Item.SubItems(2).Text))

            Belanjaan.Add(belanja)
        Next

        If CheckedOut = False Then
            For Each belanja In Belanjaan
                KodeBarang += belanja("kode_barang") & "/"
                NamaBarang += belanja("nama_barang") & "/"
                JumlahBarang += belanja("jumlah_barang") & "/"
                TotalBelanja += belanja("total_harga")
            Next
            CheckedOut = True
        End If

        kode_barang = KodeBarang.Remove(KodeBarang.Length - 1)
        nama_barang = NamaBarang.Remove(NamaBarang.Length - 1)
        jumlah_barang = JumlahBarang.Remove(JumlahBarang.Length - 1)
        total_harga = TotalBelanja

        cmd = New OleDbCommand("INSERT INTO tbl_transaksi VALUES('','" & kode_barang & "','" & nama_barang & "','" & jumlah_barang & "','" & total_harga & "')", koneksi)

        ' Form7.Show()
    End Sub
End Class