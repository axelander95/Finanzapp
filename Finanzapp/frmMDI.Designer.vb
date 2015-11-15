<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMDI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.sstBarraEstado = New System.Windows.Forms.StatusStrip()
        Me.pgbMDI = New System.Windows.Forms.ToolStripProgressBar()
        Me.mstMDI = New System.Windows.Forms.MenuStrip()
        Me.itmArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmAbrir = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmSeparador1 = New System.Windows.Forms.ToolStripSeparator()
        Me.itmGuardar = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmGuardarComo = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmSeparador2 = New System.Windows.Forms.ToolStripSeparator()
        Me.itmSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmMantenimiento = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmCuentas = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmTransacciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmSeparador3 = New System.Windows.Forms.ToolStripSeparator()
        Me.itmConfiguracion = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmVer = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmReportes = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmAyuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmDocumentacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmAcercaDe = New System.Windows.Forms.ToolStripMenuItem()
        Me.sstBarraEstado.SuspendLayout()
        Me.mstMDI.SuspendLayout()
        Me.SuspendLayout()
        '
        'sstBarraEstado
        '
        Me.sstBarraEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pgbMDI})
        Me.sstBarraEstado.Location = New System.Drawing.Point(0, 462)
        Me.sstBarraEstado.Name = "sstBarraEstado"
        Me.sstBarraEstado.Size = New System.Drawing.Size(783, 27)
        Me.sstBarraEstado.TabIndex = 1
        Me.sstBarraEstado.Text = "Barra de estado"
        '
        'pgbMDI
        '
        Me.pgbMDI.Name = "pgbMDI"
        Me.pgbMDI.Size = New System.Drawing.Size(100, 21)
        '
        'mstMDI
        '
        Me.mstMDI.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mstMDI.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 9.0!)
        Me.mstMDI.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itmArchivo, Me.itmMantenimiento, Me.itmVer, Me.itmAyuda})
        Me.mstMDI.Location = New System.Drawing.Point(0, 0)
        Me.mstMDI.Name = "mstMDI"
        Me.mstMDI.Size = New System.Drawing.Size(783, 25)
        Me.mstMDI.TabIndex = 3
        Me.mstMDI.Text = "Barra de menú"
        '
        'itmArchivo
        '
        Me.itmArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itmNuevo, Me.itmAbrir, Me.itmSeparador1, Me.itmGuardar, Me.itmGuardarComo, Me.itmSeparador2, Me.itmSalir})
        Me.itmArchivo.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 9.0!)
        Me.itmArchivo.Name = "itmArchivo"
        Me.itmArchivo.Size = New System.Drawing.Size(62, 21)
        Me.itmArchivo.Text = "Archivo"
        '
        'itmNuevo
        '
        Me.itmNuevo.Name = "itmNuevo"
        Me.itmNuevo.Size = New System.Drawing.Size(165, 22)
        Me.itmNuevo.Text = "Nuevo"
        '
        'itmAbrir
        '
        Me.itmAbrir.Name = "itmAbrir"
        Me.itmAbrir.Size = New System.Drawing.Size(165, 22)
        Me.itmAbrir.Text = "Abrir"
        '
        'itmSeparador1
        '
        Me.itmSeparador1.Name = "itmSeparador1"
        Me.itmSeparador1.Size = New System.Drawing.Size(162, 6)
        '
        'itmGuardar
        '
        Me.itmGuardar.Name = "itmGuardar"
        Me.itmGuardar.Size = New System.Drawing.Size(165, 22)
        Me.itmGuardar.Text = "Guardar"
        '
        'itmGuardarComo
        '
        Me.itmGuardarComo.Name = "itmGuardarComo"
        Me.itmGuardarComo.Size = New System.Drawing.Size(165, 22)
        Me.itmGuardarComo.Text = "Guardar como..."
        '
        'itmSeparador2
        '
        Me.itmSeparador2.Name = "itmSeparador2"
        Me.itmSeparador2.Size = New System.Drawing.Size(162, 6)
        '
        'itmSalir
        '
        Me.itmSalir.Name = "itmSalir"
        Me.itmSalir.Size = New System.Drawing.Size(165, 22)
        Me.itmSalir.Text = "Salir"
        '
        'itmMantenimiento
        '
        Me.itmMantenimiento.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itmCuentas, Me.itmTransacciones, Me.itmSeparador3, Me.itmConfiguracion})
        Me.itmMantenimiento.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 9.0!)
        Me.itmMantenimiento.Name = "itmMantenimiento"
        Me.itmMantenimiento.Size = New System.Drawing.Size(105, 21)
        Me.itmMantenimiento.Text = "Mantenimiento"
        '
        'itmCuentas
        '
        Me.itmCuentas.Name = "itmCuentas"
        Me.itmCuentas.Size = New System.Drawing.Size(154, 22)
        Me.itmCuentas.Text = "Cuentas"
        '
        'itmTransacciones
        '
        Me.itmTransacciones.Name = "itmTransacciones"
        Me.itmTransacciones.Size = New System.Drawing.Size(154, 22)
        Me.itmTransacciones.Text = "Transacciones"
        '
        'itmSeparador3
        '
        Me.itmSeparador3.Name = "itmSeparador3"
        Me.itmSeparador3.Size = New System.Drawing.Size(151, 6)
        '
        'itmConfiguracion
        '
        Me.itmConfiguracion.Name = "itmConfiguracion"
        Me.itmConfiguracion.Size = New System.Drawing.Size(154, 22)
        Me.itmConfiguracion.Text = "Configuración"
        '
        'itmVer
        '
        Me.itmVer.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itmReportes})
        Me.itmVer.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 9.0!)
        Me.itmVer.Name = "itmVer"
        Me.itmVer.Size = New System.Drawing.Size(39, 21)
        Me.itmVer.Text = "Ver"
        '
        'itmReportes
        '
        Me.itmReportes.Name = "itmReportes"
        Me.itmReportes.Size = New System.Drawing.Size(125, 22)
        Me.itmReportes.Text = "Reportes"
        '
        'itmAyuda
        '
        Me.itmAyuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itmDocumentacion, Me.itmAcercaDe})
        Me.itmAyuda.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 9.0!)
        Me.itmAyuda.Name = "itmAyuda"
        Me.itmAyuda.Size = New System.Drawing.Size(54, 21)
        Me.itmAyuda.Text = "Ayuda"
        '
        'itmDocumentacion
        '
        Me.itmDocumentacion.Name = "itmDocumentacion"
        Me.itmDocumentacion.Size = New System.Drawing.Size(165, 22)
        Me.itmDocumentacion.Text = "Documentación"
        '
        'itmAcercaDe
        '
        Me.itmAcercaDe.Name = "itmAcercaDe"
        Me.itmAcercaDe.Size = New System.Drawing.Size(165, 22)
        Me.itmAcercaDe.Text = "Acerca de"
        '
        'frmMDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 489)
        Me.Controls.Add(Me.sstBarraEstado)
        Me.Controls.Add(Me.mstMDI)
        Me.Font = New System.Drawing.Font("Microsoft YaHei Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mstMDI
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMDI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FinanzApp"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.sstBarraEstado.ResumeLayout(False)
        Me.sstBarraEstado.PerformLayout()
        Me.mstMDI.ResumeLayout(False)
        Me.mstMDI.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sstBarraEstado As StatusStrip
    Friend WithEvents pgbMDI As ToolStripProgressBar
    Friend WithEvents mstMDI As MenuStrip
    Friend WithEvents itmArchivo As ToolStripMenuItem
    Friend WithEvents itmMantenimiento As ToolStripMenuItem
    Friend WithEvents itmVer As ToolStripMenuItem
    Friend WithEvents itmAyuda As ToolStripMenuItem
    Friend WithEvents itmNuevo As ToolStripMenuItem
    Friend WithEvents itmAbrir As ToolStripMenuItem
    Friend WithEvents itmSeparador1 As ToolStripSeparator
    Friend WithEvents itmGuardar As ToolStripMenuItem
    Friend WithEvents itmSeparador2 As ToolStripSeparator
    Friend WithEvents itmSalir As ToolStripMenuItem
    Friend WithEvents itmCuentas As ToolStripMenuItem
    Friend WithEvents itmSeparador3 As ToolStripSeparator
    Friend WithEvents itmConfiguracion As ToolStripMenuItem
    Friend WithEvents itmReportes As ToolStripMenuItem
    Friend WithEvents itmDocumentacion As ToolStripMenuItem
    Friend WithEvents itmAcercaDe As ToolStripMenuItem
    Friend WithEvents itmTransacciones As ToolStripMenuItem
    Friend WithEvents itmGuardarComo As ToolStripMenuItem
End Class
