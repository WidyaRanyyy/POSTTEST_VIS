Imports MySqlConnector

Public Class FormCheckIn

    ' 1. Buat Sub khusus untuk menampilkan/me-refresh data dari Database ke DataGridView
    Private Sub TampilData()
        ' Query untuk mengambil data dari tabel tamu
        Dim query As String = "SELECT * FROM tamu ORDER BY id_checkin DESC"

        ' Memanfaatkan fungsi AmbilData dari ModulData yang sudah kita buat
        Dim dt As DataTable = ModulData.AmbilData(query)
        dgvCheckIn.DataSource = dt

        ' (Opsional) Mengubah nama header kolom agar lebih rapi
        If dgvCheckIn.Columns.Count > 0 Then
            dgvCheckIn.Columns(0).HeaderText = "ID"
            dgvCheckIn.Columns(1).HeaderText = "Nama Tamu"
            dgvCheckIn.Columns(2).HeaderText = "No. Kamar"
            dgvCheckIn.Columns(3).HeaderText = "Tanggal"
        End If
    End Sub

    ' 2. Saat Form Load, langsung tampilkan data dari database
    Private Sub FormCheckIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
    End Sub

    ' 3. Saat Tombol Simpan Ditekan
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ' Validasi form tidak boleh kosong
        If txtNama.Text = "" Or txtKamar.Text = "" Then
            MessageBox.Show("Nama dan Kamar harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            ' Buka koneksi menggunakan blok Using (Aman & Otomatis tertutup)
            Using conn As MySqlConnection = ConnectionModule.GetConnection()

                ' Query Insert dengan Parameter untuk keamanan (Mencegah SQL Injection)
                Dim query As String = "INSERT INTO tamu (nama_tamu, nomor_kamar, tanggal) VALUES (@nama, @kamar, @tgl)"

                Using cmd As New MySqlCommand(query, conn)
                    ' Memasukkan data dari TextBox ke Parameter Query
                    cmd.Parameters.AddWithValue("@nama", txtNama.Text)
                    cmd.Parameters.AddWithValue("@kamar", txtKamar.Text)

                    ' PENTING: MySQL meminta format tanggal YYYY-MM-DD
                    cmd.Parameters.AddWithValue("@tgl", dtpTanggal.Value.ToString("yyyy-MM-dd"))

                    ' Buka koneksi dan jalankan perintah simpan
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Data Check-In berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refresh tabel agar data yang baru disimpan langsung muncul
            TampilData()

            ' Bersihkan form untuk input selanjutnya
            txtNama.Clear()
            txtKamar.Clear()
            dtpTanggal.Value = DateTime.Now
            txtNama.Focus()

        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class