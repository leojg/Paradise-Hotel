''' <summary>
''' Representa los huespedes nacionales
''' </summary>
''' <remarks></remarks>
Public Class Nacional
    Inherits Huesped

    Public Sub New(ByVal nom As String, ByVal ape As String, ByVal doc As Integer, ByVal tel As Integer, ByVal dir As String)
        MyBase.New(nom, ape, doc, tel, dir)
    End Sub

End Class
