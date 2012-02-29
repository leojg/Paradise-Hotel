Imports Dominio

Module Index
    Public Sub main()
        cargarCollections()
        Dim frm As New Hotel()
        frm.ShowDialog()
    End Sub

    Public Sub cargarCollections()
        Dim objH As Dominio.Hotel = Dominio.Hotel.GetInstance
        objH.ObtenerPisos()
        objH.ObtenerServicios()
        HuespedAdmin.GetInstance.obtenerHuespedes()
    End Sub

End Module
