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

    Public Function ValidarEmail(ByVal email As String) As Boolean
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
        Dim descripCuenta As String = frmAsignarCuenta.cbxTipoCuenta.Text
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
            Return False
        Else
            Return True
        End If
    End Function

    Public Function existe_contraseña() As Boolean
        Dim contraseña_ingresada As String = frmLogin.txtContraseña.Text
        Dim consultaNick As String = "SELECT contraseña_usuario FROM usuarios WHERE contraseña_usuario = '" & contraseña_ingresada & "'"
        Dim nick As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, consultaNick)
        ModuloConexion.sqlConnection1.Close()

        If (nick = String.Empty) Then
            Return False
        Else
            Return True
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

    Public Function ExisteTipoCuenta() As Boolean

        Dim id_tipoCuenta As String = ModuloFunciones.GetElementFromGridViewCol("id_tipoCuenta", frmNuevoTipoCuentaBancaria.dgvTipoCuentas)
        Dim consulta As String = "SELECT id_tipoCuenta FROM cuentas WHERE id_tipoCuenta = '" & id_tipoCuenta & "'"
        Dim traerValor As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, consulta)
        ModuloConexion.sqlConnection1.Close()

        If traerValor = String.Empty Then
            Return False

        Else
            Return True
        End If

    End Function

    Public Function Existe_proveedor() As Boolean

        Dim id_proveedor As String = ModuloFunciones.GetElementFromGridViewCol("id_proveedor", frmAdministrarProveedor.dgvProveedores)
        Dim consultaProv As String = "SELECT id_proveedor FROM Servicios WHERE id_proveedor = '" & id_proveedor & "'"
        Dim traerProv As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, consultaProv)
        ModuloConexion.sqlConnection1.Close()

        If traerProv = String.Empty Then
            Return False
        Else
            Return True
        End If
    End Function

    '***********************COMBOBOX CATEGORIA DE PRODUCTO **********************************
    Public Function CargaComboBoxCuentasAsociadas(ByVal comboBox As ComboBox, ByVal IDusuario As Integer) As Boolean
        Dim conectar As New System.Data.SqlClient.SqlConnection(ModuloConexion.source)
        Dim cmsql As New System.Data.SqlClient.SqlCommand
        Dim sql As String

        Try

            sql = "SELECT tc.descripcion_tipoCuenta FROM tipoCuenta tc INNER JOIN cuentas c ON tc.id_tipoCuenta = c.id_tipoCuenta INNER JOIN usuarios u ON u.id_usuario = c.id_usuario WHERE u.id_usuario  = '" & IDusuario & "'"
            conectar.Open()
            cmsql = New SqlCommand(sql, conectar)
            Dim da As New SqlDataAdapter(cmsql)
            'crear y llenar el dateSet
            Dim ds As New DataSet
            da.Fill(ds)
            'asignar el dataSources al comboBox
            comboBox.DataSource = ds.Tables(0)
            'asignar el campo a la propiedad DisplayMembre y el ValueMembre del comboBox
            comboBox.DisplayMember = ds.Tables(0).Columns(0).Caption.ToString
            comboBox.ValueMember = ds.Tables(0).Columns(0).Caption

            ' Close and Clean up objects
            conectar.Close()
            cmsql.Dispose()
            conectar.Dispose()
            'Me.Dispose()

            Return True

        Catch Exp As SqlException
            MsgBox(Exp.Message, MsgBoxStyle.Critical, "SQL Error")
            conectar.Close()
            Return False
        Catch Exp As Exception
            MsgBox(Exp.Message, MsgBoxStyle.Critical, "General Error")
            Return False

        End Try
    End Function

    Public Function CargarComboBoxServicios(ByVal comboBox As ComboBox) As Boolean
        Dim conectar As New System.Data.SqlClient.SqlConnection(ModuloConexion.source)
        Dim cmsql As New System.Data.SqlClient.SqlCommand
        Dim sql As String

        Try

            sql = "SELECT descripcion_servicio FROM Servicios"
            conectar.Open()
            cmsql = New SqlCommand(sql, conectar)
            Dim da As New SqlDataAdapter(cmsql)
            'crear y llenar el dateSet
            Dim ds As New DataSet
            da.Fill(ds)
            'asignar el dataSources al comboBox
            comboBox.DataSource = ds.Tables(0)
            'asignar el campo a la propiedad DisplayMembre y el ValueMembre del comboBox
            comboBox.DisplayMember = ds.Tables(0).Columns(0).Caption.ToString
            comboBox.ValueMember = ds.Tables(0).Columns(0).Caption

            ' Close and Clean up objects
            conectar.Close()
            cmsql.Dispose()
            conectar.Dispose()
            'Me.Dispose()

            Return True

        Catch Exp As SqlException
            MsgBox(Exp.Message, MsgBoxStyle.Critical, "SQL Error")
            conectar.Close()
            Return False
        Catch Exp As Exception
            MsgBox(Exp.Message, MsgBoxStyle.Critical, "General Error")
            Return False

        End Try
    End Function

    Public Function CargarComboBoxProveedores(ByVal comboBox As ComboBox) As Boolean
        Dim conectar As New System.Data.SqlClient.SqlConnection(ModuloConexion.source)
        Dim cmsql As New System.Data.SqlClient.SqlCommand
        Dim sql As String

        Try

            sql = "SELECT descripcion_proveedor FROM proveedores"
            conectar.Open()
            cmsql = New SqlCommand(sql, conectar)
            Dim da As New SqlDataAdapter(cmsql)
            'crear y llenar el dateSet
            Dim ds As New DataSet
            da.Fill(ds)
            'asignar el dataSources al comboBox
            comboBox.DataSource = ds.Tables(0)
            'asignar el campo a la propiedad DisplayMembre y el ValueMembre del comboBox
            comboBox.DisplayMember = ds.Tables(0).Columns(0).Caption.ToString
            comboBox.ValueMember = ds.Tables(0).Columns(0).Caption

            ' Close and Clean up objects
            conectar.Close()
            cmsql.Dispose()
            conectar.Dispose()
            'Me.Dispose()

            Return True

        Catch Exp As SqlException
            MsgBox(Exp.Message, MsgBoxStyle.Critical, "SQL Error")
            conectar.Close()
            Return False
        Catch Exp As Exception
            MsgBox(Exp.Message, MsgBoxStyle.Critical, "General Error")
            Return False

        End Try
    End Function

    Public Function CargarComboBoxTipoCuentas(ByVal comboBox As ComboBox) As Boolean
        Dim conectar As New System.Data.SqlClient.SqlConnection(ModuloConexion.source)
        Dim cmsql As New System.Data.SqlClient.SqlCommand
        Dim sql As String

        Try

            sql = "SELECT descripcion_tipoCuenta FROM tipoCuenta"
            conectar.Open()
            cmsql = New SqlCommand(sql, conectar)
            Dim da As New SqlDataAdapter(cmsql)
            'crear y llenar el dateSet
            Dim ds As New DataSet
            da.Fill(ds)
            'asignar el dataSources al comboBox
            comboBox.DataSource = ds.Tables(0)
            'asignar el campo a la propiedad DisplayMembre y el ValueMembre del comboBox
            comboBox.DisplayMember = ds.Tables(0).Columns(0).Caption.ToString
            comboBox.ValueMember = ds.Tables(0).Columns(0).Caption

            ' Close and Clean up objects
            conectar.Close()
            cmsql.Dispose()
            conectar.Dispose()
            'Me.Dispose()

            Return True

        Catch Exp As SqlException
            MsgBox(Exp.Message, MsgBoxStyle.Critical, "SQL Error")
            conectar.Close()
            Return False
        Catch Exp As Exception
            MsgBox(Exp.Message, MsgBoxStyle.Critical, "General Error")
            Return False

        End Try
    End Function

    Public Function verificarServicio()
        If frmPagarServicios.cbxServicios.Text = ModuloFunciones.GetElementFromGridViewCol("Servicio", frmPagarServicios.dgvDetalle) Then
            Return True
        End If

    End Function

    Public Function consultarSaldo()

        Dim cuenta As String = frmPagarServicios.cbxCuentasAsociadas.Text
        Dim nickUsuario As String = frmPagarServicios.lblNomUsuario.Text
        Dim total As Integer = frmPagarServicios.lblTotal.Text
        Dim query As String = "SELECT saldo_cuenta FROM cuentas c INNER JOIN tipoCuenta tc ON c.id_tipoCuenta = tc.id_tipoCuenta INNER JOIN usuarios u ON u.id_usuario = c.id_usuario WHERE tc.descripcion_tipoCuenta='" & cuenta & "' and u.nick_usuario ='" & nickUsuario & "'"
        Dim saldo As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query)
        ModuloConexion.sqlConnection1.Close()
        If saldo < total Then
            Return True
        End If
    End Function

    Public Function comprobarSiHayServiciosCargadosAlMomentoDePagar()
        If frmPagarServicios.dgvDetalle.RowCount() = 0 Then
            Return True
        End If
    End Function

    Public Function existeCuentaEnMovimiento() As Boolean

        'Extraer id_tipoCuenta
        Dim nombreCuenta As String = frmAdministrarCuentas.lblDesc.Text
        Dim consulta1 As String = "SELECT id_tipoCuenta FROM tipoCuenta WHERE descripcion_tipoCuenta = '" & nombreCuenta & "'"
        Dim id_tipoCuenta As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, consulta1)
        ModuloConexion.sqlConnection1.Close()

        'Extraer id de la cuenta 
        Dim consulta2 As String = "SELECT id_cuenta FROM cuentas WHERE id_tipoCuenta = " & id_tipoCuenta & ""
        Dim id_cuenta As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, consulta2)
        ModuloConexion.sqlConnection1.Close()

        'verificar si la cuenta existe en la tabla movimientos
        Dim consulta3 As String = "SELECT id_cuenta FROM movimientos WHERE id_cuenta = " & id_cuenta & ""
        Dim valor As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, consulta3)
        ModuloConexion.sqlConnection1.Close()

        If valor = String.Empty Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function existeCuentaEnFactura() As Boolean

        'extraer id del tipo de cuenta 
        Dim descrip As String = frmAdministrarCuentas.lblDesc.Text
        Dim consulta_cuenta As String = "SELECT id_tipoCuenta FROM tipoCuenta WHERE  descripcion_tipoCuenta = '" & descrip & "'"
        Dim id_tipo As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, consulta_cuenta)
        ModuloConexion.sqlConnection1.Close()

        'a partir del id tipo cuenta, extraer el id de la cuenta para verificarla si se encuentra o no en Factura
        Dim consulta_id As String = "SELECT id_cuenta FROM cuentas WHERE id_tipoCuenta = " & id_tipo & ""
        Dim id_cuen As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, consulta_id)
        ModuloConexion.sqlConnection1.Close()

        'Verificar si el id_cuenta existe en Factura
        Dim consultaEnFactura As String = "SELECT id_cuenta FROM Factura WHERE id_cuenta = " & id_cuen & ""
        Dim valorCuen As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, consultaEnFactura)
        ModuloConexion.sqlConnection1.Close()

        'Verificar si la consulta devolvio algun valor
        If (valorCuen = String.Empty) Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function existeFacturaEnDetalleServicio() As Boolean

        Dim id_factura As Integer = frmVerFacturas.lblFacturaID.Text

        Dim consultaFactura As String = "SELECT id_factura FROM detalleServicios WHERE id_factura = " & id_factura & ""
        Dim valor As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, consultaFactura)
        ModuloConexion.sqlConnection1.Close()

        If valor = String.Empty Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function existeServicioEnDetalle() As Boolean

        'Extraer codigo del servicio que va ser verificado
        Dim descripcionServicio As String = frmAdministrarServicios.txtDescripcionServicio.Text
        Dim consultaServicio As String = "SELECT cod_servicio FROM Servicios WHERE descripcion_servicio = '" & descripcionServicio & "'"
        Dim cod_servicio As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, consultaServicio)
        ModuloConexion.sqlConnection1.Close()

        'Verificar si el codigo de servicio existe en la tabla detalleServicios

        Dim consultaCodigo As String = "SELECT cod_servicio FROM detalleServicios WHERE cod_servicio = " & cod_servicio & ""
        Dim valorCodigo As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, consultaCodigo)
        ModuloConexion.sqlConnection1.Close()

        If valorCodigo = String.Empty Then
            Return False
        Else
            Return True

        End If
    End Function

    Public Function existeDetalleEnMovimiento() As Boolean

        Dim id_detalle As Integer = frmVerFacturas.id_Detalle1

        Dim consultaDetalle As String = "SELECT id_detalleServicio FROM movimientos WHERE id_detalleServicio = " & id_detalle & ""
        Dim valorDetalle As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, consultaDetalle)
        ModuloConexion.sqlConnection1.Close()

        If valorDetalle = String.Empty Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function verificarPeriodo()
        Dim periodoPago As String = frmPagarServicios.dtpPeriodoPago.Text
        Dim nombreUsuario As String = frmPagarServicios.lblNomUsuario.Text
        Dim descripcionServ As String = frmPagarServicios.cbxCuentasAsociadas.Text

        Dim query5 As String = "SELECT id_usuario FROM usuarios WHERE nick_usuario ='" & nombreUsuario & "'"
        Dim id_us As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query5)
        ModuloConexion.sqlConnection1.Close()

        Dim query As String = "SELECT periodoPago FROM Factura WHERE periodoPago='" & periodoPago & "' and id_usuario ='" & id_us & "' and "
        Dim periodoP As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query)
        ModuloConexion.sqlConnection1.Close()


        If periodoP = String.Empty Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function verificarTipoCuenta()
        Dim cuenta As String = frmAsignarCuenta.cbxTipoCuenta.Text

        Dim query As String = "SELECT MAX(id_usuario) FROM usuarios"
        Dim IDUsuario As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query)
        ModuloConexion.sqlConnection1.Close()

        Dim query2 As String = "SELECT tc.descripcion_tipoCuenta FROM tipoCuenta tc INNER JOIN cuentas c ON c.id_tipoCuenta = tc.id_tipoCuenta WHERE c.id_usuario ='" & IDUsuario & "' and tc.descripcion_tipoCuenta ='" & cuenta & "'"
        Dim descTC As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query2)
        ModuloConexion.sqlConnection1.Close()

        Dim descripcionTC As String = frmAsignarCuenta.cbxTipoCuenta.Text

        If descripcionTC = descTC Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function verificarTipoCuenta2()
        Dim nick As String = frmAsignarOtraCuenta.lblTit.Text
        Dim cuenta As String = frmAsignarOtraCuenta.cbxTipoDeCuenta.Text

        Dim query2 As String = "SELECT tc.descripcion_tipoCuenta FROM tipoCuenta tc INNER JOIN cuentas c ON c.id_tipoCuenta = tc.id_tipoCuenta INNER JOIN usuarios u ON u.id_usuario = c.id_usuario WHERE u.nick_usuario ='" & nick & "' and tc.descripcion_tipoCuenta ='" & cuenta & "'"
        Dim descTC As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query2)
        ModuloConexion.sqlConnection1.Close()

        Dim descripcionTC As String = frmAsignarOtraCuenta.cbxTipoDeCuenta.Text

        If descripcionTC = descTC Then
            Return True
        Else
            Return False
        End If
    End Function


End Module
