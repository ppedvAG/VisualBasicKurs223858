Imports Fahrzeugpark
Module Module1

    'Delegates sind Datentypen, deren Variablen Refernzen auf Methoden aufnehmen können. Bei Aufruf der
    ''Variablen werden dann die Methoden ausgeführt. Jeder Delegatetyp kann die Methoden aufnehmen, welche
    ''seiner Signatur entsprechen

    'Definition eines Delegate-Datentypen
    Public Delegate Function MeinDelegate(zahl1 As Integer, zahl2 As Integer) As Integer

    Sub Main()

        'Deklaration einer Delegatevariablen
        'Mittels des ADDRESSOF-Stichworts können Methoden den Delegate-Variablen zugeordnet werden 
        Dim delegateVariable As MeinDelegate = AddressOf Addiere
        'Ausführung der Methode in der Variablen
        Dim erg = delegateVariable(123, 4354)
        Console.WriteLine(erg)

        'Neuzuweisung der Variablen
        delegateVariable = AddressOf Subtrahiere
        erg = delegateVariable(123, 4354)
        Console.WriteLine(erg)

        'Übergabe einer Methode an eine andere Methode (mittels Delegate-Übergabeparameter)
        RechneUndGibAus(AddressOf Addiere)
        RechneUndGibAus(delegateVariable)

        'Deklaration eines Funcs (generischer Function-Delegate) und Initialisierung mit einer Methode
        Dim meinFunc As Func(Of Integer, Integer, Integer) = AddressOf Addiere
        'Deklaration eines Action (generischer Sub-Delegate) und Initialisierung mit einer Methode
        Dim meinAction As Action(Of MeinDelegate) = AddressOf RechneUndGibAus
        'Ausführung des Actions
        meinAction(AddressOf Addiere)

        'Bsp-Liste
        Dim städteListe As List(Of String) = New List(Of String)
        städteListe.Add("Hamburg")
        städteListe.Add("Berlin")
        städteListe.Add("München")
        städteListe.Add("Köln")
        städteListe.Add("Dresden")

        'Übergabe einer Suchlogik an Find-Funktion der Liste
        Dim gefundeneStadt = städteListe.Find(AddressOf SucheStadtMitB)
        Console.WriteLine(gefundeneStadt)

        'Bsp-Liste
        Dim fahrzeugListe As List(Of Fahrzeug) = New List(Of Fahrzeug)
        fahrzeugListe.Add(New PKW("BMW", 270, 27000, 5))
        fahrzeugListe.Add(New Flugzeug("Boing", 800, 3500000, 9999))
        fahrzeugListe.Add(New Schiff("Titanic", 50, 2900000, Schiff.Schiffstreibstoff.Dampf))

        'Verschiedene Ausführungen der Befüllung der Find()-Funktion einer Liste:
        ''Übergabe einer Methode (für Methode s.u.)
        Dim gefundenesFz = fahrzeugListe.Find(AddressOf SucheFzMitMehrAls300MaxG)
        Console.WriteLine(gefundenesFz.BeschreibeMich())

        ''Übergabe einer anonymen Methode in einem Delegate <- Methode, welche keinen Bezeichner hat und nur ein einem Delegate existiert
        Dim suchPredicate As Predicate(Of Fahrzeug) = Function(fz As Fahrzeug) As Boolean
                                                          Return fz.MaxGeschwindigkeit > 300
                                                      End Function
        gefundenesFz = fahrzeugListe.Find(suchPredicate)

        ''Übergabe einer anonymen Methode direkt in den Übergabeparamteren
        gefundenesFz = fahrzeugListe.Find(Function(fz As Fahrzeug) As Boolean
                                              Return fz.MaxGeschwindigkeit > 300
                                          End Function)

        ''Übergabe der anonymen Methode in KurzSchreibweise
        gefundenesFz = fahrzeugListe.Find(Function(fz) fz.MaxGeschwindigkeit > 300)


        'Ausgabe des Ergebnisses
        Console.WriteLine(gefundenesFz.BeschreibeMich())

        'Sortieren der Liste nach Anfangsbuchstaben per Kurzschreibweise
        städteListe = städteListe.OrderBy(Function(stadt) stadt(0)).ToList()
        For Each stadt In städteListe
            Console.WriteLine(stadt)
        Next

        'Sortieren der Liste nach Wortlänge per Kurzschreibweise
        städteListe = städteListe.OrderBy(Function(stadt) stadt.Length).ToList()
        For Each stadt In städteListe
            Console.WriteLine(stadt)
        Next


        Console.ReadKey()
    End Sub

    'Beispielmethoden:
    ''Methoden, welche die Suchlogik für die Find()-Funktion beinhaltet
    Public Function SucheFzMitMehrAls300MaxG(fz As Fahrzeug) As Boolean
        Return fz.MaxGeschwindigkeit > 300
    End Function

    Public Function SucheStadtMitB(stadt As String) As Boolean
        Return stadt.StartsWith("B")
    End Function

    ''Methode, welche einen Delegate als Übegabeparameter verlangt
    Public Sub RechneUndGibAus(methode As MeinDelegate)
        Console.WriteLine(methode(1, 2))
    End Sub

    ''Bsp-Methoden zur Befüllung der Delegates
    Public Function Addiere(a As Integer, b As Integer) As Integer
        Console.WriteLine($"Summe: {a + b}")
        Return a + b
    End Function

    Public Function Subtrahiere(a As Integer, b As Integer) As Integer
        Console.WriteLine($"Differenz: {a - b}")
        Return a - b
    End Function

End Module
