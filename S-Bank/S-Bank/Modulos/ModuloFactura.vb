Imports System.Data
Imports System.Data.SqlClient

Module ModuloFactura
    '*****************************ALTA DE LA CABECERA DE LA FACTURA*****************************
    Public Function AltaFactura() As Boolean
        Try
            Dim id_us As Integer = frmPagarServicios.lblIDusuario.Text
            Dim montoTotal As Integer = frmPagarServicios.lblTotal.Text

            Dim fechaPago As String = frmPagarServicios.dtvFechaPago.Value.Day & "-" & frmPagarServicios.dtvFechaPago.Value.Month & "-" & frmPagarServicios.dtvFechaPago.Value.Year

            Dim query As String = "INSERT INTO Factura(id_usuario, montoTotal, fechaPago) VALUES('" & id_us & "','" & montoTotal & "','" & fechaPago & "')"
            ModuloConexion.SQL_Consulta(ModuloConexion.sqlConnection1, query)
            ModuloConexion.sqlConnection1.Close()
            Return True

        Catch Exp As SqlException
            MsgBox(Exp.Message, MsgBoxStyle.Critical, "SQL Error")
            ModuloConexion.sqlConnection1.Close()
            Return False
        Catch Exp As Exception
            MsgBox(Exp.Message, MsgBoxStyle.Critical, "General Error")
            Return False
        End Try

    End Function

    Public Function ListaDeFactura() As Boolean

        Try
            Dim query As String = "SELECT * FROM Factura"
            ModuloConexion.SQL_Consulta(ModuloConexion.sqlConnection1, query)
            ModuloConexion.sqlConnection1.Close()

            Return True

        Catch Exp As SqlException
            MsgBox(Exp.Message, MsgBoxStyle.Critical, "SQL Error")
            ModuloConexion.sqlConnection1.Close()
            Return False
        Catch Exp As Exception
            MsgBox(Exp.Message, MsgBoxStyle.Critical, "General Error")
            Return False
        End Try

    End Function
End Module
