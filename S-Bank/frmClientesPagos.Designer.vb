<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientesPagos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientesPagos))
        Me.dgvPagaron = New System.Windows.Forms.DataGridView()
        Me.lblTitulo1 = New System.Windows.Forms.Label()
        Me.dgvNoPagaron = New System.Windows.Forms.DataGridView()
        Me.lblTitulo2 = New System.Windows.Forms.Label()
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.lblSim1 = New System.Windows.Forms.Label()
        Me.lblPor1 = New System.Windows.Forms.Label()
        Me.lblPor = New System.Windows.Forms.Label()
        Me.lblNum1 = New System.Windows.Forms.Label()
        Me.lblCant = New System.Windows.Forms.Label()
        Me.pnl2 = New System.Windows.Forms.Panel()
        Me.lblSim2 = New System.Windows.Forms.Label()
        Me.lblPor2 = New System.Windows.Forms.Label()
        Me.lblPorc = New System.Windows.Forms.Label()
        Me.lblNum2 = New System.Windows.Forms.Label()
        Me.lblCant2 = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        CType(Me.dgvPagaron, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvNoPagaron, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl1.SuspendLayout()
        Me.pnl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvPagaron
        '
        Me.dgvPagaron.AllowUserToAddRows = False
        Me.dgvPagaron.AllowUserToDeleteRows = False
        Me.dgvPagaron.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPagaron.Location = New System.Drawing.Point(64, 29)
        Me.dgvPagaron.Name = "dgvPagaron"
        Me.dgvPagaron.ReadOnly = True
        Me.dgvPagaron.Size = New System.Drawing.Size(322, 127)
        Me.dgvPagaron.TabIndex = 0
        '
        'lblTitulo1
        '
        Me.lblTitulo1.AutoSize = True
        Me.lblTitulo1.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTitulo1.Location = New System.Drawing.Point(77, 9)
        Me.lblTitulo1.Name = "lblTitulo1"
        Me.lblTitulo1.Size = New System.Drawing.Size(287, 17)
        Me.lblTitulo1.TabIndex = 1
        Me.lblTitulo1.Text = "Usuarios que registran pagos de servicios:"
        '
        'dgvNoPagaron
        '
        Me.dgvNoPagaron.AllowUserToAddRows = False
        Me.dgvNoPagaron.AllowUserToDeleteRows = False
        Me.dgvNoPagaron.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNoPagaron.Location = New System.Drawing.Point(60, 38)
        Me.dgvNoPagaron.Name = "dgvNoPagaron"
        Me.dgvNoPagaron.ReadOnly = True
        Me.dgvNoPagaron.Size = New System.Drawing.Size(326, 114)
        Me.dgvNoPagaron.TabIndex = 2
        '
        'lblTitulo2
        '
        Me.lblTitulo2.AutoSize = True
        Me.lblTitulo2.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTitulo2.Location = New System.Drawing.Point(57, 9)
        Me.lblTitulo2.Name = "lblTitulo2"
        Me.lblTitulo2.Size = New System.Drawing.Size(314, 17)
        Me.lblTitulo2.TabIndex = 3
        Me.lblTitulo2.Text = "Usuarios que NO registran pagos de servicios:"
        '
        'pnl1
        '
        Me.pnl1.BackgroundImage = CType(resources.GetObject("pnl1.BackgroundImage"), System.Drawing.Image)
        Me.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnl1.Controls.Add(Me.lblSim1)
        Me.pnl1.Controls.Add(Me.lblPor1)
        Me.pnl1.Controls.Add(Me.lblPor)
        Me.pnl1.Controls.Add(Me.lblNum1)
        Me.pnl1.Controls.Add(Me.lblCant)
        Me.pnl1.Controls.Add(Me.dgvPagaron)
        Me.pnl1.Controls.Add(Me.lblTitulo1)
        Me.pnl1.Location = New System.Drawing.Point(30, 83)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(435, 204)
        Me.pnl1.TabIndex = 4
        '
        'lblSim1
        '
        Me.lblSim1.AutoSize = True
        Me.lblSim1.BackColor = System.Drawing.Color.Transparent
        Me.lblSim1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSim1.ForeColor = System.Drawing.Color.Red
        Me.lblSim1.Location = New System.Drawing.Point(334, 176)
        Me.lblSim1.Name = "lblSim1"
        Me.lblSim1.Size = New System.Drawing.Size(23, 17)
        Me.lblSim1.TabIndex = 7
        Me.lblSim1.Text = "%"
        '
        'lblPor1
        '
        Me.lblPor1.AutoSize = True
        Me.lblPor1.BackColor = System.Drawing.Color.Transparent
        Me.lblPor1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPor1.ForeColor = System.Drawing.Color.Red
        Me.lblPor1.Location = New System.Drawing.Point(291, 176)
        Me.lblPor1.Name = "lblPor1"
        Me.lblPor1.Size = New System.Drawing.Size(44, 17)
        Me.lblPor1.TabIndex = 6
        Me.lblPor1.Text = "num1"
        '
        'lblPor
        '
        Me.lblPor.AutoSize = True
        Me.lblPor.BackColor = System.Drawing.Color.Transparent
        Me.lblPor.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPor.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPor.Location = New System.Drawing.Point(61, 176)
        Me.lblPor.Name = "lblPor"
        Me.lblPor.Size = New System.Drawing.Size(219, 17)
        Me.lblPor.TabIndex = 5
        Me.lblPor.Text = "Porcentaje del total de usuarios:"
        '
        'lblNum1
        '
        Me.lblNum1.AutoSize = True
        Me.lblNum1.BackColor = System.Drawing.Color.Transparent
        Me.lblNum1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum1.ForeColor = System.Drawing.Color.Red
        Me.lblNum1.Location = New System.Drawing.Point(138, 159)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(44, 17)
        Me.lblNum1.TabIndex = 3
        Me.lblNum1.Text = "num1"
        '
        'lblCant
        '
        Me.lblCant.AutoSize = True
        Me.lblCant.BackColor = System.Drawing.Color.Transparent
        Me.lblCant.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCant.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCant.Location = New System.Drawing.Point(61, 159)
        Me.lblCant.Name = "lblCant"
        Me.lblCant.Size = New System.Drawing.Size(71, 17)
        Me.lblCant.TabIndex = 2
        Me.lblCant.Text = "Cantidad:"
        '
        'pnl2
        '
        Me.pnl2.BackgroundImage = CType(resources.GetObject("pnl2.BackgroundImage"), System.Drawing.Image)
        Me.pnl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnl2.Controls.Add(Me.lblSim2)
        Me.pnl2.Controls.Add(Me.lblPor2)
        Me.pnl2.Controls.Add(Me.lblPorc)
        Me.pnl2.Controls.Add(Me.lblNum2)
        Me.pnl2.Controls.Add(Me.lblCant2)
        Me.pnl2.Controls.Add(Me.dgvNoPagaron)
        Me.pnl2.Controls.Add(Me.lblTitulo2)
        Me.pnl2.Location = New System.Drawing.Point(32, 302)
        Me.pnl2.Name = "pnl2"
        Me.pnl2.Size = New System.Drawing.Size(435, 211)
        Me.pnl2.TabIndex = 5
        '
        'lblSim2
        '
        Me.lblSim2.AutoSize = True
        Me.lblSim2.BackColor = System.Drawing.Color.Transparent
        Me.lblSim2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSim2.ForeColor = System.Drawing.Color.Red
        Me.lblSim2.Location = New System.Drawing.Point(312, 185)
        Me.lblSim2.Name = "lblSim2"
        Me.lblSim2.Size = New System.Drawing.Size(23, 17)
        Me.lblSim2.TabIndex = 8
        Me.lblSim2.Text = "%"
        '
        'lblPor2
        '
        Me.lblPor2.AutoSize = True
        Me.lblPor2.BackColor = System.Drawing.Color.Transparent
        Me.lblPor2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPor2.ForeColor = System.Drawing.Color.Red
        Me.lblPor2.Location = New System.Drawing.Point(271, 185)
        Me.lblPor2.Name = "lblPor2"
        Me.lblPor2.Size = New System.Drawing.Size(44, 17)
        Me.lblPor2.TabIndex = 8
        Me.lblPor2.Text = "num2"
        '
        'lblPorc
        '
        Me.lblPorc.AutoSize = True
        Me.lblPorc.BackColor = System.Drawing.Color.Transparent
        Me.lblPorc.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPorc.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPorc.Location = New System.Drawing.Point(46, 185)
        Me.lblPorc.Name = "lblPorc"
        Me.lblPorc.Size = New System.Drawing.Size(219, 17)
        Me.lblPorc.TabIndex = 7
        Me.lblPorc.Text = "Porcentaje del total de usuarios:"
        '
        'lblNum2
        '
        Me.lblNum2.AutoSize = True
        Me.lblNum2.BackColor = System.Drawing.Color.Transparent
        Me.lblNum2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum2.ForeColor = System.Drawing.Color.Red
        Me.lblNum2.Location = New System.Drawing.Point(123, 168)
        Me.lblNum2.Name = "lblNum2"
        Me.lblNum2.Size = New System.Drawing.Size(44, 17)
        Me.lblNum2.TabIndex = 5
        Me.lblNum2.Text = "num2"
        '
        'lblCant2
        '
        Me.lblCant2.AutoSize = True
        Me.lblCant2.BackColor = System.Drawing.Color.Transparent
        Me.lblCant2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCant2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCant2.Location = New System.Drawing.Point(46, 168)
        Me.lblCant2.Name = "lblCant2"
        Me.lblCant2.Size = New System.Drawing.Size(71, 17)
        Me.lblCant2.TabIndex = 4
        Me.lblCant2.Text = "Cantidad:"
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Image = CType(resources.GetObject("btnAtras.Image"), System.Drawing.Image)
        Me.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtras.Location = New System.Drawing.Point(117, 538)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(97, 43)
        Me.btnAtras.TabIndex = 33
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(259, 538)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(110, 43)
        Me.btnSalir.TabIndex = 32
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(25, 18)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(458, 26)
        Me.lblTitulo.TabIndex = 34
        Me.lblTitulo.Text = "Usuarios que registran y no registran pagos"
        '
        'frmClientesPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(499, 593)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.pnl2)
        Me.Controls.Add(Me.pnl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmClientesPagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        CType(Me.dgvPagaron, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvNoPagaron, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        Me.pnl2.ResumeLayout(False)
        Me.pnl2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvPagaron As System.Windows.Forms.DataGridView
    Friend WithEvents lblTitulo1 As System.Windows.Forms.Label
    Friend WithEvents dgvNoPagaron As System.Windows.Forms.DataGridView
    Friend WithEvents lblTitulo2 As System.Windows.Forms.Label
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents lblNum1 As System.Windows.Forms.Label
    Friend WithEvents lblCant As System.Windows.Forms.Label
    Friend WithEvents pnl2 As System.Windows.Forms.Panel
    Friend WithEvents lblNum2 As System.Windows.Forms.Label
    Friend WithEvents lblCant2 As System.Windows.Forms.Label
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents lblPor As System.Windows.Forms.Label
    Friend WithEvents lblPor1 As System.Windows.Forms.Label
    Friend WithEvents lblPor2 As System.Windows.Forms.Label
    Friend WithEvents lblPorc As System.Windows.Forms.Label
    Friend WithEvents lblSim1 As System.Windows.Forms.Label
    Friend WithEvents lblSim2 As System.Windows.Forms.Label
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
End Class
