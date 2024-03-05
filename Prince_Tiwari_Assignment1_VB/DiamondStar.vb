Public Class DiamondStar
    Public Shared Sub Main(args As String())
        Dim n As Integer = Convert.ToInt32(Console.ReadLine())

        For i As Integer = 1 To n
            For j As Integer = 1 To n - i
                Console.Write(" ")
            Next j
            For k As Integer = 1 To (2 * i - 1)
                Console.Write("*")
            Next k
            Console.WriteLine()
        Next i

        For i As Integer = n - 1 To 1 Step -1
            For j As Integer = 1 To n - i
                Console.Write(" ")
            Next j
            For k As Integer = 1 To (2 * i - 1)
                Console.Write("*")
            Next k
            Console.WriteLine()
        Next i
    End Sub
End Class
