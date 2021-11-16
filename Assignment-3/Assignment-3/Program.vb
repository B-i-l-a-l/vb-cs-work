Imports System

Module Program
    Sub Main()
        Dim Str As String
        Dim char1, c As Char

        Dim Count, a, letterCount, specialCount As Integer

        Str =""
        char1 = ""
        c = ""
        Count = 0
        a = 0
        letterCount = 0
        specialCount = 0
        Console.Write("Enter Text: ")
        Str = Console.ReadLine
        Console.Write("Enter character to count: ")
        char1 = Console.ReadLine
        For Count = 1 To Len(Str)
            c = Mid(Str, Count, 1)
            If UCase(c) = UCase(char1) Then
                a = a + 1
            End If
            If Asc(c) >= 65 And Asc(c) <= 90 Or Asc(c) >= 97 And Asc(c) <= 122 Then
                letterCount = letterCount + 1
            Else
                specialCount = specialCount + 1
            End If
        Next
        Console.WriteLine("Character appeared " & a & " " & "time/s ")
        Console.WriteLine("Total Letters: " & letterCount)
        Console.WriteLine("Total Special Characters: " & specialCount)

    End Sub
End Module
