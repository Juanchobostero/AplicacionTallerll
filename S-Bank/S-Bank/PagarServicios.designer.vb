<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagarServicios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPagarServicios))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbxCuentasAsociadas = New System.Windows.Forms.ComboBox()
        Me.lblCuentaAfectada = New System.Windows.Forms.Label()
        Me.lblIDusuario = New System.Windows.Forms.Label()
        Me.lblNomUsuario = New System.Windows.Forms.Label()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.lblapeYnom = New System.Windows.Forms.Label()
        Me.lblApellidoyNombre = New System.Windows.Forms.Label()
        Me.dtvFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaPago = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbServicios = New System.Windows.Forms.ComboBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblTipoServicio = New System.Windows.Forms.Label()
        Me.lblPrecioServicio = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnBorrarDetalle = New System.Windows.Forms.Button()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.btnFacturas = New System.Windows.Forms.Button()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(304, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(178, 25)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Pagar Servicios"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.cbxCuentasAsociadas)
        Me.Panel1.Controls.Add(Me.lblCuentaAfectada)
        Me.Panel1.Controls.Add(Me.lblIDusuario)
        Me.Panel1.Controls.Add(Me.lblNomUsuario)
        Me.Panel1.Controls.Add(Me.lblNombreUsuario)
        Me.Panel1.Controls.Add(Me.lblapeYnom)
        Me.Panel1.Controls.Add(Me.lblApellidoyNombre)
        Me.Panel1.Location = New System.Drawing.Point(12, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(419, 99)
        Me.Panel1.TabIndex = 16
        '
        'cbxCuentasAsociadas
        '
        Me.cbxCuentasAsociadas.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCuentasAsociadas.FormattingEnabled = True
        Me.cbxCuentasAsociadas.Location = New System.Drawing.Point(150, 59)
        Me.cbxCuentasAsociadas.Name = "cbxCuentasAsociadas"
        Me.cbxCuentasAsociadas.Size = New System.Drawing.Size(121, 25)
        Me.cbxCuentasAsociadas.TabIndex = 8
        '
        'lblCuentaAfectada
        '
        Me.lblCuentaAfectada.AutoSize = True
        Me.lblCuentaAfectada.BackColor = System.Drawing.Color.Transparent
        Me.lblCuentaAfectada.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuentaAfectada.ForeColor = System.Drawing.Color.White
        Me.lblCuentaAfectada.Location = New System.Drawing.Point(19, 67)
        Me.lblCuentaAfectada.Name = "lblCuentaAfectada"
        Me.lblCuentaAfectada.Size = New System.Drawing.Size(111, 17)
        Me.lblCuentaAfectada.TabIndex = 7
        Me.lblCuentaAfectada.Text = "Cuenta Afectada:"
        '
        'lblIDusuario
        '
        Me.lblIDusuario.AutoSize = True
        Me.lblIDusuario.BackColor = System.Drawing.Color.Transparent
        Me.lblIDusuario.ForeColor = System.Drawing.Color.Black
        Me.lblIDusuario.Location = New System.Drawing.Point(394, 69)
        Me.lblIDusuario.Name = "lblIDusuario"
        Me.lblIDusuario.Size = New System.Drawing.Size(18, 13)
        Me.lblIDusuario.TabIndex = 6
        Me.lblIDusuario.Text = "ID"
        '
        'lblNomUsuario
        '
        Me.lblNomUsuario.AutoSize = True
        Me.lblNomUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblNomUsuario.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomUsuario.ForeColor = System.Drawing.Color.Red
        Me.lblNomUsuario.Location = New System.Drawing.Point(152, 36)
        Me.lblNomUsuario.Name = "lblNomUsuario"
        Me.lblNomUsuario.Size = New System.Drawing.Size(90, 17)
        Me.lblNomUsuario.TabIndex = 5
        Me.lblNomUsuario.Text = "NomUsuario"
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreUsuario.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreUsuario.ForeColor = System.Drawing.Color.White
        Me.lblNombreUsuario.Location = New System.Drawing.Point(19, 37)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(127, 17)
        Me.lblNombreUsuario.TabIndex = 3
        Me.lblNombreUsuario.Text = "Nombre de Usuario:"
        '
        'lblapeYnom
        '
        Me.lblapeYnom.AutoSize = True
        Me.lblapeYnom.BackColor = System.Drawing.Color.Transparent
        Me.lblapeYnom.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblapeYnom.ForeColor = System.Drawing.Color.Red
        Me.lblapeYnom.Location = New System.Drawing.Point(152, 6)
        Me.lblapeYnom.Name = "lblapeYnom"
        Me.lblapeYnom.Size = New System.Drawing.Size(69, 17)
        Me.lblapeYnom.TabIndex = 1
        Me.lblapeYnom.Text = "apeYnom"
        '
        'lblApellidoyNombre
        '
        Me.lblApellidoyNombre.AutoSize = True
        Me.lblApellidoyNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblApellidoyNombre.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidoyNombre.ForeColor = System.Drawing.Color.White
        Me.lblApellidoyNombre.Location = New System.Drawing.Point(19, 7)
        Me.lblApellidoyNombre.Name = "lblApellidoyNombre"
        Me.lblApellidoyNombre.Size = New System.Drawing.Size(122, 17)
        Me.lblApellidoyNombre.TabIndex = 0
        Me.lblApellidoyNombre.Text = "Apellido y Nombre:"
        '
        'dtvFechaPago
        '
        Me.dtvFechaPago.CustomFormat = ""
        Me.dtvFechaPago.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtvFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtvFechaPago.Location = New System.Drawing.Point(150, 68)
        Me.dtvFechaPago.Name = "dtvFechaPago"
        Me.dtvFechaPago.Size = New System.Drawing.Size(79, 25)
        Me.dtvFechaPago.TabIndex = 11
        Me.dtvFechaPago.Value = New Date(2014, 9, 7, 0, 0, 0, 0)
        '
        'lblFechaPago
        '
        Me.lblFechaPago.AutoSize = True
        Me.lblFechaPago.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaPago.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaPago.ForeColor = System.Drawing.Color.White
        Me.lblFechaPago.Location = New System.Drawing.Point(13, 68)
        Me.lblFechaPago.Name = "lblFechaPago"
        Me.lblFechaPago.Size = New System.Drawing.Size(103, 17)
        Me.lblFechaPago.TabIndex = 1
        Me.lblFechaPago.Text = "Fecha de Pago: "
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.cbServicios)
        Me.Panel2.Controls.Add(Me.dtvFechaPago)
        Me.Panel2.Controls.Add(Me.lblFechaPago)
        Me.Panel2.Controls.Add(Me.btnEliminar)
        Me.Panel2.Controls.Add(Me.btnCargar)
        Me.Panel2.Controls.Add(Me.lblPeso)
        Me.Panel2.Controls.Add(Me.lblPrecio)
        Me.Panel2.Controls.Add(Me.lblTipoServicio)
        Me.Panel2.Controls.Add(Me.lblPrecioServicio)
        Me.Panel2.Location = New System.Drawing.Point(12, 171)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(419, 172)
        Me.Panel2.TabIndex = 17
        '
        'cbServicios
        '
        Me.cbServicios.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbServicios.FormattingEnabled = True
        Me.cbServicios.Location = New System.Drawing.Point(150, 15)
        Me.cbServicios.Name = "cbServicios"
        Me.cbServicios.Size = New System.Drawing.Size(121, 25)
        Me.cbServicios.TabIndex = 16
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.S_Bank.My.Resources.Resources.Stop_2
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(295, 82)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(95, 56)
        Me.btnEliminar.TabIndex = 14
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnCargar
        '
        Me.btnCargar.Image = Global.S_Bank.My.Resources.Resources.Fasticon_Shop_Cart_Shop_cart_add
        Me.btnCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCargar.Location = New System.Drawing.Point(296, 20)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(94, 56)
        Me.btnCargar.TabIndex = 13
        Me.btnCargar.Text = "Cargar"
        Me.btnCargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.BackColor = System.Drawing.Color.Transparent
        Me.lblPeso.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeso.ForeColor = System.Drawing.Color.Red
        Me.lblPeso.Location = New System.Drawing.Point(147, 121)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(15, 17)
        Me.lblPeso.TabIndex = 4
        Me.lblPeso.Text = "$"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.BackColor = System.Drawing.Color.Transparent
        Me.lblPrecio.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.ForeColor = System.Drawing.Color.Red
        Me.lblPrecio.Location = New System.Drawing.Point(168, 120)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(49, 17)
        Me.lblPrecio.TabIndex = 3
        Me.lblPrecio.Text = "precio"
        '
        'lblTipoServicio
        '
        Me.lblTipoServicio.AutoSize = True
        Me.lblTipoServicio.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoServicio.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoServicio.ForeColor = System.Drawing.Color.White
        Me.lblTipoServicio.Location = New System.Drawing.Point(13, 20)
        Me.lblTipoServicio.Name = "lblTipoServicio"
        Me.lblTipoServicio.Size = New System.Drawing.Size(130, 17)
        Me.lblTipoServicio.TabIndex = 1
        Me.lblTipoServicio.Text = "Seleccionar Servicio:"
        '
        'lblPrecioServicio
        '
        Me.lblPrecioServicio.AutoSize = True
        Me.lblPrecioServicio.BackColor = System.Drawing.Color.Transparent
        Me.lblPrecioServicio.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioServicio.ForeColor = System.Drawing.Color.White
        Me.lblPrecioServicio.Location = New System.Drawing.Point(13, 121)
        Me.lblPrecioServicio.Name = "lblPrecioServicio"
        Me.lblPrecioServicio.Size = New System.Drawing.Size(133, 17)
        Me.lblPrecioServicio.TabIndex = 2
        Me.lblPrecioServicio.Text = "Precio del Servicio:   "
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.S_Bank.My.Resources.Resources.imagesdfs
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.btnBorrarDetalle)
        Me.Panel3.Controls.Add(Me.btnPagar)
        Me.Panel3.Controls.Add(Me.btnFacturas)
        Me.Panel3.Location = New System.Drawing.Point(12, 365)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(419, 57)
        Me.Panel3.TabIndex = 18
        '
        'btnBorrarDetalle
        '
        Me.btnBorrarDetalle.Image = Global.S_Bank.My.Resources.Resources.Fasticon_Shop_Cart_Shop_cart_exclude
        Me.btnBorrarDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrarDetalle.Location = New System.Drawing.Point(154, 3)
        Me.btnBorrarDetalle.Name = "btnBorrarDetalle"
        Me.btnBorrarDetalle.Size = New System.Drawing.Size(109, 42)
        Me.btnBorrarDetalle.TabIndex = 2
        Me.btnBorrarDetalle.Text = "Borrar Detalle"
        Me.btnBorrarDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBorrarDetalle.UseVisualStyleBackColor = True
        '
        'btnPagar
        '
        Me.btnPagar.Image = Global.S_Bank.My.Resources.Resources.Fasticon_Shop_Cart_Shop_cart_apply
        Me.btnPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPagar.Location = New System.Drawing.Point(59, 3)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(89, 42)
        Me.btnPagar.TabIndex = 5
        Me.btnPagar.Text = "Pagar"
        Me.btnPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPagar.UseVisualStyleBackColor = True
        '
        'btnFacturas
        '
        Me.btnFacturas.Image = Global.S_Bank.My.Resources.Resources.Aha_Soft_Universal_Shop_Cash_register
        Me.btnFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFacturas.Location = New System.Drawing.Point(269, 3)
        Me.btnFacturas.Name = "btnFacturas"
        Me.btnFacturas.Size = New System.Drawing.Size(108, 42)
        Me.btnFacturas.TabIndex = 24
        Me.btnFacturas.Text = "Ver Facturas"
        Me.btnFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFacturas.UseVisualStyleBackColor = True
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToDeleteRows = False
        Me.dgvDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Location = New System.Drawing.Point(457, 82)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.ReadOnly = True
        Me.dgvDetalle.RowTemplate.Height = 24
        Me.dgvDetalle.Size = New System.Drawing.Size(347, 239)
        Me.dgvDetalle.TabIndex = 19
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(453, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 25)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Detalle"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(659, 342)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 20)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "TOTAL:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(734, 342)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 20)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "$"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Red
        Me.lblTotal.Location = New System.Drawing.Point(759, 342)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(45, 20)
        Me.lblTotal.TabIndex = 22
        Me.lblTotal.Text = "total"
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.S_Bank.My.Resources.Resources.salir_de_gnome_icono_8179_48
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(717, 386)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(87, 36)
        Me.btnSalir.TabIndex = 25
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.Image = Global.S_Bank.My.Resources.Resources.preocupaciones_icono_8798_321
        Me.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtras.Location = New System.Drawing.Point(621, 386)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(77, 36)
        Me.btnAtras.TabIndex = 26
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'frmPagarServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.S_Bank.My.Resources.Resources.tabla_de_madera_1280x800
        Me.ClientSize = New System.Drawing.Size(823, 434)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.dgvDetalle)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label9)
        Me.Name = "frmPagarServicios"
        Me.Text = "Pagar Servicios"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dtvFechaPago As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaPago As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnCargar As System.Windows.Forms.Button
    Friend WithEvents lblPeso As System.Windows.Forms.Label
    Friend WithEvents lblPrecio As System.Windows.Forms.Label
    Friend WithEvents lblTipoServicio As System.Windows.Forms.Label
    Friend WithEvents lblPrecioServicio As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnBorrarDetalle As System.Windows.Forms.Button
    Friend WithEvents btnPagar As System.Windows.Forms.Button
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents btnFacturas As System.Windows.Forms.Button
    Friend WithEvents lblNomUsuario As System.Windows.Forms.Label
    Friend WithEvents lblNombreUsuario As System.Windows.Forms.Label
    Friend WithEvents lblapeYnom As System.Windows.Forms.Label
    Friend WithEvents lblApellidoyNombre As System.Windows.Forms.Label
    Friend WithEvents cbServicios As System.Windows.Forms.ComboBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents lblIDusuario As System.Windows.Forms.Label
    Friend WithEvents cbxCuentasAsociadas As System.Windows.Forms.ComboBox
    Friend WithEvents lblCuentaAfectada As System.Windows.Forms.Label
End Class
