Class Logic
    ' Variable declaration
    ReadOnly gridSize As Integer = 4
    Dim matrix(gridSize - 1, gridSize - 1) As Tile
    Dim winningMatrix(gridSize - 1, gridSize - 1) As Tile
    Dim selected As Boolean = False
    Dim selectedX As Integer
    Dim selectedY As Integer
    ' Dim symbolmatrix(gridSize - 1, gridSize - 1) As Char
    'Sub Main()
    'Console.WriteLine("Test001")
    'newBoard()
    'printSymbolMatrix()
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
    'myForm = Nothing
    'While 1 > 0
    '    input = Console.ReadLine()
    '    If (input = "select") Then
    '        Console.Write("Row (0 to " & gridSize - 1 & "): ")
    '        x = CInt(Console.ReadLine())
    '        Console.WriteLine()
    '        Console.Write("Column (0 - " & gridSize - 1 & "): ")
    '        y = CInt(Console.ReadLine())
    '        Console.WriteLine()
    '        'Console.WriteLine(x & " " & y)
    '        selectTile(x, y)
    '        printSymbolMatrix()
    '    End If
    '    If (input = "moveUp") Then
    '        moveUp()
    '        printSymbolMatrix()
    '    End If
    '    If (input = "moveDown") Then
    '        moveDown()
    '        printSymbolMatrix()
    '    End If
    '    If (input = "moveLeft") Then
    '        moveLeft()
    '        printSymbolMatrix()
    '    End If
    '    If (input = "moveRight") Then
    '        moveRight()
    '        printSymbolMatrix()
    '    End If
    'End While
    'End Sub

    Sub newBoard() ' Creates a new game field
        Dim myTile As Tile
        Dim tileNo As Integer = 1
        While tileNo < 16
            For i As Integer = 0 To 3
                For j As Integer = 0 To 3
                    myTile = New Tile(False, tileNo)
                    matrix(i, j) = myTile
                    winningMatrix(i, j) = myTile
                    tileNo = tileNo + 1
                Next
            Next
        End While
        matrix(gridSize - 1, gridSize - 1) = New Tile(False, 0)
        winningMatrix(gridSize - 1, gridSize - 1) = New Tile(False, 0)
        Shuffle(500000)
        'matrix = oldShuffle(matrix)
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
                    selectTile(selectedX, selectedY)
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
                    selectTile(selectedX, selectedY)
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
                    selectTile(selectedX, selectedY)
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
                    selectTile(selectedX, selectedY)
                End If
            Else
                Console.WriteLine("Unable to move: Board runs out to the right")
            End If
        Else
            Console.WriteLine("Unable to move: Tile is not selected")
        End If
    End Sub

    Sub move()
        
    End Sub

    Function getMatrix() As Tile(,) 'Why can't you just return matrix, if it's a class-wide variable? lol
        Dim myMatrix(gridSize - 1, gridSize - 1) As Tile
        myMatrix = matrix
        Return myMatrix
    End Function

    Function getSelected() As Boolean
        Return selected
    End Function

    Function getSelectedX() As Integer
        Return selectedX
    End Function

    Function getSelectedY() As Integer
        Return selectedY
    End Function

    Function oldShuffle(ByVal tiles As Tile(,)) As Tile(,)
        Dim cupHolder As Tile
        Dim randHolder(1) As Integer
        Dim r As Random = New Random()

        For i As Integer = 0 To gridSize - 1
            For j As Integer = 0 To gridSize - 1
                randHolder(0) = r.Next(0, gridSize - 1)
                randHolder(1) = r.Next(0, gridSize - 1)
                cupHolder = tiles(randHolder(0), randHolder(1))
                tiles(randHolder(0), randHolder(1)) = tiles(i, j)
                tiles(i, j) = cupHolder
            Next
        Next

        Return tiles
    End Function

    Sub Shuffle(n As Integer)
        Dim myTimeSubstring As String
        Dim myTimeInt As Integer
        Dim myArray(3) As Integer
        Dim zeroLocation(1) As Integer
        Dim r As Random = New Random()
        Dim randHolder As Integer
        For numberOfShuffles As Integer = 0 To n - 1
            For i As Integer = 0 To gridSize - 1
                For j As Integer = 0 To gridSize - 1
                    If matrix(i, j).getNumber = 0 Then
                        zeroLocation(0) = i
                        zeroLocation(1) = j
                    End If
                Next
            Next

            myArray = {0, 0, 0, 0}

            If withinBounds(zeroLocation(0) - 1, zeroLocation(1)) Then
                myArray(0) = 1
            End If
            If withinBounds(zeroLocation(0) + 1, zeroLocation(1)) Then
                myArray(1) = 1
            End If
            If withinBounds(zeroLocation(0), zeroLocation(1) - 1) Then
                myArray(2) = 1
            End If
            If withinBounds(zeroLocation(0), zeroLocation(1) + 1) Then
                myArray(3) = 1
            End If

            myTimeSubstring = TimeString.Substring(0, 2) & TimeString.Substring(3, 2) & TimeString.Substring(6, 2)
            myTimeInt = CInt(myTimeSubstring)

            randHolder = (r.Next(0, myTimeInt) Mod 4)
            While Not myArray(randHolder) = 1
                randHolder = (r.Next(0, myTimeInt) Mod 4)
            End While

            Select Case randHolder
                Case 0
                    selectTile(zeroLocation(0) - 1, zeroLocation(1))
                    moveDown()
                Case 1
                    selectTile(zeroLocation(0) + 1, zeroLocation(1))
                    moveUp()
                Case 2
                    selectTile(zeroLocation(0), zeroLocation(1) - 1)
                    moveRight()
                Case 3
                    selectTile(zeroLocation(0), zeroLocation(1) + 1)
                    moveLeft()
            End Select
        Next
    End Sub

    Function withinBounds(x As Integer, y As Integer) As Boolean
        If (x < 0 Or x > gridSize - 1 Or y < 0 Or y > gridSize - 1) Then
            Return False
        Else
            Return True
        End If
    End Function

    Function isGameWon() As Boolean
        Dim differenceExists As Integer = 0
        For i As Integer = 0 To 3
            For j As Integer = 0 To 3
                If Not matrix(i, j).getNumber = winningMatrix(i, j).getNumber Then
                    differenceExists = 1
                End If
            Next
        Next
        If differenceExists = 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
