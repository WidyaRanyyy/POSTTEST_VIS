<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCheckIn
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
        txtNama = New TextBox()
        Label1 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        txtKamar = New TextBox()
        dtpTanggal = New DateTimePicker()
        Label4 = New Label()
        btnSimpan = New Button()
        GroupBox1 = New GroupBox()
        dgvCheckIn = New DataGridView()
        Label5 = New Label()
        GroupBox1.SuspendLayout()
        CType(dgvCheckIn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(171, 44)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(300, 35)
        txtNama.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(27, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 28)
        Label1.TabIndex = 1
        Label1.Text = "Nama"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Ravie", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.MenuHighlight
        Label3.Location = New Point(283, 34)
        Label3.Name = "Label3"
        Label3.Size = New Size(181, 59)
        Label3.TabIndex = 6
        Label3.Text = "DATA"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(27, 117)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 28)
        Label2.TabIndex = 8
        Label2.Text = "Kamar"
        ' 
        ' txtKamar
        ' 
        txtKamar.Location = New Point(171, 114)
        txtKamar.Name = "txtKamar"
        txtKamar.Size = New Size(300, 35)
        txtKamar.TabIndex = 7
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.Location = New Point(171, 195)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(300, 35)
        dtpTanggal.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(27, 202)
        Label4.Name = "Label4"
        Label4.Size = New Size(81, 28)
        Label4.TabIndex = 10
        Label4.Text = "Tanggal"
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(198, 271)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(112, 34)
        btnSimpan.TabIndex = 11
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnSimpan)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(dtpTanggal)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtKamar)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtNama)
        GroupBox1.Location = New Point(56, 118)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(516, 330)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        ' 
        ' dgvCheckIn
        ' 
        dgvCheckIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCheckIn.Location = New Point(610, 130)
        dgvCheckIn.Name = "dgvCheckIn"
        dgvCheckIn.RowHeadersWidth = 62
        dgvCheckIn.Size = New Size(307, 315)
        dgvCheckIn.TabIndex = 13
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Ravie", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.IndianRed
        Label5.Location = New Point(455, 34)
        Label5.Name = "Label5"
        Label5.Size = New Size(198, 59)
        Label5.TabIndex = 14
        Label5.Text = "TAMU"
        ' 
        ' FormCheckIn
        ' 
        AutoScaleDimensions = New SizeF(12F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.GhostWhite
        ClientSize = New Size(960, 504)
        Controls.Add(Label5)
        Controls.Add(dgvCheckIn)
        Controls.Add(GroupBox1)
        Controls.Add(Label3)
        Font = New Font("Perpetua", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 3, 4, 3)
        Name = "FormCheckIn"
        Text = "FormCheckIn"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgvCheckIn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtKamar As TextBox
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvCheckIn As DataGridView
    Friend WithEvents Label5 As Label
End Class
