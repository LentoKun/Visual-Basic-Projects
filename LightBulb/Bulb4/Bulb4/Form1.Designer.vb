<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBulb4
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
        Me.btnOnOff = New System.Windows.Forms.Button()
        CType(Me.imgBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgBox
        '
        Me.imgBox.Location = New System.Drawing.Point(37, 12)
        Me.imgBox.Name = "imgBox"
        Me.imgBox.Size = New System.Drawing.Size(217, 288)
        Me.imgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgBox.TabIndex = 0
        Me.imgBox.TabStop = False
        '
        'btnOnOff
        '
        Me.btnOnOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOnOff.Location = New System.Drawing.Point(58, 306)
        Me.btnOnOff.Name = "btnOnOff"
        Me.btnOnOff.Size = New System.Drawing.Size(175, 39)
        Me.btnOnOff.TabIndex = 1
        Me.btnOnOff.Text = "Turn On"
        Me.btnOnOff.UseVisualStyleBackColor = True
        '
        'frmBulb4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 362)
        Me.Controls.Add(Me.btnOnOff)
        Me.Controls.Add(Me.imgBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBulb4"
        Me.Text = "Light Bulb (4)"
        CType(Me.imgBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imgBox As System.Windows.Forms.PictureBox
    Friend WithEvents btnOnOff As System.Windows.Forms.Button

End Class
