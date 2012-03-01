Imports Dominio
Public Class Lib_util
    Public Shared Sub cargar_lview(ByVal col_habitaciones As Hashtable, ByVal lview As ListView)
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
                .Tag = habitacion
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
End Class
