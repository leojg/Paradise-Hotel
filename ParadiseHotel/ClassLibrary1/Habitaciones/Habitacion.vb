''' <summary>
''' Clase que representa las habitaciones. 
''' Es abstracta y los distintos tipos de habitaciones heredan de ella
''' </summary>
''' <remarks></remarks>
Public MustInherit Class Habitacion
    Dim id As Int32
    Dim numpiso As Int16
    Dim costoNoche As Int16
    Dim objPers As PersHabitacion

    Public MustOverride Function Metraje() As Integer

#Region "Metodos para persistir"
    Public Sub guardame()
        objPers.guardar(Me)
    End Sub

    Public Sub eliminame()
        objPers.eliminar(Me)
    End Sub

    Public Sub modificame()
        objPers.modificar(Me)
    End Sub
#End Region

#Region "Constructores, ToString y Properys"

    Public Sub New(ByVal id As Int32, ByVal numpiso As Int16, ByVal costo As Int16)
        Me.id = id
        Me.numpiso = numpiso
        Me.costoNoche = costo
        objPers = New PersHabitacion
    End Sub

    Public Overrides Function ToString() As String
        Return "Habitacion Nº: " & id & " - Piso: " & numpiso & " - Costo/Noche: " & costoNoche & " - Tipo: " & Me.GetType.Name
    End Function

    Public Property Numero() As Integer
        Get
            Return id
        End Get
        Set(ByVal value As Integer)
            id = value
        End Set
    End Property

    Public Property Piso() As Int16
        Get
            Return numpiso
        End Get
        Set(ByVal value As Int16)
            numpiso = value
        End Set
    End Property

    Public Property Costo() As Int16
        Get
            Return costoNoche
        End Get
        Set(ByVal value As Int16)
            costoNoche = value
        End Set
    End Property


#End Region


End Class
