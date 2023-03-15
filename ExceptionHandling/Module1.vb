Class MeineException
    Inherits Exception

    Sub New()
        MyBase.New("Dies ist mein Fehler")
    End Sub

End Class


Module Module1

    Sub Main()

        EingabeUndVerdopplung()

        Console.ReadKey()
    End Sub

    Sub EingabeUndVerdopplung()

        Dim eingabe As String
        Dim zahl1 As Integer

        eingabe = Console.ReadLine()

        Try
            zahl1 = Integer.Parse(eingabe)

            Console.WriteLine(zahl1 * 2)

            If (zahl1 = 100) Then
                Throw New MeineException()
            End If


        Catch ex As FormatException

            Console.WriteLine("Du musst eine Zahl eingeben")
            EingabeUndVerdopplung()

        Catch ex As OverflowException

            Console.WriteLine("Deine Zahl ist zu groß/klein")
            EingabeUndVerdopplung()

        Catch ex As Exception

            Console.WriteLine("Ein unbekannter Fehler ist aufgetaucht. " + ex.Message)
            EingabeUndVerdopplung()

        Finally

            Console.WriteLine("Finally")

        End Try

        Console.WriteLine("ENDE")

    End Sub

End Module
