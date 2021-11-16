Imports System

Module Program
    Sub Main()
        Dim Donuts As Integer = 0
        Dim Count As Integer = 0


        Console.WriteLine("Enter number of Donuts required")
        Donuts = Console.ReadLine

        If Donuts >= 10 Then
            Console.WriteLine("Number of Donuts: many ")

        Else
            Console.WriteLine("Number of Donuts: " & Donuts)

        End If

        Console.ReadKey()


    End Sub
End Module
