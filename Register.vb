Public Class Register
    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        User = txtuser.Text
        Pass = txtpass.Text
        Position = txtposition.Text
        MsgBox("! สมัครสมาชิกเสร็จสิ้น !", MsgBoxStyle.Information, "ข้อความจากระบบ")
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub lbllogin_Click(sender As Object, e As EventArgs) Handles lbllogin.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub
End Class