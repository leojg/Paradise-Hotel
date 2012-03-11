<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Man_habitacion
    Inherits ParadiseHotel.Mantenimiento

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lview_habitaciones = New System.Windows.Forms.ListView
        Me.id = New System.Windows.Forms.ColumnHeader
        Me.mtrs2 = New System.Windows.Forms.ColumnHeader
        Me.categoria = New System.Windows.Forms.ColumnHeader
        Me.terraza = New System.Windows.Forms.ColumnHeader
        Me.costo = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.lbl_pesos = New System.Windows.Forms.Label
        Me.tx_nom_suite = New System.Windows.Forms.TextBox
        Me.lbl_nombre_suite = New System.Windows.Forms.Label
        Me.lbl_metrajedispo = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbox_tipo = New System.Windows.Forms.ComboBox
        Me.tx_num = New System.Windows.Forms.TextBox
        Me.Piso = New System.Windows.Forms.Label
        Me.cbox_piso = New System.Windows.Forms.ComboBox
        Me.tx_costo = New System.Windows.Forms.TextBox
        Me.lbl_costo = New System.Windows.Forms.Label
        Me.lbl_nro_habitacion = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btn_agregar
        '
        Me.btn_agregar.TabIndex = 7
        '
        'btn_modificar
        '
        Me.btn_modificar.TabIndex = 8
        '
        'btn_eliminar
        '
        Me.btn_eliminar.TabIndex = 9
        '
        'btn_cancelar
        '
        Me.btn_cancelar.TabIndex = 10
        '
        'lview_habitaciones
        '
        Me.lview_habitaciones.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.mtrs2, Me.categoria, Me.terraza, Me.costo, Me.ColumnHeader6})
        Me.lview_habitaciones.Enabled = False
        Me.lview_habitaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lview_habitaciones.FullRowSelect = True
        Me.lview_habitaciones.GridLines = True
        Me.lview_habitaciones.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lview_habitaciones.HideSelection = False
        Me.lview_habitaciones.Location = New System.Drawing.Point(10, 316)
        Me.lview_habitaciones.Name = "lview_habitaciones"
        Me.lview_habitaciones.Size = New System.Drawing.Size(430, 145)
        Me.lview_habitaciones.TabIndex = 33
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
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Nombre"
        '
        'lbl_pesos
        '
        Me.lbl_pesos.AutoSize = True
        Me.lbl_pesos.Location = New System.Drawing.Point(88, 120)
        Me.lbl_pesos.Name = "lbl_pesos"
        Me.lbl_pesos.Size = New System.Drawing.Size(26, 29)
        Me.lbl_pesos.TabIndex = 32
        Me.lbl_pesos.Text = "$"
        '
        'tx_nom_suite
        '
        Me.tx_nom_suite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_nom_suite.Location = New System.Drawing.Point(120, 165)
        Me.tx_nom_suite.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tx_nom_suite.Name = "tx_nom_suite"
        Me.tx_nom_suite.Size = New System.Drawing.Size(317, 22)
        Me.tx_nom_suite.TabIndex = 25
        '
        'lbl_nombre_suite
        '
        Me.lbl_nombre_suite.AutoSize = True
        Me.lbl_nombre_suite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre_suite.Location = New System.Drawing.Point(7, 168)
        Me.lbl_nombre_suite.Name = "lbl_nombre_suite"
        Me.lbl_nombre_suite.Size = New System.Drawing.Size(83, 15)
        Me.lbl_nombre_suite.TabIndex = 31
        Me.lbl_nombre_suite.Text = "Nombre Suite"
        '
        'lbl_metrajedispo
        '
        Me.lbl_metrajedispo.AutoSize = True
        Me.lbl_metrajedispo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_metrajedispo.Location = New System.Drawing.Point(8, 285)
        Me.lbl_metrajedispo.Name = "lbl_metrajedispo"
        Me.lbl_metrajedispo.Size = New System.Drawing.Size(111, 15)
        Me.lbl_metrajedispo.TabIndex = 30
        Me.lbl_metrajedispo.Text = "Metraje Disponible"
        Me.lbl_metrajedispo.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 15)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Tipo"
        '
        'cbox_tipo
        '
        Me.cbox_tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbox_tipo.FormattingEnabled = True
        Me.cbox_tipo.Items.AddRange(New Object() {"Individual", "Doble", "SuiteJr", "SuiteSr"})
        Me.cbox_tipo.Location = New System.Drawing.Point(120, 205)
        Me.cbox_tipo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbox_tipo.Name = "cbox_tipo"
        Me.cbox_tipo.Size = New System.Drawing.Size(317, 24)
        Me.cbox_tipo.TabIndex = 24
        '
        'tx_num
        '
        Me.tx_num.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_num.Location = New System.Drawing.Point(120, 88)
        Me.tx_num.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tx_num.Name = "tx_num"
        Me.tx_num.ReadOnly = True
        Me.tx_num.Size = New System.Drawing.Size(317, 22)
        Me.tx_num.TabIndex = 21
        '
        'Piso
        '
        Me.Piso.AutoSize = True
        Me.Piso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Piso.Location = New System.Drawing.Point(8, 248)
        Me.Piso.Name = "Piso"
        Me.Piso.Size = New System.Drawing.Size(31, 15)
        Me.Piso.TabIndex = 28
        Me.Piso.Text = "Piso"
        '
        'cbox_piso
        '
        Me.cbox_piso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbox_piso.FormattingEnabled = True
        Me.cbox_piso.Location = New System.Drawing.Point(120, 245)
        Me.cbox_piso.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbox_piso.Name = "cbox_piso"
        Me.cbox_piso.Size = New System.Drawing.Size(317, 24)
        Me.cbox_piso.TabIndex = 27
        '
        'tx_costo
        '
        Me.tx_costo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_costo.Location = New System.Drawing.Point(120, 127)
        Me.tx_costo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tx_costo.Name = "tx_costo"
        Me.tx_costo.Size = New System.Drawing.Size(317, 22)
        Me.tx_costo.TabIndex = 22
        '
        'lbl_costo
        '
        Me.lbl_costo.AutoSize = True
        Me.lbl_costo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_costo.Location = New System.Drawing.Point(8, 130)
        Me.lbl_costo.Name = "lbl_costo"
        Me.lbl_costo.Size = New System.Drawing.Size(77, 15)
        Me.lbl_costo.TabIndex = 26
        Me.lbl_costo.Text = "Costo/Noche"
        '
        'lbl_nro_habitacion
        '
        Me.lbl_nro_habitacion.AutoSize = True
        Me.lbl_nro_habitacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nro_habitacion.Location = New System.Drawing.Point(7, 91)
        Me.lbl_nro_habitacion.Name = "lbl_nro_habitacion"
        Me.lbl_nro_habitacion.Size = New System.Drawing.Size(52, 15)
        Me.lbl_nro_habitacion.TabIndex = 23
        Me.lbl_nro_habitacion.Text = "Número"
        '
        'Man_habitacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 548)
        Me.Controls.Add(Me.lview_habitaciones)
        Me.Controls.Add(Me.lbl_pesos)
        Me.Controls.Add(Me.tx_nom_suite)
        Me.Controls.Add(Me.lbl_nombre_suite)
        Me.Controls.Add(Me.lbl_metrajedispo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbox_tipo)
        Me.Controls.Add(Me.tx_num)
        Me.Controls.Add(Me.Piso)
        Me.Controls.Add(Me.cbox_piso)
        Me.Controls.Add(Me.tx_costo)
        Me.Controls.Add(Me.lbl_costo)
        Me.Controls.Add(Me.lbl_nro_habitacion)
        Me.Name = "Man_habitacion"
        Me.Text = "man_habitacion"
        Me.Controls.SetChildIndex(Me.lbl_nro_habitacion, 0)
        Me.Controls.SetChildIndex(Me.lbl_costo, 0)
        Me.Controls.SetChildIndex(Me.tx_costo, 0)
        Me.Controls.SetChildIndex(Me.cbox_piso, 0)
        Me.Controls.SetChildIndex(Me.Piso, 0)
        Me.Controls.SetChildIndex(Me.tx_num, 0)
        Me.Controls.SetChildIndex(Me.cbox_tipo, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.lbl_metrajedispo, 0)
        Me.Controls.SetChildIndex(Me.lbl_nombre_suite, 0)
        Me.Controls.SetChildIndex(Me.tx_nom_suite, 0)
        Me.Controls.SetChildIndex(Me.lbl_pesos, 0)
        Me.Controls.SetChildIndex(Me.lview_habitaciones, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lview_habitaciones As System.Windows.Forms.ListView
    Friend WithEvents id As System.Windows.Forms.ColumnHeader
    Friend WithEvents mtrs2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents categoria As System.Windows.Forms.ColumnHeader
    Friend WithEvents terraza As System.Windows.Forms.ColumnHeader
    Friend WithEvents costo As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbl_pesos As System.Windows.Forms.Label
    Friend WithEvents tx_nom_suite As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nombre_suite As System.Windows.Forms.Label
    Friend WithEvents lbl_metrajedispo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbox_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents tx_num As System.Windows.Forms.TextBox
    Friend WithEvents Piso As System.Windows.Forms.Label
    Friend WithEvents cbox_piso As System.Windows.Forms.ComboBox
    Friend WithEvents tx_costo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_costo As System.Windows.Forms.Label
    Friend WithEvents lbl_nro_habitacion As System.Windows.Forms.Label
End Class
