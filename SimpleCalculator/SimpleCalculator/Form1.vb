Public Class frmMain

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        txtResult.Text = Val(txtNum1.Text) + Val(txtNum2.Text)
    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        txtResult.Text = Val(txtNum1.Text) - Val(txtNum2.Text)
    End Sub

    Private Sub btnMul_Click(sender As Object, e As EventArgs) Handles btnMul.Click
        txtResult.Text = Val(txtNum1.Text) * Val(txtNum2.Text)
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        txtResult.Text = Val(txtNum1.Text) / Val(txtNum2.Text)
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        txtResult.Text = Val(txtNum1.Text) Mod Val(txtNum2.Text)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNum1.Clear()
        txtNum2.Clear()
        txtResult.Clear()
        txtNum1.Focus()
    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        MsgBox("Allen James Baluyot", vbInformation, "Information")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblResult.Click

    End Sub
End Class
