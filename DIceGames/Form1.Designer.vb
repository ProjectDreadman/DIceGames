<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnDiceGames1 = New System.Windows.Forms.Button()
        Me.btnDiceGames2 = New System.Windows.Forms.Button()
        Me.btnDiceGames3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe Print", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(41, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(512, 51)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "WELCOME TO THE DICE GAMES"
        '
        'btnDiceGames1
        '
        Me.btnDiceGames1.Location = New System.Drawing.Point(213, 94)
        Me.btnDiceGames1.Name = "btnDiceGames1"
        Me.btnDiceGames1.Size = New System.Drawing.Size(163, 32)
        Me.btnDiceGames1.TabIndex = 2
        Me.btnDiceGames1.Text = "PREDICTION"
        Me.btnDiceGames1.UseVisualStyleBackColor = True
        '
        'btnDiceGames2
        '
        Me.btnDiceGames2.Location = New System.Drawing.Point(213, 167)
        Me.btnDiceGames2.Name = "btnDiceGames2"
        Me.btnDiceGames2.Size = New System.Drawing.Size(163, 32)
        Me.btnDiceGames2.TabIndex = 3
        Me.btnDiceGames2.Text = "PLAYER VS. CPU"
        Me.btnDiceGames2.UseVisualStyleBackColor = True
        '
        'btnDiceGames3
        '
        Me.btnDiceGames3.Location = New System.Drawing.Point(213, 247)
        Me.btnDiceGames3.Name = "btnDiceGames3"
        Me.btnDiceGames3.Size = New System.Drawing.Size(163, 32)
        Me.btnDiceGames3.TabIndex = 4
        Me.btnDiceGames3.Text = "GUESSING GAME"
        Me.btnDiceGames3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.btnDiceGames3)
        Me.Controls.Add(Me.btnDiceGames2)
        Me.Controls.Add(Me.btnDiceGames1)
        Me.Controls.Add(Me.lblTitle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnDiceGames1 As Button
    Friend WithEvents btnDiceGames2 As Button
    Friend WithEvents btnDiceGames3 As Button
End Class
