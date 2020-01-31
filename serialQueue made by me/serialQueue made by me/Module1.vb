Module Module1
    Dim queue(5) As String
    Dim frontPointer, endPointer As Integer

    Sub Main()
        frontPointer = 0
        endPointer = -1
        Dim choice As Integer
        Do
            Console.WriteLine("1) to push value in queue")
            Console.WriteLine("2) to pop value in queue")
            Console.WriteLine("3) to exit from program")
            Do

                Console.WriteLine("enter your choice:")
                choice = Console.ReadLine()
                Select Case choice
                    Case 1 : Call push()
                    Case 2 : Call pop()
                End Select

            Loop Until choice >= 1 And choice <= 3
        Loop Until choice = 3

       
    End Sub

    Sub push()
        If endPointer >= 4 Then
            Console.WriteLine("not enough space available")

        Else
            Dim value As String
            Console.WriteLine("enter value to push:")
            value = Console.ReadLine()
            queue(endPointer + 1) = value
            endPointer = endPointer + 1
            Console.WriteLine("value has been pushed which is:" + value)

        End If
        
    End Sub

    Sub pop()
        Dim value As String
        If frontPointer > endPointer Then
            Console.WriteLine("Array is empty hence no value to pop!")
        Else
            value = queue(frontPointer)
            queue(frontPointer) = "*"
            Console.WriteLine(value + " has been popped!")
            frontPointer = frontPointer + 1
        End If


    End Sub



End Module
