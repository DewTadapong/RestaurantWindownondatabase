Public Class Sales
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbldate.Text = Now.ToShortDateString
        lbltime.Text = TimeOfDay
    End Sub

    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        TextBox1.Text = 0
        TextBox2.Text = 0
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            TextBox1.Text += DataGridView1.Rows(i).Cells(4).Value
            TextBox2.Text += DataGridView1.Rows(i).Cells(1).Value

        Next

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Home.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Statustable.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Reserve.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        TextBox1.Text = 0
        TextBox2.Text = 0
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            TextBox1.Text += DataGridView1.Rows(i).Cells(4).Value
            TextBox2.Text += DataGridView1.Rows(i).Cells(1).Value

        Next
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Close()

    End Sub
End Class