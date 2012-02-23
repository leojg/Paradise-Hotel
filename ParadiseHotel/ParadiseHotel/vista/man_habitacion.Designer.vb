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
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.lbl_cat_hab = New System.Windows.Forms.Label
        Me.cbox_cat_mant_hab = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'lbl_nro_habitacion
        '
        Me.lbl_nro_habitacion.AutoSize = True
        Me.lbl_nro_habitacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nro_habitacion.Location = New System.Drawing.Point(18, 92)
        Me.lbl_nro_habitacion.Name = "lbl_nro_habitacion"
        Me.lbl_nro_habitacion.Size = New System.Drawing.Size(52, 15)
        Me.lbl_nro_habitacion.TabIndex = 3
        Me.lbl_nro_habitacion.Text = "Número"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(85, 89)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(171, 21)
        Me.TextBox1.TabIndex = 4
        '
        'lbl_cat_hab
        '
        Me.lbl_cat_hab.AutoSize = True
        Me.lbl_cat_hab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cat_hab.Location = New System.Drawing.Point(18, 136)
        Me.lbl_cat_hab.Name = "lbl_cat_hab"
        Me.lbl_cat_hab.Size = New System.Drawing.Size(60, 15)
        Me.lbl_cat_hab.TabIndex = 5
        Me.lbl_cat_hab.Text = "Categoría"
        '
        'cbox_cat_mant_hab
        '
        Me.cbox_cat_mant_hab.FormattingEnabled = True
        Me.cbox_cat_mant_hab.Location = New System.Drawing.Point(237, 200)
        Me.cbox_cat_mant_hab.Name = "cbox_cat_mant_hab"
        Me.cbox_cat_mant_hab.Size = New System.Drawing.Size(121, 37)
        Me.cbox_cat_mant_hab.TabIndex = 6
        '
        'Man_habitacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 425)
        Me.Controls.Add(Me.cbox_cat_mant_hab)
        Me.Controls.Add(Me.lbl_cat_hab)
        Me.Controls.Add(Me.lbl_nro_habitacion)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Man_habitacion"
        Me.Text = "man_habitacion"
        Me.Controls.SetChildIndex(Me.TextBox1, 0)
        Me.Controls.SetChildIndex(Me.lbl_nro_habitacion, 0)
        Me.Controls.SetChildIndex(Me.lbl_cat_hab, 0)
        Me.Controls.SetChildIndex(Me.cbox_cat_mant_hab, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_nro_habitacion As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cat_hab As System.Windows.Forms.Label
    Friend WithEvents cbox_cat_mant_hab As System.Windows.Forms.ComboBox
End Class
