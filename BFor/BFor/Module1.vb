Module Module1

    Sub Main()
        Dim num, i, s, x As Integer
        ''Pedir num
        ''Try

        Console.WriteLine("Introduce número")
        If Integer.TryParse(Console.ReadLine, num) Then

            ''Establezco los límites del for


            If num > 0 Then
                i = 1
                s = num
            Else
                i = num
                s = -1
            End If

            ''desde x es i hasta que x es s mostrar x*num
            For x = i To s
                Console.WriteLine("{0}", x * num)
            Next
        Else
            Console.WriteLine("Debe introducir un número")
        End If
        Console.ReadLine()
        'Catch ex As Exception
        '    Console.WriteLine("Debe introducir un número")
        'Finally

        '    Console.ReadLine()
        'End Try
    End Sub

End Module
