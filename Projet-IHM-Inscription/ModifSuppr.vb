Public Class ModifSuppr
    'Indice à laquelle se trouve le candidat dans la liste
    Private Shared index As Integer
    '@brief : Getter, retourne l'index
    Public Function getIndex()
        Return index
    End Function
    '@brief : Initialise le formulaire (boutons + combobox des noms de candidat)
    Private Sub ModifSuppr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadNum.Checked = True
        txtNum.Visible = True
        cboxId.Visible = False

        Dim tab As List(Of candidat)
        tab = getListeCandidats()
        For i As Integer = 0 To tab.Count - 1
            cboxId.Items.Add(tab(i).num & " " & Strings.UCase(tab(i).nom) & " " & tab(i).prenom)
        Next
    End Sub
    '@brief : Contrôle la visiblité de txtNum
    Private Sub RadNum_CheckedChanged(sender As Object, e As EventArgs) Handles RadNum.CheckedChanged
        txtNum.Visible = RadNum.Checked
    End Sub
    '@brief : Contrôle la visiblité de cboxId
    Private Sub RadId_CheckedChanged(sender As Object, e As EventArgs) Handles RadId.CheckedChanged
        cboxId.Visible = RadId.Checked
    End Sub

    '@brief : Re-colore le fond en blanc pour signaler qu'un candidat a bien été indiqué par l'utilisateur
    Private Sub RadCboxTextChanged(sender As Object, e As EventArgs) Handles txtNum.TextChanged,
        cboxId.SelectedIndexChanged
        sender.backColor = Color.White
    End Sub
    '@brief : Empêche l'entrée des caractères alphabétiques pour le numéro
    Private Sub TxtNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNum.KeyPress
        If e.KeyChar = vbBack Then
            Exit Sub
        End If
        If Not (e.KeyChar >= "0" AndAlso e.KeyChar <= "9") Then
            e.Handled = True 'On écrit que les caractères numériques
        End If
    End Sub
    '@brief : Initialise le formulaire Recap pour une suppression d'un candidat
    Private Sub ButSuppr_Click(sender As Object, e As EventArgs) Handles ButSuppr.Click
        InitForm(Recap.EtatEnum.Supprimer)
    End Sub
    '@brief : Initialise le formulaire Recap pour une modification des données d'un candidat
    Private Sub ButModif_Click(sender As Object, e As EventArgs) Handles ButModif.Click
        InitForm(Recap.EtatEnum.Modifier)
    End Sub
    '@brief : Initialise le formulaire Recap
    Private Sub InitForm(etat As Recap.EtatEnum)
        Dim num As Integer = 0
        Dim liste As List(Of candidat) = getListeCandidats()
        'Vérifie qu'un numéro ou un candidat a été sélectionné
        If RadNum.Checked And Not String.IsNullOrEmpty(txtNum.Text) Then
            For i As Integer = 0 To liste.Count - 1
                If txtNum.Text = liste(i).num Then
                    num = txtNum.Text
                End If
            Next
            If num = 0 Then
                txtNum.BackColor = Color.LightGray
            End If

        ElseIf RadId.Checked And cboxId.SelectedIndex <> -1 Then
            Dim indice As Integer
            indice = InStr(cboxId.SelectedItem, " ")
            num = cboxId.SelectedItem.Substring(0, indice)
        ElseIf RadNum.Checked Then
            txtNum.BackColor = Color.LightGray
        Else
            cboxId.BackColor = Color.LightGray
        End If


        If num <> 0 Then
            For i As Integer = 0 To liste.Count - 1
                If liste(i).num = num Then
                    index = i
                End If
            Next

            'Initialise les données du formulaire InfosCandidat
            InfosCandidat.txtNom.Text = liste(index).nom
            InfosCandidat.txtPrenom.Text = liste(index).prenom
            InfosCandidat.txtAdresse.Text = liste(index).ad
            InfosCandidat.txtVille.Text = liste(index).ville
            InfosCandidat.txtCP.Text = liste(index).cp
            InfosCandidat.txtAge.Text = liste(index).age

            Recap.SetEtat(etat)
            If etat = Recap.EtatEnum.Modifier Then
                ChoixEpreuves.Show()
                ChoixEpreuves.SetEstInscription(False)
                Dim idxReg As Integer
                idxReg = ChoixEpreuves.cboxReg.Items.IndexOf(liste(index).region)
                ChoixEpreuves.cboxReg.SelectedIndex = idxReg

                For Each tabEcrit As String In liste(index).tabEpreuvesEcrit
                    For Each check As CheckBox In ChoixEpreuves.gboxEcrit.Controls
                        If check.Text = tabEcrit Then
                            check.Checked = True
                        End If
                    Next
                Next
                For Each tabOral As String In liste(index).tabEpreuvesOral
                    For Each check As CheckBox In ChoixEpreuves.gboxOral.Controls
                        If check.Text = tabOral Then
                            check.Checked = True
                        End If
                    Next
                Next
                If liste(index).epFac <> "" Then
                    ChoixEpreuves.RadButOui.Checked = True
                    Dim idxFac As Integer
                    idxFac = ChoixEpreuves.cboxFac.Items.IndexOf(liste(index).epFac)
                    ChoixEpreuves.cboxFac.SelectedIndex = idxFac
                End If

            ElseIf etat = Recap.EtatEnum.Supprimer Then
                Recap.Show()
                Recap.txtReg.Text = liste(index).region
                Recap.txtFac.Text = liste(index).epFac

                For i As Integer = 0 To liste(index).tabEpreuvesEcrit.Length - 1
                    Recap.lboxEpEcrit.Items.Add(liste(index).tabEpreuvesEcrit(i))
                Next
                For i As Integer = 0 To liste(index).tabEpreuvesOral.Length - 1
                    Recap.lboxEpOral.Items.Add(liste(index).tabEpreuvesOral(i))
                Next

            End If
            Me.Close()
        End If
    End Sub
    '@brief : Retourne à l'accueil
    Private Sub ButRet_Click(sender As Object, e As EventArgs) Handles ButRet.Click
        Me.Close()
        Accueil.Show()
    End Sub
End Class