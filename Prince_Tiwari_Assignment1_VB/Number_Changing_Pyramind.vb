Public Class Number_Changing_Pyramind
    Public Shared Sub Main(args As String())
        Dim n As Integer = Convert.ToInt32(Console.ReadLine())
        Dim count As Integer = 1

        For i As Integer = 1 To n - 1
            For j As Integer = 1 To i
                Console.Write(count)
                count += 1
            Next j
            Console.WriteLine()
        Next i
    End Sub
End Class
