Public Class frmAdministrarProveedor
    'bandera para saber si modificar un tipo de cuenta o no
    Dim modificarRegistro As Boolean = False
    Dim idProveedorModificar As String = ""

    'columnas del datagrid
    Dim ColumnaEliminar As New DataGridViewButtonColumn
    Dim ColumnaModificar As New DataGridViewButtonColumn

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim ask As MsgBoxResult

        If (txtDescripcionProveedor.Text = String.Empty) Then
            MsgBox("Debe completar el campo descripcion", 0 + 0 + 16, "Error")
        Else
            ask = MsgBox("¿Seguro que desea agregar un nuevo tipo de Servicio?", 4 + 0 + 32, "Agregar")

        End If

        If ask = MsgBoxResult.Yes Then

            If verificar_proveedor() Then

                MsgBox("El proveedor ingresado ya existe", 0 + 0 + 16, "Error")
            Else
                Dim descripcionProveedor As String = txtDescripcionProveedor.Text


                'ASIGNA CUENTA

                If (modificarRegistro = False) Then

                    Dim query As String = "INSERT INTO proveedores(descripcion_proveedor) VALUES('" & descripcionProveedor & "')"
                    ModuloConexion.SQL_Consulta(ModuloConexion.sqlConnection1, query)
                    ModuloConexion.sqlConnection1.Close()

                    actualizar_dtv()

                    MsgBox("El proveedor se ha insertado correctamente", MsgBoxStyle.Information, "Agregar proveedor")

                    clear_all()

                Else
                    'Modificar Cuenta
                    Dim variableAux As MsgBoxResult

                    variableAux = MsgBox("Desea modificar el tipo de servicio id_proveedor: " & idProveedorModificar & "?", 4 + 256 + 32, "Modificacion del tipo de Servicio")
                    If variableAux = MsgBoxResult.Yes Then
                        'consulta al a base de datos
                        Dim query As String = "UPDATE proveedores SET descripcion_proveedor='" & descripcionProveedor & "'  WHERE id_proveedor=" & idProveedorModificar
                        ModuloConexion.SQL_Consulta(ModuloConexion.sqlConnection1, query)
                        ModuloConexion.sqlConnection1.Close()

                        'habilitar componentes
                        ColumnaModificar.Visible = True
                        ColumnaEliminar.Visible = True
                        modificarRegistro = False
                        txtDescripcionProveedor.Enabled = True

                        'actualizar grid
                        actualizar_dtv()
                        MsgBox("Los datos han sido modificados correctamente!", MsgBoxStyle.Information, "Modificar")

                        'limpiar componentes
                        clear_all()
                        btnAgregar.Text = "Agregar"
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub actualizar_dtv()
        dgvProveedores.Visible = False

        'limpiar datagrid
        Try
            dgvProveedores.DataSource = Nothing
            dgvProveedores.Refresh()
            dgvProveedores.Rows.Clear()
            dgvProveedores.Columns.Clear()
        Catch ex As Exception

        End Try

        'cargar datagrid
        ModuloFunciones.FillDataGrid(dgvProveedores, ModuloConexion.source, "SELECT * FROM proveedores")
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

            dgvProveedores.Columns.Add(ColumnaEliminar)
            dgvProveedores.Columns.Add(ColumnaModificar)

            'set font
            dgvProveedores.Columns("descripcion").DefaultCellStyle.Font = New System.Drawing.Font("Verdana", 9.75)

            'cargar datos en las columnas nuevas
            For Each row As DataGridViewRow In dgvProveedor.Rows
                If Not row.IsNewRow Then
                    'set eliminar en el boton
                    row.Cells(ModuloFunciones.GetColName("Eliminar", dgvProveedor)).Value = "Eliminar"
                    row.Cells(ModuloFunciones.GetColName("Modificar", dgvProveedor)).Value = "Modificar"
                End If
            Next
        Catch ex As Exception

        End Try

        'auto ajustar tamaño
        dgvProveedores.AutoResizeColumns()
        dgvProveedores.Visible = True
    End Sub

    Private Sub clear_all()
        txtDescripcionProveedor.Clear()
    End Sub

    Private Sub AgregarTipoServicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        actualizar_dtv()
    End Sub

    Private Sub dgvProveedores_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProveedores.CellContentClick
        Dim ask As MsgBoxResult
        Dim cell As DataGridViewButtonCell = TryCast(dgvProveedores.CurrentCell, DataGridViewButtonCell)
        'Fila actual
        Dim row As DataGridViewRow = dgvProveedores.CurrentRow
        'boton del datagrid
        Dim botonData As DataGridViewButtonColumn = TryCast(dgvProveedores.Columns(e.ColumnIndex), DataGridViewButtonColumn)
        'get descripcion
        Dim descripcion1 As String = ModuloFunciones.GetElementFromGridViewCol("descripcion_proveedor", dgvProveedor)
        If botonData IsNot Nothing Then

            'eliminar
            If Me.dgvProveedores.Columns(e.ColumnIndex).Name = "Eliminar" Then
                ask = MsgBox("Desea eliminar este registro?", 4 + 256 + 32, "Eliminacion de Registro")
                If ask = MsgBoxResult.Yes Then
                    If ModuloFunciones.Existe_proveedor() Then
                        MsgBox("El proveedor esta asociado a un servicio, asegurese de eliminar primero el servicio correspondiente", 0 + 0 + 48, "Advertencia")


                    Else

                        Dim id_proveedor As String = ModuloFunciones.GetElementFromGridViewCol("id_proveedor", dgvProveedores)
                        Dim query As String = "DELETE FROM proveedores WHERE id_proveedor=" & id_proveedor
                        ModuloConexion.SQL_Consulta(sqlConnection1, query)
                        sqlConnection1.Close()
                        actualizar_dtv()
                        MsgBox("El proveedor ha sido eliminado con èxito!", MsgBoxStyle.Information, "Eliminar proveedor")
                    End If
                End If

                'modificar
                If Me.dgvProveedores.Columns(e.ColumnIndex).Name = "Modificar" Then
                    ask = MsgBox("Desea Modificar este registro?", 4 + 256 + 32, "Modificacion de Registro")
                    If ask = MsgBoxResult.Yes Then

                        modificarRegistro = True
                        'recuperar datos del grid
                        idProveedorModificar = ModuloFunciones.GetElementFromGridViewCol("id_proveedor", dgvProveedores)
                        Dim descripcion As String = ModuloFunciones.GetElementFromGridViewCol("descripcion_proveedor", dgvProveedores)

                        'setear componentes con datos del grid
                        txtDescripcionProveedor.Enabled = True
                        btnAgregar.Text = "Confirmar"
                        txtDescripcionProveedor.Text = descripcion

                        'deshabilitar componentes al modificar

                        ColumnaModificar.Visible = False
                        ColumnaEliminar.Visible = False
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub frmAgregarProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actualizar_dtv()
    End Sub

    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        frmInicioAdm.Show()
        Me.Close()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class