
Public Class frmRegistro

    'bandera para saber si se eligio modificar registro
    Dim banderaModificacion As Boolean = False



    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
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

    Private Sub txtApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellido.KeyPress
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

    Private Sub txtDNI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNI.KeyPress
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

    Public Sub btnRegistrarse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrarse.Click

        Dim ask As MsgBoxResult
        Dim query As String

        Dim mail As String = txtDireccionDeCorreo.Text

        ask = MsgBox("¿Seguro que desea insertar un nuevo Cliente?", 4 + 0 + 32, "Confirmar Insercion")
        If ask = MsgBoxResult.Yes Then

            Dim nombre As String = txtNombre.Text
            Dim apellido As String = txtApellido.Text
            Dim fechaNac As String = dtpFechaNacimiento.Value.Day & "-" & dtpFechaNacimiento.Value.Month & "-" & dtpFechaNacimiento.Value.Year
            Dim dni As String = txtDNI.Text

            Dim sexo As String
            If rbnHombre.Checked Then
                sexo = "Hombre"
            Else
                sexo = "Mujer"
            End If

            Dim edad As String = txtEdad.Text
            Dim direccion As String = txtDireccion.Text
            Dim telefono As String = txtTelefono.Text

            Dim rol As String = "Cliente"
            Dim nick As String = txtNombreUsuario.Text
            Dim contraseña As String = txtContraseña.Text


            If Not (txtContraseña.Text = txtRepetirContraseña.Text) Then

                MsgBox("Las contraseñas deben coincidir", 0 + 0 + 16, "Error")
                txtRepetirContraseña.BackColor = Color.Red
                txtContraseña.Focus()

            Else

                If Not (rbnHombre.Checked) And Not (rbnMujer.Checked) Then

                    MsgBox("Debe seleccionar el sexo", 0 + 0 + 16, "Error")
                Else


                    'VERIFICAR CAMPOS VACIOS
                    If (txtNombre.Text = String.Empty Or txtApellido.Text = String.Empty Or txtDNI.Text = String.Empty Or txtEdad.Text = String.Empty Or txtDireccion.Text = String.Empty Or txtTelefono.Text = String.Empty Or txtContraseña.Text = String.Empty Or txtRepetirContraseña.Text = String.Empty) Then
                        MsgBox("Debe completar todos los campos obligatorios", 0 + 0 + 16, "Error")
                    Else

                        'VERIFICAR DNI 
                        If ModuloFunciones.verificar_dni() = True Then
                            MsgBox("El DNI ingresado ya existe", 0 + 0 + 48, "Advertencia")
                            txtDNI.BackColor = Color.Red
                            txtDNI.Focus()

                        Else

                            'VERIFICAR EMAIL
                            If ModuloFunciones.ValidarEmail(mail) = False Then

                                MsgBox("Debe especificar un mail correcto", 0 + 0 + 48, "Advertencia")
                                txtDireccionDeCorreo.BackColor = Color.Red
                                txtDireccionDeCorreo.Focus()

                            Else

                                'VERIFICAR NICK DEL USUARIO

                                If ModuloFunciones.existe_nick() Then

                                    MsgBox("El nombre de usuario ingresado no esta disponible, ingrese otro", 0 + 0 + 48, "Advertencia")
                                    txtNombreUsuario.BackColor = Color.Red
                                    txtNombreUsuario.Focus()

                                Else

                                    'VERIFICAR TELEFONO DEL USUARIO
                                    If existe_telefono() Then

                                        MsgBox("El telefono ingresado ya existe, ingrese otro", 0 + 0 + 48, "Advertencia")
                                        txtTelefono.BackColor = Color.Red
                                        txtTelefono.Focus()
                                    Else

                                        'VERIFICAR E-MAIL DEL USUARIO
                                        If existe_mail() Then

                                            MsgBox("El mail ingresado ya existe, ingrese otro", 0 + 0 + 48, "Advertencia")
                                            txtDireccionDeCorreo.BackColor = Color.Red
                                            txtDireccionDeCorreo.Focus()

                                        Else


                                            'ALTA USUARIO

                                            query = "INSERT INTO usuarios(apellido_usuario,nombre_usuario,dni_usuario, fechaNacimiento, direccion_usuario, telefono_usuario, mail_usuario, rol_usuario, edad_usuario, sexo_usuario, nick_usuario, contraseña_usuario) VALUES('" & apellido & "','" & nombre & "','" & dni & "','" & fechaNac & "','" & direccion & "','" & telefono & "','" & mail & "', '" & rol & "' , '" & edad & "', '" & sexo & "', '" & nick & "' , '" & contraseña & "')"

                                            ModuloConexion.SQL_Consulta(ModuloConexion.sqlConnection1, query)
                                            ModuloConexion.sqlConnection1.Close()
                                            MsgBox("El Cliente se dio de alta correctamente", MsgBoxStyle.Information, "Alta usuario")

                                            frmAsignarCuenta.Show()
                                            Me.Close()
                                            clear_all()

                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            End If
        End If
    End Sub

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged

    End Sub

    Public Sub clear_all()
        txtNombre.Clear()
        txtApellido.Clear()
        txtDNI.Clear()
        rbnHombre.Checked() = True
        rbnMujer.Checked() = False
        dtpFechaNacimiento.Value() = "3 / 5 / 1991"
        txtDireccion.Clear()
        txtTelefono.Clear()
        txtContraseña.Clear()
        txtEdad.Clear()
        txtNombreUsuario.Clear()
        txtDireccionDeCorreo.Clear()
        txtRepetirContraseña.Clear()
    End Sub




    Private Sub frmRegistro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click

        frmUsuarios.Show()
        Me.Close()

    End Sub

End Class
