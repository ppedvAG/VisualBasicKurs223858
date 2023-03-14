Public Class PKW
    Inherits Fahrzeug

    Private _anzahlTüren As Integer
    Public Property AnzahlTüren() As Integer
        Get
            Return _anzahlTüren
        End Get
        Set(ByVal value As Integer)
            _anzahlTüren = value
        End Set
    End Property


    Public Sub New(name As String, maxG As Integer, preis As Double, anzahlTüren As Integer)
        MyBase.New(name, maxG, preis)

        Me._anzahlTüren = anzahlTüren
    End Sub

    Public Overrides Function BeschreibeMich() As String
        Return "Der PKW " + MyBase.BeschreibeMich() + $" Er hat {Me.AnzahlTüren} Türen."
    End Function

    Public Overrides Function ToString() As String
        Return Me.BeschreibeMich()
    End Function

    Public Overrides Sub Hupen()
        Console.WriteLine("Hup Hup")
    End Sub

End Class
