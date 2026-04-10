Public Class FormKamar
    Dim dt As New DataTable

    Private Sub FormKamar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt.Columns.Add("NoKamar")
        dt.Columns.Add("Tipe")
        dt.Columns.Add("Harga")
        dt.Columns.Add("Status")

        dgvKamar.DataSource = dt

        cmbTipe.Items.Add("Standard")
        cmbTipe.Items.Add("Deluxe")
        cmbTipe.Items.Add("Suite")

        cmbStatus.Items.Add("Kosong")
        cmbStatus.Items.Add("Terisi")
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        dt.Rows.Add(txtNoKamar.Text, cmbTipe.Text, txtHarga.Text, cmbStatus.Text)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        For Each row As DataRow In dt.Rows
            If row("NoKamar") = txtNoKamar.Text Then
                row("Tipe") = cmbTipe.Text
                row("Harga") = txtHarga.Text
                row("Status") = cmbStatus.Text
            End If
        Next
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        For i As Integer = dt.Rows.Count - 1 To 0 Step -1
            If dt.Rows(i)("NoKamar") = txtNoKamar.Text Then
                dt.Rows.RemoveAt(i)
            End If
        Next
    End Sub

    Private Sub dgvKamar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKamar.CellClick
        If e.RowIndex >= 0 Then
            txtNoKamar.Text = dgvKamar.Rows(e.RowIndex).Cells(0).Value
            cmbTipe.Text = dgvKamar.Rows(e.RowIndex).Cells(1).Value
            txtHarga.Text = dgvKamar.Rows(e.RowIndex).Cells(2).Value
            cmbStatus.Text = dgvKamar.Rows(e.RowIndex).Cells(3).Value
        End If
    End Sub
End Class