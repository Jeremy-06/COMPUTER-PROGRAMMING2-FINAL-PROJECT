Public Class Form5
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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
        Form1.Show()
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

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Dim rotate As Image = New Bitmap(PictureBox12.Image)
        rotate.RotateFlip(RotateFlipType.Rotate90FlipNone)
        PictureBox12.Image = rotate
        ROAD12 += 1
        If ROAD12 = 4 Then
            ROAD12 = 0
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ROAD2 = 1 And ROAD4 = 3 And ROAD5 = 2 And ROAD6 = 3 And ROAD8 = 3 And ROAD9 = 2 And ROAD10 = 1 And ROAD12 = 2 Then
            Dim startPosition As Integer = PictureBox13.Left
            Dim endPosition As Integer = Me.ClientSize.Width - PictureBox13.Width
            Dim stepSize As Integer = 3
            Dim stopPosition As Integer = 600 ' Set your specific stop position here  
            Dim downwardStopPosition As Integer = 300 ' downward stop position here  
            Dim timer As New Timer()
            AddHandler timer.Tick, Sub()
                                       If PictureBox13.Left >= stopPosition Then
                                           timer.Stop()

                                           Dim rotate As Image = New Bitmap(PictureBox13.Image)
                                           rotate.RotateFlip(RotateFlipType.Rotate90FlipNone)
                                           PictureBox13.Image = rotate

                                           Dim downwardTimer As New Timer()
                                           AddHandler downwardTimer.Tick, Sub()
                                                                              If PictureBox13.Top >= downwardStopPosition Then
                                                                                  downwardTimer.Stop()

                                                                                  Dim rotateAgain As Image = New Bitmap(PictureBox13.Image)
                                                                                  rotateAgain.RotateFlip(RotateFlipType.Rotate90FlipNone)
                                                                                  PictureBox13.Image = rotateAgain

                                                                                  Dim leftwardTimer As New Timer()
                                                                                  AddHandler leftwardTimer.Tick, Sub()
                                                                                                                     If PictureBox13.Left <= startPosition Then
                                                                                                                         leftwardTimer.Stop()
                                                                                                                         MessageBox.Show("Congratulations! You have passed the level!", "Level Passed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                                                                                         Button2.Visible = True
                                                                                                                     Else
                                                                                                                         PictureBox13.Left -= stepSize
                                                                                                                         PictureBox13.BringToFront()
                                                                                                                     End If
                                                                                                                 End Sub
                                                                                  leftwardTimer.Interval = 3
                                                                                  leftwardTimer.Start()
                                                                              Else
                                                                                  PictureBox13.Top += stepSize
                                                                                  PictureBox13.BringToFront()
                                                                              End If
                                                                          End Sub
                                           downwardTimer.Interval = 3
                                           downwardTimer.Start()
                                       Else
                                           PictureBox13.Left += stepSize
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Form4.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form6.Show()
    End Sub
End Class