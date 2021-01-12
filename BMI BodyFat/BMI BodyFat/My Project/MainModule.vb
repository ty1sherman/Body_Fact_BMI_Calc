Module MainModule
	'BMI Function
	Public Function BMICalculations(ByVal dblWeight As Double, ByVal dblHeight As Double)

		Dim dblResult As Double

		'Body Mass Index Calculations
		dblResult = CDec(dblWeight * 703 / (dblHeight * dblHeight))
		dblResult = Math.Round(dblResult, 2, MidpointRounding.AwayFromZero)

		Return dblResult
	End Function



	'Male BFP Function
	Public Function MaleBFPCalc(ByVal dblWaist As Double, ByVal dblNeck As Double, ByVal dblHeight As Double)
		Dim dblResult As Double

		dblResult = 495 / (1.0324 - 0.19077 * Math.Log10(dblWaist - dblNeck) + 0.15456 * Math.Log10(dblHeight)) - 450
		dblResult = Math.Round(dblResult, 2, MidpointRounding.AwayFromZero)
		Return dblResult

	End Function



	'Female BFP Function
	Public Function FemaleBFPCalc(ByVal dblWaist As Double, ByVal dblHip As Double, ByVal dblNeck As Double, ByVal dblHeight As Double)
		Dim dblResult As Double

		dblResult = 495 / (1.29579 - 0.35004 * Math.Log10(dblWaist + dblHip - dblNeck) + 0.221 * Math.Log10(dblHeight)) - 450
		dblResult = Math.Round(dblResult, 2, MidpointRounding.AwayFromZero)
		Return dblResult


	End Function


End Module
