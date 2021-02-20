Public Class AffInscrip


    '@brief : Initialise le formulaire et ses ListBox par ordre alphabétique des noms
    Private Sub AffInscrip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tab As List(Of candidat) = getListeCandidats()
        tab = tab.OrderBy(Function(c) c.nom).ThenBy(Function(c) c.prenom).ToList
        For Each c As candidat In tab
            lboxNum.Items.Add(c.num)
            lboxNom.Items.Add(c.nom)
            lboxPrenom.Items.Add(c.prenom)
            Dim nomEcrit As String = ""
            For i As Integer = 0 To c.tabEpreuvesEcrit.Length - 1
                If c.tabEpreuvesEcrit(i) = "Langage C" Or c.tabEpreuvesEcrit(i) = "Langage Java" Then
                    Dim indexEspace = c.tabEpreuvesEcrit(i).IndexOf(" ")
                    nomEcrit += c.tabEpreuvesEcrit(i).Substring(0, 2) & c.tabEpreuvesEcrit(i).Substring(indexEspace + 1, 1) & " "
                Else
                    nomEcrit += c.tabEpreuvesEcrit(i).Substring(0, 3) & " "
                End If
            Next
            lboxEcrit.Items.Add(Strings.UCase(nomEcrit))
            Dim nomOral As String = ""
            For i As Integer = 0 To c.tabEpreuvesOral.Length - 1
                nomOral += c.tabEpreuvesOral(i).Substring(0, 3) & " "
            Next
            lboxOral.Items.Add(Strings.UCase(nomOral))
            Dim str As String = c.epFac
            If String.IsNullOrEmpty(c.epFac) Then
                str = ""
            End If
            lboxFac.Items.Add(str)
        Next

        SBInscrits.Maximum = tab.Count - 1

    End Sub
    '@brief : Synchronise la sélection d'un candidat pour les 6 ListBox
    Private Sub ListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lboxNum.SelectedIndexChanged, lboxNom.SelectedIndexChanged,
            lboxPrenom.SelectedIndexChanged, lboxEcrit.SelectedIndexChanged, lboxOral.SelectedIndexChanged, lboxFac.SelectedIndexChanged

        Dim index As Integer = sender.selectedIndex
        For Each ctrl As Control In Panel1.Controls
            If TypeOf ctrl Is ListBox Then
                DirectCast(ctrl, ListBox).SelectedIndex = index
                sender.topIndex = DirectCast(ctrl, ListBox).TopIndex
                SBInscrits.Value = DirectCast(ctrl, ListBox).TopIndex
            End If
        Next
    End Sub
    '@brief : Retourne à l'accueil
    Private Sub ButRet_Click(sender As Object, e As EventArgs) Handles ButRet.Click
        Me.Close()
        Accueil.Visible = True
    End Sub

    '@brief : Change l'index de toutes les ListBox lors du défilement de la barre verticale
    Private Sub SBInscrits_Scroll(sender As Object, e As ScrollEventArgs) Handles SBInscrits.Scroll
        For Each ctrl As Control In Panel1.Controls
            If TypeOf ctrl Is ListBox Then
                DirectCast(ctrl, ListBox).TopIndex = SBInscrits.Value
            End If
        Next
    End Sub

    Private Sub test(sender As Object, e As MouseEventArgs) Handles lboxNum.MouseWheel, lboxNom.MouseWheel,
            lboxPrenom.MouseWheel, lboxEcrit.MouseWheel, lboxOral.MouseWheel, lboxFac.MouseWheel
        Dim mouseEvent As HandledMouseEventArgs = DirectCast(e, HandledMouseEventArgs)
        mouseEvent.Handled = True
    End Sub
End Class