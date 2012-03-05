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

    Public Function ObtenerDataSetHuespedes() As DataSet
        abrirConexion()
        Me.objcomando = New OleDbCommand("SELECT * FROM Pasajeros", objconexion)
        objdataadapter = New OleDbDataAdapter(objcomando)
        Dim objdataset As New DataSet()
        objdataadapter.Fill(objdataset, "Pasajeros")
        objconexion.Close()
        Return objdataset
    End Function

    Public Function ObtenerDataSetExtranjeros() As DataSet
        abrirConexion()
        Me.objcomando = New OleDbCommand("SELECT * FROM Extranjeros", objconexion)
        objdataadapter = New OleDbDataAdapter(objcomando)
        Dim objdataset As New DataSet()
        objdataadapter.Fill(objdataset, "Extranjeros")
        objconexion.Close()
        Return objdataset
    End Function

    Public Function ObtenerDataSetPisos() As DataSet
        abrirConexion()
        Me.objcomando = New OleDbCommand("SELECT * FROM Pisos", objconexion)
        objdataadapter = New OleDbDataAdapter(objcomando)
        Dim objdataset As New DataSet()
        objdataadapter.Fill(objdataset, "Pisos")
        objconexion.Close()
        Return objdataset
    End Function

    Public Function ObtenerDataSetServicios() As DataSet
        abrirConexion()
        Me.objcomando = New OleDbCommand("SELECT * FROM Servicios", objconexion)
        objdataadapter = New OleDbDataAdapter(objcomando)
        Dim objdataset As New DataSet()
        objdataadapter.Fill(objdataset, "Servicios")
        objconexion.Close()
        Return objdataset
    End Function

    Public Function ObtenerDataSetReservas() As DataSet
        abrirConexion()
        Me.objcomando = New OleDbCommand("SELECT * FROM Reservas where MontoReembolsado=" & -1, objconexion)
        objdataadapter = New OleDbDataAdapter(objcomando)
        Dim objdataset As New DataSet()
        objdataadapter.Fill(objdataset, "Reservas")
        objconexion.Close()
        Return objdataset
    End Function

    Public Function ObtenerDataSetReservasHuespedes() As DataSet
        abrirConexion()
        Me.objcomando = New OleDbCommand("SELECT * FROM ReservasHuespedes", objconexion)
        objdataadapter = New OleDbDataAdapter(objcomando)
        Dim objdataset As New DataSet()
        objdataadapter.Fill(objdataset, "ReservasHuespedes")
        objconexion.Close()
        Return objdataset
    End Function

    Public Function cargarReporte() As DataSet
        abrirConexion()

        Dim sqlDaHab As OleDbDataAdapter
        Dim sqlDaDen As OleDbDataAdapter
        Dim sqlDaTipo As OleDbDataAdapter
        Dim dsMetraje As New DataSet 'dsprodxcat

        Dim StrCommHab = New OleDbCommand("Select * From Habitaciones", objconexion)
        Dim strCommDen = New OleDbCommand("Select * From DenominacionesSuites", objconexion)
        Dim strCommTipo = New OleDbCommand("Select * From TiposHabitacion", objconexion)

        sqlDaHab = New OleDbDataAdapter(StrCommHab)
        sqlDaDen = New OleDbDataAdapter(strCommDen)
        sqlDaTipo = New OleDbDataAdapter(strCommTipo)

        sqlDaHab.Fill(dsMetraje, "Habitaciones")
        sqlDaDen.Fill(dsMetraje, "DenominacionesSuites")
        sqlDaTipo.Fill(dsMetraje, "TiposHabitacion")

        Return dsMetraje

    End Function
End Class
