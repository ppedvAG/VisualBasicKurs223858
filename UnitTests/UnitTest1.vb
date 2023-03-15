Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Fahrzeugpark
Imports System.Reflection

<TestClass()> Public Class TestPKW

    <TestMethod()> Public Sub Beschleunige_über_MaxG()

        Dim pkw As PKW = New PKW("BMW", 230, 4000, 4)

        pkw.StarteMotor()
        pkw.Beschleunige(pkw.MaxGeschwindigkeit + 1)

        Assert.AreEqual(pkw.MaxGeschwindigkeit, pkw.AktGeschwindigkeit)

    End Sub

    <TestMethod()> Public Sub Bremse_unter_0()

        Dim pkw As PKW = New PKW("BMW", 230, 4000, 4)

        pkw.StarteMotor()
        pkw.Beschleunige(100)
        pkw.Beschleunige(-101)

        Assert.AreEqual(0, pkw.AktGeschwindigkeit)

    End Sub

    <TestMethod()> Public Sub Teste_EH()

        Assert.ThrowsException(Of Exception)(TesteFahrzeugpark.Module1.Main)


    End Sub

End Class