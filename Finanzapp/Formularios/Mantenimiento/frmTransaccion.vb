Public Class frmTransaccion
    Private Modificacion As Boolean = False
    Private Sub frmTransaccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarAños(cmbAño)
        EstadoInicial()
    End Sub
    Private Sub EstadoInicial()
        btnSeleccionar.Enabled = True
        cmbAño.Enabled = True
        grvTransacciones.Enabled = False
        btnEliminar.Enabled = False
        btnGuardar.Enabled = False
        grvTransacciones.Rows.Clear()
        cmbAño.SelectedIndex = -1
    End Sub
    Private Sub EstadoTransaccional()
        grvTransacciones.Rows.Clear()
        cmbAño.Enabled = False
        btnSeleccionar.Enabled = False
        grvTransacciones.Enabled = True
        btnGuardar.Enabled = True
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If btnSeleccionar.Enabled Then Close() Else EstadoInicial()
    End Sub
    Private Sub BuscarCuenta(ByVal Fila As Integer)
        Dim Busqueda As New frmBusqueda()
        Busqueda.ShowDialog()
        If Busqueda.CuentaSeleccionada IsNot Nothing Then
            If Not ExisteCuenta(Busqueda.CuentaSeleccionada.Codigo) Then
                grvTransacciones.Rows(Fila).Cells(txtCodigo.Name).Value = Busqueda.CuentaSeleccionada.Codigo
                grvTransacciones.Rows(Fila).Cells(txtCuenta.Name).Value = Busqueda.CuentaSeleccionada.Descripcion
            Else
                MessageBox.Show("Esta cuenta ya ha sido ingresada con anterioridad, acción inválida.", "Mensaje del Sistema",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub
    Private Function ExisteCuenta(ByVal Cuenta As String) As Boolean
        For Each Fila As DataGridViewRow In grvTransacciones.Rows
            If Fila.Cells(txtCodigo.Name).Value = Cuenta Then Return True
        Next
        Return False
    End Function
    Private Sub grvTransacciones_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grvTransacciones.CellClick
        If e.RowIndex > -1 And e.ColumnIndex = 2 Then
            BuscarCuenta(e.RowIndex)
        End If
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        If cmbAño.SelectedIndex > -1 Then
            EstadoTransaccional()
            Dim ObjetoEstadoFinanciero As EstadoFinanciero = ObtenerEstadoFinanciero()
            If ObjetoEstadoFinanciero IsNot Nothing Then
                Modificacion = True
                For Each ObjetoTransaccion As Transaccion In ObjetoEstadoFinanciero.ListaTransaccion

                Next
            End If
        Else
            MessageBox.Show("Debe seleccionar un año.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Function ExisteAño() As Boolean
        For Each ObjetoEstadoFinanciero In ArchivoPrincipal
            If ObjetoEstadoFinanciero.Año = cmbAño.SelectedItem Then Return True
        Next
        Return False
    End Function
    Private Function ObtenerEstadoFinanciero() As EstadoFinanciero
        For Each ObjetoEstadoFinanciero In ArchivoPrincipal
            If ObjetoEstadoFinanciero.Año = cmbAño.SelectedItem Then Return ObjetoEstadoFinanciero
        Next
        Return Nothing
    End Function
End Class