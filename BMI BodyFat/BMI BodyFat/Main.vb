Public Class frmMain

	Dim BMIForm As New frmBMI
	Dim BFPForm As New frmBFP


	Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub btnBMI_Click(sender As Object, e As EventArgs) Handles btnBMI.Click

		BMIForm.Show()
		Me.Hide()

	End Sub

	Private Sub btnBFP_Click(sender As Object, e As EventArgs) Handles btnBFP.Click

		BFPForm.Show()

		Me.Hide()

	End Sub

	Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

		Me.Close()
		frmBFP.Close()
		frmBMI.Close()

	End Sub
End Class
