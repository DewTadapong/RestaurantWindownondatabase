Public Class Reserve
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Close()
    End Sub

    Private Sub Reserve_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        namereverse2 = TextBox3.Text
        people2 = Val(TextBox4.Text)
        namereverse3 = TextBox5.Text
        people3 = Val(TextBox6.Text)
        TextBox1.Hide()
        TextBox2.Hide()
        TextBox3.Hide()
        TextBox4.Hide()
        TextBox5.Hide()
        TextBox6.Hide()
        Enter1.Hide()
        Enter2.Hide()
        Enter3.Hide()
        ing1.Hide()
        ing2.Hide()
        ing3.Hide()
        Timer1.Start()
        If table1 = "full" Then
            btn1.BackColor = Color.Red
            btn1.Enabled = False
        ElseIf table1 = "null" Then
            btn1.BackColor = Color.Green
            btn1.Enabled = True
        End If
        ' *****************  โต๊ะ 2 ***********************
        If table2 = "full" Then
            btn2.BackColor = Color.Red
            btn2.Enabled = False
        ElseIf table2 = "null" Then
            btn2.BackColor = Color.Green
            btn2.Enabled = True
        End If
        ' *****************  โต๊ะ 3 ***********************
        If table3 = "full" Then
            btn3.BackColor = Color.Red
            btn3.Enabled = False
        ElseIf table3 = "null" Then
            btn3.BackColor = Color.Green
            btn3.Enabled = True
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbldate.Text = Now.ToShortDateString
        lbltime.Text = TimeOfDay
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Yes1 = 1
        ing1.Show()
        Enter1.Show()
        Enterno.Hide()
        Enter2.Hide()
        Enter3.Hide()
        btn2.Enabled = False
        btn3.Enabled = False
        TextBox1.Show()
        TextBox2.Show()
        TextBoxno1.Hide()
        TextBoxno2.Hide()
        If rebugtable1 = 0 Then
            TextBox1.Text = ""
            TextBox2.Text = 0
        End If
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Statustable.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        ' *****************  โต๊ะ 1 ***********************
        If table1 = "full" Then
            btn1.BackColor = Color.Red
            btn1.Enabled = False
        ElseIf table1 = "null" Then
            btn1.BackColor = Color.Green
            btn1.Enabled = True
        End If
        ' *****************  โต๊ะ 2 ***********************
        If table2 = "full" Then
            btn2.BackColor = Color.Red
            btn2.Enabled = False
        ElseIf table2 = "null" Then
            btn2.BackColor = Color.Green
            btn2.Enabled = True
        End If
        ' *****************  โต๊ะ 3 ***********************
        If table3 = "full" Then
            btn3.BackColor = Color.Red
            btn3.Enabled = False
        ElseIf table3 = "null" Then
            btn3.BackColor = Color.Green
            btn3.Enabled = True
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Yes2 = 1
        ing2.Show()
        Enter2.Show()
        Enterno.Hide()
        Enter1.Hide()
        Enter3.Hide()
        btn1.Enabled = False
        btn3.Enabled = False
        TextBox3.Show()
        TextBox4.Show()
        TextBoxno1.Hide()
        TextBoxno2.Hide()
        If rebugtable2 = 0 Then
            TextBox3.Text = ""
            TextBox4.Text = 0
        End If
    End Sub
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Yes3 = 1
        ing3.Show()
        Enter3.Show()
        Enterno.Hide()
        Enter1.Hide()
        Enter2.Hide()
        btn2.Enabled = False
        btn1.Enabled = False
        TextBox5.Show()
        TextBox6.Show()
        TextBoxno1.Hide()
        TextBoxno2.Hide()
        If rebugtable3 = 0 Then
            TextBox5.Text = ""
            TextBox6.Text = 0
        End If
    End Sub

    Private Sub Enter1_Click(sender As Object, e As EventArgs) Handles Enter1.Click
        If btn1.BackColor = Color.Green Then
            btn1.Enabled = True
        Else
            btn1.Enabled = False
        End If
        If btn2.BackColor = Color.Green Then
            btn2.Enabled = True
        Else
            btn2.Enabled = False
        End If
        If btn3.BackColor = Color.Green Then
            btn3.Enabled = True
        Else
            btn3.Enabled = False
        End If

        '********************   โต๊ะ 1   ***************************
        namereverse1 = TextBox1.Text
        people1 = Val(TextBox2.Text)
        If MessageBox.Show("ยืนยันการจองโต๊ะอาหารที่ 1 ใช่หรือไม่",
                 "การแจ้งเตื่อนจากระบบ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If Yes1 = 1 And people1 > 0 And namereverse1 <> "" Then
                If btn1.BackColor = Color.Green Then
                    table1 = "full"
                Else
                    table1 = "null"
                End If
                If table1 = "full" Then
                    btn1.BackColor = Color.Red
                    btn1.Enabled = False
                    rebugtable1 = 1
                End If
                MessageBox.Show("คุณ " & TextBox1.Text & " จองโต๊ะอาหารที่ 1 เป็นที่เรียบร้อยแล้ว",
                         "การแจ้งเตื่อนจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBoxno1.Show()
                TextBoxno2.Show()
                Enterno.Show()
                Enter1.Hide()
                TextBox1.Hide()
                TextBox2.Hide()
                TextBox3.Hide()
                TextBox4.Hide()
                TextBox5.Hide()
                TextBox6.Hide()
                ing1.Hide()
            Else
                MessageBox.Show("** ขออภัยคุณกรอกข้อมูลไม่ครบถ้วน ** " & vbNewLine & "      *** ไม่สามารถจองโต๊ะได้ ***",
                       "การแจ้งเตื่อนจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                btn2.Enabled = False
                btn3.Enabled = False
            End If
        Else
            TextBoxno1.Show()
            TextBoxno2.Show()
            TextBox1.Hide()
            TextBox2.Hide()
            Enterno.Show()
            Enter1.Hide()
            ing1.Hide()
            Yes1 = 0
            TextBox1.Text = ""
            TextBox2.Text = ""
            Exit Sub
        End If

    End Sub
    Private Sub Enter2_Click_1(sender As Object, e As EventArgs) Handles Enter2.Click
        If btn1.BackColor = Color.Green Then
            btn1.Enabled = True
        Else
            btn1.Enabled = False
        End If
        If btn2.BackColor = Color.Green Then
            btn2.Enabled = True
        Else
            btn2.Enabled = False
        End If
        If btn3.BackColor = Color.Green Then
            btn3.Enabled = True
        Else
            btn3.Enabled = False
        End If

        '********************   โต๊ะ 2   ***************************
        namereverse2 = TextBox3.Text
        people2 = Val(TextBox4.Text)
        If MessageBox.Show("ยืนยันการจองโต๊ะอาหารที่ 2 ใช่หรือไม่",
                "การแจ้งเตื่อนจากระบบ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If Yes2 = 1 And people2 > 0 And namereverse2 <> "" Then
                If btn2.BackColor = Color.Green Then
                    table2 = "full"
                Else
                    table2 = "null"
                End If
                If table2 = "full" Then
                    btn2.BackColor = Color.Red
                    btn2.Enabled = False
                    rebugtable2 = 1
                End If
                MessageBox.Show("คุณ " & TextBox3.Text & " จองโต๊ะอาหารที่ 2 เป็นที่เรียบร้อยแล้ว",
                     "การแจ้งเตื่อนจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBoxno1.Show()
                TextBoxno2.Show()
                Enterno.Show()
                Enter2.Hide()
                TextBox1.Hide()
                TextBox2.Hide()
                TextBox3.Hide()
                TextBox4.Hide()
                TextBox5.Hide()
                TextBox6.Hide()
                ing2.Hide()
            Else
                MessageBox.Show("** ขออภัยคุณกรอกข้อมูลไม่ครบถ้วน ** " & vbNewLine & "      *** ไม่สามารถจองโต๊ะได้ ***",
                   "การแจ้งเตื่อนจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                btn1.Enabled = False
                btn3.Enabled = False
            End If
        Else
            TextBoxno1.Show()
            TextBoxno2.Show()
            TextBox3.Hide()
            TextBox4.Hide()
            Enterno.Show()
            Enter2.Hide()
            ing2.Hide()
            Yes2 = 0
            TextBox3.Text = ""
            TextBox4.Text = ""
            Exit Sub
        End If

    End Sub
    Private Sub Enter3_Click_1(sender As Object, e As EventArgs) Handles Enter3.Click
        If btn1.BackColor = Color.Green Then
            btn1.Enabled = True
        Else
            btn1.Enabled = False
        End If
        If btn2.BackColor = Color.Green Then
            btn2.Enabled = True
        Else
            btn2.Enabled = False
        End If
        If btn3.BackColor = Color.Green Then
            btn3.Enabled = True
        Else
            btn3.Enabled = False
        End If

        '********************   โต๊ะ 3   ***************************
        namereverse3 = TextBox5.Text
        people3 = Val(TextBox6.Text)
        If MessageBox.Show("ยืนยันการจองโต๊ะอาหารที่ 3 ใช่หรือไม่",
                 "การแจ้งเตื่อนจากระบบ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If Yes3 = 1 And people3 > 0 And namereverse3 <> "" Then
                If btn3.BackColor = Color.Green Then
                    table3 = "full"
                Else
                    table3 = "null"
                End If
                If table3 = "full" Then
                    btn3.BackColor = Color.Red
                    btn3.Enabled = False
                    rebugtable3 = 1
                End If
                MessageBox.Show("คุณ " & TextBox5.Text & " จองโต๊ะอาหารที่ 3 เป็นที่เรียบร้อยแล้ว",
                         "การแจ้งเตื่อนจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBoxno1.Show()
                TextBoxno2.Show()
                Enterno.Show()
                Enter3.Hide()
                TextBox1.Hide()
                TextBox2.Hide()
                TextBox3.Hide()
                TextBox4.Hide()
                TextBox5.Hide()
                TextBox6.Hide()
                ing3.Hide()

            Else
                MessageBox.Show("** ขออภัยคุณกรอกข้อมูลไม่ครบถ้วน ** " & vbNewLine & "      *** ไม่สามารถจองโต๊ะได้ ***",
                        "การแจ้งเตื่อนจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                btn2.Enabled = False
                btn1.Enabled = False
            End If
        Else
            TextBoxno1.Show()
            TextBoxno2.Show()
            TextBox5.Hide()
            TextBox6.Hide()
            Enterno.Show()
            Enter3.Hide()
            ing3.Hide()
            Yes3 = 0
            TextBox5.Text = ""
            TextBox6.Text = ""

            Exit Sub
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Sales.Show()
        Me.Hide()
    End Sub
End Class

