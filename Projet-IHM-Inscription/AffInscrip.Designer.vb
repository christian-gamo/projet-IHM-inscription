<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AffInscrip
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
        Me.lboxNum = New System.Windows.Forms.ListBox()
        Me.lboxNom = New System.Windows.Forms.ListBox()
        Me.lboxPrenom = New System.Windows.Forms.ListBox()
        Me.lboxEcrit = New System.Windows.Forms.ListBox()
        Me.lboxOral = New System.Windows.Forms.ListBox()
        Me.labNum = New System.Windows.Forms.Label()
        Me.labNom = New System.Windows.Forms.Label()
        Me.labPrenom = New System.Windows.Forms.Label()
        Me.labEcrit = New System.Windows.Forms.Label()
        Me.lboxFac = New System.Windows.Forms.ListBox()
        Me.labOral = New System.Windows.Forms.Label()
        Me.labFac = New System.Windows.Forms.Label()
        Me.ButRet = New System.Windows.Forms.Button()
        Me.Titre = New System.Windows.Forms.Label()
        Me.SBInscrits = New System.Windows.Forms.VScrollBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lboxNum
        '
        Me.lboxNum.FormattingEnabled = True
        Me.lboxNum.ItemHeight = 16
        Me.lboxNum.Location = New System.Drawing.Point(6, 0)
        Me.lboxNum.Margin = New System.Windows.Forms.Padding(4)
        Me.lboxNum.Name = "lboxNum"
        Me.lboxNum.Size = New System.Drawing.Size(159, 116)
        Me.lboxNum.TabIndex = 0
        '
        'lboxNom
        '
        Me.lboxNom.FormattingEnabled = True
        Me.lboxNom.ItemHeight = 16
        Me.lboxNom.Location = New System.Drawing.Point(142, 0)
        Me.lboxNom.Margin = New System.Windows.Forms.Padding(4)
        Me.lboxNom.Name = "lboxNom"
        Me.lboxNom.Size = New System.Drawing.Size(191, 116)
        Me.lboxNom.TabIndex = 1
        '
        'lboxPrenom
        '
        Me.lboxPrenom.FormattingEnabled = True
        Me.lboxPrenom.ItemHeight = 16
        Me.lboxPrenom.Location = New System.Drawing.Point(305, 0)
        Me.lboxPrenom.Margin = New System.Windows.Forms.Padding(4)
        Me.lboxPrenom.Name = "lboxPrenom"
        Me.lboxPrenom.Size = New System.Drawing.Size(196, 116)
        Me.lboxPrenom.TabIndex = 2
        '
        'lboxEcrit
        '
        Me.lboxEcrit.FormattingEnabled = True
        Me.lboxEcrit.ItemHeight = 16
        Me.lboxEcrit.Location = New System.Drawing.Point(476, 0)
        Me.lboxEcrit.Margin = New System.Windows.Forms.Padding(4)
        Me.lboxEcrit.Name = "lboxEcrit"
        Me.lboxEcrit.Size = New System.Drawing.Size(193, 116)
        Me.lboxEcrit.TabIndex = 3
        '
        'lboxOral
        '
        Me.lboxOral.FormattingEnabled = True
        Me.lboxOral.ItemHeight = 16
        Me.lboxOral.Location = New System.Drawing.Point(634, 0)
        Me.lboxOral.Margin = New System.Windows.Forms.Padding(4)
        Me.lboxOral.Name = "lboxOral"
        Me.lboxOral.Size = New System.Drawing.Size(203, 116)
        Me.lboxOral.TabIndex = 4
        '
        'labNum
        '
        Me.labNum.AutoSize = True
        Me.labNum.Font = New System.Drawing.Font("Goudy Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labNum.Location = New System.Drawing.Point(69, 112)
        Me.labNum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labNum.Name = "labNum"
        Me.labNum.Size = New System.Drawing.Size(76, 19)
        Me.labNum.TabIndex = 5
        Me.labNum.Text = "NUMÉRO"
        '
        'labNom
        '
        Me.labNom.AutoSize = True
        Me.labNom.Font = New System.Drawing.Font("Goudy Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labNom.Location = New System.Drawing.Point(245, 112)
        Me.labNom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labNom.Name = "labNom"
        Me.labNom.Size = New System.Drawing.Size(45, 19)
        Me.labNom.TabIndex = 6
        Me.labNom.Text = "NOM"
        '
        'labPrenom
        '
        Me.labPrenom.AutoSize = True
        Me.labPrenom.Font = New System.Drawing.Font("Goudy Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labPrenom.Location = New System.Drawing.Point(403, 112)
        Me.labPrenom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labPrenom.Name = "labPrenom"
        Me.labPrenom.Size = New System.Drawing.Size(72, 19)
        Me.labPrenom.TabIndex = 7
        Me.labPrenom.Text = "PRÉNOM"
        '
        'labEcrit
        '
        Me.labEcrit.AutoSize = True
        Me.labEcrit.Font = New System.Drawing.Font("Goudy Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labEcrit.Location = New System.Drawing.Point(572, 112)
        Me.labEcrit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labEcrit.Name = "labEcrit"
        Me.labEcrit.Size = New System.Drawing.Size(53, 19)
        Me.labEcrit.TabIndex = 8
        Me.labEcrit.Text = "ÉCRIT"
        '
        'lboxFac
        '
        Me.lboxFac.FormattingEnabled = True
        Me.lboxFac.ItemHeight = 16
        Me.lboxFac.Location = New System.Drawing.Point(794, 0)
        Me.lboxFac.Margin = New System.Windows.Forms.Padding(4)
        Me.lboxFac.Name = "lboxFac"
        Me.lboxFac.Size = New System.Drawing.Size(211, 116)
        Me.lboxFac.TabIndex = 9
        '
        'labOral
        '
        Me.labOral.AutoSize = True
        Me.labOral.Font = New System.Drawing.Font("Goudy Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labOral.Location = New System.Drawing.Point(745, 112)
        Me.labOral.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labOral.Name = "labOral"
        Me.labOral.Size = New System.Drawing.Size(49, 19)
        Me.labOral.TabIndex = 11
        Me.labOral.Text = "ORAL"
        '
        'labFac
        '
        Me.labFac.AutoSize = True
        Me.labFac.Font = New System.Drawing.Font("Goudy Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labFac.Location = New System.Drawing.Point(891, 112)
        Me.labFac.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labFac.Name = "labFac"
        Me.labFac.Size = New System.Drawing.Size(110, 19)
        Me.labFac.TabIndex = 12
        Me.labFac.Text = "FACULTATIVE"
        '
        'ButRet
        '
        Me.ButRet.BackColor = System.Drawing.Color.Snow
        Me.ButRet.Location = New System.Drawing.Point(910, 343)
        Me.ButRet.Margin = New System.Windows.Forms.Padding(4)
        Me.ButRet.Name = "ButRet"
        Me.ButRet.Size = New System.Drawing.Size(113, 46)
        Me.ButRet.TabIndex = 32
        Me.ButRet.Text = "Retour"
        Me.ButRet.UseVisualStyleBackColor = False
        '
        'Titre
        '
        Me.Titre.AutoSize = True
        Me.Titre.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titre.Location = New System.Drawing.Point(396, 11)
        Me.Titre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Titre.Name = "Titre"
        Me.Titre.Size = New System.Drawing.Size(283, 53)
        Me.Titre.TabIndex = 58
        Me.Titre.Text = "Liste des inscrits"
        '
        'SBInscrits
        '
        Me.SBInscrits.LargeChange = 1
        Me.SBInscrits.Location = New System.Drawing.Point(1023, 159)
        Me.SBInscrits.Name = "SBInscrits"
        Me.SBInscrits.Size = New System.Drawing.Size(21, 116)
        Me.SBInscrits.TabIndex = 59
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lboxFac)
        Me.Panel1.Controls.Add(Me.lboxOral)
        Me.Panel1.Controls.Add(Me.lboxEcrit)
        Me.Panel1.Controls.Add(Me.lboxPrenom)
        Me.Panel1.Controls.Add(Me.lboxNom)
        Me.Panel1.Controls.Add(Me.lboxNum)
        Me.Panel1.Location = New System.Drawing.Point(18, 159)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1005, 155)
        Me.Panel1.TabIndex = 60
        '
        'AffInscrip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1058, 446)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SBInscrits)
        Me.Controls.Add(Me.Titre)
        Me.Controls.Add(Me.ButRet)
        Me.Controls.Add(Me.labFac)
        Me.Controls.Add(Me.labOral)
        Me.Controls.Add(Me.labEcrit)
        Me.Controls.Add(Me.labPrenom)
        Me.Controls.Add(Me.labNom)
        Me.Controls.Add(Me.labNum)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AffInscrip"
        Me.Text = "Liste des inscriptions"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lboxNum As ListBox
    Friend WithEvents lboxNom As ListBox
    Friend WithEvents lboxPrenom As ListBox
    Friend WithEvents lboxEcrit As ListBox
    Friend WithEvents lboxOral As ListBox
    Friend WithEvents labNum As Label
    Friend WithEvents labNom As Label
    Friend WithEvents labPrenom As Label
    Friend WithEvents labEcrit As Label
    Friend WithEvents lboxFac As ListBox
    Friend WithEvents labOral As Label
    Friend WithEvents labFac As Label
    Friend WithEvents ButRet As Button
    Friend WithEvents Titre As Label
    Friend WithEvents SBInscrits As VScrollBar
    Friend WithEvents Panel1 As Panel
End Class
