Public Class frmReportes

 
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        frmLogin.Show()
        Me.Close()

    End Sub

    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click

        frmInicioAdm.Show()
        Me.Close()

    End Sub

    Private Sub btnVerClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerClientes.Click

        frmVerClientes.Show()
        Me.Close()

    End Sub

    Private Sub btnVerFac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerFac.Click

        frmUltimasFacturas.Show()
        Me.Close()

    End Sub

    Private Sub btnVerMov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerMov.Click

        frmClientesPagos.Show()
        Me.Close()

    End Sub

    Private Sub frmReportes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class