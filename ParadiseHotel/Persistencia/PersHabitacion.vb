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
        If (tipo = 3 Or tipo = 4) Then
            Dim objSuite As SuiteJr = objHab
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

    End Sub
End Class
