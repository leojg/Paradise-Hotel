
Public Class Hotel
    Dim nom As String
    Dim rut As Integer
    Dim dir As String
    Dim tel As Integer
    Dim gerente As String
    Dim estrellas As Byte
    Dim colPisos As Hashtable
    Dim colServicios As Hashtable
    Dim objPers As PersHotel
    Private Shared instance As Hotel

    Public Shared Function GetInstance() As Hotel
        If (instance Is Nothing) Then
            instance = New Hotel
        End If
        Return instance
    End Function

    Public Function AltaPiso(ByVal objP As Piso) As Boolean
        If Not colPisos.ContainsKey(objP.Numero) Then
            objP.guardame()
            colPisos.Add(objP.Numero, objP)
            Return True
        End If
        Return False
    End Function

    Public Function AltaHabitacion(ByVal objH As Habitacion) As Boolean
        Dim objP As Piso = DevolverPiso(objH.Piso)
        If (objH.GetType.Name = "SuiteJr" Or objH.GetType.Name = "SuiteSr") Then
            If (Me.controlarNombre(CType(objH, Suite))) Then
                Throw New ExNombreRepetido
            End If
            Return objP.AgregarHabitacion(objH)
        Else
            Return objP.AgregarHabitacion(objH)
        End If
    End Function


    Public Function BajaPiso(ByVal objP As Piso) As Boolean
        If colPisos.ContainsKey(objP.Numero) Then
            objP.eliminame()
            colPisos.Remove(objP)
            Return True
        End If
        Return False
    End Function

    Public Function CalcularNroHabitacion() As Integer
        Dim nroHabMax As Integer = 0
        For Each objp As Piso In colPisos.Values
            For Each objHab As Habitacion In objp.DevolverHabitaciones.Values
                If (nroHabMax < objHab.Numero) Then
                    nroHabMax = objHab.Numero
                End If
            Next
        Next
        Return nroHabMax + 1
    End Function

    Public Function DevolverPiso(ByVal num As Integer) As Piso
        For Each objP As Piso In colPisos.Values
            If (objP.Numero = num) Then
                Return (objP)
            End If
        Next
        Return Nothing
    End Function

    Public Function DevolverPisos() As Hashtable
        Return colPisos
    End Function

    Public Function DevolverServicios() As Hashtable
        Return colServicios
    End Function

    Public Function DevolverHabitacion(ByVal idhab As Integer) As Habitacion
        For Each objP As Piso In colPisos.Values
            For Each objH As Habitacion In objP.DevolverHabitaciones.Values
                If (objH.Numero = idhab) Then
                    Return objH
                End If
            Next
        Next
        Throw New ExHabitacionNoEncontrada
    End Function

    Public Function DevolverHabitacionPorTipo(ByVal tipo As String) As ArrayList
        Dim arr As New ArrayList
        For Each objP As Piso In colPisos.Values
            For Each objH As Habitacion In objP.DevolverHabitaciones.Values
                If (tipo = "Todo") Then
                    arr.Add(objH)
                Else
                    If (objH.GetType.Name = tipo) Then
                        arr.Add(objH)
                    End If
                End If
            Next
        Next
        Return arr
    End Function

    Public Function DevolverHabitacionPorTipo(ByVal colHab As Hashtable, ByVal tipo As String) As ArrayList
        Dim arr As New ArrayList
        For Each objH As Habitacion In colHab.Values
            If (tipo = "Todo") Then
                arr.Add(objH)
            Else
                If (objH.GetType.Name = tipo) Then
                    arr.Add(objH)
                End If
            End If
        Next
        Return arr
    End Function

    Public Function cargarReporte() As DataSet
        Return objPers.cargarReporte()
    End Function

    Private Function controlarNombre(ByVal objH As Suite) As Boolean
        For Each objP As Piso In colPisos.Values
            For Each objHab As Habitacion In objP.DevolverHabitaciones.Values
                If (objHab.GetType.Name = "SuiteJr" Or objHab.GetType.Name = "SuiteSr") Then
                    If objH.Nombre = CType(objHab, Suite).Nombre And Not objH.Numero = objHab.Numero Then
                        Return True
                    End If
                End If
            Next
        Next
        Return False
    End Function

    Public Function ModificarHabitacion(ByVal objH As Habitacion) As Boolean
        Dim objP As Piso = DevolverPiso(objH.Piso)
        If objH.GetType.Name = "SuiteSr" Or objH.GetType.Name = "SuiteJr" Then
            If (Not controlarNombre(CType(objH, Suite))) Then
                Return objP.ModificarHabitacion(objH)
            End If
            Throw New ExNombreRepetido
        End If
        Return objP.ModificarHabitacion(objH)
    End Function

    Public Function ModificarPiso(ByVal objP As Piso) As Boolean
        If colPisos.ContainsKey(objP.Numero) Then
            objP.modificame()
            colPisos.Remove(objP)
            colPisos.Add(objP.Numero, objP)
            Return True
        End If
        Return False
    End Function

    Public Sub ObtenerPisos()
        Dim objDataSet As DataSet = objPers.ObtenerDataSetPisos
        For Each objfila As DataRow In objDataSet.Tables("Pisos").Rows
            Dim objP As New Piso(CInt(objfila("NumeroPiso")), CInt(objfila("MetrajeMaximo")))
            colPisos.Add(objP.Numero, objP)
            objP.ObtenerHabitaciones()
        Next
    End Sub

    Public Sub ObtenerServicios()
        Dim objDataSet As DataSet = objPers.ObtenerDataSetServicios
        For Each objfila As DataRow In objDataSet.Tables("Servicios").Rows
            Dim objS As New Servicio(CInt(objfila("Id")), CStr(objfila("Nombre")))
            colServicios.Add(objS.Id, objS)
        Next
    End Sub

    Private Sub New()
        colPisos = New Hashtable
        colServicios = New Hashtable
        objPers = New PersHotel
    End Sub

End Class
