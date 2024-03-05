Public Class Reverse_Numb_Inc
    Public Shared Sub Main(args As String())
        Dim n As Integer = Convert.ToInt32(Console.ReadLine())

        For i As Integer = n To 1 Step -1
            For j As Integer = 1 To i
                Console.Write(j)
            Next j
            Console.WriteLine()
        Next i
    End Sub
End Class
