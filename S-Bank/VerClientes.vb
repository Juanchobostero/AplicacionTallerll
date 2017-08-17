Public Class frmVerClientes

    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click

        frmReportes.Show()
        Me.Close()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        frmLogin.Show()
        Me.Close()

    End Sub


    Private Sub actualizar_dgvClientes()
        dgvClientes.Visible = False
        'limpiar datagrid
        Try
            dgvClientes.DataSource = Nothing
            dgvClientes.Refresh()
            dgvClientes.Rows.Clear()
            dgvClientes.Columns.Clear()
        Catch ex As Exception

        End Try
        'cargar datagrid
        ModuloFunciones.FillDataGrid(dgvClientes, ModuloConexion.source, " SELECT u.id_usuario As 'Cliente nro', (u.apellido_usuario + ' ' + u.nombre_usuario)As 'Apellido y Nombre', tc.descripcion_tipoCuenta As 'Cuenta/s Asociadas', c.saldo_cuenta As 'Saldo Cuenta' FROM usuarios u INNER JOIN cuentas c ON c.id_usuario = u.id_usuario INNER JOIN tipoCuenta tc ON tc.id_tipoCuenta = c.id_tipoCuenta ORDER BY 'Apellido y Nombre' ASC")
        Try

        Catch ex As Exception

        End Try

        'auto ajustar tamaño
        dgvClientes.AutoResizeColumns()
        dgvClientes.Visible = True


    End Sub

    Private Sub frmVerClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        actualizar_dgvClientes()

    End Sub

  
End Class