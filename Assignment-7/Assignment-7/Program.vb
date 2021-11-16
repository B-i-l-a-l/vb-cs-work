Imports System

Module Program
    Sub Main()
        Dim str1 As String = ""
        Dim count As Integer = 0
        Dim char1 As Char = ""
        Dim length As Boolean = True
        Dim char2 As Char = ""
        Dim char3 As Char = ""
        Dim char4 As Char = ""


        Console.WriteLine("Enter Text: ")
        str1 = Console.ReadLine
        If Len(str1) <= 2 Then
            length = False
        End If

        If length = False Then
            Console.WriteLine("Empty String")
            Console.ReadKey()
            Exit Sub


        End If

        For count = 1 To Len(str1)
            char1 = Left(str1, 1)

            char2 = Mid(str1, 2)

            char3 = Right(str1, 2)
            char4 = Right(str1, 1)






        Next

        Console.WriteLine("Final String is : " & char1 & char2 & char3 & char4)
        Console.ReadKey()




    End Sub
End Module
