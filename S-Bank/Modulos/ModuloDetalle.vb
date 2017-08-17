Imports System.Data
Imports System.Data.SqlClient

Module ModuloDetalle
    Public Function AltaDetalle(ByVal servicio As String, ByVal proveedor As String, ByVal montoServicio As Integer) As Boolean
        Dim conectar As New System.Data.SqlClient.SqlConnection(ModuloConexion.source)
        Dim cmsql As New System.Data.SqlClient.SqlCommand

        Dim strSQL As String
        Dim NroFac As Integer
        Dim provAs As String = proveedor
        Dim codServ As Integer

        Try

            strSQL = "SELECT MAX(id_factura) FROM Factura "

            conectar.Open()
            cmsql = New SqlCommand(strSQL, conectar)
            NroFac = cmsql.ExecuteScalar()
            conectar.Close()
            cmsql.Dispose()

            strSQL = "SELECT cod_servicio FROM Servicios WHERE descripcion_servicio= '" & servicio & "'"

            conectar.Open()
            cmsql = New SqlCommand(strSQL, conectar)
            codServ = cmsql.ExecuteScalar()
            conectar.Close()
            cmsql.Dispose()


            strSQL = "INSERT INTO detalleServicios (cod_servicio, id_factura, montoServicio) VALUES(" & codServ & "," & NroFac & "," & montoServicio & ")"

            conectar.Open()
            cmsql = New SqlCommand(strSQL, conectar)
            cmsql.ExecuteNonQuery()


            conectar.Close()
            cmsql.Dispose()
            conectar.Dispose()

            Return True

        Catch Exp As SqlException
            MsgBox(Exp.Message, MsgBoxStyle.Critical, "SQL Error 111111")
            conectar.Close()
            Return False
        Catch Exp As Exception
            MsgBox(Exp.Message, MsgBoxStyle.Critical, "General Error 22222")
            Return False
        End Try

    End Function

    '**************************RECORRE EL DETALLE DE LOS SERVICIOS Y GUARDA LOS DATOS DEL DATAGRID*****************************
    Public Function RecorrerDetalle() ' carga al detalle de la factura

        Dim i As Integer = 0
        Dim texto As String
        Dim row As System.Windows.Forms.DataGridViewRow
        While i < frmPagarServicios.dgvDetalle.Rows.Count
            row = frmPagarServicios.dgvDetalle.Rows(i)
            texto = ""
            For Each celda As System.Windows.Forms.DataGridViewCell In row.Cells
                'Comprobamos que la celda tenga algún valor
                If celda.Value IsNot Nothing Then
                    texto += vbTab + celda.Value.ToString()
                End If
            Next
            'POR CADA LINEA GUARDA EL DETALLE

            AltaDetalle(frmPagarServicios.dgvDetalle.Item(0, i).Value.ToString(), frmPagarServicios.dgvDetalle.Item(1, i).Value.ToString(), frmPagarServicios.dgvDetalle.Item(2, i).Value.ToString())

            i += 1
        End While

    End Function

    Public Function RecorrerDetalle2() ' carga al detalle de la factura

        Dim i As Integer = 0
        Dim texto As String
        Dim row As System.Windows.Forms.DataGridViewRow
        While i < frmPagarServicios.dgvDetalle.Rows.Count
            row = frmPagarServicios.dgvDetalle.Rows(i)
            texto = ""
            For Each celda As System.Windows.Forms.DataGridViewCell In row.Cells
                'Comprobamos que la celda tenga algún valor
                If celda.Value IsNot Nothing Then
                    texto += vbTab + celda.Value.ToString()
                End If
            Next
            'POR CADA LINEA GUARDA EL DETALLE

            verificarPeriodo(frmPagarServicios.dgvDetalle.Item(0, i).Value.ToString(), frmPagarServicios.dgvDetalle.Item(1, i).Value.ToString(), frmPagarServicios.dgvDetalle.Item(2, i).Value.ToString())

            i += 1
        End While

    End Function

    Public Function verificarPeriodo(ByVal servicio As String, ByVal proveedor As String, ByVal montoServicio As Integer) As Boolean
        Dim provAs As String = proveedor

        Dim query As String = "SELECT MAX(id_factura) FROM Factura"
        Dim IDfactura As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query)
        ModuloConexion.sqlConnection1.Close()

        Dim query2 As String = "SELECT cod_servicio FROM Servicios WHERE descripcion_servicio ='" & servicio & "'"
        Dim codServ As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query2)
        ModuloConexion.sqlConnection1.Close()

        Dim query3 As String = "SELECT periodoMes FROM Factura f INNER JOIN detalleServicios ds ON ds.id_factura = f.id_factura WHERE ds.cod_servicio='" & codServ & "' and f.id_factura ='" & IDfactura & "'"
        Dim periodoMES As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query3)
        ModuloConexion.sqlConnection1.Close()

        If periodoMES = String.Empty Then
            Return False
        Else
            Return True
        End If

    End Function
End Module
