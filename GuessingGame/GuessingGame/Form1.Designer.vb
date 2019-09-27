<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblGuess = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.txtGuess = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnInfo
        '
        Me.btnInfo.BackColor = System.Drawing.Color.White
        Me.btnInfo.Font = New System.Drawing.Font("Monospac821 BT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInfo.Location = New System.Drawing.Point(28, 182)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(260, 50)
        Me.btnInfo.TabIndex = 2
        Me.btnInfo.Text = "Information"
        Me.btnInfo.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.White
        Me.btnHelp.Font = New System.Drawing.Font("Monospac821 BT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.Location = New System.Drawing.Point(28, 247)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(260, 50)
        Me.btnHelp.TabIndex = 3
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.White
        Me.btnSubmit.Enabled = False
        Me.btnSubmit.Font = New System.Drawing.Font("Monospac821 BT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(28, 113)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(260, 50)
        Me.btnSubmit.TabIndex = 1
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.White
        Me.btnStart.Font = New System.Drawing.Font("Monospac821 BT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnStart.Location = New System.Drawing.Point(29, 113)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(260, 50)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber.ForeColor = System.Drawing.SystemColors.Control
        Me.lblNumber.Location = New System.Drawing.Point(22, 23)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(267, 40)
        Me.lblNumber.TabIndex = 5
        Me.lblNumber.Text = "Enter your Number"
        Me.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGuess
        '
        Me.lblGuess.AutoSize = True
        Me.lblGuess.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuess.ForeColor = System.Drawing.SystemColors.Control
        Me.lblGuess.Location = New System.Drawing.Point(22, 23)
        Me.lblGuess.Name = "lblGuess"
        Me.lblGuess.Size = New System.Drawing.Size(236, 40)
        Me.lblGuess.TabIndex = 6
        Me.lblGuess.Text = "Enter your Guess"
        Me.lblGuess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNumber
        '
        Me.txtNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber.Location = New System.Drawing.Point(28, 66)
        Me.txtNumber.MaxLength = 3
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNumber.Size = New System.Drawing.Size(260, 35)
        Me.txtNumber.TabIndex = 0
        Me.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGuess
        '
        Me.txtGuess.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuess.Location = New System.Drawing.Point(28, 66)
        Me.txtGuess.MaxLength = 3
        Me.txtGuess.Name = "txtGuess"
        Me.txtGuess.Size = New System.Drawing.Size(260, 35)
        Me.txtGuess.TabIndex = 0
        Me.txtGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(314, 316)
        Me.Controls.Add(Me.txtGuess)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.lblGuess)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnInfo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guessing Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnInfo As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents lblNumber As System.Windows.Forms.Label
    Friend WithEvents lblGuess As System.Windows.Forms.Label
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtGuess As System.Windows.Forms.TextBox

End Class
