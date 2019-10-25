Public Class Ejercicio3
    Dim dectobin As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        Dim b As String = ""
        If dectobin Then
            a = CInt(txtdeci.Text)
            Do While a > 0
                b = (a Mod 2).ToString + b
                a = a \ 2
            Loop
            txtbin.Text = b
        End If



    End Sub

    Private Sub txtdeci_TextChanged(sender As Object, e As EventArgs) Handles txtdeci.TextChanged
        dectobin = True
    End Sub

    Private Sub txtbin_TextChanged(sender As Object, e As EventArgs) Handles txtbin.TextChanged
        dectobin = False
    End Sub

    Private Sub txtdeci_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles txtdeci.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            MsgBox("Debe introducirse numeros:")
        End If
    End Sub

    Private Sub txtbin_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles txtbin.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "1") And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            MsgBox("Debe introducirse numeros:")
        End If
    End Sub
End Class