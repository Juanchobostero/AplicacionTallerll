Public Class frmConsultarSaldo
    Public banderaCS As Integer = 0

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxCuentasAsociadas.SelectedIndexChanged

    End Sub

    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        frmFormUsuario.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub ConsultarSaldo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        banderaCS = 2
        Dim nombreUsuario As String = frmFormUsuario.lblNomUsuario.Text

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
        ModuloFunciones.CargaComboBoxCuentasAsociadas(cbxCuentasAsociadas, IDusuario)
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        Dim cuenta As String = cbxCuentasAsociadas.Text
        Dim nombreUsuario As String = lblNomUsuario.Text

        Dim query4 As String = "SELECT id_usuario FROM usuarios  WHERE nick_usuario = '" & nombreUsuario & "'"
        Dim IDusuario As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query4)
        ModuloConexion.sqlConnection1.Close()

        If cuenta = cbxCuentasAsociadas.Text Then
            Dim saldo As String = "SELECT c.saldo_cuenta FROM cuentas c INNER JOIN tipoCuenta tc ON tc.id_tipoCuenta = c.id_tipoCuenta INNER JOIN usuarios u ON u.id_usuario = c.id_usuario WHERE u.id_usuario ='" & IDusuario & "' and tc.descripcion_tipoCuenta ='" & cuenta & "'"
            Dim saldoCuenta As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, saldo)
            ModuloConexion.sqlConnection1.Close()

            MsgBox("Su saldo es: $" & saldoCuenta & "", MsgBoxStyle.Information, "Saldo Disponible")
        End If

    End Sub
End Class