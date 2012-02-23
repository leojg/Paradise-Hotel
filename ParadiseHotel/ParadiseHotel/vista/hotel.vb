Public Class Hotel
    Private Sub Hotel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cbox_tipo_id.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_habitaciones.Click
        Dim f = New Man_habitacion()
        f.ShowDialog()
    End Sub
End Class