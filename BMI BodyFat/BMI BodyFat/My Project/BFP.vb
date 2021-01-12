'Nelson T. Sherman
'10/ 26/ 2019
'This program calculates your Body Fat Percentage displays the results in addition to supplying
'information to educate the user.
Public Class frmBFP

	Private Sub frmBFP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub picMale_Click(sender As Object, e As EventArgs) Handles picMale.Click

	End Sub

	Private Sub picFemale_Click(sender As Object, e As EventArgs) Handles picFemale.Click

	End Sub

	Private Sub txtWaist_TextChanged(sender As Object, e As EventArgs) Handles txtWaist.TextChanged

	End Sub

	Private Sub txtNeck_TextChanged(sender As Object, e As EventArgs) Handles txtNeck.TextChanged

	End Sub

	Private Sub txtHip_TextChanged(sender As Object, e As EventArgs) Handles txtHip.TextChanged

	End Sub

	Private Sub txtHeight_TextChanged(sender As Object, e As EventArgs) Handles txtHeight.TextChanged

	End Sub

	Public Sub lblBFPResults_Click(sender As Object, e As EventArgs) Handles lblBFPResults.Click

	End Sub

	Public Sub lblBFPMessage_Click(sender As Object, e As EventArgs) Handles lblBFPMessage.Click

	End Sub

	Private Sub picBodyFatStandards_Click(sender As Object, e As EventArgs) Handles picBodyFatStandards.Click

	End Sub

	Private Sub picJacksonPollard_Click(sender As Object, e As EventArgs) Handles picJacksonPollard.Click

	End Sub

	Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
		lblHip.Visible = True
		txtHip.Text = ""
		lblHeight.Visible = True
		txtHeight.Text = ""
		txtNeck.Text = ""
		lblWaist.Visible = True
		txtWaist.Text = ""

		picFemale.Visible = False
		picMale.Visible = False

		'clear the buttons
		radFemale.Checked = False
		radMale.Checked = False

		'clear message labels
		lblBFPMessage.Text = ""
		lblBFPResults.Text = ""
	End Sub

	Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
		'Variables
		Dim dblWaist As Double
		Dim dblNeck As Double
		Dim dblHeight As Double
		Dim dblHip As Double

		If radMale.Checked = True Then
			'convert varibles to string
			dblWaist = CDec(txtWaist.Text)
			dblNeck = CDec(txtNeck.Text)
			dblHeight = CDec(txtHeight.Text)

			'call male BFP calculations and display in a label
			lblBFPResults.Text = MaleBFPCalc(dblWaist, dblNeck, dblHeight)

			If (lblBFPResults.Text > 30) Then
				lblBFPMessage.Text = "You are considered Obese." & Environment.NewLine & "Please see your doctor ASAP!!!"

			ElseIf (lblBFPResults.Text > 25 And lblBFPResults.Text <= 30) Then
				lblBFPMessage.Text = "You are over weight!! " & Environment.NewLine & "Report to the Gym Immediately"

			ElseIf (lblBFPResults.Text <= 25 And lblBFPResults.Text >= 18) Then
				lblBFPMessage.Text = "Your body fat is at an Average level!!" & Environment.NewLine & "Time to break out the Treadmill"

			ElseIf (lblBFPResults.Text < 17 And lblBFPResults.Text >= 14) Then
				lblBFPMessage.Text = "Congratulations you are at a Fit Status" & Environment.NewLine & "Keep up the Good work!!!"

			ElseIf (lblBFPResults.Text <= 13 And lblBFPResults.Text >= 6) Then
				lblBFPMessage.Text = "You are an Athlete" & Environment.NewLine & "Run Forrest Run!!!"

			End If

		ElseIf radFemale.Checked = True Then
			'convert varible to string
			dblHip = CDec(txtHip.Text)

			'call female BFP calculations and display in a label
			lblBFPResults.Text = FemaleBFPCalc(dblWaist, dblHip, dblNeck, dblHeight)

			If (lblBFPResults.Text > 32) Then
				lblBFPMessage.Text = "You are considered Obese." & Environment.NewLine & "Please see your doctor ASAP!!!"

			ElseIf (lblBFPResults.Text > 25 And lblBFPResults.Text < 31) Then
				lblBFPMessage.Text = "You are of Average weight!! "

			ElseIf (lblBFPResults.Text < 24 And lblBFPResults.Text > 21) Then
				lblBFPMessage.Text = "You are at a 'Fit' status" & Environment.NewLine & "KEEP UP THE GOOD WORK!!!"

			ElseIf (lblBFPResults.Text <= 20 And lblBFPResults.Text >= 14) Then
				lblBFPMessage.Text = "Congratulations you are at Athlete level of fitness"
			Else
				lblBFPMessage.Text = " You have 'Essential fat'" & Environment.NewLine & "Go eat a Hamburger!!!"
			End If

		ElseIf radMale.Checked = False And radFemale.Checked = False Then

			lblBFPMessage.Text = "Please check Male or Female to get started"
		End If

	End Sub

	Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

		Me.Close()
		frmMain.Show()

	End Sub

	Private Sub radFemale_Click(sender As Object, e As EventArgs) Handles radFemale.Click
		'show Female pic
		picMale.Visible = False
		picFemale.Visible = True

		lblHip.Visible = True
		txtHip.Visible = True
		lblHeight.Visible = True
		txtHeight.Visible = True
		lblNeck.Visible = True
		txtNeck.Visible = True
		lblWaist.Visible = True
		txtWaist.Visible = True

		lblBFPMessage.Text = ""
	End Sub

	Private Sub radMale_Click(sender As Object, e As EventArgs) Handles radMale.Click
		'show male pic
		picMale.Visible = True
		picFemale.Visible = False

		'hide female options
		lblHip.Visible = False
		txtHip.Visible = False

		lblHeight.Visible = True
		txtHeight.Visible = True
		lblNeck.Visible = True
		txtNeck.Visible = True
		lblWaist.Visible = True
		txtWaist.Visible = True

		lblBFPMessage.Text = ""
	End Sub

End Class