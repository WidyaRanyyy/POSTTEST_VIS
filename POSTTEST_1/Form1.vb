Public Class Form1
    Dim totalSEM As Double = 0
    Dim jumlahSemester As Integer = 0

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblsem.Click

    End Sub

    Private Sub txtisi_TextChanged(sender As Object, e As EventArgs) Handles txtisi.TextChanged

    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        Dim sem As Double

        If Double.TryParse(txtisi.Text, sem) Then

            ' Validasi 0 - 4
            If sem < 0 Or sem > 4 Then
                MessageBox.Show("IP Semester harus antara 0 - 4")
                Exit Sub
            End If

            totalSEM += sem
            jumlahSemester += 1

            Dim kum As Double = totalSEM / jumlahSemester

            txtkum.Text = kum.ToString("0.00")
            lblket.Text = TentukanPredikat(kum)
        Else
            MessageBox.Show("Masukkan angka yang valid!")
        End If

    End Sub

    Private Function TentukanPredikat(kum As Double) As String

        If kum <= 2.75 Then
            Return "Cukup"
        ElseIf kum <= 3.0 Then
            Return "Memuaskan"
        Else
            Return "Sangat Memuaskan"
        End If

    End Function

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        totalSEM = 0
        jumlahSemester = 0

        txtisi.Text = ""
        txtkum.Text = ""
        lblket.Text = "-"

    End Sub

    Private Sub txtkum_TextChanged(sender As Object, e As EventArgs) Handles txtkum.TextChanged

    End Sub
End Class
