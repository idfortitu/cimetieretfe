<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNouvelleConcession
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtDebutPlus15Ans = New System.Windows.Forms.Button()
        Me.BtDebutPlus30Ans = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbEmplacement = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GbCsnr = New System.Windows.Forms.GroupBox()
        Me.CtrlLocVillePays1 = New cimetiere.CtrlLocVillePays()
        Me.TbCsnrNoRegistre = New System.Windows.Forms.MaskedTextBox()
        Me.TbCsnrTel = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TbdateCsnrDateNaiss = New cimetiere.TextBoxDate()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbCsnrAdresse = New System.Windows.Forms.TextBox()
        Me.TbCsnrNom = New System.Windows.Forms.TextBox()
        Me.TbCsnrPrenom = New System.Windows.Forms.TextBox()
        Me.GbLocation = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TbdateDateDebut = New cimetiere.TextBoxDate()
        Me.TbdateDateFin = New cimetiere.TextBoxDate()
        Me.TbfloatMontantPaye = New cimetiere.TextBoxFloat()
        Me.BtAnnuler = New System.Windows.Forms.Button()
        Me.BtEnregistrer = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TbCommentaire = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GbCsnr.SuspendLayout()
        Me.GbLocation.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Valable du"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(291, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "au"
        '
        'BtDebutPlus15Ans
        '
        Me.BtDebutPlus15Ans.Location = New System.Drawing.Point(211, 64)
        Me.BtDebutPlus15Ans.Name = "BtDebutPlus15Ans"
        Me.BtDebutPlus15Ans.Size = New System.Drawing.Size(180, 34)
        Me.BtDebutPlus15Ans.TabIndex = 4
        Me.BtDebutPlus15Ans.Text = "→   Durée de 15 ans   →"
        Me.BtDebutPlus15Ans.UseVisualStyleBackColor = True
        '
        'BtDebutPlus30Ans
        '
        Me.BtDebutPlus30Ans.Location = New System.Drawing.Point(211, 104)
        Me.BtDebutPlus30Ans.Name = "BtDebutPlus30Ans"
        Me.BtDebutPlus30Ans.Size = New System.Drawing.Size(180, 34)
        Me.BtDebutPlus30Ans.TabIndex = 5
        Me.BtDebutPlus30Ans.Text = "→   Durée de 30 ans   →"
        Me.BtDebutPlus30Ans.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Montant Payé"
        '
        'CbEmplacement
        '
        Me.CbEmplacement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbEmplacement.FormattingEnabled = True
        Me.CbEmplacement.Location = New System.Drawing.Point(386, 176)
        Me.CbEmplacement.Name = "CbEmplacement"
        Me.CbEmplacement.Size = New System.Drawing.Size(121, 24)
        Me.CbEmplacement.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(279, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Emplacement"
        '
        'GbCsnr
        '
        Me.GbCsnr.Controls.Add(Me.CtrlLocVillePays1)
        Me.GbCsnr.Controls.Add(Me.TbCsnrNoRegistre)
        Me.GbCsnr.Controls.Add(Me.TbCsnrTel)
        Me.GbCsnr.Controls.Add(Me.Label7)
        Me.GbCsnr.Controls.Add(Me.Label9)
        Me.GbCsnr.Controls.Add(Me.Label6)
        Me.GbCsnr.Controls.Add(Me.Label10)
        Me.GbCsnr.Controls.Add(Me.TbdateCsnrDateNaiss)
        Me.GbCsnr.Controls.Add(Me.Label8)
        Me.GbCsnr.Controls.Add(Me.Label5)
        Me.GbCsnr.Controls.Add(Me.TbCsnrAdresse)
        Me.GbCsnr.Controls.Add(Me.TbCsnrNom)
        Me.GbCsnr.Controls.Add(Me.TbCsnrPrenom)
        Me.GbCsnr.Location = New System.Drawing.Point(12, 12)
        Me.GbCsnr.Name = "GbCsnr"
        Me.GbCsnr.Size = New System.Drawing.Size(614, 207)
        Me.GbCsnr.TabIndex = 10
        Me.GbCsnr.TabStop = False
        Me.GbCsnr.Text = "Concessionnaire"
        '
        'CtrlLocVillePays1
        '
        Me.CtrlLocVillePays1.Location = New System.Drawing.Point(278, 74)
        Me.CtrlLocVillePays1.Name = "CtrlLocVillePays1"
        Me.CtrlLocVillePays1.Size = New System.Drawing.Size(316, 26)
        Me.CtrlLocVillePays1.TabIndex = 65
        '
        'TbCsnrNoRegistre
        '
        Me.TbCsnrNoRegistre.Location = New System.Drawing.Point(419, 164)
        Me.TbCsnrNoRegistre.Mask = "00\.00\.00-000\.00"
        Me.TbCsnrNoRegistre.Name = "TbCsnrNoRegistre"
        Me.TbCsnrNoRegistre.Size = New System.Drawing.Size(112, 22)
        Me.TbCsnrNoRegistre.TabIndex = 64
        Me.TbCsnrNoRegistre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TbCsnrNoRegistre.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'TbCsnrTel
        '
        Me.TbCsnrTel.Location = New System.Drawing.Point(88, 110)
        Me.TbCsnrTel.Name = "TbCsnrTel"
        Me.TbCsnrTel.Size = New System.Drawing.Size(173, 22)
        Me.TbCsnrTel.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(300, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 17)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Numéro national"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 17)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Adresse"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 17)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Date de naissance"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 17)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Prénom"
        '
        'TbdateCsnrDateNaiss
        '
        Me.TbdateCsnrDateNaiss.DateValue = Nothing
        Me.TbdateCsnrDateNaiss.Location = New System.Drawing.Point(142, 164)
        Me.TbdateCsnrDateNaiss.Mask = "00/00/0000"
        Me.TbdateCsnrDateNaiss.Name = "TbdateCsnrDateNaiss"
        Me.TbdateCsnrDateNaiss.Size = New System.Drawing.Size(119, 22)
        Me.TbdateCsnrDateNaiss.TabIndex = 13
        Me.TbdateCsnrDateNaiss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 17)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Téléphone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(300, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 17)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Nom"
        '
        'TbCsnrAdresse
        '
        Me.TbCsnrAdresse.Location = New System.Drawing.Point(88, 75)
        Me.TbCsnrAdresse.Name = "TbCsnrAdresse"
        Me.TbCsnrAdresse.Size = New System.Drawing.Size(173, 22)
        Me.TbCsnrAdresse.TabIndex = 14
        '
        'TbCsnrNom
        '
        Me.TbCsnrNom.Location = New System.Drawing.Point(343, 23)
        Me.TbCsnrNom.Name = "TbCsnrNom"
        Me.TbCsnrNom.Size = New System.Drawing.Size(178, 22)
        Me.TbCsnrNom.TabIndex = 11
        '
        'TbCsnrPrenom
        '
        Me.TbCsnrPrenom.Location = New System.Drawing.Point(88, 26)
        Me.TbCsnrPrenom.Name = "TbCsnrPrenom"
        Me.TbCsnrPrenom.Size = New System.Drawing.Size(173, 22)
        Me.TbCsnrPrenom.TabIndex = 12
        '
        'GbLocation
        '
        Me.GbLocation.Controls.Add(Me.Label11)
        Me.GbLocation.Controls.Add(Me.Label1)
        Me.GbLocation.Controls.Add(Me.CbEmplacement)
        Me.GbLocation.Controls.Add(Me.Label4)
        Me.GbLocation.Controls.Add(Me.TbdateDateDebut)
        Me.GbLocation.Controls.Add(Me.TbdateDateFin)
        Me.GbLocation.Controls.Add(Me.Label2)
        Me.GbLocation.Controls.Add(Me.BtDebutPlus15Ans)
        Me.GbLocation.Controls.Add(Me.TbfloatMontantPaye)
        Me.GbLocation.Controls.Add(Me.Label3)
        Me.GbLocation.Controls.Add(Me.BtDebutPlus30Ans)
        Me.GbLocation.Location = New System.Drawing.Point(13, 239)
        Me.GbLocation.Name = "GbLocation"
        Me.GbLocation.Size = New System.Drawing.Size(614, 211)
        Me.GbLocation.TabIndex = 11
        Me.GbLocation.TabStop = False
        Me.GbLocation.Text = "Location"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(216, 179)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 17)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "€"
        '
        'TbdateDateDebut
        '
        Me.TbdateDateDebut.DateValue = Nothing
        Me.TbdateDateDebut.Location = New System.Drawing.Point(110, 30)
        Me.TbdateDateDebut.Mask = "00/00/0000"
        Me.TbdateDateDebut.Name = "TbdateDateDebut"
        Me.TbdateDateDebut.Size = New System.Drawing.Size(100, 22)
        Me.TbdateDateDebut.TabIndex = 0
        Me.TbdateDateDebut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbdateDateFin
        '
        Me.TbdateDateFin.DateValue = Nothing
        Me.TbdateDateFin.Location = New System.Drawing.Point(391, 30)
        Me.TbdateDateFin.Mask = "00/00/0000"
        Me.TbdateDateFin.Name = "TbdateDateFin"
        Me.TbdateDateFin.Size = New System.Drawing.Size(100, 22)
        Me.TbdateDateFin.TabIndex = 1
        Me.TbdateDateFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbfloatMontantPaye
        '
        Me.TbfloatMontantPaye.Location = New System.Drawing.Point(110, 178)
        Me.TbfloatMontantPaye.Name = "TbfloatMontantPaye"
        Me.TbfloatMontantPaye.Size = New System.Drawing.Size(100, 22)
        Me.TbfloatMontantPaye.TabIndex = 6
        Me.TbfloatMontantPaye.Value = Nothing
        '
        'BtAnnuler
        '
        Me.BtAnnuler.Location = New System.Drawing.Point(526, 512)
        Me.BtAnnuler.Name = "BtAnnuler"
        Me.BtAnnuler.Size = New System.Drawing.Size(101, 35)
        Me.BtAnnuler.TabIndex = 12
        Me.BtAnnuler.Text = "&Annuler"
        Me.BtAnnuler.UseVisualStyleBackColor = True
        '
        'BtEnregistrer
        '
        Me.BtEnregistrer.Location = New System.Drawing.Point(402, 512)
        Me.BtEnregistrer.Name = "BtEnregistrer"
        Me.BtEnregistrer.Size = New System.Drawing.Size(101, 35)
        Me.BtEnregistrer.TabIndex = 13
        Me.BtEnregistrer.Text = "&Terminer"
        Me.BtEnregistrer.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'TbCommentaire
        '
        Me.TbCommentaire.Location = New System.Drawing.Point(6, 21)
        Me.TbCommentaire.Multiline = True
        Me.TbCommentaire.Name = "TbCommentaire"
        Me.TbCommentaire.Size = New System.Drawing.Size(351, 73)
        Me.TbCommentaire.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TbCommentaire)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 453)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 100)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Commentaire éventuel"
        '
        'FormNouvelleConcession
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 633)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtEnregistrer)
        Me.Controls.Add(Me.BtAnnuler)
        Me.Controls.Add(Me.GbLocation)
        Me.Controls.Add(Me.GbCsnr)
        Me.Name = "FormNouvelleConcession"
        Me.Text = "Enregistrer une nouvelle location"
        Me.GbCsnr.ResumeLayout(False)
        Me.GbCsnr.PerformLayout()
        Me.GbLocation.ResumeLayout(False)
        Me.GbLocation.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TbdateDateDebut As TextBoxDate
    Friend WithEvents TbdateDateFin As TextBoxDate
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtDebutPlus15Ans As Button
    Friend WithEvents BtDebutPlus30Ans As Button
    Friend WithEvents TbfloatMontantPaye As TextBoxFloat
    Friend WithEvents Label3 As Label
    Friend WithEvents CbEmplacement As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GbCsnr As GroupBox
    Friend WithEvents TbCsnrNom As TextBox
    Friend WithEvents TbCsnrPrenom As TextBox
    Friend WithEvents TbdateCsnrDateNaiss As TextBoxDate
    Friend WithEvents TbCsnrAdresse As TextBox
    Friend WithEvents TbCsnrTel As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GbLocation As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents BtAnnuler As Button
    Friend WithEvents BtEnregistrer As Button
    Friend WithEvents TbCsnrNoRegistre As MaskedTextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents CtrlLocVillePays1 As CtrlLocVillePays
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TbCommentaire As TextBox
End Class
