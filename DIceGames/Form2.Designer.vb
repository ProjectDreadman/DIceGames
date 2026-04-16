<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.picDice = New System.Windows.Forms.PictureBox()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.optEven = New System.Windows.Forms.RadioButton()
        Me.optOdd = New System.Windows.Forms.RadioButton()
        Me.lblCorrect = New System.Windows.Forms.Label()
        Me.lblIncorrect = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picDice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picDice
        '
        Me.picDice.Location = New System.Drawing.Point(351, 112)
        Me.picDice.Name = "picDice"
        Me.picDice.Size = New System.Drawing.Size(255, 235)
        Me.picDice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDice.TabIndex = 0
        Me.picDice.TabStop = False
        '
        'btnRoll
        '
        Me.btnRoll.Location = New System.Drawing.Point(403, 375)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(152, 61)
        Me.btnRoll.TabIndex = 1
        Me.btnRoll.Text = "ROLL"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'optEven
        '
        Me.optEven.AutoSize = True
        Me.optEven.Location = New System.Drawing.Point(381, 461)
        Me.optEven.Name = "optEven"
        Me.optEven.Size = New System.Drawing.Size(65, 20)
        Me.optEven.TabIndex = 2
        Me.optEven.TabStop = True
        Me.optEven.Text = "EVEN"
        Me.optEven.UseVisualStyleBackColor = True
        '
        'optOdd
        '
        Me.optOdd.AutoSize = True
        Me.optOdd.Location = New System.Drawing.Point(527, 461)
        Me.optOdd.Name = "optOdd"
        Me.optOdd.Size = New System.Drawing.Size(58, 20)
        Me.optOdd.TabIndex = 3
        Me.optOdd.TabStop = True
        Me.optOdd.Text = "ODD"
        Me.optOdd.UseVisualStyleBackColor = True
        '
        'lblCorrect
        '
        Me.lblCorrect.AutoSize = True
        Me.lblCorrect.Location = New System.Drawing.Point(348, 22)
        Me.lblCorrect.Name = "lblCorrect"
        Me.lblCorrect.Size = New System.Drawing.Size(53, 16)
        Me.lblCorrect.TabIndex = 4
        Me.lblCorrect.Text = "Correct:"
        '
        'lblIncorrect
        '
        Me.lblIncorrect.AutoSize = True
        Me.lblIncorrect.Location = New System.Drawing.Point(348, 66)
        Me.lblIncorrect.Name = "lblIncorrect"
        Me.lblIncorrect.Size = New System.Drawing.Size(61, 16)
        Me.lblIncorrect.TabIndex = 5
        Me.lblIncorrect.Text = "Incorrect:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(951, 507)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(104, 35)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblIncorrect)
        Me.Controls.Add(Me.lblCorrect)
        Me.Controls.Add(Me.optOdd)
        Me.Controls.Add(Me.optEven)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.picDice)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form2"
        Me.Text = "Prediction"
        CType(Me.picDice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picDice As PictureBox
    Friend WithEvents btnRoll As Button
    Friend WithEvents optEven As RadioButton
    Friend WithEvents optOdd As RadioButton
    Friend WithEvents lblCorrect As Label
    Friend WithEvents lblIncorrect As Label
    Friend WithEvents btnExit As Button
End Class
