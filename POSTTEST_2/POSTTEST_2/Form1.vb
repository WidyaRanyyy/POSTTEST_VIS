Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup kolom DataGridView
        LstBuku.Columns.Clear()
        LstBuku.ColumnCount = 2
        LstBuku.Columns(0).Name = "Judul Buku"
        LstBuku.Columns(1).Name = "Genre"
        LstBuku.Columns(0).Width = 160
        LstBuku.Columns(1).Width = 140
        LstBuku.AllowUserToAddRows = False
        LstBuku.ReadOnly = True
        LstBuku.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        refreshDataGrid()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        Dim judul As String = txtJudul.Text.Trim()
        Dim genre As String = txtgenre.Text.Trim()

        If judul = "" Or genre = "" Then
            MessageBox.Show("Judul dan Genre tidak boleh kosong!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        tambahBuku(judul, genre)
        refreshDataGrid()

        txtJudul.Clear()
        txtgenre.Clear()
        txtJudul.Focus()

        MessageBox.Show("Buku '" & judul & "' berhasil ditambahkan!", "Berhasil",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim judul As String = txtHapusJudul.Text.Trim()

        If judul = "" Then
            MessageBox.Show("Masukkan judul buku yang ingin dihapus!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Cek apakah buku ditemukan
        Dim ditemukan As Boolean = False
        For i As Integer = 0 To jumlahBuku - 1
            If daftarBuku(i, 0).ToLower() = judul.ToLower() Then
                ditemukan = True
                Exit For
            End If
        Next

        If Not ditemukan Then
            MessageBox.Show("Buku '" & judul & "' tidak ditemukan!", "Gagal",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim konfirmasi As DialogResult = MessageBox.Show(
            "Yakin ingin menghapus buku '" & judul & "'?", "Konfirmasi Hapus",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            hapusBuku(judul)
            refreshDataGrid()
            txtHapusJudul.Clear()
            MessageBox.Show("Buku berhasil dihapus!", "Berhasil",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub refreshDataGrid()
        LstBuku.Rows.Clear()
        For i As Integer = 0 To jumlahBuku - 1
            LstBuku.Rows.Add(daftarBuku(i, 0), daftarBuku(i, 1))
        Next
    End Sub

    Private Sub LstBuku_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles LstBuku.CellContentClick

    End Sub
End Class