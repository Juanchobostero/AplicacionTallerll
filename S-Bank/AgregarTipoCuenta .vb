Imports System.Data.SqlClient

Public Class frmNuevoTipoCuentaBancaria
    'bandera para saber si modificar un tipo de cuenta o no
    Dim modificarRegistro As Boolean = False
    Dim idCuentaModificar As String = ""

    'columnas del datagrid
    Dim ColumnaEliminar As New DataGridViewButtonColumn
    Dim ColumnaModificar As New DataGridViewButtonColumn

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim ask As MsgBoxResult

        If (txtNombreCuenta.Text = String.Empty) Then
            MsgBox("Debe completar el campo descripcion", 0 + 0 + 16, "Error")
        Else
            ask = MsgBox("¿Seguro que desea agregar un nuevo tipo de cuenta?", 4 + 0 + 32, "Agregar")

        End If

        If ask = MsgBoxResult.Yes Then

            If verificar_cuenta() Then

                MsgBox("El tipo de cuenta ingresado ya existe", 0 + 0 + 16, "Error")

            Else

                Dim descripcionCuenta As String = txtNombreCuenta.Text


                'ALTA tipoCuenta

                If (modificarRegistro = False) Then

                    Dim query As String = "INSERT INTO tipoCuenta(descripcion_tipoCuenta) VALUES('" & descripcionCuenta & "')"
                    ModuloConexion.SQL_Consulta(ModuloConexion.sqlConnection1, query)
                    ModuloConexion.sqlConnection1.Close()

                    actualizar_dtv()

                    MsgBox("El tipo de Cuenta se ha insertado correctamente", MsgBoxStyle.Information, "Asignacion de Cuenta")

                    clear_all()

                Else
                    'Modificar tipoCuenta
                    Dim variableAux As MsgBoxResult

                    variableAux = MsgBox("Desea modificar el registro: " & idCuentaModificar & "?", 4 + 256 + 32, "Modificacion del tipo de cuenta")
                    If variableAux = MsgBoxResult.Yes Then
                        'consulta al a base de datos
                        Dim query As String = "UPDATE tipoCuenta SET descripcion_tipoCuenta='" & descripcionCuenta & "'  WHERE id_tipoCuenta=" & idCuentaModificar
                        ModuloConexion.SQL_Consulta(ModuloConexion.sqlConnection1, query)
                        ModuloConexion.sqlConnection1.Close()

                        'habilitar componentes
                        ColumnaModificar.Visible = True
                        ColumnaEliminar.Visible = True
                        modificarRegistro = False
                        txtNombreCuenta.Enabled = True

                        'actualizar grid
                        actualizar_dtv()
                        MsgBox("El tipo de cuenta ha sido modificados correctamente!", MsgBoxStyle.Information, "Modificar tipo cuenta")

                        'limpiar componentes
                        clear_all()
                        btnAgregar.Text = "Agregar"

                    Else
                        'limpiar componentes
                        clear_all()
                        btnAgregar.Text = "Agregar"

                        'habilitar componentes
                        ColumnaModificar.Visible = True
                        ColumnaEliminar.Visible = True
                    End If
                End If
            End If
        Else
            'limpiar componentes
            clear_all()
            btnAgregar.Text = "Agregar"

            'habilitar componentes
            ColumnaModificar.Visible = True
            ColumnaEliminar.Visible = True
        End If
    End Sub

    Private Sub txtNombreCuenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombreCuenta.KeyPress
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

    Private Sub clear_all()

        txtNombreCuenta.Clear()

    End Sub

    Private Sub dgvTipoCuentas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTipoCuentas.CellContentClick
        Dim ask As MsgBoxResult
        Dim cell As DataGridViewButtonCell = TryCast(dgvTipoCuentas.CurrentCell, DataGridViewButtonCell)
        'Fila actual
        Dim row As DataGridViewRow = dgvTipoCuentas.CurrentRow
        'boton del datagrid
        Dim botonData As DataGridViewButtonColumn = TryCast(dgvTipoCuentas.Columns(e.ColumnIndex), DataGridViewButtonColumn)
        'get descripcion
        Dim descripcion1 As String = ModuloFunciones.GetElementFromGridViewCol("descripcion_tipoCuenta", dgvTipoCuentas)
        If botonData IsNot Nothing Then
            'eliminar
            If Me.dgvTipoCuentas.Columns(e.ColumnIndex).Name = "Eliminar" Then
                ask = MsgBox("Desea eliminar el registro: " & descripcion1 & "?", 4 + 256 + 32, "Eliminacion de tipo cuenta")

                If ask = MsgBoxResult.Yes Then

                    If ModuloFunciones.ExisteTipoCuenta() Then

                        MsgBox("El tipo de cuenta no se puede eliminar por estar asociado a una o mas cuentas, debe eliminar primero la/s cuenta/s en cuestion y luego volver a intentar", 0 + 0 + 16, "Error")
                    Else
                        Dim id_tipoCuenta As String = ModuloFunciones.GetElementFromGridViewCol("id_tipoCuenta", dgvTipoCuentas)
                        Dim query As String = "DELETE FROM tipoCuenta WHERE id_tipoCuenta=" & id_tipoCuenta
                        ModuloConexion.SQL_Consulta(sqlConnection1, query)
                        sqlConnection1.Close()
                        actualizar_dtv()
                        MsgBox("El tipo de cuenta se ha eliminado correctamente", MsgBoxStyle.Information, "Eliminar")
                    End If
                End If
            End If
            'modificar
            If Me.dgvTipoCuentas.Columns(e.ColumnIndex).Name = "Modificar" Then
                ask = MsgBox("Desea Modificar el el tipo de cuenta: " & descripcion1 & "?", 4 + 256 + 32, "Modificacion de Registro")
                If ask = MsgBoxResult.Yes Then

                    modificarRegistro = True
                    'recuperar datos del grid
                    idCuentaModificar = ModuloFunciones.GetElementFromGridViewCol("id_tipoCuenta", dgvTipoCuentas)
                    Dim descripcion As String = ModuloFunciones.GetElementFromGridViewCol("descripcion_tipoCuenta", dgvTipoCuentas)

                    'setear componentes con datos del grid
                    txtNombreCuenta.Enabled = True
                    btnAgregar.Text = "Confirmar"
                    txtNombreCuenta.Text = descripcion

                    'deshabilitar componentes al modificar

                    ColumnaModificar.Visible = False
                    ColumnaEliminar.Visible = False

                Else

                    'habilitar componentes al modificar
                    ColumnaModificar.Visible = True
                    ColumnaEliminar.Visible = True
                    txtNombreCuenta.Enabled = False
                    clear_all()
                End If

            End If
        End If
    End Sub

    Private Sub actualizar_dtv()
        dgvTipoCuentas.Visible = False

        'limpiar datagrid
        Try
            dgvTipoCuentas.DataSource = Nothing
            dgvTipoCuentas.Refresh()
            dgvTipoCuentas.Rows.Clear()
            dgvTipoCuentas.Columns.Clear()
        Catch ex As Exception

        End Try

        'cargar datagrid
        ModuloFunciones.FillDataGrid(dgvTipoCuentas, ModuloConexion.source, "SELECT * from tipoCuenta")
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

            dgvTipoCuentas.Columns.Add(ColumnaEliminar)
            dgvTipoCuentas.Columns.Add(ColumnaModificar)

            'set font
            dgvTipoCuentas.Columns("descripcion").DefaultCellStyle.Font = New System.Drawing.Font("Verdana", 9.75)

            'cargar datos en las columnas nuevas
            For Each row As DataGridViewRow In dgvTipoCuentas.Rows
                If Not row.IsNewRow Then
                    'set eliminar en el boton
                    row.Cells("Eliminar").Value = "Eliminar"
                    row.Cells("Modificar").Value = "Modificar"
                End If
            Next
        Catch ex As Exception

        End Try

        'auto ajustar tamaño
        dgvTipoCuentas.AutoResizeColumns()
        dgvTipoCuentas.Visible = True


    End Sub

    Private Sub frmNuevoTipoCuentaBancaria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actualizar_dtv()
    End Sub

    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click

        frmAdministrarCuentas.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        frmLogin.Show()
        Me.Close()

    End Sub

    Private Sub txtNombreCuenta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombreCuenta.TextChanged

        txtNombreCuenta.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtNombreCuenta.Text)
        txtNombreCuenta.SelectionStart = txtNombreCuenta.Text.Length

    End Sub
End Class