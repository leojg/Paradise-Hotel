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
        Me.lbl_nro_habitacion = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tx_costo = New System.Windows.Forms.TextBox
        Me.cbox_piso = New System.Windows.Forms.ComboBox
        Me.Piso = New System.Windows.Forms.Label
        Me.tx_num = New System.Windows.Forms.TextBox
        Me.lb_hab = New System.Windows.Forms.ListBox
        Me.cbox_tipo = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbl_metrajedispo = New System.Windows.Forms.Label
        Me.tx_nom_suite = New System.Windows.Forms.TextBox
        Me.lbl_nombre_suite = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btn_agregar
        '
        '
        'btn_modificar
        '
        '
        'btn_eliminar
        '
        '
        'lbl_nro_habitacion
        '
        Me.lbl_nro_habitacion.AutoSize = True
        Me.lbl_nro_habitacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nro_habitacion.Location = New System.Drawing.Point(18, 86)
        Me.lbl_nro_habitacion.Name = "lbl_nro_habitacion"
        Me.lbl_nro_habitacion.Size = New System.Drawing.Size(52, 15)
        Me.lbl_nro_habitacion.TabIndex = 3
        Me.lbl_nro_habitacion.Text = "Número"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(210, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Costo/Noche"
        '
        'tx_costo
        '
        Me.tx_costo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_costo.Location = New System.Drawing.Point(302, 83)
        Me.tx_costo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tx_costo.Name = "tx_costo"
        Me.tx_costo.Size = New System.Drawing.Size(99, 22)
        Me.tx_costo.TabIndex = 6
        '
        'cbox_piso
        '
        Me.cbox_piso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbox_piso.FormattingEnabled = True
        Me.cbox_piso.Location = New System.Drawing.Point(69, 167)
        Me.cbox_piso.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbox_piso.Name = "cbox_piso"
        Me.cbox_piso.Size = New System.Drawing.Size(124, 24)
        Me.cbox_piso.TabIndex = 7
        '
        'Piso
        '
        Me.Piso.AutoSize = True
        Me.Piso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Piso.Location = New System.Drawing.Point(19, 170)
        Me.Piso.Name = "Piso"
        Me.Piso.Size = New System.Drawing.Size(31, 15)
        Me.Piso.TabIndex = 8
        Me.Piso.Text = "Piso"
        '
        'tx_num
        '
        Me.tx_num.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_num.Location = New System.Drawing.Point(94, 83)
        Me.tx_num.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tx_num.Name = "tx_num"
        Me.tx_num.ReadOnly = True
        Me.tx_num.Size = New System.Drawing.Size(99, 22)
        Me.tx_num.TabIndex = 9
        '
        'lb_hab
        '
        Me.lb_hab.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_hab.FormattingEnabled = True
        Me.lb_hab.ItemHeight = 20
        Me.lb_hab.Location = New System.Drawing.Point(12, 296)
        Me.lb_hab.Name = "lb_hab"
        Me.lb_hab.Size = New System.Drawing.Size(429, 144)
        Me.lb_hab.TabIndex = 10
        '
        'cbox_tipo
        '
        Me.cbox_tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbox_tipo.FormattingEnabled = True
        Me.cbox_tipo.Items.AddRange(New Object() {"Individual", "Doble", "SuiteJr", "SuiteSrl"})
        Me.cbox_tipo.Location = New System.Drawing.Point(69, 124)
        Me.cbox_tipo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbox_tipo.Name = "cbox_tipo"
        Me.cbox_tipo.Size = New System.Drawing.Size(126, 24)
        Me.cbox_tipo.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 15)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Tipo"
        '
        'lbl_metrajedispo
        '
        Me.lbl_metrajedispo.AutoSize = True
        Me.lbl_metrajedispo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_metrajedispo.Location = New System.Drawing.Point(18, 205)
        Me.lbl_metrajedispo.Name = "lbl_metrajedispo"
        Me.lbl_metrajedispo.Size = New System.Drawing.Size(121, 16)
        Me.lbl_metrajedispo.TabIndex = 16
        Me.lbl_metrajedispo.Text = "Metraje Disponible"
        Me.lbl_metrajedispo.Visible = False
        '
        'tx_nom_suite
        '
        Me.tx_nom_suite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_nom_suite.Location = New System.Drawing.Point(302, 124)
        Me.tx_nom_suite.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tx_nom_suite.Name = "tx_nom_suite"
        Me.tx_nom_suite.Size = New System.Drawing.Size(99, 22)
        Me.tx_nom_suite.TabIndex = 18
        '
        'lbl_nombre_suite
        '
        Me.lbl_nombre_suite.AutoSize = True
        Me.lbl_nombre_suite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre_suite.Location = New System.Drawing.Point(210, 127)
        Me.lbl_nombre_suite.Name = "lbl_nombre_suite"
        Me.lbl_nombre_suite.Size = New System.Drawing.Size(83, 15)
        Me.lbl_nombre_suite.TabIndex = 17
        Me.lbl_nombre_suite.Text = "Nombre Suite"
        '
        'Man_habitacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 548)
        Me.Controls.Add(Me.tx_nom_suite)
        Me.Controls.Add(Me.lbl_nombre_suite)
        Me.Controls.Add(Me.lbl_metrajedispo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbox_tipo)
        Me.Controls.Add(Me.lb_hab)
        Me.Controls.Add(Me.tx_num)
        Me.Controls.Add(Me.Piso)
        Me.Controls.Add(Me.cbox_piso)
        Me.Controls.Add(Me.tx_costo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_nro_habitacion)
        Me.Name = "Man_habitacion"
        Me.Text = "man_habitacion"
        Me.Controls.SetChildIndex(Me.lbl_nro_habitacion, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.tx_costo, 0)
        Me.Controls.SetChildIndex(Me.cbox_piso, 0)
        Me.Controls.SetChildIndex(Me.Piso, 0)
        Me.Controls.SetChildIndex(Me.tx_num, 0)
        Me.Controls.SetChildIndex(Me.lb_hab, 0)
        Me.Controls.SetChildIndex(Me.cbox_tipo, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.lbl_metrajedispo, 0)
        Me.Controls.SetChildIndex(Me.lbl_nombre_suite, 0)
        Me.Controls.SetChildIndex(Me.tx_nom_suite, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_nro_habitacion As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tx_costo As System.Windows.Forms.TextBox
    Friend WithEvents cbox_piso As System.Windows.Forms.ComboBox
    Friend WithEvents Piso As System.Windows.Forms.Label
    Friend WithEvents tx_num As System.Windows.Forms.TextBox
    Friend WithEvents lb_hab As System.Windows.Forms.ListBox
    Friend WithEvents cbox_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_metrajedispo As System.Windows.Forms.Label
    Friend WithEvents tx_nom_suite As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nombre_suite As System.Windows.Forms.Label
End Class
