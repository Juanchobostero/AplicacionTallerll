<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlReportes = New System.Windows.Forms.Panel()
        Me.btnVerMov = New System.Windows.Forms.Button()
        Me.lblMov = New System.Windows.Forms.Label()
        Me.btnVerFac = New System.Windows.Forms.Button()
        Me.lblFac = New System.Windows.Forms.Label()
        Me.lblClientes = New System.Windows.Forms.Label()
        Me.btnVerClientes = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.pnlReportes.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(213, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Reportes"
        '
        'pnlReportes
        '
        Me.pnlReportes.BackgroundImage = Global.S_Bank.My.Resources.Resources.images
        Me.pnlReportes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlReportes.Controls.Add(Me.btnVerMov)
        Me.pnlReportes.Controls.Add(Me.lblMov)
        Me.pnlReportes.Controls.Add(Me.btnVerFac)
        Me.pnlReportes.Controls.Add(Me.lblFac)
        Me.pnlReportes.Controls.Add(Me.lblClientes)
        Me.pnlReportes.Controls.Add(Me.btnVerClientes)
        Me.pnlReportes.Location = New System.Drawing.Point(32, 86)
        Me.pnlReportes.Name = "pnlReportes"
        Me.pnlReportes.Size = New System.Drawing.Size(506, 174)
        Me.pnlReportes.TabIndex = 4
        '
        'btnVerMov
        '
        Me.btnVerMov.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerMov.Image = CType(resources.GetObject("btnVerMov.Image"), System.Drawing.Image)
        Me.btnVerMov.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerMov.Location = New System.Drawing.Point(358, 106)
        Me.btnVerMov.Name = "btnVerMov"
        Me.btnVerMov.Size = New System.Drawing.Size(72, 30)
        Me.btnVerMov.TabIndex = 5
        Me.btnVerMov.Text = "Ver"
        Me.btnVerMov.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVerMov.UseVisualStyleBackColor = True
        '
        'lblMov
        '
        Me.lblMov.AutoSize = True
        Me.lblMov.BackColor = System.Drawing.Color.Transparent
        Me.lblMov.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMov.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMov.Location = New System.Drawing.Point(20, 109)
        Me.lblMov.Name = "lblMov"
        Me.lblMov.Size = New System.Drawing.Size(267, 17)
        Me.lblMov.TabIndex = 4
        Me.lblMov.Text = "Usuarios que (si/no) pagaron servicios: "
        '
        'btnVerFac
        '
        Me.btnVerFac.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerFac.Image = CType(resources.GetObject("btnVerFac.Image"), System.Drawing.Image)
        Me.btnVerFac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerFac.Location = New System.Drawing.Point(358, 64)
        Me.btnVerFac.Name = "btnVerFac"
        Me.btnVerFac.Size = New System.Drawing.Size(72, 32)
        Me.btnVerFac.TabIndex = 3
        Me.btnVerFac.Text = "Ver"
        Me.btnVerFac.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVerFac.UseVisualStyleBackColor = True
        '
        'lblFac
        '
        Me.lblFac.AutoSize = True
        Me.lblFac.BackColor = System.Drawing.Color.Transparent
        Me.lblFac.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFac.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFac.Location = New System.Drawing.Point(20, 64)
        Me.lblFac.Name = "lblFac"
        Me.lblFac.Size = New System.Drawing.Size(246, 17)
        Me.lblFac.TabIndex = 2
        Me.lblFac.Text = "Facturas registradas del ultimo mes:"
        '
        'lblClientes
        '
        Me.lblClientes.AutoSize = True
        Me.lblClientes.BackColor = System.Drawing.Color.Transparent
        Me.lblClientes.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblClientes.Location = New System.Drawing.Point(20, 19)
        Me.lblClientes.Name = "lblClientes"
        Me.lblClientes.Size = New System.Drawing.Size(332, 17)
        Me.lblClientes.TabIndex = 1
        Me.lblClientes.Text = "Clientes registrados con sus respectivas cuentas:"
        '
        'btnVerClientes
        '
        Me.btnVerClientes.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerClientes.Image = CType(resources.GetObject("btnVerClientes.Image"), System.Drawing.Image)
        Me.btnVerClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerClientes.Location = New System.Drawing.Point(358, 17)
        Me.btnVerClientes.Name = "btnVerClientes"
        Me.btnVerClientes.Size = New System.Drawing.Size(72, 35)
        Me.btnVerClientes.TabIndex = 0
        Me.btnVerClientes.Text = "Ver"
        Me.btnVerClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVerClientes.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.S_Bank.My.Resources.Resources.salir_de_gnome_icono_8179_48
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(313, 293)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(110, 43)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Image = Global.S_Bank.My.Resources.Resources.preocupaciones_icono_8798_321
        Me.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtras.Location = New System.Drawing.Point(190, 293)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(97, 43)
        Me.btnAtras.TabIndex = 27
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'frmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.S_Bank.My.Resources.Resources.FondoAzul2
        Me.ClientSize = New System.Drawing.Size(569, 348)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.pnlReportes)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "frmReportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes"
        Me.pnlReportes.ResumeLayout(False)
        Me.pnlReportes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlReportes As System.Windows.Forms.Panel
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents lblClientes As System.Windows.Forms.Label
    Friend WithEvents btnVerClientes As System.Windows.Forms.Button
    Friend WithEvents btnVerMov As System.Windows.Forms.Button
    Friend WithEvents lblMov As System.Windows.Forms.Label
    Friend WithEvents btnVerFac As System.Windows.Forms.Button
    Friend WithEvents lblFac As System.Windows.Forms.Label
End Class
