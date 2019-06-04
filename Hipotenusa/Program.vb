Imports System.Math

Module Program
    Sub Main(args As String())
        Dim A As Double
        Dim B As Double

        Console.WriteLine("Ingresar lado A: ")
        A = Console.ReadLine()
        Console.WriteLine("Ingresar lado B: ")
        B = Console.ReadLine()
        Console.WriteLine("El resultado es: " & CalculoHipotenusa(A, B))


    End Sub
    Function CalculoHipotenusa(A, B) As Double
        Dim C As Double
        C = Math.Sqrt(A ^ 2 + B ^ 2)
        Return C
    End Function
End Module




