Module Module1

    Sub Main()
        Dim Str1 As String = ""

        Console.WriteLine("Enter Text: ")
        Str1 = LCase(Console.ReadLine())

        For count = 1 To Len(Str1)
            For count2 = 1 To Len(Str1)
                If Mid(Str1, count, 3) = "not" And Mid(Str1, count2, 3) = "bad" Then

                    Str1 = Left(Str1, (count - 1)) & "good" & Mid(Str1, (count2 + 3), (Len(Str1)))
                End If
            Next
        Next

        Console.WriteLine(Str1)

        Console.ReadLine()
    End Sub

End Module