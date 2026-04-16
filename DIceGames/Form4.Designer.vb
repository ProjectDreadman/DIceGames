<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.lblGuess1 = New System.Windows.Forms.RadioButton()
        Me.lblGuess2 = New System.Windows.Forms.RadioButton()
        Me.lblGuess6 = New System.Windows.Forms.RadioButton()
        Me.lblGuess5 = New System.Windows.Forms.RadioButton()
        Me.lblGuess4 = New System.Windows.Forms.RadioButton()
        Me.lblGuess3 = New System.Windows.Forms.RadioButton()
        Me.lblGuesses = New System.Windows.Forms.Label()
        Me.picDIce = New System.Windows.Forms.PictureBox()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picDIce, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblGuess1
        '
        Me.lblGuess1.AutoSize = True
        Me.lblGuess1.Location = New System.Drawing.Point(208, 157)
        Me.lblGuess1.Name = "lblGuess1"
        Me.lblGuess1.Size = New System.Drawing.Size(35, 20)
        Me.lblGuess1.TabIndex = 0
        Me.lblGuess1.TabStop = True
        Me.lblGuess1.Text = "1"
        Me.lblGuess1.UseVisualStyleBackColor = True
        '
        'lblGuess2
        '
        Me.lblGuess2.AutoSize = True
        Me.lblGuess2.Location = New System.Drawing.Point(208, 183)
        Me.lblGuess2.Name = "lblGuess2"
        Me.lblGuess2.Size = New System.Drawing.Size(35, 20)
        Me.lblGuess2.TabIndex = 1
        Me.lblGuess2.TabStop = True
        Me.lblGuess2.Text = "2"
        Me.lblGuess2.UseVisualStyleBackColor = True
        '
        'lblGuess6
        '
        Me.lblGuess6.AutoSize = True
        Me.lblGuess6.Location = New System.Drawing.Point(208, 287)
        Me.lblGuess6.Name = "lblGuess6"
        Me.lblGuess6.Size = New System.Drawing.Size(35, 20)
        Me.lblGuess6.TabIndex = 2
        Me.lblGuess6.TabStop = True
        Me.lblGuess6.Text = "6"
        Me.lblGuess6.UseVisualStyleBackColor = True
        '
        'lblGuess5
        '
        Me.lblGuess5.AutoSize = True
        Me.lblGuess5.Location = New System.Drawing.Point(208, 261)
        Me.lblGuess5.Name = "lblGuess5"
        Me.lblGuess5.Size = New System.Drawing.Size(35, 20)
        Me.lblGuess5.TabIndex = 3
        Me.lblGuess5.TabStop = True
        Me.lblGuess5.Text = "5"
        Me.lblGuess5.UseVisualStyleBackColor = True
        '
        'lblGuess4
        '
        Me.lblGuess4.AutoSize = True
        Me.lblGuess4.Location = New System.Drawing.Point(208, 235)
        Me.lblGuess4.Name = "lblGuess4"
        Me.lblGuess4.Size = New System.Drawing.Size(35, 20)
        Me.lblGuess4.TabIndex = 4
        Me.lblGuess4.TabStop = True
        Me.lblGuess4.Text = "4"
        Me.lblGuess4.UseVisualStyleBackColor = True
        '
        'lblGuess3
        '
        Me.lblGuess3.AutoSize = True
        Me.lblGuess3.Location = New System.Drawing.Point(208, 209)
        Me.lblGuess3.Name = "lblGuess3"
        Me.lblGuess3.Size = New System.Drawing.Size(35, 20)
        Me.lblGuess3.TabIndex = 5
        Me.lblGuess3.TabStop = True
        Me.lblGuess3.Text = "3"
        Me.lblGuess3.UseVisualStyleBackColor = True
        '
        'lblGuesses
        '
        Me.lblGuesses.AutoSize = True
        Me.lblGuesses.Location = New System.Drawing.Point(190, 342)
        Me.lblGuesses.Name = "lblGuesses"
        Me.lblGuesses.Size = New System.Drawing.Size(64, 16)
        Me.lblGuesses.TabIndex = 6
        Me.lblGuesses.Text = "Guesses:"
        '
        'picDIce
        '
        Me.picDIce.Location = New System.Drawing.Point(362, 100)
        Me.picDIce.Name = "picDIce"
        Me.picDIce.Size = New System.Drawing.Size(344, 281)
        Me.picDIce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDIce.TabIndex = 7
        Me.picDIce.TabStop = False
        '
        'btnRoll
        '
        Me.btnRoll.Location = New System.Drawing.Point(478, 419)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(107, 34)
        Me.btnRoll.TabIndex = 8
        Me.btnRoll.Text = "ROLL"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(949, 490)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(106, 52)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.picDIce)
        Me.Controls.Add(Me.lblGuesses)
        Me.Controls.Add(Me.lblGuess3)
        Me.Controls.Add(Me.lblGuess4)
        Me.Controls.Add(Me.lblGuess5)
        Me.Controls.Add(Me.lblGuess6)
        Me.Controls.Add(Me.lblGuess2)
        Me.Controls.Add(Me.lblGuess1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form4"
        Me.Text = "Guessing Game"
        CType(Me.picDIce, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGuess1 As RadioButton
    Friend WithEvents lblGuess2 As RadioButton
    Friend WithEvents lblGuess6 As RadioButton
    Friend WithEvents lblGuess5 As RadioButton
    Friend WithEvents lblGuess4 As RadioButton
    Friend WithEvents lblGuess3 As RadioButton
    Friend WithEvents lblGuesses As Label
    Friend WithEvents picDIce As PictureBox
    Friend WithEvents btnRoll As Button
    Friend WithEvents btnExit As Button
End Class
