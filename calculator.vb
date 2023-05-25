Module Module1

    Sub Main()
        Console.WriteLine("=============")
        Console.WriteLine("CALCULATOR")
        Console.WriteLine("=============")
        Console.WriteLine("[+] Addition")
        Console.WriteLine("[-] Subtraction")
        Console.WriteLine("[*] Multiplication")
        Console.WriteLine("[/] Division")
        Console.WriteLine("Choose Arithmetic Operations")
        Dim choice As String = Console.ReadLine()

        Console.WriteLine("ENTER FIRST NUMBER ")
        Dim num1 As Double = Console.ReadLine()

        Console.WriteLine("ENTER SECOND NUMBER ")
        Dim num2 As Double = Console.ReadLine()

        Dim result As Double

        Select Case choice
            Case "+"
                result = num1 + num2
                Console.Writeline("THE SUM IS ")
            Case "-"
                result = num1 - num2
            Case "*"
                result = num1 * num2
            Case "/"
                If num2 = 0 Then
                    Console.WriteLine("Error: Cannot divide by zero")
                    Console.ReadLine()
                    Return
                Else
                    result = num1 / num2
                End If
            Case Else
                Console.WriteLine("Error: Invalid operator")
                Console.ReadLine()
                Return
        End Select
        ' End Try'
        Console.WriteLine("RESULT: " & result)

        Console.ReadLine()

    End Sub

End Module
