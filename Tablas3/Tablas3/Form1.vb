Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        For i = 0 To cont - 1
            With tabla(i)
                If CInt(.NPedido = CInt(txtPedido.Text)) Then
                    Dim res As MsgBoxResult = MsgBox("Ese producto ya está, acumular unidades?", vbYesNo)
                    If res = vbYes Then
                        .Unidades += CInt(txtUnidades.Text)
                    End If
                End If
            End With
            Exit Sub
        Next
        ReDim Preserve tabla(cont)
        With tabla(cont)
            .NPedido = CInt(txtPedido.Text)
            .Producto = txtProducto.Text
            .Unidades = CInt(txtUnidades.Text)
            .Precio = CSng(txtPrecio.Text)
        End With
        cont += 1
    End Sub
End Class
