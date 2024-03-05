Public Class Rhombus_Pattern
    Public Shared Sub Main(args As String())
        Dim n As Integer = Convert.ToInt32(Console.ReadLine())

        For i As Integer = 1 To n
            For j As Integer = 1 To n - i
                Console.Write(" ")
            Next j
            For k As Integer = 1 To n
                Console.Write("*")
            Next k
            Console.WriteLine()
        Next i
    End Sub
End Class
