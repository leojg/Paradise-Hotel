Imports Dominio
Public Class Hotel
    Private Sub Hotel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.relocate_controls()
        Dim arr As New ArrayList()
        arr.Add("Todo")
        arr.Add("SuiteJr")
        arr.Add("SuiteSr")
        arr.Add("Individual")
        arr.Add("Doble")
        Lib_util.cargar_cbox_categorias(arr, Me.cbox_filtro)
        Lib_util.cargar_lview(Dominio.Fachada.DevolverHabitacionPorTipo(Me.cbox_filtro.Items.Item(0)), Me.lview_habitaciones)
        Lib_util.cargar_lview_servicios(lview_servicios, Fachada.devolverServicios)
        Me.cbox_filtro.SelectedIndex = 0
        Me.cbox_tipo_id.SelectedIndex = 0
        Me.hide_gboxs()
        Me.gbox_habitaciones.Visible = True
        Me.btn_habitaciones.Select()


    End Sub

    Private Sub hide_gboxs()
        Me.gbox_checkinout.Visible = False
        Me.gbox_habitaciones.Visible = False
        Me.gbox_huespedes.Visible = False
        Me.gbox_servicios.Visible = False
    End Sub

    Private Sub relocate_controls()
        Me.Size = New System.Drawing.Size(725, 444)
        Dim p = New Point(12, 40)
        Me.gbox_checkinout.Location = p
        Me.gbox_habitaciones.Location = p
        Me.gbox_huespedes.Location = p
        Me.gbox_servicios.Location = p
    End Sub

    Private Sub btn_habitaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_habitaciones.Click
        Me.hide_gboxs()
        Me.gbox_habitaciones.Visible = True
    End Sub

    Private Sub btn_servicios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_servicios.Click
        Me.hide_gboxs()
        Me.gbox_servicios.Visible = True
    End Sub

    Private Sub btn_huespedes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_huespedes.Click
        Me.hide_gboxs()
        Me.gbox_huespedes.Visible = True
    End Sub

    Private Sub btn_check_in_out_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_check_in_out.Click
        Me.hide_gboxs()
        Me.gbox_checkinout.Visible = True
    End Sub
End Class