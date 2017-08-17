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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnBackUp = New System.Windows.Forms.Button()
        Me.btnReportes = New System.Windows.Forms.Button()
        Me.btnMov = New System.Windows.Forms.Button()
        Me.btnFacturas = New System.Windows.Forms.Button()
        Me.btnAdminProv = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAdminServ = New System.Windows.Forms.Button()
        Me.btnAdminCuentas = New System.Windows.Forms.Button()
        Me.btnAdminUsuarios = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picFoto = New System.Windows.Forms.PictureBox()
        Me.btnMovimientos = New System.Windows.Forms.Button()
        Me.btnVerFacturas = New System.Windows.Forms.Button()
        Me.btnAdministrarProv = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCuentas = New System.Windows.Forms.Button()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.picAdmin = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnMovimientos)
        Me.Panel1.Controls.Add(Me.btnVerFacturas)
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = Global.S_Bank.My.Resources.Resources.images
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btnBackUp)
        Me.Panel2.Controls.Add(Me.btnReportes)
        Me.Panel2.Controls.Add(Me.btnMov)
        Me.Panel2.Controls.Add(Me.btnFacturas)
        Me.Panel2.Controls.Add(Me.btnAdminProv)
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Controls.Add(Me.btnAdminServ)
        Me.Panel2.Controls.Add(Me.btnAdminCuentas)
        Me.Panel2.Controls.Add(Me.btnAdminUsuarios)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.picFoto)
        Me.Panel2.Location = New System.Drawing.Point(-2, -2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(623, 411)
        Me.Panel2.TabIndex = 17
        '
        'btnBackUp
        '
        Me.btnBackUp.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackUp.Image = Global.S_Bank.My.Resources.Resources.Smsbackup_32
        Me.btnBackUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBackUp.Location = New System.Drawing.Point(482, 292)
        Me.btnBackUp.Name = "btnBackUp"
        Me.btnBackUp.Size = New System.Drawing.Size(135, 46)
        Me.btnBackUp.TabIndex = 18
        Me.btnBackUp.Text = "Back UP"
        Me.btnBackUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBackUp.UseVisualStyleBackColor = True
        '
        'btnReportes
        '
        Me.btnReportes.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportes.Image = Global.S_Bank.My.Resources.Resources.Reports_32
        Me.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReportes.Location = New System.Drawing.Point(341, 293)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(135, 46)
        Me.btnReportes.TabIndex = 17
        Me.btnReportes.Text = "Reportes"
        Me.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReportes.UseVisualStyleBackColor = True
        '
        'btnMov
        '
        Me.btnMov.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMov.Image = Global.S_Bank.My.Resources.Resources.actualizar
        Me.btnMov.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMov.Location = New System.Drawing.Point(482, 223)
        Me.btnMov.Name = "btnMov"
        Me.btnMov.Size = New System.Drawing.Size(135, 46)
        Me.btnMov.TabIndex = 16
        Me.btnMov.Text = "Movimientos"
        Me.btnMov.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMov.UseVisualStyleBackColor = True
        '
        'btnFacturas
        '
        Me.btnFacturas.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacturas.Image = Global.S_Bank.My.Resources.Resources.Folder_invoices_Icon_32
        Me.btnFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFacturas.Location = New System.Drawing.Point(341, 223)
        Me.btnFacturas.Name = "btnFacturas"
        Me.btnFacturas.Size = New System.Drawing.Size(135, 46)
        Me.btnFacturas.TabIndex = 15
        Me.btnFacturas.Text = "Ver Facturas"
        Me.btnFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFacturas.UseVisualStyleBackColor = True
        '
        'btnAdminProv
        '
        Me.btnAdminProv.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminProv.Image = Global.S_Bank.My.Resources.Resources.la_gente_de_negocios_de_usuario_icono_4645_48
        Me.btnAdminProv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdminProv.Location = New System.Drawing.Point(481, 151)
        Me.btnAdminProv.Name = "btnAdminProv"
        Me.btnAdminProv.Size = New System.Drawing.Size(135, 50)
        Me.btnAdminProv.TabIndex = 14
        Me.btnAdminProv.Text = "Administrar Proveedores"
        Me.btnAdminProv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdminProv.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.S_Bank.My.Resources.Resources.salir_de_gnome_icono_8179_48
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(506, 344)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(110, 43)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Salir"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAdminServ
        '
        Me.btnAdminServ.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminServ.Image = Global.S_Bank.My.Resources.Resources.pantalla_de_sistemas_de_utilidades_icono_4301_48
        Me.btnAdminServ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdminServ.Location = New System.Drawing.Point(341, 152)
        Me.btnAdminServ.Name = "btnAdminServ"
        Me.btnAdminServ.Size = New System.Drawing.Size(135, 49)
        Me.btnAdminServ.TabIndex = 13
        Me.btnAdminServ.Text = "Administrar Servicios"
        Me.btnAdminServ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdminServ.UseVisualStyleBackColor = True
        '
        'btnAdminCuentas
        '
        Me.btnAdminCuentas.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminCuentas.Image = Global.S_Bank.My.Resources.Resources.tarjeta_de_informacion_del_usuario_icono_7370_48
        Me.btnAdminCuentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdminCuentas.Location = New System.Drawing.Point(482, 83)
        Me.btnAdminCuentas.Name = "btnAdminCuentas"
        Me.btnAdminCuentas.Size = New System.Drawing.Size(135, 46)
        Me.btnAdminCuentas.TabIndex = 12
        Me.btnAdminCuentas.Text = "Administrar Cuentas"
        Me.btnAdminCuentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdminCuentas.UseVisualStyleBackColor = True
        '
        'btnAdminUsuarios
        '
        Me.btnAdminUsuarios.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminUsuarios.Image = Global.S_Bank.My.Resources.Resources.los_usuarios_de_raza_mixta_masculina_icono_4624_48
        Me.btnAdminUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdminUsuarios.Location = New System.Drawing.Point(341, 83)
        Me.btnAdminUsuarios.Name = "btnAdminUsuarios"
        Me.btnAdminUsuarios.Size = New System.Drawing.Size(135, 46)
        Me.btnAdminUsuarios.TabIndex = 11
        Me.btnAdminUsuarios.Text = "Administrar Usuarios"
        Me.btnAdminUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdminUsuarios.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(339, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Bienvenido Administrador"
        '
        'picFoto
        '
        Me.picFoto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.picFoto.BackgroundImage = Global.S_Bank.My.Resources.Resources.Administracion
        Me.picFoto.Location = New System.Drawing.Point(24, 83)
        Me.picFoto.Name = "picFoto"
        Me.picFoto.Size = New System.Drawing.Size(311, 255)
        Me.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picFoto.TabIndex = 3
        Me.picFoto.TabStop = False
        '
        'btnMovimientos
        '
        Me.btnMovimientos.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMovimientos.Image = Global.S_Bank.My.Resources.Resources.actualizar
        Me.btnMovimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMovimientos.Location = New System.Drawing.Point(482, 223)
        Me.btnMovimientos.Name = "btnMovimientos"
        Me.btnMovimientos.Size = New System.Drawing.Size(135, 46)
        Me.btnMovimientos.TabIndex = 16
        Me.btnMovimientos.Text = "Movimientos"
        Me.btnMovimientos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMovimientos.UseVisualStyleBackColor = True
        '
        'btnVerFacturas
        '
        Me.btnVerFacturas.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerFacturas.Image = Global.S_Bank.My.Resources.Resources.Folder_invoices_Icon_32
        Me.btnVerFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerFacturas.Location = New System.Drawing.Point(341, 223)
        Me.btnVerFacturas.Name = "btnVerFacturas"
        Me.btnVerFacturas.Size = New System.Drawing.Size(135, 46)
        Me.btnVerFacturas.TabIndex = 15
        Me.btnVerFacturas.Text = "Ver Facturas"
        Me.btnVerFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVerFacturas.UseVisualStyleBackColor = True
        '
        'btnAdministrarProv
        '
        Me.btnAdministrarProv.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdministrarProv.Image = Global.S_Bank.My.Resources.Resources.la_gente_de_negocios_de_usuario_icono_4645_48
        Me.btnAdministrarProv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdministrarProv.Location = New System.Drawing.Point(481, 151)
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
        Me.btnSalir.Location = New System.Drawing.Point(506, 295)
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
        Me.Button1.Location = New System.Drawing.Point(341, 152)
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
        Me.btnCuentas.Location = New System.Drawing.Point(482, 83)
        Me.btnCuentas.Name = "btnCuentas"
        Me.btnCuentas.Size = New System.Drawing.Size(135, 46)
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
        Me.btnUsuarios.Location = New System.Drawing.Point(341, 83)
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
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnVerFacturas As System.Windows.Forms.Button
    Friend WithEvents btnMovimientos As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnReportes As System.Windows.Forms.Button
    Friend WithEvents btnMov As System.Windows.Forms.Button
    Friend WithEvents btnFacturas As System.Windows.Forms.Button
    Friend WithEvents btnAdminProv As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnAdminServ As System.Windows.Forms.Button
    Friend WithEvents btnAdminCuentas As System.Windows.Forms.Button
    Friend WithEvents btnAdminUsuarios As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picFoto As System.Windows.Forms.PictureBox
    Friend WithEvents btnBackUp As System.Windows.Forms.Button

End Class
