Public Class Statustable

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Close()
    End Sub

    Private Sub PictureBox4_Click_1(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim namecheck1 As String
        btn1.BackColor = Color.Red
        If btn1.BackColor = Color.Red And rebugtable1 = 0 Then
            namereverse1 = InputBox("** กรุณาระบุชื่อผู้จอง ** ", "การแจ้งเตือนจากระบบ", MessageBoxButtons.OKCancel)
            people1 = Val(InputBox("** กรุณาระบุจำนวนที่นั่ง ** ", "การแจ้งเตือนจากระบบ", MessageBoxButtons.OKCancel))
            table1 = "full"
            Selectfood1.Show()
            Me.Hide()
        End If
        If ssum < 1 Then
            If rebugtable1 = 1 Then
                btn1.Enabled = True
                If MessageBox.Show("** คุณได้ทำการจองไว้ใช่หรือไม่ ** ", "การแจ้งเตือนจากระบบ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    namecheck1 = InputBox("** กรุณาระบุชื่อผู้จอง ** ", "การแจ้งเตือนจากระบบ", MessageBoxButtons.OK)
                    If namecheck1 = namereverse1 Then 'เช้คชื่อจองให้ตรง
                        MessageBox.Show("** ยินดีต้อนรับคุณ " & namereverse1 & " กำลังเข้าสู่โต๊ะที่คุณจองไว้ **", "การแจ้งเตือนจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        btn1.BackColor = Color.Red
                        Selectfood1.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("** ขออภัยไม่มีชื่อผู้จองในระบบ **", "การแจ้งเตือนจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    End If
                Else
                    Exit Sub
                End If
            End If
        Else
            table1 = "full"
            If table1 = "full" Then
                btn1.BackColor = Color.Red
                btn1.Enabled = False
                Selectfood1.Show()
                Me.Hide()
            Else
                table1 = "null"
                btn1.BackColor = Color.Green
                btn1.Enabled = True
            End If
        End If
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Reserve.Show()
        Me.Hide()
    End Sub
    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter
        Reserve.Show()
        Me.Hide()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbldate.Text = Now.ToShortDateString
        lbltime.Text = TimeOfDay
    End Sub

    Private Sub Statustable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Label7.Hide()
        Label8.Hide()
        Label9.Hide()
        If rebugtable1 = 1 Then        '  ********  แก้บัคจองไม่ขึ้นแดง  *********
            btn1.BackColor = Color.Red
        ElseIf table1 = "null" Then
            btn1.Enabled = True
            btn1.BackColor = Color.Green
            Label7.Hide()
        End If
        If rebugtable2 = 1 Then        '  ********  แก้บัคจองไม่ขึ้นแดง  *********
            btn2.BackColor = Color.Red

        ElseIf table2 = "null" Then
            btn2.Enabled = True
            btn2.BackColor = Color.Green
            Label8.Hide()
        End If
        If rebugtable3 = 1 Then        '  ********  แก้บัคจองไม่ขึ้นแดง  *********
            btn3.BackColor = Color.Red

        ElseIf table3 = "null" Then
            btn3.Enabled = True
            btn3.BackColor = Color.Green
            Label9.Hide()
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

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        '********************  โต๊ะ ที่1  *********************
        If ssum > 1 Then  ' กลับมากดโตีะซ้ำได้ถ้ามีรายการ
            btn1.Enabled = True
            btn1.BackColor = Color.Red
            Label7.Show()
        ElseIf ssum = 0 Then
            Label7.Hide()
            btn1.Enabled = True
            btn1.BackColor = Color.Green
        End If
        '  ********  แก้บัคจองไม่ขึ้นแดง  *********
        If rebugtable1 = 1 Then
            btn1.BackColor = Color.Red
        End If
        If table1 = "null" Then
            btn1.Enabled = True
            btn1.BackColor = Color.Green
            Label7.Hide()
        End If
        '********************  โต๊ะ ที่2  *********************
        If ssum2 > 1 Then  ' กลับมากดโตีะซ้ำได้ถ้ามีรายการ
            btn2.Enabled = True
            btn2.BackColor = Color.Red
            Label8.Show()
        ElseIf ssum2 = 0 Then
            Label8.Hide()
            btn2.Enabled = True
            btn2.BackColor = Color.Green
        End If
        '  ********  แก้บัคจองไม่ขึ้นแดง  *********
        If rebugtable2 = 1 Then
            btn2.BackColor = Color.Red
        End If
        If table2 = "null" Then
            btn2.Enabled = True
            btn2.BackColor = Color.Green
            Label8.Hide()
        End If
        '********************  โต๊ะ ที่3  *********************
        If ssum3 > 1 Then  ' กลับมากดโตีะซ้ำได้ถ้ามีรายการ
            btn3.Enabled = True
            btn3.BackColor = Color.Red
            Label9.Show()
        ElseIf ssum3 = 0 Then
            Label9.Hide()
            btn3.Enabled = True
            btn3.BackColor = Color.Green
        End If
        '  ********  แก้บัคจองไม่ขึ้นแดง  *********
        If rebugtable3 = 1 Then
            btn3.BackColor = Color.Red
        End If
        If table3 = "null" Then
            btn3.Enabled = True
            btn3.BackColor = Color.Green
            Label9.Hide()
        End If

        If table4 = "full" Then
            btnhome.BackColor = Color.Red
            If ssum4 > 1 Then
                btnhome.Enabled = True
            Else
                btnhome.Enabled = False
            End If
        Else
            btnhome.Enabled = True
            btnhome.BackColor = Color.Green
        End If

    End Sub
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Selectfood1.Show()
        Me.Hide()
    End Sub
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Selectfood2.Show()
        Me.Hide()
    End Sub
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label7.Click
        selectfood3.Show()
        Me.Hide()
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Dim namecheck2 As String
        btn2.BackColor = Color.Red
        If btn2.BackColor = Color.Red And rebugtable2 = 0 Then
            namereverse2 = InputBox("** กรุณาระบุชื่อผู้จอง ** ", "การแจ้งเตือนจากระบบ", MessageBoxButtons.OKCancel)
            people2 = Val(InputBox("** กรุณาระบุจำนวนที่นั่ง ** ", "การแจ้งเตือนจากระบบ", MessageBoxButtons.OKCancel))
            table2 = "full"
            Selectfood2.Show()
            Me.Hide()
        End If
        If ssum2 < 1 Then
            If rebugtable2 = 1 Then
                btn2.Enabled = True
                If MessageBox.Show("** คุณได้ทำการจองไว้ใช่หรือไม่ ** ", "การแจ้งเตือนจากระบบ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    namecheck2 = InputBox("** กรุณาระบุชื่อผู้จอง ** ", "การแจ้งเตือนจากระบบ", MessageBoxButtons.OK)
                    If namecheck2 = namereverse2 Then 'เช้คชื่อจองให้ตรง
                        MessageBox.Show("** ยินดีต้อนรับคุณ " & namereverse2 & " กำลังเข้าสู่โต๊ะที่คุณจองไว้ **", "การแจ้งเตือนจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        btn2.BackColor = Color.Red
                        btn2.Enabled = False
                        Selectfood2.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("** ขออภัยไม่มีชื่อผู้จองในระบบ **", "การแจ้งเตือนจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    End If
                Else
                    Exit Sub
                End If
            End If
        Else
            table2 = "full"
            If table2 = "full" Then
                btn2.BackColor = Color.Red
                btn2.Enabled = False
                Selectfood2.Show()
                Me.Hide()
            Else
                table2 = "null"
                btn2.BackColor = Color.Green
                btn2.Enabled = True
            End If
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Dim namecheck3 As String
        btn3.BackColor = Color.Red
        If btn3.BackColor = Color.Red And rebugtable3 = 0 Then
            namereverse3 = InputBox("** กรุณาระบุชื่อผู้จอง ** ", "การแจ้งเตือนจากระบบ", MessageBoxButtons.OKCancel)
            people3 = Val(InputBox("** กรุณาระบุจำนวนที่นั่ง ** ", "การแจ้งเตือนจากระบบ", MessageBoxButtons.OKCancel))
            table3 = "full"
            Selectfood3.Show()
            Me.Hide()
        End If
        If ssum3 < 1 Then
            If rebugtable3 = 1 Then
                btn3.Enabled = True
                If MessageBox.Show("** คุณได้ทำการจองไว้ใช่หรือไม่ ** ", "การแจ้งเตือนจากระบบ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    namecheck3 = InputBox("** กรุณาระบุชื่อผู้จอง ** ", "การแจ้งเตือนจากระบบ", MessageBoxButtons.OK)
                    If namecheck3 = namereverse3 Then 'เช้คชื่อจองให้ตรง
                        MessageBox.Show("** ยินดีต้อนรับคุณ " & namereverse3 & " กำลังเข้าสู่โต๊ะที่คุณจองไว้ **", "การแจ้งเตือนจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        btn3.BackColor = Color.Red
                        btn3.Enabled = False
                        Selectfood3.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("** ขออภัยไม่มีชื่อผู้จองในระบบ **", "การแจ้งเตือนจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    End If
                Else
                    Exit Sub
                End If
            End If
        Else
            table3 = "full"
            If table3 = "full" Then
                btn3.BackColor = Color.Red
                btn3.Enabled = False
                selectfood3.Show()
                Me.Hide()
            Else
                table3 = "null"
                btn3.BackColor = Color.Green
                btn3.Enabled = True
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Sales.Show()
        Me.Hide()
    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        If btnhome.BackColor = Color.Green Then
            namereverse4 = InputBox("** กรุณาระบุชื่อลูกค้า ** ", "การแจ้งเตือนจากระบบ", MessageBoxButtons.OK)
            table4 = "full"
            btnhome.BackColor = Color.Red
            Selectfoodhome.Show()
            Me.Hide()
        Else
            If ssum4 > 1 Then
                btnhome.Enabled = True
                Selectfoodhome.Show()
                Me.Hide()
            Else
                btnhome.Enabled = False
            End If
        End If

    End Sub
End Class