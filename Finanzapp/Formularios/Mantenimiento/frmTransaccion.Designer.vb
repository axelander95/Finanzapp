<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransaccion
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblAño = New System.Windows.Forms.Label()
        Me.cmbAño = New System.Windows.Forms.ComboBox()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.grvTransacciones = New System.Windows.Forms.DataGridView()
        Me.btnBuscarCuenta = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.txtCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAgregarCuenta = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.txtValor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        CType(Me.grvTransacciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAño
        '
        Me.lblAño.AutoSize = True
        Me.lblAño.Location = New System.Drawing.Point(9, 16)
        Me.lblAño.Name = "lblAño"
        Me.lblAño.Size = New System.Drawing.Size(35, 18)
        Me.lblAño.TabIndex = 0
        Me.lblAño.Text = "Año"
        '
        'cmbAño
        '
        Me.cmbAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAño.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbAño.FormattingEnabled = True
        Me.cmbAño.Location = New System.Drawing.Point(50, 12)
        Me.cmbAño.Name = "cmbAño"
        Me.cmbAño.Size = New System.Drawing.Size(121, 25)
        Me.cmbAño.TabIndex = 1
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.BackColor = System.Drawing.Color.Black
        Me.btnSeleccionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSeleccionar.Location = New System.Drawing.Point(177, 8)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(89, 33)
        Me.btnSeleccionar.TabIndex = 2
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.UseVisualStyleBackColor = False
        '
        'grvTransacciones
        '
        Me.grvTransacciones.AllowUserToResizeRows = False
        Me.grvTransacciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grvTransacciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.grvTransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grvTransacciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.btnBuscarCuenta, Me.txtCuenta, Me.btnAgregarCuenta, Me.txtValor})
        Me.grvTransacciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.grvTransacciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.grvTransacciones.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.grvTransacciones.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.grvTransacciones.Location = New System.Drawing.Point(12, 47)
        Me.grvTransacciones.MultiSelect = False
        Me.grvTransacciones.Name = "grvTransacciones"
        Me.grvTransacciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.grvTransacciones.Size = New System.Drawing.Size(458, 240)
        Me.grvTransacciones.TabIndex = 3
        '
        'btnBuscarCuenta
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.NullValue = "+"
        Me.btnBuscarCuenta.DefaultCellStyle = DataGridViewCellStyle5
        Me.btnBuscarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscarCuenta.HeaderText = ""
        Me.btnBuscarCuenta.Name = "btnBuscarCuenta"
        Me.btnBuscarCuenta.Text = ""
        Me.btnBuscarCuenta.ToolTipText = "Nueva cuenta"
        Me.btnBuscarCuenta.Width = 25
        '
        'txtCuenta
        '
        Me.txtCuenta.HeaderText = "CUENTA"
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.ReadOnly = True
        Me.txtCuenta.ToolTipText = "Nombre de cuenta"
        Me.txtCuenta.Width = 280
        '
        'btnAgregarCuenta
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.NullValue = "..."
        Me.btnAgregarCuenta.DefaultCellStyle = DataGridViewCellStyle6
        Me.btnAgregarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAgregarCuenta.HeaderText = ""
        Me.btnAgregarCuenta.Name = "btnAgregarCuenta"
        Me.btnAgregarCuenta.Text = ""
        Me.btnAgregarCuenta.ToolTipText = "Buscar cuenta"
        Me.btnAgregarCuenta.Width = 25
        '
        'txtValor
        '
        Me.txtValor.HeaderText = "VALOR"
        Me.txtValor.Name = "txtValor"
        Me.txtValor.ToolTipText = "Valor de la cuenta"
        Me.txtValor.Width = 80
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.BackColor = System.Drawing.Color.Red
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnCancelar.Location = New System.Drawing.Point(380, 293)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 33)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.BackColor = System.Drawing.Color.DarkGreen
        Me.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnAceptar.Location = New System.Drawing.Point(283, 293)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(91, 33)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.BackColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(202, 293)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 33)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'frmTransaccion
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(482, 337)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.grvTransacciones)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.cmbAño)
        Me.Controls.Add(Me.lblAño)
        Me.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmTransaccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transacciones"
        CType(Me.grvTransacciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAño As Label
    Friend WithEvents cmbAño As ComboBox
    Friend WithEvents btnSeleccionar As Button
    Friend WithEvents grvTransacciones As DataGridView
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnBuscarCuenta As DataGridViewButtonColumn
    Friend WithEvents txtCuenta As DataGridViewTextBoxColumn
    Friend WithEvents btnAgregarCuenta As DataGridViewButtonColumn
    Friend WithEvents txtValor As DataGridViewTextBoxColumn
    Friend WithEvents btnEliminar As Button
End Class
