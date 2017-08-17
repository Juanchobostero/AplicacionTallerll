Imports System.Data.SqlClient
Imports System.IO


Public Class frmBackUp

    Dim con As SqlConnection
    Dim cmd As SqlCommand



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            con = New SqlConnection("Data Source=localhost;Initial Catalog=SBank;Integrated Security=True;Pooling= False")
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click


        Dim explorador As New SaveFileDialog
        explorador.InitialDirectory = "C:\backup"
        explorador.Filter = "Backup Files (*.bak)|*.bak"
        explorador.RestoreDirectory = True
        explorador.Title = " Backup de base de datos"
        explorador.FileName = "SistemaGestion_" + Now.ToString("dd-MM-yyyy_hh-mm-ss") + ".bak"
        If explorador.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            'direccion a guardar.
            Dim path As String
            path = System.IO.Path.GetFullPath(explorador.FileName)
            Try
                'Backup 
                cmd = New SqlCommand("backup database SBank to disk='" & path.ToString & "'", con)
                con.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Backup realizado correctamente", MsgBoxStyle.Information)
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
       Dim explorador2 As New OpenFileDialog
        explorador2.InitialDirectory = "C:\backup"
        explorador2.Filter = "Backup Files (*.bak)|*.bak"
        explorador2.RestoreDirectory = True
        explorador2.Title = "Abrir Archivo de Backup "
        If explorador2.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            'direccion del restore.
            Dim path As String
            path = System.IO.Path.GetFullPath(explorador2.FileName)
            'restore.
            Try
                cmd = New SqlCommand("USE master ALTER DATABASE SBank SET SINGLE_USER WITH ROLLBACK IMMEDIATE  RESTORE DATABASE SBank FROM DISK = '" & path & "' ALTER DATABASE SBank SET MULTI_USER ;", con)
                con.Open()
                cmd.ExecuteNonQuery()
                MsgBox("base de datos recuperada correctamente.", MsgBoxStyle.Information)
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        frmLogin.Show()
        Me.Close()

    End Sub

    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click

        frmInicioAdm.Show()
        Me.Close()

    End Sub
End Class
