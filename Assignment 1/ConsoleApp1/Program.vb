Imports System

Module Program
    Sub Main()
        Dim a As Integer = 0
        Dim b As Char = ""
        Dim x As String = ""
        Dim c, e, d As Integer
        c = 0
        e = 0
        d = 0


        Console.WriteLine("Enter Text: ")
        x = Console.ReadLine

        For a = 1 To Len(x)
            b = Mid(x, a, 1)
            If Asc(b) >= 65 And Asc(b) <= 90 Then
                c = c + 1
            ElseIf Asc(b) >= 97 And Asc(b) <= 122 Then
                d = d + 1
            End If

        Next
        If c = Len(x) Then
            Console.WriteLine("Text  has capital letters ...")
        ElseIf d = Len(x) Then
            Console.WriteLine("Text  has small letters ...")
        Else
            Console.WriteLine("Text  has mixed or special letters ...")
        End If

        Console.ReadKey()




    End Sub
End Module
