Public Class FormLogin
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles BtOk.Click
        ' identification via bdd à faire
        'If TbNomUtilisateur.Text = "a" And TbMdp.Text = "a" Then
        If True Then
            DialogResult = DialogResult.OK
        Else
            MessageBox.Show("Mauvais nom d'utilisateur ou mot de passe.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f = New debug
        debug.ShowDialog()
    End Sub

    ' Private Sub Button1_Click(sender As Object, e As EventArgs)
    'Dim form As New debug
    '   debug.ShowDialog()
    'End Sub
End Class