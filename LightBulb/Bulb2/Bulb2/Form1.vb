Public Class frmBulb2

    Private Sub frmBulb2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Allen Baluyot", vbInformation, "Information")
        imgBox1.Image = Image.FromFile("D:\Allen Baluyot 12 BernersLee\Bulb1\Bulb1\bin\Debug\Off.png")
        imgBox2.Image = Image.FromFile("D:\Allen Baluyot 12 BernersLee\Bulb1\Bulb1\bin\Debug\On.png")
    End Sub

    Private Sub btnOnOff_Click(sender As Object, e As EventArgs) Handles btnOnOff.Click
        If btnOnOff.Text = "Turn On" Then
            imgBox1.Image = Image.FromFile("D:\Allen Baluyot 12 BernersLee\Bulb1\Bulb1\bin\Debug\Off.png")
            btnOnOff.Text = "Turn Off"
            imgBox2.Visible = True
            imgBox1.Visible = False
        Else
            imgBox2.Image = Image.FromFile("D:\Allen Baluyot 12 BernersLee\Bulb1\Bulb1\bin\Debug\On.png")
            btnOnOff.Text = "Turn On"
            imgBox2.Visible = False
            imgBox1.Visible = True
        End If
    End Sub

End Class
