Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports MySql.Data.Types
Imports System
Imports System.Net
Imports System.IO
Imports System.Text
<<<<<<< HEAD
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


' Fonctions : - plus forcément à jour
' GetTable(table as String) As DataTable        ' ex : GetTable("demandeurs")
' GetTableWithId(table as String, NomPk As String, Id As Integer) As DataTable      ' ex : GetTableWithId("emplacements","empl_id",4)
' Function GetFormInhumation(id As Integer) As DemandeInhumation
' Function GetFormNvConcession(id As Integer) As DemandeNvConcession
' Function GetFormNvConBenefs(IdForm) As Beneficiaire()
' PutFormInhumation(LeForm As DemandeInhumation) As Integer      ' ajoute un nouveau form en bdd (table forms inhum + éventuellement form nv con & fnvcon bénéficiaires                                                                     renvoie l'id inséré
' Function PutFormNvCon(LeForm As DemandeNvConcession) As Integer


    Function Connexion(user As String, pass As String)
        conn.ConnectionString = "Server=" & BddHost & ";User Id=" & BddUser & "; Password=" & BddPass & "; Database=" & BddNom & "; Pooling=false"
        conn.Open()
        Dim myCommand As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim myData As MySqlDataReader
        Dim SQL As String
        Dim objConn As New MySql.Data.MySqlClient.MySqlConnection
        myCommand.Connection = conn

        ' La requête
        SQL = "select * from t_login where username = '" & user & "' AND password = '" & pass & "'"
        MsgBox(SQL)
        myCommand.CommandText = SQL
        myAdapter.SelectCommand = myCommand
        myData = myCommand.ExecuteReader()
        myData.Read()
        Dim str = myData.GetString(0)
        myData.Close()
        conn.Close()
        Return str
    End Function


    Function GetValeurSql(commande As String, colonne As String) As String
        conn.ConnectionString = "Server=" & BddHost & ";User Id=" & BddUser & "; Password=" & BddPass & "; Database=" & BddNom & "; Pooling=false"
        conn.Open()
        Dim myCommand As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim myData As MySqlDataReader
        Dim SQL As String
        Dim objConn As New MySql.Data.MySqlClient.MySqlConnection
        myCommand.Connection = conn
        ' La requête
        SQL = commande
        myCommand.CommandText = SQL
        myAdapter.SelectCommand = myCommand
        myData = myCommand.ExecuteReader()
        myData.Read()
        Dim str = myData.GetString(colonne)
        myData.Close()
        conn.Close()
        Return str

    End Function

    'Public Function InsertPers() As Boolean

    '    Dim conn As MySqlConnection = Connecter()
    '    Dim sqlCommand As New MySqlCommand
    '    Dim str_carSql As String

    '    Try
    '        str_carSql = "insert into personne (id, nom, prenom, naissance, mort, sepulture, enterement, expiration) values ('','heu','peutetre','25','34','65','98','20')"
    '        MsgBox(str_carSql)
    '        sqlCommand.Connection = conn
    '        sqlCommand.CommandText = str_carSql
    '        sqlCommand.ExecuteNonQuery()
    '        Return True

    '    Catch ex As Exception
    '        Return False
    '        MsgBox("Error occured: Could not insert record")
    '    End Try

    '    conn.Close()
    'End Function

