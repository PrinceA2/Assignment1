Public Class PalindromeTriangle
    Public Shared Sub Main(args As String())
        Dim n As Integer = Convert.ToInt32(Console.ReadLine())

        For i As Integer = 1 To n
            Dim count As Integer = i
            For j As Integer = 1 To n - i
                Console.Write(" ")
            Next j

            For k As Integer = 1 To i
                Console.Write(count)
                count -= 1
            Next k

            For m As Integer = 2 To i
                Console.Write(m)
            Next m
            Console.WriteLine()
        Next i
    End Sub
End Class
