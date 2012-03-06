Public Class ExElementoNoSelecionado
    Inherits Exception

    Public Sub New()
        MyBase.New("El elemento seleccionado no es correcto.")
    End Sub

    Public Sub New(ByVal msg As String)
        MyBase.New(msg)
    End Sub
End Class
