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

    'Public Function CargarReporte() As
    '    Dim sqlConn As OleDbConnection
    '    Dim sqlDaHab As OleDbDataAdapter
    '    Dim sqlDaDen As OleDbDataAdapter
    '    Dim sqlDaTipo As OleDbDataAdapter
    '    Dim dsMetraje As New DataSet 'dsprodxcat


    '    Dim datoConexion As String = "Provider = Microsoft.jet.oledb.4.0; Data Source = .\BDHotelParaiso.mdb"

    '    Dim StrCommHab As String = "Select * From Habitaciones"
    '    Dim strCommDen As String = "Select * From DenominacionesSuites"
    '    Dim strCommTipo As String = "Select * From TiposHabitacion"


    '    sqlConn = New OleDbConnection(datoConexion)
    '    sqlDaHab = New OleDbDataAdapter(StrCommHab, sqlConn)
    '    sqlDaDen = New OleDbDataAdapter(strCommDen, sqlConn)
    '    sqlDaTipo = New OleDbDataAdapter(strCommTipo, sqlConn)

    '    sqlDaHab.Fill(dsMetraje, "Habitaciones")
    '    sqlDaDen.Fill(dsMetraje, "DenominacionesSuites")
    '    sqlDaTipo.Fill(dsMetraje, "TiposHabitacion")

    '    'Dim info As New CrystalReportPrueba
    '    'info.SetDataSource(dsMetraje)
    '    'crvPruebaHab.ReportSource = info
    '    'Me.crvPruebaHab.RefreshReport()

    'End Function
End Class
