<Serializable()>
Public Class Proyecto
    Public Property ListaEstadoFinanciero As List(Of EstadoFinanciero)
    Public Property ObjetoEmpresa As Empresa
    Public Sub New()
        ListaEstadoFinanciero = New List(Of EstadoFinanciero)
        ObjetoEmpresa = New Empresa()
    End Sub
    Public Function ObtenerEstadoFinanciero(ByVal Año As Integer)
        For Each ObjetoEstadoFinanciero In ListaEstadoFinanciero
            If ObjetoEstadoFinanciero.Año = Año Then Return ObjetoEstadoFinanciero
        Next
        Return Nothing
    End Function
    Public Function ObtenerTransaccionesPorClasificacion(ByRef ListaVacia As List(Of Transaccion),
                                                         ByVal ClasificacionCuenta As String, ByVal Año As Integer) As Decimal
        Dim Total As Decimal = 0
        Dim ObjetoEstadoFinanciero As EstadoFinanciero = ObtenerEstadoFinanciero(Año)
        If ObjetoEstadoFinanciero IsNot Nothing Then
            For Each ObjetoTransaccion As Transaccion In ObjetoEstadoFinanciero.ListaTransaccion
                Dim ObjetoCuenta As Cuenta = ObtenerCuenta(ObjetoTransaccion.Cuenta)
                If ObjetoCuenta IsNot Nothing Then
                    If ObjetoCuenta.Clasificacion = ClasificacionCuenta Then
                        ListaVacia.Add(New Transaccion(ObjetoCuenta.Descripcion, ObjetoTransaccion.Valor))
                        If ObjetoCuenta.Negativa Then Total = Total - ObjetoTransaccion.Valor Else Total = Total + ObjetoTransaccion.Valor
                    End If
                End If
            Next
        End If
        Return Total
    End Function
    Public Function ObtenerTotalPorClasificacion(ByVal ClasificacionCuenta As String, ByVal Año As Integer) As Decimal
        Dim Total As Decimal = 0
        Dim ObjetoEstadoFinanciero As EstadoFinanciero = ObtenerEstadoFinanciero(Año)
        If ObjetoEstadoFinanciero IsNot Nothing Then
            For Each ObjetoTransaccion As Transaccion In ObjetoEstadoFinanciero.ListaTransaccion
                Dim ObjetoCuenta As Cuenta = ObtenerCuenta(ObjetoTransaccion.Cuenta)
                If ObjetoCuenta IsNot Nothing Then
                    If ObjetoCuenta.Clasificacion = ClasificacionCuenta Then
                        If ObjetoCuenta.Negativa Then Total = Total - ObjetoTransaccion.Valor Else Total = Total + ObjetoTransaccion.Valor
                    End If
                End If
            Next
        End If
        Return Total
    End Function
    Public Function ObtenerCuenta(ByVal Cuenta As String) As Cuenta
        Dim ObjetoArchivo As List(Of Cuenta) = CargarArchivo(ArchivoCuentasPath)
        If ObjetoArchivo IsNot Nothing Then
            For Each ObjetoCuenta As Cuenta In ObjetoArchivo
                If ObjetoCuenta.Codigo = Cuenta Then
                    Return ObjetoCuenta
                End If
            Next
        End If
        Return Nothing
    End Function
End Class
