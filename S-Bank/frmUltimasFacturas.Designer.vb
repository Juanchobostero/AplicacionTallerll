<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUltimasFacturas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUltimasFacturas))
        Me.dgvUltimasFacturas = New System.Windows.Forms.DataGridView()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblCant = New System.Windows.Forms.Label()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.pnlFac = New System.Windows.Forms.Panel()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lblValor2 = New System.Windows.Forms.Label()
        Me.lblPor = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.dgvUltimasFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFac.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvUltimasFacturas
        '
        Me.dgvUltimasFacturas.AllowUserToAddRows = False
        Me.dgvUltimasFacturas.AllowUserToDeleteRows = False
        Me.dgvUltimasFacturas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvUltimasFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUltimasFacturas.Location = New System.Drawing.Point(41, 20)
        Me.dgvUltimasFacturas.Name = "dgvUltimasFacturas"
        Me.dgvUltimasFacturas.ReadOnly = True
        Me.dgvUltimasFacturas.Size = New System.Drawing.Size(426, 130)
        Me.dgvUltimasFacturas.TabIndex = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTitulo.Location = New System.Drawing.Point(80, 32)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(442, 31)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Facturas registradas del ultimo mes:"
        '
        'lblCant
        '
        Me.lblCant.AutoSize = True
        Me.lblCant.BackColor = System.Drawing.Color.Transparent
        Me.lblCant.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCant.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCant.Location = New System.Drawing.Point(38, 162)
        Me.lblCant.Name = "lblCant"
        Me.lblCant.Size = New System.Drawing.Size(71, 17)
        Me.lblCant.TabIndex = 2
        Me.lblCant.Text = "Cantidad:"
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.BackColor = System.Drawing.Color.Transparent
        Me.lblValor.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValor.ForeColor = System.Drawing.Color.Red
        Me.lblValor.Location = New System.Drawing.Point(115, 162)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(41, 17)
        Me.lblValor.TabIndex = 3
        Me.lblValor.Text = "valor"
        '
        'pnlFac
        '
        Me.pnlFac.BackgroundImage = Global.S_Bank.My.Resources.Resources.images
        Me.pnlFac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlFac.Controls.Add(Me.lbl1)
        Me.pnlFac.Controls.Add(Me.lblValor2)
        Me.pnlFac.Controls.Add(Me.lblPor)
        Me.pnlFac.Controls.Add(Me.dgvUltimasFacturas)
        Me.pnlFac.Controls.Add(Me.lblValor)
        Me.pnlFac.Controls.Add(Me.lblCant)
        Me.pnlFac.Location = New System.Drawing.Point(45, 89)
        Me.pnlFac.Name = "pnlFac"
        Me.pnlFac.Size = New System.Drawing.Size(511, 213)
        Me.pnlFac.TabIndex = 4
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.Color.Transparent
        Me.lbl1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.Red
        Me.lbl1.Location = New System.Drawing.Point(316, 179)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(23, 17)
        Me.lbl1.TabIndex = 6
        Me.lbl1.Text = "%"
        '
        'lblValor2
        '
        Me.lblValor2.AutoSize = True
        Me.lblValor2.BackColor = System.Drawing.Color.Transparent
        Me.lblValor2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValor2.ForeColor = System.Drawing.Color.Red
        Me.lblValor2.Location = New System.Drawing.Point(272, 179)
        Me.lblValor2.Name = "lblValor2"
        Me.lblValor2.Size = New System.Drawing.Size(49, 17)
        Me.lblValor2.TabIndex = 5
        Me.lblValor2.Text = "valor2"
        '
        'lblPor
        '
        Me.lblPor.AutoSize = True
        Me.lblPor.BackColor = System.Drawing.Color.Transparent
        Me.lblPor.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPor.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPor.Location = New System.Drawing.Point(38, 179)
        Me.lblPor.Name = "lblPor"
        Me.lblPor.Size = New System.Drawing.Size(215, 17)
        Me.lblPor.TabIndex = 4
        Me.lblPor.Text = "Porcentaje del total de facturas:"
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Image = Global.S_Bank.My.Resources.Resources.preocupaciones_icono_8798_321
        Me.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtras.Location = New System.Drawing.Point(163, 308)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(97, 43)
        Me.btnAtras.TabIndex = 31
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.S_Bank.My.Resources.Resources.salir_de_gnome_icono_8179_48
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(329, 308)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(110, 43)
        Me.btnSalir.TabIndex = 30
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmUltimasFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.S_Bank.My.Resources.Resources.FondoAzul2
        Me.ClientSize = New System.Drawing.Size(599, 363)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.pnlFac)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmUltimasFacturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturas del ultimo mes"
        CType(Me.dgvUltimasFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFac.ResumeLayout(False)
        Me.pnlFac.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvUltimasFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblCant As System.Windows.Forms.Label
    Friend WithEvents lblValor As System.Windows.Forms.Label
    Friend WithEvents pnlFac As System.Windows.Forms.Panel
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents lblValor2 As System.Windows.Forms.Label
    Friend WithEvents lblPor As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
End Class
