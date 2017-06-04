Public Class FormProlong

    Private ListeConcessions As SortableBindingList(Of Concession)

    Private Sub FormProlong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgvConcessions.AutoGenerateColumns = False
        Using ctx As New CimEntities
            ChargerConcessions(ctx)
        End Using
    End Sub



    ' choix concession (aff liste)
    ' choix durée avec auto +30 et +15
    ' montant payé

    ' infos suppl :
    ' bénefs
    ' commentaire
    ' infos csnr
    ' infos défunt(s)

    Private Sub ChargerConcessions(ctx As CimEntities)
        ListeConcessions = New SortableBindingList(Of Concession)(ctx.Concessions.Include("Concessionnaire").Include("Emplacement.Defunts"))
        DgvConcessions.DataSource = ListeConcessions
    End Sub

    Private Sub osef(sender As Object, e As EventArgs)

    End Sub
End Class