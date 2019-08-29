Imports System

Module Beeper

    Sub Main()  'You cannot do Sub Main() Console.Beep() on the same line, there has to be a carriage return after Sub Main()'
        Console.Beep(392, 500) 'G4' 'first number is frequency in hertz, second is time in ms'
        Console.Beep(440, 500) 'A4' 'first number is frequency in hertz, second is time in ms'
        Console.Beep(349, 500) 'F4' 'first number is frequency in hertz, second is time in ms'
        Console.Beep(196, 500) 'G3' 'first number is frequency in hertz, second is time in ms'
        Console.Beep(262, 500) 'G4' 'first number is frequency in hertz, second is time in ms'
    End Sub


End Module
