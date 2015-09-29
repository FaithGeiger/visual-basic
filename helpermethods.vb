Module Module1

	Sub Main()


	displayTheMessage()
	

	Dim myValue As String = superSecretFormula()
	Dim myValue As String = superSecretFormula("Bob")
	Console.WriteLine(myValue)
	
	Console.WriteLine(superSecretFormula())
	Console.WriteLine(superSecretFormula("Bob"))
	
	Console.ReadLine()

	End Sub

	Sub displayTheMessage()
	Console.WriteLine("From displayTheMessage")
	End Sub

	Function superSecretFormula() As String
	Return "Hello World!"
	End Function

	Functio superSecretFormula(ByVal name As String) As String 
	Return String.Format("Hello World, {0}", name)
	End Function


End Module
