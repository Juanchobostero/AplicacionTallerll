Imports System.Data.SqlClient


Module ModuloConexion

    Public source As String = "Data Source=localhost;Initial Catalog=S-Bank;Integrated Security=True"
    Public sqlConnection1 As New SqlConnection(source)

    Public Function SQL_Consulta(ByRef sqlConnection1 As SqlConnection, ByVal query As String)
        Try
            Dim cmd As New SqlCommand
            'Dim reader As SqlDataReader
            cmd.CommandText = query
            cmd.CommandType = CommandType.Text
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            Return cmd.ExecuteReader()
        Catch excepcion As SqlException
            MsgBox(excepcion.ToString, MsgBoxStyle.Information, "SQL ERROR")
        Catch excepcion2 As Exception
            MsgBox(excepcion2.ToString, MsgBoxStyle.Information, "ERROR")
        End Try
    End Function

    Public Function SQL_Consulta2(ByRef sqlConnection1 As SqlConnection, ByVal query As String)
        Try
            Dim cmd As New SqlCommand
            'Dim reader As SqlDataReader
            cmd.CommandText = query
            cmd.CommandType = CommandType.Text
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            Return cmd.ExecuteScalar()
        Catch excepcion As SqlException
            MsgBox(excepcion.ToString, MsgBoxStyle.Information, "SQL ERROR")
        Catch excepcion2 As Exception
            MsgBox(excepcion2.ToString, MsgBoxStyle.Information, "ERROR")
        End Try
    End Function
End Module



