Public Class frmAsignarCuenta


    Private Sub btnAsignar_Click(sender As System.Object, e As System.EventArgs) Handles btnAsignar.Click
        Dim ask As MsgBoxResult
        Dim ask2 As MsgBoxResult

        If (txtSaldo.Text = String.Empty) Then
            MsgBox("Debe completar todos los campos obligatorios", 0 + 0 + 16, "Error")
        Else
            ask = MsgBox("¿Seguro que desea asignarle una Cuenta?", 4 + 0 + 32, "Confirmar Asignacion")

        End If

        If ask = MsgBoxResult.Yes Then

            Dim query As String = "SELECT MAX(id_usuario) FROM usuarios"
            Dim IDUsuario As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query)
            ModuloConexion.sqlConnection1.Close()
            Dim saldo As String = txtSaldo.Text.ToString.Replace(",", ".")

            'ASIGNA CUENTA
            Dim tipoCuenta As String = cbTipoCuenta.Text
            Dim queryTipoCuenta As String
            Dim id_tipoCuenta As Integer
            If tipoCuenta = cbTipoCuenta.Text Then
                queryTipoCuenta = "SELECT id_tipoCuenta FROM tipoCuenta WHERE descripcion_tipoCuenta ='" & tipoCuenta & "'"
                id_tipoCuenta = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, queryTipoCuenta)
                ModuloConexion.sqlConnection1.Close()
            End If

            Dim query2 As String = "INSERT INTO cuentas(saldo_cuenta, id_usuario, id_tipoCuenta) VALUES('" & saldo & "','" & IDUsuario & "','" & id_tipoCuenta & "')"

            ModuloConexion.SQL_Consulta(ModuloConexion.sqlConnection1, query2)
            ModuloConexion.sqlConnection1.Close()
            MsgBox("La cuenta se ha asignado correctamente", MsgBoxStyle.Information, "Asignacion de Cuenta")
            ask2 = MsgBox("¿Desea asignarle otra Cuenta?", 4 + 0 + 32, "Confirmar Asignacion")
            If ask2 = MsgBoxResult.Yes Then

                Me.Show()
            Else
                frmUsuarios.Show()
                Me.Close()
            End If
        End If



    End Sub

    Private Sub frmAsignarCuenta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_S_BankDataSet2.tipoCuenta' Puede moverla o quitarla según sea necesario.
        Me.TipoCuentaTableAdapter.Fill(Me._S_BankDataSet2.tipoCuenta)

       

        Dim query As String = "SELECT MAX(id_usuario) FROM usuarios"
        lblNroIDUsuario.Text = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query)
        ModuloConexion.sqlConnection1.Close()
    End Sub


    Private Sub txtSaldo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSaldo.KeyPress
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


    Private Sub clear_all()
        lblNroIDUsuario.Dispose()
        txtSaldo.Clear()
    End Sub

    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        frmUsuarios.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Sub lblIDcuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblIDcuenta.Click

    End Sub

    Private Sub lblNroIDUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNroIDUsuario.Click

    End Sub
End Class