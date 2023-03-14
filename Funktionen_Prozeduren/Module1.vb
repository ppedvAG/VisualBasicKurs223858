Module Module1

    Sub Main()

        Dim zahl1, zahl2 As Integer
        zahl1 = 123
        zahl2 = 234

        AddiereUndGibAus(zahl1, zahl2)

        Dim erg As Integer = Addiere(78, Addiere(zahl1, zahl2))
        Console.WriteLine(erg)

        Dim ergDbl As Double = Addiere(45.1, 67.12)

        erg = Addiere(1, 2, 3)
        Console.WriteLine(erg)

        Dim zahlen As Integer() = {1, 2, 3, 4, 5}
        erg = BildeSumme(zahlen)
        Console.WriteLine(erg)

        erg = BildeSumme(23, 45, 12, -34, 67)
        Console.WriteLine(erg)

        Console.ReadKey()

    End Sub

    Sub AddiereUndGibAus(a As Integer, b As Integer)
        Dim summe As Integer = a + b
        Console.WriteLine(summe)
    End Sub

    Function Addiere(a As Integer, b As Integer) As Integer
        Dim summe = a + b
        Return summe
    End Function

    Function Addiere(a As Integer, b As Integer, c As Integer, Optional d As Integer = 0) As Integer
        Dim summe = a + b + c + d
        Return summe
    End Function

    Function Addiere(a As Double, b As Double) As Double
        Return a + b
    End Function

    Function BildeSumme(ParamArray summanden As Integer()) As Integer
        Dim summe As Integer = 0
        For Each summand In summanden
            summe += summand
        Next
        Return summe
    End Function

End Module
