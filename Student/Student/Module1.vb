Class Student
    Protected StudentName As String
    Protected DateOfBirth As Date

    Public Sub ShowStudentName()
        Console.WriteLine(StudentName)
    End Sub
    Public Sub ShowDateOfBirth()
        Console.WriteLine(DateOfBirth)
    End Sub
End Class

Class FullTimeStudent
    Inherits Student
    Private Address As String
    Private TelNo As String

    Public Sub New(ByVal n As String, ByVal d As Date, ByVal a As String, ByVal t As String)
        StudentName = n
        DateOfBirth = d
        Address = a
        TelNo = t
    End Sub

    Public Sub showAddress()
        Console.WriteLine(Address)
    End Sub
    Public Sub ShowTelNo()
        Console.WriteLine(TelNo)
    End Sub
End Class

Class PartTimeStudent
    Inherits Student
    Private NoOfCourses As Integer
    Private FeePaid As Boolean
    Private TotalFee As Decimal

    Public Sub New(ByVal n As String, ByVal d As Date, ByVal c As Integer, ByVal f As Boolean, ByVal t As Decimal)
        StudentName = n
        DateOfBirth = d
        NoOfCourses = c
        FeePaid = f
        TotalFee = t
    End Sub

    Public Sub showNoOfCourses()
        Console.WriteLine(NoOfCourses)
    End Sub
    Public Sub ShowTotalFee()
        Console.WriteLine(TotalFee)
    End Sub
    Public Sub ShowFeePaid()
        Console.WriteLine(FeePaid)
    End Sub


End Class

Module Module1

    Sub Main()
        Dim NewStudent As FullTimeStudent = New FullTimeStudent("A.Nyone", #12/11/1990#, "house no 43/ sadf area", "099111")
        NewStudent.ShowStudentName()
        NewStudent.showAddress()
        NewStudent.ShowDateOfBirth()
        NewStudent.ShowTelNo()


        Console.ReadKey()
    End Sub

End Module
