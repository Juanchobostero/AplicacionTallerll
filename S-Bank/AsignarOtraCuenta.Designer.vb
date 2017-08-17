<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignarOtraCuenta
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
        Me.lblAsignar = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbxTipoDeCuenta = New System.Windows.Forms.ComboBox()
        Me.txtSaldoCuenta = New System.Windows.Forms.TextBox()
        Me.lblTipoCuenta = New System.Windows.Forms.Label()
        Me.lblSaldoCuenta = New System.Windows.Forms.Label()
        Me.lblTit = New System.Windows.Forms.Label()
        Me.lblTitular = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnAsignar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAsignar
        '
        Me.lblAsignar.AutoSize = True
        Me.lblAsignar.BackColor = System.Drawing.Color.Transparent
        Me.lblAsignar.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsignar.ForeColor = System.Drawing.Color.White
        Me.lblAsignar.Location = New System.Drawing.Point(79, 35)
        Me.lblAsignar.Name = "lblAsignar"
        Me.lblAsignar.Size = New System.Drawing.Size(198, 31)
        Me.lblAsignar.TabIndex = 0
        Me.lblAsignar.Text = "Asignar Cuenta"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.S_Bank.My.Resources.Resources.images
        Me.Panel1.Controls.Add(Me.cbxTipoDeCuenta)
        Me.Panel1.Controls.Add(Me.txtSaldoCuenta)
        Me.Panel1.Controls.Add(Me.lblTipoCuenta)
        Me.Panel1.Controls.Add(Me.lblSaldoCuenta)
        Me.Panel1.Controls.Add(Me.lblTit)
        Me.Panel1.Controls.Add(Me.lblTitular)
        Me.Panel1.Location = New System.Drawing.Point(30, 95)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(306, 171)
        Me.Panel1.TabIndex = 1
        '
        'cbxTipoDeCuenta
        '
        Me.cbxTipoDeCuenta.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTipoDeCuenta.FormattingEnabled = True
        Me.cbxTipoDeCuenta.Location = New System.Drawing.Point(167, 117)
        Me.cbxTipoDeCuenta.Name = "cbxTipoDeCuenta"
        Me.cbxTipoDeCuenta.Size = New System.Drawing.Size(119, 25)
        Me.cbxTipoDeCuenta.TabIndex = 12
        '
        'txtSaldoCuenta
        '
        Me.txtSaldoCuenta.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoCuenta.Location = New System.Drawing.Point(167, 66)
        Me.txtSaldoCuenta.Name = "txtSaldoCuenta"
        Me.txtSaldoCuenta.Size = New System.Drawing.Size(119, 25)
        Me.txtSaldoCuenta.TabIndex = 8
        '
        'lblTipoCuenta
        '
        Me.lblTipoCuenta.AutoSize = True
        Me.lblTipoCuenta.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoCuenta.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoCuenta.ForeColor = System.Drawing.Color.White
        Me.lblTipoCuenta.Location = New System.Drawing.Point(7, 120)
        Me.lblTipoCuenta.Name = "lblTipoCuenta"
        Me.lblTipoCuenta.Size = New System.Drawing.Size(154, 17)
        Me.lblTipoCuenta.TabIndex = 3
        Me.lblTipoCuenta.Text = "Asignar Tipo de  Cuenta:"
        '
        'lblSaldoCuenta
        '
        Me.lblSaldoCuenta.AutoSize = True
        Me.lblSaldoCuenta.BackColor = System.Drawing.Color.Transparent
        Me.lblSaldoCuenta.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoCuenta.ForeColor = System.Drawing.Color.White
        Me.lblSaldoCuenta.Location = New System.Drawing.Point(7, 74)
        Me.lblSaldoCuenta.Name = "lblSaldoCuenta"
        Me.lblSaldoCuenta.Size = New System.Drawing.Size(93, 17)
        Me.lblSaldoCuenta.TabIndex = 2
        Me.lblSaldoCuenta.Text = "Asignar Saldo:"
        '
        'lblTit
        '
        Me.lblTit.AutoSize = True
        Me.lblTit.BackColor = System.Drawing.Color.Transparent
        Me.lblTit.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTit.ForeColor = System.Drawing.Color.Red
        Me.lblTit.Location = New System.Drawing.Point(164, 24)
        Me.lblTit.Name = "lblTit"
        Me.lblTit.Size = New System.Drawing.Size(45, 17)
        Me.lblTit.TabIndex = 1
        Me.lblTit.Text = "Titular"
        '
        'lblTitular
        '
        Me.lblTitular.AutoSize = True
        Me.lblTitular.BackColor = System.Drawing.Color.Transparent
        Me.lblTitular.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitular.ForeColor = System.Drawing.Color.White
        Me.lblTitular.Location = New System.Drawing.Point(7, 24)
        Me.lblTitular.Name = "lblTitular"
        Me.lblTitular.Size = New System.Drawing.Size(126, 17)
        Me.lblTitular.TabIndex = 0
        Me.lblTitular.Text = "Titular de la Cuenta:"
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Image = Global.S_Bank.My.Resources.Resources.preocupaciones_icono_8798_32
        Me.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtras.Location = New System.Drawing.Point(30, 289)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(85, 35)
        Me.btnAtras.TabIndex = 2
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnAsignar
        '
        Me.btnAsignar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsignar.Image = Global.S_Bank.My.Resources.Resources._3floppy_guardar_el_desmantelamiento_icono_4124_32__1_
        Me.btnAsignar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAsignar.Location = New System.Drawing.Point(125, 272)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(104, 52)
        Me.btnAsignar.TabIndex = 3
        Me.btnAsignar.Text = "Asignar"
        Me.btnAsignar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAsignar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.S_Bank.My.Resources.Resources.salir_de_gnome_icono_8179_48
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(246, 289)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(90, 35)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmAsignarOtraCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.S_Bank.My.Resources.Resources.FondoAzul2
        Me.ClientSize = New System.Drawing.Size(348, 336)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAsignar)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblAsignar)
        Me.Name = "frmAsignarOtraCuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignar Cuenta"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAsignar As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents btnAsignar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents lblTipoCuenta As System.Windows.Forms.Label
    Friend WithEvents lblSaldoCuenta As System.Windows.Forms.Label
    Friend WithEvents lblTit As System.Windows.Forms.Label
    Friend WithEvents lblTitular As System.Windows.Forms.Label
    Friend WithEvents txtSaldoCuenta As System.Windows.Forms.TextBox
    Friend WithEvents cbxTipoDeCuenta As System.Windows.Forms.ComboBox
End Class
