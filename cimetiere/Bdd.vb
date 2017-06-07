Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports MySql.Data.Types
Imports System
Imports System.Net
Imports System.IO
Imports System.Text
Imports cimetiere.EntitesTableAdapters
Imports cimetiere.Entites

Module Bdd
    Private Const ConnStr As String = "Server=" & ConfigLocale.BddHost & ";User Id=" & ConfigLocale.BddUser & "; Password=" & ConfigLocale.BddPass & "; Database=" & ConfigLocale.BddNom & "; Pooling=false"
    Private Connexion As New MySqlConnection With {.ConnectionString = ConnStr}

    Public Function GetDataTable(sql As String) As DataTable
        Dim Req As New MySqlCommand With {
            .Connection = Connexion,
            .CommandText = sql,
            .CommandType = CommandType.Text}
        Dim Adapt As New MySqlDataAdapter With {.SelectCommand = Req}
        Dim dset As New DataSet
        Adapt.Fill(dset)
        Return dset.Tables(0)
    End Function


    Public Function GetTable_t_loc_ville(NomTable As String) As DataTable
        'Return GetDataTable("SELECT * FROM " & NomTable)
        'Dim a = New TestsetTableAdapters.t_loc_villeTableAdapter
        Dim b = New t_loc_villeTableAdapter
        Dim dset As New t_loc_villeDataTable
        b.Fill(dset)
        Return dset
    End Function



End Module
