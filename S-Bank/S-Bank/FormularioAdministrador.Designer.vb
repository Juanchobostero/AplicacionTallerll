<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicioAdm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicioAdm))
        Me.lblBienvenido = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAdministrarProv = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCuentas = New System.Windows.Forms.Button()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.picAdmin = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.picAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBienvenido
        '
        Me.lblBienvenido.AutoSize = True
        Me.lblBienvenido.BackColor = System.Drawing.Color.Transparent
        Me.lblBienvenido.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenido.ForeColor = System.Drawing.Color.White
        Me.lblBienvenido.Location = New System.Drawing.Point(17, 19)
        Me.lblBienvenido.Name = "lblBienvenido"
        Me.lblBienvenido.Size = New System.Drawing.Size(339, 32)
        Me.lblBienvenido.TabIndex = 2
        Me.lblBienvenido.Text = "Bienvenido Administrador"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.S_Bank.My.Resources.Resources.images
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnAdministrarProv)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnCuentas)
        Me.Panel1.Controls.Add(Me.btnUsuarios)
        Me.Panel1.Controls.Add(Me.lblBienvenido)
        Me.Panel1.Controls.Add(Me.picAdmin)
        Me.Panel1.Location = New System.Drawing.Point(65, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(623, 411)
        Me.Panel1.TabIndex = 4
        '
        'btnAdministrarProv
        '
        Me.btnAdministrarProv.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdministrarProv.Image = Global.S_Bank.My.Resources.Resources.la_gente_de_negocios_de_usuario_icono_4645_48
        Me.btnAdministrarProv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdministrarProv.Location = New System.Drawing.Point(456, 249)
        Me.btnAdministrarProv.Name = "btnAdministrarProv"
        Me.btnAdministrarProv.Size = New System.Drawing.Size(135, 50)
        Me.btnAdministrarProv.TabIndex = 14
        Me.btnAdministrarProv.Text = "Administrar Proveedores"
        Me.btnAdministrarProv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdministrarProv.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.S_Bank.My.Resources.Resources.salir_de_gnome_icono_8179_48
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(481, 334)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(110, 43)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.S_Bank.My.Resources.Resources.pantalla_de_sistemas_de_utilidades_icono_4301_48
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(456, 194)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 49)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Administrar Servicios"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCuentas
        '
        Me.btnCuentas.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCuentas.Image = Global.S_Bank.My.Resources.Resources.tarjeta_de_informacion_del_usuario_icono_7370_48
        Me.btnCuentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCuentas.Location = New System.Drawing.Point(456, 135)
        Me.btnCuentas.Name = "btnCuentas"
        Me.btnCuentas.Size = New System.Drawing.Size(135, 53)
        Me.btnCuentas.TabIndex = 12
        Me.btnCuentas.Text = "Administrar Cuentas"
        Me.btnCuentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCuentas.UseVisualStyleBackColor = True
        '
        'btnUsuarios
        '
        Me.btnUsuarios.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.Image = Global.S_Bank.My.Resources.Resources.los_usuarios_de_raza_mixta_masculina_icono_4624_48
        Me.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuarios.Location = New System.Drawing.Point(456, 83)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(135, 46)
        Me.btnUsuarios.TabIndex = 11
        Me.btnUsuarios.Text = "Administrar Usuarios"
        Me.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUsuarios.UseVisualStyleBackColor = True
        '
        'picAdmin
        '
        Me.picAdmin.BackColor = System.Drawing.Color.WhiteSmoke
        Me.picAdmin.BackgroundImage = Global.S_Bank.My.Resources.Resources.Administracion
        Me.picAdmin.Location = New System.Drawing.Point(24, 83)
        Me.picAdmin.Name = "picAdmin"
        Me.picAdmin.Size = New System.Drawing.Size(311, 255)
        Me.picAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picAdmin.TabIndex = 3
        Me.picAdmin.TabStop = False
        '
        'frmInicioAdm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.BackgroundImage = Global.S_Bank.My.Resources.Resources.FondoAzul2
        Me.ClientSize = New System.Drawing.Size(750, 450)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmInicioAdm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Administrador"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblBienvenido As System.Windows.Forms.Label
    Friend WithEvents picAdmin As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnCuentas As System.Windows.Forms.Button
    Friend WithEvents btnUsuarios As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnAdministrarProv As System.Windows.Forms.Button

End Class
