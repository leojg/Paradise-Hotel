Public Class imprimir
    ''' <summary>
    ''' Formulario para seleccionar que reporte se generará e imprimirá.
    ''' Por ahora solo funciona el reporte de habitaciones que era el solicitado
    ''' en los requerimientos del cliente.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub imprimir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.chkbox_imprimir_habitaciones.Checked = True
    End Sub

    Private Sub btn_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimir.Click
        Try

        If (Me.chkbox_imprimir_habitaciones.Checked = True) Then
                Dim frm As New frmReporteHab
                frm.Show()
            ElseIf Me.chkbox_imprimir_habitaciones.Checked = True Then
                MsgBox("no anda viteh")
            ElseIf Me.chkbox_imprimir_habitaciones.Checked = True Then
                MsgBox("no anda viteh")
            End If
        Catch ex As Dominio.ExNoExistenHabitaciones
            MsgBox(ex.Message)
        Catch ex As Exception
            MsgBox("Error Inesperado. Vuelva a intentar la operación")
        End Try

    End Sub
End Class