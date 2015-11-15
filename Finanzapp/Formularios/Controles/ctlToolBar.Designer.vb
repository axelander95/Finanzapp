<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlToolBar
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.tlsToolBar = New System.Windows.Forms.ToolStrip()
        Me.btnAgregar = New System.Windows.Forms.ToolStripButton()
        Me.btnModificar = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.itmSeparador2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.itmSeparador1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.tlsToolBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlsToolBar
        '
        Me.tlsToolBar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tlsToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tlsToolBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAgregar, Me.btnModificar, Me.btnEliminar, Me.itmSeparador2, Me.btnBuscar, Me.itmSeparador1, Me.btnGuardar, Me.btnCancelar})
        Me.tlsToolBar.Location = New System.Drawing.Point(0, 0)
        Me.tlsToolBar.Name = "tlsToolBar"
        Me.tlsToolBar.Size = New System.Drawing.Size(490, 25)
        Me.tlsToolBar.TabIndex = 0
        Me.tlsToolBar.Text = "ToolStrip1"
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 10.0!)
        Me.btnAgregar.Image = Global.FinanzApp.My.Resources.Resources._1439925602_001
        Me.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(79, 22)
        Me.btnAgregar.Text = "Agregar"
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 10.0!)
        Me.btnModificar.Image = Global.FinanzApp.My.Resources.Resources._1439925628_077
        Me.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(87, 22)
        Me.btnModificar.Text = "Modificar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 10.0!)
        Me.btnEliminar.Image = Global.FinanzApp.My.Resources.Resources._1439925687_008
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(77, 22)
        Me.btnEliminar.Text = "Eliminar"
        '
        'itmSeparador2
        '
        Me.itmSeparador2.Name = "itmSeparador2"
        Me.itmSeparador2.Size = New System.Drawing.Size(6, 25)
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 10.0!)
        Me.btnBuscar.Image = Global.FinanzApp.My.Resources.Resources._1439925626_140
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(69, 22)
        Me.btnBuscar.Text = "Buscar"
        '
        'itmSeparador1
        '
        Me.itmSeparador1.Name = "itmSeparador1"
        Me.itmSeparador1.Size = New System.Drawing.Size(6, 25)
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 10.0!)
        Me.btnGuardar.Image = Global.FinanzApp.My.Resources.Resources._1439925644_139
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(78, 22)
        Me.btnGuardar.Text = "Guardar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 10.0!)
        Me.btnCancelar.Image = Global.FinanzApp.My.Resources.Resources._1439925575_004
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(82, 22)
        Me.btnCancelar.Text = "Cancelar"
        '
        'ctlToolBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.tlsToolBar)
        Me.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "ctlToolBar"
        Me.Size = New System.Drawing.Size(490, 25)
        Me.tlsToolBar.ResumeLayout(False)
        Me.tlsToolBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tlsToolBar As ToolStrip
    Friend WithEvents btnAgregar As ToolStripButton
    Friend WithEvents btnModificar As ToolStripButton
    Friend WithEvents btnEliminar As ToolStripButton
    Friend WithEvents itmSeparador1 As ToolStripSeparator
    Friend WithEvents btnGuardar As ToolStripButton
    Friend WithEvents btnCancelar As ToolStripButton
    Friend WithEvents itmSeparador2 As ToolStripSeparator
    Friend WithEvents btnBuscar As ToolStripButton
End Class
