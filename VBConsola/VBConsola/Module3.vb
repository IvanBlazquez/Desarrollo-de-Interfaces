Module Module3

    Sub Main()

        Dim num As Integer

        num = GetNum(0, 3)

        Do Until num = 0
            Dim num1, num2 As Integer
            num1 = GetNum()
            num2 = GetNum()

            Select Case num
                Case 1
                    Console.WriteLine("El mayor es {0}.", IIf(num1 > num2, num1, num2))
                Case 2
                    Console.WriteLine("El menor es {0}.", IIf(num1 < num2, num1, num2))
                Case 3
                    Console.WriteLine("La media es {0}.", ((num1 + num2) / 2).ToString("#0.00"))
            End Select

            num = GetNum(0, 3)
        Loop

    End Sub

    Function GetNum(Optional ByVal min As Integer = Integer.MinValue,
                    Optional ByVal max As Integer = Integer.MaxValue) As Integer

        Dim num As Integer

        Console.Write("Introduce un numero: ")

        Do Until Integer.TryParse(Console.ReadLine(), num) And num >= min And num <= max
            Console.WriteLine("Tiene que ser un numero entre {0} y {1}.", min, max)
        Loop

        Return num

    End Function

End Module
