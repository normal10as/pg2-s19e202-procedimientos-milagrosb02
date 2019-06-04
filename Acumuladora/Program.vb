Imports System

Module Acumuladora
    Sub Main(args As String())
        Dim A As Decimal
        Dim valor As Decimal
        Console.WriteLine("Ingresar un valor decimal: ")
        A = Console.ReadLine()
        Acumular(valor)
        Console.WriteLine("Ingresar un valor decimal: ")
        A = Console.ReadLine()
        Acumular(valor)
        Console.WriteLine("Ingresar un valor decimal: ")
        A = Console.ReadLine()
        Acumular(valor)
    End Sub
    Sub Acumular(valor As Decimal)
        A = A + valor
        Console.WriteLine("El valor acumulado es: " & A)

    End Sub
End Module
