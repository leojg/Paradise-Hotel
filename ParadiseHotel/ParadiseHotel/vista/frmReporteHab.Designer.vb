<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteHab
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
        Me.crvHab = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crvHab
        '
        Me.crvHab.ActiveViewIndex = -1
        Me.crvHab.AutoSize = True
        Me.crvHab.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.crvHab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvHab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvHab.Location = New System.Drawing.Point(0, 0)
        Me.crvHab.Name = "crvHab"
        Me.crvHab.SelectionFormula = ""
        Me.crvHab.Size = New System.Drawing.Size(1341, 732)
        Me.crvHab.TabIndex = 0
        Me.crvHab.ViewTimeSelectionFormula = ""
        '
        'frmReporteHab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1341, 732)
        Me.Controls.Add(Me.crvHab)
        Me.Name = "frmReporteHab"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReporteHab"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents crvHab As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
