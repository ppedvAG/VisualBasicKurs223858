Module Program

    Sub Main()

        'Zugriff auf die BackgroundColor-Eigenschaft der Console-Klasse und Neuzuweisung dieser
        Console.BackgroundColor = ConsoleColor.Blue

        Console.WriteLine("Hello World")


        Dim meinString As String

        meinString = "Hello World"

        Console.WriteLine(meinString)


        meinString = "Heute ist ein schöner Tag!"
        Console.WriteLine(meinString)


        Dim Name As String = "Klaas"
        Dim Alter As Integer = 33

        Dim kombinierterString As String = "Mein Name ist " + Name + " und ich bin " + Alter.ToString() + " Jahre alt."
        Console.WriteLine(kombinierterString)
        Console.WriteLine("Mein Name ist " + Name + " und ich bin " + Alter.ToString() + " Jahre alt.")

        kombinierterString = $"Mein {{Name}} ist {Name} und ich bin {Alter} Jahre alt."
        Console.WriteLine(kombinierterString)

        Console.WriteLine("Mein Name ist {0} und ich bin {1} Jahre alt.", Name, Alter)

        Console.WriteLine($"Dies ist ein Zeilenumbruch{vbNewLine}{Environment.NewLine}und dies ein {vbTab} horizontaler Tab.")


        Const PI As Double = 3.15
        Console.WriteLine(PI)

        Console.WriteLine("Bitte gib eine Zahl ein:")
        Dim benutzereingabe As String = Console.ReadLine()
        Console.WriteLine($"Dein Zahl ist: {benutzereingabe}")

        Dim eingabeAlsString As Integer = Integer.Parse(benutzereingabe)
        Console.WriteLine($"Das Doppelte deiner Zahl ist: {eingabeAlsString * 2}")


        Dim gedrückteTaste As ConsoleKeyInfo = Console.ReadKey(True)
        Console.WriteLine($"Du hast die Taste >>{gedrückteTaste.Key}<< gedrückt.")


        Dim c As Char = "a"c

        Dim ganzZahl As Integer = 23
        Dim kommaZahl As Double = ganzZahl
        Console.WriteLine(kommaZahl)

        kommaZahl = 23.67
        ganzZahl = kommaZahl
        Console.WriteLine(ganzZahl)

        ganzZahl = CInt(kommaZahl)
        Console.WriteLine(ganzZahl)

        ganzZahl = Math.Floor(kommaZahl)
        Console.WriteLine(ganzZahl)


        Dim a As Integer = 12
        Dim b As Integer = 0

        Dim erg As Double = a / b
        Console.WriteLine(erg)





        Console.ReadKey()

    End Sub

End Module
