<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
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
        MenuStrip1 = New MenuStrip()
        MasterDataToolStripMenuItem = New ToolStripMenuItem()
        DataKamarToolStripMenuItem = New ToolStripMenuItem()
        TransaksiToolStripMenuItem = New ToolStripMenuItem()
        CheckInToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        Label3 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {MasterDataToolStripMenuItem, TransaksiToolStripMenuItem, LogoutToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(960, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MasterDataToolStripMenuItem
        ' 
        MasterDataToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DataKamarToolStripMenuItem})
        MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        MasterDataToolStripMenuItem.Size = New Size(124, 29)
        MasterDataToolStripMenuItem.Text = "Master Data"
        ' 
        ' DataKamarToolStripMenuItem
        ' 
        DataKamarToolStripMenuItem.Name = "DataKamarToolStripMenuItem"
        DataKamarToolStripMenuItem.Size = New Size(206, 34)
        DataKamarToolStripMenuItem.Text = "Data Kamar"
        ' 
        ' TransaksiToolStripMenuItem
        ' 
        TransaksiToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CheckInToolStripMenuItem})
        TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        TransaksiToolStripMenuItem.Size = New Size(98, 29)
        TransaksiToolStripMenuItem.Text = "Transaksi"
        ' 
        ' CheckInToolStripMenuItem
        ' 
        CheckInToolStripMenuItem.Name = "CheckInToolStripMenuItem"
        CheckInToolStripMenuItem.Size = New Size(183, 34)
        CheckInToolStripMenuItem.Text = "Check-In"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(85, 29)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Ravie", 40F)
        Label3.ForeColor = SystemColors.MenuHighlight
        Label3.Location = New Point(100, 176)
        Label3.Name = "Label3"
        Label3.Size = New Size(385, 107)
        Label3.TabIndex = 7
        Label3.Text = "HOTEL"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Ravie", 40F)
        Label1.ForeColor = Color.IndianRed
        Label1.Location = New Point(455, 176)
        Label1.Name = "Label1"
        Label1.Size = New Size(433, 107)
        Label1.TabIndex = 8
        Label1.Text = "VISUAL"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Kristen ITC", 20F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.GrayText
        Label2.Location = New Point(280, 122)
        Label2.Name = "Label2"
        Label2.Size = New Size(409, 54)
        Label2.TabIndex = 9
        Label2.Text = "Selamat Datang Di"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Kristen ITC", 15F, FontStyle.Bold Or FontStyle.Italic)
        Label4.ForeColor = SystemColors.GrayText
        Label4.Location = New Point(329, 399)
        Label4.Name = "Label4"
        Label4.Size = New Size(315, 42)
        Label4.TabIndex = 10
        Label4.Text = "Selamat Menikmati"
        ' 
        ' FormUtama
        ' 
        AutoScaleDimensions = New SizeF(12F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.GhostWhite
        ClientSize = New Size(960, 504)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(MenuStrip1)
        Font = New Font("Perpetua", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MainMenuStrip = MenuStrip1
        Margin = New Padding(4, 3, 4, 3)
        Name = "FormUtama"
        Text = "FormUtama"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MasterDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataKamarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckInToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
End Class
