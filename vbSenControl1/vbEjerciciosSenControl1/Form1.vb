Public Class Form1
    Private Sub Ejer1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejer1ToolStripMenuItem.Click
        Dim Ventanahija As New Ejer1
        Ventanahija.MdiParent = Me
        Ventanahija.Show()

    End Sub

    Private Sub Ejer2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejer2ToolStripMenuItem.Click
        Dim Ventanahija As New Ejer2
        Ventanahija.MdiParent = Me
        Ventanahija.Show()
    End Sub

    Private Sub Ejer3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejer3ToolStripMenuItem.Click
        Dim num As Integer
        Dim i As Integer = 0
        Dim f = InputBox("Introduce un numero: ")
        Console.WriteLine("Numero   Cuadrado    Cubo")
        num = f
        While (i <= num)
            Console.WriteLine("{0,6}  {1,8} {2,4}", i, i ^ 2, i ^ 3)
            i += 1
        End While
    End Sub
End Class
