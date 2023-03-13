Module Module1

    Sub Main(args As String())

        'Deklaration und Initialisierung des Zufallszahlengenerators über dessen Konstruktor
        Dim generator As Random = New Random()

        'Schleife zur Wiederholung des Programms
        Do
            'Variable für Benutzereingabe
            Dim eingabe As Integer
            'Variable für zufällige Zahl und würfeln dieser
            Dim zufälligeZahl As Integer = generator.Next(1, 6)

            'Schleife zu Wiederholung der Benutzereingabe
            Do
                'Benutzereingabe
                Console.Write("Bitte gib eine ganze Zahl zwischen 1 und 5 ein: ")
                eingabe = Integer.Parse(Console.ReadLine())

                'Vergelich der Zahlen
                If eingabe < zufälligeZahl Then
                    'Fall 'Zahl zu klein'                    
                    Console.WriteLine("Deine Zahl ist zu klein.")

                ElseIf eingabe > zufälligeZahl Then
                    'Fall 'Zahl zu groß'
                    Console.WriteLine("Deine Zahl ist zu groß.")

                Else
                    'Fall 'Zahlen gleich'
                    Console.WriteLine("Herzlichen Glückwunsch. Du hast die richtige Zahl erraten.")

                End If

                'Bedingung für Schleife: 'Zahlen ungleich'
            Loop While eingabe <> zufälligeZahl

            'Ausgabe der gesuchten Zahl
            Console.WriteLine($"Die gesuchte Zahl war {zufälligeZahl}.")

            'Bedingung zur Wiederholung: 'Benutzer drückt Taste Y'
            Console.WriteLine("Möchtest du nochmal spielen (Y/N)?")
        Loop While Console.ReadKey(True).Key = ConsoleKey.Y

    End Sub

End Module
