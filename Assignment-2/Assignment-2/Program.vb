Imports System

Module Program
    Sub Main()
        Dim x As String = ""
        Dim currentChar As Char = ""
        Dim Char1 As Char = ""
        Dim Char2 As Char = ""
        Dim a As Integer = 0
        Dim firstCount As Integer = 0
        Dim Str2 As String = ""


        Console.WriteLine("Enter Text: ")
        x = Console.ReadLine
        Console.WriteLine("Enter character to replace: ")
        Char1 = Console.ReadLine
        Console.WriteLine("Enter character to be replaced with: ")
        Char2 = Console.ReadLine



        For a = 1 To Len(x)
            currentChar = Mid(x, a, 1)
            If currentChar = Char1 Then
                currentChar = Char2


            End If
            Str2 = Str2 & currentChar





        Next

        Console.WriteLine(Str2)


        Console.ReadKey()



    End Sub
End Module
