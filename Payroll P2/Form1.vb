Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Runtime.InteropServices

Public Class Form1
	Private Const cdecFica = 0.0765
	Private Const cdecFed = 0.22
	Private Const cdecState = 0.04

	Private GrossPay = 0.0
	Private decFICA = 0.0
	Private decFed = 0.0
	Private decState = 0.0
	Private netIncome = 0.0

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		TextField.Focus()
	End Sub

	Private Sub BttnCompute_Click(sender As Object, e As EventArgs) Handles BttnCompute.Click
		If TextField.Text = "" Then
			MessageBox.Show("Please input your Salary!", "Invalid Input")
		ElseIf IsNumeric(TextField.Text) Then
			GrossPay = TextField.Text
			Dim result As DialogResult = MessageBox.Show(String.Format("Confirm input of {0:C}?", GrossPay), "Confirmation Window", MessageBoxButtons.YesNo)
			If result = DialogResult.Yes Then
				CalculatePay()
			End If
		Else
			MessageBox.Show("Make sure your input is numerical!", "Invalid Input")
		End If
	End Sub

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

	Private Sub BttnExit_Click(sender As Object, e As EventArgs) Handles BttnExit.Click
		Dim result As DialogResult = MessageBox.Show("Close Window?", "Confirmation Window", MessageBoxButtons.YesNo)
		If result = DialogResult.Yes Then
			Me.Close()
		End If
	End Sub

	Private Function CalculatePay()
		decFICA = CalcFICA()
		FICAText.Text = String.Format("{0:C}", decFICA)
		decFed = CalcFed()
		FederalText.Text = String.Format("{0:C}", decFed)
		decState = CalcState()
		StateText.Text = String.Format("{0:C}", decState)
		netIncome = CalcNetIncome()
		NetIncomeText.Text = String.Format("{0:C}", netIncome)
		Return 0
	End Function
	Private Function CalcFICA()
		Return GrossPay * cdecFica
	End Function
	Private Function CalcFed()
		Return GrossPay * cdecFed
	End Function
	Private Function CalcState()
		Return GrossPay * cdecState
	End Function
	Private Function CalcNetIncome()
		Return GrossPay - decFICA - decFed - decState
	End Function

End Class
