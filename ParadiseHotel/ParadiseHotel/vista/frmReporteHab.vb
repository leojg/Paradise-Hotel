Imports Dominio
Public Class frmReporteHab
    ''' <summary>
    ''' Formulario que muestra el reporte para imprimir las habitaciones
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub crvHab_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles crvHab.Load
        Lib_util.cargar_reporte(Fachada.cargarReporte, Me.crvHab)
    End Sub
End Class