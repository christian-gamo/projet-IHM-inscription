Imports System.IO

Public Class Bilan
    'Indique si les inscriptions sont terminées
    Private estFinal As Boolean
    'Tableau des noms de matières écrites 
    Private ReadOnly nomsMatiere() As String = {"Algorithmique", "Base de données", "Droit", "Expression", "Gestion", "Langage C",
        "Langage Java", "Mathématiques", "Programmation web", "Réseau", "Système", "Visual Basic .NET", "Anglais", "Chinois",
        "Espagnol"}
    'Tableau des noms de matières orales
    Private ReadOnly nomRegion() As String = {"Auvergne", "Bordelais", "Bourgogne", "Bretagne", "Corse", "Nord",
        "Normandie", "Paris", "Poitou", "Roussillon"}
    '@brief : Getter pour l'attribut estFinal
    Public Function GetEstFinal()
        Return estFinal
    End Function

    '@brief : Initialise le formulaire (estFinal + les deux combobox)
    Private Sub Bilan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim vbVal As Integer
        vbVal = MsgBox("Avez-vous terminé d'enregistrer les inscriptions ?", vbYesNo, "Bilan provisoire ou final")
        If vbVal = vbYes Then
            estFinal = True
        Else
            estFinal = False
        End If
        If estFinal Then
            ButRet.Text = "Quitter"
        Else
            ButRet.Text = "Retour"
        End If

        RadIndiv.Checked = True
        cboxIndiv.Visible = True
        cboxMatiere.Visible = False
        ButMatiere.Visible = False

        Dim tab As List(Of candidat) = getListeCandidats()
        txtNbInscrits.Text = tab.Count

        For i As Integer = 0 To tab.Count - 1
            cboxIndiv.Items.Add(Strings.UCase(tab(i).nom) & " " & tab(i).prenom)
        Next
        cboxIndiv.DropDownStyle = ComboBoxStyle.DropDown
        cboxIndiv.AutoCompleteMode = AutoCompleteMode.Suggest
        cboxIndiv.AutoCompleteSource = AutoCompleteSource.ListItems

        For i = 0 To nomsMatiere.Length - 1
            cboxMatiere.Items.Add(nomsMatiere(i))
        Next

    End Sub
    '@brief : Contrôle la visibilité de cboxIndiv et ButIndiv
    Private Sub RadIndiv_CheckedChanged(sender As Object, e As EventArgs) Handles RadIndiv.CheckedChanged
        cboxIndiv.Visible = RadIndiv.Checked
        ButIndiv.Visible = RadIndiv.Checked
    End Sub
    '@brief : Contrôle la visibilité de cboxMatiere et ButMatiere
    Private Sub RadMatiere_CheckedChanged(sender As Object, e As EventArgs) Handles RadMatiere.CheckedChanged
        cboxMatiere.Visible = RadMatiere.Checked
        ButMatiere.Visible = RadMatiere.Checked
    End Sub
    '@brief : Si les inscriptions sont terminées, créé les fichiers bilans en fonction de la matière et de la région
    '         Sinon, retour à l'accueil
    Private Sub ButRet_Click(sender As Object, e As EventArgs) Handles ButRet.Click
        If estFinal Then
            Dim tab As List(Of candidat) = getListeCandidats()
            tab = tab.OrderBy(Function(c) c.region).ThenBy(Function(c) c.nom).ThenBy(Function(c) c.prenom).ToList
            Dim fichier As StreamWriter
            Dim aDesCandidatsOral As Boolean = False

            'Pour chaque matière et pour chaque région, crée un fichier texte s'il y a des candidats inscrits  
            For Each str As String In nomsMatiere
                For Each r As String In nomRegion
                    For Each c As candidat In tab
                        If c.region = r Then
                            'Ajoute les candidats pour l'épreuve à l'écrit
                            For i As Integer = 0 To c.tabEpreuvesEcrit.Length - 1
                                If c.tabEpreuvesEcrit(i) = str Then
                                    If Not File.Exists(Strings.UCase(r) & "-" & Strings.UCase(str) & ".txt") Then
                                        fichier = New StreamWriter(Strings.UCase(r) & "-" & Strings.UCase(str) & ".txt")
                                        fichier.WriteLine("Liste des candidats de la région " & r & " pour la matière " & str & " à l'écrit")
                                    End If
                                    fichier.WriteLine(c.nom & " " & c.prenom & " " & c.num)
                                End If
                            Next
                        End If
                    Next
                    For Each c As Candidat In tab
                        If c.region = r Then
                            'Ajoute les candidats pour l'épreuve à l'oral
                            For i As Integer = 0 To c.tabEpreuvesOral.Length - 1
                                If c.tabEpreuvesOral(i) = str Then
                                    If Not File.Exists(Strings.UCase(r) & "-" & Strings.UCase(str) & ".txt") Then
                                        fichier = New StreamWriter(Strings.UCase(r) & "-" & Strings.UCase(str) & ".txt")
                                        fichier.WriteLine("Liste des candidats de la région " & r & " pour la matière " & str & " à l'oral")
                                        aDesCandidatsOral = True
                                    ElseIf Not aDesCandidatsOral Then
                                        fichier.WriteLine("Liste des candidats de la région " & r & " pour la matière " & str & " à l'oral")
                                        aDesCandidatsOral = True
                                    End If
                                    fichier.WriteLine(c.nom & " " & c.prenom & " " & c.num)
                                End If
                            Next
                            'Ajoute les candidats pour l'épreuve en facultatif
                            If c.epFac = str Then
                                If Not File.Exists(Strings.UCase(r) & "-" & Strings.UCase(str) & ".txt") Then
                                    fichier = New StreamWriter(Strings.UCase(r) & "-" & Strings.UCase(str) & ".txt")
                                    fichier.WriteLine("Liste des candidats de la région " & r & " pour la matière " & str & " à l'oral")
                                    aDesCandidatsOral = True
                                ElseIf Not aDesCandidatsOral Then
                                    fichier.WriteLine("Liste des candidats de la région " & r & " pour la matière " & str & " à l'oral")
                                    aDesCandidatsOral = True
                                End If
                                fichier.WriteLine(c.nom & " " & c.prenom & " " & c.num)
                            End If
                        End If
                    Next
                    fichier.Close()
                    aDesCandidatsOral = False
                Next
            Next
            'Supprime les sauvegardes des candidats s'il y en a 
            If File.Exists("sauvegarde.bin") And File.Exists("nbCpt.bin") Then
                File.Delete("sauvegarde.bin")
                File.Delete("nbCpt.bin")
            End If
            Application.Exit()
        Else
            Me.Close()
            Accueil.Show()
        End If
    End Sub
    '@brief : Initialise le formulaire Recap pour le bilan d'un candidat
    Private Sub ButIndiv_Click(sender As Object, e As EventArgs) Handles ButIndiv.Click
        Dim liste As List(Of candidat) = getListeCandidats()
        Dim index As Integer
        Dim nom As String
        Dim prenom As String
        Dim item As String

        If cboxIndiv.SelectedIndex <> -1 Then
            item = cboxIndiv.SelectedItem.ToString()
            nom = item.Substring(0, item.IndexOf(" "))
            prenom = item.Substring(item.IndexOf(" ") + 1)

            For i As Integer = 0 To liste.Count - 1
                If liste(i).nom = nom And liste(i).prenom = prenom Then
                    index = i
                End If
            Next

            InfosCandidat.txtNom.Text = liste(index).nom
            InfosCandidat.txtPrenom.Text = liste(index).prenom
            InfosCandidat.txtAdresse.Text = liste(index).ad
            InfosCandidat.txtVille.Text = liste(index).ville
            InfosCandidat.txtCP.Text = liste(index).cp
            InfosCandidat.txtAge.Text = liste(index).age
            Recap.SetEtat(Recap.EtatEnum.Individuel)

            Recap.Show()
            Recap.txtReg.Text = liste(index).region
            Recap.txtFac.Text = liste(index).epFac
            For i As Integer = 0 To liste(index).tabEpreuvesEcrit.Length - 1
                Recap.lboxEpEcrit.Items.Add(liste(index).tabEpreuvesEcrit(i))
            Next
            For i As Integer = 0 To liste(index).tabEpreuvesOral.Length - 1
                Recap.lboxEpOral.Items.Add(liste(index).tabEpreuvesOral(i))
            Next
            Me.Visible = False
        Else
            cboxIndiv.BackColor = Color.LightGray
        End If
    End Sub
    '@brief : Accède au bilan des matières si une matière est sélectionnée
    Private Sub ButMatiere_Click(sender As Object, e As EventArgs) Handles ButMatiere.Click
        If cboxMatiere.SelectedItem <> "" Then
            BilanMatiere.Show()
            Me.Visible = False
        Else
            cboxMatiere.BackColor = Color.LightGray
        End If
    End Sub

    '@brief : Re-colore le fond en blanc pour signaler qu'un candidat a bien été choisi par l'utilisateur
    Private Sub cbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxIndiv.SelectedIndexChanged,
        cboxMatiere.SelectedIndexChanged
        sender.BackColor = Color.White
    End Sub
End Class