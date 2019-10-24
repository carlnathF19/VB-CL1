Module Program

    Sub Main(args As String())
        Dim userInput As String
        Dim joe As String
        joe = "Joe"
        Dim emily As String
        emily = "Emily"
        Console.WriteLine("Type your name and press Enter")
        userInput = Console.ReadLine()
        If (userInput = joe) Then
            Console.WriteLine("How does it go " & userInput & "?")
        End If
        If (userInput = emily) Then
            Console.WriteLine("Hi " & userInput & ".")
        End If
        If (userInput = "Nathan") Then
            Console.WriteLine("BANANAS!")
        End If

    End Sub

End Module
