Imports Dominio
Public Class Lib_util
    Public Shared Sub cargar_lview(ByVal col_habitaciones As ArrayList, ByVal lview As ListView)
        Dim item As ListViewItem
        For Each habitacion As Habitacion In col_habitaciones
            item = New ListViewItem()
            With item
                .SubItems.Add(habitacion.Numero)
                .SubItems.Add(habitacion.Metraje)
                .SubItems.Add(habitacion.GetType.Name) 'aca va tipo
                .SubItems.Add(habitacion.tieneTerraza)
                .SubItems.Add(habitacion.Costo)
                .Tag = habitacion
            End With
            lview.Items.Add(item)
        Next
    End Sub

    Public Shared Sub cargar_cbox_categorias(ByVal col_categorias As ArrayList, ByVal cbox_cats As ComboBox)
        For Each cat In col_categorias
            cbox_cats.Items.Add(cat)
        Next
    End Sub

    Public Shared Sub cargar_lview_servicios(ByVal lview As ListView, ByVal hash As Hashtable)
        Dim item As ListViewItem
        For Each objS As Servicio In hash.Values
            item = New ListViewItem()
            With item
                .SubItems.Add(objS.Nombre)
                .SubItems.Add(objS.Id)
                .Tag = objS
            End With
            lview.Items.Add(item)
        Next
    End Sub
End Class
