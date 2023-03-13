Imports System.Reflection

Module Module1

    Sub Main()

        Dim a As Integer = 16
        Dim b As Integer = 17

        Dim boolVar As Boolean = (a < b)

        If (a < b) Then

            Dim c As Integer = 34

            Console.WriteLine("A ist kleiner als B")

            If a = 16 Then
                Console.WriteLine($"A ist 16, C ist {c}")
            End If

        ElseIf (a = 20) And (b < 20) Then

            Console.WriteLine("A ist gleich 20")

        ElseIf a > b Then

            Console.WriteLine("A ist größer als B")

        Else

            Console.WriteLine("A ist gleich B und nicht 20")

        End If

        Console.WriteLine("ENDE")


        a = 1
        b = 20

        While a < b

            Console.WriteLine($"{a}<{b}")

            a += 1

            If a = 15 Then
                Exit While
            End If

        End While

        Do

            Console.WriteLine("DO-Schleife")

            If Console.ReadKey().Key = ConsoleKey.Enter Then
                Exit Do

                Continue Do
            End If

        Loop While True

        'Do
        '
        '
        'Loop Until a > 50
        'Do
        '
        'Loop While Not a > 50


        For index = 1 To 10

            Console.WriteLine(index)

        Next

        For i = 100 To 1 Step -2
            Console.WriteLine(i)
            i -= 3

            'Exit For
        Next


        Dim Städte As String() = {"München", "Berlin", "Hamburg"}
        Console.WriteLine(Städte(1))

        Städte(0) = "Köln"

        For i = 0 To Städte.Length - 1

            Console.WriteLine(Städte(i))

        Next

        For Each stadt In Städte

            Console.WriteLine(stadt)

        Next

        ReDim Preserve Städte(3)

        Console.WriteLine(Städte.Contains("Hamburg"))

        Console.ReadKey()

    End Sub

End Module
