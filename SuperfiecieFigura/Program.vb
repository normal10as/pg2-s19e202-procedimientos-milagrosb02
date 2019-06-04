Imports System

Module SuperficieFigura
    Sub Main(args As String())
        Dim b, h, l, bmayor, bmenor, ht As Decimal
        Console.Write("Ingresar lado de cuadrado: ")
        l = Console.ReadLine()
        Console.Write("Ingresar base de rectangulo: ")
        b = Console.ReadLine()
        Console.Write("Ingresar altura de rectangulo: ")
        h = Console.ReadLine()
        Console.Write("Ingresar base mayor de trapecio: ")
        bmayor = Console.ReadLine()
        Console.Write("Ingresar base menor de trapecio: ")
        bmenor = Console.ReadLine()
        Console.Write("Ingresar altura de trapecio: ")
        ht = Console.ReadLine()

        Console.WriteLine("El area del cuadrado es: " & Calcular(l))
        Console.WriteLine("El area del rectangulo es: " & Calcular(b, h))
        Console.WriteLine("El area del trapecio es: " & Calcular(bmayor, bmenor, ht))

    End Sub
    Function Calcular(l As Decimal)
        Dim areacuadrado As Decimal
        areacuadrado = (l * l)
        Return areacuadrado
    End Function
    Function Calcular(b As Decimal, h As Decimal)
        Dim arearectangulo As Decimal
        arearectangulo = (b * h)
        Return arearectangulo
    End Function
    Function Calcular(bmayor As Decimal, bmenor As Decimal, ht As Decimal)
        Dim areatrapecio As Decimal
        areatrapecio = ((bmayor + bmenor) * ht) / 2
        Return areatrapecio
    End Function
End Module
