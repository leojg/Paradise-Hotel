Imports Dominio

Public Class pruebaReporte

    Dim objH As Hotel
    Dim objP As Piso

    Private Sub CargarLbox(ByVal lbox As ListBox, ByVal col As Hashtable)
        lbox.Items.Clear()
        For Each obj As Object In col.Values
            lbox.Items.Add(obj)
        Next
    End Sub

    Public Function CargarControles()
        txId.Text = objH.CalcularNroHabitacion.ToString
        CargarLbox(lboxHabitaciones, objP.DevolverHabitaciones)

    End Function

    Public Sub New(ByVal objp As Piso, ByVal objh As Hotel)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.objP = objp
        Me.objH = objh
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim str As String = CStr(Me.lboxTipos.SelectedItem)
        Dim num As Integer = CInt(Me.txId.Text)
        Dim cost As Int16 = CShort(Me.txCost.Text)

        Dim objhab As Habitacion
        If (str = "Individual") Then
            objhab = New Individual(num, objP.Numero, cost)
        ElseIf (str = "Doble") Then
            objhab = New Doble(num, objP.Numero, cost)
        ElseIf (str = "Suite Jr") Then
            objhab = New SuiteJr("ThaSuite", num, objP.Numero, cost)
        ElseIf (str = "Suite Sr") Then
            objhab = New SuiteSr("TheSuite", num, objP.Numero, cost)
        Else
            MsgBox("u are gay")
        End If
        objP.AgregarHabitacion(objhab)
        CargarControles()


    End Sub

    Private Sub pruebaReporte_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarControles()
    End Sub

    Private Sub btBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBaja.Click
        Dim hab As Habitacion = CType(Me.lboxHabitaciones.SelectedItem, Habitacion)

        objP.BajaHabitacion(hab)
        CargarControles()
    End Sub

    Private Sub btMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btMod.Click

        Dim costo As Int16 = CInt(Me.txCost.Text)
        Dim hab As Habitacion = CType(Me.lboxHabitaciones.SelectedItem, Habitacion)
        hab.Costo = costo
        objP.ModificarHabitacion(hab)
        CargarControles()

    End Sub
End Class
