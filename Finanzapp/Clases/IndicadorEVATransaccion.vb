<Serializable()>
Public Class IndicadorEVATransaccion
    Public Property Año As Integer
    Public Property Indicador As String
    Public Property Valor As Decimal
    Public Sub New(ByVal Año As Integer, ByVal Indicador As String, ByVal Valor As Decimal)
        Me.Año = Año
        Me.Indicador = Indicador
        Me.Valor = Valor
    End Sub
End Class
