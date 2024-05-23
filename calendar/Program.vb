Imports System
Imports Microsoft.VisualBasic.DateAndTime

Module Program
    Sub Main()
        Dim year As Integer
        Console.Write("Enter a year: ")
        If Not Integer.TryParse(Console.ReadLine(), year) Then
            Console.WriteLine("Invalid year input.")
            Exit Sub
        End If

        For monthIndex As Integer = 1 To 12
            Dim firstDayOfMonth As String = monthIndex.ToString("00") & "/01/" & year.ToString()
            Dim firstDayDate As Date = Date.ParseExact(firstDayOfMonth, "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture)

            Dim firstDayOfWeek As Integer = DateAndTime.Weekday(firstDayDate)

            Console.WriteLine()
            Console.WriteLine(MonthName(monthIndex) & " " & year)
            Console.WriteLine("Sun  Mon  Tue  Wed  Thu  Fri  Sat")
            For Spaces As Integer = 1 To firstDayOfWeek - 1
                Console.Write("     ")
            Next

            Dim totalMonthDays = DateTime.DaysInMonth(year, monthIndex)
            For day As Integer = 1 To totalMonthDays
                Dim currentDateProcessing As String = monthIndex.ToString("00") & "/" & day.ToString("00") & "/" & year.ToString()
                Dim currentDayProcessing As Integer = DateAndTime.Weekday(currentDateProcessing)
                If currentDayProcessing = 7 Then
                    Console.WriteLine(day.ToString("00") & "   ")
                Else
                    Console.Write(day.ToString("00") & "   ")
                End If
            Next
            Console.WriteLine()
        Next

    End Sub
End Module
