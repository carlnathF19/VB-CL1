Module Program

    Sub Main(args As String())
        Dim userInput As String
        'Console.cls()  TODO: this don't work!!
        Console.WriteLine("Type your name and press Enter")
        userInput = Console.ReadLine()
        Console.WriteLine("You Entered " & userInput)
        apples()
        'Stop
        'Console.Clear()
    End Sub

    Sub apples()
        Dim applesSold As Integer
        applesSold = 10
        Console.WriteLine(applesSold)
    End Sub
End Module
