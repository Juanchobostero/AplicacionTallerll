Imports System.Data
Imports System.Data.SqlClient

Module ModuloFactura
    '*****************************ALTA DE LA CABECERA DE LA FACTURA Y ACTUALIZO EL SALDO DE LA CUENTA ASOCIADA AL USUARIO EN SESION*****************************
    Public Function AltaFactura() As Boolean
        Try
            Dim nombreUsuario As String = frmPagarServicios.lblNomUsuario.Text
            Dim montoTotal As Integer = frmPagarServicios.lblTotal.Text
            Dim fechaPago As String = frmPagarServicios.dtpFechaPago.Value.Day & "-" & frmPagarServicios.dtpFechaPago.Value.Month & "-" & frmPagarServicios.dtpFechaPago.Value.Year
            Dim cuenta As String = frmPagarServicios.cbxCuentasAsociadas.Text
            Dim periodoMes As String = frmPagarServicios.cbxPeriodoMes.Text
            Dim periodoAño As String = frmPagarServicios.lblPeriodoYEAR.Text

            Dim query6 As String = "SELECT id_usuario FROM usuarios WHERE nick_usuario = '" & nombreUsuario & "'"
            Dim id_us As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query6)
            ModuloConexion.sqlConnection1.Close()

            Dim query5 As String = "SELECT c.id_cuenta FROM cuentas c INNER JOIN usuarios u ON u.id_usuario = c.id_usuario INNER JOIN tipoCuenta tc ON tc.id_tipoCuenta = c.id_tipoCuenta WHERE u.id_usuario= '" & id_us & "' and tc.descripcion_tipoCuenta='" & cuenta & "'"
            Dim idCuenta As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query5)
            ModuloConexion.sqlConnection1.Close()

            Dim query8 As String = "INSERT INTO Factura(id_cuenta, montoTotal, fechaPago, periodoMes, PeriodoAño) VALUES('" & idCuenta & "','" & montoTotal & "','" & fechaPago & "','" & periodoMes & "','" & periodoAño & "')"
            ModuloConexion.SQL_Consulta(ModuloConexion.sqlConnection1, query8)
            ModuloConexion.sqlConnection1.Close()

            'capturo el saldo de la cuenta del usuario en sesion y le resto el total del pago
            '*******************************************************************************
            Dim query2 As String = "SELECT saldo_cuenta FROM cuentas c INNER JOIN tipoCuenta tc ON c.id_tipoCuenta = tc.id_tipoCuenta INNER JOIN usuarios u ON u.id_usuario = c.id_usuario WHERE tc.descripcion_tipoCuenta='" & cuenta & "' and u.id_usuario='" & id_us & "'"
            Dim saldo As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query2)
            ModuloConexion.sqlConnection1.Close()


            Dim saldoActualizado As Integer = saldo - montoTotal

            Dim query4 As String = "SELECT id_tipoCuenta FROM tipoCuenta WHERE descripcion_tipoCuenta ='" & cuenta & "'"
            Dim IDtc As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query4)
            ModuloConexion.sqlConnection1.Close()

            Dim query3 As String = "UPDATE cuentas SET saldo_cuenta= '" & saldoActualizado & "' WHERE id_usuario='" & id_us & "'  and id_tipoCuenta='" & IDtc & "'"
            ModuloConexion.SQL_Consulta(ModuloConexion.sqlConnection1, query3)
            ModuloConexion.sqlConnection1.Close()
            Return True
            '********************************************************************************
            Return True

        Catch Exp As SqlException
            MsgBox(Exp.Message, MsgBoxStyle.Critical, "SQL Error")
            ModuloConexion.sqlConnection1.Close()
            Return False
        Catch Exp As Exception
            MsgBox(Exp.Message, MsgBoxStyle.Critical, "General Error")
            Return False
        End Try

    End Function

End Module
