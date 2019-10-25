Public Class Form1
    Private Sub NuevoCoralistaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoCoralistaToolStripMenuItem.Click
        Dim f As New frmNuevo
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ElaborarListaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ElaborarListaToolStripMenuItem.Click
        Dim f As New FrmElaborarLista
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub VerListaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerListaToolStripMenuItem.Click
        MostrarAlineacion()
    End Sub
End Class
