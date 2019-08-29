Imports System

Module Program
    Public Sub wait(ByVal seconds As Single)
        Static start As Single
        start = VB.Timer()
        Do While VB.Timer() < start + 5
            System.Windows.Forms.Application.DoEvents()
        Loop
    End Sub
    Sub Main(args As String())
        Dim userInput As String
        'Console.cls()  TODO: this don't work!!
        Console.WriteLine("Type your name and press Enter")
        userInput = Console.ReadLine()
        Console.WriteLine("You Entered " & userInput)
        Console.Clear()
    End Sub
End Module
