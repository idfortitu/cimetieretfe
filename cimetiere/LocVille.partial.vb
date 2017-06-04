Partial Public Class LocVille

    Public ReadOnly Property NomEtCp As String
        Get
            Return Ville & If(Cp.HasValue, " (" & Cp & ")", "")
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return NomEtCp
    End Function

End Class
