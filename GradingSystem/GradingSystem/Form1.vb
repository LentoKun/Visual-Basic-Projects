Public Class frmMain

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        MsgBox("Allen Baluyot", vbInformation, "Information")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAttendance.Clear()
        txtWorks.Clear()
        txtActivity.Clear()
        txtPtest.Clear()
        txtGrade.Clear()
        txtRemarks.Clear()

        txtAttendance.Focus()

        txtGrade.BackColor = Color.White
        txtRemarks.BackColor = Color.White

        txtAttendance.ForeColor = Color.Black
        txtWorks.ForeColor = Color.Black
        txtActivity.ForeColor = Color.Black
        txtPtest.ForeColor = Color.Black
    End Sub

    Private Sub txtAttendance_Click(sender As Object, e As EventArgs) Handles txtAttendance.Click
        If txtAttendance.Text = "" Then
            MsgBox("Please Input 60 - 100", vbCritical, "Error :")
        End If
    End Sub

    Private Sub txtAttendance_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAttendance.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Or e.KeyChar = Chr(46) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtWorks_Click(sender As Object, e As EventArgs) Handles txtWorks.Click
        If txtWorks.Text = "" Then
            MsgBox("Please Input 60 - 100", vbCritical, "Error :")
        End If
    End Sub

    Private Sub txtWorks_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWorks.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Or e.KeyChar = Chr(46) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtActivity_Click(sender As Object, e As EventArgs) Handles txtActivity.Click
        If txtActivity.Text = "" Then
            MsgBox("Please Input 60 - 100", vbCritical, "Error :")
        End If
    End Sub

    Private Sub txtActivity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtActivity.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Or e.KeyChar = Chr(46) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtPtest_Click(sender As Object, e As EventArgs) Handles txtPtest.Click
        If txtPtest.Text = "" Then
            MsgBox("Please Input 60 - 100", vbCritical, "Error :")
        End If
    End Sub

    Private Sub txtPtest_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPtest.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Or e.KeyChar = Chr(46) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtAttendance_Leave(sender As Object, e As EventArgs) Handles txtAttendance.Leave
        If txtAttendance.Text = "" Then
            txtAttendance.Text = "60"
            txtAttendance.ForeColor = Color.Red
        End If
        If txtAttendance.Text <= 59 Then
            MsgBox("Invalid Grade" & vbCrLf & "Input 60 - 100 only", vbCritical, "Error :")
            txtAttendance.Focus()
            txtAttendance.Clear()
        ElseIf txtAttendance.Text >= 101 Then
            MsgBox("Invalid Grade" & vbCrLf & "Input 60 - 100 only", vbCritical, "Error :")
            txtAttendance.Focus()
            txtAttendance.Clear()
        ElseIf txtAttendance.Text <= 75 Then
            txtAttendance.ForeColor = Color.Red
        Else
            txtAttendance.ForeColor = Color.Blue
        End If
    End Sub

    Private Sub txtWorks_Leave(sender As Object, e As EventArgs) Handles txtWorks.Leave
        If txtWorks.Text = "" Then
            txtWorks.Text = "60"
            txtWorks.ForeColor = Color.Red
        End If
        If txtWorks.Text <= 59 Then
            MsgBox("Invalid Grade" & vbCrLf & "Input 60 - 100 only", vbCritical, "Error :")
            txtWorks.Focus()
            txtWorks.Clear()
        ElseIf txtWorks.Text >= 101 Then
            MsgBox("Invalid Grade" & vbCrLf & "Input 60 - 100 only", vbCritical, "Error :")
            txtWorks.Focus()
            txtWorks.Clear()
        ElseIf txtWorks.Text <= 75 Then
            txtWorks.ForeColor = Color.Red
        Else
            txtWorks.ForeColor = Color.Blue
        End If
    End Sub

    Private Sub txtActivity_Leave(sender As Object, e As EventArgs) Handles txtActivity.Leave
        If txtActivity.Text = "" Then
            txtActivity.Text = "60"
            txtActivity.ForeColor = Color.Red
        End If
        If txtActivity.Text <= 59 Then
            MsgBox("Invalid Grade" & vbCrLf & "Input 60 - 100 only", vbCritical, "Error :")
            txtActivity.Focus()
            txtActivity.Clear()
        ElseIf txtActivity.Text >= 101 Then
            MsgBox("Invalid Grade" & vbCrLf & "Input 60 - 100 only", vbCritical, "Error :")
            txtActivity.Focus()
            txtActivity.Clear()
        ElseIf txtActivity.Text <= 75 Then
            txtActivity.ForeColor = Color.Red
        Else
            txtActivity.ForeColor = Color.Blue
        End If
    End Sub

    Private Sub txtPtest_Leave(sender As Object, e As EventArgs) Handles txtPtest.Leave
        If txtPtest.Text = "" Then
            txtPtest.Text = "60"
            txtPtest.ForeColor = Color.Red
        End If
        If txtPtest.Text <= 59 Then
            MsgBox("Invalid Grade" & vbCrLf & "Input 60 - 100 only", vbCritical, "Error :")
            txtPtest.Focus()
            txtPtest.Clear()
        ElseIf txtPtest.Text >= 101 Then
            MsgBox("Invalid Grade" & vbCrLf & "Input 60 - 100 only", vbCritical, "Error :")
            txtPtest.Focus()
            txtPtest.Clear()
        ElseIf txtPtest.Text <= 75 Then
            txtPtest.ForeColor = Color.Red
        Else
            txtPtest.ForeColor = Color.Blue
        End If
    End Sub


    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        txtGrade.Text = Val(txtAttendance.Text) * 0.1 + Val(txtWorks.Text) * 0.2 + Val(txtActivity.Text) * 0.3 + Val(txtPtest.Text) * 0.4
        If txtGrade.Text >= 74 Then
            txtRemarks.Text = "Passed"
            txtRemarks.BackColor = Color.Blue
            txtGrade.BackColor = Color.Blue
        Else
            txtRemarks.Text = "Failed"
            txtRemarks.BackColor = Color.Red
            txtGrade.BackColor = Color.Red
        End If
    End Sub
End Class
