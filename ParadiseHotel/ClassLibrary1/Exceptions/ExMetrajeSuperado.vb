Public Class ExMetrajeSuperado
    Inherits Exception

    Public Sub New()
        MyBase.New("El metraje de la habitación supera al metraje disponible en el piso")
    End Sub

    Public Sub New(ByVal msg As String)
        MyBase.New(msg)
    End Sub

End Class
