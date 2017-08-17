Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class frmInicioAdm


    Private Sub btnAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        frmRegistro.Show()
        Me.Close()


    End Sub

 

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        frmLogin.Show()
        Me.Close()
    End Sub



    Private Sub btnAgregarTipoCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        frmNuevoTipoCuentaBancaria.Show()
        Me.Close()

    End Sub

 





    Private Sub btnAdminUsuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdminUsuarios.Click

        frmUsuarios.Show()
        Me.Close()

    End Sub

    Private Sub btnAdminCuentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdminCuentas.Click

        frmAdministrarCuentas.Show()
        Me.Close()

    End Sub

    Private Sub btnAdminProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdminProv.Click

        frmAdministrarProveedor.Show()
        Me.Close()

    End Sub

    Private Sub btnAdminServ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdminServ.Click

        frmAdministrarServicios.Show()
        Me.Close()

    End Sub

    Private Sub btnFacturas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFacturas.Click

        frmVerFacturas.Show()
        Me.Close()


    End Sub

    Private Sub btnMov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMov.Click

        frmMovimientos.Show()
        Me.Close()


    End Sub

    Private Sub btnReportes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReportes.Click

        frmReportes.Show()
        Me.Close()

    End Sub

    Private Sub frmInicioAdm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub picFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picFoto.Click

        'creamos un objeto de la clase GraphicsPath
        Dim figura As GraphicsPath = New GraphicsPath
        'manipulando las variables que se corresponden con los puntos x e y, el ancho y el alto de la figura, podemos variar su aspecto
        Dim x, y, ancho, alto As Integer
        'anchura y altura de la figura (círculo en este caso)
        ancho = 260
        alto = 260
        'posiciones x e y de la figura (centrada en el control PictureBox)
        x = (picFoto.Width - ancho) / 2
        y = (picFoto.Height - alto) / 2
        'usamos el método AddEllipse para conseguir la figura de un círculo,
        'que aplicaremos sobre el control PictureBox.
        figura.AddEllipse(New Rectangle(x, y, ancho, alto))
        'en el control PictureBox creamos una región que se corresponde
        'con la figura del objeto GraphicsPath
        picFoto.Region = New Region(figura)

    End Sub

    Private Sub btnBackUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackUp.Click

        frmBackUp.Show()
        Me.Close()

    End Sub

  
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        frmLogin.Show()
        Me.Close()

    End Sub
End Class
