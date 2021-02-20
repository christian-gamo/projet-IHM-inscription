<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Bilan
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
        Me.RadIndiv = New System.Windows.Forms.RadioButton()
        Me.RadMatiere = New System.Windows.Forms.RadioButton()
        Me.cboxIndiv = New System.Windows.Forms.ComboBox()
        Me.cboxMatiere = New System.Windows.Forms.ComboBox()
        Me.ButMatiere = New System.Windows.Forms.Button()
        Me.ButIndiv = New System.Windows.Forms.Button()
        Me.ButRet = New System.Windows.Forms.Button()
        Me.txtNbInscrits = New System.Windows.Forms.TextBox()
        Me.labNbInscrits = New System.Windows.Forms.Label()
        Me.Titre = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RadIndiv
        '
        Me.RadIndiv.AutoSize = True
        Me.RadIndiv.Location = New System.Drawing.Point(160, 129)
        Me.RadIndiv.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadIndiv.Name = "RadIndiv"
        Me.RadIndiv.Size = New System.Drawing.Size(88, 21)
        Me.RadIndiv.TabIndex = 0
        Me.RadIndiv.TabStop = True
        Me.RadIndiv.Text = "Individuel"
        Me.RadIndiv.UseVisualStyleBackColor = True
        '
        'RadMatiere
        '
        Me.RadMatiere.AutoSize = True
        Me.RadMatiere.Location = New System.Drawing.Point(485, 129)
        Me.RadMatiere.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadMatiere.Name = "RadMatiere"
        Me.RadMatiere.Size = New System.Drawing.Size(76, 21)
        Me.RadMatiere.TabIndex = 1
        Me.RadMatiere.TabStop = True
        Me.RadMatiere.Text = "Matière"
        Me.RadMatiere.UseVisualStyleBackColor = True
        '
        'cboxIndiv
        '
        Me.cboxIndiv.FormattingEnabled = True
        Me.cboxIndiv.Location = New System.Drawing.Point(131, 171)
        Me.cboxIndiv.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboxIndiv.Name = "cboxIndiv"
        Me.cboxIndiv.Size = New System.Drawing.Size(175, 24)
        Me.cboxIndiv.TabIndex = 2
        '
        'cboxMatiere
        '
        Me.cboxMatiere.FormattingEnabled = True
        Me.cboxMatiere.Location = New System.Drawing.Point(424, 171)
        Me.cboxMatiere.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboxMatiere.Name = "cboxMatiere"
        Me.cboxMatiere.Size = New System.Drawing.Size(191, 24)
        Me.cboxMatiere.TabIndex = 3
        '
        'ButMatiere
        '
        Me.ButMatiere.Location = New System.Drawing.Point(465, 217)
        Me.ButMatiere.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButMatiere.Name = "ButMatiere"
        Me.ButMatiere.Size = New System.Drawing.Size(100, 28)
        Me.ButMatiere.TabIndex = 4
        Me.ButMatiere.Text = "OK"
        Me.ButMatiere.UseVisualStyleBackColor = True
        '
        'ButIndiv
        '
        Me.ButIndiv.Location = New System.Drawing.Point(160, 217)
        Me.ButIndiv.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButIndiv.Name = "ButIndiv"
        Me.ButIndiv.Size = New System.Drawing.Size(100, 28)
        Me.ButIndiv.TabIndex = 7
        Me.ButIndiv.Text = "OK"
        Me.ButIndiv.UseVisualStyleBackColor = True
        '
        'ButRet
        '
        Me.ButRet.BackColor = System.Drawing.Color.Snow
        Me.ButRet.Location = New System.Drawing.Point(609, 258)
        Me.ButRet.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButRet.Name = "ButRet"
        Me.ButRet.Size = New System.Drawing.Size(113, 46)
        Me.ButRet.TabIndex = 32
        Me.ButRet.Text = "Retour"
        Me.ButRet.UseVisualStyleBackColor = False
        '
        'txtNbInscrits
        '
        Me.txtNbInscrits.Location = New System.Drawing.Point(373, 80)
        Me.txtNbInscrits.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNbInscrits.Name = "txtNbInscrits"
        Me.txtNbInscrits.Size = New System.Drawing.Size(68, 22)
        Me.txtNbInscrits.TabIndex = 33
        '
        'labNbInscrits
        '
        Me.labNbInscrits.AutoSize = True
        Me.labNbInscrits.Location = New System.Drawing.Point(237, 84)
        Me.labNbInscrits.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labNbInscrits.Name = "labNbInscrits"
        Me.labNbInscrits.Size = New System.Drawing.Size(129, 17)
        Me.labNbInscrits.TabIndex = 34
        Me.labNbInscrits.Text = "Nombre d'inscrits : "
        '
        'Titre
        '
        Me.Titre.AutoSize = True
        Me.Titre.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titre.Location = New System.Drawing.Point(304, 9)
        Me.Titre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Titre.Name = "Titre"
        Me.Titre.Size = New System.Drawing.Size(109, 53)
        Me.Titre.TabIndex = 56
        Me.Titre.Text = "Bilan"
        '
        'Bilan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(739, 319)
        Me.Controls.Add(Me.Titre)
        Me.Controls.Add(Me.labNbInscrits)
        Me.Controls.Add(Me.txtNbInscrits)
        Me.Controls.Add(Me.ButRet)
        Me.Controls.Add(Me.ButIndiv)
        Me.Controls.Add(Me.ButMatiere)
        Me.Controls.Add(Me.cboxMatiere)
        Me.Controls.Add(Me.cboxIndiv)
        Me.Controls.Add(Me.RadMatiere)
        Me.Controls.Add(Me.RadIndiv)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Bilan"
        Me.Text = "Bilan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadIndiv As RadioButton
    Friend WithEvents RadMatiere As RadioButton
    Friend WithEvents cboxIndiv As ComboBox
    Friend WithEvents cboxMatiere As ComboBox
    Friend WithEvents ButMatiere As Button
    Friend WithEvents ButIndiv As Button
    Friend WithEvents ButRet As Button
    Friend WithEvents txtNbInscrits As TextBox
    Friend WithEvents labNbInscrits As Label
    Friend WithEvents Titre As Label
End Class
