Public Class Form7
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
    Dim ROAD13 As Short = 0
    Dim ROAD14 As Short = 0
    Dim ROAD15 As Short = 0
    Dim ROAD16 As Short = 0
    Dim ROAD17 As Short = 0
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub RotatePictureBox(pictureBox As PictureBox, ByRef road As Short)
        Dim rotate As Image = New Bitmap(pictureBox.Image)
        rotate.RotateFlip(RotateFlipType.Rotate90FlipNone)
        pictureBox.Image = rotate
        road += 1
        If road = 4 Then
            road = 0
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        RotatePictureBox(PictureBox2, ROAD2)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        RotatePictureBox(PictureBox3, ROAD3)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        RotatePictureBox(PictureBox4, ROAD4)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        RotatePictureBox(PictureBox6, ROAD6)
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        RotatePictureBox(PictureBox7, ROAD7)
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        RotatePictureBox(PictureBox8, ROAD8)
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        RotatePictureBox(PictureBox9, ROAD9)
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        RotatePictureBox(PictureBox10, ROAD10)
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        RotatePictureBox(PictureBox11, ROAD11)
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        RotatePictureBox(PictureBox12, ROAD12)
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        RotatePictureBox(PictureBox13, ROAD13)
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        RotatePictureBox(PictureBox14, ROAD14)
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        RotatePictureBox(PictureBox15, ROAD15)
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        RotatePictureBox(PictureBox16, ROAD16)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Form6.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form8.Show()
    End Sub
    '2 = 3
    '3 = 3
    '4 = 2 
    '6 = 3 
    '7 = 2
    '8 = 3
    '9 = 1 
    '10 = 1
    '12 = 1
    '14 = 1
    '15 = 2
    '16 = 2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ROAD2 = 3 And ROAD3 = 3 And ROAD4 = 2 And ROAD6 = 3 And ROAD7 = 2 And ROAD8 = 3 And ROAD9 = 3 And ROAD10 = 1 And ROAD12 = 1 And ROAD14 = 1 And ROAD15 = 2 And ROAD16 = 2 Then
            Dim startPosition As Integer = PictureBox17.Left
            Dim endPosition As Integer = Me.ClientSize.Width - PictureBox17.Width
            Dim stepSize As Integer = 3
            Dim rightStopPosition As Integer = 650 ' Set your specific stop position here
            Dim upwardStopPosition As Integer = 175
            Dim leftStopPosition As Integer = 440
            Dim downwardStopPosition As Integer = 340 ' downward stop position here
            Dim finalStopPosition As Integer = 190 ' Set your specific stop position here
            Dim timer As New Timer()
            AddHandler timer.Tick, Sub()
                                       If PictureBox17.Left >= rightStopPosition Then
                                           timer.Stop()

                                           Dim rotate As Image = New Bitmap(PictureBox17.Image)
                                           rotate.RotateFlip(RotateFlipType.Rotate270FlipNone)
                                           PictureBox17.Image = rotate

                                           Dim upwardTimer As New Timer()
                                           AddHandler upwardTimer.Tick, Sub()
                                                                            If PictureBox17.Top <= upwardStopPosition Then
                                                                                upwardTimer.Stop()

                                                                                Dim rotateAgain As Image = New Bitmap(PictureBox17.Image)
                                                                                rotateAgain.RotateFlip(RotateFlipType.Rotate270FlipNone)
                                                                                PictureBox17.Image = rotateAgain

                                                                                Dim leftwardTimer As New Timer()
                                                                                AddHandler leftwardTimer.Tick, Sub()
                                                                                                                   If PictureBox17.Left <= leftStopPosition Then
                                                                                                                       leftwardTimer.Stop()

                                                                                                                       Dim rotateAgainLeft As Image = New Bitmap(PictureBox17.Image)
                                                                                                                       rotateAgainLeft.RotateFlip(RotateFlipType.Rotate270FlipNone)
                                                                                                                       PictureBox17.Image = rotateAgainLeft

                                                                                                                       Dim downwardTimer As New Timer()
                                                                                                                       AddHandler downwardTimer.Tick, Sub()
                                                                                                                                                          If PictureBox17.Top >= downwardStopPosition Then
                                                                                                                                                              downwardTimer.Stop()

                                                                                                                                                              Dim rotateAgainDown As Image = New Bitmap(PictureBox17.Image)
                                                                                                                                                              rotateAgainDown.RotateFlip(RotateFlipType.Rotate90FlipNone)
                                                                                                                                                              PictureBox17.Image = rotateAgainDown
                                                                                                                                                              Dim finalTimer As New Timer()
                                                                                                                                                              AddHandler finalTimer.Tick, Sub()
                                                                                                                                                                                              If PictureBox17.Left <= finalStopPosition Then
                                                                                                                                                                                                  finalTimer.Stop()
                                                                                                                                                                                                  MessageBox.Show("Congratulations! You have passed the level!", "Level Passed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                                                                                                                                                                  Button2.Visible = True
                                                                                                                                                                                              Else
                                                                                                                                                                                                  PictureBox17.Left -= stepSize
                                                                                                                                                                                                  PictureBox17.BringToFront()
                                                                                                                                                                                              End If
                                                                                                                                                                                          End Sub
                                                                                                                                                              finalTimer.Interval = 3
                                                                                                                                                              finalTimer.Start()
                                                                                                                                                          Else
                                                                                                                                                              PictureBox17.Top += stepSize
                                                                                                                                                              PictureBox17.BringToFront()
                                                                                                                                                          End If
                                                                                                                                                      End Sub
                                                                                                                       downwardTimer.Interval = 3
                                                                                                                       downwardTimer.Start()
                                                                                                                   Else
                                                                                                                       PictureBox17.Left -= stepSize
                                                                                                                       PictureBox17.BringToFront()
                                                                                                                   End If
                                                                                                               End Sub
                                                                                leftwardTimer.Interval = 3
                                                                                leftwardTimer.Start()
                                                                            Else
                                                                                PictureBox17.Top -= stepSize
                                                                                PictureBox17.BringToFront()
                                                                            End If
                                                                        End Sub
                                           upwardTimer.Interval = 3
                                           upwardTimer.Start()
                                       Else
                                           PictureBox17.Left += stepSize
                                           PictureBox17.BringToFront()
                                       End If
                                   End Sub
            timer.Interval = 3 ' Set the interval to control the speed  
            timer.Start()

            Button1.Enabled = False
        Else
            MessageBox.Show("You need to align the road properly. Please try again.", "Level Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class