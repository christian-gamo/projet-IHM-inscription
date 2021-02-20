Public Class InfosCandidat
    'âge minimum proposé
    Private Const MIN_AGE As Integer = 18
    'âge maximum proposé
    Private Const MAX_AGE As Integer = 55
    'Taille maximale d'un code postal
    Private Const TAILLE_CP As Integer = 5
    'Délai de chaque tick de l'horloge
    Private Const DELAI As Integer = 1000
    'Initialise le compte à rebours 
    Private chrono As Integer = 60

    '@brief : Au démarrage de ce formulaire, on met à jour les éléments,
    '         on paramètre et on lance le timer
    Private Sub InfosCandidat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SBAge.Minimum = MIN_AGE
        SBAge.Maximum = MAX_AGE
        SBAge.SmallChange = 1
        SBAge.LargeChange = 1
        txtAge.Enabled = False
        Timer1Min.Interval = DELAI
        Timer1Min.Start()
    End Sub
    '@brief : Met à jour le compte à rebours et l'heure actuelle
    '         Si le compte à rebours atteint 0, retourne à l'accueil
    Private Sub Timer() Handles Timer1Min.Tick
        Dim str As String = chrono
        Me.Text = TimeString + " Temps restant : " + str + " seconde(s)"
        If chrono = 0 Then
            Timer1Min.Stop()
            MsgBox("Vous avez dépassé la limite de temps.")
            Me.Close()
            Accueil.Visible = True
        End If
        chrono -= 1
    End Sub
    '@brief : Empêche l'entrée de caractères non alphabétiques pour le nom, le prénom, et la ville 
    Private Sub TxtAlpha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNom.KeyPress, txtPrenom.KeyPress, txtVille.KeyPress
        If e.KeyChar = vbBack Or e.KeyChar = " " Then
            Exit Sub
        End If
        e.Handled = Not Char.IsLetter(e.KeyChar) ' on écrit que des lettres de l'alphabet
    End Sub
    '@brief : Empêche l'entrée de caractères alphabétiques pour le code postal
    Private Sub TxtCP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCP.KeyPress
        If e.KeyChar = vbBack Then
            Exit Sub
        End If
        If Not (e.KeyChar >= "0" AndAlso e.KeyChar <= "9") Then
            e.Handled = True 'On écrit que les caractères numériques
        End If

    End Sub
    '@brief : Empêche l'entrée de caractères non alphanumériques pour l'adresse
    Private Sub TxtAdresse_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAdresse.KeyPress
        If e.KeyChar = vbBack Or e.KeyChar = " " Then
            Exit Sub
        End If
        e.Handled = Not Char.IsLetterOrDigit(e.KeyChar) ' alphanumérique
    End Sub
    '@brief : Rend la saisie de l'utilisateur avec une bonne casse
    Private Sub TxtAlpha_lostFocus(sender As Object, e As EventArgs) Handles txtNom.LostFocus, txtPrenom.LostFocus, txtVille.LostFocus
        sender.Text = StrConv(sender.Text, vbProperCase)
    End Sub
    '@brief : Met à jour l'âge du candidat à chaque nouvelle valeur
    Private Sub SBAge_Scroll(sender As Object, e As ScrollEventArgs) Handles SBAge.Scroll
        txtAge.Text = SBAge.Value
    End Sub
    '@brief : Ferme le formulaire et retourne à l'accueil
    Private Sub ButAban_Click(sender As Object, e As EventArgs) Handles ButAban.Click
        Me.Close()
        Accueil.Visible = True
    End Sub
    '@brief : Accède à la deuxième partie de l'inscription si tout est rempli correctement
    Private Sub ButSuite_Click(sender As Object, e As EventArgs) Handles ButSuite.Click
        If String.IsNullOrEmpty(txtNom.Text) Then
            LabNom.ForeColor = Color.Red
        Else
            LabNom.ForeColor = Color.Black
        End If
        If String.IsNullOrEmpty(txtPrenom.Text) Then
            labPrenom.ForeColor = Color.Red
        Else
            labPrenom.ForeColor = Color.Black
        End If
        If String.IsNullOrEmpty(txtVille.Text) Then
            labVille.ForeColor = Color.Red
        Else
            labVille.ForeColor = Color.Black
        End If
        If String.IsNullOrEmpty(txtAge.Text) Then
            labAge.ForeColor = Color.Red
        Else
            labAge.ForeColor = Color.Black
        End If

        If String.IsNullOrEmpty(txtCP.Text) Or txtCP.TextLength <> TAILLE_CP Then
            labCP.ForeColor = Color.Red
        ElseIf txtCP.TextLength = TAILLE_CP Then
            If (txtCP.Text.Substring(0, 2) = "00") Then
                labCP.ForeColor = Color.Red
            Else
                labCP.ForeColor = Color.Black
            End If
        End If

        If LabNom.ForeColor = Color.Black And labPrenom.ForeColor = Color.Black And labVille.ForeColor = Color.Black And
            labAge.ForeColor = Color.Black And labCP.ForeColor = Color.Black Then
            Me.Visible = False
            ChoixEpreuves.Visible = True
            Timer1Min.Stop()
        End If

    End Sub

End Class