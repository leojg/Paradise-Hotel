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

    Private Sub link_nueva_hab_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles link_nueva_hab.LinkClicked
        Dim frm_nueva_habitación As Man_habitacion = New Man_habitacion()
        frm_nueva_habitación.ShowDialog()
    End Sub

    Private Sub btn_reservar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reservar.Click
        If Me.panel_reservar_completo() Then
            'Dominio.Fachada.altaReserva(Me.txt_id_cliente.Text, Me.lview_servicios.SelectedItems.Item, Me.dtp_checkin.Value, Me.dtp_checkout.Value)
        End If
    End Sub

    '*****************CONTROL DE DATOS*****************

    Private Function panel_reservar_completo() As Boolean
        Dim campos_faltantes As ArrayList = New ArrayList
        Dim hay_faltante = False
        If Not Me.txt_id_cliente.Text.Contains("") Then
            hay_faltante = True
            campos_faltantes.Add("identificar al cliente")
        End If
        If Me.lview_servicios.SelectedItems.Count < 1 Then
            hay_faltante = True
            campos_faltantes.Add("seleccionar una habitación")
        End If
        If DateDiff(DateInterval.Day, Me.dtp_checkin.Value, Date.Now) < 1 Then
            hay_faltante = True
            campos_faltantes.Add("la fecha de ingreso no puede ser anterior a la fecha actual")
        End If
        If DateDiff(DateInterval.Day, Me.dtp_checkout.Value, Date.Now) < 1 Then
            hay_faltante = True
            campos_faltantes.Add("la fecha de salida no puede ser anterior a la fecha actual")
        End If
        If DateDiff(DateInterval.Day, Me.dtp_checkin.Value, Me.dtp_checkout.Value) < 1 Then
            hay_faltante = True
            campos_faltantes.Add("la fecha de ingreso no puede ser anterior a la fecha de salida")
        End If
        If DateDiff(DateInterval.Day, Me.dtp_checkout.Value, Me.dtp_checkin.Value) < 1 Then
            hay_faltante = True
            campos_faltantes.Add("la fecha de salida no puede ser anterior a la fecha de entrada")
        End If

        If hay_faltante Then
            Dim mensaje = New String("")
            For i = 0 To campos_faltantes.Count
                If i < (campos_faltantes.Count - 2) Then
                    mensaje = mensaje & campos_faltantes.Item(i) & ", "
                Else
                    If i = campos_faltantes.Count Then
                        mensaje = mensaje & "."
                    Else
                        mensaje = mensaje & campos_faltantes.Item(i) & " y "
                    End If
                End If
            Next
            MsgBox("Cuidado: " & mensaje)
            Return False
        Else
            Return True
        End If
    End Function
End Class