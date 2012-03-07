Public Class HuespedAdmin
    Private Shared instance As HuespedAdmin
    Dim colHuespedes As Hashtable
    Dim objPers As PersHotel

    Private Sub New()
        colHuespedes = New Hashtable
        objPers = New PersHotel
    End Sub

    Public Shared Function GetInstance() As HuespedAdmin
        If (instance Is Nothing) Then
            instance = New HuespedAdmin
        End If
        Return instance
    End Function

    Public Function devolverHuesped(ByVal id As Integer) As Huesped
        Return Me.colHuespedes.Item(id)
    End Function

    Public Function devolverHuespedes() As Hashtable
        Return colHuespedes
    End Function

    Public Sub obtenerHuespedes()
        Dim objDataSetHues As DataSet = objPers.ObtenerDataSetHuespedes
        Dim objDataSetExt As DataSet = objPers.ObtenerDataSetExtranjeros
        For Each objfila As DataRow In objDataSetHues.Tables("Pasajeros").Rows
            Dim objH As Huesped
            Dim nom As String = CStr(objfila("Nombre"))
            Dim ape As String = CStr(objfila("Apellido"))
            Dim doc As Integer = CInt(objfila("NumeroDocumento"))
            Dim tel As Integer = CInt(objfila("Telefonos"))
            Dim dir As String = CStr(objfila("Direccion"))
            objH = New Nacional(nom, ape, doc, tel, dir)
            For Each objfila2 As DataRow In objDataSetExt.Tables("Extranjeros").Rows
                If (CInt(objfila("NumeroDocumento")) = (CInt(objfila2("DocumentoPasajero")))) Then
                    Dim visa As Boolean = CBool(objfila2("Visa"))
                    Dim vence As Date = CDate(objfila2("VencimientoVisa"))
                    Dim pais As String = CStr(objfila2("Pais"))
                    objH = New Extranjero(visa, vence, pais, nom, ape, doc, tel, dir)
                End If
            Next
            colHuespedes.Add(objH.Documento, objH)
        Next
    End Sub

    Public Function obtener_identificaciones() As ArrayList
        Dim arr_ids As ArrayList = New ArrayList
        Dim DE As DictionaryEntry
        For Each DE In Me.colHuespedes
            arr_ids.Add(CType(DE.Value, Huesped).Documento)
        Next
        Return arr_ids
    End Function

    Public Function existe_huesped(ByVal id As Integer) As Boolean
        Return Me.colHuespedes.ContainsKey(id)
    End Function
End Class
