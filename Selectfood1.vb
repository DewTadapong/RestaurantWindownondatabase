Imports System.Drawing.Printing
Public Class Selectfood1
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer
    Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = DataGridView1.Rows.Count
        longpaper = rowcount * 15
        longpaper = longpaper + 265
    End Sub
    Private Sub PictureBox26_Click(sender As Object, e As EventArgs) Handles PictureBox26.Click
        changelongpaper()
        PPD.Document = PD
        PPD.ShowDialog()

        table1 = "null"
        rebugtable1 = 0
        Yes1 = 0
        Yes2 = 0
        Yes3 = 0
        Clear_DG(DataGridView1)
        TextBox1.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""

        MessageBox.Show("** ปิดบิลโต๊ะ 1 เรียบร้อยแล้ว ** " & vbNewLine & "*** กำลังกลับสู่หน้าหลัก ***", "การแจ้งเตือนจากระบบ",
                                   MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        '**********************************************************************************
        Sales.DataGridView1.Rows.Add(User, people1, Label33.Text, namereverse1, ssum)
        '**********************************************************************************
        namereverse1 = ""
        people1 = 0
        Home.Show()
        Me.Hide()


    End Sub
    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 250, longpaper)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width
        'font alignment
        Dim right As New StringFormat
        Dim center As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String
        line = "--------------------------------------------------------------------------"

        'บนสุด
        e.Graphics.DrawString("ร้านอาหารไทย & อิตาเลียน", f14, Brushes.Black, centermargin, 5, center)
        e.Graphics.DrawString("131 หมู่10 บำราศนราดูร พลวง เขาคิชฌกูฏ จันทบุรี ", f8, Brushes.Black, centermargin, 25, center)
        e.Graphics.DrawString("Tel 064-6282730", f8, Brushes.Black, centermargin, 45, center)
        'พนักงาน
        e.Graphics.DrawString("พนักงาน", f8, Brushes.Black, 0, 60)
        e.Graphics.DrawString(" : ", f8, Brushes.Black, 50, 60)
        e.Graphics.DrawString(User, f8, Brushes.Black, 70, 60)
        'เวลา
        e.Graphics.DrawString("เวลา", f8, Brushes.Black, 0, 80)
        e.Graphics.DrawString(" : ", f8, Brushes.Black, 50, 80)
        e.Graphics.DrawString(lbltime.Text, f8, Brushes.Black, 70, 80)
        'วันที่
        e.Graphics.DrawString("วันที่", f8, Brushes.Black, 0, 95)
        e.Graphics.DrawString(" : ", f8, Brushes.Black, 50, 95)
        e.Graphics.DrawString(lbldate.Text, f8, Brushes.Black, 70, 95)
        'โต๊ะ
        e.Graphics.DrawString("โต๊ะที่ 1 ", f10, Brushes.Black, 208, 75)
        e.Graphics.DrawString("ราคารวม", f8, Brushes.Black, 208, 95)
        e.Graphics.DrawString("จำนวน", f8, Brushes.Black, 163, 95)
        'เส้นขั่น

        'เส้นขั่น
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 100)

        Dim height As Integer
        Dim i As Long
        DataGridView1.AllowUserToAddRows = False
        For row As Integer = 0 To DataGridView1.RowCount - 1
            height += 15
            'ชื่อเมนู
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(1).Value.ToString, f10, Brushes.Black, 0, 100 + height)
            'จำนวน
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(3).Value.ToString, f10, Brushes.Black, 177, 100 + height)
            'ราคารวม
            i = DataGridView1.Rows(row).Cells(2).Value
            DataGridView1.Rows(row).Cells(2).Value = Format(i, "##,##0")
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(2).Value.ToString, f10, Brushes.Black, rightmargin, 100 + height, right)
        Next
        Dim height2 As Integer
        height2 = 110 + height
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, height2)
        e.Graphics.DrawString("ราคารวม ", f10b, Brushes.Black, 0, 10 + height2)
        e.Graphics.DrawString(TextBox10.Text, f10b, Brushes.Black, rightmargin, 30 + height2, right)
        e.Graphics.DrawString("รับเงิน ", f10b, Brushes.Black, 0, 30 + height2)
        e.Graphics.DrawString(ssum, f10b, Brushes.Black, rightmargin, 10 + height2, right)
        e.Graphics.DrawString("เงินทอน ", f10b, Brushes.Black, 0, 50 + height2)
        e.Graphics.DrawString(TextBox11.Text, f10b, Brushes.Black, rightmargin, 50 + height2, right)
        e.Graphics.DrawString("ราคาเฉลี่ยต่อคน ", f10b, Brushes.Black, 0, 70 + height2)
        averagepeople = ssum / people1
        e.Graphics.DrawString(averagepeople, f10b, Brushes.Black, rightmargin, 70 + height2, right)

        e.Graphics.DrawString("~ ขอบคุณที่ใช้บริการ ~", f10, Brushes.Black, centermargin, 110 + height2, center)
        e.Graphics.DrawString("~ ร้านอาหารไทย & อิตาเลียน ~", f10, Brushes.Black, centermargin, 130 + height2, center)
        e.Graphics.DrawString("~ By ~", f10, Brushes.Black, centermargin, 150 + height2, center)
        e.Graphics.DrawString("~ ธาดาพงศ์ สุทธิกิจรุ่งโรจน์ ~", f10, Brushes.Black, centermargin, 170 + height2, center)


    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbldate.Text = Now.ToShortDateString
        lbltime.Text = TimeOfDay

    End Sub

    Private Sub Selectfood1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button6.Enabled = False
        Timer1.Start()
        'ไทย
        CheckBox1.Enabled = False
        CheckBox2.Enabled = False
        CheckBox3.Enabled = False
        GroupBox7.Hide()
        CheckBox3.Hide()
        NumericUpDown3.Hide()
        'อิตาเลียน
        CheckBox4.Enabled = False
        CheckBox5.Enabled = False
        CheckBox6.Enabled = False
        CheckBox7.Enabled = False
        GroupBox10.Hide()
        GroupBox11.Hide()
        CheckBox6.Hide()
        NumericUpDown6.Hide()
        CheckBox7.Hide()
        NumericUpDown7.Hide()
        'น้ำ
        CheckBox8.Enabled = False
        CheckBox9.Enabled = False
        'ขนมหวาน
        CheckBox10.Enabled = False
        CheckBox11.Enabled = False



    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        GroupBox5.Hide()
        GroupBox7.Show()
        CheckBox3.Show()
        NumericUpDown3.Show()
        CheckBox2.Hide()
        NumericUpDown2.Hide()
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        GroupBox7.Hide()
        GroupBox5.Show()
        CheckBox3.Hide()
        NumericUpDown3.Hide()
        CheckBox2.Show()
        NumericUpDown2.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Close()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click

        If DataGridView1.Rows.Count > 1 Then
            Home.Show()
            Me.Hide()
        Else
            MessageBox.Show("  ** คุณเปิดบิลโต๊ะแล้ว กรุณาเพิ่มสินค้าก่อนไปหน้าอื่น **" & vbNewLine & "         *** หรือทำการยกเลิกบิลโต๊ะนี้ก่อนครับ ***",
                            "การแจ้งเตือนจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If DataGridView1.Rows.Count > 1 Then
            Reserve.Show()
            Me.Hide()
        Else
            MessageBox.Show("  ** คุณเปิดบิลโต๊ะแล้ว กรุณาเพิ่มสินค้าก่อนไปหน้าอื่น **" & vbNewLine & "         *** หรือทำการยกเลิกบิลโต๊ะนี้ก่อนครับ ***",
                            "การแจ้งเตือนจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        CheckBox1.Enabled = True
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        CheckBox2.Enabled = True
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Dim price2 As Integer
        Dim food2 As Integer = NumericUpDown2.Value
        price2 = food2 * 250
        If CheckBox2.Checked = True Then
            Me.DataGridView1.Rows.Add("อาหารไทย", "ต้มยำกุ้ง", "250", food2, price2)
            CheckBox2.Checked = False
        Else
            NumericUpDown2.Value = False
            CheckBox2.Enabled = False
        End If

        ssum = 0
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            ssum += DataGridView1.Rows(i).Cells(4).Value
        Next
        TextBox1.Text = ssum
    End Sub

    Private Sub NumericUpDown3_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown3.ValueChanged
        CheckBox3.Enabled = True
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        Dim price3 As Integer
        Dim food3 As Integer = NumericUpDown3.Value
        price3 = food3 * 90
        If CheckBox3.Checked = True Then
            Me.DataGridView1.Rows.Add("อาหารไทย", "ส้มตำ", "90", food3, price3)
            CheckBox3.Checked = False
        Else
            NumericUpDown3.Value = False
            CheckBox3.Enabled = False
        End If

        ssum = 0
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            ssum += DataGridView1.Rows(i).Cells(4).Value

        Next
        TextBox1.Text = ssum
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim price1 As Integer
        Dim food1 As Integer = NumericUpDown1.Value
        price1 = food1 * 100
        If CheckBox1.Checked = True Then
            Me.DataGridView1.Rows.Add("อาหารไทย", "ผัดไทย", "100", food1, price1)
            CheckBox1.Checked = False
        Else
            NumericUpDown1.Value = False
            CheckBox1.Enabled = False
        End If

        ssum = 0
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            ssum += DataGridView1.Rows(i).Cells(4).Value
        Next
        TextBox1.Text = ssum
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If DataGridView1.Rows.Count > 1 Then
            If DataGridView1.CurrentRow.Cells(0).Value <> "" Then
                If MessageBox.Show("** คุณต้องการลบรายการอาการ " & DataGridView1.CurrentRow.Cells(1).Value & " จำนวน " &
                                   DataGridView1.CurrentRow.Cells(3).Value & " รายการใช้หรือไม่", "การแจ้งเตือนจากระบบ",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
                    ssum = 0
                    For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
                        ssum += DataGridView1.Rows(i).Cells(4).Value
                    Next
                    TextBox1.Text = ssum

                End If
            Else
                MessageBox.Show("  ** กรุณาเลือกรายการอาหารที่ต้องการลบ **",
                            "การแจ้งเตือนจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("       ยังไม่มีการเพิ่มรายการอาหาร" & vbNewLine & "**กรุณาเพิ่มรายการอาหารก่อนนะครับ**",
                            "การแจ้งเตือนจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter
        Home.Show()
        Me.Hide()
    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If DataGridView1.Rows.Count > 1 Then
            Statustable.Show()
            Me.Hide()
        Else
            MessageBox.Show("  ** คุณเปิดบิลโต๊ะแล้ว กรุณาเพิ่มสินค้าก่อนไปหน้าอื่น **" & vbNewLine & "         *** หรือทำการยกเลิกบิลโต๊ะนี้ก่อนครับ ***",
                            "การแจ้งเตือนจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If DataGridView1.Rows.Count > 1 Then
            If DataGridView1.CurrentRow.Cells(0).Value <> "" Then
                If MessageBox.Show("** คุณต้องการลบรายการอาการ " & DataGridView1.CurrentRow.Cells(1).Value & " จำนวน " &
                                   DataGridView1.CurrentRow.Cells(3).Value & " รายการใช้หรือไม่", "การแจ้งเตือนจากระบบ",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
                    ssum = 0
                    For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
                        ssum += DataGridView1.Rows(i).Cells(4).Value
                    Next
                    TextBox1.Text = ssum

                End If
            Else
                MessageBox.Show("  ** กรุณาเลือกรายการอาหารที่ต้องการลบ **",
                            "การแจ้งเตือนจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("       ยังไม่มีการเพิ่มรายการอาหาร" & vbNewLine & "**กรุณาเพิ่มรายการอาหารก่อนนะครับ**",
                            "การแจ้งเตือนจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub NumericUpDown4_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown4.ValueChanged
        CheckBox4.Enabled = True
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        Dim priceitaian1 As Integer
        Dim itaian1food1 As Integer = NumericUpDown4.Value
        priceitaian1 = itaian1food1 * 199
        If CheckBox4.Checked = True Then
            Me.DataGridView1.Rows.Add("อาหารอิตาเลียน", "พิซซ่า", "199", itaian1food1, priceitaian1)
            CheckBox4.Checked = False
        Else
            NumericUpDown4.Value = False
            CheckBox4.Enabled = False
        End If

        ssum = 0
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            ssum += DataGridView1.Rows(i).Cells(4).Value
        Next
        TextBox1.Text = ssum
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        GroupBox11.Show()
        GroupBox10.Show()
        GroupBox8.Hide()
        GroupBox9.Hide()
        CheckBox4.Hide()
        NumericUpDown4.Hide()
        CheckBox5.Hide()
        NumericUpDown5.Hide()
        CheckBox6.Show()
        NumericUpDown6.Show()
        CheckBox7.Show()
        NumericUpDown7.Show()
    End Sub
    Private Sub NumericUpDown5_ValueChanged_1(sender As Object, e As EventArgs) Handles NumericUpDown5.ValueChanged
        CheckBox5.Enabled = True
    End Sub

    Private Sub CheckBox5_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        Dim priceitaian2 As Integer
        Dim itaian1food2 As Integer = NumericUpDown5.Value
        priceitaian2 = itaian1food2 * 259
        If CheckBox5.Checked = True Then
            Me.DataGridView1.Rows.Add("อาหารอิตาเลียน", "ลาซานญ่า", "259", itaian1food2, priceitaian2)
            CheckBox5.Checked = False
        Else
            NumericUpDown5.Value = False
            CheckBox5.Enabled = False
        End If

        ssum = 0
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            ssum += DataGridView1.Rows(i).Cells(4).Value
        Next
        TextBox1.Text = ssum
    End Sub

    Private Sub NumericUpDown6_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown6.ValueChanged
        CheckBox6.Enabled = True
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        Dim priceitaian3 As Integer
        Dim itaian1food3 As Integer = NumericUpDown6.Value
        priceitaian3 = itaian1food3 * 149
        If CheckBox6.Checked = True Then
            Me.DataGridView1.Rows.Add("อาหารอิตาเลียน", "พาสต้า", "149", itaian1food3, priceitaian3)
            CheckBox6.Checked = False
        Else
            NumericUpDown6.Value = False
            CheckBox6.Enabled = False
        End If

        ssum = 0
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            ssum += DataGridView1.Rows(i).Cells(4).Value
        Next
        TextBox1.Text = ssum
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        Dim priceitaian4 As Integer
        Dim itaian1food4 As Integer = NumericUpDown7.Value
        priceitaian4 = itaian1food4 * 219
        If CheckBox7.Checked = True Then
            Me.DataGridView1.Rows.Add("อาหารอิตาเลียน", "ริซอตโต้", "219", itaian1food4, priceitaian4)
            CheckBox7.Checked = False
        Else
            NumericUpDown7.Value = False
            CheckBox7.Enabled = False
        End If

        ssum = 0
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            ssum += DataGridView1.Rows(i).Cells(4).Value
        Next
        TextBox1.Text = ssum
    End Sub

    Private Sub NumericUpDown7_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown7.ValueChanged
        CheckBox7.Enabled = True
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        GroupBox10.Hide()
        GroupBox11.Hide()
        GroupBox8.Show()
        GroupBox9.Show()
        CheckBox6.Hide()
        NumericUpDown6.Hide()
        CheckBox7.Hide()
        NumericUpDown7.Hide()
        CheckBox4.Show()
        NumericUpDown4.Show()
        CheckBox5.Show()
        NumericUpDown5.Show()
    End Sub

    Private Sub NumericUpDown8_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown8.ValueChanged
        CheckBox8.Enabled = True
    End Sub

    Private Sub NumericUpDown9_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown9.ValueChanged
        CheckBox9.Enabled = True
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        Dim pricewater1 As Integer
        Dim water1 As Integer = NumericUpDown8.Value
        pricewater1 = water1 * 20
        If CheckBox8.Checked = True Then
            Me.DataGridView1.Rows.Add("น้ำ", "น้ำอัดลม", "20", water1, pricewater1)
            CheckBox8.Checked = False
        Else
            NumericUpDown8.Value = False
            CheckBox8.Enabled = False
        End If

        ssum = 0
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            ssum += DataGridView1.Rows(i).Cells(4).Value
        Next
        TextBox1.Text = ssum
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        Dim pricewater2 As Integer
        Dim water2 As Integer = NumericUpDown9.Value
        pricewater2 = water2 * 15
        If CheckBox9.Checked = True Then
            Me.DataGridView1.Rows.Add("น้ำ", "น้ำเปล่า", "15", water2, pricewater2)
            CheckBox9.Checked = False
        Else
            NumericUpDown9.Value = False
            CheckBox9.Enabled = False
        End If

        ssum = 0
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            ssum += DataGridView1.Rows(i).Cells(4).Value
        Next
        TextBox1.Text = ssum
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        Dim pricesugar1 As Integer
        Dim sugar1 As Integer = NumericUpDown10.Value
        pricesugar1 = sugar1 * 119
        If CheckBox10.Checked = True Then
            Me.DataGridView1.Rows.Add("ขนมหวาน", "ข้าวเหนียวมะม่วง", "119", sugar1, pricesugar1)
            CheckBox10.Checked = False
        Else
            NumericUpDown10.Value = False
            CheckBox10.Enabled = False
        End If

        ssum = 0
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            ssum += DataGridView1.Rows(i).Cells(4).Value
        Next
        TextBox1.Text = ssum
    End Sub

    Private Sub NumericUpDown10_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown10.ValueChanged
        CheckBox10.Enabled = True
    End Sub

    Private Sub NumericUpDown11_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown11.ValueChanged
        CheckBox11.Enabled = True
    End Sub

    Private Sub CheckBox11_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged
        Dim pricesugar2 As Integer
        Dim sugar2 As Integer = NumericUpDown11.Value
        pricesugar2 = sugar2 * 109
        If CheckBox11.Checked = True Then
            Me.DataGridView1.Rows.Add("ขนมหวาน", "เจลาโต", "109", sugar2, pricesugar2)
            CheckBox11.Checked = False
        Else
            NumericUpDown11.Value = False
            CheckBox11.Enabled = False
        End If

        ssum = 0
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            ssum += DataGridView1.Rows(i).Cells(4).Value
        Next
        TextBox1.Text = ssum
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If DataGridView1.Rows.Count > 1 Then
            If DataGridView1.CurrentRow.Cells(0).Value <> "" Then
                If MessageBox.Show("** คุณต้องการลบรายการอาการ " & DataGridView1.CurrentRow.Cells(1).Value & " จำนวน " &
                                   DataGridView1.CurrentRow.Cells(3).Value & " รายการใช้หรือไม่", "การแจ้งเตือนจากระบบ",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
                    ssum = 0
                    For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
                        ssum += DataGridView1.Rows(i).Cells(4).Value
                    Next
                    TextBox1.Text = ssum

                End If
            Else
                MessageBox.Show("  ** กรุณาเลือกรายการอาหารที่ต้องการลบ **",
                            "การแจ้งเตือนจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("       ยังไม่มีการเพิ่มรายการอาหาร" & vbNewLine & "**กรุณาเพิ่มรายการอาหารก่อนนะครับ**",
                            "การแจ้งเตือนจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If DataGridView1.Rows.Count > 1 Then
            If DataGridView1.CurrentRow.Cells(0).Value <> "" Then
                If MessageBox.Show("** คุณต้องการลบรายการอาการ " & DataGridView1.CurrentRow.Cells(1).Value & " จำนวน " &
                                   DataGridView1.CurrentRow.Cells(3).Value & " รายการใช้หรือไม่", "การแจ้งเตือนจากระบบ",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
                    ssum = 0
                    For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
                        ssum += DataGridView1.Rows(i).Cells(4).Value
                    Next
                    TextBox1.Text = ssum

                End If
            Else
                MessageBox.Show("  ** กรุณาเลือกรายการอาหารที่ต้องการลบ **",
                            "การแจ้งเตือนจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("       ยังไม่มีการเพิ่มรายการอาหาร" & vbNewLine & "**กรุณาเพิ่มรายการอาหารก่อนนะครับ**",
                            "การแจ้งเตือนจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        table1 = "null"
        rebugtable1 = 0
        ssum = 0
        Clear_DG(DataGridView1)
        TextBox1.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        Statustable.Show()
        Me.Hide()
    End Sub
    Public Sub Clear_DG(DG_Clear_data As DataGridView)
        For i = 0 To DG_Clear_data.RowCount - 1
            For Each row As DataGridViewRow In DG_Clear_data.Rows
                DG_Clear_data.Rows.Clear()
            Next
        Next
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If DataGridView1.Rows.Count > 1 Or DataGridView1.Rows.Count = 1 Then
            TextBox11.Text = Val(TextBox10.Text) - Val(TextBox1.Text)
        Else
            MessageBox.Show("** คุณยังไม่เพิ่มรายการอาหาร  ไม่สามารถชำระเงินได้** ", "การแจ้งเตือนจากระบบ",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox10.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        If ssum > Val(TextBox10.Text) Then
            Button6.Enabled = False
        Else
            Button6.Enabled = True
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Sales.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub
End Class