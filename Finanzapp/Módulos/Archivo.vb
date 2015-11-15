Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Module Archivo
    Public Sub GuardarArchivo(ByVal Path As String, ByVal ObjetoArchivo As Object)
        Dim FlujoArchivo As New FileStream(Path, FileMode.OpenOrCreate)
        Dim FormateadorBinario As New BinaryFormatter()
        FormateadorBinario.Serialize(FlujoArchivo, ObjetoArchivo)
        FlujoArchivo.Close()
    End Sub
    Public Function CargarArchivo(ByVal Path As String) As Object
        Dim ObjetoArchivo As Object = Nothing
        If File.Exists(Path) Then
            Dim FlujoArchivo As New FileStream(Path, FileMode.Open)
            Dim FormateadorBinario As New BinaryFormatter()
            ObjetoArchivo = FormateadorBinario.Deserialize(FlujoArchivo)
            FlujoArchivo.Close()
        End If
        Return ObjetoArchivo
    End Function
End Module
