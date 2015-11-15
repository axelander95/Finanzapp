Public Class frmMDI
    Private Sub itmSalir_Click(sender As Object, e As EventArgs) Handles itmSalir.Click
        Application.Exit()
    End Sub

    Private Sub itmCuentas_Click(sender As Object, e As EventArgs) Handles itmCuentas.Click
        MostrarVentana(frmCuenta)
    End Sub

    Private Sub itmAcercaDe_Click(sender As Object, e As EventArgs) Handles itmAcercaDe.Click
    End Sub

    Private Sub itmReportes_Click(sender As Object, e As EventArgs) Handles itmReportes.Click
        MostrarVentana(frmReporte)
    End Sub

    Private Sub itmTransacciones_Click(sender As Object, e As EventArgs) Handles itmTransacciones.Click
        MostrarVentana(frmTransaccion)
    End Sub

    Private Sub itmConfiguracion_Click(sender As Object, e As EventArgs) Handles itmConfiguracion.Click
        MostrarVentana(frmConfiguracion)
    End Sub
    Private Sub MostrarVentana(ByVal Ventana As Form)
        Ventana.MdiParent = Me
        Ventana.Show()
    End Sub

    Private Sub frmMDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarClasificacionCuentas()
        InicializarCuentas()
    End Sub
End Class
