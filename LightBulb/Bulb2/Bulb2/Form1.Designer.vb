<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBulb2
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
        Me.btnOnOff = New System.Windows.Forms.Button()
        Me.imgBox1 = New System.Windows.Forms.PictureBox()
        Me.imgBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.imgBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOnOff
        '
        Me.btnOnOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOnOff.Location = New System.Drawing.Point(46, 277)
        Me.btnOnOff.Name = "btnOnOff"
        Me.btnOnOff.Size = New System.Drawing.Size(210, 58)
        Me.btnOnOff.TabIndex = 2
        Me.btnOnOff.Text = "Turn On"
        Me.btnOnOff.UseVisualStyleBackColor = True
        '
        'imgBox1
        '
        Me.imgBox1.Location = New System.Drawing.Point(46, 12)
        Me.imgBox1.Name = "imgBox1"
        Me.imgBox1.Size = New System.Drawing.Size(210, 250)
        Me.imgBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgBox1.TabIndex = 1
        Me.imgBox1.TabStop = False
        '
        'imgBox2
        '
        Me.imgBox2.Location = New System.Drawing.Point(46, 12)
        Me.imgBox2.Name = "imgBox2"
        Me.imgBox2.Size = New System.Drawing.Size(210, 250)
        Me.imgBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgBox2.TabIndex = 0
        Me.imgBox2.TabStop = False
        '
        'frmBulb2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 347)
        Me.Controls.Add(Me.btnOnOff)
        Me.Controls.Add(Me.imgBox1)
        Me.Controls.Add(Me.imgBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBulb2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Light Bulb (2)"
        CType(Me.imgBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imgBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents imgBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnOnOff As System.Windows.Forms.Button

End Class
