Public Class frmConfiguracion
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub frmConfiguracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombreEmpresa.Text = ArchivoPrincipal.ObjetoEmpresa.Nombre
        txtDireccion.Text = ArchivoPrincipal.ObjetoEmpresa.Direccion
        txtRuc.Text = ArchivoPrincipal.ObjetoEmpresa.RUC
        txtCelular.Text = ArchivoPrincipal.ObjetoEmpresa.Celular
        txtTelefono.Text = ArchivoPrincipal.ObjetoEmpresa.Telefono
        txtPaginaWeb.Text = ArchivoPrincipal.ObjetoEmpresa.PaginaWeb
        txtCorreoElectronico.Text = ArchivoPrincipal.ObjetoEmpresa.CorreoElectronico
    End Sub
    Private Function EsPermitidoGuardar() As Boolean
        If txtRuc.Text = String.Empty Or txtNombreEmpresa.Text = String.Empty Or txtDireccion.Text = String.Empty Then
            MessageBox.Show("Debe llenar los campos requeridos.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Return False
        End If
        Return True
    End Function
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If EsPermitidoGuardar() Then
            ArchivoPrincipal.ObjetoEmpresa.Modificar(txtNombreEmpresa.Text, txtRuc.Text, txtDireccion.Text,
                                                     txtTelefono.Text, txtCelular.Text, txtCorreoElectronico.Text,
                                                     txtPaginaWeb.Text)
            MessageBox.Show("Los cambios fueron almacenados con éxito.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class