Public Class frmMDI
    Private Sub itmSalir_Click(sender As Object, e As EventArgs) Handles itmSalir.Click
        Application.Exit()
    End Sub

    Private Sub itmCuentas_Click(sender As Object, e As EventArgs) Handles itmCuentas.Click
        frmCuenta.MdiParent = Me
        frmCuenta.Show()
    End Sub

    Private Sub itmAcercaDe_Click(sender As Object, e As EventArgs) Handles itmAcercaDe.Click
    End Sub
End Class
