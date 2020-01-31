Module Module1
    Dim Stack(8) As Integer
    Dim TopOfStackPointer = -1
    Const BaseOfStackPointer = 0
    Const FullStack = 8
    Const nullPointer = -1


    Sub Main()
        Dim CHOICE As Integer
        Do
            Console.WriteLine("ENTER (1) TO PUSH IN STACK")
            Console.WriteLine("ENTER (2) TO POP FROM STACK")
            Console.WriteLine("ENTER (3) TO EXIT FROM THIS PROGRAM")

            Console.WriteLine("Enter value to choose:")
            CHOICE = Console.ReadLine()

            If CHOICE = 1 Then
                
                Call Push()
            ElseIf CHOICE = 2 Then
                Call pop()
            End If

        Loop Until CHOICE = 3


    End Sub

    Sub Push()

        If TopOfStackPointer = FullStack Then
            Console.WriteLine("OverFlow of data as array is Full")
        Else

            Dim value As Integer
            Console.WriteLine("Enter value to be entered:")
            value = Console.ReadLine()

            TopOfStackPointer = TopOfStackPointer + 1
            Stack(TopOfStackPointer) = value

        End If
    End Sub

    Function pop() As Integer
        Dim value As Integer

        If TopOfStackPointer = nullPointer Then
            value = nullPointer
            Console.WriteLine("stack is empty!")

        Else

            value = Stack(TopOfStackPointer)
            TopOfStackPointer = TopOfStackPointer - 1
            Console.WriteLine("the value popped is :")

            Console.WriteLine(value)

        End If
        
        Return value
    End Function



End Module
