Public Class Ejercicio2
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click

        Dim num As Integer

        If Integer.TryParse(TxtNumero.Text, num) Then
            For index = 0 To num
                If IsPrime(index) Then
                    Console.WriteLine(index)
                End If
            Next
        Else
            MsgBox("El formato no es correcto")
        End If

    End Sub

    Public Function IsPrime(ByVal num As Integer) As Boolean
        Dim divisor As UInt32 = 2

        Do While divisor < num / 2
            If num Mod divisor = 0 Then
                Return False
            End If

            divisor += 1

        Loop

        Return True

    End Function

End Class