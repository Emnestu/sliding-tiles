Public Class Controller
    Shared WithEvents myGUI As New GUI
    Shared WithEvents myGWD As New GameWonDialog
    Shared myModel As New Logic
    Shared matrix As Tile(,)

    Shared Sub Main()

        myModel = New Logic()
        myGUI = New GUI()
        myGWD = New GameWonDialog()

        myModel.newBoard()



        matrix = myModel.getMatrix()

        redrawNumbers()


        myGUI.Show()

        Application.Run()

    End Sub

    Private Shared Sub PictureBox_TileClicked(x As Integer, y As Integer) Handles myGUI.TileClicked
        If Not myModel.getSelected Then
            myModel.selectTile(x, y)
            If myModel.getSelected Then 'Cus you may have clicked 0, which won't be selected
                myGUI.backColourOn()
                myGUI.selectedLightOn(x, y)
            End If
        Else
            matrix = myModel.getMatrix
            If x = myModel.getSelectedX And y = myModel.getSelectedY Then
                myModel.selectTile(x, y)
                myGUI.backColourOff()
                myGUI.selectedLightOff(x, y)
            ElseIf x = myModel.getSelectedX - 1 And y = myModel.getSelectedY Then
                If matrix(x, y).getNumber = 0 Then
                    myModel.moveUp()
                    myGUI.backColourOff()
                    myGUI.selectedLightOff(myModel.getSelectedX, myModel.getSelectedY)
                    redrawNumbers()
                    If myModel.isGameWon() Then
                        'showGameWonMsg()
                        'myGUI.startFlashing()
                        myGUI.ColorTimer.Start()
                        myGWD.ShowDialog()
                    End If
                Else
                    myModel.selectTile(myModel.getSelectedX, myModel.getSelectedY)
                    myGUI.selectedLightOff(myModel.getSelectedX, myModel.getSelectedY)
                    myModel.selectTile(x, y)
                    myGUI.selectedLightOn(x, y)
                End If
            ElseIf x = myModel.getSelectedX + 1 And y = myModel.getSelectedY Then
                If matrix(x, y).getNumber = 0 Then
                    myModel.moveDown()
                    myGUI.backColourOff()
                    myGUI.selectedLightOff(myModel.getSelectedX, myModel.getSelectedY)
                    redrawNumbers()
                    If myModel.isGameWon() Then
                        'showGameWonMsg()
                        'myGUI.startFlashing()
                        myGUI.ColorTimer.Start()
                        myGWD.ShowDialog()
                    End If
                Else
                    myModel.selectTile(myModel.getSelectedX, myModel.getSelectedY)
                    myGUI.selectedLightOff(myModel.getSelectedX, myModel.getSelectedY)
                    myModel.selectTile(x, y)
                    myGUI.selectedLightOn(x, y)
                End If
            ElseIf x = myModel.getSelectedX And y = myModel.getSelectedY - 1 Then
                If matrix(x, y).getNumber = 0 Then
                    myModel.moveLeft()
                    myGUI.backColourOff()
                    myGUI.selectedLightOff(myModel.getSelectedX, myModel.getSelectedY)
                    redrawNumbers()
                    If myModel.isGameWon() Then
                        'showGameWonMsg()
                        'myGUI.startFlashing()
                        myGUI.ColorTimer.Start()
                        myGWD.ShowDialog()
                    End If
                Else
                    myModel.selectTile(myModel.getSelectedX, myModel.getSelectedY)
                    myGUI.selectedLightOff(myModel.getSelectedX, myModel.getSelectedY)
                    myModel.selectTile(x, y)
                    myGUI.selectedLightOn(x, y)
                End If
            ElseIf x = myModel.getSelectedX And y = myModel.getSelectedY + 1 Then
                If matrix(x, y).getNumber = 0 Then
                    myModel.moveRight()
                    myGUI.backColourOff()
                    myGUI.selectedLightOff(myModel.getSelectedX, myModel.getSelectedY)
                    redrawNumbers()
                    If myModel.isGameWon() Then
                        'showGameWonMsg()
                        'myGUI.startFlashing()
                        myGUI.ColorTimer.Start()
                        myGWD.ShowDialog()
                    End If
                Else
                    myModel.selectTile(myModel.getSelectedX, myModel.getSelectedY)
                    myGUI.selectedLightOff(myModel.getSelectedX, myModel.getSelectedY)
                    myModel.selectTile(x, y)
                    myGUI.selectedLightOn(x, y)
                End If
            ElseIf Not matrix(x, y).getNumber = 0 Then
                myModel.selectTile(myModel.getSelectedX, myModel.getSelectedY)
                myGUI.selectedLightOff(myModel.getSelectedX, myModel.getSelectedY)
                myModel.selectTile(x, y)
                myGUI.selectedLightOn(x, y)
            End If
        End If
        myGUI.Refresh()
    End Sub

    'Private Shared Sub PictureBox_TileClicked(x As Integer, y As Integer) Handles myGUI.TileClicked
    '    matrix = myModel.getMatrix

    '    myGUI.Refresh()
    'End Sub

    Shared Sub redrawNumbers()
        myGUI.assignNumToPB(matrix(0, 0).getNumber, 1)
        myGUI.assignNumToPB(matrix(0, 1).getNumber, 2)
        myGUI.assignNumToPB(matrix(0, 2).getNumber, 3)
        myGUI.assignNumToPB(matrix(0, 3).getNumber, 4)
        myGUI.assignNumToPB(matrix(1, 0).getNumber, 5)
        myGUI.assignNumToPB(matrix(1, 1).getNumber, 6)
        myGUI.assignNumToPB(matrix(1, 2).getNumber, 7)
        myGUI.assignNumToPB(matrix(1, 3).getNumber, 8)
        myGUI.assignNumToPB(matrix(2, 0).getNumber, 9)
        myGUI.assignNumToPB(matrix(2, 1).getNumber, 10)
        myGUI.assignNumToPB(matrix(2, 2).getNumber, 11)
        myGUI.assignNumToPB(matrix(2, 3).getNumber, 12)
        myGUI.assignNumToPB(matrix(3, 0).getNumber, 13)
        myGUI.assignNumToPB(matrix(3, 1).getNumber, 14)
        myGUI.assignNumToPB(matrix(3, 2).getNumber, 15)
        myGUI.assignNumToPB(matrix(3, 3).getNumber, 16)
    End Sub

    Shared Sub GameWonDialog_ButtonClicked(s As String) Handles myGWD.ButtonClicked
        If s = "Play" Then
            newGame()
            myGWD.Hide()
            myGUI.ColorTimer.Stop()
            myGUI.BackColor = Color.FromArgb(102, 154, 204)
        End If
        If s = "Exit" Then
            Application.Exit()
        End If
        If s = "Continue" Then
            myGWD.Hide()
            myGUI.ColorTimer.Stop()
            myGUI.BackColor = Color.FromArgb(102, 154, 204)
        End If
        If s = "Sponsor" Then
            Process.Start("https://en.wikipedia.org/wiki/Milk")
        End If
    End Sub


    Shared Sub showGameWonMsg()
        Dim response = MsgBox("Would you like to play again?", MsgBoxStyle.YesNo Or MsgBoxStyle.Information, "Congratulations, you won!")
        If response = MsgBoxResult.Yes Then
            newGame()
        Else
            Application.Exit()
        End If
    End Sub

    Shared Sub newGame()
        myModel.newBoard()
        matrix = myModel.getMatrix()
        redrawNumbers()
    End Sub

    Shared Sub myGUI_FormClosing(sender As Object, e As FormClosingEventArgs) Handles myGUI.FormClosing
        Application.Exit()
    End Sub
End Class
