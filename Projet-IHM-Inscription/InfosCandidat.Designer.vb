<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfosCandidat
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
        Me.components = New System.ComponentModel.Container()
        Me.LabNom = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.labPrenom = New System.Windows.Forms.Label()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.LabAdresse = New System.Windows.Forms.Label()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.labCP = New System.Windows.Forms.Label()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.labVille = New System.Windows.Forms.Label()
        Me.txtVille = New System.Windows.Forms.TextBox()
        Me.labAge = New System.Windows.Forms.Label()
        Me.SBAge = New System.Windows.Forms.HScrollBar()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.labAgeMin = New System.Windows.Forms.Label()
        Me.labAgeMax = New System.Windows.Forms.Label()
        Me.ButSuite = New System.Windows.Forms.Button()
        Me.ButAban = New System.Windows.Forms.Button()
        Me.Timer1Min = New System.Windows.Forms.Timer(Me.components)
        Me.Titre = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabNom
        '
        Me.LabNom.AutoSize = True
        Me.LabNom.Location = New System.Drawing.Point(158, 77)
        Me.LabNom.Name = "LabNom"
        Me.LabNom.Size = New System.Drawing.Size(36, 13)
        Me.LabNom.TabIndex = 0
        Me.LabNom.Text = "Nom *"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(161, 109)
        Me.txtNom.MaxLength = 15
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(121, 20)
        Me.txtNom.TabIndex = 1
        '
        'labPrenom
        '
        Me.labPrenom.AutoSize = True
        Me.labPrenom.Location = New System.Drawing.Point(303, 77)
        Me.labPrenom.Name = "labPrenom"
        Me.labPrenom.Size = New System.Drawing.Size(50, 13)
        Me.labPrenom.TabIndex = 2
        Me.labPrenom.Text = "Prénom *"
        '
        'txtPrenom
        '
        Me.txtPrenom.Location = New System.Drawing.Point(306, 109)
        Me.txtPrenom.MaxLength = 20
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(121, 20)
        Me.txtPrenom.TabIndex = 3
        '
        'LabAdresse
        '
        Me.LabAdresse.AutoSize = True
        Me.LabAdresse.Location = New System.Drawing.Point(158, 155)
        Me.LabAdresse.Name = "LabAdresse"
        Me.LabAdresse.Size = New System.Drawing.Size(45, 13)
        Me.LabAdresse.TabIndex = 4
        Me.LabAdresse.Text = "Adresse"
        '
        'txtAdresse
        '
        Me.txtAdresse.Location = New System.Drawing.Point(161, 184)
        Me.txtAdresse.MaxLength = 30
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(190, 20)
        Me.txtAdresse.TabIndex = 5
        '
        'labCP
        '
        Me.labCP.AutoSize = True
        Me.labCP.Location = New System.Drawing.Point(159, 233)
        Me.labCP.Name = "labCP"
        Me.labCP.Size = New System.Drawing.Size(70, 13)
        Me.labCP.TabIndex = 6
        Me.labCP.Text = "Code postal *"
        '
        'txtCP
        '
        Me.txtCP.Location = New System.Drawing.Point(161, 263)
        Me.txtCP.MaxLength = 5
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(68, 20)
        Me.txtCP.TabIndex = 7
        '
        'labVille
        '
        Me.labVille.AutoSize = True
        Me.labVille.Location = New System.Drawing.Point(303, 233)
        Me.labVille.Name = "labVille"
        Me.labVille.Size = New System.Drawing.Size(33, 13)
        Me.labVille.TabIndex = 8
        Me.labVille.Text = "Ville *"
        '
        'txtVille
        '
        Me.txtVille.Location = New System.Drawing.Point(306, 263)
        Me.txtVille.MaxLength = 15
        Me.txtVille.Name = "txtVille"
        Me.txtVille.Size = New System.Drawing.Size(121, 20)
        Me.txtVille.TabIndex = 9
        '
        'labAge
        '
        Me.labAge.AutoSize = True
        Me.labAge.Location = New System.Drawing.Point(161, 303)
        Me.labAge.Name = "labAge"
        Me.labAge.Size = New System.Drawing.Size(33, 13)
        Me.labAge.TabIndex = 10
        Me.labAge.Text = "Âge *"
        '
        'SBAge
        '
        Me.SBAge.Location = New System.Drawing.Point(91, 371)
        Me.SBAge.Name = "SBAge"
        Me.SBAge.Size = New System.Drawing.Size(416, 19)
        Me.SBAge.TabIndex = 11
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(161, 335)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(37, 20)
        Me.txtAge.TabIndex = 12
        '
        'labAgeMin
        '
        Me.labAgeMin.AutoSize = True
        Me.labAgeMin.Location = New System.Drawing.Point(88, 347)
        Me.labAgeMin.Name = "labAgeMin"
        Me.labAgeMin.Size = New System.Drawing.Size(39, 13)
        Me.labAgeMin.TabIndex = 13
        Me.labAgeMin.Text = "18 ans"
        '
        'labAgeMax
        '
        Me.labAgeMax.AutoSize = True
        Me.labAgeMax.Location = New System.Drawing.Point(468, 347)
        Me.labAgeMax.Name = "labAgeMax"
        Me.labAgeMax.Size = New System.Drawing.Size(39, 13)
        Me.labAgeMax.TabIndex = 14
        Me.labAgeMax.Text = "55 ans"
        '
        'ButSuite
        '
        Me.ButSuite.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ButSuite.Location = New System.Drawing.Point(479, 423)
        Me.ButSuite.Name = "ButSuite"
        Me.ButSuite.Size = New System.Drawing.Size(85, 37)
        Me.ButSuite.TabIndex = 15
        Me.ButSuite.Text = "Suite"
        Me.ButSuite.UseVisualStyleBackColor = False
        '
        'ButAban
        '
        Me.ButAban.BackColor = System.Drawing.Color.Snow
        Me.ButAban.Location = New System.Drawing.Point(388, 423)
        Me.ButAban.Name = "ButAban"
        Me.ButAban.Size = New System.Drawing.Size(85, 37)
        Me.ButAban.TabIndex = 16
        Me.ButAban.Text = "Abandon"
        Me.ButAban.UseVisualStyleBackColor = False
        '
        'Timer1Min
        '
        '
        'Titre
        '
        Me.Titre.AutoSize = True
        Me.Titre.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titre.Location = New System.Drawing.Point(182, 6)
        Me.Titre.Name = "Titre"
        Me.Titre.Size = New System.Drawing.Size(213, 43)
        Me.Titre.TabIndex = 17
        Me.Titre.Text = "Renseignements"
        '
        'InfosCandidat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 470)
        Me.Controls.Add(Me.Titre)
        Me.Controls.Add(Me.ButAban)
        Me.Controls.Add(Me.ButSuite)
        Me.Controls.Add(Me.labAgeMax)
        Me.Controls.Add(Me.labAgeMin)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.SBAge)
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
        Me.Name = "InfosCandidat"
        Me.Text = "Informations sur le candidat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabNom As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents labPrenom As Label
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents LabAdresse As Label
    Friend WithEvents txtAdresse As TextBox
    Friend WithEvents labCP As Label
    Friend WithEvents txtCP As TextBox
    Friend WithEvents labVille As Label
    Friend WithEvents txtVille As TextBox
    Friend WithEvents labAge As Label
    Friend WithEvents SBAge As HScrollBar
    Friend WithEvents txtAge As TextBox
    Friend WithEvents labAgeMin As Label
    Friend WithEvents labAgeMax As Label
    Friend WithEvents ButSuite As Button
    Friend WithEvents ButAban As Button
    Friend WithEvents Timer1Min As Timer
    Friend WithEvents Titre As Label
End Class
