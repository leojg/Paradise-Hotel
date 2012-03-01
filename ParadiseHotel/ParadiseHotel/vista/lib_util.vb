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
        'Dim DE As DictionaryEntry
        'Dim objH As Habitacion
        'Dim lvItem As ListViewItem
        'For Each DE In col_habitaciones
        '    objH = CType(DE.Value, Habitacion)
        '    lvItem = New ListViewItem(objH.Numero)
        '    With lvItem
        '        '.SubItems.Add(objV.Matricula)
        '        .SubItems.Add(objV.Marca)
        '        .SubItems.Add(objV.Modelo)
        '        .SubItems.Add(objV.Anio)
        '        .Tag = objV
        '    End With
        '    xlview.Items.Add(lvItem)
        'Next
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
            item = New ListViewItem()
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
            item = New ListViewItem()
            item.SubItems.Add(objS.Nombre)
            With item
                .SubItems.Add(objS.Id)
                .Tag = objS
            End With
            lview.Items.Add(item)
        Next
    End Sub

    Public Shared Function integridad_del_tiempo(ByVal dtp_ini As DateTimePicker, ByVal dtp_fin As DateTimePicker) As Integer
        If DateDiff(DateInterval.Day, dtp_ini.Value, Date.Now) = 0 Or DateDiff(DateInterval.Day, Date.Now, dtp_fin.Value) = 0 Then
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
End Class
