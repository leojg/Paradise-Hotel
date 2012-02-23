Imports System.Data.OleDb
''' <summary>
''' Clase que define la funcionalidad basica de la persistencia del sistema
''' </summary>
''' <remarks></remarks>
Public MustInherit Class Persistencia
    Protected objconexion As OleDbConnection
    Protected objcomando As OleDbCommand
    Protected objdataadapter As OleDbDataAdapter
    Public Sub abrirConexion()
        Dim datoConexion As String = "Provider = Microsoft.jet.oledb.4.0; Data Source = .\BDHotelParaiso.mdb"
        objconexion = New OleDbConnection(datoConexion)
        objConexion.Open()
    End Sub
    Public Sub cerrarConexion()
        Dim datoConexion As String = "Provider = Microsoft.jet.oledb.4.0; Data Source = .\BDHotelParaiso.mdb"
        objconexion = New OleDbConnection(datoConexion)
        objConexion.Close()
    End Sub
    Public MustOverride Sub guardar(ByVal XObj As Object)
    Public MustOverride Sub modificar(ByVal xobj As Object)
    Public MustOverride Sub eliminar(ByVal xobj As Object)
End Class
