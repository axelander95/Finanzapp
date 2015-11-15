Public Class frmBusqueda
    Public Property CuentaSeleccionada As Cuenta = Nothing
    Private Sub Buscar()
        Dim Busqueda As String = txtBusqueda.Text
        Dim ObjetoArchivo As List(Of Cuenta) = CargarArchivo(ArchivoCuentasPath)
        If ObjetoArchivo IsNot Nothing Then
            If Busqueda = String.Empty Then
                lbxLista.DataSource = ObjetoArchivo
            Else
                Dim ListaTemporal As New List(Of Cuenta)()
                For Each ObjetoCuenta As Cuenta In ObjetoArchivo
                    If ObjetoCuenta.Descripcion Like Busqueda Or ObjetoCuenta.Codigo Like Busqueda Then
                        ListaTemporal.Add(ObjetoCuenta)
                    End If
                Next
                lbxLista.DataSource = ListaTemporal
            End If
            lbxLista.DisplayMember = "Descripcion"
            lbxLista.ValueMember = "Codigo"
            If lbxLista.Items.Count = 0 Then btnSeleccionar.Enabled = False Else btnSeleccionar.Enabled = True
        End If
    End Sub

    Private Sub btnBusqueda_Click(sender As Object, e As EventArgs) Handles btnBusqueda.Click
        Buscar()
    End Sub

    Private Sub txtBusqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBusqueda.KeyUp
        Buscar()
    End Sub

    Private Sub frmBusqueda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Buscar()
    End Sub
    Private Sub Seleccionar()
        If lbxLista.SelectedIndex > -1 Then
            CuentaSeleccionada = lbxLista.SelectedItem
            Close()
        Else
            MessageBox.Show("Debe seleccionar una cuenta.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        Seleccionar()
    End Sub

    Private Sub lbxLista_DoubleClick(sender As Object, e As EventArgs) Handles lbxLista.DoubleClick
        Seleccionar()
    End Sub
End Class