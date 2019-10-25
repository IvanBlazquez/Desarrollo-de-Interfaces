Module Module1

    Sub Main()
        Dim num, count As Integer
        Console.WriteLine("Introduce un número")
        num = CInt(Console.ReadLine())
        Do While num > 0
            Select Case num
                Case Is < 5
                    Console.WriteLine("BAJO")
                    count += 1
                Case 5 To 8
                    Console.WriteLine("MEDIO")
                Case 8 To 10
                    Console.WriteLine("ALTO")
                Case Is > 10
                    Console.WriteLine("FUERA DE RANGO")
            End Select
            Console.ReadLine()
            Console.Clear()
            Console.WriteLine("Introduce otro número")
            num = Console.ReadLine()
        Loop
        Console.WriteLine(vbCrLf + "Has introducido {0} números menores que 5", count)
        Console.ReadLine()
    End Sub

End Module
