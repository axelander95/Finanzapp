<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAcercaDe
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
        Me.ptbLogo = New System.Windows.Forms.PictureBox()
        Me.lblAplicacion = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblDesarrolladoPor = New System.Windows.Forms.Label()
        Me.ptbNamSolutions = New System.Windows.Forms.PictureBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbNamSolutions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ptbLogo
        '
        Me.ptbLogo.Location = New System.Drawing.Point(13, 13)
        Me.ptbLogo.Name = "ptbLogo"
        Me.ptbLogo.Size = New System.Drawing.Size(185, 173)
        Me.ptbLogo.TabIndex = 0
        Me.ptbLogo.TabStop = False
        '
        'lblAplicacion
        '
        Me.lblAplicacion.AutoSize = True
        Me.lblAplicacion.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAplicacion.Location = New System.Drawing.Point(205, 13)
        Me.lblAplicacion.Name = "lblAplicacion"
        Me.lblAplicacion.Size = New System.Drawing.Size(83, 18)
        Me.lblAplicacion.TabIndex = 1
        Me.lblAplicacion.Text = "FinanzApp"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(205, 31)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(86, 18)
        Me.lblVersion.TabIndex = 2
        Me.lblVersion.Text = "Versión 1.0.0"
        '
        'lblDesarrolladoPor
        '
        Me.lblDesarrolladoPor.AutoSize = True
        Me.lblDesarrolladoPor.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesarrolladoPor.Location = New System.Drawing.Point(204, 49)
        Me.lblDesarrolladoPor.Name = "lblDesarrolladoPor"
        Me.lblDesarrolladoPor.Size = New System.Drawing.Size(130, 18)
        Me.lblDesarrolladoPor.TabIndex = 3
        Me.lblDesarrolladoPor.Text = "Desarrollado por"
        '
        'ptbNamSolutions
        '
        Me.ptbNamSolutions.Location = New System.Drawing.Point(204, 70)
        Me.ptbNamSolutions.Name = "ptbNamSolutions"
        Me.ptbNamSolutions.Size = New System.Drawing.Size(127, 72)
        Me.ptbNamSolutions.TabIndex = 4
        Me.ptbNamSolutions.TabStop = False
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(204, 145)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(137, 18)
        Me.lblDescripcion.TabIndex = 5
        Me.lblDescripcion.Text = "Aplicación financiera"
        '
        'frmAcercaDe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(354, 200)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.ptbNamSolutions)
        Me.Controls.Add(Me.lblDesarrolladoPor)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblAplicacion)
        Me.Controls.Add(Me.ptbLogo)
        Me.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAcercaDe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acerca de FinanzApp"
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbNamSolutions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ptbLogo As PictureBox
    Friend WithEvents lblAplicacion As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents lblDesarrolladoPor As Label
    Friend WithEvents ptbNamSolutions As PictureBox
    Friend WithEvents lblDescripcion As Label
End Class
