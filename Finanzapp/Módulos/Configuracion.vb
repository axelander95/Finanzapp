Imports System.Configuration
Module Configuracion
    Public ArchivoUsuarioPath As String = Nothing
    Public ArchivoClasificacionCuentasPath As String = Application.StartupPath & "/" & ConfigurationManager.AppSettings("ArchivoClasificacionCuentas")
    Public ArchivoCuentasPath As String = Application.StartupPath & "/" & ConfigurationManager.AppSettings("ArchivoCuentas")
    Public Sub InicializarClasificacionCuentas()
        Dim ObjetoArchivo As List(Of ClasificacionCuenta) = CargarArchivo(ArchivoClasificacionCuentasPath)
        If ObjetoArchivo Is Nothing Then
            ObjetoArchivo = New List(Of ClasificacionCuenta)
            ObjetoArchivo.Add(New ClasificacionCuenta("AC", "ACTIVO CORRIENTE"))
            ObjetoArchivo.Add(New ClasificacionCuenta("AF", "ACTIVO FIJO"))
            ObjetoArchivo.Add(New ClasificacionCuenta("PC", "PASIVO CORRIENTE"))
            ObjetoArchivo.Add(New ClasificacionCuenta("PD", "PASIVO DIFERIDO"))
            ObjetoArchivo.Add(New ClasificacionCuenta("PAT", "PATRIMONIO"))
            ObjetoArchivo.Add(New ClasificacionCuenta("IN", "INGRESO"))
            ObjetoArchivo.Add(New ClasificacionCuenta("EG", "EGRESO"))
            GuardarArchivo(ArchivoClasificacionCuentasPath, ObjetoArchivo)
        End If
    End Sub
    Public Sub InicializarCuentas()
        Dim ObjetoArchivo As List(Of Cuenta) = CargarArchivo(ArchivoCuentasPath)
        If ObjetoArchivo Is Nothing Then
            ObjetoArchivo = New List(Of Cuenta)
            ObjetoArchivo.Add(New Cuenta("CAJ", "AC", "CAJA O EFECTIVO", False))
            ObjetoArchivo.Add(New Cuenta("BAN", "AC", "BANCO", False))
            ObjetoArchivo.Add(New Cuenta("CXC", "AC", "CUENTAS POR COBRAR", False))
            ObjetoArchivo.Add(New Cuenta("CLI", "AC", "CLIENTES", False))
            ObjetoArchivo.Add(New Cuenta("DED", "AC", "DEUDORES DIVERSOS", False))
            ObjetoArchivo.Add(New Cuenta("ALM", "AC", "ALMACÉN", False))
            ObjetoArchivo.Add(New Cuenta("EDO", "AF", "EQUIPOS DE OFICINA", False))
            ObjetoArchivo.Add(New Cuenta("EDF", "AF", "EDIFICIOS", False))
            ObjetoArchivo.Add(New Cuenta("TER", "AF", "TERRENOS", False))
            ObjetoArchivo.Add(New Cuenta("EQR", "AF", "EQUIPOS DE REPARTO", False))
            ObjetoArchivo.Add(New Cuenta("PYM", "AF", "PATENTES Y MARCAS", False))
            ObjetoArchivo.Add(New Cuenta("DEG", "AF", "DEPÓSITOS EN GARANTÍA", False))
            ObjetoArchivo.Add(New Cuenta("DEH", "AF", "DEPÓSITOS HIPOTECARIOS", False))
            ObjetoArchivo.Add(New Cuenta("PYP", "AF", "PROPAGANDA Y PUBLICIDAD", False))
            ObjetoArchivo.Add(New Cuenta("PRO", "PC", "PROVEEDORES", False))
            ObjetoArchivo.Add(New Cuenta("ACR", "PC", "ACREEDORES", False))
            ObjetoArchivo.Add(New Cuenta("IXP", "PC", "IMPUESTOS POR PAGAR", False))
            ObjetoArchivo.Add(New Cuenta("CXP", "PC", "CUENTAS POR PAGAR", False))
            GuardarArchivo(ArchivoCuentasPath, ObjetoArchivo)
        End If
    End Sub
End Module
