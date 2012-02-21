Public Class SuiteJr
    Inherits Habitacion
    Dim nom As String

    Public Sub New(ByVal nom As String, ByVal id As Int32, ByVal numpiso As Int16, ByVal costo As Int16)
        MyBase.New(id, numpiso, costo)
        Me.nom = nom
    End Sub

    Public Property Nombre() As String
        Get
            Return nom
        End Get
        Set(ByVal value As String)
            nom = value
        End Set
    End Property

    Public Overrides Function Metraje() As Integer
        Return 16
    End Function

    Public Overrides Function ToString() As String
        Return nom & " - " & MyBase.ToString()
    End Function
End Class
