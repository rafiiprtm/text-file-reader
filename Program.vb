Imports System.IO

Module Module1
    Sub Main()
        ' Path ke file teks
        Dim filePath As String = "C:\Users\INFINIX X2\OneDrive\Desktop/Teknik manipulasi DOM.txt"

        ' Memanggil procedure untuk membaca file dan menghitung kata
        Dim wordCount As Integer = CountWordsInFile(filePath)

        ' Memanggil procedure untuk menampilkan pesan berdasarkan jumlah kata
        DisplayMessageBasedOnWordCount(wordCount)

        Console.ReadLine()
    End Sub

    ' Procedure untuk membaca file dan menghitung kata
    Function CountWordsInFile(filePath As String) As Integer
        Dim wordCount As Integer = 0

        ' Membaca file teks
        If File.Exists(filePath) Then
            Dim lines() As String = File.ReadAllLines(filePath)

            ' Perulangan untuk menghitung kata dalam setiap baris
            For Each line As String In lines
                Dim words() As String = line.Split(" "c)
                wordCount += words.Length
            Next
        Else
            Console.WriteLine("File tidak ditemukan!")
        End If

        Return wordCount
    End Function

    ' Procedure untuk menampilkan pesan berdasarkan jumlah kata
    Sub DisplayMessageBasedOnWordCount(wordCount As Integer)
        ' Percabangan berdasarkan jumlah kata
        If wordCount < 10 Then
            Console.WriteLine("Teks terlalu pendek. Jumlah kata: " & wordCount)
        ElseIf wordCount >= 10 And wordCount <= 50 Then
            Console.WriteLine("Teks memiliki panjang yang cukup. Jumlah kata: " & wordCount)
        Else
            Console.WriteLine("Teks terlalu panjang. Jumlah kata: " & wordCount)
        End If
    End Sub
End Module