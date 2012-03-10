<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reserva
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblResNum = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblHabNum = New System.Windows.Forms.Label
        Me.lblFCIn = New System.Windows.Forms.Label
        Me.lblFCOut = New System.Windows.Forms.Label
        Me.lblMAdelantado = New System.Windows.Forms.Label
        Me.lblMTotal = New System.Windows.Forms.Label
        Me.lboxHuespedes = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reserva Nº "
        '
        'lblResNum
        '
        Me.lblResNum.AutoSize = True
        Me.lblResNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResNum.Location = New System.Drawing.Point(134, 9)
        Me.lblResNum.Name = "lblResNum"
        Me.lblResNum.Size = New System.Drawing.Size(43, 25)
        Me.lblResNum.TabIndex = 1
        Me.lblResNum.Text = "nro"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Habitación Nº"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Fecha de check in:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Monto de Adelanto:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha de check out:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Huespedes:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Monto Total:"
        '
        'lblHabNum
        '
        Me.lblHabNum.AutoSize = True
        Me.lblHabNum.Location = New System.Drawing.Point(136, 52)
        Me.lblHabNum.Name = "lblHabNum"
        Me.lblHabNum.Size = New System.Drawing.Size(39, 13)
        Me.lblHabNum.TabIndex = 8
        Me.lblHabNum.Text = "Label8"
        '
        'lblFCIn
        '
        Me.lblFCIn.AutoSize = True
        Me.lblFCIn.Location = New System.Drawing.Point(136, 76)
        Me.lblFCIn.Name = "lblFCIn"
        Me.lblFCIn.Size = New System.Drawing.Size(39, 13)
        Me.lblFCIn.TabIndex = 9
        Me.lblFCIn.Text = "Label9"
        '
        'lblFCOut
        '
        Me.lblFCOut.AutoSize = True
        Me.lblFCOut.Location = New System.Drawing.Point(136, 101)
        Me.lblFCOut.Name = "lblFCOut"
        Me.lblFCOut.Size = New System.Drawing.Size(45, 13)
        Me.lblFCOut.TabIndex = 10
        Me.lblFCOut.Text = "Label10"
        '
        'lblMAdelantado
        '
        Me.lblMAdelantado.AutoSize = True
        Me.lblMAdelantado.Location = New System.Drawing.Point(136, 125)
        Me.lblMAdelantado.Name = "lblMAdelantado"
        Me.lblMAdelantado.Size = New System.Drawing.Size(45, 13)
        Me.lblMAdelantado.TabIndex = 11
        Me.lblMAdelantado.Text = "Label11"
        '
        'lblMTotal
        '
        Me.lblMTotal.AutoSize = True
        Me.lblMTotal.Location = New System.Drawing.Point(136, 150)
        Me.lblMTotal.Name = "lblMTotal"
        Me.lblMTotal.Size = New System.Drawing.Size(45, 13)
        Me.lblMTotal.TabIndex = 12
        Me.lblMTotal.Text = "Label12"
        '
        'lboxHuespedes
        '
        Me.lboxHuespedes.FormattingEnabled = True
        Me.lboxHuespedes.Location = New System.Drawing.Point(12, 196)
        Me.lboxHuespedes.Name = "lboxHuespedes"
        Me.lboxHuespedes.Size = New System.Drawing.Size(199, 108)
        Me.lboxHuespedes.TabIndex = 13
        '
        'reserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(223, 316)
        Me.Controls.Add(Me.lboxHuespedes)
        Me.Controls.Add(Me.lblMTotal)
        Me.Controls.Add(Me.lblMAdelantado)
        Me.Controls.Add(Me.lblFCOut)
        Me.Controls.Add(Me.lblFCIn)
        Me.Controls.Add(Me.lblHabNum)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblResNum)
        Me.Controls.Add(Me.Label1)
        Me.Name = "reserva"
        Me.Text = "Reserva"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblResNum As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblHabNum As System.Windows.Forms.Label
    Friend WithEvents lblFCIn As System.Windows.Forms.Label
    Friend WithEvents lblFCOut As System.Windows.Forms.Label
    Friend WithEvents lblMAdelantado As System.Windows.Forms.Label
    Friend WithEvents lblMTotal As System.Windows.Forms.Label
    Friend WithEvents lboxHuespedes As System.Windows.Forms.ListBox
End Class
