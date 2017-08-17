Public Class frmLogin

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIniciar.Click

        If (txtNombre.Text = String.Empty Or txtContraseña.Text = String.Empty) Then

            MsgBox("Debe completar todos los campos obligatorios", 0 + 0 + 16, "Error")

        ElseIf (txtNombre.Text = "admin" And txtContraseña.Text = "37698") Then

            frmInicioAdm.Show()
            Me.Close()

        ElseIf (ModuloFunciones.existe_usuario() And ModuloFunciones.existe_contraseña()) Then
            frmFormUsuario.Show()
            Me.Close()
        Else
            MsgBox("Asegurese de ingresar correctamente los datos!", 0 + 0 + 16, "Error")

        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class
