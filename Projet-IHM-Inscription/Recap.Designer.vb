<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recap
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButAban = New System.Windows.Forms.Button()
        Me.ButEnreg = New System.Windows.Forms.Button()
        Me.ButRet = New System.Windows.Forms.Button()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.labAge = New System.Windows.Forms.Label()
        Me.txtVille = New System.Windows.Forms.TextBox()
        Me.labVille = New System.Windows.Forms.Label()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.labCP = New System.Windows.Forms.Label()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.LabAdresse = New System.Windows.Forms.Label()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.labPrenom = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.LabNom = New System.Windows.Forms.Label()
        Me.labRegion = New System.Windows.Forms.Label()
        Me.labEpEcrit = New System.Windows.Forms.Label()
        Me.labEpOral = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFac = New System.Windows.Forms.TextBox()
        Me.txtReg = New System.Windows.Forms.TextBox()
        Me.lboxEpEcrit = New System.Windows.Forms.ListBox()
        Me.lboxEpOral = New System.Windows.Forms.ListBox()
        Me.Titre = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButAban
        '
        Me.ButAban.BackColor = System.Drawing.Color.MistyRose
        Me.ButAban.Location = New System.Drawing.Point(16, 330)
        Me.ButAban.Name = "ButAban"
        Me.ButAban.Size = New System.Drawing.Size(85, 37)
        Me.ButAban.TabIndex = 29
        Me.ButAban.Text = "Abandon"
        Me.ButAban.UseVisualStyleBackColor = False
        '
        'ButEnreg
        '
        Me.ButEnreg.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ButEnreg.Location = New System.Drawing.Point(561, 330)
        Me.ButEnreg.Name = "ButEnreg"
        Me.ButEnreg.Size = New System.Drawing.Size(85, 37)
        Me.ButEnreg.TabIndex = 30
        Me.ButEnreg.Text = "Enregistrer"
        Me.ButEnreg.UseVisualStyleBackColor = False
        '
        'ButRet
        '
        Me.ButRet.BackColor = System.Drawing.Color.Snow
        Me.ButRet.Location = New System.Drawing.Point(453, 330)
        Me.ButRet.Name = "ButRet"
        Me.ButRet.Size = New System.Drawing.Size(85, 37)
        Me.ButRet.TabIndex = 31
        Me.ButRet.Text = "Retour"
        Me.ButRet.UseVisualStyleBackColor = False
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(16, 269)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(37, 20)
        Me.txtAge.TabIndex = 43
        '
        'labAge
        '
        Me.labAge.AutoSize = True
        Me.labAge.Location = New System.Drawing.Point(16, 237)
        Me.labAge.Name = "labAge"
        Me.labAge.Size = New System.Drawing.Size(26, 13)
        Me.labAge.TabIndex = 42
        Me.labAge.Text = "Âge"
        '
        'txtVille
        '
        Me.txtVille.Location = New System.Drawing.Point(161, 197)
        Me.txtVille.MaxLength = 15
        Me.txtVille.Name = "txtVille"
        Me.txtVille.Size = New System.Drawing.Size(121, 20)
        Me.txtVille.TabIndex = 41
        '
        'labVille
        '
        Me.labVille.AutoSize = True
        Me.labVille.Location = New System.Drawing.Point(158, 167)
        Me.labVille.Name = "labVille"
        Me.labVille.Size = New System.Drawing.Size(26, 13)
        Me.labVille.TabIndex = 40
        Me.labVille.Text = "Ville"
        '
        'txtCP
        '
        Me.txtCP.Location = New System.Drawing.Point(16, 197)
        Me.txtCP.MaxLength = 5
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(68, 20)
        Me.txtCP.TabIndex = 39
        '
        'labCP
        '
        Me.labCP.AutoSize = True
        Me.labCP.Location = New System.Drawing.Point(14, 167)
        Me.labCP.Name = "labCP"
        Me.labCP.Size = New System.Drawing.Size(63, 13)
        Me.labCP.TabIndex = 38
        Me.labCP.Text = "Code postal"
        '
        'txtAdresse
        '
        Me.txtAdresse.Location = New System.Drawing.Point(92, 269)
        Me.txtAdresse.MaxLength = 30
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(190, 20)
        Me.txtAdresse.TabIndex = 37
        '
        'LabAdresse
        '
        Me.LabAdresse.AutoSize = True
        Me.LabAdresse.Location = New System.Drawing.Point(89, 240)
        Me.LabAdresse.Name = "LabAdresse"
        Me.LabAdresse.Size = New System.Drawing.Size(45, 13)
        Me.LabAdresse.TabIndex = 36
        Me.LabAdresse.Text = "Adresse"
        '
        'txtPrenom
        '
        Me.txtPrenom.Location = New System.Drawing.Point(161, 116)
        Me.txtPrenom.MaxLength = 20
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(121, 20)
        Me.txtPrenom.TabIndex = 35
        '
        'labPrenom
        '
        Me.labPrenom.AutoSize = True
        Me.labPrenom.Location = New System.Drawing.Point(158, 84)
        Me.labPrenom.Name = "labPrenom"
        Me.labPrenom.Size = New System.Drawing.Size(43, 13)
        Me.labPrenom.TabIndex = 34
        Me.labPrenom.Text = "Prénom"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(16, 116)
        Me.txtNom.MaxLength = 15
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(121, 20)
        Me.txtNom.TabIndex = 33
        '
        'LabNom
        '
        Me.LabNom.AutoSize = True
        Me.LabNom.Location = New System.Drawing.Point(13, 84)
        Me.LabNom.Name = "LabNom"
        Me.LabNom.Size = New System.Drawing.Size(29, 13)
        Me.LabNom.TabIndex = 32
        Me.LabNom.Text = "Nom"
        '
        'labRegion
        '
        Me.labRegion.AutoSize = True
        Me.labRegion.Location = New System.Drawing.Point(338, 87)
        Me.labRegion.Name = "labRegion"
        Me.labRegion.Size = New System.Drawing.Size(41, 13)
        Me.labRegion.TabIndex = 45
        Me.labRegion.Text = "Région"
        '
        'labEpEcrit
        '
        Me.labEpEcrit.AutoSize = True
        Me.labEpEcrit.Location = New System.Drawing.Point(338, 167)
        Me.labEpEcrit.Name = "labEpEcrit"
        Me.labEpEcrit.Size = New System.Drawing.Size(86, 13)
        Me.labEpEcrit.TabIndex = 46
        Me.labEpEcrit.Text = "Épreuves écrites"
        '
        'labEpOral
        '
        Me.labEpOral.AutoSize = True
        Me.labEpOral.Location = New System.Drawing.Point(520, 167)
        Me.labEpOral.Name = "labEpOral"
        Me.labEpOral.Size = New System.Drawing.Size(83, 13)
        Me.labEpOral.TabIndex = 47
        Me.labEpOral.Text = "Épreuves orales"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(517, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Épreuve orale facultative"
        '
        'txtFac
        '
        Me.txtFac.Location = New System.Drawing.Point(520, 115)
        Me.txtFac.MaxLength = 15
        Me.txtFac.Name = "txtFac"
        Me.txtFac.Size = New System.Drawing.Size(126, 20)
        Me.txtFac.TabIndex = 51
        '
        'txtReg
        '
        Me.txtReg.Location = New System.Drawing.Point(341, 115)
        Me.txtReg.MaxLength = 15
        Me.txtReg.Name = "txtReg"
        Me.txtReg.Size = New System.Drawing.Size(137, 20)
        Me.txtReg.TabIndex = 52
        '
        'lboxEpEcrit
        '
        Me.lboxEpEcrit.Enabled = False
        Me.lboxEpEcrit.FormattingEnabled = True
        Me.lboxEpEcrit.Location = New System.Drawing.Point(339, 197)
        Me.lboxEpEcrit.Name = "lboxEpEcrit"
        Me.lboxEpEcrit.Size = New System.Drawing.Size(139, 95)
        Me.lboxEpEcrit.TabIndex = 53
        '
        'lboxEpOral
        '
        Me.lboxEpOral.Enabled = False
        Me.lboxEpOral.FormattingEnabled = True
        Me.lboxEpOral.Location = New System.Drawing.Point(523, 197)
        Me.lboxEpOral.Name = "lboxEpOral"
        Me.lboxEpOral.Size = New System.Drawing.Size(123, 95)
        Me.lboxEpOral.TabIndex = 54
        '
        'Titre
        '
        Me.Titre.AutoSize = True
        Me.Titre.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titre.Location = New System.Drawing.Point(211, 9)
        Me.Titre.Name = "Titre"
        Me.Titre.Size = New System.Drawing.Size(182, 43)
        Me.Titre.TabIndex = 55
        Me.Titre.Text = "Récapitulatif"
        '
        'Recap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 379)
        Me.Controls.Add(Me.Titre)
        Me.Controls.Add(Me.lboxEpOral)
        Me.Controls.Add(Me.lboxEpEcrit)
        Me.Controls.Add(Me.txtReg)
        Me.Controls.Add(Me.txtFac)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.labEpOral)
        Me.Controls.Add(Me.labEpEcrit)
        Me.Controls.Add(Me.labRegion)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.labAge)
        Me.Controls.Add(Me.txtVille)
        Me.Controls.Add(Me.labVille)
        Me.Controls.Add(Me.txtCP)
        Me.Controls.Add(Me.labCP)
        Me.Controls.Add(Me.txtAdresse)
        Me.Controls.Add(Me.LabAdresse)
        Me.Controls.Add(Me.txtPrenom)
        Me.Controls.Add(Me.labPrenom)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.LabNom)
        Me.Controls.Add(Me.ButRet)
        Me.Controls.Add(Me.ButEnreg)
        Me.Controls.Add(Me.ButAban)
        Me.Name = "Recap"
        Me.Text = "Récapitulatif"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButAban As Button
    Friend WithEvents ButEnreg As Button
    Friend WithEvents ButRet As Button
    Friend WithEvents txtAge As TextBox
    Friend WithEvents labAge As Label
    Friend WithEvents txtVille As TextBox
    Friend WithEvents labVille As Label
    Friend WithEvents txtCP As TextBox
    Friend WithEvents labCP As Label
    Friend WithEvents txtAdresse As TextBox
    Friend WithEvents LabAdresse As Label
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents labPrenom As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents LabNom As Label
    Friend WithEvents labRegion As Label
    Friend WithEvents labEpEcrit As Label
    Friend WithEvents labEpOral As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFac As TextBox
    Friend WithEvents txtReg As TextBox
    Friend WithEvents lboxEpEcrit As ListBox
    Friend WithEvents lboxEpOral As ListBox
    Friend WithEvents Titre As Label
End Class
