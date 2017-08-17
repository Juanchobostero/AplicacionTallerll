Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class frmInicioAdm


    Private Sub btnAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        frmRegistro.Show()
        Me.Close()


    End Sub

    Private Sub btnBajaUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnUsuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsuarios.Click

        frmUsuarios.Show()
        Me.Close()

    End Sub

    Private Sub btnCuentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuentas.Click

        frmAdministrarCuentas.Show()
        Me.Close()
    End Sub

    Private Sub btnAgregarTipoCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        frmNuevoTipoCuentaBancaria.Show()
        Me.Close()

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picAdmin.Click

    End Sub

    Private Sub frmInicioAdm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub picAdmin_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles picAdmin.Paint

        'creamos un objeto de la clase GraphicsPath
        Dim figura As GraphicsPath = New GraphicsPath
        'manipulando las variables que se corresponden con los puntos x e y, el ancho y el alto de la figura, podemos variar su aspecto
        Dim x, y, ancho, alto As Integer
        'anchura y altura de la figura (círculo en este caso)
        ancho = 260
        alto = 260
        'posiciones x e y de la figura (centrada en el control PictureBox)
        x = (picAdmin.Width - ancho) / 2
        y = (picAdmin.Height - alto) / 2
        'usamos el método AddEllipse para conseguir la figura de un círculo,
        'que aplicaremos sobre el control PictureBox.
        figura.AddEllipse(New Rectangle(x, y, ancho, alto))
        'en el control PictureBox creamos una región que se corresponde
        'con la figura del objeto GraphicsPath
        picAdmin.Region = New Region(figura)
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmAdministrarServicios.Show()
        Me.Close()
    End Sub

    Private Sub btnAdministrarProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdministrarProv.Click
        frmAdministrarProveedor.Show()
        Me.Close()
    End Sub
End Class
