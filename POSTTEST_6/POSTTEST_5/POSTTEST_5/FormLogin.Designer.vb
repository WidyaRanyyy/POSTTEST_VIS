<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        Label1 = New Label()
        Label2 = New Label()
        GroupBox1 = New GroupBox()
        txtPass = New TextBox()
        txtUser = New TextBox()
        btnLogin = New Button()
        btnKeluar = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(30, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 28)
        Label1.TabIndex = 0
        Label1.Text = "User"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(30, 111)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 28)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.White
        GroupBox1.Controls.Add(txtPass)
        GroupBox1.Controls.Add(txtUser)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(253, 188)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(459, 174)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Form Login"
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(178, 108)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(237, 35)
        txtPass.TabIndex = 3
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(178, 56)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(237, 35)
        txtUser.TabIndex = 2
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(339, 402)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(112, 43)
        btnLogin.TabIndex = 3
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(515, 402)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(112, 43)
        btnKeluar.TabIndex = 4
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Ravie", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.MenuHighlight
        Label3.Location = New Point(206, 53)
        Label3.Name = "Label3"
        Label3.Size = New Size(309, 59)
        Label3.TabIndex = 5
        Label3.Text = "SELAMAT"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(305, 129)
        Label4.Name = "Label4"
        Label4.Size = New Size(350, 28)
        Label4.TabIndex = 6
        Label4.Text = "Silahkan Masukkan User dan Password"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Ravie", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.IndianRed
        Label5.Location = New Point(515, 53)
        Label5.Name = "Label5"
        Label5.Size = New Size(252, 59)
        Label5.TabIndex = 7
        Label5.Text = "DATANG"
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(12F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.GhostWhite
        ClientSize = New Size(960, 504)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(btnKeluar)
        Controls.Add(btnLogin)
        Controls.Add(GroupBox1)
        Font = New Font("Perpetua", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 3, 4, 3)
        Name = "FormLogin"
        Text = "Form Login"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label

End Class
