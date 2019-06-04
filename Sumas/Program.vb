Imports System

Module Sumas
    Sub Main(args As String())
        Dim n1, n2, n3, n4 As Integer
        Console.Write("Ingresar primer numero: ")
        n1 = Console.ReadLine()
        Console.Write("Ingresar segundo numero: ")
        n2 = Console.ReadLine()
        Console.Write("Ingresar tercer numero: ")
        n3 = Console.ReadLine()
        Console.Write("Ingresar cuarto numero: ")
        n4 = Console.ReadLine()

        Console.WriteLine("N1+N2: " & Suma(n1, n2))
        Console.WriteLine("N2 + N3 + N4: " & Suma(n2, n3, n4))
        Console.WriteLine("N1+N2+N3+N4: " & Suma(n1, n2, n3, n4))

    End Sub
    Function Suma(n1, n3)
        Return n1 + n3
    End Function
    Function Suma(n2, n3, n4)
        Return n2 + n3 + n4
    End Function
    Function Suma(n1, n2, n3, n4)
        Return n1 + n2 + n3 + n4
    End Function
End Module
