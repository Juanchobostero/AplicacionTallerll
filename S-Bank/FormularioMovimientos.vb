Public Class frmMovimientos

    Public columnaEliminar As New DataGridViewButtonColumn
    Public columnaEliminar2 As New DataGridViewButtonColumn

    Private Sub frmMovimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actualizar_dgvMovimientos()
        actualizar_dgvTransferencias()

    End Sub

    Public Sub actualizar_dgvMovimientos()

        dgvMovimientos.Visible = False

        'limpiar datagrid
        Try
            dgvMovimientos.DataSource = Nothing
            dgvMovimientos.Refresh()
            dgvMovimientos.Rows.Clear()
            dgvMovimientos.Columns.Clear()
        Catch ex As Exception

        End Try


        'cargar datagrid

        ModuloFunciones.FillDataGrid(dgvMovimientos, ModuloConexion.source, "SELECT id_movimiento As 'Movimiento nro', ds.id_factura As 'Factura nro', u.nick_usuario As 'Titular', descripcion_tipoCuenta As 'Cuenta', s.descripcion_Servicio As Servicio, descripcion, fecha_movimiento As 'Fecha', monto_movimiento As 'Monto' FROM movimientos m INNER JOIN cuentas c ON c.id_cuenta = m.id_cuenta INNER JOIN tipoCuenta tc ON tc.id_tipoCuenta = c.id_tipoCuenta INNER JOIN usuarios u ON u.id_usuario = c.id_usuario INNER JOIN detalleServicios ds ON ds.id_detalleServicio = m.id_detalleServicio INNER JOIN Servicios s ON s.cod_servicio = ds.cod_servicio")
        Try
            'agregar columnas

            columnaEliminar.Text = "Eliminar"
            columnaEliminar.Name = "Eliminar"
            columnaEliminar.HeaderText = "Eliminar"
            columnaEliminar.DisplayIndex = 8
            columnaEliminar.UseColumnTextForButtonValue = True

            dgvMovimientos.Columns.Add(columnaEliminar)

            'cargar datos en las columnas nuevas
            For Each row As DataGridViewRow In dgvMovimientos.Rows
                If Not row.IsNewRow Then
                    'set eliminar en el boton
                    row.Cells("Eliminar").Value = "Eliminar"
                End If
            Next
        Catch ex As Exception

        End Try

        'auto ajustar tamaño
        dgvMovimientos.AutoResizeColumns()
        dgvMovimientos.Visible = True


    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        frmLogin.Show()
        Me.Close()

    End Sub

    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click

        frmInicioAdm.Show()
        Me.Close()

    End Sub

    Private Sub dgvMovimientos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMovimientos.CellContentClick

        Dim ask As MsgBoxResult
        Dim cell As DataGridViewButtonCell = TryCast(dgvMovimientos.CurrentCell, DataGridViewButtonCell)
        'Fila actual
        Dim row As DataGridViewRow = dgvMovimientos.CurrentRow
        'boton del datagrid
        Dim botonData As DataGridViewButtonColumn = TryCast(dgvMovimientos.Columns(e.ColumnIndex), DataGridViewButtonColumn)


        If botonData IsNot Nothing Then
            'eliminar

            If Me.dgvMovimientos.Columns(e.ColumnIndex).Name = "Eliminar" Then

                ask = MsgBox("Desea eliminar el registro ?", 4 + 256 + 32, "Eliminacion de Registro")
                If ask = MsgBoxResult.Yes Then


                    Dim id_movimiento As Integer = ModuloFunciones.GetElementFromGridViewCol("Movimiento nro", dgvMovimientos)
                    Dim query As String = "DELETE FROM movimientos WHERE id_movimiento = " & id_movimiento & ""
                    ModuloFunciones.SQL_query(sqlConnection1, query)
                    sqlConnection1.Close()
                    actualizar_dgvMovimientos()
                    MsgBox("El movimiento ha sido eliminado correctamente", MsgBoxStyle.Information, "Eliminar")

                End If
            End If

            End If

    End Sub

    Public Sub actualizar_dgvTransferencias()

        dgvTransferencias.Visible = False

        'limpiar datagrid
        Try
            dgvTransferencias.DataSource = Nothing
            dgvTransferencias.Refresh()
            dgvTransferencias.Rows.Clear()
            dgvTransferencias.Columns.Clear()
        Catch ex As Exception

        End Try

        'cargar datagrid
        ModuloFunciones.FillDataGrid(dgvTransferencias, ModuloConexion.source, "SELECT m.id_movimiento As 'Movimiento nro', tc.descripcion_tipoCuenta As 'Cuentas Afectadas', u.nick_usuario As 'Titular', m.descripcion As Descripcion, m.fecha_movimiento As 'Fecha Movimiento', m.monto_movimiento As 'Monto Movimiento' FROM movimientos m  INNER JOIN cuentas c ON c.id_cuenta = m.id_cuenta INNER JOIN usuarios u ON u.id_usuario = c.id_usuario INNER JOIN tipoCuenta tc ON tc.id_tipoCuenta = c.id_tipoCuenta WHERE descripcion = 'Transferencia'")
        Try
            'agregar columnas

            columnaEliminar2.Text = "Eliminar"
            columnaEliminar2.Name = "Eliminar"
            columnaEliminar2.HeaderText = "Eliminar"
            columnaEliminar2.DisplayIndex = 6
            columnaEliminar2.UseColumnTextForButtonValue = True

            dgvTransferencias.Columns.Add(columnaEliminar2)

            'cargar datos en las columnas nuevas
            For Each row As DataGridViewRow In dgvTransferencias.Rows
                If Not row.IsNewRow Then
                    'set eliminar en el boton
                    row.Cells("Eliminar").Value = "Eliminar"
                End If
            Next
        Catch ex As Exception

        End Try

        'auto ajustar tamaño
        dgvTransferencias.AutoResizeColumns()
        dgvTransferencias.Visible = True


    End Sub

    Private Sub dgvTransferencias_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTransferencias.CellContentClick

        Dim ask As MsgBoxResult
        Dim cell As DataGridViewButtonCell = TryCast(dgvTransferencias.CurrentCell, DataGridViewButtonCell)
        'Fila actual
        Dim row As DataGridViewRow = dgvTransferencias.CurrentRow
        'boton del datagrid
        Dim botonData As DataGridViewButtonColumn = TryCast(dgvTransferencias.Columns(e.ColumnIndex), DataGridViewButtonColumn)


        If botonData IsNot Nothing Then
            'eliminar

            If Me.dgvTransferencias.Columns(e.ColumnIndex).Name = "Eliminar" Then

                ask = MsgBox("Desea eliminar el registro ?", 4 + 256 + 32, "Eliminacion de Registro")
                If ask = MsgBoxResult.Yes Then


                    Dim id_movimiento As Integer = ModuloFunciones.GetElementFromGridViewCol("Movimiento nro", dgvTransferencias)
                    Dim query As String = "DELETE FROM movimientos WHERE id_movimiento = " & id_movimiento & ""
                    ModuloFunciones.SQL_query(sqlConnection1, query)
                    sqlConnection1.Close()
                    actualizar_dgvTransferencias()
                    MsgBox("El movimiento ha sido eliminado correctamente", MsgBoxStyle.Information, "Eliminar")

                End If
            End If

        End If

    End Sub
End Class