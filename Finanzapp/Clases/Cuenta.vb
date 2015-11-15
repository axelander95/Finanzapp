<Serializable()>
Public Class Cuenta
    Public Property Codigo As String
    Public Property Clasificacion As String
    Public Property Descripcion As String
    Public Property Negativa As Boolean
    Public Sub New(ByVal Codigo As String, ByVal Clasificacion As String, ByVal Descripcion As String,
                   ByVal Negativa As Boolean)
        Me.Codigo = Codigo
        Me.Clasificacion = Clasificacion
        Me.Descripcion = Descripcion
        Me.Negativa = Negativa
    End Sub
End Class
