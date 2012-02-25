Imports System.Windows.Forms.Form

Public Class Mantenimiento
    Private Sub Mantenimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lbl_titulo.BackColor = Color.Transparent
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
End Class