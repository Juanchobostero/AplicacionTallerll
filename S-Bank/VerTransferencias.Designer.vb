<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerTransferencias
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.dgvTransferRealizadas = New System.Windows.Forms.DataGridView()
        CType(Me.dgvTransferRealizadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(70, 23)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(245, 24)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Transferencias Realizadas "
        '
        'dgvTransferRealizadas
        '
        Me.dgvTransferRealizadas.AllowUserToAddRows = False
        Me.dgvTransferRealizadas.AllowUserToDeleteRows = False
        Me.dgvTransferRealizadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransferRealizadas.Location = New System.Drawing.Point(12, 62)
        Me.dgvTransferRealizadas.Name = "dgvTransferRealizadas"
        Me.dgvTransferRealizadas.ReadOnly = True
        Me.dgvTransferRealizadas.Size = New System.Drawing.Size(389, 130)
        Me.dgvTransferRealizadas.TabIndex = 1
        '
        'VerTransferencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 262)
        Me.Controls.Add(Me.dgvTransferRealizadas)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "VerTransferencias"
        Me.Text = "VerTransferencias"
        CType(Me.dgvTransferRealizadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents dgvTransferRealizadas As System.Windows.Forms.DataGridView
End Class
