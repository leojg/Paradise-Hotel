Public Class HabitacionNoEncontradaEx
    Inherits Exception

    Public Sub New()
        MyBase.New("La habitación que busca no existe o el ID ingresado es incorrecto.")
    End Sub

    Public Sub New(ByVal msg As String)
        MyBase.New(msg)
    End Sub
End Class
