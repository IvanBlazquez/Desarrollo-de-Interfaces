Public Class FrmElaborarLista
    Private Sub FrmElaborarLista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ids() As Integer = NoConvocados()
        LlenarLista(ListBox1, ids)
    End Sub

    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click
        If Not ListBox1.SelectedItem Is Nothing Then
            txtNombre.Text = coralistas(ListBox1.SelectedItem).Nombre
            txtCuerda.Text = coralistas(ListBox1.SelectedItem).voz.ToString
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        coralistas(ListBox1.SelectedItem).setConvocado(True)

    End Sub
End Class