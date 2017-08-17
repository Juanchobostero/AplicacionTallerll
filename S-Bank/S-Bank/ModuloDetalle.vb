Imports System.Data
Imports System.Data.SqlClient

Module ModuloDetalle
    Public Function AltaDetalle(ByVal nombreProveedor As String, ByVal montoServicio As String) As Boolean
        Try
            Dim id_factura As String = "SELECT MAX(id_factura) FROM Factura"
            Dim id_fact As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, id_factura)
            ModuloConexion.sqlConnection1.Close()

      

            Dim query As String = "INSERT INTO detalleServicios(cod_servicio, id_factura, nombreProveedor, montoServicio) VALUES('" & cod_serv & "','" & id_fact & "','" & nombreProveedor & "','" & montoServicio & "')"
            ModuloConexion.SQL_Consulta(ModuloConexion.sqlConnection1, query)
            ModuloConexion.sqlConnection1.Close()
            Return True

        Catch Exp As SqlException
            MsgBox(Exp.Message, MsgBoxStyle.Critical, "SQL Error 111111")
            ModuloConexion.sqlConnection1.Close()
            Return False
        Catch Exp As Exception
            MsgBox(Exp.Message, MsgBoxStyle.Critical, "General Error 22222")
            Return False
        End Try

    End Function

    '**************************RECORRE EL DETALLE DE LA COMPRA Y GUARDA LOS DATOS DEL DATAGRID*****************************
    Public Function RecorrerDetalle() ' carga al detalle de la factura y actualiza el  stock de los productos

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


            AltaDetalle(frmPagarServicios.dgvDetalle.Item(0, i).Value.ToString(), frmPagarServicios.dgvDetalle.Item(2, i).Value.ToString())

            i += 1
        End While

    End Function
End Module
