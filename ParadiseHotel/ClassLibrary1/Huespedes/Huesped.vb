''' <summary>
''' Brinda una interfaz e implementacion común a todos los huespedes
''' </summary>
''' <remarks></remarks>
Public MustInherit Class Huesped

    Dim nom As String
    Dim ape As String
    Dim doc As Integer
    Dim tel As Integer
    Dim dir As String

    Public Sub New(ByVal nom As String, ByVal ape As String, ByVal doc As Integer, ByVal tel As Integer, ByVal dir As String)
        Me.nom = nom
        Me.ape = ape
        Me.doc = doc
        Me.tel = tel
        Me.dir = dir
    End Sub

    Public Overrides Function ToString() As String
        Return nom & " " & ape & " - Doc.: " & doc & " - Tel.: " & tel & " - Dir.: " & dir
    End Function

    Public Property Nombre() As String
        Get
            Return nom
        End Get
        Set(ByVal value As String)
            nom = value
        End Set
    End Property

    Public Property Apellido() As String
        Get
            Return ape
        End Get
        Set(ByVal value As String)
            ape = value
        End Set
    End Property

    Public Property Documento() As Integer
        Get
            Return doc
        End Get
        Set(ByVal value As Integer)
            doc = value
        End Set
    End Property

    Public Property Telefono() As Integer
        Get
            Return tel
        End Get
        Set(ByVal value As Integer)
            tel = value
        End Set
    End Property

    Public Property Direccion() As String
        Get
            Return dir
        End Get
        Set(ByVal value As String)
            dir = value
        End Set
    End Property

End Class
