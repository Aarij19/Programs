Module Module1

    Structure Node
        Dim dataItem As String
        Dim pointer As Integer
    End Structure

    Dim FreeListPointer, startPointer, nullPointer As Integer

    Dim MyList(5) As Node

    Sub Main()

        nullPointer = -1


        Call initialiseList()

        ''Hard-coded array
        MyList(0).dataItem = "a"
        'MyList(0).pointer = 1
        MyList(1).dataItem = "b"
        'MyList(1).pointer = 2
        MyList(2).dataItem = "c"
        'MyList(2).pointer = 3
        MyList(3).dataItem = "d"
        'MyList(3).pointer = 4
        MyList(4).dataItem = "e"
        'MyList(4).pointer = -1


        'Console.WriteLine(MyList(0).dataItem)
        'Console.WriteLine(MyList(0).pointer)
        'Console.WriteLine(MyList(1).dataItem)
        'Console.WriteLine(MyList(1).pointer)
        'Console.WriteLine(MyList(2).dataItem)
        'Console.WriteLine(MyList(2).pointer)
        'Console.WriteLine(MyList(3).dataItem)
        'Console.WriteLine(MyList(3).pointer)
        'Console.WriteLine(MyList(4).dataItem)
        'Console.WriteLine(MyList(4).pointer)

        startPointer = 0

        Dim searchedItemIndex As Integer
        searchedItemIndex = FindNode("g")
        Console.WriteLine(searchedItemIndex)
        Console.WriteLine("*************************************************")
        Call outputList()
        Console.ReadKey()

    End Sub

    Sub initialiseList()
        startPointer = nullPointer
        FreeListPointer = 0
        For count = 0 To 3
            MyList(count).dataItem = ""
            MyList(count).pointer = count + 1
        Next
        MyList(4).pointer = nullPointer
        Console.WriteLine("List Initialized.....................")
    End Sub

    Function FindNode(ByVal value As String) As Integer
        Dim currentNodePointer As Integer
        currentNodePointer = startPointer
        While currentNodePointer <> nullPointer And MyList(currentNodePointer).dataItem <> value
            currentNodePointer = MyList(currentNodePointer).pointer
        End While
        Return currentNodePointer
    End Function

    Sub outputList()
        Dim CurrentNodePointer As Integer
        CurrentNodePointer = startPointer

        Console.WriteLine(startPointer)
        If startPointer = nullPointer Then
            Console.WriteLine("List is empty")
        Else
            Console.WriteLine("************ showing linked-list ***********")
            While CurrentNodePointer <> nullPointer

                Console.WriteLine(MyList(CurrentNodePointer).dataItem)
                CurrentNodePointer = MyList(CurrentNodePointer).pointer

            End While
        End If

    End Sub
End Module
