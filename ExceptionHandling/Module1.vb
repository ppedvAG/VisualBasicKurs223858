'Mittels Exception-Handling führt man eine Bearbeitung von Laufzeitfehlern im Programm durch.

'Eigene Exceptions müssen von der Exception-Klasse erben und können dann manuell mittels des Throw-Stichworts
''geworfen werden
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

        'In einen TRY-Block werden die Programmteile geschrieben, welche möglicherweise zur Laufzeit einen Fehler
        ''produzieren (z.B. die Integer.Parse()-Funktion). Kommt es zu einem Fehler wird eine EXCEPTION geworfen,
        ''die Ausführung des Try-Blocks wird abgebrochen und die Exception muss von einem passenden CATCH-Block 
        ''abgefangen werden.
        Try
            'Möglicher Exceptionwurf
            zahl1 = Integer.Parse(eingabe)

            Console.WriteLine(zahl1 * 2)

            If (zahl1 = 100) Then
                'Mittels des THROW-Stichworts können Exceptions manuell geworfen werden
                Throw New MeineException()
            End If


        Catch ex As FormatException

            'Jedem Try-Block muss mindestens ein Catch-Block folgen, in welchem die geworfenen Fehler abgefangen 
            ''werden. Im Catch-Block kann definiert werden, welche Exceptions abgefangen werden (Signatur) und 
            ''wie sie bearbeitet werden (Körper). Nach der Bearbeitung Nicht abgefangene Exceptions werden an 
            ''den Benutzer durchgereicht und führen zum Programmabbruch.

            Console.WriteLine("Du musst eine Zahl eingeben")
            EingabeUndVerdopplung()

        Catch ex As OverflowException

            Console.WriteLine("Deine Zahl ist zu groß/klein")
            EingabeUndVerdopplung()

            'Ein Throw-Befehl in einem Catch-Block schmeißt die Exception eine Ebene höher
            Throw

        Catch ex As Exception

            Console.WriteLine("Ein unbekannter Fehler ist aufgetaucht. " + ex.Message)
            EingabeUndVerdopplung()

        Finally

            'Der optionale FINALLY-Block wird, egal ob es zu einem Fehler kam oder nicht, immer ausgeführt

            Console.WriteLine("Finally")

        End Try

        Console.WriteLine("ENDE")

    End Sub

End Module
