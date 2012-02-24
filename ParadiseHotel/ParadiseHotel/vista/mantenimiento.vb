Imports System.Windows.Forms.Form

Public Class Mantenimiento

    Public Event Agregar()
    Public Event Modificar()
    Public Event Eliminar()
    Public Event Cancelar()

    Private Sub Mantenimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lbl_titulo.BackColor = Color.Transparent
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        RaiseEvent Cancelar()
        Me.Close()
    End Sub

    Private Sub btn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar.Click
        RaiseEvent Agregar()
    End Sub

    Private Sub btn_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar.Click
        RaiseEvent Modificar()
    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        RaiseEvent Eliminar()
    End Sub
End Class