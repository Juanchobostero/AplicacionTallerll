<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerFacturas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVerFacturas))
        Me.lblVerFacturas = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.dgvFacturas = New System.Windows.Forms.DataGridView()
        Me.dgvDetalleFactura = New System.Windows.Forms.DataGridView()
        Me.lblDetalle = New System.Windows.Forms.Label()
        Me.lblFacturaID = New System.Windows.Forms.Label()
        CType(Me.dgvFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalleFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblVerFacturas
        '
        Me.lblVerFacturas.AutoSize = True
        Me.lblVerFacturas.BackColor = System.Drawing.Color.Transparent
        Me.lblVerFacturas.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVerFacturas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblVerFacturas.Location = New System.Drawing.Point(232, 33)
        Me.lblVerFacturas.Name = "lblVerFacturas"
        Me.lblVerFacturas.Size = New System.Drawing.Size(166, 31)
        Me.lblVerFacturas.TabIndex = 0
        Me.lblVerFacturas.Tag = ""
        Me.lblVerFacturas.Text = "Ver Facturas"
        '
        'btnAtras
        '
        Me.btnAtras.BackColor = System.Drawing.Color.Transparent
        Me.btnAtras.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAtras.Image = Global.S_Bank.My.Resources.Resources.preocupaciones_icono_8798_321
        Me.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtras.Location = New System.Drawing.Point(182, 410)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(93, 51)
        Me.btnAtras.TabIndex = 1
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAtras.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Transparent
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSalir.Image = Global.S_Bank.My.Resources.Resources.salir_de_gnome_icono_8179_48
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(367, 410)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(93, 51)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'dgvFacturas
        '
        Me.dgvFacturas.AllowUserToAddRows = False
        Me.dgvFacturas.AllowUserToDeleteRows = False
        Me.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFacturas.Location = New System.Drawing.Point(12, 79)
        Me.dgvFacturas.Name = "dgvFacturas"
        Me.dgvFacturas.ReadOnly = True
        Me.dgvFacturas.Size = New System.Drawing.Size(633, 150)
        Me.dgvFacturas.TabIndex = 3
        '
        'dgvDetalleFactura
        '
        Me.dgvDetalleFactura.AllowUserToAddRows = False
        Me.dgvDetalleFactura.AllowUserToDeleteRows = False
        Me.dgvDetalleFactura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleFactura.Location = New System.Drawing.Point(108, 288)
        Me.dgvDetalleFactura.Name = "dgvDetalleFactura"
        Me.dgvDetalleFactura.ReadOnly = True
        Me.dgvDetalleFactura.Size = New System.Drawing.Size(410, 116)
        Me.dgvDetalleFactura.TabIndex = 4
        '
        'lblDetalle
        '
        Me.lblDetalle.AutoSize = True
        Me.lblDetalle.BackColor = System.Drawing.Color.Transparent
        Me.lblDetalle.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetalle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDetalle.Location = New System.Drawing.Point(106, 268)
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.Size = New System.Drawing.Size(169, 17)
        Me.lblDetalle.TabIndex = 5
        Me.lblDetalle.Text = "Detalle de la factura nro:"
        '
        'lblFacturaID
        '
        Me.lblFacturaID.AutoSize = True
        Me.lblFacturaID.BackColor = System.Drawing.Color.Transparent
        Me.lblFacturaID.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFacturaID.ForeColor = System.Drawing.Color.Red
        Me.lblFacturaID.Location = New System.Drawing.Point(281, 268)
        Me.lblFacturaID.Name = "lblFacturaID"
        Me.lblFacturaID.Size = New System.Drawing.Size(78, 17)
        Me.lblFacturaID.TabIndex = 6
        Me.lblFacturaID.Text = "Factura ID"
        '
        'frmVerFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.S_Bank.My.Resources.Resources.FondoAzul2
        Me.ClientSize = New System.Drawing.Size(657, 473)
        Me.Controls.Add(Me.lblFacturaID)
        Me.Controls.Add(Me.lblDetalle)
        Me.Controls.Add(Me.dgvDetalleFactura)
        Me.Controls.Add(Me.dgvFacturas)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.lblVerFacturas)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmVerFacturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturas"
        CType(Me.dgvFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalleFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblVerFacturas As System.Windows.Forms.Label
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents dgvFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents dgvDetalleFactura As System.Windows.Forms.DataGridView
    Friend WithEvents lblDetalle As System.Windows.Forms.Label
    Friend WithEvents lblFacturaID As System.Windows.Forms.Label
End Class
