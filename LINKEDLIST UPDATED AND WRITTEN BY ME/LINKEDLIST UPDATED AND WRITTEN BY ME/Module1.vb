Module Module1
    Structure Node
        Dim dataItem As String
        Dim pointer As Integer
    End Structure

    Dim FreeListPointer, startPointer, nullPointer As Integer

    Dim MyList(7) As Node





    Sub Main()
        nullPointer = -1
        Call initialiseList()

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
        'Console.WriteLine(MyList(5).dataItem)
        'Console.WriteLine(MyList(5).pointer)
        'Console.WriteLine(MyList(6).dataItem)
        'Console.WriteLine(MyList(6).pointer)
        Call insertNode("A")
        Call insertNode("M")
        Call insertNode("D")

        Call outputList()
        Console.WriteLine(startPointer)
        Console.WriteLine(FreeListPointer)
        Console.WriteLine(nullPointer)
        Console.ReadKey()
    End Sub


    Sub initialiseList()
        startPointer = nullPointer
        FreeListPointer = 0
        For count = 0 To 5
            MyList(count).pointer = count + 1
        Next
        MyList(6).pointer = nullPointer
        Console.WriteLine("List Initialized .....................")
    End Sub

    Sub insertNode(ByVal value As String)
        Dim NewNodePointer, ThisNodePointer, PreviousNodePointer As Integer

        

        If FreeListPointer <> nullPointer Then

            If startPointer = nullPointer Then

                startPointer = FreeListPointer
                MyList(FreeListPointer).dataItem = value
                FreeListPointer = MyList(FreeListPointer).pointer
                Console.WriteLine("node added at start of list.........")

            Else

                NewNodePointer = FreeListPointer
                MyList(NewNodePointer).dataItem = value
                FreeListPointer = MyList(FreeListPointer).pointer

                ThisNodePointer = startPointer
                While ThisNodePointer <> nullPointer And MyList(NewNodePointer).dataItem < value
                    PreviousNodePointer = ThisNodePointer
                    ThisNodePointer = MyList(ThisNodePointer).pointer
                    Console.WriteLine("insertion point found............")
                End While

                If ThisNodePointer = startPointer Then

                    startPointer = NewNodePointer
                    MyList(NewNodePointer).pointer = ThisNodePointer
                    Console.WriteLine("node added at start.............")

                Else

                    MyList(PreviousNodePointer).pointer = NewNodePointer
                    MyList(NewNodePointer).pointer = ThisNodePointer
                    Console.WriteLine("node added in the list..................")
                End If

            End If
        End If
    End Sub





    Function FindNode(ByVal value As String) As Integer
        Dim currentNodePointer As Integer
        currentNodePointer = startPointer
        While currentNodePointer <> nullPointer And MyList(currentNodePointer).dataItem <> value
            currentNodePointer = MyList(currentNodePointer).pointer
        End While
        Return currentNodePointer
    End Function

    Sub deleteNode(ByVal value As String)
        Dim ThisNodePointer, previousNodePointer As Integer
        ThisNodePointer = startPointer
        While ThisNodePointer <> nullPointer And MyList(ThisNodePointer).dataItem <> value
            previousNodePOinter = ThisNodePointer
            ThisNodePointer = MyList(ThisNodePointer).pointer

        End While

        If ThisNodePointer <> nullPointer Then

            If ThisNodePointer = startPointer Then
                startPointer = MyList(ThisNodePointer).pointer
            Else
                MyList(previousNodePointer).pointer = MyList(ThisNodePointer).pointer

            End If
            MyList(ThisNodePointer).pointer = FreeListPointer
            FreeListPointer = ThisNodePointer

        End If

        Console.WriteLine("Item not found in this array")
    End Sub



    Sub outputList()
        Dim CurrentNodePointer As Integer
        CurrentNodePointer = startPointer

        If startPointer = nullPointer Then
            Console.WriteLine("List is empty .........!!!")
        Else
            Console.WriteLine("************ showing linked-list ***********")
            While CurrentNodePointer <> nullPointer

                Console.WriteLine(MyList(CurrentNodePointer).dataItem)
                CurrentNodePointer = MyList(CurrentNodePointer).pointer

            End While
            Console.WriteLine("************ linked-list end ***********")
        End If
    End Sub


End Module
