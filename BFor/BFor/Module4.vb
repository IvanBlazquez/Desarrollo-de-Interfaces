Module Module4
    Public Sub Main()
        Dim i, anios As Integer
        Dim it, capital As Single
        Console.WriteLine("Años: ")
        anios = CInt(Console.ReadLine())
        Console.WriteLine("Capital: ")
        capital = CSng(Console.ReadLine())
        Console.WriteLine("INteres")
        it = CSng(Console.ReadLine())
        Console.WriteLine("{0,3}  {1,17}", "Año", "Capital Acumulado")
        For i = 1 To anios
            capital += capital * it / 100
            Console.WriteLine("{0,3}  {1,17}", i, capital.ToString("#0.00"))
        Next
        Console.ReadLine()
    End Sub
End Module
