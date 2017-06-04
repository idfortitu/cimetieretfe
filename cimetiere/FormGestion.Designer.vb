<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGestion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGestion))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.BtDefAnnulerRecherche = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtpDefRechercherDateDecesApres = New System.Windows.Forms.DateTimePicker()
        Me.DtpDefRechercherDateDecesAvant = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbDefChampRecherche = New System.Windows.Forms.TextBox()
        Me.CbDefChercherNom = New System.Windows.Forms.CheckBox()
        Me.CbDefChercherCode = New System.Windows.Forms.CheckBox()
        Me.CbDefChercherEmplacement = New System.Windows.Forms.CheckBox()
        Me.BtDefChercher = New System.Windows.Forms.Button()
        Me.LvListeDefunts = New System.Windows.Forms.ListView()
        Me.Nom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Prenom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Emplacement = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DateDeces = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FPBAjouter = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DgvListeDefunts = New cimetiere.DataGridViewCustom()
        Me.ColDefNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDefEmpl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDefDateDeces = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDateCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CtrlLocVillePays1 = New cimetiere.CtrlLocVillePays()
        Me.FPTBLieuNaiss = New System.Windows.Forms.TextBox()
        Me.FPLLieuNaiss = New System.Windows.Forms.Label()
        Me.TbDefAdresse = New System.Windows.Forms.TextBox()
        Me.FPLAdresse = New System.Windows.Forms.Label()
        Me.TbDefPrenom = New System.Windows.Forms.TextBox()
        Me.FPLEmplacement = New System.Windows.Forms.Label()
        Me.FPLDateM = New System.Windows.Forms.Label()
        Me.FPLPrenom = New System.Windows.Forms.Label()
        Me.FPTBDateNaiss = New System.Windows.Forms.TextBox()
        Me.FPLDateNaiss = New System.Windows.Forms.Label()
        Me.TbDefNom = New System.Windows.Forms.TextBox()
        Me.FPLNom = New System.Windows.Forms.Label()
        Me.FPBSupprimer = New System.Windows.Forms.Button()
        Me.FPBModifier = New System.Windows.Forms.Button()
        Me.FPBDetails = New System.Windows.Forms.Button()
        Me.FPBLienCons = New System.Windows.Forms.Button()
        Me.FPTBLahulpe = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.FCDGDefunt = New System.Windows.Forms.DataGridView()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.FCDGBeneficiaire = New System.Windows.Forms.DataGridView()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.FCDGConss = New System.Windows.Forms.DataGridView()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.FCTBDateDeb = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.FCTBDateFin = New System.Windows.Forms.TextBox()
        Me.FCLDenomination = New System.Windows.Forms.Label()
        Me.FCTBnumero = New System.Windows.Forms.TextBox()
        Me.FCLEmplacement = New System.Windows.Forms.Label()
        Me.FCTBEmplacement = New System.Windows.Forms.TextBox()
        Me.FCLPlaceLibre = New System.Windows.Forms.Label()
        Me.FCTBPlaceLibre = New System.Windows.Forms.TextBox()
        Me.FCLPlaceOccupe = New System.Windows.Forms.Label()
        Me.FCTBPlaceOccupe = New System.Windows.Forms.TextBox()
        Me.FCTBMonumentClasse = New System.Windows.Forms.TextBox()
        Me.FCLCommentaire = New System.Windows.Forms.Label()
        Me.FCTBCommentaire = New System.Windows.Forms.TextBox()
        Me.FCLMonumentC = New System.Windows.Forms.Label()
        Me.FCLHistoire = New System.Windows.Forms.Label()
        Me.FCTBHistoire = New System.Windows.Forms.TextBox()
        Me.FCLType = New System.Windows.Forms.Label()
        Me.FCTBType = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.FCTBRechercher = New System.Windows.Forms.TextBox()
        Me.FCCBNom = New System.Windows.Forms.CheckBox()
        Me.FCCBEmplacement = New System.Windows.Forms.CheckBox()
        Me.FCCBType = New System.Windows.Forms.CheckBox()
        Me.FCBSupp = New System.Windows.Forms.Button()
        Me.FCBModifier = New System.Windows.Forms.Button()
        Me.FCBAjouter = New System.Windows.Forms.Button()
        Me.FCBLienDefunt = New System.Windows.Forms.Button()
        Me.FCBDetails = New System.Windows.Forms.Button()
        Me.FCPBlahulpe = New System.Windows.Forms.PictureBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.PRBPersCon = New System.Windows.Forms.RadioButton()
        Me.PRBConcessionnaire = New System.Windows.Forms.RadioButton()
        Me.PRBBenef = New System.Windows.Forms.RadioButton()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.DgvListeConcessionnaires = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TbDateDeces = New cimetiere.TextBoxDate()
        Me.TbDateNaiss = New cimetiere.TextBoxDate()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgvListeDefunts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.FPTBLahulpe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.FCDGDefunt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.FCDGBeneficiaire, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.FCDGConss, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.FCPBlahulpe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        CType(Me.DgvListeConcessionnaires, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(64, 32)
        Me.TabControl1.Location = New System.Drawing.Point(-1, 1)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1733, 828)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.Panel10)
        Me.TabPage1.Controls.Add(Me.LvListeDefunts)
        Me.TabPage1.Controls.Add(Me.FPBAjouter)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.FPBSupprimer)
        Me.TabPage1.Controls.Add(Me.FPBModifier)
        Me.TabPage1.Controls.Add(Me.FPBDetails)
        Me.TabPage1.Controls.Add(Me.FPBLienCons)
        Me.TabPage1.Controls.Add(Me.FPTBLahulpe)
        Me.TabPage1.Location = New System.Drawing.Point(4, 36)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(1725, 788)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Défunt"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel10.Controls.Add(Me.GroupBox10)
        Me.Panel10.Location = New System.Drawing.Point(10, 107)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(283, 261)
        Me.Panel10.TabIndex = 96
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox10.Controls.Add(Me.BtDefAnnulerRecherche)
        Me.GroupBox10.Controls.Add(Me.Label3)
        Me.GroupBox10.Controls.Add(Me.Label2)
        Me.GroupBox10.Controls.Add(Me.DtpDefRechercherDateDecesApres)
        Me.GroupBox10.Controls.Add(Me.DtpDefRechercherDateDecesAvant)
        Me.GroupBox10.Controls.Add(Me.Label1)
        Me.GroupBox10.Controls.Add(Me.TbDefChampRecherche)
        Me.GroupBox10.Controls.Add(Me.CbDefChercherNom)
        Me.GroupBox10.Controls.Add(Me.CbDefChercherCode)
        Me.GroupBox10.Controls.Add(Me.CbDefChercherEmplacement)
        Me.GroupBox10.Controls.Add(Me.BtDefChercher)
        Me.GroupBox10.Location = New System.Drawing.Point(4, 5)
        Me.GroupBox10.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox10.Size = New System.Drawing.Size(274, 251)
        Me.GroupBox10.TabIndex = 0
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Rechercher"
        '
        'BtDefAnnulerRecherche
        '
        Me.BtDefAnnulerRecherche.Location = New System.Drawing.Point(49, 212)
        Me.BtDefAnnulerRecherche.Margin = New System.Windows.Forms.Padding(4)
        Me.BtDefAnnulerRecherche.Name = "BtDefAnnulerRecherche"
        Me.BtDefAnnulerRecherche.Size = New System.Drawing.Size(91, 28)
        Me.BtDefAnnulerRecherche.TabIndex = 97
        Me.BtDefAnnulerRecherche.Text = "Annuler filtre"
        Me.BtDefAnnulerRecherche.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 142)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 18)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "Décédé après :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 177)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 18)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "Décédé avant :"
        '
        'DtpDefRechercherDateDecesApres
        '
        Me.DtpDefRechercherDateDecesApres.Checked = False
        Me.DtpDefRechercherDateDecesApres.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDefRechercherDateDecesApres.Location = New System.Drawing.Point(116, 140)
        Me.DtpDefRechercherDateDecesApres.Margin = New System.Windows.Forms.Padding(4)
        Me.DtpDefRechercherDateDecesApres.Name = "DtpDefRechercherDateDecesApres"
        Me.DtpDefRechercherDateDecesApres.ShowCheckBox = True
        Me.DtpDefRechercherDateDecesApres.Size = New System.Drawing.Size(149, 25)
        Me.DtpDefRechercherDateDecesApres.TabIndex = 94
        '
        'DtpDefRechercherDateDecesAvant
        '
        Me.DtpDefRechercherDateDecesAvant.Checked = False
        Me.DtpDefRechercherDateDecesAvant.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDefRechercherDateDecesAvant.Location = New System.Drawing.Point(116, 174)
        Me.DtpDefRechercherDateDecesAvant.Margin = New System.Windows.Forms.Padding(4)
        Me.DtpDefRechercherDateDecesAvant.Name = "DtpDefRechercherDateDecesAvant"
        Me.DtpDefRechercherDateDecesAvant.ShowCheckBox = True
        Me.DtpDefRechercherDateDecesAvant.Size = New System.Drawing.Size(149, 25)
        Me.DtpDefRechercherDateDecesAvant.TabIndex = 93
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 18)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Dans :"
        '
        'TbDefChampRecherche
        '
        Me.TbDefChampRecherche.Location = New System.Drawing.Point(13, 25)
        Me.TbDefChampRecherche.Margin = New System.Windows.Forms.Padding(4)
        Me.TbDefChampRecherche.Name = "TbDefChampRecherche"
        Me.TbDefChampRecherche.Size = New System.Drawing.Size(199, 25)
        Me.TbDefChampRecherche.TabIndex = 40
        '
        'CbDefChercherNom
        '
        Me.CbDefChercherNom.AutoSize = True
        Me.CbDefChercherNom.Checked = True
        Me.CbDefChercherNom.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbDefChercherNom.Location = New System.Drawing.Point(13, 85)
        Me.CbDefChercherNom.Margin = New System.Windows.Forms.Padding(4)
        Me.CbDefChercherNom.Name = "CbDefChercherNom"
        Me.CbDefChercherNom.Size = New System.Drawing.Size(60, 22)
        Me.CbDefChercherNom.TabIndex = 45
        Me.CbDefChercherNom.Text = "Nom"
        Me.CbDefChercherNom.UseVisualStyleBackColor = True
        '
        'CbDefChercherCode
        '
        Me.CbDefChercherCode.AutoSize = True
        Me.CbDefChercherCode.Checked = True
        Me.CbDefChercherCode.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbDefChercherCode.Location = New System.Drawing.Point(129, 108)
        Me.CbDefChercherCode.Margin = New System.Windows.Forms.Padding(4)
        Me.CbDefChercherCode.Name = "CbDefChercherCode"
        Me.CbDefChercherCode.Size = New System.Drawing.Size(62, 22)
        Me.CbDefChercherCode.TabIndex = 46
        Me.CbDefChercherCode.Text = "Code"
        Me.CbDefChercherCode.UseVisualStyleBackColor = True
        '
        'CbDefChercherEmplacement
        '
        Me.CbDefChercherEmplacement.AutoSize = True
        Me.CbDefChercherEmplacement.Checked = True
        Me.CbDefChercherEmplacement.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbDefChercherEmplacement.Location = New System.Drawing.Point(13, 108)
        Me.CbDefChercherEmplacement.Margin = New System.Windows.Forms.Padding(4)
        Me.CbDefChercherEmplacement.Name = "CbDefChercherEmplacement"
        Me.CbDefChercherEmplacement.Size = New System.Drawing.Size(112, 22)
        Me.CbDefChercherEmplacement.TabIndex = 47
        Me.CbDefChercherEmplacement.Text = "Emplacement"
        Me.CbDefChercherEmplacement.UseVisualStyleBackColor = True
        '
        'BtDefChercher
        '
        Me.BtDefChercher.Location = New System.Drawing.Point(168, 212)
        Me.BtDefChercher.Margin = New System.Windows.Forms.Padding(4)
        Me.BtDefChercher.Name = "BtDefChercher"
        Me.BtDefChercher.Size = New System.Drawing.Size(97, 28)
        Me.BtDefChercher.TabIndex = 49
        Me.BtDefChercher.Text = "Rechercher"
        Me.BtDefChercher.UseVisualStyleBackColor = True
        '
        'LvListeDefunts
        '
        Me.LvListeDefunts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Nom, Me.Prenom, Me.Emplacement, Me.Code, Me.DateDeces})
        Me.LvListeDefunts.FullRowSelect = True
        Me.LvListeDefunts.Location = New System.Drawing.Point(2161, 821)
        Me.LvListeDefunts.Margin = New System.Windows.Forms.Padding(4)
        Me.LvListeDefunts.MultiSelect = False
        Me.LvListeDefunts.Name = "LvListeDefunts"
        Me.LvListeDefunts.Size = New System.Drawing.Size(297, 164)
        Me.LvListeDefunts.TabIndex = 95
        Me.LvListeDefunts.UseCompatibleStateImageBehavior = False
        Me.LvListeDefunts.View = System.Windows.Forms.View.Details
        '
        'Nom
        '
        Me.Nom.Tag = "nom"
        Me.Nom.Text = "Nom"
        '
        'Prenom
        '
        Me.Prenom.Tag = "prenom"
        Me.Prenom.Text = "Prénom"
        '
        'Emplacement
        '
        Me.Emplacement.Tag = "emplacement"
        Me.Emplacement.Text = "Emplacement"
        '
        'Code
        '
        Me.Code.Tag = "code"
        Me.Code.Text = "Code"
        '
        'DateDeces
        '
        Me.DateDeces.Tag = "datedeces"
        Me.DateDeces.Text = "Date de décès"
        '
        'FPBAjouter
        '
        Me.FPBAjouter.BackColor = System.Drawing.Color.SeaGreen
        Me.FPBAjouter.ForeColor = System.Drawing.Color.Transparent
        Me.FPBAjouter.Location = New System.Drawing.Point(1009, 364)
        Me.FPBAjouter.Margin = New System.Windows.Forms.Padding(4)
        Me.FPBAjouter.Name = "FPBAjouter"
        Me.FPBAjouter.Size = New System.Drawing.Size(85, 28)
        Me.FPBAjouter.TabIndex = 88
        Me.FPBAjouter.Text = "Ajouter"
        Me.FPBAjouter.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel3.Controls.Add(Me.GroupBox3)
        Me.Panel3.Location = New System.Drawing.Point(407, 6)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(537, 631)
        Me.Panel3.TabIndex = 94
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox3.Controls.Add(Me.DgvListeDefunts)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 10)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(508, 610)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'DgvListeDefunts
        '
        Me.DgvListeDefunts.AllowUserToAddRows = False
        Me.DgvListeDefunts.AllowUserToDeleteRows = False
        Me.DgvListeDefunts.AllowUserToOrderColumns = True
        Me.DgvListeDefunts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvListeDefunts.BackgroundColor = System.Drawing.Color.White
        Me.DgvListeDefunts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListeDefunts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColDefNom, Me.ColDefEmpl, Me.ColDefDateDeces, Me.ColDateCode})
        Me.DgvListeDefunts.CustomFilterFunc = Nothing
        Me.DgvListeDefunts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvListeDefunts.Location = New System.Drawing.Point(7, 5)
        Me.DgvListeDefunts.MultiSelect = False
        Me.DgvListeDefunts.Name = "DgvListeDefunts"
        Me.DgvListeDefunts.ReadOnly = True
        Me.DgvListeDefunts.RowHeadersVisible = False
        Me.DgvListeDefunts.RowTemplate.Height = 24
        Me.DgvListeDefunts.SelectedItem = Nothing
        Me.DgvListeDefunts.SelectedRowIndex = -1
        Me.DgvListeDefunts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvListeDefunts.Size = New System.Drawing.Size(494, 598)
        Me.DgvListeDefunts.TabIndex = 0
        '
        'ColDefNom
        '
        Me.ColDefNom.DataPropertyName = "Nom"
        Me.ColDefNom.HeaderText = "Nom"
        Me.ColDefNom.Name = "ColDefNom"
        Me.ColDefNom.ReadOnly = True
        Me.ColDefNom.Width = 188
        '
        'ColDefEmpl
        '
        Me.ColDefEmpl.DataPropertyName = "RefEmplacement"
        Me.ColDefEmpl.FillWeight = 50.0!
        Me.ColDefEmpl.HeaderText = "Empl."
        Me.ColDefEmpl.Name = "ColDefEmpl"
        Me.ColDefEmpl.ReadOnly = True
        Me.ColDefEmpl.Width = 94
        '
        'ColDefDateDeces
        '
        Me.ColDefDateDeces.DataPropertyName = "DateDeces"
        Me.ColDefDateDeces.FillWeight = 60.0!
        Me.ColDefDateDeces.HeaderText = "Date de décès"
        Me.ColDefDateDeces.Name = "ColDefDateDeces"
        Me.ColDefDateDeces.ReadOnly = True
        Me.ColDefDateDeces.Width = 112
        '
        'ColDateCode
        '
        Me.ColDateCode.DataPropertyName = "NumeroLh"
        Me.ColDateCode.FillWeight = 50.0!
        Me.ColDateCode.HeaderText = "Code"
        Me.ColDateCode.Name = "ColDateCode"
        Me.ColDateCode.ReadOnly = True
        Me.ColDateCode.Width = 94
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(957, 7)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(724, 327)
        Me.Panel1.TabIndex = 92
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox1.Controls.Add(Me.TbDateNaiss)
        Me.GroupBox1.Controls.Add(Me.TbDateDeces)
        Me.GroupBox1.Controls.Add(Me.CtrlLocVillePays1)
        Me.GroupBox1.Controls.Add(Me.FPTBLieuNaiss)
        Me.GroupBox1.Controls.Add(Me.FPLLieuNaiss)
        Me.GroupBox1.Controls.Add(Me.TbDefAdresse)
        Me.GroupBox1.Controls.Add(Me.FPLAdresse)
        Me.GroupBox1.Controls.Add(Me.TbDefPrenom)
        Me.GroupBox1.Controls.Add(Me.FPLEmplacement)
        Me.GroupBox1.Controls.Add(Me.FPLDateM)
        Me.GroupBox1.Controls.Add(Me.FPLPrenom)
        Me.GroupBox1.Controls.Add(Me.FPTBDateNaiss)
        Me.GroupBox1.Controls.Add(Me.FPLDateNaiss)
        Me.GroupBox1.Controls.Add(Me.TbDefNom)
        Me.GroupBox1.Controls.Add(Me.FPLNom)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(712, 302)
        Me.GroupBox1.TabIndex = 93
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informations du défunt"
        '
        'CtrlLocVillePays1
        '
        Me.CtrlLocVillePays1.Location = New System.Drawing.Point(160, 98)
        Me.CtrlLocVillePays1.Name = "CtrlLocVillePays1"
        Me.CtrlLocVillePays1.Size = New System.Drawing.Size(321, 29)
        Me.CtrlLocVillePays1.TabIndex = 112
        '
        'FPTBLieuNaiss
        '
        Me.FPTBLieuNaiss.Location = New System.Drawing.Point(160, 241)
        Me.FPTBLieuNaiss.Margin = New System.Windows.Forms.Padding(4)
        Me.FPTBLieuNaiss.Name = "FPTBLieuNaiss"
        Me.FPTBLieuNaiss.Size = New System.Drawing.Size(201, 25)
        Me.FPTBLieuNaiss.TabIndex = 111
        '
        'FPLLieuNaiss
        '
        Me.FPLLieuNaiss.AutoSize = True
        Me.FPLLieuNaiss.Location = New System.Drawing.Point(13, 246)
        Me.FPLLieuNaiss.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FPLLieuNaiss.Name = "FPLLieuNaiss"
        Me.FPLLieuNaiss.Size = New System.Drawing.Size(123, 18)
        Me.FPLLieuNaiss.TabIndex = 110
        Me.FPLLieuNaiss.Text = "Lieu de Naissance :"
        '
        'TbDefAdresse
        '
        Me.TbDefAdresse.Location = New System.Drawing.Point(160, 66)
        Me.TbDefAdresse.Margin = New System.Windows.Forms.Padding(4)
        Me.TbDefAdresse.Name = "TbDefAdresse"
        Me.TbDefAdresse.Size = New System.Drawing.Size(201, 25)
        Me.TbDefAdresse.TabIndex = 103
        '
        'FPLAdresse
        '
        Me.FPLAdresse.AutoSize = True
        Me.FPLAdresse.Location = New System.Drawing.Point(79, 70)
        Me.FPLAdresse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FPLAdresse.Name = "FPLAdresse"
        Me.FPLAdresse.Size = New System.Drawing.Size(63, 18)
        Me.FPLAdresse.TabIndex = 102
        Me.FPLAdresse.Text = "Adresse :"
        '
        'TbDefPrenom
        '
        Me.TbDefPrenom.Location = New System.Drawing.Point(463, 33)
        Me.TbDefPrenom.Margin = New System.Windows.Forms.Padding(4)
        Me.TbDefPrenom.Name = "TbDefPrenom"
        Me.TbDefPrenom.Size = New System.Drawing.Size(201, 25)
        Me.TbDefPrenom.TabIndex = 98
        '
        'FPLEmplacement
        '
        Me.FPLEmplacement.AutoSize = True
        Me.FPLEmplacement.Location = New System.Drawing.Point(371, 245)
        Me.FPLEmplacement.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FPLEmplacement.Name = "FPLEmplacement"
        Me.FPLEmplacement.Size = New System.Drawing.Size(97, 18)
        Me.FPLEmplacement.TabIndex = 96
        Me.FPLEmplacement.Text = "Emplacement :"
        '
        'FPLDateM
        '
        Me.FPLDateM.AutoSize = True
        Me.FPLDateM.Location = New System.Drawing.Point(42, 184)
        Me.FPLDateM.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FPLDateM.Name = "FPLDateM"
        Me.FPLDateM.Size = New System.Drawing.Size(118, 18)
        Me.FPLDateM.TabIndex = 95
        Me.FPLDateM.Text = "Date de naissance"
        '
        'FPLPrenom
        '
        Me.FPLPrenom.AutoSize = True
        Me.FPLPrenom.Location = New System.Drawing.Point(389, 33)
        Me.FPLPrenom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FPLPrenom.Name = "FPLPrenom"
        Me.FPLPrenom.Size = New System.Drawing.Size(63, 18)
        Me.FPLPrenom.TabIndex = 94
        Me.FPLPrenom.Text = "Prenom :"
        '
        'FPTBDateNaiss
        '
        Me.FPTBDateNaiss.Location = New System.Drawing.Point(160, 202)
        Me.FPTBDateNaiss.Margin = New System.Windows.Forms.Padding(4)
        Me.FPTBDateNaiss.Name = "FPTBDateNaiss"
        Me.FPTBDateNaiss.Size = New System.Drawing.Size(201, 25)
        Me.FPTBDateNaiss.TabIndex = 91
        '
        'FPLDateNaiss
        '
        Me.FPLDateNaiss.AutoSize = True
        Me.FPLDateNaiss.Location = New System.Drawing.Point(358, 163)
        Me.FPLDateNaiss.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FPLDateNaiss.Name = "FPLDateNaiss"
        Me.FPLDateNaiss.Size = New System.Drawing.Size(94, 18)
        Me.FPLDateNaiss.TabIndex = 88
        Me.FPLDateNaiss.Text = "Date de décès"
        '
        'TbDefNom
        '
        Me.TbDefNom.Location = New System.Drawing.Point(160, 26)
        Me.TbDefNom.Margin = New System.Windows.Forms.Padding(4)
        Me.TbDefNom.Name = "TbDefNom"
        Me.TbDefNom.Size = New System.Drawing.Size(201, 25)
        Me.TbDefNom.TabIndex = 87
        '
        'FPLNom
        '
        Me.FPLNom.AutoSize = True
        Me.FPLNom.Location = New System.Drawing.Point(88, 30)
        Me.FPLNom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FPLNom.Name = "FPLNom"
        Me.FPLNom.Size = New System.Drawing.Size(45, 18)
        Me.FPLNom.TabIndex = 86
        Me.FPLNom.Text = "Nom :"
        '
        'FPBSupprimer
        '
        Me.FPBSupprimer.BackColor = System.Drawing.Color.SeaGreen
        Me.FPBSupprimer.ForeColor = System.Drawing.Color.Transparent
        Me.FPBSupprimer.Location = New System.Drawing.Point(1233, 364)
        Me.FPBSupprimer.Margin = New System.Windows.Forms.Padding(4)
        Me.FPBSupprimer.Name = "FPBSupprimer"
        Me.FPBSupprimer.Size = New System.Drawing.Size(99, 28)
        Me.FPBSupprimer.TabIndex = 90
        Me.FPBSupprimer.Text = "Supprimer"
        Me.FPBSupprimer.UseVisualStyleBackColor = False
        '
        'FPBModifier
        '
        Me.FPBModifier.BackColor = System.Drawing.Color.SeaGreen
        Me.FPBModifier.ForeColor = System.Drawing.Color.Transparent
        Me.FPBModifier.Location = New System.Drawing.Point(1124, 364)
        Me.FPBModifier.Margin = New System.Windows.Forms.Padding(4)
        Me.FPBModifier.Name = "FPBModifier"
        Me.FPBModifier.Size = New System.Drawing.Size(85, 28)
        Me.FPBModifier.TabIndex = 89
        Me.FPBModifier.Text = "Modifier"
        Me.FPBModifier.UseVisualStyleBackColor = False
        '
        'FPBDetails
        '
        Me.FPBDetails.BackColor = System.Drawing.Color.SeaGreen
        Me.FPBDetails.ForeColor = System.Drawing.Color.Transparent
        Me.FPBDetails.Location = New System.Drawing.Point(1543, 405)
        Me.FPBDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.FPBDetails.Name = "FPBDetails"
        Me.FPBDetails.Size = New System.Drawing.Size(132, 59)
        Me.FPBDetails.TabIndex = 87
        Me.FPBDetails.Text = "Détails"
        Me.FPBDetails.UseVisualStyleBackColor = False
        '
        'FPBLienCons
        '
        Me.FPBLienCons.BackColor = System.Drawing.Color.SeaGreen
        Me.FPBLienCons.ForeColor = System.Drawing.Color.Transparent
        Me.FPBLienCons.Location = New System.Drawing.Point(1476, 343)
        Me.FPBLienCons.Margin = New System.Windows.Forms.Padding(4)
        Me.FPBLienCons.Name = "FPBLienCons"
        Me.FPBLienCons.Size = New System.Drawing.Size(203, 59)
        Me.FPBLienCons.TabIndex = 86
        Me.FPBLienCons.Text = "Lien vers concession"
        Me.FPBLienCons.UseVisualStyleBackColor = False
        '
        'FPTBLahulpe
        '
        Me.FPTBLahulpe.Image = CType(resources.GetObject("FPTBLahulpe.Image"), System.Drawing.Image)
        Me.FPTBLahulpe.Location = New System.Drawing.Point(0, 4)
        Me.FPTBLahulpe.Margin = New System.Windows.Forms.Padding(4)
        Me.FPTBLahulpe.Name = "FPTBLahulpe"
        Me.FPTBLahulpe.Size = New System.Drawing.Size(148, 95)
        Me.FPTBLahulpe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FPTBLahulpe.TabIndex = 50
        Me.FPTBLahulpe.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.GhostWhite
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage2.Controls.Add(Me.Panel9)
        Me.TabPage2.Controls.Add(Me.Panel8)
        Me.TabPage2.Controls.Add(Me.Panel7)
        Me.TabPage2.Controls.Add(Me.Panel5)
        Me.TabPage2.Controls.Add(Me.Panel6)
        Me.TabPage2.Controls.Add(Me.Panel4)
        Me.TabPage2.Controls.Add(Me.FCBSupp)
        Me.TabPage2.Controls.Add(Me.FCBModifier)
        Me.TabPage2.Controls.Add(Me.FCBAjouter)
        Me.TabPage2.Controls.Add(Me.FCBLienDefunt)
        Me.TabPage2.Controls.Add(Me.FCBDetails)
        Me.TabPage2.Controls.Add(Me.FCPBlahulpe)
        Me.TabPage2.Location = New System.Drawing.Point(4, 36)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(1725, 788)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Concession"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel9.Controls.Add(Me.GroupBox9)
        Me.Panel9.Location = New System.Drawing.Point(404, 261)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(465, 246)
        Me.Panel9.TabIndex = 131
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox9.Controls.Add(Me.FCDGDefunt)
        Me.GroupBox9.Location = New System.Drawing.Point(23, 17)
        Me.GroupBox9.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox9.Size = New System.Drawing.Size(416, 204)
        Me.GroupBox9.TabIndex = 0
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Défunt :"
        '
        'FCDGDefunt
        '
        Me.FCDGDefunt.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.FCDGDefunt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FCDGDefunt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FCDGDefunt.EnableHeadersVisualStyles = False
        Me.FCDGDefunt.Location = New System.Drawing.Point(0, 17)
        Me.FCDGDefunt.Margin = New System.Windows.Forms.Padding(4)
        Me.FCDGDefunt.Name = "FCDGDefunt"
        Me.FCDGDefunt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FCDGDefunt.RowHeadersVisible = False
        Me.FCDGDefunt.Size = New System.Drawing.Size(416, 187)
        Me.FCDGDefunt.TabIndex = 92
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel8.Controls.Add(Me.GroupBox8)
        Me.Panel8.Location = New System.Drawing.Point(404, 514)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(465, 246)
        Me.Panel8.TabIndex = 131
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox8.Controls.Add(Me.FCDGBeneficiaire)
        Me.GroupBox8.Location = New System.Drawing.Point(23, 17)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox8.Size = New System.Drawing.Size(416, 204)
        Me.GroupBox8.TabIndex = 0
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Bénéficiaire :"
        '
        'FCDGBeneficiaire
        '
        Me.FCDGBeneficiaire.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.FCDGBeneficiaire.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FCDGBeneficiaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FCDGBeneficiaire.EnableHeadersVisualStyles = False
        Me.FCDGBeneficiaire.Location = New System.Drawing.Point(0, 21)
        Me.FCDGBeneficiaire.Margin = New System.Windows.Forms.Padding(4)
        Me.FCDGBeneficiaire.Name = "FCDGBeneficiaire"
        Me.FCDGBeneficiaire.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FCDGBeneficiaire.RowHeadersVisible = False
        Me.FCDGBeneficiaire.Size = New System.Drawing.Size(416, 183)
        Me.FCDGBeneficiaire.TabIndex = 93
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel7.Controls.Add(Me.GroupBox7)
        Me.Panel7.Location = New System.Drawing.Point(925, 514)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(715, 246)
        Me.Panel7.TabIndex = 130
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox7.Controls.Add(Me.Label14)
        Me.GroupBox7.Controls.Add(Me.Label16)
        Me.GroupBox7.Controls.Add(Me.Label18)
        Me.GroupBox7.Controls.Add(Me.Label19)
        Me.GroupBox7.Controls.Add(Me.Label20)
        Me.GroupBox7.Controls.Add(Me.Label21)
        Me.GroupBox7.Controls.Add(Me.Label22)
        Me.GroupBox7.Location = New System.Drawing.Point(23, 17)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox7.Size = New System.Drawing.Size(669, 204)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Infos Bénéficiaires"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(97, 59)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 18)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "Adresse"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(95, 98)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(118, 18)
        Me.Label16.TabIndex = 51
        Me.Label16.Text = "Date de naissance"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(380, 127)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(36, 18)
        Me.Label18.TabIndex = 48
        Me.Label18.Text = "Pays"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(380, 92)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(33, 18)
        Me.Label19.TabIndex = 46
        Me.Label19.Text = "Ville"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(376, 57)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(81, 18)
        Me.Label20.TabIndex = 43
        Me.Label20.Text = "Code postal"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(375, 20)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(38, 18)
        Me.Label21.TabIndex = 41
        Me.Label21.Text = "Nom"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(97, 22)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(56, 18)
        Me.Label22.TabIndex = 39
        Me.Label22.Text = "Prénom"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel5.Controls.Add(Me.GroupBox5)
        Me.Panel5.Location = New System.Drawing.Point(404, 7)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(465, 246)
        Me.Panel5.TabIndex = 130
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox5.Controls.Add(Me.FCDGConss)
        Me.GroupBox5.Location = New System.Drawing.Point(23, 17)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(416, 204)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Concession :"
        '
        'FCDGConss
        '
        Me.FCDGConss.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.FCDGConss.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FCDGConss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FCDGConss.EnableHeadersVisualStyles = False
        Me.FCDGConss.Location = New System.Drawing.Point(0, 18)
        Me.FCDGConss.Margin = New System.Windows.Forms.Padding(4)
        Me.FCDGConss.Name = "FCDGConss"
        Me.FCDGConss.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FCDGConss.RowHeadersVisible = False
        Me.FCDGConss.Size = New System.Drawing.Size(416, 186)
        Me.FCDGConss.TabIndex = 43
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel6.Controls.Add(Me.GroupBox6)
        Me.Panel6.Location = New System.Drawing.Point(925, 7)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(715, 246)
        Me.Panel6.TabIndex = 130
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.FCTBDateDeb)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.FCTBDateFin)
        Me.GroupBox6.Controls.Add(Me.FCLDenomination)
        Me.GroupBox6.Controls.Add(Me.FCTBnumero)
        Me.GroupBox6.Controls.Add(Me.FCLEmplacement)
        Me.GroupBox6.Controls.Add(Me.FCTBEmplacement)
        Me.GroupBox6.Controls.Add(Me.FCLPlaceLibre)
        Me.GroupBox6.Controls.Add(Me.FCTBPlaceLibre)
        Me.GroupBox6.Controls.Add(Me.FCLPlaceOccupe)
        Me.GroupBox6.Controls.Add(Me.FCTBPlaceOccupe)
        Me.GroupBox6.Controls.Add(Me.FCTBMonumentClasse)
        Me.GroupBox6.Controls.Add(Me.FCLCommentaire)
        Me.GroupBox6.Controls.Add(Me.FCTBCommentaire)
        Me.GroupBox6.Controls.Add(Me.FCLMonumentC)
        Me.GroupBox6.Controls.Add(Me.FCLHistoire)
        Me.GroupBox6.Controls.Add(Me.FCTBHistoire)
        Me.GroupBox6.Controls.Add(Me.FCLType)
        Me.GroupBox6.Controls.Add(Me.FCTBType)
        Me.GroupBox6.Location = New System.Drawing.Point(23, 17)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Size = New System.Drawing.Size(669, 204)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Infos Concessions"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(48, 174)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 18)
        Me.Label12.TabIndex = 125
        Me.Label12.Text = "Date de debut"
        '
        'FCTBDateDeb
        '
        Me.FCTBDateDeb.Location = New System.Drawing.Point(164, 170)
        Me.FCTBDateDeb.Margin = New System.Windows.Forms.Padding(4)
        Me.FCTBDateDeb.Name = "FCTBDateDeb"
        Me.FCTBDateDeb.Size = New System.Drawing.Size(169, 25)
        Me.FCTBDateDeb.TabIndex = 126
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(385, 174)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 18)
        Me.Label13.TabIndex = 127
        Me.Label13.Text = "Date de fin"
        '
        'FCTBDateFin
        '
        Me.FCTBDateFin.Location = New System.Drawing.Point(479, 167)
        Me.FCTBDateFin.Margin = New System.Windows.Forms.Padding(4)
        Me.FCTBDateFin.Name = "FCTBDateFin"
        Me.FCTBDateFin.Size = New System.Drawing.Size(169, 25)
        Me.FCTBDateFin.TabIndex = 128
        '
        'FCLDenomination
        '
        Me.FCLDenomination.AutoSize = True
        Me.FCLDenomination.Location = New System.Drawing.Point(84, 28)
        Me.FCLDenomination.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FCLDenomination.Name = "FCLDenomination"
        Me.FCLDenomination.Size = New System.Drawing.Size(58, 18)
        Me.FCLDenomination.TabIndex = 64
        Me.FCLDenomination.Text = "Numero"
        '
        'FCTBnumero
        '
        Me.FCTBnumero.Location = New System.Drawing.Point(165, 27)
        Me.FCTBnumero.Margin = New System.Windows.Forms.Padding(4)
        Me.FCTBnumero.Name = "FCTBnumero"
        Me.FCTBnumero.Size = New System.Drawing.Size(171, 25)
        Me.FCTBnumero.TabIndex = 65
        '
        'FCLEmplacement
        '
        Me.FCLEmplacement.AutoSize = True
        Me.FCLEmplacement.Location = New System.Drawing.Point(369, 25)
        Me.FCLEmplacement.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FCLEmplacement.Name = "FCLEmplacement"
        Me.FCLEmplacement.Size = New System.Drawing.Size(97, 18)
        Me.FCLEmplacement.TabIndex = 66
        Me.FCLEmplacement.Text = "Emplacement :"
        '
        'FCTBEmplacement
        '
        Me.FCTBEmplacement.Location = New System.Drawing.Point(481, 25)
        Me.FCTBEmplacement.Margin = New System.Windows.Forms.Padding(4)
        Me.FCTBEmplacement.Name = "FCTBEmplacement"
        Me.FCTBEmplacement.Size = New System.Drawing.Size(169, 25)
        Me.FCTBEmplacement.TabIndex = 67
        '
        'FCLPlaceLibre
        '
        Me.FCLPlaceLibre.AutoSize = True
        Me.FCLPlaceLibre.Location = New System.Drawing.Point(71, 65)
        Me.FCLPlaceLibre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FCLPlaceLibre.Name = "FCLPlaceLibre"
        Me.FCLPlaceLibre.Size = New System.Drawing.Size(76, 18)
        Me.FCLPlaceLibre.TabIndex = 68
        Me.FCLPlaceLibre.Text = "Place libre :"
        '
        'FCTBPlaceLibre
        '
        Me.FCTBPlaceLibre.Location = New System.Drawing.Point(167, 62)
        Me.FCTBPlaceLibre.Margin = New System.Windows.Forms.Padding(4)
        Me.FCTBPlaceLibre.Name = "FCTBPlaceLibre"
        Me.FCTBPlaceLibre.Size = New System.Drawing.Size(169, 25)
        Me.FCTBPlaceLibre.TabIndex = 69
        '
        'FCLPlaceOccupe
        '
        Me.FCLPlaceOccupe.AutoSize = True
        Me.FCLPlaceOccupe.Location = New System.Drawing.Point(372, 63)
        Me.FCLPlaceOccupe.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FCLPlaceOccupe.Name = "FCLPlaceOccupe"
        Me.FCLPlaceOccupe.Size = New System.Drawing.Size(93, 18)
        Me.FCLPlaceOccupe.TabIndex = 70
        Me.FCLPlaceOccupe.Text = "Place occupé :"
        '
        'FCTBPlaceOccupe
        '
        Me.FCTBPlaceOccupe.Location = New System.Drawing.Point(481, 59)
        Me.FCTBPlaceOccupe.Margin = New System.Windows.Forms.Padding(4)
        Me.FCTBPlaceOccupe.Name = "FCTBPlaceOccupe"
        Me.FCTBPlaceOccupe.Size = New System.Drawing.Size(169, 25)
        Me.FCTBPlaceOccupe.TabIndex = 71
        '
        'FCTBMonumentClasse
        '
        Me.FCTBMonumentClasse.Location = New System.Drawing.Point(165, 98)
        Me.FCTBMonumentClasse.Margin = New System.Windows.Forms.Padding(4)
        Me.FCTBMonumentClasse.Name = "FCTBMonumentClasse"
        Me.FCTBMonumentClasse.Size = New System.Drawing.Size(169, 25)
        Me.FCTBMonumentClasse.TabIndex = 95
        '
        'FCLCommentaire
        '
        Me.FCLCommentaire.AutoSize = True
        Me.FCLCommentaire.Location = New System.Drawing.Point(369, 100)
        Me.FCLCommentaire.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FCLCommentaire.Name = "FCLCommentaire"
        Me.FCLCommentaire.Size = New System.Drawing.Size(98, 18)
        Me.FCLCommentaire.TabIndex = 124
        Me.FCLCommentaire.Text = "Commentaire :"
        '
        'FCTBCommentaire
        '
        Me.FCTBCommentaire.Location = New System.Drawing.Point(481, 96)
        Me.FCTBCommentaire.Margin = New System.Windows.Forms.Padding(4)
        Me.FCTBCommentaire.Name = "FCTBCommentaire"
        Me.FCTBCommentaire.Size = New System.Drawing.Size(169, 25)
        Me.FCTBCommentaire.TabIndex = 97
        '
        'FCLMonumentC
        '
        Me.FCLMonumentC.AutoSize = True
        Me.FCLMonumentC.Location = New System.Drawing.Point(19, 102)
        Me.FCLMonumentC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FCLMonumentC.Name = "FCLMonumentC"
        Me.FCLMonumentC.Size = New System.Drawing.Size(126, 18)
        Me.FCLMonumentC.TabIndex = 123
        Me.FCLMonumentC.Text = "Monument Classé :"
        '
        'FCLHistoire
        '
        Me.FCLHistoire.AutoSize = True
        Me.FCLHistoire.Location = New System.Drawing.Point(87, 138)
        Me.FCLHistoire.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FCLHistoire.Name = "FCLHistoire"
        Me.FCLHistoire.Size = New System.Drawing.Size(62, 18)
        Me.FCLHistoire.TabIndex = 98
        Me.FCLHistoire.Text = "Histoire :"
        '
        'FCTBHistoire
        '
        Me.FCTBHistoire.Location = New System.Drawing.Point(167, 134)
        Me.FCTBHistoire.Margin = New System.Windows.Forms.Padding(4)
        Me.FCTBHistoire.Name = "FCTBHistoire"
        Me.FCTBHistoire.Size = New System.Drawing.Size(169, 25)
        Me.FCTBHistoire.TabIndex = 99
        '
        'FCLType
        '
        Me.FCLType.AutoSize = True
        Me.FCLType.Location = New System.Drawing.Point(424, 135)
        Me.FCLType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FCLType.Name = "FCLType"
        Me.FCLType.Size = New System.Drawing.Size(44, 18)
        Me.FCLType.TabIndex = 100
        Me.FCLType.Text = "Type :"
        '
        'FCTBType
        '
        Me.FCTBType.Location = New System.Drawing.Point(481, 132)
        Me.FCTBType.Margin = New System.Windows.Forms.Padding(4)
        Me.FCTBType.Name = "FCTBType"
        Me.FCTBType.Size = New System.Drawing.Size(169, 25)
        Me.FCTBType.TabIndex = 101
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel4.Controls.Add(Me.GroupBox4)
        Me.Panel4.Location = New System.Drawing.Point(25, 113)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(351, 170)
        Me.Panel4.TabIndex = 129
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.FCTBRechercher)
        Me.GroupBox4.Controls.Add(Me.FCCBNom)
        Me.GroupBox4.Controls.Add(Me.FCCBEmplacement)
        Me.GroupBox4.Controls.Add(Me.FCCBType)
        Me.GroupBox4.Location = New System.Drawing.Point(15, 12)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(312, 139)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Rechercher :"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(7, 80)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(169, 28)
        Me.Button2.TabIndex = 127
        Me.Button2.Text = "Annuler la recherche"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(193, 79)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 28)
        Me.Button3.TabIndex = 126
        Me.Button3.Text = "Rechercher"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FCTBRechercher
        '
        Me.FCTBRechercher.Location = New System.Drawing.Point(8, 17)
        Me.FCTBRechercher.Margin = New System.Windows.Forms.Padding(4)
        Me.FCTBRechercher.Name = "FCTBRechercher"
        Me.FCTBRechercher.Size = New System.Drawing.Size(208, 25)
        Me.FCTBRechercher.TabIndex = 35
        '
        'FCCBNom
        '
        Me.FCCBNom.AutoSize = True
        Me.FCCBNom.Location = New System.Drawing.Point(11, 50)
        Me.FCCBNom.Margin = New System.Windows.Forms.Padding(4)
        Me.FCCBNom.Name = "FCCBNom"
        Me.FCCBNom.Size = New System.Drawing.Size(60, 22)
        Me.FCCBNom.TabIndex = 40
        Me.FCCBNom.Text = "Nom"
        Me.FCCBNom.UseVisualStyleBackColor = True
        '
        'FCCBEmplacement
        '
        Me.FCCBEmplacement.AutoSize = True
        Me.FCCBEmplacement.Location = New System.Drawing.Point(83, 50)
        Me.FCCBEmplacement.Margin = New System.Windows.Forms.Padding(4)
        Me.FCCBEmplacement.Name = "FCCBEmplacement"
        Me.FCCBEmplacement.Size = New System.Drawing.Size(112, 22)
        Me.FCCBEmplacement.TabIndex = 42
        Me.FCCBEmplacement.Text = "Emplacement"
        Me.FCCBEmplacement.UseVisualStyleBackColor = True
        '
        'FCCBType
        '
        Me.FCCBType.AutoSize = True
        Me.FCCBType.Location = New System.Drawing.Point(216, 50)
        Me.FCCBType.Margin = New System.Windows.Forms.Padding(4)
        Me.FCCBType.Name = "FCCBType"
        Me.FCCBType.Size = New System.Drawing.Size(59, 22)
        Me.FCCBType.TabIndex = 125
        Me.FCCBType.Text = "Type"
        Me.FCCBType.UseVisualStyleBackColor = True
        '
        'FCBSupp
        '
        Me.FCBSupp.BackColor = System.Drawing.Color.SeaGreen
        Me.FCBSupp.ForeColor = System.Drawing.Color.Transparent
        Me.FCBSupp.Location = New System.Drawing.Point(233, 290)
        Me.FCBSupp.Margin = New System.Windows.Forms.Padding(4)
        Me.FCBSupp.Name = "FCBSupp"
        Me.FCBSupp.Size = New System.Drawing.Size(99, 28)
        Me.FCBSupp.TabIndex = 128
        Me.FCBSupp.Text = "Supprimer"
        Me.FCBSupp.UseVisualStyleBackColor = False
        '
        'FCBModifier
        '
        Me.FCBModifier.BackColor = System.Drawing.Color.SeaGreen
        Me.FCBModifier.ForeColor = System.Drawing.Color.Transparent
        Me.FCBModifier.Location = New System.Drawing.Point(132, 290)
        Me.FCBModifier.Margin = New System.Windows.Forms.Padding(4)
        Me.FCBModifier.Name = "FCBModifier"
        Me.FCBModifier.Size = New System.Drawing.Size(85, 28)
        Me.FCBModifier.TabIndex = 127
        Me.FCBModifier.Text = "Modifier"
        Me.FCBModifier.UseVisualStyleBackColor = False
        '
        'FCBAjouter
        '
        Me.FCBAjouter.BackColor = System.Drawing.Color.SeaGreen
        Me.FCBAjouter.ForeColor = System.Drawing.Color.Transparent
        Me.FCBAjouter.Location = New System.Drawing.Point(39, 289)
        Me.FCBAjouter.Margin = New System.Windows.Forms.Padding(4)
        Me.FCBAjouter.Name = "FCBAjouter"
        Me.FCBAjouter.Size = New System.Drawing.Size(85, 28)
        Me.FCBAjouter.TabIndex = 126
        Me.FCBAjouter.Text = "Ajouter"
        Me.FCBAjouter.UseVisualStyleBackColor = False
        '
        'FCBLienDefunt
        '
        Me.FCBLienDefunt.BackColor = System.Drawing.Color.SeaGreen
        Me.FCBLienDefunt.ForeColor = System.Drawing.Color.Transparent
        Me.FCBLienDefunt.Location = New System.Drawing.Point(1243, 329)
        Me.FCBLienDefunt.Margin = New System.Windows.Forms.Padding(4)
        Me.FCBLienDefunt.Name = "FCBLienDefunt"
        Me.FCBLienDefunt.Size = New System.Drawing.Size(205, 70)
        Me.FCBLienDefunt.TabIndex = 91
        Me.FCBLienDefunt.Text = "Lien vers Défunt"
        Me.FCBLienDefunt.UseVisualStyleBackColor = False
        '
        'FCBDetails
        '
        Me.FCBDetails.BackColor = System.Drawing.Color.SeaGreen
        Me.FCBDetails.ForeColor = System.Drawing.Color.Transparent
        Me.FCBDetails.Location = New System.Drawing.Point(1525, 331)
        Me.FCBDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.FCBDetails.Name = "FCBDetails"
        Me.FCBDetails.Size = New System.Drawing.Size(115, 65)
        Me.FCBDetails.TabIndex = 90
        Me.FCBDetails.Text = "Détails"
        Me.FCBDetails.UseVisualStyleBackColor = False
        '
        'FCPBlahulpe
        '
        Me.FCPBlahulpe.Image = CType(resources.GetObject("FCPBlahulpe.Image"), System.Drawing.Image)
        Me.FCPBlahulpe.Location = New System.Drawing.Point(0, 2)
        Me.FCPBlahulpe.Margin = New System.Windows.Forms.Padding(4)
        Me.FCPBlahulpe.Name = "FCPBlahulpe"
        Me.FCPBlahulpe.Size = New System.Drawing.Size(148, 95)
        Me.FCPBlahulpe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FCPBlahulpe.TabIndex = 45
        Me.FCPBlahulpe.TabStop = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Panel2)
        Me.TabPage3.Controls.Add(Me.Button10)
        Me.TabPage3.Controls.Add(Me.Button11)
        Me.TabPage3.Controls.Add(Me.Button12)
        Me.TabPage3.Controls.Add(Me.PRBPersCon)
        Me.TabPage3.Controls.Add(Me.PRBConcessionnaire)
        Me.TabPage3.Controls.Add(Me.PRBBenef)
        Me.TabPage3.Controls.Add(Me.FlowLayoutPanel1)
        Me.TabPage3.Controls.Add(Me.Panel12)
        Me.TabPage3.Controls.Add(Me.PictureBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 36)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Size = New System.Drawing.Size(1725, 788)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Personnes"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Location = New System.Drawing.Point(27, 111)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(351, 170)
        Me.Panel2.TabIndex = 146
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button9)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 12)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(312, 139)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rechercher :"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(7, 80)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(169, 28)
        Me.Button4.TabIndex = 127
        Me.Button4.Text = "Annuler la recherche"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(193, 79)
        Me.Button9.Margin = New System.Windows.Forms.Padding(4)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(100, 28)
        Me.Button9.TabIndex = 126
        Me.Button9.Text = "Rechercher"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(8, 17)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(208, 25)
        Me.TextBox1.TabIndex = 35
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(11, 50)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(60, 22)
        Me.CheckBox1.TabIndex = 40
        Me.CheckBox1.Text = "Nom"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(83, 50)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(140, 22)
        Me.CheckBox2.TabIndex = 42
        Me.CheckBox2.Text = "Date de naissance"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.SeaGreen
        Me.Button10.ForeColor = System.Drawing.Color.Transparent
        Me.Button10.Location = New System.Drawing.Point(235, 288)
        Me.Button10.Margin = New System.Windows.Forms.Padding(4)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(99, 28)
        Me.Button10.TabIndex = 145
        Me.Button10.Text = "Supprimer"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.SeaGreen
        Me.Button11.ForeColor = System.Drawing.Color.Transparent
        Me.Button11.Location = New System.Drawing.Point(133, 288)
        Me.Button11.Margin = New System.Windows.Forms.Padding(4)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(85, 28)
        Me.Button11.TabIndex = 144
        Me.Button11.Text = "Modifier"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.SeaGreen
        Me.Button12.ForeColor = System.Drawing.Color.Transparent
        Me.Button12.Location = New System.Drawing.Point(40, 287)
        Me.Button12.Margin = New System.Windows.Forms.Padding(4)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(85, 28)
        Me.Button12.TabIndex = 143
        Me.Button12.Text = "Ajouter"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'PRBPersCon
        '
        Me.PRBPersCon.AutoSize = True
        Me.PRBPersCon.Location = New System.Drawing.Point(681, 10)
        Me.PRBPersCon.Margin = New System.Windows.Forms.Padding(4)
        Me.PRBPersCon.Name = "PRBPersCon"
        Me.PRBPersCon.Size = New System.Drawing.Size(154, 22)
        Me.PRBPersCon.TabIndex = 142
        Me.PRBPersCon.Text = "Personne de contact"
        Me.PRBPersCon.UseVisualStyleBackColor = True
        '
        'PRBConcessionnaire
        '
        Me.PRBConcessionnaire.AutoSize = True
        Me.PRBConcessionnaire.Location = New System.Drawing.Point(532, 10)
        Me.PRBConcessionnaire.Margin = New System.Windows.Forms.Padding(4)
        Me.PRBConcessionnaire.Name = "PRBConcessionnaire"
        Me.PRBConcessionnaire.Size = New System.Drawing.Size(128, 22)
        Me.PRBConcessionnaire.TabIndex = 141
        Me.PRBConcessionnaire.Text = "Concessionnaire"
        Me.PRBConcessionnaire.UseVisualStyleBackColor = True
        '
        'PRBBenef
        '
        Me.PRBBenef.AutoSize = True
        Me.PRBBenef.Checked = True
        Me.PRBBenef.Location = New System.Drawing.Point(412, 10)
        Me.PRBBenef.Margin = New System.Windows.Forms.Padding(4)
        Me.PRBBenef.Name = "PRBBenef"
        Me.PRBBenef.Size = New System.Drawing.Size(97, 22)
        Me.PRBBenef.TabIndex = 140
        Me.PRBBenef.TabStop = True
        Me.PRBBenef.Text = "Bénéficiaire"
        Me.PRBBenef.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel13)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel15)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(919, 38)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(729, 523)
        Me.FlowLayoutPanel1.TabIndex = 139
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel13.Controls.Add(Me.GroupBox13)
        Me.Panel13.Location = New System.Drawing.Point(4, 4)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(708, 246)
        Me.Panel13.TabIndex = 138
        '
        'GroupBox13
        '
        Me.GroupBox13.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox13.Controls.Add(Me.Button5)
        Me.GroupBox13.Controls.Add(Me.Button6)
        Me.GroupBox13.Controls.Add(Me.Label4)
        Me.GroupBox13.Controls.Add(Me.Label9)
        Me.GroupBox13.Controls.Add(Me.Label8)
        Me.GroupBox13.Controls.Add(Me.Label7)
        Me.GroupBox13.Controls.Add(Me.Label6)
        Me.GroupBox13.Controls.Add(Me.Label5)
        Me.GroupBox13.Controls.Add(Me.Label10)
        Me.GroupBox13.Controls.Add(Me.Label11)
        Me.GroupBox13.Controls.Add(Me.Label28)
        Me.GroupBox13.Location = New System.Drawing.Point(23, 17)
        Me.GroupBox13.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox13.Size = New System.Drawing.Size(667, 204)
        Me.GroupBox13.TabIndex = 0
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Infos Personnes"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.SeaGreen
        Me.Button5.ForeColor = System.Drawing.Color.Transparent
        Me.Button5.Location = New System.Drawing.Point(537, 159)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(99, 28)
        Me.Button5.TabIndex = 137
        Me.Button5.Text = "Supprimer"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.SeaGreen
        Me.Button6.ForeColor = System.Drawing.Color.Transparent
        Me.Button6.Location = New System.Drawing.Point(537, 123)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(85, 28)
        Me.Button6.TabIndex = 136
        Me.Button6.Text = "Modifier"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 18)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Adresse"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 161)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 18)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "N° national"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 18)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Date de naissance"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 18)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Téléphone"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(301, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 18)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Pays"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(301, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 18)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Ville"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(297, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 18)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Code postal"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(296, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 18)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Nom"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(19, 21)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(56, 18)
        Me.Label28.TabIndex = 21
        Me.Label28.Text = "Prénom"
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel15.Controls.Add(Me.GroupBox15)
        Me.Panel15.Location = New System.Drawing.Point(4, 258)
        Me.Panel15.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(708, 246)
        Me.Panel15.TabIndex = 140
        '
        'GroupBox15
        '
        Me.GroupBox15.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox15.Controls.Add(Me.LinkLabel1)
        Me.GroupBox15.Controls.Add(Me.Button7)
        Me.GroupBox15.Controls.Add(Me.Button8)
        Me.GroupBox15.Location = New System.Drawing.Point(23, 17)
        Me.GroupBox15.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox15.Size = New System.Drawing.Size(667, 204)
        Me.GroupBox15.TabIndex = 0
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Infos bénéficiaires"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(43, 33)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(135, 18)
        Me.LinkLabel1.TabIndex = 138
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Emplacement A7262"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.SeaGreen
        Me.Button7.ForeColor = System.Drawing.Color.Transparent
        Me.Button7.Location = New System.Drawing.Point(524, 94)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(99, 28)
        Me.Button7.TabIndex = 137
        Me.Button7.Text = "Supprimer"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.SeaGreen
        Me.Button8.ForeColor = System.Drawing.Color.Transparent
        Me.Button8.Location = New System.Drawing.Point(537, 58)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(85, 28)
        Me.Button8.TabIndex = 136
        Me.Button8.Text = "Modifier"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel12.Controls.Add(Me.GroupBox12)
        Me.Panel12.Location = New System.Drawing.Point(403, 38)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(465, 649)
        Me.Panel12.TabIndex = 137
        '
        'GroupBox12
        '
        Me.GroupBox12.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox12.Controls.Add(Me.DgvListeConcessionnaires)
        Me.GroupBox12.Location = New System.Drawing.Point(23, 17)
        Me.GroupBox12.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox12.Size = New System.Drawing.Size(416, 594)
        Me.GroupBox12.TabIndex = 0
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Acteurs"
        '
        'DgvListeConcessionnaires
        '
        Me.DgvListeConcessionnaires.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DgvListeConcessionnaires.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvListeConcessionnaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListeConcessionnaires.EnableHeadersVisualStyles = False
        Me.DgvListeConcessionnaires.Location = New System.Drawing.Point(0, 18)
        Me.DgvListeConcessionnaires.Margin = New System.Windows.Forms.Padding(4)
        Me.DgvListeConcessionnaires.Name = "DgvListeConcessionnaires"
        Me.DgvListeConcessionnaires.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DgvListeConcessionnaires.RowHeadersVisible = False
        Me.DgvListeConcessionnaires.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvListeConcessionnaires.Size = New System.Drawing.Size(416, 578)
        Me.DgvListeConcessionnaires.TabIndex = 43
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(148, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 132
        Me.PictureBox1.TabStop = False
        '
        'TbDateDeces
        '
        Me.TbDateDeces.DateValue = Nothing
        Me.TbDateDeces.Location = New System.Drawing.Point(1135, 499)
        Me.TbDateDeces.Mask = "00/00/0000"
        Me.TbDateDeces.Name = "TbDateDeces"
        Me.TbDateDeces.Size = New System.Drawing.Size(100, 25)
        Me.TbDateDeces.TabIndex = 113
        Me.TbDateDeces.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbDateNaiss
        '
        Me.TbDateNaiss.DateValue = Nothing
        Me.TbDateNaiss.Location = New System.Drawing.Point(180, 160)
        Me.TbDateNaiss.Mask = "00/00/0000"
        Me.TbDateNaiss.Name = "TbDateNaiss"
        Me.TbDateNaiss.Size = New System.Drawing.Size(100, 25)
        Me.TbDateNaiss.TabIndex = 114
        Me.TbDateNaiss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FormGestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1906, 1037)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FormGestion"
        Me.Text = "FormGestion"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DgvListeDefunts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.FPTBLahulpe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        CType(Me.FCDGDefunt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.FCDGBeneficiaire, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.FCDGConss, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.FCPBlahulpe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.Panel15.ResumeLayout(False)
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        CType(Me.DgvListeConcessionnaires, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents LvListeDefunts As ListView
    Friend WithEvents Nom As ColumnHeader
    Friend WithEvents Prenom As ColumnHeader
    Friend WithEvents Emplacement As ColumnHeader
    Friend WithEvents Code As ColumnHeader
    Friend WithEvents DateDeces As ColumnHeader
    Friend WithEvents FPBAjouter As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FPTBLieuNaiss As TextBox
    Friend WithEvents FPLLieuNaiss As Label
    Friend WithEvents TbDefAdresse As TextBox
    Friend WithEvents FPLAdresse As Label
    Friend WithEvents TbDefPrenom As TextBox
    Friend WithEvents FPLEmplacement As Label
    Friend WithEvents FPLDateM As Label
    Friend WithEvents FPLPrenom As Label
    Friend WithEvents FPTBDateNaiss As TextBox
    Friend WithEvents FPLDateNaiss As Label
    Friend WithEvents TbDefNom As TextBox
    Friend WithEvents FPLNom As Label
    Friend WithEvents FPBSupprimer As Button
    Friend WithEvents FPBModifier As Button
    Friend WithEvents FPBDetails As Button
    Friend WithEvents FPBLienCons As Button
    Friend WithEvents FPTBLahulpe As PictureBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel9 As Panel
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents FCDGDefunt As DataGridView
    Friend WithEvents Panel8 As Panel
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents FCDGBeneficiaire As DataGridView
    Friend WithEvents Panel7 As Panel
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents FCDGConss As DataGridView
    Friend WithEvents Panel6 As Panel
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents FCTBDateDeb As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents FCTBDateFin As TextBox
    Friend WithEvents FCLDenomination As Label
    Friend WithEvents FCTBnumero As TextBox
    Friend WithEvents FCLEmplacement As Label
    Friend WithEvents FCTBEmplacement As TextBox
    Friend WithEvents FCLPlaceLibre As Label
    Friend WithEvents FCTBPlaceLibre As TextBox
    Friend WithEvents FCLPlaceOccupe As Label
    Friend WithEvents FCTBPlaceOccupe As TextBox
    Friend WithEvents FCTBMonumentClasse As TextBox
    Friend WithEvents FCLCommentaire As Label
    Friend WithEvents FCTBCommentaire As TextBox
    Friend WithEvents FCLMonumentC As Label
    Friend WithEvents FCLHistoire As Label
    Friend WithEvents FCTBHistoire As TextBox
    Friend WithEvents FCLType As Label
    Friend WithEvents FCTBType As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents FCTBRechercher As TextBox
    Friend WithEvents FCCBNom As CheckBox
    Friend WithEvents FCCBEmplacement As CheckBox
    Friend WithEvents FCCBType As CheckBox
    Friend WithEvents FCBSupp As Button
    Friend WithEvents FCBModifier As Button
    Friend WithEvents FCBAjouter As Button
    Friend WithEvents FCBLienDefunt As Button
    Friend WithEvents FCBDetails As Button
    Friend WithEvents FCPBlahulpe As PictureBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents PRBPersCon As RadioButton
    Friend WithEvents PRBConcessionnaire As RadioButton
    Friend WithEvents PRBBenef As RadioButton
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Panel15 As Panel
    Friend WithEvents GroupBox15 As GroupBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Panel12 As Panel
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents DgvListeConcessionnaires As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DgvListeDefunts As DataGridViewCustom
    Friend WithEvents ColDefNom As DataGridViewTextBoxColumn
    Friend WithEvents ColDefEmpl As DataGridViewTextBoxColumn
    Friend WithEvents ColDefDateDeces As DataGridViewTextBoxColumn
    Friend WithEvents ColDateCode As DataGridViewTextBoxColumn
    Friend WithEvents Panel10 As Panel
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents BtDefAnnulerRecherche As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DtpDefRechercherDateDecesApres As DateTimePicker
    Friend WithEvents DtpDefRechercherDateDecesAvant As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents TbDefChampRecherche As TextBox
    Friend WithEvents CbDefChercherNom As CheckBox
    Friend WithEvents CbDefChercherCode As CheckBox
    Friend WithEvents CbDefChercherEmplacement As CheckBox
    Friend WithEvents BtDefChercher As Button
    Friend WithEvents CtrlLocVillePays1 As CtrlLocVillePays
    Friend WithEvents TbDateNaiss As TextBoxDate
    Friend WithEvents TbDateDeces As TextBoxDate
End Class
