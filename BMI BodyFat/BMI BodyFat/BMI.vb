'Nelson T. Sherman
'10/ 26/ 2019
'This program calculates your Body Mass Index and displays the results.

Public Class frmBMI


	Private Sub frmBMI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub txtHeight_TextChanged(sender As Object, e As EventArgs) Handles txtHeight.TextChanged

	End Sub

	Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtWeight.TextChanged

	End Sub

	Private Sub lblResults_Click(sender As Object, e As EventArgs) Handles lblResults.Click

	End Sub

	Private Sub lblMessage_Click(sender As Object, e As EventArgs) Handles lblMessage.Click

	End Sub

	Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click

	End Sub

	Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
		'Variables
		Dim dblWeight As Double
		Dim dblHeight As Double
		Dim dblBMI As Double

		dblWeight = Val(txtWeight.Text)
		dblHeight = Val(txtHeight.Text)

		'BMI calculations from function
		lblResults.Text = BMICalculations(dblWeight, dblHeight)

		If (lblResults.Text > 25) Then
			lblMessage.Text = "You are considered Obese." & Environment.NewLine & "Please see your doctor ASAP!!!"

		ElseIf (lblResults.Text > 25 And lblResults.Text < 30) Then
			lblMessage.Text = "You are over weight!! " & Environment.NewLine & "See Recommendations below."

		ElseIf (lblResults.Text < 25 And lblResults.Text > 18) Then
			lblMessage.Text = "Your body fat is at an acceptable level!!" & Environment.NewLine & "See Recommendations below."

		ElseIf (lblMessage.Text < 18) Then
			lblMessage.Text = "Congratulations you are at a Fit Status"
		End If

		'Me.lblRecommend.Text = "Note: Results of the BMI calculator are based on averages." & ControlChars.NewLine & "Keep in mind that the BMI calculator may" & ControlChars.NewLine & "over-estimate body fat in those with a muscular build." & ControlChars.NewLine & "A BMI calculator is designed to assess your relative fitness" & ControlChars.NewLine & "but it is NOT a calculation of body fat percentage." & Environment.NewLine & "   "


	End Sub

	Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

		Me.Close()
		frmMain.Show()

	End Sub
End Class