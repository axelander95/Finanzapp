Module AnalisisEVA
    Public ListaEVA As List(Of IndicadorEVATransaccion)
    Public Sub GenerarAnalisis(ByVal Desde As Integer, ByVal Hasta As Integer)
        Dim AñoActual As Integer = Desde
        Do
            AñoActual += 1
        Loop While (AñoActual <= Hasta)
    End Sub
End Module
