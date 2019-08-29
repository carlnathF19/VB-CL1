Imports System

Module Beeper

    Sub Main()  'You cannot do Sub Main() Console.Beep() on the same line, there has to be a carriage return after Sub Main()'
        Console.Beep() 'G4' 'first number is frequency in hertz, second is time in ms'
        OtherBeep()

    End Sub

    Sub OtherBeep()
        'other code'
        if 1 > 2 then
	    Console.WriteLine("yes 1 > 2") 'do stuff'
	else
	    Console.WriteLine("no 1 < 2") 'do stuff' 
	end if   
        
    End Sub

End Module
