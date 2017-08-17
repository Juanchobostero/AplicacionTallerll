Public Class frmUltimasFacturas

    Private Sub actualizar_dgvUltimasFacturas()
        dgvUltimasFacturas.Visible = False
        'limpiar datagrid
        Try
            dgvUltimasFacturas.DataSource = Nothing
            dgvUltimasFacturas.Refresh()
            dgvUltimasFacturas.Rows.Clear()
            dgvUltimasFacturas.Columns.Clear()
        Catch ex As Exception

        End Try
        'cargar datagrid
        ModuloFunciones.FillDataGrid(dgvUltimasFacturas, ModuloConexion.source, "SELECT f.id_factura As 'Factura nro', tc.descripcion_tipoCuenta As 'Cuenta Afectada',u.nick_usuario As 'Usuario', (f.periodoMes + ' ' + f.periodoAño)As 'Periodo', CONVERT(CHAR(10), f.fechaPago, 103) As 'Fecha Pago' FROM Factura f INNER JOIN cuentas c ON c.id_cuenta = f.id_cuenta INNER JOIN tipoCuenta tc ON tc.id_tipoCuenta = c.id_tipoCuenta INNER JOIN usuarios u ON u.id_usuario = c.id_usuario WHERE(DateDiff(Day, f.fechaPago, getdate()) <= 30) ORDER BY u.nick_usuario")
        Try

        Catch ex As Exception

        End Try

        'auto ajustar tamaño
        dgvUltimasFacturas.AutoResizeColumns()
        dgvUltimasFacturas.Visible = True


    End Sub

 
    Private Sub frmUltimasFacturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        actualizar_dgvUltimasFacturas()

        If dgvUltimasFacturas.RowCount > 0 Then

            'Calcular total facturas
            Dim consultaFac As String = "SELECT COUNT(*) FROM Factura"
            Dim numeroDeFacturas As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, consultaFac)
            ModuloConexion.sqlConnection1.Close()

            Dim porcentaje As Integer = (dgvUltimasFacturas.RowCount().ToString * 100 / numeroDeFacturas)


            lblValor.Text = dgvUltimasFacturas.RowCount().ToString
            lblValor2.Text = porcentaje

        End If

    End Sub

    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click

        frmReportes.Show()
        Me.Close()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        frmLogin.Show()
        Me.Close()

    End Sub

 
End Class