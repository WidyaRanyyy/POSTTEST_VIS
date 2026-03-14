Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblnama.Text = DataModule.Nama
        lblumur.Text = DataModule.Umur
        lblTelp.Text = DataModule.Telp
        lblAlamat.Text = DataModule.Alamat
        lblTLahir.Text = DataModule.Tglahir.ToString("dd MMMM yyyy")
        lblJK.Text = DataModule.JK
        lblHobi.Text = DataModule.Hobi

        If Not String.IsNullOrEmpty(DataModule.Foto) Then
            pbFoto.Image = Image.FromFile(DataModule.Foto)
        End If
    End Sub
End Class