Imports Dominio

Module Index
    Public Sub main()
        Dim objh As New Hotel
        objh.ObtenerPisos()
        Dim frm As New pruebaAltaPiso(objh)
        frm.ShowDialog()
    End Sub
End Module
