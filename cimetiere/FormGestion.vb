Public Class FormGestion

    Private ListeDefunts As SortableBindingList(Of Defunt)
    Private ListeBeneficiaires As SortableBindingList(Of Beneficiaire)
    Private ListeConcessionnaires As SortableBindingList(Of Concessionnaire)
    Private ListePersonnesContact As SortableBindingList(Of PersonneContact)
    Private ListeEmplacements As SortableBindingList(Of Emplacement)


    Public Sub New()
        InitializeComponent()      ' This call is required by the designer.
        DgvListeDefunts.AutoGenerateColumns = False

    End Sub


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Using ctx As New CimEntities
            ChargerDefunts(ctx)
            DgvListeDefunts.CustomFilterFunc = AddressOf FiltrerElemDefunt
            ChargerBenefs(ctx)
            'DgvListeBeneficiaires.CustomFilterFunc = AddressOf FiltrerElemPersonne
            ChargerCsnrs(ctx)
            'DgvListeConcessionnaires.CustomFilterFunc = AddressOf FiltrerElemPersonne
            ChargerPersContact(ctx)
            'DgvListePersContact.CustomFilterFunc = AddressOf FiltrerElemPersonne
            ChargerEmplacements(ctx)
            'DgvListeEmplacements.CustomFilterFunc = AddressOf FiltrerElemEmplacement
        End Using
    End Sub

    Private Function FiltrerElemDefunt(elem As Object, filtre As String) As Boolean
        Dim def = CType(elem, Defunt)
        With def

            ' élimine les défunts qui ne correspondent pas aux dates, si celles-ci sont précisées
            ' (la value du contrôle DateTimePicker comprend aussi l'heure actuelle même si il ne le montre pas, d'où la précisionDtpDefRecherche.Value.Date)
            If DtpDefRechercherDateDecesApres.Checked AndAlso (Not .DateDeces.HasValue OrElse .DateDeces < DtpDefRechercherDateDecesApres.Value.Date) Then Return False
            If DtpDefRechercherDateDecesAvant.Checked AndAlso (Not .DateDeces.HasValue OrElse .DateDeces > DtpDefRechercherDateDecesAvant.Value.Date) Then Return False

            ' filtre sur base du texte de recherche
            filtre = TbDefChampRecherche.Text       ' on n'utilise pas le filtre de la SBList, on le lit directement depuis la textbox 

            ' un filtre vide ne filtre rien, peu importe que les checkbox soient cochées ou pas
            If filtre = "" Then Return True

            ' on accepte l'élément dès qu'un critère (nom, code, emplacement) correspond à la recherche
            Dim filtrereduit = Uzineagaz.ReduireString(filtre)
            If CbDefChercherNom.Checked AndAlso Uzineagaz.ReduireString(.Nom).Contains(filtrereduit) Then Return True
            If CbDefChercherEmplacement.Checked AndAlso .Emplacement.Reference IsNot Nothing AndAlso .Emplacement.Reference.Contains(filtrereduit) Then Return True
            If CbDefChercherCode.Checked AndAlso .NumeroLh.HasValue AndAlso .NumeroLh.ToString.Contains(filtrereduit) Then Return True

            ' sinon, on élimine
            Return False
        End With
    End Function


    'Private Sub FPBDetails_Click(sender As Object, e As EventArgs) Handles FPBDetails.Click
    '    Dim FDetails As New FDetails
    '    FDetails.ShowDialog()
    'End Sub

    'Private Sub FCBDetails_Click(sender As Object, e As EventArgs) Handles FCBDetails.Click
    '    Dim FDetails As New FDetails
    '    FDetails.ShowDialog()
    'End Sub

    'Private Sub FPBAjouter_Click(sender As Object, e As EventArgs) Handles FPBAjouter.Click
    'End Sub


    'Private Sub FPBRechercher_Click(sender As Object, e As EventArgs)
    '    'If FPCBNom.Checked = True Then
    '    'Dim Source As New BindingSource()
    '    'Source.DataSource = Me.DgvListeDefunts.DataSource
    '    'Source.Filter = "def_nom Like '%" & FPTBRechercher.Text & "%'"
    '    'ElseIf FPCBEmplacement.Checked = True Then

    '    '        ElseIf FPCBDate.Checked = True Then
    '    ' erreur avec les dates
    '    ' Dim Source As New BindingSource()
    '    '  Source.DataSource = Me.DgvListeDefunts.DataSource
    '    '  Source.Filter = "def_date_naiss like '%" & FPTBRechercher.ToString & "%'"

    '    ' ElseIf FPCBDateD.Checked = True Then

    '    ' Else
    '    'MessageBox.Show("Veuillez inserer un choix")
    '    '  End If

    'End Sub



    Private Sub BtDefChercher_Click(sender As Object, e As EventArgs) Handles BtDefChercher.Click
        If TbDefChampRecherche.Text.Trim = "" OrElse (CbDefChercherNom.Checked OrElse CbDefChercherEmplacement.Checked OrElse CbDefChercherCode.Checked) OrElse DtpDefRechercherDateDecesApres.Checked OrElse DtpDefRechercherDateDecesAvant.Checked Then
            ListeDefunts.UpdateFilter()      ' appellera FiltrerElemListeDefunts sur chaque item de la liste
            ' appel manuel : la sortablebindinglist ne refiltre pas si le filtre est le même qu'avant, sauf que les checkbox peuvent avoir changé
        Else
            ' À FAIRE : aucun critère -> tooltip "choisissez au moins un critère"
        End If

    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    '    Dim Source As New BindingSource()
    '    Source.DataSource = Me.DgvListeDefunts.DataSource

    '    Source.Filter = "def_nom like '%'"
    'End Sub



    'Private Sub PRBConcessionnaire_CheckedChanged(sender As Object, e As EventArgs) Handles PRBConcessionnaire.CheckedChanged
    '    DataBindClear()
    '    DgvListeConcessionnaires.DataBindings.Clear()
    '    DgvListeConcessionnaires.Columns.Clear()
    '    DataTableConcess()
    '    DataBindConss()
    'End Sub

    'Private Sub PRBPersCon_CheckedChanged(sender As Object, e As EventArgs) Handles PRBPersCon.CheckedChanged
    '    DataBindClear()
    '    DgvListeConcessionnaires.DataBindings.Clear()
    '    DgvListeConcessionnaires.Columns.Clear()
    '    DataTablePersContact()
    '    DataBindPersContact()
    'End Sub

    'Private Sub PRBBenef_CheckedChanged(sender As Object, e As EventArgs) Handles PRBBenef.CheckedChanged
    '    DataBindClear()
    '    DgvListeConcessionnaires.DataBindings.Clear()
    '    DgvListeConcessionnaires.Columns.Clear()
    '    DataTableBeneficiaire()
    '    DataBindBenef()
    'End Sub

    'Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

    '    If TabControl1.SelectedIndex.ToString = 0 Then
    '        If flagdefunt = 0 Then
    '            DataBindClearBeneficiaire()
    '            DgvListeDefunts.DataBindings.Clear()
    '            DgvListeDefunts.Columns.Clear()
    '            DataTableDefunt()
    '            DataBindDefunt()
    '            flagdefunt = 1
    '        End If

    '    ElseIf TabControl1.SelectedIndex.ToString = 1 Then
    '        If flagconssession = 0 Then
    '            FCDGConss.DataBindings.Clear()
    '            FCDGConss.Columns.Clear()
    '            FCDGDefunt.Columns.Clear()
    '            FCDGDefunt.DataBindings.Clear()
    '            FCDGBeneficiaire.DataBindings.Clear()
    '            FCDGBeneficiaire.Columns.Clear()
    '            DataTableConcession()
    '            flagconssession = 1
    '        End If

    '    ElseIf TabControl1.SelectedIndex.ToString = 2 Then
    '        If flagacteur = 0 Then
    '            DataBindClear()
    '            DgvListeConcessionnaires.DataBindings.Clear()
    '            DgvListeConcessionnaires.Columns.Clear()
    '            DataTableBeneficiaire()
    '            DataBindBenef()
    '            flagacteur = 1
    '        End If
    '    End If
    'End Sub

    'Private Sub FCDGConss_SelectionChanged(sender As Object, e As EventArgs) Handles FCDGConss.SelectionChanged

    '    DataBindClearConcessions()
    '    FCDGBeneficiaire.DataBindings.Clear()
    '    FCDGBeneficiaire.Columns.Clear()
    '    FCDGDefunt.DataBindings.Clear()
    '    FCDGDefunt.Columns.Clear()
    '    DataTableDefuntCons()
    '    DataTableConsBeneficiaire()
    '    DataBindConsDefunt()
    '    FCTBPlaceOccupe.Text = FCDGDefunt.RowCount - 1
    '    FCTBPlaceLibre.Text = dtcons.Rows(FCDGConss.CurrentRow.Index())("empl_nb_places") - (FCDGDefunt.RowCount - 1)
    '    Try
    '        TBconsBenefcodepostal.Text = GetValeurSql("SELECT * FROM t_loc_ville where locville_id = " & dtbenef.Rows(FCDGBeneficiaire.CurrentRow.Index())("locville_id") & "", "locville_cp")
    '        TBconsBenefville.Text = GetValeurSql("SELECT * FROM t_loc_ville where locville_id = " & dtbenef.Rows(FCDGBeneficiaire.CurrentRow.Index())("locville_id") & "", "locville_ville")
    '        TBconsBenefpays.Text = GetValeurSql("Select * From t_loc_ville INNER Join t_pays On t_loc_ville.locville_id = t_pays.Pays_id Where locville_id = " & dtbenef.Rows(FCDGBeneficiaire.CurrentRow.Index())("locville_id") & "", "Pays_nom")

    '    Catch ex As Exception
    '        MessageBox.Show("merde")
    '    End Try

    'End Sub

    'Private Sub FCDGBeneficiaire_SelectionChanged(sender As Object, e As EventArgs) Handles FCDGBeneficiaire.SelectionChanged
    '    DataBindClearConcessionsBeneficiaire()
    '    DataBindConsbenef()
    'End Sub

    'Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    '    Dim Source As New BindingSource()
    '    Source.DataSource = Me.FCDGConss.DataSource
    '    Source.Filter = "empl_reference Like '%" & FCTBRechercher.Text & "%'"
    'End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    Dim Source As New BindingSource()
    '    Source.DataSource = Me.FCDGConss.DataSource

    '    Source.Filter = "empl_reference like '%'"
    'End Sub






    ' Affiche les infos d'un défunt quand celui-ci est sélectionné dans la liste
    ' '   MsgBox("Num site : " & dtcons.Rows(FCDGConss.CurrentRow.Index())("empl_id"))




    Private Sub ChargerDefunts(ctx As CimEntities)
        ListeDefunts = New SortableBindingList(Of Defunt)(ctx.Defunts.Include("LocVille.Pays").ToList)
        DgvListeDefunts.DataSource = ListeDefunts
    End Sub

    Private Sub ChargerBenefs(ctx As CimEntities)
        ListeBeneficiaires = New SortableBindingList(Of Beneficiaire)(ctx.Beneficiaires.Include("LocVille.Pays").ToList)
        'DgvListeBeneficiaires.DataSource = ListeBeneficiaires
    End Sub

    Private Sub ChargerCsnrs(ctx As CimEntities)
        ListeConcessionnaires = New SortableBindingList(Of Concessionnaire)(ctx.Concessionnaires.Include("LocVille.Pays").ToList)
        'DgvListeConcessionnaires.DataSource = ListeConcessionnaires
    End Sub

    Private Sub ChargerPersContact(ctx As CimEntities)
        ListePersonnesContact = New SortableBindingList(Of PersonneContact)(ctx.PersonnesContact.Include("LocVille.Pays").ToList)
        'DgvListePersContact.datasource = ListePersonnesContact
    End Sub

    Private Sub ChargerEmplacements(ctx As CimEntities)
        ListeEmplacements = New SortableBindingList(Of Emplacement)(ctx.Emplacements.Include("Concessions").Include("Defunts").Include("Histoire"))
        ' DgvListeEmplacements.datasource = ListeEmplacements
    End Sub

    Private Sub BtDefAnnulerRecherche_Click(sender As Object, e As EventArgs) Handles BtDefAnnulerRecherche.Click
        TbDefChampRecherche.Text = ""
        DtpDefRechercherDateDecesApres.Checked = False
        DtpDefRechercherDateDecesAvant.Checked = False
        ListeDefunts.UpdateFilter()
    End Sub

    Private Sub TbDefChampRecherche_KeyDown(sender As Object, e As KeyEventArgs) Handles TbDefChampRecherche.KeyDown
        If e.KeyCode = Keys.Enter Then BtDefChercher_Click(BtDefChercher, Nothing)
    End Sub

End Class
