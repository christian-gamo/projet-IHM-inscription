<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChoixEpreuves
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
        Me.labPrenom = New System.Windows.Forms.Label()
        Me.cboxReg = New System.Windows.Forms.ComboBox()
        Me.labRegion = New System.Windows.Forms.Label()
        Me.gboxEcrit = New System.Windows.Forms.GroupBox()
        Me.checkAlgo = New System.Windows.Forms.CheckBox()
        Me.checkBD = New System.Windows.Forms.CheckBox()
        Me.checkDroit = New System.Windows.Forms.CheckBox()
        Me.checkExp = New System.Windows.Forms.CheckBox()
        Me.checkGest = New System.Windows.Forms.CheckBox()
        Me.checkC = New System.Windows.Forms.CheckBox()
        Me.checkJava = New System.Windows.Forms.CheckBox()
        Me.checkMaths = New System.Windows.Forms.CheckBox()
        Me.checkWeb = New System.Windows.Forms.CheckBox()
        Me.checkRes = New System.Windows.Forms.CheckBox()
        Me.checkSys = New System.Windows.Forms.CheckBox()
        Me.checkVB = New System.Windows.Forms.CheckBox()
        Me.gboxOral = New System.Windows.Forms.GroupBox()
        Me.checkODroit = New System.Windows.Forms.CheckBox()
        Me.checkOExp = New System.Windows.Forms.CheckBox()
        Me.checkOGest = New System.Windows.Forms.CheckBox()
        Me.checkOMaths = New System.Windows.Forms.CheckBox()
        Me.checkORes = New System.Windows.Forms.CheckBox()
        Me.checkOSys = New System.Windows.Forms.CheckBox()
        Me.checkOAng = New System.Windows.Forms.CheckBox()
        Me.checkOChi = New System.Windows.Forms.CheckBox()
        Me.checkOEsp = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.labNbEcrit = New System.Windows.Forms.Label()
        Me.labNbOral = New System.Windows.Forms.Label()
        Me.RadButNon = New System.Windows.Forms.RadioButton()
        Me.RadButOui = New System.Windows.Forms.RadioButton()
        Me.Timer1Min30 = New System.Windows.Forms.Timer(Me.components)
        Me.cboxFac = New System.Windows.Forms.ComboBox()
        Me.ButEnreg = New System.Windows.Forms.Button()
        Me.ButAban = New System.Windows.Forms.Button()
        Me.labQuest = New System.Windows.Forms.Label()
        Me.Titre = New System.Windows.Forms.Label()
        Me.gboxEcrit.SuspendLayout()
        Me.gboxOral.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabNom
        '
        Me.LabNom.AutoSize = True
        Me.LabNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabNom.Location = New System.Drawing.Point(24, 142)
        Me.LabNom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabNom.Name = "LabNom"
        Me.LabNom.Size = New System.Drawing.Size(44, 20)
        Me.LabNom.TabIndex = 1
        Me.LabNom.Text = "Nom"
        '
        'labPrenom
        '
        Me.labPrenom.AutoSize = True
        Me.labPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.labPrenom.Location = New System.Drawing.Point(24, 180)
        Me.labPrenom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labPrenom.Name = "labPrenom"
        Me.labPrenom.Size = New System.Drawing.Size(67, 20)
        Me.labPrenom.TabIndex = 3
        Me.labPrenom.Text = "Prénom"
        '
        'cboxReg
        '
        Me.cboxReg.FormattingEnabled = True
        Me.cboxReg.Location = New System.Drawing.Point(127, 101)
        Me.cboxReg.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboxReg.Name = "cboxReg"
        Me.cboxReg.Size = New System.Drawing.Size(181, 24)
        Me.cboxReg.TabIndex = 4
        '
        'labRegion
        '
        Me.labRegion.AutoSize = True
        Me.labRegion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.labRegion.Location = New System.Drawing.Point(24, 102)
        Me.labRegion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labRegion.Name = "labRegion"
        Me.labRegion.Size = New System.Drawing.Size(61, 20)
        Me.labRegion.TabIndex = 5
        Me.labRegion.Text = "Région"
        '
        'gboxEcrit
        '
        Me.gboxEcrit.Controls.Add(Me.checkAlgo)
        Me.gboxEcrit.Controls.Add(Me.checkBD)
        Me.gboxEcrit.Controls.Add(Me.checkDroit)
        Me.gboxEcrit.Controls.Add(Me.checkExp)
        Me.gboxEcrit.Controls.Add(Me.checkGest)
        Me.gboxEcrit.Controls.Add(Me.checkC)
        Me.gboxEcrit.Controls.Add(Me.checkJava)
        Me.gboxEcrit.Controls.Add(Me.checkMaths)
        Me.gboxEcrit.Controls.Add(Me.checkWeb)
        Me.gboxEcrit.Controls.Add(Me.checkRes)
        Me.gboxEcrit.Controls.Add(Me.checkSys)
        Me.gboxEcrit.Controls.Add(Me.checkVB)
        Me.gboxEcrit.Location = New System.Drawing.Point(16, 240)
        Me.gboxEcrit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gboxEcrit.Name = "gboxEcrit"
        Me.gboxEcrit.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gboxEcrit.Size = New System.Drawing.Size(344, 217)
        Me.gboxEcrit.TabIndex = 6
        Me.gboxEcrit.TabStop = False
        Me.gboxEcrit.Text = "Écrit"
        '
        'checkAlgo
        '
        Me.checkAlgo.AutoSize = True
        Me.checkAlgo.Location = New System.Drawing.Point(8, 30)
        Me.checkAlgo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkAlgo.Name = "checkAlgo"
        Me.checkAlgo.Size = New System.Drawing.Size(116, 21)
        Me.checkAlgo.TabIndex = 18
        Me.checkAlgo.Text = "Algorithmique"
        Me.checkAlgo.UseVisualStyleBackColor = True
        '
        'checkBD
        '
        Me.checkBD.AutoSize = True
        Me.checkBD.Location = New System.Drawing.Point(8, 58)
        Me.checkBD.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkBD.Name = "checkBD"
        Me.checkBD.Size = New System.Drawing.Size(141, 21)
        Me.checkBD.TabIndex = 17
        Me.checkBD.Text = "Base de données"
        Me.checkBD.UseVisualStyleBackColor = True
        '
        'checkDroit
        '
        Me.checkDroit.AutoSize = True
        Me.checkDroit.Location = New System.Drawing.Point(8, 86)
        Me.checkDroit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkDroit.Name = "checkDroit"
        Me.checkDroit.Size = New System.Drawing.Size(60, 21)
        Me.checkDroit.TabIndex = 16
        Me.checkDroit.Text = "Droit"
        Me.checkDroit.UseVisualStyleBackColor = True
        '
        'checkExp
        '
        Me.checkExp.AutoSize = True
        Me.checkExp.Location = New System.Drawing.Point(8, 114)
        Me.checkExp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkExp.Name = "checkExp"
        Me.checkExp.Size = New System.Drawing.Size(99, 21)
        Me.checkExp.TabIndex = 15
        Me.checkExp.Text = "Expression"
        Me.checkExp.UseVisualStyleBackColor = True
        '
        'checkGest
        '
        Me.checkGest.AutoSize = True
        Me.checkGest.Location = New System.Drawing.Point(8, 143)
        Me.checkGest.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkGest.Name = "checkGest"
        Me.checkGest.Size = New System.Drawing.Size(79, 21)
        Me.checkGest.TabIndex = 14
        Me.checkGest.Text = "Gestion"
        Me.checkGest.UseVisualStyleBackColor = True
        '
        'checkC
        '
        Me.checkC.AutoSize = True
        Me.checkC.Location = New System.Drawing.Point(8, 171)
        Me.checkC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkC.Name = "checkC"
        Me.checkC.Size = New System.Drawing.Size(99, 21)
        Me.checkC.TabIndex = 12
        Me.checkC.Text = "Langage C"
        Me.checkC.UseVisualStyleBackColor = True
        '
        'checkJava
        '
        Me.checkJava.AutoSize = True
        Me.checkJava.Location = New System.Drawing.Point(168, 30)
        Me.checkJava.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkJava.Name = "checkJava"
        Me.checkJava.Size = New System.Drawing.Size(120, 21)
        Me.checkJava.TabIndex = 11
        Me.checkJava.Text = "Langage Java"
        Me.checkJava.UseVisualStyleBackColor = True
        '
        'checkMaths
        '
        Me.checkMaths.AutoSize = True
        Me.checkMaths.Location = New System.Drawing.Point(168, 58)
        Me.checkMaths.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkMaths.Name = "checkMaths"
        Me.checkMaths.Size = New System.Drawing.Size(126, 21)
        Me.checkMaths.TabIndex = 10
        Me.checkMaths.Text = "Mathématiques"
        Me.checkMaths.UseVisualStyleBackColor = True
        '
        'checkWeb
        '
        Me.checkWeb.AutoSize = True
        Me.checkWeb.Location = New System.Drawing.Point(168, 86)
        Me.checkWeb.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkWeb.Name = "checkWeb"
        Me.checkWeb.Size = New System.Drawing.Size(155, 21)
        Me.checkWeb.TabIndex = 9
        Me.checkWeb.Text = "Programmation web"
        Me.checkWeb.UseVisualStyleBackColor = True
        '
        'checkRes
        '
        Me.checkRes.AutoSize = True
        Me.checkRes.Location = New System.Drawing.Point(168, 114)
        Me.checkRes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkRes.Name = "checkRes"
        Me.checkRes.Size = New System.Drawing.Size(79, 21)
        Me.checkRes.TabIndex = 8
        Me.checkRes.Text = "Réseau"
        Me.checkRes.UseVisualStyleBackColor = True
        '
        'checkSys
        '
        Me.checkSys.AutoSize = True
        Me.checkSys.Location = New System.Drawing.Point(168, 143)
        Me.checkSys.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkSys.Name = "checkSys"
        Me.checkSys.Size = New System.Drawing.Size(84, 21)
        Me.checkSys.TabIndex = 13
        Me.checkSys.Text = "Système"
        Me.checkSys.UseVisualStyleBackColor = True
        '
        'checkVB
        '
        Me.checkVB.AutoSize = True
        Me.checkVB.Location = New System.Drawing.Point(168, 171)
        Me.checkVB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkVB.Name = "checkVB"
        Me.checkVB.Size = New System.Drawing.Size(142, 21)
        Me.checkVB.TabIndex = 7
        Me.checkVB.Text = "Visual Basic .NET"
        Me.checkVB.UseVisualStyleBackColor = True
        '
        'gboxOral
        '
        Me.gboxOral.Controls.Add(Me.checkODroit)
        Me.gboxOral.Controls.Add(Me.checkOExp)
        Me.gboxOral.Controls.Add(Me.checkOGest)
        Me.gboxOral.Controls.Add(Me.checkOMaths)
        Me.gboxOral.Controls.Add(Me.checkORes)
        Me.gboxOral.Controls.Add(Me.checkOSys)
        Me.gboxOral.Controls.Add(Me.checkOAng)
        Me.gboxOral.Controls.Add(Me.checkOChi)
        Me.gboxOral.Controls.Add(Me.checkOEsp)
        Me.gboxOral.Location = New System.Drawing.Point(368, 240)
        Me.gboxOral.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gboxOral.Name = "gboxOral"
        Me.gboxOral.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gboxOral.Size = New System.Drawing.Size(260, 217)
        Me.gboxOral.TabIndex = 19
        Me.gboxOral.TabStop = False
        Me.gboxOral.Text = "Oral"
        '
        'checkODroit
        '
        Me.checkODroit.AutoSize = True
        Me.checkODroit.Location = New System.Drawing.Point(8, 30)
        Me.checkODroit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkODroit.Name = "checkODroit"
        Me.checkODroit.Size = New System.Drawing.Size(60, 21)
        Me.checkODroit.TabIndex = 31
        Me.checkODroit.Text = "Droit"
        Me.checkODroit.UseVisualStyleBackColor = True
        '
        'checkOExp
        '
        Me.checkOExp.AutoSize = True
        Me.checkOExp.Location = New System.Drawing.Point(8, 58)
        Me.checkOExp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkOExp.Name = "checkOExp"
        Me.checkOExp.Size = New System.Drawing.Size(99, 21)
        Me.checkOExp.TabIndex = 30
        Me.checkOExp.Text = "Expression"
        Me.checkOExp.UseVisualStyleBackColor = True
        '
        'checkOGest
        '
        Me.checkOGest.AutoSize = True
        Me.checkOGest.Location = New System.Drawing.Point(8, 86)
        Me.checkOGest.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkOGest.Name = "checkOGest"
        Me.checkOGest.Size = New System.Drawing.Size(79, 21)
        Me.checkOGest.TabIndex = 29
        Me.checkOGest.Text = "Gestion"
        Me.checkOGest.UseVisualStyleBackColor = True
        '
        'checkOMaths
        '
        Me.checkOMaths.AutoSize = True
        Me.checkOMaths.Location = New System.Drawing.Point(8, 114)
        Me.checkOMaths.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkOMaths.Name = "checkOMaths"
        Me.checkOMaths.Size = New System.Drawing.Size(126, 21)
        Me.checkOMaths.TabIndex = 17
        Me.checkOMaths.Text = "Mathématiques"
        Me.checkOMaths.UseVisualStyleBackColor = True
        '
        'checkORes
        '
        Me.checkORes.AutoSize = True
        Me.checkORes.Location = New System.Drawing.Point(8, 143)
        Me.checkORes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkORes.Name = "checkORes"
        Me.checkORes.Size = New System.Drawing.Size(79, 21)
        Me.checkORes.TabIndex = 16
        Me.checkORes.Text = "Réseau"
        Me.checkORes.UseVisualStyleBackColor = True
        '
        'checkOSys
        '
        Me.checkOSys.AutoSize = True
        Me.checkOSys.Location = New System.Drawing.Point(8, 171)
        Me.checkOSys.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkOSys.Name = "checkOSys"
        Me.checkOSys.Size = New System.Drawing.Size(84, 21)
        Me.checkOSys.TabIndex = 14
        Me.checkOSys.Text = "Système"
        Me.checkOSys.UseVisualStyleBackColor = True
        '
        'checkOAng
        '
        Me.checkOAng.AutoSize = True
        Me.checkOAng.Location = New System.Drawing.Point(141, 30)
        Me.checkOAng.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkOAng.Name = "checkOAng"
        Me.checkOAng.Size = New System.Drawing.Size(76, 21)
        Me.checkOAng.TabIndex = 11
        Me.checkOAng.Text = "Anglais"
        Me.checkOAng.UseVisualStyleBackColor = True
        '
        'checkOChi
        '
        Me.checkOChi.AutoSize = True
        Me.checkOChi.Location = New System.Drawing.Point(141, 58)
        Me.checkOChi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkOChi.Name = "checkOChi"
        Me.checkOChi.Size = New System.Drawing.Size(76, 21)
        Me.checkOChi.TabIndex = 10
        Me.checkOChi.Text = "Chinois"
        Me.checkOChi.UseVisualStyleBackColor = True
        '
        'checkOEsp
        '
        Me.checkOEsp.AutoSize = True
        Me.checkOEsp.Location = New System.Drawing.Point(141, 86)
        Me.checkOEsp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkOEsp.Name = "checkOEsp"
        Me.checkOEsp.Size = New System.Drawing.Size(89, 21)
        Me.checkOEsp.TabIndex = 9
        Me.checkOEsp.Text = "Espagnol"
        Me.checkOEsp.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(109, 475)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 17)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Nombre restant :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(412, 475)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Nombre restant :"
        '
        'labNbEcrit
        '
        Me.labNbEcrit.AutoSize = True
        Me.labNbEcrit.Location = New System.Drawing.Point(221, 475)
        Me.labNbEcrit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labNbEcrit.Name = "labNbEcrit"
        Me.labNbEcrit.Size = New System.Drawing.Size(16, 17)
        Me.labNbEcrit.TabIndex = 22
        Me.labNbEcrit.Text = "0"
        '
        'labNbOral
        '
        Me.labNbOral.AutoSize = True
        Me.labNbOral.Location = New System.Drawing.Point(528, 475)
        Me.labNbOral.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labNbOral.Name = "labNbOral"
        Me.labNbOral.Size = New System.Drawing.Size(16, 17)
        Me.labNbOral.TabIndex = 23
        Me.labNbOral.Text = "0"
        '
        'RadButNon
        '
        Me.RadButNon.AutoSize = True
        Me.RadButNon.Location = New System.Drawing.Point(641, 270)
        Me.RadButNon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadButNon.Name = "RadButNon"
        Me.RadButNon.Size = New System.Drawing.Size(55, 21)
        Me.RadButNon.TabIndex = 24
        Me.RadButNon.TabStop = True
        Me.RadButNon.Text = "Non"
        Me.RadButNon.UseVisualStyleBackColor = True
        Me.RadButNon.Visible = False
        '
        'RadButOui
        '
        Me.RadButOui.AutoSize = True
        Me.RadButOui.Location = New System.Drawing.Point(641, 299)
        Me.RadButOui.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadButOui.Name = "RadButOui"
        Me.RadButOui.Size = New System.Drawing.Size(51, 21)
        Me.RadButOui.TabIndex = 25
        Me.RadButOui.TabStop = True
        Me.RadButOui.Text = "Oui"
        Me.RadButOui.UseVisualStyleBackColor = True
        Me.RadButOui.Visible = False
        '
        'Timer1Min30
        '
        '
        'cboxFac
        '
        Me.cboxFac.FormattingEnabled = True
        Me.cboxFac.Location = New System.Drawing.Point(641, 327)
        Me.cboxFac.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboxFac.Name = "cboxFac"
        Me.cboxFac.Size = New System.Drawing.Size(160, 24)
        Me.cboxFac.TabIndex = 26
        Me.cboxFac.Visible = False
        '
        'ButEnreg
        '
        Me.ButEnreg.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ButEnreg.Location = New System.Drawing.Point(912, 500)
        Me.ButEnreg.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButEnreg.Name = "ButEnreg"
        Me.ButEnreg.Size = New System.Drawing.Size(113, 46)
        Me.ButEnreg.TabIndex = 27
        Me.ButEnreg.Text = "Enregistrer"
        Me.ButEnreg.UseVisualStyleBackColor = False
        '
        'ButAban
        '
        Me.ButAban.BackColor = System.Drawing.Color.Snow
        Me.ButAban.Location = New System.Drawing.Point(789, 500)
        Me.ButAban.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButAban.Name = "ButAban"
        Me.ButAban.Size = New System.Drawing.Size(113, 46)
        Me.ButAban.TabIndex = 28
        Me.ButAban.Text = "Abandon"
        Me.ButAban.UseVisualStyleBackColor = False
        '
        'labQuest
        '
        Me.labQuest.AutoSize = True
        Me.labQuest.Location = New System.Drawing.Point(637, 240)
        Me.labQuest.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labQuest.Name = "labQuest"
        Me.labQuest.Size = New System.Drawing.Size(391, 17)
        Me.labQuest.TabIndex = 29
        Me.labQuest.Text = "Souhaitez-vous participer à une épreuve facultative à l'oral ?"
        Me.labQuest.Visible = False
        '
        'Titre
        '
        Me.Titre.AutoSize = True
        Me.Titre.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titre.Location = New System.Drawing.Point(357, 11)
        Me.Titre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Titre.Name = "Titre"
        Me.Titre.Size = New System.Drawing.Size(310, 53)
        Me.Titre.TabIndex = 30
        Me.Titre.Text = "Choix des épreuves"
        '
        'ChoixEpreuves
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 560)
        Me.Controls.Add(Me.Titre)
        Me.Controls.Add(Me.labQuest)
        Me.Controls.Add(Me.ButAban)
        Me.Controls.Add(Me.ButEnreg)
        Me.Controls.Add(Me.cboxFac)
        Me.Controls.Add(Me.RadButOui)
        Me.Controls.Add(Me.RadButNon)
        Me.Controls.Add(Me.labNbOral)
        Me.Controls.Add(Me.labNbEcrit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gboxOral)
        Me.Controls.Add(Me.gboxEcrit)
        Me.Controls.Add(Me.labRegion)
        Me.Controls.Add(Me.cboxReg)
        Me.Controls.Add(Me.labPrenom)
        Me.Controls.Add(Me.LabNom)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ChoixEpreuves"
        Me.Text = "Choix des épreuves"
        Me.gboxEcrit.ResumeLayout(False)
        Me.gboxEcrit.PerformLayout()
        Me.gboxOral.ResumeLayout(False)
        Me.gboxOral.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabNom As Label
    Friend WithEvents labPrenom As Label
    Friend WithEvents cboxReg As ComboBox
    Friend WithEvents labRegion As Label
    Friend WithEvents gboxEcrit As GroupBox
    Friend WithEvents checkAlgo As CheckBox
    Friend WithEvents checkBD As CheckBox
    Friend WithEvents checkDroit As CheckBox
    Friend WithEvents checkExp As CheckBox
    Friend WithEvents checkGest As CheckBox
    Friend WithEvents checkSys As CheckBox
    Friend WithEvents checkC As CheckBox
    Friend WithEvents checkJava As CheckBox
    Friend WithEvents checkMaths As CheckBox
    Friend WithEvents checkWeb As CheckBox
    Friend WithEvents checkRes As CheckBox
    Friend WithEvents checkVB As CheckBox
    Friend WithEvents gboxOral As GroupBox
    Friend WithEvents checkOMaths As CheckBox
    Friend WithEvents checkORes As CheckBox
    Friend WithEvents checkOSys As CheckBox
    Friend WithEvents checkOAng As CheckBox
    Friend WithEvents checkOChi As CheckBox
    Friend WithEvents checkOEsp As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents labNbEcrit As Label
    Friend WithEvents labNbOral As Label
    Friend WithEvents RadButNon As RadioButton
    Friend WithEvents RadButOui As RadioButton
    Friend WithEvents Timer1Min30 As Timer
    Friend WithEvents cboxFac As ComboBox
    Friend WithEvents ButEnreg As Button
    Friend WithEvents ButAban As Button
    Friend WithEvents checkODroit As CheckBox
    Friend WithEvents checkOExp As CheckBox
    Friend WithEvents checkOGest As CheckBox
    Friend WithEvents labQuest As Label
    Friend WithEvents Titre As Label
End Class
