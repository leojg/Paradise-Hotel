Public Class HuespedNoEncontradoException
    Inherits Exception

    Public Sub New()
        MyBase.New("No existe un huésped con ese número de documento")
    End Sub
End Class
