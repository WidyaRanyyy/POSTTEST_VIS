Imports MySqlConnector

Public Class FormCheckOut

    ' 1. Load Data Tamu yang belum check-out ke ComboBox
    Private Sub LoadTamuAktif()
        Try
            Using conn As MySqlConnection = ConnectionModule.GetConnection()
                ' Mengambil tamu yang ID-nya belum ada di tabel transaksi
                Dim query As String = "SELECT t.id_checkin, t.nama_tamu FROM tamu t LEFT JOIN transaksi tr ON t.id_checkin = tr.id_checkin WHERE tr.id_transaksi IS NULL"
                Using cmd As New MySqlCommand(query, conn)
                    conn.Open()
                    Using rd As MySqlDataReader = cmd.ExecuteReader()
                        cmbPilihTamu.Items.Clear()
                        While rd.Read()
                            ' Menyimpan format "ID - Nama Tamu" di combobox
                            cmbPilihTamu.Items.Add(rd("id_checkin").ToString() & " - " & rd("nama_tamu").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data tamu: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FormCheckOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Isi pilihan kotak metode pembayaran
        cmbMetodeBayar.Items.Clear()
        cmbMetodeBayar.Items.Add("Tunai")
        cmbMetodeBayar.Items.Add("Transfer Bank")
        cmbMetodeBayar.Items.Add("QRIS")
        cmbMetodeBayar.Items.Add("Kartu Kredit")

        ' 2. Panggil data tamu dari database
        LoadTamuAktif()
    End Sub

    ' 2. Saat nama tamu dipilih, otomatis tarik data kamar dan harga
    Private Sub cmbPilihTamu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPilihTamu.SelectedIndexChanged
        If cmbPilihTamu.SelectedIndex = -1 Then Exit Sub

        ' Mengambil ID CheckIn
        Dim idCheckIn As String = cmbPilihTamu.Text.Split("-"c)(0).Trim()

        Try
            Using conn As MySqlConnection = ConnectionModule.GetConnection()
                ' MENGGUNAKAN LEFT JOIN: Agar data tamu tetap muncul meski kamarnya tidak ada di tabel master
                Dim query As String = "SELECT t.nomor_kamar, t.tanggal, k.harga FROM tamu t LEFT JOIN kamar k ON t.nomor_kamar = k.nomor_kamar WHERE t.id_checkin = @id"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", idCheckIn)
                    conn.Open()
                    Using rd As MySqlDataReader = cmd.ExecuteReader()
                        If rd.Read() Then
                            txtKamar.Text = rd("nomor_kamar").ToString()
                            txtTglCheckIn.Text = Convert.ToDateTime(rd("tanggal")).ToString("dd-MM-yyyy")

                            ' Cek apakah harga ditemukan (jika nomor kamar ngawur, harga akan kosong)
                            If IsDBNull(rd("harga")) Then
                                txtHarga.Text = "0"
                                MessageBox.Show("Peringatan: Kamar " & txtKamar.Text & " tidak ditemukan di data Master Kamar. Harga di-set 0.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                txtHarga.Text = rd("harga").ToString()
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menarik detail: " & ex.Message)
        End Try
    End Sub


    ' 3. Tombol untuk menghitung total tagihan
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        If txtTglCheckIn.Text = "" Then Exit Sub

        ' Menghitung selisih hari
        Dim tglMasuk As DateTime = DateTime.ParseExact(txtTglCheckIn.Text, "dd-MM-yyyy", Nothing)
        Dim tglKeluar As DateTime = dtpCheckOut.Value.Date
        Dim lamaInap As Integer = (tglKeluar - tglMasuk).Days

        ' Jika check-out di hari yang sama, dihitung minimal 1 hari
        If lamaInap = 0 Then lamaInap = 1

        If lamaInap < 0 Then
            MessageBox.Show("Tanggal Check-Out tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        txtLamaMenginap.Text = lamaInap.ToString()

        ' Hitung total (Lama Inap x Harga Kamar)
        Dim harga As Integer = Convert.ToInt32(txtHarga.Text)
        Dim totalTagihan As Integer = lamaInap * harga
        txtTotalTagihan.Text = totalTagihan.ToString()
    End Sub

    ' 4. Tombol Proses Pembayaran & Check Out
    Private Sub btnProsesBayar_Click(sender As Object, e As EventArgs) Handles btnProsesBayar.Click
        If txtTotalTagihan.Text = "" Or cmbMetodeBayar.Text = "" Then
            MessageBox.Show("Silakan hitung tagihan dan pilih metode pembayaran!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim idCheckIn As String = cmbPilihTamu.Text.Split("-"c)(0).Trim()
        Dim tglKeluarSQL As String = dtpCheckOut.Value.ToString("yyyy-MM-dd")

        Try
            Using conn As MySqlConnection = ConnectionModule.GetConnection()
                conn.Open()

                ' Gunakan Transaction agar jika salah satu gagal, semuanya dibatalkan
                Using tr As MySqlTransaction = conn.BeginTransaction()
                    Try
                        ' A. Simpan ke tabel Transaksi
                        Dim queryInsert As String = "INSERT INTO transaksi (id_checkin, tgl_checkout, lama_menginap, total_tagihan, metode_bayar) VALUES (@id, @tgl, @lama, @total, @metode)"
                        Using cmd1 As New MySqlCommand(queryInsert, conn, tr)
                            cmd1.Parameters.AddWithValue("@id", idCheckIn)
                            cmd1.Parameters.AddWithValue("@tgl", tglKeluarSQL)
                            cmd1.Parameters.AddWithValue("@lama", txtLamaMenginap.Text)
                            cmd1.Parameters.AddWithValue("@total", txtTotalTagihan.Text)
                            cmd1.Parameters.AddWithValue("@metode", cmbMetodeBayar.Text)
                            cmd1.ExecuteNonQuery()
                        End Using

                        ' B. Update status kamar menjadi 'Kotor' (harus dibersihkan sebelum dijual lagi)
                        Dim queryUpdate As String = "UPDATE kamar SET status = 'Kotor' WHERE nomor_kamar = @kamar"
                        Using cmd2 As New MySqlCommand(queryUpdate, conn, tr)
                            cmd2.Parameters.AddWithValue("@kamar", txtKamar.Text)
                            cmd2.ExecuteNonQuery()
                        End Using

                        tr.Commit() ' Terapkan semua perubahan
                        MessageBox.Show("Pembayaran berhasil! Kamar " & txtKamar.Text & " kini berstatus Kotor/Perlu Dibersihkan.", "Check-Out Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Reset form
                        cmbPilihTamu.SelectedIndex = -1
                        cmbPilihTamu.Text = ""
                        txtKamar.Clear()
                        txtHarga.Clear()
                        txtTglCheckIn.Clear()
                        txtLamaMenginap.Clear()
                        txtTotalTagihan.Clear()
                        cmbMetodeBayar.SelectedIndex = -1
                        LoadTamuAktif() ' Refresh daftar tamu

                    Catch ex2 As Exception
                        tr.Rollback() ' Batalkan jika ada error
                        Throw ex2
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memproses transaksi: " & ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class