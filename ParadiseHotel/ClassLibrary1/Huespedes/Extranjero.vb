''' <summary>
''' Representa los huespedes extranjeros
''' </summary>
''' <remarks></remarks>
Public Class Extranjero
    Inherits Huesped

    Dim tieneVisa As Boolean
    Dim venceVisa As Date
    Dim paisProcedencia As String

    Public Sub New(ByVal visa As Boolean, ByVal vence As Date, ByVal pais As String, ByVal nom As String, ByVal ape As String, ByVal doc As Integer, ByVal tel As Integer, ByVal dir As String)
        MyBase.New(nom, ape, doc, tel, dir)
        Me.tieneVisa = visa
        Me.venceVisa = vence
        Me.paisProcedencia = pais
    End Sub

    Public Overrides Function ToString() As String
        Return MyBase.ToString() & "Ciudadano de:" & paisProcedencia
    End Function

    Public Property Visa() As Boolean
        Get
            Return tieneVisa
        End Get
        Set(ByVal value As Boolean)
            tieneVisa = value
        End Set
    End Property

    Public Property Vencimiento() As Date
        Get
            Return venceVisa
        End Get
        Set(ByVal value As Date)
            venceVisa = value
        End Set
    End Property

    Public Property Pais() As String
        Get
            Return paisProcedencia
        End Get
        Set(ByVal value As String)
            paisProcedencia = value
        End Set
    End Property


End Class
