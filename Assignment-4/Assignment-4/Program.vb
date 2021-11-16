Imports System

Module Program
    Sub Main()
        Dim nextChar, thisChar, finalChar As Char
        Dim Str1 As String
        Dim a, b, Count, Highest As Integer


        nextChar = ""
        thisChar = ""
        finalChar = ""
        Highest = 0
        Count = 0
        a = 0
        b = 0


        Console.WriteLine("Enter Text: ")
        Str1 = Console.ReadLine

        For a = 1 To Len(Str1)
            nextChar = Mid(Str1, a, 1)
            Count = 0
            For b = 1 To Len(Str1)
                thisChar = Mid(Str1, b, 1)
                If thisChar = nextChar Then Count = Count + 1
            Next

            If Count > Highest Then
                Highest = Count
                finalChar = nextChar
            End If
        Next

        Console.WriteLine(finalChar & " appeared " & Highest & " number of times")
        Console.ReadKey()





    End Sub
End Module
