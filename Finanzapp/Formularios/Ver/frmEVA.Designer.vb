<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEVA
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
        Me.lblPrimerAño = New System.Windows.Forms.Label()
        Me.cmbPrimerAño = New System.Windows.Forms.ComboBox()
        Me.lblUltimoAño = New System.Windows.Forms.Label()
        Me.cmbUltimoAño = New System.Windows.Forms.ComboBox()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.grvEVA = New System.Windows.Forms.DataGridView()
        CType(Me.grvEVA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPrimerAño
        '
        Me.lblPrimerAño.AutoSize = True
        Me.lblPrimerAño.Location = New System.Drawing.Point(12, 16)
        Me.lblPrimerAño.Name = "lblPrimerAño"
        Me.lblPrimerAño.Size = New System.Drawing.Size(77, 18)
        Me.lblPrimerAño.TabIndex = 0
        Me.lblPrimerAño.Text = "Primer año"
        '
        'cmbPrimerAño
        '
        Me.cmbPrimerAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPrimerAño.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbPrimerAño.FormattingEnabled = True
        Me.cmbPrimerAño.Location = New System.Drawing.Point(95, 13)
        Me.cmbPrimerAño.Name = "cmbPrimerAño"
        Me.cmbPrimerAño.Size = New System.Drawing.Size(121, 25)
        Me.cmbPrimerAño.TabIndex = 1
        '
        'lblUltimoAño
        '
        Me.lblUltimoAño.AutoSize = True
        Me.lblUltimoAño.Location = New System.Drawing.Point(222, 16)
        Me.lblUltimoAño.Name = "lblUltimoAño"
        Me.lblUltimoAño.Size = New System.Drawing.Size(78, 18)
        Me.lblUltimoAño.TabIndex = 2
        Me.lblUltimoAño.Text = "Último año"
        '
        'cmbUltimoAño
        '
        Me.cmbUltimoAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUltimoAño.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbUltimoAño.FormattingEnabled = True
        Me.cmbUltimoAño.Location = New System.Drawing.Point(306, 12)
        Me.cmbUltimoAño.Name = "cmbUltimoAño"
        Me.cmbUltimoAño.Size = New System.Drawing.Size(121, 25)
        Me.cmbUltimoAño.TabIndex = 3
        '
        'btnGenerar
        '
        Me.btnGenerar.Image = Global.FinanzApp.My.Resources.Resources._1439925608_006
        Me.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerar.Location = New System.Drawing.Point(433, 12)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(86, 26)
        Me.btnGenerar.TabIndex = 4
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Image = Global.FinanzApp.My.Resources.Resources._1439925575_004
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(525, 12)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(88, 26)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'grvEVA
        '
        Me.grvEVA.AllowUserToAddRows = False
        Me.grvEVA.AllowUserToDeleteRows = False
        Me.grvEVA.AllowUserToResizeRows = False
        Me.grvEVA.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grvEVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grvEVA.Location = New System.Drawing.Point(13, 48)
        Me.grvEVA.Name = "grvEVA"
        Me.grvEVA.ReadOnly = True
        Me.grvEVA.RowHeadersVisible = False
        Me.grvEVA.Size = New System.Drawing.Size(775, 354)
        Me.grvEVA.TabIndex = 6
        '
        'frmEVA
        '
        Me.AcceptButton = Me.btnGenerar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(800, 414)
        Me.Controls.Add(Me.grvEVA)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.cmbUltimoAño)
        Me.Controls.Add(Me.lblUltimoAño)
        Me.Controls.Add(Me.cmbPrimerAño)
        Me.Controls.Add(Me.lblPrimerAño)
        Me.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmEVA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Valor Económico Agregado"
        CType(Me.grvEVA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrimerAño As Label
    Friend WithEvents cmbPrimerAño As ComboBox
    Friend WithEvents lblUltimoAño As Label
    Friend WithEvents cmbUltimoAño As ComboBox
    Friend WithEvents btnGenerar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents grvEVA As DataGridView
End Class
