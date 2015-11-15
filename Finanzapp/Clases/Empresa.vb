<Serializable()>
Public Class Empresa
    Public Property Nombre As String
    Public Property RUC As String
    Public Property Direccion As String
    Public Property Telefono As String
    Public Property Celular As String
    Public Property CorreoElectronico As String
    Public Property PaginaWeb As String
    Public Sub New()
        Nombre = "EMPRESA XYZ"
        RUC = "099999999999"
        Direccion = "NO ESTABLECIDA"
        Telefono = "044444444"
        Celular = "099999999"
        CorreoElectronico = "alguien@emprezaxyz.com"
        PaginaWeb = "www.empresaxyz.com"
    End Sub
    Public Sub Modificar(ByVal Nombre As String, ByVal RUC As String, ByVal Direccion As String, ByVal Telefono As String,
                         ByVal Celular As String, ByVal CorreoElectronico As String, ByVal PaginaWeb As String)
        Me.Nombre = Nombre
        Me.RUC = RUC
        Me.Direccion = Direccion
        Me.Telefono = Telefono
        Me.Celular = Celular
        Me.CorreoElectronico = CorreoElectronico
        Me.PaginaWeb = PaginaWeb
    End Sub
End Class
