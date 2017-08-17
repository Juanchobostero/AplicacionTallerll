<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignarCuenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsignarCuenta))
        Me.lblAsignarCuenta = New System.Windows.Forms.Label()
        Me.lblIDcuenta = New System.Windows.Forms.Label()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.lblTipoCuenta = New System.Windows.Forms.Label()
        Me.lblNroIDUsuario = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.btnAsignar = New System.Windows.Forms.Button()
        Me.cbTipoCuenta = New System.Windows.Forms.ComboBox()
        Me.TipoCuentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me._S_BankDataSet2 = New S_Bank._S_BankDataSet2()
        Me.TipoCuentaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoCuentaTableAdapter = New S_Bank._S_BankDataSet2TableAdapters.tipoCuentaTableAdapter()
        CType(Me.TipoCuentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me._S_BankDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoCuentaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAsignarCuenta
        '
        Me.lblAsignarCuenta.AutoSize = True
        Me.lblAsignarCuenta.BackColor = System.Drawing.Color.Transparent
        Me.lblAsignarCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsignarCuenta.ForeColor = System.Drawing.Color.White
        Me.lblAsignarCuenta.Location = New System.Drawing.Point(70, 18)
        Me.lblAsignarCuenta.Name = "lblAsignarCuenta"
        Me.lblAsignarCuenta.Size = New System.Drawing.Size(181, 25)
        Me.lblAsignarCuenta.TabIndex = 0
        Me.lblAsignarCuenta.Text = "Asignar Cuenta "
        '
        'lblIDcuenta
        '
        Me.lblIDcuenta.AutoSize = True
        Me.lblIDcuenta.BackColor = System.Drawing.Color.Transparent
        Me.lblIDcuenta.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDcuenta.ForeColor = System.Drawing.Color.White
        Me.lblIDcuenta.Location = New System.Drawing.Point(12, 25)
        Me.lblIDcuenta.Name = "lblIDcuenta"
        Me.lblIDcuenta.Size = New System.Drawing.Size(102, 17)
        Me.lblIDcuenta.TabIndex = 1
        Me.lblIDcuenta.Text = "ID del Usuario: "
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.BackColor = System.Drawing.Color.Transparent
        Me.lblSaldo.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldo.ForeColor = System.Drawing.Color.White
        Me.lblSaldo.Location = New System.Drawing.Point(12, 74)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(93, 17)
        Me.lblSaldo.TabIndex = 2
        Me.lblSaldo.Text = "Asignar Saldo:"
        '
        'lblTipoCuenta
        '
        Me.lblTipoCuenta.AutoSize = True
        Me.lblTipoCuenta.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoCuenta.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoCuenta.ForeColor = System.Drawing.Color.White
        Me.lblTipoCuenta.Location = New System.Drawing.Point(12, 122)
        Me.lblTipoCuenta.Name = "lblTipoCuenta"
        Me.lblTipoCuenta.Size = New System.Drawing.Size(150, 17)
        Me.lblTipoCuenta.TabIndex = 3
        Me.lblTipoCuenta.Text = "Asignar Tipo de Cuenta:"
        '
        'lblNroIDUsuario
        '
        Me.lblNroIDUsuario.AutoSize = True
        Me.lblNroIDUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblNroIDUsuario.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroIDUsuario.ForeColor = System.Drawing.Color.Transparent
        Me.lblNroIDUsuario.Location = New System.Drawing.Point(176, 25)
        Me.lblNroIDUsuario.Name = "lblNroIDUsuario"
        Me.lblNroIDUsuario.Size = New System.Drawing.Size(74, 17)
        Me.lblNroIDUsuario.TabIndex = 6
        Me.lblNroIDUsuario.Text = "ID Usuairo"
        '
        'txtSaldo
        '
        Me.txtSaldo.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.Location = New System.Drawing.Point(179, 66)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(119, 25)
        Me.txtSaldo.TabIndex = 7
        '
        'btnAsignar
        '
        Me.btnAsignar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsignar.Image = Global.S_Bank.My.Resources.Resources._3floppy_guardar_el_desmantelamiento_icono_4124_32__1_
        Me.btnAsignar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAsignar.Location = New System.Drawing.Point(127, 277)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(101, 45)
        Me.btnAsignar.TabIndex = 10
        Me.btnAsignar.Text = "Asignar"
        Me.btnAsignar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAsignar.UseVisualStyleBackColor = True
        '
        'cbTipoCuenta
        '
        Me.cbTipoCuenta.DataSource = Me.TipoCuentaBindingSource1
        Me.cbTipoCuenta.DisplayMember = "descripcion_tipoCuenta"
        Me.cbTipoCuenta.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoCuenta.FormattingEnabled = True
        Me.cbTipoCuenta.Location = New System.Drawing.Point(179, 114)
        Me.cbTipoCuenta.Name = "cbTipoCuenta"
        Me.cbTipoCuenta.Size = New System.Drawing.Size(119, 25)
        Me.cbTipoCuenta.TabIndex = 11
        '
        'TipoCuentaBindingSource
        '
        Me.TipoCuentaBindingSource.DataMember = "tipoCuenta"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BackgroundImage = Global.S_Bank.My.Resources.Resources.images
        Me.Panel1.Controls.Add(Me.lblIDcuenta)
        Me.Panel1.Controls.Add(Me.cbTipoCuenta)
        Me.Panel1.Controls.Add(Me.lblNroIDUsuario)
        Me.Panel1.Controls.Add(Me.txtSaldo)
        Me.Panel1.Controls.Add(Me.lblTipoCuenta)
        Me.Panel1.Controls.Add(Me.lblSaldo)
        Me.Panel1.Location = New System.Drawing.Point(24, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(308, 187)
        Me.Panel1.TabIndex = 12
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Image = Global.S_Bank.My.Resources.Resources.preocupaciones_icono_8798_321
        Me.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtras.Location = New System.Drawing.Point(27, 282)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(89, 40)
        Me.btnAtras.TabIndex = 16
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.S_Bank.My.Resources.Resources.salir_de_gnome_icono_8179_48
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(234, 287)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(100, 35)
        Me.btnSalir.TabIndex = 17
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        '_S_BankDataSet2
        '
        Me._S_BankDataSet2.DataSetName = "_S_BankDataSet2"
        Me._S_BankDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TipoCuentaBindingSource1
        '
        Me.TipoCuentaBindingSource1.DataMember = "tipoCuenta"
        Me.TipoCuentaBindingSource1.DataSource = Me._S_BankDataSet2
        '
        'TipoCuentaTableAdapter
        '
        Me.TipoCuentaTableAdapter.ClearBeforeFill = True
        '
        'frmAsignarCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.BackgroundImage = Global.S_Bank.My.Resources.Resources.FondoAzul2
        Me.ClientSize = New System.Drawing.Size(346, 334)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnAsignar)
        Me.Controls.Add(Me.lblAsignarCuenta)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAsignarCuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignar Cuenta"
        CType(Me.TipoCuentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me._S_BankDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoCuentaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAsignarCuenta As System.Windows.Forms.Label
    Friend WithEvents lblIDcuenta As System.Windows.Forms.Label
    Friend WithEvents lblSaldo As System.Windows.Forms.Label
    Friend WithEvents lblTipoCuenta As System.Windows.Forms.Label
    Friend WithEvents lblNroIDUsuario As System.Windows.Forms.Label
    Friend WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents btnAsignar As System.Windows.Forms.Button
    Friend WithEvents cbTipoCuenta As System.Windows.Forms.ComboBox


    Friend WithEvents Panel1 As System.Windows.Forms.Panel


    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button

    Friend WithEvents TipoCuentaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents _S_BankDataSet2 As S_Bank._S_BankDataSet2
    Friend WithEvents TipoCuentaBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TipoCuentaTableAdapter As S_Bank._S_BankDataSet2TableAdapters.tipoCuentaTableAdapter


End Class
