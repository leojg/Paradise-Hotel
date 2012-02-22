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
        Me.lview_habitaciones = New System.Windows.Forms.ListView
        Me.id = New System.Windows.Forms.ColumnHeader
        Me.mtrs2 = New System.Windows.Forms.ColumnHeader
        Me.categoria = New System.Windows.Forms.ColumnHeader
        Me.terraza = New System.Windows.Forms.ColumnHeader
        Me.costo = New System.Windows.Forms.ColumnHeader
        Me.cbox_filtro = New System.Windows.Forms.ComboBox
        Me.lbl_filtro = New System.Windows.Forms.Label
        Me.lbl_id_cliente = New System.Windows.Forms.Label
        Me.txt_id_cliente = New System.Windows.Forms.TextBox
        Me.cbox_tipo_id = New System.Windows.Forms.ComboBox
        Me.btn_servicios = New System.Windows.Forms.Button
        Me.btn_huespedes = New System.Windows.Forms.Button
        Me.btn_check_in_out = New System.Windows.Forms.Button
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
        'lview_habitaciones
        '
        Me.lview_habitaciones.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.mtrs2, Me.categoria, Me.terraza, Me.costo})
        Me.lview_habitaciones.GridLines = True
        Me.lview_habitaciones.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lview_habitaciones.Location = New System.Drawing.Point(12, 128)
        Me.lview_habitaciones.MultiSelect = False
        Me.lview_habitaciones.Name = "lview_habitaciones"
        Me.lview_habitaciones.Size = New System.Drawing.Size(644, 217)
        Me.lview_habitaciones.TabIndex = 1
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
        'cbox_filtro
        '
        Me.cbox_filtro.FormattingEnabled = True
        Me.cbox_filtro.Location = New System.Drawing.Point(472, 93)
        Me.cbox_filtro.Name = "cbox_filtro"
        Me.cbox_filtro.Size = New System.Drawing.Size(184, 21)
        Me.cbox_filtro.TabIndex = 2
        '
        'lbl_filtro
        '
        Me.lbl_filtro.AutoSize = True
        Me.lbl_filtro.Location = New System.Drawing.Point(437, 96)
        Me.lbl_filtro.Name = "lbl_filtro"
        Me.lbl_filtro.Size = New System.Drawing.Size(29, 13)
        Me.lbl_filtro.TabIndex = 3
        Me.lbl_filtro.Text = "Filtro"
        '
        'lbl_id_cliente
        '
        Me.lbl_id_cliente.AutoSize = True
        Me.lbl_id_cliente.Location = New System.Drawing.Point(9, 97)
        Me.lbl_id_cliente.Name = "lbl_id_cliente"
        Me.lbl_id_cliente.Size = New System.Drawing.Size(119, 13)
        Me.lbl_id_cliente.TabIndex = 4
        Me.lbl_id_cliente.Text = "Identificación de cliente"
        '
        'txt_id_cliente
        '
        Me.txt_id_cliente.Location = New System.Drawing.Point(137, 94)
        Me.txt_id_cliente.Name = "txt_id_cliente"
        Me.txt_id_cliente.Size = New System.Drawing.Size(169, 20)
        Me.txt_id_cliente.TabIndex = 5
        '
        'cbox_tipo_id
        '
        Me.cbox_tipo_id.FormattingEnabled = True
        Me.cbox_tipo_id.Items.AddRange(New Object() {"Cédula", "Pasaporte", "Nro. Usuario"})
        Me.cbox_tipo_id.Location = New System.Drawing.Point(328, 94)
        Me.cbox_tipo_id.Name = "cbox_tipo_id"
        Me.cbox_tipo_id.Size = New System.Drawing.Size(86, 21)
        Me.cbox_tipo_id.TabIndex = 6
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
        'Hotel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 376)
        Me.Controls.Add(Me.btn_check_in_out)
        Me.Controls.Add(Me.btn_huespedes)
        Me.Controls.Add(Me.btn_servicios)
        Me.Controls.Add(Me.cbox_tipo_id)
        Me.Controls.Add(Me.txt_id_cliente)
        Me.Controls.Add(Me.lbl_id_cliente)
        Me.Controls.Add(Me.lbl_filtro)
        Me.Controls.Add(Me.cbox_filtro)
        Me.Controls.Add(Me.lview_habitaciones)
        Me.Controls.Add(Me.btn_habitaciones)
        Me.Name = "Hotel"
        Me.Text = "Main"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_habitaciones As System.Windows.Forms.Button
    Friend WithEvents lview_habitaciones As System.Windows.Forms.ListView
    Friend WithEvents id As System.Windows.Forms.ColumnHeader
    Friend WithEvents mtrs2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents categoria As System.Windows.Forms.ColumnHeader
    Friend WithEvents terraza As System.Windows.Forms.ColumnHeader
    Friend WithEvents costo As System.Windows.Forms.ColumnHeader
    Friend WithEvents cbox_filtro As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_filtro As System.Windows.Forms.Label
    Friend WithEvents lbl_id_cliente As System.Windows.Forms.Label
    Friend WithEvents txt_id_cliente As System.Windows.Forms.TextBox
    Friend WithEvents cbox_tipo_id As System.Windows.Forms.ComboBox
    Friend WithEvents btn_servicios As System.Windows.Forms.Button
    Friend WithEvents btn_huespedes As System.Windows.Forms.Button
    Friend WithEvents btn_check_in_out As System.Windows.Forms.Button
End Class
