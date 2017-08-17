Imports System.Data.SqlClient

Module ModuloMovimiento

    Public Function altaMovimiento()
        Dim descripcionMovimiento As String = frmPagarServicios.lblPagoServicio.Text
        Dim fechaMovimiento As String = frmPagarServicios.dtpFechaPago.Value.Day & "-" & frmPagarServicios.dtpFechaPago.Value.Month & "-" & frmPagarServicios.dtpFechaPago.Value.Year


        Dim nomUsuario As String = frmPagarServicios.lblNomUsuario.Text
        Dim descCuenta As String = frmPagarServicios.cbxCuentasAsociadas.Text

        Dim query As String = "SELECT id_usuario FROM usuarios WHERE nick_usuario ='" & nomUsuario & "'"
        Dim idUsuario As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query)
        ModuloConexion.sqlConnection1.Close()

        Dim query2 As String = "SELECT id_tipoCuenta FROM tipoCuenta WHERE descripcion_tipoCuenta ='" & descCuenta & "'"
        Dim idTC As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query2)
        ModuloConexion.sqlConnection1.Close()

        Dim query3 As String = "SELECT c.id_cuenta FROM cuentas c INNER JOIN tipoCuenta tc ON tc.id_tipoCuenta = c.id_tipoCuenta INNER JOIN usuarios u  ON u.id_usuario = c.id_usuario WHERE u.id_usuario='" & idUsuario & "' and tc.id_tipoCuenta='" & idTC & "'"
        Dim idCuenta As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query3)
        ModuloConexion.sqlConnection1.Close()

        Dim query4 As String = "SELECT MAX(id_factura) FROM Factura"
        Dim IDFactura As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query4)
        ModuloConexion.sqlConnection1.Close()

        Dim query5 As String = "SELECT ds.id_detalleServicio, s.monto_Servicio FROM detalleServicios ds INNER JOIN Factura f ON f.id_factura = ds.id_factura INNER JOIN servicios s ON s.cod_Servicio = ds.cod_servicio WHERE f.id_factura ='" & IDFactura & "'"
        'Dim idDS As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query5)
        Dim cmd As New SqlCommand(query5, ModuloConexion.sqlConnection1)

        'id por cada detalle de servicio pagado ******************************
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)
        ModuloConexion.sqlConnection1.Close()

        Dim idDS As Integer
        Dim montoMov As Integer

        For Each row As DataRow In ds.Tables(0).Rows
            idDS = row.Item(0)
            montoMov = row.Item(1)

            Dim query7 As String = "INSERT INTO movimientos(id_detalleServicio, id_cuenta, descripcion, fecha_movimiento, monto_movimiento) VALUES('" & idDS & "','" & idCuenta & "','" & descripcionMovimiento & "','" & fechaMovimiento & "','" & montoMov & "')"
            ModuloConexion.SQL_Consulta(ModuloConexion.sqlConnection1, query7)
            ModuloConexion.sqlConnection1.Close()
        Next
        '**********************************************************************************
    End Function


    Public Function altaMovimientoTransferencia()
        Dim descripcionMovimiento As String = frmTransferencias.lbltipoMovimiento.Text
        Dim nickUsuario As String = frmTransferencias.lblNomUsuario.Text
        Dim monto As Integer = frmTransferencias.txtMonto.Text
        Dim cuentaOrigen As String = frmTransferencias.cbxCuentasOrigen.Text
        Dim cuentaDestino As String = frmTransferencias.cbxCuentasDestino.Text
        Dim fechaTransferencia As String = frmTransferencias.dtpFechaTransferencia.Value.Day & "-" & frmTransferencias.dtpFechaTransferencia.Value.Month & "-" & frmTransferencias.dtpFechaTransferencia.Value.Year

        Dim query As String = "SELECT c.id_cuenta from cuentas c INNER JOIN tipoCuenta tc ON tc.id_tipoCuenta = c.id_tipoCuenta INNER JOIN usuarios u ON u.id_usuario = c.id_usuario WHERE u.nick_usuario='" & nickUsuario & "' and tc.descripcion_tipoCuenta='" & cuentaOrigen & "'"
        Dim IDcuentaOrigen As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query)
        ModuloConexion.sqlConnection1.Close()

        Dim query2 As String = "INSERT INTO movimientos(id_cuenta, descripcion, fecha_movimiento, monto_movimiento) VALUES('" & IDcuentaOrigen & "','" & descripcionMovimiento & "','" & fechaTransferencia & "','" & monto & "')"
        ModuloConexion.SQL_Consulta(ModuloConexion.sqlConnection1, query2)
        ModuloConexion.sqlConnection1.Close()

        Dim query3 As String = "SELECT c.id_cuenta from cuentas c INNER JOIN tipoCuenta tc ON tc.id_tipoCuenta = c.id_tipoCuenta INNER JOIN usuarios u ON u.id_usuario = c.id_usuario WHERE u.nick_usuario='" & nickUsuario & "' and tc.descripcion_tipoCuenta='" & cuentaDestino & "'"
        Dim IDcuentaDestino As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query3)
        ModuloConexion.sqlConnection1.Close()

        Dim query4 As String = "INSERT INTO movimientos(id_cuenta, descripcion, fecha_movimiento, monto_movimiento) VALUES('" & IDcuentaDestino & "','" & descripcionMovimiento & "','" & fechaTransferencia & "','" & monto & "')"
        ModuloConexion.SQL_Consulta(ModuloConexion.sqlConnection1, query4)
        ModuloConexion.sqlConnection1.Close()

    End Function

    Public Function altaMovimientoTransferenciaAtercero()

        Dim descripcionMovimiento As String = frmTransferencias.lbltipoMovimiento.Text
        Dim nickUsuario As String = frmTransferencias.lbltitular.Text
        Dim nickUsuarioDestino As String = frmTransferencias.cbxUsuarios.Text
        Dim monto As Integer = frmTransferencias.txtMonto2.Text
        Dim cuentaOrigen As String = frmTransferencias.cbxCtaOrigen.Text
        Dim cuentaDestino As String = frmTransferencias.cbxCtasDestinoAsociadas.Text
        Dim fechaTransferencia As String = frmTransferencias.dtpFechaTransferencia.Value.Day & "-" & frmTransferencias.dtpFechaTransferencia.Value.Month & "-" & frmTransferencias.dtpFechaTransferencia.Value.Year

        '********** capturo datos y doy alta el movimiento de la cuenta origen *****************
        Dim query As String = "SELECT c.id_cuenta from cuentas c INNER JOIN tipoCuenta tc ON tc.id_tipoCuenta = c.id_tipoCuenta INNER JOIN usuarios u ON u.id_usuario = c.id_usuario WHERE u.nick_usuario='" & nickUsuario & "' and tc.descripcion_tipoCuenta='" & cuentaOrigen & "'"
        Dim IDcuentaOrigen As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query)
        ModuloConexion.sqlConnection1.Close()

        Dim query2 As String = "INSERT INTO movimientos(id_cuenta, descripcion, fecha_movimiento, monto_movimiento) VALUES('" & IDcuentaOrigen & "','" & descripcionMovimiento & "','" & fechaTransferencia & "','" & monto & "')"
        ModuloConexion.SQL_Consulta(ModuloConexion.sqlConnection1, query2)
        ModuloConexion.sqlConnection1.Close()
        '*******************************************************************************************

        '********** capturo datos y doy alta el movimiento de la cuenta destino ********************
        Dim query3 As String = "SELECT c.id_cuenta from cuentas c INNER JOIN tipoCuenta tc ON tc.id_tipoCuenta = c.id_tipoCuenta INNER JOIN usuarios u ON u.id_usuario = c.id_usuario WHERE u.nick_usuario='" & nickUsuarioDestino & "' and tc.descripcion_tipoCuenta='" & cuentaDestino & "'"
        Dim IDcuentaDestino As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query3)
        ModuloConexion.sqlConnection1.Close()

        Dim query4 As String = "INSERT INTO movimientos(id_cuenta, descripcion, fecha_movimiento, monto_movimiento) VALUES('" & IDcuentaDestino & "','" & descripcionMovimiento & "','" & fechaTransferencia & "','" & monto & "')"
        ModuloConexion.SQL_Consulta(ModuloConexion.sqlConnection1, query4)
        ModuloConexion.sqlConnection1.Close()
        '*********************************************************************************************

    End Function
End Module
