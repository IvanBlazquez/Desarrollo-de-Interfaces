Public Class ejercicio1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer = 0
        Dim Numero As Integer = CInt(TxtNumero.Text)
        Dim Espacio As Integer = 0
        Dim Asterisco As Integer = 0
        While Numero >= i
            While Espacio < i
                Console.Write(" ")
                Espacio = Espacio + 1
            End While
            While Asterisco < ((Numero * 2) - (Espacio * 2) - 1)
                Console.Write("*")
                Asterisco = Asterisco + 1
            End While
            Espacio = 0
            Asterisco = 0
            i = i + 1
            Console.WriteLine()
        End While
    End Sub
End Class