<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFormUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFormUsuario))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblmail = New System.Windows.Forms.Label()
        Me.lblDirec = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblEd = New System.Windows.Forms.Label()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.lblFechaNac = New System.Windows.Forms.Label()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.lblNroDoc = New System.Windows.Forms.Label()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.lblNomUsuario = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblNomyApe = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnSaldo = New System.Windows.Forms.Button()
        Me.btnMovimiento = New System.Windows.Forms.Button()
        Me.btnPagarServicios = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.S_Bank.My.Resources.Resources.imagesdfs
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblSex)
        Me.Panel1.Controls.Add(Me.lblSexo)
        Me.Panel1.Controls.Add(Me.lblCorreo)
        Me.Panel1.Controls.Add(Me.lblmail)
        Me.Panel1.Controls.Add(Me.lblDirec)
        Me.Panel1.Controls.Add(Me.lblDireccion)
        Me.Panel1.Controls.Add(Me.lblEd)
        Me.Panel1.Controls.Add(Me.lblEdad)
        Me.Panel1.Controls.Add(Me.lblFechaNac)
        Me.Panel1.Controls.Add(Me.lblFechaNacimiento)
        Me.Panel1.Controls.Add(Me.lblNroDoc)
        Me.Panel1.Controls.Add(Me.lblDNI)
        Me.Panel1.Controls.Add(Me.lblNombreUsuario)
        Me.Panel1.Controls.Add(Me.lblNomUsuario)
        Me.Panel1.Controls.Add(Me.lblCliente)
        Me.Panel1.Controls.Add(Me.lblNomyApe)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.Red
        Me.Panel1.Location = New System.Drawing.Point(21, 57)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(502, 172)
        Me.Panel1.TabIndex = 0
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.BackColor = System.Drawing.Color.Transparent
        Me.lblSex.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSex.ForeColor = System.Drawing.Color.Red
        Me.lblSex.Location = New System.Drawing.Point(374, 134)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(39, 17)
        Me.lblSex.TabIndex = 15
        Me.lblSex.Text = "sexo"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.BackColor = System.Drawing.Color.Transparent
        Me.lblSexo.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.ForeColor = System.Drawing.Color.White
        Me.lblSexo.Location = New System.Drawing.Point(227, 134)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(45, 17)
        Me.lblSexo.TabIndex = 14
        Me.lblSexo.Text = "Sexo:"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.BackColor = System.Drawing.Color.Transparent
        Me.lblCorreo.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.ForeColor = System.Drawing.Color.White
        Me.lblCorreo.Location = New System.Drawing.Point(15, 134)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(60, 17)
        Me.lblCorreo.TabIndex = 11
        Me.lblCorreo.Text = "Correo:"
        '
        'lblmail
        '
        Me.lblmail.AutoSize = True
        Me.lblmail.BackColor = System.Drawing.Color.Transparent
        Me.lblmail.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmail.ForeColor = System.Drawing.Color.Red
        Me.lblmail.Location = New System.Drawing.Point(82, 134)
        Me.lblmail.Name = "lblmail"
        Me.lblmail.Size = New System.Drawing.Size(48, 17)
        Me.lblmail.TabIndex = 12
        Me.lblmail.Text = "e-mail"
        '
        'lblDirec
        '
        Me.lblDirec.AutoSize = True
        Me.lblDirec.BackColor = System.Drawing.Color.Transparent
        Me.lblDirec.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirec.ForeColor = System.Drawing.Color.Red
        Me.lblDirec.Location = New System.Drawing.Point(374, 97)
        Me.lblDirec.Name = "lblDirec"
        Me.lblDirec.Size = New System.Drawing.Size(71, 17)
        Me.lblDirec.TabIndex = 13
        Me.lblDirec.Text = "Direccion"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.BackColor = System.Drawing.Color.Transparent
        Me.lblDireccion.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.ForeColor = System.Drawing.Color.White
        Me.lblDireccion.Location = New System.Drawing.Point(227, 97)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(76, 17)
        Me.lblDireccion.TabIndex = 12
        Me.lblDireccion.Text = "Dirección:"
        '
        'lblEd
        '
        Me.lblEd.AutoSize = True
        Me.lblEd.BackColor = System.Drawing.Color.Transparent
        Me.lblEd.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEd.ForeColor = System.Drawing.Color.Red
        Me.lblEd.Location = New System.Drawing.Point(82, 97)
        Me.lblEd.Name = "lblEd"
        Me.lblEd.Size = New System.Drawing.Size(41, 17)
        Me.lblEd.TabIndex = 11
        Me.lblEd.Text = "Edad"
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.BackColor = System.Drawing.Color.Transparent
        Me.lblEdad.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdad.ForeColor = System.Drawing.Color.White
        Me.lblEdad.Location = New System.Drawing.Point(15, 97)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(46, 17)
        Me.lblEdad.TabIndex = 10
        Me.lblEdad.Text = "Edad:"
        '
        'lblFechaNac
        '
        Me.lblFechaNac.AutoSize = True
        Me.lblFechaNac.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaNac.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNac.ForeColor = System.Drawing.Color.Red
        Me.lblFechaNac.Location = New System.Drawing.Point(374, 52)
        Me.lblFechaNac.Name = "lblFechaNac"
        Me.lblFechaNac.Size = New System.Drawing.Size(121, 17)
        Me.lblFechaNac.TabIndex = 9
        Me.lblFechaNac.Text = "FechaNacimiento"
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaNacimiento.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNacimiento.ForeColor = System.Drawing.Color.White
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(227, 52)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(150, 17)
        Me.lblFechaNacimiento.TabIndex = 8
        Me.lblFechaNacimiento.Text = "Fecha de Nacimiento:"
        '
        'lblNroDoc
        '
        Me.lblNroDoc.AutoSize = True
        Me.lblNroDoc.BackColor = System.Drawing.Color.Transparent
        Me.lblNroDoc.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroDoc.ForeColor = System.Drawing.Color.Red
        Me.lblNroDoc.Location = New System.Drawing.Point(82, 52)
        Me.lblNroDoc.Name = "lblNroDoc"
        Me.lblNroDoc.Size = New System.Drawing.Size(36, 17)
        Me.lblNroDoc.TabIndex = 7
        Me.lblNroDoc.Text = "DNI"
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.BackColor = System.Drawing.Color.Transparent
        Me.lblDNI.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNI.ForeColor = System.Drawing.Color.White
        Me.lblDNI.Location = New System.Drawing.Point(15, 52)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(49, 17)
        Me.lblDNI.TabIndex = 6
        Me.lblDNI.Text = "D.N.I:"
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreUsuario.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreUsuario.ForeColor = System.Drawing.Color.White
        Me.lblNombreUsuario.Location = New System.Drawing.Point(227, 15)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(141, 17)
        Me.lblNombreUsuario.TabIndex = 4
        Me.lblNombreUsuario.Text = "Nombre de Usuario:"
        '
        'lblNomUsuario
        '
        Me.lblNomUsuario.AutoSize = True
        Me.lblNomUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblNomUsuario.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomUsuario.ForeColor = System.Drawing.Color.Red
        Me.lblNomUsuario.Location = New System.Drawing.Point(374, 15)
        Me.lblNomUsuario.Name = "lblNomUsuario"
        Me.lblNomUsuario.Size = New System.Drawing.Size(112, 17)
        Me.lblNomUsuario.TabIndex = 5
        Me.lblNomUsuario.Text = "NombreUsuario"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.BackColor = System.Drawing.Color.Transparent
        Me.lblCliente.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.ForeColor = System.Drawing.Color.White
        Me.lblCliente.Location = New System.Drawing.Point(15, 15)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(61, 17)
        Me.lblCliente.TabIndex = 2
        Me.lblCliente.Text = "Cliente:"
        '
        'lblNomyApe
        '
        Me.lblNomyApe.AutoSize = True
        Me.lblNomyApe.BackColor = System.Drawing.Color.Transparent
        Me.lblNomyApe.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomyApe.ForeColor = System.Drawing.Color.Red
        Me.lblNomyApe.Location = New System.Drawing.Point(82, 15)
        Me.lblNomyApe.Name = "lblNomyApe"
        Me.lblNomyApe.Size = New System.Drawing.Size(67, 17)
        Me.lblNomyApe.TabIndex = 3
        Me.lblNomyApe.Text = "nomYape"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(196, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(169, 32)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Bienvenido! "
        '
        'btnSaldo
        '
        Me.btnSaldo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaldo.Location = New System.Drawing.Point(63, 273)
        Me.btnSaldo.Name = "btnSaldo"
        Me.btnSaldo.Size = New System.Drawing.Size(88, 56)
        Me.btnSaldo.TabIndex = 2
        Me.btnSaldo.Text = "Consultar Saldo"
        Me.btnSaldo.UseVisualStyleBackColor = True
        '
        'btnMovimiento
        '
        Me.btnMovimiento.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMovimiento.Location = New System.Drawing.Point(169, 273)
        Me.btnMovimiento.Name = "btnMovimiento"
        Me.btnMovimiento.Size = New System.Drawing.Size(106, 56)
        Me.btnMovimiento.TabIndex = 3
        Me.btnMovimiento.Text = "Realizar Movimiento"
        Me.btnMovimiento.UseVisualStyleBackColor = True
        '
        'btnPagarServicios
        '
        Me.btnPagarServicios.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagarServicios.Location = New System.Drawing.Point(296, 273)
        Me.btnPagarServicios.Name = "btnPagarServicios"
        Me.btnPagarServicios.Size = New System.Drawing.Size(103, 56)
        Me.btnPagarServicios.TabIndex = 4
        Me.btnPagarServicios.Text = "Pagar Servicios"
        Me.btnPagarServicios.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.S_Bank.My.Resources.Resources.salir_de_gnome_icono_8179_48
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(432, 295)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(91, 40)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmFormUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.S_Bank.My.Resources.Resources.tabla_de_madera_1280x800
        Me.ClientSize = New System.Drawing.Size(535, 341)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnPagarServicios)
        Me.Controls.Add(Me.btnMovimiento)
        Me.Controls.Add(Me.btnSaldo)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmFormUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario Usuario"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblFechaNac As System.Windows.Forms.Label
    Friend WithEvents lblFechaNacimiento As System.Windows.Forms.Label
    Friend WithEvents lblNroDoc As System.Windows.Forms.Label
    Friend WithEvents lblDNI As System.Windows.Forms.Label
    Friend WithEvents lblNombreUsuario As System.Windows.Forms.Label
    Friend WithEvents lblNomUsuario As System.Windows.Forms.Label
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents lblNomyApe As System.Windows.Forms.Label
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btnSaldo As System.Windows.Forms.Button
    Friend WithEvents btnMovimiento As System.Windows.Forms.Button
    Friend WithEvents btnPagarServicios As System.Windows.Forms.Button
    Friend WithEvents lblSex As System.Windows.Forms.Label
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Private WithEvents lblCorreo As System.Windows.Forms.Label
    Friend WithEvents lblmail As System.Windows.Forms.Label
    Friend WithEvents lblDirec As System.Windows.Forms.Label
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents lblEd As System.Windows.Forms.Label
    Friend WithEvents lblEdad As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
End Class
