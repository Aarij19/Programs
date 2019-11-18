
MustInherit Class Employee
    Protected EmployeeName As String
    Protected EmployeeID As String
    Protected AmountPaidThisMonth As Integer

    Public Sub setEmployeeName(ByVal name As String)
        EmployeeName = name
    End Sub

    Public Function getEmployeeName() As String
        Return EmployeeName
    End Function

    Public Sub setEmployeeID(ByVal ID As String)
        EmployeeID = ID
    End Sub

    Public Overridable Sub CalculatePay()
    End Sub
End Class

Class HourlyPaidEmployee
    Inherits Employee
    Private hourlyRate As Decimal
    Private NoOfHours As Integer

    Public Sub New(ByVal n As String, ByVal i As String, ByVal a As Decimal, ByVal h As Decimal, ByVal nh As Integer)

        EmployeeName = n
        EmployeeID = i
        AmountPaidThisMonth = a
        hourlyRate = h
        NoOfHours = nh

    End Sub


    Public Overrides Sub CalculatePay()
        Dim wage As Decimal
        wage = hourlyRate * NoOfHours
        Console.WriteLine(wage)
    End Sub





End Class

Class SalariedEmployee
    Inherits Employee
    Private AnnualSalary As Decimal

    Public Sub New(ByVal n As String, ByVal i As String, ByVal a As Decimal, ByVal s As Decimal)
        EmployeeName = n
        EmployeeID = i
        AmountPaidThisMonth = a
        AnnualSalary = s

    End Sub





    Public Overrides Sub CalculatePay()
        Dim monthlywage As Decimal
        monthlywage = AnnualSalary / 12
        Console.WriteLine(monthlywage)
    End Sub


End Class



Module Module1

    Sub Main()

        Dim myemployee1 As HourlyPaidEmployee = New HourlyPaidEmployee("Aarij", "2018114", 2000.0, 500, 6)
        Dim myemployee222 As SalariedEmployee = New SalariedEmployee("maroof", "2018999", 4000.0, 35000.0)

        myemployee1.CalculatePay()
        myemployee222.CalculatePay()

        Console.WriteLine(myemployee1.getEmployeeName())

        myemployee1.setEmployeeName("hasan")

        Console.WriteLine(myemployee1.getEmployeeName())
        Console.ReadKey()
    End Sub

End Module



