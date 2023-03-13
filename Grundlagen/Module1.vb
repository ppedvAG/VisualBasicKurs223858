'MODULE sind grundlegende Programmeinheiten, von welchen sich keine Instanzen erstellen lassen. Sie beinhalten nur ausführbaren Code
''der einer bestimmten Aufgabe zugeordnet ist.
Module Program

    'Die Main()-Methode ist der Einstiegspunkt in jedes .NET-Programm. Hier startet das Programm.
    Sub Main()

        'Zugriff auf die BackgroundColor-Eigenschaft der Console-Klasse und Neuzuweisung dieser
        Console.BackgroundColor = ConsoleColor.Blue

        'Ausgabe eines String-Literals in der Console
        Console.WriteLine("Hello World")

        'Deklaration einer String-Variablen
        Dim meinString As String
        'Initialisierung der String-Variablen
        meinString = "Hello World"
        'Ausgabe der String-Variablen
        Console.WriteLine(meinString)

        'Neuzuweisung und Ausgabe der String-Variablen
        meinString = "Heute ist ein schöner Tag!"
        Console.WriteLine(meinString)

        'Deklaration und Initialisierung weiterer Variablen (jeweils in einer Zeile)
        Dim Name As String = "Klaas"
        Dim Alter As Integer = 33

        'String-Formatierungen
        ''"traditionelle" Verknüpfung durch +-Operatoren (Nicht-Strings müssen explizit umgewandelt werden
        Dim kombinierterString As String = "Mein Name ist " + Name + " und ich bin " + Alter.ToString() + " Jahre alt."
        Console.WriteLine(kombinierterString)
        Console.WriteLine("Mein Name ist " + Name + " und ich bin " + Alter.ToString() + " Jahre alt.")

        ''$-Schreibweise -> Variablen werden direkt im String plaziert
        kombinierterString = $"Mein {{Name}} ist {Name} und ich bin {Alter} Jahre alt."
        Console.WriteLine(kombinierterString)

        ''Indexschreibweise -> Null-basierte Indizes werden durch angegebene Variablen ausgetauscht
        Console.WriteLine("Mein Name ist {0} und ich bin {1} Jahre alt.", Name, Alter)

        'Formatierung durch Konstanten
        ''vbNewLine -> erzwingt Zeilenumbruch
        ''vbTab -> erzwingt horizontalen Tabulator
        Console.WriteLine($"Dies ist ein Zeilenumbruch{vbNewLine}{Environment.NewLine}und dies ein {vbTab} horizontaler Tab.")


        'Deklaration und Initialisierung einer eigenen Konstanten
        Const PI As Double = 3.15
        Console.WriteLine(PI)

        'Speichern einer Benutzereingabe (String) in einer Variablen
        Console.WriteLine("Bitte gib eine Zahl ein:")
        Dim benutzereingabe As String = Console.ReadLine()
        Console.WriteLine($"Dein Zahl ist: {benutzereingabe}")

        'Parsen des Strings in einen Integer
        Dim eingabeAlsString As Integer = Integer.Parse(benutzereingabe)
        Console.WriteLine($"Das Doppelte deiner Zahl ist: {eingabeAlsString * 2}")

        'Abgreifen und Zwischenspeichern einer gedrückten Taste
        Dim gedrückteTaste As ConsoleKeyInfo = Console.ReadKey(True)
        Console.WriteLine($"Du hast die Taste >>{gedrückteTaste.Key}<< gedrückt.")

        'Charvariableninitialisierung
        Dim c As Char = "a"c

        'Umwandlung Integer in Double (implizit)
        Dim ganzZahl As Integer = 23
        Dim kommaZahl As Double = ganzZahl
        Console.WriteLine(kommaZahl)

        'Umwandlung Double in Integer (implizit und explizit)
        kommaZahl = 23.67
        ganzZahl = kommaZahl
        Console.WriteLine(ganzZahl)

        ganzZahl = CInt(kommaZahl)
        Console.WriteLine(ganzZahl)

        'Anwendung von Math.Floor() (Rundung zur niedrigeren Zahl)
        ganzZahl = Math.Floor(kommaZahl)
        Console.WriteLine(ganzZahl)

        'Demonstration: Teilung durch 0
        Dim a As Integer = 12
        Dim b As Integer = 0
        Dim erg As Double = a / b
        Console.WriteLine(erg)

        'Programmpause bis Tastendruck
        Console.ReadKey()

    End Sub

End Module
