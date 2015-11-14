Public Class Transaccion
    Public Cuenta As String
    Public Valor As Decimal
    Public Sub New(ByVal Cuenta As String, ByVal Valor As Decimal)
        Me.Cuenta = Cuenta
        Me.Valor = Valor
    End Sub
End Class
