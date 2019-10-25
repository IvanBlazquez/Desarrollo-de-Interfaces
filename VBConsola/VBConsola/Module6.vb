Module Module6
    Public Sub Main()
        Dim num As Integer
        Dim texto As String

        Console.Write("Introduce un numero: ")
        texto = Console.ReadLine
        num = Integer.Parse(texto)

        Do While num < 0 Or num > 3
            Console.Write("Introduce un numero: ")
            texto = Console.ReadLine
            num = Integer.Parse(texto)
        Loop

        Do Until num = 0
            Dim num1 As Integer
            Dim num2 As Integer
            Dim aux As Integer

            If num = 1 Then
                Console.Write("Introduce un numero: ")
                texto = Console.ReadLine
                num1 = Integer.Parse(texto)

                Console.Write("Introduce otro numero: ")
                texto = Console.ReadLine
                num2 = Integer.Parse(texto)

                aux = num1
                num1 = num2
                num2 = aux

                Console.WriteLine("num1: {0}  num2: {1} ", num1, num2)
            ElseIf num = 2 Then
                Console.Write("Introduce un numero: ")
                texto = Console.ReadLine
                num1 = Integer.Parse(texto)

                Console.Write("Introduce otro numero: ")
                texto = Console.ReadLine
                num2 = Integer.Parse(texto)

                If num1 Mod num2 = 0 Then
                    Console.WriteLine("Es divisible")
                Else
                    Console.WriteLine("No es divisible")


                End If
            Else
                Console.Write("Introduce un numero: ")
                texto = Console.ReadLine
                num1 = Integer.Parse(texto)

                Console.Write("Introduce otro numero: ")
                texto = Console.ReadLine
                num2 = Integer.Parse(texto)

                If num2 Mod num1 = 0 Then
                    Console.WriteLine("Es divisible")
                Else
                    Console.WriteLine("No es divisible")
                End If

            End If
            Console.Write("Introduce un numero: ")
            texto = Console.ReadLine
            num = Integer.Parse(texto)

            Do While num < 0 Or num > 3
                Console.Write("Introduce un numero: ")
                texto = Console.ReadLine
                num = Integer.Parse(texto)
            Loop
        Loop



    End Sub

End Module
