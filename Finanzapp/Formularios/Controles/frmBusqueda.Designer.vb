﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.lbxLista.Size = New System.Drawing.Size(504, 242)
        Me.lbxLista.TabIndex = 2
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBusqueda.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.Location = New System.Drawing.Point(17, 15)
        Me.txtBusqueda.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtBusqueda.MaxLength = 50
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(452, 24)
        Me.txtBusqueda.TabIndex = 0
        '
        'btnBusqueda
        '
        Me.btnBusqueda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBusqueda.Image = Global.FinanzApp.My.Resources.Resources._1439925626_140
        Me.btnBusqueda.Location = New System.Drawing.Point(477, 15)
        Me.btnBusqueda.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnBusqueda.Name = "btnBusqueda"
        Me.btnBusqueda.Size = New System.Drawing.Size(43, 24)
        Me.btnBusqueda.TabIndex = 1
        Me.btnBusqueda.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Image = Global.FinanzApp.My.Resources.Resources._1439925575_004
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(435, 300)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(85, 33)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionar.Image = Global.FinanzApp.My.Resources.Resources._1439925608_006
        Me.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSeleccionar.Location = New System.Drawing.Point(321, 300)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(108, 33)
        Me.btnSeleccionar.TabIndex = 5
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'frmBusqueda
        '
        Me.AcceptButton = Me.btnSeleccionar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(532, 340)
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
