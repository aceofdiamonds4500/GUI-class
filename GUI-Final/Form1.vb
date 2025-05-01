Public Class Form1
	Private filename As String = "filemeasures.txt"

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		rdioInToM.Checked = True
		lblSaveStatus.Text = ""
	End Sub

	'**This code is reused from the Midterm.
	'controls conversion
	Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
		'empty input conditional
		If txtInput.Text = "" Then
			MessageBox.Show("Please input a number to convert.", "Invalid Input")
			txtInput.Focus()
		ElseIf Not IsNumeric(txtInput.Text) Then
			'input not a number
			MessageBox.Show("Input must be a numerical value.", "Invalid Input")
		Else
			'convert
			Dim input As Double = txtInput.Text
			If rdioInToM.Checked Then
				InchToMeter(input)
			ElseIf rdioMToIn.Checked Then
				MeterToInch(input)
			Else
				'in case the user SOMEHOW finds a way to unselect either
				lblConverted.Text = "Select a conversion first."
			End If
		End If
	End Sub

	' puts word in list
	Private Sub btnSaveToList_Click(sender As Object, e As EventArgs) Handles btnSaveToList.Click
		If lblConverted.Text IsNot "" Then
			lstConvertList.Items.Add(lblConverted.Text)
		End If
	End Sub

	' clears recent convert
	Private Sub btnClearResults_Click(sender As Object, e As EventArgs) Handles btnClearResults.Click
		lblConverted.Text = ""
		txtInput.Text = ""
		txtInput.Focus()
		rdioInToM.Checked = True
	End Sub

	' clear entire list
	Private Sub btnClearList_Click(sender As Object, e As EventArgs) Handles btnClearList.Click
		lstConvertList.Items.Clear()
	End Sub

	' save to file
	Private Sub btnSaveToFile_Click(sender As Object, e As EventArgs) Handles btnSaveToFile.Click
		Dim file As System.IO.StreamWriter
		file = My.Computer.FileSystem.OpenTextFileWriter(filename, True)
		If lstConvertList.Items.Count > 0 Then
			For i = 0 To lstConvertList.Items.Count - 1
				file.WriteLine(lstConvertList.Items(i))
			Next i

			lblSaveStatus.Text = "Saved " + lstConvertList.Items.Count.ToString() + " entries to " + filename
		End If

		file.Close()
	End Sub

	'**This code is reused from the Midterm.

	'This function takes inches as an input and calculates the meter conversion 
	Private Function InchToMeter(input)
		Dim inches As Double = input
		Dim meters As Double = inches * 0.0254

		If meters < 0 Then
			MessageBox.Show("Converted number was negative. Enter a value greater than zero.", "Conversion Error")
			lblConverted.Text = ""
			Return 0
		End If

		Dim StrMeters = meters.ToString("0.###")    'String format of displayed numbers is 3 significant digits
		Dim StrInches = inches.ToString("0.###")
		lblConverted.Text = StrInches + " inches is " + StrMeters + " meters."
		Return 0
	End Function

	'This function is the inverse of InchToMeter() and converts to inches
	Private Function MeterToInch(input)
		Dim meters As Double = input
		Dim inches As Double = meters * 39.37001

		If inches < 0 Then
			MessageBox.Show("Converted number was negative. Enter a value greater than zero.", "Conversion Error")
			lblConverted.Text = ""
			Return 0
		End If

		Dim StrInches = inches.ToString("0.###")
		Dim StrMeters = meters.ToString("0.###")
		lblConverted.Text = StrMeters + " meters is " + StrInches + " inches."
		Return 0
	End Function
End Class
