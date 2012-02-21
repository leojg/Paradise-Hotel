Imports System.Data.OleDb
Imports Dominio
Public Class PersHotel
    Inherits Persistencia
    Public Overrides Sub eliminar(ByVal xobj As Object)
    End Sub
    Public Overrides Sub guardar(ByVal XObj As Object)
    End Sub
    Public Overrides Sub modificar(ByVal xobj As Object)
    End Sub

    Public Function ObtenerDataSetPisos() As DataSet
        abrirConexion()
        Me.objcomando = New OleDbCommand("SELECT * FROM Pisos", objconexion)
        objdataadapter = New OleDbDataAdapter(objcomando)
        Dim objdataset As New DataSet()
        objdataadapter.Fill(objdataset, "Pisos")
        objconexion.Close()
        Return objdataset
    End Function

    Public Function ObtenerDataSetHabitaciones() As DataSet
        abrirConexion()
        Me.objcomando = New OleDbCommand("SELECT * FROM Habitaciones", objconexion)
        objdataadapter = New OleDbDataAdapter(objcomando)
        Dim objdataset As New DataSet()
        objdataadapter.Fill(objdataset, "Habitaciones")
        objconexion.Close()
        Return objdataset
    End Function

End Class
