Imports System.Reflection

Module Module1

    'KONTROLLSTRUKTUREN regeln den Ablauf des Programms unter Bezug auf bestimmte, durch boolsche Werte oder logische
    ''Operationen dargestellte Zustände des Programms
    Sub Main()

        'Deklaration und Initialisierung von Beispiel-Variablen
        Dim a As Integer = 16
        Dim b As Integer = 17

        'Bsp für Zwischenspeichern eines Wahrheitswerts in einer Boolean-Variable
        Dim boolVar As Boolean = (a < b)

        'Ein IF-Block teilt den Programmablauf in mehrere Pfade, abhängig von einer oder mehrerer Bedingungen. Das Programm
        ''wird jeweils den ersten Block ausführen, bei welchem es auf eine wahre Bedingung trifft.
        If (a < b) Then
            'Dies wird ausgeführt, wenn die Bedingung des IF-Blocks wahr ist.
            Console.WriteLine("A ist kleiner als B")
            'Diese Variable ist nur innerhalb des If-Blocks bekannt
            Dim zahl As Integer = 123
            Console.WriteLine(zahl)

            'IF-Bloöcke können auch verschachtelt werden
            If a = 16 Then
                Console.WriteLine($"A ist 16")
            End If

        ElseIf (a = 20) And (b < 20) Then
            'Dieser Block wird ausgeführt, wenn a=20 UND b<20 ist, wenn der obige IF-Block nicht ausgeführt wurde
            Console.WriteLine("A ist gleich 20")

        ElseIf a > b Then
            'Ein If-Block kann beliebig viele ELSEIF-Blöcke beinhalten, welche weitere Bedingungen prüfen. Diese werden
            ''jedoch nur geprüft, wenn alle vorherigen Bedingungen false sind.
            Console.WriteLine("A ist größer als B")

        Else
            'Der optionale ELSE-Block wird ausgeführt, wenn keine der vorherigen Bedingungen wahr sind.
            Console.WriteLine("A ist gleich B")

        End If
        Console.WriteLine("Ende des IF-Blocks")


        a = 1
        b = 20

        'Eine WHILE-Schleife wird wiederholt, solange die Bedingung wahr ist. Ist die Bedingung von vornherein
        ''unwahr, wird die Schleife übersprungen
        While a < b

            Console.WriteLine("Schleife " + a.ToString())

            a += 1

            'Der CONTINUE-Befehl beendet den aktuellen Schleifendurchlauf und zwingt das Programm die Bedingung erneut
            ''zu prüfen. Ist die Bedingug nicht wahr, wird kein neuer Durchlauf gestartet.
            Continue While

        End While


        'Auch eine DO-WHILE-Schleife wird solange wiederholt, bis die Bedingung unwahr ist. Allerdings findet die Bedingungs-
        ''prüfung erst am Ende eines Schleifendurchlaufs statt. D.h. die Scheife läuft mindestens einmal durch.
        Do

            Console.WriteLine("Do-Schleife")

            Console.Write("Soll die Schleife wiederholt werden (Y/N)?")
            If Console.ReadKey().Key <> ConsoleKey.Y Then
                'Der EXIT-Befehl beendet eine Schleife sofort und zwingt das Programm unterhalb der Schleife weiter zu machen.
                Exit Do
            End If

        Loop While True


        'Bsp für Do Until (<= Verneinung von Do While)
        Do

            a -= 1


        Loop Until a < 0


        'Do
        '    a -= 1
        'Loop While Not a < 0


        'Eine FOR-Schleife besitzt eine Laufindexvariable, welche bei jedem Durchlauf manipuliert wird. Durch die Initialisierung
        ''dieser und der Angabe eines maximalen Werts, kann man festlegen, wie oft die Schleife durchläuft
        For index = 1 To 10

            Console.WriteLine("Durchlauf Nr. " + index.ToString())

        Next

        'Mittels des optionalen STEP-Befehls kann man selbst die Manipulation der Indexvariablen bestimmen
        For index = 10 To 0 Step -2

            Console.WriteLine("Durchlauf Nr. " + index.ToString())
            'Exit For

        Next


        'Ein ARRAY ist eine Sammlung von Werten eines bestimmten Datentyps. Ein Zugriff auf die einzelnen Werte erfolgt über
        ''einen Null-basierten Index. Die Größe eines Arrays muss bei Deklaration festgelegt werden.
        Dim Städte As String() = {"München", "Berlin", "Hamburg"}
        Dim Städte2(5) As String

        'Ausgabe des Werts an der Indexposition 1
        Console.WriteLine(Städte(1))
        'Manipulation des Wertes an der ersten(!) Position
        Städte(0) = "Köln"

        'Iteration einer For-Schleife über ein Array
        For index = 0 To Städte.Length - 1

            Console.WriteLine(Städte(index))

        Next

        'Eine FOREACH-Schleife kann über eine Collection wie z.B. ein Array laufen und spricht dabei jedes Element genau
        ''einmal an
        For Each stadt In Städte

            Console.WriteLine(stadt)

        Next

        'Mittels des REDIM-Befehls kann man die Größe (d.h. Kapazität) des Arrays manipulieren. In die Klammern schreibt man
        ''die neue Größe des Arrays. Mit dem PRESERVE-Stichwort behält das Array alle bisherigen Werte
        ReDim Preserve Städte(3)
        Städte(3) = "Berlin"

        'Mittels der Contains()-Methode kann eine Collection auf einen Inhalt hin überprüft werden
        Console.WriteLine(Städte.Contains("Hamburg"))

        'Programmpause
        Console.ReadKey()

    End Sub

End Module
