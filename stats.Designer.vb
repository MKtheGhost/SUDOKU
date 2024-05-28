<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stats
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
        Me.bestTimeLabel = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.returnBtn = New System.Windows.Forms.Button()
        Me.bestTimeLb = New System.Windows.Forms.Label()
        Me.nbGameLb = New System.Windows.Forms.Label()
        Me.totalTimeLb = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bestTimeLabel
        '
        Me.bestTimeLabel.AutoSize = True
        Me.bestTimeLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.bestTimeLabel.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bestTimeLabel.ForeColor = System.Drawing.Color.White
        Me.bestTimeLabel.Location = New System.Drawing.Point(73, 137)
        Me.bestTimeLabel.Name = "bestTimeLabel"
        Me.bestTimeLabel.Size = New System.Drawing.Size(113, 26)
        Me.bestTimeLabel.TabIndex = 0
        Me.bestTimeLabel.Text = "Best time : "
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.ForeColor = System.Drawing.Color.White
        Me.nameLabel.Location = New System.Drawing.Point(74, 79)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(62, 26)
        Me.nameLabel.TabIndex = 1
        Me.nameLabel.Text = "name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(73, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Number of game played :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(73, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 26)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "total time played :"
        '
        'returnBtn
        '
        Me.returnBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.returnBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.returnBtn.FlatAppearance.BorderSize = 2
        Me.returnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.returnBtn.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.returnBtn.ForeColor = System.Drawing.Color.White
        Me.returnBtn.Location = New System.Drawing.Point(338, 293)
        Me.returnBtn.Name = "returnBtn"
        Me.returnBtn.Size = New System.Drawing.Size(112, 42)
        Me.returnBtn.TabIndex = 4
        Me.returnBtn.Text = "return"
        Me.returnBtn.UseVisualStyleBackColor = False
        '
        'bestTimeLb
        '
        Me.bestTimeLb.AutoSize = True
        Me.bestTimeLb.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bestTimeLb.ForeColor = System.Drawing.Color.White
        Me.bestTimeLb.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bestTimeLb.Location = New System.Drawing.Point(371, 137)
        Me.bestTimeLb.Name = "bestTimeLb"
        Me.bestTimeLb.Size = New System.Drawing.Size(69, 26)
        Me.bestTimeLb.TabIndex = 5
        Me.bestTimeLb.Text = "Label3"
        Me.bestTimeLb.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nbGameLb
        '
        Me.nbGameLb.AutoSize = True
        Me.nbGameLb.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nbGameLb.ForeColor = System.Drawing.Color.White
        Me.nbGameLb.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.nbGameLb.Location = New System.Drawing.Point(371, 179)
        Me.nbGameLb.Name = "nbGameLb"
        Me.nbGameLb.Size = New System.Drawing.Size(69, 26)
        Me.nbGameLb.TabIndex = 6
        Me.nbGameLb.Text = "Label4"
        Me.nbGameLb.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'totalTimeLb
        '
        Me.totalTimeLb.AutoSize = True
        Me.totalTimeLb.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalTimeLb.ForeColor = System.Drawing.Color.White
        Me.totalTimeLb.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.totalTimeLb.Location = New System.Drawing.Point(371, 220)
        Me.totalTimeLb.Name = "totalTimeLb"
        Me.totalTimeLb.Size = New System.Drawing.Size(69, 26)
        Me.totalTimeLb.TabIndex = 7
        Me.totalTimeLb.Text = "Label5"
        Me.totalTimeLb.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'stats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(518, 387)
        Me.Controls.Add(Me.totalTimeLb)
        Me.Controls.Add(Me.nbGameLb)
        Me.Controls.Add(Me.bestTimeLb)
        Me.Controls.Add(Me.returnBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.bestTimeLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "stats"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "stats"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bestTimeLabel As Label
    Friend WithEvents nameLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents returnBtn As Button
    Friend WithEvents bestTimeLb As Label
    Friend WithEvents nbGameLb As Label
    Friend WithEvents totalTimeLb As Label
End Class
