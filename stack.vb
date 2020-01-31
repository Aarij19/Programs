Module Module1
    Dim stack(10) As Integer
    Dim headPointer As Integer

    Sub Push(ByVal value As Integer)
        HeadPointer = HeadPointer + 1
        stack(headPointer) = value
    End Sub

    Sub Pop()
        stack(headPointer) = 10000
        headPointer = headPointer - 1
    End Sub


    Public Sub Main()
        headPointer = -1

        Push(25)
        Push(615)
        Push(517)
        Push(350)
        Console.WriteLine(headPointer)
        For i = 0 To headPointer
            Console.WriteLine(stack(i))
        Next

        Pop()
        Pop()
        Console.WriteLine(headPointer)
        For i = 0 To headPointer
            Console.WriteLine(stack(i))
        Next
        Console.ReadKey()
    End Sub

    


    

End Module

