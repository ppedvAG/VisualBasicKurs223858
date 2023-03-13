﻿Module Module1

    'ENUMs sind Datentypen, deren Variablen ausschließlich bestimmte vordefinierte Werte annehmen können.
    ''Enumes müssen außerhalb von Methoden definiert werden
    Enum Wochentag
        Montag = 1
        Dienstag
        Mittwoch
        Donnerstag
        Freitag
        Samstag
        Sonntag
    End Enum


    Sub Main()

        'Deklaration und Initialisierung einer Enum-Variablen
        Dim heute As Wochentag = Wochentag.Montag
        Console.WriteLine($"Heute ist {heute}.")

        Console.WriteLine("Was glaubst du, was heute für ein Wochentag ist?")
        For index = 1 To 7
            'Durchlauf über die möglichen Zustande
            Console.WriteLine($"{index}: {DirectCast(index, Wochentag)}")
        Next
        heute = Integer.Parse(Console.ReadLine())
        'Abfrage eines Enumerator-Zustandes vom Benutzer und Umwandlung von String -> Int -> Enumarator
        Console.WriteLine($"Du denkst, dass heute {heute} ist.")

        'Abfrage eines Enum-Zustandes vom Benutzer und String -> Enum per Parsing
        heute = [Enum].Parse(GetType(Wochentag), Console.ReadLine())
        Console.WriteLine($"Du denkst, dass heute {heute} ist.")


        'SELECTs sind verkürzte If-Blöcke, mit denen genau eine Variable auf ihren Zustand hin überprüft wird.
        ''Jeder Zustand, bei dem etwas passieren soll, wird als CASE definiert, in welchem dann der spezifische Programm-
        ''verlauf definiert wird. Wenn die Variable einen nicht näher definierten Zustand annimmt, wird der ELSE-CASE
        ''ausgeführt
        Select Case heute
            Case Wochentag.Montag
                Console.WriteLine("Wochenstart")

            Case Wochentag.Dienstag Or Wochentag.Mittwoch Or Wochentag.Donnerstag
                Console.WriteLine("Woche läuft")

            Case Else
                Console.WriteLine("Wochenende")

        End Select

        Console.ReadKey()
    End Sub

End Module
