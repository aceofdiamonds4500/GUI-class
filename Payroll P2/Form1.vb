'''---------------------------
''' Author: Nicholas Cieplensky
''' Project: Payroll Calculator Application
''' Class Names: frmBurgers
''' 
''' Description:
'''	This program calculates payroll using the gross pay of the employee and muliplying it
'''	by a FICA, Federal, and State tax rate. The total is a subtraction of these from the input gross pay.

Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Runtime.InteropServices

Public Class Form1
	' constants for taxes
	Private Const cdecFica = 0.0765
	Private Const cdecFed = 0.22
	Private Const cdecState = 0.04

	'fields for each variable
	Private GrossPay = 0.0
	Private decFICA = 0.0
	Private decFed = 0.0
	Private decState = 0.0
	Private netIncome = 0.0

	'On startup. I know it's required to reset values to zero on startup, but I set the text to default as "$0.00" instead to cut down on operations.
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		TextField.Focus()
	End Sub

	'Handles input validation from the user
	Private Sub BttnCompute_Click(sender As Object, e As EventArgs) Handles BttnCompute.Click
		If TextField.Text = "" Then
			MessageBox.Show("Please input your gross pay!", "Invalid Input")
		ElseIf IsNumeric(TextField.Text) Then   'valid user input
			If TextField.Text < 0 Then
				MessageBox.Show("Gross pay cannot be less than zero!", "Invalid Input")
			Else
				GrossPay = TextField.Text
				Dim result As DialogResult = MessageBox.Show(String.Format("Confirm input of {0:C}?", GrossPay), "Confirmation Window", MessageBoxButtons.YesNo)
				If result = DialogResult.Yes Then
					CalculatePay()
				End If
			End If
		Else
				MessageBox.Show("Make sure your input is numerical!", "Invalid Input")
		End If
	End Sub

	'Resets all fields to zero and displays it to user, then focuses cursor back to input field
	Private Sub BttnClear_Click(sender As Object, e As EventArgs) Handles BttnClear.Click
		TextField.Text = ""
		GrossPay = 0.0
		decFICA = 0.0
		FICAText.Text = String.Format("{0:C}", decFICA)
		decFed = 0.0
		FederalText.Text = String.Format("{0:C}", decFed)
		decState = 0.0
		StateText.Text = String.Format("{0:C}", decState)
		netIncome = 0.0
		NetIncomeText.Text = String.Format("{0:C}", netIncome)

		TextField.Focus()
	End Sub

	'Exit button
	Private Sub BttnExit_Click(sender As Object, e As EventArgs) Handles BttnExit.Click
		Dim result As DialogResult = MessageBox.Show("Close Window?", "Confirmation Window", MessageBoxButtons.YesNo)
		If result = DialogResult.Yes Then
			Me.Close()
		End If
	End Sub

	'Handles the calculation and display of each tax's output
	Private Function CalculatePay()
		decFICA = CalcFICA()
		FICAText.Text = String.Format("{0:C}", decFICA) 'i like {0:C} since it formats currency perfectly
		decFed = CalcFed()
		FederalText.Text = String.Format("{0:C}", decFed)
		decState = CalcState()
		StateText.Text = String.Format("{0:C}", decState)
		netIncome = CalcNetIncome()
		NetIncomeText.Text = String.Format("{0:C}", netIncome)
		Return 0
	End Function
	'Function for FICA
	Private Function CalcFICA()
		Return GrossPay * cdecFica
	End Function
	'Function for Federal Tax
	Private Function CalcFed()
		Return GrossPay * cdecFed
	End Function
	'Function for State Tax
	Private Function CalcState()
		Return GrossPay * cdecState
	End Function
	'Function for Net Income
	Private Function CalcNetIncome()
		Return GrossPay - decFICA - decFed - decState
	End Function

End Class
