Public Class Recap
    'Les différents états de ce formulaire
    Enum EtatEnum
        Enregistrer
        Modifier
        Supprimer
        Individuel
    End Enum
    'État actuel du formulaire
    Private etat As EtatEnum = EtatEnum.Enregistrer

    '@brief : Setter pour modifier l'attribut etat
    Public Sub SetEtat(e As EtatEnum)
        etat = e
    End Sub

    '@brief : Initialise le formulaire (état + informations du candidat + choix des matières)
    Private Sub Recap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If etat = EtatEnum.Enregistrer Then
            Titre.Text = "Récapitulatif"
            ButEnreg.Text = "Inscrire"
            ButRet.Visible = True
        ElseIf etat = EtatEnum.Modifier Then
            Titre.Text = "Modification"
            ButEnreg.Text = "Modifier"
            ButRet.Visible = True
        ElseIf etat = EtatEnum.Supprimer Then
            Titre.Text = "Suppression"
            ButRet.Visible = False
            ButEnreg.Text = "Supprimer"
        Else
            Titre.Text = "Bilan individuel"
            ButRet.Visible = False
            ButAban.Visible = False
            ButEnreg.BackColor = Color.Snow
            ButEnreg.Text = "Retour"
        End If

        'Partie informations sur le candidat
        txtNom.Text = InfosCandidat.txtNom.Text
        txtPrenom.Text = InfosCandidat.txtPrenom.Text
        txtCP.Text = InfosCandidat.txtCP.Text
        txtVille.Text = InfosCandidat.txtVille.Text
        txtAge.Text = InfosCandidat.txtAge.Text
        If Not Trim(InfosCandidat.txtAdresse.Text) = "" Then
            txtAdresse.Text = InfosCandidat.txtAdresse.Text
        Else
            txtAdresse.Enabled = False
        End If
        'Partie sur les choix des matières des épreuves du candidat
        txtReg.Text = ChoixEpreuves.cboxReg.Text
        For Each check As CheckBox In ChoixEpreuves.gboxEcrit.Controls
            If check.Checked AndAlso lboxEpEcrit.Items.IndexOf(check) = -1 Then
                lboxEpEcrit.Items.Add(check.Text)
            End If
        Next
        For Each check As CheckBox In ChoixEpreuves.gboxOral.Controls
            If check.Checked AndAlso lboxEpOral.Items.IndexOf(check) = -1 Then
                lboxEpOral.Items.Add(check.Text)
            End If
        Next
        If ChoixEpreuves.RadButOui.Checked Then
            txtFac.Text = ChoixEpreuves.cboxFac.Text
        Else
            txtFac.Enabled = False
        End If
    End Sub
    '@brief : Ferme les formulaires liées à l'inscription
    '         Si nous somme dans un enregisrement on retourne à l'accueil
    '         Si nous sommes dans une modification/suppression retour au formulaire ModifSuppr
    Private Sub FinRecap()
        Me.Close()
        InfosCandidat.Close()
        ChoixEpreuves.Close()
        If etat = EtatEnum.Enregistrer Then
            Accueil.Visible = True
        ElseIf etat = EtatEnum.Modifier Or etat = EtatEnum.Supprimer Then
            ModifSuppr.Show()
        End If
    End Sub
    '@brief : Lance la fin de l'inscription/modification/suppression
    Private Sub ButAban_Click(sender As Object, e As EventArgs) Handles ButAban.Click
        FinRecap()
    End Sub
    '@brief : Retourne à la dernière partie de l'inscription
    Private Sub ButRet_Click(sender As Object, e As EventArgs) Handles ButRet.Click
        Me.Close()
        ChoixEpreuves.Visible = True
        ChoixEpreuves.Timer1Min30.Start() 'On relance le timer
    End Sub
    '@brief : En fonction de l'attribut etat :
    '         1) Enregistrer : ajoute un candidat à la liste des candidats
    '         2) Modifier : modifie les informations du candidat
    '         3) Supprimer : supprime le candidat de la liste
    '         4) Individuel : retourne au formulaire Bilan
    Private Sub ButEnreg_Click(sender As Object, e As EventArgs) Handles ButEnreg.Click
        Dim c As candidat
        'Initialisation du candidat
        c.nom = txtNom.Text
        c.prenom = txtPrenom.Text
        c.cp = txtCP.Text
        c.ville = txtVille.Text
        c.age = txtAge.Text
        c.region = txtReg.Text
        If txtAdresse.Enabled Then
            c.ad = txtAdresse.Text
        End If
        If txtFac.Enabled Then
            c.epFac = txtFac.Text
        End If
        ReDim c.tabEpreuvesEcrit(lboxEpEcrit.Items.Count - 1)
        For i As Integer = 0 To lboxEpEcrit.Items.Count - 1
            c.tabEpreuvesEcrit(i) = lboxEpEcrit.Items(i)
        Next
        ReDim c.tabEpreuvesOral(lboxEpOral.Items.Count - 1)
        For i As Integer = 0 To lboxEpOral.Items.Count - 1
            c.tabEpreuvesOral(i) = lboxEpOral.Items(i)
        Next

        If etat = EtatEnum.Enregistrer Then
            Ajouter(c)
        ElseIf etat = EtatEnum.Modifier Then
            Modifier(c, ModifSuppr.getIndex())
        ElseIf etat = EtatEnum.Supprimer Then
            Supprimer(ModifSuppr.getIndex)
        Else
            Bilan.Visible = True
        End If

        FinRecap()
    End Sub

    '@brief : Empêche la saisie sur ce formulaire récapitulatif
    Private Sub Txt_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNom.KeyPress, txtPrenom.KeyPress,
        txtAdresse.KeyPress, txtCP.KeyPress, txtVille.KeyPress, txtAge.KeyPress, txtReg.KeyPress, txtFac.KeyPress
        e.Handled = True
    End Sub
End Class