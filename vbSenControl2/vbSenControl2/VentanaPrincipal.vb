Public Class VentanaPrincipal



    Private Sub Ejercicio1ToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles Ejercicio1ToolStripMenuItem.Click
        Dim F1 As New ejercicio1
        F1.MdiParent = Me
        F1.Show()
    End Sub

    Private Sub Ejercicio2ToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles Ejercicio2ToolStripMenuItem.Click
        Dim F1 As New Ejercicio2
        F1.MdiParent = Me
        F1.Show()
    End Sub

    Private Sub Ejercicio3ToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles Ejercicio3ToolStripMenuItem.Click
        Dim F1 As New Ejercicio3
        F1.MdiParent = Me
        F1.Show()
    End Sub
End Class