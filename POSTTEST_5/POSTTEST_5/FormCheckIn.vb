Public Class FormCheckIn
    Dim dt As New DataTable

    Private Sub FormCheckIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt.Columns.Add("Nama")
        dt.Columns.Add("Kamar")
        dt.Columns.Add("Tanggal")

        dgvCheckIn.DataSource = dt
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        dt.Rows.Add(txtNama.Text, txtKamar.Text, dtpTanggal.Value)
    End Sub
End Class