Public Class ReservasAdmin

    Dim instance As ReservasAdmin
    Dim colReservas As Hashtable

    Private Sub New()
        colReservas = New Hashtable
    End Sub

    Public Function GetInstance() As ReservasAdmin
        If (instance Is Nothing) Then
            instance = New ReservasAdmin
        End If
        Return instance
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
    Public Function VerificarFechasDisponibles(ByVal fecha_inicio As Date, ByVal fecha_fin As Date) As Hashtable
        Dim colhab As ArrayList = Hotel.GetInstance.DevolverHabitacionPorTipo("Todo")
        Dim colhabhash As New Hashtable
        For Each objR As Reserva In colReservas.Values
            If (Not objR.CheckOut < fecha_inicio Or Not objR.CheckIn > fecha_fin) Then
                For Each objhab As Habitacion In colhab
                    If Not objhab.Numero = objR.Habitacion.Numero Then
                        colhabhash.Add(objhab.Numero, objhab)
                    End If
                Next
            End If
        Next
        Return colhabhash
    End Function

    Public Function devolverReservas() As Hashtable
        Return colReservas
    End Function

End Class
