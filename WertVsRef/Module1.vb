Module Module1

    'WERTEtyp-Objekte werden bei Zuweisung zu einer anderen Variablen oder bei Übergabe an eine Methode kopiert.
    ''Eine Veränderung der Kopie hat keine Auswirkungen auf das Original-Objekt.
    ''STRUCTUREs sind Klassen-ähnliche Konstrukte welche nicht, wie Klassen, als Referenztypen behandelt werden, sondern ein Wertetyp sind.
    Public Structure S_Person

        Private _name As String
        Public Property Name() As String
            Get
                Return _name
            End Get
            Set(ByVal value As String)
                _name = value
            End Set
        End Property

        Private _alter As Integer
        Public Property Alter() As Integer
            Get
                Return _alter
            End Get
            Set(ByVal value As Integer)
                _alter = value
            End Set
        End Property

        Public Sub New(name As String, alter As Integer)
            _alter = alter
            _name = name
        End Sub

    End Structure

    'Bei REFERENZtyp-Objekten, wie z.B. Klassenobjekten, wird bei einer Übergabe an eine Methode oder einer Zuweisung
    ''zu einer neuen Variablen die entsprechende Speicherstelle übergeben. D.h. eine Manipulation des Objekts macht sich
    ''bei beiden Variablen bemerkbar, da beide auf dasselbe Objekt zeigen
    Public Class C_Person

        Private _name As String
        Public Property Name() As String
            Get
                Return _name
            End Get
            Set(ByVal value As String)
                _name = value
            End Set
        End Property

        Private _alter As Integer
        Public Property Alter() As Integer
            Get
                Return _alter
            End Get
            Set(ByVal value As Integer)
                _alter = value
            End Set
        End Property

        Public Sub New(name As String, alter As Integer)
            _alter = alter
            _name = name
        End Sub

    End Class

    Sub Main()

        'Referenz (mehrere Variablen zeigen auf das selbe Objekt)
        Dim ClassPerson01 As C_Person = New C_Person("Anna", 34)
        Dim ClassPerson02 As C_Person = ClassPerson01

        Console.WriteLine(ClassPerson01.Name)
        Console.WriteLine(ClassPerson02.Name)

        ClassPerson02.Name = "Maria"
        Console.WriteLine(ClassPerson01.Name) '<- Eigenschaftsveränderung werden in beiden Variablen sichtbar


        'Wert (bei Zuweisung wird der Variableninhalt kopiert)
        Dim StructPerson01 As S_Person = New S_Person("Hugo", 34)
        Dim StructPerson02 As S_Person = StructPerson01

        Console.WriteLine(StructPerson01.Name)
        Console.WriteLine(StructPerson02.Name)

        StructPerson02.Name = "Maria"
        Console.WriteLine(StructPerson01.Name) '<- Eigenschaftsveränderung nur in veränderter Variable sichtbar


        'Startzustand
        Console.WriteLine($"{StructPerson01.Name}: {StructPerson01.Alter}")
        Console.WriteLine($"{ClassPerson01.Name}: {ClassPerson01.Alter}")

        'Übergabe an jeweilige Altern()-Methode
        Altern(StructPerson01)
        Altern(ClassPerson01)

        'Ergebnis: Nur Referenztyp hat neues Alter, da bei Werttyp innerhalb der Methode die Kopie gealtert ist
        Console.WriteLine($"{StructPerson01.Name}: {StructPerson01.Alter}")
        Console.WriteLine($"{ClassPerson01.Name}: {ClassPerson01.Alter}")

        'Aufruf der ByRef-Methode
        WirlichAltern(StructPerson01)
        Console.WriteLine($"{StructPerson01.Name}: {StructPerson01.Alter}")


        'Bsp für .NET-interne Verwendung des ByRef-Stichworts (hier in Integer.TryParse())
        ''Dies gibt hier die Möglichkeit zwei Rückgabewerte zu erlangen (1. Boolean über return, 2. Integer [eingabeAlsInteger] über ByRef)
        Dim eingabe As String = Console.ReadLine()
        Dim eingabeAlsInterger As Integer

        If Integer.TryParse(eingabe, eingabeAlsInterger) Then

            Console.WriteLine(eingabeAlsInterger * 2)

        End If

        Console.ReadKey()

    End Sub

    Sub Altern(person As C_Person)
        person.Alter += 1
    End Sub
    Sub Altern(ByVal person As S_Person)
        person.Alter += 1
    End Sub


    'Mittels des BYREF-Stichworts können Wertetypen als Referenz an Methoden übergeben werden. D.h. die übergebene Speicherstelle selbst 
    ''wird manipuliert und nicht, wie normalerweise bei Wertetypen, eine Kopie des Werts.
    Sub WirlichAltern(ByRef person As S_Person)
        person.Alter += 1
    End Sub

End Module
