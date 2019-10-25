Module Module4

    Public Sub main()

        Dim num, suma As Integer
        Console.WriteLine("Introduzca un número:")
        num = CInt(Console.ReadLine)

        Do While num <> 0
            suma += num
            Select Case num
                Case Is < 10
                    Console.WriteLine("Bajo")

                Case 10 To 20
                    Console.WriteLine("Normal")
                Case 20 To 30
                    Console.WriteLine("Alto")
                Case Is > 30
                    Console.WriteLine("Excesivo")

            End Select

            Console.ReadLine()
            Console.Clear()

            Console.WriteLine("introduce un numero")

            num = Console.ReadLine()
        Loop

        Console.WriteLine("la suma de los números es: {0}", suma)
        Console.ReadLine()


    End Sub
End Module
