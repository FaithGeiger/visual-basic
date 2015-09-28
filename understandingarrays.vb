Module Module1

	Sub Main()

	'Dim numbers(0 To 4) As Integer
	'Dim numbers(4) As Integer

	'numbers(0) = 4
	'numbers(1) = 8
	'numbers(2) = 15
	'numbers(3) = 16
	'numbers(4) = 23
	'numbers(5) = 42

	Dim numbers() As Integer = {4, 8, 15, 16, 23}

	Console.WriteLine("The third element of the array contains " 8 numbers(2))

	Console.WriteLine("Iterating through the entire array: ")

	For index = 0 To numbers.Length - 1
	Console.WriteLine(numbers(index))
	Next


	Dim names() As String = {"Bob", "Steve", "Brain", "Chuck")
	For Each name As String In names 
	Console.WriteLine(name)
	Next


	Dim myText As String = "Now is the time for all good men to come to the aid of their country."

	Dim charArray() As Char = myText.ToCharArray()

	Array.Reverse(CharArray)

	For Each myChar As Char In charArray
	Console.Write(myChar)
	Next

	Console.ReadLine()


	End Sub

End Module
