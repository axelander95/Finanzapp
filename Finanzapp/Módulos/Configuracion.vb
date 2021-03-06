﻿Imports System.Configuration
Imports System.IO
Module Configuracion
    Public ArchivoUsuarioPath As String = Nothing
    Public DirectorioCuentas As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "/" & ConfigurationManager.AppSettings("DirectorioCuentas")
    Public ArchivoIndicadoresEVA As String = DirectorioCuentas & "/" & ConfigurationManager.AppSettings("ArchivoIndicadoresEVA")
    Public ArchivoClasificacionCuentasPath As String = DirectorioCuentas & "/" & ConfigurationManager.AppSettings("ArchivoClasificacionCuentas")
    Public ArchivoCuentasPath As String = DirectorioCuentas & "/" & ConfigurationManager.AppSettings("ArchivoCuentas")
    Public ArchivoPrincipal As Proyecto = Nothing
    Public Sub InicializarClasificacionCuentas()
        Dim ObjetoArchivo As List(Of ClasificacionCuenta) = CargarArchivo(ArchivoClasificacionCuentasPath)
        If ObjetoArchivo Is Nothing Then
            ObjetoArchivo = New List(Of ClasificacionCuenta)
            ObjetoArchivo.Add(New ClasificacionCuenta("AC", "ACTIVO CORRIENTE"))
            ObjetoArchivo.Add(New ClasificacionCuenta("AF", "ACTIVO FIJO"))
            ObjetoArchivo.Add(New ClasificacionCuenta("PC", "PASIVO CORRIENTE"))
            ObjetoArchivo.Add(New ClasificacionCuenta("PD", "PASIVO DIFERIDO"))
            ObjetoArchivo.Add(New ClasificacionCuenta("PAT", "PATRIMONIO"))
            ObjetoArchivo.Add(New ClasificacionCuenta("INB", "INGRESO BRUTO"))
            ObjetoArchivo.Add(New ClasificacionCuenta("COS", "COSTO"))
            ObjetoArchivo.Add(New ClasificacionCuenta("GAO", "GASTO DE OPERACIÓN"))
            ObjetoArchivo.Add(New ClasificacionCuenta("OIN", "OTRO INGRESO NO OPERATIVO"))
            ObjetoArchivo.Add(New ClasificacionCuenta("OGA", "OTRO GASTO NO OPERATIVO"))
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
            ObjetoArchivo.Add(New Cuenta("VTS", "INB", "VENTAS", False))
            GuardarArchivo(ArchivoCuentasPath, ObjetoArchivo)
        End If
    End Sub
    Public Sub InicializarDirectorioCuentas()
        If Not Directory.Exists(DirectorioCuentas) Then
            Directory.CreateDirectory(DirectorioCuentas)
        End If
    End Sub
    Public Sub InicializarIndicadoresEVA()
        Dim ObjetoArchivo As List(Of IndicadorEVA) = CargarArchivo(ArchivoIndicadoresEVA)
        If ObjetoArchivo Is Nothing Then
            ObjetoArchivo = New List(Of IndicadorEVA)
            ObjetoArchivo.Add(New IndicadorEVA("M", "MARGEN DE UTILIDAD"))
            ObjetoArchivo.Add(New IndicadorEVA("R", "ROTACIÓN DE ACTIVOS"))
            ObjetoArchivo.Add(New IndicadorEVA("ROI", "RETORNO DE LA INVERSIÓN"))
            ObjetoArchivo.Add(New IndicadorEVA("MO", "MARGEN OPERACIONAL"))
            ObjetoArchivo.Add(New IndicadorEVA("A", "GRADO DE ENDEUDAMIENTO"))
            ObjetoArchivo.Add(New IndicadorEVA("ROE", "RETORNO DEL PATRIMONIO"))
            ObjetoArchivo.Add(New IndicadorEVA("D", "ENDEUDAMIENTO"))
            ObjetoArchivo.Add(New IndicadorEVA("I**", "TASA MÁXIMA DE INTERÉS PARA PAGAR"))
            ObjetoArchivo.Add(New IndicadorEVA("IE", "COSTO PROMEDIO DE LAS DEUDAS"))
            ObjetoArchivo.Add(New IndicadorEVA("TI", "TASA IMPOSITIVA"))
            ObjetoArchivo.Add(New IndicadorEVA("TCP", "TASA DE INTERÉS A CORTO PLAZO"))
            ObjetoArchivo.Add(New IndicadorEVA("CC", "COSTO DE OPORTUNIDAD DEL ACCIONISTA"))
            ObjetoArchivo.Add(New IndicadorEVA("TIP", "TASA DE INTERES A LARGO PLAZO"))
            ObjetoArchivo.Add(New IndicadorEVA("RCP", "RENDIMIENTO DE CAPITAL PROPIO"))
            ObjetoArchivo.Add(New IndicadorEVA("CAF", "COEFICIENTE DE APALANCAMIENTO FINANCIERO"))
            ObjetoArchivo.Add(New IndicadorEVA("CI", "COSTO DE DEUDA PONDERADA (ANUAL)"))
            ObjetoArchivo.Add(New IndicadorEVA("CPPC", "COSTO PROMEDIO PONDERADO DE CAPITAL"))
            GuardarArchivo(ArchivoIndicadoresEVA, ObjetoArchivo)
        End If
    End Sub
End Module
