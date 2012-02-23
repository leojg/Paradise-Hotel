Imports System.Data.OleDb
Imports Dominio
''' <summary>
''' Clase que brinda los servicios de persistencia a pisos y la obtencion desde la
''' base de datos de habitaciones.
''' </summary>
''' <remarks></remarks>
Public Class PersPiso
    Inherits Persistencia

    Public Overrides Sub eliminar(ByVal xobj As Object)
        Dim objP As Piso = CType(xobj, Piso)
        abrirConexion()
        Dim objComando = New OleDbCommand("select * from Pisos where NumeroPiso =" & objP.Numero, objconexion)
        Dim objDataAdapter = New OleDbDataAdapter(objComando)
        Dim objDataSet As New DataSet
        objDataAdapter.Fill(objDataSet, "Pisos")
        Dim constComando As New OleDbCommandBuilder(objDataAdapter)
        objDataAdapter.DeleteCommand = constComando.GetDeleteCommand
        cerrarConexion()
        Dim objFila As DataRow = objDataSet.Tables("Pisos").Rows(0)
        objFila.Delete()
        objDataAdapter.Update(objDataSet, "Pisos")
    End Sub

    Public Overrides Sub guardar(ByVal XObj As Object)
        Dim objP As Piso = CType(XObj, Piso)
        abrirConexion()
        Dim objComando = New OleDbCommand("select * from Pisos", objconexion)
        Dim objDataAdapter = New OleDbDataAdapter(objComando)
        Dim objDataSet As New DataSet
        objDataAdapter.Fill(objDataSet, "Pisos")
        Dim constComando As New OleDbCommandBuilder(objDataAdapter)
        objDataAdapter.InsertCommand = constComando.GetInsertCommand
        Dim objFila As DataRow = objDataSet.Tables("Pisos").NewRow()
        objFila("NumeroPiso") = objP.Numero
        objFila("MetrajeMaximo") = objP.Metraje
        objDataSet.Tables("Pisos").Rows.Add(objFila)
        objDataAdapter.Update(objDataSet, "Pisos")
    End Sub

    Public Overrides Sub modificar(ByVal xobj As Object)
        Dim objP As Piso = CType(xobj, Piso)
        abrirConexion()
        objcomando = New OleDbCommand("Select * From Pisos where NumeroPiso=" & objP.Numero, objconexion)
        objdataadapter = New OleDbDataAdapter(objcomando)
        Dim objdataSet As New DataSet()
        objdataadapter.Fill(objdataSet, "Pisos")
        Dim contcomandos As New OleDbCommandBuilder(objdataadapter)
        objdataadapter.UpdateCommand() = contcomandos.GetUpdateCommand()
        cerrarConexion()
        Dim objFila As DataRow = objdataSet.Tables("Pisos").Rows.Item(0)
        objFila.BeginEdit()
        objFila("NumeroPiso") = objP.Numero
        objFila("MetrajeMaximo") = objP.Metraje
        objFila.EndEdit()
        objdataadapter.Update(objdataSet, "Pisos")
    End Sub

    Public Function ObtenerDataSetHabitaciones() As DataSet
        abrirConexion()
        Me.objcomando = New OleDbCommand("SELECT * FROM Habitaciones", objconexion)
        objdataadapter = New OleDbDataAdapter(objcomando)
        Dim objdataset As New DataSet()
        objdataadapter.Fill(objdataset, "Habitaciones")
        objconexion.Close()
        Return objdataset
    End Function

    Public Function ObtenerDataNombresSuites() As DataSet
        abrirConexion()
        Me.objcomando = New OleDbCommand("SELECT * FROM DenominacionesSuites", objconexion)
        objdataadapter = New OleDbDataAdapter(objcomando)
        Dim objdataset As New DataSet()
        objdataadapter.Fill(objdataset, "DenominacionesSuites")
        objconexion.Close()
        Return objdataset
    End Function

End Class
