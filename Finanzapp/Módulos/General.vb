Module General
    Public Sub CargarAños(ByVal ComboBoxAños As ComboBox)
        For Año As Integer = 1980 To Today.Year + 30
            ComboBoxAños.Items.Add(Año)
        Next
    End Sub
    Public Function ObtenerIngresosBrutos(ByVal Año As Integer) As Decimal
        Return ArchivoPrincipal.ObtenerTotalPorClasificacion("INB", Año)
    End Function
    Public Function ObtenerCostos(ByVal Año As Integer) As Decimal
        Return ArchivoPrincipal.ObtenerTotalPorClasificacion("COS", Año)
    End Function
    Public Function ObtenerUtilidadBruta(ByVal Año As Integer) As Decimal
        Dim UtilidadBruta As Decimal = 0
        Dim IngresosBrutos As Decimal = ObtenerIngresosBrutos(Año)
        Dim Costos As Decimal = ObtenerCostos(Año)
        UtilidadBruta = IngresosBrutos - Costos
        Return UtilidadBruta
    End Function
    Public Function ObtenerGastosOperacion(ByVal Año As Integer) As Decimal
        Return ArchivoPrincipal.ObtenerTotalPorClasificacion("GAO", Año)
    End Function
    Public Function ObtenerOtrosIngresos(ByVal Año As Integer) As Decimal
        Return ArchivoPrincipal.ObtenerTotalPorClasificacion("OIN", Año)
    End Function
    Public Function ObtenerOtrosGastos(ByVal Año As Integer) As Decimal
        Return ArchivoPrincipal.ObtenerTotalPorClasificacion("OGA", Año)
    End Function
    Public Function ObtenerUtilidadOperacion(ByVal Año As Integer) As Decimal
        Dim UtilidadBruta As Decimal = ObtenerUtilidadBruta(Año)
        Dim GastosOperacion As Decimal = ObtenerGastosOperacion(Año)
        Dim UtilidadOperacion As Decimal = UtilidadBruta - GastosOperacion
        Return UtilidadOperacion
    End Function
    Public Function ObtenerUAI(ByVal Año As Integer) As Decimal
        Dim UtilidadOperacion As Decimal = ObtenerUtilidadOperacion(Año)
        Dim OtrosIngresos As Decimal = ObtenerOtrosIngresos(Año)
        Dim OtrosGastos As Decimal = ObtenerOtrosGastos(Año)
        Dim UAI As Decimal = UtilidadOperacion + OtrosIngresos - OtrosGastos
        Return UAI
    End Function
    Public Function ObtenerActivoCorriente(ByVal Año As Integer) As Decimal
        Return ArchivoPrincipal.ObtenerTotalPorClasificacion("AC", Año)
    End Function
    Public Function ObtenerActivoFijo(ByVal Año As Integer) As Decimal
        Return ArchivoPrincipal.ObtenerTotalPorClasificacion("AF", Año)
    End Function
    Public Function ObtenerActivoTotal(ByVal Año As Integer) As Decimal
        Dim ActivoTotal As Decimal = 0
        Dim ActivoCorriente As Decimal = ObtenerActivoCorriente(Año)
        Dim ActivoFijo As Decimal = ObtenerActivoFijo(Año)
        ActivoTotal = ActivoCorriente + ActivoFijo
        Return ActivoTotal
    End Function
    Public Function ObtenerPasivoCorriente(ByVal Año As Integer) As Decimal
        Return ArchivoPrincipal.ObtenerTotalPorClasificacion("PC", Año)
    End Function
    Public Function ObtenerPasivoDiferido(ByVal Año As Integer) As Decimal
        Return ArchivoPrincipal.ObtenerTotalPorClasificacion("PD", Año)
    End Function
    Public Function ObtenerPasivoTotal(ByVal Año As Integer) As Decimal
        Dim PasivoTotal As Decimal = 0
        Dim PasivoCorriente As Decimal = ObtenerPasivoCorriente(Año)
        Dim PasivoDiferido As Decimal = ObtenerPasivoDiferido(Año)
        PasivoTotal = PasivoCorriente + PasivoDiferido
        Return PasivoTotal
    End Function
    Public Function ObtenerPatrimonio(ByVal Año As Integer) As Decimal
        Return ArchivoPrincipal.ObtenerTotalPorClasificacion("PAT", Año)
    End Function
    Public Function ObtenerPasivoPatrimonio(ByVal Año As Integer) As Decimal
        Dim PasivoPatrimonio As Decimal = 0
        Dim PasivoTotal As Decimal = ObtenerPasivoTotal(Año)
        Dim Patrimonio As Decimal = ObtenerPatrimonio(Año)
        PasivoPatrimonio = PasivoTotal + Patrimonio
        Return PasivoPatrimonio
    End Function
    Public Function BalanceGeneralEquilibrado(ByVal Año As Integer) As Decimal
        Dim ActivoTotal As Decimal = ObtenerActivoTotal(Año)
        Dim PasivoPatrimonio As Decimal = ObtenerPasivoPatrimonio(Año)
        If ActivoTotal <> PasivoPatrimonio Then Return False Else Return True
    End Function
End Module
