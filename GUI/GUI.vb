Public Class GUI
    Dim matrix(,) As Tile
    Dim x As Integer
    Dim y As Integer
    Dim interval As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(102, 154, 204)
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        x = 0
        y = 0
        RaiseEvent TileClicked(x, y)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        x = 0
        y = 1
        RaiseEvent TileClicked(x, y)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        x = 0
        y = 2
        RaiseEvent TileClicked(x, y)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        x = 0
        y = 3
        RaiseEvent TileClicked(x, y)
    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        x = 1
        y = 0
        RaiseEvent TileClicked(x, y)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        x = 1
        y = 1
        RaiseEvent TileClicked(x, y)
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        x = 1
        y = 2
        RaiseEvent TileClicked(x, y)
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        x = 1
        y = 3
        RaiseEvent TileClicked(x, y)
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        x = 2
        y = 0
        RaiseEvent TileClicked(x, y)
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        x = 2
        y = 1
        RaiseEvent TileClicked(x, y)
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        x = 2
        y = 2
        RaiseEvent TileClicked(x, y)
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        x = 2
        y = 3
        RaiseEvent TileClicked(x, y)
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        x = 3
        y = 0
        RaiseEvent TileClicked(x, y)
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        x = 3
        y = 1
        RaiseEvent TileClicked(x, y)
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        x = 3
        y = 2
        RaiseEvent TileClicked(x, y)
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        x = 3
        y = 3
        RaiseEvent TileClicked(x, y)
    End Sub

    Public Event TileClicked(x As Integer, y As Integer)

    Sub assignNumToPB(ByVal num As Integer, ByVal pb As Integer)
        If pb = 1 Then
            PictureBox1.Image = getPic(num)
        End If
        If pb = 2 Then
            PictureBox2.Image = getPic(num)
        End If
        If pb = 3 Then
            PictureBox3.Image = getPic(num)
        End If
        If pb = 4 Then
            PictureBox4.Image = getPic(num)
        End If
        If pb = 5 Then
            PictureBox5.Image = getPic(num)
        End If
        If pb = 6 Then
            PictureBox6.Image = getPic(num)
        End If
        If pb = 7 Then
            PictureBox7.Image = getPic(num)
        End If
        If pb = 8 Then
            PictureBox8.Image = getPic(num)
        End If
        If pb = 9 Then
            PictureBox9.Image = getPic(num)
        End If
        If pb = 10 Then
            PictureBox10.Image = getPic(num)
        End If
        If pb = 11 Then
            PictureBox11.Image = getPic(num)
        End If
        If pb = 12 Then
            PictureBox12.Image = getPic(num)
        End If
        If pb = 13 Then
            PictureBox13.Image = getPic(num)
        End If
        If pb = 14 Then
            PictureBox14.Image = getPic(num)
        End If
        If pb = 15 Then
            PictureBox15.Image = getPic(num)
        End If
        If pb = 16 Then
            PictureBox16.Image = getPic(num)
        End If
    End Sub

    Function getPic(ByVal i As Integer) As Image
        If i = 0 Then
            Return My.Resources.blank_tile
        End If
        If i = 1 Then
            Return My.Resources.printable_number_1
        End If
        If i = 2 Then
            Return My.Resources.printable_number_2
        End If
        If i = 3 Then
            Return My.Resources.printable_number_3
        End If
        If i = 4 Then
            Return My.Resources.printable_number_4
        End If
        If i = 5 Then
            Return My.Resources.printable_number_5
        End If
        If i = 6 Then
            Return My.Resources.printable_number_6
        End If
        If i = 7 Then
            Return My.Resources.printable_number_7
        End If
        If i = 8 Then
            Return My.Resources.printable_number_8
        End If
        If i = 9 Then
            Return My.Resources.printable_number_9
        End If
        If i = 10 Then
            Return My.Resources.printable_number_10
        End If
        If i = 11 Then
            Return My.Resources.printable_number_11
        End If
        If i = 12 Then
            Return My.Resources.printable_number_12
        End If
        If i = 13 Then
            Return My.Resources.printable_number_13
        End If
        If i = 14 Then
            Return My.Resources.printable_number_14
        End If
        If i = 15 Then
            Return My.Resources.printable_number_15
        End If
        Return My.Resources.icon_error
    End Function

    Sub selectedLightOn(x As Integer, y As Integer)
        If x = 0 And y = 0 Then
            PictureBox1.BackColor = Color.FromArgb(204, 102, 102)
        End If
        If x = 0 And y = 1 Then
            PictureBox2.BackColor = Color.FromArgb(204, 102, 102)
        End If
        If x = 0 And y = 2 Then
            PictureBox3.BackColor = Color.FromArgb(204, 102, 102)
        End If
        If x = 0 And y = 3 Then
            PictureBox4.BackColor = Color.FromArgb(204, 102, 102)
        End If
        If x = 1 And y = 0 Then
            PictureBox5.BackColor = Color.FromArgb(204, 102, 102)
        End If
        If x = 1 And y = 1 Then
            PictureBox6.BackColor = Color.FromArgb(204, 102, 102)
        End If
        If x = 1 And y = 2 Then
            PictureBox7.BackColor = Color.FromArgb(204, 102, 102)
        End If
        If x = 1 And y = 3 Then
            PictureBox8.BackColor = Color.FromArgb(204, 102, 102)
        End If
        If x = 2 And y = 0 Then
            PictureBox9.BackColor = Color.FromArgb(204, 102, 102)
        End If
        If x = 2 And y = 1 Then
            PictureBox10.BackColor = Color.FromArgb(204, 102, 102)
        End If
        If x = 2 And y = 2 Then
            PictureBox11.BackColor = Color.FromArgb(204, 102, 102)
        End If
        If x = 2 And y = 3 Then
            PictureBox12.BackColor = Color.FromArgb(204, 102, 102)
        End If
        If x = 3 And y = 0 Then
            PictureBox13.BackColor = Color.FromArgb(204, 102, 102)
        End If
        If x = 3 And y = 1 Then
            PictureBox14.BackColor = Color.FromArgb(204, 102, 102)
        End If
        If x = 3 And y = 2 Then
            PictureBox15.BackColor = Color.FromArgb(204, 102, 102)
        End If
        If x = 3 And y = 3 Then
            PictureBox16.BackColor = Color.FromArgb(204, 102, 102)
        End If
    End Sub

    Sub selectedLightOff(x As Integer, y As Integer)
        If x = 0 And y = 0 Then
            PictureBox1.BackColor = Color.Transparent
        End If
        If x = 0 And y = 1 Then
            PictureBox2.BackColor = Color.Transparent
        End If
        If x = 0 And y = 2 Then
            PictureBox3.BackColor = Color.Transparent
        End If
        If x = 0 And y = 3 Then
            PictureBox4.BackColor = Color.Transparent
        End If
        If x = 1 And y = 0 Then
            PictureBox5.BackColor = Color.Transparent
        End If
        If x = 1 And y = 1 Then
            PictureBox6.BackColor = Color.Transparent
        End If
        If x = 1 And y = 2 Then
            PictureBox7.BackColor = Color.Transparent
        End If
        If x = 1 And y = 3 Then
            PictureBox8.BackColor = Color.Transparent
        End If
        If x = 2 And y = 0 Then
            PictureBox9.BackColor = Color.Transparent
        End If
        If x = 2 And y = 1 Then
            PictureBox10.BackColor = Color.Transparent
        End If
        If x = 2 And y = 2 Then
            PictureBox11.BackColor = Color.Transparent
        End If
        If x = 2 And y = 3 Then
            PictureBox12.BackColor = Color.Transparent
        End If
        If x = 3 And y = 0 Then
            PictureBox13.BackColor = Color.Transparent
        End If
        If x = 3 And y = 1 Then
            PictureBox14.BackColor = Color.Transparent
        End If
        If x = 3 And y = 2 Then
            PictureBox15.BackColor = Color.Transparent
        End If
        If x = 3 And y = 3 Then
            PictureBox16.BackColor = Color.Transparent
        End If
    End Sub

    Sub backColourOn()
        'Me.BackColor = Color.Blue
    End Sub

    Sub backColourOff()
        'Me.BackColor = Color.White
    End Sub

    Private Sub ColorTimer_Tick(sender As Object, e As EventArgs) Handles ColorTimer.Tick
        If interval = 37 Then
            interval = 0
        End If
        Dim frequency As Double = 0.3
        Dim colorRed As Double = Math.Sin(frequency * interval) * 127.5 + 127.5
        Dim colorGreen As Double = Math.Sin(frequency * interval + 2) * 127.5 + 127.5
        Dim colorBlue As Double = Math.Sin(frequency * interval + 4) * 127.5 + 127.5
        Me.BackColor = Color.FromArgb(CInt(colorRed), CInt(colorGreen), CInt(colorBlue))
        Me.Refresh()
        interval = interval + 1
    End Sub
End Class
