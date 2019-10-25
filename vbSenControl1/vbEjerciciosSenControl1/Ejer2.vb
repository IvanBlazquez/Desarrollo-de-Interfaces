Public Class Ejer2

    Private Sub btCalcular_Click(sender As Object, e As EventArgs) Handles btCalcular.Click
        Dim Capital As Single
        Dim interes As Single
        Dim Años As Integer
        Capital = CSng(txtCapital.Text)
        interes = CSng(txtInteres.Text)
        Años = CInt(txtAños.Text)
        For i As Integer = 1 To Años Step 1
            Capital = Capital + (Capital * interes) / 100
            lstAños.Items.Add(i.ToString)
            lstCapital.Items.Add(Capital.ToString)
        Next

    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub
End Class