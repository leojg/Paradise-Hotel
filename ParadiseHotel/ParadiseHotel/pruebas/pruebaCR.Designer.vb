<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pruebaCR
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
        Me.crvPruebaHab = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crvPruebaHab
        '
        Me.crvPruebaHab.ActiveViewIndex = -1
        Me.crvPruebaHab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvPruebaHab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvPruebaHab.Location = New System.Drawing.Point(0, 0)
        Me.crvPruebaHab.Name = "crvPruebaHab"
        Me.crvPruebaHab.SelectionFormula = ""
        Me.crvPruebaHab.Size = New System.Drawing.Size(292, 270)
        Me.crvPruebaHab.TabIndex = 0
        Me.crvPruebaHab.ViewTimeSelectionFormula = ""
        '
        'pruebaCR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 270)
        Me.Controls.Add(Me.crvPruebaHab)
        Me.Name = "pruebaCR"
        Me.Text = "pruebaCR"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvPruebaHab As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
