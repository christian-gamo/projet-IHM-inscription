<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BilanMatiere
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lboxRegEcrit = New System.Windows.Forms.ListBox()
        Me.lboxNomEcrit = New System.Windows.Forms.ListBox()
        Me.lboxPrenomEcrit = New System.Windows.Forms.ListBox()
        Me.lboxRegOral = New System.Windows.Forms.ListBox()
        Me.lboxNomOral = New System.Windows.Forms.ListBox()
        Me.lboxPrenomOral = New System.Windows.Forms.ListBox()
        Me.labOral = New System.Windows.Forms.Label()
        Me.labEcrit = New System.Windows.Forms.Label()
        Me.labPrenom = New System.Windows.Forms.Label()
        Me.labNom = New System.Windows.Forms.Label()
        Me.labNum = New System.Windows.Forms.Label()
        Me.labReg = New System.Windows.Forms.Label()
        Me.ButRet = New System.Windows.Forms.Button()
        Me.txtMatiere = New System.Windows.Forms.TextBox()
        Me.Titre = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lboxRegEcrit
        '
        Me.lboxRegEcrit.FormattingEnabled = True
        Me.lboxRegEcrit.Location = New System.Drawing.Point(69, 148)
        Me.lboxRegEcrit.Name = "lboxRegEcrit"
        Me.lboxRegEcrit.Size = New System.Drawing.Size(120, 95)
        Me.lboxRegEcrit.TabIndex = 0
        '
        'lboxNomEcrit
        '
        Me.lboxNomEcrit.FormattingEnabled = True
        Me.lboxNomEcrit.Location = New System.Drawing.Point(208, 148)
        Me.lboxNomEcrit.Name = "lboxNomEcrit"
        Me.lboxNomEcrit.Size = New System.Drawing.Size(120, 95)
        Me.lboxNomEcrit.TabIndex = 1
        '
        'lboxPrenomEcrit
        '
        Me.lboxPrenomEcrit.FormattingEnabled = True
        Me.lboxPrenomEcrit.Location = New System.Drawing.Point(348, 148)
        Me.lboxPrenomEcrit.Name = "lboxPrenomEcrit"
        Me.lboxPrenomEcrit.Size = New System.Drawing.Size(120, 95)
        Me.lboxPrenomEcrit.TabIndex = 2
        '
        'lboxRegOral
        '
        Me.lboxRegOral.FormattingEnabled = True
        Me.lboxRegOral.Location = New System.Drawing.Point(69, 249)
        Me.lboxRegOral.Name = "lboxRegOral"
        Me.lboxRegOral.Size = New System.Drawing.Size(120, 95)
        Me.lboxRegOral.TabIndex = 3
        '
        'lboxNomOral
        '
        Me.lboxNomOral.FormattingEnabled = True
        Me.lboxNomOral.Location = New System.Drawing.Point(208, 249)
        Me.lboxNomOral.Name = "lboxNomOral"
        Me.lboxNomOral.Size = New System.Drawing.Size(120, 95)
        Me.lboxNomOral.TabIndex = 4
        '
        'lboxPrenomOral
        '
        Me.lboxPrenomOral.FormattingEnabled = True
        Me.lboxPrenomOral.Location = New System.Drawing.Point(348, 249)
        Me.lboxPrenomOral.Name = "lboxPrenomOral"
        Me.lboxPrenomOral.Size = New System.Drawing.Size(120, 95)
        Me.lboxPrenomOral.TabIndex = 5
        '
        'labOral
        '
        Me.labOral.AutoSize = True
        Me.labOral.Font = New System.Drawing.Font("Goudy Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labOral.Location = New System.Drawing.Point(6, 295)
        Me.labOral.Name = "labOral"
        Me.labOral.Size = New System.Drawing.Size(40, 16)
        Me.labOral.TabIndex = 17
        Me.labOral.Text = "ORAL"
        '
        'labEcrit
        '
        Me.labEcrit.AutoSize = True
        Me.labEcrit.Font = New System.Drawing.Font("Goudy Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labEcrit.Location = New System.Drawing.Point(6, 186)
        Me.labEcrit.Name = "labEcrit"
        Me.labEcrit.Size = New System.Drawing.Size(43, 16)
        Me.labEcrit.TabIndex = 16
        Me.labEcrit.Text = "ÉCRIT"
        '
        'labPrenom
        '
        Me.labPrenom.AutoSize = True
        Me.labPrenom.Font = New System.Drawing.Font("Goudy Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labPrenom.Location = New System.Drawing.Point(378, 118)
        Me.labPrenom.Name = "labPrenom"
        Me.labPrenom.Size = New System.Drawing.Size(57, 16)
        Me.labPrenom.TabIndex = 15
        Me.labPrenom.Text = "PRÉNOM"
        '
        'labNom
        '
        Me.labNom.AutoSize = True
        Me.labNom.Font = New System.Drawing.Font("Goudy Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labNom.Location = New System.Drawing.Point(250, 118)
        Me.labNom.Name = "labNom"
        Me.labNom.Size = New System.Drawing.Size(36, 16)
        Me.labNom.TabIndex = 14
        Me.labNom.Text = "NOM"
        '
        'labNum
        '
        Me.labNum.AutoSize = True
        Me.labNum.Location = New System.Drawing.Point(-130, 25)
        Me.labNum.Name = "labNum"
        Me.labNum.Size = New System.Drawing.Size(55, 13)
        Me.labNum.TabIndex = 13
        Me.labNum.Text = "NUMÉRO"
        '
        'labReg
        '
        Me.labReg.AutoSize = True
        Me.labReg.Font = New System.Drawing.Font("Goudy Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labReg.Location = New System.Drawing.Point(89, 118)
        Me.labReg.Name = "labReg"
        Me.labReg.Size = New System.Drawing.Size(54, 16)
        Me.labReg.TabIndex = 18
        Me.labReg.Text = "RÉGION"
        '
        'ButRet
        '
        Me.ButRet.BackColor = System.Drawing.Color.Snow
        Me.ButRet.Location = New System.Drawing.Point(383, 385)
        Me.ButRet.Name = "ButRet"
        Me.ButRet.Size = New System.Drawing.Size(85, 37)
        Me.ButRet.TabIndex = 32
        Me.ButRet.Text = "Retour"
        Me.ButRet.UseVisualStyleBackColor = False
        '
        'txtMatiere
        '
        Me.txtMatiere.Location = New System.Drawing.Point(218, 64)
        Me.txtMatiere.Name = "txtMatiere"
        Me.txtMatiere.Size = New System.Drawing.Size(100, 20)
        Me.txtMatiere.TabIndex = 33
        '
        'Titre
        '
        Me.Titre.AutoSize = True
        Me.Titre.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titre.Location = New System.Drawing.Point(174, 9)
        Me.Titre.Name = "Titre"
        Me.Titre.Size = New System.Drawing.Size(185, 43)
        Me.Titre.TabIndex = 34
        Me.Titre.Text = "Bilan matière"
        '
        'BilanMatiere
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 434)
        Me.Controls.Add(Me.Titre)
        Me.Controls.Add(Me.txtMatiere)
        Me.Controls.Add(Me.ButRet)
        Me.Controls.Add(Me.labReg)
        Me.Controls.Add(Me.labOral)
        Me.Controls.Add(Me.labEcrit)
        Me.Controls.Add(Me.labPrenom)
        Me.Controls.Add(Me.labNom)
        Me.Controls.Add(Me.labNum)
        Me.Controls.Add(Me.lboxPrenomOral)
        Me.Controls.Add(Me.lboxNomOral)
        Me.Controls.Add(Me.lboxRegOral)
        Me.Controls.Add(Me.lboxPrenomEcrit)
        Me.Controls.Add(Me.lboxNomEcrit)
        Me.Controls.Add(Me.lboxRegEcrit)
        Me.Name = "BilanMatiere"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lboxRegEcrit As ListBox
    Friend WithEvents lboxNomEcrit As ListBox
    Friend WithEvents lboxPrenomEcrit As ListBox
    Friend WithEvents lboxRegOral As ListBox
    Friend WithEvents lboxNomOral As ListBox
    Friend WithEvents lboxPrenomOral As ListBox
    Friend WithEvents labOral As Label
    Friend WithEvents labEcrit As Label
    Friend WithEvents labPrenom As Label
    Friend WithEvents labNom As Label
    Friend WithEvents labNum As Label
    Friend WithEvents labReg As Label
    Friend WithEvents ButRet As Button
    Friend WithEvents txtMatiere As TextBox
    Friend WithEvents Titre As Label
End Class
