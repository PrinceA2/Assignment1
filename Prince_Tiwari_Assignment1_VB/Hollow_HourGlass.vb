Public Class Hollow_HourGlass
    Public Shared Sub Main(args As String())
        Dim n As Integer = Convert.ToInt32(Console.ReadLine())

        For i As Integer = n To 1 Step -1
            For j As Integer = 1 To n - i
                Console.Write(" ")
            Next j

            For k As Integer = 1 To (2 * i - 1)
                If k = 1 OrElse k = 2 * i - 1 OrElse i = n Then
                    Console.Write("*")
                Else
                    Console.Write(" ")
                End If
            Next k
            Console.WriteLine()
        Next i

        For i As Integer = 1 To n
            For j As Integer = 1 To n - i
                Console.Write(" ")
            Next j

            For k As Integer = 1 To (2 * i - 1)
                If k = 1 OrElse k = 2 * i - 1 OrElse i = n Then
                    Console.Write("*")
                Else
                    Console.Write(" ")
                End If
            Next k
            Console.WriteLine()
        Next i
    End Sub
End Class
