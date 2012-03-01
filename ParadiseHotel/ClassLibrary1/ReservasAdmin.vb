''' <summary>
''' Clase encargada de gestionar las reservas de habitaciones
''' </summary>
''' <remarks></remarks>
Public Class ReservasAdmin

    Shared instance As ReservasAdmin
    Dim colReservas As Hashtable

    Private Sub New()
        colReservas = New Hashtable
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
            colReservas.Remove(objR.Id)
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
        For Each objR As Reserva In colReservas
            If (nroResMax < objR.Id) Then
                nroResMax = objR.Id
            End If
        Next
        Return nroResMax + 1
    End Function

    Public Function devolverReservas() As Hashtable
        Return colReservas
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
    Public Function VerificarHabitacionesDisponibles(ByVal fecha_inicio As Date, ByVal fecha_fin As Date) As ArrayList
        Dim colhab As ArrayList = Hotel.GetInstance.DevolverHabitacionPorTipo("Todo")
        For Each objR As Reserva In colReservas.Values
            If (Not objR.CheckOut < fecha_inicio Or Not objR.CheckIn > fecha_fin) Then
                For Each objhab As Habitacion In colhab
                    If Not objhab.Numero = objR.Habitacion.Numero Then
                        colhab.Remove(objhab.Numero)
                    End If
                Next
            End If
        Next
        Return colhab
    End Function
End Class
