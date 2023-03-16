Imports System.Xml.Schema
Imports Fahrzeugpark

Public Module Module1

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

#Region "Modul 08: Interfaces und Polymorphismus"
        ''Bsp-Objekt
        'Dim pkw1 As PKW = New PKW("BMW", 270, 27000, 5)

        ''Zugriff auf durch Interface definierte Property und Methode
        'Console.WriteLine(pkw1.AnzahlRäder)
        'pkw1.BaueUnfall()

        ''Durch den POLYMORPHISMUS kann der PKW auch als allgemeines FAHRZEUG (Vererbung) oder
        ''IBERÄDERT-OBJEKT (Interface) betrachtet werden. Dies erlaubt einen gemeinsamen Zugriff auf Objekte,
        ''welche eine Vererbungshierachie oder ein Interface teilen (Bsp in Arrays oder Methodenübergaben)

        ''PKW in Fahrzeug-Variabler
        'Dim fz1 As Fahrzeug = pkw1
        ''PKW in IBerädert-Variabler
        'Dim berädertesObjekt As IBerädert = pkw1
        ''Array von Fahrzeugen mit einem PKW und einem Schiff
        'Dim fahrzeugArray As Fahrzeug() = {pkw1, New Schiff("Titanic", 20000, 200, Schiff.Schiffstreibstoff.Dampf)}
        ''Übergabe eines PKWs an eine Methode, welche ein Fahrzeug als Übergabeparameter erwartet
        'Repariere(pkw1)
#End Region

#Region "Lab08: IBeladbar"
        ''Bsp-Objekte
        'Dim pkw1 As PKW = New PKW("BMW", 270, 27000, 5)
        'Dim flugzeug1 As Flugzeug = New Flugzeug("Boing", 800, 3500000, 9999)
        'Dim schiff1 As Schiff = New Schiff("Titanic", 50, 2900000, Schiff.Schiffstreibstoff.Dampf)

        ''Aufruf der BeladeFahrzeuge()-Methode mit verschiedenenen Objekten
        'BeladeFahrzeug(schiff1, schiff1)
        'Console.WriteLine()

        'BeladeFahrzeug(pkw1, flugzeug1)
        'Console.WriteLine()

        'BeladeFahrzeug(pkw1, schiff1)
        'Console.WriteLine()

        'BeladeFahrzeug(schiff1, flugzeug1)
        'Console.WriteLine()

        ''Ausgabe der BeschreibeMich()-Funktion des beladenenen Schiffes
        'Console.WriteLine(schiff1.BeschreibeMich())
        'Console.WriteLine()

        'schiff1.Entlade()
        'Console.WriteLine()

        'schiff1.Entlade()
#End Region

#Region "Modul09: Generische Listen"

        ''Deklaration und Initialisierung einer List-Variablen, welche Strings fassen kann
        'Dim städteListe As List(Of String) = New List(Of String)

        ''Hinzufügen von Strings zu der Liste
        'städteListe.Add("Hamburg")
        'städteListe.Add("Berlin")
        'städteListe.Add("München")
        'städteListe.Add("Köln")

        ''Ausgabe der Anzahl der Elemente in der Liste
        'Console.WriteLine(städteListe.Count)

        ''Ausgabe des dritten Elements in der Liste
        'Console.WriteLine(städteListe(2))

        ''Löschen des Objekts 'Berlin' aus der Liste -> untere Objekte rutschen nach oben und Platz-Anzahl innerhalb der LIste wird reduziert
        'städteListe.Remove("Berlin")
        'Console.WriteLine(städteListe.Count)
        'Console.WriteLine(städteListe(2))

        ''Neuzuweisung des zweiten Elements in der Liste
        'städteListe(1) = "Magdeburg"

        ''Ausgabe der Liste in einer For-Each-Schleife
        'For Each stadt In städteListe
        '    Console.WriteLine(stadt)
        'Next

        ''Erstellen einer Liste, welche beliebige Fahrzeuge (PKWs, Flugzeuge, Schiffe) fassen kann
        'Dim fahrzeugListe As List(Of Fahrzeug) = New List(Of Fahrzeug)

        ''Deklaration und Initialisierung von Bsp-Variablen
        'Dim pkw1 As PKW = New PKW("BMW", 270, 27000, 5)
        'Dim schiff1 As Schiff = New Schiff("Titanic", 50, 2900000, Schiff.Schiffstreibstoff.Dampf)

        ''Hinzufügen von Elementen zur Liste
        'fahrzeugListe.Add(pkw1)
        'fahrzeugListe.Add(New Flugzeug("Boing", 800, 3500000, 9999))
        'fahrzeugListe.Add(schiff1)

        ''For-Schleife über die Liste
        'For index = 0 To fahrzeugListe.Count - 1
        '    Console.WriteLine(fahrzeugListe(index).BeschreibeMich())
        'Next


        ''Erstellen eines neuen Dictionaries mit Strins als Keys und Fahrzeugen als Values
        'Dim dict As Dictionary(Of String, Fahrzeug) = New Dictionary(Of String, Fahrzeug)

        ''Hinzufügen von neuen Dictionary-Einträgen
        'dict.Add("fahren", pkw1)
        'dict.Add("schwimmen", schiff1)
        'dict.Add("fliegen", fahrzeugListe(1))

        ''Ausgabe der BeschreibeMich()-Methode des Flugzeuges über den String-Key des Dictionaries
        'Console.WriteLine(dict("schwimmen").BeschreibeMich())

        ''ForEach-Schleife über Dictionary
        'For Each zeile In dict
        '    Console.WriteLine($"{zeile.Key}: {zeile.Value.Name}")
        'Next
