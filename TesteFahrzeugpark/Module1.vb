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

#Region "Modul 07 Vererbung"
        'Dim pkw1 As PKW = New PKW("BMW", 260, 28000, 5)

        'Console.WriteLine(pkw1.BeschreibeMich())

        'Console.WriteLine(pkw1)

        ''Dim fz1 As Fahrzeug = New Fahrzeug()

        'Fahrzeug.ZeigeAnzahlErstellterFahrzeuge()

        'pkw1.Hupen()
#End Region

#Region "Lab 07 Schiffs-, PKW-, Flugzeug-Klassen"
        ''Deklaration und Initialisierung der spezifischen Fahrzeuge sowie Aufruf der BeschreibeMich()-Methoden
        'Dim pkw1 As PKW = New PKW("BMW", 270, 27000, 5)
        'Console.WriteLine(pkw1.BeschreibeMich())

        'Dim flugzeug1 As Flugzeug = New Flugzeug("Boing", 800, 3500000, 9999)
        'Console.WriteLine(flugzeug1.BeschreibeMich())

        'Dim schiff1 As Schiff = New Schiff("Titanic", 50, 2900000, Schiff.Schiffstreibstoff.Dampf)
        'Console.WriteLine(schiff1.BeschreibeMich())

        ''Aufruf der abstarkten Methoden Hupen()
        'pkw1.Hupen()
        'schiff1.Hupen()
        'flugzeug1.Hupen()

        ''Ausgabe des Shared Members der Fahrzeug-Klasse
        'Fahrzeug.ZeigeAnzahlErstellterFahrzeuge()
#End Region

        'Bsp-Objekt
        Dim pkw1 As PKW = New PKW("BMW", 270, 27000, 5)

        'Zugriff auf durch Interface definierte Property und Methode
        Console.WriteLine(pkw1.AnzahlRäder)
        pkw1.BaueUnfall()

        'Durch den POLYMORPHISMUS kann der PKW auch als allgemeines FAHRZEUG (Vererbung) oder
        ''IBERÄDERT-OBJEKT (Interface) betrachtet werden. Dies erlaubt einen gemeinsamen Zugriff auf Objekte,
        ''welche eine Vererbungshierachie oder ein Interface teilen (Bsp in Arrays oder Methodenübergaben)

        'PKW in Fahrzeug-Variabler
        Dim fz1 As Fahrzeug = pkw1
        'PKW in IBerädert-Variabler
        Dim berädertesObjekt As IBerädert = pkw1
        'Array von Fahrzeugen mit einem PKW und einem Schiff
        Dim fahrzeugArray As Fahrzeug() = {pkw1, New Schiff("Titanic", 20000, 200, Schiff.Schiffstreibstoff.Dampf)}
        'Übergabe eines PKWs an eine Methode, welche ein Fahrzeug als Übergabeparameter erwartet
        Repariere(pkw1)


        Console.ReadKey()
    End Sub

#Region "Modul 08 Methode"
    Sub Repariere(fz1 As Fahrzeug)

        'Prüfung, ob das Fahrzeug ein PKW ist
        If TypeOf fz1 Is PKW Then

            'Cast in PKW und Reperatur der Tür
            Dim pkw1 As PKW = DirectCast(fz1, PKW)
            pkw1.AnzahlTüren += 1

        End If

        'Prüfung, ob das Fahrzeug Räder hat
        If TypeOf fz1 Is IBerädert Then

            'Cast in IBerädert und Reperatur der Räder
            DirectCast(fz1, IBerädert).AnzahlRäder += 1

        End If

        Console.WriteLine($"{fz1.Name} wurde repariert.")

    End Sub
#End Region

End Module
