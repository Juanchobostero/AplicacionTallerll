Public Class frmVerFacturasUsuario
    Public banderaVF = 0

    Private Sub frmVerFacturasUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        actualizar_dgvMasPagados()
        actualizar_dgvPagados()
        banderaVF = 1

        actualizar_dgvFacturas()


        Dim nombreUsuario As String = frmPagarServicios.lblNomUsuario.Text

        '*******capturo datos de la sesion ******************
        Dim query As String = "SELECT nombre_usuario FROM usuarios  WHERE nick_usuario = '" & nombreUsuario & "'"
        Dim nombre As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query)
        ModuloConexion.sqlConnection1.Close()

        Dim query2 As String = "SELECT apellido_usuario FROM usuarios  WHERE nick_usuario = '" & nombreUsuario & "'"
        Dim apellido As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query2)
        ModuloConexion.sqlConnection1.Close()

        Dim query3 As String = "SELECT nick_usuario FROM usuarios  WHERE nick_usuario = '" & nombreUsuario & "'"
        Dim nick As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query3)
        ModuloConexion.sqlConnection1.Close()

        Dim query4 As String = "SELECT id_usuario FROM usuarios  WHERE nick_usuario = '" & nombreUsuario & "'"
        Dim IDusuario As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query4)
        ModuloConexion.sqlConnection1.Close()
        '*****************************************************

        'Datos de la sesion
        lblapeYnom.Text = nombre + " " + apellido
        lblNomUsuario.Text = nick

    End Sub

    Private Sub actualizar_dgvFacturas()
        dgvVerFacturas.Visible = False

        'limpiar datagrid
        Try
            dgvVerFacturas.DataSource = Nothing
            dgvVerFacturas.Refresh()
            dgvVerFacturas.Rows.Clear()
            dgvVerFacturas.Columns.Clear()
        Catch ex As Exception

        End Try

        'cargar datagrid
        Dim nickUsuario As String = frmPagarServicios.lblNomUsuario.Text
        ModuloFunciones.FillDataGrid(dgvVerFacturas, ModuloConexion.source, "SELECT f.id_factura As 'Factura Nro', u.nick_usuario As 'Usuario', tc.descripcion_tipoCuenta As 'Cuenta Afectada', f.fechaPago As 'Fecha de Pago', f.periodoMes As 'Periodo Mes', f.periodoAño As 'Periodo Año', f.montoTotal as 'Monto Total'  FROM Factura f INNER JOIN cuentas c ON c.id_cuenta = f.id_cuenta INNER JOIN usuarios u ON u.id_usuario = c.id_usuario INNER JOIN tipoCuenta tc ON tc.id_tipoCuenta = c.id_tipoCuenta WHERE u.nick_usuario='" & nickUsuario & "'")

        'auto ajustar tamaño
        dgvVerFacturas.AutoResizeColumns()
        dgvVerFacturas.Visible = True
    End Sub


    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click

        frmPagarServicios.Show()
        Me.Close()

    End Sub


    Private Sub actualizar_dgvPagados()
        dgvVerFacturas.Visible = False

        'limpiar datagrid
        Try
            dgvPagados.DataSource = Nothing
            dgvPagados.Refresh()
            dgvPagados.Rows.Clear()
            dgvPagados.Columns.Clear()
        Catch ex As Exception

        End Try

        'cargar datagrid
        Dim nick As String = frmPagarServicios.lblNomUsuario.Text
        Dim consultaNick As String = "SELECT id_usuario FROM usuarios WHERE nick_usuario = '" & nick & "'"
        Dim id_usuario As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, consultaNick)
        ModuloConexion.sqlConnection1.Close()

        ModuloFunciones.FillDataGrid(dgvPagados, ModuloConexion.source, "SELECT s.descripcion_servicio As 'Servicios Pagados' FROM detalleServicios ds INNER JOIN servicios s ON s.cod_servicio = ds.cod_servicio INNER JOIN factura f ON f.id_factura = ds.id_factura INNER JOIN cuentas c ON c.id_cuenta = f.id_cuenta INNER JOIN usuarios u ON u.id_usuario = c.id_usuario WHERE u.id_usuario = '" & id_usuario & "'")

        'auto ajustar tamaño
        dgvPagados.AutoResizeColumns()
        dgvPagados.Visible = True
    End Sub

    Private Sub actualizar_dgvMasPagados()
        dgvMasPagados.Visible = False

        'limpiar datagrid
        Try
            dgvMasPagados.DataSource = Nothing
            dgvMasPagados.Refresh()
            dgvMasPagados.Rows.Clear()
            dgvMasPagados.Columns.Clear()
        Catch ex As Exception

        End Try

        'cargar datagrid
        Dim nick As String = frmPagarServicios.lblNomUsuario.Text
        Dim consultaNick As String = "SELECT id_usuario FROM usuarios WHERE nick_usuario = '" & nick & "'"
        Dim id_usuario As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, consultaNick)
        ModuloConexion.sqlConnection1.Close()

        ModuloFunciones.FillDataGrid(dgvMasPagados, ModuloConexion.source, "SELECT s.descripcion_servicio As 'Servicio mas pagado', COUNT(*) As 'Veces pagado', u.nick_usuario As 'Usuario' FROM detalleServicios ds INNER JOIN servicios s ON s.cod_servicio = ds.cod_servicio INNER JOIN factura f ON f.id_factura = ds.id_factura INNER JOIN cuentas c ON c.id_cuenta = f.id_cuenta INNER JOIN usuarios u ON u.id_usuario = c.id_usuario GROUP BY s.descripcion_servicio, u.id_usuario, u.nick_usuario HAVING count(*) > 1 AND u.id_usuario = '" & id_usuario & "'")

        'auto ajustar tamaño
        dgvMasPagados.AutoResizeColumns()
        dgvMasPagados.Visible = True
    End Sub


    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        frmPagarServicios.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        frmLogin.Show()
        Me.Close()
    End Sub

End Class