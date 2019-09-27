Public Class frmMain

    Dim Count = 0

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        MsgBox("Allen Baluyot", vbInformation, "Information")
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        MsgBox("(1) Enter any number to Start the game." & Chr(13) & "Note: Letters and Symbols are not allowed." & Chr(13) & "" & Chr(13) & "(2) Press the Start button to Play." & Chr(13) & "Note: You need to Input or Enter any Number to Play." & Chr(13) & "" & Chr(13) & "(3) The Main Objective here is to Guess any Number." & Chr(13) & "Note: Only 5 Chances if you not Guess any Number." & Chr(13) & "" & Chr(13) & "(4) If you Guess the Number, You Won." & Chr(13) & "     If Not, You go back to Play Again.", vbInformation, "How to Play?")
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If txtNumber.Text = "" Then
            MsgBox("Please Input A Number", vbCritical, "Error")
            txtNumber.Focus()
        Else
            MsgBox("You Only Have 5 Chances to Guess" & Chr(13) & "We Gonna Start The Game, Goodluck", vbInformation, "Lets Play")
            Me.Width = 330
            Me.Height = 250

            lblGuess.Visible = True
            btnSubmit.Visible = True
            txtGuess.Visible = True

            lblNumber.Visible = False
            btnStart.Visible = False
            btnInfo.Visible = False
            btnHelp.Visible = False
            txtNumber.Visible = False

        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtGuess.Text = txtNumber.Text Then
            MsgBox("You Guessed the Number, Congratulations", vbInformation, "Hey, Congratulations!")
            Count = 0
            Me.Width = 330
            Me.Height = 355
            lblNumber.Visible = True
            btnStart.Visible = True
            btnInfo.Visible = True
            btnHelp.Visible = True
            txtNumber.Visible = True

            lblGuess.Visible = False
            btnSubmit.Visible = False
            txtGuess.Visible = False

            txtGuess.Clear()
            txtNumber.Clear()
            txtNumber.Focus()
        Else
            MsgBox("Sorry Wrong Guess" & Chr(13) & "Please Try Again", vbInformation, "Wrong Guess")
            Count = Count + 1

            txtGuess.Clear()
            txtGuess.Focus()

            If Count >= 5 Then
                MsgBox("Game Over! " & Chr(13) & "The Guess Number is (" + txtNumber.Text + ") Better luck next time!", vbInformation, "Gameover")

                txtGuess.Clear()
                txtGuess.Focus()
                Count = 0
                Me.Width = 330
                Me.Height = 355

                lblNumber.Visible = True
                btnStart.Visible = True
                btnInfo.Visible = True
                btnHelp.Visible = True
                txtNumber.Visible = True

                lblGuess.Visible = False
                btnSubmit.Visible = False
                txtGuess.Visible = False

                txtGuess.Clear()
                txtNumber.Clear()
                txtNumber.Focus()
            End If
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblGuess.Visible = False
        btnSubmit.Visible = False
        txtGuess.Visible = False
        txtNumber.Focus()
    End Sub

    Private Sub txtNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumber.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtGuess_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGuess.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtGuess_TextChanged(sender As Object, e As EventArgs) Handles txtGuess.TextChanged
        If txtGuess.Text = "" Then
            btnSubmit.Enabled = False
        Else
            btnSubmit.Enabled = True
        End If
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged

    End Sub
End Class
