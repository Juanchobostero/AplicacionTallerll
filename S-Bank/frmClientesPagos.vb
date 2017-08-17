Public Class frmClientesPagos

    Private Sub actualizar_dgvPagaron()
        dgvPagaron.Visible = False
        'limpiar datagrid
        Try
            dgvPagaron.DataSource = Nothing
            dgvPagaron.Refresh()
            dgvPagaron.Rows.Clear()
            dgvPagaron.Columns.Clear()
        Catch ex As Exception

        End Try
        'cargar datagrid
        ModuloFunciones.FillDataGrid(dgvPagaron, ModuloConexion.source, "SELECT DISTINCT(u.apellido_usuario + ' ' + u.nombre_usuario)As 'Usuario', u.nick_usuario As 'Nick', u.mail_usuario As 'Mail' FROM usuarios u WHERE u.id_usuario IN (SELECT us.id_usuario FROM Factura f INNER JOIN cuentas c ON c.id_cuenta = f.id_cuenta INNER JOIN usuarios us ON us.id_usuario = c.id_usuario)")
        Try

        Catch ex As Exception

        End Try

        'auto ajustar tamaño
        dgvPagaron.AutoResizeColumns()
        dgvPagaron.Visible = True


    End Sub

    Private Sub actualizar_dgvNoPagaron()
        dgvNoPagaron.Visible = False
        'limpiar datagrid
        Try
            dgvNoPagaron.DataSource = Nothing
            dgvNoPagaron.Refresh()
            dgvNoPagaron.Rows.Clear()
            dgvNoPagaron.Columns.Clear()
        Catch ex As Exception

        End Try
        'cargar datagrid
        ModuloFunciones.FillDataGrid(dgvNoPagaron, ModuloConexion.source, "SELECT DISTINCT(u.apellido_usuario + ' ' + u.nombre_usuario)As 'Usuario', u.nick_usuario As 'Nick', u.mail_usuario As 'Mail' FROM usuarios u WHERE u.id_usuario NOT IN (SELECT us.id_usuario FROM Factura f INNER JOIN cuentas c ON c.id_cuenta = f.id_cuenta INNER JOIN usuarios us ON us.id_usuario = c.id_usuario)")
        Try

        Catch ex As Exception

        End Try

        'auto ajustar tamaño
        dgvNoPagaron.AutoResizeColumns()
        dgvNoPagaron.Visible = True


    End Sub

    Private Sub frmClientesPagos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        actualizar_dgvPagaron()
        actualizar_dgvNoPagaron()

        If dgvPagaron.RowCount > 0 And dgvNoPagaron.RowCount > 0 Then


            'Consulta del total de usuarios para calcular porcentajes
            Dim consultaUsuarios As String = "SELECT COUNT(*) FROM usuarios"
            Dim numeroDeUsuarios As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, consultaUsuarios)
            ModuloConexion.sqlConnection1.Close()

            Dim porcentajePagaron As Integer = (dgvPagaron.RowCount.ToString * 100 / numeroDeUsuarios)
            Dim porcentajeNoPagaron As Integer = (dgvNoPagaron.RowCount.ToString * 100 / numeroDeUsuarios)

            lblNum1.Text = dgvPagaron.RowCount.ToString
            lblNum2.Text = dgvNoPagaron.RowCount.ToString
            lblPor1.Text = porcentajePagaron
            lblPor2.Text = porcentajeNoPagaron
        End If
    End Sub


    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        frmLogin.Show()
        Me.Close()

    End Sub

    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click

        frmReportes.Show()
        Me.Close()

    End Sub


End Class