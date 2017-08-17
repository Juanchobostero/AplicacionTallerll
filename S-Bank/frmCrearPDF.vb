Imports iTextSharp.text
Imports iTextSharp.pdfa
Imports iTextSharp.text.pdf

Public Class frmCrearPDF

    Private Sub btnCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrear.Click

        'Vamos a encontrar la ruta donde guardar el pdf
        'Muestro el SaveFileDialog y guardo el contenido del PDF
        Dim SaveFileDialog As New SaveFileDialog
        Dim ruta As String

        With SaveFileDialog
            .Title = "Guardar"

            'Selecciono la ruta de generacion por defecto
            'En todos los demas casos uso la ruta por defecto

            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            .Filter = "*Archivos PDF (*.pdf)|*.pdf"
            .FileName = "Archivo"
            .OverwritePrompt = True
            .CheckPathExists = True
        End With

        If SaveFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            ruta = SaveFileDialog.FileName
        Else
            ruta = String.Empty
        End If

        'GENERACION DEL PDF

        Try

            'Creacion de documento
            Dim documento As New iTextSharp.text.Document(PageSize.A4)

            'Configuracion de hoja
            documento.PageSize.Rotate()

            'Propiedades
            documento.AddAuthor("S-Bank")
            documento.AddTitle("Factura")

            Dim writer As PdfWriter = PdfWriter.GetInstance(documento, New System.IO.FileStream _
            (ruta, System.IO.FileMode.Create))

            'Con esto conseguimos que el formato del PDF sea en pagina simple
            writer.ViewerPreferences = PdfWriter.PageLayoutSinglePage

            'Abrimos el documento para empezar a grabarlo
            documento.Open()

            '*********************************************************************
            'Definimos tipo de letra y posteriormente añadir contenido
            Dim cb As PdfContentByte = writer.DirectContent
            Dim bf As BaseFont = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED)
            cb.SetFontAndSize(bf, 30)
            cb.BeginText()

            'Datos
            cb.SetTextMatrix(50, 790)
            cb.ShowText("***************S-BANK****************")

            cb.NewlineShowText("Monto: " + txtDatos.Text)


            cb.EndText()
            '*********************************************************************
            'Cerramos el documento
            documento.Close()



        Catch ex As Exception
            MessageBox.Show("Error en la generacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class