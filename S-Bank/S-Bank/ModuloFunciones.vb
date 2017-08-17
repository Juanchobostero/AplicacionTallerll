Imports System.Data.SqlClient

Module ModuloFunciones

    Public Function GetElementFromGridViewCol(ByVal name As String, ByRef dgv As DataGridView) As String
        Dim return_string As String = ""
        Try
            Dim row As DataGridViewRow = dgv.CurrentRow
            return_string = CStr(row.Cells(ModuloFunciones.GetColName(name, dgv)).Value)
        Catch ex As Exception
        End Try
        Return return_string
    End Function


    Public Function GetColName(ByVal name As String, ByRef dgv As DataGridView) As Integer
        Dim retVal As Integer

        For Each col As DataGridViewColumn In dgv.Columns
            If col.HeaderText = name Then
                retVal = col.Index
                Exit For
            End If
        Next

        Return retVal

    End Function


    Public Function SQL_query(ByRef sqlConnection1 As SqlConnection, ByVal query As String)
        Try
            Dim cmd As New SqlCommand
            'Dim reader As SqlDataReader
            cmd.CommandText = query
            cmd.CommandType = CommandType.Text
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            Return cmd.ExecuteReader()
        Catch exx As SqlException
            MsgBox(exx.ToString, MsgBoxStyle.Information, "SQL ERROR")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, "ERROR")
        End Try


    End Function


    Public Function FillDataGrid(ByRef grid As DataGridView, ByVal Source As String, ByVal query As String)
        Try
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim ds As New DataSet
            DBConn = New SqlConnection(Source)
            DBCommand = New SqlDataAdapter(query, DBConn)
            DBCommand.Fill(ds)
            grid.DataSource = ds.Tables(0)

            DBCommand.Dispose()
            DBConn.Dispose()
            DBConn.Close()
        Catch exx As SqlException
            MsgBox(exx.ToString, MsgBoxStyle.Information, "SQL ERROR")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, "ERROR")

        End Try


    End Function

    Public Function verificar_dni() As Boolean

        Dim DNI As String = frmRegistro.txtDNI.Text
        Dim consultaDNI As String = "SELECT dni_usuario FROM usuarios WHERE dni_usuario = " & DNI & ""
        Dim dni2 As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, consultaDNI)
        ModuloConexion.sqlConnection1.Close()
        If (dni2 = String.Empty) Then
            Return False
        Else
            Return True
        End If


    End Function

    Function ValidarEmail(ByVal email As String) As Boolean
        Dim emailRegex As New System.Text.RegularExpressions.Regex(
            "^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As System.Text.RegularExpressions.Match =
           emailRegex.Match(email)
        Return emailMatch.Success
    End Function

  

    Public Function posee_cuenta() As Boolean

        Dim id_usuario As String = ModuloFunciones.GetElementFromGridViewCol("id_usuario", frmUsuarios.dgvUsuarios)
        Dim consultaCuenta As String = "SELECT id_usuario FROM cuentas WHERE id_usuario = " & id_usuario & ""
        Dim id_usuario2 As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, consultaCuenta)
        ModuloConexion.sqlConnection1.Close()

        If (id_usuario2 = String.Empty) Then

            Return False
        Else
            Return True

        End If

    End Function

    Public Function verificar_proveedor() As Boolean

        Dim descripcionProveedor As String = frmAdministrarProveedor.txtDescripcionProveedor.Text
        Dim consultaProveedor As String = "SELECT descripcion_proveedor FROM proveedores WHERE descripcion_proveedor = '" & descripcionProveedor & "'"
        Dim consultaProveedor2 As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, consultaProveedor)
        ModuloConexion.sqlConnection1.Close()
        If (consultaProveedor2 = String.Empty) Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function verificar_cuenta() As Boolean

        Dim descripcionTipoCuenta As String = frmNuevoTipoCuentaBancaria.txtNombreCuenta.Text
        Dim consultaCuenta As String = "SELECT descripcion_tipoCuenta FROM tipoCuenta WHERE descripcion_tipoCuenta = '" & descripcionTipoCuenta & "'"
        Dim consultaCuenta2 As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, consultaCuenta)
        ModuloConexion.sqlConnection1.Close()
        If (consultaCuenta2 = String.Empty) Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function existe_nick() As Boolean

        Dim nick_ingresado As String = frmRegistro.txtNombreUsuario.Text
        Dim consultaNick As String = "SELECT nick_usuario FROM usuarios WHERE nick_usuario = '" & nick_ingresado & "'"
        Dim nick As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, consultaNick)
        ModuloConexion.sqlConnection1.Close()

        If (nick = String.Empty) Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function existe_cuenta() As Boolean
        Dim descripCuenta As String = frmAsignarCuenta.cbTipoCuenta.Text
        Dim query As String = "SELECT id_tipoCuenta FROM tipoCuenta WHERE descripcion_tipoCuenta= '" & descripCuenta & "'"
        Dim id_tipoCuenta As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query)
        ModuloConexion.sqlConnection1.Close()
        Dim consultaCuenta As String = "SELECT id_tipoCuenta FROM cuentas WHERE id_tipoCuenta= '" & id_tipoCuenta & "'"
        Dim existeCuenta As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, consultaCuenta)
        ModuloConexion.sqlConnection1.Close()

        If (existeCuenta = String.Empty) Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function existe_usuario() As Boolean
        Dim nick_ingresado As String = frmLogin.txtNombre.Text
        Dim consultaNick As String = "SELECT nick_usuario FROM usuarios WHERE nick_usuario = '" & nick_ingresado & "'"
        Dim nick As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, consultaNick)
        ModuloConexion.sqlConnection1.Close()

        If (nick = String.Empty) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function existe_contraseña() As Boolean
        Dim contraseña_ingresada As String = frmLogin.txtContraseña.Text
        Dim consultaNick As String = "SELECT contraseña_usuario FROM usuarios WHERE nick_usuario = '" & contraseña_ingresada & "'"
        Dim nick As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, consultaNick)
        ModuloConexion.sqlConnection1.Close()

        If (nick = String.Empty) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function existe_telefono() As Boolean

        Dim tel As String = frmRegistro.txtTelefono.Text
        Dim consulta As String = "SELECT telefono_usuario FROM usuarios WHERE telefono_usuario = '" & tel & "'"
        Dim consultaTel As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, consulta)
        ModuloConexion.sqlConnection1.Close()

        If (consultaTel = String.Empty) Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function existe_mail() As Boolean

        Dim mail As String = frmRegistro.txtDireccionDeCorreo.Text
        Dim consulta As String = "SELECT mail_usuario FROM usuarios WHERE mail_usuario = '" & mail & "'"
        Dim consultaMail As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, consulta)
        ModuloConexion.sqlConnection1.Close()

        If consultaMail = String.Empty Then

            Return False
        Else
            Return True
        End If
    End Function
End Module
