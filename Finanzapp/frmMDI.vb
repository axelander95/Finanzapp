Public Class frmMDI
    Private Sub itmSalir_Click(sender As Object, e As EventArgs) Handles itmSalir.Click
        Application.Exit()
    End Sub

    Private Sub itmCuentas_Click(sender As Object, e As EventArgs) Handles itmCuentas.Click
        MostrarVentana(frmCuenta)
    End Sub

    Private Sub itmAcercaDe_Click(sender As Object, e As EventArgs) Handles itmAcercaDe.Click
        frmAcercaDe.MdiParent = Me
        frmAcercaDe.Show()
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
        InicializarDirectorioCuentas()
        InicializarClasificacionCuentas()
        InicializarCuentas()
        EstadoInicial()
    End Sub
    Private Sub EstadoInicial()
        itmTransacciones.Enabled = False
        itmReportes.Enabled = False
        itmGuardar.Enabled = False
        itmGuardarComo.Enabled = False
        itmConfiguracion.Enabled = False
        ArchivoUsuarioPath = Nothing
        ArchivoPrincipal = Nothing
        For Each VentanaHija In MdiChildren
            VentanaHija.Close()
        Next
    End Sub
    Private Sub EstadoConArchivo()
        itmTransacciones.Enabled = True
        itmReportes.Enabled = True
        itmGuardar.Enabled = True
        itmGuardarComo.Enabled = True
        itmConfiguracion.Enabled = True
    End Sub
    Private Sub Nuevo()
        If ArchivoUsuarioPath Is Nothing Then
            CrearNuevoArchivo()
        Else
            Dim Respuesta = MsgBox("Esta acción cerrará el archivo actual, ¿Deseas guardar los cambios realizados?",
                                   MsgBoxStyle.YesNoCancel, "Mensaje del Sistema")
            If Not Respuesta = MsgBoxResult.Cancel Then
                If Respuesta = MsgBoxResult.Yes Then Guardar()
                EstadoInicial()
                CrearNuevoArchivo()
            End If
        End If
    End Sub
    Private Sub CrearNuevoArchivo()
        If sfdArchivo.ShowDialog() = DialogResult.OK Then
            ArchivoUsuarioPath = sfdArchivo.FileName
            If ArchivoPrincipal Is Nothing Then ArchivoPrincipal = New Proyecto
            GuardarArchivo(ArchivoUsuarioPath, ArchivoPrincipal)
            EstadoConArchivo()
            MostrarVentana(frmTransaccion)
        Else
            EstadoInicial()
        End If
    End Sub
    Private Sub Guardar()
        GuardarArchivo(ArchivoUsuarioPath, ArchivoPrincipal)
    End Sub
    Private Sub Abrir()
        If ArchivoUsuarioPath Is Nothing Then
            AbrirArchivo()
        Else
            Dim Respuesta = MsgBox("Esta acción cerrará el archivo actual, ¿Deseas guardar los cambios realizados?",
                                   MsgBoxStyle.YesNoCancel, "Mensaje del Sistema")
            If Not Respuesta = MsgBoxResult.Cancel Then
                If Respuesta = MsgBoxResult.Yes Then Guardar()
                ArchivoUsuarioPath = Nothing
                ArchivoPrincipal = Nothing
                EstadoInicial()
                AbrirArchivo()
            End If
        End If
    End Sub
    Private Sub AbrirArchivo()
        If ofdArchivo.ShowDialog() = DialogResult.OK Then
            ArchivoUsuarioPath = ofdArchivo.FileName
            ArchivoPrincipal = CargarArchivo(ArchivoUsuarioPath)
            MostrarVentana(frmTransaccion)
            EstadoConArchivo()
        Else
            EstadoInicial()
        End If
    End Sub
    Private Sub GuardarComo()
        CrearNuevoArchivo()
    End Sub
    Private Sub itmNuevo_Click(sender As Object, e As EventArgs) Handles itmNuevo.Click
        Nuevo()
    End Sub

    Private Sub itmAbrir_Click(sender As Object, e As EventArgs) Handles itmAbrir.Click
        Abrir()
    End Sub

    Private Sub itmGuardar_Click(sender As Object, e As EventArgs) Handles itmGuardar.Click
        Guardar()
    End Sub

    Private Sub itmGuardarComo_Click(sender As Object, e As EventArgs) Handles itmGuardarComo.Click
        GuardarComo()
    End Sub

    Private Sub frmMDI_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If ArchivoUsuarioPath IsNot Nothing Then
            Dim Resultado = MsgBox("¿Deseas guardar los cambios realizados antes de cerrar la aplicación?", MsgBoxStyle.YesNoCancel, "Mensaje del Sistema")
            If Resultado = MsgBoxResult.Yes Then GuardarArchivo(ArchivoUsuarioPath, ArchivoPrincipal) Else If Resultado = MsgBoxResult.Cancel Then e.Cancel = True
        End If
    End Sub
End Class
