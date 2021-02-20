Public Class ChoixEpreuves
    'Nombre d'épreuves écrites obligatoire
    Private Const NB_OBLI_ECRIT As Integer = 4
    'Nombre d'épreuves orales obligatoire
    Private Const NB_OBLI_ORAL As Integer = 3
    'Temps de départ du compte à rebours
    Private Const TMP_CHRONO As Integer = 90
    'Délai entre chaque tick de l'horloge
    Private Const DELAI As Integer = 1000
    'Nombre d'épreuves écrites coché
    Private nbCocheEcrit As Integer = 0
    'Nombre d'épreuves orales coché
    Private nbCocheOral As Integer = 0
    'Initialise le compte à rebours
    Private chrono As Integer = TMP_CHRONO
    'État du formulaire, inscription ou modification
    Private estInscription As Boolean
    'Tableau des noms de région proposés
    Private ReadOnly nomRegion() As String = {"Auvergne", "Bordelais", "Bourgogne", "Bretagne", "Corse", "Nord",
        "Normandie", "Paris", "Poitou", "Roussillon"}
    'Tableau des noms de matières écrites proposés
    Private ReadOnly nomEcrit() As String = {"Algorithmique", "Base de données", "Droit", "Expression", "Gestion", "Langage C",
        "Langage Java", "Mathématiques", "Programmation web", "Réseau", "Système", "Visual Basic .NET"}
    'Tableau des noms de matières orales proposés
    Private ReadOnly nomOral() As String = {"Droit", "Expression", "Gestion", "Mathématiques",
        "Réseau", "Système", "Anglais", "Chinois", "Espagnol"}

    '@brief : Setter de l'attribut estInscription
    Public Sub SetEstInscription(bool As Boolean)
        estInscription = bool
    End Sub
    '@brief : Initialise le formulaire (liste des régions, liste des matières et le timer)
    Private Sub ChoixEpreuves_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        estInscription = True
        LabNom.Text = InfosCandidat.txtNom.Text
        labPrenom.Text = InfosCandidat.txtPrenom.Text
        RadButNon.Checked = True 'On coche le radio bouton Non par défaut

        For Each str As String In nomRegion
            cboxReg.Items.Add(str)
        Next
        cboxReg.SelectedIndex = 0
        ' Permet de faire des suggestions si l'utilisateur saisi
        cboxReg.DropDownStyle = ComboBoxStyle.DropDown
        cboxReg.AutoCompleteMode = AutoCompleteMode.Suggest
        cboxReg.AutoCompleteSource = AutoCompleteSource.ListItems

        Dim i As Integer
        For i = 0 To gboxEcrit.Controls.Count - 1
            If TypeOf gboxEcrit.Controls(i) Is CheckBox Then
                gboxEcrit.Controls(i).Text = nomEcrit(i)
            End If
        Next
        labNbEcrit.Text = NB_OBLI_ECRIT

        For i = 0 To gboxOral.Controls.Count - 1
            If TypeOf gboxOral.Controls(i) Is CheckBox Then
                gboxOral.Controls(i).Text = nomOral(i)
            End If
        Next
        labNbOral.Text = NB_OBLI_ORAL

        Timer1Min30.Interval = DELAI
        Timer1Min30.Start()
    End Sub
    '@brief : Met à jour le compteur des épreuves écrites pour chaque checkbox cochée ou décochée
    Private Sub CheckEcrit_CheckedChanged(sender As Object, e As EventArgs) Handles checkAlgo.CheckedChanged, checkBD.CheckedChanged,
            checkDroit.CheckedChanged, checkExp.CheckedChanged, checkGest.CheckedChanged, checkC.CheckedChanged, checkJava.CheckedChanged,
            checkMaths.CheckedChanged, checkWeb.CheckedChanged, checkRes.CheckedChanged, checkSys.CheckedChanged, checkVB.CheckedChanged

        If sender.Checked Then
            nbCocheEcrit += 1
            If nbCocheEcrit > NB_OBLI_ECRIT Then
                Dim nbEcrit As String = NB_OBLI_ECRIT
                MsgBox("Impossible de sélectionner plus de " + nbEcrit + " épreuves à l'écrit", vbOK, "Limite de choix")
                sender.Checked = False
            End If
        Else nbCocheEcrit -= 1
        End If

        labNbEcrit.Text = NB_OBLI_ECRIT - nbCocheEcrit
        CheckIndispo(sender, gboxOral)

    End Sub
    '@brief : Met à jour le compteur des épreuves orales pour chaque checkbox cochée ou décochée
    Private Sub CheckOral_CheckedChanged(sender As Object, e As EventArgs) Handles checkOMaths.CheckedChanged,
        checkORes.CheckedChanged, checkOSys.CheckedChanged, checkOAng.CheckedChanged, checkOChi.CheckedChanged,
        checkOEsp.CheckedChanged, checkODroit.CheckedChanged, checkOExp.CheckedChanged, checkOGest.CheckedChanged

        If sender.Checked Then
            nbCocheOral += 1
            If nbCocheOral > NB_OBLI_ORAL Then
                Dim nbOral As String = NB_OBLI_ORAL
                MsgBox("Impossible de sélectionner plus de " + nbOral + " épreuves à l'oral", vbOK, "Limite de choix")
                sender.Checked = False
            End If
        Else nbCocheOral -= 1
        End If

        labNbOral.Text = NB_OBLI_ORAL - nbCocheOral
        CheckIndispo(sender, gboxEcrit)
    End Sub
    '@brief : Rend indisponible l'équivalent dans l'autre groupbox pour la matière sélectionnée
    '         (pour une matière qui se situe à la fois dans Écrit et dans Oral)
    Private Sub CheckIndispo(sender As Object, gbox As GroupBox)
        For Each str As String In nomOral
            For Each check As CheckBox In gbox.Controls
                If sender.Text = str And sender.Text = check.Text Then
                    check.Enabled = Not sender.Checked
                End If
            Next
        Next
    End Sub
    '@brief : Fait apparaître le choix d'une épreuve facultative
    Private Sub EpreuveFac() Handles labNbOral.TextChanged, labNbEcrit.TextChanged
        Dim condition As Boolean = labNbOral.Text = "0" AndAlso labNbEcrit.Text = "0"
        labQuest.Visible = condition
        RadButNon.Visible = condition
        RadButOui.Visible = condition
        cboxFac.Visible = False
    End Sub
    '@brief : Lorsque le bouton Oui (épreuve facultative) est cochée, on affiche la liste des matières
    '         pour laquelle le candidat peut passer l'épreuve
    Private Sub RadButOui_CheckedChanged(sender As Object, e As EventArgs) Handles RadButOui.CheckedChanged
        cboxFac.Visible = RadButOui.Checked
        gboxEcrit.Enabled = Not RadButOui.Checked
        gboxOral.Enabled = Not RadButOui.Checked
        If RadButOui.Checked Then
            InitCboxFac()
        Else
            cboxFac.Items.Clear()
        End If
    End Sub
    '@brief : Initialise la combobox qui prend toutes les matières possibles
    '         pour lesquels le candidat peut choisir de passer pour l'épreuve facultative
    Private Sub InitCboxFac()
        For Each check As CheckBox In gboxOral.Controls
            If Not check.Checked Then
                'Si le nom appartient à un nom dans écrit également
                If nomEcrit.Contains(check.Text) Then
                    For i As Integer = 0 To gboxEcrit.Controls.Count - 1
                        If TypeOf gboxEcrit.Controls(i) Is CheckBox Then
                            If gboxEcrit.Controls(i).Text = check.Text Then
                                Dim c As CheckBox = CType(gboxEcrit.Controls(i), CheckBox)
                                If Not c.Checked Then
                                    cboxFac.Items.Add(check.Text)
                                End If
                            End If
                        End If
                    Next
                Else 'Si le nom est simplement dans le groupebox Oral
                    cboxFac.Items.Add(check.Text)
                End If

            End If
        Next
        cboxFac.SelectedIndex = 0
    End Sub
    '@brief : Ferme les formulaires liées à l'inscription 
    '         Si nous sommes dans une modification on retourne au formulaire ModifSuppr 
    '         Sinon retour à l'accueil
    Private Sub FinChoixEpreuves()
        InfosCandidat.Close()
        Me.Close()
        If Not estInscription Then
            ModifSuppr.Show()
        Else
            Accueil.Visible = True
        End If
    End Sub
    '@brief : Lance la fin de l'inscription/modification 
    Private Sub ButAban_Click(sender As Object, e As EventArgs) Handles ButAban.Click
        FinChoixEpreuves()
    End Sub
    '@brief : Met à jour le compte à rebours et l'heure actuelle
    '         Si le compte à rebours atteint 0, lance la fin de l'inscription
    Private Sub Timer() Handles Timer1Min30.Tick
        Dim str As String = chrono
        Me.Text = TimeString + " Temps restant : " + str + " seconde(s)"
        If chrono = 0 Then
            Timer1Min30.Stop()
            MsgBox("Vous avez dépassé la limite de temps.",, "Limite de temps")
            FinChoixEpreuves()
        End If
        chrono -= 1
    End Sub
    '@brief : Permet d'accéder au récapitulatif s'il n'y a pas d'erreurs,
    '         sinon, affiche un message lié à l'erreur
    Private Sub ButEnreg_Click(sender As Object, e As EventArgs) Handles ButEnreg.Click
        If nbCocheEcrit <> NB_OBLI_ECRIT Or nbCocheOral <> NB_OBLI_ORAL Then
            MsgBox("Vous n'avez pas coché le nombre d'épreuves réglementaire.", vbOK, "Épreuves manquants")
        ElseIf cboxReg.SelectedIndex = -1 Then
            MsgBox("oops", vbOKOnly, "Attention !")
        Else
            If Not estInscription Then 'Si nous sommes dans une modifcation, l'état du formulaire Recap change
                Recap.SetEtat(Recap.EtatEnum.Modifier)
            End If
            Recap.Visible = True
            Me.Visible = False
            Timer1Min30.Stop() 'Le chrono ne tourne plus
            chrono = TMP_CHRONO ' On le réinitialise
        End If
    End Sub
End Class