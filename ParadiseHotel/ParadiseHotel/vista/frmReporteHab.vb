Imports Dominio
Public Class frmReporteHab
    Private Sub crvHab_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles crvHab.Load
        Lib_util.cargar_reporte(Fachada.cargarReporte, Me.crvHab)
    End Sub
End Class