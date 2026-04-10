<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKamar
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
        txtNoKamar = New TextBox()
        Label1 = New Label()
        cmbTipe = New ComboBox()
        Label2 = New Label()
        Label3 = New Label()
        txtHarga = New TextBox()
        cmbStatus = New ComboBox()
        Label4 = New Label()
        dgvKamar = New DataGridView()
        Form = New GroupBox()
        btnTambah = New Button()
        btnHapus = New Button()
        btnClear = New Button()
        btnUpdate = New Button()
        Label5 = New Label()
        Label6 = New Label()
        CType(dgvKamar, ComponentModel.ISupportInitialize).BeginInit()
        Form.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtNoKamar
        ' 
        txtNoKamar.Location = New Point(250, 57)
        txtNoKamar.Name = "txtNoKamar"
        txtNoKamar.Size = New Size(182, 35)
        txtNoKamar.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(58, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(138, 28)
        Label1.TabIndex = 1
        Label1.Text = "Nomor Kamar"
        ' 
        ' cmbTipe
        ' 
        cmbTipe.FormattingEnabled = True
        cmbTipe.Location = New Point(250, 103)
        cmbTipe.Name = "cmbTipe"
        cmbTipe.Size = New Size(182, 36)
        cmbTipe.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(58, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 28)
        Label2.TabIndex = 3
        Label2.Text = "Tipe Kamar"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(58, 159)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 28)
        Label3.TabIndex = 4
        Label3.Text = "Harga"
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(250, 156)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(182, 35)
        txtHarga.TabIndex = 5
        ' 
        ' cmbStatus
        ' 
        cmbStatus.FormattingEnabled = True
        cmbStatus.Location = New Point(250, 211)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(182, 36)
        cmbStatus.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(58, 214)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 28)
        Label4.TabIndex = 7
        Label4.Text = "Status"
        ' 
        ' dgvKamar
        ' 
        dgvKamar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvKamar.Location = New Point(569, 133)
        dgvKamar.Name = "dgvKamar"
        dgvKamar.RowHeadersWidth = 62
        dgvKamar.Size = New Size(360, 268)
        dgvKamar.TabIndex = 8
        ' 
        ' Form
        ' 
        Form.BackColor = Color.White
        Form.Controls.Add(Label4)
        Form.Controls.Add(cmbStatus)
        Form.Controls.Add(txtHarga)
        Form.Controls.Add(Label3)
        Form.Controls.Add(Label2)
        Form.Controls.Add(cmbTipe)
        Form.Controls.Add(Label1)
        Form.Controls.Add(txtNoKamar)
        Form.Location = New Point(35, 115)
        Form.Name = "Form"
        Form.Size = New Size(498, 286)
        Form.TabIndex = 9
        Form.TabStop = False
        Form.Text = "Form Data"
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(220, 439)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(100, 34)
        btnTambah.TabIndex = 10
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(360, 439)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(92, 34)
        btnHapus.TabIndex = 11
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(634, 439)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(85, 34)
        btnClear.TabIndex = 13
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(485, 439)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(112, 34)
        btnUpdate.TabIndex = 12
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Ravie", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.MenuHighlight
        Label5.Location = New Point(262, 28)
        Label5.Name = "Label5"
        Label5.Size = New Size(181, 59)
        Label5.TabIndex = 14
        Label5.Text = "DATA"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Ravie", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.IndianRed
        Label6.Location = New Point(436, 28)
        Label6.Name = "Label6"
        Label6.Size = New Size(250, 59)
        Label6.TabIndex = 15
        Label6.Text = "KAMAR"
        ' 
        ' FormKamar
        ' 
        AutoScaleDimensions = New SizeF(12F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.GhostWhite
        ClientSize = New Size(960, 504)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(btnClear)
        Controls.Add(btnUpdate)
        Controls.Add(btnHapus)
        Controls.Add(btnTambah)
        Controls.Add(Form)
        Controls.Add(dgvKamar)
        Font = New Font("Perpetua", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 3, 4, 3)
        Name = "FormKamar"
        Text = "FormKamar"
        CType(dgvKamar, ComponentModel.ISupportInitialize).EndInit()
        Form.ResumeLayout(False)
        Form.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNoKamar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbTipe As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvKamar As DataGridView
    Friend WithEvents Form As GroupBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
