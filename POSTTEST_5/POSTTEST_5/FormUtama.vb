Public Class FormUtama

    Private Sub DataKamarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataKamarToolStripMenuItem.Click
        FormKamar.ShowDialog()
    End Sub

    Private Sub CheckInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckInToolStripMenuItem.Click
        FormCheckIn.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        FormLogin.Show()
        Me.Hide()
    End Sub

End Class