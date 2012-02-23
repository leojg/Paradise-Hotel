''' <summary>
''' Representa los servicios que brinda el hotel.
''' </summary>
''' <remarks></remarks>
Public Class Servicio
    Dim idserv As Int16
    Dim nom As String

    Public Sub New(ByVal id As Int32, ByVal nom As String)
        Me.idserv = id
        Me.nom = nom
    End Sub

    Public Property Id() As Integer
        Get
            Return idserv
        End Get
        Set(ByVal value As Integer)
            idserv = value
        End Set
    End Property

    Public Property Nombre() As Integer
        Get
            Return nom
        End Get
        Set(ByVal value As Integer)
            nom = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return nom
    End Function
End Class
