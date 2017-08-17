<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdministrarCuentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdministrarCuentas))
        Me.dgvCuentas = New System.Windows.Forms.DataGridView()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblIDCuenta = New System.Windows.Forms.Label()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.cbxTipoCuenta = New System.Windows.Forms.ComboBox()
        Me.lblTipoCuenta = New System.Windows.Forms.Label()
        Me.lblTitular = New System.Windows.Forms.Label()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lbltit = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAgregarTipoCuenta = New System.Windows.Forms.Button()
        CType(Me.dgvCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvCuentas
        '
        Me.dgvCuentas.AllowUserToAddRows = False
        Me.dgvCuentas.AllowUserToDeleteRows = False
        Me.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCuentas.Location = New System.Drawing.Point(12, 60)
        Me.dgvCuentas.Name = "dgvCuentas"
        Me.dgvCuentas.ReadOnly = True
        Me.dgvCuentas.Size = New System.Drawing.Size(420, 144)
        Me.dgvCuentas.TabIndex = 0
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Image = Global.S_Bank.My.Resources.Resources.preocupaciones_icono_8798_321
        Me.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtras.Location = New System.Drawing.Point(203, 378)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(89, 40)
        Me.btnAtras.TabIndex = 1
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.S_Bank.My.Resources.Resources.salir_de_gnome_icono_8179_48
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(327, 378)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(95, 40)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(170, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Administrar Cuentas"
        '
        'txtSaldo
        '
        Me.txtSaldo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.Location = New System.Drawing.Point(77, 62)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(100, 26)
        Me.txtSaldo.TabIndex = 12
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.S_Bank.My.Resources.Resources.images
        Me.Panel1.Controls.Add(Me.lblIDCuenta)
        Me.Panel1.Controls.Add(Me.btnConfirmar)
        Me.Panel1.Controls.Add(Me.cbxTipoCuenta)
        Me.Panel1.Controls.Add(Me.lblTipoCuenta)
        Me.Panel1.Controls.Add(Me.lblTitular)
        Me.Panel1.Controls.Add(Me.lblSaldo)
        Me.Panel1.Controls.Add(Me.lblDesc)
        Me.Panel1.Controls.Add(Me.txtSaldo)
        Me.Panel1.Controls.Add(Me.lbltit)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(12, 225)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(572, 116)
        Me.Panel1.TabIndex = 14
        '
        'lblIDCuenta
        '
        Me.lblIDCuenta.AutoSize = True
        Me.lblIDCuenta.BackColor = System.Drawing.Color.Transparent
        Me.lblIDCuenta.Location = New System.Drawing.Point(530, 0)
        Me.lblIDCuenta.Name = "lblIDCuenta"
        Me.lblIDCuenta.Size = New System.Drawing.Size(39, 13)
        Me.lblIDCuenta.TabIndex = 16
        Me.lblIDCuenta.Text = "Label2"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnConfirmar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.Image = Global.S_Bank.My.Resources.Resources.editar_secuencias_de_comandos_icono_6203_32
        Me.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfirmar.Location = New System.Drawing.Point(447, 43)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(113, 41)
        Me.btnConfirmar.TabIndex = 15
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'cbxTipoCuenta
        '
        Me.cbxTipoCuenta.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTipoCuenta.FormattingEnabled = True
        Me.cbxTipoCuenta.Location = New System.Drawing.Point(289, 59)
        Me.cbxTipoCuenta.Name = "cbxTipoCuenta"
        Me.cbxTipoCuenta.Size = New System.Drawing.Size(121, 25)
        Me.cbxTipoCuenta.TabIndex = 14
        '
        'lblTipoCuenta
        '
        Me.lblTipoCuenta.AutoSize = True
        Me.lblTipoCuenta.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoCuenta.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoCuenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTipoCuenta.Location = New System.Drawing.Point(198, 65)
        Me.lblTipoCuenta.Name = "lblTipoCuenta"
        Me.lblTipoCuenta.Size = New System.Drawing.Size(86, 19)
        Me.lblTipoCuenta.TabIndex = 13
        Me.lblTipoCuenta.Text = "Tipo Cuenta:"
        '
        'lblTitular
        '
        Me.lblTitular.AutoSize = True
        Me.lblTitular.BackColor = System.Drawing.Color.Transparent
        Me.lblTitular.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitular.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTitular.Location = New System.Drawing.Point(17, 17)
        Me.lblTitular.Name = "lblTitular"
        Me.lblTitular.Size = New System.Drawing.Size(49, 19)
        Me.lblTitular.TabIndex = 4
        Me.lblTitular.Text = "Titular:"
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.BackColor = System.Drawing.Color.Transparent
        Me.lblSaldo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSaldo.Location = New System.Drawing.Point(17, 65)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(44, 19)
        Me.lblSaldo.TabIndex = 11
        Me.lblSaldo.Text = "Saldo"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblDesc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.ForeColor = System.Drawing.Color.Red
        Me.lblDesc.Location = New System.Drawing.Point(286, 17)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(78, 19)
        Me.lblDesc.TabIndex = 10
        Me.lblDesc.Text = "descripcion"
        '
        'lbltit
        '
        Me.lbltit.AutoSize = True
        Me.lbltit.BackColor = System.Drawing.Color.Transparent
        Me.lbltit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltit.ForeColor = System.Drawing.Color.Red
        Me.lbltit.Location = New System.Drawing.Point(73, 17)
        Me.lbltit.Name = "lbltit"
        Me.lbltit.Size = New System.Drawing.Size(46, 19)
        Me.lbltit.TabIndex = 8
        Me.lbltit.Text = "Titular"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(198, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tipo cuenta:"
        '
        'btnAgregarTipoCuenta
        '
        Me.btnAgregarTipoCuenta.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarTipoCuenta.Image = Global.S_Bank.My.Resources.Resources.anadir_mas_datos_de_base_icono_8363_48
        Me.btnAgregarTipoCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarTipoCuenta.Location = New System.Drawing.Point(438, 60)
        Me.btnAgregarTipoCuenta.Name = "btnAgregarTipoCuenta"
        Me.btnAgregarTipoCuenta.Size = New System.Drawing.Size(146, 53)
        Me.btnAgregarTipoCuenta.TabIndex = 15
        Me.btnAgregarTipoCuenta.Text = "Agregar Tipo Cuenta"
        Me.btnAgregarTipoCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregarTipoCuenta.UseVisualStyleBackColor = True
        '
        'frmAdministrarCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.S_Bank.My.Resources.Resources.FondoAzul2
        Me.ClientSize = New System.Drawing.Size(598, 430)
        Me.Controls.Add(Me.btnAgregarTipoCuenta)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.dgvCuentas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAdministrarCuentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar Cuentas"
        CType(Me.dgvCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvCuentas As System.Windows.Forms.DataGridView
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnAgregarTipoCuenta As System.Windows.Forms.Button
    Friend WithEvents cbxTipoCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoCuenta As System.Windows.Forms.Label
    Friend WithEvents lblTitular As System.Windows.Forms.Label
    Friend WithEvents lblSaldo As System.Windows.Forms.Label
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents lbltit As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents lblIDCuenta As System.Windows.Forms.Label

End Class
