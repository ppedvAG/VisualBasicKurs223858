Module Module1

    Sub Main()

        Dim generator As Random = New Random()

        Do

            Dim eingabe As Integer

            Dim zufälligeZahl As Integer = generator.Next(1, 6)

            Do
                Console.Write("Bitte gib eine Zahl zwischen 1 und 5 ein: ")
                eingabe = Integer.Parse(Console.ReadLine())

                If zufälligeZahl < eingabe Then
                    Console.WriteLine("Deine Zahl ist zu groß")
                ElseIf zufälligeZahl > eingabe Then
                    Console.WriteLine("Deine Zahl ist zu klein")
                Else
                    Console.WriteLine("Herzlichen Glückwunsch. Du hast richtig geraten")
                End If

            Loop While eingabe <> zufälligeZahl

            Console.WriteLine("Möchtest du noch einmal spielen? (Y/N)")
        Loop While Console.ReadKey(True).Key = ConsoleKey.Y

    End Sub

End Module
