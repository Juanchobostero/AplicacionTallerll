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
        Me.components = New System.ComponentModel.Container()
        Me.lblAsignar = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbTipoDeCuenta = New System.Windows.Forms.ComboBox()
        Me.TipoCuentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtSaldoCuenta = New System.Windows.Forms.TextBox()
        Me.lblTipoCuenta = New System.Windows.Forms.Label()
        Me.lblSaldoCuenta = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnAsignar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me._S_BankDataSet2 = New S_Bank._S_BankDataSet2()
        Me.TipoCuentaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoCuentaTableAdapter = New S_Bank._S_BankDataSet2TableAdapters.tipoCuentaTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.TipoCuentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._S_BankDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoCuentaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAsignar
        '
        Me.lblAsignar.AutoSize = True
        Me.lblAsignar.BackColor = System.Drawing.Color.Transparent
        Me.lblAsignar.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsignar.ForeColor = System.Drawing.Color.White
        Me.lblAsignar.Location = New System.Drawing.Point(98, 34)
        Me.lblAsignar.Name = "lblAsignar"
        Me.lblAsignar.Size = New System.Drawing.Size(198, 31)
        Me.lblAsignar.TabIndex = 0
        Me.lblAsignar.Text = "Asignar Cuenta"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.S_Bank.My.Resources.Resources.images
        Me.Panel1.Controls.Add(Me.cbTipoDeCuenta)
        Me.Panel1.Controls.Add(Me.txtSaldoCuenta)
        Me.Panel1.Controls.Add(Me.lblTipoCuenta)
        Me.Panel1.Controls.Add(Me.lblSaldoCuenta)
        Me.Panel1.Controls.Add(Me.lblID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 95)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(370, 171)
        Me.Panel1.TabIndex = 1
        '
        'cbTipoDeCuenta
        '
        Me.cbTipoDeCuenta.DataSource = Me.TipoCuentaBindingSource1
        Me.cbTipoDeCuenta.DisplayMember = "descripcion_tipoCuenta"
        Me.cbTipoDeCuenta.FormattingEnabled = True
        Me.cbTipoDeCuenta.Location = New System.Drawing.Point(141, 125)
        Me.cbTipoDeCuenta.Name = "cbTipoDeCuenta"
        Me.cbTipoDeCuenta.Size = New System.Drawing.Size(111, 21)
        Me.cbTipoDeCuenta.TabIndex = 5
        '
        'TipoCuentaBindingSource
        '
        Me.TipoCuentaBindingSource.DataMember = "tipoCuenta"
        '
        'txtSaldoCuenta
        '
        Me.txtSaldoCuenta.Location = New System.Drawing.Point(137, 82)
        Me.txtSaldoCuenta.Name = "txtSaldoCuenta"
        Me.txtSaldoCuenta.Size = New System.Drawing.Size(115, 20)
        Me.txtSaldoCuenta.TabIndex = 4
        '
        'lblTipoCuenta
        '
        Me.lblTipoCuenta.AutoSize = True
        Me.lblTipoCuenta.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoCuenta.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoCuenta.ForeColor = System.Drawing.Color.White
        Me.lblTipoCuenta.Location = New System.Drawing.Point(48, 128)
        Me.lblTipoCuenta.Name = "lblTipoCuenta"
        Me.lblTipoCuenta.Size = New System.Drawing.Size(86, 19)
        Me.lblTipoCuenta.TabIndex = 3
        Me.lblTipoCuenta.Text = "Tipo Cuenta:"
        '
        'lblSaldoCuenta
        '
        Me.lblSaldoCuenta.AutoSize = True
        Me.lblSaldoCuenta.BackColor = System.Drawing.Color.Transparent
        Me.lblSaldoCuenta.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoCuenta.ForeColor = System.Drawing.Color.White
        Me.lblSaldoCuenta.Location = New System.Drawing.Point(49, 83)
        Me.lblSaldoCuenta.Name = "lblSaldoCuenta"
        Me.lblSaldoCuenta.Size = New System.Drawing.Size(47, 19)
        Me.lblSaldoCuenta.TabIndex = 2
        Me.lblSaldoCuenta.Text = "Saldo:"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.Transparent
        Me.lblID.ForeColor = System.Drawing.Color.Red
        Me.lblID.Location = New System.Drawing.Point(177, 40)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(64, 13)
        Me.lblID.TabIndex = 1
        Me.lblID.Text = "lblIDUsuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(48, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID usuario:"
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Image = Global.S_Bank.My.Resources.Resources.preocupaciones_icono_8798_32
        Me.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtras.Location = New System.Drawing.Point(12, 289)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(96, 35)
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
        Me.btnAsignar.Location = New System.Drawing.Point(149, 272)
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
        Me.btnSalir.Location = New System.Drawing.Point(289, 289)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(96, 35)
        Me.btnSalir.TabIndex = 4
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
        'frmAsignarOtraCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.S_Bank.My.Resources.Resources.FondoAzul2
        Me.ClientSize = New System.Drawing.Size(394, 336)
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
        CType(Me.TipoCuentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._S_BankDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoCuentaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbTipoDeCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents txtSaldoCuenta As System.Windows.Forms.TextBox
    Friend WithEvents TipoCuentaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents _S_BankDataSet2 As S_Bank._S_BankDataSet2
    Friend WithEvents TipoCuentaBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TipoCuentaTableAdapter As S_Bank._S_BankDataSet2TableAdapters.tipoCuentaTableAdapter
End Class
