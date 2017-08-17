<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuarios))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnAltaUsuario = New System.Windows.Forms.Button()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblclave = New System.Windows.Forms.Label()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.txtNick = New System.Windows.Forms.TextBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.lblNick = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.lblDni = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtApe = New System.Windows.Forms.TextBox()
        Me.lblApe = New System.Windows.Forms.Label()
        Me.btnAsignarOtraCuenta = New System.Windows.Forms.Button()
        Me.rbnHombre = New System.Windows.Forms.RadioButton()
        Me.rbnMujer = New System.Windows.Forms.RadioButton()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(212, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(342, 31)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Administracion de Usuarios"
        '
        'btnAltaUsuario
        '
        Me.btnAltaUsuario.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAltaUsuario.Image = Global.S_Bank.My.Resources.Resources.anadir_usuario_icono_7225_48
        Me.btnAltaUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAltaUsuario.Location = New System.Drawing.Point(861, 254)
        Me.btnAltaUsuario.Name = "btnAltaUsuario"
        Me.btnAltaUsuario.Size = New System.Drawing.Size(143, 72)
        Me.btnAltaUsuario.TabIndex = 2
        Me.btnAltaUsuario.Text = "Nuevo Usuario"
        Me.btnAltaUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAltaUsuario.UseVisualStyleBackColor = True
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AllowUserToAddRows = False
        Me.dgvUsuarios.AllowUserToDeleteRows = False
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Location = New System.Drawing.Point(12, 34)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.ReadOnly = True
        Me.dgvUsuarios.Size = New System.Drawing.Size(996, 201)
        Me.dgvUsuarios.TabIndex = 3
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.S_Bank.My.Resources.Resources.salir_de_gnome_icono_8179_48
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(908, 434)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(100, 61)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Image = Global.S_Bank.My.Resources.Resources.preocupaciones_icono_8798_321
        Me.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtras.Location = New System.Drawing.Point(797, 434)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(86, 61)
        Me.btnAtras.TabIndex = 5
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackgroundImage = Global.S_Bank.My.Resources.Resources.editar_secuencias_de_comandos_icono_6203_32
        Me.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnConfirmar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfirmar.Location = New System.Drawing.Point(523, 131)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(101, 43)
        Me.btnConfirmar.TabIndex = 6
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(85, 47)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(129, 26)
        Me.txtDireccion.TabIndex = 7
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(85, 82)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(129, 26)
        Me.txtTelefono.TabIndex = 8
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.Transparent
        Me.lblID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblID.Location = New System.Drawing.Point(3, 11)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(28, 19)
        Me.lblID.TabIndex = 10
        Me.lblID.Text = "ID:"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.BackColor = System.Drawing.Color.Transparent
        Me.lblDireccion.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDireccion.Location = New System.Drawing.Point(6, 47)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(70, 19)
        Me.lblDireccion.TabIndex = 12
        Me.lblDireccion.Text = "Direccion:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.BackColor = System.Drawing.Color.Transparent
        Me.lblTelefono.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTelefono.Location = New System.Drawing.Point(6, 85)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(64, 19)
        Me.lblTelefono.TabIndex = 13
        Me.lblTelefono.Text = "Telefono:"
        '
        'lblclave
        '
        Me.lblclave.AutoSize = True
        Me.lblclave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclave.ForeColor = System.Drawing.Color.Red
        Me.lblclave.Location = New System.Drawing.Point(30, 11)
        Me.lblclave.Name = "lblclave"
        Me.lblclave.Size = New System.Drawing.Size(40, 19)
        Me.lblclave.TabIndex = 14
        Me.lblclave.Text = "clave"
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.BackColor = System.Drawing.Color.Transparent
        Me.lblContraseña.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblContraseña.Location = New System.Drawing.Point(4, 118)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(81, 19)
        Me.lblContraseña.TabIndex = 16
        Me.lblContraseña.Text = "Contraseña:"
        '
        'txtContraseña
        '
        Me.txtContraseña.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.Location = New System.Drawing.Point(85, 118)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(129, 26)
        Me.txtContraseña.TabIndex = 17
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = Global.S_Bank.My.Resources.Resources.images
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.rbnMujer)
        Me.Panel3.Controls.Add(Me.rbnHombre)
        Me.Panel3.Controls.Add(Me.dtpFechaNac)
        Me.Panel3.Controls.Add(Me.lblFecha)
        Me.Panel3.Controls.Add(Me.txtNick)
        Me.Panel3.Controls.Add(Me.txtMail)
        Me.Panel3.Controls.Add(Me.txtEdad)
        Me.Panel3.Controls.Add(Me.txtDni)
        Me.Panel3.Controls.Add(Me.lblNick)
        Me.Panel3.Controls.Add(Me.lblSexo)
        Me.Panel3.Controls.Add(Me.lblMail)
        Me.Panel3.Controls.Add(Me.lblEdad)
        Me.Panel3.Controls.Add(Me.lblDni)
        Me.Panel3.Controls.Add(Me.lblNom)
        Me.Panel3.Controls.Add(Me.txtNom)
        Me.Panel3.Controls.Add(Me.txtApe)
        Me.Panel3.Controls.Add(Me.lblApe)
        Me.Panel3.Controls.Add(Me.lblID)
        Me.Panel3.Controls.Add(Me.lblclave)
        Me.Panel3.Controls.Add(Me.btnConfirmar)
        Me.Panel3.Controls.Add(Me.txtContraseña)
        Me.Panel3.Controls.Add(Me.lblContraseña)
        Me.Panel3.Controls.Add(Me.lblDireccion)
        Me.Panel3.Controls.Add(Me.txtTelefono)
        Me.Panel3.Controls.Add(Me.lblTelefono)
        Me.Panel3.Controls.Add(Me.txtDireccion)
        Me.Panel3.Location = New System.Drawing.Point(12, 241)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(700, 254)
        Me.Panel3.TabIndex = 19
        '
        'dtpFechaNac
        '
        Me.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNac.Location = New System.Drawing.Point(537, 42)
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.Size = New System.Drawing.Size(87, 20)
        Me.dtpFechaNac.TabIndex = 33
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.BackColor = System.Drawing.Color.Transparent
        Me.lblFecha.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFecha.Location = New System.Drawing.Point(448, 44)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(83, 19)
        Me.lblFecha.TabIndex = 32
        Me.lblFecha.Text = "Fecha Nac.:"
        '
        'txtNick
        '
        Me.txtNick.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNick.Location = New System.Drawing.Point(298, 188)
        Me.txtNick.Name = "txtNick"
        Me.txtNick.Size = New System.Drawing.Size(129, 26)
        Me.txtNick.TabIndex = 31
        '
        'txtMail
        '
        Me.txtMail.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMail.Location = New System.Drawing.Point(298, 115)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(129, 26)
        Me.txtMail.TabIndex = 29
        '
        'txtEdad
        '
        Me.txtEdad.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdad.Location = New System.Drawing.Point(298, 82)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(129, 26)
        Me.txtEdad.TabIndex = 28
        '
        'txtDni
        '
        Me.txtDni.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDni.Location = New System.Drawing.Point(298, 44)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(129, 26)
        Me.txtDni.TabIndex = 27
        '
        'lblNick
        '
        Me.lblNick.AutoSize = True
        Me.lblNick.BackColor = System.Drawing.Color.Transparent
        Me.lblNick.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNick.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNick.Location = New System.Drawing.Point(238, 191)
        Me.lblNick.Name = "lblNick"
        Me.lblNick.Size = New System.Drawing.Size(42, 19)
        Me.lblNick.TabIndex = 26
        Me.lblNick.Text = "Nick:"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.BackColor = System.Drawing.Color.Transparent
        Me.lblSexo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSexo.Location = New System.Drawing.Point(238, 155)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(43, 19)
        Me.lblSexo.TabIndex = 25
        Me.lblSexo.Text = "Sexo:"
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.BackColor = System.Drawing.Color.Transparent
        Me.lblMail.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMail.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMail.Location = New System.Drawing.Point(238, 121)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(54, 19)
        Me.lblMail.TabIndex = 24
        Me.lblMail.Text = "E-Mail:"
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.BackColor = System.Drawing.Color.Transparent
        Me.lblEdad.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdad.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblEdad.Location = New System.Drawing.Point(238, 85)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(44, 19)
        Me.lblEdad.TabIndex = 23
        Me.lblEdad.Text = "Edad:"
        '
        'lblDni
        '
        Me.lblDni.AutoSize = True
        Me.lblDni.BackColor = System.Drawing.Color.Transparent
        Me.lblDni.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDni.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDni.Location = New System.Drawing.Point(238, 47)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Size = New System.Drawing.Size(40, 19)
        Me.lblDni.TabIndex = 22
        Me.lblDni.Text = "DNI:"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.BackColor = System.Drawing.Color.Transparent
        Me.lblNom.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNom.Location = New System.Drawing.Point(3, 188)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(63, 19)
        Me.lblNom.TabIndex = 21
        Me.lblNom.Text = "Nombre:"
        '
        'txtNom
        '
        Me.txtNom.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom.Location = New System.Drawing.Point(85, 188)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(129, 26)
        Me.txtNom.TabIndex = 20
        '
        'txtApe
        '
        Me.txtApe.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApe.Location = New System.Drawing.Point(85, 152)
        Me.txtApe.Name = "txtApe"
        Me.txtApe.Size = New System.Drawing.Size(129, 26)
        Me.txtApe.TabIndex = 19
        '
        'lblApe
        '
        Me.lblApe.AutoSize = True
        Me.lblApe.BackColor = System.Drawing.Color.Transparent
        Me.lblApe.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApe.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblApe.Location = New System.Drawing.Point(4, 155)
        Me.lblApe.Name = "lblApe"
        Me.lblApe.Size = New System.Drawing.Size(63, 19)
        Me.lblApe.TabIndex = 18
        Me.lblApe.Text = "Apellido:"
        '
        'btnAsignarOtraCuenta
        '
        Me.btnAsignarOtraCuenta.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsignarOtraCuenta.Image = Global.S_Bank.My.Resources.Resources.anadir_mas_datos_de_base_icono_8363_48
        Me.btnAsignarOtraCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAsignarOtraCuenta.Location = New System.Drawing.Point(861, 334)
        Me.btnAsignarOtraCuenta.Name = "btnAsignarOtraCuenta"
        Me.btnAsignarOtraCuenta.Size = New System.Drawing.Size(143, 65)
        Me.btnAsignarOtraCuenta.TabIndex = 20
        Me.btnAsignarOtraCuenta.Text = "Asignar Cuenta" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnAsignarOtraCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAsignarOtraCuenta.UseVisualStyleBackColor = True
        '
        'rbnHombre
        '
        Me.rbnHombre.AutoSize = True
        Me.rbnHombre.BackColor = System.Drawing.Color.Transparent
        Me.rbnHombre.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnHombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rbnHombre.Location = New System.Drawing.Point(298, 155)
        Me.rbnHombre.Name = "rbnHombre"
        Me.rbnHombre.Size = New System.Drawing.Size(77, 23)
        Me.rbnHombre.TabIndex = 34
        Me.rbnHombre.TabStop = True
        Me.rbnHombre.Text = "Hombre"
        Me.rbnHombre.UseVisualStyleBackColor = False
        '
        'rbnMujer
        '
        Me.rbnMujer.AutoSize = True
        Me.rbnMujer.BackColor = System.Drawing.Color.Transparent
        Me.rbnMujer.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnMujer.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rbnMujer.Location = New System.Drawing.Point(381, 155)
        Me.rbnMujer.Name = "rbnMujer"
        Me.rbnMujer.Size = New System.Drawing.Size(64, 23)
        Me.rbnMujer.TabIndex = 35
        Me.rbnMujer.TabStop = True
        Me.rbnMujer.Text = "Mujer"
        Me.rbnMujer.UseVisualStyleBackColor = False
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BackgroundImage = Global.S_Bank.My.Resources.Resources.FondoAzul2
        Me.ClientSize = New System.Drawing.Size(1029, 507)
        Me.Controls.Add(Me.btnAsignarOtraCuenta)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAltaUsuario)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.dgvUsuarios)
        Me.Controls.Add(Me.lblTitulo)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administracion de Usuarios"
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btnAltaUsuario As System.Windows.Forms.Button
    Friend WithEvents dgvUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents lblclave As System.Windows.Forms.Label
    Friend WithEvents lblContraseña As System.Windows.Forms.Label
    Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents txtNick As System.Windows.Forms.TextBox
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents txtEdad As System.Windows.Forms.TextBox
    Friend WithEvents txtDni As System.Windows.Forms.TextBox
    Friend WithEvents lblNick As System.Windows.Forms.Label
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents lblMail As System.Windows.Forms.Label
    Friend WithEvents lblEdad As System.Windows.Forms.Label
    Friend WithEvents lblDni As System.Windows.Forms.Label
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents txtApe As System.Windows.Forms.TextBox
    Friend WithEvents lblApe As System.Windows.Forms.Label
    Friend WithEvents dtpFechaNac As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnAsignarOtraCuenta As System.Windows.Forms.Button
    Friend WithEvents rbnHombre As System.Windows.Forms.RadioButton
    Friend WithEvents rbnMujer As System.Windows.Forms.RadioButton
End Class
