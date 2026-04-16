<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.lblPLAYERTitle = New System.Windows.Forms.Label()
        Me.lblCPUTitle = New System.Windows.Forms.Label()
        Me.picPLAYER = New System.Windows.Forms.PictureBox()
        Me.picCPU = New System.Windows.Forms.PictureBox()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.lblPlayerScore = New System.Windows.Forms.Label()
        Me.lblCPUScore = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picPLAYER, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCPU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPLAYERTitle
        '
        Me.lblPLAYERTitle.AutoSize = True
        Me.lblPLAYERTitle.Location = New System.Drawing.Point(228, 87)
        Me.lblPLAYERTitle.Name = "lblPLAYERTitle"
        Me.lblPLAYERTitle.Size = New System.Drawing.Size(60, 16)
        Me.lblPLAYERTitle.TabIndex = 0
        Me.lblPLAYERTitle.Text = "PLAYER"
        '
        'lblCPUTitle
        '
        Me.lblCPUTitle.AutoSize = True
        Me.lblCPUTitle.Location = New System.Drawing.Point(713, 87)
        Me.lblCPUTitle.Name = "lblCPUTitle"
        Me.lblCPUTitle.Size = New System.Drawing.Size(35, 16)
        Me.lblCPUTitle.TabIndex = 1
        Me.lblCPUTitle.Text = "CPU"
        '
        'picPLAYER
        '
        Me.picPLAYER.Location = New System.Drawing.Point(166, 143)
        Me.picPLAYER.Name = "picPLAYER"
        Me.picPLAYER.Size = New System.Drawing.Size(194, 176)
        Me.picPLAYER.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPLAYER.TabIndex = 2
        Me.picPLAYER.TabStop = False
        '
        'picCPU
        '
        Me.picCPU.Location = New System.Drawing.Point(631, 143)
        Me.picCPU.Name = "picCPU"
        Me.picCPU.Size = New System.Drawing.Size(194, 176)
        Me.picCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCPU.TabIndex = 3
        Me.picCPU.TabStop = False
        '
        'btnRoll
        '
        Me.btnRoll.Location = New System.Drawing.Point(436, 362)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(144, 61)
        Me.btnRoll.TabIndex = 4
        Me.btnRoll.Text = "ROLL"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'lblPlayerScore
        '
        Me.lblPlayerScore.AutoSize = True
        Me.lblPlayerScore.Location = New System.Drawing.Point(419, 9)
        Me.lblPlayerScore.Name = "lblPlayerScore"
        Me.lblPlayerScore.Size = New System.Drawing.Size(49, 16)
        Me.lblPlayerScore.TabIndex = 5
        Me.lblPlayerScore.Text = "Player:"
        '
        'lblCPUScore
        '
        Me.lblCPUScore.AutoSize = True
        Me.lblCPUScore.Location = New System.Drawing.Point(419, 59)
        Me.lblCPUScore.Name = "lblCPUScore"
        Me.lblCPUScore.Size = New System.Drawing.Size(38, 16)
        Me.lblCPUScore.TabIndex = 6
        Me.lblCPUScore.Text = "CPU:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(958, 490)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(97, 52)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblCPUScore)
        Me.Controls.Add(Me.lblPlayerScore)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.picCPU)
        Me.Controls.Add(Me.picPLAYER)
        Me.Controls.Add(Me.lblCPUTitle)
        Me.Controls.Add(Me.lblPLAYERTitle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form3"
        Me.Text = "Player Vs. Cpu"
        CType(Me.picPLAYER, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCPU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPLAYERTitle As Label
    Friend WithEvents lblCPUTitle As Label
    Friend WithEvents picPLAYER As PictureBox
    Friend WithEvents picCPU As PictureBox
    Friend WithEvents btnRoll As Button
    Friend WithEvents lblPlayerScore As Label
    Friend WithEvents lblCPUScore As Label
    Friend WithEvents btnExit As Button
End Class
