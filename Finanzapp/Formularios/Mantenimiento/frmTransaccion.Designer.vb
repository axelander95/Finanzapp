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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransaccion))
        Me.lblAño = New System.Windows.Forms.Label()
        Me.cmbAño = New System.Windows.Forms.ComboBox()
        Me.grvTransacciones = New System.Windows.Forms.DataGridView()
        Me.txtCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAgregarCuenta = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.txtValor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
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
        'grvTransacciones
        '
        Me.grvTransacciones.AllowUserToResizeRows = False
        Me.grvTransacciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grvTransacciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.grvTransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grvTransacciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.txtCodigo, Me.txtCuenta, Me.btnAgregarCuenta, Me.txtValor})
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
        'txtCodigo
        '
        Me.txtCodigo.HeaderText = "CÓDIGO"
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Visible = False
        '
        'txtCuenta
        '
        Me.txtCuenta.HeaderText = "CUENTA"
        Me.txtCuenta.MaxInputLength = 50
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.ReadOnly = True
        Me.txtCuenta.ToolTipText = "Nombre de cuenta"
        Me.txtCuenta.Width = 285
        '
        'btnAgregarCuenta
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = "..."
        Me.btnAgregarCuenta.DefaultCellStyle = DataGridViewCellStyle1
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
        Me.txtValor.MaxInputLength = 18
        Me.txtValor.Name = "txtValor"
        Me.txtValor.ToolTipText = "Valor de la cuenta"
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Image = Global.FinanzApp.My.Resources.Resources._1439925608_006
        Me.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSeleccionar.Location = New System.Drawing.Point(177, 12)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(113, 25)
        Me.btnSeleccionar.TabIndex = 2
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Image = Global.FinanzApp.My.Resources.Resources._1439925575_004
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(382, 293)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(87, 24)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Image = Global.FinanzApp.My.Resources.Resources._1439925644_139
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(289, 293)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(87, 24)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.Image = Global.FinanzApp.My.Resources.Resources._1439925687_008
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(196, 293)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(87, 24)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'frmTransaccion
        '
        Me.AcceptButton = Me.btnGuardar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(482, 329)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.grvTransacciones)
        Me.Controls.Add(Me.cmbAño)
        Me.Controls.Add(Me.lblAño)
        Me.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
    Friend WithEvents grvTransacciones As DataGridView
    Friend WithEvents btnSeleccionar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents txtCodigo As DataGridViewTextBoxColumn
    Friend WithEvents txtCuenta As DataGridViewTextBoxColumn
    Friend WithEvents btnAgregarCuenta As DataGridViewButtonColumn
    Friend WithEvents txtValor As DataGridViewTextBoxColumn
End Class
