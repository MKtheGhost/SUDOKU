<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sudoku3X3
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
        Me.giveUpButton = New System.Windows.Forms.Button()
        Me.Case1_1 = New System.Windows.Forms.TextBox()
        Me.Case1_2 = New System.Windows.Forms.TextBox()
        Me.Case1_3 = New System.Windows.Forms.TextBox()
        Me.Case2_1 = New System.Windows.Forms.TextBox()
        Me.Case2_2 = New System.Windows.Forms.TextBox()
        Me.Case2_3 = New System.Windows.Forms.TextBox()
        Me.Case3_1 = New System.Windows.Forms.TextBox()
        Me.Case3_2 = New System.Windows.Forms.TextBox()
        Me.Case3_3 = New System.Windows.Forms.TextBox()
        Me.Case1_4 = New System.Windows.Forms.TextBox()
        Me.Case2_4 = New System.Windows.Forms.TextBox()
        Me.Case3_4 = New System.Windows.Forms.TextBox()
        Me.Case1_5 = New System.Windows.Forms.TextBox()
        Me.Case2_5 = New System.Windows.Forms.TextBox()
        Me.Case3_5 = New System.Windows.Forms.TextBox()
        Me.Case1_6 = New System.Windows.Forms.TextBox()
        Me.Case2_6 = New System.Windows.Forms.TextBox()
        Me.Case3_6 = New System.Windows.Forms.TextBox()
        Me.Case1_7 = New System.Windows.Forms.TextBox()
        Me.Case2_7 = New System.Windows.Forms.TextBox()
        Me.Case3_7 = New System.Windows.Forms.TextBox()
        Me.Case1_8 = New System.Windows.Forms.TextBox()
        Me.Case2_8 = New System.Windows.Forms.TextBox()
        Me.Case3_8 = New System.Windows.Forms.TextBox()
        Me.Case1_9 = New System.Windows.Forms.TextBox()
        Me.Case2_9 = New System.Windows.Forms.TextBox()
        Me.Case3_9 = New System.Windows.Forms.TextBox()
        Me.Case6_9 = New System.Windows.Forms.TextBox()
        Me.Case5_9 = New System.Windows.Forms.TextBox()
        Me.Case4_9 = New System.Windows.Forms.TextBox()
        Me.Case6_8 = New System.Windows.Forms.TextBox()
        Me.Case5_8 = New System.Windows.Forms.TextBox()
        Me.Case4_8 = New System.Windows.Forms.TextBox()
        Me.Case6_7 = New System.Windows.Forms.TextBox()
        Me.Case5_7 = New System.Windows.Forms.TextBox()
        Me.Case4_7 = New System.Windows.Forms.TextBox()
        Me.Case6_6 = New System.Windows.Forms.TextBox()
        Me.Case5_6 = New System.Windows.Forms.TextBox()
        Me.Case4_6 = New System.Windows.Forms.TextBox()
        Me.Case6_5 = New System.Windows.Forms.TextBox()
        Me.Case5_5 = New System.Windows.Forms.TextBox()
        Me.Case4_5 = New System.Windows.Forms.TextBox()
        Me.Case6_4 = New System.Windows.Forms.TextBox()
        Me.Case5_4 = New System.Windows.Forms.TextBox()
        Me.Case4_4 = New System.Windows.Forms.TextBox()
        Me.Case6_3 = New System.Windows.Forms.TextBox()
        Me.Case6_2 = New System.Windows.Forms.TextBox()
        Me.Case6_1 = New System.Windows.Forms.TextBox()
        Me.Case5_3 = New System.Windows.Forms.TextBox()
        Me.Case5_2 = New System.Windows.Forms.TextBox()
        Me.Case5_1 = New System.Windows.Forms.TextBox()
        Me.Case4_3 = New System.Windows.Forms.TextBox()
        Me.Case4_2 = New System.Windows.Forms.TextBox()
        Me.Case4_1 = New System.Windows.Forms.TextBox()
        Me.Case9_9 = New System.Windows.Forms.TextBox()
        Me.Case8_9 = New System.Windows.Forms.TextBox()
        Me.Case7_9 = New System.Windows.Forms.TextBox()
        Me.Case9_8 = New System.Windows.Forms.TextBox()
        Me.Case8_8 = New System.Windows.Forms.TextBox()
        Me.Case7_8 = New System.Windows.Forms.TextBox()
        Me.Case9_7 = New System.Windows.Forms.TextBox()
        Me.Case8_7 = New System.Windows.Forms.TextBox()
        Me.Case7_7 = New System.Windows.Forms.TextBox()
        Me.Case9_6 = New System.Windows.Forms.TextBox()
        Me.Case8_6 = New System.Windows.Forms.TextBox()
        Me.Case7_6 = New System.Windows.Forms.TextBox()
        Me.Case9_5 = New System.Windows.Forms.TextBox()
        Me.Case8_5 = New System.Windows.Forms.TextBox()
        Me.Case7_5 = New System.Windows.Forms.TextBox()
        Me.Case9_4 = New System.Windows.Forms.TextBox()
        Me.Case8_4 = New System.Windows.Forms.TextBox()
        Me.Case7_4 = New System.Windows.Forms.TextBox()
        Me.Case9_3 = New System.Windows.Forms.TextBox()
        Me.Case9_2 = New System.Windows.Forms.TextBox()
        Me.Case9_1 = New System.Windows.Forms.TextBox()
        Me.Case8_3 = New System.Windows.Forms.TextBox()
        Me.Case8_2 = New System.Windows.Forms.TextBox()
        Me.Case8_1 = New System.Windows.Forms.TextBox()
        Me.Case7_3 = New System.Windows.Forms.TextBox()
        Me.Case7_2 = New System.Windows.Forms.TextBox()
        Me.Case7_1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'giveUpButton
        '
        Me.giveUpButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.giveUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.giveUpButton.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.giveUpButton.ForeColor = System.Drawing.Color.White
        Me.giveUpButton.Location = New System.Drawing.Point(805, 1065)
        Me.giveUpButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.giveUpButton.Name = "giveUpButton"
        Me.giveUpButton.Size = New System.Drawing.Size(193, 63)
        Me.giveUpButton.TabIndex = 5
        Me.giveUpButton.Text = "END GAME"
        Me.giveUpButton.UseVisualStyleBackColor = False
        '
        'Case1_1
        '
        Me.Case1_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case1_1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case1_1.ForeColor = System.Drawing.Color.White
        Me.Case1_1.Location = New System.Drawing.Point(216, 288)
        Me.Case1_1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case1_1.Multiline = True
        Me.Case1_1.Name = "Case1_1"
        Me.Case1_1.Size = New System.Drawing.Size(68, 66)
        Me.Case1_1.TabIndex = 7
        Me.Case1_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case1_2
        '
        Me.Case1_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case1_2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case1_2.ForeColor = System.Drawing.Color.White
        Me.Case1_2.Location = New System.Drawing.Point(300, 288)
        Me.Case1_2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case1_2.Multiline = True
        Me.Case1_2.Name = "Case1_2"
        Me.Case1_2.Size = New System.Drawing.Size(68, 66)
        Me.Case1_2.TabIndex = 8
        Me.Case1_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case1_3
        '
        Me.Case1_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case1_3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case1_3.ForeColor = System.Drawing.Color.White
        Me.Case1_3.Location = New System.Drawing.Point(384, 288)
        Me.Case1_3.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case1_3.Multiline = True
        Me.Case1_3.Name = "Case1_3"
        Me.Case1_3.Size = New System.Drawing.Size(68, 66)
        Me.Case1_3.TabIndex = 9
        Me.Case1_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case2_1
        '
        Me.Case2_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case2_1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case2_1.ForeColor = System.Drawing.Color.White
        Me.Case2_1.Location = New System.Drawing.Point(216, 369)
        Me.Case2_1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case2_1.Multiline = True
        Me.Case2_1.Name = "Case2_1"
        Me.Case2_1.Size = New System.Drawing.Size(68, 66)
        Me.Case2_1.TabIndex = 10
        Me.Case2_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case2_2
        '
        Me.Case2_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case2_2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case2_2.ForeColor = System.Drawing.Color.White
        Me.Case2_2.Location = New System.Drawing.Point(300, 369)
        Me.Case2_2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case2_2.Multiline = True
        Me.Case2_2.Name = "Case2_2"
        Me.Case2_2.Size = New System.Drawing.Size(68, 66)
        Me.Case2_2.TabIndex = 11
        Me.Case2_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case2_3
        '
        Me.Case2_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case2_3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case2_3.ForeColor = System.Drawing.Color.White
        Me.Case2_3.Location = New System.Drawing.Point(384, 369)
        Me.Case2_3.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case2_3.Multiline = True
        Me.Case2_3.Name = "Case2_3"
        Me.Case2_3.Size = New System.Drawing.Size(68, 66)
        Me.Case2_3.TabIndex = 12
        Me.Case2_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case3_1
        '
        Me.Case3_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case3_1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case3_1.ForeColor = System.Drawing.Color.White
        Me.Case3_1.Location = New System.Drawing.Point(216, 450)
        Me.Case3_1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case3_1.Multiline = True
        Me.Case3_1.Name = "Case3_1"
        Me.Case3_1.Size = New System.Drawing.Size(68, 66)
        Me.Case3_1.TabIndex = 13
        Me.Case3_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case3_2
        '
        Me.Case3_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case3_2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case3_2.ForeColor = System.Drawing.Color.White
        Me.Case3_2.Location = New System.Drawing.Point(300, 450)
        Me.Case3_2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case3_2.Multiline = True
        Me.Case3_2.Name = "Case3_2"
        Me.Case3_2.Size = New System.Drawing.Size(68, 66)
        Me.Case3_2.TabIndex = 14
        Me.Case3_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case3_3
        '
        Me.Case3_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case3_3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case3_3.ForeColor = System.Drawing.Color.White
        Me.Case3_3.Location = New System.Drawing.Point(384, 450)
        Me.Case3_3.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case3_3.Multiline = True
        Me.Case3_3.Name = "Case3_3"
        Me.Case3_3.Size = New System.Drawing.Size(68, 66)
        Me.Case3_3.TabIndex = 15
        Me.Case3_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case1_4
        '
        Me.Case1_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case1_4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case1_4.ForeColor = System.Drawing.Color.White
        Me.Case1_4.Location = New System.Drawing.Point(488, 288)
        Me.Case1_4.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case1_4.Multiline = True
        Me.Case1_4.Name = "Case1_4"
        Me.Case1_4.Size = New System.Drawing.Size(68, 66)
        Me.Case1_4.TabIndex = 16
        Me.Case1_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case2_4
        '
        Me.Case2_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case2_4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case2_4.ForeColor = System.Drawing.Color.White
        Me.Case2_4.Location = New System.Drawing.Point(488, 369)
        Me.Case2_4.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case2_4.Multiline = True
        Me.Case2_4.Name = "Case2_4"
        Me.Case2_4.Size = New System.Drawing.Size(68, 66)
        Me.Case2_4.TabIndex = 17
        Me.Case2_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case3_4
        '
        Me.Case3_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case3_4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case3_4.ForeColor = System.Drawing.Color.White
        Me.Case3_4.Location = New System.Drawing.Point(488, 450)
        Me.Case3_4.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case3_4.Multiline = True
        Me.Case3_4.Name = "Case3_4"
        Me.Case3_4.Size = New System.Drawing.Size(68, 66)
        Me.Case3_4.TabIndex = 18
        Me.Case3_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case1_5
        '
        Me.Case1_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case1_5.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case1_5.ForeColor = System.Drawing.Color.White
        Me.Case1_5.Location = New System.Drawing.Point(572, 288)
        Me.Case1_5.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case1_5.Multiline = True
        Me.Case1_5.Name = "Case1_5"
        Me.Case1_5.Size = New System.Drawing.Size(68, 66)
        Me.Case1_5.TabIndex = 19
        Me.Case1_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case2_5
        '
        Me.Case2_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case2_5.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case2_5.ForeColor = System.Drawing.Color.White
        Me.Case2_5.Location = New System.Drawing.Point(572, 369)
        Me.Case2_5.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case2_5.Multiline = True
        Me.Case2_5.Name = "Case2_5"
        Me.Case2_5.Size = New System.Drawing.Size(68, 66)
        Me.Case2_5.TabIndex = 20
        Me.Case2_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case3_5
        '
        Me.Case3_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case3_5.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case3_5.ForeColor = System.Drawing.Color.White
        Me.Case3_5.Location = New System.Drawing.Point(572, 450)
        Me.Case3_5.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case3_5.Multiline = True
        Me.Case3_5.Name = "Case3_5"
        Me.Case3_5.Size = New System.Drawing.Size(68, 66)
        Me.Case3_5.TabIndex = 21
        Me.Case3_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case1_6
        '
        Me.Case1_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case1_6.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case1_6.ForeColor = System.Drawing.Color.White
        Me.Case1_6.Location = New System.Drawing.Point(656, 288)
        Me.Case1_6.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case1_6.Multiline = True
        Me.Case1_6.Name = "Case1_6"
        Me.Case1_6.Size = New System.Drawing.Size(68, 66)
        Me.Case1_6.TabIndex = 22
        Me.Case1_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case2_6
        '
        Me.Case2_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case2_6.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case2_6.ForeColor = System.Drawing.Color.White
        Me.Case2_6.Location = New System.Drawing.Point(656, 369)
        Me.Case2_6.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case2_6.Multiline = True
        Me.Case2_6.Name = "Case2_6"
        Me.Case2_6.Size = New System.Drawing.Size(68, 66)
        Me.Case2_6.TabIndex = 23
        Me.Case2_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case3_6
        '
        Me.Case3_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case3_6.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case3_6.ForeColor = System.Drawing.Color.White
        Me.Case3_6.Location = New System.Drawing.Point(656, 450)
        Me.Case3_6.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case3_6.Multiline = True
        Me.Case3_6.Name = "Case3_6"
        Me.Case3_6.Size = New System.Drawing.Size(68, 66)
        Me.Case3_6.TabIndex = 24
        Me.Case3_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case1_7
        '
        Me.Case1_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case1_7.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case1_7.ForeColor = System.Drawing.Color.White
        Me.Case1_7.Location = New System.Drawing.Point(762, 288)
        Me.Case1_7.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case1_7.Multiline = True
        Me.Case1_7.Name = "Case1_7"
        Me.Case1_7.Size = New System.Drawing.Size(68, 66)
        Me.Case1_7.TabIndex = 25
        Me.Case1_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case2_7
        '
        Me.Case2_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case2_7.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case2_7.ForeColor = System.Drawing.Color.White
        Me.Case2_7.Location = New System.Drawing.Point(762, 369)
        Me.Case2_7.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case2_7.Multiline = True
        Me.Case2_7.Name = "Case2_7"
        Me.Case2_7.Size = New System.Drawing.Size(68, 66)
        Me.Case2_7.TabIndex = 26
        Me.Case2_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case3_7
        '
        Me.Case3_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case3_7.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case3_7.ForeColor = System.Drawing.Color.White
        Me.Case3_7.Location = New System.Drawing.Point(762, 450)
        Me.Case3_7.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case3_7.Multiline = True
        Me.Case3_7.Name = "Case3_7"
        Me.Case3_7.Size = New System.Drawing.Size(68, 66)
        Me.Case3_7.TabIndex = 27
        Me.Case3_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case1_8
        '
        Me.Case1_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case1_8.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case1_8.ForeColor = System.Drawing.Color.White
        Me.Case1_8.Location = New System.Drawing.Point(846, 288)
        Me.Case1_8.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case1_8.Multiline = True
        Me.Case1_8.Name = "Case1_8"
        Me.Case1_8.Size = New System.Drawing.Size(68, 66)
        Me.Case1_8.TabIndex = 28
        Me.Case1_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case2_8
        '
        Me.Case2_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case2_8.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case2_8.ForeColor = System.Drawing.Color.White
        Me.Case2_8.Location = New System.Drawing.Point(846, 369)
        Me.Case2_8.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case2_8.Multiline = True
        Me.Case2_8.Name = "Case2_8"
        Me.Case2_8.Size = New System.Drawing.Size(68, 66)
        Me.Case2_8.TabIndex = 29
        Me.Case2_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case3_8
        '
        Me.Case3_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case3_8.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case3_8.ForeColor = System.Drawing.Color.White
        Me.Case3_8.Location = New System.Drawing.Point(846, 450)
        Me.Case3_8.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case3_8.Multiline = True
        Me.Case3_8.Name = "Case3_8"
        Me.Case3_8.Size = New System.Drawing.Size(68, 66)
        Me.Case3_8.TabIndex = 30
        Me.Case3_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case1_9
        '
        Me.Case1_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case1_9.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case1_9.ForeColor = System.Drawing.Color.White
        Me.Case1_9.Location = New System.Drawing.Point(930, 288)
        Me.Case1_9.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case1_9.Multiline = True
        Me.Case1_9.Name = "Case1_9"
        Me.Case1_9.Size = New System.Drawing.Size(68, 66)
        Me.Case1_9.TabIndex = 31
        Me.Case1_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case2_9
        '
        Me.Case2_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case2_9.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case2_9.ForeColor = System.Drawing.Color.White
        Me.Case2_9.Location = New System.Drawing.Point(930, 369)
        Me.Case2_9.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case2_9.Multiline = True
        Me.Case2_9.Name = "Case2_9"
        Me.Case2_9.Size = New System.Drawing.Size(68, 66)
        Me.Case2_9.TabIndex = 32
        Me.Case2_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case3_9
        '
        Me.Case3_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case3_9.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case3_9.ForeColor = System.Drawing.Color.White
        Me.Case3_9.Location = New System.Drawing.Point(930, 450)
        Me.Case3_9.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case3_9.Multiline = True
        Me.Case3_9.Name = "Case3_9"
        Me.Case3_9.Size = New System.Drawing.Size(68, 66)
        Me.Case3_9.TabIndex = 33
        Me.Case3_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case6_9
        '
        Me.Case6_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case6_9.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case6_9.ForeColor = System.Drawing.Color.White
        Me.Case6_9.Location = New System.Drawing.Point(930, 710)
        Me.Case6_9.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case6_9.Multiline = True
        Me.Case6_9.Name = "Case6_9"
        Me.Case6_9.Size = New System.Drawing.Size(68, 66)
        Me.Case6_9.TabIndex = 60
        Me.Case6_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case5_9
        '
        Me.Case5_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case5_9.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case5_9.ForeColor = System.Drawing.Color.White
        Me.Case5_9.Location = New System.Drawing.Point(930, 629)
        Me.Case5_9.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case5_9.Multiline = True
        Me.Case5_9.Name = "Case5_9"
        Me.Case5_9.Size = New System.Drawing.Size(68, 66)
        Me.Case5_9.TabIndex = 59
        Me.Case5_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case4_9
        '
        Me.Case4_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case4_9.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case4_9.ForeColor = System.Drawing.Color.White
        Me.Case4_9.Location = New System.Drawing.Point(930, 548)
        Me.Case4_9.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case4_9.Multiline = True
        Me.Case4_9.Name = "Case4_9"
        Me.Case4_9.Size = New System.Drawing.Size(68, 66)
        Me.Case4_9.TabIndex = 58
        Me.Case4_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case6_8
        '
        Me.Case6_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case6_8.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case6_8.ForeColor = System.Drawing.Color.White
        Me.Case6_8.Location = New System.Drawing.Point(846, 710)
        Me.Case6_8.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case6_8.Multiline = True
        Me.Case6_8.Name = "Case6_8"
        Me.Case6_8.Size = New System.Drawing.Size(68, 66)
        Me.Case6_8.TabIndex = 57
        Me.Case6_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case5_8
        '
        Me.Case5_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case5_8.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case5_8.ForeColor = System.Drawing.Color.White
        Me.Case5_8.Location = New System.Drawing.Point(846, 629)
        Me.Case5_8.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case5_8.Multiline = True
        Me.Case5_8.Name = "Case5_8"
        Me.Case5_8.Size = New System.Drawing.Size(68, 66)
        Me.Case5_8.TabIndex = 56
        Me.Case5_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case4_8
        '
        Me.Case4_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case4_8.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case4_8.ForeColor = System.Drawing.Color.White
        Me.Case4_8.Location = New System.Drawing.Point(846, 548)
        Me.Case4_8.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case4_8.Multiline = True
        Me.Case4_8.Name = "Case4_8"
        Me.Case4_8.Size = New System.Drawing.Size(68, 66)
        Me.Case4_8.TabIndex = 55
        Me.Case4_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case6_7
        '
        Me.Case6_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case6_7.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case6_7.ForeColor = System.Drawing.Color.White
        Me.Case6_7.Location = New System.Drawing.Point(762, 710)
        Me.Case6_7.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case6_7.Multiline = True
        Me.Case6_7.Name = "Case6_7"
        Me.Case6_7.Size = New System.Drawing.Size(68, 66)
        Me.Case6_7.TabIndex = 54
        Me.Case6_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case5_7
        '
        Me.Case5_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case5_7.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case5_7.ForeColor = System.Drawing.Color.White
        Me.Case5_7.Location = New System.Drawing.Point(762, 629)
        Me.Case5_7.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case5_7.Multiline = True
        Me.Case5_7.Name = "Case5_7"
        Me.Case5_7.Size = New System.Drawing.Size(68, 66)
        Me.Case5_7.TabIndex = 53
        Me.Case5_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case4_7
        '
        Me.Case4_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case4_7.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case4_7.ForeColor = System.Drawing.Color.White
        Me.Case4_7.Location = New System.Drawing.Point(762, 548)
        Me.Case4_7.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case4_7.Multiline = True
        Me.Case4_7.Name = "Case4_7"
        Me.Case4_7.Size = New System.Drawing.Size(68, 66)
        Me.Case4_7.TabIndex = 52
        Me.Case4_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case6_6
        '
        Me.Case6_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case6_6.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case6_6.ForeColor = System.Drawing.Color.White
        Me.Case6_6.Location = New System.Drawing.Point(656, 710)
        Me.Case6_6.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case6_6.Multiline = True
        Me.Case6_6.Name = "Case6_6"
        Me.Case6_6.Size = New System.Drawing.Size(68, 66)
        Me.Case6_6.TabIndex = 51
        Me.Case6_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case5_6
        '
        Me.Case5_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case5_6.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case5_6.ForeColor = System.Drawing.Color.White
        Me.Case5_6.Location = New System.Drawing.Point(656, 629)
        Me.Case5_6.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case5_6.Multiline = True
        Me.Case5_6.Name = "Case5_6"
        Me.Case5_6.Size = New System.Drawing.Size(68, 66)
        Me.Case5_6.TabIndex = 50
        Me.Case5_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case4_6
        '
        Me.Case4_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case4_6.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case4_6.ForeColor = System.Drawing.Color.White
        Me.Case4_6.Location = New System.Drawing.Point(656, 548)
        Me.Case4_6.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case4_6.Multiline = True
        Me.Case4_6.Name = "Case4_6"
        Me.Case4_6.Size = New System.Drawing.Size(68, 66)
        Me.Case4_6.TabIndex = 49
        Me.Case4_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case6_5
        '
        Me.Case6_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case6_5.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case6_5.ForeColor = System.Drawing.Color.White
        Me.Case6_5.Location = New System.Drawing.Point(572, 710)
        Me.Case6_5.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case6_5.Multiline = True
        Me.Case6_5.Name = "Case6_5"
        Me.Case6_5.Size = New System.Drawing.Size(68, 66)
        Me.Case6_5.TabIndex = 48
        Me.Case6_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case5_5
        '
        Me.Case5_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case5_5.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case5_5.ForeColor = System.Drawing.Color.White
        Me.Case5_5.Location = New System.Drawing.Point(572, 629)
        Me.Case5_5.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case5_5.Multiline = True
        Me.Case5_5.Name = "Case5_5"
        Me.Case5_5.Size = New System.Drawing.Size(68, 66)
        Me.Case5_5.TabIndex = 47
        Me.Case5_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case4_5
        '
        Me.Case4_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case4_5.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case4_5.ForeColor = System.Drawing.Color.White
        Me.Case4_5.Location = New System.Drawing.Point(572, 548)
        Me.Case4_5.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case4_5.Multiline = True
        Me.Case4_5.Name = "Case4_5"
        Me.Case4_5.Size = New System.Drawing.Size(68, 66)
        Me.Case4_5.TabIndex = 46
        Me.Case4_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case6_4
        '
        Me.Case6_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case6_4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case6_4.ForeColor = System.Drawing.Color.White
        Me.Case6_4.Location = New System.Drawing.Point(488, 710)
        Me.Case6_4.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case6_4.Multiline = True
        Me.Case6_4.Name = "Case6_4"
        Me.Case6_4.Size = New System.Drawing.Size(68, 66)
        Me.Case6_4.TabIndex = 45
        Me.Case6_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case5_4
        '
        Me.Case5_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case5_4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case5_4.ForeColor = System.Drawing.Color.White
        Me.Case5_4.Location = New System.Drawing.Point(488, 629)
        Me.Case5_4.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case5_4.Multiline = True
        Me.Case5_4.Name = "Case5_4"
        Me.Case5_4.Size = New System.Drawing.Size(68, 66)
        Me.Case5_4.TabIndex = 44
        Me.Case5_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case4_4
        '
        Me.Case4_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case4_4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case4_4.ForeColor = System.Drawing.Color.White
        Me.Case4_4.Location = New System.Drawing.Point(488, 548)
        Me.Case4_4.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case4_4.Multiline = True
        Me.Case4_4.Name = "Case4_4"
        Me.Case4_4.Size = New System.Drawing.Size(68, 66)
        Me.Case4_4.TabIndex = 43
        Me.Case4_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case6_3
        '
        Me.Case6_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case6_3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case6_3.ForeColor = System.Drawing.Color.White
        Me.Case6_3.Location = New System.Drawing.Point(384, 710)
        Me.Case6_3.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case6_3.Multiline = True
        Me.Case6_3.Name = "Case6_3"
        Me.Case6_3.Size = New System.Drawing.Size(68, 66)
        Me.Case6_3.TabIndex = 42
        Me.Case6_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case6_2
        '
        Me.Case6_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case6_2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case6_2.ForeColor = System.Drawing.Color.White
        Me.Case6_2.Location = New System.Drawing.Point(300, 710)
        Me.Case6_2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case6_2.Multiline = True
        Me.Case6_2.Name = "Case6_2"
        Me.Case6_2.Size = New System.Drawing.Size(68, 66)
        Me.Case6_2.TabIndex = 41
        Me.Case6_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case6_1
        '
        Me.Case6_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case6_1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case6_1.ForeColor = System.Drawing.Color.White
        Me.Case6_1.Location = New System.Drawing.Point(216, 710)
        Me.Case6_1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case6_1.Multiline = True
        Me.Case6_1.Name = "Case6_1"
        Me.Case6_1.Size = New System.Drawing.Size(68, 66)
        Me.Case6_1.TabIndex = 40
        Me.Case6_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case5_3
        '
        Me.Case5_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case5_3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case5_3.ForeColor = System.Drawing.Color.White
        Me.Case5_3.Location = New System.Drawing.Point(384, 629)
        Me.Case5_3.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case5_3.Multiline = True
        Me.Case5_3.Name = "Case5_3"
        Me.Case5_3.Size = New System.Drawing.Size(68, 66)
        Me.Case5_3.TabIndex = 39
        Me.Case5_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case5_2
        '
        Me.Case5_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case5_2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case5_2.ForeColor = System.Drawing.Color.White
        Me.Case5_2.Location = New System.Drawing.Point(300, 629)
        Me.Case5_2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case5_2.Multiline = True
        Me.Case5_2.Name = "Case5_2"
        Me.Case5_2.Size = New System.Drawing.Size(68, 66)
        Me.Case5_2.TabIndex = 38
        Me.Case5_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case5_1
        '
        Me.Case5_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case5_1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case5_1.ForeColor = System.Drawing.Color.White
        Me.Case5_1.Location = New System.Drawing.Point(216, 629)
        Me.Case5_1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case5_1.Multiline = True
        Me.Case5_1.Name = "Case5_1"
        Me.Case5_1.Size = New System.Drawing.Size(68, 66)
        Me.Case5_1.TabIndex = 37
        Me.Case5_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case4_3
        '
        Me.Case4_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case4_3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case4_3.ForeColor = System.Drawing.Color.White
        Me.Case4_3.Location = New System.Drawing.Point(384, 548)
        Me.Case4_3.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case4_3.Multiline = True
        Me.Case4_3.Name = "Case4_3"
        Me.Case4_3.Size = New System.Drawing.Size(68, 66)
        Me.Case4_3.TabIndex = 36
        Me.Case4_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case4_2
        '
        Me.Case4_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case4_2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case4_2.ForeColor = System.Drawing.Color.White
        Me.Case4_2.Location = New System.Drawing.Point(300, 548)
        Me.Case4_2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case4_2.Multiline = True
        Me.Case4_2.Name = "Case4_2"
        Me.Case4_2.Size = New System.Drawing.Size(68, 66)
        Me.Case4_2.TabIndex = 35
        Me.Case4_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case4_1
        '
        Me.Case4_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case4_1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case4_1.ForeColor = System.Drawing.Color.White
        Me.Case4_1.Location = New System.Drawing.Point(216, 548)
        Me.Case4_1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case4_1.Multiline = True
        Me.Case4_1.Name = "Case4_1"
        Me.Case4_1.Size = New System.Drawing.Size(68, 66)
        Me.Case4_1.TabIndex = 34
        Me.Case4_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case9_9
        '
        Me.Case9_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case9_9.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case9_9.ForeColor = System.Drawing.Color.White
        Me.Case9_9.Location = New System.Drawing.Point(930, 971)
        Me.Case9_9.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case9_9.Multiline = True
        Me.Case9_9.Name = "Case9_9"
        Me.Case9_9.Size = New System.Drawing.Size(68, 66)
        Me.Case9_9.TabIndex = 87
        Me.Case9_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case8_9
        '
        Me.Case8_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case8_9.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case8_9.ForeColor = System.Drawing.Color.White
        Me.Case8_9.Location = New System.Drawing.Point(930, 890)
        Me.Case8_9.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case8_9.Multiline = True
        Me.Case8_9.Name = "Case8_9"
        Me.Case8_9.Size = New System.Drawing.Size(68, 66)
        Me.Case8_9.TabIndex = 86
        Me.Case8_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case7_9
        '
        Me.Case7_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case7_9.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case7_9.ForeColor = System.Drawing.Color.White
        Me.Case7_9.Location = New System.Drawing.Point(930, 810)
        Me.Case7_9.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case7_9.Multiline = True
        Me.Case7_9.Name = "Case7_9"
        Me.Case7_9.Size = New System.Drawing.Size(68, 66)
        Me.Case7_9.TabIndex = 85
        Me.Case7_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case9_8
        '
        Me.Case9_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case9_8.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case9_8.ForeColor = System.Drawing.Color.White
        Me.Case9_8.Location = New System.Drawing.Point(846, 971)
        Me.Case9_8.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case9_8.Multiline = True
        Me.Case9_8.Name = "Case9_8"
        Me.Case9_8.Size = New System.Drawing.Size(68, 66)
        Me.Case9_8.TabIndex = 84
        Me.Case9_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case8_8
        '
        Me.Case8_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case8_8.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case8_8.ForeColor = System.Drawing.Color.White
        Me.Case8_8.Location = New System.Drawing.Point(846, 890)
        Me.Case8_8.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case8_8.Multiline = True
        Me.Case8_8.Name = "Case8_8"
        Me.Case8_8.Size = New System.Drawing.Size(68, 66)
        Me.Case8_8.TabIndex = 83
        Me.Case8_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case7_8
        '
        Me.Case7_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case7_8.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case7_8.ForeColor = System.Drawing.Color.White
        Me.Case7_8.Location = New System.Drawing.Point(846, 810)
        Me.Case7_8.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case7_8.Multiline = True
        Me.Case7_8.Name = "Case7_8"
        Me.Case7_8.Size = New System.Drawing.Size(68, 66)
        Me.Case7_8.TabIndex = 82
        Me.Case7_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case9_7
        '
        Me.Case9_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case9_7.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case9_7.ForeColor = System.Drawing.Color.White
        Me.Case9_7.Location = New System.Drawing.Point(762, 971)
        Me.Case9_7.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case9_7.Multiline = True
        Me.Case9_7.Name = "Case9_7"
        Me.Case9_7.Size = New System.Drawing.Size(68, 66)
        Me.Case9_7.TabIndex = 81
        Me.Case9_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case8_7
        '
        Me.Case8_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case8_7.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case8_7.ForeColor = System.Drawing.Color.White
        Me.Case8_7.Location = New System.Drawing.Point(762, 890)
        Me.Case8_7.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case8_7.Multiline = True
        Me.Case8_7.Name = "Case8_7"
        Me.Case8_7.Size = New System.Drawing.Size(68, 66)
        Me.Case8_7.TabIndex = 80
        Me.Case8_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case7_7
        '
        Me.Case7_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case7_7.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case7_7.ForeColor = System.Drawing.Color.White
        Me.Case7_7.Location = New System.Drawing.Point(762, 810)
        Me.Case7_7.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case7_7.Multiline = True
        Me.Case7_7.Name = "Case7_7"
        Me.Case7_7.Size = New System.Drawing.Size(68, 66)
        Me.Case7_7.TabIndex = 79
        Me.Case7_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case9_6
        '
        Me.Case9_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case9_6.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case9_6.ForeColor = System.Drawing.Color.White
        Me.Case9_6.Location = New System.Drawing.Point(656, 971)
        Me.Case9_6.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case9_6.Multiline = True
        Me.Case9_6.Name = "Case9_6"
        Me.Case9_6.Size = New System.Drawing.Size(68, 66)
        Me.Case9_6.TabIndex = 78
        Me.Case9_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case8_6
        '
        Me.Case8_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case8_6.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case8_6.ForeColor = System.Drawing.Color.White
        Me.Case8_6.Location = New System.Drawing.Point(656, 890)
        Me.Case8_6.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case8_6.Multiline = True
        Me.Case8_6.Name = "Case8_6"
        Me.Case8_6.Size = New System.Drawing.Size(68, 66)
        Me.Case8_6.TabIndex = 77
        Me.Case8_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case7_6
        '
        Me.Case7_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case7_6.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case7_6.ForeColor = System.Drawing.Color.White
        Me.Case7_6.Location = New System.Drawing.Point(656, 810)
        Me.Case7_6.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case7_6.Multiline = True
        Me.Case7_6.Name = "Case7_6"
        Me.Case7_6.Size = New System.Drawing.Size(68, 66)
        Me.Case7_6.TabIndex = 76
        Me.Case7_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case9_5
        '
        Me.Case9_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case9_5.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case9_5.ForeColor = System.Drawing.Color.White
        Me.Case9_5.Location = New System.Drawing.Point(572, 971)
        Me.Case9_5.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case9_5.Multiline = True
        Me.Case9_5.Name = "Case9_5"
        Me.Case9_5.Size = New System.Drawing.Size(68, 66)
        Me.Case9_5.TabIndex = 75
        Me.Case9_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case8_5
        '
        Me.Case8_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case8_5.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case8_5.ForeColor = System.Drawing.Color.White
        Me.Case8_5.Location = New System.Drawing.Point(572, 890)
        Me.Case8_5.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case8_5.Multiline = True
        Me.Case8_5.Name = "Case8_5"
        Me.Case8_5.Size = New System.Drawing.Size(68, 66)
        Me.Case8_5.TabIndex = 74
        Me.Case8_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case7_5
        '
        Me.Case7_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case7_5.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case7_5.ForeColor = System.Drawing.Color.White
        Me.Case7_5.Location = New System.Drawing.Point(572, 810)
        Me.Case7_5.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case7_5.Multiline = True
        Me.Case7_5.Name = "Case7_5"
        Me.Case7_5.Size = New System.Drawing.Size(68, 66)
        Me.Case7_5.TabIndex = 73
        Me.Case7_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case9_4
        '
        Me.Case9_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case9_4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case9_4.ForeColor = System.Drawing.Color.White
        Me.Case9_4.Location = New System.Drawing.Point(488, 971)
        Me.Case9_4.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case9_4.Multiline = True
        Me.Case9_4.Name = "Case9_4"
        Me.Case9_4.Size = New System.Drawing.Size(68, 66)
        Me.Case9_4.TabIndex = 72
        Me.Case9_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case8_4
        '
        Me.Case8_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case8_4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case8_4.ForeColor = System.Drawing.Color.White
        Me.Case8_4.Location = New System.Drawing.Point(488, 890)
        Me.Case8_4.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case8_4.Multiline = True
        Me.Case8_4.Name = "Case8_4"
        Me.Case8_4.Size = New System.Drawing.Size(68, 66)
        Me.Case8_4.TabIndex = 71
        Me.Case8_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case7_4
        '
        Me.Case7_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case7_4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case7_4.ForeColor = System.Drawing.Color.White
        Me.Case7_4.Location = New System.Drawing.Point(488, 810)
        Me.Case7_4.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case7_4.Multiline = True
        Me.Case7_4.Name = "Case7_4"
        Me.Case7_4.Size = New System.Drawing.Size(68, 66)
        Me.Case7_4.TabIndex = 70
        Me.Case7_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case9_3
        '
        Me.Case9_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case9_3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case9_3.ForeColor = System.Drawing.Color.White
        Me.Case9_3.Location = New System.Drawing.Point(384, 971)
        Me.Case9_3.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case9_3.Multiline = True
        Me.Case9_3.Name = "Case9_3"
        Me.Case9_3.Size = New System.Drawing.Size(68, 66)
        Me.Case9_3.TabIndex = 69
        Me.Case9_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case9_2
        '
        Me.Case9_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case9_2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case9_2.ForeColor = System.Drawing.Color.White
        Me.Case9_2.Location = New System.Drawing.Point(300, 971)
        Me.Case9_2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case9_2.Multiline = True
        Me.Case9_2.Name = "Case9_2"
        Me.Case9_2.Size = New System.Drawing.Size(68, 66)
        Me.Case9_2.TabIndex = 68
        Me.Case9_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case9_1
        '
        Me.Case9_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case9_1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case9_1.ForeColor = System.Drawing.Color.White
        Me.Case9_1.Location = New System.Drawing.Point(216, 971)
        Me.Case9_1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case9_1.Multiline = True
        Me.Case9_1.Name = "Case9_1"
        Me.Case9_1.Size = New System.Drawing.Size(68, 66)
        Me.Case9_1.TabIndex = 67
        Me.Case9_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case8_3
        '
        Me.Case8_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case8_3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case8_3.ForeColor = System.Drawing.Color.White
        Me.Case8_3.Location = New System.Drawing.Point(384, 890)
        Me.Case8_3.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case8_3.Multiline = True
        Me.Case8_3.Name = "Case8_3"
        Me.Case8_3.Size = New System.Drawing.Size(68, 66)
        Me.Case8_3.TabIndex = 66
        Me.Case8_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case8_2
        '
        Me.Case8_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case8_2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case8_2.ForeColor = System.Drawing.Color.White
        Me.Case8_2.Location = New System.Drawing.Point(300, 890)
        Me.Case8_2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case8_2.Multiline = True
        Me.Case8_2.Name = "Case8_2"
        Me.Case8_2.Size = New System.Drawing.Size(68, 66)
        Me.Case8_2.TabIndex = 65
        Me.Case8_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case8_1
        '
        Me.Case8_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case8_1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case8_1.ForeColor = System.Drawing.Color.White
        Me.Case8_1.Location = New System.Drawing.Point(216, 890)
        Me.Case8_1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case8_1.Multiline = True
        Me.Case8_1.Name = "Case8_1"
        Me.Case8_1.Size = New System.Drawing.Size(68, 66)
        Me.Case8_1.TabIndex = 64
        Me.Case8_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case7_3
        '
        Me.Case7_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case7_3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case7_3.ForeColor = System.Drawing.Color.White
        Me.Case7_3.Location = New System.Drawing.Point(384, 810)
        Me.Case7_3.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case7_3.Multiline = True
        Me.Case7_3.Name = "Case7_3"
        Me.Case7_3.Size = New System.Drawing.Size(68, 66)
        Me.Case7_3.TabIndex = 63
        Me.Case7_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case7_2
        '
        Me.Case7_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case7_2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case7_2.ForeColor = System.Drawing.Color.White
        Me.Case7_2.Location = New System.Drawing.Point(300, 810)
        Me.Case7_2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case7_2.Multiline = True
        Me.Case7_2.Name = "Case7_2"
        Me.Case7_2.Size = New System.Drawing.Size(68, 66)
        Me.Case7_2.TabIndex = 62
        Me.Case7_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Case7_1
        '
        Me.Case7_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Case7_1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Case7_1.ForeColor = System.Drawing.Color.White
        Me.Case7_1.Location = New System.Drawing.Point(216, 810)
        Me.Case7_1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Case7_1.Multiline = True
        Me.Case7_1.Name = "Case7_1"
        Me.Case7_1.Size = New System.Drawing.Size(68, 66)
        Me.Case7_1.TabIndex = 61
        Me.Case7_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Sudoku3X3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1276, 1356)
        Me.Controls.Add(Me.Case9_9)
        Me.Controls.Add(Me.Case8_9)
        Me.Controls.Add(Me.Case7_9)
        Me.Controls.Add(Me.Case9_8)
        Me.Controls.Add(Me.Case8_8)
        Me.Controls.Add(Me.Case7_8)
        Me.Controls.Add(Me.Case9_7)
        Me.Controls.Add(Me.Case8_7)
        Me.Controls.Add(Me.Case7_7)
        Me.Controls.Add(Me.Case9_6)
        Me.Controls.Add(Me.Case8_6)
        Me.Controls.Add(Me.Case7_6)
        Me.Controls.Add(Me.Case9_5)
        Me.Controls.Add(Me.Case8_5)
        Me.Controls.Add(Me.Case7_5)
        Me.Controls.Add(Me.Case9_4)
        Me.Controls.Add(Me.Case8_4)
        Me.Controls.Add(Me.Case7_4)
        Me.Controls.Add(Me.Case9_3)
        Me.Controls.Add(Me.Case9_2)
        Me.Controls.Add(Me.Case9_1)
        Me.Controls.Add(Me.Case8_3)
        Me.Controls.Add(Me.Case8_2)
        Me.Controls.Add(Me.Case8_1)
        Me.Controls.Add(Me.Case7_3)
        Me.Controls.Add(Me.Case7_2)
        Me.Controls.Add(Me.Case7_1)
        Me.Controls.Add(Me.Case6_9)
        Me.Controls.Add(Me.Case5_9)
        Me.Controls.Add(Me.Case4_9)
        Me.Controls.Add(Me.Case6_8)
        Me.Controls.Add(Me.Case5_8)
        Me.Controls.Add(Me.Case4_8)
        Me.Controls.Add(Me.Case6_7)
        Me.Controls.Add(Me.Case5_7)
        Me.Controls.Add(Me.Case4_7)
        Me.Controls.Add(Me.Case6_6)
        Me.Controls.Add(Me.Case5_6)
        Me.Controls.Add(Me.Case4_6)
        Me.Controls.Add(Me.Case6_5)
        Me.Controls.Add(Me.Case5_5)
        Me.Controls.Add(Me.Case4_5)
        Me.Controls.Add(Me.Case6_4)
        Me.Controls.Add(Me.Case5_4)
        Me.Controls.Add(Me.Case4_4)
        Me.Controls.Add(Me.Case6_3)
        Me.Controls.Add(Me.Case6_2)
        Me.Controls.Add(Me.Case6_1)
        Me.Controls.Add(Me.Case5_3)
        Me.Controls.Add(Me.Case5_2)
        Me.Controls.Add(Me.Case5_1)
        Me.Controls.Add(Me.Case4_3)
        Me.Controls.Add(Me.Case4_2)
        Me.Controls.Add(Me.Case4_1)
        Me.Controls.Add(Me.Case3_9)
        Me.Controls.Add(Me.Case2_9)
        Me.Controls.Add(Me.Case1_9)
        Me.Controls.Add(Me.Case3_8)
        Me.Controls.Add(Me.Case2_8)
        Me.Controls.Add(Me.Case1_8)
        Me.Controls.Add(Me.Case3_7)
        Me.Controls.Add(Me.Case2_7)
        Me.Controls.Add(Me.Case1_7)
        Me.Controls.Add(Me.Case3_6)
        Me.Controls.Add(Me.Case2_6)
        Me.Controls.Add(Me.Case1_6)
        Me.Controls.Add(Me.Case3_5)
        Me.Controls.Add(Me.Case2_5)
        Me.Controls.Add(Me.Case1_5)
        Me.Controls.Add(Me.Case3_4)
        Me.Controls.Add(Me.Case2_4)
        Me.Controls.Add(Me.Case1_4)
        Me.Controls.Add(Me.Case3_3)
        Me.Controls.Add(Me.Case3_2)
        Me.Controls.Add(Me.Case3_1)
        Me.Controls.Add(Me.Case2_3)
        Me.Controls.Add(Me.Case2_2)
        Me.Controls.Add(Me.Case2_1)
        Me.Controls.Add(Me.Case1_3)
        Me.Controls.Add(Me.Case1_2)
        Me.Controls.Add(Me.Case1_1)
        Me.Controls.Add(Me.giveUpButton)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "Sudoku3X3"
        Me.Opacity = 0.95R
        Me.Text = "Sudoku3X3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents giveUpButton As Button
    Friend WithEvents Case1_1 As TextBox
    Friend WithEvents Case1_2 As TextBox
    Friend WithEvents Case1_3 As TextBox
    Friend WithEvents Case2_1 As TextBox
    Friend WithEvents Case2_2 As TextBox
    Friend WithEvents Case2_3 As TextBox
    Friend WithEvents Case3_1 As TextBox
    Friend WithEvents Case3_2 As TextBox
    Friend WithEvents Case3_3 As TextBox
    Friend WithEvents Case1_4 As TextBox
    Friend WithEvents Case2_4 As TextBox
    Friend WithEvents Case3_4 As TextBox
    Friend WithEvents Case1_5 As TextBox
    Friend WithEvents Case2_5 As TextBox
    Friend WithEvents Case3_5 As TextBox
    Friend WithEvents Case1_6 As TextBox
    Friend WithEvents Case2_6 As TextBox
    Friend WithEvents Case3_6 As TextBox
    Friend WithEvents Case1_7 As TextBox
    Friend WithEvents Case2_7 As TextBox
    Friend WithEvents Case3_7 As TextBox
    Friend WithEvents Case1_8 As TextBox
    Friend WithEvents Case2_8 As TextBox
    Friend WithEvents Case3_8 As TextBox
    Friend WithEvents Case1_9 As TextBox
    Friend WithEvents Case2_9 As TextBox
    Friend WithEvents Case3_9 As TextBox
    Friend WithEvents Case6_9 As TextBox
    Friend WithEvents Case5_9 As TextBox
    Friend WithEvents Case4_9 As TextBox
    Friend WithEvents Case6_8 As TextBox
    Friend WithEvents Case5_8 As TextBox
    Friend WithEvents Case4_8 As TextBox
    Friend WithEvents Case6_7 As TextBox
    Friend WithEvents Case5_7 As TextBox
    Friend WithEvents Case4_7 As TextBox
    Friend WithEvents Case6_6 As TextBox
    Friend WithEvents Case5_6 As TextBox
    Friend WithEvents Case4_6 As TextBox
    Friend WithEvents Case6_5 As TextBox
    Friend WithEvents Case5_5 As TextBox
    Friend WithEvents Case4_5 As TextBox
    Friend WithEvents Case6_4 As TextBox
    Friend WithEvents Case5_4 As TextBox
    Friend WithEvents Case4_4 As TextBox
    Friend WithEvents Case6_3 As TextBox
    Friend WithEvents Case6_2 As TextBox
    Friend WithEvents Case6_1 As TextBox
    Friend WithEvents Case5_3 As TextBox
    Friend WithEvents Case5_2 As TextBox
    Friend WithEvents Case5_1 As TextBox
    Friend WithEvents Case4_3 As TextBox
    Friend WithEvents Case4_2 As TextBox
    Friend WithEvents Case4_1 As TextBox
    Friend WithEvents Case9_9 As TextBox
    Friend WithEvents Case8_9 As TextBox
    Friend WithEvents Case7_9 As TextBox
    Friend WithEvents Case9_8 As TextBox
    Friend WithEvents Case8_8 As TextBox
    Friend WithEvents Case7_8 As TextBox
    Friend WithEvents Case9_7 As TextBox
    Friend WithEvents Case8_7 As TextBox
    Friend WithEvents Case7_7 As TextBox
    Friend WithEvents Case9_6 As TextBox
    Friend WithEvents Case8_6 As TextBox
    Friend WithEvents Case7_6 As TextBox
    Friend WithEvents Case9_5 As TextBox
    Friend WithEvents Case8_5 As TextBox
    Friend WithEvents Case7_5 As TextBox
    Friend WithEvents Case9_4 As TextBox
    Friend WithEvents Case8_4 As TextBox
    Friend WithEvents Case7_4 As TextBox
    Friend WithEvents Case9_3 As TextBox
    Friend WithEvents Case9_2 As TextBox
    Friend WithEvents Case9_1 As TextBox
    Friend WithEvents Case8_3 As TextBox
    Friend WithEvents Case8_2 As TextBox
    Friend WithEvents Case8_1 As TextBox
    Friend WithEvents Case7_3 As TextBox
    Friend WithEvents Case7_2 As TextBox
    Friend WithEvents Case7_1 As TextBox
End Class
