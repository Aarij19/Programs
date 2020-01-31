Module Module1
    Structure node
        Dim data As String
        Dim pointer As Integer
    End Structure

    Dim startpointer, freelistpointer, nullpointer As Integer

    Dim list(10) As node


    Sub Main()
        nullpointer = -1
        startpointer = nullpointer
        freelistpointer = 0

        Call initialize()
        Console.ReadKey()
    End Sub

    Sub initialize()
        startpointer = 0
        For index = 0 To 8
            list(index).pointer = index + 1
        Next
        list(9).pointer = nullpointer

    End Sub

    Sub insertNode(ByVal value As String)
        list(freelistpointer).data = value
        freelistpointer = freelistpointer + 1

    End Sub

    Sub displayLinkedlist()
        For counter = startpointer To freelistpointer - 1
            Console.WriteLine(list(counter).data + " & " + list(counter).pointer)

        Next

    End Sub

End Module
