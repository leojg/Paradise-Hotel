Imports System.Windows.Forms.Form
Imports Dominio
Public Class man_piso
    Inherits ParadiseHotel.Mantenimiento
    Private Sub man_piso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lbl_titulo.Text = "Mantenimiento de piso"
        Me.lbl_descripcion.Text = "Informacion a definir"
    End Sub
End Class