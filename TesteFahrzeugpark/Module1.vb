Imports Fahrzeugpark

Module Module1

    Sub Main()


#Region "Modul 05 OOP"

        ''Deklaration von Klassen-Variablen und Initialisierung von neuen Objekten über deren Konstruktor
        'Dim fz1 As Fahrzeugpark.Fahrzeug = New Fahrzeug("BMW", 230)
        'Dim fz2 As Fahrzeug = New Fahrzeug("Mercedes", 190)

        ''Ausgabe von Objekt-Eigenschaften (über Property-Getter)
        'Console.WriteLine(fz1.Name)
        'Console.WriteLine(fz1.MaxGeschwindigkeit)
        'Console.WriteLine(fz2.Name)
        'Console.WriteLine(fz2.MaxGeschwindigkeit)

        ''Neubelegung einer Eigenschaft (über Property-Setter)
        ''Dies hat nur Auswirkungen auf diese spezifische Fahrzeug-Instanz und auf kein anderes Fahrzeug-Objekt
        'fz2.Name = "Audi"
        'Console.WriteLine(fz2.Name)

        ''Aufruf einer Klassen-Funktion und Ausgabe des Rückgabewerts
        'Console.WriteLine(fz2.BeschreibeMich())
        'Console.WriteLine(fz1.BeschreibeMich())

        ''Schleife zur Demonstration des Destruktors
        'Dim fz As Fahrzeug
        'For index = 1 To 10000
        '    fz = New Fahrzeug($"{index}", 100)
        'Next

        ''Erzwingung einer GarbageCollection-Iteration zur Demonstration des Destruktors
        'GC.Collect()
        'GC.WaitForPendingFinalizers()
#End Region

#Region "Lab 05 Fahrzeug-Klasse"

        ''Deklaration der Fahrzeugvariablen und Initialisierung der Fahrzeugobjekte
        'Dim fz1 As Fahrzeug = New Fahrzeug("BMW", 270, 25000)
        'Dim fz2 As Fahrzeug = New Fahrzeug("Mercedes", 260, 28000)

        ''Ausgabe der Name-Property von fz1 (über deren Getter)
        'Console.WriteLine(fz1.Name)

        ''Ausführen einer Methode von fz1
        'fz1.Beschleunige(80)

        ''Ausgabe der AktGeschwindigkeit-Properties
        'Console.WriteLine(fz1.AktGeschwindigkeit)
        'Console.WriteLine(fz2.AktGeschwindigkeit)

        ''Ausführen von Methoden von fz1
        'fz1.StarteMotor()
        'fz1.Beschleunige(300)

        ''Ausgabe der BeschreibeMich()-Methoden
        'Console.WriteLine(fz1.BeschreibeMich())
        'Console.WriteLine(fz2.BeschreibeMich())

#End Region

        Dim pkw1 As PKW = New PKW("BMW", 230, 4000, 4)

        Console.WriteLine(pkw1.BeschreibeMich())

        Console.WriteLine(pkw1)

        pkw1.Hupen()

        Fahrzeug.ZeigeAnzahlFahrzeuge()

        Console.ReadKey()
    End Sub

End Module
