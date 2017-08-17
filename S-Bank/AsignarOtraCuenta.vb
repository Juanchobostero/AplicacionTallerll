Public Class frmAsignarOtraCuenta

    Private Sub AsignarOtraCuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
 
        Dim ID As Integer = frmUsuarios.lblclave.Text
        Dim query2 As String = "SELECT nick_usuario FROM usuarios WHERE id_usuario =" & ID & ""
        lblTit.Text = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query2)
        ModuloConexion.sqlConnection1.Close()

        'Cargar combobox con los tipos de cuenta disponibles
        ModuloFunciones.CargarComboBoxTipoCuentas(cbxTipoDeCuenta)

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        frmLogin.Show()
        Me.Close()

    End Sub

    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click

        frmUsuarios.Show()
        Me.Close()
    End Sub

    Private Sub btnAsignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignar.Click

        Dim ask As MsgBoxResult
        Dim ask2 As MsgBoxResult

        If (txtSaldoCuenta.Text = String.Empty) Then
            MsgBox("Debe completar todos los campos obligatorios", 0 + 0 + 16, "Error")
        Else
            ask = MsgBox("¿Seguro que desea asignarle una Cuenta?", 4 + 0 + 32, "Confirmar Asignacion")

            If ask = MsgBoxResult.Yes Then
                If ModuloFunciones.verificarTipoCuenta2() Then
                    txtSaldoCuenta.Clear()
                    MsgBox("El tipo de cuenta seleccionado ya existe, asegurese de asignarle otra cuenta", 0 + 0 + 16, "Error")
                Else
                    Dim query As String = "SELECT id_usuario FROM usuarios WHERE nick_usuario = '" & lblTit.Text & "'"
                    Dim id As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query)
                    ModuloConexion.sqlConnection1.Close()

                    Dim IDUsuario As Integer = id
                    Dim saldo As String = txtSaldoCuenta.Text.ToString.Replace(",", ".")

                    'ASIGNA CUENTA
                    Dim tipoCuenta As String = cbxTipoDeCuenta.Text
                    Dim queryTipoCuenta As String
                    Dim id_tipoCuenta As Integer
                    If tipoCuenta = cbxTipoDeCuenta.Text Then
                        queryTipoCuenta = "SELECT id_tipoCuenta FROM tipoCuenta WHERE descripcion_tipoCuenta ='" & tipoCuenta & "'"
                        id_tipoCuenta = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, queryTipoCuenta)
                        ModuloConexion.sqlConnection1.Close()
                    End If

                    Dim query2 As String = "INSERT INTO cuentas(saldo_cuenta, id_usuario, id_tipoCuenta) VALUES('" & saldo & "'," & IDUsuario & ",'" & id_tipoCuenta & "')"

                    ModuloConexion.SQL_Consulta(ModuloConexion.sqlConnection1, query2)
                    ModuloConexion.sqlConnection1.Close()
                    MsgBox("La cuenta se ha asignado correctamente", MsgBoxStyle.Information, "Asignacion de Cuenta")
                End If

                ask2 = MsgBox("¿Desea asignarle otra Cuenta?", 4 + 0 + 32, "Confirmar Asignacion")
                If ask2 = MsgBoxResult.Yes Then
                    txtSaldoCuenta.Clear()
                    Me.Show()
                Else
                    frmUsuarios.Show()
                    Me.Close()
                End If
            End If
            End If
    End Sub

    Private Sub txtSaldoCuenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

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

    Private Sub txtSaldoCuenta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class