Public Class Servicio

    Dim idServ As Byte
    Dim nomServ As String

    Public Property Id() As Byte
        Get
            Return idServ
        End Get
        Set(ByVal value As Byte)
            idServ = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return nomServ
        End Get
        Set(ByVal value As String)
            nomServ = value
        End Set
    End Property

    Public Sub New(ByVal id As Byte, ByVal nom As String)
        Me.idServ = id
        Me.nomServ = nom
    End Sub

    Public Overrides Function ToString() As String
        Return Me.nomServ
    End Function

End Class
