''' <summary>
''' Representa los pisos del hotel. También es la gestora de Habitaciones
''' </summary>
''' <remarks></remarks>
Public Class Piso
    Dim colHabitaciones As Hashtable
    Dim num As Int16
    Dim metros As Int16
    Dim metrajeDisponible As Int16
    Dim objPers As PersPiso


    Public Function AgregarHabitacion(ByVal objHab As Habitacion) As Boolean
        If (Not colHabitaciones.ContainsKey(objHab.Numero)) Then
            If (Me.ControlarMetraje(objHab)) Then
                Me.metrajeDisponible = metrajeDisponible - objHab.Metraje
                MsgBox(metrajeDisponible)
                objHab.guardame()
                colHabitaciones.Add(objHab.Numero, objHab)
                Return True
            End If
        End If
        Return False
    End Function

    Public Function BajaHabitacion(ByVal objHab As Habitacion) As Boolean
        If (Me.colHabitaciones.ContainsKey(objHab.Numero)) Then
            Me.metrajeDisponible = metrajeDisponible + objHab.Metraje
            MsgBox(metrajeDisponible)
            objHab.eliminame()
            colHabitaciones.Remove(objHab.Numero)
            Return True
        End If
        Return False
    End Function

    Private Function ControlarMetraje(ByVal objHab As Habitacion) As Boolean
        If (objHab.Metraje > Me.metrajeDisponible) Then
            Return False
        End If
        Return True
    End Function

    Public Function DevolverHabitaciones() As Hashtable
        Return colHabitaciones
    End Function

    Public Function ModificarHabitacion(ByVal objHab As Habitacion) As Boolean
        If (Me.colHabitaciones.ContainsKey(objHab.Numero)) Then
            objHab.modificame()
            colHabitaciones.Remove(objHab.Numero)
            colHabitaciones.Add(objHab.Numero, objHab)
            Return True
        End If
        Return False
    End Function

    Public Sub ObtenerHabitaciones()
        Dim objDataSet As DataSet = objPers.ObtenerDataSetHabitaciones
        For Each objfila As DataRow In objDataSet.Tables("Habitaciones").Rows
            If (Me.Numero = CInt(objfila("NumeroPiso"))) Then
                Dim tipo As String = CInt(objfila("IdTipoHabitacion"))
                Dim objhab As Habitacion
                If (tipo = 1) Then
                    objhab = New Individual(CInt(objfila("Numero")), CInt(objfila("NumeroPiso")), CInt(objfila("CostoUnitario")))
                ElseIf (tipo = 2) Then
                    objhab = New Doble(CInt(objfila("Numero")), CInt(objfila("NumeroPiso")), CInt(objfila("CostoUnitario")))
                ElseIf (tipo = 3) Then
                    Dim nomSuite = ObtenerNombreSuite(CInt(objfila("Numero")))
                    objhab = New SuiteJr(nomSuite, CInt(objfila("Numero")), CInt(objfila("NumeroPiso")), CInt(objfila("CostoUnitario")))
                ElseIf (tipo = 4) Then
                    Dim nomSuite = ObtenerNombreSuite(CInt(objfila("Numero")))
                    objhab = New SuiteSr(nomSuite, CInt(objfila("Numero")), CInt(objfila("NumeroPiso")), CInt(objfila("CostoUnitario")))
                End If
                colHabitaciones.Add(objhab.Numero, objhab)
            End If
        Next
    End Sub

    Private Function ObtenerNombreSuite(ByVal numHab As Integer) As String
        Dim objDataSet As DataSet = objPers.ObtenerDataNombresSuites
        For Each objfila As DataRow In objDataSet.Tables("DenominacionesSuites").Rows
            If (numHab = CInt(objfila("NumeroSuite"))) Then
                Return CStr(objfila("Denominacion"))
            End If
        Next
        'para borrar
        Return Nothing
    End Function

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
    Public Sub New(ByVal num As Int16, ByVal metraje As Int16)
        colHabitaciones = New Hashtable
        Me.num = num
        Me.metros = metraje
        metrajeDisponible = metros
        objPers = New PersPiso
    End Sub

    Public Overrides Function ToString() As String
        Return "Piso: " & Numero & " - Superficie: " & metros
    End Function

    Public Property Numero() As Int16
        Get
            Return num
        End Get
        Set(ByVal value As Int16)
            num = value
        End Set
    End Property

    Public Property Metraje() As Int16
        Get
            Return metros

        End Get
        Set(ByVal value As Int16)
            metros = value
        End Set
    End Property
#End Region


End Class
