''' <summary>
''' Clase que representa las habitaciones tipo Individual
''' </summary>
''' <remarks></remarks>
Public Class Individual
    Inherits Habitacion


    Public Sub New(ByVal id As Int32, ByVal numpiso As Int16, ByVal costo As Int16)
        MyBase.New(id, numpiso, costo)
    End Sub

    Public Overrides Function Metraje() As Integer
        Return 7
    End Function
End Class
