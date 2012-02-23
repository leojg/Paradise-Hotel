Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.OleDb
Public Class pruebaCR

    Private Sub pruebaCR_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim sqlConn As OleDbConnection
        Dim sqlDaHab As OleDbDataAdapter
        Dim sqlDaDen As OleDbDataAdapter
        Dim sqlDaTipo As OleDbDataAdapter
        Dim dsPc As New DataSet 'dsprodxcat


        Dim datoConexion As String = "Provider = Microsoft.jet.oledb.4.0; Data Source = .\BDHotelParaiso.mdb"

        Dim StrCommHab As String = "Select * From Habitaciones"
        Dim strCommDen As String = "Select * From DenominacionesSuites"
        Dim strCommTipo As String = "Select * From TiposHabitacion"

        Try
            sqlConn = New OleDbConnection(datoConexion)
            sqlDaHab = New OleDbDataAdapter(StrCommHab, sqlConn)
            sqlDaDen = New OleDbDataAdapter(strCommDen, sqlConn)
            sqlDaTipo = New OleDbDataAdapter(strCommTipo, sqlConn)

            sqlDaHab.Fill(dsPc, "Habitaciones")
            sqlDaDen.Fill(dsPc, "DenominacionesSuites")
            sqlDaTipo.Fill(dsPc, "TiposHabitacion")

            Dim info As New CrystalReportPrueba
            info.SetDataSource(dsPc)
            crvPruebaHab.ReportSource = info
            Me.crvPruebaHab.RefreshReport()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class