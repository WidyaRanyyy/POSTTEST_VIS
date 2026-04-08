Public Class Form1

    Dim fotoPath As String = ""

    ' =====================
    ' VALIDASI INPUT
    ' =====================

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not (Char.IsLetter(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or e.KeyChar = Chr(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8)) Then
            e.Handled = True
        End If
    End Sub

    ' =====================
    ' BROWSE FOTO
    ' =====================
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        If ofd.ShowDialog() = DialogResult.OK Then
            fotoPath = ofd.FileName
            picFoto.Image = Image.FromFile(fotoPath)
        End If
    End Sub

    ' =====================
    ' VALIDASI & SIMPAN CETAK
    ' =====================
    Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles btnSimpanCetak.Click
        ' Cek inputan kosong - Tab 1
        If txtNama.Text.Trim = "" Then
            MessageBox.Show("Inputan tidak boleh kosong: Nama", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tabMain.SelectedIndex = 0 : txtNama.Focus() : Exit Sub
        End If
        If txtID.Text.Trim = "" Then
            MessageBox.Show("Inputan tidak boleh kosong: NIM", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tabMain.SelectedIndex = 0 : txtID.Focus() : Exit Sub
        End If
        If cmbKomunitas.SelectedIndex = -1 Then
            MessageBox.Show("Inputan tidak boleh kosong: Divisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tabMain.SelectedIndex = 0 : cmbKomunitas.Focus() : Exit Sub
        End If
        If Not rbLakiLaki.Checked AndAlso Not rbPerempuan.Checked Then
            MessageBox.Show("Inputan tidak boleh kosong: Jenis Kelamin", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tabMain.SelectedIndex = 0 : Exit Sub
        End If

        ' Cek inputan kosong - Tab 2
        If mtxtTelepon.Text.Trim = "" OrElse mtxtTelepon.Text.Contains("_") Then
            MessageBox.Show("Inputan tidak boleh kosong atau format telepon salah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tabMain.SelectedIndex = 1 : mtxtTelepon.Focus() : Exit Sub
        End If
        If txtEmail.Text.Trim = "" Then
            MessageBox.Show("Inputan tidak boleh kosong: Email", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tabMain.SelectedIndex = 1 : txtEmail.Focus() : Exit Sub
        End If
        If txtAlamat.Text.Trim = "" Then
            MessageBox.Show("Inputan tidak boleh kosong: Alamat", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tabMain.SelectedIndex = 1 : txtAlamat.Focus() : Exit Sub
        End If

        ' Cek inputan kosong - Tab 3
        Dim adaHobby As Boolean = chkCoding.Checked Or chkDesign.Checked Or chkMusik.Checked Or
                                   chkOlahraga.Checked Or chkFotografi.Checked Or chkMenulis.Checked Or
                                   chkGaming.Checked Or chkMasak.Checked
        If Not adaHobby Then
            MessageBox.Show("Inputan tidak boleh kosong: Pilih minimal 1 hobby/aktivitas", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tabMain.SelectedIndex = 2 : Exit Sub
        End If

        ' Konfirmasi cetak
        Dim hasil As DialogResult = MessageBox.Show("Simpan dan cetak kartu?", "Konfirmasi",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            ' Kumpulkan hobby
            Dim hobbyList As New List(Of String)
            If chkCoding.Checked Then hobbyList.Add("Coding")
            If chkDesign.Checked Then hobbyList.Add("Design")
            If chkMusik.Checked Then hobbyList.Add("Musik")
            If chkOlahraga.Checked Then hobbyList.Add("Olahraga")
            If chkFotografi.Checked Then hobbyList.Add("Fotografi")
            If chkMenulis.Checked Then hobbyList.Add("Menulis")
            If chkGaming.Checked Then hobbyList.Add("Gaming")
            If chkMasak.Checked Then hobbyList.Add("Memasak")

            ' Tentukan gender
            Dim gender As String = ""
            If rbLakiLaki.Checked Then gender = "Laki-Laki"
            If rbPerempuan.Checked Then gender = "Perempuan"

            ' Tentukan peran
            Dim peran As String = "Anggota"
            If rbKetua.Checked Then peran = "Ketua"
            If rbWakil.Checked Then peran = "Wakil"
            If rbPengawas.Checked Then peran = "Pengawas"
            If rbAnggota.Checked Then peran = "Anggota"

            ' Buka Form Hasil
            Dim frmHasil As New FormHasil
            frmHasil.lblNamaHasil.Text = txtNama.Text
            frmHasil.lblIDHasil.Text = txtID.Text
            frmHasil.lblKomunitasHasil.Text = cmbKomunitas.Text
            frmHasil.lblKontakHasil.Text = mtxtTelepon.Text & " | " & txtEmail.Text
            frmHasil.lblHobbyHasil.Text = String.Join(", ", hobbyList)
            frmHasil.lblTglLahirHasil.Text = dtpLahir.Value.ToString("dd MMMM yyyy")
            frmHasil.lblPeranHasil.Text = peran
            frmHasil.lblGenderHasil.Text = gender
            If fotoPath <> "" Then frmHasil.picFotoHasil.Image = Image.FromFile(fotoPath)
            frmHasil.ShowDialog()
        End If
    End Sub

    ' =====================
    ' MENU - SIMPAN DATA
    ' =====================
    Private Sub mnuSimpan_Click(sender As Object, e As EventArgs) Handles mnuSimpan.Click
        sfd.Filter = "Text File|*.txt|CSV File|*.csv"
        sfd.FileName = "DataAnggota"
        If sfd.ShowDialog() = DialogResult.OK Then
            Dim isi As String = $"Nama: {txtNama.Text}{vbCrLf}ID: {txtID.Text}{vbCrLf}Komunitas: {cmbKomunitas.Text}{vbCrLf}Telepon: {mtxtTelepon.Text}{vbCrLf}Email: {txtEmail.Text}"
            System.IO.File.WriteAllText(sfd.FileName, isi)
            MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' =====================
    ' MENU - BUKA DATA
    ' =====================
    Private Sub mnuBuka_Click(sender As Object, e As EventArgs) Handles mnuBuka.Click
        ofd.Filter = "Text File|*.txt|CSV File|*.csv"
        If ofd.ShowDialog() = DialogResult.OK Then
            Dim baris() As String = System.IO.File.ReadAllLines(ofd.FileName)
            For Each b As String In baris
                If b.StartsWith("Nama: ") Then txtNama.Text = b.Replace("Nama: ", "")
                If b.StartsWith("NIM: ") Then txtID.Text = b.Replace("NIM: ", "")
                If b.StartsWith("Divisi: ") Then cmbKomunitas.Text = b.Replace("Divisi: ", "")
                If b.StartsWith("Telepon: ") Then mtxtTelepon.Text = b.Replace("Telepon: ", "")
                If b.StartsWith("Email: ") Then txtEmail.Text = b.Replace("Email: ", "")
            Next
            MessageBox.Show("Data berhasil dibuka!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' =====================
    ' MENU - KELUAR
    ' =====================
    Private Sub mnuKeluar_Click(sender As Object, e As EventArgs) Handles mnuKeluar.Click
        Dim hasil As DialogResult = MessageBox.Show("Yakin ingin keluar?", "Konfirmasi Keluar",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then Application.Exit()
    End Sub

    ' =====================
    ' MENU - LIHAT KARTU
    ' =====================
    Private Sub mnuLihatKartu_Click(sender As Object, e As EventArgs) Handles mnuLihatKartu.Click
        btnSimpanCetak.PerformClick()
    End Sub

End Class