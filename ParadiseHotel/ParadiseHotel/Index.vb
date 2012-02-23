Imports Dominio

Module Index
    Public Sub main()
        Dim objhab As Habitacion
        If objhab.GetType.Name Is GetType(Doble) Then

        End If
        Dominio.Hotel.GetInstance.ObtenerServicios()
        'Dim objh As New Hotel
        'objh.ObtenerPisos()
        Dim frm As New Hotel()
        frm.ShowDialog()
    End Sub
End Module
