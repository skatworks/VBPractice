Module Module1

    Sub Main()
        Dim i As Integer = 0
        For i = 1 To 100
            If (i Mod 3 = 0) And (i Mod 5 = 0) then
                Console.WriteLine("FizzBuzz")
            Else If (i Mod 3 = 0) Then
                Console.WriteLine("Fizz")
            Else If (i Mod 5 = 0) Then
                Console.WriteLine("Buzz")
            Else
                Console.WriteLine(i)
            end if
        Next
#If DEBUG Then
        Console.WriteLine("続行するには何かキーを押してください．．．")
        Console.ReadKey()
#End If
    End Sub

End Module
