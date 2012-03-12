<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class imprimir
    Inherits System.Windows.Forms.Form

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
        Me.btn_imprimir = New System.Windows.Forms.Button
        Me.chkbox_imprimir_habitaciones = New System.Windows.Forms.CheckBox
        Me.chkbox_imprimir_huespedes = New System.Windows.Forms.CheckBox
        Me.chkbox_imprimir_reservas = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Location = New System.Drawing.Point(12, 128)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(260, 23)
        Me.btn_imprimir.TabIndex = 0
        Me.btn_imprimir.Text = "Imprimir"
        Me.btn_imprimir.UseVisualStyleBackColor = True
        '
        'chkbox_imprimir_habitaciones
        '
        Me.chkbox_imprimir_habitaciones.AutoSize = True
        Me.chkbox_imprimir_habitaciones.Location = New System.Drawing.Point(35, 19)
        Me.chkbox_imprimir_habitaciones.Name = "chkbox_imprimir_habitaciones"
        Me.chkbox_imprimir_habitaciones.Size = New System.Drawing.Size(138, 17)
        Me.chkbox_imprimir_habitaciones.TabIndex = 1
        Me.chkbox_imprimir_habitaciones.Text = "Listado de habitaciones"
        Me.chkbox_imprimir_habitaciones.UseVisualStyleBackColor = True
        '
        'chkbox_imprimir_huespedes
        '
        Me.chkbox_imprimir_huespedes.AutoSize = True
        Me.chkbox_imprimir_huespedes.Enabled = False
        Me.chkbox_imprimir_huespedes.Location = New System.Drawing.Point(35, 42)
        Me.chkbox_imprimir_huespedes.Name = "chkbox_imprimir_huespedes"
        Me.chkbox_imprimir_huespedes.Size = New System.Drawing.Size(130, 17)
        Me.chkbox_imprimir_huespedes.TabIndex = 2
        Me.chkbox_imprimir_huespedes.Text = "Listado de huespedes"
        Me.chkbox_imprimir_huespedes.UseVisualStyleBackColor = True
        '
        'chkbox_imprimir_reservas
        '
        Me.chkbox_imprimir_reservas.AutoSize = True
        Me.chkbox_imprimir_reservas.Enabled = False
        Me.chkbox_imprimir_reservas.Location = New System.Drawing.Point(35, 65)
        Me.chkbox_imprimir_reservas.Name = "chkbox_imprimir_reservas"
        Me.chkbox_imprimir_reservas.Size = New System.Drawing.Size(118, 17)
        Me.chkbox_imprimir_reservas.TabIndex = 3
        Me.chkbox_imprimir_reservas.Text = "Listado de reservas"
        Me.chkbox_imprimir_reservas.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkbox_imprimir_habitaciones)
        Me.GroupBox1.Controls.Add(Me.chkbox_imprimir_reservas)
        Me.GroupBox1.Controls.Add(Me.chkbox_imprimir_huespedes)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 100)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccionar"
        '
        'imprimir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 169)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Name = "imprimir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "imprimir"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents chkbox_imprimir_habitaciones As System.Windows.Forms.CheckBox
    Friend WithEvents chkbox_imprimir_huespedes As System.Windows.Forms.CheckBox
    Friend WithEvents chkbox_imprimir_reservas As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
