Public Class frmEVA
    Private ListaIndicadorEVATransaccion As New List(Of IndicadorEVATransaccion)
    Private Sub GenerarAnalisis()
        grvEVA.Rows.Clear()
        grvEVA.Columns.Clear()
        Dim PrimerAño As Integer = cmbPrimerAño.SelectedItem
        Dim UltimoAño As Integer = cmbUltimoAño.SelectedItem
        Dim AñoActual As Integer = PrimerAño
        Dim ListaIndicadores As List(Of IndicadorEVA) = CargarArchivo(ArchivoIndicadoresEVA)
        If ListaIndicadores IsNot Nothing Then
            Dim ColumnaDescripcion As New DataGridViewTextBoxColumn()
            grvEVA.Columns.Add(ColumnaDescripcion)
            ColumnaDescripcion.Width = 400
            ColumnaDescripcion.HeaderText = "INDICADOR"
            For Each Indicador As IndicadorEVA In ListaIndicadores
                grvEVA.Rows.Add(New DataGridViewRow)
                grvEVA.Rows(grvEVA.Rows.Count - 1).Cells(ColumnaDescripcion.Name).Value = Indicador.Descripcion
            Next
            Do
                ListaIndicadorEVATransaccion.Clear()
                Dim ColumnaAño As New DataGridViewTextBoxColumn
                ColumnaAño.Name = "ColumnaAño" & AñoActual
                ColumnaAño.Width = 100
                ColumnaAño.HeaderText = "AÑO " & AñoActual
                grvEVA.Columns.Add(ColumnaAño)
                CalcularMargenUtilidad(AñoActual)
                CalcularRotacionActivos(AñoActual)
                CalcularRetornoInversion(AñoActual)
                CalcularMargenOperacional(AñoActual)
                CalcularGradoEndeudamiento(AñoActual)
                CalcularRetornoPatrimonio(AñoActual)
                CalcularEndeudamiento(AñoActual)
                CalcularTasaMaximaInteres(AñoActual)
                CalcularCostoPromedioDeudas(AñoActual)
                CalcularTasaImpositiva(AñoActual)
                CalcularTasaInteresCortoPlazo(AñoActual)
                CalcularCostoOportunidadAccionista(AñoActual)
                CalcularTasaInteresLargoPlazo(AñoActual)
                CalcularRendimientoCapitalPropio(AñoActual)
                CalcularCoeficienteApalancamientoFinanciero(AñoActual)
                CalcularCostoDeudaPonderada(AñoActual)
                CalcularCostoPromedioPonderadoCapital(AñoActual)
                For Indice As Integer = 0 To ListaIndicadorEVATransaccion.Count - 1
                    grvEVA.Rows(Indice).Cells(ColumnaAño.Name).Value = ListaIndicadorEVATransaccion.Item(Indice).Valor
                Next
                AñoActual += 1
            Loop While (AñoActual <= UltimoAño)
        End If
    End Sub
    Private Sub CalcularMargenUtilidad(ByVal Año As Integer)
        ListaIndicadorEVATransaccion.Add(New IndicadorEVATransaccion(Año, "M", 0))
    End Sub
    Private Sub CalcularRotacionActivos(ByVal Año As Integer)
        ListaIndicadorEVATransaccion.Add(New IndicadorEVATransaccion(Año, "M", 0))
    End Sub
    Private Sub CalcularRetornoInversion(ByVal Año As Integer)
        ListaIndicadorEVATransaccion.Add(New IndicadorEVATransaccion(Año, "M", 0))
    End Sub
    Private Sub CalcularMargenOperacional(ByVal Año As Integer)
        ListaIndicadorEVATransaccion.Add(New IndicadorEVATransaccion(Año, "M", 0))
    End Sub
    Private Sub CalcularGradoEndeudamiento(ByVal Año As Integer)
        ListaIndicadorEVATransaccion.Add(New IndicadorEVATransaccion(Año, "M", 0))
    End Sub
    Private Sub CalcularRetornoPatrimonio(ByVal Año As Integer)
        ListaIndicadorEVATransaccion.Add(New IndicadorEVATransaccion(Año, "M", 0))
    End Sub
    Private Sub CalcularEndeudamiento(ByVal Año As Integer)
        ListaIndicadorEVATransaccion.Add(New IndicadorEVATransaccion(Año, "M", 0))
    End Sub
    Private Sub CalcularTasaMaximaInteres(ByVal Año As Integer)
        ListaIndicadorEVATransaccion.Add(New IndicadorEVATransaccion(Año, "M", 0))
    End Sub
    Private Sub CalcularCostoPromedioDeudas(ByVal Año As Integer)
        ListaIndicadorEVATransaccion.Add(New IndicadorEVATransaccion(Año, "M", 0))
    End Sub
    Private Sub CalcularTasaImpositiva(ByVal Año As Integer)
        ListaIndicadorEVATransaccion.Add(New IndicadorEVATransaccion(Año, "M", 0))
    End Sub
    Private Sub CalcularTasaInteresCortoPlazo(ByVal Año As Integer)
        ListaIndicadorEVATransaccion.Add(New IndicadorEVATransaccion(Año, "M", 0))
    End Sub
    Private Sub CalcularCostoOportunidadAccionista(ByVal Año As Integer)
        ListaIndicadorEVATransaccion.Add(New IndicadorEVATransaccion(Año, "M", 0))
    End Sub
    Private Sub CalcularTasaInteresLargoPlazo(ByVal Año As Integer)
        ListaIndicadorEVATransaccion.Add(New IndicadorEVATransaccion(Año, "M", 0))
    End Sub
    Private Sub CalcularRendimientoCapitalPropio(ByVal Año As Integer)
        ListaIndicadorEVATransaccion.Add(New IndicadorEVATransaccion(Año, "M", 0))
    End Sub
    Private Sub CalcularCoeficienteApalancamientoFinanciero(ByVal Año As Integer)
        ListaIndicadorEVATransaccion.Add(New IndicadorEVATransaccion(Año, "M", 0))
    End Sub
    Private Sub CalcularCostoDeudaPonderada(ByVal Año As Integer)
        ListaIndicadorEVATransaccion.Add(New IndicadorEVATransaccion(Año, "M", 0))
    End Sub
    Private Sub CalcularCostoPromedioPonderadoCapital(ByVal Año As Integer)
        ListaIndicadorEVATransaccion.Add(New IndicadorEVATransaccion(Año, "M", 0))
    End Sub
    Private Sub frmEVA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarAños(cmbPrimerAño)
        CargarAños(cmbUltimoAño)
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        If cmbPrimerAño.SelectedIndex > -1 And cmbUltimoAño.SelectedIndex > -1 And cmbUltimoAño.SelectedItem >= cmbPrimerAño.SelectedItem Then
            GenerarAnalisis()
        Else
            MessageBox.Show("No se puede generar el análisis financiero. Debe seleccionar los años a generar y considerar que el primero sea menor o igual al último.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class