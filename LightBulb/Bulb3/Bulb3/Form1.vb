Public Class frmBulb3

    Private Sub btnOn_Click(sender As Object, e As EventArgs) Handles btnOn.Click
        imgBox.Image = Image.FromFile(Application.StartupPath & "\On.png")
        btnOn.Visible = False
        btnOff.Visible = True
    End Sub

    Private Sub btnOff_Click(sender As Object, e As EventArgs) Handles btnOff.Click
        imgBox.Image = Image.FromFile(Application.StartupPath & "\Off.png")
        btnOn.Visible = True
        btnOff.Visible = False
    End Sub

    Private Sub frmBulb3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Allen Baluyot", vbInformation, "Information")
        imgBox.Image = Image.FromFile(Application.StartupPath & "\Off.png")
    End Sub

End Class
