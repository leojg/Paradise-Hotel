Public Class Fachada

    Public Function altaHabitacion(ByVal nom As String, ByVal id As Int32, ByVal numpiso As Int16, ByVal costo As Int16, ByVal tipo As Byte)
        Dim objh As Habitacion = crearHabitacion(nom, id, numpiso, costo, tipo)
        Dim objP As Piso = Hotel.GetInstance().DevolverPiso(numpiso)
        Return objP.AgregarHabitacion(objh)
    End Function

    Public Function altaPiso(ByVal num As Int16, ByVal metraje As Int16)
        Dim objp = crearPiso(num, metraje)
        Return Hotel.GetInstance.AltaPiso(objp)
    End Function

    Public Function bajaHabitacion(ByVal nom As String, ByVal id As Int32, ByVal numpiso As Int16, ByVal costo As Int16, ByVal tipo As Byte)
        Dim objh As Habitacion = crearHabitacion(nom, id, numpiso, costo, tipo)
        Dim objP As Piso = Hotel.GetInstance().DevolverPiso(numpiso)
        Return objP.BajaHabitacion(objh)
    End Function

    Public Function bajaPiso(ByVal num As Int16, ByVal metraje As Int16)
        Dim objp = crearPiso(num, metraje)
        Return Hotel.GetInstance.BajaPiso(objp)
    End Function

    Private Function crearHabitacion(ByVal nom As String, ByVal id As Int32, ByVal numpiso As Int16, ByVal costo As Int16, ByVal tipo As Byte) As Habitacion
        Dim objH As Habitacion
        If (nom = "") Then
            If (tipo = 1) Then
                objH = New Individual(id, numpiso, costo)
            ElseIf (tipo = 2) Then
                objH = New Doble(id, numpiso, costo)
            End If
        Else
            If (tipo = 3) Then
                objH = New SuiteJr(nom, id, numpiso, costo)
            ElseIf (tipo = 4) Then
                objH = New SuiteSr(nom, id, numpiso, costo)
            End If
        End If
        Return objH
    End Function

    Public Function crearPiso(ByVal num As Int16, ByVal metraje As Int16) As Piso
        Dim objP As New Piso(num, metraje)
        Return objP
    End Function

    Public Function modHabitacion(ByVal nom As String, ByVal id As Int32, ByVal numpiso As Int16, ByVal costo As Int16, ByVal tipo As Byte)
        Dim objh As Habitacion = crearHabitacion(nom, id, numpiso, costo, tipo)
        Dim objP As Piso = Hotel.GetInstance().DevolverPiso(numpiso)
        Return objP.ModificarHabitacion(objh)
    End Function

    Public Function modPiso(ByVal num As Int16, ByVal metraje As Int16)
        Dim objp = crearPiso(num, metraje)
        Return Hotel.GetInstance.ModificarPiso(objp)
    End Function

    Public Function devolverHabitacionesPiso(ByVal numPiso) As Hashtable
        Return Hotel.GetInstance.DevolverPiso(numPiso).DevolverHabitaciones
    End Function

    Public Function DevolverHabitacionPorTipo(ByVal tipo As String) As ArrayList
        Return Hotel.GetInstance.DevolverHabitacionPorTipo(tipo)
    End Function

    Public Function devolverPiso(ByVal numPiso As Integer) As Piso
        Return Hotel.GetInstance.DevolverPiso(numPiso)
    End Function

    Public Function devolverPisos() As Hashtable
        Return Hotel.GetInstance.DevolverPisos
    End Function

    Public Function devolverServicios() As Hashtable
        Return Hotel.GetInstance.DevolverServicios
    End Function

End Class
