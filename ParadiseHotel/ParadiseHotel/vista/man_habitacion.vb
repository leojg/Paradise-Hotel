Imports System.Windows.Forms.Form
Imports Dominio

Public Class Man_habitacion
    Inherits ParadiseHotel.Mantenimiento

    Private Sub cargarLbox(ByVal lbx As ListBox, ByVal hash As Hashtable)
        lbx.Items.Clear()
        For Each objo In hash.Values
            lbx.Items.Add(objo)
        Next
    End Sub

    Private Sub Man_habitacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lbl_titulo.Text = "Mantenimiento de habitaciones"
        Me.lbl_descripcion.Text = "Informacion a definir"
        Me.tx_num.Text = CStr(Fachada.calcularNroHabitacion)
        For Each objp As Piso In Fachada.devolverPisos.Values
            cbox_piso.Items.Add(objp.Numero)
        Next
        Me.lbl_nombre_suite.Visible = False
        Me.tx_nom_suite.Visible = False

    End Sub

    Private Sub cbox_piso_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbox_piso.SelectedIndexChanged
        cargarLbox(lb_hab, Fachada.devolverHabitacionesPiso(CShort(cbox_piso.SelectedItem)))
        lbl_metrajedispo.Visible = True
        Dim piso As Piso = Fachada.devolverPiso(CShort(cbox_piso.SelectedItem))
        lbl_metrajedispo.ForeColor = Color.Blue
        lbl_metrajedispo.Text = "Metraje Disponible en el piso: " & piso.MetrajeDisponible & " m2"
    End Sub

    Private Sub btn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar.Click
        MsgBox("funca")
        Dim tipoStr = CStr(cbox_tipo.SelectedItem)
        Dim tipoInt
        If (tipoStr = "Indivudual") Then
            tipoInt = 1
        ElseIf (tipoStr = "Doble") Then
            tipoInt = 2
        ElseIf (tipoStr = "SuiteJr") Then
            tipoInt = 3
        ElseIf (tipoStr = "SuiteSr") Then
            tipoInt = 4
        End If
        Fachada.altaHabitacion(tx_nom_suite.Text, CInt(tx_num.Text), CShort(cbox_piso.SelectedItem), CShort(tx_costo.Text), tipoInt)
        cargarLbox(lb_hab, Fachada.devolverHabitacionesPiso(CShort(cbox_piso.SelectedItem)))
        Me.tx_num.Text = CStr(Fachada.calcularNroHabitacion)
        Dim piso As Piso = Fachada.devolverPiso(CShort(cbox_piso.SelectedItem))
        lbl_metrajedispo.Text = "Metraje Disponible en el piso: " & Piso.MetrajeDisponible & " m2"
    End Sub

    Private Sub btn_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar.Click
        MsgBox("funca")
        Dim tipoStr = CStr(cbox_tipo.SelectedItem)
        Dim tipoInt
        If (tipoStr = "Indivudual") Then
            tipoInt = 1
        ElseIf (tipoStr = "Doble") Then
            tipoInt = 2
        ElseIf (tipoStr = "SuiteJr") Then
            tipoInt = 3
        ElseIf (tipoStr = "SuiteSr") Then
            tipoInt = 4
        End If
        Fachada.modHabitacion(tx_nom_suite.Text, CInt(tx_num.Text), CShort(cbox_piso.SelectedItem), CShort(tx_costo.Text), tipoInt)
        cargarLbox(lb_hab, Fachada.devolverHabitacionesPiso(CShort(cbox_piso.SelectedItem)))
        Me.tx_num.Text = CStr(Fachada.calcularNroHabitacion)
        Dim piso As Piso = Fachada.devolverPiso(CShort(cbox_piso.SelectedItem))
        lbl_metrajedispo.Text = "Metraje Disponible en el piso: " & Piso.MetrajeDisponible & " m2"
    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        MsgBox("funca")
        Dim tipoStr = CStr(cbox_tipo.SelectedItem)
        Dim tipoInt
        If (tipoStr = "Indivudual") Then
            tipoInt = 1
        ElseIf (tipoStr = "Doble") Then
            tipoInt = 2
        ElseIf (tipoStr = "SuiteJr") Then
            tipoInt = 3
        ElseIf (tipoStr = "SuiteSr") Then
            tipoInt = 4
        End If
        Fachada.bajaHabitacion(tx_nom_suite.Text, CInt(tx_num.Text), CShort(cbox_piso.SelectedItem), CShort(tx_costo.Text), tipoInt)
        cargarLbox(lb_hab, Fachada.devolverHabitacionesPiso(CShort(cbox_piso.SelectedItem)))
        Me.tx_num.Text = CStr(Fachada.calcularNroHabitacion)
        Dim piso As Piso = Fachada.devolverPiso(CShort(cbox_piso.SelectedItem))
        lbl_metrajedispo.Text = "Metraje Disponible en el piso: " & Piso.MetrajeDisponible & " m2"
    End Sub

    Private Sub lb_hab_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lb_hab.SelectedIndexChanged
        Dim objh As Habitacion = CType(lb_hab.SelectedItem, Habitacion)
        Me.tx_num.Text = objh.Numero.ToString
        Me.tx_costo.Text = objh.Costo.ToString
        Me.cbox_piso.SelectedItem = objh.Piso
        Me.cbox_tipo.SelectedItem = objh.GetType.Name
        Me.cbox_tipo.Enabled = False
        If (objh.GetType.Name = "SuiteJr" Or objh.GetType.Name = "SuiteSr") Then
            Dim objsuite As Suite = CType(objh, Suite)
            Me.tx_nom_suite.Text = objsuite.Nombre
        End If

    End Sub

    Private Sub cbox_tipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbox_tipo.SelectedIndexChanged
        If (Me.cbox_tipo.SelectedItem = "SuiteJr" Or Me.cbox_tipo.SelectedItem = "SuiteSr") Then
            Me.lbl_nombre_suite.Visible = True
            Me.tx_nom_suite.Visible = True
        Else
            Me.lbl_nombre_suite.Visible = False
            Me.tx_nom_suite.Visible = False
        End If
    End Sub
End Class