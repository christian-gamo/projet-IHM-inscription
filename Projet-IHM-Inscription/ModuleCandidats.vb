Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

Module ModuleCandidats
    Private listeCandidats As List(Of candidat)
    Private cptInscrit As Integer = 0

    <Serializable()>
    Public Structure candidat
        Dim num As Integer
        Dim nom As String
        Dim prenom As String
        Dim ad As String
        Dim ville As String
        Dim cp As Integer
        Dim age As Integer
        Dim region As String
        Dim tabEpreuvesEcrit() As String
        Dim tabEpreuvesOral() As String
        Dim epFac As String
    End Structure
    'Getter pour la listeCandidats
    Public Function getListeCandidats()
        Dim copie As List(Of candidat)
        copie = listeCandidats
        Return copie
    End Function
    Public Function getCpt()
        Return cptInscrit
    End Function

    '@brief : Initialise la liste des candidats et lance l'application
    Sub Main()
        listeCandidats = New List(Of candidat)
        Dim nom As String = "sauvegarde.bin"
        Dim nomCpt As String = "nbCpt.bin"
        Charger(nom, nomCpt)
        Application.Run(Accueil)
    End Sub
    '@brief : Ajoute un candidat à la liste des inscrits
    Public Sub Ajouter(ByRef candid As candidat)
        candid.num = cptInscrit + 1
        listeCandidats.Add(candid)
        MsgBox("Le numéro qui vous a été attribué est le numéro : " & candid.num, vbOK, "Attribution du numéro candidat")
        cptInscrit += 1
    End Sub
    '@brief : Modifie les informations d'un candidat
    Public Sub Modifier(ByRef candid As candidat, ByRef index As Integer)
        candid.num = listeCandidats(index).num
        listeCandidats(index) = candid
    End Sub
    '@brief : Supprime un candidat de la liste des inscrits
    Public Sub Supprimer(ByRef index As Integer)
        listeCandidats.RemoveAt(index)
    End Sub
    '@brief : Créé une sauvegarde de la liste des candidats et du compteur de candidats
    Public Sub Sauvegarder(nomListe As String, nomCpt As String)
        Dim sauvegardeListe As FileStream = File.Create(nomListe)
        Dim sauvegardeCpt As FileStream = File.Create(nomCpt)
        Dim SerialiseurListe As New BinaryFormatter
        Dim SerialiseurCpt As New BinaryFormatter

        SerialiseurListe.Serialize(sauvegardeListe, listeCandidats)
        SerialiseurCpt.Serialize(sauvegardeCpt, cptInscrit)
        sauvegardeListe.Close()
        sauvegardeCpt.Close()
    End Sub
    '@brief: Récupère la sauvegarde de la liste et du compteur
    Public Sub Charger(nomListe As String, nomCpt As String)
        If File.Exists(nomListe) And File.Exists(nomCpt) Then

            Dim FluxListe As Stream = File.OpenRead(nomListe)
            Dim DeserialiseurListe As New BinaryFormatter()
            Dim FluxCpt As Stream = File.OpenRead(nomCpt)
            Dim DeserialiseurCpt As New BinaryFormatter()

            listeCandidats = CType(DeserialiseurListe.Deserialize(FluxListe), List(Of candidat))
            cptInscrit = CType(DeserialiseurCpt.Deserialize(FluxCpt), Integer)

            FluxListe.Close()
            FluxCpt.Close()
        End If
    End Sub


End Module
