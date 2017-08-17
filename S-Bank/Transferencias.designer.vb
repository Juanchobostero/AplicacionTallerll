<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransferencias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransferencias))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblTipoTransferencia = New System.Windows.Forms.Label()
        Me.cbxTipoTransferencia = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblSaldo1 = New System.Windows.Forms.Label()
        Me.lblSaldo2 = New System.Windows.Forms.Label()
        Me.lblSignoPeso3 = New System.Windows.Forms.Label()
        Me.lblSignoPeso4 = New System.Windows.Forms.Label()
        Me.lblSaldoCuentaDestino = New System.Windows.Forms.Label()
        Me.lblSaldoCuentaOrigen = New System.Windows.Forms.Label()
        Me.btnTransferir = New System.Windows.Forms.Button()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.lblSignoPeso = New System.Windows.Forms.Label()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.cbxCuentasDestino = New System.Windows.Forms.ComboBox()
        Me.cbxCuentasOrigen = New System.Windows.Forms.ComboBox()
        Me.lblAsiMismo = New System.Windows.Forms.Label()
        Me.lblCuentaDestino = New System.Windows.Forms.Label()
        Me.lblCuentaOrigen = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblSaldo4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbltitular = New System.Windows.Forms.Label()
        Me.lblTitularCtaOrigen = New System.Windows.Forms.Label()
        Me.btnTransferir2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMonto2 = New System.Windows.Forms.TextBox()
        Me.lblMonto2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblSaldo3 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSaldoCta = New System.Windows.Forms.Label()
        Me.cbxCtasDestinoAsociadas = New System.Windows.Forms.ComboBox()
        Me.lblTitularCtaDestino = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxUsuarios = New System.Windows.Forms.ComboBox()
        Me.cbxCtaOrigen = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCtaOrigen = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblNomUsuario = New System.Windows.Forms.Label()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.lblapeYnom = New System.Windows.Forms.Label()
        Me.lblApellidoyNombre = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dtpFechaTransferencia = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaTransferencia = New System.Windows.Forms.Label()
        Me.lbltipoMovimiento = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.btnVerTransfer = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Black
        Me.lblTitulo.Location = New System.Drawing.Point(265, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(282, 31)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Realizar Transferencia"
        '
        'lblTipoTransferencia
        '
        Me.lblTipoTransferencia.AutoSize = True
        Me.lblTipoTransferencia.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoTransferencia.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoTransferencia.ForeColor = System.Drawing.Color.White
        Me.lblTipoTransferencia.Location = New System.Drawing.Point(3, 41)
        Me.lblTipoTransferencia.Name = "lblTipoTransferencia"
        Me.lblTipoTransferencia.Size = New System.Drawing.Size(337, 19)
        Me.lblTipoTransferencia.TabIndex = 1
        Me.lblTipoTransferencia.Text = "Seleccione el Tipo de Transferencia que desea realizar:"
        '
        'cbxTipoTransferencia
        '
        Me.cbxTipoTransferencia.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTipoTransferencia.FormattingEnabled = True
        Me.cbxTipoTransferencia.Items.AddRange(New Object() {"A una cuenta propia", "A tercero"})
        Me.cbxTipoTransferencia.Location = New System.Drawing.Point(352, 38)
        Me.cbxTipoTransferencia.Name = "cbxTipoTransferencia"
        Me.cbxTipoTransferencia.Size = New System.Drawing.Size(154, 27)
        Me.cbxTipoTransferencia.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblSaldo1)
        Me.Panel1.Controls.Add(Me.lblSaldo2)
        Me.Panel1.Controls.Add(Me.lblSignoPeso3)
        Me.Panel1.Controls.Add(Me.lblSignoPeso4)
        Me.Panel1.Controls.Add(Me.lblSaldoCuentaDestino)
        Me.Panel1.Controls.Add(Me.lblSaldoCuentaOrigen)
        Me.Panel1.Controls.Add(Me.btnTransferir)
        Me.Panel1.Controls.Add(Me.txtMonto)
        Me.Panel1.Controls.Add(Me.lblSignoPeso)
        Me.Panel1.Controls.Add(Me.lblMonto)
        Me.Panel1.Controls.Add(Me.cbxCuentasDestino)
        Me.Panel1.Controls.Add(Me.cbxCuentasOrigen)
        Me.Panel1.Controls.Add(Me.lblAsiMismo)
        Me.Panel1.Controls.Add(Me.lblCuentaDestino)
        Me.Panel1.Controls.Add(Me.lblCuentaOrigen)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 271)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(369, 229)
        Me.Panel1.TabIndex = 3
        '
        'lblSaldo1
        '
        Me.lblSaldo1.AutoSize = True
        Me.lblSaldo1.BackColor = System.Drawing.Color.Transparent
        Me.lblSaldo1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldo1.ForeColor = System.Drawing.Color.Red
        Me.lblSaldo1.Location = New System.Drawing.Point(312, 61)
        Me.lblSaldo1.Name = "lblSaldo1"
        Me.lblSaldo1.Size = New System.Drawing.Size(52, 19)
        Me.lblSaldo1.TabIndex = 15
        Me.lblSaldo1.Text = "saldo1"
        '
        'lblSaldo2
        '
        Me.lblSaldo2.AutoSize = True
        Me.lblSaldo2.BackColor = System.Drawing.Color.Transparent
        Me.lblSaldo2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldo2.ForeColor = System.Drawing.Color.Red
        Me.lblSaldo2.Location = New System.Drawing.Point(313, 98)
        Me.lblSaldo2.Name = "lblSaldo2"
        Me.lblSaldo2.Size = New System.Drawing.Size(52, 19)
        Me.lblSaldo2.TabIndex = 14
        Me.lblSaldo2.Text = "saldo2"
        '
        'lblSignoPeso3
        '
        Me.lblSignoPeso3.AutoSize = True
        Me.lblSignoPeso3.BackColor = System.Drawing.Color.Transparent
        Me.lblSignoPeso3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignoPeso3.ForeColor = System.Drawing.Color.Red
        Me.lblSignoPeso3.Location = New System.Drawing.Point(297, 61)
        Me.lblSignoPeso3.Name = "lblSignoPeso3"
        Me.lblSignoPeso3.Size = New System.Drawing.Size(17, 19)
        Me.lblSignoPeso3.TabIndex = 13
        Me.lblSignoPeso3.Text = "$"
        '
        'lblSignoPeso4
        '
        Me.lblSignoPeso4.AutoSize = True
        Me.lblSignoPeso4.BackColor = System.Drawing.Color.Transparent
        Me.lblSignoPeso4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignoPeso4.ForeColor = System.Drawing.Color.Red
        Me.lblSignoPeso4.Location = New System.Drawing.Point(297, 98)
        Me.lblSignoPeso4.Name = "lblSignoPeso4"
        Me.lblSignoPeso4.Size = New System.Drawing.Size(17, 19)
        Me.lblSignoPeso4.TabIndex = 12
        Me.lblSignoPeso4.Text = "$"
        '
        'lblSaldoCuentaDestino
        '
        Me.lblSaldoCuentaDestino.AutoSize = True
        Me.lblSaldoCuentaDestino.BackColor = System.Drawing.Color.Transparent
        Me.lblSaldoCuentaDestino.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoCuentaDestino.ForeColor = System.Drawing.Color.White
        Me.lblSaldoCuentaDestino.Location = New System.Drawing.Point(246, 98)
        Me.lblSaldoCuentaDestino.Name = "lblSaldoCuentaDestino"
        Me.lblSaldoCuentaDestino.Size = New System.Drawing.Size(47, 19)
        Me.lblSaldoCuentaDestino.TabIndex = 11
        Me.lblSaldoCuentaDestino.Text = "Saldo:"
        '
        'lblSaldoCuentaOrigen
        '
        Me.lblSaldoCuentaOrigen.AutoSize = True
        Me.lblSaldoCuentaOrigen.BackColor = System.Drawing.Color.Transparent
        Me.lblSaldoCuentaOrigen.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoCuentaOrigen.ForeColor = System.Drawing.Color.White
        Me.lblSaldoCuentaOrigen.Location = New System.Drawing.Point(246, 61)
        Me.lblSaldoCuentaOrigen.Name = "lblSaldoCuentaOrigen"
        Me.lblSaldoCuentaOrigen.Size = New System.Drawing.Size(47, 19)
        Me.lblSaldoCuentaOrigen.TabIndex = 10
        Me.lblSaldoCuentaOrigen.Text = "Saldo:"
        '
        'btnTransferir
        '
        Me.btnTransferir.BackColor = System.Drawing.SystemColors.Control
        Me.btnTransferir.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransferir.ForeColor = System.Drawing.Color.Black
        Me.btnTransferir.Image = CType(resources.GetObject("btnTransferir.Image"), System.Drawing.Image)
        Me.btnTransferir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransferir.Location = New System.Drawing.Point(124, 179)
        Me.btnTransferir.Name = "btnTransferir"
        Me.btnTransferir.Size = New System.Drawing.Size(106, 38)
        Me.btnTransferir.TabIndex = 9
        Me.btnTransferir.Text = "Transferir"
        Me.btnTransferir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTransferir.UseVisualStyleBackColor = False
        '
        'txtMonto
        '
        Me.txtMonto.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.Location = New System.Drawing.Point(119, 136)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(121, 26)
        Me.txtMonto.TabIndex = 7
        '
        'lblSignoPeso
        '
        Me.lblSignoPeso.AutoSize = True
        Me.lblSignoPeso.BackColor = System.Drawing.Color.Transparent
        Me.lblSignoPeso.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignoPeso.ForeColor = System.Drawing.Color.White
        Me.lblSignoPeso.Location = New System.Drawing.Point(96, 139)
        Me.lblSignoPeso.Name = "lblSignoPeso"
        Me.lblSignoPeso.Size = New System.Drawing.Size(17, 19)
        Me.lblSignoPeso.TabIndex = 8
        Me.lblSignoPeso.Text = "$"
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.BackColor = System.Drawing.Color.Transparent
        Me.lblMonto.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.ForeColor = System.Drawing.Color.White
        Me.lblMonto.Location = New System.Drawing.Point(13, 139)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(53, 19)
        Me.lblMonto.TabIndex = 6
        Me.lblMonto.Text = "Monto:"
        '
        'cbxCuentasDestino
        '
        Me.cbxCuentasDestino.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCuentasDestino.FormattingEnabled = True
        Me.cbxCuentasDestino.Location = New System.Drawing.Point(119, 95)
        Me.cbxCuentasDestino.Name = "cbxCuentasDestino"
        Me.cbxCuentasDestino.Size = New System.Drawing.Size(121, 27)
        Me.cbxCuentasDestino.TabIndex = 5
        '
        'cbxCuentasOrigen
        '
        Me.cbxCuentasOrigen.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCuentasOrigen.FormattingEnabled = True
        Me.cbxCuentasOrigen.Location = New System.Drawing.Point(119, 58)
        Me.cbxCuentasOrigen.Name = "cbxCuentasOrigen"
        Me.cbxCuentasOrigen.Size = New System.Drawing.Size(121, 27)
        Me.cbxCuentasOrigen.TabIndex = 4
        '
        'lblAsiMismo
        '
        Me.lblAsiMismo.AutoSize = True
        Me.lblAsiMismo.BackColor = System.Drawing.Color.Transparent
        Me.lblAsiMismo.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsiMismo.ForeColor = System.Drawing.Color.White
        Me.lblAsiMismo.Location = New System.Drawing.Point(96, 13)
        Me.lblAsiMismo.Name = "lblAsiMismo"
        Me.lblAsiMismo.Size = New System.Drawing.Size(174, 22)
        Me.lblAsiMismo.TabIndex = 2
        Me.lblAsiMismo.Text = "A una cuenta propia"
        '
        'lblCuentaDestino
        '
        Me.lblCuentaDestino.AutoSize = True
        Me.lblCuentaDestino.BackColor = System.Drawing.Color.Transparent
        Me.lblCuentaDestino.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuentaDestino.ForeColor = System.Drawing.Color.White
        Me.lblCuentaDestino.Location = New System.Drawing.Point(13, 98)
        Me.lblCuentaDestino.Name = "lblCuentaDestino"
        Me.lblCuentaDestino.Size = New System.Drawing.Size(102, 19)
        Me.lblCuentaDestino.TabIndex = 1
        Me.lblCuentaDestino.Text = "Cuenta destino:"
        '
        'lblCuentaOrigen
        '
        Me.lblCuentaOrigen.AutoSize = True
        Me.lblCuentaOrigen.BackColor = System.Drawing.Color.Transparent
        Me.lblCuentaOrigen.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuentaOrigen.ForeColor = System.Drawing.Color.White
        Me.lblCuentaOrigen.Location = New System.Drawing.Point(13, 61)
        Me.lblCuentaOrigen.Name = "lblCuentaOrigen"
        Me.lblCuentaOrigen.Size = New System.Drawing.Size(100, 19)
        Me.lblCuentaOrigen.TabIndex = 0
        Me.lblCuentaOrigen.Text = "Cuenta Origen:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.lblSaldo4)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.lbltitular)
        Me.Panel2.Controls.Add(Me.lblTitularCtaOrigen)
        Me.Panel2.Controls.Add(Me.btnTransferir2)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtMonto2)
        Me.Panel2.Controls.Add(Me.lblMonto2)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.cbxCtaOrigen)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lblCtaOrigen)
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(401, 271)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(375, 374)
        Me.Panel2.TabIndex = 4
        '
        'lblSaldo4
        '
        Me.lblSaldo4.AutoSize = True
        Me.lblSaldo4.BackColor = System.Drawing.Color.Transparent
        Me.lblSaldo4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldo4.ForeColor = System.Drawing.Color.Red
        Me.lblSaldo4.Location = New System.Drawing.Point(312, 82)
        Me.lblSaldo4.Name = "lblSaldo4"
        Me.lblSaldo4.Size = New System.Drawing.Size(52, 19)
        Me.lblSaldo4.TabIndex = 17
        Me.lblSaldo4.Text = "saldo4"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(289, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 19)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "$"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(245, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 19)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Saldo:"
        '
        'lbltitular
        '
        Me.lbltitular.AutoSize = True
        Me.lbltitular.BackColor = System.Drawing.Color.Transparent
        Me.lbltitular.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitular.ForeColor = System.Drawing.Color.Red
        Me.lbltitular.Location = New System.Drawing.Point(161, 47)
        Me.lbltitular.Name = "lbltitular"
        Me.lbltitular.Size = New System.Drawing.Size(47, 17)
        Me.lbltitular.TabIndex = 6
        Me.lbltitular.Text = "titular"
        '
        'lblTitularCtaOrigen
        '
        Me.lblTitularCtaOrigen.AutoSize = True
        Me.lblTitularCtaOrigen.BackColor = System.Drawing.Color.Transparent
        Me.lblTitularCtaOrigen.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitularCtaOrigen.Location = New System.Drawing.Point(12, 46)
        Me.lblTitularCtaOrigen.Name = "lblTitularCtaOrigen"
        Me.lblTitularCtaOrigen.Size = New System.Drawing.Size(141, 19)
        Me.lblTitularCtaOrigen.TabIndex = 14
        Me.lblTitularCtaOrigen.Text = "Titular Cuenta Origen:"
        '
        'btnTransferir2
        '
        Me.btnTransferir2.BackColor = System.Drawing.SystemColors.Control
        Me.btnTransferir2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransferir2.ForeColor = System.Drawing.Color.Black
        Me.btnTransferir2.Image = CType(resources.GetObject("btnTransferir2.Image"), System.Drawing.Image)
        Me.btnTransferir2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransferir2.Location = New System.Drawing.Point(135, 316)
        Me.btnTransferir2.Name = "btnTransferir2"
        Me.btnTransferir2.Size = New System.Drawing.Size(103, 41)
        Me.btnTransferir2.TabIndex = 10
        Me.btnTransferir2.Text = "Transferir"
        Me.btnTransferir2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTransferir2.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(95, 278)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "$"
        '
        'txtMonto2
        '
        Me.txtMonto2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto2.Location = New System.Drawing.Point(118, 275)
        Me.txtMonto2.Name = "txtMonto2"
        Me.txtMonto2.Size = New System.Drawing.Size(121, 26)
        Me.txtMonto2.TabIndex = 10
        '
        'lblMonto2
        '
        Me.lblMonto2.AutoSize = True
        Me.lblMonto2.BackColor = System.Drawing.Color.Transparent
        Me.lblMonto2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto2.ForeColor = System.Drawing.Color.White
        Me.lblMonto2.Location = New System.Drawing.Point(24, 278)
        Me.lblMonto2.Name = "lblMonto2"
        Me.lblMonto2.Size = New System.Drawing.Size(53, 19)
        Me.lblMonto2.TabIndex = 10
        Me.lblMonto2.Text = "Monto:"
        '
        'Panel5
        '
        Me.Panel5.BackgroundImage = Global.S_Bank.My.Resources.Resources.images
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.lblSaldo3)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.lblSaldoCta)
        Me.Panel5.Controls.Add(Me.cbxCtasDestinoAsociadas)
        Me.Panel5.Controls.Add(Me.lblTitularCtaDestino)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.cbxUsuarios)
        Me.Panel5.Location = New System.Drawing.Point(28, 121)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(319, 135)
        Me.Panel5.TabIndex = 13
        '
        'lblSaldo3
        '
        Me.lblSaldo3.AutoSize = True
        Me.lblSaldo3.BackColor = System.Drawing.Color.Transparent
        Me.lblSaldo3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldo3.ForeColor = System.Drawing.Color.Red
        Me.lblSaldo3.Location = New System.Drawing.Point(165, 99)
        Me.lblSaldo3.Name = "lblSaldo3"
        Me.lblSaldo3.Size = New System.Drawing.Size(52, 19)
        Me.lblSaldo3.TabIndex = 16
        Me.lblSaldo3.Text = "saldo3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(142, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 19)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "$"
        '
        'lblSaldoCta
        '
        Me.lblSaldoCta.AutoSize = True
        Me.lblSaldoCta.BackColor = System.Drawing.Color.Transparent
        Me.lblSaldoCta.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoCta.ForeColor = System.Drawing.Color.White
        Me.lblSaldoCta.Location = New System.Drawing.Point(88, 99)
        Me.lblSaldoCta.Name = "lblSaldoCta"
        Me.lblSaldoCta.Size = New System.Drawing.Size(47, 19)
        Me.lblSaldoCta.TabIndex = 16
        Me.lblSaldoCta.Text = "Saldo:"
        '
        'cbxCtasDestinoAsociadas
        '
        Me.cbxCtasDestinoAsociadas.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCtasDestinoAsociadas.FormattingEnabled = True
        Me.cbxCtasDestinoAsociadas.Location = New System.Drawing.Point(187, 56)
        Me.cbxCtasDestinoAsociadas.Name = "cbxCtasDestinoAsociadas"
        Me.cbxCtasDestinoAsociadas.Size = New System.Drawing.Size(121, 27)
        Me.cbxCtasDestinoAsociadas.TabIndex = 12
        '
        'lblTitularCtaDestino
        '
        Me.lblTitularCtaDestino.AutoSize = True
        Me.lblTitularCtaDestino.BackColor = System.Drawing.Color.Transparent
        Me.lblTitularCtaDestino.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitularCtaDestino.ForeColor = System.Drawing.Color.White
        Me.lblTitularCtaDestino.Location = New System.Drawing.Point(2, 15)
        Me.lblTitularCtaDestino.Name = "lblTitularCtaDestino"
        Me.lblTitularCtaDestino.Size = New System.Drawing.Size(179, 19)
        Me.lblTitularCtaDestino.TabIndex = 1
        Me.lblTitularCtaDestino.Text = "Titular de la Cuenta Destino:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 19)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Cuentas Destinos Asociadas:"
        '
        'cbxUsuarios
        '
        Me.cbxUsuarios.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxUsuarios.FormattingEnabled = True
        Me.cbxUsuarios.Location = New System.Drawing.Point(187, 11)
        Me.cbxUsuarios.Name = "cbxUsuarios"
        Me.cbxUsuarios.Size = New System.Drawing.Size(121, 27)
        Me.cbxUsuarios.TabIndex = 10
        '
        'cbxCtaOrigen
        '
        Me.cbxCtaOrigen.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCtaOrigen.FormattingEnabled = True
        Me.cbxCtaOrigen.Location = New System.Drawing.Point(118, 79)
        Me.cbxCtaOrigen.Name = "cbxCtaOrigen"
        Me.cbxCtaOrigen.Size = New System.Drawing.Size(121, 27)
        Me.cbxCtaOrigen.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(148, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "A Tercero"
        '
        'lblCtaOrigen
        '
        Me.lblCtaOrigen.AutoSize = True
        Me.lblCtaOrigen.BackColor = System.Drawing.Color.Transparent
        Me.lblCtaOrigen.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCtaOrigen.Location = New System.Drawing.Point(12, 82)
        Me.lblCtaOrigen.Name = "lblCtaOrigen"
        Me.lblCtaOrigen.Size = New System.Drawing.Size(100, 19)
        Me.lblCtaOrigen.TabIndex = 0
        Me.lblCtaOrigen.Text = "Cuenta Origen:"
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.ForeColor = System.Drawing.Color.Black
        Me.btnAtras.Image = Global.S_Bank.My.Resources.Resources.preocupaciones_icono_8798_321
        Me.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtras.Location = New System.Drawing.Point(97, 609)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(80, 36)
        Me.btnAtras.TabIndex = 27
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = Global.S_Bank.My.Resources.Resources.salir_de_gnome_icono_8179_48
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(183, 610)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(90, 36)
        Me.btnSalir.TabIndex = 28
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.lblNomUsuario)
        Me.Panel3.Controls.Add(Me.lblNombreUsuario)
        Me.Panel3.Controls.Add(Me.lblapeYnom)
        Me.Panel3.Controls.Add(Me.lblApellidoyNombre)
        Me.Panel3.Location = New System.Drawing.Point(271, 56)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(259, 74)
        Me.Panel3.TabIndex = 31
        '
        'lblNomUsuario
        '
        Me.lblNomUsuario.AutoSize = True
        Me.lblNomUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblNomUsuario.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomUsuario.ForeColor = System.Drawing.Color.Red
        Me.lblNomUsuario.Location = New System.Drawing.Point(138, 36)
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
        Me.lblNombreUsuario.Location = New System.Drawing.Point(3, 37)
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
        Me.lblapeYnom.Location = New System.Drawing.Point(138, 6)
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
        Me.lblApellidoyNombre.Location = New System.Drawing.Point(3, 7)
        Me.lblApellidoyNombre.Name = "lblApellidoyNombre"
        Me.lblApellidoyNombre.Size = New System.Drawing.Size(122, 17)
        Me.lblApellidoyNombre.TabIndex = 0
        Me.lblApellidoyNombre.Text = "Apellido y Nombre:"
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = Global.S_Bank.My.Resources.Resources.imagesdfs
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.dtpFechaTransferencia)
        Me.Panel4.Controls.Add(Me.lblFechaTransferencia)
        Me.Panel4.Controls.Add(Me.lbltipoMovimiento)
        Me.Panel4.Controls.Add(Me.lblTipoTransferencia)
        Me.Panel4.Controls.Add(Me.cbxTipoTransferencia)
        Me.Panel4.Controls.Add(Me.lblDescripcion)
        Me.Panel4.Location = New System.Drawing.Point(133, 136)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(527, 111)
        Me.Panel4.TabIndex = 6
        '
        'dtpFechaTransferencia
        '
        Me.dtpFechaTransferencia.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaTransferencia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaTransferencia.Location = New System.Drawing.Point(177, 71)
        Me.dtpFechaTransferencia.Name = "dtpFechaTransferencia"
        Me.dtpFechaTransferencia.Size = New System.Drawing.Size(100, 26)
        Me.dtpFechaTransferencia.TabIndex = 22
        '
        'lblFechaTransferencia
        '
        Me.lblFechaTransferencia.AutoSize = True
        Me.lblFechaTransferencia.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaTransferencia.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaTransferencia.ForeColor = System.Drawing.Color.White
        Me.lblFechaTransferencia.Location = New System.Drawing.Point(3, 77)
        Me.lblFechaTransferencia.Name = "lblFechaTransferencia"
        Me.lblFechaTransferencia.Size = New System.Drawing.Size(166, 19)
        Me.lblFechaTransferencia.TabIndex = 5
        Me.lblFechaTransferencia.Text = "Fecha de la Transferencia:"
        '
        'lbltipoMovimiento
        '
        Me.lbltipoMovimiento.AutoSize = True
        Me.lbltipoMovimiento.BackColor = System.Drawing.Color.Transparent
        Me.lbltipoMovimiento.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipoMovimiento.ForeColor = System.Drawing.Color.Red
        Me.lbltipoMovimiento.Location = New System.Drawing.Point(191, 10)
        Me.lbltipoMovimiento.Name = "lbltipoMovimiento"
        Me.lbltipoMovimiento.Size = New System.Drawing.Size(115, 19)
        Me.lbltipoMovimiento.TabIndex = 4
        Me.lbltipoMovimiento.Text = "tipoMovimiento"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.lblDescripcion.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.ForeColor = System.Drawing.Color.White
        Me.lblDescripcion.Location = New System.Drawing.Point(3, 10)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(182, 19)
        Me.lblDescripcion.TabIndex = 3
        Me.lblDescripcion.Text = "Descripcion del Movimiento:"
        '
        'btnVerTransfer
        '
        Me.btnVerTransfer.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerTransfer.ForeColor = System.Drawing.Color.Black
        Me.btnVerTransfer.Image = Global.S_Bank.My.Resources.Resources._3D_Search_32
        Me.btnVerTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerTransfer.Location = New System.Drawing.Point(133, 537)
        Me.btnVerTransfer.Name = "btnVerTransfer"
        Me.btnVerTransfer.Size = New System.Drawing.Size(132, 48)
        Me.btnVerTransfer.TabIndex = 32
        Me.btnVerTransfer.Text = "Ver Transfers"
        Me.btnVerTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVerTransfer.UseVisualStyleBackColor = True
        '
        'frmTransferencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.S_Bank.My.Resources.Resources.tabla_de_madera_1280x800
        Me.ClientSize = New System.Drawing.Size(788, 658)
        Me.Controls.Add(Me.btnVerTransfer)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblTitulo)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmTransferencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transferencias"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblTipoTransferencia As System.Windows.Forms.Label
    Friend WithEvents cbxTipoTransferencia As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cbxCuentasDestino As System.Windows.Forms.ComboBox
    Friend WithEvents cbxCuentasOrigen As System.Windows.Forms.ComboBox
    Friend WithEvents lblAsiMismo As System.Windows.Forms.Label
    Friend WithEvents lblCuentaDestino As System.Windows.Forms.Label
    Friend WithEvents lblCuentaOrigen As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTitularCtaDestino As System.Windows.Forms.Label
    Friend WithEvents lblCtaOrigen As System.Windows.Forms.Label
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblNomUsuario As System.Windows.Forms.Label
    Friend WithEvents lblNombreUsuario As System.Windows.Forms.Label
    Friend WithEvents lblapeYnom As System.Windows.Forms.Label
    Friend WithEvents lblApellidoyNombre As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnTransferir As System.Windows.Forms.Button
    Friend WithEvents lblSignoPeso As System.Windows.Forms.Label
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents lbltipoMovimiento As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblFechaTransferencia As System.Windows.Forms.Label
    Friend WithEvents dtpFechaTransferencia As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbxCtaOrigen As System.Windows.Forms.ComboBox
    Friend WithEvents cbxUsuarios As System.Windows.Forms.ComboBox
    Friend WithEvents btnTransferir2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMonto2 As System.Windows.Forms.TextBox
    Friend WithEvents lblMonto2 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents cbxCtasDestinoAsociadas As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbltitular As System.Windows.Forms.Label
    Friend WithEvents lblTitularCtaOrigen As System.Windows.Forms.Label
    Friend WithEvents lblSaldo1 As System.Windows.Forms.Label
    Friend WithEvents lblSaldo2 As System.Windows.Forms.Label
    Friend WithEvents lblSignoPeso3 As System.Windows.Forms.Label
    Friend WithEvents lblSignoPeso4 As System.Windows.Forms.Label
    Friend WithEvents lblSaldoCuentaDestino As System.Windows.Forms.Label
    Friend WithEvents lblSaldoCuentaOrigen As System.Windows.Forms.Label
    Friend WithEvents lblSaldo3 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblSaldoCta As System.Windows.Forms.Label
    Friend WithEvents btnVerTransfer As System.Windows.Forms.Button
    Friend WithEvents lblSaldo4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
