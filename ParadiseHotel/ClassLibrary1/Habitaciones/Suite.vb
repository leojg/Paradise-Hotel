Public MustInherit Class Suite
    Inherits Habitacion

    Dim nom As String

    Public Sub New(ByVal nom As String, ByVal id As Int32, ByVal numpiso As Int16, ByVal costo As Int16)
        MyBase.New(id, numpiso, costo)
        Me.nom = nom
        Me.tieneTerraza = True
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

    End Function

    Public Overrides Function ToString() As String
        Return nom & " - " & MyBase.ToString()
    End Function

    Public Overrides Property Costo() As Short
        Get
            Return MyBase.Costo + (Costo * 1.1)
        End Get
        Set(ByVal value As Short)
            MyBase.Costo = value
        End Set
    End Property

End Class
