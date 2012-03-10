''' <summary>
''' Clase encargada de brindar un acceso unificado y controlado a la capa de dominio
''' </summary>
''' <remarks></remarks>
Public Class Fachada

    Public Shared Function altaHabitacion(ByVal nom As String, ByVal id As Int32, ByVal numpiso As Int16, ByVal costo As Int16, ByVal tipo As Byte)
        Dim objh As Habitacion = crearHabitacion(nom, id, numpiso, costo, tipo)
        Return Hotel.GetInstance.AltaHabitacion(objh)
    End Function

    Public Shared Function altaPiso(ByVal num As Int16, ByVal metraje As Int16)
        Dim objp = crearPiso(num, metraje)
        Return Hotel.GetInstance.AltaPiso(objp)
    End Function

    Public Shared Function altaReserva(ByVal objResp As Huesped, ByVal id As Integer, ByVal idhab As Int32, ByVal colHuespedes As Hashtable, ByVal cin As Date, ByVal cout As Date)
        Dim objH As Habitacion = Hotel.GetInstance.DevolverHabitacion(idhab)
        Dim arr As ArrayList = ReservasAdmin.GetInstance.CalcularCostosReserva(cin, cout, objH)
        Dim montoTotal = arr.Item(0)
        Dim montoAdelanto = arr.Item(1)
        Dim objR As Reserva = crearReserva(objResp, id, objH, colHuespedes, cin, cout, montoAdelanto, Date.Today, montoTotal)
        ReservasAdmin.GetInstance.altaReserva(objR)
    End Function

    Public Shared Function altaReserva(ByVal objResp As Huesped, ByVal id As Integer, ByVal objH As Habitacion, ByVal colHuespedes As Hashtable, ByVal cin As Date, ByVal cout As Date)
        Dim arr As ArrayList = ReservasAdmin.GetInstance.CalcularCostosReserva(cin, cout, objH)
        Dim montoTotal = arr.Item(0)
        Dim montoAdelanto = arr.Item(1)
        Dim objR As Reserva = crearReserva(objResp, id, objH, colHuespedes, cin, cout, montoAdelanto, Date.Today, montoTotal)
        ReservasAdmin.GetInstance.altaReserva(objR)
    End Function

    Public Shared Function bajaHabitacion(ByVal nom As String, ByVal id As Int32, ByVal numpiso As Int16, ByVal costo As Int16, ByVal tipo As Byte)
        Dim objh As Habitacion = crearHabitacion(nom, id, numpiso, costo, tipo)
        Dim objP As Piso = Hotel.GetInstance().DevolverPiso(numpiso)
        If ReservasAdmin.GetInstance.verificarHabitacionTieneReservas(objh) Then
            Return objP.BajaHabitacion(objh)
        End If
    End Function

    Public Shared Function bajaPiso(ByVal num As Int16, ByVal metraje As Int16)
        Dim objp = crearPiso(num, metraje)
        Return Hotel.GetInstance.BajaPiso(objp)
    End Function

    Public Shared Function bajaReserva(ByVal resId As Integer) As Boolean
        Dim objR As Reserva = ReservasAdmin.GetInstance.devolverReserva(resId)
        Return ReservasAdmin.GetInstance.bajaReserva(objR)
    End Function

    Public Shared Function cargarReporte() As DataSet
        Return Hotel.GetInstance.cargarReporte
    End Function

    Public Shared Function CalcularCostosReserva(ByVal fecha_inicio As Date, ByVal fecha_fin As Date, ByVal habid As Int16) As ArrayList
        Dim objH As Habitacion = Hotel.GetInstance.DevolverHabitacion(habid)
        Return ReservasAdmin.GetInstance.CalcularCostosReserva(fecha_inicio, fecha_fin, objH)
    End Function

    Public Shared Function CalcularCostosReserva(ByVal fecha_inicio As Date, ByVal fecha_fin As Date, ByVal objH As Habitacion) As ArrayList
        Return ReservasAdmin.GetInstance.CalcularCostosReserva(fecha_inicio, fecha_fin, objH)
    End Function


    Public Shared Function calcularNroHabitacion() As Integer
        Return Hotel.GetInstance.CalcularNroHabitacion
    End Function

    Public Shared Function calcularNroReserva() As Integer
        Return ReservasAdmin.GetInstance.calcularNumeroReserva
    End Function

    Private Shared Function crearHabitacion(ByVal nom As String, ByVal id As Int32, ByVal numpiso As Int16, ByVal costo As Int16, ByVal tipo As Byte) As Habitacion
        Try
            Dim objH As Habitacion
            If (nom = Nothing) Then
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
        Catch ex As NullReferenceException
            If (nom Is Nothing And tipo > 2) Then
                ex = New NullReferenceException("El campo Nombre está vacio")
            ElseIf (Not IsNumeric(costo)) Then
                ex = New NullReferenceException("El campo Costo está vacio")
            ElseIf (Not IsNumeric(numpiso)) Then
                ex = New NullReferenceException("El campo Piso está vacio")
            End If
            Throw ex
        End Try
    End Function

    Private Shared Function crearPiso(ByVal num As Int16, ByVal metraje As Int16) As Piso
        Dim objP As New Piso(num, metraje)
        Return objP
    End Function

    Private Shared Function crearReserva(ByVal objResp As Huesped, ByVal id As Integer, ByVal objhab As Habitacion, ByVal colHuespedes As Hashtable, ByVal cin As Date, ByVal cout As Date, ByVal Reserva As Integer, ByVal fRealizacion As Date, ByVal total As Integer)
        Try

            Dim objR As New Reserva(objResp, id, objhab, colHuespedes, cin, cout, Reserva, fRealizacion, total)
            Return objR
        Catch ex As NullReferenceException

        End Try

    End Function

    Public Shared Function modHabitacion(ByVal nom As String, ByVal id As Int32, ByVal numpiso As Int16, ByVal costo As Int16, ByVal tipo As Byte)
        Dim objh As Habitacion = crearHabitacion(nom, id, numpiso, costo, tipo)
        Return Hotel.GetInstance.ModificarHabitacion(objh)
    End Function

    Public Shared Function modPiso(ByVal num As Int16, ByVal metraje As Int16)
        Dim objp = crearPiso(num, metraje)
        Return Hotel.GetInstance.ModificarPiso(objp)
    End Function

    Public Shared Function devolverHabitacionesPiso(ByVal numPiso As Integer) As Hashtable
        Return Hotel.GetInstance.DevolverPiso(numPiso).DevolverHabitaciones
    End Function

    Public Shared Function DevolverHabitacionPorTipo(ByVal tipo As String) As ArrayList
        Return Hotel.GetInstance.DevolverHabitacionPorTipo(tipo)
    End Function

    Public Shared Function DevolverHabitacionPorTipo(ByVal tipo As String, ByVal h_table As String) As Hashtable
        Return Hotel.GetInstance.DevolverHabitacionPorTipo(tipo, h_table)
    End Function

    Public Shared Function devolverHuespedes() As Hashtable
        Return HuespedAdmin.GetInstance.devolverHuespedes()
    End Function

    Public Shared Function devolverPiso(ByVal numPiso As Integer) As Piso
        Return Hotel.GetInstance.DevolverPiso(numPiso)
    End Function

    Public Shared Function devolverPisos() As Hashtable
        Return Hotel.GetInstance.DevolverPisos
    End Function

    Public Shared Function devolverServicios() As Hashtable
        Return Hotel.GetInstance.DevolverServicios
    End Function

    Public Shared Function devolverHabitacionesReservadas() As Hashtable
        Return ReservasAdmin.GetInstance.devolverHabitacionesReservadas
    End Function

    Public Shared Function devolverHuesped(ByVal id As Integer) As Huesped
        Return HuespedAdmin.GetInstance.devolverHuesped(id)
    End Function

    Public Shared Function devolverReservas() As Hashtable
        Return ReservasAdmin.GetInstance.devolverReservas
    End Function

    Public Shared Function obtener_identificaciones() As ArrayList
        Return HuespedAdmin.GetInstance.obtener_identificaciones()
    End Function

    Public Shared Function VerificarFechasDisponibles(ByVal fecha_inicio As Date, ByVal fecha_fin As Date) As ArrayList
        Return ReservasAdmin.GetInstance.verificarHabitacionesDisponibles(fecha_inicio, fecha_fin)
    End Function

    Public Shared Function existe_huesped(ByVal id As Integer) As Boolean
        Return HuespedAdmin.GetInstance.existe_huesped(id)
    End Function

End Class
