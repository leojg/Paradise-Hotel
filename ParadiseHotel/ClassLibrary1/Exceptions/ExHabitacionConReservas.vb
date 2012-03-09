Public Class ExHabitacionConReservas
    Inherits Exception

    Public Sub New()
        MyBase.New("La habitación tiene reservas activas. No puede ser eliminada.")
    End Sub

    Public Sub New(ByVal msg As String)
        MyBase.New(msg)
    End Sub

End Class
