Public Class NoHayHabitacionesDisponiblesEx
    Inherits Exception

    Public Sub New()
        MyBase.New("No existen habitaciones disponibles entre las fechas elegidas.")
    End Sub

    Public Sub New(ByVal msg As String)
        MyBase.New(msg)
    End Sub
End Class
