Imports System.Windows.Forms.Form
Imports Dominio

Public Class Man_habitacion
    Inherits ParadiseHotel.Mantenimiento
    ''' <summary>
    ''' Formulario para alta y modificacion (y eliminación) de habitaciones.
    ''' </summary>
    ''' <remarks></remarks>
    Dim objH As Habitacion
    Dim accion As String

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
        Me.tx_costo.TextAlign = HorizontalAlignment.Right
        Me.tx_num.TextAlign = HorizontalAlignment.Right
        Me.lbl_titulo.Text = "Mantenimiento de habitaciones"
        For Each objP As Piso In Fachada.devolverPisos.Values
            Me.cbox_piso.Items.Add(objP.Numero)
        Next
        If (objH Is Nothing) Then
            Me.accion = "alta"
            Me.maquetar_form(Me.accion)
            'Me.lbl_nombre_suite.Visible = False
            'Me.tx_nom_suite.Visible = False
            'Me.tx_costo.Visible = False
            'Me.cbox_piso.Visible = False
            'Me.btn_agregar.Enabled = False
            'Me.lbl_costo.Visible = False
            'Me.Piso.Visible = False
        Else
            Me.accion = "modificacion"
            Me.maquetar_form(Me.accion)
        End If
    End Sub

    Private Sub cbox_piso_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'If (objH Is Nothing) Then
        '    Lib_util.cargar_lview_hab_hash(Fachada.devolverHabitacionesPiso(CShort(cbox_piso.SelectedItem)), Me.lview_habitaciones)
        '    lbl_metrajedispo.Visible = True
        '    Dim piso As Piso = Fachada.devolverPiso(CShort(cbox_piso.SelectedItem))
        '    lbl_metrajedispo.ForeColor = Color.Blue
        '    lbl_metrajedispo.Text = "Metraje Disponible en el piso: " & piso.MetrajeDisponible & " m2"
        'End If
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
            Lib_util.cargar_lview_hab_hash(Fachada.devolverHabitacionesPiso(CShort(cbox_piso.SelectedItem)), Me.lview_habitaciones)
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
        If Me.accion = "alta" Then
            Me.accion = "modificacion"
            Me.maquetar_form(Me.accion)
            Me.lview_habitaciones.Enabled = True
        Else
            Dim tipoStr = CStr(cbox_tipo.SelectedItem)

            If Me.tx_costo.Text = "" Then
                MsgBox("Faltó el costo de la habitación, introdúzcalos para poder continuar")
                Return
            ElseIf Me.tx_nom_suite.Text = "" And (tipoStr = "SuiteJr" Or tipoStr = "SuiteSr") Then
                MsgBox("Faltó el nombre de la suite, introdúzcalos para poder continuar")
                Return
            End If
            Try
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
                Me.tx_num.Text = CStr(Fachada.calcularNroHabitacion)
                Dim piso As Piso = Fachada.devolverPiso(CShort(cbox_piso.SelectedItem))
                lbl_metrajedispo.Text = "Metraje Disponible en el piso: " & piso.MetrajeDisponible & " m2"
                MsgBox("Suite Modificada con Exito")
                Me.limpiar_campos()
            Catch ex As ExNombreRepetido
                MsgBox(ex.Message)
            Catch ex As ExMetrajeSuperado
                MsgBox(ex.Message)
            Catch ex As NullReferenceException
                MsgBox(ex.Message)
            Catch ex As Exception
                MsgBox("Error Inesperado. Intente Nuevamente")
            End Try
        End If
        Me.limpiar_campos()
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
            'cargarLbox(lb_hab, Fachada.devolverHabitacionesPiso(CShort(cbox_piso.SelectedItem)))
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

    Private Sub lb_hab_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim objh As Habitacion = Nothing
        For Each item As ListViewItem In Me.lview_habitaciones.SelectedItems
            If (Not item.Tag Is Nothing) Then
                objh = CType(item.Tag, Habitacion)
            End If
        Next
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

    Private Sub cbox_tipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
    Private Sub maquetar_form(ByVal accion As String)
        If accion = "modificacion" Then
            Me.lbl_descripcion.Text = "Edición de Habitación"
            cbox_piso.Enabled = False
            If Me.objH Is Nothing Then
                Lib_util.cargar_lview_hab_hash(Fachada.DevolverHabitacionPorTipo("Todo", "Hash"), Me.lview_habitaciones)
            Else
                Me.tx_num.Text = objH.Numero
                Me.tx_costo.Text = objH.Costo
                cbox_piso.SelectedItem = objH.Piso
                Me.cbox_tipo.SelectedItem = objH.GetType.Name
                If (objH.GetType.Name = "SuiteJr" Or objH.GetType.Name = "SuiteSr") Then
                    Me.tx_nom_suite.Visible = True
                    Me.lbl_nombre_suite.Visible = True
                    Me.tx_nom_suite.Text = CType(objH, Suite).Nombre
                End If
            End If
            Me.btn_agregar.Visible = False
            Me.btn_eliminar.Visible = False
            Me.cbox_tipo.Enabled = False
            Dim p = New Point(17, 15)
            Me.btn_modificar.Location = p
        Else
            Me.lbl_descripcion.Text = "Ingreso de nueva habitación"
            Me.tx_num.Text = CStr(Fachada.calcularNroHabitacion)
            For Each objp As Piso In Fachada.devolverPisos.Values
                cbox_piso.Items.Add(objp.Numero)
            Next
            Me.btn_eliminar.Enabled = False
        End If
    End Sub

    Private Sub limpiar_campos()
        Me.tx_costo.Text = ""
        Me.tx_nom_suite.Text = ""
        Me.tx_num.Text = ""
        Me.cbox_piso.SelectedIndex = 0
        Me.cbox_tipo.SelectedIndex = 0
    End Sub

    Private Sub lview_habitaciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lview_habitaciones.SelectedIndexChanged
        Me.limpiar_campos()
        Dim objH As Habitacion
        For Each item As ListViewItem In Me.lview_habitaciones.SelectedItems
            objH = CType(item.Tag, Habitacion)
            Me.tx_costo.Text = objH.Costo
            Me.tx_num.Text = objH.Numero
            Me.cbox_piso.SelectedItem = objH.Piso
            Me.cbox_tipo.SelectedItem = objH.GetType.Name
            If (objH.GetType.Name = "SuiteJr" Or objH.GetType.Name = "SuiteSr") Then
                Me.tx_nom_suite.Visible = True
                Me.lbl_nombre_suite.Visible = True
                Me.tx_nom_suite.Text = CType(objH, Suite).Nombre
            End If
        Next
    End Sub
End Class