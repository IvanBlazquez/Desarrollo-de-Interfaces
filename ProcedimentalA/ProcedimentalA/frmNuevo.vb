Public Class frmNuevo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nuevo As Coralista
        If (Not coralistas.Contains(txtId.Text)) Then
            nuevo = Alta(CInt(txtId.Text), txtNombre.Text, cmbCuerda.SelectedIndex)
            coralistas.Add(nuevo, txtId.Text)
        Else
            MsgBox("Ese coralista ya existe")
        End If
    End Sub

    Private Sub FrmNuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Llenarcombo(cmbCuerda)
    End Sub
End Class