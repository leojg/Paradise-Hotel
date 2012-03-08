Public Class ExNoExistenHabitaciones
    Inherits Exception

    Public Sub New()
        MyBase.New("No existen habitaciónes en la base de datos. Ingrese una para continuar.")
    End Sub

    Public Sub New(ByVal msg As String)
        MyBase.New(msg)
    End Sub

End Class
