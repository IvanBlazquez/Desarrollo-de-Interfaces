Module Module2
    Public Sub Main()
        Dim i, num As Integer
        Dim resp As String
        Do

            Console.WriteLine("Numero:")
            If Integer.TryParse(Console.ReadLine, num) Then
                For i = 1 To 10
                    Console.WriteLine("{0} X {1}={2}", num, i, num * i)
                Next
            Else
                Console.WriteLine("Debe Introducir un número")
            End If

            Console.WriteLine("Desea repetir")
            resp = Console.ReadLine().ToUpper
        Loop While resp.CompareTo("SI") = 0
    End Sub
End Module
