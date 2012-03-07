Imports System.Data.OleDb
Imports Dominio
Public Class PersReserva
    Inherits Persistencia

    Public Sub cancelar(ByVal objR As Reserva)
        abrirConexion()
        objcomando = New OleDbCommand("Select * From Reservas where Id=" & objR.Id, objconexion)
        objdataadapter = New OleDbDataAdapter(objcomando)
        Dim objdataSet As New DataSet()
        objdataadapter.Fill(objdataSet, "Reservas")
        Dim contcomandos As New OleDbCommandBuilder(objdataadapter)
        objdataadapter.UpdateCommand() = contcomandos.GetUpdateCommand()
        cerrarConexion()
        Dim objFila As DataRow = objdataSet.Tables("Reservas").Rows.Item(0)
        objFila.BeginEdit()
        objFila("MontoReembolsado") = objR.Rembolso
        objFila.EndEdit()
        objdataadapter.Update(objdataSet, "Reservas")
        modificarReservasHuespedes(objR.devolverHuespedes, objR)
    End Sub

    Public Overrides Sub eliminar(ByVal xobj As Object)
        Dim objR As Reserva = CType(xobj, Reserva)
        abrirConexion()
        Dim objComando = New OleDbCommand("select * from Reservas where Id =" & objR.Id, objconexion)
        Dim objDataAdapter = New OleDbDataAdapter(objComando)
        Dim objDataSet As New DataSet
        objDataAdapter.Fill(objDataSet, "Reservas")
        Dim constComando As New OleDbCommandBuilder(objDataAdapter)
        objDataAdapter.DeleteCommand = constComando.GetDeleteCommand
        cerrarConexion()
        Dim objFila As DataRow = objDataSet.Tables("Reservas").Rows(0)
        objFila.Delete()
        objDataAdapter.Update(objDataSet, "Reservas")
        eliminarReservasHuespedes(objR.devolverHuespedes, objR)
    End Sub

    Public Sub eliminarReservasHuespedes(ByVal colHuespedes As Hashtable, ByVal objR As Reserva)

    End Sub

    Public Overrides Sub guardar(ByVal XObj As Object)
        Dim objR As Reserva = CType(XObj, Reserva)
        abrirConexion()
        Dim objComando = New OleDbCommand("select * from Reservas", objconexion)
        Dim objDataAdapter = New OleDbDataAdapter(objComando)
        Dim objDataSet As New DataSet
        objDataAdapter.Fill(objDataSet, "Reservas")
        Dim constComando As New OleDbCommandBuilder(objDataAdapter)
        objDataAdapter.InsertCommand = constComando.GetInsertCommand
        Dim objFila As DataRow = objDataSet.Tables("Reservas").NewRow()
        objFila("NumeroHabitacion") = objR.Habitacion.Numero
        objFila("FechaEntrada") = objR.CheckIn
        objFila("FechaSalida") = objR.CheckOut
        objFila("FechaRealizacion") = objR.fechaRealizacion
        objFila("MontoAdelantado") = objR.montoReserva
        objFila("MontoTotal") = objR.montoTotal
        objFila("FechaPagoSaldo") = objR.FechaPago
        objFila("MontoReembolsado") = objR.Rembolso
        objDataSet.Tables("Reservas").Rows.Add(objFila)
        objDataAdapter.Update(objDataSet, "Reservas")
        For Each objH As Huesped In objR.devolverHuespedes.Values
            guardarReservasHuespedes(objH, objR)
        Next
    End Sub

    Public Sub guardarReservasHuespedes(ByVal objH As Huesped, ByVal objR As Reserva)
        abrirConexion()
        Dim objComando = New OleDbCommand("select * from ReservasHuespedes", objconexion)
        Dim objDataAdapter = New OleDbDataAdapter(objComando)
        Dim objDataSet As New DataSet
        objDataAdapter.Fill(objDataSet, "ReservasHuespedes")
        Dim constComando As New OleDbCommandBuilder(objDataAdapter)
        objDataAdapter.InsertCommand = constComando.GetInsertCommand
        Dim objFila As DataRow = objDataSet.Tables("ReservasHuespedes").NewRow()
        objFila("pasajero_id") = objH.Documento.ToString
        objFila("reserva_id") = objR.Id
        If (objH.Documento = objR.Resposalbe.Documento) Then
            objFila("responsable") = True
        End If
        objDataSet.Tables("ReservasHuespedes").Rows.Add(objFila)
        objDataAdapter.Update(objDataSet, "ReservasHuespedes")
    End Sub

    Public Overrides Sub modificar(ByVal xobj As Object)
        Dim objR As Reserva = CType(xobj, Reserva)
        abrirConexion()
        objcomando = New OleDbCommand("Select * From Reservas where Id=" & objR.Id, objconexion)
        objdataadapter = New OleDbDataAdapter(objcomando)
        Dim objdataSet As New DataSet()
        objdataadapter.Fill(objdataSet, "Reservas")
        Dim contcomandos As New OleDbCommandBuilder(objdataadapter)
        objdataadapter.UpdateCommand() = contcomandos.GetUpdateCommand()
        cerrarConexion()
        Dim objFila As DataRow = objdataSet.Tables("Reservas").Rows.Item(0)
        objFila.BeginEdit()
        objFila("NumeroHabitacion") = objR.Habitacion.Numero
        objFila("FechaEntrada") = objR.CheckIn
        objFila("FechaSalida") = objR.CheckOut
        objFila("FechaRealizacion") = objR.fechaRealizacion
        objFila("MontoAdelantado") = objR.montoReserva
        objFila("MontoTotal") = objR.montoTotal
        objFila("FechaPagoSaldo") = objR.FechaPago
        objFila("MontoReembolsado") = objR.Rembolso
        objFila.EndEdit()
        objdataadapter.Update(objdataSet, "Reservas")
        modificarReservasHuespedes(objR.devolverHuespedes, objR)
    End Sub

    Public Sub modificarReservasHuespedes(ByVal colHuespedes As Hashtable, ByVal objR As Reserva)

    End Sub
End Class
