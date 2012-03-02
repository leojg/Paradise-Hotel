<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hotel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_habitaciones = New System.Windows.Forms.Button
        Me.btn_servicios = New System.Windows.Forms.Button
        Me.btn_huespedes = New System.Windows.Forms.Button
        Me.btn_check_in_out = New System.Windows.Forms.Button
        Me.gbox_habitaciones = New System.Windows.Forms.GroupBox
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.btn_reservar = New System.Windows.Forms.Button
        Me.tab_gral_habitaciones = New System.Windows.Forms.TabControl
        Me.tab_reservar = New System.Windows.Forms.TabPage
        Me.lview_habitaciones = New System.Windows.Forms.ListView
        Me.id = New System.Windows.Forms.ColumnHeader
        Me.mtrs2 = New System.Windows.Forms.ColumnHeader
        Me.categoria = New System.Windows.Forms.ColumnHeader
        Me.terraza = New System.Windows.Forms.ColumnHeader
        Me.costo = New System.Windows.Forms.ColumnHeader
        Me.lbl_aniadir_huepedes = New System.Windows.Forms.LinkLabel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btn_comprobar = New System.Windows.Forms.Button
        Me.dtp_checkout = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtp_checkin = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbox_tipo_id = New System.Windows.Forms.ComboBox
        Me.txt_id_cliente = New System.Windows.Forms.TextBox
        Me.lbl_id_cliente = New System.Windows.Forms.Label
        Me.lbl_filtro = New System.Windows.Forms.Label
        Me.cbox_filtro = New System.Windows.Forms.ComboBox
        Me.tab_admin_habitaciones = New System.Windows.Forms.TabPage
        Me.btn_eliminar_habitacion = New System.Windows.Forms.Button
        Me.btn_modificar_habitacion = New System.Windows.Forms.Button
        Me.link_nueva_hab = New System.Windows.Forms.LinkLabel
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.gbox_checkinout = New System.Windows.Forms.GroupBox
        Me.tab_control_check = New System.Windows.Forms.TabControl
        Me.tab_control = New System.Windows.Forms.TabPage
        Me.checkbox_reservas = New System.Windows.Forms.CheckBox
        Me.gbox_accion = New System.Windows.Forms.GroupBox
        Me.rbtn_checkout = New System.Windows.Forms.RadioButton
        Me.rbtn_checkin = New System.Windows.Forms.RadioButton
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.ListView2 = New System.Windows.Forms.ListView
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.gbox_servicios = New System.Windows.Forms.GroupBox
        Me.tab_mostrar_servicios = New System.Windows.Forms.TabControl
        Me.tabpage_servicios = New System.Windows.Forms.TabPage
        Me.lview_servicios = New System.Windows.Forms.ListView
        Me.numero = New System.Windows.Forms.ColumnHeader
        Me.nombre = New System.Windows.Forms.ColumnHeader
        Me.gbox_huespedes = New System.Windows.Forms.GroupBox
        Me.tab_huespedes = New System.Windows.Forms.TabControl
        Me.tabpage_huespedes = New System.Windows.Forms.TabPage
        Me.lview_huespedes = New System.Windows.Forms.ListView
        Me.num_doc = New System.Windows.Forms.ColumnHeader
        Me.nombres = New System.Windows.Forms.ColumnHeader
        Me.apellidos = New System.Windows.Forms.ColumnHeader
        Me.telefono = New System.Windows.Forms.ColumnHeader
        Me.domicilio = New System.Windows.Forms.ColumnHeader
        Me.num_habitacion = New System.Windows.Forms.ColumnHeader
        Me.btn_ver_reporte = New System.Windows.Forms.Button
        Me.gbox_habitaciones.SuspendLayout()
        Me.tab_gral_habitaciones.SuspendLayout()
        Me.tab_reservar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tab_admin_habitaciones.SuspendLayout()
        Me.gbox_checkinout.SuspendLayout()
        Me.tab_control_check.SuspendLayout()
        Me.tab_control.SuspendLayout()
        Me.gbox_accion.SuspendLayout()
        Me.gbox_servicios.SuspendLayout()
        Me.tab_mostrar_servicios.SuspendLayout()
        Me.tabpage_servicios.SuspendLayout()
        Me.gbox_huespedes.SuspendLayout()
        Me.tab_huespedes.SuspendLayout()
        Me.tabpage_huespedes.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_habitaciones
        '
        Me.btn_habitaciones.Location = New System.Drawing.Point(12, 12)
        Me.btn_habitaciones.Name = "btn_habitaciones"
        Me.btn_habitaciones.Size = New System.Drawing.Size(85, 23)
        Me.btn_habitaciones.TabIndex = 0
        Me.btn_habitaciones.Text = "Habitaciones"
        Me.btn_habitaciones.UseVisualStyleBackColor = True
        '
        'btn_servicios
        '
        Me.btn_servicios.Location = New System.Drawing.Point(103, 12)
        Me.btn_servicios.Name = "btn_servicios"
        Me.btn_servicios.Size = New System.Drawing.Size(75, 23)
        Me.btn_servicios.TabIndex = 7
        Me.btn_servicios.Text = "Servicios"
        Me.btn_servicios.UseVisualStyleBackColor = True
        '
        'btn_huespedes
        '
        Me.btn_huespedes.Location = New System.Drawing.Point(184, 12)
        Me.btn_huespedes.Name = "btn_huespedes"
        Me.btn_huespedes.Size = New System.Drawing.Size(75, 23)
        Me.btn_huespedes.TabIndex = 8
        Me.btn_huespedes.Text = "Huéspedes"
        Me.btn_huespedes.UseVisualStyleBackColor = True
        '
        'btn_check_in_out
        '
        Me.btn_check_in_out.Location = New System.Drawing.Point(265, 12)
        Me.btn_check_in_out.Name = "btn_check_in_out"
        Me.btn_check_in_out.Size = New System.Drawing.Size(92, 23)
        Me.btn_check_in_out.TabIndex = 9
        Me.btn_check_in_out.Text = "Check In/Out"
        Me.btn_check_in_out.UseVisualStyleBackColor = True
        '
        'gbox_habitaciones
        '
        Me.gbox_habitaciones.Controls.Add(Me.btn_cancelar)
        Me.gbox_habitaciones.Controls.Add(Me.btn_reservar)
        Me.gbox_habitaciones.Controls.Add(Me.tab_gral_habitaciones)
        Me.gbox_habitaciones.Location = New System.Drawing.Point(12, 377)
        Me.gbox_habitaciones.Name = "gbox_habitaciones"
        Me.gbox_habitaciones.Size = New System.Drawing.Size(685, 355)
        Me.gbox_habitaciones.TabIndex = 10
        Me.gbox_habitaciones.TabStop = False
        Me.gbox_habitaciones.Text = "Habitaciones"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(499, 323)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 13
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_reservar
        '
        Me.btn_reservar.Location = New System.Drawing.Point(600, 323)
        Me.btn_reservar.Name = "btn_reservar"
        Me.btn_reservar.Size = New System.Drawing.Size(75, 23)
        Me.btn_reservar.TabIndex = 12
        Me.btn_reservar.Text = "Reservar"
        Me.btn_reservar.UseVisualStyleBackColor = True
        '
        'tab_gral_habitaciones
        '
        Me.tab_gral_habitaciones.Controls.Add(Me.tab_reservar)
        Me.tab_gral_habitaciones.Controls.Add(Me.tab_admin_habitaciones)
        Me.tab_gral_habitaciones.Location = New System.Drawing.Point(6, 19)
        Me.tab_gral_habitaciones.Name = "tab_gral_habitaciones"
        Me.tab_gral_habitaciones.SelectedIndex = 0
        Me.tab_gral_habitaciones.Size = New System.Drawing.Size(673, 298)
        Me.tab_gral_habitaciones.TabIndex = 0
        '
        'tab_reservar
        '
        Me.tab_reservar.Controls.Add(Me.lview_habitaciones)
        Me.tab_reservar.Controls.Add(Me.lbl_aniadir_huepedes)
        Me.tab_reservar.Controls.Add(Me.Panel1)
        Me.tab_reservar.Controls.Add(Me.cbox_tipo_id)
        Me.tab_reservar.Controls.Add(Me.txt_id_cliente)
        Me.tab_reservar.Controls.Add(Me.lbl_id_cliente)
        Me.tab_reservar.Controls.Add(Me.lbl_filtro)
        Me.tab_reservar.Controls.Add(Me.cbox_filtro)
        Me.tab_reservar.Location = New System.Drawing.Point(4, 22)
        Me.tab_reservar.Name = "tab_reservar"
        Me.tab_reservar.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_reservar.Size = New System.Drawing.Size(665, 272)
        Me.tab_reservar.TabIndex = 0
        Me.tab_reservar.Text = "Reservar"
        Me.tab_reservar.UseVisualStyleBackColor = True
        '
        'lview_habitaciones
        '
        Me.lview_habitaciones.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.mtrs2, Me.categoria, Me.terraza, Me.costo})
        Me.lview_habitaciones.Enabled = False
        Me.lview_habitaciones.FullRowSelect = True
        Me.lview_habitaciones.GridLines = True
        Me.lview_habitaciones.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lview_habitaciones.HideSelection = False
        Me.lview_habitaciones.Location = New System.Drawing.Point(12, 100)
        Me.lview_habitaciones.Name = "lview_habitaciones"
        Me.lview_habitaciones.Size = New System.Drawing.Size(644, 135)
        Me.lview_habitaciones.TabIndex = 13
        Me.lview_habitaciones.UseCompatibleStateImageBehavior = False
        Me.lview_habitaciones.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.id.Tag = ""
        Me.id.Text = "Nro. Id."
        Me.id.Width = 96
        '
        'mtrs2
        '
        Me.mtrs2.Text = "Mtrs. 2"
        Me.mtrs2.Width = 62
        '
        'categoria
        '
        Me.categoria.Text = "Categoría"
        Me.categoria.Width = 115
        '
        'terraza
        '
        Me.terraza.Text = "Terraza"
        Me.terraza.Width = 49
        '
        'costo
        '
        Me.costo.Text = "Costo"
        Me.costo.Width = 56
        '
        'lbl_aniadir_huepedes
        '
        Me.lbl_aniadir_huepedes.AutoSize = True
        Me.lbl_aniadir_huepedes.Enabled = False
        Me.lbl_aniadir_huepedes.Location = New System.Drawing.Point(25, 248)
        Me.lbl_aniadir_huepedes.Name = "lbl_aniadir_huepedes"
        Me.lbl_aniadir_huepedes.Size = New System.Drawing.Size(92, 13)
        Me.lbl_aniadir_huepedes.TabIndex = 23
        Me.lbl_aniadir_huepedes.TabStop = True
        Me.lbl_aniadir_huepedes.Text = "Añadir huéspedes"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_comprobar)
        Me.Panel1.Controls.Add(Me.dtp_checkout)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.dtp_checkin)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(12, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(644, 52)
        Me.Panel1.TabIndex = 22
        '
        'btn_comprobar
        '
        Me.btn_comprobar.Location = New System.Drawing.Point(540, 11)
        Me.btn_comprobar.Name = "btn_comprobar"
        Me.btn_comprobar.Size = New System.Drawing.Size(75, 23)
        Me.btn_comprobar.TabIndex = 23
        Me.btn_comprobar.Text = "Comprobar"
        Me.btn_comprobar.UseVisualStyleBackColor = True
        '
        'dtp_checkout
        '
        Me.dtp_checkout.Location = New System.Drawing.Point(329, 14)
        Me.dtp_checkout.Name = "dtp_checkout"
        Me.dtp_checkout.Size = New System.Drawing.Size(169, 20)
        Me.dtp_checkout.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(265, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Check Out"
        '
        'dtp_checkin
        '
        Me.dtp_checkin.Location = New System.Drawing.Point(69, 15)
        Me.dtp_checkin.Name = "dtp_checkin"
        Me.dtp_checkin.Size = New System.Drawing.Size(169, 20)
        Me.dtp_checkin.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Check In"
        '
        'cbox_tipo_id
        '
        Me.cbox_tipo_id.FormattingEnabled = True
        Me.cbox_tipo_id.Items.AddRange(New Object() {"Cédula", "Pasaporte", "Nro. Usuario"})
        Me.cbox_tipo_id.Location = New System.Drawing.Point(328, 11)
        Me.cbox_tipo_id.Name = "cbox_tipo_id"
        Me.cbox_tipo_id.Size = New System.Drawing.Size(86, 21)
        Me.cbox_tipo_id.TabIndex = 18
        '
        'txt_id_cliente
        '
        Me.txt_id_cliente.Location = New System.Drawing.Point(137, 11)
        Me.txt_id_cliente.Name = "txt_id_cliente"
        Me.txt_id_cliente.Size = New System.Drawing.Size(169, 20)
        Me.txt_id_cliente.TabIndex = 17
        '
        'lbl_id_cliente
        '
        Me.lbl_id_cliente.AutoSize = True
        Me.lbl_id_cliente.Location = New System.Drawing.Point(9, 14)
        Me.lbl_id_cliente.Name = "lbl_id_cliente"
        Me.lbl_id_cliente.Size = New System.Drawing.Size(119, 13)
        Me.lbl_id_cliente.TabIndex = 16
        Me.lbl_id_cliente.Text = "Identificación de cliente"
        '
        'lbl_filtro
        '
        Me.lbl_filtro.AutoSize = True
        Me.lbl_filtro.Location = New System.Drawing.Point(437, 13)
        Me.lbl_filtro.Name = "lbl_filtro"
        Me.lbl_filtro.Size = New System.Drawing.Size(29, 13)
        Me.lbl_filtro.TabIndex = 15
        Me.lbl_filtro.Text = "Filtro"
        '
        'cbox_filtro
        '
        Me.cbox_filtro.FormattingEnabled = True
        Me.cbox_filtro.Location = New System.Drawing.Point(472, 10)
        Me.cbox_filtro.Name = "cbox_filtro"
        Me.cbox_filtro.Size = New System.Drawing.Size(184, 21)
        Me.cbox_filtro.TabIndex = 14
        '
        'tab_admin_habitaciones
        '
        Me.tab_admin_habitaciones.Controls.Add(Me.btn_eliminar_habitacion)
        Me.tab_admin_habitaciones.Controls.Add(Me.btn_modificar_habitacion)
        Me.tab_admin_habitaciones.Controls.Add(Me.link_nueva_hab)
        Me.tab_admin_habitaciones.Controls.Add(Me.ListView1)
        Me.tab_admin_habitaciones.Location = New System.Drawing.Point(4, 22)
        Me.tab_admin_habitaciones.Name = "tab_admin_habitaciones"
        Me.tab_admin_habitaciones.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_admin_habitaciones.Size = New System.Drawing.Size(665, 272)
        Me.tab_admin_habitaciones.TabIndex = 1
        Me.tab_admin_habitaciones.Text = "Administrar"
        Me.tab_admin_habitaciones.UseVisualStyleBackColor = True
        '
        'btn_eliminar_habitacion
        '
        Me.btn_eliminar_habitacion.Location = New System.Drawing.Point(136, 14)
        Me.btn_eliminar_habitacion.Name = "btn_eliminar_habitacion"
        Me.btn_eliminar_habitacion.Size = New System.Drawing.Size(93, 23)
        Me.btn_eliminar_habitacion.TabIndex = 17
        Me.btn_eliminar_habitacion.Text = "Eliminar"
        Me.btn_eliminar_habitacion.UseVisualStyleBackColor = True
        '
        'btn_modificar_habitacion
        '
        Me.btn_modificar_habitacion.Location = New System.Drawing.Point(6, 14)
        Me.btn_modificar_habitacion.Name = "btn_modificar_habitacion"
        Me.btn_modificar_habitacion.Size = New System.Drawing.Size(94, 23)
        Me.btn_modificar_habitacion.TabIndex = 16
        Me.btn_modificar_habitacion.Text = "Modificar"
        Me.btn_modificar_habitacion.UseVisualStyleBackColor = True
        '
        'link_nueva_hab
        '
        Me.link_nueva_hab.AutoSize = True
        Me.link_nueva_hab.Location = New System.Drawing.Point(559, 14)
        Me.link_nueva_hab.Name = "link_nueva_hab"
        Me.link_nueva_hab.Size = New System.Drawing.Size(91, 13)
        Me.link_nueva_hab.TabIndex = 15
        Me.link_nueva_hab.TabStop = True
        Me.link_nueva_hab.Text = "Nueva habitación"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(6, 49)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(644, 217)
        Me.ListView1.TabIndex = 14
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Tag = ""
        Me.ColumnHeader1.Text = "Nro. Id."
        Me.ColumnHeader1.Width = 96
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Mtrs. 2"
        Me.ColumnHeader2.Width = 62
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Categoría"
        Me.ColumnHeader3.Width = 115
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Terraza"
        Me.ColumnHeader4.Width = 49
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Costo"
        Me.ColumnHeader5.Width = 56
        '
        'gbox_checkinout
        '
        Me.gbox_checkinout.Controls.Add(Me.tab_control_check)
        Me.gbox_checkinout.Location = New System.Drawing.Point(12, 40)
        Me.gbox_checkinout.Name = "gbox_checkinout"
        Me.gbox_checkinout.Size = New System.Drawing.Size(685, 323)
        Me.gbox_checkinout.TabIndex = 11
        Me.gbox_checkinout.TabStop = False
        Me.gbox_checkinout.Text = "Check In/Out"
        '
        'tab_control_check
        '
        Me.tab_control_check.Controls.Add(Me.tab_control)
        Me.tab_control_check.Location = New System.Drawing.Point(6, 19)
        Me.tab_control_check.Name = "tab_control_check"
        Me.tab_control_check.SelectedIndex = 0
        Me.tab_control_check.Size = New System.Drawing.Size(673, 298)
        Me.tab_control_check.TabIndex = 0
        '
        'tab_control
        '
        Me.tab_control.Controls.Add(Me.checkbox_reservas)
        Me.tab_control.Controls.Add(Me.gbox_accion)
        Me.tab_control.Controls.Add(Me.ComboBox1)
        Me.tab_control.Controls.Add(Me.TextBox1)
        Me.tab_control.Controls.Add(Me.Label1)
        Me.tab_control.Controls.Add(Me.Label2)
        Me.tab_control.Controls.Add(Me.ComboBox2)
        Me.tab_control.Controls.Add(Me.ListView2)
        Me.tab_control.Location = New System.Drawing.Point(4, 22)
        Me.tab_control.Name = "tab_control"
        Me.tab_control.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_control.Size = New System.Drawing.Size(665, 272)
        Me.tab_control.TabIndex = 0
        Me.tab_control.Text = "Control"
        Me.tab_control.UseVisualStyleBackColor = True
        '
        'checkbox_reservas
        '
        Me.checkbox_reservas.AutoSize = True
        Me.checkbox_reservas.Location = New System.Drawing.Point(579, 79)
        Me.checkbox_reservas.Name = "checkbox_reservas"
        Me.checkbox_reservas.Size = New System.Drawing.Size(71, 17)
        Me.checkbox_reservas.TabIndex = 20
        Me.checkbox_reservas.Text = "Reservas"
        Me.checkbox_reservas.UseVisualStyleBackColor = True
        '
        'gbox_accion
        '
        Me.gbox_accion.Controls.Add(Me.rbtn_checkout)
        Me.gbox_accion.Controls.Add(Me.rbtn_checkin)
        Me.gbox_accion.Location = New System.Drawing.Point(12, 44)
        Me.gbox_accion.Name = "gbox_accion"
        Me.gbox_accion.Size = New System.Drawing.Size(402, 52)
        Me.gbox_accion.TabIndex = 19
        Me.gbox_accion.TabStop = False
        Me.gbox_accion.Text = "Acción"
        '
        'rbtn_checkout
        '
        Me.rbtn_checkout.AutoSize = True
        Me.rbtn_checkout.Location = New System.Drawing.Point(205, 19)
        Me.rbtn_checkout.Name = "rbtn_checkout"
        Me.rbtn_checkout.Size = New System.Drawing.Size(87, 17)
        Me.rbtn_checkout.TabIndex = 1
        Me.rbtn_checkout.TabStop = True
        Me.rbtn_checkout.Text = "CHECK OUT"
        Me.rbtn_checkout.UseVisualStyleBackColor = True
        '
        'rbtn_checkin
        '
        Me.rbtn_checkin.AutoSize = True
        Me.rbtn_checkin.Location = New System.Drawing.Point(69, 19)
        Me.rbtn_checkin.Name = "rbtn_checkin"
        Me.rbtn_checkin.Size = New System.Drawing.Size(75, 17)
        Me.rbtn_checkin.TabIndex = 0
        Me.rbtn_checkin.TabStop = True
        Me.rbtn_checkin.Text = "CHECK IN"
        Me.rbtn_checkin.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Cédula", "Pasaporte", "Nro. Usuario"})
        Me.ComboBox1.Location = New System.Drawing.Point(328, 11)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(86, 21)
        Me.ComboBox1.TabIndex = 18
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(137, 11)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(169, 20)
        Me.TextBox1.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Identificación de cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(437, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Filtro"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(472, 10)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(184, 21)
        Me.ComboBox2.TabIndex = 14
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.ListView2.GridLines = True
        Me.ListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView2.Location = New System.Drawing.Point(12, 102)
        Me.ListView2.MultiSelect = False
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(644, 160)
        Me.ListView2.TabIndex = 13
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Tag = ""
        Me.ColumnHeader6.Text = "Nro. Id."
        Me.ColumnHeader6.Width = 96
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Mtrs. 2"
        Me.ColumnHeader7.Width = 62
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Categoría"
        Me.ColumnHeader8.Width = 115
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Terraza"
        Me.ColumnHeader9.Width = 49
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Costo"
        Me.ColumnHeader10.Width = 56
        '
        'gbox_servicios
        '
        Me.gbox_servicios.Controls.Add(Me.tab_mostrar_servicios)
        Me.gbox_servicios.Location = New System.Drawing.Point(725, 377)
        Me.gbox_servicios.Name = "gbox_servicios"
        Me.gbox_servicios.Size = New System.Drawing.Size(685, 355)
        Me.gbox_servicios.TabIndex = 14
        Me.gbox_servicios.TabStop = False
        Me.gbox_servicios.Text = "Servicios"
        '
        'tab_mostrar_servicios
        '
        Me.tab_mostrar_servicios.Controls.Add(Me.tabpage_servicios)
        Me.tab_mostrar_servicios.Location = New System.Drawing.Point(6, 19)
        Me.tab_mostrar_servicios.Name = "tab_mostrar_servicios"
        Me.tab_mostrar_servicios.SelectedIndex = 0
        Me.tab_mostrar_servicios.Size = New System.Drawing.Size(673, 298)
        Me.tab_mostrar_servicios.TabIndex = 0
        '
        'tabpage_servicios
        '
        Me.tabpage_servicios.Controls.Add(Me.lview_servicios)
        Me.tabpage_servicios.Location = New System.Drawing.Point(4, 22)
        Me.tabpage_servicios.Name = "tabpage_servicios"
        Me.tabpage_servicios.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpage_servicios.Size = New System.Drawing.Size(665, 272)
        Me.tabpage_servicios.TabIndex = 0
        Me.tabpage_servicios.Text = "Servicios"
        Me.tabpage_servicios.UseVisualStyleBackColor = True
        '
        'lview_servicios
        '
        Me.lview_servicios.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.numero, Me.nombre})
        Me.lview_servicios.Location = New System.Drawing.Point(11, 14)
        Me.lview_servicios.Name = "lview_servicios"
        Me.lview_servicios.Size = New System.Drawing.Size(644, 247)
        Me.lview_servicios.TabIndex = 0
        Me.lview_servicios.UseCompatibleStateImageBehavior = False
        Me.lview_servicios.View = System.Windows.Forms.View.Details
        '
        'numero
        '
        Me.numero.DisplayIndex = 1
        Me.numero.Text = "Numero"
        '
        'nombre
        '
        Me.nombre.DisplayIndex = 0
        Me.nombre.Text = "Nombre"
        Me.nombre.Width = 126
        '
        'gbox_huespedes
        '
        Me.gbox_huespedes.Controls.Add(Me.tab_huespedes)
        Me.gbox_huespedes.Enabled = False
        Me.gbox_huespedes.Location = New System.Drawing.Point(725, 12)
        Me.gbox_huespedes.Name = "gbox_huespedes"
        Me.gbox_huespedes.Size = New System.Drawing.Size(685, 355)
        Me.gbox_huespedes.TabIndex = 15
        Me.gbox_huespedes.TabStop = False
        Me.gbox_huespedes.Text = "Huéspedes"
        '
        'tab_huespedes
        '
        Me.tab_huespedes.Controls.Add(Me.tabpage_huespedes)
        Me.tab_huespedes.Location = New System.Drawing.Point(6, 19)
        Me.tab_huespedes.Name = "tab_huespedes"
        Me.tab_huespedes.SelectedIndex = 0
        Me.tab_huespedes.Size = New System.Drawing.Size(673, 298)
        Me.tab_huespedes.TabIndex = 0
        '
        'tabpage_huespedes
        '
        Me.tabpage_huespedes.Controls.Add(Me.lview_huespedes)
        Me.tabpage_huespedes.Location = New System.Drawing.Point(4, 22)
        Me.tabpage_huespedes.Name = "tabpage_huespedes"
        Me.tabpage_huespedes.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpage_huespedes.Size = New System.Drawing.Size(665, 272)
        Me.tabpage_huespedes.TabIndex = 0
        Me.tabpage_huespedes.Text = "Listado"
        Me.tabpage_huespedes.UseVisualStyleBackColor = True
        '
        'lview_huespedes
        '
        Me.lview_huespedes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.num_doc, Me.nombres, Me.apellidos, Me.telefono, Me.domicilio, Me.num_habitacion})
        Me.lview_huespedes.FullRowSelect = True
        Me.lview_huespedes.Location = New System.Drawing.Point(11, 14)
        Me.lview_huespedes.MultiSelect = False
        Me.lview_huespedes.Name = "lview_huespedes"
        Me.lview_huespedes.Size = New System.Drawing.Size(644, 247)
        Me.lview_huespedes.TabIndex = 0
        Me.lview_huespedes.UseCompatibleStateImageBehavior = False
        Me.lview_huespedes.View = System.Windows.Forms.View.Details
        '
        'num_doc
        '
        Me.num_doc.Text = "Numero"
        Me.num_doc.Width = 108
        '
        'nombres
        '
        Me.nombres.Text = "Nombres"
        Me.nombres.Width = 100
        '
        'apellidos
        '
        Me.apellidos.Text = "Apellidos"
        Me.apellidos.Width = 95
        '
        'telefono
        '
        Me.telefono.Text = "Teléfono"
        Me.telefono.Width = 82
        '
        'domicilio
        '
        Me.domicilio.Text = "Domicilio"
        Me.domicilio.Width = 172
        '
        'num_habitacion
        '
        Me.num_habitacion.Text = "Habitacion"
        Me.num_habitacion.Width = 70
        '
        'btn_ver_reporte
        '
        Me.btn_ver_reporte.Location = New System.Drawing.Point(363, 12)
        Me.btn_ver_reporte.Name = "btn_ver_reporte"
        Me.btn_ver_reporte.Size = New System.Drawing.Size(92, 23)
        Me.btn_ver_reporte.TabIndex = 16
        Me.btn_ver_reporte.Text = "Ver Reporte"
        Me.btn_ver_reporte.UseVisualStyleBackColor = True
        '
        'Hotel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 732)
        Me.Controls.Add(Me.btn_ver_reporte)
        Me.Controls.Add(Me.gbox_servicios)
        Me.Controls.Add(Me.gbox_habitaciones)
        Me.Controls.Add(Me.gbox_huespedes)
        Me.Controls.Add(Me.btn_check_in_out)
        Me.Controls.Add(Me.btn_huespedes)
        Me.Controls.Add(Me.btn_servicios)
        Me.Controls.Add(Me.btn_habitaciones)
        Me.Controls.Add(Me.gbox_checkinout)
        Me.Name = "Hotel"
        Me.Text = "Main"
        Me.gbox_habitaciones.ResumeLayout(False)
        Me.tab_gral_habitaciones.ResumeLayout(False)
        Me.tab_reservar.ResumeLayout(False)
        Me.tab_reservar.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tab_admin_habitaciones.ResumeLayout(False)
        Me.tab_admin_habitaciones.PerformLayout()
        Me.gbox_checkinout.ResumeLayout(False)
        Me.tab_control_check.ResumeLayout(False)
        Me.tab_control.ResumeLayout(False)
        Me.tab_control.PerformLayout()
        Me.gbox_accion.ResumeLayout(False)
        Me.gbox_accion.PerformLayout()
        Me.gbox_servicios.ResumeLayout(False)
        Me.tab_mostrar_servicios.ResumeLayout(False)
        Me.tabpage_servicios.ResumeLayout(False)
        Me.gbox_huespedes.ResumeLayout(False)
        Me.tab_huespedes.ResumeLayout(False)
        Me.tabpage_huespedes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_habitaciones As System.Windows.Forms.Button
    Friend WithEvents btn_servicios As System.Windows.Forms.Button
    Friend WithEvents btn_huespedes As System.Windows.Forms.Button
    Friend WithEvents btn_check_in_out As System.Windows.Forms.Button
    Friend WithEvents gbox_habitaciones As System.Windows.Forms.GroupBox
    Friend WithEvents tab_gral_habitaciones As System.Windows.Forms.TabControl
    Friend WithEvents tab_reservar As System.Windows.Forms.TabPage
    Friend WithEvents cbox_tipo_id As System.Windows.Forms.ComboBox
    Friend WithEvents txt_id_cliente As System.Windows.Forms.TextBox
    Friend WithEvents lbl_id_cliente As System.Windows.Forms.Label
    Friend WithEvents lbl_filtro As System.Windows.Forms.Label
    Friend WithEvents cbox_filtro As System.Windows.Forms.ComboBox
    Friend WithEvents lview_habitaciones As System.Windows.Forms.ListView
    Friend WithEvents id As System.Windows.Forms.ColumnHeader
    Friend WithEvents mtrs2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents categoria As System.Windows.Forms.ColumnHeader
    Friend WithEvents terraza As System.Windows.Forms.ColumnHeader
    Friend WithEvents costo As System.Windows.Forms.ColumnHeader
    Friend WithEvents tab_admin_habitaciones As System.Windows.Forms.TabPage
    Friend WithEvents btn_modificar_habitacion As System.Windows.Forms.Button
    Friend WithEvents link_nueva_hab As System.Windows.Forms.LinkLabel
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btn_eliminar_habitacion As System.Windows.Forms.Button
    Friend WithEvents gbox_checkinout As System.Windows.Forms.GroupBox
    Friend WithEvents tab_control_check As System.Windows.Forms.TabControl
    Friend WithEvents tab_control As System.Windows.Forms.TabPage
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents gbox_accion As System.Windows.Forms.GroupBox
    Friend WithEvents rbtn_checkout As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_checkin As System.Windows.Forms.RadioButton
    Friend WithEvents checkbox_reservas As System.Windows.Forms.CheckBox
    Friend WithEvents btn_reservar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents gbox_servicios As System.Windows.Forms.GroupBox
    Friend WithEvents tab_mostrar_servicios As System.Windows.Forms.TabControl
    Friend WithEvents tabpage_servicios As System.Windows.Forms.TabPage
    Friend WithEvents lview_servicios As System.Windows.Forms.ListView
    Friend WithEvents nombre As System.Windows.Forms.ColumnHeader
    Friend WithEvents numero As System.Windows.Forms.ColumnHeader
    Friend WithEvents gbox_huespedes As System.Windows.Forms.GroupBox
    Friend WithEvents tab_huespedes As System.Windows.Forms.TabControl
    Friend WithEvents tabpage_huespedes As System.Windows.Forms.TabPage
    Friend WithEvents lview_huespedes As System.Windows.Forms.ListView
    Friend WithEvents num_doc As System.Windows.Forms.ColumnHeader
    Friend WithEvents nombres As System.Windows.Forms.ColumnHeader
    Friend WithEvents apellidos As System.Windows.Forms.ColumnHeader
    Friend WithEvents telefono As System.Windows.Forms.ColumnHeader
    Friend WithEvents domicilio As System.Windows.Forms.ColumnHeader
    Friend WithEvents num_habitacion As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_aniadir_huepedes As System.Windows.Forms.LinkLabel
    Friend WithEvents dtp_checkout As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtp_checkin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_comprobar As System.Windows.Forms.Button
    Friend WithEvents btn_ver_reporte As System.Windows.Forms.Button
End Class
