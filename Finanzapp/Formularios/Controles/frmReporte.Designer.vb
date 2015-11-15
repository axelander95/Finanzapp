<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReporte))
        Me.lblEstadoFinanciero = New System.Windows.Forms.Label()
        Me.cmbEstadoFinanciero = New System.Windows.Forms.ComboBox()
        Me.lblAño = New System.Windows.Forms.Label()
        Me.cmbAño = New System.Windows.Forms.ComboBox()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.rpvEstadoFinanciero = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'lblEstadoFinanciero
        '
        Me.lblEstadoFinanciero.AutoSize = True
        Me.lblEstadoFinanciero.Location = New System.Drawing.Point(14, 15)
        Me.lblEstadoFinanciero.Name = "lblEstadoFinanciero"
        Me.lblEstadoFinanciero.Size = New System.Drawing.Size(117, 18)
        Me.lblEstadoFinanciero.TabIndex = 0
        Me.lblEstadoFinanciero.Text = "Estado financiero"
        '
        'cmbEstadoFinanciero
        '
        Me.cmbEstadoFinanciero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstadoFinanciero.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbEstadoFinanciero.FormattingEnabled = True
        Me.cmbEstadoFinanciero.Items.AddRange(New Object() {"BALANCE GENERAL", "ESTADO DE RESULTADOS"})
        Me.cmbEstadoFinanciero.Location = New System.Drawing.Point(137, 12)
        Me.cmbEstadoFinanciero.Name = "cmbEstadoFinanciero"
        Me.cmbEstadoFinanciero.Size = New System.Drawing.Size(210, 25)
        Me.cmbEstadoFinanciero.TabIndex = 1
        '
        'lblAño
        '
        Me.lblAño.AutoSize = True
        Me.lblAño.Location = New System.Drawing.Point(354, 15)
        Me.lblAño.Name = "lblAño"
        Me.lblAño.Size = New System.Drawing.Size(35, 18)
        Me.lblAño.TabIndex = 2
        Me.lblAño.Text = "Año"
        '
        'cmbAño
        '
        Me.cmbAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAño.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbAño.FormattingEnabled = True
        Me.cmbAño.Location = New System.Drawing.Point(395, 12)
        Me.cmbAño.Name = "cmbAño"
        Me.cmbAño.Size = New System.Drawing.Size(165, 25)
        Me.cmbAño.TabIndex = 3
        '
        'btnGenerar
        '
        Me.btnGenerar.Image = Global.FinanzApp.My.Resources.Resources.report
        Me.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerar.Location = New System.Drawing.Point(566, 12)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(85, 25)
        Me.btnGenerar.TabIndex = 4
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(657, 12)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(83, 25)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'rpvEstadoFinanciero
        '
        Me.rpvEstadoFinanciero.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rpvEstadoFinanciero.Location = New System.Drawing.Point(17, 43)
        Me.rpvEstadoFinanciero.Name = "rpvEstadoFinanciero"
        Me.rpvEstadoFinanciero.Size = New System.Drawing.Size(723, 328)
        Me.rpvEstadoFinanciero.TabIndex = 6
        '
        'frmReporte
        '
        Me.AcceptButton = Me.btnGenerar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(752, 383)
        Me.Controls.Add(Me.rpvEstadoFinanciero)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.cmbAño)
        Me.Controls.Add(Me.lblAño)
        Me.Controls.Add(Me.cmbEstadoFinanciero)
        Me.Controls.Add(Me.lblEstadoFinanciero)
        Me.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmReporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEstadoFinanciero As Label
    Friend WithEvents cmbEstadoFinanciero As ComboBox
    Friend WithEvents lblAño As Label
    Friend WithEvents cmbAño As ComboBox
    Friend WithEvents btnGenerar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents rpvEstadoFinanciero As Microsoft.Reporting.WinForms.ReportViewer
End Class
