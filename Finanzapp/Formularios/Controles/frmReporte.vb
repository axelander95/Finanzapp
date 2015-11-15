Imports Microsoft.Reporting.WinForms
Public Class frmReporte
    Private Parametros As List(Of ReportParameter) = Nothing
    Private ConjuntoDatos As List(Of ReportDataSource) = Nothing
    Private ReportePath As String = Nothing
    Private Sub frmReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        rpvEstadoFinanciero.RefreshReport()
        CargarAños(cmbAño)
    End Sub
    Private Sub LlenarParametrosCompartidos()
        Parametros.Add(New ReportParameter("rppRuc", " RUC: " & ArchivoPrincipal.ObjetoEmpresa.RUC))
        Parametros.Add(New ReportParameter("rppDireccion", "DIRECCIÓN: " & ArchivoPrincipal.ObjetoEmpresa.Direccion))
        Parametros.Add(New ReportParameter("rppTelefono", "TELÉFONO: " & ArchivoPrincipal.ObjetoEmpresa.Telefono))
        Parametros.Add(New ReportParameter("rppCelular", "CELULAR: " & ArchivoPrincipal.ObjetoEmpresa.Celular))
        Parametros.Add(New ReportParameter("rppCorreoElectronico", "CORREO ELECTRÓNICO: " & ArchivoPrincipal.ObjetoEmpresa.CorreoElectronico))
        Parametros.Add(New ReportParameter("rppPaginaWeb", "SITIO WEB: " & ArchivoPrincipal.ObjetoEmpresa.PaginaWeb))
        Parametros.Add(New ReportParameter("rppNombreEmpresa", ArchivoPrincipal.ObjetoEmpresa.Nombre))
        Parametros.Add(New ReportParameter("rppAño", "AL 31 DE DICIEMBRE DE " & cmbAño.SelectedItem.ToString()))
    End Sub
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        If cmbAño.SelectedIndex > -1 And cmbEstadoFinanciero.SelectedIndex > -1 Then
            Parametros = New List(Of ReportParameter)
            ConjuntoDatos = New List(Of ReportDataSource)
            LlenarParametrosCompartidos()
            If cmbEstadoFinanciero.SelectedIndex = 0 Then BalanceGeneral() Else If cmbEstadoFinanciero.SelectedIndex = 1 Then EstadoResultados()
            rpvEstadoFinanciero.LocalReport.ReportEmbeddedResource = ReportePath
            rpvEstadoFinanciero.LocalReport.SetParameters(Parametros)
            For Each Origen As ReportDataSource In ConjuntoDatos
                rpvEstadoFinanciero.LocalReport.DataSources.Add(Origen)
            Next
            rpvEstadoFinanciero.LocalReport.Refresh()
            rpvEstadoFinanciero.RefreshReport()
        Else
            MessageBox.Show("Debe seleccionar el año y el tipo de estado financiero.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub BalanceGeneral()
        ReportePath = "FinanzApp.rptBalanceGeneral.rdlc"
        AgregarOrigenDeDatos("rppTotalActivoCorriente", "AC", "dstActivoCorriente")
        AgregarOrigenDeDatos("rppTotalPasivoCorriente", "PC", "dstPasivoCorriente")
        AgregarOrigenDeDatos("rppTotalActivoFijo", "AF", "dstActivoFijo")
        AgregarOrigenDeDatos("rppTotalPasivoDiferido", "PD", "dstPasivoDiferido")
        AgregarOrigenDeDatos("rppPatrimonioTotal", "PAT", "dstPatrimonio")
        Dim ActivoTotal As Decimal = ArchivoPrincipal.ObtenerTotalPorClasificacion("AC", cmbAño.SelectedItem) +
            ArchivoPrincipal.ObtenerTotalPorClasificacion("AF", cmbAño.SelectedItem)
        Dim PasivoTotal As Decimal = ArchivoPrincipal.ObtenerTotalPorClasificacion("PC", cmbAño.SelectedItem) +
            ArchivoPrincipal.ObtenerTotalPorClasificacion("PD", cmbAño.SelectedItem)
        Dim CapitalTotal As Decimal = ArchivoPrincipal.ObtenerTotalPorClasificacion("PAT", cmbAño.SelectedItem)
        Dim CapitalPasivo As Decimal = CapitalTotal + PasivoTotal
        Parametros.Add(New ReportParameter("rppActivoTotal", ActivoTotal.ToString()))
        Parametros.Add(New ReportParameter("rppPasivoTotal", PasivoTotal.ToString()))
        Parametros.Add(New ReportParameter("rppPasivoPatrimonio", CapitalPasivo.ToString()))
    End Sub
    Private Sub EstadoResultados()
        ReportePath = "FinanzApp.rptEstadoResultados.rdlc"
        Dim IngresosBrutos As Decimal = AgregarOrigenDeDatos("INB", "dstIngresosNetos")
        Dim Costos As Decimal = AgregarOrigenDeDatos("COS", "dstCostos")
        Dim UtilidadBruta As Decimal = IngresosBrutos - Costos
        Dim GastosOperacion As Decimal = AgregarOrigenDeDatos("GAO", "dstGastosOperacion")
        Dim UtilidadOperacion As Decimal = UtilidadBruta - GastosOperacion
        Dim OtrosIngresos As Decimal = AgregarOrigenDeDatos("OIN", "dstOtrosIngresos")
        Dim OtrosGastos As Decimal = AgregarOrigenDeDatos("OGA", "dstOtrosGastos")
        Dim UAI As Decimal = UtilidadOperacion + OtrosIngresos - OtrosGastos
        Dim Impuestos As Decimal = 0
        Dim UtilidadNeta As Decimal = UAI - Impuestos
        Parametros.Add(New ReportParameter("rppUtilidadBruta", UtilidadBruta.ToString()))
        Parametros.Add(New ReportParameter("rppUtilidadOperacion", UtilidadOperacion.ToString()))
        Parametros.Add(New ReportParameter("rppUAI", UAI.ToString()))
        Parametros.Add(New ReportParameter("rppUtilidadNeta", UtilidadNeta.ToString()))
    End Sub
    Private Sub AgregarOrigenDeDatos(ByVal ParametroTotal As String, ByVal ClasificacionCuenta As String,
                                     ByVal NombreTabla As String)
        Dim ListaTransaccion As New List(Of Transaccion)
        Dim Total As Decimal = ArchivoPrincipal.ObtenerTransaccionesPorClasificacion(ListaTransaccion, ClasificacionCuenta, cmbAño.SelectedItem)
        ConjuntoDatos.Add(New ReportDataSource(NombreTabla, ListaTransaccion))
        Parametros.Add(New ReportParameter(ParametroTotal, Total.ToString()))
    End Sub
    Private Function AgregarOrigenDeDatos(ByVal ClasificacionCuenta As String, ByVal NombreTabla As String) As Decimal
        Dim ListaTransaccion As New List(Of Transaccion)
        Dim Total As Decimal = ArchivoPrincipal.ObtenerTransaccionesPorClasificacion(ListaTransaccion, ClasificacionCuenta, cmbAño.SelectedItem)
        ConjuntoDatos.Add(New ReportDataSource(NombreTabla, ListaTransaccion))
        Return Total
    End Function
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub
End Class