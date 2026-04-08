<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        mnuInputData = New ToolStripMenuItem()
        mnuLihatKartu = New ToolStripMenuItem()
        mnuSimpan = New ToolStripMenuItem()
        mnuBuka = New ToolStripMenuItem()
        mnuKeluar = New ToolStripMenuItem()
        lblJudul = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        tabMain = New TabControl()
        TabPage1 = New TabPage()
        lblDivisi = New Label()
        cmbKomunitas = New ComboBox()
        GroupBox1 = New GroupBox()
        rbLakiLaki = New RadioButton()
        rbPerempuan = New RadioButton()
        Label3 = New Label()
        lblLahir = New Label()
        dtpLahir = New DateTimePicker()
        txtID = New TextBox()
        txtNama = New TextBox()
        lblNIM = New Label()
        lblNama = New Label()
        TabPage2 = New TabPage()
        lblAlamat = New Label()
        txtAlamat = New TextBox()
        lblNoHP = New Label()
        mtxtTelepon = New MaskedTextBox()
        lblEmail = New Label()
        txtEmail = New TextBox()
        TabPage3 = New TabPage()
        btnSimpanCetak = New Button()
        lblHobi = New Label()
        chkMasak = New CheckBox()
        chkGaming = New CheckBox()
        chkMenulis = New CheckBox()
        chkFotografi = New CheckBox()
        chkOlahraga = New CheckBox()
        chkMusik = New CheckBox()
        chkDesign = New CheckBox()
        chkCoding = New CheckBox()
        grpPeran = New GroupBox()
        rbPengawas = New RadioButton()
        rbAnggota = New RadioButton()
        rbWakil = New RadioButton()
        rbKetua = New RadioButton()
        btnBrowse = New Button()
        picFoto = New PictureBox()
        ofd = New OpenFileDialog()
        sfd = New SaveFileDialog()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        tabMain.SuspendLayout()
        TabPage1.SuspendLayout()
        GroupBox1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        grpPeran.SuspendLayout()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnuInputData, mnuLihatKartu, mnuSimpan, mnuBuka, mnuKeluar})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1120, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' mnuInputData
        ' 
        mnuInputData.Name = "mnuInputData"
        mnuInputData.Size = New Size(112, 29)
        mnuInputData.Text = "Input Data"
        ' 
        ' mnuLihatKartu
        ' 
        mnuLihatKartu.Name = "mnuLihatKartu"
        mnuLihatKartu.Size = New Size(111, 29)
        mnuLihatKartu.Text = "Lihat Kartu"
        ' 
        ' mnuSimpan
        ' 
        mnuSimpan.Name = "mnuSimpan"
        mnuSimpan.Size = New Size(130, 29)
        mnuSimpan.Text = "Simpan Data"
        ' 
        ' mnuBuka
        ' 
        mnuBuka.Name = "mnuBuka"
        mnuBuka.Size = New Size(108, 29)
        mnuBuka.Text = "Buka Data"
        ' 
        ' mnuKeluar
        ' 
        mnuKeluar.Name = "mnuKeluar"
        mnuKeluar.Size = New Size(76, 29)
        mnuKeluar.Text = "Keluar"
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Location = New Point(200, 61)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(144, 54)
        lblJudul.TabIndex = 1
        lblJudul.Text = "Celebration" & vbCrLf
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Screenshot_2026_04_08_172508_removebg_preview
        PictureBox1.Location = New Point(36, 53)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(155, 149)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(243, 102)
        Label1.Name = "Label1"
        Label1.Size = New Size(141, 54)
        Label1.TabIndex = 3
        Label1.Text = "Informatics"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(339, 148)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 54)
        Label2.TabIndex = 4
        Label2.Text = "Day"
        ' 
        ' tabMain
        ' 
        tabMain.Controls.Add(TabPage1)
        tabMain.Controls.Add(TabPage2)
        tabMain.Controls.Add(TabPage3)
        tabMain.Location = New Point(55, 252)
        tabMain.Name = "tabMain"
        tabMain.SelectedIndex = 0
        tabMain.Size = New Size(996, 671)
        tabMain.TabIndex = 5
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.White
        TabPage1.Controls.Add(lblDivisi)
        TabPage1.Controls.Add(cmbKomunitas)
        TabPage1.Controls.Add(GroupBox1)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(lblLahir)
        TabPage1.Controls.Add(dtpLahir)
        TabPage1.Controls.Add(txtID)
        TabPage1.Controls.Add(txtNama)
        TabPage1.Controls.Add(lblNIM)
        TabPage1.Controls.Add(lblNama)
        TabPage1.Location = New Point(4, 63)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(988, 604)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Data Utama"
        ' 
        ' lblDivisi
        ' 
        lblDivisi.AutoSize = True
        lblDivisi.Location = New Point(48, 514)
        lblDivisi.Name = "lblDivisi"
        lblDivisi.Size = New Size(84, 54)
        lblDivisi.TabIndex = 11
        lblDivisi.Text = "Divisi"
        ' 
        ' cmbKomunitas
        ' 
        cmbKomunitas.FormattingEnabled = True
        cmbKomunitas.Items.AddRange(New Object() {"Kesehatan", "Tata Ruang", "Media", "Humas", "Konsumsi", "Acara", "Perlengkapan", "Keamanan", "Kestari"})
        cmbKomunitas.Location = New Point(168, 511)
        cmbKomunitas.Name = "cmbKomunitas"
        cmbKomunitas.Size = New Size(490, 62)
        cmbKomunitas.TabIndex = 10
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbLakiLaki)
        GroupBox1.Controls.Add(rbPerempuan)
        GroupBox1.Location = New Point(30, 301)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(414, 150)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "Jenis Kelamin"
        ' 
        ' rbLakiLaki
        ' 
        rbLakiLaki.AutoSize = True
        rbLakiLaki.Location = New Point(29, 61)
        rbLakiLaki.Name = "rbLakiLaki"
        rbLakiLaki.Size = New Size(161, 58)
        rbLakiLaki.TabIndex = 6
        rbLakiLaki.TabStop = True
        rbLakiLaki.Text = "Laki - Laki"
        rbLakiLaki.UseVisualStyleBackColor = True
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(208, 61)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(165, 58)
        rbPerempuan.TabIndex = 7
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(30, 301)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 54)
        Label3.TabIndex = 8
        ' 
        ' lblLahir
        ' 
        lblLahir.AutoSize = True
        lblLahir.Location = New Point(30, 207)
        lblLahir.Name = "lblLahir"
        lblLahir.Size = New Size(164, 54)
        lblLahir.TabIndex = 5
        lblLahir.Text = "Tanggal Lahir"
        ' 
        ' dtpLahir
        ' 
        dtpLahir.Location = New Point(219, 199)
        dtpLahir.Name = "dtpLahir"
        dtpLahir.Size = New Size(439, 62)
        dtpLahir.TabIndex = 4
        ' 
        ' txtID
        ' 
        txtID.Font = New Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtID.Location = New Point(164, 114)
        txtID.Name = "txtID"
        txtID.Size = New Size(339, 48)
        txtID.TabIndex = 3
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNama.Location = New Point(164, 39)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(536, 48)
        txtNama.TabIndex = 2
        ' 
        ' lblNIM
        ' 
        lblNIM.AutoSize = True
        lblNIM.Location = New Point(30, 114)
        lblNIM.Name = "lblNIM"
        lblNIM.Size = New Size(72, 54)
        lblNIM.TabIndex = 1
        lblNIM.Text = "NIM"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(30, 35)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(83, 54)
        lblNama.TabIndex = 0
        lblNama.Text = "Nama"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(lblAlamat)
        TabPage2.Controls.Add(txtAlamat)
        TabPage2.Controls.Add(lblNoHP)
        TabPage2.Controls.Add(mtxtTelepon)
        TabPage2.Controls.Add(lblEmail)
        TabPage2.Controls.Add(txtEmail)
        TabPage2.Location = New Point(4, 63)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(988, 604)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kontak & Info"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(114, 397)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(98, 54)
        lblAlamat.TabIndex = 5
        lblAlamat.Text = "Alamat"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(280, 389)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(370, 146)
        txtAlamat.TabIndex = 4
        ' 
        ' lblNoHP
        ' 
        lblNoHP.AutoSize = True
        lblNoHP.Location = New Point(114, 143)
        lblNoHP.Name = "lblNoHP"
        lblNoHP.Size = New Size(93, 54)
        lblNoHP.TabIndex = 3
        lblNoHP.Text = "No HP"
        ' 
        ' mtxtTelepon
        ' 
        mtxtTelepon.Location = New Point(280, 135)
        mtxtTelepon.Mask = "0000-0000-0000"
        mtxtTelepon.Name = "mtxtTelepon"
        mtxtTelepon.Size = New Size(370, 62)
        mtxtTelepon.TabIndex = 2
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(114, 270)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(84, 54)
        lblEmail.TabIndex = 1
        lblEmail.Text = "Email"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(280, 262)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(370, 62)
        txtEmail.TabIndex = 0
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(btnSimpanCetak)
        TabPage3.Controls.Add(lblHobi)
        TabPage3.Controls.Add(chkMasak)
        TabPage3.Controls.Add(chkGaming)
        TabPage3.Controls.Add(chkMenulis)
        TabPage3.Controls.Add(chkFotografi)
        TabPage3.Controls.Add(chkOlahraga)
        TabPage3.Controls.Add(chkMusik)
        TabPage3.Controls.Add(chkDesign)
        TabPage3.Controls.Add(chkCoding)
        TabPage3.Controls.Add(grpPeran)
        TabPage3.Controls.Add(btnBrowse)
        TabPage3.Controls.Add(picFoto)
        TabPage3.Location = New Point(4, 63)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(988, 604)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Profil & Aktivitas"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' btnSimpanCetak
        ' 
        btnSimpanCetak.Location = New Point(280, 498)
        btnSimpanCetak.Name = "btnSimpanCetak"
        btnSimpanCetak.Size = New Size(418, 52)
        btnSimpanCetak.TabIndex = 12
        btnSimpanCetak.Text = "Simpan dan Cetak Kartu"
        btnSimpanCetak.UseVisualStyleBackColor = True
        ' 
        ' lblHobi
        ' 
        lblHobi.AutoSize = True
        lblHobi.Location = New Point(302, 278)
        lblHobi.Name = "lblHobi"
        lblHobi.Size = New Size(177, 54)
        lblHobi.TabIndex = 11
        lblHobi.Text = "Hobi/Aktivitas"
        ' 
        ' chkMasak
        ' 
        chkMasak.AutoSize = True
        chkMasak.Font = New Font("Javanese Text", 10F)
        chkMasak.Location = New Point(571, 390)
        chkMasak.Name = "chkMasak"
        chkMasak.Size = New Size(130, 49)
        chkMasak.TabIndex = 10
        chkMasak.Text = "Memasak"
        chkMasak.UseVisualStyleBackColor = True
        ' 
        ' chkGaming
        ' 
        chkGaming.AutoSize = True
        chkGaming.Font = New Font("Javanese Text", 10F)
        chkGaming.Location = New Point(453, 390)
        chkGaming.Name = "chkGaming"
        chkGaming.Size = New Size(114, 49)
        chkGaming.TabIndex = 9
        chkGaming.Text = "Gaming"
        chkGaming.UseVisualStyleBackColor = True
        ' 
        ' chkMenulis
        ' 
        chkMenulis.AutoSize = True
        chkMenulis.Font = New Font("Javanese Text", 10F)
        chkMenulis.Location = New Point(332, 390)
        chkMenulis.Name = "chkMenulis"
        chkMenulis.Size = New Size(117, 49)
        chkMenulis.TabIndex = 8
        chkMenulis.Text = "Menulis"
        chkMenulis.UseVisualStyleBackColor = True
        ' 
        ' chkFotografi
        ' 
        chkFotografi.AutoSize = True
        chkFotografi.Font = New Font("Javanese Text", 10F)
        chkFotografi.Location = New Point(707, 390)
        chkFotografi.Name = "chkFotografi"
        chkFotografi.Size = New Size(124, 49)
        chkFotografi.TabIndex = 7
        chkFotografi.Text = "Fotografi"
        chkFotografi.UseVisualStyleBackColor = True
        ' 
        ' chkOlahraga
        ' 
        chkOlahraga.AutoSize = True
        chkOlahraga.Font = New Font("Javanese Text", 10F)
        chkOlahraga.Location = New Point(663, 335)
        chkOlahraga.Name = "chkOlahraga"
        chkOlahraga.Size = New Size(126, 49)
        chkOlahraga.TabIndex = 6
        chkOlahraga.Text = "Olahraga"
        chkOlahraga.UseVisualStyleBackColor = True
        ' 
        ' chkMusik
        ' 
        chkMusik.AutoSize = True
        chkMusik.Font = New Font("Javanese Text", 10F)
        chkMusik.Location = New Point(553, 335)
        chkMusik.Name = "chkMusik"
        chkMusik.Size = New Size(101, 49)
        chkMusik.TabIndex = 5
        chkMusik.Text = "Musik"
        chkMusik.UseVisualStyleBackColor = True
        ' 
        ' chkDesign
        ' 
        chkDesign.AutoSize = True
        chkDesign.Font = New Font("Javanese Text", 10F)
        chkDesign.Location = New Point(443, 335)
        chkDesign.Name = "chkDesign"
        chkDesign.Size = New Size(106, 49)
        chkDesign.TabIndex = 4
        chkDesign.Text = "Design"
        chkDesign.UseVisualStyleBackColor = True
        ' 
        ' chkCoding
        ' 
        chkCoding.AutoSize = True
        chkCoding.Font = New Font("Javanese Text", 10F)
        chkCoding.Location = New Point(332, 335)
        chkCoding.Name = "chkCoding"
        chkCoding.Size = New Size(107, 49)
        chkCoding.TabIndex = 3
        chkCoding.Text = "Coding"
        chkCoding.UseVisualStyleBackColor = True
        ' 
        ' grpPeran
        ' 
        grpPeran.Controls.Add(rbPengawas)
        grpPeran.Controls.Add(rbAnggota)
        grpPeran.Controls.Add(rbWakil)
        grpPeran.Controls.Add(rbKetua)
        grpPeran.Location = New Point(302, 79)
        grpPeran.Name = "grpPeran"
        grpPeran.Size = New Size(629, 139)
        grpPeran.TabIndex = 2
        grpPeran.TabStop = False
        grpPeran.Text = "Peran/Role"
        ' 
        ' rbPengawas
        ' 
        rbPengawas.AutoSize = True
        rbPengawas.Font = New Font("Javanese Text", 10F)
        rbPengawas.Location = New Point(468, 61)
        rbPengawas.Name = "rbPengawas"
        rbPengawas.Size = New Size(130, 49)
        rbPengawas.TabIndex = 3
        rbPengawas.TabStop = True
        rbPengawas.Text = "Pengawas"
        rbPengawas.UseVisualStyleBackColor = True
        ' 
        ' rbAnggota
        ' 
        rbAnggota.AutoSize = True
        rbAnggota.Font = New Font("Javanese Text", 10F)
        rbAnggota.Location = New Point(311, 61)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(117, 49)
        rbAnggota.TabIndex = 2
        rbAnggota.TabStop = True
        rbAnggota.Text = "Anggota"
        rbAnggota.UseVisualStyleBackColor = True
        ' 
        ' rbWakil
        ' 
        rbWakil.AutoSize = True
        rbWakil.Font = New Font("Javanese Text", 10F)
        rbWakil.Location = New Point(165, 62)
        rbWakil.Name = "rbWakil"
        rbWakil.Size = New Size(96, 49)
        rbWakil.TabIndex = 1
        rbWakil.TabStop = True
        rbWakil.Text = "Wakil"
        rbWakil.UseVisualStyleBackColor = True
        ' 
        ' rbKetua
        ' 
        rbKetua.AutoSize = True
        rbKetua.Font = New Font("Javanese Text", 10F)
        rbKetua.Location = New Point(26, 61)
        rbKetua.Name = "rbKetua"
        rbKetua.Size = New Size(98, 49)
        rbKetua.TabIndex = 0
        rbKetua.TabStop = True
        rbKetua.Text = "Ketua"
        rbKetua.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(70, 317)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(176, 48)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse Foto"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' picFoto
        ' 
        picFoto.BorderStyle = BorderStyle.FixedSingle
        picFoto.Location = New Point(59, 93)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(187, 205)
        picFoto.SizeMode = PictureBoxSizeMode.Zoom
        picFoto.TabIndex = 0
        picFoto.TabStop = False
        ' 
        ' ofd
        ' 
        ofd.FileName = "OpenFileDialog1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(14F, 54F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.GhostWhite
        ClientSize = New Size(1120, 972)
        Controls.Add(tabMain)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(lblJudul)
        Controls.Add(MenuStrip1)
        Font = New Font("Javanese Text", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MainMenuStrip = MenuStrip1
        Margin = New Padding(4, 6, 4, 6)
        Name = "Form1"
        Text = "KARTU PANITIA CID"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        tabMain.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        grpPeran.ResumeLayout(False)
        grpPeran.PerformLayout()
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuInputData As ToolStripMenuItem
    Friend WithEvents mnuLihatKartu As ToolStripMenuItem
    Friend WithEvents mnuSimpan As ToolStripMenuItem
    Friend WithEvents mnuBuka As ToolStripMenuItem
    Friend WithEvents mnuKeluar As ToolStripMenuItem
    Friend WithEvents lblJudul As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tabMain As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents lblNIM As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblLahir As Label
    Friend WithEvents dtpLahir As DateTimePicker
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbLakiLaki As RadioButton
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents lblDivisi As Label
    Friend WithEvents cmbKomunitas As ComboBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblAlamat As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents lblNoHP As Label
    Friend WithEvents mtxtTelepon As MaskedTextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents grpPeran As GroupBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents rbWakil As RadioButton
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents rbPengawas As RadioButton
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents chkCoding As CheckBox
    Friend WithEvents chkOlahraga As CheckBox
    Friend WithEvents chkMusik As CheckBox
    Friend WithEvents chkDesign As CheckBox
    Friend WithEvents chkFotografi As CheckBox
    Friend WithEvents chkMenulis As CheckBox
    Friend WithEvents lblHobi As Label
    Friend WithEvents chkMasak As CheckBox
    Friend WithEvents chkGaming As CheckBox
    Friend WithEvents btnSimpanCetak As Button
    Friend WithEvents ofd As OpenFileDialog
    Friend WithEvents sfd As SaveFileDialog

End Class
