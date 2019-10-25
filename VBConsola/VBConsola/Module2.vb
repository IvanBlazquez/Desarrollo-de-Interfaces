Imports System.IO

Module Module2
    Sub Main()
        Dim s As String
        Dim numero As Integer
        Dim i = 2
        Dim resultado As Integer
        Dim contador As Integer = 0
        Dim c As Integer = 0
        Dim aux As TextWriter
        Dim respuesta As String

        Do
            Console.WriteLine("Introduce un numero mayor que 100:")
            s = Console.ReadLine
            aux = Console.Out
            Console.SetOut(New StreamWriter("salida.txt"))
            numero = CInt(s)
            If numero > 100 Then
                Console.WriteLine("{0,15} {1,20}", "Valor", "Resultado")
                For i = 2 To 10
                    If numero Mod i <> 0 Then
                        Console.WriteLine("{0,15} {1,20}", i.ToString, "No Divisible")
                        c += 1
                    Else
                        resultado = numero / i
                        contador += 1
                        Console.WriteLine("{0,15} {1,20}", i.ToString, resultado.ToString)
                    End If


                Next
                Console.WriteLine("Divisibles:{0}", contador)
                Console.WriteLine("No divisibles:{0}", c)
                Console.ReadLine()
            End If
            Console.Out.Close()
            Console.SetOut(aux)
            Console.WriteLine("Quiere repetir?")
            respuesta = Console.ReadLine()
        Loop While respuesta.ToUpper.CompareTo("SI") = 0


    End Sub
End Module
