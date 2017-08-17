<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdministrarServicios
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdministrarServicios))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.dgvTipoServicio = New System.Windows.Forms.DataGridView()
        Me.lblAgregarTipoServicio = New System.Windows.Forms.Label()
        Me.txtDescripcionServicio = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lblProveedor = New System.Windows.Forms.Label()
        Me.lblVencimiento1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxProveedor = New System.Windows.Forms.ComboBox()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._S_BankDataSet1 = New S_Bank._S_BankDataSet1()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.dtpVencimiento1 = New System.Windows.Forms.DateTimePicker()
        Me.lblVencimiento2 = New System.Windows.Forms.Label()
        Me.dtpVencimiento2 = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.ProveedoresTableAdapter = New S_Bank._S_BankDataSet1TableAdapters.proveedoresTableAdapter()
        CType(Me.dgvTipoServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._S_BankDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(281, 20)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(201, 24)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Administrar Servicios"
        '
        'dgvTipoServicio
        '
        Me.dgvTipoServicio.AllowUserToAddRows = False
        Me.dgvTipoServicio.AllowUserToDeleteRows = False
        Me.dgvTipoServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTipoServicio.Location = New System.Drawing.Point(23, 74)
        Me.dgvTipoServicio.Name = "dgvTipoServicio"
        Me.dgvTipoServicio.ReadOnly = True
        Me.dgvTipoServicio.Size = New System.Drawing.Size(749, 150)
        Me.dgvTipoServicio.TabIndex = 1
        '
        'lblAgregarTipoServicio
        '
        Me.lblAgregarTipoServicio.AutoSize = True
        Me.lblAgregarTipoServicio.BackColor = System.Drawing.Color.Transparent
        Me.lblAgregarTipoServicio.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgregarTipoServicio.ForeColor = System.Drawing.Color.White
        Me.lblAgregarTipoServicio.Location = New System.Drawing.Point(13, 32)
        Me.lblAgregarTipoServicio.Name = "lblAgregarTipoServicio"
        Me.lblAgregarTipoServicio.Size = New System.Drawing.Size(203, 19)
        Me.lblAgregarTipoServicio.TabIndex = 2
        Me.lblAgregarTipoServicio.Text = "Descripcion  del nuevo Servicio:"
        '
        'txtDescripcionServicio
        '
        Me.txtDescripcionServicio.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionServicio.Location = New System.Drawing.Point(219, 28)
        Me.txtDescripcionServicio.Name = "txtDescripcionServicio"
        Me.txtDescripcionServicio.Size = New System.Drawing.Size(170, 25)
        Me.txtDescripcionServicio.TabIndex = 3
        '
        'btnAgregar
        '
        Me.btnAgregar.BackgroundImage = Global.S_Bank.My.Resources.Resources._3floppy_guardar_el_desmantelamiento_icono_4124_32__1_
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAgregar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(606, 137)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(113, 41)
        Me.btnAgregar.TabIndex = 4
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'lblProveedor
        '
        Me.lblProveedor.AutoSize = True
        Me.lblProveedor.BackColor = System.Drawing.Color.Transparent
        Me.lblProveedor.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProveedor.ForeColor = System.Drawing.Color.White
        Me.lblProveedor.Location = New System.Drawing.Point(425, 32)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(151, 19)
        Me.lblProveedor.TabIndex = 5
        Me.lblProveedor.Text = "Proveedor del Servicio:"
        '
        'lblVencimiento1
        '
        Me.lblVencimiento1.AutoSize = True
        Me.lblVencimiento1.BackColor = System.Drawing.Color.Transparent
        Me.lblVencimiento1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVencimiento1.ForeColor = System.Drawing.Color.Transparent
        Me.lblVencimiento1.Location = New System.Drawing.Point(13, 144)
        Me.lblVencimiento1.Name = "lblVencimiento1"
        Me.lblVencimiento1.Size = New System.Drawing.Size(97, 19)
        Me.lblVencimiento1.TabIndex = 7
        Me.lblVencimiento1.Text = "Vencimiento 1:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(13, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Monto ($):"
        '
        'cbxProveedor
        '
        Me.cbxProveedor.DataSource = Me.ProveedoresBindingSource
        Me.cbxProveedor.DisplayMember = "descripcion_proveedor"
        Me.cbxProveedor.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxProveedor.FormattingEnabled = True
        Me.cbxProveedor.Location = New System.Drawing.Point(594, 26)
        Me.cbxProveedor.Name = "cbxProveedor"
        Me.cbxProveedor.Size = New System.Drawing.Size(125, 27)
        Me.cbxProveedor.TabIndex = 9
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "proveedores"
        Me.ProveedoresBindingSource.DataSource = Me._S_BankDataSet1
        '
        '_S_BankDataSet1
        '
        Me._S_BankDataSet1.DataSetName = "_S_BankDataSet1"
        Me._S_BankDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtMonto
        '
        Me.txtMonto.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.Location = New System.Drawing.Point(133, 86)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(100, 26)
        Me.txtMonto.TabIndex = 10
        '
        'dtpVencimiento1
        '
        Me.dtpVencimiento1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpVencimiento1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVencimiento1.Location = New System.Drawing.Point(133, 137)
        Me.dtpVencimiento1.Name = "dtpVencimiento1"
        Me.dtpVencimiento1.Size = New System.Drawing.Size(100, 26)
        Me.dtpVencimiento1.TabIndex = 11
        '
        'lblVencimiento2
        '
        Me.lblVencimiento2.AutoSize = True
        Me.lblVencimiento2.BackColor = System.Drawing.Color.Transparent
        Me.lblVencimiento2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVencimiento2.ForeColor = System.Drawing.Color.White
        Me.lblVencimiento2.Location = New System.Drawing.Point(309, 144)
        Me.lblVencimiento2.Name = "lblVencimiento2"
        Me.lblVencimiento2.Size = New System.Drawing.Size(97, 19)
        Me.lblVencimiento2.TabIndex = 12
        Me.lblVencimiento2.Text = "Vencimiento 2:"
        '
        'dtpVencimiento2
        '
        Me.dtpVencimiento2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpVencimiento2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVencimiento2.Location = New System.Drawing.Point(429, 138)
        Me.dtpVencimiento2.Name = "dtpVencimiento2"
        Me.dtpVencimiento2.Size = New System.Drawing.Size(100, 26)
        Me.dtpVencimiento2.TabIndex = 13
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BackgroundImage = Global.S_Bank.My.Resources.Resources.images
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblAgregarTipoServicio)
        Me.Panel1.Controls.Add(Me.dtpVencimiento2)
        Me.Panel1.Controls.Add(Me.txtDescripcionServicio)
        Me.Panel1.Controls.Add(Me.btnAgregar)
        Me.Panel1.Controls.Add(Me.lblVencimiento2)
        Me.Panel1.Controls.Add(Me.lblProveedor)
        Me.Panel1.Controls.Add(Me.dtpVencimiento1)
        Me.Panel1.Controls.Add(Me.cbxProveedor)
        Me.Panel1.Controls.Add(Me.lblVencimiento1)
        Me.Panel1.Controls.Add(Me.txtMonto)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(23, 241)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(743, 188)
        Me.Panel1.TabIndex = 14
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Image = Global.S_Bank.My.Resources.Resources.preocupaciones_icono_8798_321
        Me.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtras.Location = New System.Drawing.Point(208, 447)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(89, 40)
        Me.btnAtras.TabIndex = 15
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.S_Bank.My.Resources.Resources.salir_de_gnome_icono_8179_48
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(489, 450)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(100, 35)
        Me.btnSalir.TabIndex = 16
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'frmAdministrarServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.BackgroundImage = Global.S_Bank.My.Resources.Resources.FondoAzul2
        Me.ClientSize = New System.Drawing.Size(806, 501)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvTipoServicio)
        Me.Controls.Add(Me.lblTitulo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAdministrarServicios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar Servicios"
        CType(Me.dgvTipoServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._S_BankDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents dgvTipoServicio As System.Windows.Forms.DataGridView
    Friend WithEvents lblAgregarTipoServicio As System.Windows.Forms.Label
    Friend WithEvents txtDescripcionServicio As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents lblProveedor As System.Windows.Forms.Label
    Friend WithEvents lblVencimiento1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbxProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents dtpVencimiento1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblVencimiento2 As System.Windows.Forms.Label
    Friend WithEvents dtpVencimiento2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents _S_BankDataSet As S_Bank._S_BankDataSet
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents _S_BankDataSet1 As S_Bank._S_BankDataSet1
    Friend WithEvents ProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresTableAdapter As S_Bank._S_BankDataSet1TableAdapters.proveedoresTableAdapter

End Class
