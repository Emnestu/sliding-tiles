Module Logic
    ' Variable declaration
    ReadOnly gridSize As Integer = 4
    Dim matrix(gridSize - 1, gridSize - 1) As Tile
    Dim selected As Boolean = False
    Dim selectedX As Integer
    Dim selectedY As Integer
    ' Dim symbolmatrix(gridSize - 1, gridSize - 1) As Char
    Sub Main()
        Console.WriteLine("Test001")
        Console.WriteLine("TestTime: " & TimeString)
        Dim myTimeSubstring As String = TimeString.Substring(0, 2) & TimeString.Substring(3, 2) & TimeString.Substring(6, 2)
        Console.WriteLine(CInt(myTimeSubstring))
        newBoard()
        printSymbolMatrix()
        'selectTile(1, 0)
        'printSymbolMatrix()
        'moveUp()
        'printSymbolMatrix()
        'selectTile(0, 0)
        'printSymbolMatrix()
        'moveDown()
        'printSymbolMatrix()
        'selectTile(0, 1)
        'printSymbolMatrix()
        'moveLeft()
        'printSymbolMatrix()
        'selectTile(0, 0)
        'printSymbolMatrix()
        'moveRight()
        'printSymbolMatrix()
        Dim input As String
        Dim x As Integer
        Dim y As Integer
        While 1 > 0
            input = Console.ReadLine()
            If (input = "select") Then
                Console.Write("Row (0 to " & gridSize - 1 & "): ")
                x = CInt(Console.ReadLine())
                Console.WriteLine()
                Console.Write("Column (0 - " & gridSize - 1 & "): ")
                y = CInt(Console.ReadLine())
                Console.WriteLine()
                'Console.WriteLine(x & " " & y)
                selectTile(x, y)
                printSymbolMatrix()
            End If
            If (input = "moveUp") Then
                moveUp()
                printSymbolMatrix()
            End If
            If (input = "moveDown") Then
                moveDown()
                printSymbolMatrix()
            End If
            If (input = "moveLeft") Then
                moveLeft()
                printSymbolMatrix()
            End If
            If (input = "moveRight") Then
                moveRight()
                printSymbolMatrix()
            End If
        End While
    End Sub

    Sub newBoard() ' Creates a new game field
        Dim tileNo As Integer = 0
        For i As Integer = 0 To 3
            For j As Integer = 0 To 3
                Dim myTile As New Tile(False, tileNo)
                matrix(i, j) = myTile
                tileNo = tileNo + 1
            Next
        Next
    End Sub

    Sub printSymbolMatrix() 'Shows the objects in the matrix as characters for testing purposes in console
        Dim selected As Boolean
        Dim number As Integer
        For i As Integer = 0 To 3
            Console.WriteLine()
            Console.WriteLine()
            For j As Integer = 0 To 3
                selected = matrix(i, j).getSelected()
                number = matrix(i, j).getNumber()
                If Not selected Then
                    If number < 10 Then
                        Console.Write(" " & number & "  ")
                    Else
                        Console.Write(" " & number & " ")
                    End If
                ElseIf number < 10 Then
                    Console.Write("[" & number & "] ")
                Else
                    Console.Write("[" & number & "]")
                End If
            Next
        Next
        Console.WriteLine()
        Console.WriteLine()
    End Sub

    Sub selectTile(ByVal x As Integer, y As Integer)
        If matrix(x, y).getNumber = 0 Then
            Console.WriteLine("You cannot select the empty Tile!")
            Return
        End If
        If selected = True And matrix(x, y).getSelected = False Then 'If a tile is selected, but it's not the tile we're trying to select right now
            'unselect the selected Tile
            unselect(selectedX, selectedY)
            selected = False
        End If
        If matrix(x, y).getSelected = False Then
            matrix(x, y).setSelected(True)
            selectedX = x
            selectedY = y
            selected = True
        Else
            unselect(x, y)
        End If
    End Sub

    Private Sub unselect(ByVal x As Integer, y As Integer)
        If matrix(x, y).getSelected = True Then
            matrix(x, y).setSelected(False)
            selected = False
        Else
            Console.WriteLine("Unselect Error: Tile is not selected")
        End If
    End Sub

    Sub moveUp()
        Dim myTile As Tile
        If selected = True Then
            If selectedX <> 0 Then
                If matrix(selectedX - 1, selectedY).getNumber = 0 Then
                    myTile = matrix(selectedX - 1, selectedY) 'Store the 0 (empty) tile
                    matrix(selectedX - 1, selectedY) = matrix(selectedX, selectedY) 'Duplicate the number tile
                    matrix(selectedX, selectedY) = myTile 'Restore the 0 (empty) tile
                    selectTile(selectedX - 1, selectedY) 'Unselects duplicated number tile
                Else
                    Console.WriteLine("Unable to move: An empty Tile above does not exist")
                    'selectTile(selectedX, selectedY)
                End If
            Else
                Console.WriteLine("Unable to move: Board runs out above")
            End If
        Else
            Console.WriteLine("Unable to move: Tile is not selected")
        End If
    End Sub

    Sub moveDown()
        Dim myTile As Tile
        If selected = True Then
            If selectedX <> gridSize - 1 Then
                If matrix(selectedX + 1, selectedY).getNumber = 0 Then
                    myTile = matrix(selectedX + 1, selectedY) 'Store the 0 (empty) tile
                    matrix(selectedX + 1, selectedY) = matrix(selectedX, selectedY) 'Duplicate the number tile
                    matrix(selectedX, selectedY) = myTile 'Restore the 0 (empty) tile
                    selectTile(selectedX + 1, selectedY) 'Unselects duplicated number tile
                Else
                    Console.WriteLine("Unable to move: An empty Tile below does not exist")
                End If
            Else
                Console.WriteLine("Unable to move: Board runs out below")
            End If
        Else
            Console.WriteLine("Unable to move: Tile is not selected")
        End If
    End Sub

    Sub moveLeft()
        Dim myTile As Tile
        If selected = True Then
            If selectedY <> 0 Then
                If matrix(selectedX, selectedY - 1).getNumber = 0 Then
                    myTile = matrix(selectedX, selectedY - 1) 'Store the 0 (empty) tile
                    matrix(selectedX, selectedY - 1) = matrix(selectedX, selectedY) 'Duplicate the number tile
                    matrix(selectedX, selectedY) = myTile 'Restore the 0 (empty) tile
                    selectTile(selectedX, selectedY - 1) 'Unselects duplicated number tile
                Else
                    Console.WriteLine("Unable to move: An empty Tile to the left does not exist")
                End If
            Else
                Console.WriteLine("Unable to move: Board runs out to the left")
            End If
        Else
            Console.WriteLine("Unable to move: Tile is not selected")
        End If
    End Sub

    Sub moveRight()
        Dim myTile As Tile
        If selected = True Then
            If selectedY <> gridSize - 1 Then
                If matrix(selectedX, selectedY + 1).getNumber = 0 Then
                    myTile = matrix(selectedX, selectedY + 1) 'Store the 0 (empty) tile
                    matrix(selectedX, selectedY + 1) = matrix(selectedX, selectedY) 'Duplicate the number tile
                    matrix(selectedX, selectedY) = myTile 'Restore the 0 (empty) tile
                    selectTile(selectedX, selectedY + 1) 'Unselects duplicated number tile
                Else
                    Console.WriteLine("Unable to move: An empty Tile to the right does not exist")
                End If
            Else
                Console.WriteLine("Unable to move: Board runs out to the right")
            End If
        Else
            Console.WriteLine("Unable to move: Tile is not selected")
        End If
    End Sub
End Module
