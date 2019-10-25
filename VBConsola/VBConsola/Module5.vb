Imports System.IO

Module Module5
    Public Sub main()
        Dim num As Integer
        Dim respuesta As String
        Dim cont1 As Integer
        Dim cont2 As Integer
        Dim i As Integer
        Dim consola As TextWriter
        Do
            Console.WriteLine("introduce un numero menor que 100:")
            consola = Console.Out
            Console.SetOut(New StreamWriter("salida.txt"))
            num = CInt(Console.ReadLine())
            Console.WriteLine("{0, 15}{1, 20}", "Valor", "Resultado")
            For i = 2 To 10

                If num Mod i = 0 Then
                    Console.WriteLine("{0, 15}{1, 20}", i.ToString, "divisible")
                    cont1 += 1
                Else
                    Console.WriteLine("{0, 15}{1, 20}", i.ToString, (num Mod i).ToString)
                    cont2 += 1
                End If
            Next
            Console.WriteLine("Divisibles {0}", cont1)
            Console.WriteLine("No divisibles {0}", cont2)
            Console.Out.Close()
            Console.SetOut(consola)
            Console.WriteLine("Desea continuar?")
            respuesta = Console.ReadLine()
        Loop While respuesta.ToUpper.CompareTo("SI") = 0

    End Sub
End Module
