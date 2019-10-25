Imports System.IO

Public Class Form1
    Private Sub NuevoContactoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoContactoToolStripMenuItem.Click
        frmNuevo.MainForm = Me
        frmNuevo.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Me.Dispose()
    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        If coleccion.Contains(ListBox1.SelectedItem) Then
            With (coleccion(ListBox1.SelectedItem))
                txtNombre.Text = .Nombre
                txtCategoria.Text = .Categoria
                txtDirección.Text = .Direccion
                txtTelefono.Text = .Telefono
            End With
        End If
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Dim categoria As String
        categoria = InputBox("Categoria")
        Dim sw As New StreamWriter(categoria + ".txt")
        sw.WriteLine("Categoría: {0}", categoria)
        sw.WriteLine("{0,15}   {1,25}   {2,9}", "NOMBRE", "DIRECCION", "TELEFONO")
        For Each elem As Contacto In coleccion
            If elem.Categoria = categoria Then
                sw.WriteLine("{0,15}   {1,25}   {2,9}", elem.Nombre, elem.Direccion, elem.Telefono)
            End If
        Next
        sw.Close()
    End Sub
End Class
