﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PanelEditConcessionnaire
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.TbNom = New System.Windows.Forms.TextBox()
        Me.TbAdresse = New System.Windows.Forms.TextBox()
        Me.TbVille = New System.Windows.Forms.TextBox()
        Me.TbPrénom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbPays = New System.Windows.Forms.TextBox()
        Me.TbdateDateNaiss = New cimetiere.TextBoxDate()
        Me.TbintCp = New cimetiere.TextBoxInt()
        Me.TbintNoNat = New cimetiere.TextBoxInt64()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TbTel = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TbNom
        '
        Me.TbNom.Location = New System.Drawing.Point(49, 24)
        Me.TbNom.Name = "TbNom"
        Me.TbNom.Size = New System.Drawing.Size(132, 22)
        Me.TbNom.TabIndex = 0
        '
        'TbAdresse
        '
        Me.TbAdresse.Location = New System.Drawing.Point(72, 17)
        Me.TbAdresse.Name = "TbAdresse"
        Me.TbAdresse.Size = New System.Drawing.Size(132, 22)
        Me.TbAdresse.TabIndex = 1
        '
        'TbVille
        '
        Me.TbVille.Location = New System.Drawing.Point(72, 48)
        Me.TbVille.Name = "TbVille"
        Me.TbVille.Size = New System.Drawing.Size(132, 22)
        Me.TbVille.TabIndex = 2
        '
        'TbPrénom
        '
        Me.TbPrénom.Location = New System.Drawing.Point(271, 24)
        Me.TbPrénom.Name = "TbPrénom"
        Me.TbPrénom.Size = New System.Drawing.Size(132, 22)
        Me.TbPrénom.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(203, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Prénom"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Ville"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(257, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "CP"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(244, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Pays"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Date de naissance"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(54, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "N° national"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 17)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Adresse"
        '
        'TbPays
        '
        Me.TbPays.Location = New System.Drawing.Point(294, 53)
        Me.TbPays.Name = "TbPays"
        Me.TbPays.Size = New System.Drawing.Size(132, 22)
        Me.TbPays.TabIndex = 16
        '
        'TbdateDateNaiss
        '
        Me.TbdateDateNaiss.DateValue = Nothing
        Me.TbdateDateNaiss.Location = New System.Drawing.Point(147, 26)
        Me.TbdateDateNaiss.Mask = "00/00/0000"
        Me.TbdateDateNaiss.Name = "TbdateDateNaiss"
        Me.TbdateDateNaiss.Size = New System.Drawing.Size(123, 22)
        Me.TbdateDateNaiss.TabIndex = 14
        Me.TbdateDateNaiss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbintCp
        '
        Me.TbintCp.Location = New System.Drawing.Point(294, 20)
        Me.TbintCp.Name = "TbintCp"
        Me.TbintCp.Size = New System.Drawing.Size(100, 22)
        Me.TbintCp.TabIndex = 13
        Me.TbintCp.Value = Nothing
        '
        'TbintNoNat
        '
        Me.TbintNoNat.Location = New System.Drawing.Point(147, 59)
        Me.TbintNoNat.Name = "TbintNoNat"
        Me.TbintNoNat.Size = New System.Drawing.Size(123, 22)
        Me.TbintNoNat.TabIndex = 17
        Me.TbintNoNat.Value = Nothing
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 17)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Téléphone"
        '
        'TbTel
        '
        Me.TbTel.Location = New System.Drawing.Point(88, 24)
        Me.TbTel.Name = "TbTel"
        Me.TbTel.Size = New System.Drawing.Size(116, 22)
        Me.TbTel.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TbNom)
        Me.GroupBox1.Controls.Add(Me.TbPrénom)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, -3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(444, 69)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TbAdresse)
        Me.GroupBox2.Controls.Add(Me.TbVille)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TbPays)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TbintCp)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(444, 90)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TbdateDateNaiss)
        Me.GroupBox3.Controls.Add(Me.TbintNoNat)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 233)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(442, 99)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.TbTel)
        Me.GroupBox4.Location = New System.Drawing.Point(5, 168)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(442, 59)
        Me.GroupBox4.TabIndex = 23
        Me.GroupBox4.TabStop = False
        '
        'PanelEditConcessionnaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "PanelEditConcessionnaire"
        Me.Size = New System.Drawing.Size(460, 339)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TbNom As TextBox
    Friend WithEvents TbAdresse As TextBox
    Friend WithEvents TbVille As TextBox
    Friend WithEvents TbPrénom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TbintCp As TextBoxInt
    Friend WithEvents TbdateDateNaiss As TextBoxDate
    Friend WithEvents TbPays As TextBox
    Friend WithEvents TbintNoNat As TextBoxInt64
    Friend WithEvents Label9 As Label
    Friend WithEvents TbTel As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
End Class