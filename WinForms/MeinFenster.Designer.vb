<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MeinFenster
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Btn_KlickMich = New System.Windows.Forms.Button()
        Me.Btn_Zwei = New System.Windows.Forms.Button()
        Me.Lbl_Output = New System.Windows.Forms.Label()
        Me.Cbx_Haken = New System.Windows.Forms.CheckBox()
        Me.Tbx_Input = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.Cbb_Auswahl = New System.Windows.Forms.ComboBox()
        Me.Lbx_Auswahl = New System.Windows.Forms.ListBox()
        Me.Lbl_Fahrzeug = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SchließenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeuesDialogFensterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeuesFensterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_Ok = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EinfügenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KopierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AusschneidenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_KlickMich
        '
        Me.Btn_KlickMich.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_KlickMich.Font = New System.Drawing.Font("Matura MT Script Capitals", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_KlickMich.Location = New System.Drawing.Point(129, 84)
        Me.Btn_KlickMich.Name = "Btn_KlickMich"
        Me.Btn_KlickMich.Size = New System.Drawing.Size(305, 90)
        Me.Btn_KlickMich.TabIndex = 0
        Me.Btn_KlickMich.Text = "Klick Mich"
        Me.Btn_KlickMich.UseVisualStyleBackColor = False
        '
        'Btn_Zwei
        '
        Me.Btn_Zwei.Location = New System.Drawing.Point(138, 261)
        Me.Btn_Zwei.Name = "Btn_Zwei"
        Me.Btn_Zwei.Size = New System.Drawing.Size(193, 65)
        Me.Btn_Zwei.TabIndex = 1
        Me.Btn_Zwei.Text = "Button1"
        Me.Btn_Zwei.UseVisualStyleBackColor = True
        '
        'Lbl_Output
        '
        Me.Lbl_Output.AutoSize = True
        Me.Lbl_Output.Location = New System.Drawing.Point(138, 425)
        Me.Lbl_Output.Name = "Lbl_Output"
        Me.Lbl_Output.Size = New System.Drawing.Size(255, 37)
        Me.Lbl_Output.TabIndex = 2
        Me.Lbl_Output.Text = "Ich bin ein String"
        '
        'Cbx_Haken
        '
        Me.Cbx_Haken.AutoSize = True
        Me.Cbx_Haken.Location = New System.Drawing.Point(586, 47)
        Me.Cbx_Haken.Name = "Cbx_Haken"
        Me.Cbx_Haken.Size = New System.Drawing.Size(228, 41)
        Me.Cbx_Haken.TabIndex = 3
        Me.Cbx_Haken.Text = "Hak mich ab"
        Me.Cbx_Haken.UseVisualStyleBackColor = True
        '
        'Tbx_Input
        '
        Me.Tbx_Input.AcceptsReturn = True
        Me.Tbx_Input.AcceptsTab = True
        Me.Tbx_Input.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Tbx_Input.Location = New System.Drawing.Point(490, 116)
        Me.Tbx_Input.Multiline = True
        Me.Tbx_Input.Name = "Tbx_Input"
        Me.Tbx_Input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Tbx_Input.Size = New System.Drawing.Size(312, 210)
        Me.Tbx_Input.TabIndex = 4
        Me.Tbx_Input.WordWrap = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(586, 425)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(240, 41)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(586, 481)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(242, 41)
        Me.RadioButton2.TabIndex = 6
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(586, 368)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(242, 41)
        Me.RadioButton3.TabIndex = 7
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton5)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Location = New System.Drawing.Point(908, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 207)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(21, 76)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(242, 41)
        Me.RadioButton4.TabIndex = 0
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "RadioButton4"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(21, 124)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(242, 41)
        Me.RadioButton5.TabIndex = 1
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "RadioButton5"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'Cbb_Auswahl
        '
        Me.Cbb_Auswahl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbb_Auswahl.FormattingEnabled = True
        Me.Cbb_Auswahl.Items.AddRange(New Object() {"Eintrag1", "Auswahl2", "Item3"})
        Me.Cbb_Auswahl.Location = New System.Drawing.Point(963, 402)
        Me.Cbb_Auswahl.Name = "Cbb_Auswahl"
        Me.Cbb_Auswahl.Size = New System.Drawing.Size(394, 45)
        Me.Cbb_Auswahl.TabIndex = 9
        '
        'Lbx_Auswahl
        '
        Me.Lbx_Auswahl.FormattingEnabled = True
        Me.Lbx_Auswahl.ItemHeight = 37
        Me.Lbx_Auswahl.Location = New System.Drawing.Point(963, 507)
        Me.Lbx_Auswahl.Name = "Lbx_Auswahl"
        Me.Lbx_Auswahl.Size = New System.Drawing.Size(394, 226)
        Me.Lbx_Auswahl.TabIndex = 10
        '
        'Lbl_Fahrzeug
        '
        Me.Lbl_Fahrzeug.AutoSize = True
        Me.Lbl_Fahrzeug.Location = New System.Drawing.Point(99, 657)
        Me.Lbl_Fahrzeug.Name = "Lbl_Fahrzeug"
        Me.Lbl_Fahrzeug.Size = New System.Drawing.Size(0, 37)
        Me.Lbl_Fahrzeug.TabIndex = 11
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1396, 40)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeuToolStripMenuItem, Me.SchließenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(90, 36)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'NeuToolStripMenuItem
        '
        Me.NeuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeuesDialogFensterToolStripMenuItem, Me.NeuesFensterToolStripMenuItem})
        Me.NeuToolStripMenuItem.Name = "NeuToolStripMenuItem"
        Me.NeuToolStripMenuItem.Size = New System.Drawing.Size(359, 44)
        Me.NeuToolStripMenuItem.Text = "Neu"
        '
        'SchließenToolStripMenuItem
        '
        Me.SchließenToolStripMenuItem.Name = "SchließenToolStripMenuItem"
        Me.SchließenToolStripMenuItem.Size = New System.Drawing.Size(359, 44)
        Me.SchließenToolStripMenuItem.Text = "Schließen"
        '
        'NeuesDialogFensterToolStripMenuItem
        '
        Me.NeuesDialogFensterToolStripMenuItem.Name = "NeuesDialogFensterToolStripMenuItem"
        Me.NeuesDialogFensterToolStripMenuItem.Size = New System.Drawing.Size(369, 44)
        Me.NeuesDialogFensterToolStripMenuItem.Text = "Neues DialogFenster"
        '
        'NeuesFensterToolStripMenuItem
        '
        Me.NeuesFensterToolStripMenuItem.Name = "NeuesFensterToolStripMenuItem"
        Me.NeuesFensterToolStripMenuItem.Size = New System.Drawing.Size(369, 44)
        Me.NeuesFensterToolStripMenuItem.Text = "Neues Fenster"
        '
        'Btn_Ok
        '
        Me.Btn_Ok.Location = New System.Drawing.Point(247, 670)
        Me.Btn_Ok.Name = "Btn_Ok"
        Me.Btn_Ok.Size = New System.Drawing.Size(197, 79)
        Me.Btn_Ok.TabIndex = 13
        Me.Btn_Ok.Text = "OK"
        Me.Btn_Ok.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EinfügenToolStripMenuItem, Me.KopierenToolStripMenuItem, Me.AusschneidenToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(237, 118)
        '
        'EinfügenToolStripMenuItem
        '
        Me.EinfügenToolStripMenuItem.Name = "EinfügenToolStripMenuItem"
        Me.EinfügenToolStripMenuItem.Size = New System.Drawing.Size(300, 38)
        Me.EinfügenToolStripMenuItem.Text = "Einfügen"
        '
        'KopierenToolStripMenuItem
        '
        Me.KopierenToolStripMenuItem.Name = "KopierenToolStripMenuItem"
        Me.KopierenToolStripMenuItem.Size = New System.Drawing.Size(300, 38)
        Me.KopierenToolStripMenuItem.Text = "Kopieren"
        '
        'AusschneidenToolStripMenuItem
        '
        Me.AusschneidenToolStripMenuItem.Name = "AusschneidenToolStripMenuItem"
        Me.AusschneidenToolStripMenuItem.Size = New System.Drawing.Size(300, 38)
        Me.AusschneidenToolStripMenuItem.Text = "Ausschneiden"
        '
        'MeinFenster
        '
        Me.AcceptButton = Me.Btn_KlickMich
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1396, 796)
        Me.Controls.Add(Me.Btn_Ok)
        Me.Controls.Add(Me.Lbl_Fahrzeug)
        Me.Controls.Add(Me.Lbx_Auswahl)
        Me.Controls.Add(Me.Cbb_Auswahl)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Tbx_Input)
        Me.Controls.Add(Me.Cbx_Haken)
        Me.Controls.Add(Me.Lbl_Output)
        Me.Controls.Add(Me.Btn_Zwei)
        Me.Controls.Add(Me.Btn_KlickMich)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "MeinFenster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mein besonders schönes Fenster"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_KlickMich As Button
    Friend WithEvents Btn_Zwei As Button
    Friend WithEvents Lbl_Output As Label
    Friend WithEvents Cbx_Haken As CheckBox
    Friend WithEvents Tbx_Input As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Cbb_Auswahl As ComboBox
    Friend WithEvents Lbx_Auswahl As ListBox
    Friend WithEvents Lbl_Fahrzeug As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DateiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NeuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NeuesDialogFensterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NeuesFensterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SchließenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Btn_Ok As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EinfügenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KopierenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AusschneidenToolStripMenuItem As ToolStripMenuItem
End Class
