<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Tbx_TextToSave = New System.Windows.Forms.TextBox()
        Me.Btn_SaveText = New System.Windows.Forms.Button()
        Me.Btn_LoadText = New System.Windows.Forms.Button()
        Me.Lbx_Fahrzeuge = New System.Windows.Forms.ListBox()
        Me.Btn_SaveFz = New System.Windows.Forms.Button()
        Me.Btn_LoadFz = New System.Windows.Forms.Button()
        Me.Btn_New = New System.Windows.Forms.Button()
        Me.Btn_Delete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Tbx_TextToSave
        '
        Me.Tbx_TextToSave.AcceptsReturn = True
        Me.Tbx_TextToSave.Location = New System.Drawing.Point(49, 49)
        Me.Tbx_TextToSave.Multiline = True
        Me.Tbx_TextToSave.Name = "Tbx_TextToSave"
        Me.Tbx_TextToSave.Size = New System.Drawing.Size(334, 337)
        Me.Tbx_TextToSave.TabIndex = 0
        '
        'Btn_SaveText
        '
        Me.Btn_SaveText.Location = New System.Drawing.Point(426, 49)
        Me.Btn_SaveText.Name = "Btn_SaveText"
        Me.Btn_SaveText.Size = New System.Drawing.Size(179, 65)
        Me.Btn_SaveText.TabIndex = 1
        Me.Btn_SaveText.Text = "Speichern"
        Me.Btn_SaveText.UseVisualStyleBackColor = True
        '
        'Btn_LoadText
        '
        Me.Btn_LoadText.Location = New System.Drawing.Point(426, 120)
        Me.Btn_LoadText.Name = "Btn_LoadText"
        Me.Btn_LoadText.Size = New System.Drawing.Size(179, 66)
        Me.Btn_LoadText.TabIndex = 2
        Me.Btn_LoadText.Text = "Laden"
        Me.Btn_LoadText.UseVisualStyleBackColor = True
        '
        'Lbx_Fahrzeuge
        '
        Me.Lbx_Fahrzeuge.FormattingEnabled = True
        Me.Lbx_Fahrzeuge.ItemHeight = 25
        Me.Lbx_Fahrzeuge.Location = New System.Drawing.Point(680, 384)
        Me.Lbx_Fahrzeuge.Name = "Lbx_Fahrzeuge"
        Me.Lbx_Fahrzeuge.Size = New System.Drawing.Size(362, 254)
        Me.Lbx_Fahrzeuge.TabIndex = 3
        '
        'Btn_SaveFz
        '
        Me.Btn_SaveFz.Location = New System.Drawing.Point(336, 432)
        Me.Btn_SaveFz.Name = "Btn_SaveFz"
        Me.Btn_SaveFz.Size = New System.Drawing.Size(154, 51)
        Me.Btn_SaveFz.TabIndex = 4
        Me.Btn_SaveFz.Text = "Save Fz"
        Me.Btn_SaveFz.UseVisualStyleBackColor = True
        '
        'Btn_LoadFz
        '
        Me.Btn_LoadFz.Location = New System.Drawing.Point(336, 498)
        Me.Btn_LoadFz.Name = "Btn_LoadFz"
        Me.Btn_LoadFz.Size = New System.Drawing.Size(154, 52)
        Me.Btn_LoadFz.TabIndex = 5
        Me.Btn_LoadFz.Text = "Load Fz"
        Me.Btn_LoadFz.UseVisualStyleBackColor = True
        '
        'Btn_New
        '
        Me.Btn_New.Location = New System.Drawing.Point(143, 432)
        Me.Btn_New.Name = "Btn_New"
        Me.Btn_New.Size = New System.Drawing.Size(165, 51)
        Me.Btn_New.TabIndex = 6
        Me.Btn_New.Text = "New Fz"
        Me.Btn_New.UseVisualStyleBackColor = True
        '
        'Btn_Delete
        '
        Me.Btn_Delete.Location = New System.Drawing.Point(143, 499)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(165, 51)
        Me.Btn_Delete.TabIndex = 7
        Me.Btn_Delete.Text = "Delete Fz"
        Me.Btn_Delete.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1135, 756)
        Me.Controls.Add(Me.Btn_Delete)
        Me.Controls.Add(Me.Btn_New)
        Me.Controls.Add(Me.Btn_LoadFz)
        Me.Controls.Add(Me.Btn_SaveFz)
        Me.Controls.Add(Me.Lbx_Fahrzeuge)
        Me.Controls.Add(Me.Btn_LoadText)
        Me.Controls.Add(Me.Btn_SaveText)
        Me.Controls.Add(Me.Tbx_TextToSave)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tbx_TextToSave As TextBox
    Friend WithEvents Btn_SaveText As Button
    Friend WithEvents Btn_LoadText As Button
    Friend WithEvents Lbx_Fahrzeuge As ListBox
    Friend WithEvents Btn_SaveFz As Button
    Friend WithEvents Btn_LoadFz As Button
    Friend WithEvents Btn_New As Button
    Friend WithEvents Btn_Delete As Button
End Class
