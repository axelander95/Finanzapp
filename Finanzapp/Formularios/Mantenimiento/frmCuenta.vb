Public Class frmCuenta
    Private btnBuscar As ToolStripButton
    Public Sub New()
        InitializeComponent()
        btnBuscar = ctlToolBarCuenta.btnBuscar
        AddHandler btnBuscar.Click, AddressOf Buscar
    End Sub
    Private Sub Buscar()
        Dim busqueda As New frmBusqueda()
        busqueda.ShowDialog()
    End Sub
End Class