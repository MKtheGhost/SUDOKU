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
        Me.SudokuLabel = New System.Windows.Forms.Label()
        Me.NewGameBtn = New System.Windows.Forms.Button()
        Me.QuitGameBtn = New System.Windows.Forms.Button()
        Me.ScoreBtn = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'SudokuLabel
        '
        Me.SudokuLabel.AutoSize = True
        Me.SudokuLabel.Location = New System.Drawing.Point(61, 53)
        Me.SudokuLabel.Name = "SudokuLabel"
        Me.SudokuLabel.Size = New System.Drawing.Size(53, 13)
        Me.SudokuLabel.TabIndex = 0
        Me.SudokuLabel.Text = "SUDOKU"
        '
        'NewGameBtn
        '
        Me.NewGameBtn.Location = New System.Drawing.Point(233, 356)
        Me.NewGameBtn.Name = "NewGameBtn"
        Me.NewGameBtn.Size = New System.Drawing.Size(75, 23)
        Me.NewGameBtn.TabIndex = 1
        Me.NewGameBtn.Text = "New Game"
        Me.NewGameBtn.UseVisualStyleBackColor = True
        '
        'QuitGameBtn
        '
        Me.QuitGameBtn.Location = New System.Drawing.Point(75, 356)
        Me.QuitGameBtn.Name = "QuitGameBtn"
        Me.QuitGameBtn.Size = New System.Drawing.Size(75, 23)
        Me.QuitGameBtn.TabIndex = 2
        Me.QuitGameBtn.Text = "Quit Game"
        Me.QuitGameBtn.UseVisualStyleBackColor = True
        '
        'ScoreBtn
        '
        Me.ScoreBtn.Location = New System.Drawing.Point(402, 355)
        Me.ScoreBtn.Name = "ScoreBtn"
        Me.ScoreBtn.Size = New System.Drawing.Size(77, 24)
        Me.ScoreBtn.TabIndex = 3
        Me.ScoreBtn.Text = "Score"
        Me.ScoreBtn.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(64, 108)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 450)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ScoreBtn)
        Me.Controls.Add(Me.QuitGameBtn)
        Me.Controls.Add(Me.NewGameBtn)
        Me.Controls.Add(Me.SudokuLabel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SudokuLabel As Label
    Friend WithEvents NewGameBtn As Button
    Friend WithEvents QuitGameBtn As Button
    Friend WithEvents ScoreBtn As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
