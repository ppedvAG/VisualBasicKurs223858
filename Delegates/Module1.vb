Imports Fahrzeugpark
Module Module1

    Public Delegate Function MeinDelegate(zahl1 As Integer, zahl2 As Integer) As Integer

    Sub Main()

        Dim delegateVariable As MeinDelegate = AddressOf Addiere

        Dim erg = delegateVariable(123, 4354)
        Console.WriteLine(erg)

        delegateVariable = AddressOf Subtrahiere

        erg = delegateVariable(123, 4354)
        Console.WriteLine(erg)

        RechneUndGibAus(AddressOf Addiere)
        RechneUndGibAus(delegateVariable)

        Dim meinFunc As Func(Of Integer, Integer, Integer) = AddressOf Addiere
        Dim meinAction As Action(Of MeinDelegate) = AddressOf RechneUndGibAus

        meinAction(AddressOf Addiere)


        Dim städteListe As List(Of String) = New List(Of String)
        städteListe.Add("Hamburg")
        städteListe.Add("Berlin")
        städteListe.Add("München")
        städteListe.Add("Köln")
        städteListe.Add("Dresden")

        Dim gefundeneStadt = städteListe.Find(AddressOf SucheStadtMitB)
        Console.WriteLine(gefundeneStadt)


        Dim fahrzeugListe As List(Of Fahrzeug) = New List(Of Fahrzeug)

        'Deklaration und Initialisierung von Bsp-Variablen
        Dim pkw1 As PKW = New PKW("BMW", 270, 27000, 5)
        Dim schiff1 As Schiff = New Schiff("Titanic", 50, 2900000, Schiff.Schiffstreibstoff.Dampf)

        'Hinzufügen von Elementen zur Liste
        fahrzeugListe.Add(pkw1)
        fahrzeugListe.Add(New Flugzeug("Boing", 800, 3500000, 9999))
        fahrzeugListe.Add(schiff1)

        Dim gefundenesFz = fahrzeugListe.Find(AddressOf SucheFzMitMehrAls300MaxG)
        Console.WriteLine(gefundenesFz.BeschreibeMich())

        Dim suchPredicate As Predicate(Of Fahrzeug) = Function(fz As Fahrzeug) As Boolean
                                                          Return fz.MaxGeschwindigkeit > 300
                                                      End Function
        gefundenesFz = fahrzeugListe.Find(suchPredicate)

        gefundenesFz = fahrzeugListe.Find(Function(fz As Fahrzeug) As Boolean
                                              Return fz.MaxGeschwindigkeit > 300
                                          End Function)

        gefundenesFz = fahrzeugListe.Find(Function(fz) fz.MaxGeschwindigkeit > 300)


        städteListe = städteListe.OrderBy(Function(stadt) stadt(0)).ToList()
        For Each stadt In städteListe
            Console.WriteLine(stadt)
        Next

        städteListe = städteListe.OrderBy(Function(stadt) stadt.Length).ToList()
        For Each stadt In städteListe
            Console.WriteLine(stadt)
        Next


        Console.ReadKey()
    End Sub

    Public Function SucheFzMitMehrAls300MaxG(fz As Fahrzeug) As Boolean
        Return fz.MaxGeschwindigkeit > 300
    End Function

    Public Function SucheStadtMitB(stadt As String) As Boolean
        Return stadt.StartsWith("B")
    End Function

    Public Sub RechneUndGibAus(methode As MeinDelegate)
        Console.WriteLine(methode(1, 2))
    End Sub

    Public Function Addiere(a As Integer, b As Integer) As Integer
        Console.WriteLine($"Summe: {a + b}")
        Return a + b
    End Function

    Public Function Subtrahiere(a As Integer, b As Integer) As Integer
        Console.WriteLine($"Differenz: {a - b}")
        Return a - b
    End Function

End Module
