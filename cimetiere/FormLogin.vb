Imports System.Security.Cryptography


Public Class FormLogin
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles BtOk.Click
        ' identification via bdd à faire
        'If TbNomUtilisateur.Text = "a" And TbMdp.Text = "a" Then
        Try
            Dim mMD5 As New MD5CryptoServiceProvider
            Dim UniEnc As New System.Text.UnicodeEncoding
            Dim bitPass() As Byte = UniEnc.GetBytes(TbMdp.Text)
            Dim pass As String = Convert.ToBase64String(mMD5.ComputeHash(bitPass)).ToString
            'MsgBox(pass)
            'MsgBox(TbNomUtilisateur.Text)
            Dim a = Bdd.Login(TbNomUtilisateur.Text, pass)
            DialogResult = DialogResult.OK
        Catch ex As Exception
            MsgBox("Le nom d'utilisateur ou le mot de passe est incorrecte.")
        End Try





    End Sub

    Sub osef() Handles Me.Load
        Dim u = Bdd.GetTable("t_loc_ville")
        Bdd.Insert("t_loc_ville", u.Rows(0))
    End Sub

    Private Sub BtQuitter_Click(sender As Object, e As EventArgs) Handles BtQuitter.Click
        Me.Close()
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