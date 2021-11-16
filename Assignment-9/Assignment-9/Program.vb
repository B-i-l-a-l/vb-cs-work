Imports System

Module Program
    Sub Main()
        Dim stra As String = ""
        Dim strb As String = ""
        Dim Count As Integer = 0
        Dim Char1 As Char = ""
        Dim Char2 As Char = ""
        Dim Char3 As Char = ""
        Dim Char4 As Char = ""
        Dim finalStr As String = ""
        Dim currentChar As Char = ""

        Console.WriteLine("Enter Phrase1: ")
        stra = Console.ReadLine
        Console.WriteLine("Enter Phrase2: ")
        strb = Console.ReadLine


        Char1 = Left(stra, 1)
        Char2 = Mid(stra, 2)
        Char3 = Left(strb, 1)
        Char4 = Mid(strb, 2)

        finalStr = stra & " " & strb
        For Count = 1 To Len(finalStr)
            currentChar = Mid(finalStr, Count, 1)
            If currentChar = Char1 Then
                currentChar = Char3
            ElseIf currentChar = Char2 Then
                currentChar = Char4
            ElseIf currentChar = Char3 Then
                currentChar = Char1
            ElseIf currentChar = Char4 Then
                currentChar = Char2


            End If

            Console.Write(currentChar)


        Next


    End Sub
End Module
