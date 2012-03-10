Imports Dominio
Public Class Lib_util
    Private Shared bKeyBack As Boolean

    Public Shared Sub cargar_lview(ByVal col_habitaciones As ArrayList, ByVal lview As ListView)
        lview.Items.Clear()
        Dim item As ListViewItem
        For Each habitacion As Habitacion In col_habitaciones
            item = New ListViewItem(habitacion.Numero)
            With item
                '.SubItems.Add(habitacion.Numero)
                .SubItems.Add(habitacion.Metraje)
                .SubItems.Add(habitacion.GetType.Name) 'aca va tipo
                .SubItems.Add(habitacion.tieneTerraza)
                .SubItems.Add(habitacion.Costo)
                If (habitacion.GetType.Name = "SuiteJr" Or habitacion.GetType.Name = "SuiteSr") Then
                    .SubItems.Add(CType(habitacion, Suite).Nombre)
                End If
                Try
                    If (Not CType(habitacion, Suite).Nombre = Nothing) Then
                        .SubItems.Add(CType(habitacion, Suite).Nombre)
                    End If
                Catch ex As Exception
                Finally
                    .Tag = habitacion
                End Try
            End With
            lview.Items.Add(item)
        Next
    End Sub

    Public Shared Sub cargar_lview_hab_hash(ByVal col_habitaciones As Hashtable, ByVal lview As ListView)
        Dim arr As New ArrayList
        For Each objH As Habitacion In col_habitaciones.Values
            arr.Add(objH)
        Next
        cargar_lview(arr, lview)
    End Sub

    Public Shared Sub cargar_cbox_categorias(ByVal col_categorias As ArrayList, ByVal cbox_cats As ComboBox)
        For Each cat In col_categorias
            cbox_cats.Items.Add(cat)
        Next
    End Sub

    Public Shared Sub cargar_lview_huespedes(ByVal lview As ListView, ByVal hash As Hashtable)
        Dim item As ListViewItem
        For Each objH As Huesped In hash.Values
            item = New ListViewItem(objH.Documento)
            With item
                .SubItems.Add(objH.Nombre)
                .SubItems.Add(objH.Apellido)
                .SubItems.Add(objH.Telefono)
                .SubItems.Add(objH.Direccion)
                .SubItems.Add(objH.GetType.Name)
                .Tag = objH
            End With
            lview.Items.Add(item)
        Next
    End Sub

    Public Shared Sub cargar_lview_servicios(ByVal lview As ListView, ByVal hash As Hashtable)
        Dim item As ListViewItem
        For Each objS As Servicio In hash.Values
            item = New ListViewItem(objS.Id)

            With item
                .SubItems.Add(objS.Nombre)
                .Tag = objS
            End With
            lview.Items.Add(item)
        Next
    End Sub

    Public Shared Sub cargar_reporte(ByVal ds As DataSet, ByVal crv As CrystalDecisions.Windows.Forms.CrystalReportViewer)
        Dim reporte As New CrystalReportHabitaciones
        reporte.SetDataSource(ds)
        crv.ReportSource = reporte
        crv.RefreshReport()
    End Sub

    Public Shared Function integridad_del_tiempo(ByVal dtp_ini As DateTimePicker, ByVal dtp_fin As DateTimePicker) As Integer
        If DateDiff(DateInterval.Day, Date.Now, dtp_fin.Value) = 0 Then
            Return 2
        ElseIf DateDiff(DateInterval.Day, dtp_ini.Value, dtp_fin.Value) < 0 Then
            Return 1
        ElseIf DateDiff(DateInterval.Day, dtp_ini.Value, dtp_fin.Value) = 0 Then
            Return 0
        Else
            Return 3
        End If
    End Function

    Public Shared Sub autocompletar_textbox(ByVal tbox As TextBox, ByVal datos As ArrayList)
        Dim i As Integer
        Dim posSelect As Integer

        Select Case (bKeyBack Or Len(tbox.Text) = 0)
            Case True
                bKeyBack = False
                Exit Sub
        End Select

        With tbox
            'Recorremos todos los elementos del array  
            For i = 0 To datos.Count - 1
                ' Buscamos coincidencias  
                If InStr(1, datos(i), .Text, vbTextCompare) = 1 Then
                    posSelect = .SelectionStart
                    ' asignar el texto de array al textbox  
                    .Text = datos(i)

                    ' seleccionar el texto  
                    .SelectionStart = posSelect
                    .SelectionLength = Len(.Text) - posSelect
                    Exit For ' salimos del bucle  
                End If
            Next i
        End With
    End Sub

    Public Shared Sub cargar_lview_reservas(ByVal lview As ListView, ByVal hash As Hashtable)
        Dim item As ListViewItem
        lview.Items.Clear()
        For Each objR As Dominio.Reserva In hash.Values
            item = New ListViewItem(objR.Id)

            With item
                .SubItems.Add(objR.Habitacion.Numero)
                .SubItems.Add(objR.montoTotal)
                .SubItems.Add(objR.montoReserva)
                .SubItems.Add(objR.CheckIn)
                .SubItems.Add(objR.CheckOut)
                .SubItems.Add(objR.fechaRealizacion)
                .Tag = objR
            End With
            lview.Items.Add(item)
        Next
    End Sub

    Public Shared Function habitacion_del_listview(ByVal lview As ListView) As Habitacion
        Dim i As Integer
        Dim item As ListViewItem
        Dim objH As Habitacion
        For Each i In lview.SelectedIndices
            item = lview.Items(i)
            objH = CType(item.Tag, Habitacion)
            Return objH
        Next
        Return Nothing
    End Function

    Public Shared Sub cambiar_list_view(ByVal lview As ListView, ByVal tipo As String)
        lview.Clear()
        If tipo = "habitacion" Then
            Dim vec_headers(4) As ColumnHeader

            Dim header1, header2, header3, header4, header5 As ColumnHeader
            header1 = New ColumnHeader
            header2 = New ColumnHeader
            header3 = New ColumnHeader
            header4 = New ColumnHeader
            header5 = New ColumnHeader

            header1.Name = "id"
            header1.Text = "Id"
            vec_headers(0) = header1

            header2.Name = "metraje"
            header2.Text = "Metraje"
            vec_headers(1) = header2

            header3.Name = "tipo"
            header3.Text = "Tipo"
            vec_headers(2) = header3

            header4.Name = "terraza"
            header4.Text = "Terraza"
            vec_headers(3) = header4

            header5.Name = "costo"
            header5.Text = "Costo"
            vec_headers(4) = header5

            lview.Columns.AddRange(vec_headers)

            cargar_lview(Fachada.DevolverHabitacionPorTipo("Todo"), lview)

        ElseIf tipo = "reserva" Then
            Dim vec_headers(6) As ColumnHeader

            Dim header1, header2, header3, header4, header5, header6, header7 As ColumnHeader
            header1 = New ColumnHeader
            header2 = New ColumnHeader
            header3 = New ColumnHeader
            header4 = New ColumnHeader
            header5 = New ColumnHeader
            header6 = New ColumnHeader
            header7 = New ColumnHeader

            header1.Name = "id"
            header1.Text = "Nro Id"
            vec_headers(0) = header1

            header2.Name = "hab"
            header2.Text = "Habitacion"
            vec_headers(1) = header2

            header3.Name = "mtot"
            header3.Text = "Monto Total"
            vec_headers(2) = header3

            header4.Name = "made"
            header4.Text = "Adelanto"
            vec_headers(3) = header4

            header5.Name = "fcheckin"
            header5.Text = "Fecha Check In"
            vec_headers(4) = header5

            header6.Name = "fcheckout"
            header6.Text = "Fecha Check Out"
            vec_headers(5) = header6

            header7.Name = "freal"
            header7.Text = "Fecha Realizacion"
            vec_headers(6) = header7

            lview.Columns.AddRange(vec_headers)

            cargar_lview_reservas(lview, Fachada.devolverReservas)

        End If
    End Sub
End Class