#End Region

#Region "Lab 09: Zufällige Fahrzeuglisten"
        ''Initialisierung der Listen und des Zufallszahlengenerators
        'Dim generator As Random = New Random()
        'Dim fzQueue As Queue(Of Fahrzeug) = New Queue(Of Fahrzeug)()
        'Dim fzStack As Stack(Of Fahrzeug) = New Stack(Of Fahrzeug)()
        'Dim fzDict As Dictionary(Of Fahrzeug, Fahrzeug) = New Dictionary(Of Fahrzeug, Fahrzeug)()

        ''Initialisierung einer Variablen zur Angabe der Durchläufe
        'Dim anzahlFahrzeuge As Integer = 10000

        ''Zufällige "Befüllung" der Listen mittels des Zufallszahlengenerators und SelectCase
        'For index = 1 To anzahlFahrzeuge
        '    Select Case generator.Next(1, 4)
        '        Case 1
        '            fzStack.Push(PKW.ErstelleZufälligenPKW($"_S{index}"))
        '            fzQueue.Enqueue(PKW.ErstelleZufälligenPKW($"_Q{index}"))
        '        Case 2
        '            fzStack.Push(New Schiff($"Titanic_S{index}", 50, 3000000, Schiff.Schiffstreibstoff.Dampf))
        '            fzQueue.Enqueue(New Schiff($"Titanic_Q{index}", 50, 3000000, Schiff.Schiffstreibstoff.Dampf))
        '        Case 3
        '            fzStack.Push(New Flugzeug($"Boing_S{index}", 800, 2900000, 9900))
        '            fzQueue.Enqueue(New Flugzeug($"Boing_Q{index}", 800, 2900000, 9900))
        '    End Select
        'Next

        ''Versuch, die QueueFz's mit den StackFz's zu beladen
        'For index = 1 To anzahlFahrzeuge
        '    'Prüfung auf das Interface (ob beladen werden kann)
        '    If TypeOf fzQueue.Peek() Is IBeladbar Then
        '        'wenn ja, dann Cast ins Interface 
        '        Dim beladbaresFz As IBeladbar = DirectCast(fzQueue.Peek(), IBeladbar)
        '        'und Aufruf der Belade()-Funktion (mittels Peek(), da die Fz's noch benötigt werden)
        '        beladbaresFz.Belade(fzStack.Peek())
        '        'Hinzufügen der Fz's zum Dictionary (mittels Dequeue()/Pop(), damit beim nächsten Durchlauf andere Fz's oben sind)
        '        fzDict.Add(fzQueue.Dequeue(), fzStack.Pop())
        '    Else
        '        'wenn nein, dann werden die Fz's vor dem nächsten Durchlauf rausgeschmissen
        '        fzQueue.Dequeue()
        '        fzStack.Pop()
        '    End If
        'Next

        ''Programmpause
        'Console.ReadKey()
        'Console.WriteLine("-----LADELISTE----")

        ''Ausgabe des Dictionaries
        'For Each item In fzDict
        '    Console.WriteLine($"{item.Key.Name} hat {item.Value.Name} geladen.")
        'Next
#End Region

        'Bsp-PKWs
        Dim fz1 = New PKW("BMW", 230, 12345, 4)
        Dim fz2 = New PKW("BMW", 345, 23455, 2)
        Dim fz3 = New PKW("Mercedes", 345, 23455, 2)

        'Anwendung des in der PKW-Klasse definierten Vergelichsoperators
        Console.WriteLine(fz1 = fz2)
        Console.WriteLine(fz2 = fz3)

        Dim flugzeug1 = New Flugzeug("Boing", 40000000, 30000, 9999)

        'Anwendung der GetEnumerator-Funktion aus der Flugzeugklasse
        For Each passagier In flugzeug1
            Console.WriteLine(passagier)
        Next

        'Anwendung der Indexer-Property aus der Flugzeugklasse
        Console.WriteLine(flugzeug1(1))

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

#Region "Lab 08 Methode"
    Public Sub BeladeFahrzeug(fz1 As Fahrzeug, fz2 As Fahrzeug)
        'Überprüfung, ob die fz's das Interface implementiert haben (dh. ob sie eine Ladung aufnehmen können)
        If TypeOf fz1 Is IBeladbar Then
            'Wenn ja, dann Cast in temporäre IBeladbar-Variable
            Dim beladbaresO As IBeladbar = DirectCast(fz1, IBeladbar)
            'und Aufruf der Belade()-Funktion mit Übergabe des anderen Fahrzeugs
            beladbaresO.Belade(fz2)
        ElseIf TypeOf fz2 Is IBeladbar Then
            'Alternative Schreibweise ohne temporäre Variable
            DirectCast(fz2, IBeladbar).Belade(fz1)
        Else
            Console.WriteLine("Kein Fahrzeug hat einen Laderaum, der beladen werden konnte.")
        End If
    End Sub
#End Region

End Module
