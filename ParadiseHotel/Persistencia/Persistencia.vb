Imports System.Data.OleDb
Public MustInherit Class Persistencia
    Protected objconexion As OleDbConnection
    Protected objcomando As OleDbCommand
    Protected objdataadapter As OleDbDataAdapter
    Public Sub abrirConexion()
        Dim datoConexion As String = "Provider = Microsoft.jet.oledb.4.0; Data Source = .\"".mdb"
        objconexion = New OleDbConnection(datoConexion)
        objConexion.Open()
    End Sub
    Public Sub cerrarConexion()
        Dim datoConexion As String = "Provider = Microsoft.jet.oledb.4.0; Data Source = .\"".mdb"
        objconexion = New OleDbConnection(datoConexion)
        objConexion.Close()
    End Sub
    Public MustOverride Sub guardar(ByVal XObj As Object)
    Public MustOverride Sub modificar(ByVal xobj As Object)
    Public MustOverride Sub eliminar(ByVal xobj As Object)
End Class
