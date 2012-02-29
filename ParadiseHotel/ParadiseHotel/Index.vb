Imports Dominio

Module Index
    Public Sub main()
        Dominio.Hotel.GetInstance.ObtenerPisos()
        Dominio.Hotel.GetInstance.ObtenerServicios()
        Dim frm As New Hotel()
        frm.ShowDialog()
    End Sub
End Module
