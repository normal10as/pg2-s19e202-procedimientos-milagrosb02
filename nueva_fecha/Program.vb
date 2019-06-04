Imports System.DateTime

Module NuevaFecha
    Sub Main(args As String())
        Dim dia As Integer
        Dim fecha As Date
        Console.WriteLine("Ingresar dias: ")
        dia = Console.ReadLine()
        Console.WriteLine("Ingresar una fecha: ")
        fecha = Console.ReadLine()
        Console.WriteLine("El valor obtenido es: " & ValorFecha(dia, fecha))

    End Sub

    Function ValorFecha(dia As Integer, fecha As Date)
        Return fecha.AddDays(dia)
    End Function
End Module

