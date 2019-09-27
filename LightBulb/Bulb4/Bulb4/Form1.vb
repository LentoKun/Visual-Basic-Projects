Public Class frmBulb4

    Private Sub frmBulb4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Allen Baluyot", vbInformation, "Information")
        imgBox.Image = Image.FromFile(Application.StartupPath & "\Off.png")
    End Sub

    Private Sub btnOnOff_Click(sender As Object, e As EventArgs) Handles btnOnOff.Click
        If btnOnOff.Text = "Turn On" Then
            btnOnOff.Text = "Turn Off"
            imgBox.Image = Image.FromFile(Application.StartupPath & "\On.png")
        Else
            btnOnOff.Text = "Turn On"
            imgBox.Image = Image.FromFile(Application.StartupPath & "\Off.png")
        End If
    End Sub
End Class
