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
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.lblSignoPeso = New System.Windows.Forms.Label()
        Me.lblSaldoCuenta = New System.Windows.Forms.Label()
        Me.cbxCuentasAsociadas = New System.Windows.Forms.ComboBox()
        Me.lblCuentaAfectada = New System.Windows.Forms.Label()
        Me.lblNomUsuario = New System.Windows.Forms.Label()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.lblapeYnom = New System.Windows.Forms.Label()
        Me.lblApellidoyNombre = New System.Windows.Forms.Label()
        Me.lblFechaPago = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtpFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.lblPagoServicio = New System.Windows.Forms.Label()
        Me.lblDescripcionMovimiento = New System.Windows.Forms.Label()
        Me.cbxServicios = New System.Windows.Forms.ComboBox()
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cbxPeriodoMes = New System.Windows.Forms.ComboBox()
        Me.lblPeriodoYEAR = New System.Windows.Forms.Label()
        Me.lblAñoPeriodo = New System.Windows.Forms.Label()
        Me.lblPeriodoMes = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(304, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(197, 31)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Pagar Servicios"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblSaldo)
        Me.Panel1.Controls.Add(Me.lblSignoPeso)
        Me.Panel1.Controls.Add(Me.lblSaldoCuenta)
        Me.Panel1.Controls.Add(Me.cbxCuentasAsociadas)
        Me.Panel1.Controls.Add(Me.lblCuentaAfectada)
        Me.Panel1.Controls.Add(Me.lblNomUsuario)
        Me.Panel1.Controls.Add(Me.lblNombreUsuario)
        Me.Panel1.Controls.Add(Me.lblapeYnom)
        Me.Panel1.Controls.Add(Me.lblApellidoyNombre)
        Me.Panel1.Location = New System.Drawing.Point(12, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(419, 99)
        Me.Panel1.TabIndex = 16
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.BackColor = System.Drawing.Color.Transparent
        Me.lblSaldo.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldo.ForeColor = System.Drawing.Color.Red
        Me.lblSaldo.Location = New System.Drawing.Point(360, 66)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(42, 17)
        Me.lblSaldo.TabIndex = 23
        Me.lblSaldo.Text = "saldo"
        '
        'lblSignoPeso
        '
        Me.lblSignoPeso.AutoSize = True
        Me.lblSignoPeso.BackColor = System.Drawing.Color.Transparent
        Me.lblSignoPeso.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignoPeso.ForeColor = System.Drawing.Color.Red
        Me.lblSignoPeso.Location = New System.Drawing.Point(338, 67)
        Me.lblSignoPeso.Name = "lblSignoPeso"
        Me.lblSignoPeso.Size = New System.Drawing.Size(16, 17)
        Me.lblSignoPeso.TabIndex = 28
        Me.lblSignoPeso.Text = "$"
        '
        'lblSaldoCuenta
        '
        Me.lblSaldoCuenta.AutoSize = True
        Me.lblSaldoCuenta.BackColor = System.Drawing.Color.Transparent
        Me.lblSaldoCuenta.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoCuenta.ForeColor = System.Drawing.Color.White
        Me.lblSaldoCuenta.Location = New System.Drawing.Point(292, 68)
        Me.lblSaldoCuenta.Name = "lblSaldoCuenta"
        Me.lblSaldoCuenta.Size = New System.Drawing.Size(55, 17)
        Me.lblSaldoCuenta.TabIndex = 27
        Me.lblSaldoCuenta.Text = "Saldo:   "
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
        'lblFechaPago
        '
        Me.lblFechaPago.AutoSize = True
        Me.lblFechaPago.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaPago.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaPago.ForeColor = System.Drawing.Color.White
        Me.lblFechaPago.Location = New System.Drawing.Point(13, 104)
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
        Me.Panel2.Controls.Add(Me.dtpFechaPago)
        Me.Panel2.Controls.Add(Me.lblPagoServicio)
        Me.Panel2.Controls.Add(Me.lblDescripcionMovimiento)
        Me.Panel2.Controls.Add(Me.cbxServicios)
        Me.Panel2.Controls.Add(Me.lblFechaPago)
        Me.Panel2.Controls.Add(Me.btnEliminar)
        Me.Panel2.Controls.Add(Me.btnCargar)
        Me.Panel2.Controls.Add(Me.lblPeso)
        Me.Panel2.Controls.Add(Me.lblPrecio)
        Me.Panel2.Controls.Add(Me.lblTipoServicio)
        Me.Panel2.Controls.Add(Me.lblPrecioServicio)
        Me.Panel2.Location = New System.Drawing.Point(12, 181)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(419, 193)
        Me.Panel2.TabIndex = 17
        '
        'dtpFechaPago
        '
        Me.dtpFechaPago.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaPago.Location = New System.Drawing.Point(150, 96)
        Me.dtpFechaPago.Name = "dtpFechaPago"
        Me.dtpFechaPago.Size = New System.Drawing.Size(100, 26)
        Me.dtpFechaPago.TabIndex = 21
        '
        'lblPagoServicio
        '
        Me.lblPagoServicio.AutoSize = True
        Me.lblPagoServicio.BackColor = System.Drawing.Color.Transparent
        Me.lblPagoServicio.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPagoServicio.ForeColor = System.Drawing.Color.Red
        Me.lblPagoServicio.Location = New System.Drawing.Point(194, 9)
        Me.lblPagoServicio.Name = "lblPagoServicio"
        Me.lblPagoServicio.Size = New System.Drawing.Size(117, 17)
        Me.lblPagoServicio.TabIndex = 18
        Me.lblPagoServicio.Text = "Pago de Servicio"
        '
        'lblDescripcionMovimiento
        '
        Me.lblDescripcionMovimiento.AutoSize = True
        Me.lblDescripcionMovimiento.BackColor = System.Drawing.Color.Transparent
        Me.lblDescripcionMovimiento.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionMovimiento.ForeColor = System.Drawing.Color.White
        Me.lblDescripcionMovimiento.Location = New System.Drawing.Point(13, 10)
        Me.lblDescripcionMovimiento.Name = "lblDescripcionMovimiento"
        Me.lblDescripcionMovimiento.Size = New System.Drawing.Size(175, 17)
        Me.lblDescripcionMovimiento.TabIndex = 17
        Me.lblDescripcionMovimiento.Text = "Descripcion del Movimiento:"
        '
        'cbxServicios
        '
        Me.cbxServicios.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxServicios.FormattingEnabled = True
        Me.cbxServicios.Location = New System.Drawing.Point(150, 52)
        Me.cbxServicios.Name = "cbxServicios"
        Me.cbxServicios.Size = New System.Drawing.Size(121, 25)
        Me.cbxServicios.TabIndex = 16
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.Black
        Me.btnEliminar.Image = Global.S_Bank.My.Resources.Resources.Stop_2
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(307, 92)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(95, 56)
        Me.btnEliminar.TabIndex = 14
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnCargar
        '
        Me.btnCargar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargar.ForeColor = System.Drawing.Color.Black
        Me.btnCargar.Image = Global.S_Bank.My.Resources.Resources.Add_green_32
        Me.btnCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCargar.Location = New System.Drawing.Point(308, 29)
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
        Me.lblPeso.Location = New System.Drawing.Point(147, 153)
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
        Me.lblPrecio.Location = New System.Drawing.Point(172, 151)
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
        Me.lblTipoServicio.Location = New System.Drawing.Point(11, 55)
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
        Me.lblPrecioServicio.Location = New System.Drawing.Point(13, 152)
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
        Me.Panel3.Location = New System.Drawing.Point(12, 394)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(419, 57)
        Me.Panel3.TabIndex = 18
        '
        'btnBorrarDetalle
        '
        Me.btnBorrarDetalle.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarDetalle.ForeColor = System.Drawing.Color.Black
        Me.btnBorrarDetalle.Image = Global.S_Bank.My.Resources.Resources.Gnome_Edit_Clear_32
        Me.btnBorrarDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrarDetalle.Location = New System.Drawing.Point(154, 3)
        Me.btnBorrarDetalle.Name = "btnBorrarDetalle"
        Me.btnBorrarDetalle.Size = New System.Drawing.Size(109, 42)
        Me.btnBorrarDetalle.TabIndex = 2
        Me.btnBorrarDetalle.Text = "Limpiar Detalle"
        Me.btnBorrarDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBorrarDetalle.UseVisualStyleBackColor = True
        '
        'btnPagar
        '
        Me.btnPagar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagar.ForeColor = System.Drawing.Color.Black
        Me.btnPagar.Image = Global.S_Bank.My.Resources.Resources.Money_Bag_32
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
        Me.btnFacturas.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacturas.ForeColor = System.Drawing.Color.Black
        Me.btnFacturas.Image = Global.S_Bank.My.Resources.Resources.Aha_Soft_Universal_Shop_Cash_register
        Me.btnFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFacturas.Location = New System.Drawing.Point(269, 3)
        Me.btnFacturas.Name = "btnFacturas"
        Me.btnFacturas.Size = New System.Drawing.Size(113, 42)
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
        Me.dgvDetalle.Location = New System.Drawing.Point(457, 202)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.ReadOnly = True
        Me.dgvDetalle.RowTemplate.Height = 24
        Me.dgvDetalle.Size = New System.Drawing.Size(354, 172)
        Me.dgvDetalle.TabIndex = 19
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(452, 171)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 26)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Detalle"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(641, 394)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 24)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "TOTAL:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(733, 394)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 24)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "$"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Red
        Me.lblTotal.Location = New System.Drawing.Point(760, 394)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(51, 24)
        Me.lblTotal.TabIndex = 22
        Me.lblTotal.Text = "total"
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = Global.S_Bank.My.Resources.Resources.salir_de_gnome_icono_8179_48
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(724, 433)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(87, 36)
        Me.btnSalir.TabIndex = 25
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.ForeColor = System.Drawing.Color.Black
        Me.btnAtras.Image = Global.S_Bank.My.Resources.Resources.preocupaciones_icono_8798_321
        Me.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtras.Location = New System.Drawing.Point(641, 433)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(77, 36)
        Me.btnAtras.TabIndex = 26
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = Global.S_Bank.My.Resources.Resources.imagesdfs
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.cbxPeriodoMes)
        Me.Panel4.Controls.Add(Me.lblPeriodoYEAR)
        Me.Panel4.Controls.Add(Me.lblAñoPeriodo)
        Me.Panel4.Controls.Add(Me.lblPeriodoMes)
        Me.Panel4.Controls.Add(Me.lblTitulo)
        Me.Panel4.Location = New System.Drawing.Point(457, 54)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(293, 99)
        Me.Panel4.TabIndex = 27
        '
        'cbxPeriodoMes
        '
        Me.cbxPeriodoMes.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxPeriodoMes.FormattingEnabled = True
        Me.cbxPeriodoMes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cbxPeriodoMes.Location = New System.Drawing.Point(109, 33)
        Me.cbxPeriodoMes.Name = "cbxPeriodoMes"
        Me.cbxPeriodoMes.Size = New System.Drawing.Size(121, 25)
        Me.cbxPeriodoMes.TabIndex = 26
        '
        'lblPeriodoYEAR
        '
        Me.lblPeriodoYEAR.AutoSize = True
        Me.lblPeriodoYEAR.BackColor = System.Drawing.Color.Transparent
        Me.lblPeriodoYEAR.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriodoYEAR.ForeColor = System.Drawing.Color.Red
        Me.lblPeriodoYEAR.Location = New System.Drawing.Point(106, 67)
        Me.lblPeriodoYEAR.Name = "lblPeriodoYEAR"
        Me.lblPeriodoYEAR.Size = New System.Drawing.Size(92, 17)
        Me.lblPeriodoYEAR.TabIndex = 25
        Me.lblPeriodoYEAR.Text = "periodoYEAR"
        '
        'lblAñoPeriodo
        '
        Me.lblAñoPeriodo.AutoSize = True
        Me.lblAñoPeriodo.BackColor = System.Drawing.Color.Transparent
        Me.lblAñoPeriodo.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAñoPeriodo.ForeColor = System.Drawing.Color.White
        Me.lblAñoPeriodo.Location = New System.Drawing.Point(3, 67)
        Me.lblAñoPeriodo.Name = "lblAñoPeriodo"
        Me.lblAñoPeriodo.Size = New System.Drawing.Size(96, 17)
        Me.lblAñoPeriodo.TabIndex = 24
        Me.lblAñoPeriodo.Text = "Año del Priodo"
        '
        'lblPeriodoMes
        '
        Me.lblPeriodoMes.AutoSize = True
        Me.lblPeriodoMes.BackColor = System.Drawing.Color.Transparent
        Me.lblPeriodoMes.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriodoMes.ForeColor = System.Drawing.Color.White
        Me.lblPeriodoMes.Location = New System.Drawing.Point(3, 36)
        Me.lblPeriodoMes.Name = "lblPeriodoMes"
        Me.lblPeriodoMes.Size = New System.Drawing.Size(119, 17)
        Me.lblPeriodoMes.TabIndex = 23
        Me.lblPeriodoMes.Text = "Mes del Periodo:   "
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(73, 5)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(157, 18)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Periodo del Pago"
        '
        'frmPagarServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.S_Bank.My.Resources.Resources.tabla_de_madera_1280x800
        Me.ClientSize = New System.Drawing.Size(823, 471)
        Me.Controls.Add(Me.Panel4)
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
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmPagarServicios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pagar Servicios"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
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
    Friend WithEvents cbxServicios As System.Windows.Forms.ComboBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents cbxCuentasAsociadas As System.Windows.Forms.ComboBox
    Friend WithEvents lblCuentaAfectada As System.Windows.Forms.Label
    Friend WithEvents lblPagoServicio As System.Windows.Forms.Label
    Friend WithEvents lblDescripcionMovimiento As System.Windows.Forms.Label
    Friend WithEvents dtpFechaPago As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents cbxPeriodoMes As System.Windows.Forms.ComboBox
    Friend WithEvents lblPeriodoYEAR As System.Windows.Forms.Label
    Friend WithEvents lblAñoPeriodo As System.Windows.Forms.Label
    Friend WithEvents lblPeriodoMes As System.Windows.Forms.Label
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblSaldo As System.Windows.Forms.Label
    Friend WithEvents lblSignoPeso As System.Windows.Forms.Label
    Friend WithEvents lblSaldoCuenta As System.Windows.Forms.Label
End Class
