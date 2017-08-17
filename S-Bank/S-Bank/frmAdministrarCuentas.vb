Public Class frmAdministrarCuentas
    'bandera para saber si modificar un tipo de cuenta o no
    Dim modificarRegistro As Boolean = False
    Dim idCuentaModificar As String = ""

    'columnas del datagrid
    Dim ColumnaEliminar As New DataGridViewButtonColumn
    Dim ColumnaModificar As New DataGridViewButtonColumn


    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click

        frmInicioAdm.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub dgvCuentas_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCuentas.CellClick

        btnConfirmar.Enabled = True
        Dim i As Integer
        i = dgvCuentas.CurrentRow.Index

        lbltit.Text = dgvCuentas.Item(1, i).Value()
        lblDesc.Text = dgvCuentas.Item(2, i).Value()
        txtSaldo.Text = dgvCuentas.Item(3, i).Value()


    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCuentas.CellContentClick

        Dim ask As MsgBoxResult
        Dim cell As DataGridViewButtonCell = TryCast(dgvCuentas.CurrentCell, DataGridViewButtonCell)
        'Fila actual
        Dim row As DataGridViewRow = dgvCuentas.CurrentRow
        Dim descripcion1 As String = ModuloFunciones.GetElementFromGridViewCol("descripcion_cuenta", dgvCuentas)
        'boton del datagrid
        Dim botonData As DataGridViewButtonColumn = TryCast(dgvCuentas.Columns(e.ColumnIndex), DataGridViewButtonColumn)
       

        If botonData IsNot Nothing Then
            'eliminar

            If Me.dgvCuentas.Columns(e.ColumnIndex).Name = "Eliminar" Then

                ask = MsgBox("Desea eliminar este registro?", 4 + 256 + 32, "Eliminacion de Registro")
                If ask = MsgBoxResult.Yes Then
                    Dim id_cuenta As String = ModuloFunciones.GetElementFromGridViewCol("id_cuenta", dgvCuentas)
                    Dim query As String = "DELETE FROM cuentas WHERE id_cuenta = " & id_cuenta & ""
                    ModuloFunciones.SQL_query(sqlConnection1, query)
                    sqlConnection1.Close()
                    actualizar_dtv()
                    MsgBox("La cuenta ha sido eliminada correctamente", MsgBoxStyle.Information, "Eliminar")

                End If

            End If

            'modificar
            If Me.dgvCuentas.Columns(e.ColumnIndex).Name = "Modificar" Then
                ask = MsgBox("Desea Modificar el registro: " & descripcion1 & "?", 4 + 256 + 32, "Modificacion de Registro")
                If ask = MsgBoxResult.Yes Then

                    modificarRegistro = True
                    'recuperar datos del grid
                    idCuentaModificar = ModuloFunciones.GetElementFromGridViewCol("cod_servicio", dgvCuentas)

                    'setear componentes con datos del grid
                    txtSaldo.Enabled = True
                    cbxTipoCuenta.Enabled = True
                    btnConfirmar.Enabled = True

                    'deshabilitar componentes al modificar
                    ColumnaModificar.Visible = False
                    ColumnaEliminar.Visible = False
                End If

            End If
        End If

    End Sub

    Private Sub frmAdministrarCuentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_S_BankDataSet2.tipoCuenta' Puede moverla o quitarla según sea necesario.
        Me.TipoCuentaTableAdapter.Fill(Me._S_BankDataSet2.tipoCuenta)

        actualizar_dtv()
        txtSaldo.Enabled = False
        cbxTipoCuenta.Enabled = False
        btnConfirmar.Enabled = False

    End Sub



    Private Sub btnAgregarTipoCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarTipoCuenta.Click

        frmNuevoTipoCuentaBancaria.Show()
        Me.Close()

    End Sub


    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        Dim ask As MsgBoxResult


        If (txtSaldo.Text = String.Empty) Then

            MsgBox("Debe completar el campo saldo", 0 + 0 + 16, "Error")

            Else
            ask = MsgBox("¿Seguro que desea modificar esta Cuenta?", 4 + 0 + 32, "Modificar")
        End If

        If ask = MsgBoxResult.Yes Then

            'habilitar componentes
            ColumnaModificar.Visible = True
            ColumnaEliminar.Visible = True
            modificarRegistro = False
            Dim saldo As String = txtSaldo.Text
            Dim tipoCuenta As String = cbxTipoCuenta.Text
            Dim query2 As String = "SELECT id_tipoCuenta FROM tipoCuenta WHERE descripcion_tipoCuenta ='" & tipoCuenta & "'"
            Dim id_tipoCuenta As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query2)
            ModuloConexion.sqlConnection1.Close()


            Dim id_cuenta As String = lblIDCuenta.Text
            Dim query As String = "UPDATE cuentas SET saldo_cuenta='" & saldo & "' WHERE id_cuenta ='" & id_cuenta & "'"
            ModuloConexion.SQL_Consulta(ModuloConexion.sqlConnection1, query)
            ModuloConexion.sqlConnection1.Close()

            'actualizar grid
            actualizar_dtv()
            MsgBox("La cuenta ha sido modificada correctamente", MsgBoxStyle.Information, "Modificar Cuenta")

            'limpiar componentes
            clear_all()
            txtSaldo.Enabled = False
            cbxTipoCuenta.Enabled = False
            btnConfirmar.Enabled = False

        End If

    End Sub

    Private Sub actualizar_dtv()
        dgvCuentas.Visible = False

        'limpiar datagrid
        Try
            dgvCuentas.DataSource = Nothing
            dgvCuentas.Refresh()
            dgvCuentas.Rows.Clear()
            dgvCuentas.Columns.Clear()
        Catch ex As Exception

        End Try

        'cargar datagrid

        'cargar datagrid
        ModuloFunciones.FillDataGrid(dgvCuentas, ModuloConexion.source, "SELECT c.id_cuenta, u.nick_usuario As nombreUsuario, tc.descripcion_tipoCuenta As 'Tipo Cuenta', c.saldo_cuenta As Saldo  FROM cuentas c INNER JOIN tipoCuenta tc ON c.id_tipoCuenta = tc.id_tipoCuenta INNER JOIN usuarios u ON u.id_usuario = c.id_usuario")
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

            dgvCuentas.Columns.Add(ColumnaEliminar)
            dgvCuentas.Columns.Add(ColumnaModificar)

            'set font
            dgvCuentas.Columns("descripcion").DefaultCellStyle.Font = New System.Drawing.Font("Verdana", 9.75)

            'cargar datos en las columnas nuevas
            For Each row As DataGridViewRow In dgvCuentas.Rows
                If Not row.IsNewRow Then
                    'set eliminar en el boton
                    row.Cells(ModuloFunciones.GetColName("Eliminar", dgvCuentas)).Value = "Eliminar"
                    row.Cells(ModuloFunciones.GetColName("Modificar", dgvCuentas)).Value = "Modificar"
                End If
            Next
        Catch ex As Exception

        End Try

        'auto ajustar tamaño
        dgvCuentas.AutoResizeColumns()
        dgvCuentas.Visible = True
    End Sub

    Private Sub clear_all()
        txtSaldo.Clear()
    End Sub

End Class