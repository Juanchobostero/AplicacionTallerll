Public Class frmVerTransferenciasUsuarios
    Public banderaVT = 0

    Private Sub frmMovimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        banderaVT = 1

        actualizar_dgvTransferencias()

        Dim nombreUsuario As String = frmTransferencias.lblNomUsuario.Text

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


    Public Sub actualizar_dgvTransferencias()

        dgvVerTransfer.Visible = False

        'limpiar datagrid
        Try
            dgvVerTransfer.DataSource = Nothing
            dgvVerTransfer.Refresh()
            dgvVerTransfer.Rows.Clear()
            dgvVerTransfer.Columns.Clear()
        Catch ex As Exception

        End Try

        'cargar datagrid
        Dim nickUsuario As String = frmTransferencias.lblNomUsuario.Text
        ModuloFunciones.FillDataGrid(dgvVerTransfer, ModuloConexion.source, "SELECT m.id_movimiento As 'Movimiento nro', tc.descripcion_tipoCuenta As 'Cuentas Afectadas', m.fecha_movimiento As 'Fecha Transferencia', m.monto_movimiento As 'Monto Transferencia' FROM movimientos m  INNER JOIN cuentas c ON c.id_cuenta = m.id_cuenta INNER JOIN usuarios u ON u.id_usuario = c.id_usuario INNER JOIN tipoCuenta tc ON tc.id_tipoCuenta = c.id_tipoCuenta WHERE u.nick_usuario='" & nickUsuario & "'")

        'auto ajustar tamaño
        dgvVerTransfer.AutoResizeColumns()
        dgvVerTransfer.Visible = True


    End Sub

    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        frmTransferencias.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub dgvVerTransfer_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvVerTransfer.CellContentClick

    End Sub
End Class