<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QuitGameMsgBox
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
        Me.yesQuit = New System.Windows.Forms.Button()
        Me.noQuit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'yesQuit
        '
        Me.yesQuit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.yesQuit.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.yesQuit.FlatAppearance.BorderSize = 2
        Me.yesQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.yesQuit.ForeColor = System.Drawing.Color.White
        Me.yesQuit.Location = New System.Drawing.Point(68, 125)
        Me.yesQuit.Name = "yesQuit"
        Me.yesQuit.Size = New System.Drawing.Size(104, 38)
        Me.yesQuit.TabIndex = 0
        Me.yesQuit.Text = "YES"
        Me.yesQuit.UseVisualStyleBackColor = False
        '
        'noQuit
        '
        Me.noQuit.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.noQuit.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.noQuit.FlatAppearance.BorderSize = 2
        Me.noQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.noQuit.ForeColor = System.Drawing.Color.White
        Me.noQuit.Location = New System.Drawing.Point(220, 125)
        Me.noQuit.Name = "noQuit"
        Me.noQuit.Size = New System.Drawing.Size(104, 38)
        Me.noQuit.TabIndex = 1
        Me.noQuit.Text = "NO"
        Me.noQuit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(165, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Quit ?"
        '
        'QuitGameMsgBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(398, 232)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.noQuit)
        Me.Controls.Add(Me.yesQuit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "QuitGameMsgBox"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QuitGameMsgBox"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents yesQuit As Button
    Friend WithEvents noQuit As Button
    Friend WithEvents Label1 As Label
End Class
