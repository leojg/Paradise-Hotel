Imports System.Windows.Forms.Form

Public Class Man_habitacion
    Inherits ParadiseHotel.Mantenimiento

    Private Sub Man_habitacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lbl_titulo.Text = "Ingresar una nueva habitación"
        Me.lbl_descripcion.Text = "Las habitaciones deben bla bla bla..."
    End Sub
End Class