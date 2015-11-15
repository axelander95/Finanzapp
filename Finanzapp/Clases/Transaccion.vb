<Serializable()>
Public Class Transaccion
    Public Property Cuenta As String
    Public Property Valor As Decimal
    Public Sub New(ByVal Cuenta As String, ByVal Valor As Decimal)
        Me.Cuenta = Cuenta
        Me.Valor = Valor
    End Sub
End Class
