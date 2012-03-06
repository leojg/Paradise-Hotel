Public Class ExNombreRepetido
    Inherits Exception

    Public Sub New()
        MyBase.New("El nombre elegido ya está siendo usado en otra habitación")
    End Sub

    Public Sub New(ByVal msg As String)
        MyBase.New(msg)
    End Sub

End Class
