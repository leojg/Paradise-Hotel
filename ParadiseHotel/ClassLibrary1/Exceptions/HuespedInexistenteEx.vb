Public Class HuespedInexistenteEx
    Inherits Exception

    Public Sub New()
        MyBase.New("El huesped que busca no existe.")
    End Sub

    Public Sub New(ByVal msg As String)
        MyBase.New(msg)
    End Sub
End Class

