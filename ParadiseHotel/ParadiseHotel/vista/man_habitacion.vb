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
    End Sub

    Private Sub _Agregar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
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
        Fachada.altaHabitacion("", CInt(tx_num.Text), CShort(cbox_piso.SelectedItem), CShort(tx_costo.Text), tipoInt)
        cargarLbox(lb_hab, Fachada.devolverHabitacionesPiso(CShort(cbox_piso.SelectedItem)))
        Me.tx_num.Text = CStr(Fachada.calcularNroHabitacion)
    End Sub

    Private Sub _Modificar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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
        Fachada.modHabitacion("", CInt(tx_num.Text), CShort(cbox_piso.SelectedItem), CShort(tx_costo.Text), tipoInt)
        cargarLbox(lb_hab, Fachada.devolverHabitacionesPiso(CShort(cbox_piso.SelectedItem)))
        Me.tx_num.Text = CStr(Fachada.calcularNroHabitacion)
    End Sub

    Private Sub cbox_piso_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbox_piso.SelectedIndexChanged
        cargarLbox(lb_hab, Fachada.devolverHabitacionesPiso(CShort(cbox_piso.SelectedItem)))
    End Sub

    Private Sub _Eliminar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
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
        Fachada.bajaHabitacion("", CInt(tx_num.Text), CShort(cbox_piso.SelectedItem), CShort(tx_costo.Text), tipoInt)
        cargarLbox(lb_hab, Fachada.devolverHabitacionesPiso(CShort(cbox_piso.SelectedItem)))
        Me.tx_num.Text = CStr(Fachada.calcularNroHabitacion)
    End Sub
End Class