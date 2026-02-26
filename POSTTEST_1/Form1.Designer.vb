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
        lblsem = New Label()
        lblkum = New Label()
        txtisi = New TextBox()
        btntambah = New Button()
        btnreset = New Button()
        txtkum = New TextBox()
        lblket = New Label()
        SuspendLayout()
        ' 
        ' lblsem
        ' 
        lblsem.AutoSize = True
        lblsem.Location = New Point(101, 129)
        lblsem.Name = "lblsem"
        lblsem.Size = New Size(105, 25)
        lblsem.TabIndex = 0
        lblsem.Text = "IP Semester"
        ' 
        ' lblkum
        ' 
        lblkum.AutoSize = True
        lblkum.Location = New Point(101, 250)
        lblkum.Name = "lblkum"
        lblkum.Size = New Size(107, 25)
        lblkum.TabIndex = 1
        lblkum.Text = "IP Kumulatif"
        ' 
        ' txtisi
        ' 
        txtisi.Location = New Point(269, 129)
        txtisi.Name = "txtisi"
        txtisi.Size = New Size(190, 31)
        txtisi.TabIndex = 2
        ' 
        ' btntambah
        ' 
        btntambah.Location = New Point(269, 191)
        btntambah.Name = "btntambah"
        btntambah.Size = New Size(94, 34)
        btntambah.TabIndex = 3
        btntambah.Text = "Tambah"
        btntambah.UseVisualStyleBackColor = True
        ' 
        ' btnreset
        ' 
        btnreset.Location = New Point(369, 191)
        btnreset.Name = "btnreset"
        btnreset.Size = New Size(90, 34)
        btnreset.TabIndex = 4
        btnreset.Text = "Reset"
        btnreset.UseVisualStyleBackColor = True
        ' 
        ' txtkum
        ' 
        txtkum.Location = New Point(269, 250)
        txtkum.Name = "txtkum"
        txtkum.Size = New Size(190, 31)
        txtkum.TabIndex = 5
        ' 
        ' lblket
        ' 
        lblket.AutoSize = True
        lblket.Location = New Point(280, 317)
        lblket.Name = "lblket"
        lblket.Size = New Size(168, 25)
        lblket.TabIndex = 6
        lblket.Text = "Sangat Memuaskan"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblket)
        Controls.Add(txtkum)
        Controls.Add(btnreset)
        Controls.Add(btntambah)
        Controls.Add(txtisi)
        Controls.Add(lblkum)
        Controls.Add(lblsem)
        Name = "Form1"
        Text = "Kalkulator IP"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblsem As Label
    Friend WithEvents lblkum As Label
    Friend WithEvents txtisi As TextBox
    Friend WithEvents btntambah As Button
    Friend WithEvents btnreset As Button
    Friend WithEvents txtkum As TextBox
    Friend WithEvents lblket As Label

End Class
