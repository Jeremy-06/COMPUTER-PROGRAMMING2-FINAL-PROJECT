Public Class Form8
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
    Dim ROAD18 As Short = 0
    Dim ROAD19 As Short = 0
    Dim ROAD20 As Short = 0
    Dim ROAD21 As Short = 0
    Dim ROAD22 As Short = 0

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

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        RotatePictureBox(PictureBox4, ROAD4)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        RotatePictureBox(PictureBox5, ROAD5)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        RotatePictureBox(PictureBox6, ROAD6)
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        RotatePictureBox(PictureBox7, ROAD7)
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        RotatePictureBox(PictureBox9, ROAD9)
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        RotatePictureBox(PictureBox13, ROAD13)
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        RotatePictureBox(PictureBox14, ROAD14)
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        RotatePictureBox(PictureBox16, ROAD16)
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        RotatePictureBox(PictureBox17, ROAD17)
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        RotatePictureBox(PictureBox19, ROAD19)
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        RotatePictureBox(PictureBox21, ROAD21)
    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click
        RotatePictureBox(PictureBox22, ROAD22)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ROAD2 = 2 And ROAD4 = 1 And ROAD5 = 3 And ROAD6 = 3 And ROAD7 = 1 And ROAD9 = 2 And ROAD13 = 3 And ROAD14 = 3 And ROAD16 = 3 And ROAD17 = 2 And ROAD19 = 3 And ROAD21 = 1 And ROAD22 = 2 Then
            Dim stepSize As Integer = 3
            Dim pb As PictureBox = PictureBox24

            Button1.Enabled = False

            ' Start the full movement chain
            MovePictureBox(pb, stepSize)
        Else
            MessageBox.Show("You need to align the road properly. Please try again.", "Level Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub MovePictureBox(pb As PictureBox, stepSize As Integer)
        Dim right1 = 535
        Dim down1 = 250
        Dim right2 = 680
        Dim up1 = 175
        Dim left1 = 610
        Dim down2 = 330
        Dim left2 = 463
        Dim up2 = 250
        Dim left3 = 390
        Dim down3 = 334
        Dim left4 = 315
        Dim up3 = 255
        Dim left5 = 245
        Dim down4 = 334
        Dim left6 = 100
        Dim up4 = 300

        MoveRight(pb, right1, stepSize, Sub()
                                            Rotate(pb, RotateFlipType.Rotate90FlipNone)
                                            MoveDown(pb, down1, stepSize, Sub()
                                                                              Rotate(pb, RotateFlipType.Rotate270FlipNone)
                                                                              MoveRight(pb, right2, stepSize, Sub()
                                                                                                                  Rotate(pb, RotateFlipType.Rotate270FlipNone)
                                                                                                                  MoveUp(pb, up1, stepSize, Sub()
                                                                                                                                                Rotate(pb, RotateFlipType.Rotate270FlipNone)
                                                                                                                                                MoveLeft(pb, left1, stepSize, Sub()
                                                                                                                                                                                  Rotate(pb, RotateFlipType.Rotate270FlipNone)
                                                                                                                                                                                  MoveDown(pb, down2, stepSize, Sub()
                                                                                                                                                                                                                    Rotate(pb, RotateFlipType.Rotate90FlipNone)
                                                                                                                                                                                                                    MoveLeft(pb, left2, stepSize, Sub()
                                                                                                                                                                                                                                                      Rotate(pb, RotateFlipType.Rotate90FlipNone)
                                                                                                                                                                                                                                                      MoveUp(pb, up2, stepSize, Sub()
                                                                                                                                                                                                                                                                                    Rotate(pb, RotateFlipType.Rotate270FlipNone)
                                                                                                                                                                                                                                                                                    MoveLeft(pb, left3, stepSize, Sub()
                                                                                                                                                                                                                                                                                                                      Rotate(pb, RotateFlipType.Rotate270FlipNone)
                                                                                                                                                                                                                                                                                                                      MoveDown(pb, down3, stepSize, Sub()
                                                                                                                                                                                                                                                                                                                                                        Rotate(pb, RotateFlipType.Rotate90FlipNone)
                                                                                                                                                                                                                                                                                                                                                        MoveLeft(pb, left4, stepSize, Sub()
                                                                                                                                                                                                                                                                                                                                                                                          Rotate(pb, RotateFlipType.Rotate90FlipNone)
                                                                                                                                                                                                                                                                                                                                                                                          MoveUp(pb, up3, stepSize, Sub()
                                                                                                                                                                                                                                                                                                                                                                                                                        Rotate(pb, RotateFlipType.Rotate270FlipNone)
                                                                                                                                                                                                                                                                                                                                                                                                                        MoveLeft(pb, left5, stepSize, Sub()
                                                                                                                                                                                                                                                                                                                                                                                                                                                          Rotate(pb, RotateFlipType.Rotate270FlipNone)
                                                                                                                                                                                                                                                                                                                                                                                                                                                          MoveDown(pb, down4, stepSize, Sub()
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            Rotate(pb, RotateFlipType.Rotate90FlipNone)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            MoveLeft(pb, left6, stepSize, Sub()
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              Rotate(pb, RotateFlipType.Rotate90FlipNone)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              MoveUp(pb, up4, stepSize, Sub()
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            MessageBox.Show("Congratulations! You have passed the level!", "Level Passed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            Button2.Visible = True
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        End Sub)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          End Sub)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        End Sub)
                                                                                                                                                                                                                                                                                                                                                                                                                                                      End Sub)
                                                                                                                                                                                                                                                                                                                                                                                                                    End Sub)
                                                                                                                                                                                                                                                                                                                                                                                      End Sub)
                                                                                                                                                                                                                                                                                                                                                    End Sub)
                                                                                                                                                                                                                                                                                                                  End Sub)
                                                                                                                                                                                                                                                                                End Sub)
                                                                                                                                                                                                                                                  End Sub)
                                                                                                                                                                                                                End Sub)
                                                                                                                                                                              End Sub)
                                                                                                                                            End Sub)
                                                                                                              End Sub)
                                                                          End Sub)
                                        End Sub)
    End Sub

    ' Movement Helpers
    Private Sub MoveRight(pb As PictureBox, target As Integer, stepSize As Integer, callback As Action)
        Dim t As New Timer With {.Interval = 3}
        AddHandler t.Tick, Sub()
                               If pb.Left >= target Then
                                   t.Stop()
                                   callback()
                               Else
                                   pb.Left += stepSize
                                   pb.BringToFront()
                               End If
                           End Sub
        t.Start()
    End Sub

    Private Sub MoveLeft(pb As PictureBox, target As Integer, stepSize As Integer, callback As Action)
        Dim t As New Timer With {.Interval = 3}
        AddHandler t.Tick, Sub()
                               If pb.Left <= target Then
                                   t.Stop()
                                   callback()
                               Else
                                   pb.Left -= stepSize
                                   pb.BringToFront()
                               End If
                           End Sub
        t.Start()
    End Sub

    Private Sub MoveDown(pb As PictureBox, target As Integer, stepSize As Integer, callback As Action)
        Dim t As New Timer With {.Interval = 3}
        AddHandler t.Tick, Sub()
                               If pb.Top >= target Then
                                   t.Stop()
                                   callback()
                               Else
                                   pb.Top += stepSize
                                   pb.BringToFront()
                               End If
                           End Sub
        t.Start()
    End Sub

    Private Sub MoveUp(pb As PictureBox, target As Integer, stepSize As Integer, callback As Action)
        Dim t As New Timer With {.Interval = 3}
        AddHandler t.Tick, Sub()
                               If pb.Top <= target Then
                                   t.Stop()
                                   callback()
                               Else
                                   pb.Top -= stepSize
                                   pb.BringToFront()
                               End If
                           End Sub
        t.Start()
    End Sub

    ' Rotate Image
    Private Sub Rotate(pb As PictureBox, flipType As RotateFlipType)
        Dim img As Image = New Bitmap(pb.Image)
        img.RotateFlip(flipType)
        pb.Image = img
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("LOPIT MO, NATAPOS MO!!!")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Form7.Show()
    End Sub
End Class