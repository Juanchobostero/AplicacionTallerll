<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultarSaldo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultarSaldo))
        Me.cbxCuentasAsociadas = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCuentas = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblNomUsuario = New System.Windows.Forms.Label()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.lblapeYnom = New System.Windows.Forms.Label()
        Me.lblApellidoyNombre = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbxCuentasAsociadas
        '
        Me.cbxCuentasAsociadas.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCuentasAsociadas.FormattingEnabled = True
        Me.cbxCuentasAsociadas.Location = New System.Drawing.Point(166, 18)
        Me.cbxCuentasAsociadas.Name = "cbxCuentasAsociadas"
        Me.cbxCuentasAsociadas.Size = New System.Drawing.Size(121, 25)
        Me.cbxCuentasAsociadas.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Consulta de Saldo"
        '
        'lblCuentas
        '
        Me.lblCuentas.AutoSize = True
        Me.lblCuentas.BackColor = System.Drawing.Color.Transparent
        Me.lblCuentas.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuentas.ForeColor = System.Drawing.Color.White
        Me.lblCuentas.Location = New System.Drawing.Point(8, 20)
        Me.lblCuentas.Name = "lblCuentas"
        Me.lblCuentas.Size = New System.Drawing.Size(139, 17)
        Me.lblCuentas.TabIndex = 2
        Me.lblCuentas.Text = "Seleccionar Cuenta:"
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.S_Bank.My.Resources.Resources.salir_de_gnome_icono_8179_48
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(249, 228)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(87, 36)
        Me.btnSalir.TabIndex = 28
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Image = Global.S_Bank.My.Resources.Resources.preocupaciones_icono_8798_321
        Me.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtras.Location = New System.Drawing.Point(21, 228)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(77, 36)
        Me.btnAtras.TabIndex = 27
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.Image = Global.S_Bank.My.Resources.Resources.img3774
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultar.Location = New System.Drawing.Point(116, 218)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(116, 46)
        Me.btnConsultar.TabIndex = 4
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.S_Bank.My.Resources.Resources.imagesdfs
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblCuentas)
        Me.Panel1.Controls.Add(Me.cbxCuentasAsociadas)
        Me.Panel1.Location = New System.Drawing.Point(21, 137)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 64)
        Me.Panel1.TabIndex = 29
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.lblNomUsuario)
        Me.Panel2.Controls.Add(Me.lblNombreUsuario)
        Me.Panel2.Controls.Add(Me.lblapeYnom)
        Me.Panel2.Controls.Add(Me.lblApellidoyNombre)
        Me.Panel2.Location = New System.Drawing.Point(46, 57)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(244, 74)
        Me.Panel2.TabIndex = 30
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
        'frmConsultarSaldo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.S_Bank.My.Resources.Resources.tabla_de_madera_1280x800
        Me.ClientSize = New System.Drawing.Size(348, 276)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmConsultarSaldo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Saldo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxCuentasAsociadas As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCuentas As System.Windows.Forms.Label
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblNomUsuario As System.Windows.Forms.Label
    Friend WithEvents lblNombreUsuario As System.Windows.Forms.Label
    Friend WithEvents lblapeYnom As System.Windows.Forms.Label
    Friend WithEvents lblApellidoyNombre As System.Windows.Forms.Label
End Class
