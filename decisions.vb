Module Module1

	Sub Main()

	Console.WriteLine("Please type something and press enter")
	Dim userValue = As String

	userValue = Console.RedaLine()
	Console.Write("You typed: " & userValue)
	Console.ReadLine()

	Console.WriteLine("Would you perfer what is behind number 1, 2 or 3?")

	Dim userValue As String = Console.ReadLine()

	If uservalue = "1" Then
		Console.WriteLine("You won a new car!")
		Console.ReadLine()
	ElseIf uservalue = "2" Then
		Console.WriteLine("You won a new boat!")
		Console.ReadLine()
	ElseIf uservalue = "3" Then
		Console.WriteLine("You won a cat!")
		Console.ReadLine()
	Elself
		Console.WriteLine("Sorry, we did not understand your response. Youlose!")
		Console.ReadLine()
	End If
	
	
	End Sub

End Module
