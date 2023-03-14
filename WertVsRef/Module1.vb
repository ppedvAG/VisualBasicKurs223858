Module Module1

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

        'Referenz
        Dim ClassPerson01 As C_Person = New C_Person("Anna", 34)
        Dim ClassPerson02 As C_Person = ClassPerson01

        Console.WriteLine(ClassPerson01.Name)
        Console.WriteLine(ClassPerson02.Name)

        ClassPerson02.Name = "Maria"
        Console.WriteLine(ClassPerson01.Name)


        'Wert
        Dim StructPerson01 As S_Person = New S_Person("Hugo", 34)
        Dim StructPerson02 As S_Person = StructPerson01

        Console.WriteLine(StructPerson01.Name)
        Console.WriteLine(StructPerson02.Name)

        StructPerson02.Name = "Maria"
        Console.WriteLine(StructPerson01.Name)



        Console.WriteLine($"{StructPerson01.Name}: {StructPerson01.Alter}")
        Console.WriteLine($"{ClassPerson01.Name}: {ClassPerson01.Alter}")

        Altern(StructPerson01)
        Altern(ClassPerson01)

        Console.WriteLine($"{StructPerson01.Name}: {StructPerson01.Alter}")
        Console.WriteLine($"{ClassPerson01.Name}: {ClassPerson01.Alter}")

        WirlichAltern(StructPerson01)
        Console.WriteLine($"{StructPerson01.Name}: {StructPerson01.Alter}")



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


    Sub WirlichAltern(ByRef person As S_Person)
        person.Alter += 1
    End Sub

End Module
