<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accueil
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
        Me.ButEnreg = New System.Windows.Forms.Button()
        Me.ButModifSuppr = New System.Windows.Forms.Button()
        Me.ButAffInscri = New System.Windows.Forms.Button()
        Me.ButBilan = New System.Windows.Forms.Button()
        Me.ButQuitter = New System.Windows.Forms.Button()
        Me.Titre = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButEnreg
        '
        Me.ButEnreg.Font = New System.Drawing.Font("Goudy Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButEnreg.Location = New System.Drawing.Point(0, 210)
        Me.ButEnreg.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButEnreg.Name = "ButEnreg"
        Me.ButEnreg.Size = New System.Drawing.Size(141, 46)
        Me.ButEnreg.TabIndex = 0
        Me.ButEnreg.Text = "Enregistrer une inscription"
        Me.ButEnreg.UseVisualStyleBackColor = True
        '
        'ButModifSuppr
        '
        Me.ButModifSuppr.Font = New System.Drawing.Font("Goudy Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButModifSuppr.Location = New System.Drawing.Point(139, 210)
        Me.ButModifSuppr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButModifSuppr.Name = "ButModifSuppr"
        Me.ButModifSuppr.Size = New System.Drawing.Size(141, 46)
        Me.ButModifSuppr.TabIndex = 1
        Me.ButModifSuppr.Text = "Modification ou suppression"
        Me.ButModifSuppr.UseVisualStyleBackColor = True
        '
        'ButAffInscri
        '
        Me.ButAffInscri.Font = New System.Drawing.Font("Goudy Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButAffInscri.Location = New System.Drawing.Point(277, 210)
        Me.ButAffInscri.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButAffInscri.Name = "ButAffInscri"
        Me.ButAffInscri.Size = New System.Drawing.Size(141, 46)
        Me.ButAffInscri.TabIndex = 2
        Me.ButAffInscri.Text = "Afficher l'état actuel des inscriptions"
        Me.ButAffInscri.UseVisualStyleBackColor = True
        '
        'ButBilan
        '
        Me.ButBilan.Font = New System.Drawing.Font("Goudy Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButBilan.Location = New System.Drawing.Point(415, 210)
        Me.ButBilan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButBilan.Name = "ButBilan"
        Me.ButBilan.Size = New System.Drawing.Size(141, 46)
        Me.ButBilan.TabIndex = 3
        Me.ButBilan.Text = "Bilan des inscriptions"
        Me.ButBilan.UseVisualStyleBackColor = True
        '
        'ButQuitter
        '
        Me.ButQuitter.Font = New System.Drawing.Font("Goudy Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButQuitter.Location = New System.Drawing.Point(554, 210)
        Me.ButQuitter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButQuitter.Name = "ButQuitter"
        Me.ButQuitter.Size = New System.Drawing.Size(124, 46)
        Me.ButQuitter.TabIndex = 4
        Me.ButQuitter.Text = "Quitter"
        Me.ButQuitter.UseVisualStyleBackColor = True
        '
        'Titre
        '
        Me.Titre.AutoSize = True
        Me.Titre.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titre.Location = New System.Drawing.Point(217, 73)
        Me.Titre.Name = "Titre"
        Me.Titre.Size = New System.Drawing.Size(255, 57)
        Me.Titre.TabIndex = 5
        Me.Titre.Text = "Menu général"
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(677, 255)
        Me.Controls.Add(Me.Titre)
        Me.Controls.Add(Me.ButQuitter)
        Me.Controls.Add(Me.ButBilan)
        Me.Controls.Add(Me.ButAffInscri)
        Me.Controls.Add(Me.ButModifSuppr)
        Me.Controls.Add(Me.ButEnreg)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Accueil"
        Me.ShowIcon = False
        Me.Text = "Accueil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButEnreg As Button
    Friend WithEvents ButModifSuppr As Button
    Friend WithEvents ButAffInscri As Button
    Friend WithEvents ButBilan As Button
    Friend WithEvents ButQuitter As Button
    Friend WithEvents Titre As Label
End Class
