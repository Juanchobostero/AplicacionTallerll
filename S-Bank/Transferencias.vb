Public Class frmTransferencias
    Public banderaT As Integer = 0

    Private Sub lblTitulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        banderaT = 3
        cbxTipoTransferencia.SelectedIndex = 0
        lbltipoMovimiento.Text = "Transferencia"
        Dim nick2 As String = frmVerTransferenciasUsuarios.lblNomUsuario.Text
        Dim nombreUsuario As String = frmFormUsuario.lblNomUsuario.Text

        'Set fecha de pago
        dtpFechaTransferencia.Text = Date.Now.Date

        If frmVerTransferenciasUsuarios.banderaVT = 1 Then

            nombreUsuario = nick2

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

            'Datos de la sesion
            lblapeYnom.Text = nombre + " " + apellido
            lblNomUsuario.Text = nick

            'cargar comboBox con las cuentas asociadas al usuario en sesion
            ModuloFunciones.CargaComboBoxCuentasAsociadas(cbxCuentasOrigen, IDusuario)
            ModuloFunciones.CargaComboBoxCuentasAsociadas(cbxCuentasDestino, IDusuario)
            ModuloFunciones.CargaComboBoxCuentasAsociadas(cbxCtaOrigen, IDusuario)
            ModuloFunciones.CargarComboBoxUsuarios(cbxUsuarios, IDusuario)

        Else

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

            'Datos de la sesion
            lblapeYnom.Text = nombre + " " + apellido
            lblNomUsuario.Text = nick

            'cargar comboBox con las cuentas asociadas al usuario en sesion
            ModuloFunciones.CargaComboBoxCuentasAsociadas(cbxCuentasOrigen, IDusuario)
            ModuloFunciones.CargaComboBoxCuentasAsociadas(cbxCuentasDestino, IDusuario)
            ModuloFunciones.CargaComboBoxCuentasAsociadas(cbxCtaOrigen, IDusuario)
            ModuloFunciones.CargarComboBoxUsuarios(cbxUsuarios, IDusuario)

        End If
    End Sub

    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        frmFormUsuario.Show()
        Me.Close()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub txtMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnTransferir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransferir.Click
        Dim ask As MsgBoxResult
        Dim ask2 As MsgBoxResult
        Dim nickUsuario As String = lblNomUsuario.Text
        Dim cuentaOrigen As String = cbxCuentasOrigen.Text
        Dim cuentaDestino As String = cbxCuentasDestino.Text
        Dim saldoOrigenNuevo As Integer = 0
        Dim saldoDestinoNuevo As Integer = 0


        If txtMonto.Text = String.Empty Then
            MsgBox("Debe Ingresar el monto a transferir", 0 + 0 + 16, "Monto Invalido")
        ElseIf cuentaOrigen = cuentaDestino Then
            MsgBox("Asegurese de que la cuenta origen no sea igual a la cuenta destino", 0 + 0 + 16, "Cuentas Repetidas")
        Else
            ask = MsgBox("¿Seguro que desea realizar la transferencia?", 4 + 0 + 32, "Confirmar Transferencia")
            If ask = MsgBoxResult.Yes Then
                If ModuloFunciones.ConsultarSaldo2 Then
                    MsgBox("Saldo Insuficiente", 0 + 0 + 48, "Saldo Insuficiente")
                    txtMonto.Clear()
                Else

                    Dim monto As Integer = txtMonto.Text

                    Dim query As String = "SELECT c.saldo_cuenta FROM cuentas c INNER JOIN usuarios u ON u.id_usuario = c.id_usuario INNER JOIN tipoCuenta tc ON tc.id_tipoCuenta = c.id_tipoCuenta WHERE u.nick_usuario ='" & nickUsuario & "' and tc.descripcion_tipoCuenta='" & cuentaOrigen & "'"
                    Dim saldoCuentaOrigen As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query)
                    ModuloConexion.sqlConnection1.Close()

                    Dim query2 As String = "SELECT id_tipoCuenta FROM tipoCuenta WHERE descripcion_tipoCuenta ='" & cuentaOrigen & "'"
                    Dim IDtipoCuentaOrigen As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query2)
                    ModuloConexion.sqlConnection1.Close()

                    Dim query3 As String = "SELECT id_usuario FROM usuarios WHERE nick_usuario ='" & nickUsuario & "'"
                    Dim IDusuario As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query3)
                    ModuloConexion.sqlConnection1.Close()

                    '******************* ACTUALIZO EL SALDO DE LA CUENTA ORIGEN ***********************
                    saldoOrigenNuevo = saldoCuentaOrigen - monto


                    Dim query5 As String = "UPDATE cuentas SET saldo_cuenta='" & saldoOrigenNuevo & "' WHERE id_usuario ='" & IDusuario & "' and id_tipoCuenta ='" & IDtipoCuentaOrigen & "'"
                    ModuloConexion.SQL_Consulta(ModuloConexion.sqlConnection1, query5)
                    ModuloConexion.sqlConnection1.Close()
                    '**********************************************************************************

                    Dim query6 As String = "SELECT c.saldo_cuenta FROM cuentas c INNER JOIN usuarios u ON u.id_usuario = c.id_usuario INNER JOIN tipoCuenta tc ON tc.id_tipoCuenta = c.id_tipoCuenta WHERE u.nick_usuario ='" & nickUsuario & "' and tc.descripcion_tipoCuenta='" & cuentaDestino & "'"
                    Dim saldoCuentaDestino As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query6)
                    ModuloConexion.sqlConnection1.Close()

                    Dim query7 As String = "SELECT id_tipoCuenta FROM tipoCuenta WHERE descripcion_tipoCuenta ='" & cuentaDestino & "'"
                    Dim IDtipoCuentaDestino As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query7)
                    ModuloConexion.sqlConnection1.Close()


                    '******************* ACUTALIZO EL SALDO DE LA CUENTA DESTINO **********************
                    saldoDestinoNuevo = saldoCuentaDestino + monto

                    Dim query9 As String = "UPDATE cuentas SET saldo_cuenta='" & saldoDestinoNuevo & "' WHERE id_usuario ='" & IDusuario & "' and id_tipoCuenta ='" & IDtipoCuentaDestino & "'"
                    ModuloConexion.SQL_Consulta(ModuloConexion.sqlConnection1, query9)
                    ModuloConexion.sqlConnection1.Close()
                    '**********************************************************************************


                    ' ******ALTA DE LOS MOVIMIENTOS REALIZADOS ******
                    ModuloMovimiento.altaMovimientoTransferencia()
                    '***********************************************


                    MsgBox("La Transferencia ha sido realizada con éxito!", MsgBoxStyle.Information, "Transferencia Completada")
                    txtMonto.Clear()

                    '********** actualizo el label de la cuenta destino y lo muestro ******************
                    Dim query10 As String = "SELECT c.saldo_cuenta FROM cuentas c INNER JOIN usuarios u ON u.id_usuario = c.id_usuario INNER JOIN tipoCuenta tc ON tc.id_tipoCuenta = c.id_tipoCuenta WHERE u.nick_usuario ='" & nickUsuario & "' and tc.descripcion_tipoCuenta='" & cuentaDestino & "'"
                    Dim saldoCuentaDestino2 As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query10)
                    ModuloConexion.sqlConnection1.Close()
                    lblSaldo2.Text = saldoCuentaDestino2
                    '*********************************************************************************

                    '********** actualizo el label de la cuenta origen y lo muestro ******************
                    Dim query11 As String = "SELECT c.saldo_cuenta FROM cuentas c INNER JOIN usuarios u ON u.id_usuario = c.id_usuario INNER JOIN tipoCuenta tc ON tc.id_tipoCuenta = c.id_tipoCuenta WHERE u.nick_usuario ='" & nickUsuario & "' and tc.descripcion_tipoCuenta='" & cuentaOrigen & "'"
                    Dim saldoCuentaOrigen2 As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query11)
                    ModuloConexion.sqlConnection1.Close()
                    lblSaldo1.Text = saldoCuentaOrigen2
                    '*********************************************************************************

                    

                    ask2 = MsgBox("¿Desea realizar otra transferencia?", 4 + 0 + 32, "Transferencia")
                    If ask2 = MsgBoxResult.Yes Then
                        Me.Show()
                    Else
                        frmFormUsuario.Show()
                        Me.Close()
                    End If
                End If
            Else
                txtMonto.Clear()
            End If
        End If

    End Sub

    Private Sub cbxTipoTransferencia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxTipoTransferencia.SelectedIndexChanged

        'Habilitar los paneles de acuerdo al tipo de tranferencia
        Dim tipo1 As String = cbxTipoTransferencia.Text
        Dim tipo2 As String = cbxTipoTransferencia.Text
        Dim nombreUsuario As String = lblNomUsuario.Text

        If tipo1 = "A una cuenta propia" Then
            Panel1.Enabled = True
            Panel2.Enabled = False

        ElseIf tipo2 = "A tercero" Then
            Panel1.Enabled = False
            Panel2.Enabled = True

            Dim query3 As String = "SELECT nick_usuario FROM usuarios  WHERE nick_usuario = '" & nombreUsuario & "'"
            Dim nick As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query3)
            ModuloConexion.sqlConnection1.Close()

            lbltitular.Text = nick
        End If
        '******************************************************
    End Sub


    Private Sub cbxUsuarios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxUsuarios.SelectedIndexChanged
        'Cargo comboBox con las cuentas asociadas al titular seleccionado
        Dim titular As String = cbxUsuarios.Text

        If titular = cbxUsuarios.Text Then
            Dim titular2 As String = cbxUsuarios.Text

            Dim query5 As String = "SELECT id_usuario FROM usuarios  WHERE nick_usuario = '" & titular2 & "'"
            Dim ID As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query5)
            ModuloConexion.sqlConnection1.Close()

            ModuloFunciones.CargaComboBoxCuentasAsociadas(cbxCtasDestinoAsociadas, ID)
        End If
    End Sub

    Private Sub txtMonto2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto2.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnTransferir2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransferir2.Click
        Dim ask2 As MsgBoxResult
        Dim nickUsuario As String = lblNomUsuario.Text
        Dim nickUsuarioDestino As String = cbxUsuarios.Text
        Dim cuentaOrigen As String = cbxCtaOrigen.Text
        Dim cuentaDestino As String = cbxCtasDestinoAsociadas.Text
        Dim saldoOrigenNuevo As Integer = 0
        Dim saldoDestinoNuevo As Integer = 0
        Dim ask As MsgBoxResult

        If txtMonto2.Text = String.Empty Then
            MsgBox("Debe Ingresar el monto a transferir", 0 + 0 + 16, "Monto Invalido")
        Else
            ask = MsgBox("¿Seguro que desea realizar la transferencia?", 4 + 0 + 32, "Confirmar Transferencia")
            If ask = MsgBoxResult.Yes Then
                If ModuloFunciones.ConsultarSaldo3 Then
                    MsgBox("Saldo Insuficiente", 0 + 0 + 48, "Saldo Insuficiente")
                Else
                    Dim monto As Integer = txtMonto2.Text

                    Dim query As String = "SELECT c.saldo_cuenta FROM cuentas c INNER JOIN usuarios u ON u.id_usuario = c.id_usuario INNER JOIN tipoCuenta tc ON tc.id_tipoCuenta = c.id_tipoCuenta WHERE u.nick_usuario ='" & nickUsuario & "' and tc.descripcion_tipoCuenta='" & cuentaOrigen & "'"
                    Dim saldoCuentaOrigen As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query)
                    ModuloConexion.sqlConnection1.Close()

                    Dim query2 As String = "SELECT id_tipoCuenta FROM tipoCuenta WHERE descripcion_tipoCuenta ='" & cuentaOrigen & "'"
                    Dim IDtipoCuentaOrigen As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query2)
                    ModuloConexion.sqlConnection1.Close()

                    Dim query3 As String = "SELECT id_usuario FROM usuarios WHERE nick_usuario ='" & nickUsuario & "'"
                    Dim IDusuario As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query3)
                    ModuloConexion.sqlConnection1.Close()

                    '******************* ACTUALIZO EL SALDO DE LA CUENTA ORIGEN ***********************
                    saldoOrigenNuevo = saldoCuentaOrigen - monto


                    Dim query5 As String = "UPDATE cuentas SET saldo_cuenta='" & saldoOrigenNuevo & "' WHERE id_usuario ='" & IDusuario & "' and id_tipoCuenta ='" & IDtipoCuentaOrigen & "'"
                    ModuloConexion.SQL_Consulta(ModuloConexion.sqlConnection1, query5)
                    ModuloConexion.sqlConnection1.Close()
                    '**********************************************************************************


                    Dim query6 As String = "SELECT c.saldo_cuenta FROM cuentas c INNER JOIN usuarios u ON u.id_usuario = c.id_usuario INNER JOIN tipoCuenta tc ON tc.id_tipoCuenta = c.id_tipoCuenta WHERE u.nick_usuario ='" & nickUsuarioDestino & "' and tc.descripcion_tipoCuenta='" & cuentaDestino & "'"
                    Dim saldoCuentaDestino As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query6)
                    ModuloConexion.sqlConnection1.Close()

                    Dim query7 As String = "SELECT id_tipoCuenta FROM tipoCuenta WHERE descripcion_tipoCuenta ='" & cuentaDestino & "'"
                    Dim IDtipoCuentaDestino As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query7)
                    ModuloConexion.sqlConnection1.Close()

                    Dim query8 As String = "SELECT id_usuario FROM usuarios WHERE nick_usuario ='" & nickUsuarioDestino & "'"
                    Dim IDusuarioDestino As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query8)
                    ModuloConexion.sqlConnection1.Close()

                    '******************* ACTUALIZO EL SALDO DE LA CUENTA ORIGEN ***********************
                    saldoDestinoNuevo = saldoCuentaDestino + monto


                    Dim query9 As String = "UPDATE cuentas SET saldo_cuenta='" & saldoDestinoNuevo & "' WHERE id_usuario ='" & IDusuarioDestino & "' and id_tipoCuenta ='" & IDtipoCuentaDestino & "'"
                    ModuloConexion.SQL_Consulta(ModuloConexion.sqlConnection1, query9)
                    ModuloConexion.sqlConnection1.Close()
                    '**********************************************************************************


                    ' ******ALTA DE LOS MOVIMIENTOS REALIZADOS ******
                    ModuloMovimiento.altaMovimientoTransferenciaAtercero()
                    '***********************************************

                    '********** actualizo el label de la cuenta origen y lo muestro ******************
                    Dim query10 As String = "SELECT c.saldo_cuenta FROM cuentas c INNER JOIN usuarios u ON u.id_usuario = c.id_usuario INNER JOIN tipoCuenta tc ON tc.id_tipoCuenta = c.id_tipoCuenta WHERE u.nick_usuario ='" & nickUsuario & "' and tc.descripcion_tipoCuenta='" & cuentaOrigen & "'"
                    Dim saldoCuentaOrigen2 As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query10)
                    ModuloConexion.sqlConnection1.Close()
                    lblSaldo4.Text = saldoCuentaOrigen2
                    '*********************************************************************************

                    '********** actualizo el label3 de la cuenta destino y lo muestro ******************
                    Dim query11 As String = "SELECT c.saldo_cuenta FROM cuentas c INNER JOIN usuarios u ON u.id_usuario = c.id_usuario INNER JOIN tipoCuenta tc ON tc.id_tipoCuenta = c.id_tipoCuenta WHERE u.nick_usuario ='" & nickUsuarioDestino & "' and tc.descripcion_tipoCuenta='" & cuentaDestino & "'"
                    Dim saldoCuentaDestino2 As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query11)
                    ModuloConexion.sqlConnection1.Close()
                    lblSaldo3.Text = saldoCuentaDestino2
                    '*********************************************************************************

                    MsgBox("La Transferencia ha sido realizada con éxito!", MsgBoxStyle.Information, "Transferencia Completada")
                    txtMonto2.Clear()

                    ask2 = MsgBox("¿Desea realizar otra transferencia?", 4 + 0 + 32, "Transferencia")
                    If ask2 = MsgBoxResult.Yes Then
                        Me.Show()
                    Else
                        frmFormUsuario.Show()
                        Me.Close()
                    End If
                End If
            Else
                txtMonto2.Clear()
            End If
        End If
    End Sub

    Private Sub cbxCuentasOrigen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxCuentasOrigen.SelectedIndexChanged
        Dim nombreUsuario As String = lblNomUsuario.Text

        Dim query4 As String = "SELECT id_usuario FROM usuarios  WHERE nick_usuario = '" & nombreUsuario & "'"
        Dim IDusuario As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query4)
        ModuloConexion.sqlConnection1.Close()


        'capturo y Muestro el Saldo de la cuenta origen del usuario en sesion en saldo1 cuando se trata de un transfer a una cuenta propia
        Dim tipoCuenta As String = cbxCuentasOrigen.Text

        Dim query6 As String = "SELECT c.saldo_cuenta FROM cuentas c INNER JOIN tipoCuenta tc ON tc.id_tipoCuenta = c.id_tipoCuenta WHERE c.id_usuario = '" & IDusuario & "' and tc.descripcion_tipoCuenta='" & tipoCuenta & "'"
        Dim saldoCuenta As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query6)
        ModuloConexion.sqlConnection1.Close()

        If tipoCuenta = cbxCuentasOrigen.Text Then
            lblSaldo1.Text = saldoCuenta
        End If
        '*******************************************
    End Sub

    Private Sub cbxCuentasDestino_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxCuentasDestino.SelectedIndexChanged
        Dim nombreUsuario As String = lblNomUsuario.Text

        Dim query4 As String = "SELECT id_usuario FROM usuarios  WHERE nick_usuario = '" & nombreUsuario & "'"
        Dim IDusuario As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query4)
        ModuloConexion.sqlConnection1.Close()


        'capturo y Muestro el saldo de la cuenta destino del usuario en sesion en saldo2 cuando se trata de un transfer a una cuenta propia 
        Dim tipoCuenta As String = cbxCuentasDestino.Text

        Dim query7 As String = "SELECT c.saldo_cuenta FROM cuentas c INNER JOIN tipoCuenta tc ON tc.id_tipoCuenta = c.id_tipoCuenta WHERE c.id_usuario = '" & IDusuario & "' and tc.descripcion_tipoCuenta='" & tipoCuenta & "'"
        Dim saldoCuenta As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query7)
        ModuloConexion.sqlConnection1.Close()

        If tipoCuenta = cbxCuentasDestino.Text Then
            lblSaldo2.Text = saldoCuenta
        End If
        '*******************************************
    End Sub

    Private Sub cbxCtasDestinoAsociadas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxCtasDestinoAsociadas.SelectedIndexChanged
        Dim nombreUsuarioDestino As String = cbxUsuarios.Text

        Dim query4 As String = "SELECT id_usuario FROM usuarios  WHERE nick_usuario = '" & nombreUsuarioDestino & "'"
        Dim IDusuario As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query4)
        ModuloConexion.sqlConnection1.Close()


        'capturo y Muestro el saldo de la cuenta destino del usuario al que queres transferir un saldo en saldo3 cuando se trata de un transfer a terceros
        Dim tipoCuenta As String = cbxCtasDestinoAsociadas.Text

        Dim query7 As String = "SELECT c.saldo_cuenta FROM cuentas c INNER JOIN tipoCuenta tc ON tc.id_tipoCuenta = c.id_tipoCuenta WHERE c.id_usuario = '" & IDusuario & "' and tc.descripcion_tipoCuenta='" & tipoCuenta & "'"
        Dim saldoCuenta As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query7)
        ModuloConexion.sqlConnection1.Close()

        If tipoCuenta = cbxCtasDestinoAsociadas.Text Then
            lblSaldo3.Text = saldoCuenta
        End If
        '*******************************************

    End Sub

    Private Sub btnVerTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerTransfer.Click
        frmVerTransferenciasUsuarios.Show()
        Me.Close()

    End Sub

    Private Sub cbxCtaOrigen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxCtaOrigen.SelectedIndexChanged
        Dim nombreUsuarioOrigen As String = lblNomUsuario.Text

        Dim query4 As String = "SELECT id_usuario FROM usuarios  WHERE nick_usuario = '" & nombreUsuarioOrigen & "'"
        Dim IDusuario As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query4)
        ModuloConexion.sqlConnection1.Close()


        'capturo y Muestro el saldo de la cuenta destino del usuario al que queres transferir un saldo en saldo3 cuando se trata de un transfer a terceros
        Dim tipoCuenta As String = cbxCtaOrigen.Text

        Dim query7 As String = "SELECT c.saldo_cuenta FROM cuentas c INNER JOIN tipoCuenta tc ON tc.id_tipoCuenta = c.id_tipoCuenta WHERE c.id_usuario = '" & IDusuario & "' and tc.descripcion_tipoCuenta='" & tipoCuenta & "'"
        Dim saldoCuenta As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query7)
        ModuloConexion.sqlConnection1.Close()

        If tipoCuenta = cbxCtaOrigen.Text Then
            lblSaldo4.Text = saldoCuenta
        End If
    End Sub
End Class