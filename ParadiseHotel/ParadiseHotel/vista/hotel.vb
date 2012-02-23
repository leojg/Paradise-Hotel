Imports Dominio.Fachada
Public Class Hotel
    Private Sub Hotel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim arr As New ArrayList()
        arr.Add("Todo")
        arr.Add("SuiteJr")
        arr.Add("SuiteSr")
        arr.Add("Individual")
        arr.Add("Doble")
        Lib_util.cargar_cbox_categorias(arr, Me.cbox_filtro)
        Lib_util.cargar_lview(Dominio.Fachada.DevolverHabitacionPorTipo(Me.cbox_filtro.SelectedText), Me.lview_habitaciones)
        Me.cbox_filtro.SelectedIndex = 0
        Me.cbox_tipo_id.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_habitaciones.Click
        Dim f = New Man_habitacion()
        f.ShowDialog()
    End Sub
End Class