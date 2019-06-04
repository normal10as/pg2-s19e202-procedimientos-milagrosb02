Imports System.Math

Module Potencias
    Sub Main(args As String())
        Dim valor As Integer
        Console.WriteLine("Ingresar un valor: ")
        valor = Console.ReadLine()
        Console.WriteLine("Valor obtenido: " & Potencia2(valor))
        Console.WriteLine("Valor obtenido: " & Potencia3(valor))
        Console.WriteLine("Valor obtenido: " & Potencia5(valor))

    End Sub
    Function Potencia2(valor As Integer)
        valor = Math.Pow(valor, 2)
        Return valor
    End Function

    Function Potencia3(valor As Integer)
        valor = Math.Pow(valor, 3)
        Return valor
    End Function
    Function Potencia5(valor As Integer)
        valor = Math.Pow(valor, 5)
        Return valor

    End Function
End Module
