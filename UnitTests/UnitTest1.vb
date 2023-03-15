Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Fahrzeugpark
Imports System.Reflection

<TestClass()> Public Class TestPKW


    'UNIT-TESTS sind simple Überprüfungen, mit denen kleine Programmteile über längere Zeit auf ihre korrekte
    ''Funktionalität hin überprüft werden können. Ausgeführt werden diese über das 'Test'-Menü
    <TestMethod()> Public Sub Beschleunige_über_MaxG()

        Dim pkw As PKW = New PKW("BMW", 230, 4000, 4)

        pkw.StarteMotor()
        pkw.Beschleunige(pkw.MaxGeschwindigkeit + 1)

        'Jede TestMethod muss mindestens einen Zugriff auf die Assert-Klasse nehmen, mit deren Methoden die
        ''zu überprüfenden Programmteile getestet werden. Ein Test gilt als erfolgreich, wenn alle Assert-Methoden
        ''in einer TestMethod ein true zurückgeben.
        Assert.AreEqual(pkw.MaxGeschwindigkeit, pkw.AktGeschwindigkeit)

    End Sub

    <TestMethod()> Public Sub Bremse_unter_0()

        Dim pkw As PKW = New PKW("BMW", 230, 4000, 4)

        pkw.StarteMotor()
        pkw.Beschleunige(100)
        pkw.Beschleunige(-101)

        Assert.AreEqual(0, pkw.AktGeschwindigkeit)

    End Sub

    '<TestMethod()> Public Sub Teste_EH()

    '    Assert.ThrowsException(Of Exception)(AddressOf TesteFahrzeugpark.Module1.Main)


    'End Sub

End Class