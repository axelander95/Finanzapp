Public Class Cuenta
    Public Codigo As String
    Public Clasificacion As String
    Public Descripcion As String
    Public Negativa As Boolean
    Public Sub New(ByVal Codigo As String, ByVal Clasificacion As String, ByVal Descripcion As String,
                   ByVal Negativa As Boolean)
        Me.Codigo = Codigo
        Me.Clasificacion = Clasificacion
        Me.Descripcion = Descripcion
        Me.Negativa = Negativa
    End Sub
End Class
