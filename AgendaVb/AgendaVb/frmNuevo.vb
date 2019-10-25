Public Class frmNuevo
    Public Property MainForm As Form1
        Get
            Return padre
        End Get
        Set(value As Form1)
            padre = value
        End Set
    End Property
    Private padre As Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim contactoNuevo As Contacto
        If coleccion.Contains(txtNombre.Text) Then
            ''Ya existe
            Dim result As MsgBoxResult
            result = MsgBox("El nombre ya existe, desea introducirlo de todos modos?", vbYesNo)
            If result = vbYes Then
                Dim nombre As String
                nombre = CalcularNombre(txtNombre.Text)
                contactoNuevo.Nombre = nombre
                contactoNuevo.Direccion = txtDirección.Text
                contactoNuevo.Telefono = txtTelefono.Text
                contactoNuevo.Categoria = txtCategoria.Text
                coleccion.Add(contactoNuevo, nombre)
                ActualizarFormulario(nombre)
            End If

        Else
            ''No existe

            contactoNuevo.Nombre = txtNombre.Text
            contactoNuevo.Direccion = txtDirección.Text
            contactoNuevo.Telefono = txtTelefono.Text
            contactoNuevo.Categoria = txtCategoria.Text
            coleccion.Add(contactoNuevo, txtNombre.Text)
            ActualizarFormulario(txtNombre.Text)
        End If
    End Sub

    Private Sub ActualizarFormulario(text As String)
        MainForm.ListBox1.Items.Add(text)
        MainForm.txtTotal.Text = coleccion.Count.ToString
    End Sub

    Private Function CalcularNombre(nom As String) As String
        Dim cont As Integer = 0
        Do
            cont += 1
        Loop While coleccion.Contains(nom + "-" + cont.ToString)
        Return nom + "-" + cont.ToString()
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub
End Class