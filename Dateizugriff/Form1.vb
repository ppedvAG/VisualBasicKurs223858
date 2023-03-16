Imports System.IO
Imports Fahrzeugpark
Imports Newtonsoft.Json

Public Class Form1

    'EventHandler für die Text-Speicher und -Lade-Buttons
    Private Sub Btn_SaveText_Click(sender As Object, e As EventArgs) Handles Btn_SaveText.Click
        SaveText(Tbx_TextToSave.Text)
    End Sub

    Private Sub Btn_LoadText_Click(sender As Object, e As EventArgs) Handles Btn_LoadText.Click
        Try
            Tbx_TextToSave.Text = LoadText()
        Catch
        End Try
    End Sub


    Private Sub SaveText(text As String)

        'Mittels eines StreamWriters können daten in das dateisystem gespeichert werden
        Dim writer As StreamWriter

        Try
            'Der SaveFileDialog bietet dem Benutzer die Möglichkeit den Speicherort auszuwählen
            Dim saveDialog As SaveFileDialog = New SaveFileDialog()

            'Standartdateiname
            saveDialog.FileName = "testText.txt"
            'Standartordner
            saveDialog.InitialDirectory = "C:\"
            saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            'Filterliste
            saveDialog.Filter = "Textdatei|*.txt|Stringdatei|*.string|Alle Dateien|*.*"

            'Aufruf des Dialogfensters und Überprüfung, ob der Benutzer OK geklickt hat
            If saveDialog.ShowDialog = DialogResult.OK Then

                'Initialisierung des StreamWriters
                writer = New StreamWriter(saveDialog.FileName)

                'Übertrag des Texts in die Datei
                writer.WriteLine(text)
                writer.Write("ENDE DER DATEI")

                MessageBox.Show("Speichern erfolgreich")

            End If

        Catch ex As Exception
            MessageBox.Show("Speichern fehlgeschlagen")

        Finally
            If Not IsNothing(writer) Then
                'Schließen der Verbindung zwischen StreamWriter und Datei
                writer.Close()
            End If
        End Try

    End Sub

    Private Function LoadText() As String

        'vgl SaveText
        Dim reader As StreamReader
        Dim geladenerText As String = String.Empty

        Try
            Dim openDialog As OpenFileDialog = New OpenFileDialog()

            openDialog.FileName = "testText.txt"
            openDialog.InitialDirectory = "C:\"
            openDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            openDialog.Filter = "Textdatei|*.txt|Stringdatei|*.string|Alle Dateien|*.*"

            If openDialog.ShowDialog = DialogResult.OK Then

                reader = New StreamReader(openDialog.FileName)

                'While Not reader.EndOfStream
                '    geladenerText += reader.ReadLine()
                'End While

                geladenerText = reader.ReadToEnd()

                MessageBox.Show("Laden erfolgreich")

                Return geladenerText

            End If
        Catch ex As Exception
            MessageBox.Show("Laden fehlgeschlagen")

        Finally
            If Not IsNothing(reader) Then
                reader.Close()
            End If
        End Try


        Throw New Exception("Laden abgebrochen")

    End Function


    Private fahrzeugliste As List(Of Fahrzeug) = New List(Of Fahrzeug)

    'EventHandler zum Erstellen und Löschen von Fahrzeugen
    Private Sub Btn_New_Click(sender As Object, e As EventArgs) Handles Btn_New.Click
        'Hinzufügen eines neuen Fahrzeugs zur Liste
        fahrzeugliste.Add(PKW.ErstelleZufälligenPKW(""))
        'Aktualisierung der GUI
        UpdateGUI()
    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click

        'Überprüfung, ob in der ListBox ein Objekt ausgewählt wurde
        If Lbx_Fahrzeuge.SelectedIndex >= 0 And Lbx_Fahrzeuge.SelectedIndex < Lbx_Fahrzeuge.Items.Count Then
            'Löschen des Objekts aus der Liste
            fahrzeugliste.RemoveAt(Lbx_Fahrzeuge.SelectedIndex)
            'Aktualisierung der GUI
            UpdateGUI()
        End If

    End Sub

    Private Sub Btn_SaveFz_Click(sender As Object, e As EventArgs) Handles Btn_SaveFz.Click
        'vgl. SaveText

        Dim writer As StreamWriter

        Try

            writer = New StreamWriter("fahrzeuge.txt")

            'Erstellen eines Settings-Objekts zur Serialisierung, damit der Objekttyp mit abgespeichert wird
            Dim settings = New JsonSerializerSettings()
            settings.TypeNameHandling = TypeNameHandling.Objects

            For Each fz In fahrzeugliste

                'Serialisierung des Fahrzeugs in einen JsonString
                Dim fahrzeugString = JsonConvert.SerializeObject(fz, settings)
                writer.WriteLine(fahrzeugString)

            Next

            MessageBox.Show("Speichern erfolgreich")


        Catch ex As Exception
            MessageBox.Show("Speichern fehlgeschlagen")

        Finally
            If Not IsNothing(writer) Then
                writer.Close()
            End If
        End Try
    End Sub

    Private Sub Btn_LoadFz_Click(sender As Object, e As EventArgs) Handles Btn_LoadFz.Click
        'vgl. Btn_SaveFz_Click

        Dim reader As StreamReader

        Try
            reader = New StreamReader("fahrzeuge.txt")

            Dim settings = New JsonSerializerSettings()
            settings.TypeNameHandling = TypeNameHandling.Objects

            fahrzeugliste.Clear()

            While Not reader.EndOfStream

                Dim geladenesFz As Fahrzeug = JsonConvert.DeserializeObject(Of Fahrzeug)(reader.ReadLine(), settings)
                fahrzeugliste.Add(geladenesFz)

            End While

            MessageBox.Show("Laden erfolgreich")



        Catch ex As Exception
            MessageBox.Show("Laden fehlgeschlagen")

        Finally
            If Not IsNothing(reader) Then
                reader.Close()
            End If
        End Try

        UpdateGUI()
    End Sub

    'Methode zur Aktualisierung der GUI
    Private Sub UpdateGUI()

        'Löschen der ListBox
        Lbx_Fahrzeuge.Items.Clear()

        'Übertrag der Fahrzeugliste in ListBox
        For Each fz In fahrzeugliste
            Lbx_Fahrzeuge.Items.Add(fz)
        Next

    End Sub
End Class
