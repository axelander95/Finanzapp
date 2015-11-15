<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfiguracion
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
        Me.lblNombreEmpresa = New System.Windows.Forms.Label()
        Me.txtNombreEmpresa = New System.Windows.Forms.TextBox()
        Me.lblRuc = New System.Windows.Forms.Label()
        Me.txtRuc = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.lblCorreoElectronico = New System.Windows.Forms.Label()
        Me.txtCorreoElectronico = New System.Windows.Forms.TextBox()
        Me.lblPaginaWeb = New System.Windows.Forms.Label()
        Me.txtPaginaWeb = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNombreEmpresa
        '
        Me.lblNombreEmpresa.AutoSize = True
        Me.lblNombreEmpresa.Location = New System.Drawing.Point(14, 16)
        Me.lblNombreEmpresa.Name = "lblNombreEmpresa"
        Me.lblNombreEmpresa.Size = New System.Drawing.Size(153, 18)
        Me.lblNombreEmpresa.TabIndex = 0
        Me.lblNombreEmpresa.Text = "Nombre de la empresa"
        '
        'txtNombreEmpresa
        '
        Me.txtNombreEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreEmpresa.Location = New System.Drawing.Point(173, 13)
        Me.txtNombreEmpresa.MaxLength = 50
        Me.txtNombreEmpresa.Name = "txtNombreEmpresa"
        Me.txtNombreEmpresa.Size = New System.Drawing.Size(391, 24)
        Me.txtNombreEmpresa.TabIndex = 1
        '
        'lblRuc
        '
        Me.lblRuc.AutoSize = True
        Me.lblRuc.Location = New System.Drawing.Point(126, 45)
        Me.lblRuc.Name = "lblRuc"
        Me.lblRuc.Size = New System.Drawing.Size(41, 18)
        Me.lblRuc.TabIndex = 2
        Me.lblRuc.Text = "R.U.C"
        '
        'txtRuc
        '
        Me.txtRuc.Location = New System.Drawing.Point(173, 43)
        Me.txtRuc.MaxLength = 13
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(215, 24)
        Me.txtRuc.TabIndex = 3
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(99, 77)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(68, 18)
        Me.lblDireccion.TabIndex = 4
        Me.lblDireccion.Text = "Dirección"
        '
        'txtDireccion
        '
        Me.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccion.Location = New System.Drawing.Point(173, 74)
        Me.txtDireccion.MaxLength = 13
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(391, 24)
        Me.txtDireccion.TabIndex = 5
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(104, 107)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(63, 18)
        Me.lblTelefono.TabIndex = 6
        Me.lblTelefono.Text = "Teléfono"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(173, 104)
        Me.txtTelefono.MaxLength = 9
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(164, 24)
        Me.txtTelefono.TabIndex = 7
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Location = New System.Drawing.Point(343, 107)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(51, 18)
        Me.lblCelular.TabIndex = 8
        Me.lblCelular.Text = "Celular"
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(400, 101)
        Me.txtCelular.MaxLength = 10
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(164, 24)
        Me.txtCelular.TabIndex = 9
        '
        'lblCorreoElectronico
        '
        Me.lblCorreoElectronico.AutoSize = True
        Me.lblCorreoElectronico.Location = New System.Drawing.Point(38, 139)
        Me.lblCorreoElectronico.Name = "lblCorreoElectronico"
        Me.lblCorreoElectronico.Size = New System.Drawing.Size(129, 18)
        Me.lblCorreoElectronico.TabIndex = 10
        Me.lblCorreoElectronico.Text = "Correo electrónico"
        '
        'txtCorreoElectronico
        '
        Me.txtCorreoElectronico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCorreoElectronico.Location = New System.Drawing.Point(173, 136)
        Me.txtCorreoElectronico.MaxLength = 100
        Me.txtCorreoElectronico.Name = "txtCorreoElectronico"
        Me.txtCorreoElectronico.Size = New System.Drawing.Size(391, 24)
        Me.txtCorreoElectronico.TabIndex = 11
        '
        'lblPaginaWeb
        '
        Me.lblPaginaWeb.AutoSize = True
        Me.lblPaginaWeb.Location = New System.Drawing.Point(88, 169)
        Me.lblPaginaWeb.Name = "lblPaginaWeb"
        Me.lblPaginaWeb.Size = New System.Drawing.Size(79, 18)
        Me.lblPaginaWeb.TabIndex = 12
        Me.lblPaginaWeb.Text = "Página web"
        '
        'txtPaginaWeb
        '
        Me.txtPaginaWeb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPaginaWeb.Location = New System.Drawing.Point(173, 166)
        Me.txtPaginaWeb.MaxLength = 100
        Me.txtPaginaWeb.Name = "txtPaginaWeb"
        Me.txtPaginaWeb.Size = New System.Drawing.Size(391, 24)
        Me.txtPaginaWeb.TabIndex = 13
        '
        'btnAceptar
        '
        Me.btnAceptar.Image = Global.FinanzApp.My.Resources.Resources._1439925608_006
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(385, 196)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 14
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.FinanzApp.My.Resources.Resources._1439925575_004
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(489, 196)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmConfiguracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(579, 234)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtPaginaWeb)
        Me.Controls.Add(Me.lblPaginaWeb)
        Me.Controls.Add(Me.txtCorreoElectronico)
        Me.Controls.Add(Me.lblCorreoElectronico)
        Me.Controls.Add(Me.txtCelular)
        Me.Controls.Add(Me.lblCelular)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.txtRuc)
        Me.Controls.Add(Me.lblRuc)
        Me.Controls.Add(Me.txtNombreEmpresa)
        Me.Controls.Add(Me.lblNombreEmpresa)
        Me.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmConfiguracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombreEmpresa As Label
    Friend WithEvents txtNombreEmpresa As TextBox
    Friend WithEvents lblRuc As Label
    Friend WithEvents txtRuc As TextBox
    Friend WithEvents lblDireccion As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents lblCelular As Label
    Friend WithEvents txtCelular As TextBox
    Friend WithEvents lblCorreoElectronico As Label
    Friend WithEvents txtCorreoElectronico As TextBox
    Friend WithEvents lblPaginaWeb As Label
    Friend WithEvents txtPaginaWeb As TextBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
End Class
