<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pruebaAltaPiso
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
        Me.btHab = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txNum = New System.Windows.Forms.TextBox
        Me.txMetraje = New System.Windows.Forms.TextBox
        Me.btAdd = New System.Windows.Forms.Button
        Me.btEdit = New System.Windows.Forms.Button
        Me.btBaja = New System.Windows.Forms.Button
        Me.lboxPisos = New System.Windows.Forms.ListBox
        Me.btReportSee = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btHab
        '
        Me.btHab.Location = New System.Drawing.Point(275, 17)
        Me.btHab.Name = "btHab"
        Me.btHab.Size = New System.Drawing.Size(92, 23)
        Me.btHab.TabIndex = 0
        Me.btHab.Text = "Habitaciones"
        Me.btHab.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Numero"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Metraje"
        '
        'txNum
        '
        Me.txNum.Location = New System.Drawing.Point(57, 17)
        Me.txNum.Name = "txNum"
        Me.txNum.Size = New System.Drawing.Size(100, 20)
        Me.txNum.TabIndex = 3
        '
        'txMetraje
        '
        Me.txMetraje.Location = New System.Drawing.Point(57, 52)
        Me.txMetraje.Name = "txMetraje"
        Me.txMetraje.Size = New System.Drawing.Size(100, 20)
        Me.txMetraje.TabIndex = 4
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(185, 14)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(69, 23)
        Me.btAdd.TabIndex = 5
        Me.btAdd.Text = "Atla"
        Me.btAdd.UseVisualStyleBackColor = True
        '
        'btEdit
        '
        Me.btEdit.Location = New System.Drawing.Point(185, 43)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(69, 23)
        Me.btEdit.TabIndex = 6
        Me.btEdit.Text = "Edit"
        Me.btEdit.UseVisualStyleBackColor = True
        '
        'btBaja
        '
        Me.btBaja.Location = New System.Drawing.Point(185, 72)
        Me.btBaja.Name = "btBaja"
        Me.btBaja.Size = New System.Drawing.Size(69, 23)
        Me.btBaja.TabIndex = 7
        Me.btBaja.Text = "Baja"
        Me.btBaja.UseVisualStyleBackColor = True
        '
        'lboxPisos
        '
        Me.lboxPisos.FormattingEnabled = True
        Me.lboxPisos.Location = New System.Drawing.Point(12, 103)
        Me.lboxPisos.Name = "lboxPisos"
        Me.lboxPisos.Size = New System.Drawing.Size(355, 212)
        Me.lboxPisos.TabIndex = 8
        '
        'btReportSee
        '
        Me.btReportSee.Location = New System.Drawing.Point(39, 355)
        Me.btReportSee.Name = "btReportSee"
        Me.btReportSee.Size = New System.Drawing.Size(75, 23)
        Me.btReportSee.TabIndex = 9
        Me.btReportSee.Text = "btVerReporte"
        Me.btReportSee.UseVisualStyleBackColor = True
        '
        'pruebaAltaPiso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 519)
        Me.Controls.Add(Me.btReportSee)
        Me.Controls.Add(Me.lboxPisos)
        Me.Controls.Add(Me.btBaja)
        Me.Controls.Add(Me.btEdit)
        Me.Controls.Add(Me.btAdd)
        Me.Controls.Add(Me.txMetraje)
        Me.Controls.Add(Me.txNum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btHab)
        Me.Name = "pruebaAltaPiso"
        Me.Text = "pruebaAltaPiso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btHab As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txNum As System.Windows.Forms.TextBox
    Friend WithEvents txMetraje As System.Windows.Forms.TextBox
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents btEdit As System.Windows.Forms.Button
    Friend WithEvents btBaja As System.Windows.Forms.Button
    Friend WithEvents lboxPisos As System.Windows.Forms.ListBox
    Friend WithEvents btReportSee As System.Windows.Forms.Button
End Class
