Imports Microsoft.VisualBasic

Public Class Tile
    Sub New(ByRef s As Boolean, n As Integer)
        isSelected = s
        number = n
    End Sub

    Dim isSelected As Boolean = False
    Dim number As Integer

    Function getSelected() As Boolean
        Return isSelected
    End Function

    Function getNumber() As Integer
        Return number
    End Function

    Sub setSelected(ByVal s As Boolean)
        isSelected = s
    End Sub

    Sub setNumber(ByVal n As Integer)
        number = n
    End Sub
End Class
