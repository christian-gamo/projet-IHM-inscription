Imports System.IO
Public Class Accueil
    '@brief : Supprime les bilans liés à la fin des inscriptions d'un ancien concours
    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not File.Exists("sauvegarde.bin") And Not File.Exists("nbCpt.bin") Then
            For Each fichierTxt In Directory.GetFiles(Directory.GetCurrentDirectory, "*.txt", SearchOption.TopDirectoryOnly)
                File.Delete(fichierTxt)
            Next
        End If
    End Sub
    '@brief : Sélectionne le menu Enregistrer, ouvre le formulaire pour inscrire un candidat
    Private Sub ButEnreg_Click(sender As Object, e As EventArgs) Handles ButEnreg.Click
        Me.Visible = False
        InfosCandidat.Visible = True
        Recap.SetEtat(Recap.EtatEnum.Enregistrer)
    End Sub
    '@brief : Ouvre le formulaire pour modifier/supprimer un candidat (s'il y en a)
    Private Sub ButtonModifSuppr_Click(sender As Object, e As EventArgs) Handles ButModifSuppr.Click
        Dim tab As List(Of candidat) = getListeCandidats()
        If tab.Count = 0 Then
            MsgBox("Vous ne pouvez pas accéder à ce menu s'il n'y a pas encore d'inscrits", vbOK)
        Else
            Me.Visible = False
            ModifSuppr.Visible = True
        End If
    End Sub
    '@brief : Ouvre le formulaire pour afficher la liste des inscrits (s'il y en a)
    Private Sub ButAffInscri_Click(sender As Object, e As EventArgs) Handles ButAffInscri.Click
        Dim tab As List(Of candidat) = getListeCandidats()
        If tab.Count = 0 Then
            MsgBox("Vous ne pouvez pas accéder à ce menu s'il n'y a pas encore d'inscrits", vbOK)
        Else
            Me.Visible = False
            AffInscrip.Visible = True
        End If
    End Sub
    '@brief : Ouvre le formulaire pour le bilan individuel ou par matière (s'il y a des candidats)
    Private Sub ButtonBilan_Click_1(sender As Object, e As EventArgs) Handles ButBilan.Click
        Dim tab As List(Of candidat) = getListeCandidats()
        If tab.Count = 0 Then
            MsgBox("Vous ne pouvez pas accéder à ce menu s'il n'y a pas encore d'inscrits", vbOK)
        Else
            Me.Visible = False
            Bilan.Visible = True
        End If
    End Sub
    '@brief : Quitter l'application sans avoir fini les inscriptions
    '         On crée une sauvegarde des candidats inscrits et du compteur d'inscrits
    Private Sub ButQuitter_Click(sender As Object, e As EventArgs) Handles ButQuitter.Click
        If Bilan.GetEstFinal Then
            Application.Exit()
        Else
            sauvegarder("sauvegarde.bin", "nbCpt.bin")
            Application.Exit()
        End If
    End Sub
End Class
