<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrearPDF
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
        Me.lblDatos = New System.Windows.Forms.Label()
        Me.txtDatos = New System.Windows.Forms.TextBox()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDatos
        '
        Me.lblDatos.AutoSize = True
        Me.lblDatos.Location = New System.Drawing.Point(27, 50)
        Me.lblDatos.Name = "lblDatos"
        Me.lblDatos.Size = New System.Drawing.Size(38, 13)
        Me.lblDatos.TabIndex = 0
        Me.lblDatos.Text = "Datos:"
        '
        'txtDatos
        '
        Me.txtDatos.Location = New System.Drawing.Point(99, 50)
        Me.txtDatos.Name = "txtDatos"
        Me.txtDatos.Size = New System.Drawing.Size(201, 20)
        Me.txtDatos.TabIndex = 1
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(330, 46)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(75, 23)
        Me.btnCrear.TabIndex = 2
        Me.btnCrear.Text = "Crear PDF"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'frmCrearPDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 311)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.txtDatos)
        Me.Controls.Add(Me.lblDatos)
        Me.Name = "frmCrearPDF"
        Me.Text = "frmCrearPDF"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDatos As System.Windows.Forms.Label
    Friend WithEvents txtDatos As System.Windows.Forms.TextBox
    Friend WithEvents btnCrear As System.Windows.Forms.Button
End Class
