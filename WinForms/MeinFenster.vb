Imports Fahrzeugpark

''FORMS sind Klassen, deren Objekte als 'Fenster' angezeigt werden. Dieses Klassen sind zweigeteilt. Die automatisch generierte Datei
'sollte nicht verändert werden. Im CodeBehind (diese Datei) können EventHandler und eigene Eigenschaften und Methoden definiert werden
Public Class MeinFenster
    'Events, welche von GUI-Elementen unter bestimmten Umständen geworfen werden, sind spezielle Delegates.
    ''Methoden, welche durch diese Events ausgeführt werden sollen, können mittels des HANDLES-Stichworts an
    ''Events gebunden werden

    ''EventHandler, der durch Klick auf den 'KlickMich'-Button ausgelöst wird
    Private Sub Btn_KlickMich_Click(sender As Object, e As EventArgs) Handles Btn_KlickMich.Click, Btn_Zwei.Click

        'Ändern der Hintergrundfarbe des Forms
        Me.BackColor = Color.HotPink

        'Ändern der Text-Eigenschaft des Buttons
        Btn_KlickMich.Text = "Button wurde geklickt"

        'Prüfung der Checked-Eigenschaft der CheckBox
        If Cbx_Haken.Checked Then
            'Ändern der Left-Eigenschaft des Buttons über den sender-Parameter
            DirectCast(sender, Button).Left = 5
        End If

        'Übertrag des TextBox-Inhalts in das Label
        Lbl_Output.Text = Tbx_Input.Text

        'Übertrag des ausgewählten ComboBox-Texts in die TextBox
        Tbx_Input.Text = Cbb_Auswahl.Text

    End Sub

    'Bsp-Liste
    Private fahrzeugliste As List(Of Fahrzeug) = New List(Of Fahrzeug)

    'Methode, welche beim Start des Fensters ausgeführt wird (durch Shown-Event des Forms), als Alternative zum Konstruktor
    Private Sub MeinFenster_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'Hinzufügen von Elementen zur Liste
        fahrzeugliste.Add(New PKW("BMW", 270, 27000, 5))
        fahrzeugliste.Add(New Flugzeug("Boing", 800, 3500000, 9999))
        fahrzeugliste.Add(New Schiff("Titanic", 50, 2900000, Schiff.Schiffstreibstoff.Dampf))

        'Übertrag der Listen-Elemente in die ListBox 
        For Each fz In fahrzeugliste
            Lbx_Auswahl.Items.Add(fz)
        Next
    End Sub

    'Methode, welche bei Neuauswahl eines ListBox-Elements ausgeführt wird (durch ListBox.SelectedValueChanged-Event)
    Private Sub Lbx_Auswahl_SelectedValueChanged(sender As Object, e As EventArgs) Handles Lbx_Auswahl.SelectedValueChanged
        'Cast des ausgwählten ListBox-Elements in Fahrzeug und Übertrag von dessen BeschreibeMich()-Methode in Label
        Lbl_Fahrzeug.Text = DirectCast(Lbx_Auswahl.SelectedItem, Fahrzeug).BeschreibeMich()
    End Sub

    'Methode, welche bei Klick auf Schließen-MenüButton ausgeführt wird
    Private Sub SchließenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SchließenToolStripMenuItem.Click
        'Aufruf einer MessageBox und Prüfung des geklickten Buttons
        If MessageBox.Show("Möchtest du dieses Fenster wirklich schließen?", "Programm beenden", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            'Schließen des Fensters
            Me.Close()
        End If

        'Schließen der ganzen Applikation
        'Application.Exit()
    End Sub

    Private Sub NeuesFensterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeuesFensterToolStripMenuItem.Click

        'Instanzierung eines neuen Fenster-Objekts
        Dim neuesFenster As MeinFenster = New MeinFenster
        'Ändern der Text-Eigenschaft des Fensters
        neuesFenster.Text = "Mein neues Fenster"
        'Anzeigen des Fensters als gleichberechtigtes Fenster
        neuesFenster.Show()

    End Sub

    Private Sub NeuesDialogFensterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeuesDialogFensterToolStripMenuItem.Click

        'Instanzierung eines neuen Fenster-Objekts
        Dim neuesDialogFenster As MeinFenster = New MeinFenster
        'Ändern der Text-Eigenschaft des Fensters
        neuesDialogFenster.Text = "Mein neues Dialog-Fenster"
        'Anzeigen des Fensters als Dialog-Fenster und Prüfung des DialogResults (vgl. Btn_Ok_Click())
        If neuesDialogFenster.ShowDialog() = DialogResult.OK Then
            Lbl_Output.Text = "OKAYYYYY"
        End If

    End Sub

    Private Sub Btn_Ok_Click(sender As Object, e As EventArgs) Handles Btn_Ok.Click
        'Setzen des DialogResults zur Rückgabe an die ShowDialog()-Methode des öffnenden Fensters
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class
