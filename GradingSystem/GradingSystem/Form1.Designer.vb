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
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.lblInfo1 = New System.Windows.Forms.Label()
        Me.lblInfo2 = New System.Windows.Forms.Label()
        Me.lblInfo3 = New System.Windows.Forms.Label()
        Me.lblInfo4 = New System.Windows.Forms.Label()
        Me.lblInfo5 = New System.Windows.Forms.Label()
        Me.lblInfo6 = New System.Windows.Forms.Label()
        Me.txtAttendance = New System.Windows.Forms.TextBox()
        Me.txtWorks = New System.Windows.Forms.TextBox()
        Me.txtActivity = New System.Windows.Forms.TextBox()
        Me.txtPtest = New System.Windows.Forms.TextBox()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClear.Location = New System.Drawing.Point(12, 248)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(151, 43)
        Me.btnClear.TabIndex = 0
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCompute
        '
        Me.btnCompute.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.Location = New System.Drawing.Point(169, 248)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(161, 43)
        Me.btnCompute.TabIndex = 1
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'btnInfo
        '
        Me.btnInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInfo.Location = New System.Drawing.Point(12, 297)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(320, 46)
        Me.btnInfo.TabIndex = 2
        Me.btnInfo.Text = "Information"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'lblInfo1
        '
        Me.lblInfo1.AutoSize = True
        Me.lblInfo1.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblInfo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo1.ForeColor = System.Drawing.SystemColors.Control
        Me.lblInfo1.Location = New System.Drawing.Point(61, 18)
        Me.lblInfo1.Name = "lblInfo1"
        Me.lblInfo1.Size = New System.Drawing.Size(128, 24)
        Me.lblInfo1.TabIndex = 3
        Me.lblInfo1.Text = "Attendance :"
        '
        'lblInfo2
        '
        Me.lblInfo2.AutoSize = True
        Me.lblInfo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo2.ForeColor = System.Drawing.SystemColors.Control
        Me.lblInfo2.Location = New System.Drawing.Point(38, 55)
        Me.lblInfo2.Name = "lblInfo2"
        Me.lblInfo2.Size = New System.Drawing.Size(151, 24)
        Me.lblInfo2.TabIndex = 4
        Me.lblInfo2.Text = "Written Works :"
        '
        'lblInfo3
        '
        Me.lblInfo3.AutoSize = True
        Me.lblInfo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo3.ForeColor = System.Drawing.SystemColors.Control
        Me.lblInfo3.Location = New System.Drawing.Point(101, 88)
        Me.lblInfo3.Name = "lblInfo3"
        Me.lblInfo3.Size = New System.Drawing.Size(87, 24)
        Me.lblInfo3.TabIndex = 5
        Me.lblInfo3.Text = "Activity :"
        '
        'lblInfo4
        '
        Me.lblInfo4.AutoSize = True
        Me.lblInfo4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo4.ForeColor = System.Drawing.SystemColors.Control
        Me.lblInfo4.Location = New System.Drawing.Point(27, 123)
        Me.lblInfo4.Name = "lblInfo4"
        Me.lblInfo4.Size = New System.Drawing.Size(161, 24)
        Me.lblInfo4.TabIndex = 6
        Me.lblInfo4.Text = "Periodical Test :"
        '
        'lblInfo5
        '
        Me.lblInfo5.AutoSize = True
        Me.lblInfo5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo5.ForeColor = System.Drawing.SystemColors.Control
        Me.lblInfo5.Location = New System.Drawing.Point(58, 158)
        Me.lblInfo5.Name = "lblInfo5"
        Me.lblInfo5.Size = New System.Drawing.Size(131, 24)
        Me.lblInfo5.TabIndex = 7
        Me.lblInfo5.Text = "Final Grade :"
        '
        'lblInfo6
        '
        Me.lblInfo6.AutoSize = True
        Me.lblInfo6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo6.ForeColor = System.Drawing.SystemColors.Control
        Me.lblInfo6.Location = New System.Drawing.Point(85, 193)
        Me.lblInfo6.Name = "lblInfo6"
        Me.lblInfo6.Size = New System.Drawing.Size(103, 24)
        Me.lblInfo6.TabIndex = 8
        Me.lblInfo6.Text = "Remarks :"
        '
        'txtAttendance
        '
        Me.txtAttendance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAttendance.Location = New System.Drawing.Point(214, 15)
        Me.txtAttendance.MaxLength = 3
        Me.txtAttendance.Name = "txtAttendance"
        Me.txtAttendance.Size = New System.Drawing.Size(100, 29)
        Me.txtAttendance.TabIndex = 9
        '
        'txtWorks
        '
        Me.txtWorks.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWorks.Location = New System.Drawing.Point(214, 50)
        Me.txtWorks.MaxLength = 3
        Me.txtWorks.Name = "txtWorks"
        Me.txtWorks.Size = New System.Drawing.Size(100, 29)
        Me.txtWorks.TabIndex = 10
        '
        'txtActivity
        '
        Me.txtActivity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActivity.Location = New System.Drawing.Point(214, 85)
        Me.txtActivity.MaxLength = 3
        Me.txtActivity.Name = "txtActivity"
        Me.txtActivity.Size = New System.Drawing.Size(100, 29)
        Me.txtActivity.TabIndex = 11
        '
        'txtPtest
        '
        Me.txtPtest.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPtest.Location = New System.Drawing.Point(214, 120)
        Me.txtPtest.MaxLength = 3
        Me.txtPtest.Name = "txtPtest"
        Me.txtPtest.Size = New System.Drawing.Size(100, 29)
        Me.txtPtest.TabIndex = 12
        '
        'txtGrade
        '
        Me.txtGrade.BackColor = System.Drawing.SystemColors.Window
        Me.txtGrade.Enabled = False
        Me.txtGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrade.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtGrade.Location = New System.Drawing.Point(214, 155)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(100, 29)
        Me.txtGrade.TabIndex = 13
        '
        'txtRemarks
        '
        Me.txtRemarks.BackColor = System.Drawing.SystemColors.Window
        Me.txtRemarks.Enabled = False
        Me.txtRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRemarks.Location = New System.Drawing.Point(214, 190)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(100, 29)
        Me.txtRemarks.TabIndex = 14
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(344, 358)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.txtGrade)
        Me.Controls.Add(Me.txtPtest)
        Me.Controls.Add(Me.txtActivity)
        Me.Controls.Add(Me.txtWorks)
        Me.Controls.Add(Me.txtAttendance)
        Me.Controls.Add(Me.lblInfo6)
        Me.Controls.Add(Me.lblInfo5)
        Me.Controls.Add(Me.lblInfo4)
        Me.Controls.Add(Me.lblInfo3)
        Me.Controls.Add(Me.lblInfo2)
        Me.Controls.Add(Me.lblInfo1)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.btnClear)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grading System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents btnInfo As System.Windows.Forms.Button
    Friend WithEvents lblInfo1 As System.Windows.Forms.Label
    Friend WithEvents lblInfo2 As System.Windows.Forms.Label
    Friend WithEvents lblInfo3 As System.Windows.Forms.Label
    Friend WithEvents lblInfo4 As System.Windows.Forms.Label
    Friend WithEvents lblInfo5 As System.Windows.Forms.Label
    Friend WithEvents lblInfo6 As System.Windows.Forms.Label
    Friend WithEvents txtAttendance As System.Windows.Forms.TextBox
    Friend WithEvents txtWorks As System.Windows.Forms.TextBox
    Friend WithEvents txtActivity As System.Windows.Forms.TextBox
    Friend WithEvents txtPtest As System.Windows.Forms.TextBox
    Friend WithEvents txtGrade As System.Windows.Forms.TextBox
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox

End Class
