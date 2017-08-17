Public Class frmPagarServicios

    Public banderaPS As Integer = 0
    Public Tabla As New DataTable 'se crea la tabla

    'variables
    Public total As Single = 0
    Public precioUnitario As Single = 0

    'SE DEFINE LA ESTRUCTURA
    Structure servicio
        Dim tipoServicio As String
        Dim nombreProveedor As String
        Dim precio As String
    End Structure

    Public servicios(50) As servicio 'el array

    Dim nombreUsuario As String = frmFormUsuario.lblNomUsuario.Text

    Private Sub frmPagarServicios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        banderaPS = 1

        btnEliminar.Enabled = False
        btnBorrarDetalle.Enabled = False
        Dim nombreUsuario As String = frmFormUsuario.lblNomUsuario.Text
        lblPeriodoYEAR.Text = "2014"
        cbxPeriodoMes.SelectedIndex = 0
        Dim nick2 As String = frmVerFacturasUsuario.lblNomUsuario.Text

        'Set fecha de pago
        dtpFechaPago.Text = Date.Now.Date

        If frmVerFacturasUsuario.banderaVF = 1 Then
            nombreUsuario = nick2

            Dim query As String = "SELECT nombre_usuario FROM usuarios  WHERE nick_usuario = '" & nombreUsuario & "'"
            Dim nombre As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query)
            ModuloConexion.sqlConnection1.Close()

            Dim query2 As String = "SELECT apellido_usuario FROM usuarios  WHERE nick_usuario = '" & nombreUsuario & "'"
            Dim apellido As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query2)
            ModuloConexion.sqlConnection1.Close()

            Dim query3 As String = "SELECT nick_usuario FROM usuarios  WHERE nick_usuario = '" & nombreUsuario & "'"
            Dim nick As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query3)
            ModuloConexion.sqlConnection1.Close()

            Dim query4 As String = "SELECT id_usuario FROM usuarios  WHERE nick_usuario = '" & nombreUsuario & "'"
            Dim IDusuario As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query4)
            ModuloConexion.sqlConnection1.Close()



            'Datos de la sesion
            lblapeYnom.Text = nombre + " " + apellido
            lblNomUsuario.Text = nick

            'Definimos las columnas de las tablas
            Tabla.Columns.Add("Tipo de Servicio", System.Type.GetType("System.String")) '0
            '**********************************************************************
            Tabla.Columns.Add("Proveedor", System.Type.GetType("System.String")) '1
            Tabla.Columns.Add("Precio $", System.Type.GetType("System.String")) '2

            lblTotal.Text = 0


            'Precio por cada servicio seleccionado
            Dim tipoServ As String = cbxServicios.Text

            Dim query5 As String = "SELECT monto_servicio FROM Servicios WHERE descripcion_servicio ='" & tipoServ & "'"
            Dim monto_servicio As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query5)
            ModuloConexion.sqlConnection1.Close()

            If tipoServ = cbxServicios.Text Then
                lblPrecio.Text = monto_servicio
                precioUnitario = monto_servicio
            End If
            '************************************

            'Saldo de la Cuenta seleccionada del usuario en sesion
            Dim tipoCuenta As String = cbxCuentasAsociadas.Text

            Dim query6 As String = "SELECT c.saldo_cuenta FROM cuentas c INNER JOIN tipoCuenta tc ON tc.id_tipoCuenta = c.id_tipoCuenta WHERE c.id_usuario = '" & IDusuario & "' and tc.descripcion_tipoCuenta='" & tipoCuenta & "'"
            Dim saldoCuenta As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query6)
            ModuloConexion.sqlConnection1.Close()

            If tipoCuenta = cbxCuentasAsociadas.Text Then
                lblSaldo.Text = saldoCuenta
            End If
            '*******************************************


            'cargar comboBox con las cuentas asociadas al usuario en sesion
            ModuloFunciones.CargaComboBoxCuentasAsociadas(cbxCuentasAsociadas, IDusuario)

            'cargar comboBox con los servicios disponibles
            ModuloFunciones.CargarComboBoxServicios(cbxServicios)


        Else

            Dim query As String = "SELECT nombre_usuario FROM usuarios  WHERE nick_usuario = '" & nombreUsuario & "'"
            Dim nombre As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query)
            ModuloConexion.sqlConnection1.Close()

            Dim query2 As String = "SELECT apellido_usuario FROM usuarios  WHERE nick_usuario = '" & nombreUsuario & "'"
            Dim apellido As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query2)
            ModuloConexion.sqlConnection1.Close()

            Dim query3 As String = "SELECT nick_usuario FROM usuarios  WHERE nick_usuario = '" & nombreUsuario & "'"
            Dim nick As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query3)
            ModuloConexion.sqlConnection1.Close()

            Dim query4 As String = "SELECT id_usuario FROM usuarios  WHERE nick_usuario = '" & nombreUsuario & "'"
            Dim IDusuario As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query4)
            ModuloConexion.sqlConnection1.Close()



            'Datos de la sesion
            lblapeYnom.Text = nombre + " " + apellido
            lblNomUsuario.Text = nick

            'Definimos las columnas de las tablas
            Tabla.Columns.Add("Tipo de Servicio", System.Type.GetType("System.String")) '0
            '**********************************************************************
            Tabla.Columns.Add("Proveedor", System.Type.GetType("System.String")) '1
            Tabla.Columns.Add("Precio $", System.Type.GetType("System.String")) '2

            lblTotal.Text = 0


            'Precio por cada servicio seleccionado
            Dim tipoServ As String = cbxServicios.Text

            Dim query5 As String = "SELECT monto_servicio FROM Servicios WHERE descripcion_servicio ='" & tipoServ & "'"
            Dim monto_servicio As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query5)
            ModuloConexion.sqlConnection1.Close()

            If tipoServ = cbxServicios.Text Then
                lblPrecio.Text = monto_servicio
                precioUnitario = monto_servicio
            End If
            '************************************

            'Saldo de la Cuenta seleccionada del usuario en sesion
            Dim tipoCuenta As String = cbxCuentasAsociadas.Text

            Dim query6 As String = "SELECT c.saldo_cuenta FROM cuentas c INNER JOIN tipoCuenta tc ON tc.id_tipoCuenta = c.id_tipoCuenta WHERE c.id_usuario = '" & IDusuario & "' and tc.descripcion_tipoCuenta='" & tipoCuenta & "'"
            Dim saldoCuenta As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query6)
            ModuloConexion.sqlConnection1.Close()

            If tipoCuenta = cbxCuentasAsociadas.Text Then
                lblSaldo.Text = saldoCuenta
            End If
            '*******************************************


            'cargar comboBox con las cuentas asociadas al usuario en sesion
            ModuloFunciones.CargaComboBoxCuentasAsociadas(cbxCuentasAsociadas, IDusuario)

            'cargar comboBox con los servicios disponibles
            ModuloFunciones.CargarComboBoxServicios(cbxServicios)

        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Se resta al total el precio del servicio a eliminar del detalle
        total = total - dgvDetalle.Item(2, dgvDetalle.CurrentRow.Index).Value.ToString()
        lblTotal.Text = total

        dgvDetalle.Rows.RemoveAt(dgvDetalle.CurrentRow.Index) 'ELIMINA SOLO EL ELEMENTO QUE ESTA SELECCIONADO EN EL GRIDDETALLE
        dgvDetalle.Refresh() 'REFRESCA PARA VER LOS DATOS UNA VEZ ELIMINADO UN ELEMNTO


    End Sub

    Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        btnBorrarDetalle.Enabled = True
        btnEliminar.Enabled = True
        Dim ask As MsgBoxResult
        ask = MsgBox("¿Seguro que desea agregar este Servicio?", 4 + 0 + 32, "Agregar")

        If ask = MsgBoxResult.Yes Then

            btnEliminar.Enabled = True
            Dim tipoServ As String = cbxServicios.Text

            Dim query4 As String = "SELECT monto_servicio FROM Servicios WHERE descripcion_servicio ='" & tipoServ & "'"
            Dim monto_servicio As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query4)
            ModuloConexion.sqlConnection1.Close()


            Dim query3 As String = "SELECT descripcion_proveedor FROM proveedores p INNER JOIN Servicios s ON p.id_proveedor = s.id_proveedor WHERE descripcion_servicio = '" & tipoServ & "'"
            Dim desc_prov As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query3)
            ModuloConexion.sqlConnection1.Close()




            'Se carga la estructura
            servicios(0).tipoServicio = cbxServicios.Text
            servicios(0).nombreProveedor = desc_prov
            servicios(0).precio = monto_servicio


            Tabla.Rows.Add(servicios(0).tipoServicio, servicios(0).nombreProveedor, servicios(0).precio)
            'Se Carga el producto al DataGrid
            dgvDetalle.DataSource = Tabla
            total = precioUnitario + total
            lblTotal.Text = total
            MsgBox("El servicio ha sido agregado correctamente", MsgBoxStyle.Information, "Agregar Servicio")
        Else
            Me.Show()
        End If
    End Sub


    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        frmFormUsuario.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub btnEliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        'Se resta al total el precio del servicio a eliminar del detalle
        total = total - dgvDetalle.Item(2, dgvDetalle.CurrentRow.Index).Value.ToString()
        lblTotal.Text = total

        dgvDetalle.Rows.RemoveAt(dgvDetalle.CurrentRow.Index) 'Elimina elemento seleccionado
        dgvDetalle.Refresh() 'Actualiza el grid

        'Verificar que no haya mas detalles por eliminar del datagrid, y de ser asi, bloquear el boton
        If dgvDetalle.RowCount = 0 Then
            btnEliminar.Enabled = False
            btnBorrarDetalle.Enabled = False
        End If

    End Sub

    Private Sub btnCargar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargar.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("¿Seguro que desea agregar este Servicio?", 4 + 0 + 32, "Agregar")
        If ModuloFunciones.verificarServicio() Then
            MsgBox("El servicio ingresado ha sido agregado anteriormente, asegurese de no ingresar el mismo servicio", 0 + 0 + 48, "Advertencia")

        ElseIf ask = MsgBoxResult.Yes Then
            btnBorrarDetalle.Enabled = True
            btnEliminar.Enabled = True
            Dim tipoServ As String = cbxServicios.Text

            Dim query4 As String = "SELECT monto_servicio FROM Servicios WHERE descripcion_servicio ='" & tipoServ & "'"
            Dim monto_servicio As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query4)
            ModuloConexion.sqlConnection1.Close()


            Dim query3 As String = "SELECT descripcion_proveedor FROM proveedores p INNER JOIN Servicios s ON p.id_proveedor = s.id_proveedor WHERE descripcion_servicio = '" & tipoServ & "'"
            Dim desc_prov As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query3)
            ModuloConexion.sqlConnection1.Close()


            'Se carga la estructura
            servicios(0).tipoServicio = tipoServ
            servicios(0).nombreProveedor = desc_prov
            servicios(0).precio = monto_servicio


            Tabla.Rows.Add(servicios(0).tipoServicio, servicios(0).nombreProveedor, servicios(0).precio)
            'Se Carga el servicio al DataGrid
            dgvDetalle.DataSource = Tabla
            total = monto_servicio + total
            lblTotal.Text = total
            MsgBox("El servicio ha sido agregado correctamente", MsgBoxStyle.Information, "Agregar Servicio")
        Else
            Me.Show()
        End If
    End Sub


    Private Sub btnBorrarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarDetalle.Click
        Tabla.Clear() 'BORRO TODO EL DETALLE
        total = 0
        precioUnitario = 0
        lblTotal.Text = 0
        btnEliminar.Enabled = False
        btnBorrarDetalle.Enabled = False
    End Sub

    Private Sub btnPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagar.Click
        Dim ask As String


        If ModuloFunciones.comprobarSiHayServiciosCargadosAlMomentoDePagar() Then
            MsgBox("Asegurese de ingresar al menos un servicios para realizar un pago", +0 + 0 + 16, "Error")

        Else
            ask = MsgBox("¿Seguro que desea efectuar el pago?", 4 + 0 + 32, "Confirmar Pago")
            If ask = MsgBoxResult.Yes Then

                If ModuloFunciones.consultarSaldo() Then
                    MsgBox("Saldo Insuficiente", 0 + 0 + 48, "Advertencia")

                    'ElseIf ModuloDetalle.RecorrerDetalle2() Then
                    '    MsgBox("El periodo a pagar ya sido abonado anteriormente", +0 + 0 + 48, "Error")

                Else

                    'Se da de alta la factura
                    ModuloFactura.AltaFactura()
                    '****************************************************************

                    'RECORRO EL GRID DEL DETALLE Y GUARDO LOS DETALLES
                    ModuloDetalle.RecorrerDetalle()
                    ''*************************************

                    'Se da de alta el Movimiento
                    ModuloMovimiento.altaMovimiento()
                    '***************************************************************


                    'Vacio el Datetable para una nueva compra y pongo todas las variables en cero
                    Tabla.Clear()
                    total = 0
                    precioUnitario = 0
                    lblTotal.Text = 0
                    btnEliminar.Enabled = False
                    btnBorrarDetalle.Enabled = False

                    '**************ACTUALIZO EL SALDO DE LA CUENTA AL REALIZAR LA COMPRA DEL USUARIO EN SESION ***************
                    Dim nombreUsuario As String = lblNomUsuario.Text

                    Dim query4 As String = "SELECT id_usuario FROM usuarios  WHERE nick_usuario = '" & nombreUsuario & "'"
                    Dim IDusuario As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query4)
                    ModuloConexion.sqlConnection1.Close()

                    'Saldo de la Cuenta seleccionada del usuario en sesion
                    Dim tipoCuenta As String = cbxCuentasAsociadas.Text

                    Dim query6 As String = "SELECT c.saldo_cuenta FROM cuentas c INNER JOIN tipoCuenta tc ON tc.id_tipoCuenta = c.id_tipoCuenta WHERE c.id_usuario = '" & IDusuario & "' and tc.descripcion_tipoCuenta='" & tipoCuenta & "'"
                    Dim saldoCuenta As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query6)
                    ModuloConexion.sqlConnection1.Close()

                    If tipoCuenta = cbxCuentasAsociadas.Text Then
                        lblSaldo.Text = saldoCuenta
                    End If
                    '*******************************************

                    MsgBox("El Pago se realizo correctamente", MsgBoxStyle.Information, "Pago de Servicio")

                End If
            End If
        End If
    End Sub

    Private Sub cbServicios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxServicios.SelectedIndexChanged
        'Precio por cada servicio seleccionado
        Dim tipoServ As String = cbxServicios.Text

        Dim query4 As String = "SELECT monto_servicio FROM Servicios WHERE descripcion_servicio ='" & tipoServ & "'"
        Dim monto_servicio As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query4)
        ModuloConexion.sqlConnection1.Close()

        If tipoServ = cbxServicios.Text Then
            lblPrecio.Text = monto_servicio
            precioUnitario = monto_servicio
        End If
    End Sub

    Private Sub cbxCuentasAsociadas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxCuentasAsociadas.SelectedIndexChanged
        Dim nombreUsuario As String = lblNomUsuario.Text

        Dim query4 As String = "SELECT id_usuario FROM usuarios  WHERE nick_usuario = '" & nombreUsuario & "'"
        Dim IDusuario As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query4)
        ModuloConexion.sqlConnection1.Close()

        'Saldo de la Cuenta seleccionada del usuario en sesion
        Dim tipoCuenta As String = cbxCuentasAsociadas.Text

        Dim query6 As String = "SELECT c.saldo_cuenta FROM cuentas c INNER JOIN tipoCuenta tc ON tc.id_tipoCuenta = c.id_tipoCuenta WHERE c.id_usuario = '" & IDusuario & "' and tc.descripcion_tipoCuenta='" & tipoCuenta & "'"
        Dim saldoCuenta As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query6)
        ModuloConexion.sqlConnection1.Close()

        If tipoCuenta = cbxCuentasAsociadas.Text Then
            lblSaldo.Text = saldoCuenta
        End If
        '*******************************************
    End Sub

    Private Sub cbxPeriodoMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxPeriodoMes.SelectedIndexChanged
        cbxCuentasAsociadas.Focus()
    End Sub

    Private Sub btnFacturas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFacturas.Click
        frmVerFacturasUsuario.Show()
        Me.Close()
    End Sub
End Class