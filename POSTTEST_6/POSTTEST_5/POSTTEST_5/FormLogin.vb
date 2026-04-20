Imports MySqlConnector

Public Class FormLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' 1. Cek apakah ada textbox yang kosong (jika Anda masih pakai ModulValidasi)
        If txtUser.Text = "" Or txtPass.Text = "" Then
            MessageBox.Show("Username dan Password harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            ' 2. Panggil koneksi dari ConnectionModule
            Using conn As MySqlConnection = GetConnection()

                ' 3. Siapkan Query (Menggunakan Parameter agar kebal dari Hacker / SQL Injection)
                Dim query As String = "SELECT * FROM admin WHERE username = @user AND pasword = @pass"

                Using cmd As New MySqlCommand(query, conn)
                    ' Masukkan data dari textbox ke parameter
                    cmd.Parameters.AddWithValue("@user", txtUser.Text)
                    cmd.Parameters.AddWithValue("@pass", txtPass.Text)

                    ' Buka koneksi
                    conn.Open()

                    ' Eksekusi dan baca datanya
                    Using rd As MySqlDataReader = cmd.ExecuteReader()
                        If rd.HasRows Then
                            rd.Read()
                            MessageBox.Show("Login berhasil! Selamat datang, " & rd("username").ToString(), "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            FormUtama.Show()
                            Me.Hide()
                        Else
                            MessageBox.Show("Username atau Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            txtPass.Clear()
                            txtUser.Focus()
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error Database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        ' Memunculkan kotak dialog konfirmasi
        Dim peringatan As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Jika pengguna memilih "Yes", maka aplikasi akan ditutup
        If peringatan = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class