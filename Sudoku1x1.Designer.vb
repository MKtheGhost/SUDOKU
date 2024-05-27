<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sudoku1x1
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Case1_4 = New System.Windows.Forms.TextBox()
        Me.Case1_5 = New System.Windows.Forms.TextBox()
        Me.Case1_6 = New System.Windows.Forms.TextBox()
        Me.Case1_1 = New System.Windows.Forms.TextBox()
        Me.Case1_2 = New System.Windows.Forms.TextBox()
        Me.Case1_3 = New System.Windows.Forms.TextBox()
        Me.Case1_7 = New System.Windows.Forms.TextBox()
        Me.Case1_8 = New System.Windows.Forms.TextBox()
        Me.Case1_9 = New System.Windows.Forms.TextBox()
        Me.giveUpButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel3)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel4)
        Me.FlowLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(115, 146)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(437, 409)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.Panel1)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 397)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(8, 8)
        Me.FlowLayoutPanel2.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(429, 133)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Case1_6)
        Me.Panel2.Controls.Add(Me.Case1_5)
        Me.Panel2.Controls.Add(Me.Case1_4)
        Me.Panel2.Location = New System.Drawing.Point(0, 129)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(427, 129)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Case1_3)
        Me.Panel3.Controls.Add(Me.Case1_2)
        Me.Panel3.Controls.Add(Me.Case1_1)
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(424, 123)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Case1_9)
        Me.Panel4.Controls.Add(Me.Case1_8)
        Me.Panel4.Controls.Add(Me.Case1_7)
        Me.Panel4.Location = New System.Drawing.Point(3, 261)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(424, 130)
        Me.Panel4.TabIndex = 3
        '
        'Case1_4
        '
        Me.Case1_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case1_4.Font = New System.Drawing.Font("Calibri", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case1_4.ForeColor = System.Drawing.Color.White
        Me.Case1_4.Location = New System.Drawing.Point(19, 5)
        Me.Case1_4.MaxLength = 1
        Me.Case1_4.Multiline = True
        Me.Case1_4.Name = "Case1_4"
        Me.Case1_4.Size = New System.Drawing.Size(120, 120)
        Me.Case1_4.TabIndex = 0
        Me.Case1_4.Text = "4"
        Me.Case1_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case1_5
        '
        Me.Case1_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case1_5.Font = New System.Drawing.Font("Calibri", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case1_5.ForeColor = System.Drawing.Color.White
        Me.Case1_5.Location = New System.Drawing.Point(145, 5)
        Me.Case1_5.MaxLength = 1
        Me.Case1_5.Multiline = True
        Me.Case1_5.Name = "Case1_5"
        Me.Case1_5.Size = New System.Drawing.Size(120, 120)
        Me.Case1_5.TabIndex = 1
        Me.Case1_5.Text = "5"
        Me.Case1_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case1_6
        '
        Me.Case1_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case1_6.Font = New System.Drawing.Font("Calibri", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case1_6.ForeColor = System.Drawing.Color.White
        Me.Case1_6.Location = New System.Drawing.Point(271, 5)
        Me.Case1_6.MaxLength = 1
        Me.Case1_6.Multiline = True
        Me.Case1_6.Name = "Case1_6"
        Me.Case1_6.Size = New System.Drawing.Size(120, 120)
        Me.Case1_6.TabIndex = 2
        Me.Case1_6.Text = "6"
        Me.Case1_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case1_1
        '
        Me.Case1_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case1_1.Font = New System.Drawing.Font("Calibri", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case1_1.ForeColor = System.Drawing.Color.White
        Me.Case1_1.Location = New System.Drawing.Point(16, 3)
        Me.Case1_1.MaxLength = 1
        Me.Case1_1.Multiline = True
        Me.Case1_1.Name = "Case1_1"
        Me.Case1_1.Size = New System.Drawing.Size(120, 120)
        Me.Case1_1.TabIndex = 1
        Me.Case1_1.Text = "1"
        Me.Case1_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case1_2
        '
        Me.Case1_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case1_2.Font = New System.Drawing.Font("Calibri", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case1_2.ForeColor = System.Drawing.Color.White
        Me.Case1_2.Location = New System.Drawing.Point(142, 3)
        Me.Case1_2.MaxLength = 1
        Me.Case1_2.Multiline = True
        Me.Case1_2.Name = "Case1_2"
        Me.Case1_2.Size = New System.Drawing.Size(120, 120)
        Me.Case1_2.TabIndex = 2
        Me.Case1_2.Text = "2"
        Me.Case1_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case1_3
        '
        Me.Case1_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case1_3.Font = New System.Drawing.Font("Calibri", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case1_3.ForeColor = System.Drawing.Color.White
        Me.Case1_3.Location = New System.Drawing.Point(268, 3)
        Me.Case1_3.MaxLength = 1
        Me.Case1_3.Multiline = True
        Me.Case1_3.Name = "Case1_3"
        Me.Case1_3.Size = New System.Drawing.Size(120, 120)
        Me.Case1_3.TabIndex = 3
        Me.Case1_3.Text = "3"
        Me.Case1_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case1_7
        '
        Me.Case1_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case1_7.Font = New System.Drawing.Font("Calibri", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case1_7.ForeColor = System.Drawing.Color.White
        Me.Case1_7.Location = New System.Drawing.Point(16, -1)
        Me.Case1_7.MaxLength = 1
        Me.Case1_7.Multiline = True
        Me.Case1_7.Name = "Case1_7"
        Me.Case1_7.Size = New System.Drawing.Size(120, 120)
        Me.Case1_7.TabIndex = 1
        Me.Case1_7.Text = "7"
        Me.Case1_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case1_8
        '
        Me.Case1_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case1_8.Font = New System.Drawing.Font("Calibri", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case1_8.ForeColor = System.Drawing.Color.White
        Me.Case1_8.Location = New System.Drawing.Point(142, -1)
        Me.Case1_8.MaxLength = 1
        Me.Case1_8.Multiline = True
        Me.Case1_8.Name = "Case1_8"
        Me.Case1_8.Size = New System.Drawing.Size(120, 120)
        Me.Case1_8.TabIndex = 2
        Me.Case1_8.Text = "8"
        Me.Case1_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case1_9
        '
        Me.Case1_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case1_9.Font = New System.Drawing.Font("Calibri", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case1_9.ForeColor = System.Drawing.Color.White
        Me.Case1_9.Location = New System.Drawing.Point(268, -1)
        Me.Case1_9.MaxLength = 1
        Me.Case1_9.Multiline = True
        Me.Case1_9.Name = "Case1_9"
        Me.Case1_9.Size = New System.Drawing.Size(120, 120)
        Me.Case1_9.TabIndex = 3
        Me.Case1_9.Text = "9"
        Me.Case1_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'giveUpButton
        '
        Me.giveUpButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.giveUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.giveUpButton.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.giveUpButton.ForeColor = System.Drawing.Color.White
        Me.giveUpButton.Location = New System.Drawing.Point(425, 561)
        Me.giveUpButton.Name = "giveUpButton"
        Me.giveUpButton.Size = New System.Drawing.Size(81, 33)
        Me.giveUpButton.TabIndex = 4
        Me.giveUpButton.Text = "Give Up"
        Me.giveUpButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(115, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(118, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Label2"
        '
        'Sudoku1x1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(638, 705)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.giveUpButton)
        Me.Name = "Sudoku1x1"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sudoku"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Case1_6 As TextBox
    Friend WithEvents Case1_5 As TextBox
    Friend WithEvents Case1_4 As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Case1_3 As TextBox
    Friend WithEvents Case1_2 As TextBox
    Friend WithEvents Case1_1 As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Case1_9 As TextBox
    Friend WithEvents Case1_8 As TextBox
    Friend WithEvents Case1_7 As TextBox
    Friend WithEvents giveUpButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
