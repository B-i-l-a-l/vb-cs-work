
Imports System

Module Program
    Sub Main()
        Dim firstChar As Char = ""
        Dim secChar As Char = "*"
        Dim Str1 As String = ""
        Dim Str2 As String = ""
        Dim Count As Integer = 0

        Console.WriteLine("Enter Text: ")
        Str1 = Console.ReadLine
        firstChar = Left(Str1, 1)
        Console.Write(firstChar)
        For Count = 1 To Len(Str1)
            secChar = Mid(Str1, Count + 1, 1)
            If secChar = firstChar Then
                secChar = "*"

            End If

            Console.Write(secChar)

        Next

        Console.ReadKey()

    End Sub
End Module
