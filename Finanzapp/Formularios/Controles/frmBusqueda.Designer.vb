<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusqueda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBusqueda))
        Me.lbxLista = New System.Windows.Forms.ListBox()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.btnBusqueda = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbxLista
        '
        Me.lbxLista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbxLista.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxLista.FormattingEnabled = True
        Me.lbxLista.ItemHeight = 17
        Me.lbxLista.Location = New System.Drawing.Point(16, 49)
        Me.lbxLista.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lbxLista.Name = "lbxLista"
        Me.lbxLista.Size = New System.Drawing.Size(499, 242)
        Me.lbxLista.TabIndex = 0
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBusqueda.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.Location = New System.Drawing.Point(17, 15)
        Me.txtBusqueda.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtBusqueda.MaxLength = 50
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(447, 24)
        Me.txtBusqueda.TabIndex = 1
        '
        'btnBusqueda
        '
        Me.btnBusqueda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBusqueda.Image = Global.Finanzapp.My.Resources.Resources._1439925626_140
        Me.btnBusqueda.Location = New System.Drawing.Point(472, 15)
        Me.btnBusqueda.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnBusqueda.Name = "btnBusqueda"
        Me.btnBusqueda.Size = New System.Drawing.Size(43, 24)
        Me.btnBusqueda.TabIndex = 2
        Me.btnBusqueda.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.BackColor = System.Drawing.Color.Red
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnCancelar.Location = New System.Drawing.Point(424, 300)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 33)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionar.BackColor = System.Drawing.Color.DarkGreen
        Me.btnSeleccionar.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnSeleccionar.Location = New System.Drawing.Point(327, 300)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(91, 33)
        Me.btnSeleccionar.TabIndex = 4
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.UseVisualStyleBackColor = False
        '
        'frmBusqueda
        '
        Me.AcceptButton = Me.btnSeleccionar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(532, 345)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnBusqueda)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.lbxLista)
        Me.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmBusqueda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Búsqueda"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbxLista As ListBox
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents btnBusqueda As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnSeleccionar As Button
End Class
