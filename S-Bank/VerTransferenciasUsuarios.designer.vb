<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerTransferenciasUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVerTransferenciasUsuarios))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.dgvVerTransfer = New System.Windows.Forms.DataGridView()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblNomUsuario = New System.Windows.Forms.Label()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.lblapeYnom = New System.Windows.Forms.Label()
        Me.lblApellidoyNombre = New System.Windows.Forms.Label()
        CType(Me.dgvVerTransfer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(167, 9)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(369, 31)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Ver Transferencias Realizadas"
        '
        'dgvVerTransfer
        '
        Me.dgvVerTransfer.AllowUserToAddRows = False
        Me.dgvVerTransfer.AllowUserToDeleteRows = False
        Me.dgvVerTransfer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvVerTransfer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVerTransfer.Location = New System.Drawing.Point(13, 155)
        Me.dgvVerTransfer.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvVerTransfer.Name = "dgvVerTransfer"
        Me.dgvVerTransfer.ReadOnly = True
        Me.dgvVerTransfer.Size = New System.Drawing.Size(614, 190)
        Me.dgvVerTransfer.TabIndex = 1
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.ForeColor = System.Drawing.Color.Black
        Me.btnAtras.Image = Global.S_Bank.My.Resources.Resources.preocupaciones_icono_8798_321
        Me.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtras.Location = New System.Drawing.Point(241, 369)
        Me.btnAtras.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(86, 46)
        Me.btnAtras.TabIndex = 28
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
        Me.btnSalir.Location = New System.Drawing.Point(335, 369)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(105, 46)
        Me.btnSalir.TabIndex = 29
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
        Me.Panel3.Location = New System.Drawing.Point(193, 61)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(286, 74)
        Me.Panel3.TabIndex = 32
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
        'frmVerTransferenciasUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.S_Bank.My.Resources.Resources.tabla_de_madera_1280x800
        Me.ClientSize = New System.Drawing.Size(640, 428)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.dgvVerTransfer)
        Me.Controls.Add(Me.lblTitulo)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.Name = "frmVerTransferenciasUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ver Transferencias"
        CType(Me.dgvVerTransfer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents dgvVerTransfer As System.Windows.Forms.DataGridView
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblNomUsuario As System.Windows.Forms.Label
    Friend WithEvents lblNombreUsuario As System.Windows.Forms.Label
    Friend WithEvents lblapeYnom As System.Windows.Forms.Label
    Friend WithEvents lblApellidoyNombre As System.Windows.Forms.Label
End Class
