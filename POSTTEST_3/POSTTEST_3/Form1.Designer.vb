<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pbFoto = New PictureBox()
        btnBrowse = New Button()
        lblnama = New Label()
        lblumur = New Label()
        lbltelp = New Label()
        lbllahir = New Label()
        lblalamat = New Label()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtTelp = New TextBox()
        txtAlamat = New TextBox()
        Hobi = New GroupBox()
        cbVoli = New CheckBox()
        cbBadminton = New CheckBox()
        cbMuayThai = New CheckBox()
        cbTinju = New CheckBox()
        cbSilat = New CheckBox()
        cbTaekwondo = New CheckBox()
        cbKarate = New CheckBox()
        cbMembaca = New CheckBox()
        cbMenyanyi = New CheckBox()
        cbMenari = New CheckBox()
        cbMelukis = New CheckBox()
        cbMenulis = New CheckBox()
        Gender = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        dtpLahir = New DateTimePicker()
        btnCetak = New Button()
        CType(pbFoto, ComponentModel.ISupportInitialize).BeginInit()
        Hobi.SuspendLayout()
        Gender.SuspendLayout()
        SuspendLayout()

        ' ── pbFoto ──────────────────────────────────────────────────
        pbFoto.Location = New Point(46, 40)
        pbFoto.Name = "pbFoto"
        pbFoto.Size = New Size(234, 294)
        pbFoto.TabIndex = 0
        pbFoto.TabStop = False
        pbFoto.BorderStyle = BorderStyle.FixedSingle
        pbFoto.BackColor = Color.FromArgb(255, 240, 245)

        ' ── btnBrowse ───────────────────────────────────────────────
        btnBrowse.Location = New Point(107, 356)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(112, 34)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        btnBrowse.FlatStyle = FlatStyle.Flat
        btnBrowse.FlatAppearance.BorderColor = Color.FromArgb(219, 112, 147)
        btnBrowse.FlatAppearance.BorderSize = 1
        btnBrowse.BackColor = Color.FromArgb(255, 182, 193)
        btnBrowse.ForeColor = Color.FromArgb(100, 20, 50)
        btnBrowse.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        btnBrowse.Cursor = Cursors.Hand

        ' ── lblnama ─────────────────────────────────────────────────
        lblnama.AutoSize = True
        lblnama.Location = New Point(358, 40)
        lblnama.Name = "lblnama"
        lblnama.Size = New Size(59, 25)
        lblnama.TabIndex = 2
        lblnama.Text = "Nama"
        lblnama.ForeColor = Color.FromArgb(150, 30, 70)
        lblnama.Font = New Font("Segoe UI", 9, FontStyle.Bold)

        ' ── lblumur ─────────────────────────────────────────────────
        lblumur.AutoSize = True
        lblumur.Location = New Point(358, 89)
        lblumur.Name = "lblumur"
        lblumur.Size = New Size(56, 25)
        lblumur.TabIndex = 3
        lblumur.Text = "Umur"
        lblumur.ForeColor = Color.FromArgb(150, 30, 70)
        lblumur.Font = New Font("Segoe UI", 9, FontStyle.Bold)

        ' ── lbltelp ─────────────────────────────────────────────────
        lbltelp.AutoSize = True
        lbltelp.Location = New Point(358, 139)
        lbltelp.Name = "lbltelp"
        lbltelp.Size = New Size(71, 25)
        lbltelp.TabIndex = 4
        lbltelp.Text = "No.Telp"
        lbltelp.ForeColor = Color.FromArgb(150, 30, 70)
        lbltelp.Font = New Font("Segoe UI", 9, FontStyle.Bold)

        ' ── lbllahir ────────────────────────────────────────────────
        lbllahir.AutoSize = True
        lbllahir.Location = New Point(358, 197)
        lbllahir.Name = "lbllahir"
        lbllahir.Size = New Size(115, 25)
        lbllahir.TabIndex = 6
        lbllahir.Text = "Tanggal Lahir"
        lbllahir.TextAlign = ContentAlignment.TopCenter
        lbllahir.ForeColor = Color.FromArgb(150, 30, 70)
        lbllahir.Font = New Font("Segoe UI", 9, FontStyle.Bold)

        ' ── lblalamat ───────────────────────────────────────────────
        lblalamat.AutoSize = True
        lblalamat.Location = New Point(358, 311)
        lblalamat.Name = "lblalamat"
        lblalamat.Size = New Size(68, 25)
        lblalamat.TabIndex = 7
        lblalamat.Text = "Alamat"
        lblalamat.TextAlign = ContentAlignment.TopCenter
        lblalamat.ForeColor = Color.FromArgb(150, 30, 70)
        lblalamat.Font = New Font("Segoe UI", 9, FontStyle.Bold)

        ' ── txtNama ─────────────────────────────────────────────────
        txtNama.Location = New Point(493, 40)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(150, 31)
        txtNama.TabIndex = 8
        txtNama.BackColor = Color.FromArgb(255, 240, 245)
        txtNama.ForeColor = Color.FromArgb(100, 20, 50)
        txtNama.BorderStyle = BorderStyle.FixedSingle
        txtNama.Font = New Font("Segoe UI", 9)

        ' ── txtUmur ─────────────────────────────────────────────────
        txtUmur.Location = New Point(493, 89)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(150, 31)
        txtUmur.TabIndex = 9
        txtUmur.BackColor = Color.FromArgb(255, 240, 245)
        txtUmur.ForeColor = Color.FromArgb(100, 20, 50)
        txtUmur.BorderStyle = BorderStyle.FixedSingle
        txtUmur.Font = New Font("Segoe UI", 9)

        ' ── txtTelp ─────────────────────────────────────────────────
        txtTelp.Location = New Point(493, 139)
        txtTelp.Name = "txtTelp"
        txtTelp.Size = New Size(150, 31)
        txtTelp.TabIndex = 10
        txtTelp.BackColor = Color.FromArgb(255, 240, 245)
        txtTelp.ForeColor = Color.FromArgb(100, 20, 50)
        txtTelp.BorderStyle = BorderStyle.FixedSingle
        txtTelp.Font = New Font("Segoe UI", 9)

        ' ── txtAlamat ───────────────────────────────────────────────
        txtAlamat.Location = New Point(493, 311)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(150, 31)
        txtAlamat.TabIndex = 11
        txtAlamat.BackColor = Color.FromArgb(255, 240, 245)
        txtAlamat.ForeColor = Color.FromArgb(100, 20, 50)
        txtAlamat.BorderStyle = BorderStyle.FixedSingle
        txtAlamat.Font = New Font("Segoe UI", 9)

        ' ── Hobi (GroupBox) ─────────────────────────────────────────
        Hobi.Controls.Add(cbVoli)
        Hobi.Controls.Add(cbBadminton)
        Hobi.Controls.Add(cbMuayThai)
        Hobi.Controls.Add(cbTinju)
        Hobi.Controls.Add(cbSilat)
        Hobi.Controls.Add(cbTaekwondo)
        Hobi.Controls.Add(cbKarate)
        Hobi.Controls.Add(cbMembaca)
        Hobi.Controls.Add(cbMenyanyi)
        Hobi.Controls.Add(cbMenari)
        Hobi.Controls.Add(cbMelukis)
        Hobi.Controls.Add(cbMenulis)
        Hobi.Location = New Point(693, 40)
        Hobi.Name = "Hobi"
        Hobi.Size = New Size(527, 350)
        Hobi.TabIndex = 12
        Hobi.TabStop = False
        Hobi.Text = "Hobi"
        Hobi.BackColor = Color.FromArgb(255, 228, 235)
        Hobi.ForeColor = Color.FromArgb(150, 30, 70)
        Hobi.Font = New Font("Segoe UI", 9, FontStyle.Bold)

        ' ── cbVoli ──────────────────────────────────────────────────
        cbVoli.AutoSize = True
        cbVoli.Location = New Point(360, 102)
        cbVoli.Name = "cbVoli"
        cbVoli.Size = New Size(67, 29)
        cbVoli.TabIndex = 11
        cbVoli.Text = "Voli"
        cbVoli.ForeColor = Color.FromArgb(120, 20, 60)
        cbVoli.BackColor = Color.Transparent
        cbVoli.Font = New Font("Segoe UI", 9)

        ' ── cbBadminton ─────────────────────────────────────────────
        cbBadminton.AutoSize = True
        cbBadminton.Location = New Point(360, 52)
        cbBadminton.Name = "cbBadminton"
        cbBadminton.Size = New Size(125, 29)
        cbBadminton.TabIndex = 10
        cbBadminton.Text = "Badminton"
        cbBadminton.ForeColor = Color.FromArgb(120, 20, 60)
        cbBadminton.BackColor = Color.Transparent
        cbBadminton.Font = New Font("Segoe UI", 9)

        ' ── cbMuayThai ──────────────────────────────────────────────
        cbMuayThai.AutoSize = True
        cbMuayThai.Location = New Point(191, 265)
        cbMuayThai.Name = "cbMuayThai"
        cbMuayThai.Size = New Size(114, 29)
        cbMuayThai.TabIndex = 9
        cbMuayThai.Text = "MuayThai"
        cbMuayThai.ForeColor = Color.FromArgb(120, 20, 60)
        cbMuayThai.BackColor = Color.Transparent
        cbMuayThai.Font = New Font("Segoe UI", 9)

        ' ── cbTinju ─────────────────────────────────────────────────
        cbTinju.AutoSize = True
        cbTinju.Location = New Point(191, 207)
        cbTinju.Name = "cbTinju"
        cbTinju.Size = New Size(75, 29)
        cbTinju.TabIndex = 8
        cbTinju.Text = "Tinju"
        cbTinju.ForeColor = Color.FromArgb(120, 20, 60)
        cbTinju.BackColor = Color.Transparent
        cbTinju.Font = New Font("Segoe UI", 9)

        ' ── cbSilat ─────────────────────────────────────────────────
        cbSilat.AutoSize = True
        cbSilat.Location = New Point(191, 153)
        cbSilat.Name = "cbSilat"
        cbSilat.Size = New Size(71, 29)
        cbSilat.TabIndex = 7
        cbSilat.Text = "Silat"
        cbSilat.ForeColor = Color.FromArgb(120, 20, 60)
        cbSilat.BackColor = Color.Transparent
        cbSilat.Font = New Font("Segoe UI", 9)

        ' ── cbTaekwondo ─────────────────────────────────────────────
        cbTaekwondo.AutoSize = True
        cbTaekwondo.Location = New Point(191, 101)
        cbTaekwondo.Name = "cbTaekwondo"
        cbTaekwondo.Size = New Size(128, 29)
        cbTaekwondo.TabIndex = 6
        cbTaekwondo.Text = "Taekwondo"
        cbTaekwondo.ForeColor = Color.FromArgb(120, 20, 60)
        cbTaekwondo.BackColor = Color.Transparent
        cbTaekwondo.Font = New Font("Segoe UI", 9)

        ' ── cbKarate ────────────────────────────────────────────────
        cbKarate.AutoSize = True
        cbKarate.Location = New Point(191, 51)
        cbKarate.Name = "cbKarate"
        cbKarate.Size = New Size(87, 29)
        cbKarate.TabIndex = 5
        cbKarate.Text = "Karate"
        cbKarate.ForeColor = Color.FromArgb(120, 20, 60)
        cbKarate.BackColor = Color.Transparent
        cbKarate.Font = New Font("Segoe UI", 9)

        ' ── cbMembaca ───────────────────────────────────────────────
        cbMembaca.AutoSize = True
        cbMembaca.Location = New Point(21, 265)
        cbMembaca.Name = "cbMembaca"
        cbMembaca.Size = New Size(116, 29)
        cbMembaca.TabIndex = 4
        cbMembaca.Text = "Membaca"
        cbMembaca.ForeColor = Color.FromArgb(120, 20, 60)
        cbMembaca.BackColor = Color.Transparent
        cbMembaca.Font = New Font("Segoe UI", 9)

        ' ── cbMenyanyi ──────────────────────────────────────────────
        cbMenyanyi.AutoSize = True
        cbMenyanyi.Location = New Point(21, 207)
        cbMenyanyi.Name = "cbMenyanyi"
        cbMenyanyi.Size = New Size(114, 29)
        cbMenyanyi.TabIndex = 3
        cbMenyanyi.Text = "Menyanyi"
        cbMenyanyi.ForeColor = Color.FromArgb(120, 20, 60)
        cbMenyanyi.BackColor = Color.Transparent
        cbMenyanyi.Font = New Font("Segoe UI", 9)

        ' ── cbMenari ────────────────────────────────────────────────
        cbMenari.AutoSize = True
        cbMenari.Location = New Point(21, 153)
        cbMenari.Name = "cbMenari"
        cbMenari.Size = New Size(92, 29)
        cbMenari.TabIndex = 2
        cbMenari.Text = "Menari"
        cbMenari.ForeColor = Color.FromArgb(120, 20, 60)
        cbMenari.BackColor = Color.Transparent
        cbMenari.Font = New Font("Segoe UI", 9)

        ' ── cbMelukis ───────────────────────────────────────────────
        cbMelukis.AutoSize = True
        cbMelukis.Location = New Point(21, 101)
        cbMelukis.Name = "cbMelukis"
        cbMelukis.Size = New Size(98, 29)
        cbMelukis.TabIndex = 1
        cbMelukis.Text = "Melukis"
        cbMelukis.ForeColor = Color.FromArgb(120, 20, 60)
        cbMelukis.BackColor = Color.Transparent
        cbMelukis.Font = New Font("Segoe UI", 9)

        ' ── cbMenulis ───────────────────────────────────────────────
        cbMenulis.AutoSize = True
        cbMenulis.Location = New Point(21, 52)
        cbMenulis.Name = "cbMenulis"
        cbMenulis.Size = New Size(99, 29)
        cbMenulis.TabIndex = 0
        cbMenulis.Text = "Menulis"
        cbMenulis.ForeColor = Color.FromArgb(120, 20, 60)
        cbMenulis.BackColor = Color.Transparent
        cbMenulis.Font = New Font("Segoe UI", 9)

        ' ── Gender (GroupBox) ────────────────────────────────────────
        Gender.Controls.Add(rbPerempuan)
        Gender.Controls.Add(rbLaki)
        Gender.Location = New Point(358, 369)
        Gender.Name = "Gender"
        Gender.Size = New Size(306, 99)
        Gender.TabIndex = 13
        Gender.TabStop = False
        Gender.Text = "Gender"
        Gender.BackColor = Color.FromArgb(255, 228, 235)
        Gender.ForeColor = Color.FromArgb(150, 30, 70)
        Gender.Font = New Font("Segoe UI", 9, FontStyle.Bold)

        ' ── rbPerempuan ─────────────────────────────────────────────
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(152, 44)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(126, 29)
        rbPerempuan.TabIndex = 1
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.ForeColor = Color.FromArgb(120, 20, 60)
        rbPerempuan.BackColor = Color.Transparent
        rbPerempuan.Font = New Font("Segoe UI", 9)

        ' ── rbLaki ──────────────────────────────────────────────────
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(22, 44)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(114, 29)
        rbLaki.TabIndex = 0
        rbLaki.TabStop = True
        rbLaki.Text = "Laki - Laki"
        rbLaki.ForeColor = Color.FromArgb(120, 20, 60)
        rbLaki.BackColor = Color.Transparent
        rbLaki.Font = New Font("Segoe UI", 9)

        ' ── dtpLahir ────────────────────────────────────────────────
        dtpLahir.Location = New Point(358, 247)
        dtpLahir.Name = "dtpLahir"
        dtpLahir.Size = New Size(300, 31)
        dtpLahir.TabIndex = 14
        dtpLahir.CalendarMonthBackground = Color.FromArgb(255, 228, 235)
        dtpLahir.CalendarTitleBackColor = Color.FromArgb(219, 112, 147)
        dtpLahir.CalendarTitleForeColor = Color.White
        dtpLahir.CalendarForeColor = Color.FromArgb(120, 20, 60)

        ' ── btnCetak ────────────────────────────────────────────────
        btnCetak.Location = New Point(849, 432)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(229, 45)
        btnCetak.TabIndex = 15
        btnCetak.Text = "Cetak Kartu"
        btnCetak.FlatStyle = FlatStyle.Flat
        btnCetak.FlatAppearance.BorderColor = Color.FromArgb(180, 60, 100)
        btnCetak.FlatAppearance.BorderSize = 2
        btnCetak.BackColor = Color.FromArgb(219, 112, 147)
        btnCetak.ForeColor = Color.White
        btnCetak.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btnCetak.Cursor = Cursors.Hand

        ' ── Form1 ───────────────────────────────────────────────────
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1269, 528)
        Controls.Add(btnCetak)
        Controls.Add(dtpLahir)
        Controls.Add(Gender)
        Controls.Add(Hobi)
        Controls.Add(txtAlamat)
        Controls.Add(txtTelp)
        Controls.Add(txtUmur)
        Controls.Add(txtNama)
        Controls.Add(lblalamat)
        Controls.Add(lbllahir)
        Controls.Add(lbltelp)
        Controls.Add(lblumur)
        Controls.Add(lblnama)
        Controls.Add(btnBrowse)
        Controls.Add(pbFoto)
        Name = "Form1"
        Text = "FormCetak"
        BackColor = Color.FromArgb(255, 245, 248)
        CType(pbFoto, ComponentModel.ISupportInitialize).EndInit()
        Hobi.ResumeLayout(False)
        Hobi.PerformLayout()
        Gender.ResumeLayout(False)
        Gender.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents lblnama As Label
    Friend WithEvents lblumur As Label
    Friend WithEvents lbltelp As Label
    Friend WithEvents lbllahir As Label
    Friend WithEvents lblalamat As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtTelp As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents Hobi As GroupBox
    Friend WithEvents cbMembaca As CheckBox
    Friend WithEvents cbMenyanyi As CheckBox
    Friend WithEvents cbMenari As CheckBox
    Friend WithEvents cbMelukis As CheckBox
    Friend WithEvents cbMenulis As CheckBox
    Friend WithEvents Gender As GroupBox
    Friend WithEvents cbVoli As CheckBox
    Friend WithEvents cbBadminton As CheckBox
    Friend WithEvents cbMuayThai As CheckBox
    Friend WithEvents cbTinju As CheckBox
    Friend WithEvents cbSilat As CheckBox
    Friend WithEvents cbTaekwondo As CheckBox
    Friend WithEvents cbKarate As CheckBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents dtpLahir As DateTimePicker
    Friend WithEvents btnCetak As Button

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbMenulis.CheckedChanged

    End Sub
End Class