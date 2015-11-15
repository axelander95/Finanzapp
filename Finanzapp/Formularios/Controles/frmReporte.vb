Public Class frmReporte
    Private Sub frmReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        rpvEstadoFinanciero.RefreshReport()
    End Sub
End Class