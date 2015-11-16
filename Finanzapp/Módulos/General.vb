Module General
    Public Sub CargarAños(ByVal ComboBoxAños As ComboBox)
        For Año As Integer = 1980 To Today.Year + 30
            ComboBoxAños.Items.Add(Año)
        Next
    End Sub
    Public Function ObtenerIngresosBrutos() As Decimal
        Dim IngresosBrutos As Decimal = 0
        Return IngresosBrutos
    End Function
End Module
