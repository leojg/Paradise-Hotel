Imports Dominio
Public Class pruebaAltaPiso
    Dim objH As Hotel

    Private Sub CargarLbox(ByVal lbox As ListBox, ByVal col As Hashtable)
        lbox.Items.Clear()
        For Each obj As Object In col.Values
            lbox.Items.Add(obj)
        Next
    End Sub

    Public Sub New(ByVal objH As hotel)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.objH = objH

    End Sub

    Private Sub pruebaAltaPiso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarLbox(lboxPisos, objH.DevolverPisos)
        txNum.Text = objH.DevolverPisos.Count
    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        Dim num As Integer = CInt(txNum.Text)
        Dim metraje As Integer = CInt(txMetraje.Text)
        Dim objP As New Piso(num, metraje)
        objH.AltaPiso(objP)
        CargarLbox(lboxPisos, objH.DevolverPisos)
        txNum.Text = objH.DevolverPisos.Count
    End Sub

    Private Sub btHab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btHab.Click
        Dim objP As Piso = CType(lboxPisos.SelectedItem, Piso)
        Dim frm As New pruebaReporte(objP, objH)
        frm.ShowDialog()
    End Sub

    Private Sub btReportSee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btReportSee.Click
        Dim frmrep As New pruebaCR
        frmrep.ShowDialog()
    End Sub
End Class