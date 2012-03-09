''' <summary>
''' Clase encargada de gestionar las reservas de habitaciones
''' </summary>
''' <remarks></remarks>
Public Class ReservasAdmin

    Shared instance As ReservasAdmin
    Dim colReservas As Hashtable
    Dim objPers As PersHotel

    Private Sub New()
        colReservas = New Hashtable
        objPers = New PersHotel
    End Sub

    Public Shared Function GetInstance() As ReservasAdmin
        If (instance Is Nothing) Then
            instance = New ReservasAdmin
        End If
        Return instance
    End Function

    Public Function altaReserva(ByVal objR As Reserva) As Boolean
        If (Not colReservas.ContainsKey(objR.Id)) Then
            objR.guardame()
            colReservas.Add(objR.Id, objR)
        End If
    End Function

    Public Function bajaReserva(ByVal objR As Reserva) As Boolean
        If colReservas.ContainsKey(objR.Id) Then
            objR.Rembolso = calcularRembolso(objR)
            objR.cancelame()
            colReservas.Remove(objR.Id)
            colReservas.Add(objR.Id, objR)
        End If
    End Function

    ''' <summary>
    ''' Calcula el costo de las reservas según la habitación y dias pasados.
    ''' Devuelve un array con el costo total(posición 0), el monto de adelanto(posición 1) 
    ''' y el numero de dias de reserva(posición 2).
    ''' </summary>
    ''' <param name="fecha_inicio"></param>
    ''' <param name="fecha_fin"></param>
    ''' <param name="objH"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CalcularCostosReserva(ByVal fecha_inicio As Date, ByVal fecha_fin As Date, ByVal objH As Habitacion) As ArrayList
        Dim arr As New ArrayList
        Dim dias As Int16 = DateDiff(DateInterval.Day, fecha_inicio, fecha_fin)
        Dim costo_total As Int32 = objH.Costo * dias
        Dim costo_reserva As Int32 = costo_total * 0.4
        arr.Add(costo_total)
        arr.Add(costo_reserva)
        arr.Add(dias)
        Return arr
    End Function

    Public Function calcularNumeroReserva() As Integer
        Dim nroResMax As Integer = 0
        For Each objR As Reserva In colReservas.Values
            If (nroResMax < objR.Id) Then
                nroResMax = objR.Id
            End If
        Next
        Return nroResMax + 1
    End Function

    Public Function calcularRembolso(ByVal objR As Reserva) As Integer
        If (DateDiff(DateInterval.Hour, Date.Today, objR.CheckIn) > 72) Then
            Return objR.montoReserva
        End If
        Return 0
    End Function

    Public Function devolverReserva(ByVal idres As Integer) As Reserva
        Dim objR As Reserva = CType(colReservas.Item(idres), Reserva)
        Return objR
    End Function

    Public Function devolverReservas() As Hashtable
        Return colReservas
    End Function

    Public Function devolverHabitacionesReservadas() As Hashtable
        Dim hash As New Hashtable
        For Each objR As Reserva In colReservas.Values
            hash.Add(objR.Habitacion.Numero, objR.Habitacion)
        Next
        Return hash
    End Function

    Public Sub obtenerReservas()
        Dim objDataSetReservas As DataSet = objPers.ObtenerDataSetReservas
        Dim objDataSetReservasHuespedes As DataSet = objPers.ObtenerDataSetReservasHuespedes
        For Each objfila As DataRow In objDataSetReservas.Tables("Reservas").Rows
            Dim objR As Reserva
            Dim id As Integer = CInt(objfila("Id"))
            Dim nrohab As Integer = CInt(objfila("NumeroHabitacion"))
            Dim cin As Date = CDate(objfila("FechaEntrada"))
            Dim cout As Date = CDate(objfila("FechaSalida"))
            Dim freal As Date = CDate(objfila("FechaRealizacion"))
            Dim madel As Integer = CInt(objfila("MontoAdelantado"))
            Dim mtot As Integer = CInt(objfila("MontoTotal"))
            Dim fpago As Date = CDate(objfila("FechaPagoSaldo"))
            Dim montoRem As Integer = CInt(objfila("MontoReembolsado"))

            Dim objhab As Habitacion = Hotel.GetInstance.DevolverHabitacion(nrohab)
            Dim colHuespedes As New Hashtable
            Dim objResposable As Huesped
            For Each objfila2 As DataRow In objDataSetReservasHuespedes.Tables("ReservasHuespedes").Rows
                If (CInt(objfila("Id")) = (CInt(objfila2("reserva_id")))) Then
                    Dim huesped_id As Integer = CInt(objfila2("pasajero_id"))
                    Dim objh As Huesped = HuespedAdmin.GetInstance.devolverHuesped(huesped_id)
                    If (CBool(objfila2("responsable")) = True) Then
                        colHuespedes.Add(objh.Documento, objh)
                    Else
                        objResposable = objh
                    End If
                End If
            Next
            objR = New Reserva(objResposable, id, objhab, colHuespedes, cin, cout, madel, freal, mtot)
            objR.Rembolso = montoRem
            objR.FechaPago = fpago
            Me.colReservas.Add(objR.Id, objR)
        Next
    End Sub

    Public Function verificarHabitacionTieneReservas(ByVal objH As Habitacion)
        For Each objR As Reserva In colReservas.Values
            If (objR.Habitacion.Numero = objH.Numero) Then
                Throw New ExHabitacionConReservas
            End If
        Next
        Return True
    End Function

    ''' <summary>
    ''' Dadas las fechas de checkin y checkout indicadas, recorre las reservas y obtiene aquellas
    ''' que sus fechas de ingreso y salida coincidan con los parametros y compara cada habitacion con
    ''' las de dichas reservas y devuelve aquellas que no están reservadas
    ''' </summary>
    ''' <param name="fecha_inicio"></param>
    ''' <param name="fecha_fin"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function verificarHabitacionesDisponibles(ByVal fecha_inicio As Date, ByVal fecha_fin As Date) As ArrayList
        Dim colhab As ArrayList = Hotel.GetInstance.DevolverHabitacionPorTipo("Todo")
        For Each objR As Reserva In colReservas.Values
            If (Not objR.CheckOut < fecha_inicio Or Not objR.CheckIn > fecha_fin) Then
                If (colhab.Contains(objR.Habitacion)) Then
                    colhab.Remove(objR.Habitacion)
                End If
            End If
        Next
        Return colhab
    End Function
End Class
