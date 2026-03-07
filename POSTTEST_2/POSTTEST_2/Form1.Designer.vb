<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        ' ── Deklarasi Kontrol ──
        Me.grpTambah = New System.Windows.Forms.GroupBox()
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.txtJudul = New System.Windows.Forms.TextBox()
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.txtGenre = New System.Windows.Forms.TextBox()
        Me.btnTambah = New System.Windows.Forms.Button()

        Me.grpHapus = New System.Windows.Forms.GroupBox()
        Me.lblHapusJudul = New System.Windows.Forms.Label()
        Me.txtHapusJudul = New System.Windows.Forms.TextBox()
        Me.btnHapus = New System.Windows.Forms.Button()

        Me.LstBuku = New System.Windows.Forms.DataGridView()

        Me.grpTambah.SuspendLayout()
        Me.grpHapus.SuspendLayout()
        Me.SuspendLayout()

        ' ════════════════════════════════
        '  GROUP BOX : Tambah Buku
        ' ════════════════════════════════
        Me.grpTambah.Location = New System.Drawing.Point(30, 30)
        Me.grpTambah.Size = New System.Drawing.Size(330, 220)
        Me.grpTambah.Text = "Tambah Buku"
        Me.grpTambah.Font = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        Me.grpTambah.ForeColor = System.Drawing.Color.FromArgb(180, 60, 100)
        Me.grpTambah.BackColor = System.Drawing.Color.FromArgb(255, 240, 245)

        ' Label Judul
        Me.lblJudul.Text = "Judul Buku"
        Me.lblJudul.Location = New System.Drawing.Point(20, 50)
        Me.lblJudul.Size = New System.Drawing.Size(80, 23)
        Me.lblJudul.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblJudul.ForeColor = System.Drawing.Color.FromArgb(120, 40, 70)

        ' TextBox Judul
        Me.txtJudul.Location = New System.Drawing.Point(120, 47)
        Me.txtJudul.Size = New System.Drawing.Size(180, 23)
        Me.txtJudul.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.txtJudul.BackColor = System.Drawing.Color.FromArgb(255, 250, 252)
        Me.txtJudul.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle

        ' Label Genre
        Me.lblGenre.Text = "Genre"
        Me.lblGenre.Location = New System.Drawing.Point(20, 100)
        Me.lblGenre.Size = New System.Drawing.Size(80, 23)
        Me.lblGenre.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblGenre.ForeColor = System.Drawing.Color.FromArgb(120, 40, 70)

        ' TextBox Genre
        Me.txtGenre.Location = New System.Drawing.Point(120, 97)
        Me.txtGenre.Size = New System.Drawing.Size(180, 23)
        Me.txtGenre.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.txtGenre.BackColor = System.Drawing.Color.FromArgb(255, 250, 252)
        Me.txtGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle

        ' Tombol Tambah
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.Location = New System.Drawing.Point(110, 158)
        Me.btnTambah.Size = New System.Drawing.Size(110, 35)
        Me.btnTambah.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.btnTambah.BackColor = System.Drawing.Color.FromArgb(219, 112, 147)
        Me.btnTambah.ForeColor = System.Drawing.Color.White
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.FlatAppearance.BorderSize = 0
        Me.btnTambah.Cursor = System.Windows.Forms.Cursors.Hand

        Me.grpTambah.Controls.Add(Me.lblJudul)
        Me.grpTambah.Controls.Add(Me.txtJudul)
        Me.grpTambah.Controls.Add(Me.lblGenre)
        Me.grpTambah.Controls.Add(Me.txtGenre)
        Me.grpTambah.Controls.Add(Me.btnTambah)

        ' ════════════════════════════════
        '  GROUP BOX : Hapus Buku
        ' ════════════════════════════════
        Me.grpHapus.Location = New System.Drawing.Point(390, 30)
        Me.grpHapus.Size = New System.Drawing.Size(280, 220)
        Me.grpHapus.Text = "Hapus Buku"
        Me.grpHapus.Font = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        Me.grpHapus.ForeColor = System.Drawing.Color.FromArgb(180, 60, 100)
        Me.grpHapus.BackColor = System.Drawing.Color.FromArgb(255, 228, 235)

        ' Label Judul Hapus
        Me.lblHapusJudul.Text = "Judul Buku"
        Me.lblHapusJudul.Location = New System.Drawing.Point(70, 50)
        Me.lblHapusJudul.Size = New System.Drawing.Size(140, 23)
        Me.lblHapusJudul.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblHapusJudul.ForeColor = System.Drawing.Color.FromArgb(120, 40, 70)
        Me.lblHapusJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' TextBox Judul Hapus
        Me.txtHapusJudul.Location = New System.Drawing.Point(50, 83)
        Me.txtHapusJudul.Size = New System.Drawing.Size(180, 23)
        Me.txtHapusJudul.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.txtHapusJudul.BackColor = System.Drawing.Color.FromArgb(255, 250, 252)
        Me.txtHapusJudul.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle

        ' Tombol Hapus
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.Location = New System.Drawing.Point(85, 145)
        Me.btnHapus.Size = New System.Drawing.Size(110, 35)
        Me.btnHapus.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(199, 21, 133)
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.FlatAppearance.BorderSize = 0
        Me.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand

        Me.grpHapus.Controls.Add(Me.lblHapusJudul)
        Me.grpHapus.Controls.Add(Me.txtHapusJudul)
        Me.grpHapus.Controls.Add(Me.btnHapus)

        ' ════════════════════════════════
        '  DATAGRIDVIEW : Daftar Buku
        ' ════════════════════════════════
        Me.LstBuku.Location = New System.Drawing.Point(700, 30)
        Me.LstBuku.Size = New System.Drawing.Size(340, 220)
        Me.LstBuku.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.LstBuku.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LstBuku.BackgroundColor = System.Drawing.Color.FromArgb(255, 240, 245)

        ' Warna header kolom
        Me.LstBuku.EnableHeadersVisualStyles = False
        Me.LstBuku.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(219, 112, 147)
        Me.LstBuku.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.LstBuku.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.LstBuku.ColumnHeadersHeight = 32

        ' Warna baris biasa
        Me.LstBuku.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 250, 252)
        Me.LstBuku.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(80, 20, 50)
        Me.LstBuku.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(255, 182, 193)
        Me.LstBuku.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(80, 20, 50)

        ' Warna baris selang-seling
        Me.LstBuku.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 228, 235)

        ' Warna grid line
        Me.LstBuku.GridColor = System.Drawing.Color.FromArgb(255, 182, 193)

        ' ════════════════════════════════
        '  FORM UTAMA
        ' ════════════════════════════════
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 290)
        Me.Text = "POSTTEST_2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.BackColor = System.Drawing.Color.FromArgb(255, 230, 240)

        Me.Controls.Add(Me.grpTambah)
        Me.Controls.Add(Me.grpHapus)
        Me.Controls.Add(Me.LstBuku)

        Me.grpTambah.ResumeLayout(False)
        Me.grpHapus.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    ' ── Deklarasi Variabel Kontrol ──
    Friend WithEvents grpTambah As System.Windows.Forms.GroupBox
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents txtJudul As System.Windows.Forms.TextBox
    Friend WithEvents lblGenre As System.Windows.Forms.Label
    Friend WithEvents txtGenre As System.Windows.Forms.TextBox
    Friend WithEvents btnTambah As System.Windows.Forms.Button

    Friend WithEvents grpHapus As System.Windows.Forms.GroupBox
    Friend WithEvents lblHapusJudul As System.Windows.Forms.Label
    Friend WithEvents txtHapusJudul As System.Windows.Forms.TextBox
    Friend WithEvents btnHapus As System.Windows.Forms.Button

    Friend WithEvents LstBuku As System.Windows.Forms.DataGridView
End Class