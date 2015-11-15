Public Class ctlToolBar
    Private VentanaContenedora As Form = Nothing
    Public Sub New()
        InitializeComponent()
        EstadoInicial()
    End Sub
    Friend Sub EstablecerVentanaContenedora(ByVal VentanaContenedora As Form)
        Me.VentanaContenedora = VentanaContenedora
    End Sub
    Friend Sub Limpiar()
        If Not VentanaContenedora Is Nothing Then
            For Each ControlVentana As Control In VentanaContenedora.Controls
                If TypeOf (ControlVentana) Is TextBox Then
                    CType(ControlVentana, TextBox).Text = String.Empty
                ElseIf TypeOf (ControlVentana) Is CheckBox Then
                    CType(ControlVentana, CheckBox).Checked = False
                ElseIf TypeOf (ControlVentana) Is DataGridView
                    CType(ControlVentana, DataGridView).Rows.Clear()
                ElseIf TypeOf (ControlVentana) Is ComboBox
                    CType(ControlVentana, ComboBox).SelectedIndex = -1
                End If
            Next
        End If
    End Sub
    Friend Sub HabilitarControles(ByVal Habilitar As Boolean)
        If Not VentanaContenedora Is Nothing Then
            For Each ControlVentana As Control In VentanaContenedora.Controls
                If TypeOf (ControlVentana) IsNot ctlToolBar Then ControlVentana.Enabled = Habilitar
            Next
        End If
    End Sub
    Friend Sub EstadoInicial()
        btnAgregar.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False
        btnGuardar.Enabled = False
        btnBuscar.Enabled = True
    End Sub
    Friend Sub EstadoEdicion()
        btnAgregar.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnBuscar.Enabled = False
    End Sub
    Friend Sub EstadoEspera()
        btnAgregar.Enabled = False
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        btnBuscar.Enabled = False
        btnGuardar.Enabled = False
        btnCancelar.Enabled = True
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Limpiar()
        EstadoInicial()
        HabilitarControles(False)
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        EstadoEdicion()
        HabilitarControles(True)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        EstadoEdicion()
        HabilitarControles(True)
    End Sub
End Class
