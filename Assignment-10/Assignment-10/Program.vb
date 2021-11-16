Imports System

Module Program
    Sub Main()
        Dim str1 As String = ""
        Dim str2 As String = "ing"
        Dim str3 As String = ""
        Dim finalStr As String = ""
        Dim Count As Integer = 0

        Console.WriteLine("Enter Phrase: ")
        str1 = Console.ReadLine

        For Count = 1 To Len(str1)
            str3 = Right(str1, 3)

            If Len(str1) >= 3 And Right(str1, 3) <> str2 Then
                finalStr = str1 & str2
            ElseIf Len(str1) < 3 Then
                Console.WriteLine(str1)
                finalStr = ""

                Exit For

            End If



        Next



        If str3 = str2 Then
            str3 = "ly"
            Console.Write(str1 & str3)
        Else str3 = ""


        End If

        Console.WriteLine(finalStr)

        Console.ReadKey()

    End Sub
End Module
