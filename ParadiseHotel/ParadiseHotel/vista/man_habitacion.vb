Imports System.Windows.Forms.Form
Imports Dominio

Public Class Man_habitacion
    Inherits ParadiseHotel.Mantenimiento
    Dim objH As Habitacion

    Public Sub New(ByVal objH As Habitacion)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.objH = objH
    End Sub

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub cargarLbox(ByVal lbx As ListBox, ByVal hash As Hashtable)
        lbx.Items.Clear()
        For Each objo In hash.Values
            lbx.Items.Add(objo)
        Next
    End Sub

    Private Sub Man_habitacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lbl_titulo.Text = "Mantenimiento de habitaciones"
        If (objH Is Nothing) Then
            Me.lbl_descripcion.Text = "Mantenimiento General"
            Me.tx_num.Text = CStr(Fachada.calcularNroHabitacion)
            For Each objp As Piso In Fachada.devolverPisos.Values
                cbox_piso.Items.Add(objp.Numero)
            Next
            Me.lbl_nombre_suite.Visible = False
            Me.tx_nom_suite.Visible = False
            Me.tx_costo.Visible = False
            Me.cbox_piso.Visible = False
            Me.btn_agregar.Enabled = False
            Me.lbl_costo.Visible = False
            Me.Piso.Visible = False
        Else
            Me.lbl_descripcion.Text = "Edición de Habitación"
            cbox_piso.Enabled = False
            Me.tx_num.Text = objH.Numero
            Me.tx_costo.Text = objH.Costo
            Me.cbox_piso.Items.Add(objH.Piso)
            cbox_piso.SelectedItem = objH.Piso
            Me.cbox_tipo.SelectedItem = objH.GetType.Name
            Me.btn_agregar.Visible = False
            Me.btn_eliminar.Visible = False
            Me.cbox_tipo.Enabled = False
            If (objH.GetType.Name = "SuiteJr" Or objH.GetType.Name = "SuiteSr") Then
                Me.tx_nom_suite.Text = CType(objH, Suite).Nombre
            End If
        End If

    End Sub

    Private Sub cbox_piso_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbox_piso.SelectedIndexChanged
        If (objH Is Nothing) Then


            cargarLbox(lb_hab, Fachada.devolverHabitacionesPiso(CShort(cbox_piso.SelectedItem)))
            lbl_metrajedispo.Visible = True
            Dim piso As Piso = Fachada.devolverPiso(CShort(cbox_piso.SelectedItem))
            lbl_metrajedispo.ForeColor = Color.Blue
            lbl_metrajedispo.Text = "Metraje Disponible en el piso: " & piso.MetrajeDisponible & " m2"
        End If
    End Sub

    Private Sub btn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar.Click
        Try
            Dim tipoStr = CStr(cbox_tipo.SelectedItem)
            Dim tipoInt
            If (tipoStr = GetType(Individual).Name) Then
                tipoInt = 1
            ElseIf (tipoStr = GetType(Doble).Name) Then
                tipoInt = 2
            ElseIf (tipoStr = GetType(SuiteJr).Name) Then
                tipoInt = 3
            ElseIf (tipoStr = GetType(SuiteSr).Name) Then
                tipoInt = 4
            End If
            Fachada.altaHabitacion(tx_nom_suite.Text, CInt(tx_num.Text), CShort(cbox_piso.SelectedItem), CShort(tx_costo.Text), tipoInt)
            cargarLbox(lb_hab, Fachada.devolverHabitacionesPiso(CShort(cbox_piso.SelectedItem)))
            Me.tx_num.Text = CStr(Fachada.calcularNroHabitacion)
            Dim piso As Piso = Fachada.devolverPiso(CShort(cbox_piso.SelectedItem))
            lbl_metrajedispo.Text = "Metraje Disponible en el piso: " & piso.MetrajeDisponible & " m2"
            MsgBox("Habitación Agregada")
        Catch ex As ExNombreRepetido
            MsgBox(ex.Message)
        Catch ex As ExMetrajeSuperado
            MsgBox(ex.Message)
        Catch ex As NullReferenceException
            If (cbox_piso.SelectedItem Is Nothing) Then
                MsgBox("El campo Piso está vacio")
            End If
        Catch ex As InvalidCastException
            If (tx_costo.Text = "") Then
                MsgBox("El campo Costo está vacio")
            End If
        Catch ex As Exception
            MsgBox("Error Inesperado. Intente Nuevamente")
        End Try
    End Sub

    Private Sub btn_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar.Click

        If (Me.tx_costo.Text = "" Or Me.tx_nom_suite.Text = "") Then
            MsgBox("Algunos campos están vacios. Ingrese datos para continuar")
            Return
        End If
        Try
            Dim tipoStr = CStr(cbox_tipo.SelectedItem)
            Dim tipoInt
            If (tipoStr = "Individual") Then
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
            lbl_metrajedispo.Text = "Metraje Disponible en el piso: " & piso.MetrajeDisponible & " m2"
            MsgBox("Suite Modificada con Exito")
        Catch ex As ExNombreRepetido
            MsgBox(ex.Message)
        Catch ex As ExMetrajeSuperado
            MsgBox(ex.Message)
        Catch ex As NullReferenceException
            MsgBox(ex.Message)
        Catch ex As Exception
            MsgBox("Error Inesperado. Intente Nuevamente")
        End Try
    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        Try
            Dim tipoStr = CStr(cbox_tipo.SelectedItem)
            Dim tipoInt
            If (tipoStr = "Individual") Then
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
            lbl_metrajedispo.Text = "Metraje Disponible en el piso: " & piso.MetrajeDisponible & " m2"
            MsgBox("Habitacion Eliminada Correctamente")
        Catch ex As ExNombreRepetido
            MsgBox(ex.Message)
        Catch ex As NullReferenceException
            MsgBox(ex.Message)
        Catch ex As ExHabitacionConReservas
            MsgBox(ex.Message)
        Catch ex As Exception
            MsgBox("Error Inesperado. Intente Nuevamente")
        End Try
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
        If (objH Is Nothing) Then
            Me.tx_costo.Visible = True
            Me.cbox_piso.Visible = True
            Me.btn_agregar.Enabled = True
            Me.lbl_costo.Visible = True
            Me.Piso.Visible = True
        End If
        If (Me.cbox_tipo.SelectedItem = "SuiteJr" Or Me.cbox_tipo.SelectedItem = "SuiteSr") Then
            Me.lbl_nombre_suite.Visible = True
            Me.tx_nom_suite.Visible = True
        Else
            Me.lbl_nombre_suite.Visible = False
            Me.tx_nom_suite.Visible = False
        End If
    End Sub
End Class