<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        pbFoto = New PictureBox()
        lblTlahir = New Label()
        lblTelp = New Label()
        lblumur = New Label()
        lblnama = New Label()
        lblAlamat = New Label()
        lblHobi = New Label()
        lblJK = New Label()

        ' ── Label dekoratif header ───────────────────────────────────
        lblHeader = New Label()
        lblDivider = New Label()
        lblFotoFrame = New Label()

        CType(pbFoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()

        ' ── Form2 background ────────────────────────────────────────
        Me.BackColor = Color.FromArgb(255, 245, 248)

        ' ── lblHeader (judul kartu) ──────────────────────────────────
        lblHeader.AutoSize = False
        lblHeader.Location = New Point(0, 0)
        lblHeader.Size = New Size(652, 60)
        lblHeader.Name = "lblHeader"
        lblHeader.Text = "✦  KARTU IDENTITAS  ✦"
        lblHeader.TextAlign = ContentAlignment.MiddleCenter
        lblHeader.BackColor = Color.FromArgb(219, 112, 147)
        lblHeader.ForeColor = Color.White
        lblHeader.Font = New Font("Segoe UI", 13, FontStyle.Bold)

        ' ── lblDivider (garis bawah header) ─────────────────────────
        lblDivider.AutoSize = False
        lblDivider.Location = New Point(0, 60)
        lblDivider.Size = New Size(652, 4)
        lblDivider.Name = "lblDivider"
        lblDivider.Text = ""
        lblDivider.BackColor = Color.FromArgb(255, 182, 193)

        ' ── lblFotoFrame (frame dekoratif di belakang foto) ──────────
        lblFotoFrame.AutoSize = False
        lblFotoFrame.Location = New Point(42, 78)
        lblFotoFrame.Size = New Size(229, 268)
        lblFotoFrame.Name = "lblFotoFrame"
        lblFotoFrame.Text = ""
        lblFotoFrame.BackColor = Color.FromArgb(255, 182, 193)
        lblFotoFrame.BorderStyle = BorderStyle.None

        ' ── pbFoto ──────────────────────────────────────────────────
        pbFoto.Location = New Point(52, 83)
        pbFoto.Name = "pbFoto"
        pbFoto.Size = New Size(209, 248)
        pbFoto.TabIndex = 0
        pbFoto.TabStop = False
        pbFoto.BackColor = Color.FromArgb(255, 240, 245)
        pbFoto.BorderStyle = BorderStyle.FixedSingle
        pbFoto.SizeMode = PictureBoxSizeMode.Zoom

        ' ── lblnama ─────────────────────────────────────────────────
        lblnama.AutoSize = False
        lblnama.Location = New Point(300, 75)
        lblnama.Size = New Size(330, 40)
        lblnama.Name = "lblnama"
        lblnama.Text = "Nama  :  -"
        lblnama.ForeColor = Color.FromArgb(120, 20, 60)
        lblnama.BackColor = Color.Transparent
        lblnama.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        lblnama.TextAlign = ContentAlignment.MiddleLeft
        lblnama.BorderStyle = BorderStyle.None

        ' ── lblumur ─────────────────────────────────────────────────
        lblumur.AutoSize = False
        lblumur.Location = New Point(300, 122)
        lblumur.Size = New Size(330, 40)
        lblumur.Name = "lblumur"
        lblumur.Text = "Umur  :  -"
        lblumur.ForeColor = Color.FromArgb(120, 20, 60)
        lblumur.BackColor = Color.Transparent
        lblumur.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        lblumur.TextAlign = ContentAlignment.MiddleLeft

        ' ── lblTelp ─────────────────────────────────────────────────
        lblTelp.AutoSize = False
        lblTelp.Location = New Point(300, 169)
        lblTelp.Size = New Size(330, 40)
        lblTelp.Name = "lblTelp"
        lblTelp.Text = "No.Telp  :  -"
        lblTelp.ForeColor = Color.FromArgb(120, 20, 60)
        lblTelp.BackColor = Color.Transparent
        lblTelp.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        lblTelp.TextAlign = ContentAlignment.MiddleLeft

        ' ── lblTlahir ───────────────────────────────────────────────
        lblTlahir.AutoSize = False
        lblTlahir.Location = New Point(300, 216)
        lblTlahir.Size = New Size(330, 40)
        lblTlahir.Name = "lblTlahir"
        lblTlahir.Text = "Tgl. Lahir  :  -"
        lblTlahir.ForeColor = Color.FromArgb(120, 20, 60)
        lblTlahir.BackColor = Color.Transparent
        lblTlahir.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        lblTlahir.TextAlign = ContentAlignment.MiddleLeft

        ' ── lblAlamat ───────────────────────────────────────────────
        lblAlamat.AutoSize = False
        lblAlamat.Location = New Point(300, 263)
        lblAlamat.Size = New Size(330, 40)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Text = "Alamat  :  -"
        lblAlamat.ForeColor = Color.FromArgb(120, 20, 60)
        lblAlamat.BackColor = Color.Transparent
        lblAlamat.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        lblAlamat.TextAlign = ContentAlignment.MiddleLeft

        ' ── lblHobi ─────────────────────────────────────────────────
        lblHobi.AutoSize = False
        lblHobi.Location = New Point(300, 310)
        lblHobi.Size = New Size(330, 40)
        lblHobi.Name = "lblHobi"
        lblHobi.Text = "Hobi  :  -"
        lblHobi.ForeColor = Color.FromArgb(120, 20, 60)
        lblHobi.BackColor = Color.Transparent
        lblHobi.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        lblHobi.TextAlign = ContentAlignment.MiddleLeft

        ' ── lblJK ───────────────────────────────────────────────────
        lblJK.AutoSize = False
        lblJK.Location = New Point(52, 357)
        lblJK.Size = New Size(200, 40)
        lblJK.Name = "lblJK"
        lblJK.Text = "Gender  :  -"
        lblJK.ForeColor = Color.FromArgb(120, 20, 60)
        lblJK.BackColor = Color.Transparent
        lblJK.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        lblJK.TextAlign = ContentAlignment.MiddleLeft

        ' ── Panel bawah (footer dekoratif) ───────────────────────────
        lblFooter = New Label()
        lblFooter.AutoSize = False
        lblFooter.Location = New Point(0, 418)
        lblFooter.Size = New Size(652, 32)
        lblFooter.Name = "lblFooter"
        lblFooter.Text = "~ Kartu Identitas Pribadi ~"
        lblFooter.TextAlign = ContentAlignment.MiddleCenter
        lblFooter.BackColor = Color.FromArgb(255, 182, 193)
        lblFooter.ForeColor = Color.FromArgb(100, 20, 50)
        lblFooter.Font = New Font("Segoe UI", 8, FontStyle.Italic)

        ' ── Form2 ───────────────────────────────────────────────────
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(652, 450)
        Controls.Add(lblFooter)
        Controls.Add(lblJK)
        Controls.Add(lblHobi)
        Controls.Add(lblAlamat)
        Controls.Add(lblTlahir)
        Controls.Add(lblTelp)
        Controls.Add(lblumur)
        Controls.Add(lblnama)
        Controls.Add(pbFoto)
        Controls.Add(lblFotoFrame)
        Controls.Add(lblDivider)
        Controls.Add(lblHeader)
        Name = "Form2"
        Text = "Hasil Kartu"
        CType(pbFoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents lblTlahir As Label
    Friend WithEvents lblTelp As Label
    Friend WithEvents lblumur As Label
    Friend WithEvents lblnama As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblHobi As Label
    Friend WithEvents lblJK As Label
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblDivider As Label
    Friend WithEvents lblFotoFrame As Label
    Friend WithEvents lblFooter As Label
End Class