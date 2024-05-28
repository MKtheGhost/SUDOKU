<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SudokuLabel = New System.Windows.Forms.Label()
        Me.NewGameBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.quitGameBtn = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.scoreBtn = New System.Windows.Forms.Button()
        Me.homeBtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.playerCB = New System.Windows.Forms.ComboBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.sudokuTitle = New System.Windows.Forms.Label()
        Me.newPlayerLabel = New System.Windows.Forms.Label()
        Me.newNameTBox = New System.Windows.Forms.TextBox()
        Me.addNameBtn = New System.Windows.Forms.Button()
        Me.nameLB = New System.Windows.Forms.ListBox()
        Me.scoreLB = New System.Windows.Forms.ListBox()
        Me.searchPlayerCB = New System.Windows.Forms.ComboBox()
        Me.showStatsBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SudokuLabel
        '
        Me.SudokuLabel.AutoSize = True
        Me.SudokuLabel.Location = New System.Drawing.Point(30, 28)
        Me.SudokuLabel.Name = "SudokuLabel"
        Me.SudokuLabel.Size = New System.Drawing.Size(53, 13)
        Me.SudokuLabel.TabIndex = 0
        Me.SudokuLabel.Text = "SUDOKU"
        '
        'NewGameBtn
        '
        Me.NewGameBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NewGameBtn.FlatAppearance.BorderSize = 2
        Me.NewGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewGameBtn.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewGameBtn.ForeColor = System.Drawing.Color.White
        Me.NewGameBtn.Location = New System.Drawing.Point(324, 465)
        Me.NewGameBtn.Name = "NewGameBtn"
        Me.NewGameBtn.Size = New System.Drawing.Size(113, 38)
        Me.NewGameBtn.TabIndex = 1
        Me.NewGameBtn.Text = "New Game"
        Me.NewGameBtn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.quitGameBtn)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.scoreBtn)
        Me.Panel1.Controls.Add(Me.homeBtn)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(146, 667)
        Me.Panel1.TabIndex = 5
        '
        'quitGameBtn
        '
        Me.quitGameBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.quitGameBtn.FlatAppearance.BorderSize = 2
        Me.quitGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.quitGameBtn.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quitGameBtn.ForeColor = System.Drawing.Color.White
        Me.quitGameBtn.Location = New System.Drawing.Point(2, 563)
        Me.quitGameBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.quitGameBtn.Name = "quitGameBtn"
        Me.quitGameBtn.Size = New System.Drawing.Size(142, 38)
        Me.quitGameBtn.TabIndex = 4
        Me.quitGameBtn.Text = "Quit game"
        Me.quitGameBtn.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(0, 186)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(146, 42)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Options"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'scoreBtn
        '
        Me.scoreBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.scoreBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.scoreBtn.FlatAppearance.BorderSize = 0
        Me.scoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.scoreBtn.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scoreBtn.ForeColor = System.Drawing.Color.White
        Me.scoreBtn.Location = New System.Drawing.Point(0, 144)
        Me.scoreBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.scoreBtn.Name = "scoreBtn"
        Me.scoreBtn.Size = New System.Drawing.Size(146, 42)
        Me.scoreBtn.TabIndex = 2
        Me.scoreBtn.Text = "Score"
        Me.scoreBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.scoreBtn.UseVisualStyleBackColor = True
        '
        'homeBtn
        '
        Me.homeBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.homeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.homeBtn.FlatAppearance.BorderSize = 2
        Me.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.homeBtn.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homeBtn.ForeColor = System.Drawing.Color.White
        Me.homeBtn.Location = New System.Drawing.Point(0, 102)
        Me.homeBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.homeBtn.Name = "homeBtn"
        Me.homeBtn.Size = New System.Drawing.Size(146, 42)
        Me.homeBtn.TabIndex = 1
        Me.homeBtn.Text = "Home"
        Me.homeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.homeBtn.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(146, 102)
        Me.Panel2.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(18, 20)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(102, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'playerCB
        '
        Me.playerCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.playerCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.playerCB.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.playerCB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.playerCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.playerCB.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playerCB.ForeColor = System.Drawing.Color.White
        Me.playerCB.FormattingEnabled = True
        Me.playerCB.Location = New System.Drawing.Point(313, 311)
        Me.playerCB.Margin = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.playerCB.Name = "playerCB"
        Me.playerCB.Size = New System.Drawing.Size(160, 23)
        Me.playerCB.TabIndex = 6
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.NameLabel.Location = New System.Drawing.Point(257, 314)
        Me.NameLabel.Margin = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(48, 18)
        Me.NameLabel.TabIndex = 7
        Me.NameLabel.Text = "NAME"
        '
        'sudokuTitle
        '
        Me.sudokuTitle.AutoSize = True
        Me.sudokuTitle.Font = New System.Drawing.Font("Impact", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sudokuTitle.ForeColor = System.Drawing.Color.White
        Me.sudokuTitle.Location = New System.Drawing.Point(211, 111)
        Me.sudokuTitle.Name = "sudokuTitle"
        Me.sudokuTitle.Size = New System.Drawing.Size(363, 117)
        Me.sudokuTitle.TabIndex = 8
        Me.sudokuTitle.Text = "SUDOKU"
        '
        'newPlayerLabel
        '
        Me.newPlayerLabel.AutoSize = True
        Me.newPlayerLabel.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newPlayerLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.newPlayerLabel.Location = New System.Drawing.Point(214, 352)
        Me.newPlayerLabel.Name = "newPlayerLabel"
        Me.newPlayerLabel.Size = New System.Drawing.Size(91, 18)
        Me.newPlayerLabel.TabIndex = 9
        Me.newPlayerLabel.Text = "NEW PLAYER"
        '
        'newNameTBox
        '
        Me.newNameTBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.newNameTBox.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newNameTBox.ForeColor = System.Drawing.Color.White
        Me.newNameTBox.Location = New System.Drawing.Point(313, 348)
        Me.newNameTBox.Margin = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.newNameTBox.Name = "newNameTBox"
        Me.newNameTBox.Size = New System.Drawing.Size(159, 23)
        Me.newNameTBox.TabIndex = 10
        '
        'addNameBtn
        '
        Me.addNameBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.addNameBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.addNameBtn.FlatAppearance.BorderSize = 2
        Me.addNameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addNameBtn.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addNameBtn.ForeColor = System.Drawing.Color.White
        Me.addNameBtn.Location = New System.Drawing.Point(493, 348)
        Me.addNameBtn.Name = "addNameBtn"
        Me.addNameBtn.Size = New System.Drawing.Size(56, 23)
        Me.addNameBtn.TabIndex = 11
        Me.addNameBtn.Text = "Add"
        Me.addNameBtn.UseVisualStyleBackColor = False
        '
        'nameLB
        '
        Me.nameLB.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.nameLB.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLB.ForeColor = System.Drawing.Color.White
        Me.nameLB.FormattingEnabled = True
        Me.nameLB.ItemHeight = 19
        Me.nameLB.Location = New System.Drawing.Point(186, 129)
        Me.nameLB.Name = "nameLB"
        Me.nameLB.Size = New System.Drawing.Size(175, 384)
        Me.nameLB.TabIndex = 12
        '
        'scoreLB
        '
        Me.scoreLB.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.scoreLB.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scoreLB.ForeColor = System.Drawing.Color.White
        Me.scoreLB.FormattingEnabled = True
        Me.scoreLB.ItemHeight = 19
        Me.scoreLB.Location = New System.Drawing.Point(388, 129)
        Me.scoreLB.Name = "scoreLB"
        Me.scoreLB.Size = New System.Drawing.Size(175, 384)
        Me.scoreLB.TabIndex = 13
        '
        'searchPlayerCB
        '
        Me.searchPlayerCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.searchPlayerCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.searchPlayerCB.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.searchPlayerCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchPlayerCB.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchPlayerCB.ForeColor = System.Drawing.Color.White
        Me.searchPlayerCB.FormattingEnabled = True
        Me.searchPlayerCB.Location = New System.Drawing.Point(193, 88)
        Me.searchPlayerCB.Name = "searchPlayerCB"
        Me.searchPlayerCB.Size = New System.Drawing.Size(120, 26)
        Me.searchPlayerCB.TabIndex = 14
        '
        'showStatsBtn
        '
        Me.showStatsBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.showStatsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.showStatsBtn.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showStatsBtn.ForeColor = System.Drawing.Color.White
        Me.showStatsBtn.Location = New System.Drawing.Point(451, 549)
        Me.showStatsBtn.Name = "showStatsBtn"
        Me.showStatsBtn.Size = New System.Drawing.Size(112, 33)
        Me.showStatsBtn.TabIndex = 15
        Me.showStatsBtn.Text = "Show stats"
        Me.showStatsBtn.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(634, 667)
        Me.Controls.Add(Me.showStatsBtn)
        Me.Controls.Add(Me.searchPlayerCB)
        Me.Controls.Add(Me.scoreLB)
        Me.Controls.Add(Me.nameLB)
        Me.Controls.Add(Me.addNameBtn)
        Me.Controls.Add(Me.newNameTBox)
        Me.Controls.Add(Me.newPlayerLabel)
        Me.Controls.Add(Me.sudokuTitle)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.playerCB)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.NewGameBtn)
        Me.Controls.Add(Me.SudokuLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form1"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SUDOKU"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SudokuLabel As Label
    Friend WithEvents NewGameBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents homeBtn As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents scoreBtn As Button
    Friend WithEvents quitGameBtn As Button
    Friend WithEvents playerCB As ComboBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents sudokuTitle As Label
    Friend WithEvents newPlayerLabel As Label
    Friend WithEvents newNameTBox As TextBox
    Friend WithEvents addNameBtn As Button
    Friend WithEvents nameLB As ListBox
    Friend WithEvents scoreLB As ListBox
    Friend WithEvents searchPlayerCB As ComboBox
    Friend WithEvents showStatsBtn As Button
End Class
