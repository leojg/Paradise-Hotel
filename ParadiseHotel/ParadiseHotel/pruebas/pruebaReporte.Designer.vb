<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pruebaReporte
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
        Me.txPiso = New System.Windows.Forms.TextBox
        Me.txCost = New System.Windows.Forms.TextBox
        Me.txId = New System.Windows.Forms.TextBox
        Me.lboxTipos = New System.Windows.Forms.ListBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lboxHabitaciones = New System.Windows.Forms.ListBox
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btBaja = New System.Windows.Forms.Button
        Me.btMod = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txPiso
        '
        Me.txPiso.Location = New System.Drawing.Point(54, 81)
        Me.txPiso.Name = "txPiso"
        Me.txPiso.Size = New System.Drawing.Size(100, 20)
        Me.txPiso.TabIndex = 16
        '
        'txCost
        '
        Me.txCost.Location = New System.Drawing.Point(54, 41)
        Me.txCost.Name = "txCost"
        Me.txCost.Size = New System.Drawing.Size(100, 20)
        Me.txCost.TabIndex = 15
        '
        'txId
        '
        Me.txId.Location = New System.Drawing.Point(54, 10)
        Me.txId.Name = "txId"
        Me.txId.Size = New System.Drawing.Size(100, 20)
        Me.txId.TabIndex = 14
        '
        'lboxTipos
        '
        Me.lboxTipos.FormattingEnabled = True
        Me.lboxTipos.Items.AddRange(New Object() {"Individual", "Doble", "Suite Jr", "Suite Sr"})
        Me.lboxTipos.Location = New System.Drawing.Point(54, 119)
        Me.lboxTipos.Name = "lboxTipos"
        Me.lboxTipos.Size = New System.Drawing.Size(120, 69)
        Me.lboxTipos.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Tipo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Piso"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Costo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Id"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(276, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Habitaciones"
        '
        'lboxHabitaciones
        '
        Me.lboxHabitaciones.FormattingEnabled = True
        Me.lboxHabitaciones.Location = New System.Drawing.Point(215, 41)
        Me.lboxHabitaciones.Name = "lboxHabitaciones"
        Me.lboxHabitaciones.Size = New System.Drawing.Size(455, 199)
        Me.lboxHabitaciones.TabIndex = 18
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(215, 283)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 17
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btBaja
        '
        Me.btBaja.Location = New System.Drawing.Point(315, 283)
        Me.btBaja.Name = "btBaja"
        Me.btBaja.Size = New System.Drawing.Size(75, 23)
        Me.btBaja.TabIndex = 20
        Me.btBaja.Text = "Baja"
        Me.btBaja.UseVisualStyleBackColor = True
        '
        'btMod
        '
        Me.btMod.Location = New System.Drawing.Point(420, 283)
        Me.btMod.Name = "btMod"
        Me.btMod.Size = New System.Drawing.Size(75, 23)
        Me.btMod.TabIndex = 21
        Me.btMod.Text = "Mod"
        Me.btMod.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(54, 296)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pruebaReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 386)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btMod)
        Me.Controls.Add(Me.btBaja)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lboxHabitaciones)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txPiso)
        Me.Controls.Add(Me.txCost)
        Me.Controls.Add(Me.txId)
        Me.Controls.Add(Me.lboxTipos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "pruebaReporte"
        Me.Text = "pruebaReporte"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txPiso As System.Windows.Forms.TextBox
    Friend WithEvents txCost As System.Windows.Forms.TextBox
    Friend WithEvents txId As System.Windows.Forms.TextBox
    Friend WithEvents lboxTipos As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lboxHabitaciones As System.Windows.Forms.ListBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btBaja As System.Windows.Forms.Button
    Friend WithEvents btMod As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
