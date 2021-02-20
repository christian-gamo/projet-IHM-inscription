Public Class BilanMatiere
    '@brief : Initialise le formulaire (nom de la matière + les listbox)
    Private Sub BilanMatiere_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tab As List(Of Candidat) = GetListeCandidats()
        txtMatiere.Text = Bilan.cboxMatiere.SelectedItem
        tab = tab.OrderBy(Function(c) c.region).ThenBy(Function(c) c.nom).ThenBy(Function(c) c.prenom).ToList
        For Each c As Candidat In tab
            For i As Integer = 0 To c.tabEpreuvesEcrit.Length - 1
                If c.tabEpreuvesEcrit(i) = txtMatiere.Text Then
                    lboxRegEcrit.Items.Add(c.region)
                    lboxNomEcrit.Items.Add(c.nom)
                    lboxPrenomEcrit.Items.Add(c.prenom)
                End If
            Next
            For i As Integer = 0 To c.tabEpreuvesOral.Length - 1
                If c.tabEpreuvesOral(i) = txtMatiere.Text Then
                    lboxRegOral.Items.Add(c.region)
                    lboxNomOral.Items.Add(c.nom)
                    lboxPrenomOral.Items.Add(c.prenom)
                End If
            Next
            If c.epFac = txtMatiere.Text Then
                lboxRegOral.Items.Add(c.region)
                lboxNomOral.Items.Add(c.nom)
                lboxPrenomOral.Items.Add(c.prenom)
            End If
        Next

    End Sub
    '@brief : Retourne à l'accueil
    Private Sub ButRet_Click(sender As Object, e As EventArgs) Handles ButRet.Click
        Me.Close()
        Bilan.Visible = True
    End Sub
    '@brief : Synchronise la sélection d'un candidat pour les 3 ListBox Écrit
    Private Sub lboxEcrit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lboxRegEcrit.SelectedIndexChanged,
        lboxPrenomEcrit.SelectedIndexChanged, lboxNomEcrit.SelectedIndexChanged
        Dim index As Integer = sender.selectedIndex
        lboxRegEcrit.SelectedIndex = index
        lboxPrenomEcrit.SelectedIndex = index
        lboxNomEcrit.SelectedIndex = index
    End Sub
    '@brief : Synchronise la sélection d'un candidat pour les 3 ListBox Oral
    Private Sub lboxOral_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lboxRegOral.SelectedIndexChanged,
    lboxPrenomOral.SelectedIndexChanged, lboxNomOral.SelectedIndexChanged
        Dim index As Integer = sender.selectedIndex
        lboxRegOral.SelectedIndex = index
        lboxPrenomOral.SelectedIndex = index
        lboxNomOral.SelectedIndex = index
    End Sub

End Class