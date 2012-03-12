Public Class ExHuespedNoEncontrado
    Inherits Exception

    Public Sub New()
        MyBase.New("No existe un huesped con ese id. Registrese en www.hotelparaiso.com.uy")
    End Sub

    Public Sub New(ByVal msg As String)
        MyBase.New(msg)
    End Sub
End Class
