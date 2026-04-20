<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCheckout
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        cmbPilihTamu = New ComboBox()
        txtKamar = New TextBox()
        txtHarga = New TextBox()
        txtTglCheckIn = New TextBox()
        txtLamaMenginap = New TextBox()
        txtTotalTagihan = New TextBox()
        dtpCheckOut = New DateTimePicker()
        cmbMetodeBayar = New ComboBox()
        btnHitung = New Button()
        btnProsesBayar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        GroupBox1 = New GroupBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' cmbPilihTamu
        ' 
        cmbPilihTamu.FormattingEnabled = True
        cmbPilihTamu.Location = New Point(156, 126)
        cmbPilihTamu.Margin = New Padding(4)
        cmbPilihTamu.Name = "cmbPilihTamu"
        cmbPilihTamu.Size = New Size(181, 36)
        cmbPilihTamu.TabIndex = 0
        ' 
        ' txtKamar
        ' 
        txtKamar.Location = New Point(136, 63)
        txtKamar.Margin = New Padding(4)
        txtKamar.Name = "txtKamar"
        txtKamar.ReadOnly = True
        txtKamar.Size = New Size(133, 35)
        txtKamar.TabIndex = 1
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(136, 130)
        txtHarga.Margin = New Padding(4)
        txtHarga.Name = "txtHarga"
        txtHarga.ReadOnly = True
        txtHarga.Size = New Size(131, 35)
        txtHarga.TabIndex = 2
        ' 
        ' txtTglCheckIn
        ' 
        txtTglCheckIn.Location = New Point(340, 101)
        txtTglCheckIn.Margin = New Padding(4)
        txtTglCheckIn.Name = "txtTglCheckIn"
        txtTglCheckIn.ReadOnly = True
        txtTglCheckIn.Size = New Size(245, 35)
        txtTglCheckIn.TabIndex = 3
        ' 
        ' txtLamaMenginap
        ' 
        txtLamaMenginap.Location = New Point(184, 197)
        txtLamaMenginap.Margin = New Padding(4)
        txtLamaMenginap.Name = "txtLamaMenginap"
        txtLamaMenginap.ReadOnly = True
        txtLamaMenginap.Size = New Size(83, 35)
        txtLamaMenginap.TabIndex = 4
        ' 
        ' txtTotalTagihan
        ' 
        txtTotalTagihan.Location = New Point(343, 210)
        txtTotalTagihan.Margin = New Padding(4)
        txtTotalTagihan.Name = "txtTotalTagihan"
        txtTotalTagihan.ReadOnly = True
        txtTotalTagihan.Size = New Size(234, 35)
        txtTotalTagihan.TabIndex = 5
        ' 
        ' dtpCheckOut
        ' 
        dtpCheckOut.Location = New Point(596, 127)
        dtpCheckOut.Margin = New Padding(4)
        dtpCheckOut.Name = "dtpCheckOut"
        dtpCheckOut.Size = New Size(331, 35)
        dtpCheckOut.TabIndex = 6
        ' 
        ' cmbMetodeBayar
        ' 
        cmbMetodeBayar.FormattingEnabled = True
        cmbMetodeBayar.Location = New Point(691, 246)
        cmbMetodeBayar.Margin = New Padding(4)
        cmbMetodeBayar.Name = "cmbMetodeBayar"
        cmbMetodeBayar.Size = New Size(187, 36)
        cmbMetodeBayar.TabIndex = 7
        cmbMetodeBayar.Text = "Metode Bayar"
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(691, 303)
        btnHitung.Margin = New Padding(4)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(187, 42)
        btnHitung.TabIndex = 8
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' btnProsesBayar
        ' 
        btnProsesBayar.Location = New Point(691, 365)
        btnProsesBayar.Margin = New Padding(4)
        btnProsesBayar.Name = "btnProsesBayar"
        btnProsesBayar.Size = New Size(187, 41)
        btnProsesBayar.TabIndex = 9
        btnProsesBayar.Text = "Proses Bayar"
        btnProsesBayar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(35, 126)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 28)
        Label1.TabIndex = 10
        Label1.Text = "Pilih Tamu"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(398, 126)
        Label2.Name = "Label2"
        Label2.Size = New Size(178, 28)
        Label2.TabIndex = 11
        Label2.Text = "Tanggal CheckOut"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txtTotalTagihan)
        GroupBox1.Controls.Add(txtLamaMenginap)
        GroupBox1.Controls.Add(txtTglCheckIn)
        GroupBox1.Controls.Add(txtHarga)
        GroupBox1.Controls.Add(txtKamar)
        GroupBox1.Location = New Point(18, 191)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(611, 284)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        GroupBox1.Text = "Data Tamu"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(389, 166)
        Label7.Name = "Label7"
        Label7.Size = New Size(134, 28)
        Label7.TabIndex = 17
        Label7.Text = "Total Tagihan"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(15, 200)
        Label6.Name = "Label6"
        Label6.Size = New Size(151, 28)
        Label6.TabIndex = 16
        Label6.Text = "Lama Menginap"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(378, 63)
        Label5.Name = "Label5"
        Label5.Size = New Size(159, 28)
        Label5.TabIndex = 15
        Label5.Text = "Tanggal CheckIn"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(22, 137)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 28)
        Label4.TabIndex = 14
        Label4.Text = "Harga"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(22, 70)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 28)
        Label3.TabIndex = 13
        Label3.Text = "No Kamar"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Ravie", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.IndianRed
        Label8.Location = New Point(491, 26)
        Label8.Name = "Label8"
        Label8.Size = New Size(138, 59)
        Label8.TabIndex = 16
        Label8.Text = "OUT"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Ravie", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.MenuHighlight
        Label9.Location = New Point(289, 26)
        Label9.Name = "Label9"
        Label9.Size = New Size(210, 59)
        Label9.TabIndex = 15
        Label9.Text = "CHECK"
        ' 
        ' FormCheckOut
        ' 
        AutoScaleDimensions = New SizeF(12F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.GhostWhite
        ClientSize = New Size(960, 504)
        Controls.Add(Label8)
        Controls.Add(Label9)
        Controls.Add(GroupBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnProsesBayar)
        Controls.Add(btnHitung)
        Controls.Add(cmbMetodeBayar)
        Controls.Add(dtpCheckOut)
        Controls.Add(cmbPilihTamu)
        Font = New Font("Perpetua", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "FormCheckOut"
        Text = "FormCheckOut"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbPilihTamu As ComboBox
    Friend WithEvents txtKamar As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtTglCheckIn As TextBox
    Friend WithEvents txtLamaMenginap As TextBox
    Friend WithEvents txtTotalTagihan As TextBox
    Friend WithEvents dtpCheckOut As DateTimePicker
    Friend WithEvents cmbMetodeBayar As ComboBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents btnProsesBayar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
