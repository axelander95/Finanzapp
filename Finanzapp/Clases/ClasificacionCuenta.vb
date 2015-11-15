<Serializable()>
Public Class ClasificacionCuenta
    Public Property Codigo As String
    Public Property Descripcion As String
    Public Sub New(ByVal Codigo As String, ByVal Descripcion As String)
        Me.Codigo = Codigo
        Me.Descripcion = Descripcion
    End Sub
End Class
