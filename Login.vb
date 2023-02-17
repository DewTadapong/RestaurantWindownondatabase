Public Class Login
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtuser.Text = User And txtpass.Text = Pass Then
            MsgBox("!! เข้าสู่ระบบสำเร็จ !!", MsgBoxStyle.Information, "ข้อความจากระบบ")
            Home.Show()
            Me.Hide()
        Else
            MsgBox("!! รหัสผ่านไม่ถูกต้อง !!", MsgBoxStyle.Critical, "ข้อความจากระบบ")
        End If
    End Sub

    Private Sub lblregister_Click(sender As Object, e As EventArgs) Handles lblregister.Click
        Register.Show()
        Me.Hide()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class