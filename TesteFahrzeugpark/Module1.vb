Imports Fahrzeugpark

Module Module1

    Sub Main()

        Dim fz1 As Fahrzeugpark.Fahrzeug = New Fahrzeug("BMW", 230)
        Dim fz2 As Fahrzeug = New Fahrzeug("Mercedes", 190)

        Console.WriteLine(fz1.Name)
        Console.WriteLine(fz1.MaxGeschwindigkeit)
        Console.WriteLine(fz2.Name)
        Console.WriteLine(fz2.MaxGeschwindigkeit)

        fz2.Name = "Audi"
        Console.WriteLine(fz2.Name)

        Console.WriteLine(fz2.BeschreibeMich())
        Console.WriteLine(fz1.BeschreibeMich())


        Dim fz As Fahrzeug
        For index = 1 To 10000
            fz = New Fahrzeug($"{index}", 100)
        Next

        GC.Collect()
        GC.WaitForPendingFinalizers()

        Console.ReadKey()
    End Sub

End Module
