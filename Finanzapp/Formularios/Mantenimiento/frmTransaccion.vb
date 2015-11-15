Public Class frmTransaccion
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
        btnEliminar.Enabled = False
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
                grvTransacciones.AllowUserToAddRows = False
                For Each ObjetoTransaccion As Transaccion In ObjetoEstadoFinanciero.ListaTransaccion
                    Dim ObjetoCuenta As Cuenta = ObtenerCuenta(ObjetoTransaccion.Cuenta)
                    If ObjetoCuenta IsNot Nothing Then
                        grvTransacciones.Rows.Add(New DataGridViewRow())
                        Dim Fila As DataGridViewRow = grvTransacciones.Rows(grvTransacciones.Rows.Count - 1)
                        Fila.Cells(txtCodigo.Name).Value = ObjetoCuenta.Codigo
                        Fila.Cells(txtCuenta.Name).Value = ObjetoCuenta.Descripcion
                        Fila.Cells(txtValor.Name).Value = ObjetoTransaccion.Valor
                    End If
                Next
                grvTransacciones.AllowUserToAddRows = True
                btnEliminar.Enabled = True
            End If
        Else
            MessageBox.Show("Debe seleccionar un año.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Function ObtenerCuenta(ByVal Cuenta As String) As Cuenta
        Dim ObjetoArchivo As List(Of Cuenta) = CargarArchivo(ArchivoCuentasPath)
        For Each ObjetoCuenta As Cuenta In ObjetoArchivo
            If ObjetoCuenta.Codigo = Cuenta Then Return ObjetoCuenta
        Next
        Return Nothing
    End Function
    Private Function ObtenerEstadoFinanciero() As EstadoFinanciero
        For Each ObjetoEstadoFinanciero In ArchivoPrincipal.ListaEstadoFinanciero
            If ObjetoEstadoFinanciero.Año = cmbAño.SelectedItem Then Return ObjetoEstadoFinanciero
        Next
        Return Nothing
    End Function
    Private Function DataGridViewEsValido() As Boolean
        Return True
    End Function
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If DataGridViewEsValido() Then
            Dim ObjetoEstadoFinanciero As EstadoFinanciero = ObtenerEstadoFinanciero()
            If ObjetoEstadoFinanciero IsNot Nothing Then ArchivoPrincipal.ListaEstadoFinanciero.Remove(ObjetoEstadoFinanciero)
            ObjetoEstadoFinanciero = New EstadoFinanciero(cmbAño.SelectedItem)
            For Each Fila As DataGridViewRow In grvTransacciones.Rows
                If Fila.Index < grvTransacciones.Rows.Count - 1 Then
                    Dim ObjetoTransaccion As New Transaccion(Fila.Cells(txtCodigo.Name).Value, Val(Fila.Cells(txtValor.Name).Value))
                    ObjetoEstadoFinanciero.AgregarTransaccion(ObjetoTransaccion)
                End If
            Next
            ArchivoPrincipal.ListaEstadoFinanciero.Add(ObjetoEstadoFinanciero)
            MessageBox.Show("Los datos fueron almacenados con éxito.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Hay datos inválidos en la lista de transacciones, por favor verifique los datos ingresados.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim Respuesta = MsgBox("¿Deseas eliminar las transacciones correspondientes al año " & cmbAño.SelectedItem & "?",
               MsgBoxStyle.YesNo, "Mensaje del Sistema")
        If Respuesta = MsgBoxResult.Yes Then
            Dim ObjetoEstadoFinanciero As EstadoFinanciero = ObtenerEstadoFinanciero()
            If ObjetoEstadoFinanciero IsNot Nothing Then ArchivoPrincipal.ListaEstadoFinanciero.Remove(ObjetoEstadoFinanciero)
            EstadoInicial()
        End If
    End Sub
End Class