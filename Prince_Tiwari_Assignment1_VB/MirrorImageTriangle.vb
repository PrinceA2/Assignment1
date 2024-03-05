Public Class MirrorImageTriangle
    Public Shared Sub Main(args As String())
        Dim n As Integer = Convert.ToInt32(Console.ReadLine())

        For i As Integer = 1 To n
            For j As Integer = 1 To i - 1
                Console.Write(" ")
            Next j
            For k As Integer = i To n
                Console.Write(k & " ")
            Next k
            Console.WriteLine()
        Next i

        For i As Integer = n To 2 Step -1
            For j As Integer = 2 To i - 1
                Console.Write(" ")
            Next j
            For k As Integer = i - 1 To n
                Console.Write(k & " ")
            Next k
            Console.WriteLine()
        Next i
    End Sub
End Class
