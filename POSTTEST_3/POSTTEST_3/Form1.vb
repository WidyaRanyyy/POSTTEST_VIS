Imports System.IO

Public Class Form1
    Dim grupHobi() As CheckBox
    Dim grupJK() As RadioButton

    ' =============================================
    '  VALIDASI SEMUA INPUT
    ' =============================================
    Private Function CekData() As Boolean
        grupHobi = {cbMenulis, cbMelukis, cbMenari, cbMenyanyi, cbMembaca,
                    cbKarate, cbTaekwondo, cbSilat, cbTinju, cbMuayThai,
                    cbBadminton, cbVoli}
        grupJK = {rbLaki, rbPerempuan}

        If Not ValidasiTextBox(txtNama, "Nama Tidak Boleh Kosong") Then Return False
        If Not ValidasiTextBox(txtUmur, "Umur Tidak Boleh Kosong") Then Return False
        If Not ValidasiTextBox(txtTelp, "No. Telp Tidak Boleh Kosong") Then Return False
        If Not ValidasiTextBox(txtAlamat, "Alamat Tidak Boleh Kosong") Then Return False
        If Not ValidasiDateTimePicker(dtpLahir, "Tanggal Lahir Tidak Boleh Kosong") Then Return False
        If Not ValidasiRadioButton(grupJK, "Pilih Jenis Kelamin Anda") Then Return False
        If Not ValidasiCheckBox(grupHobi, "Pilih Minimal 1 Hobi") Then Return False
        If Not ValidasiPictureBox(pbFoto, "Foto Tidak Boleh Kosong") Then Return False

        Return True
    End Function

    ' =============================================
    '  VALIDASI DATETIMEPICKER (ShowCheckBox = True)
    '  User wajib mencentang DTP sebelum memilih tanggal
    ' =============================================
    Public Function ValidasiDateTimePicker(dtp As DateTimePicker, pesan As String) As Boolean
        If Not dtp.Checked Then
            MessageBox.Show(pesan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    ' =============================================
    '  TOMBOL BROWSE FOTO
    ' =============================================
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim ofd As New OpenFileDialog()
        ofd.Title = "Pilih Foto"
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If ofd.ShowDialog() = DialogResult.OK Then
            pbFoto.Image = Image.FromFile(ofd.FileName)
            DataModule.Foto = ofd.FileName
        End If
    End Sub

    ' =============================================
    '  TOMBOL CETAK KARTU
    ' =============================================
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        grupHobi = {cbMenulis, cbMelukis, cbMenari, cbMenyanyi, cbMembaca,
                    cbKarate, cbTaekwondo, cbSilat, cbTinju, cbMuayThai,
                    cbBadminton, cbVoli}
        grupJK = {rbLaki, rbPerempuan}

        If CekData() Then
            ' Simpan semua data ke DataModule
            DataModule.Nama = txtNama.Text
            DataModule.Umur = txtUmur.Text
            DataModule.Telp = txtTelp.Text
            DataModule.Alamat = txtAlamat.Text
            DataModule.Tglahir = dtpLahir.Value
            DataModule.JK = GetSelectedRadioButton(grupJK)
            DataModule.Hobi = GetSelectedCheckBox(grupHobi)
            ' DataModule.Foto sudah diset saat Browse

            Dim frm2 As New Form2()
            frm2.Show()
        End If
    End Sub

    ' =============================================
    '  FILTER INPUT: HANYA HURUF (Nama)
    ' =============================================
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        HanyaHuruf(sender, e)
    End Sub

    ' =============================================
    '  FILTER INPUT: HANYA ANGKA (Umur & No.Telp)
    ' =============================================
    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        HanyaAngka(sender, e)
    End Sub

    Private Sub txtTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelp.KeyPress
        HanyaAngka(sender, e)
    End Sub

End Class