Imports System.Data.OleDb
Imports Dominio
Public Class PersHabitacion
    Inherits Persistencia

    Private Function calcularTipoHab(ByVal hab As Habitacion) As Integer
        If hab.GetType.Name = "Individual" Then
            Return 1
        ElseIf hab.GetType.Name = "Doble" Then
            Return 2
        ElseIf hab.GetType.Name = "SuiteJr" Then
            Return 3
        ElseIf hab.GetType.Name = "SuiteSr" Then
            Return 4
        End If
    End Function



    Public Overrides Sub eliminar(ByVal xobj As Object)
        Dim objHab As Habitacion = CType(xobj, Habitacion)
        Dim tipo As Int16 = calcularTipoHab(objHab)
        abrirConexion()
        Dim objComando = New OleDbCommand("select * from Habitaciones where Numero =" & objHab.Numero, objconexion)
        Dim objDataAdapter = New OleDbDataAdapter(objComando)
        Dim objDataSet As New DataSet
        objDataAdapter.Fill(objDataSet, "Habitaciones")
        Dim constComando As New OleDbCommandBuilder(objDataAdapter)
        objDataAdapter.DeleteCommand = constComando.GetDeleteCommand
        cerrarConexion()
        Dim objFila As DataRow = objDataSet.Tables("Habitaciones").Rows(0)
        objFila.Delete()
        objDataAdapter.Update(objDataSet, "Habitaciones")
        If (tipo = 3) Then
            Dim objSuite As SuiteJr = objHab
            eliminarDenominacionSuite(objSuite.Numero, objSuite.Nombre)
        ElseIf tipo = 4 Then
            Dim objSuite As SuiteSr = objHab
            eliminarDenominacionSuite(objSuite.Numero, objSuite.Nombre)
        End If
    End Sub

    Public Sub eliminarDenominacionSuite(ByVal numeroSuite As Int16, ByVal nombreSuite As String)
        abrirConexion()
        objcomando = New OleDbCommand("Select * From DenominacionesSuites where NumeroSuite=" & numeroSuite, objconexion)
        objdataadapter = New OleDbDataAdapter(objcomando)
        Dim objdataSet As New DataSet()
        objdataadapter.Fill(objdataSet, "DenominacionesSuites")
        Dim constComando As New OleDbCommandBuilder(objdataadapter)
        objdataadapter.DeleteCommand = constComando.GetDeleteCommand
        cerrarConexion()
        Dim objFila As DataRow = objdataSet.Tables("DenominacionesSuites").Rows(0)
        objFila.Delete()
        objdataadapter.Update(objdataSet, "DenominacionesSuites")
    End Sub

    Public Overrides Sub guardar(ByVal XObj As Object)

        Dim objHab As Habitacion = CType(XObj, Habitacion)
        Dim tipo As Int16 = calcularTipoHab(objHab)
        abrirConexion()
        Dim objComando = New OleDbCommand("select * from Habitaciones", objconexion)
        Dim objDataAdapter = New OleDbDataAdapter(objComando)
        Dim objDataSet As New DataSet
        objDataAdapter.Fill(objDataSet, "Habitaciones")
        Dim constComando As New OleDbCommandBuilder(objDataAdapter)
        objDataAdapter.InsertCommand = constComando.GetInsertCommand
        Dim objFila As DataRow = objDataSet.Tables("Habitaciones").NewRow()
        objFila("Numero") = objHab.Numero
        objFila("NumeroPiso") = objHab.Piso
        objFila("CostoUnitario") = objHab.Costo
        objFila("MetrajeTotal") = objHab.Metraje
        objFila("IdTipoHabitacion") = tipo
        objDataSet.Tables("Habitaciones").Rows.Add(objFila)
        objDataAdapter.Update(objDataSet, "Habitaciones")
        If (tipo = 3) Then
            Dim objSuite As SuiteJr = objHab
            guardarNombreSuite(objSuite.Numero, objSuite.Nombre)
        ElseIf tipo = 4 Then
            Dim objSuite As SuiteSr = objHab
            guardarNombreSuite(objSuite.Numero, objSuite.Nombre)
        End If

    End Sub

    Private Sub guardarNombreSuite(ByVal numeroSuite As Int16, ByVal nombreSuite As String)
        Dim objComando = New OleDbCommand("select * from DenominacionesSuites", objconexion)
        Dim objDataAdapter = New OleDbDataAdapter(objComando)
        Dim objDataSet As New DataSet
        objDataAdapter.Fill(objDataSet, "DenominacionesSuites")
        Dim constComando As New OleDbCommandBuilder(objDataAdapter)
        objDataAdapter.InsertCommand = constComando.GetInsertCommand
        Dim objFila As DataRow = objDataSet.Tables("DenominacionesSuites").NewRow()
        objFila("NumeroSuite") = numeroSuite
        objFila("Denominacion") = nombreSuite
        objDataSet.Tables("DenominacionesSuites").Rows.Add(objFila)
        objDataAdapter.Update(objDataSet, "DenominacionesSuites")
    End Sub

    Public Overrides Sub modificar(ByVal xobj As Object)
        Dim objHab As Habitacion = CType(xobj, Habitacion)
        abrirConexion()
        objcomando = New OleDbCommand("Select * From Habitaciones where Numero=" & objHab.Numero, objconexion)
        objdataadapter = New OleDbDataAdapter(objcomando)
        Dim objdataSet As New DataSet()
        objdataadapter.Fill(objdataSet, "Habitaciones")
        Dim contcomandos As New OleDbCommandBuilder(objdataadapter)
        objdataadapter.UpdateCommand() = contcomandos.GetUpdateCommand()
        cerrarConexion()
        Dim objFila As DataRow = objdataSet.Tables("Habitaciones").Rows.Item(0)
        objFila.BeginEdit()
        objFila("Numero") = objHab.Numero
        objFila("NumeroPiso") = objHab.Piso
        objFila("CostoUnitario") = objHab.Costo
        If objHab.GetType.Name = "Suite Jr" Then
            objHab = CType(objHab, SuiteJr)
            modificarDenominacionSuite(objHab.Numero, CType(objHab, SuiteJr).Nombre)
        ElseIf objHab.GetType.Name = "Suite Sr" Then
            objHab = CType(objHab, SuiteSr)
            modificarDenominacionSuite(objHab.Numero, CType(objHab, SuiteSr).Nombre)
        End If
        objFila.EndEdit()
        objdataadapter.Update(objdataSet, "Habitaciones")
    End Sub

    Public Sub modificarDenominacionSuite(ByVal numeroSuite As Int16, ByVal nombreSuite As String)
        abrirConexion()
        objcomando = New OleDbCommand("Select * From DenominacionesSuites where NumeroSuite=" & numeroSuite, objconexion)
        objdataadapter = New OleDbDataAdapter(objcomando)
        Dim objdataSet As New DataSet()
        objdataadapter.Fill(objdataSet, "DenominacionesSuites")
        Dim contcomandos As New OleDbCommandBuilder(objdataadapter)
        objdataadapter.UpdateCommand() = contcomandos.GetUpdateCommand()
        cerrarConexion()
        Dim objFila As DataRow = objdataSet.Tables("DenominacionesSuites").Rows.Item(0)
        objFila.BeginEdit()
        objFila("Numero") = nombreSuite
        objFila.EndEdit()
        objdataadapter.Update(objdataSet, "DenominacionesSuites")
    End Sub

End Class
