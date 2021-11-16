Imports System

Module Program
    Sub Main()
        Dim Str1 As String = ""
        Dim Char1 As Char = ""
        Dim Count As Integer = 0
        Dim Str2 As String = ""
        Dim vowelCount As Integer = 0

        Console.Write("Enter Text: ")
        Str1 = Console.ReadLine
        Str2 = UCase(Str1)

        For Count = 1 To Len(Str2)
            Char1 = Mid(Str2, Count, 1)
            If Char1 = "A" Or Char1 = "E" Or Char1 = "I" Or Char1 = "O" Or Char1 = "U" Then
                vowelCount = vowelCount + 1

            End If


        Next
        Console.WriteLine("Total number of Vowels: " & vowelCount)

        Console.ReadKey()



    End Sub
End Module
