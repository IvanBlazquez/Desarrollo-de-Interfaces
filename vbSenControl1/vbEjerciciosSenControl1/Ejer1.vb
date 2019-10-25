Public Class Ejer1
    Private Sub btCal_Click(sender As Object, e As EventArgs) Handles btCal.Click
        Dim a, b As Integer
        Dim i As Integer
        Dim aux As Integer
        a = CInt(txtA.Text)
        b = CInt(txtB.Text)

        If a > b Then
            aux = a
            a = b
            b = aux
        End If

        If a Mod 2 = 0 Then
            a += 1
        End If

        While a < b

            Console.WriteLine(a)
            a += 2
        End While

    End Sub
End Class