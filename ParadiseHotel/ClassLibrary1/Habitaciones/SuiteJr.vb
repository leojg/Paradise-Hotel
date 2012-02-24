Public Class SuiteJr
    Inherits Suite

    Public Sub New(ByVal nom As String, ByVal id As Int32, ByVal numpiso As Int16, ByVal costo As Int16)
        MyBase.New(nom, id, numpiso, costo)
    End Sub


    Public Overrides Function Metraje() As Integer
        Return 16
    End Function

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
End Class
