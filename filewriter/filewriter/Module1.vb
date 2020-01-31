Option Explicit On
Imports System.IO

Structure Car
    Dim VehicleID As String
    Dim colour As String
    Dim carName As String
End Structure





Module Module1

    Sub Main()
        Dim CarArray(3) As Car

        CarArray(0).VehicleID = "agv708"
        CarArray(0).colour = "silver"
        CarArray(0).carName = "city"
        CarArray(1).VehicleID = "f3606"
        CarArray(1).colour = "white"
        CarArray(1).carName = "khyber"
        CarArray(2).VehicleID = "aux123"
        CarArray(2).colour = "black"
        CarArray(2).carName = "civic"

        Dim carfileWriter As BinaryWriter
        Dim carfile As FileStream


        carfile = New FileStream("carfile.dat", FileMode.Create)
        carfileWriter = New BinaryWriter(carfile)

        For x = 0 To 2
            carfileWriter.Write(CarArray(x).VehicleID)
            carfileWriter.Write(CarArray(x).colour)
            carfileWriter.Write(CarArray(x).carName)
        Next
        carfileWriter.Close()
        carfile.Close()

        Dim carfilereader As BinaryReader

        carfile = New FileStream("carfile.dat", FileMode.Open)
        carfilereader = New BinaryReader(carfile)

        Dim cararray2(3) As Car

        Dim i = 0
        Do While carfile.Position < carfile.Length
            'Console.WriteLine(carfile.Position)
            'Console.WriteLine(carfile.Length)
            cararray2(i).VehicleID = carfilereader.ReadString()
            cararray2(i).colour = carfilereader.ReadString()
            cararray2(i).carName = carfilereader.ReadString()
            i = i + 1
        Loop

        For j = 0 To 2
            Console.WriteLine(cararray2(j).VehicleID)
            Console.WriteLine(cararray2(j).colour)
            Console.WriteLine(cararray2(j).carName)
        Next


        carfilereader.Close()
        carfile.Close()
        Console.ReadKey()






    End Sub

End Module
