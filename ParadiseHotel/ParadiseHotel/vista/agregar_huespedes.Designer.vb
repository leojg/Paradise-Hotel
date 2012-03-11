<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agregar_huespedes
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btn_limpiar_huespedes = New System.Windows.Forms.Button
        Me.btn_quitar_huesped = New System.Windows.Forms.Button
        Me.btn_agregar_huesped = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbox_tipo_id = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_domicilio = New System.Windows.Forms.TextBox
        Me.txt_telefono = New System.Windows.Forms.TextBox
        Me.txt_apellidos = New System.Windows.Forms.TextBox
        Me.txt_nombres = New System.Windows.Forms.TextBox
        Me.txt_nro_documento = New System.Windows.Forms.TextBox
        Me.lbox_huespedes = New System.Windows.Forms.ListBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_agregar
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_limpiar_huespedes)
        Me.GroupBox1.Controls.Add(Me.btn_quitar_huesped)
        Me.GroupBox1.Controls.Add(Me.btn_agregar_huesped)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbox_tipo_id)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_domicilio)
        Me.GroupBox1.Controls.Add(Me.txt_telefono)
        Me.GroupBox1.Controls.Add(Me.txt_apellidos)
        Me.GroupBox1.Controls.Add(Me.txt_nombres)
        Me.GroupBox1.Controls.Add(Me.txt_nro_documento)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(424, 257)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nuevo huésped"
        '
        'btn_limpiar_huespedes
        '
        Me.btn_limpiar_huespedes.Location = New System.Drawing.Point(34, 228)
        Me.btn_limpiar_huespedes.Name = "btn_limpiar_huespedes"
        Me.btn_limpiar_huespedes.Size = New System.Drawing.Size(75, 23)
        Me.btn_limpiar_huespedes.TabIndex = 24
        Me.btn_limpiar_huespedes.Text = "Limpiar"
        Me.btn_limpiar_huespedes.UseVisualStyleBackColor = True
        '
        'btn_quitar_huesped
        '
        Me.btn_quitar_huesped.Location = New System.Drawing.Point(234, 228)
        Me.btn_quitar_huesped.Name = "btn_quitar_huesped"
        Me.btn_quitar_huesped.Size = New System.Drawing.Size(75, 23)
        Me.btn_quitar_huesped.TabIndex = 23
        Me.btn_quitar_huesped.Text = "Quitar"
        Me.btn_quitar_huesped.UseVisualStyleBackColor = True
        '
        'btn_agregar_huesped
        '
        Me.btn_agregar_huesped.Location = New System.Drawing.Point(331, 228)
        Me.btn_agregar_huesped.Name = "btn_agregar_huesped"
        Me.btn_agregar_huesped.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregar_huesped.TabIndex = 22
        Me.btn_agregar_huesped.Text = "Agregar"
        Me.btn_agregar_huesped.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 15)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Domicilio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 15)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Teléfono"
        '
        'cbox_tipo_id
        '
        Me.cbox_tipo_id.FormattingEnabled = True
        Me.cbox_tipo_id.Items.AddRange(New Object() {"Cédula", "Pasaporte", "Nro. Usuario"})
        Me.cbox_tipo_id.Location = New System.Drawing.Point(320, 35)
        Me.cbox_tipo_id.Name = "cbox_tipo_id"
        Me.cbox_tipo_id.Size = New System.Drawing.Size(86, 23)
        Me.cbox_tipo_id.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nro. Documento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Apellidos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nombres"
        '
        'txt_domicilio
        '
        Me.txt_domicilio.Enabled = False
        Me.txt_domicilio.Location = New System.Drawing.Point(126, 182)
        Me.txt_domicilio.Name = "txt_domicilio"
        Me.txt_domicilio.Size = New System.Drawing.Size(280, 21)
        Me.txt_domicilio.TabIndex = 4
        '
        'txt_telefono
        '
        Me.txt_telefono.Enabled = False
        Me.txt_telefono.Location = New System.Drawing.Point(126, 145)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(280, 21)
        Me.txt_telefono.TabIndex = 3
        '
        'txt_apellidos
        '
        Me.txt_apellidos.Enabled = False
        Me.txt_apellidos.Location = New System.Drawing.Point(126, 109)
        Me.txt_apellidos.Name = "txt_apellidos"
        Me.txt_apellidos.Size = New System.Drawing.Size(280, 21)
        Me.txt_apellidos.TabIndex = 2
        '
        'txt_nombres
        '
        Me.txt_nombres.Enabled = False
        Me.txt_nombres.Location = New System.Drawing.Point(126, 72)
        Me.txt_nombres.Name = "txt_nombres"
        Me.txt_nombres.Size = New System.Drawing.Size(280, 21)
        Me.txt_nombres.TabIndex = 1
        '
        'txt_nro_documento
        '
        Me.txt_nro_documento.Location = New System.Drawing.Point(126, 35)
        Me.txt_nro_documento.Name = "txt_nro_documento"
        Me.txt_nro_documento.Size = New System.Drawing.Size(183, 21)
        Me.txt_nro_documento.TabIndex = 0
        '
        'lbox_huespedes
        '
        Me.lbox_huespedes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbox_huespedes.FormattingEnabled = True
        Me.lbox_huespedes.ItemHeight = 15
        Me.lbox_huespedes.Location = New System.Drawing.Point(7, 361)
        Me.lbox_huespedes.Name = "lbox_huespedes"
        Me.lbox_huespedes.Size = New System.Drawing.Size(423, 109)
        Me.lbox_huespedes.TabIndex = 4
        '
        'agregar_huespedes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 574)
        Me.Controls.Add(Me.lbox_huespedes)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "agregar_huespedes"
        Me.Text = "agregar_huespedes"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.lbox_huespedes, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_domicilio As System.Windows.Forms.TextBox
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellidos As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombres As System.Windows.Forms.TextBox
    Friend WithEvents txt_nro_documento As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbox_tipo_id As System.Windows.Forms.ComboBox
    Friend WithEvents btn_limpiar_huespedes As System.Windows.Forms.Button
    Friend WithEvents btn_quitar_huesped As System.Windows.Forms.Button
    Friend WithEvents btn_agregar_huesped As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbox_huespedes As System.Windows.Forms.ListBox
End Class
