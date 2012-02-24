Public Class ReservasAdmin

    Dim instance As ReservasAdmin
    Dim colReservas As Hashtable

    Private Sub New()
        colReservas = New Hashtable
    End Sub

    Public Function GetInstance() As ReservasAdmin
        If (instance Is Nothing) Then
            instance = New ReservasAdmin
        End If
        Return instance
    End Function

    Public Function devolverReservas() As Hashtable
        Return colReservas
    End Function

End Class
