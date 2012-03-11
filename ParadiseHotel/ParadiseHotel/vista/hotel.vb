Imports Dominio
Public Class Hotel
    ''' <summary>
    ''' Formulario principal de la aplicación
    ''' </summary>
    ''' <remarks></remarks>
    Private _col_acompaniantes As New Hashtable
    Private _objH_titular As Huesped
    Private _auto_compl_col As New AutoCompleteStringCollection

    Private Sub Hotel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.relocate_controls()
        Dim arr As New ArrayList()
        arr.Add("Todo")
        arr.Add("SuiteJr")
        arr.Add("SuiteSr")
        arr.Add("Individual")
        arr.Add("Doble")
        Me.dtp_checkin.MinDate = Date.Now
        Me.dtp_checkout.MinDate = Date.Now
        Me.lbl_res_id.Text = Fachada.calcularNroReserva.ToString
        Lib_util.cargar_lview(Fachada.DevolverHabitacionPorTipo("Todo"), lview_hab_admin)
        Lib_util.cargar_cbox_categorias(arr, Me.cbox_filtro)
        'Lib_util.cargar_lview(Dominio.Fachada.DevolverHabitacionPorTipo(Me.cbox_filtro.Items.Item(0)), Me.lview_habitaciones)
        Lib_util.cargar_lview_servicios(lview_servicios, Fachada.devolverServicios)
        Lib_util.cargar_lview_huespedes(lview_huespedes, Fachada.devolverHuespedes)
        Lib_util.cargar_lview_reservas(lview_reservas, Fachada.devolverReservas)
        Me.cbox_filtro.SelectedIndex = 0
        Me.cbox_tipo_id.SelectedIndex = 0
        Me.hide_gboxs()
        Me.gbox_habitaciones.Visible = True
        'Me.btn_habitaciones.Select()
        '''''''No funca''''''''
        Me.tab_gral_habitaciones.SelectedTab = Me.tabpage_reservar
        Me.txt_id_cliente.Select()
        Me.txt_id_cliente.Focus()

        '*******AUTOCOMPLETADO MEJORADO*******'
        Me._auto_compl_col = Lib_util.crear_string_collection(Fachada.obtener_identificaciones())
        With Me.txt_id_cliente
            .AutoCompleteCustomSource = Me._auto_compl_col
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With

        With Me.txt_id_cli_checkinout
            .AutoCompleteCustomSource = Me._auto_compl_col
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With
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
        'MsgBox("hi")
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
        Me.checkbox_reservas.Checked = True
        Me.rbtn_checkin.Select()
    End Sub

    Private Sub link_nueva_hab_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles link_nueva_hab.LinkClicked
        Dim frm_nueva_habitación As Man_habitacion = New Man_habitacion()
        frm_nueva_habitación.ShowDialog()
    End Sub

    Private Sub btn_reservar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reservar.Click
        Try
            'If Me.panel_reservar_completo() Then
            If (Not _col_acompaniantes.Count = 0) Then
                Me._col_acompaniantes.Add(Me._objH_titular.Documento, Me._objH_titular)
            End If
            'la coleccion de acompaniantes y el titular se pasan separados, no juntos como aparece arriba
            For Each objO As ListViewItem In lview_habitaciones.SelectedItems
                If (Not objO.Tag Is Nothing) Then
                    Dim objH As Habitacion
                    objH = objO.Tag
                    Dominio.Fachada.altaReserva(Me._objH_titular, CInt(lbl_res_id.Text), objH, Me._col_acompaniantes, dtp_checkin.Value, dtp_checkout.Value)
                    'End If
                    MsgBox("Reserva Agregada Exitosamente.")
                    Me.lview_habitaciones.Enabled = False
                    Me.txt_id_cliente.Clear()
                    Me.cbox_filtro.Enabled = False
                    lbltot.Text = 0
                    lblAdelanto.Text = 0
                    lbldias.Text = 0
                End If
            Next
            _col_acompaniantes.Clear()
        Catch ex As NullReferenceException
            MsgBox("Uno de los campos está vacio. Ingrese datos para continuar")
        Catch ex As Exception
            MsgBox("Error Inesperado. Intente Nuevamente")
        End Try
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

    Private Sub cbox_filtro_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbox_filtro.SelectedIndexChanged
        Lib_util.cargar_lview(Dominio.Fachada.DevolverHabitacionPorTipo(Me.cbox_filtro.SelectedItem), Me.lview_habitaciones)
    End Sub

    Private Sub btn_comprobar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_comprobar.Click
        If Me.txt_id_cliente.Text = "" Then
            MsgBox("No ha ingresado un número de documento válido")
            Exit Sub
        End If

        Dim limpiar As Boolean = False

        If Lib_util.integridad_del_tiempo(Me.dtp_checkin, Me.dtp_checkout) = 3 Then
            Lib_util.cargar_lview(Dominio.Fachada.VerificarFechasDisponibles(Me.dtp_checkin.Value, Me.dtp_checkout.Value), Me.lview_habitaciones)
            Me.lview_habitaciones.Enabled = True
            Me.cbox_filtro.Enabled = True
        ElseIf Lib_util.integridad_del_tiempo(Me.dtp_checkin, Me.dtp_checkout) = 2 Then
            MsgBox("La fecha de Check out no puede ser hoy mismo")
            limpiar = True
        ElseIf Lib_util.integridad_del_tiempo(Me.dtp_checkin, Me.dtp_checkout) = 1 Then
            MsgBox("La fecha de check-out que has seleccionado es anterior a la de check-in")
            limpiar = True
        ElseIf Lib_util.integridad_del_tiempo(Me.dtp_checkin, Me.dtp_checkout) = 0 Then
            MsgBox("La fecha de check-in que has seleccionado es igual a la de check-out")
            limpiar = True
        End If

        If limpiar Then
            Me.dtp_checkin.Value = Date.Now
            Me.dtp_checkout.Value = Date.Now
        End If
    End Sub

    Private Sub txt_id_cliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_id_cliente.KeyPress
        If InStr(1, "0123456789()" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btn_cancelar_reserva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar_reserva.Click
        Me.limpiar_panel_reservas()
    End Sub

    Private Sub limpiar_panel_reservas()
        Me.txt_id_cliente.Text = ""
        Me.cbox_filtro.SelectedIndex = 0
        Me.cbox_tipo_id.SelectedIndex = 0
        Me.dtp_checkin.Value = Date.Now
        Me.dtp_checkout.Value = Date.Now
        Me.lview_habitaciones.Enabled = False
    End Sub

    Private Sub txt_id_cliente_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_id_cliente.LostFocus
        If Me.txt_id_cliente.Text <> "" Then
            Me._objH_titular = Fachada.devolverHuesped(CInt(Me.txt_id_cliente.Text))
        Else
            Fachada.devolverHuesped(-1)
        End If
    End Sub

    Private Sub btn_ir_a_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ir_a_imprimir.Click
        Dim frm_imprimir As imprimir = New imprimir
        frm_imprimir.ShowDialog()
    End Sub

    Private Sub lbl_aniadir_huepedes_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbl_aniadir_huepedes.LinkClicked
        If Me.txt_id_cliente.Text <> "" Then
            Dim frm_agregar_huespedes As agregar_huespedes = New agregar_huespedes(Lib_util.habitacion_del_listview(Me.lview_habitaciones), CInt(Me.txt_id_cliente.Text), Me)
            frm_agregar_huespedes.ShowDialog()
        Else
            MsgBox("Debe ingresar el número de documento del huesped responsable de la reserva")
        End If
    End Sub

    Private Sub btn_eliminar_habitacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar_habitacion.Click
        Try

            For Each obj As ListViewItem In Me.lview_hab_admin.SelectedItems
                If (obj.Tag.GetType.Name = "SuiteSr") Then
                    Dim objH As SuiteSr = obj.Tag
                    Fachada.bajaHabitacion(objH.Nombre, objH.Numero, objH.Piso, objH.Costo, 4)
                ElseIf (obj.Tag.GetType.Name = "SuiteJr") Then
                    Dim objH As SuiteJr = obj.Tag
                    Fachada.bajaHabitacion(objH.Nombre, objH.Numero, objH.Piso, objH.Costo, 3)
                ElseIf (obj.Tag.GetType.Name = "Doble") Then
                    Dim objH As Doble = obj.Tag
                    Fachada.bajaHabitacion("", objH.Numero, objH.Piso, objH.Costo, 2)
                ElseIf (obj.Tag.GetType.Name = "Individual") Then
                    Dim objH As Individual = obj.Tag
                    Fachada.bajaHabitacion("", objH.Numero, objH.Piso, objH.Costo, 1)
                End If
            Next
            Lib_util.cargar_lview(Fachada.DevolverHabitacionPorTipo("Todo"), lview_hab_admin)
            MsgBox("Habitacion Eliminada Correctamente")
        Catch ex As ExElementoNoSelecionado
            MsgBox(ex.Message)
        Catch ex As ExHabitacionNoEncontrada
            MsgBox(ex.Message)
        Catch ex As NullReferenceException
            MsgBox("Se ha seleccionado un elemento invalido. Vuelva a Intentarlo")
        Catch ex As ExHabitacionConReservas
            MsgBox(ex.Message)
        Catch ex As Exception
            MsgBox("Error Inesperado. Vuelva a intentar la operación")
        End Try
    End Sub

    Private Sub btn_modificar_habitacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar_habitacion.Click
        Try
            Dim frm As Man_habitacion
            Dim objH As Habitacion = Nothing
            For Each obj As ListViewItem In Me.lview_hab_admin.SelectedItems
                If (obj.Tag.GetType.Name = "SuiteSr") Then
                    objH = obj.Tag
                ElseIf (obj.Tag.GetType.Name = "SuiteJr") Then
                    objH = obj.Tag
                ElseIf (obj.Tag.GetType.Name = "Doble") Then
                    objH = obj.Tag
                ElseIf (obj.Tag.GetType.Name = "Individual") Then
                    objH = obj.Tag
                End If
            Next
            frm = New Man_habitacion(objH)
            frm.ShowDialog()
            Lib_util.cargar_lview(Fachada.DevolverHabitacionPorTipo("Todo"), lview_hab_admin)
        Catch ex As ExElementoNoSelecionado
            MsgBox(ex.Message)
        Catch ex As ExHabitacionNoEncontrada
            MsgBox(ex.Message)
        Catch ex As NullReferenceException
            MsgBox("Se ha seleccionado un elemento invalido. Vuelva a Intentarlo")
        Catch ex As Exception
            MsgBox("Error Inesperado. Vuelva a intentar la operación")
        End Try
    End Sub

    Public Sub depositar_acompaniantes(ByVal colAcomp As Hashtable)
        Me._col_acompaniantes = colAcomp
        Me.lbl_nro_acompaniantes.Text = CStr(Me._col_acompaniantes.Count())
    End Sub

    Private Sub btn_cancelar_reservado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar_reservado.Click
        Try
            For Each objR As ListViewItem In Me.lview_reservas.SelectedItems
                If (Not objR.Tag Is Nothing) Then
                    Dim objReserva As Dominio.Reserva
                    objReserva = CType(objR.Tag, Dominio.Reserva)
                    Dominio.Fachada.bajaReserva(objReserva.Id)
                    MsgBox("Reserva cancelada de forma exitosa")
                    Lib_util.cargar_lview_reservas(lview_reservas, Fachada.devolverReservas)
                    'End If
                End If
            Next
        Catch ex As Exception
            MsgBox("Error Inesperado")
        End Try
    End Sub

    Private Sub btn_cancelar_control_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar_control.Click
    End Sub



    Private Sub lview_habitaciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lview_habitaciones.SelectedIndexChanged
        For Each objI As ListViewItem In lview_habitaciones.SelectedItems
            Dim arr As ArrayList = Fachada.CalcularCostosReserva(Me.dtp_checkin.Value, Me.dtp_checkout.Value, CType(objI.Tag, Habitacion))
            lbltot.Text = arr(0)
            lblAdelanto.Text = arr(1)
            lbldias.Text = arr(2)
        Next
    End Sub

    Private Sub checkbox_reservas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkbox_reservas.CheckedChanged
        If Me.checkbox_reservas.Checked = False Then
            'Me.checkbox_reservas.CheckState = CheckState.Unchecked
            Lib_util.cambiar_list_view(Me.lview_reservas, "habitacion")
        ElseIf Me.checkbox_reservas.Checked = True Then
            'Me.checkbox_reservas.CheckState = CheckState.Checked
            Lib_util.cambiar_list_view(Me.lview_reservas, "reserva")
        End If
    End Sub
End Class