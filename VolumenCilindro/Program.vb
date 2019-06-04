Imports System.Math

Module VolumenCilindro
    Sub Main(args As String())
        Dim r As Double
        Dim h As Double
        Console.Write("Ingresar base: ")
        r = Console.ReadLine()
        Console.Write("Ingresar altura: ")
        h = Console.ReadLine()
        Console.Write("El volumen del cilindro es: " & CalculoVolumen(r, h))
    End Sub

    Function CalculoVolumen(r As Double, h As Double)
        Dim volumen As Double
        Const Pi As Double = 3.14159265
        volumen = (Pi * r ^ 2 * h)
        Return volumen

    End Function
End Module
