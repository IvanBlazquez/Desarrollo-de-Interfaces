Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        For i = 0 To cont - 1
            ''Si encuentro la palabra,muestro traducción y salgo del sub
            If (diccionario(i).palabra = txtPalabra.Text) Then
                txtTraduccion.Text = diccionario(i).traduccion
                Exit Sub
            End If

        Next
        ''Si no existe la palabra, la añadimos
        ReDim Preserve diccionario(cont)
        diccionario(cont).palabra = txtPalabra.Text
        diccionario(cont).traduccion = InputBox("Traduccion: ")
        cont += 1
    End Sub
End Class
