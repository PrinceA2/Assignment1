Public Class NumberTriangle
    Public Shared Sub Main(args As String())
        Dim n As Integer = Convert.ToInt32(Console.ReadLine())

        For i As Integer = 1 To n
            For j As Integer = 1 To n - i
                Console.Write(" ")
            Next j
            For j As Integer = 1 To i
                Console.Write(i & " ")
            Next j
            Console.WriteLine()
        Next i
    End Sub
End Class
