Public Class frmVerFacturas

    Public columnaEliminar As New DataGridViewButtonColumn
    Public columnaEliminar2 As New DataGridViewButtonColumn
    Public id_Detalle1 As Integer

    Private Sub frmVerFacturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        actualizar_dgvFac()

    End Sub

    Public Sub actualizar_dgvFac()

        dgvFacturas.Visible = False

        'limpiar datagrid
        Try
            dgvFacturas.DataSource = Nothing
            dgvFacturas.Refresh()
            dgvFacturas.Rows.Clear()
            dgvFacturas.Columns.Clear()
        Catch ex As Exception

        End Try


        'cargar datagrid

        ModuloFunciones.FillDataGrid(dgvFacturas, ModuloConexion.source, "SELECT f.id_factura As 'Factura Nro', u.nick_usuario As 'Usuario', tc.descripcion_tipoCuenta As 'Cuenta Afectada', f.fechaPago As 'Fecha de Pago', f.periodoMes As 'Periodo Mes', f.periodoAño As 'Periodo Año', f.montoTotal as 'Monto Total'  FROM Factura f INNER JOIN cuentas c ON c.id_cuenta = f.id_cuenta INNER JOIN usuarios u ON u.id_usuario = c.id_usuario INNER JOIN tipoCuenta tc ON tc.id_tipoCuenta = c.id_tipoCuenta")
        Try
            'agregar columnas

            columnaEliminar.Text = "Eliminar"
            columnaEliminar.Name = "Eliminar"
            columnaEliminar.HeaderText = "Eliminar"
            columnaEliminar.DisplayIndex = 7
            columnaEliminar.UseColumnTextForButtonValue = True

            dgvFacturas.Columns.Add(columnaEliminar)

            'cargar datos en las columnas nuevas
            For Each row As DataGridViewRow In dgvFacturas.Rows
                If Not row.IsNewRow Then
                    'set eliminar en el boton
                    row.Cells("Eliminar").Value = "Eliminar"
                End If
            Next
        Catch ex As Exception

        End Try

        'auto ajustar tamaño
        dgvFacturas.AutoResizeColumns()
        dgvFacturas.Visible = True

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        frmLogin.Show()
        Me.Close()

    End Sub


    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click

        frmInicioAdm.Show()
        Me.Close()

    End Sub


    Private Sub dgvFacturas_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFacturas.CellClick

        Dim i As Integer
        i = dgvFacturas.CurrentRow.Index
        lblFacturaID.Text = dgvFacturas.Item(0, i).Value()
        actualizar_dgvDetalleFactura()

    End Sub

    Public Sub actualizar_dgvDetalleFactura()

        dgvDetalleFactura.Visible = False

        'limpiar datagrid
        Try
            dgvDetalleFactura.DataSource = Nothing
            dgvDetalleFactura.Refresh()
            dgvDetalleFactura.Rows.Clear()
            dgvDetalleFactura.Columns.Clear()
        Catch ex As Exception

        End Try

        'cargar datagrid
        Dim id_factura As Integer = lblFacturaID.Text
        ModuloFunciones.FillDataGrid(dgvDetalleFactura, ModuloConexion.source, "SELECT ds.id_detalleServicio As 'Detalle Nro', s.descripcion_servicio As 'Servicio', s.monto_servicio As 'Monto Servicio' FROM detalleServicios ds INNER JOIN Servicios s ON s.cod_servicio = ds.cod_servicio INNER JOIN Factura f ON f.id_factura = ds.id_factura WHERE f.id_factura = " & id_factura & "")

        Try
            'agregar columnas

            columnaEliminar2.Text = "Eliminar"
            columnaEliminar2.Name = "Eliminar"
            columnaEliminar2.HeaderText = "Eliminar"
            columnaEliminar2.DisplayIndex = 4
            columnaEliminar2.UseColumnTextForButtonValue = True

            dgvDetalleFactura.Columns.Add(columnaEliminar2)

            'cargar datos en las columnas nuevas
            For Each row As DataGridViewRow In dgvDetalleFactura.Rows
                If Not row.IsNewRow Then
                    'set eliminar en el boton
                    row.Cells("Eliminar").Value = "Eliminar"
                End If
            Next
        Catch ex As Exception

        End Try

        'auto ajustar tamaño
        dgvDetalleFactura.AutoResizeColumns()
        dgvDetalleFactura.Visible = True


    End Sub


    Private Sub dgvFacturas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFacturas.CellContentClick

        Dim ask As MsgBoxResult
        Dim cell As DataGridViewButtonCell = TryCast(dgvFacturas.CurrentCell, DataGridViewButtonCell)
        'Fila actual
        Dim row As DataGridViewRow = dgvFacturas.CurrentRow
        'boton del datagrid
        Dim botonData As DataGridViewButtonColumn = TryCast(dgvFacturas.Columns(e.ColumnIndex), DataGridViewButtonColumn)


        If botonData IsNot Nothing Then
            'eliminar

            If Me.dgvFacturas.Columns(e.ColumnIndex).Name = "Eliminar" Then

                ask = MsgBox("Desea eliminar el registro ?", 4 + 256 + 32, "Eliminacion de Registro")
                If ask = MsgBoxResult.Yes Then
                    If existeFacturaEnDetalleServicio() Then

                        MsgBox("La factura no puede eliminarse debido a que esta asociada a uno o mas detalles, elimine primero el detalle/s asociado/s a  esta factura y luego la factura en cuestion", 0 + 0 + 16, "Error")

                    Else

                        Dim id_factura As Integer = ModuloFunciones.GetElementFromGridViewCol("id_factura", dgvFacturas)
                        Dim query As String = "DELETE FROM Factura WHERE id_factura = " & id_factura & ""
                        ModuloFunciones.SQL_query(sqlConnection1, query)
                        sqlConnection1.Close()
                        actualizar_dgvFac()
                        MsgBox("La factura ha sido eliminada correctamente", MsgBoxStyle.Information, "Eliminar")

                    End If
                End If
            End If
        End If

    End Sub

    Private Sub dgvDetalleFactura_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalleFactura.CellContentClick

        Dim ask As MsgBoxResult
        Dim cell As DataGridViewButtonCell = TryCast(dgvDetalleFactura.CurrentCell, DataGridViewButtonCell)
        'Fila actual
        Dim row As DataGridViewRow = dgvDetalleFactura.CurrentRow
        'boton del datagrid
        Dim botonData As DataGridViewButtonColumn = TryCast(dgvDetalleFactura.Columns(e.ColumnIndex), DataGridViewButtonColumn)


        If botonData IsNot Nothing Then
            'eliminar

            If Me.dgvDetalleFactura.Columns(e.ColumnIndex).Name = "Eliminar" Then

                ask = MsgBox("Desea eliminar el registro ?", 4 + 256 + 32, "Eliminacion de Registro")
                If ask = MsgBoxResult.Yes Then
                    id_Detalle1 = ModuloFunciones.GetElementFromGridViewCol("id_detalleServicio", dgvDetalleFactura)
                    If existeDetalleEnMovimiento() Then

                        MsgBox("El detalle no puede ser eliminado por estar asociado a un movimiento, elimine primero el movimiento asociado a este detalle y luego elimine el detalle en cuestion", 0 + 0 + 16, "Error")

                    Else

                        Dim id_detalle As Integer = ModuloFunciones.GetElementFromGridViewCol("id_detalleServicio", dgvDetalleFactura)
                        Dim query As String = "DELETE FROM detalleServicios WHERE id_detalleServicio = " & id_detalle & ""
                        ModuloFunciones.SQL_query(sqlConnection1, query)
                        sqlConnection1.Close()
                        actualizar_dgvDetalleFactura()
                        MsgBox("El detalle ha sido eliminado correctamente", MsgBoxStyle.Information, "Eliminar")

                    End If
                End If
            End If
        End If
    End Sub
End Class