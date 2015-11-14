<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCuenta
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
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblClasificacion = New System.Windows.Forms.Label()
        Me.cmbClasificacion = New System.Windows.Forms.ComboBox()
        Me.chkNegatividad = New System.Windows.Forms.CheckBox()
        Me.ctlToolBarCuenta = New FinanzApp.ctlToolBar()
        Me.SuspendLayout()
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(12, 33)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(54, 18)
        Me.lblCodigo.TabIndex = 1
        Me.lblCodigo.Text = "Código"
        '
        'txtCodigo
        '
        Me.txtCodigo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodigo.Location = New System.Drawing.Point(72, 30)
        Me.txtCodigo.MaxLength = 5
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(96, 24)
        Me.txtCodigo.TabIndex = 2
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(197, 33)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(82, 18)
        Me.lblDescripcion.TabIndex = 3
        Me.lblDescripcion.Text = "Descripción"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(285, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(280, 24)
        Me.TextBox1.TabIndex = 4
        '
        'lblClasificacion
        '
        Me.lblClasificacion.AutoSize = True
        Me.lblClasificacion.Location = New System.Drawing.Point(195, 63)
        Me.lblClasificacion.Name = "lblClasificacion"
        Me.lblClasificacion.Size = New System.Drawing.Size(84, 18)
        Me.lblClasificacion.TabIndex = 5
        Me.lblClasificacion.Text = "Clasificación"
        '
        'cmbClasificacion
        '
        Me.cmbClasificacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbClasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClasificacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbClasificacion.FormattingEnabled = True
        Me.cmbClasificacion.Location = New System.Drawing.Point(285, 60)
        Me.cmbClasificacion.Name = "cmbClasificacion"
        Me.cmbClasificacion.Size = New System.Drawing.Size(280, 25)
        Me.cmbClasificacion.TabIndex = 6
        '
        'chkNegatividad
        '
        Me.chkNegatividad.AutoSize = True
        Me.chkNegatividad.Location = New System.Drawing.Point(27, 61)
        Me.chkNegatividad.Name = "chkNegatividad"
        Me.chkNegatividad.Size = New System.Drawing.Size(141, 22)
        Me.chkNegatividad.TabIndex = 7
        Me.chkNegatividad.Text = "Posee negatividad"
        Me.chkNegatividad.UseVisualStyleBackColor = True
        '
        'ctlToolBarCuenta
        '
        Me.ctlToolBarCuenta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctlToolBarCuenta.BackColor = System.Drawing.SystemColors.Control
        Me.ctlToolBarCuenta.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctlToolBarCuenta.Location = New System.Drawing.Point(-1, -1)
        Me.ctlToolBarCuenta.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ctlToolBarCuenta.Name = "ctlToolBarCuenta"
        Me.ctlToolBarCuenta.Size = New System.Drawing.Size(603, 25)
        Me.ctlToolBarCuenta.TabIndex = 0
        '
        'frmCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(600, 98)
        Me.Controls.Add(Me.chkNegatividad)
        Me.Controls.Add(Me.cmbClasificacion)
        Me.Controls.Add(Me.lblClasificacion)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.ctlToolBarCuenta)
        Me.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "frmCuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuenta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ctlToolBarCuenta As ctlToolBar
    Friend WithEvents lblCodigo As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblClasificacion As Label
    Friend WithEvents cmbClasificacion As ComboBox
    Friend WithEvents chkNegatividad As CheckBox
End Class
