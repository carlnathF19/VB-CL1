Imports System

Module Program
    Sub Main(args As String())
        Dim userInput As String
        'Console.cls()  TODO: this don't work!!
        Console.WriteLine("Type your name and press Enter")
        userInput = Console.ReadLine()
        Console.WriteLine("Hello " & userInput & "!")
    End Sub

End Module
