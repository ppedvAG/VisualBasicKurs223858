'vgl Schiff
Public Class Flugzeug
    Inherits Fahrzeug
    Implements IBerädert, IEnumerable

    Private _maxFlughöhe As Integer
    Public Property MaxFlughöhe() As Integer
        Get
            Return _maxFlughöhe
        End Get
        Set(ByVal value As Integer)
            _maxFlughöhe = value
        End Set
    End Property


    Private _anzahlRäder As Integer
    Public Property AnzahlRäder As Integer Implements IBerädert.AnzahlRäder
        Get
            Return _anzahlRäder
        End Get
        Set(value As Integer)
            _anzahlRäder = value
        End Set
    End Property

    Public Sub New(name As String, preis As Double, maxG As Integer, maxF As Integer)
        MyBase.New(name, preis, maxG)
        _maxFlughöhe = maxF
        _anzahlRäder = 6

        Me.Passagiere = New List(Of String)
        Passagiere.Add("Rainer Zufall")
        Passagiere.Add("Anna Nass")
    End Sub

    Public Overrides Function BeschreibeMich() As String
        Return "Das Flugzeug " + MyBase.BeschreibeMich() + $" Es kann auf {MaxFlughöhe}m aufsteigen."
    End Function

    Public Overrides Sub Hupen()
        Console.WriteLine("Piep")
    End Sub
    Public Sub BaueUnfall() Implements IBerädert.BaueUnfall
        AnzahlRäder -= 1
        Console.WriteLine("Du hast einen Vogel übersehen.")
    End Sub

    'GetEnumerator()-Funktion vom IEnumerable-Interface erlaubt das Einfügen von Objekten in die ForEach-Schleife
    Public Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
        Return Passagiere.GetEnumerator()
    End Function

    'Bsp-Liste
    Private _passagiere As List(Of String)
    Public Property Passagiere() As List(Of String)
        Get
            Return _passagiere
        End Get
        Set(ByVal value As List(Of String))
            _passagiere = value
        End Set
    End Property

    'Indexer-(Item)-Eigenschaften erlauben den Zugriff über Indizes (wie bei Arrays und Listen)
    Default Public Property Item(index As Integer) As String
        Get
            Return Me.Passagiere(index)
        End Get
        Set(ByVal value As String)
            Me.Passagiere(index) = value
        End Set
    End Property
End Class
