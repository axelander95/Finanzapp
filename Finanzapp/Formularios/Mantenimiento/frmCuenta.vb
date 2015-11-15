Public Class frmCuenta
    Private btnBuscar As ToolStripButton, btnGuardar As ToolStripButton, btnModificar As ToolStripButton,
        btnCancelar As ToolStripButton, btnEliminar As ToolStripButton, Modificacion As Boolean = False,
        ObjetoArchivo As List(Of Cuenta)
    Public Sub New()
        InitializeComponent()
        btnBuscar = ctlToolBarCuenta.btnBuscar
        ObjetoArchivo = CargarArchivo(ArchivoCuentasPath)
        AddHandler btnBuscar.Click, AddressOf Buscar
        btnGuardar = ctlToolBarCuenta.btnGuardar
        AddHandler btnGuardar.Click, AddressOf Guardar
        btnModificar = ctlToolBarCuenta.btnModificar
        AddHandler btnModificar.Click, AddressOf Modificar
        btnCancelar = ctlToolBarCuenta.btnCancelar
        AddHandler btnCancelar.Click, AddressOf Cancelar
        btnEliminar = ctlToolBarCuenta.btnEliminar
        AddHandler btnEliminar.Click, AddressOf Eliminar
    End Sub
    Private Sub Modificar()
        txtCodigo.ReadOnly = True
        Modificacion = True
    End Sub
    Private Sub Cancelar()
        Modificacion = False
        txtCodigo.ReadOnly = False
    End Sub
    Private Sub Eliminar()
        Dim Result = MsgBox("¿Estás seguro que deseas eliminar esta cuenta?", MsgBoxStyle.YesNo, "Mensaje del Sistema")
        If Result = MsgBoxResult.Yes Then
            Dim ObjetoCuenta As Cuenta = ObtenerCuenta(txtCodigo.Text)
            ObjetoArchivo.Remove(ObjetoCuenta)
            Cancelar()
            ctlToolBarCuenta.EstadoInicial()
            ctlToolBarCuenta.HabilitarControles(False)
            ctlToolBarCuenta.Limpiar()
            GuardarArchivo(ArchivoCuentasPath, ObjetoArchivo)
        End If
    End Sub
    Private Sub Buscar()
        Dim Busqueda As New frmBusqueda()
        Busqueda.ShowDialog()
        If Busqueda.CuentaSeleccionada IsNot Nothing Then
            txtCodigo.Text = Busqueda.CuentaSeleccionada.Codigo
            txtDescripcion.Text = Busqueda.CuentaSeleccionada.Descripcion
            cmbClasificacion.SelectedValue = Busqueda.CuentaSeleccionada.Clasificacion
            chkNegatividad.Checked = Busqueda.CuentaSeleccionada.Negativa
            ctlToolBarCuenta.EstadoEspera()
            ctlToolBarCuenta.HabilitarControles(False)
        End If
    End Sub
    Private Sub frmCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ctlToolBarCuenta.EstablecerVentanaContenedora(Me)
        ctlToolBarCuenta.HabilitarControles(False)
        CargarCalsificacionCuenta()
    End Sub
    Private Sub CargarCalsificacionCuenta()
        Dim ObjetoArchivo As List(Of ClasificacionCuenta) = CargarArchivo(ArchivoClasificacionCuentasPath)
        If ObjetoArchivo IsNot Nothing Then
            cmbClasificacion.DataSource = ObjetoArchivo
            cmbClasificacion.DisplayMember = "Descripcion"
            cmbClasificacion.ValueMember = "Codigo"
            cmbClasificacion.SelectedIndex = -1
        End If
    End Sub
    Private Sub Guardar()
        If EsPermitidoGuardar() Then
            ObjetoArchivo = CargarArchivo(ArchivoCuentasPath)
            If ObjetoArchivo Is Nothing Then ObjetoArchivo = New List(Of Cuenta)()
            If Not Modificacion Then
                If Not ExisteCuenta(txtCodigo.Text) Then
                    Dim ObjetoCuenta As New Cuenta(txtCodigo.Text, cmbClasificacion.SelectedValue, txtDescripcion.Text,
                                           chkNegatividad.Checked)
                    ObjetoArchivo.Add(ObjetoCuenta)
                    MessageBox.Show("La cuenta '" & ObjetoCuenta.Descripcion & " fue ingresada con éxito.",
                                    "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Ya existe una cuenta con el mismo código, no se puede continuar.",
                                    "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If
            Else
                Dim ObjetoCuenta As Cuenta = ObtenerCuenta(txtCodigo.Text)
                ObjetoCuenta.Descripcion = txtDescripcion.Text
                ObjetoCuenta.Clasificacion = cmbClasificacion.SelectedValue
                ObjetoCuenta.Negativa = chkNegatividad.Checked
                MessageBox.Show("La cuenta " & ObjetoCuenta.Descripcion & " ha sido modificada con éxito.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            ctlToolBarCuenta.EstadoEspera()
            ctlToolBarCuenta.HabilitarControles(False)
            GuardarArchivo(ArchivoCuentasPath, ObjetoArchivo)
        End If
    End Sub
    Private Function EsPermitidoGuardar() As Boolean
        Dim Mensaje As String = Nothing
        If txtCodigo.Text = String.Empty Then
            Mensaje = "Debe ingresar el código de la cuenta."
        ElseIf txtDescripcion.Text = String.Empty Then
            Mensaje = "Debe ingresar la descripción de la cuenta."
        ElseIf cmbClasificacion.SelectedIndex = -1
            Mensaje = "Debe seleccionar la clasificación de la cuenta."
        End If
        If Mensaje Is Nothing Then
            Return True
        Else
            MessageBox.Show(Mensaje, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Return False
        End If
    End Function
    Private Function ExisteCuenta(ByVal Cuenta As String) As Boolean
        For Each ObjetoCuenta As Cuenta In ObjetoArchivo
            If ObjetoCuenta.Codigo = Cuenta Then Return True
        Next
        Return False
    End Function
    Private Function ObtenerCuenta(ByVal Cuenta As String) As Cuenta
        For Each ObjetoCuenta As Cuenta In ObjetoArchivo
            If ObjetoCuenta.Codigo = Cuenta Then Return ObjetoCuenta
        Next
        Return Nothing
    End Function
End Class