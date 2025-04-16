Public Class Form4
    Dim ROAD1 As Short = 0
    Dim ROAD2 As Short = 0
    Dim ROAD3 As Short = 0
    Dim ROAD4 As Short = 0
    Dim ROAD5 As Short = 0
    Dim ROAD6 As Short = 0
    Dim ROAD7 As Short = 0
    Dim ROAD8 As Short = 0
    Dim blinkTimer As New Timer()

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ROAD2 = 1 And ROAD3 = 3 And ROAD5 = 2 And ROAD6 = 1 And ROAD7 = 2 Then
            Dim startPosition As Integer = PictureBox9.Left
            Dim endPosition As Integer = Me.ClientSize.Width - PictureBox9.Width
            Dim stepSize As Integer = 3
            Dim stopPosition As Integer = 660 ' Set your specific stop position here
            Dim timer As New Timer()
            AddHandler timer.Tick, Sub()
                                       If PictureBox9.Left >= stopPosition Then
                                           timer.Stop()
                                           MessageBox.Show("Congratulations! You have passed the level!", "Level Passed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                           Button2.Visible = True
                                       Else
                                           PictureBox9.Left += stepSize
                                           PictureBox9.BringToFront()
                                       End If
                                   End Sub
            timer.Interval = 3 ' Set the interval to control the speed
            timer.Start()

            Button1.Enabled = False
        Else
            MessageBox.Show("You need to align the road properly. Please try again.", "Level Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form5.Show()
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim rotate As Image = New Bitmap(PictureBox2.Image)
        rotate.RotateFlip(RotateFlipType.Rotate90FlipNone)
        PictureBox2.Image = rotate
        ROAD2 += 1
        If ROAD2 = 4 Then
            ROAD2 = 0
        End If
    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim rotate As Image = New Bitmap(PictureBox3.Image)
        rotate.RotateFlip(RotateFlipType.Rotate90FlipNone)
        PictureBox3.Image = rotate
        ROAD3 += 1
        If ROAD3 = 4 Then
            ROAD3 = 0
        End If
    End Sub

    Private Sub PictureBox5_Click_1(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim rotate As Image = New Bitmap(PictureBox5.Image)
        rotate.RotateFlip(RotateFlipType.Rotate90FlipNone)
        PictureBox5.Image = rotate
        ROAD5 += 1
        If ROAD5 = 4 Then
            ROAD5 = 0
        End If
    End Sub

    Private Sub PictureBox6_Click_1(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim rotate As Image = New Bitmap(PictureBox6.Image)
        rotate.RotateFlip(RotateFlipType.Rotate90FlipNone)
        PictureBox6.Image = rotate
        ROAD6 += 1
        If ROAD6 = 4 Then
            ROAD6 = 0
        End If
    End Sub

    Private Sub PictureBox7_Click_1(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Dim rotate As Image = New Bitmap(PictureBox7.Image)
        rotate.RotateFlip(RotateFlipType.Rotate90FlipNone)
        PictureBox7.Image = rotate
        ROAD7 += 1
        If ROAD7 = 4 Then
            ROAD7 = 0
        End If
    End Sub
End Class