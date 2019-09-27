<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBulb3
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
        Me.imgBox = New System.Windows.Forms.PictureBox()
        Me.btnOff = New System.Windows.Forms.Button()
        Me.btnOn = New System.Windows.Forms.Button()
        CType(Me.imgBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgBox
        '
        Me.imgBox.Location = New System.Drawing.Point(39, 12)
        Me.imgBox.Name = "imgBox"
        Me.imgBox.Size = New System.Drawing.Size(229, 278)
        Me.imgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgBox.TabIndex = 0
        Me.imgBox.TabStop = False
        '
        'btnOff
        '
        Me.btnOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOff.Location = New System.Drawing.Point(61, 296)
        Me.btnOff.Name = "btnOff"
        Me.btnOff.Size = New System.Drawing.Size(193, 53)
        Me.btnOff.TabIndex = 1
        Me.btnOff.Text = "Turn Off"
        Me.btnOff.UseVisualStyleBackColor = True
        '
        'btnOn
        '
        Me.btnOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOn.Location = New System.Drawing.Point(61, 296)
        Me.btnOn.Name = "btnOn"
        Me.btnOn.Size = New System.Drawing.Size(193, 53)
        Me.btnOn.TabIndex = 2
        Me.btnOn.Text = "Turn On"
        Me.btnOn.UseVisualStyleBackColor = True
        '
        'frmBulb3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 361)
        Me.Controls.Add(Me.btnOn)
        Me.Controls.Add(Me.btnOff)
        Me.Controls.Add(Me.imgBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBulb3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Light Bulb (3)"
        CType(Me.imgBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imgBox As System.Windows.Forms.PictureBox
    Friend WithEvents btnOff As System.Windows.Forms.Button
    Friend WithEvents btnOn As System.Windows.Forms.Button

End Class
