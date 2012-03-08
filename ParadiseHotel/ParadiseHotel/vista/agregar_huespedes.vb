Imports System.Windows.Forms.Form
Imports Dominio
Public Class agregar_huespedes
    Inherits ParadiseHotel.Mantenimiento

    Private _objH As Habitacion
    Private _objFrm As Hotel
    Private _id_huesped_1 As Integer
    Private _col_huspedes As Hashtable

    Public Sub New(ByVal objH As Habitacion, ByVal id_huesped_1 As Integer, ByRef objFrm As Hotel)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me._objH = objH
        Me._objFrm = objFrm
        Me._id_huesped_1 = id_huesped_1
        Me._col_huspedes = New Hashtable()
    End Sub

    Private Sub agregar_huespedes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lbl_titulo.Text = "Agregar huéspedes acompañantes"
        Me.lbl_descripcion.Text = "Informacion a definir"
    End Sub

    Private Sub txt_nro_documento_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_nro_documento.LostFocus
        Dim id As Integer = CInt(Me.txt_nro_documento.Text)
        If id <> Me._id_huesped_1 Then
            If Fachada.existe_huesped(id) Then
                Me.cargar_cajas(Fachada.devolverHuesped(CInt(Me.txt_nro_documento.Text)))
            Else
                MsgBox("Ese huesped no está registrado en nuestra BD, \n por favor ingrese sus datos en esta página: www.padisehotel.com/registro.asp")
                Me.txt_nro_documento.Text = ""
            End If
        Else
            MsgBox("El huesped con id = " & Me._id_huesped_1 & " ya está registrado como titular de la reserva.")
            Me.txt_nro_documento.Text = ""
        End If
    End Sub

    Private Sub txt_nro_documento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_nro_documento.TextChanged
        Lib_util.autocompletar_textbox(Me.txt_nro_documento, Fachada.obtener_identificaciones())
    End Sub

    Private Sub limpiar_cajas()
        Me.txt_nro_documento.Text = ""
        Me.txt_nombres.Text = ""
        Me.txt_apellidos.Text = ""
        Me.txt_telefono.Text = ""
        Me.txt_domicilio.Text = ""
    End Sub

    Private Sub cargar_cajas(ByVal objH As Huesped)
        Me._col_huspedes.Add(objH.Documento, objH)
        Me.txt_nombres.Text = objH.Nombre
        Me.txt_apellidos.Text = objH.Apellido
        Me.txt_telefono.Text = objH.Telefono
        Me.txt_domicilio.Text = objH.Direccion
    End Sub

    Private Sub cargar_list_box()
        Me.lbox_huespedes.Items.Clear()
        Dim DE As DictionaryEntry
        Dim objH As Huesped
        For Each DE In Me._col_huspedes
            objH = CType(DE.Value, Huesped)
            Me.lbox_huespedes.Items.Add(objH)
        Next
    End Sub

    Private Sub btn_agregar_huesped_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar_huesped.Click
        Me.cargar_list_box()
    End Sub

    Private Sub btn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar.Click
        Me._objFrm.depositar_acompaniantes(Me._col_huspedes)
        Me.Close()
    End Sub
End Class