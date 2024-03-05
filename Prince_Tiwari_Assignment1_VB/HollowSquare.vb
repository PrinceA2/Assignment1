Public Class HollowSquare
    Public Shared Sub Main(args As String())
        Dim n As Integer = Convert.ToInt32(Console.ReadLine())

        For i As Integer = 0 To n - 1
            For j As Integer = 0 To n - 1
                If i = 0 OrElse i = n - 1 OrElse j = 0 OrElse j = n - 1 Then
                    Console.Write("*")
                Else
                    Console.Write(" ")
                End If
            Next j
            Console.WriteLine()
        Next i
    End Sub
End Class
