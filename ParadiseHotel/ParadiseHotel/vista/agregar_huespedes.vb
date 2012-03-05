Imports System.Windows.Forms.Form
Imports Dominio
Public Class agregar_huespedes
    Inherits ParadiseHotel.Mantenimiento

    Private _objH As Habitacion

    Public Sub New(ByVal objH As Habitacion)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me._objH = objH
    End Sub

    Private Sub agregar_huespedes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lbl_titulo.Text = "Agregar huéspedes acompañantes"
        Me.lbl_descripcion.Text = "Informacion a definir"
    End Sub
End Class