'vgl auch PKW
Public Class Schiff
    Inherits Fahrzeug

    'Klasseneigener (dh nur für diese Klasse gültiger) Enumerator
    Enum Schiffstreibstoff
        Diesel
        Schweröl
        Dampf
        Wind
        Muskelkraft
    End Enum

    Private _treibstoff As Schiffstreibstoff
    Public Property Treibstoff() As Schiffstreibstoff
        Get
            Return _treibstoff
        End Get
        Set(ByVal value As Schiffstreibstoff)
            _treibstoff = value
        End Set
    End Property

    Public Sub New(name As String, preis As Double, maxG As Integer, treibstoff As Schiffstreibstoff)
        MyBase.New(name, preis, maxG)
        _treibstoff = treibstoff
    End Sub

    Public Overrides Function BeschreibeMich() As String
        Return "Das Schiff " + MyBase.BeschreibeMich() + $" Es fährt mit {Treibstoff}."
    End Function

    Public Overrides Sub Hupen()
        Console.WriteLine("Trööööt")
    End Sub
End Class
