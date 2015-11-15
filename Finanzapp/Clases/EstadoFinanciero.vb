<Serializable()>
Public Class EstadoFinanciero
    Public Property ListaTransaccion As List(Of Transaccion)
    Public Property Año As Integer
    Public Sub New(ByVal Año As Integer)
        ListaTransaccion = New List(Of Transaccion)
        Me.Año = Año
    End Sub
    Public Sub AgregarTransaccion(ByVal ItemTransaccion As Transaccion)
        ListaTransaccion.Add(ItemTransaccion)
    End Sub
    Public Sub LimpiarListaTransaccion()
        ListaTransaccion.Clear()
    End Sub
    Public Sub RemoverTransaccion(ByVal ItemTransaccion As Transaccion)
        ListaTransaccion.Remove(ItemTransaccion)
    End Sub
    Public Function ObtenerTransaccion(ByVal Cuenta As String) As Transaccion
        For Each ItemTransaccion As Transaccion In ListaTransaccion
            If ItemTransaccion.Cuenta = Cuenta Then Return ItemTransaccion
        Next
        Return Nothing
    End Function
End Class
