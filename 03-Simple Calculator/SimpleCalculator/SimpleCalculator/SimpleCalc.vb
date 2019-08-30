Module Program

    Sub Main(args As String())
        Dim num1 As Integer
        Dim num2 As Integer
        Dim mathoperator As Integer
        'Dim userInput As String
        Console.WriteLine("Choose a Number")
        num1 = Console.ReadLine()
        Console.WriteLine("Choose a Number")
        num2 = Console.ReadLine()
        Console.WriteLine("Choose one of the following options:")
        Console.WriteLine("1. Sum")
        Console.WriteLine("2. Product")
        mathoperator = Console.ReadLine()
        If (mathoperator = 1) Then
            Console.WriteLine(value:=num1 + num2)
        End If
        If (mathoperator = 2) Then
            Console.WriteLine(value:=num1 * num2)
        End If
        'Stop
        'Console.Clear()

    End Sub

    Sub apples()
        Dim applesSold As Integer
        applesSold = 10
        Console.WriteLine(applesSold)
    End Sub

End Module
