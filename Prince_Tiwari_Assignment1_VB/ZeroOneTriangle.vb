Public Class ZeroOneTriangle
    Public Shared Sub Main(args As String())
        Dim n As Integer = Convert.ToInt32(Console.ReadLine())
        Dim x As Integer = 1

        For i As Integer = 1 To n
            For j As Integer = 1 To i
                Console.Write(x & " ")
                If x = 1 Then
                    x = x - 1
                Else
                    x = x + 1
                End If
            Next j
            Console.WriteLine()
        Next i
    End Sub
End Class
