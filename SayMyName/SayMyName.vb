'Noah Holloway
'RCET 2265
'Spring 2025
'Say My Name
Module SayMyName

    Sub Main()
        Console.WriteLine("What's your name?") 'displays whats your name to user
        Dim Name As String = Console.ReadLine() 'reads anything typed by the user as a name

        Select Case Name.ToLower() 'allows for lower case lettering

            'if any of the following cases are detetced, it will choose from the following
            Case "tony"
                Console.WriteLine("F*ck you Tony!")

            Case "heisenberg"
                Console.WriteLine("You're goddamn right")

            Case "hello there"
                Console.WriteLine("General Kenobi")

            Case "tim"
                Console.WriteLine("Would you like a complimentary warm roll?")

            Case "rossiter"
                Console.WriteLine("Care for some jelly beans?")

            Case "alex"
                Console.WriteLine("Evening...BUDDY!")

            Case Else 'if the user doesn't type any of the above names, it will greet them with whatever name they type
                Console.WriteLine("Hello, " & Name & "!" & " Nice of you to drop by.")
        End Select

    End Sub

End Module
