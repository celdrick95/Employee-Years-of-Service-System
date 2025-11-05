Imports System

Module Program
    Sub Main()
        Dim office As String
        Dim yrs As Integer

        Console.Write("Enter years in Service: ")
        yrs = Console.ReadLine()
        Console.Write("Enter Office: ")
        office = Console.ReadLine()

        If office = "IT" Then
            If yrs >= 10 Then
                Console.WriteLine("Years in Service: " & yrs.ToString())
                Console.WriteLine("Office: IT")
                Console.WriteLine("Years in Service: 10000")
            ElseIf yrs < 9 Then
                Console.WriteLine("Years in Service: " & yrs.ToString())
                Console.WriteLine("Office: IT")
                Console.WriteLine("Years in Service: 5000")
            End If

        ElseIf office = "ACCT" Then
            If yrs >= 10 Then
                Console.WriteLine("Years in Service: " & yrs.ToString())
                Console.WriteLine("Office: ACCT")
                Console.WriteLine("Years in Service: 12000")
            ElseIf yrs < 9 Then
                Console.WriteLine("Years in Service: " & yrs.ToString())
                Console.WriteLine("Office: ACCT")
                Console.WriteLine("Years in Service: 6000")
            End If

        ElseIf office = "HR" Then
            If yrs >= 10 Then
                Console.WriteLine("Years in Service: " & yrs.ToString())
                Console.WriteLine("Office: HR")
                Console.WriteLine("Years in Service: 15000")
            ElseIf yrs < 9 Then
                Console.WriteLine("Years in Service: " & yrs.ToString())
                Console.WriteLine("Office: HR")
                Console.WriteLine("Years in Service: 7500")
            End If
        End If

        Console.ReadLine()
    End Sub
End Module
