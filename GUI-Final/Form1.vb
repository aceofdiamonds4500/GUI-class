''' <summary>
''' Project: Measurement Converter 2 [FINAL]
''' Author: Nicholas Cieplensky
''' Description:
'''		This is my final project for GUI Dev - a revision of the measurement converter I once wrote for the midterm.
'''		It does three main tasks:
'''		- Takes input and converts the inches to meters OR meters to inches
'''		- Writes the result to the on-screen list (can also clear the result)
'''		- Writes the contents of the ListBox to a file (can also clear the ListBox
'''		
''' </summary>
Public Class Form1
	Private filename As String = "filemeasures.txt"

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		rdioInToM.Checked = True
		lblSaveStatus.Text = ""
	End Sub

	'**This code is reused from the Midterm.
	'Controls conversions
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

	'Saves the result of the conversion to the ListBox
	Private Sub btnSaveToList_Click(sender As Object, e As EventArgs) Handles btnSaveToList.Click
		If lblConverted.Text IsNot "" Then
			lstConvertList.Items.Add(lblConverted.Text)
		End If
	End Sub

	'Clears label containing result, returns focus to TextBox
	Private Sub btnClearResults_Click(sender As Object, e As EventArgs) Handles btnClearResults.Click
		lblConverted.Text = ""
		txtInput.Text = ""
		txtInput.Focus()
		rdioInToM.Checked = True
	End Sub

	'Clears items from ListBox
	Private Sub btnClearList_Click(sender As Object, e As EventArgs) Handles btnClearList.Click
		lstConvertList.Items.Clear()
	End Sub

	'Saves each item in ListBox to filename
	Private Sub btnSaveToFile_Click(sender As Object, e As EventArgs) Handles btnSaveToFile.Click
		Dim file As System.IO.StreamWriter
		file = My.Computer.FileSystem.OpenTextFileWriter(filename, True)
		'prevents writing an empty list to the file
		If lstConvertList.Items.Count > 0 Then
			For i = 0 To lstConvertList.Items.Count - 1
				file.WriteLine(lstConvertList.Items(i))
			Next i

			'Saved 0 entries to filemeasures.txt
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
