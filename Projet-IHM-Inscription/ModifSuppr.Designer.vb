<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifSuppr
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
        Me.RadNum = New System.Windows.Forms.RadioButton()
        Me.RadId = New System.Windows.Forms.RadioButton()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.cboxId = New System.Windows.Forms.ComboBox()
        Me.ButSuppr = New System.Windows.Forms.Button()
        Me.ButModif = New System.Windows.Forms.Button()
        Me.ButRet = New System.Windows.Forms.Button()
        Me.Titre = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RadNum
        '
        Me.RadNum.AutoSize = True
        Me.RadNum.Location = New System.Drawing.Point(113, 79)
        Me.RadNum.Name = "RadNum"
        Me.RadNum.Size = New System.Drawing.Size(62, 17)
        Me.RadNum.TabIndex = 0
        Me.RadNum.TabStop = True
        Me.RadNum.Text = "Numéro"
        Me.RadNum.UseVisualStyleBackColor = True
        '
        'RadId
        '
        Me.RadId.AutoSize = True
        Me.RadId.Location = New System.Drawing.Point(334, 79)
        Me.RadId.Name = "RadId"
        Me.RadId.Size = New System.Drawing.Size(71, 17)
        Me.RadId.TabIndex = 1
        Me.RadId.TabStop = True
        Me.RadId.Text = "Identifiant"
        Me.RadId.UseVisualStyleBackColor = True
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(127, 130)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(38, 20)
        Me.txtNum.TabIndex = 2
        '
        'cboxId
        '
        Me.cboxId.FormattingEnabled = True
        Me.cboxId.Location = New System.Drawing.Point(274, 129)
        Me.cboxId.Name = "cboxId"
        Me.cboxId.Size = New System.Drawing.Size(189, 21)
        Me.cboxId.TabIndex = 3
        '
        'ButSuppr
        '
        Me.ButSuppr.Location = New System.Drawing.Point(113, 185)
        Me.ButSuppr.Name = "ButSuppr"
        Me.ButSuppr.Size = New System.Drawing.Size(75, 23)
        Me.ButSuppr.TabIndex = 4
        Me.ButSuppr.Text = "Supprimer"
        Me.ButSuppr.UseVisualStyleBackColor = True
        '
        'ButModif
        '
        Me.ButModif.Location = New System.Drawing.Point(330, 185)
        Me.ButModif.Name = "ButModif"
        Me.ButModif.Size = New System.Drawing.Size(75, 23)
        Me.ButModif.TabIndex = 5
        Me.ButModif.Text = "Modifier"
        Me.ButModif.UseVisualStyleBackColor = True
        '
        'ButRet
        '
        Me.ButRet.BackColor = System.Drawing.Color.Snow
        Me.ButRet.Location = New System.Drawing.Point(450, 245)
        Me.ButRet.Name = "ButRet"
        Me.ButRet.Size = New System.Drawing.Size(85, 37)
        Me.ButRet.TabIndex = 32
        Me.ButRet.Text = "Retour"
        Me.ButRet.UseVisualStyleBackColor = False
        '
        'Titre
        '
        Me.Titre.AutoSize = True
        Me.Titre.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titre.Location = New System.Drawing.Point(98, 9)
        Me.Titre.Name = "Titre"
        Me.Titre.Size = New System.Drawing.Size(365, 43)
        Me.Titre.TabIndex = 57
        Me.Titre.Text = "Modification ou suppression"
        '
        'ModifSuppr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 294)
        Me.Controls.Add(Me.Titre)
        Me.Controls.Add(Me.ButRet)
        Me.Controls.Add(Me.ButModif)
        Me.Controls.Add(Me.ButSuppr)
        Me.Controls.Add(Me.cboxId)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.RadId)
        Me.Controls.Add(Me.RadNum)
        Me.Name = "ModifSuppr"
        Me.Text = "Modification ou suppresion de candidat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadNum As RadioButton
    Friend WithEvents RadId As RadioButton
    Friend WithEvents txtNum As TextBox
    Friend WithEvents cboxId As ComboBox
    Friend WithEvents ButSuppr As Button
    Friend WithEvents ButModif As Button
    Friend WithEvents ButRet As Button
    Friend WithEvents Titre As Label
End Class
