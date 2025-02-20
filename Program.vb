Imports System.IO

Module Module1
    Sub Main()
        ' Path ke file teks
        Dim filePath As String = "C:\Users\INFINIX X2\OneDrive\Desktop/Teknik manipulasi DOM.txt"

        
        Dim wordCount As Integer = CountWordsInFile(filePath)

        
        DisplayMessageBasedOnWordCount(wordCount)

        Console.ReadLine()
    End Sub

    
    Function CountWordsInFile(filePath As String) As Integer
        Dim wordCount As Integer = 0

      
        If File.Exists(filePath) Then
            Dim lines() As String = File.ReadAllLines(filePath)

           
            For Each line As String In lines
                Dim words() As String = line.Split(" "c)
                wordCount += words.Length
            Next
        Else
            Console.WriteLine("File tidak ditemukan!")
        End If

        Return wordCount
    End Function

    Sub DisplayMessageBasedOnWordCount(wordCount As Integer)
        '
        If wordCount < 10 Then
            Console.WriteLine("Teks terlalu pendek. Jumlah kata: " & wordCount)
        ElseIf wordCount >= 10 And wordCount <= 50 Then
            Console.WriteLine("Teks memiliki panjang yang cukup. Jumlah kata: " & wordCount)
        Else
            Console.WriteLine("Teks terlalu panjang. Jumlah kata: " & wordCount)
        End If
    End Sub
End Module
