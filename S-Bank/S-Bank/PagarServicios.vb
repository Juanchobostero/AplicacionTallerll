Public Class frmPagarServicios

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

    Private Sub frmPagarServicios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_S_BankDataSet.Servicios' Puede moverla o quitarla según sea necesario.
        Me.ServiciosTableAdapter.Fill(Me._S_BankDataSet.Servicios)
   
     

        Dim nombreUsuario As String = frmFormUsuario.lblNomUsuario.Text

        Dim query As String = "SELECT nombre_usuario FROM usuarios  WHERE nick_usuario = '" & nombreUsuario & "'"
        Dim nombre As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query)
        ModuloConexion.sqlConnection1.Close()

        Dim query2 As String = "SELECT apellido_usuario FROM usuarios  WHERE nick_usuario = '" & nombreUsuario & "'"
        Dim apellido As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query2)
        ModuloConexion.sqlConnection1.Close()

        Dim query3 As String = "SELECT nick_usuario FROM usuarios  WHERE nick_usuario = '" & nombreUsuario & "'"
        Dim nick As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query3)
        ModuloConexion.sqlConnection1.Close()

        Dim ID As String = "SELECT id_usuario FROM usuarios  WHERE nick_usuario = '" & nombreUsuario & "'"
        Dim id_usuario As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, ID)
        ModuloConexion.sqlConnection1.Close()

        'Datos de la sesion
        lblIDusuario.Text = id_usuario
        lblIDusuario.Enabled = False
        lblapeYnom.Text = nombre + " " + apellido
        lblNomUsuario.Text = nick

        'Definimos las columnas de las tablas
        Tabla.Columns.Add("Tipo de Servicio", System.Type.GetType("System.String")) '0
        '**********************************************************************
        Tabla.Columns.Add("Proveedor", System.Type.GetType("System.String")) '1
        Tabla.Columns.Add("Precio $", System.Type.GetType("System.String")) '2

        lblTotal.Text = 0

        'Precio por cada servicio seleccionado
        Dim tipoServ As String = cbServicios.Text

        Dim query4 As String = "SELECT monto_servicio FROM Servicios WHERE descripcion_servicio ='" & tipoServ & "'"
        Dim monto_servicio As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query4)
        ModuloConexion.sqlConnection1.Close()

        If tipoServ = cbServicios.Text Then
            lblPrecio.Text = monto_servicio
            precioUnitario = monto_servicio
        End If
        '************************************

        'cargar comboBox con las cuentas asociadas al usuario en sesion
        Dim cuentas As String = "SELECT tc.descripcion_tipoCuenta FROM tipoCuenta tc INNER JOIN cuentas c ON tc.id_tipoCuenta = c.id_tipoCuenta INNER JOIN usuarios u ON u.id_usuario = c.id_usuario WHERE u.id_usuario  = '" & id_usuario & "'"
        Dim cuentas2 As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, ID)
        ModuloConexion.sqlConnection1.Close()

        cbxCuentasAsociadas.DataSource = cuentas2

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Se resta al total el precio del servicio a eliminar del detalle
        total = total - dgvDetalle.Item(2, dgvDetalle.CurrentRow.Index).Value.ToString()
        lblTotal.Text = total

        dgvDetalle.Rows.RemoveAt(dgvDetalle.CurrentRow.Index) 'ELIMINA SOLO EL ELEMENTO QUE ESTA SELECCIONADO EN EL GRIDDETALLE
        dgvDetalle.Refresh() 'REFRESCA PARA VER LOS DATOS UNA VEZ ELIMINADO UN ELEMNTO


    End Sub

    Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ask As MsgBoxResult
        ask = MsgBox("¿Seguro que desea agregar este Servicio?", 4 + 0 + 32, "Agregar")

        If ask = MsgBoxResult.Yes Then

            btnEliminar.Enabled = True
            Dim tipoServ As String = cbServicios.Text

            Dim query4 As String = "SELECT monto_servicio FROM Servicios WHERE descripcion_servicio ='" & tipoServ & "'"
            Dim monto_servicio As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query4)
            ModuloConexion.sqlConnection1.Close()


            Dim query3 As String = "SELECT descripcion_proveedor FROM proveedores p INNER JOIN Servicios s ON p.id_proveedor = s.id_proveedor WHERE descripcion_servicio = '" & tipoServ & "'"
            Dim desc_prov As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query3)
            ModuloConexion.sqlConnection1.Close()




            'Se carga la estructura
            servicios(0).tipoServicio = cbServicios.Text
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
        Close()
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
        End If

    End Sub

    Private Sub btnCargar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargar.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("¿Seguro que desea agregar este Servicio?", 4 + 0 + 32, "Agregar")

        If ask = MsgBoxResult.Yes Then

            btnEliminar.Enabled = True
            Dim tipoServ As String = cbServicios.Text

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
            total = precioUnitario + total
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
        btnEliminar.Enabled = False
    End Sub

    Private Sub btnPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagar.Click

        'Se da de alta la factura
        ModuloFactura.AltaFactura()
        MsgBox("El Pago se realizo correctamente", MsgBoxStyle.Information, "Pago de Servicio")
        '****************************************************************

        ''RECORRO EL GRID DEL DETALLE Y GUARDO LOS DETALLES
        'ModuloDetalle.RecorrerDetalle()
        ''*************************************

        'Vacio el Datetable para una nueva compra
        Tabla.Clear()
        total = 0
        precioUnitario = 0
    End Sub

    Private Sub cbServicios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbServicios.SelectedIndexChanged
        'Precio por cada servicio seleccionado
        Dim tipoServ As String = cbServicios.Text

        Dim query4 As String = "SELECT monto_servicio FROM Servicios WHERE descripcion_servicio ='" & tipoServ & "'"
        Dim monto_servicio As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query4)
        ModuloConexion.sqlConnection1.Close()

        If tipoServ = cbServicios.Text Then
            lblPrecio.Text = monto_servicio
            precioUnitario = monto_servicio
        End If
    End Sub
End Class