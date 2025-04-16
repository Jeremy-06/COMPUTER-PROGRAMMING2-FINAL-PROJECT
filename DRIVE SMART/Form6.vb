Public Class Form6
    Dim ROAD1 As Short = 0
    Dim ROAD2 As Short = 0
    Dim ROAD3 As Short = 0
    Dim ROAD4 As Short = 0
    Dim ROAD5 As Short = 0
    Dim ROAD6 As Short = 0
    Dim ROAD7 As Short = 0
    Dim ROAD8 As Short = 0
    Dim ROAD9 As Short = 0
    Dim ROAD10 As Short = 0
    Dim ROAD11 As Short = 0
    Dim ROAD12 As Short = 0
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form7.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim rotate As Image = New Bitmap(PictureBox2.Image)
        rotate.RotateFlip(RotateFlipType.Rotate90FlipNone)
        PictureBox2.Image = rotate
        ROAD2 += 1
        If ROAD2 = 4 Then
            ROAD2 = 0
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim rotate As Image = New Bitmap(PictureBox4.Image)
        rotate.RotateFlip(RotateFlipType.Rotate90FlipNone)
        PictureBox4.Image = rotate
        ROAD4 += 1
        If ROAD4 = 4 Then
            ROAD4 = 0
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim rotate As Image = New Bitmap(PictureBox5.Image)
        rotate.RotateFlip(RotateFlipType.Rotate90FlipNone)
        PictureBox5.Image = rotate
        ROAD5 += 1
        If ROAD5 = 4 Then
            ROAD5 = 0
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim rotate As Image = New Bitmap(PictureBox6.Image)
        rotate.RotateFlip(RotateFlipType.Rotate90FlipNone)
        PictureBox6.Image = rotate
        ROAD6 += 1
        If ROAD6 = 4 Then
            ROAD6 = 0
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Dim rotate As Image = New Bitmap(PictureBox7.Image)
        rotate.RotateFlip(RotateFlipType.Rotate90FlipNone)
        PictureBox7.Image = rotate
        ROAD7 += 1
        If ROAD7 = 4 Then
            ROAD7 = 0
        End If
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Dim rotate As Image = New Bitmap(PictureBox8.Image)
        rotate.RotateFlip(RotateFlipType.Rotate90FlipNone)
        PictureBox8.Image = rotate
        ROAD8 += 1
        If ROAD8 = 4 Then
            ROAD8 = 0
        End If
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Dim rotate As Image = New Bitmap(PictureBox9.Image)
        rotate.RotateFlip(RotateFlipType.Rotate90FlipNone)
        PictureBox9.Image = rotate
        ROAD9 += 1
        If ROAD9 = 4 Then
            ROAD9 = 0
        End If
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Dim rotate As Image = New Bitmap(PictureBox10.Image)
        rotate.RotateFlip(RotateFlipType.Rotate90FlipNone)
        PictureBox10.Image = rotate
        ROAD10 += 1
        If ROAD10 = 4 Then
            ROAD10 = 0
        End If
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Dim rotate As Image = New Bitmap(PictureBox11.Image)
        rotate.RotateFlip(RotateFlipType.Rotate90FlipNone)
        PictureBox11.Image = rotate
        ROAD11 += 1
        If ROAD11 = 4 Then
            ROAD11 = 0
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
        Form1.Show()
    End Sub
    '2 = 2
    '4 = 2
    '5 = 1
    '6 = 2
    '7 = 1
    '8 = 3
    '9 = 2
    '10 = 2
    '11 = 3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ROAD2 = 2 And ROAD4 = 2 And ROAD5 = 1 And ROAD6 = 2 And ROAD7 = 1 And ROAD8 = 3 And ROAD9 = 2 And ROAD10 = 2 And ROAD11 = 3 Then

            Dim startPosition As Integer = PictureBox13.Top
            Dim endPosition As Integer = Me.ClientSize.Height - PictureBox13.Height
            Dim stepSize As Integer = 3
            Dim stopPosition As Integer = 340 ' Set your specific stop position here  
            Dim rightStopPosition As Integer = 390 ' right stop position here
            Dim topStopPosition As Integer = 260
            Dim right2StopPosition As Integer = 700
            Dim timer As New Timer()
            AddHandler timer.Tick, Sub()
                                       If PictureBox13.Top >= stopPosition Then
                                           timer.Stop()

                                           Dim rotate2 As Image = New Bitmap(PictureBox13.Image)
                                           rotate2.RotateFlip(RotateFlipType.Rotate270FlipNone)
                                           PictureBox13.Image = rotate2

                                           Dim rightwardTimer As New Timer()
                                           AddHandler rightwardTimer.Tick, Sub()
                                                                               If PictureBox13.Left >= rightStopPosition Then
                                                                                   rightwardTimer.Stop()

                                                                                   Dim rotate3 As Image = New Bitmap(PictureBox13.Image)
                                                                                   rotate3.RotateFlip(RotateFlipType.Rotate270FlipNone)
                                                                                   PictureBox13.Image = rotate3

                                                                                   Dim upwardTimer As New Timer()
                                                                                   AddHandler upwardTimer.Tick, Sub()
                                                                                                                    If PictureBox13.Top <= topStopPosition Then
                                                                                                                        upwardTimer.Stop()

                                                                                                                        Dim rotate4 As Image = New Bitmap(PictureBox13.Image)
                                                                                                                        rotate4.RotateFlip(RotateFlipType.Rotate90FlipNone)
                                                                                                                        PictureBox13.Image = rotate4

                                                                                                                        Dim rightwardTimer2 As New Timer()
                                                                                                                        AddHandler rightwardTimer2.Tick, Sub()
                                                                                                                                                             If PictureBox13.Left >= right2StopPosition Then
                                                                                                                                                                 rightwardTimer2.Stop()
                                                                                                                                                                 MessageBox.Show("Congratulations! You have passed the level!", "Level Passed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                                                                                                                                 Button2.Visible = True
                                                                                                                                                             Else
                                                                                                                                                                 PictureBox13.Left += stepSize
                                                                                                                                                                 PictureBox13.BringToFront()
                                                                                                                                                             End If
                                                                                                                                                         End Sub
                                                                                                                        rightwardTimer2.Interval = 3
                                                                                                                        rightwardTimer2.Start()
                                                                                                                    Else
                                                                                                                        PictureBox13.Top -= stepSize
                                                                                                                        PictureBox13.BringToFront()
                                                                                                                    End If
                                                                                                                End Sub
                                                                                   upwardTimer.Interval = 3
                                                                                   upwardTimer.Start()
                                                                               Else
                                                                                   PictureBox13.Left += stepSize
                                                                                   PictureBox13.BringToFront()
                                                                               End If
                                                                           End Sub
                                           rightwardTimer.Interval = 3
                                           rightwardTimer.Start()
                                       Else
                                           PictureBox13.Top += stepSize
                                           PictureBox13.BringToFront()
                                       End If
                                   End Sub
            timer.Interval = 3 ' Set the interval to control the speed  
            timer.Start()

            Button1.Enabled = False
        Else
            MessageBox.Show("You need to align the road properly. Please try again.", "Level Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rotate1 As Image = New Bitmap(PictureBox13.Image)
        rotate1.RotateFlip(RotateFlipType.Rotate90FlipNone)
        PictureBox13.Image = rotate1
    End Sub
End Class