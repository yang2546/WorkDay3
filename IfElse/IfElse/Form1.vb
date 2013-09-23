Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        Dim num1, num2 As Double

        'Verify user typed a number
        If Not (IsNumeric(txtFirstNum.Text) And IsNumeric(txtSecondNum.Text)) Then
            MessageBox.Show("Error: Please type a number.")
            Return
        End If

        'Change from text to double
        num1 = CDbl(txtFirstNum.Text)
        num2 = CDbl(txtSecondNum.Text)

        'Verify user typed positive numbers
        If ((num1 < 0) Or (num2 < 0)) Then
            MessageBox.Show("Error: Please type a positive number.")
            Return
        End If

        'Find larger number
        If (num1 > num2) Then
            txtResult.Text = "Larger number is " & num1
        ElseIf (num2 > num1) Then
            txtResult.Text = "Larger number is " & num2
        Else
            txtResult.Text = "The two are equal."
        End If

    End Sub

End Class
