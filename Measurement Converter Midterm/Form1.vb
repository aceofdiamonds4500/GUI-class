﻿Imports System.Runtime.InteropServices

''' <summary>
''' ---------------------------
''' Author: Nicholas Cieplensky
''' Project: Measurement Converter Application
''' Class Names: Form1
''' 
''' Description:
'''	This program is made to convert inches to meters and vice versa. It includes input validation to prevent unexpected output
'''	and includes clear and exit buttons.
''' </summary>
Public Class Form1
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		RadInToM.Checked = True 'makes sure an option is selected before all else
	End Sub

	'Convert button; handles radio button checks
	Private Sub BtnConvert_Click(sender As Object, e As EventArgs) Handles BtnConvert.Click
		'empty input conditional
		If TxtInput.Text = "" Then
			MessageBox.Show("Please input a number to convert.", "Invalid Input")
			TxtInput.Focus()
		ElseIf Not IsNumeric(TxtInput.Text) Then
			'input not a number
			MessageBox.Show("Input must be a numerical value.", "Invalid Input")
		Else
			'convert
			Dim input As Double = TxtInput.Text
			If RadInToM.Checked Then
				InchToMeter(input)
			ElseIf RadMToIn.Checked Then
				MeterToInch(input)
			Else
				'in case the user SOMEHOW finds a way to unselect either
				LblOutput.Text = "Select a conversion first."
			End If
		End If
	End Sub

	'Clear button
	Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
		TxtInput.Text = ""
		LblOutput.Text = ""
		RadInToM.Checked = True
		TxtInput.Focus()
	End Sub

	'Exit button
	Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
		Dim result As DialogResult = MessageBox.Show("Close Window?", "Confirmation Window", MessageBoxButtons.YesNo)
		If result = DialogResult.Yes Then
			Me.Close()
		End If
	End Sub

	'This function takes inches as an input and calculates the meter conversion 
	Private Function InchToMeter(input)
		Dim inches As Double = input
		Dim meters As Double = inches * 0.0254

		If meters < 0 Then
			MessageBox.Show("Converted number was negative. Enter a value greater than zero.", "Conversion Error")
			LblOutput.Text = ""
			Return 0
		End If

		Dim StrMeters = meters.ToString("0.###")    'String format of displayed numbers is 3 significant digits
		Dim StrInches = inches.ToString("0.###")
		LblOutput.Text = StrInches + " inches is " + StrMeters + " meters."
		Return 0
	End Function

	'This function is the inverse of InchToMeter() and converts to inches
	Private Function MeterToInch(input)
		Dim meters As Double = input
		Dim inches As Double = meters * 39.37001

		If inches < 0 Then
			MessageBox.Show("Converted number was negative. Enter a value greater than zero.", "Conversion Error")
			LblOutput.Text = ""
			Return 0
		End If

		Dim StrInches = inches.ToString("0.###")
		Dim StrMeters = meters.ToString("0.###")
		LblOutput.Text = StrMeters + " meters is " + StrInches + " inches."
		Return 0
	End Function

End Class
