Public Class frmFormUsuario

    Private Sub FormularioUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim nombreUsuario As String = frmLogin.txtNombre.Text
        Dim nick2 As String = frmPagarServicios.lblNomUsuario.Text

        If nombreUsuario = String.Empty Then

            nombreUsuario = nick2

            Dim id_us As String = "SELECT id_usuario FROM usuarios WHERE nick_usuario = '" & nombreUsuario & "'"
            Dim id_usuario As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, id_us)
            ModuloConexion.sqlConnection1.Close()

            Dim query As String = "SELECT nombre_usuario FROM usuarios WHERE id_usuario = '" & id_usuario & "'"
            Dim nombre As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query)
            ModuloConexion.sqlConnection1.Close()

            Dim query2 As String = "SELECT apellido_usuario FROM usuarios WHERE id_usuario = '" & id_usuario & "'"
            Dim apellido As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query2)
            ModuloConexion.sqlConnection1.Close()

            Dim query3 As String = "SELECT nick_usuario FROM usuarios WHERE id_usuario = '" & id_usuario & "'"
            Dim nick As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query3)
            ModuloConexion.sqlConnection1.Close()

            Dim query4 As String = "SELECT dni_usuario FROM usuarios WHERE id_usuario = '" & id_usuario & "'"
            Dim DNI As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query4)
            ModuloConexion.sqlConnection1.Close()

            Dim query5 As String = "SELECT fechaNacimiento FROM usuarios WHERE id_usuario = '" & id_usuario & "'"
            Dim fechaNacimiento = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query5)
            ModuloConexion.sqlConnection1.Close()

            Dim query6 As String = "SELECT edad_usuario FROM usuarios WHERE id_usuario = '" & id_usuario & "'"
            Dim edad As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query6)
            ModuloConexion.sqlConnection1.Close()

            Dim query7 As String = "SELECT direccion_usuario FROM usuarios WHERE id_usuario = '" & id_usuario & "'"
            Dim direccion As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query7)
            ModuloConexion.sqlConnection1.Close()

            Dim query8 As String = "SELECT mail_usuario FROM usuarios WHERE id_usuario = '" & id_usuario & "'"
            Dim correo As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query8)
            ModuloConexion.sqlConnection1.Close()

            Dim query9 As String = "SELECT sexo_usuario FROM usuarios WHERE id_usuario = '" & id_usuario & "'"
            Dim sexo As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query9)
            ModuloConexion.sqlConnection1.Close()

            lblNomyApe.Text = nombre + " " + apellido
            lblNomUsuario.Text = nick
            lblNroDoc.Text = DNI
            lblFechaNac.Text = fechaNacimiento
            lblEd.Text = edad
            lblDirec.Text = direccion
            lblmail.Text = correo
            lblSex.Text = sexo
        Else

            Dim id_us As String = "SELECT id_usuario FROM usuarios WHERE nick_usuario = '" & nombreUsuario & "'"
            Dim id_usuario As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, id_us)
            ModuloConexion.sqlConnection1.Close()

            Dim query As String = "SELECT nombre_usuario FROM usuarios WHERE id_usuario = '" & id_usuario & "'"
            Dim nombre As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query)
            ModuloConexion.sqlConnection1.Close()

            Dim query2 As String = "SELECT apellido_usuario FROM usuarios WHERE id_usuario = '" & id_usuario & "'"
            Dim apellido As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query2)
            ModuloConexion.sqlConnection1.Close()

            Dim query3 As String = "SELECT nick_usuario FROM usuarios WHERE id_usuario = '" & id_usuario & "'"
            Dim nick As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query3)
            ModuloConexion.sqlConnection1.Close()

            Dim query4 As String = "SELECT dni_usuario FROM usuarios WHERE id_usuario = '" & id_usuario & "'"
            Dim DNI As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query4)
            ModuloConexion.sqlConnection1.Close()

            Dim query5 As String = "SELECT fechaNacimiento FROM usuarios WHERE id_usuario = '" & id_usuario & "'"
            Dim fechaNacimiento = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query5)
            ModuloConexion.sqlConnection1.Close()

            Dim query6 As String = "SELECT edad_usuario FROM usuarios WHERE id_usuario = '" & id_usuario & "'"
            Dim edad As Integer = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query6)
            ModuloConexion.sqlConnection1.Close()

            Dim query7 As String = "SELECT direccion_usuario FROM usuarios WHERE id_usuario = '" & id_usuario & "'"
            Dim direccion As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query7)
            ModuloConexion.sqlConnection1.Close()

            Dim query8 As String = "SELECT mail_usuario FROM usuarios WHERE id_usuario = '" & id_usuario & "'"
            Dim correo As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query8)
            ModuloConexion.sqlConnection1.Close()

            Dim query9 As String = "SELECT sexo_usuario FROM usuarios WHERE id_usuario = '" & id_usuario & "'"
            Dim sexo As String = ModuloConexion.SQL_Consulta2(ModuloConexion.sqlConnection1, query9)
            ModuloConexion.sqlConnection1.Close()

            lblNomyApe.Text = nombre + " " + apellido
            lblNomUsuario.Text = nick
            lblNroDoc.Text = DNI
            lblFechaNac.Text = fechaNacimiento
            lblEd.Text = edad
            lblDirec.Text = direccion
            lblmail.Text = correo
            lblSex.Text = sexo
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub lblNomyApe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNomyApe.Click

    End Sub

    Private Sub btnPagarServicios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagarServicios.Click
        frmPagarServicios.Show()
        Me.Close()
    End Sub
End Class