Imports System

Module Program
    Sub Main(args As String())

        Console.Write("Número para a: ")
        Dim a As Integer = Console.ReadLine()
        Console.Write("Numero para b: ")
        Dim b As Integer = Console.ReadLine()
        Dim sum As Integer = a + b
        Console.WriteLine("El resultado para esta suma es " & sum)

    End Sub
End Module
