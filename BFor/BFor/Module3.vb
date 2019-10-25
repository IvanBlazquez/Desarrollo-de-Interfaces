Module Module3
    Const ELEMS As Integer = 20
    Sub Main()
        Dim i, num, suma As Integer
        For i = 1 To ELEMS
            Console.WriteLine("Numero {0}", i)
            num = CInt(Console.ReadLine)
            suma += num
        Next
        Console.WriteLine("La suma es {0}", suma)
        Console.WriteLine("La media es {0}", suma / ELEMS)
        Console.ReadLine()
    End Sub
End Module
