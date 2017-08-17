
Imports System.Data.Sql


Public Class frmUsuarios

    'bandera para saber si se eligio modificar registro
    Public banderaModificacion As Boolean = False

    'id del cliente a modificar
    Public id_cliente_modificar As String = ""

    'columnas del datagrid
    Public colEliminar As New DataGridViewButtonColumn
    Public colModificar As New DataGridViewButtonColumn

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        frmLogin.Show()
        Me.Close()

    End Sub

    Private Sub btnAltaUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAltaUsuario.Click

        frmRegistro.Show()
        Me.Close()

    End Sub

    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click

        frmInicioAdm.Show()
        Me.Close()
    End Sub

    Private Sub dgvUsuarios_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUsuarios.CellClick

        btnConfirmar.Visible = True
        Dim i As Integer
        i = dgvUsuarios.CurrentRow.Index

        lblclave.Text = dgvUsuarios.Item(0, i).Value()
        txtDireccion.Text = dgvUsuarios.Item(5, i).Value()
        txtTelefono.Text = dgvUsuarios.Item(6, i).Value()
        txtContraseña.Text = dgvUsuarios.Item(12, i).Value()
        txtEdad.Text = dgvUsuarios.Item(9, i).Value()
        txtMail.Text = dgvUsuarios.Item(7, i).Value()
        txtNick.Text = dgvUsuarios.Item(11, i).Value()
        txtNom.Text = dgvUsuarios.Item(1, i).Value()
        txtApe.Text = dgvUsuarios.Item(2, i).Value()
        txtDni.Text = dgvUsuarios.Item(3, i).Value()
        dtpFechaNac.Text = dgvUsuarios.Item(4, i).Value()
        btnAsignarOtraCuenta.Enabled = True
        txtSexo.Text = dgvUsuarios.Item(10, i).Value()

    End Sub

    Public Sub dgvUsuarios_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUsuarios.CellContentClick

        Dim ask As MsgBoxResult
        Dim cell As DataGridViewButtonCell = TryCast(dgvUsuarios.CurrentCell, DataGridViewButtonCell)
        'Fila actual
        Dim row As DataGridViewRow = dgvUsuarios.CurrentRow
        'boton del datagrid
        Dim botonData As DataGridViewButtonColumn = TryCast(dgvUsuarios.Columns(e.ColumnIndex), DataGridViewButtonColumn)


        If botonData IsNot Nothing Then
            'eliminar

            If Me.dgvUsuarios.Columns(e.ColumnIndex).Name = "Eliminar" Then

                ask = MsgBox("Desea eliminar el registro ?", 4 + 256 + 32, "Eliminacion de Registro")
                If ask = MsgBoxResult.Yes Then

                    If posee_cuenta() Then

                        MsgBox("El usuario no se puede eliminar por tener una o mas cuenta/s asociada/s", 0 + 0 + 16, "Error")

                    Else

                        Dim id_usuario As String = ModuloFunciones.GetElementFromGridViewCol("id_usuario", dgvUsuarios)
                        Dim query As String = "DELETE FROM usuarios WHERE id_usuario = '" & id_usuario & "'"
                        ModuloFunciones.SQL_query(sqlConnection1, query)
                        sqlConnection1.Close()
                        actualizar_datagrid()
                        MsgBox("El usuario ha sido eliminado correctamente", MsgBoxStyle.Information, "Eliminar")
                        txtApe.Clear()
                        txtContraseña.Clear()
                        txtDireccion.Clear()
                        txtDni.Clear()
                        txtEdad.Clear()
                        txtMail.Clear()
                        txtNick.Clear()
                        txtNom.Clear()
                        txtSexo.Clear()
                        txtTelefono.Clear()
                    End If
                End If

            End If

            If Me.dgvUsuarios.Columns(e.ColumnIndex).Name = "Modificar" Then
                'modificar

                ask = MsgBox("Desea Modificar el registro ?", 4 + 256 + 32, "Modificacion de Registro")
                If ask = MsgBoxResult.Yes Then

                    'Habilitar textbox para modificar los datos
                    'habilitar componentes
                    colModificar.Visible = True
                    colEliminar.Visible = True
                    banderaModificacion = False
                    txtDireccion.Enabled = True
                    txtDni.Enabled = True
                    txtEdad.Enabled = False
                    txtMail.Enabled = True
                    txtNick.Enabled = True
                    txtNom.Enabled = True
                    txtTelefono.Enabled = True
                    txtApe.Enabled = True
                    txtContraseña.Enabled = True
                    btnConfirmar.Enabled = True
                    dtpFechaNac.Enabled = True
                    txtSexo.Enabled = True
                End If
            End If


        End If

    End Sub



    Private Sub actualizar_datagrid()
        dgvUsuarios.Visible = False
        'limpiar datagrid
        Try
            dgvUsuarios.DataSource = Nothing
            dgvUsuarios.Refresh()
            dgvUsuarios.Rows.Clear()
            dgvUsuarios.Columns.Clear()
        Catch ex As Exception

        End Try
        'cargar datagrid
        ModuloFunciones.FillDataGrid(dgvUsuarios, ModuloConexion.source, "SELECT * FROM usuarios")
        Try
            'agregar columnas

            colEliminar.HeaderText = "Eliminar"
            colEliminar.Text = "Eliminar"
            colEliminar.Name = "Eliminar"
            colEliminar.DisplayIndex = 14
            colEliminar.UseColumnTextForButtonValue = True

            colModificar.HeaderText = "Modificar"
            colModificar.Text = "Modificar"
            colModificar.Name = "Modificar"
            colModificar.DisplayIndex = 15
            colModificar.UseColumnTextForButtonValue = True


            dgvUsuarios.Columns.Add(colModificar)
            dgvUsuarios.Columns.Add(colEliminar)

            'cargar datos en las columnas nuevas
            For Each row As DataGridViewRow In dgvUsuarios.Rows
                If Not row.IsNewRow Then

                    'set eliminar en el boton eliminar
                    row.Cells("Eliminar").Value = "Eliminar"
                    row.Cells("Modificar").Value() = "Modificar"

                End If
            Next
        Catch ex As Exception

        End Try

        'auto ajustar tamaño
        dgvUsuarios.AutoResizeColumns()
        dgvUsuarios.Visible = True


    End Sub

 

    Private Sub frmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        actualizar_datagrid()
        btnConfirmar.Enabled = False
        txtDireccion.Enabled = False
        txtDni.Enabled = False
        txtEdad.Enabled = False
        txtMail.Enabled = False
        txtNick.Enabled = False
        dtpFechaNac.Enabled = False
        txtApe.Enabled = False
        txtNom.Enabled = False
        txtSexo.Enabled = False
        txtTelefono.Enabled = False
        txtContraseña.Enabled = False
        btnAsignarOtraCuenta.Enabled = False

    End Sub

 

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        actualizar_datagrid()
    End Sub



    Private Sub txtModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click

        Dim ask As MsgBoxResult

        Dim direccion As String = txtDireccion.Text
        Dim telefono As String = txtTelefono.Text
        Dim contraseña As String = txtContraseña.Text
        Dim apellido As String = txtApe.Text
        Dim nombre As String = txtNom.Text
        Dim mail As String = txtMail.Text
        Dim dni As String = txtDni.Text
        Dim fechaNac As String = dtpFechaNac.Text
        Dim nick As String = txtNick.Text
        Dim edad As String = txtEdad.Text
        Dim sexo As String = txtSexo.Text


        'VERIFICAR CAMPOS VACIOS
        If (txtNick.Text = String.Empty Or txtNom.Text = String.Empty Or txtApe.Text = String.Empty Or txtDni.Text = String.Empty Or txtEdad.Text = String.Empty Or txtDireccion.Text = String.Empty Or txtTelefono.Text = String.Empty Or txtContraseña.Text = String.Empty) Then
            MsgBox("Debe completar todos los campos obligatorios", 0 + 0 + 16, "Error")

        ElseIf ModuloFunciones.ValidarEmail(mail) = False Then

            MsgBox("Debe especificar un mail correcto", 0 + 0 + 48, "Advertencia")
            txtMail.BackColor = Color.Red
            txtMail.Focus()

        Else
            If (txtSexo.Text <> "Hombre") And (txtSexo.Text <> "Mujer") And (txtSexo.Text <> "Mujer ") Then
                MsgBox("Debe ingresar Hombre/Mujer ", 0 + 0 + 48, "Advertencia")
                txtSexo.BackColor = Color.Red
                txtSexo.Focus()
            Else

                ask = MsgBox("¿Seguro que desea modificar este registro?", 4 + 0 + 32, "Confirmar Modificacion")

                If (ask = MsgBoxResult.Yes) Then

                    Dim clave As String = lblclave.Text

                    Dim consulta As String = "UPDATE usuarios SET direccion_usuario='" & direccion & "', telefono_usuario='" & telefono & "', contraseña_usuario='" & contraseña & "', dni_usuario = '" & dni & "', fechaNacimiento = '" & fechaNac & "', edad_usuario = '" & edad & "', sexo_usuario = '" & sexo & "', nick_usuario = '" & nick & "', apellido_usuario = '" & apellido & "', nombre_usuario = '" & nombre & "', mail_usuario = '" & mail & "'  WHERE id_usuario =" & clave & " "
                    ModuloConexion.SQL_Consulta(ModuloConexion.sqlConnection1, consulta)
                    ModuloConexion.sqlConnection1.Close()

                    actualizar_datagrid()
                    MsgBox("El usuario se ha modificado correctamente", MsgBoxStyle.Information, "Modificar")

                    'limpiar componentes
                    clear_all()
                    btnConfirmar.Enabled = False
                    txtApe.Enabled = False
                    txtContraseña.Enabled = False
                    txtDireccion.Enabled = False
                    txtDni.Enabled = False
                    txtEdad.Enabled = False
                    txtMail.Enabled = False
                    txtNick.Enabled = False
                    txtNom.Enabled = False
                    txtSexo.Enabled = False
                    txtTelefono.Enabled = False
                    dtpFechaNac.Enabled = False
                    txtSexo.BackColor = Color.AntiqueWhite
                    txtMail.BackColor = Color.AntiqueWhite
                End If
            End If
        End If
    End Sub

    Private Sub clear_all()

        txtDireccion.Clear()
        txtDni.Clear()
        txtEdad.Clear()
        txtMail.Clear()
        txtNick.Clear()
        txtNom.Clear()
        txtTelefono.Clear()
        txtApe.Clear()
        txtContraseña.Clear()
        txtSexo.Clear()

    End Sub


 
    Private Sub btnAsignarOtraCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignarOtraCuenta.Click

        frmAsignarOtraCuenta.Show()
        Me.Close()
    End Sub

    Private Sub txtDni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDni.KeyPress
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

    Private Sub txtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
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

    Private Sub txtEdad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEdad.KeyPress
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

    Private Sub txtSexo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSexo.KeyPress
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

 
    Private Sub txtDireccion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDireccion.TextChanged

        txtDireccion.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtDireccion.Text)
        txtDireccion.SelectionStart = txtDireccion.Text.Length

    End Sub

    Private Sub txtApe_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtApe.TextChanged

        txtApe.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtApe.Text)
        txtApe.SelectionStart = txtApe.Text.Length

    End Sub

    Private Sub txtNom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNom.TextChanged

        txtNom.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtNom.Text)
        txtNom.SelectionStart = txtNom.Text.Length

    End Sub

    Private Sub txtSexo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSexo.TextChanged

        txtSexo.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtSexo.Text)
        txtSexo.SelectionStart = txtSexo.Text.Length

    End Sub

    Private Sub txtTelefono_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelefono.TextChanged

    End Sub
End Class