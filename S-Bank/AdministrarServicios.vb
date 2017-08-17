Imports System.Data
Imports System.Data.SqlClient

Public Class frmAdministrarServicios
    'bandera para saber si modificar un tipo de cuenta o no
    Dim modificarRegistro As Boolean = False
    Dim idServicioModificar As String = ""

    'columnas del datagrid
    Dim ColumnaEliminar As New DataGridViewButtonColumn
    Dim ColumnaModificar As New DataGridViewButtonColumn

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim ask As MsgBoxResult

        If (txtDescripcionServicio.Text = String.Empty Or txtMonto.Text = String.Empty) Then

            MsgBox("Debe completar todos los campos", 0 + 0 + 16, "Error")


        Else
            ask = MsgBox("¿Seguro que desea agregar un nuevo Servicio?", 4 + 0 + 32, "Agregar")
           
            If ask = MsgBoxResult.Yes Then
                If ModuloFunciones.existeServicio Then
                    MsgBox("El servicio ingresado ya existe!", 0 + 0 + 16, "Servicio Existente")

                Else

                    Dim descripcionServicio As String = txtDescripcionServicio.Text
                    Dim monto As Integer = txtMonto.Text.ToString.Replace(",", ".")
                    Dim fechaVencimiento1 As String = dtpVencimiento1.Value.Day & "-" & dtpVencimiento1.Value.Month & "-" & dtpVencimiento1.Value.Year
                    Dim fechaVencimiento2 As String = dtpVencimiento2.Value.Day & "-" & dtpVencimiento2.Value.Month & "-" & dtpVencimiento2.Value.Year

                    'ALTA SERVICIO

                    If (modificarRegistro = False) Then
                        Dim Proveedor As String = cbxProveedor.Text
                        Dim id_proveedor As Integer
                        Dim query2 As String
                        If Proveedor = cbxProveedor.Text Then
                            query2 = "SELECT id_proveedor FROM proveedores WHERE descripcion_proveedor ='" & Proveedor & "'"
                            id_proveedor = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query2)
                            ModuloConexion.sqlConnection1.Close()
                        End If

                        Dim query As String = "INSERT INTO Servicios(id_proveedor, descripcion_servicio, monto_servicio, fecha_vencimiento1, fecha_vencimiento2) VALUES('" & id_proveedor & "','" & descripcionServicio & "','" & monto & "','" & fechaVencimiento1 & "','" & fechaVencimiento2 & "')"
                        ModuloConexion.SQL_Consulta(ModuloConexion.sqlConnection1, query)
                        ModuloConexion.sqlConnection1.Close()

                        actualizar_dtv()
                        MsgBox("El servicio se ha insertado correctamente", MsgBoxStyle.Information, "Agregar Servicio")

                        clear_all()

                    Else
                        'Modificar Servicio

                        'consulta al a base de datos
                        btnAgregar.Text = "Confirmar"

                        'habilitar componentes
                        ColumnaModificar.Visible = True
                        ColumnaEliminar.Visible = True
                        modificarRegistro = False
                        txtDescripcionServicio.Enabled = True
                        txtMonto.Enabled = True

                        Dim query As String = "UPDATE Servicios SET descripcion_servicio='" & descripcionServicio & "', monto_servicio='" & monto & "', fecha_vencimiento1 = '" & fechaVencimiento1 & "', fecha_vencimiento2 = '" & fechaVencimiento2 & "'  WHERE cod_servicio=" & idServicioModificar
                        ModuloConexion.SQL_Consulta(ModuloConexion.sqlConnection1, query)
                        ModuloConexion.sqlConnection1.Close()

                        'actualizar grid
                        actualizar_dtv()
                        MsgBox("El servicio se ha modificado correctamente", MsgBoxStyle.Information, "Modificar Servicio")

                        'limpiar componentes
                        clear_all()
                        btnAgregar.Text = "Agregar"
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub actualizar_dtv()
        dgvTipoServicio.Visible = False

        'limpiar datagrid
        Try
            dgvTipoServicio.DataSource = Nothing
            dgvTipoServicio.Refresh()
            dgvTipoServicio.Rows.Clear()
            dgvTipoServicio.Columns.Clear()
        Catch ex As Exception

        End Try

        'cargar datagrid
        ModuloFunciones.FillDataGrid(dgvTipoServicio, ModuloConexion.source, "SELECT s.cod_servicio, p.descripcion_proveedor As Proveedor, s.descripcion_servicio As Servicio, s.monto_servicio As Precio, s.fecha_Vencimiento1 As fechaVencimiento1, s.fecha_Vencimiento2 As fechaVencimiento2 FROM Servicios s INNER JOIN proveedores p ON s.id_proveedor = p.id_proveedor")
        Try
            'agregar columnas

            ColumnaEliminar.HeaderText = "Eliminar"
            ColumnaEliminar.Text = "Eliminar"
            ColumnaEliminar.Name = "Eliminar"
            ColumnaEliminar.DisplayIndex = 7
            ColumnaEliminar.UseColumnTextForButtonValue = True

            ColumnaModificar.HeaderText = "Modificar"
            ColumnaModificar.Text = "Modificar"
            ColumnaModificar.Name = "Modificar"
            ColumnaModificar.DisplayIndex = 8
            ColumnaModificar.UseColumnTextForButtonValue = True

            dgvTipoServicio.Columns.Add(ColumnaEliminar)
            dgvTipoServicio.Columns.Add(ColumnaModificar)

            'set font
            dgvTipoServicio.Columns("descripcion").DefaultCellStyle.Font = New System.Drawing.Font("Verdana", 9.75)

            'cargar datos en las columnas nuevas
            For Each row As DataGridViewRow In dgvTipoServicio.Rows
                If Not row.IsNewRow Then
                    'set eliminar en el boton
                    row.Cells(ModuloFunciones.GetColName("Eliminar", dgvTipoServicio)).Value = "Eliminar"
                    row.Cells(ModuloFunciones.GetColName("Modificar", dgvTipoServicio)).Value = "Modificar"
                End If
            Next
        Catch ex As Exception

        End Try

        'auto ajustar tamaño
        dgvTipoServicio.AutoResizeColumns()
        dgvTipoServicio.Visible = True
    End Sub

    Private Sub clear_all()
        txtDescripcionServicio.Clear()
        txtMonto.Clear()
    End Sub

    Private Sub AgregarTipoServicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        actualizar_dtv()
        'Cargar combobox con los proveedores disponibles
        ModuloFunciones.CargarComboBoxProveedores(cbxProveedor)
    End Sub

    Private Sub dgvTipoServicio_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTipoServicio.CellContentClick
        Dim ask As MsgBoxResult
        Dim cell As DataGridViewButtonCell = TryCast(dgvTipoServicio.CurrentCell, DataGridViewButtonCell)
        'Fila actual
        Dim row As DataGridViewRow = dgvTipoServicio.CurrentRow
        'boton del datagrid
        Dim botonData As DataGridViewButtonColumn = TryCast(dgvTipoServicio.Columns(e.ColumnIndex), DataGridViewButtonColumn)
        'get descripcion
        Dim descripcion1 As String = ModuloFunciones.GetElementFromGridViewCol("descripcion_servicio", dgvTipoServicio)

        If botonData IsNot Nothing Then

            'eliminar
            If Me.dgvTipoServicio.Columns(e.ColumnIndex).Name = "Eliminar" Then
                ask = MsgBox("Desea eliminar este registro ?", 4 + 256 + 32, "Eliminacion de Registro")
                If ask = MsgBoxResult.Yes Then
                    If ModuloFunciones.existeServicioEnDetalle() Then

                        MsgBox("El servicio esta asociado a uno o mas detalles, elimine primero los detalles asociado a este servicio y luego elimine el servicio en cuestion", 0 + 0 + 16, "Error")

                    Else
                        Dim cod_servicio As String = ModuloFunciones.GetElementFromGridViewCol("cod_servicio", dgvTipoServicio)
                        Dim query As String = "DELETE FROM Servicios WHERE cod_servicio=" & cod_servicio
                        ModuloConexion.SQL_Consulta(sqlConnection1, query)
                        sqlConnection1.Close()

                        clear_all()
                        actualizar_dtv()

                        MsgBox("El servicio ha sido eliminado con èxito!", MsgBoxStyle.Information, "Eliminar")
                    End If
                End If
            End If

            'modificar
            If Me.dgvTipoServicio.Columns(e.ColumnIndex).Name = "Modificar" Then
                ask = MsgBox("Desea Modificar el registro: " & descripcion1 & "?", 4 + 256 + 32, "Modificacion de Registro")
                If ask = MsgBoxResult.Yes Then

                    modificarRegistro = True

                    'recuperar datos del grid
                    idServicioModificar = ModuloFunciones.GetElementFromGridViewCol("cod_servicio", dgvTipoServicio)
                    Dim i As Integer
                    i = dgvTipoServicio.CurrentRow.Index
                    txtDescripcionServicio.Text = dgvTipoServicio.Item(2, i).Value()
                    txtMonto.Text = dgvTipoServicio.Item(3, i).Value()
                    dtpVencimiento1.Text = dgvTipoServicio.Item(4, i).Value()
                    dtpVencimiento2.Text = dgvTipoServicio.Item(5, i).Value()


                    'setear componentes con datos del grid
                    txtDescripcionServicio.Enabled = True
                    btnAgregar.Text = "Confirmar"

                    'deshabilitar componentes al modificar
                    ColumnaModificar.Visible = True
                    ColumnaEliminar.Visible = True
                End If

            End If
        End If
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


    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click

        frmInicioAdm.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        frmLogin.Show()
        Me.Close()

    End Sub

    Private Sub txtDescripcionServicio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcionServicio.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtDescripcionServicio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcionServicio.TextChanged

        txtDescripcionServicio.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtDescripcionServicio.Text)
        txtDescripcionServicio.SelectionStart = txtDescripcionServicio.Text.Length

    End Sub
End Class